using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(
    fileName = "New Debug Log Effect",
    menuName = "Scripable Object/Effects/Debug Log")]
public class DebugLogEffect : Effect
{
    [SerializeField]
    private string message = string.Empty;

    public override void Apply(PlayerMove player)
    {
        Debug.Log($"Appling an effect to {player.name}", player.gameObject);
        Debug.Log(message);
    }
}
