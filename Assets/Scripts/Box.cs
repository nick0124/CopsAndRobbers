using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour {

    private GameManager gameManager;

	void Start () 
    {
        //грузим гейм менеджер, потому что коробка префаб
        gameManager = FindObjectOfType<GameManager>();
	}

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.name == "Cop")
        {
            Destroy(gameObject);
            gameManager.ReloadLevel();
        }
    }
}
