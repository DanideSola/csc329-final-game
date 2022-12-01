using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KillBox : MonoBehaviour
{
    public Animator lAnim;
    public Health playerHealth;
    public Animator anim;
    AudioSource audio;
    public bool trapIsClosed = false;
    
    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerHealth.healthAmount <= 0) {
            Debug.Log("Game Over."); 
            SceneManager.LoadScene(2);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.tag == "Player") {
            //Debug.Log("Collision with Trap Detected");
            anim.SetTrigger("CloseTrap");
            if (!trapIsClosed) {
                lAnim.SetTrigger("Damage");
                audio.Play();
                playerHealth.TakeDamage(1);
            }
            trapIsClosed = true;
            BoxCollider2D bc = gameObject.GetComponent<BoxCollider2D>();
            bc.size = new Vector3(1.1f, 1.5f);
            bc.offset = new Vector3(0.01f, -0.85f);
        }
    }
}
