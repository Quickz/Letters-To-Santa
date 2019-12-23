using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner4 : MonoBehaviour
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
            Pos.x = 10.0f - (Random.value * 20.0f);
            Pos.y = 3.0f  - (Random.value * 3f);
            Pos.z = 0;
            Instantiate(Letters[randomLetter], Pos, Quaternion.identity);
            timer = 5;
        }
    }
}
