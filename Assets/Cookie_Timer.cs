using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cookie_Timer : MonoBehaviour
{
    GameObject CookieParent;
    [SerializeField]
    float TimeLeft;
    float InitialTime;
    // Start is called before the first frame update
    void Start()
    {
        CookieParent = transform.parent.gameObject;
        InitialTime = CookieParent.GetComponent<Timer>().InitialTime;
    }

    // Update is called once per frame
    void Update()
    {
        TimeLeft = CookieParent.GetComponent<Timer>().RemainingTime / InitialTime;
        gameObject.GetComponent<SpriteMask>().alphaCutoff = 1.0f - TimeLeft;
    }
}
