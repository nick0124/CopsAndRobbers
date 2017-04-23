using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour {

    private GameManager gameManager;

    void Start()
    {
        //грузим гейм менеджер, потому что монетка префаб
        gameManager = FindObjectOfType<GameManager>();
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        //если полицейский взял монетку то
        //увеличиваем счет и удаляем монетку
        if (coll.name == "Cop")
        {
            gameManager.IncreaseScore();
            Destroy(gameObject);
        }
    }
}
