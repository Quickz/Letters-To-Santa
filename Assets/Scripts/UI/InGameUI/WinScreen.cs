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
    public Points pts;
    private float points;
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

    }

    public void DoneGame() {
        Open();
        points = pts.Total / 10;
        textmesh.text = "" + points;
    }

    private void ReturnToMainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
