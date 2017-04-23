using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour {
    public GameObject cop;
    public GameObject thief;

    public string firstLevelName;

    private ScoreSaver scoreSaver;
    public GameObject scoreSaverPrefub;

    public Text scoreText;

	// Use this for initialization
	void Start () {
        scoreSaver = FindObjectOfType<ScoreSaver>();
        if(scoreSaver == null)
        {
            GameObject go = (GameObject)Instantiate(scoreSaverPrefub);
            scoreSaver = go.GetComponent<ScoreSaver>();
        }
        UpdateScore();
	}
	
	// Update is called once per frame
	void Update () {
        cop.GetComponent<Rigidbody2D>().velocity = new Vector2(-2, cop.GetComponent<Rigidbody2D>().velocity.y);
        thief.GetComponent<Rigidbody2D>().velocity = new Vector2(-2, thief.GetComponent<Rigidbody2D>().velocity.y);
	}

    public void LoadFirstLevel()
    {
        scoreSaver.score = 0;
        SceneManager.LoadScene(firstLevelName);
    }

    private void UpdateScore()
    {
        if(scoreSaver.score == 0)
        {
            scoreText.text = "Catch robbers and save all coins.";
        }
        else if(scoreSaver.score < 30)
        {
            scoreText.text = "You save " + scoreSaver.score.ToString() + " of 30 coins. Try better!";
        }
        else if (scoreSaver.score == 30)
        {
            scoreText.text = "You save all coins. Good job.";
        }
    }
}
