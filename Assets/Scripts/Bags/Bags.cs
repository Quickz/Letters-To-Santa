using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Bags : MonoBehaviour
{
    public float points;
    public string tagg;
    public int Letters_Rec;

    private Points pts;

    private void Start()
    {
        pts = FindObjectOfType<Points>();
        if (pts == null)
        {
            Debug.LogError("Unable to find an instance of Points");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == tagg) {
            pts.Total += 10;
            collision.GetComponent<DroppingLetter>().DestroyLetter();
            //Debug.Log(points);
           
        } else if (collision.gameObject.tag != "Player")
        {
            pts.Total -= 5;
            collision.GetComponent<DroppingLetter>().DestroyLetter();
            //Debug.Log(points);
        }
    }

    public void CountLetters() {
        
    }
}
