using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public static class SaveSystem
{
    private const string equippedCostumeKey = "equipped-costume";
    private const string purchasedCostumesKey = "purchased-costumes";

    public static void Save()
    {
        SaveEquippedCostume();
        SavePurchasedCostumes();
    }

    public static void Load()
    {
        if (SaveData.availableCostumes == null)
        {
            Debug.LogError("No available costumes found!");
            return;
        }

        LoadEquippedCostume();
        LoadPurchasedCostumes();
    }

    public static void Clear()
    {
        PlayerPrefs.DeleteAll();
    }

    private static void SaveEquippedCostume()
    {
        PlayerPrefs.SetString(equippedCostumeKey, SaveData.EquippedCostume.ID);
    }

    private static void LoadEquippedCostume()
    {
        if (!PlayerPrefs.HasKey(equippedCostumeKey))
        {
            SaveData.EquippedCostume = SaveData.availableCostumes.costumes[0];
            return;
        }

        string id = PlayerPrefs.GetString(equippedCostumeKey);
        Costume costume = SaveData
            .availableCostumes
            .costumes
            .FirstOrDefault(c => c.ID == id);

        if (costume == null)
        {
            SaveData.EquippedCostume = SaveData.availableCostumes.costumes[0];
            return;
        }

        SaveData.EquippedCostume = costume;
    }

    private static void SavePurchasedCostumes()
    {
        if (SaveData.PurchasedCostumes == null ||
            SaveData.PurchasedCostumes.Count == 0)
        {
            return;
        }

        StringBuilder builder = new StringBuilder();
        for (int i = 0; i < SaveData.PurchasedCostumes.Count - 1; i++)
        {
            if (SaveData.PurchasedCostumes[i].ID.Contains(" "))
            {
                Debug.LogError("Illegal symbol detected, no spaces allowed.");
                continue;
            }

            builder.Append(SaveData.PurchasedCostumes[i].ID);
            builder.Append(" ");
        }
        builder.Append(SaveData.PurchasedCostumes.Last().ID);

        PlayerPrefs.SetString(purchasedCostumesKey, builder.ToString());
    }

    private static void LoadPurchasedCostumes()
    {
        SaveData.PurchasedCostumes.Clear();

        if (!PlayerPrefs.HasKey(purchasedCostumesKey))
        {
            SaveData.PurchasedCostumes.Add(SaveData.availableCostumes.costumes[0]);
            return;
        }

        string[] costumeIDs = PlayerPrefs.GetString(purchasedCostumesKey).Split(' ');
        foreach (string costumeID in costumeIDs)
        {
            Costume costume = SaveData
                .availableCostumes
                .costumes
                .FirstOrDefault(x => x.ID == costumeID);

            if (costume != null)
            {
                SaveData.PurchasedCostumes.Add(costume);
            }
        }
    }
}
