using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class Timer : MonoBehaviour
{
    public float RemainingTime { get; private set; }
    public float InitialTime => initialTime;

    [SerializeField]
    private TMP_Text textField = null;

    [SerializeField]
    private Image progressBar = null;

    [Tooltip("Amount of time left in the beginning (in seconds).")]
    [SerializeField]
    private float initialTime = 60f;

    private void Awake()
    {
        RemainingTime = initialTime;
    }

    private void Start()
    {
        StartTimerAndOnCompletionExecute(WinScreen.Instance.DoneGame);
    }

    private void StartTimerAndOnCompletionExecute(Action callback)
    {
        StartCoroutine(Process());

        IEnumerator Process()
        {
            while (RemainingTime > 0f)
            {
                RemainingTime -= Time.deltaTime;
                
                if (textField != null)
                {
                    textField.text = RemainingTime.ToString("0");
                    progressBar.fillAmount = 1f / (initialTime / RemainingTime);
                }

                yield return new WaitForEndOfFrame();
            }
            callback();
        }
    }
}
