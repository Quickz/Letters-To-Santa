using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using UnityEngine;

[CreateAssetMenu(
    fileName = "New Costume",
    menuName = "Scripable Object/Costume")]
public class Costume : ScriptableObject
{
    public Sprite FrontSprite => FrontSprite;

    public ReadOnlyCollection<Effect> Effects => effects.AsReadOnly();

    [SerializeField]
    private Sprite frontSprite = null;

    [SerializeField]
    private List<Effect> effects = null;
}
