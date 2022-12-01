using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement; 
using UnityEngine;

public class ActivateGrim : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator anim;
    public GameObject lumberjack;
    Animator lAnim;
    public GameObject darkness;
    public GameObject darkCircle;

    IEnumerator waitToSwing() {
        yield return new WaitForSeconds(2f);
        anim.SetTrigger("Swing");
        yield return new WaitForSeconds (0.5f);
        //lAnim.Play("LumberjackDamageRight");
        lAnim.SetTrigger("Grim");
        lAnim.SetTrigger("Damage");
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene(2);
    }

    // Start is called before the first frame update
    void Start()
    {
        lumberjack = GameObject.Find("Lumberjack");
        lAnim = lumberjack.GetComponent<Animator>();
        lumberjack.GetComponent<PlayerMovement>().enabled = false;
        StartCoroutine(waitToSwing());
    }
}
