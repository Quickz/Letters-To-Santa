﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grab : MonoBehaviour
{
    public bool isGrabbed;
    RaycastHit2D ray;
    RaycastHit2D cast;
    public float distance;
    public Transform point;
    public Transform point2;
    public Transform HoldPoint;
    public Transform DownPos;
    public Transform NormalPos;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            if (!isGrabbed)
            {
                ray = Physics2D.Raycast(point.position, Vector2.right * transform.localScale.x, distance);
                if (ray.collider != null && ray.collider.gameObject.tag != "World")
                {
                    isGrabbed = true;
                }
            }

            if (isGrabbed && ray != default(RaycastHit2D))
            {
                ray.collider.gameObject.transform.position = HoldPoint.position;
            }
        }
        else {
            isGrabbed = false;
        }
    }

    public void changeWhereObject() { 
        point.transform.position = DownPos.transform.position;
    }
    public void changeBackWhereObject()
    {
        point.transform.position = NormalPos.transform.position;
    }
}

