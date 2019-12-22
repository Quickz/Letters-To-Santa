using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroppingLetter : MonoBehaviour
{
    public int randomTag;
    public Points pts;
    BagsMove bags;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bin") {
            bags = collision.gameObject.GetComponent<BagsMove>();
            bags.AmountOfBags += 1;
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
