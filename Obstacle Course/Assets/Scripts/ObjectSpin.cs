using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpin : MonoBehaviour
{
    [SerializeField] float xRotation = 0;
    [SerializeField] float yRotation = 0;
    [SerializeField] float zRotation = 0;
    // Update is called once per frame
    void Update()
    {
        //Rotate the Object
        transform.Rotate(xRotation, yRotation, zRotation);
    }
}
