using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    private Player player;
    private Vector3 cameraPosition;
    private Vector3 cameraError;

    private void Start()
    {
        player = FindObjectOfType<Player>();
        if (player == null)
        {
            Debug.LogError("Unable to find player instance");
        }
    }

    private void FixedUpdate()
    {
        if (player != null)
        {
            cameraError = player.transform.position - cameraPosition;
            cameraPosition += cameraError * Time.fixedDeltaTime * (cameraError.magnitude - 9);
            cameraPosition.z = -10;
            gameObject.transform.position = cameraPosition;
        }
    }
}
