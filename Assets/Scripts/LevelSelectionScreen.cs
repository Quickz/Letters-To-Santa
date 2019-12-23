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

    [SerializeField]
    private Button levelButton1 = null;

    [SerializeField]
    private Button levelButton2 = null;

    [SerializeField]
    private Button levelButton3 = null;

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
        levelButton1.onClick.AddListener(OpenNextSceneWithFade);
        levelButton2.onClick.AddListener(OpenNextSceneWithFade);
        levelButton3.onClick.AddListener(OpenNextSceneWithFade);
    }

    private void OpenNextSceneWithFade()
    {
        SceneTransition.Instance.RunWithFade(OpenNextScene);
    }

    private void OpenNextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
