using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public sealed class WinScreen : BaseScreen
{
    public static WinScreen Instance { get; private set; }

    [SerializeField]
    private Button exitButton = null;
    public TextMeshProUGUI textmesh;
    private Points pts;
    private float points = 0f;

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
        exitButton.onClick.AddListener(ReturnToMainMenuWithFade);

        pts = FindObjectOfType<Points>();
        if (pts == null)
        {
            Debug.LogError("Unable to find an instance of Points");
        }
    }

    public void DoneGame()
    {
        Open();

        //fall back
        if (pts.Total > 0) {
            points = pts.Total / 10;
        }
        else {
            pts.point = 1;
        }
        //Debug.Log(points);
        textmesh.text = "" + points;
        CoinManager.Coins = (int)points;
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
