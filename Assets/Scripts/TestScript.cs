using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    [SerializeField]
    private float speed = 5f;

    private new Rigidbody2D rigidbody;

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        float moveX = 0f;
        float moveY = 0f;

        if (Input.GetKey(KeyCode.D))
        {
            moveX = 1f;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            moveX = -1f;
        }

        if (Input.GetKey(KeyCode.W))
        {
            moveY = 1f;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            moveY = -1f;
        }

        rigidbody.velocity = new Vector2(moveX * speed, moveY * speed);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("collision");
    }
}
