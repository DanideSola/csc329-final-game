using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boardName : MonoBehaviour
{
    GameObject board;
    // Update is called once per frame

    void Start() {
        board = GameObject.FindGameObjectWithTag("Board");
    }

    void Update()
    {
        //constantly returns name of board
        returnName();
    }

    //returns name of board
    public string returnName () {
        //Debug.Log("Name of board is " + board.name);
        return board.name;
    }

    //updates board to the one player is colliding with
    public void OnTriggerStay2D(Collider2D collider) {
        if (collider.gameObject.tag == "Board") {
            board = collider.gameObject;
        }
    }
}
