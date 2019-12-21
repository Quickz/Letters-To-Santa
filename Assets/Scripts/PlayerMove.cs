using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float Hmove = Input.GetAxis("Horizontal");
        float Vmove = Input.GetAxis("Vertical");

        Vector2 move = new Vector2(Hmove,Vmove);

        transform.Translate(move * speed * Time.deltaTime);
    }
}
