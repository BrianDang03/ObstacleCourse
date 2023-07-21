using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    //When Wall is Hit
    private void OnCollisionEnter(Collision other)
    {
        //Print into concole msg
        Debug.Log("Object Hit Wall.");

        //Change the color of Wall
        GetComponent<MeshRenderer>().material.color = Color.red;
    }
}
