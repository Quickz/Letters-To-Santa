using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed;
    float _posX;
    float direction = 1;
    float someScale;
    public Rigidbody2D rb;
    Vector2 Movemnt;
    public Grab g;
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
        Movemnt.x = Input.GetAxisRaw("Horizontal");
        Movemnt.y = Input.GetAxisRaw("Vertical");
            
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.localScale = new Vector2(-someScale, transform.localScale.y);
            direction = -1;
        }
     
          
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.localScale = new Vector2(someScale, transform.localScale.y);
            direction = 1;
        }
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + Movemnt * speed * Time.deltaTime);
    }
}
