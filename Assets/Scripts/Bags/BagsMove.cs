using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BagsMove : MonoBehaviour
{
    public int AmountOfBags;
    int FinalBonus;
    public Points pts;
    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "LastCarpet") {
            FinalBonus = AmountOfBags / 2;
            FinalBonus += pts.Total;
            AmountOfBags = 0;
            FinalBonus = 0;
            Vector2 SpawnPos = new Vector2(4.16f, 6.24f);
            transform.position = SpawnPos;
        }
    }
}
