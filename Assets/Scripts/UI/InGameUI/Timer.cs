using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class Timer : MonoBehaviour
{
    public float RemainingTime => remainingTime;

    [Tooltip("Amount of time left (in seconds).")]
    [SerializeField]
    private float remainingTime = 60f;

    [SerializeField]
    private TMP_Text textField = null;

    private void Start()
    {
        StartTimerAndOnCompletionExecute(WinScreen.Instance.DoneGame);
    }

    private void StartTimerAndOnCompletionExecute(Action callback)
    {
        StartCoroutine(Process());

        IEnumerator Process()
        {
            while (remainingTime > 0f)
            {
                remainingTime -= Time.deltaTime;
                
                if (textField != null)
                {
                    textField.text = remainingTime.ToString("0");
                }

                yield return new WaitForEndOfFrame();
            }
            callback();
        }
    }
}
