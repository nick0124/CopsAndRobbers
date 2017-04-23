using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour {

    //точка спавна
    public Transform spawnPoint;

    void OnTriggerEnter2D(Collider2D coll)
    {
        //если игрок зашел в телепорт то перемещаем его на место спавна
        //и разворачиваем в другую сторону
        if(coll.name == "Cop")
        {
            coll.transform.position = spawnPoint.position;
            coll.GetComponent<Cop>().speed *= -1;
            coll.transform.localScale = new Vector3(coll.transform.localScale.x * - 1, 1, 1);
        }
        //если вор зашел в телепорт то перемещаем его на место спавна
        //и разворачиваем в другую сторону
        if (coll.name == "Thief")
        {
            coll.transform.position = spawnPoint.position;
            coll.GetComponent<Thief>().speed *= -1;
            coll.transform.localScale = new Vector3(coll.transform.localScale.x * -1, 1, 1);
        }

        //если в меню
        //и разворачиваем в другую сторону
        if (coll.name == "Menu")
        {
            coll.transform.position = spawnPoint.position;
        }
    }
}
