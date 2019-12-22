using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(
    fileName = "New Inventory",
    menuName = "Scripable Object/Inventory")]
public class Inventory : ScriptableObject
{
    public List<Costume> costumes = new List<Costume>();
}
