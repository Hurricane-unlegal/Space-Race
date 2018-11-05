using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RaceLogic : MonoBehaviour {

    bool WinH = false;
    bool WinE = false;
    bool WinA = false;
    public Text txt1;
    public GameObject Hen;
    public GameObject Eag;
    public GameObject Ass;
    int pos = 0;
    int posA = 0;
    int posE = 0;
    int posP = 0;
	
	void Update () {
        WinH = Hen.GetComponent<CheckPoints>().Win;
        WinE = Eag.GetComponent<CheckPoints>().Win;
        WinA = Ass.GetComponent<CheckPoints>().Win;

        if (WinH == true)
        {
            pos++;
            posP = pos;
        }
        if (WinE == true)
        {
            pos++;
            posE = pos;
        }
        if (WinA == true)
        {
            pos++;
            posA = pos;
        }
        txt1.text = posP + " Хеннекс\n" + posE + " Орел\n" + posA + " Летун";
        //Invoke("ReloadingLevel", 3);
    }

    void ReloadingLevel()
    {
        Application.LoadLevel("Menu");
    }
}
