using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Timers;
using System.Threading;
using UnityEngine.UI;

public class ChangeShip : MonoBehaviour
{

    public Text textTimer;
    public MainMenu mainMenu;
    public Text textH;
    public GameObject HenneksP;
    public GameObject EagleP;
    public GameObject AssaulterP;
    public GameObject CamH;
    int ship = 2;
    float pause = -3f;

    void Start()
    {
        //ship = MainMenu.ship;
    }

   /*void Timer()
    {
        {
            pause -= Time.deltaTime;
            textTimer.text = " " + pause;
        }
        while (pause < 0) ;
    }*/

    void Update()
    {
        //Timer();
        ship = MainMenu.ship;
        switch (ship)
        {
            case 1:
                HenneksP.SetActive(false);
                EagleP.SetActive(true);
                AssaulterP.SetActive(false);
                break;
            case 2:
                HenneksP.SetActive(true);
                EagleP.SetActive(false);
                AssaulterP.SetActive(false);
                break;
            case 3:
                HenneksP.SetActive(false);
                EagleP.SetActive(false);
                AssaulterP.SetActive(true);
                break;
        }
        /*if (ship == 1)
        {
            Henneks.GetComponent<ShipControll>().enabled = false;
            Henneks.GetComponent<WayPMove>().enabled = true;
            Eagle.GetComponent<ShipControll>().enabled = true;
            Eagle.GetComponent<WayPMove>().enabled = false;
            Assaulter.GetComponent<ShipControll>().enabled = false;
            Assaulter.GetComponent<WayPMove>().enabled = true;
        }
        if (ship == 2)
        {
            Henneks.GetComponent<ShipControll>().enabled = true;
            Henneks.GetComponent<WayPMove>().enabled = false;
            Eagle.GetComponent<ShipControll>().enabled = false;
            Eagle.GetComponent<WayPMove>().enabled = true;
            Assaulter.GetComponent<ShipControll>().enabled = false;
            Assaulter.GetComponent<WayPMove>().enabled = true;
        }
        if (ship == 3)
        {
            Henneks.GetComponent<ShipControll>().enabled = false;
            Henneks.GetComponent<WayPMove>().enabled = true;
            Eagle.GetComponent<ShipControll>().enabled = false;
            Eagle.GetComponent<WayPMove>().enabled = true;
            Assaulter.GetComponent<ShipControll>().enabled = true;
            Assaulter.GetComponent<WayPMove>().enabled = false;
        }*/
        
    }
}

