using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeRoom : MonoBehaviour
{
    GameObject board;
    string teleporterName = "";
    public boardName bn;
    // Start is called before the first frame update
    void Start()
    {
        board = GameObject.FindGameObjectWithTag("Board");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)) {
            Debug.Log("Name of teleporter = " + teleporterName);
            //updates board to the one player is colliding with
            board = GameObject.Find(bn.returnName());
            Debug.Log("Board is " + board.name + ". Tag is " + board.tag);
            if (teleporterName != "") {
                switch (teleporterName) {
                    case "EntranceTop":    
                        if (board.tag == "Broken Board") {
                            transform.position = new Vector3(-0.99f, 16.8f, 0);
                        }                    
                        break;
                    case "LivingRoomLowLeft":
                        transform.position = new Vector3(-0.99f, 2.34f, 0);
                        break;
                    case "EntranceLeft":
                        transform.position = new Vector3(-23.6f, -1.82f, 0);
                        break;
                    case "StairRoomLowRight":
                        transform.position = new Vector3(-5.35f, -1.82f, 0);
                        break;
                    case "StairRoomTop":
                        if (board.tag == "Broken Board") {
                        transform.position = new Vector3(-5.0f, 39.85f, 0);    
                        }
                        break;
                    case "KDLeft":
                        if (GameObject.Find("Wood Board (1)").tag == "Broken Board") {
                            transform.position = new Vector3(-23.98f, 12.2f, 0);
                        }
                        break;
                    case "StairRoomToSecondFloor":
                        transform.position = new Vector3(87.68f, 10.85f, 0);
                        break;
                    case "FromStair":
                        transform.position = new Vector3(-30.83f, 11.97f, 0);
                        break;
                    case "LivingRoomLowRight":
                        transform.position = new Vector3(21.99f, 2.30f, 0);
                        break;
                    case "LibraryTop":
                    /*
                    if (board.tag == "Broken Board") {
                        transform.position = new Vector3(5.998f, 16.83f, 0);
                    }
                    */
                        transform.position = new Vector3(5.998f, 16.83f, 0);
                        break;
                    case "LivingRoomTop":
                        if (board.tag == "Broken Board") {
                        transform.position = new Vector3(5.99f, 39.85f, 0);
                        }
                        break;
                    case "KDRight":
                        //Debug.Log("Wood Board (2) tag is " + GameObject.Find("Wood Board (2)").tag);
                        if (GameObject.Find("Wood Board (2)").tag == "Broken Board") {
                            transform.position = new Vector3(5.99f, 23.27f, 0);
                        }
                        break;
                    case "LibraryLowRight":
                        transform.position = new Vector3(50.66f, -1.82f, 0);
                        break;
                    case "Office":
                        transform.position = new Vector3(29.37f, -1.82f, 0);
                        break;
                    case "ToBedroom1":
                        if (board.tag == "Broken Board") {
                        transform.position = new Vector3(97.0f, 35.78f, 0);
                        }
                        break;
                    case "ToBedroom2":
                        if (board.tag == "Broken Board") {
                        transform.position = new Vector3(118.0f, 35.78f, 0);
                        }
                        break;
                    case "HallwayBottom":
                        transform.position = new Vector3(95.99f, -9.74f, 0);
                        break;
                    case "Bedroom1Bottom":
                        transform.position = new Vector3(97.0f, 10.29f, 0);
                        break;
                    case "Bedroom2Bottom":
                        transform.position = new Vector3(102.0f, 10.29f, 0);
                        break;
                    case "LivingTop":
                    /*
                    if (board.tag == "Broken Board") {
                        transform.position = new Vector3(97.0f, 6.79f, 0);
                    }
                    */
                        transform.position = new Vector3(97.0f, 6.79f, 0);
                        break;
                    case "LivingRight":
                        transform.position = new Vector3(123.74f, -13.82f, 0);
                        break;
                    case "StorageLeft":
                        transform.position = new Vector3(100.36f, -13.82f, 0);
                        break;
                    case "StorageTop":
                        transform.position = new Vector3(156.49f, 13.6f, 0);
                        break;
                    case "AtticBottomRight":
                        transform.position = new Vector3(126.5f, -10.0f, 0);
                        break;
                }
            }
        }
    }

    void OnTriggerStay2D(Collider2D collision) {
        if (collision.gameObject.tag == "Teleporter") {
            teleporterName = collision.gameObject.name;
        }
    }

    void OnTriggerExit2D(Collider2D collision) {
        if (collision.gameObject.tag == "Teleporter") {
            teleporterName = "";
        }
    }
}
