using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsScreen : BaseScreen
{
    public static SettingsScreen Instance { get; private set; }

    [SerializeField]
    private Button deleteSavesButton = null;

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
            Destroy(gameObject);
            return;
        }
    }

    private void Start()
    {
        deleteSavesButton.onClick.AddListener(OnDeleteSavesButtonClicked);
        backButton.onClick.AddListener(MainScreen.Instance.OpenAlone);
    }

    public override void Close()
    {
        base.Close();
        deleteSavesButton.interactable = true;
    }

    private void OnDeleteSavesButtonClicked()
    {
        DeleteSavedData();
        deleteSavesButton.interactable = false;
    }

    private void DeleteSavedData()
    {
        SaveSystem.Clear();

        // loading up the default values
        SaveSystem.Load();
    }
}
