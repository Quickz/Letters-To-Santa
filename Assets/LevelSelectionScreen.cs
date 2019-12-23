using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelSelectionScreen : BaseScreen
{
    public static LevelSelectionScreen Instance { get; private set; }

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
    }
}
