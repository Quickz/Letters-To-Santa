using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public sealed class MainScreen : BaseScreen
{
    public static MainScreen Instance { get; private set; }

    [SerializeField]
    private Button startButton = null;

    [SerializeField]
    private Button highscoresButton = null;

    [SerializeField]
    private Button creditsButton = null;
    
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
        startButton.onClick.AddListener(StartGameWithFade);
        highscoresButton.onClick.AddListener(HighscoresScreen.Instance.OpenAlone);
        creditsButton.onClick.AddListener(CreditsScreen.Instance.OpenAlone);

        OpenAlone();
    }

    private void StartGameWithFade()
    {
        SceneTransition.Instance.RunWithFade(StartGame);
    }

    private void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
