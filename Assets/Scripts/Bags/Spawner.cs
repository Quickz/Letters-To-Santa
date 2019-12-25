using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    float TimerStart = 2.0f;
    public float timer = 0.0f;
    [SerializeField]
    int MaxLetters = 20;
    [SerializeField]
    int LetterCount = 0;
    public GameObject[] Letters;
    int randomLetter;
    public Vector3 Pos;

    public void DecLetters()
    {
        LetterCount -= 1;
        if (LetterCount < 0)
        {
            LetterCount = 0;
        }
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0) {
            if (LetterCount < MaxLetters)
            {
                randomLetter = Random.Range(0, 3);
                Pos.x = (Random.value * 22.0f) - 11.0f;
                Pos.y = 0 - (Random.value * 7f);
                Pos.z = -0.6f;
                Instantiate(Letters[randomLetter], Pos, Quaternion.identity);
                LetterCount += 1;
            }
            timer = TimerStart;
            
        }
    }
}
