using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowFall_Mid : MonoBehaviour
{
    public Vector3 SnowPos;
    public Vector3 SnowStartPos;
    public Vector3 SnowOffset;
    public float Speed;
    public Color SnowColor;
    // Start is called before the first frame update
    void Start()
    {
        SnowStartPos = new Vector2(700 + (Random.value * 50.0f), 700+(Random.value * 50.0f));
        Speed = 20.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (SnowPos.y < -100.0f)
        {
            SnowOffset += SnowStartPos;
        }
        SnowPos.x = SnowStartPos.x - (Speed) * Time.time - (2.0f * Speed) * Mathf.PerlinNoise(0.5f * Time.time + SnowStartPos.x, -0.5f * Time.time + SnowStartPos.y) + SnowOffset.x;
        SnowPos.y = SnowStartPos.y - (2.0f * Speed) * Time.time - Speed * Mathf.PerlinNoise(Time.time, Time.time) + SnowOffset.y;
        gameObject.GetComponent<RectTransform>().position = SnowPos;
    }
}
