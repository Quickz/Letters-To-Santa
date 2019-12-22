using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow_Player : MonoBehaviour
{
    public GameObject Player;
    Vector3 CamPosition;
    Vector3 CamError;
    [SerializeField]
    float CamErrorMag;
    [SerializeField]
    private float CamSpeed = 5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CamError = Player.transform.position - CamPosition;
        CamErrorMag = CamError.magnitude;
        CamPosition += (CamError) * Time.deltaTime * (CamErrorMag - 9);
        CamPosition.z = -10;
        gameObject.transform.position = CamPosition;
    }
}
