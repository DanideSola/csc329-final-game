using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardBreak : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject board;
    public GameObject lumberjack;
    public Animator bAnim;
    public Animator lAnim;
    public AudioSource audio;
    public float distance = 0;
    public boardName bn;
    AnimatorStateInfo currentStateLumberjack;

    // Update is called once per frame
    void Update()
    {
        //get state of lumberjack to see if animation is playing
        currentStateLumberjack = lAnim.GetCurrentAnimatorStateInfo(0);
        //distance from board
        distance = Vector3.Distance(board.transform.position, lumberjack.transform.position);

        //if animation is playing and close to board
        if (currentStateLumberjack.fullPathHash == Animator.StringToHash("Base Layer.Ax_Swing_Left") || currentStateLumberjack.fullPathHash == Animator.StringToHash("Base Layer.Ax_Swing_Right") || currentStateLumberjack.fullPathHash == Animator.StringToHash("Base Layer.Ax_Swing_Right 1")) {
            if (distance >= 0 && distance <= 1f) {
                //call break board
                breakBoard();
                //change the tag of board after it has been broken
                changeBoardTag();
            }
        }
    }

    //plays breaking board animation
    public void breakBoard() {
        bAnim.SetTrigger("Break");
    }

    //changes board tag to "Broken Board"
    public void changeBoardTag() {
        Debug.Log("ChangeBoardTag is reached!");
        //create object that stores board that player is colliding with (finds specific name of board from collision detection with lumberjack)
        GameObject board = GameObject.Find(bn.returnName());

        //if the tag is not broken board then change it to broken board
        if (board.tag != "Broken Board") {
            audio.Play();
            Debug.Log("Name of board is " + bn.returnName() + ". Tag is " + board.tag);
            board.tag = "Broken Board";
            Debug.Log("Tag becomes " + board.tag);
        }
    }
}
