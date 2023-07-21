using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScore : MonoBehaviour
{
    private int playerScore;
    private void OnCollisionEnter(Collision other)
    {
        //If has not been hit
        if (other.gameObject.GetComponent<MeshRenderer>().material.color != Color.red)
        {
            //Inc Player Score
            playerScore++;
        }

        //Print into concole msg
        Debug.Log("Object Hit Wall. Your Score is " + playerScore);
    }
}
