using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Points : MonoBehaviour
{
    public int point = 0;
    public int Total = 0;
    public Text tx;

    // Update is called once per frame
    void Update()
    {
        tx.text = "Points: " + Total;
        if (Total < 0) {
            Total = 0;
        }
    }
}
