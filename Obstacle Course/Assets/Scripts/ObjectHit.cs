using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    MeshRenderer mr;

    void Start()
    {
        //Assign Mesh Render
        mr = GetComponent<MeshRenderer>();
    }
    //When object is Hit
    private void OnCollisionEnter(Collision other)
    {
        //If Player Hits Object
        if (other.gameObject.tag == "Player")
        {
            //Change the color of Object to red
            mr.material.color = Color.red;
            //Change object to hit Object
            gameObject.tag = "Hit";
        }
    }
}
