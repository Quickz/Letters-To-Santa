using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShopCostume : MonoBehaviour
{
    public Costume Costume => costume;

    [SerializeField]
    private Costume costume = null;

    [SerializeField]
    private Button button = null;

    [SerializeField]
    private Inventory playerInventory = null;

    [SerializeField]
    private Image icon = null;

    [SerializeField]
    private TMP_Text priceLabel = null;

    enum CostumeStatus
    {
        None,
        Purchased,
        Equipped
    }
    private CostumeStatus costumeStatus;

    private void Awake()
    {
        EquipedCostumeManager.EquipedCostumeChanged += OnEquipedCostumeChanged;
    }

    private void Start()
    {
        if (playerInventory.costumes.Contains(costume))
        {
            if (EquipedCostumeManager.EquipedCostume == costume)
            {
                MarkAsEquipped();
            }
            else
            {
                MarkAsPurchased();
            }
        }
        button.onClick.AddListener(OnButtonClick);
    }

    private void OnButtonClick()
    {
        if (costumeStatus == CostumeStatus.None)
        {
            Buy();
        }
        else if (costumeStatus == CostumeStatus.Purchased)
        {
            Equip();
        }
    }

    private void OnEquipedCostumeChanged(object sender, Costume equippedCostume)
    {
        // equip
        if (equippedCostume == costume)
        {
            MarkAsEquipped();
        }
        // unequip
        else if (costumeStatus == CostumeStatus.Equipped)
        {
            MarkAsPurchased();
        }
    }

    private void Buy()
    {
        if (CoinManager.Coins < costume.Price)
        {
            return;
        }

        MarkAsPurchased();
        CoinManager.Coins -= costume.Price;
        playerInventory.costumes.Add(costume);
    }

    private void Equip()
    {
        EquipedCostumeManager.EquipedCostume = costume;
    }

    private void MarkAsPurchased()
    {
        costumeStatus = CostumeStatus.Purchased;
        button.interactable = true;
        TMP_Text textField = button.GetComponentInChildren<TMP_Text>();
        textField.text = "Equip";
        textField.color = Color.white;
    }

    private void MarkAsEquipped()
    {
        costumeStatus = CostumeStatus.Equipped;
        button.interactable = false;
        TMP_Text textField = button.GetComponentInChildren<TMP_Text>();
        textField.text = "Equipped";
        textField.color = Color.white;
    }

    private void OnValidate()
    {
        if (costume != null)
        {
            if (icon != null && icon.sprite != costume.FrontSprite)
            {
                icon.sprite = costume.FrontSprite;
            }

            string price = $"{costume.Price}c";
            if (priceLabel != null && priceLabel.text != price)
            {
                priceLabel.text = price;
            }
        }
    }
}
