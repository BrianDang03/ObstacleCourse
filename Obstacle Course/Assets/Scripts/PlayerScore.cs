using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScore : MonoBehaviour
{
    private int playerScore;
    private void OnCollisionEnter(Collision other)
    {
        //If has not been hit
        if (other.gameObject.tag != "Hit")
        {
            //Inc Player Score
            playerScore++;

            //Print into concole msg
            Debug.Log("You hit somthing! You have hit " + playerScore + " times");
        }
    }
}
