using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsScreen : BaseScreen
{
    public static SettingsScreen Instance { get; private set; }

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
        backButton.onClick.AddListener(MainScreen.Instance.OpenAlone);
    }
}
