using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShowCookies : MonoBehaviour
{
    public TextMeshProUGUI Cookies;
    // Start is called before the first frame update
    void Start()
    {
        Cookies.SetText(CoinManager.Coins +"C");
    }
}
