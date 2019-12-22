using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public sealed class PauseScreen : BaseScreen
{
    public static PauseScreen Instance { get; private set; }

    [SerializeField]
    private Button resumeButton = null;

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
        resumeButton.onClick.AddListener(Close);
        exitButton.onClick.AddListener(ReturnToMainMenuWithFade);

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!IsOpen)
            {
                Open();
                
            }
            else
            {
                Close();
                
            }
        }

        if (!IsOpen) {
            Time.timeScale = 1f;
        }
        else {
            Time.timeScale = 0f;
        }
    }

    private void ReturnToMainMenuWithFade()
    {
        SceneTransition.Instance.RunWithFade(ReturnToMainMenu);
    }

    private void ReturnToMainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
