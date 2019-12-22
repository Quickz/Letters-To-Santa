using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float TimeLeft;
    public WinScreen ws;
    public FailedScreen fs;
    public Points pt;
    public Text tx;
    // Update is called once per frame
    void Update()
    {
        TimeLeft -= Time.deltaTime;
        if (TimeLeft <= 0)
        {
            ws.DoneGame();
        }

        tx.text = "" + (int)TimeLeft;
    }
}
