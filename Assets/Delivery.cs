using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool hasPackage = false;
    float delayTime = 0.5f;
    Color defaultColor = Color.white;
    SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Package")
        {
            Color packageColor = collision.GetComponent<SpriteRenderer>().color;
            Destroy(collision.gameObject, delayTime);
            spriteRenderer.color = packageColor;
            hasPackage = true;
        }

        if(collision.tag == "Customer" && hasPackage)
        {
            spriteRenderer.color = defaultColor;

        }
        
        if(collision.tag == "Boost")
        {
            gameObject.GetComponent<PlayerControl>().hasCollision = true;
        }



    }
}
