using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class BackgroundOnOff : MonoBehaviour
{
    public AudioSource backgroundMusic;

    void Start () {
        if (SceneManager.GetActiveScene().name == "Lumberjack") {
            backgroundMusic.Play();
        }
    }

    void Update() {
        if (Input.GetKeyDown(KeyCode.M)) {
            if (backgroundMusic.isPlaying) {
                backgroundMusic.Pause();
            }
            else {
                backgroundMusic.Play();
            }
        }
    }
}
