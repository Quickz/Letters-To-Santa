using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float timer = 5;
    public GameObject[] Letters;
    int randomLetter;

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0) {
            randomLetter = Random.Range(1, 3);
            Instantiate(Letters[randomLetter], transform.position, Quaternion.identity);
            timer = 5;
        }
    }
}
