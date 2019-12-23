using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner3 : MonoBehaviour
{
    public float timer = 5;
    public GameObject[] Letters;
    int randomLetter;
    public Vector3 Pos;

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0) {
            randomLetter = Random.Range(1, 3);
            Pos.x = -2 + (Random.value * 12.0f);
            Pos.y = -4 - (Random.value * 3.0f);
            Pos.z = 0;
            Instantiate(Letters[randomLetter], Pos, Quaternion.identity);
            timer = 5;
        }
    }
}
