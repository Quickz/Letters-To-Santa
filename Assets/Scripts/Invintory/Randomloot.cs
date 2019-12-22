using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Randomloot : MonoBehaviour
{
    public List<GameObject> lights;
    public int[] table = {
        70, // Costume a
        50, //Costume B
        40, //Costume C
        30, //Costume D

    };
    public int total;
    public int RandomNum;
    
    void Start()
    {   
        foreach (var item in table) {
            total += item;
        }

        RandomNum = Random.Range(0, total);

        for (int i = 0; i < table.Length;) {
            if (RandomNum <= table[i])
            {
                lights[i].SetActive(true);
            }
            else {
                RandomNum -= table[i];
            }
        }
    }
}
