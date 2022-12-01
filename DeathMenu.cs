using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathMenu : MonoBehaviour
{
    //Code borrowed from: https://www.youtube.com/watch?v=-GWjA6dixV4 

    public void restartGame() {
        SceneManager.LoadScene(1);
    }

    public void loadMainMenu() {
        SceneManager.LoadScene(0);
    }

}
