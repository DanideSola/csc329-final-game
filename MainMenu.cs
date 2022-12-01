using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject controlMenu;

    // Start is called before the first frame update
    //Code borrowed from: https://www.youtube.com/watch?v=-GWjA6dixV4 
    
    void Start() {
        mainMenu.active = true;
        controlMenu.active = false;
    }

    public void playGame() {
        SceneManager.LoadScene("Lumberjack");
    }
    
    public void quitGame() {
        Application.Quit();
    }

    public void toControlsMenu() {
        SceneManager.LoadScene("Controls Menu");
    }

    public void toMainMenu() {
        SceneManager.LoadScene("Main Menu");
    }

}
