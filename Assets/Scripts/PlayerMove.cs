using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed;
    float _posX;
    float direction = 1;
    float someScale;
    // Start is called before the first frame update
    void Start()
    {
        _posX = transform.position.x;
        transform.localScale = new Vector2(-transform.localScale.x, transform.localScale.y);
        someScale = transform.localScale.x;
    }

    // Update is called once per frame
    void Update()
    {
        float Hmove = Input.GetAxis("Horizontal");
        float Vmove = Input.GetAxis("Vertical");

        Vector2 move = new Vector2(Hmove,Vmove);
        
        transform.Translate(move * speed * Time.deltaTime);

            Debug.Log("Moving left - " + transform.position.x);
            if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            {
                transform.localScale = new Vector2(-someScale, transform.localScale.y);
                direction = -1;
            }
     
            Debug.Log("Moving right - " + transform.position.x);
            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            {
                transform.localScale = new Vector2(someScale, transform.localScale.y);
                direction = 1;
            }
        
    }
}
