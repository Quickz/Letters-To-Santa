using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Belt : MonoBehaviour
{
    public GameObject belt;
    public Transform endpoint;
    public float speed;
    public Vector2 Direction;

    private void OnTriggerStay2D(Collider2D collision)
    {
        collision.transform.Translate(Direction * speed * Time.deltaTime);
    }
}
