using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDrop : MonoBehaviour
{
    //Seconds for Object to Drop
    [SerializeField] float secsToDrop = 0f;
    Rigidbody rb;
    MeshRenderer mr;

    // Start is called before the first frame update
    void Start()
    {
        //Assgin Body
        rb = GetComponent<Rigidbody>();
        mr = GetComponent<MeshRenderer>();

        //Cube is Invisable and No Garavity
        mr.enabled = false;
        rb.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        //If seconds then drop
        if (Time.time > secsToDrop)
        {
            //Make the Cube Appear and Drop
            mr.enabled = true;
            rb.useGravity = true;
        }
    }
}
