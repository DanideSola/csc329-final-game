using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Timer : MonoBehaviour
{
    //displayTime method and some lines in Update method is code borrowed from: https://www.youtube.com/watch?v=HmHPJL-OcQE  

    public float time = 150;
    public Text timer;
    public float seconds = 0;
    public float minutes = 0;

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(SceneManager.GetActiveScene().name);
        if (SceneManager.GetActiveScene().name == "Lumberjack") {
            if (time <= 0) {
                time = 0;
            }

            else {
                time -= Time.deltaTime;
            }

            //changes color of timer
            if (time <= 30) {
                timer.color = Color.red;
            }
            displayTime(time);
        }
    }

    void displayTime(float time) {
        if (time < 0) {
            time = 0;
        }

        minutes = Mathf.FloorToInt(time / 60);
        seconds = Mathf.FloorToInt(time % 60);

        timer.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

}
