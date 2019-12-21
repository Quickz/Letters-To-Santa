﻿using System.Collections;
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
        exitButton.onClick.AddListener(ReturnToMainMenu);

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
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
    }

    private void ReturnToMainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
