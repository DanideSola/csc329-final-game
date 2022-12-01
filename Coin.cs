using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    //Based on code we learned in class
    public CoinCounter coinCounter;
    
    // Start is called before the first frame update
    void Start()
    {
        coinCounter = GameObject.Find("CoinCounter").GetComponent<CoinCounter>();
    }

    //professor method
    private void OnCollisionEnter2D(Collision2D collision) {
        if(collision.gameObject.tag == "Player") {
            coinCounter.coinCount++;
            gameObject.SetActive(false);
            Debug.Log("Coin collision. Coins = " + coinCounter.coinCount);
        }
    }
}
