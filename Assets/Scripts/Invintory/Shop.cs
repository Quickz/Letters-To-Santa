using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    public Inventory In;
    public string[] Items = {
        "Kevin",
        "Jack",
        "elsa",
        "grinch",
        "Santa"
    };
    public int[] ItemPrice = {
        50,
        50,
        100,
        150,
        200
    };

    //We set Name to int becaue we ant to get the name in the list.
    public void BuyObject(int Name)
    {
        Debug.Log("Test");
        int AmountOfCoins = CoinManager.Coins;
        string Objectbuying;
        int Price;
        Objectbuying = Items[Name];
        Price = ItemPrice[Name];

        if (AmountOfCoins <= Price)
        {
            
        }
        //testing
        Debug.Log(Objectbuying);
    }
}
