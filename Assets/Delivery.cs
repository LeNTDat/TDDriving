using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        print("What hit this shit!! it's a " + collision.transform.name);
        print("this shit is a " + transform.name);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        print(collision.transform.name);
        if (collision.transform.name == "Package")
        {
            print("you pick up a " + collision.transform.name);
        }
    }
}
