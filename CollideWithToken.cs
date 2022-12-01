using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollideWithToken : MonoBehaviour
{
    public AudioSource audio; //lumberjack
    public AudioClip coinCollectSound; //token collest sound
    public AudioClip gainLife; //gained life sound
    public Health h; //health script

    // Start is called before the first frame update
    private void OnCollisionEnter2D(Collision2D collision) {
        if(collision.gameObject.tag == "Coin") {
            audio.PlayOneShot(coinCollectSound);
        }
        if (collision.gameObject.tag == "Food") {
            h.TakeHealth(1);
            audio.PlayOneShot(gainLife);
        }
    }
}
