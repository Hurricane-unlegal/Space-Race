using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour {

    public GameObject text;
    public GameObject text2;
    void OnTriggerEnter(Collider ship)
    {
        if (ship.gameObject.tag == "Player")
        {
            text.gameObject.SetActive (true);
            //Invoke("ReloadingLevel", 3);
        }
        if (ship.gameObject.tag == "Enemy")
        {
            text2.gameObject.SetActive (true);
            //Invoke("ReloadingLevel", 3);
        }
    }

    void ReloadingLevel()
    {
        Application.LoadLevel("Menu");
    }
}
