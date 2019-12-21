using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Belt : MonoBehaviour
{
    public GameObject belt;
    public Transform endpoint;
    public float speed;

    private void OnTriggerStay2D(Collider2D collision)
    {
        collision.transform.Translate(Vector2.left * speed * Time.deltaTime);
    }
}
