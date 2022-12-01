using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PullLever : MonoBehaviour
{
    public Animator lever;
    public bool contact = false;
    public bool pulled = false;
    // Start is called before the first frame update
    IEnumerator waitForLevelLoad() {
        yield return new WaitForSeconds(1.0f);
        SceneManager.LoadScene(3);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q) && contact == true) {
            Debug.Log("Q was pressed. In contact = " + contact);
            if (pulled == false) {
                pullLever();
            } 
        }
    }

    void OnTriggerStay2D(Collider2D collision) {
        if (collision.CompareTag("Player")) {
            Debug.Log("Lever should be pulled.");
            contact = true;
        }
    }
    
    void OnTriggerExit2D(Collider2D collision) {
        if (collision.CompareTag("Player")) {
            contact = false;
        }
    }

    void pullLever() {
        pulled = true;
        lever.SetTrigger("Pulled");
        GameObject darkness = GameObject.Find("Darkness");
        Destroy(darkness);
        GameObject darkCircle = GameObject.Find("Dark Circle");
        Destroy(darkCircle);
        //Load Game Won Scene
        StartCoroutine(waitForLevelLoad());
        //SceneManager.LoadScene(3);
    }
}
