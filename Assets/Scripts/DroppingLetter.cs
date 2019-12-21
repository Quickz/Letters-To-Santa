using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroppingLetter : MonoBehaviour
{
    public int randomTag;
    public Points pts;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Cool");
        if (collision.gameObject.tag == "Bin") {
            Destroy(gameObject);
        }
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "End Carpet")
        {
            pts.Total -= 1;
            Destroy(gameObject);
        }
    }
}
