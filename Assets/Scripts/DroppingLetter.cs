﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroppingLetter : MonoBehaviour
{
    public int randomTag;

    private void Start()
    {
       
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.tag != "Player") {
            Destroy(gameObject);
        }
    }
}
