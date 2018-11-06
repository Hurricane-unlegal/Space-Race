using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour {

    public static int ship = 2;
    public Text txt;

    void Start()
    {
        Cursor.visible = true;
    }

	public void Play () {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}

    public void Eagle () {
        ship = 3;
        txt.text = "Орел - Бывший легкий истребитель, когда-то являвшейся гордостью давно забытой расы сейчас же успешно выступает в гонках, обганяя совремеые корабли";
    }

    public void Assaulter () {
        ship = 1;
        txt.text = "Какой-то шар с двумя квадратами... Но вроде летает";
    }

    public void Henneks () {
        ship = 2;
        txt.text = "Разработаный на скорую руку из кубов и палок, Хеннекс является гордостью данного астеройдного пояса, немного уступая в скорости Орлу, он выигрывает в курсовой устойчивости";
    }

    public void Quit () {
        Application.Quit();
	}
}
