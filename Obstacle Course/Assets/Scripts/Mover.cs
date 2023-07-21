using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float playerSpeed = 0f;

    // Start is called before the first frame update
    void Start()
    {
        PrintInstructions();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    //Print to Concole
    void PrintInstructions()
    {
        Debug.Log("Welcome to the Game!");
        Debug.Log("Move Player with WASD or Arrow Keys!");
        Debug.Log("Avoid the Walls!");
    }

    void MovePlayer()
    {
        //AD Inputs
        float xValue = Input.GetAxisRaw("Horizontal") * playerSpeed * Time.deltaTime;
        //WS Inputs
        float zValue = Input.GetAxisRaw("Vertical") * playerSpeed * Time.deltaTime;

        //Move Player
        transform.Translate(xValue, 0f, zValue);
    }
}
