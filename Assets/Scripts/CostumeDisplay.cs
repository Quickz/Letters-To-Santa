using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CostumeDisplay : MonoBehaviour
{
    public Costume costume;
    private SpriteRenderer SpriteR;
    private Sprite[] sprites;
    // Start is called before the first frame update
    void Start()
    {
        SpriteR.sprite = costume.FrontSprite;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
