using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    //количество очков
    public int score;
    //текст в UI для отображения счета
    public Text scoreTxt;
    //название следующего уровня
    public string nextLevelName;

    /// <summary>
    /// Загружает следующий уровень
    /// </summary>
    public void LoadNextLevel()
    {
        SceneManager.LoadScene(nextLevelName);
    }
    /// <summary>
    /// Перезагружает текущий уровень
    /// </summary>
    public void ReloadLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    /// <summary>
    /// Увеличевает счет
    /// </summary>
    public void IncreaseScore()
    {
        score++;
        UpdateScore();
    }
    /// <summary>
    /// Обновляет счет в UI
    /// </summary>
    private void UpdateScore()
    {
        scoreTxt.text = "Score: " + score.ToString();
    }
}
