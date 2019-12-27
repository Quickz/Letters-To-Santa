using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    float TimerStart = 2.0f;
    public float timer = 0.0f;
    [SerializeField]
    static int MaxLetters = 20;
    [SerializeField]
    int LetterCount = 0;
    public GameObject[] Letters;
    int randomLetter;
    public Vector3 Pos;
    [SerializeField]
    GameObject Player;
    [SerializeField]
    List<GameObject> LetterList;
    [SerializeField]
    List<float> DistanceList;
    Vector3 PlayerOldPos;
    int OldTime;
    Rigidbody2D rb;
    Vector3 LetterVector;

    // Start is called before the first frame update
    void Start()
    {
        //try to set player if its not explicitly assigned in inspector
        if (Player == null) {
            Player = GameObject.Find("Player");
        }

        //prebuild distance list
        for (var i = 0; i < MaxLetters; i++)
        {
            DistanceList.Add(0);
        }
        }

      //======================\\
     // Decrease Letters Count \\
    //==========================\\ -JW
    public void DecLetters()
    {
        LetterCount -= 1;
        if (LetterCount < 0)
        {
            LetterCount = 0;
        }
        PurgeList();
    }

      //=================================\\
     // Remove all null objects from list \\
    //=====================================\\ -JW
    public void PurgeList()
    {
        LetterList.RemoveAll(GameObject => GameObject == null);
    }

      //========================================================================================\\
     // Updates distance list based on first child of Player object (assumed to be holding point \\
    //============================================================================================\\ -JW
    void UpdateDistanceList()
    {
        for(var i = 0; i < LetterList.Count; i++)
        {
            if (LetterList[i] != null && Player.transform.childCount > 0) {
                DistanceList[i] = (Player.transform.GetChild(0).gameObject.transform.position - LetterList[i].transform.position).magnitude;
            }
        }
    }
    

    // Update is called once per frame
    void Update()
    {
        //Update Distance to Letters if player position changes and space is being pressed
        if (Player.transform.position != PlayerOldPos && Input.GetKey(KeyCode.Space))
        {
            UpdateDistanceList();
            PlayerOldPos = Player.transform.position;
        }

        if (timer <= Time.time) {
            PurgeList();
            if (LetterCount < MaxLetters)
            {
                randomLetter = Random.Range(0, 3);
                Pos.x = (Random.value * 22.0f) - 11.0f;
                Pos.y = 0 - (Random.value * 7f);
                Pos.z = -0.6f;
                LetterList.Add (Instantiate(Letters[randomLetter], Pos, Quaternion.identity));
                LetterCount += 1;
            }
            timer += TimerStart;
            
        }
    }

}
