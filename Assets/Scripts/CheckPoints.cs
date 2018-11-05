using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckPoints : MonoBehaviour {

    public int ChPoints1 = 0;
    public int ChPoints2 = 0;
    public int ChPoints3 = 0;
    public int ChPoints4 = 0;
    public int ChPoints5 = 0;
    public int ChPoints6 = 0;
    int CP = 0;
    public bool Win = false;
    public Text txt;

    void OnTriggerEnter(Collider ChP)
    {
        if (ChP.gameObject.tag == "CheckPoint1")
        {
            ChPoints1 = 1;
            CP = 1;
        }
        if (ChP.gameObject.tag == "CheckPoint2" && ChPoints1 == 1)
        {
            ChPoints2 = 1;
            CP = 2;
        }
        if (ChP.gameObject.tag == "CheckPoint3" && ChPoints2 == 1)
        {
            ChPoints3 = 1;
            CP = 3;
        }
        if (ChP.gameObject.tag == "CheckPoint4" && ChPoints3 == 1)
        {
            ChPoints4 = 1;
            CP = 4;
        }
        if (ChP.gameObject.tag == "CheckPoint5" && ChPoints4 == 1)
        {
            ChPoints5 = 1;
            CP = 5;
        }
        if (ChP.gameObject.tag == "CheckPoint6" && ChPoints5 == 1)
        {
            ChPoints6 = 1;
            CP = 6;
        }
    }

    void Update()
    {
        txt.text = CP + "/6";
        if (ChPoints6 == 1)
        {
            Win = true;
            //Invoke("ReloadingLevel", 3);
        }      
    }

    void ReloadingLevel()
    {
        Application.LoadLevel("Menu");
    }
}
