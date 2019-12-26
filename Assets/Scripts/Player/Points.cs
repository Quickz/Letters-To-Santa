using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Points : MonoBehaviour
{
    public int point = 0;
    public int Total = 0;
    private TMP_Text textField;

    private void Start()
    {
        textField = FindObjectOfType<PointsField>()?.TextField;
        if (textField == null)
        {
            Debug.LogError("Unable to find points field");
        }
    }

    private void Update()
    {
        textField.text = $"Points: {Total}";
        if (Total < 0)
        {
            Total = 0;
        }
    }
}
