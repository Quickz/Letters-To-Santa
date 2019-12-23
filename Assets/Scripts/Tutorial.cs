using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Tutorial : MonoBehaviour
{
    public GameObject[] popUps;
    private int popUpIndex;
    public float WaitTime = 10f;
    public TextMeshProUGUI textDisplay;
    public string[] sentences;
    public float typingSpeed;
    public int index;
    public float thing = 3;


    private void Start()
    {
        StartCoroutine(Type());
    }

    IEnumerator Type() {
        foreach (char letter in sentences[index].ToCharArray()) {
            textDisplay.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
    }

    public void NextSentince() {
        thing -= Time.deltaTime;
        if (thing <= 0)
        {
            if (index < sentences.Length - 1)
            {
                index++;
                textDisplay.text = " ";
                StartCoroutine(Type());
            }
            else
            {
                textDisplay.text = " ";
            }
            thing = 10;
        }
    }

    // Update is called once per frame
    void Update()
    {
        NextSentince();
        for (int i = 0; i < popUps.Length; i++)
        {
            if (i == popUpIndex)
            {
                popUps[i].SetActive(true);
            }
            else
            {
                popUps[i].SetActive(false);
            }
        }

        if (popUpIndex == 0)
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                popUpIndex++;
               
            }
          
        }
        else if (popUpIndex == 1)
        {
            if (Input.GetKeyDown(KeyCode.D))
            {
                popUpIndex++;
            }
    
        }
        else if (popUpIndex == 2)
        {

            if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.S))
            {
                popUpIndex++;
            }
            NextSentince();
        }
        else if (popUpIndex == 3)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                popUpIndex++;
            }
           
        }


    }
}
