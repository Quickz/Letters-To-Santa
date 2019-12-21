using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FailedScreen : BaseScreen
{
    public static FailedScreen Instance { get; private set; }

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


    private void ReturnToMainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
