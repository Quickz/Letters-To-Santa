using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroppingLetter : MonoBehaviour
{
    public int randomTag;
    public Points pts;
    BagsMove bags;
    [SerializeField]
    private bool IsHeld;
    [SerializeField]
    GameObject SpawnerObj;

    public void SetHeld()
    {
        IsHeld = true;
        gameObject.GetComponent<CircleCollider2D>().isTrigger = true;
    }

    public void SetDrop()
    {
        IsHeld = false;
        gameObject.GetComponent<CircleCollider2D>().isTrigger = false;
    }

    public bool GetHeld()
    {
        return IsHeld;
    }

    public void DestroyLetter()
    {
        Destroy(gameObject);
        SpawnerObj.GetComponent<Spawner>().DecLetters();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bin") {
            bags = collision.gameObject.GetComponent<BagsMove>();
            bags.AmountOfBags += 1;
            Destroy(gameObject);
            SpawnerObj.GetComponent<Spawner>().DecLetters();
        }
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "End Carpet")
        {
            pts.Total -= 1;
            Destroy(gameObject);
            SpawnerObj.GetComponent<Spawner>().DecLetters();
        }
    }
}
