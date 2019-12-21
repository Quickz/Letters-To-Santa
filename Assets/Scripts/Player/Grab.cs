using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grab : MonoBehaviour
{
    public bool isGrabbed { get; private set; }
    
    [SerializeField]
    private float distance;
    [SerializeField]
    private Transform holdPoint;
    [SerializeField]
    private Transform downPos;
    [SerializeField]
    private Transform normalPos;
    
    private RaycastHit2D ray;
    private RaycastHit2D cast;

    private void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            if (!isGrabbed)
            {
                ray = Physics2D.Raycast(
                    normalPos.position,
                    Vector2.right * transform.localScale.x,
                    distance);

                if (ray != default(RaycastHit2D) && ray.collider.GetComponent<DroppingLetter>())
                {
                    isGrabbed = true;
                }
            }

            if (isGrabbed && ray != default(RaycastHit2D))
            {
                ray.collider.gameObject.transform.position = holdPoint.position;
            }
        }
        else
        {
            isGrabbed = false;
        }
    }

    public void ChangeWhereObject()
    { 
        normalPos.transform.position = downPos.transform.position;
    }
    public void ChangeBackWhereObject()
    {
        normalPos.transform.position = normalPos.transform.position;
    }
}

