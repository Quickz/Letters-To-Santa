using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class SaveData
{
    public static EventHandler<Costume> EquippedCostumeChanged;

    public static List<Costume> PurchasedCostumes { get; set; } = new List<Costume>();

    public static Inventory availableCostumes;

    public static Costume EquippedCostume
    {
        get
        {
            return _equippedCostume;
        }
        set
        {
            _equippedCostume = value;
            EquippedCostumeChanged?.Invoke(null, value);
        }
    }
    private static Costume _equippedCostume;
}
