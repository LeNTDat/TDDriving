using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    float rotationVal = 120f;
    float moveSpeed = 10f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        move();

    }

    void move()
    {
        float horizontalVal = Input.GetAxis("Horizontal") * rotationVal * Time.deltaTime;
        float verticalVal = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, 0, -horizontalVal);
        }
        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S)) {
            transform.Translate(0, verticalVal, 0);
        }
       
    }
}
