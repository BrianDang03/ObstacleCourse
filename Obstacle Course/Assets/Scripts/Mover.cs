using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float playerSpeed = 0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //AD Inputs
        float xValue = Input.GetAxisRaw("Horizontal") * playerSpeed * Time.deltaTime;
        //WS Inputs
        float zValue = Input.GetAxisRaw("Vertical") * playerSpeed * Time.deltaTime;

        //Move Player
        transform.Translate(xValue, 0f, zValue);
    }
}
