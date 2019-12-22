using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow_Player : MonoBehaviour
{
    public GameObject Player;
    Vector3 CamPosition;
    Vector3 CamError;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        CamError = Player.transform.position - CamPosition;
        CamPosition += (CamError) * Time.fixedDeltaTime * (CamError.magnitude - 9);
        CamPosition.z = -10;
        gameObject.transform.position = CamPosition;
    }
}
