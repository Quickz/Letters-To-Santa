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

    void Update()
    {
        TimeLeft -= Time.deltaTime;
        if (TimeLeft <= 0 && pt.Total >= 50) {
            ws.Open();
        }

        tx.text = "" + (int)TimeLeft;

        if (TimeLeft <= 0 && pt.Total <= 50) {
            fs.Open();
        }
    }
}
