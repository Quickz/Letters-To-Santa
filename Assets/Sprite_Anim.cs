using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sprite_Anim : MonoBehaviour
{
    [SerializeField]
    static int NumFrames;
    [SerializeField]
    Sprite[] Frames = new Sprite[NumFrames];
    [SerializeField]
    float FPS;
    float CurrentFrame;
    int NumFrames2;

    // Start is called before the first frame update
    void Start()
    {
        NumFrames2 = Frames.Length;
    }

    // Update is called once per frame
    void Update()
    {
        CurrentFrame = (int)((Time.time/ NumFrames2) % (1 / FPS) * NumFrames2 * FPS);
        gameObject.GetComponent<SpriteRenderer>().sprite = Frames[(int)CurrentFrame];
    }
}
