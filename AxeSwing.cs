using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxeSwing : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator anim;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            axSwing();
        }
    }

    void axSwing() {
        //Play swing animation
        anim.SetTrigger("Swing");
    }
}
