using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Bags : MonoBehaviour
{
    public float points;
    public Points pts;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == gameObject.tag) {
            pts.Total += 10;
            Debug.Log(points);
        } else if (collision.gameObject.tag != "Player")
        {
            pts.Total -= 5;
            Debug.Log(points);
        }
    }
}
