using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
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
            Pos.x = (Random.value * 22.0f) - 11.0f;
            Pos.y = 0 - (Random.value * 7f);
            Pos.x = -4f;
            Instantiate(Letters[randomLetter], Pos, Quaternion.identity);
            timer = 5;
        }
    }
}
