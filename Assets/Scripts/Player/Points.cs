using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Points : MonoBehaviour
{
    public int point;
    public int Total;
    public Text tx;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
        tx.text = "Points: " + Total;
        if (Total < 0) {
            Total = 0;
        }
    }
}
