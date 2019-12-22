using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class CoinManager
{
    private static int coins;
    public static int Coins
    {
        get {
            return coins;
        }
        set {
            coins = value;
        }
    }

    
}
