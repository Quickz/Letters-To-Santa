using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using UnityEngine;

[CreateAssetMenu(
    fileName = "New Costume",
    menuName = "Scripable Object/Costume")]
public class Costume : ScriptableObject
{
    public string ID => id;
    public Sprite FrontSprite => frontSprite;
    public int Price => price;

    public ReadOnlyCollection<Effect> Effects => effects.AsReadOnly();

    [SerializeField]
    private string id = Guid.NewGuid().ToString();

    [SerializeField]
    private Sprite frontSprite = null;

    [SerializeField]
    private List<Effect> effects = null;

    [SerializeField]
    private int price = 50;
}
