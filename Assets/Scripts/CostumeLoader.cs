using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CostumeLoader : MonoBehaviour
{
    [SerializeField]
    private SpriteRenderer costumeSpriteRenderer;

    private void Start()
    {
        if (EquipedCostumeManager.EquipedCostume != null)
        {
            costumeSpriteRenderer.sprite = EquipedCostumeManager.EquipedCostume.FrontSprite;
        }
    }
}
