using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Money : MonoBehaviour {

    private GameManager gameManager;

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.name == "Thief")
        {
            gameManager.ReloadLevel();
        }
    }
}
