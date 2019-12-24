using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointsField : MonoBehaviour
{
    public Text TextField => textField;

    [SerializeField]
    private Text textField = null;
}
