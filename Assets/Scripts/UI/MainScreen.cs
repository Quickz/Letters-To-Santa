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

    [SerializeField]
    private Button shopButton = null;

    [SerializeField]
    private Button settingsButton = null;

    [SerializeField]
    private Button quitButton = null;

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
        startButton.onClick.AddListener(StartGame);
        highscoresButton.onClick.AddListener(HighscoresScreen.Instance.OpenAlone);
        creditsButton.onClick.AddListener(CreditsScreen.Instance.OpenAlone);
        shopButton.onClick.AddListener(ShopScreen.Instance.OpenAlone);
        settingsButton.onClick.AddListener(SettingsScreen.Instance.OpenAlone);
        quitButton.onClick.AddListener(Application.Quit);

#if UNITY_WEBGL
        quitButton.gameObject.SetActive(false);
#endif

        OpenAlone();
    }

    private void StartGame()
    {
        LevelSelectionScreen.Instance.OpenAlone();
    }
}
