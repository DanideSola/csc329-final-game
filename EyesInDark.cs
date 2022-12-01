using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class EyesInDark : MonoBehaviour
{
    public Image eyes1;
    public Image eyes2;
    public Image eyes3;
    public Timer t;
    public Animator anim;
    // Start is called before the first frame update

    void Start()
    {
        eyes1.enabled = false;
        eyes2.enabled = false;
        eyes3.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (t.minutes == 2) {
           if (t.seconds == 0) {
                eyes1.enabled = true;
                //Debug.Log("Eyes are " + eyes1);
                anim.SetTrigger("Blink");
            }
        }
        if (t.minutes == 1) {
            if (t.seconds == 57) {
                eyes1.GetComponent<Image>().color = new Color (1f, 1f, 1f, 0f);
            }
            if (t.seconds == 30) {
                eyes2.enabled = true;
                anim.SetTrigger("Blink");
            }
            if (t.seconds == 27) {
                eyes2.enabled = false;
            }
            if (t.seconds == 0) {
                eyes3.enabled = true;
                anim.SetTrigger("Blink");
            }
        }
        if (t.minutes == 0) {
            if (t.seconds == 57) {
                eyes3.enabled = false;
            }
        }
    }
}
