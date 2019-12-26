using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float TimeLeft;
    public WinScreen ws;
    public FailScreen fs;
    public Text tx;
    // Update is called once per frame
    void Update()
    {
        
        if (TimeLeft <= 0)
        {
            
            ws.DoneGame();
        } else
        {
            TimeLeft -= Time.deltaTime;
        }

        tx.text = "" + (int)TimeLeft;
    }
}
