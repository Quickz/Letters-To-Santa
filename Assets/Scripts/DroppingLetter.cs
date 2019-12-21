using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroppingLetter : MonoBehaviour
{
    public int randomTag;

    private void Start()
    {
        randomTag = Random.Range(1, 3);
        gameObject.tag = "Item"+randomTag;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Am Colliding");
        if (collision.gameObject.tag == "Bin") {
            Destroy(gameObject);
        }
    }
}
