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
    private Button buyButton = null;

    [SerializeField]
    private Inventory playerInventory = null;

    [SerializeField]
    private Image icon = null;

    [SerializeField]
    private TMP_Text priceLabel = null;

    private void Start()
    {
        if (playerInventory.costumes.Contains(costume))
        {
            DisablePurchasingOption();
        }
        else
        {
            buyButton.onClick.AddListener(Buy);
        }
    }

    private void Buy()
    {
        if (CoinManager.Coins < costume.Price)
        {
            return;
        }

        CoinManager.Coins -= costume.Price;
        playerInventory.costumes.Add(costume);
        DisablePurchasingOption();
    }

    private void DisablePurchasingOption()
    {
        buyButton.interactable = false;
        TMP_Text textField = buyButton.GetComponentInChildren<TMP_Text>();
        textField.text = "Owned";
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
