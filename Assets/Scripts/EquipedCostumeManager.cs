using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class EquipedCostumeManager
{
    public static EventHandler<Costume> EquipedCostumeChanged;

    public static Costume EquipedCostume
    {
        get
        {
            return _equipedCostume;
        }
        set
        {
            _equipedCostume = value;
            EquipedCostumeChanged?.Invoke(null, value);
        }
    }
    private static Costume _equipedCostume;
}
