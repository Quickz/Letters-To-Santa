using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    public Invintory In;
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
    void BuyObject(int Name) {
        int AmountOfCoins = CoinManager.Coins;
        string Objectbuying;
        int Price;
        Objectbuying = Items[Name];
        Price = ItemPrice[Name];

        if (AmountOfCoins <= Price) {
            In.TakeInInvintory(Objectbuying);
        }
        //testing
        Debug.Log(Objectbuying);
    }
}
