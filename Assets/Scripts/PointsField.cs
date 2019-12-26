using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PointsField : MonoBehaviour
{
    public TMP_Text TextField => textField;

    [SerializeField]
    private TMP_Text textField = null;
}
