using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    float rotationVal = 120f;
    [SerializeField] float moveSpeed = 18f;
    float slowDownSpeed = 9f;
    float bootsSpeed = 30f;
    public bool hasCollision = false;

    void Start()
    {

    }

    void Update()
    {
        move();

    }

    void move()
    {
        float horizontalVal = Input.GetAxis("Horizontal") * rotationVal * Time.deltaTime;
        float verticalVal = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Rotate(0, 0, -horizontalVal);
        transform.Translate(0, verticalVal, 0);
    }


}
