using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public sealed class WinScreen : BaseScreen
{
    public static WinScreen Instance { get; private set; }

    [SerializeField]
    private Button exitButton = null;

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
        exitButton.onClick.AddListener(ReturnToMainMenu);

    }

    private void Update()
    {
        // for testing purposes only
        if (Input.GetKeyDown(KeyCode.L))
        {
            if (!IsOpen)
            {
                Open();
            }
        }
    }

    private void ReturnToMainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
