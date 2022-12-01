using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCounter : MonoBehaviour
{
    //Based on code we learned in class
    public int coinCount = 0;
    Text coinScore;
    
    // Start is called before the first frame update
    void Start()
    {
       coinScore = GameObject.Find("CoinScoreText").GetComponent<Text>(); 
    }

    // Update is called once per frame
    void Update()
    {
        coinScore.text = "Score: " + coinCount.ToString();
    }
}
