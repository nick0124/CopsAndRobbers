using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thief : MonoBehaviour {

    public float speed;
    public float jumpHeight;

    public Animator animator;

    public Transform jumpRay;//Begin;
    //public Transform jumpRayEnd;

    public Transform groundCheck;
    public LayerMask whatIsGround;
    public float groundRadius;
    public bool grounded;

    public bool jump;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        GetComponent<Rigidbody2D>().velocity = new Vector2(speed, GetComponent<Rigidbody2D>().velocity.y);

        grounded = Physics2D.OverlapCircle(groundCheck.position, groundRadius, whatIsGround);

        RaycastHit2D hit = Physics2D.Linecast(jumpRay.position, new Vector2(jumpRay.position.x-0.01f,jumpRay.position.y));
        if (hit.collider != null)
        {
            if (hit.collider.tag == "Box")
                jump = true;
        }
        else
        {
            jump = false;
        }
        if (jump)
        {

            GetComponent<Rigidbody2D>().AddForce(Vector2.up * jumpHeight);
        }

        if (grounded)
            animator.SetBool("Jump", false);
        else
            animator.SetBool("Jump", true);
	}
}
