using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public sealed class ShopScreen : BaseScreen
{
    public static ShopScreen Instance { get; private set; }

    [SerializeField]
    private Inventory playerInventory = null;

    [SerializeField]
    private Inventory availableCostumes = null;

    [SerializeField]
    private Button backButton = null;

    protected override void Awake()
    {
        base.Awake();
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Debug.LogError("Duplicate screen detected");
            Destroy(gameObject);
            return;
        }
    }

    private void Start()
    {
        backButton.onClick.AddListener(MainScreen.Instance.OpenAlone);

        if (EquipedCostumeManager.EquipedCostume == null)
        {
            playerInventory.costumes.Clear();

            // default costume
            playerInventory.costumes.Add(availableCostumes.costumes[0]);
            EquipedCostumeManager.EquipedCostume = availableCostumes.costumes[0];
        }
    }
}
