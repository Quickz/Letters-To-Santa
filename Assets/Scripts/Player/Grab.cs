using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grab : MonoBehaviour
{
    public bool isGrabbed;
    RaycastHit2D ray;
    public float distance;
    public Transform point;
    public Transform HoldPoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

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
            else
            {
          
            }

            if (isGrabbed)
            {
                ray.collider.gameObject.transform.position = HoldPoint.position;
            }
        }
        else {
            isGrabbed = false;
        }
    }
}
