using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyItem : MonoBehaviour
{
    public Shop shop;
    public Button[] Items;
   public void Buyone() {
        shop.BuyObject(0);
    }
    public void Buytwo()
    {
        shop.BuyObject(1);
    }
   public void Buythreee()
    {
        shop.BuyObject(2);
    }
    public void Buyfour()
    {
        shop.BuyObject(3);
    }
    public void Buyfive()
    {
        shop.BuyObject(4);
    }
}
