using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cop : MonoBehaviour {

    public float speed;
    public float jumpHeight;

    public Animator animator;

    public Transform groundCheck;
    public LayerMask whatIsGround;
    public float groundRadius;
    public bool grounded;

    private GameManager gameManager;

	void Start () {
        //находим гейм менеджер
        gameManager = FindObjectOfType<GameManager>();
	}
	
	void Update () {
        GetComponent<Rigidbody2D>().velocity = new Vector2(speed, GetComponent<Rigidbody2D>().velocity.y);

        grounded = Physics2D.OverlapCircle(groundCheck.position, groundRadius, whatIsGround);

        if (grounded && (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)))
        {

            GetComponent<Rigidbody2D>().AddForce(Vector2.up*jumpHeight);
        }

        if (grounded)
            animator.SetBool("Jump", false);
        else
            animator.SetBool("Jump", true);
	}

    void OnCollisionEnter2D(Collision2D coll)
    {
        if(coll.gameObject.name == "Thief")
        {
            ScoreSaver scoreSaver = FindObjectOfType<ScoreSaver>();
            scoreSaver.score += gameManager.score;
            gameManager.LoadNextLevel();
        }

    }
}
