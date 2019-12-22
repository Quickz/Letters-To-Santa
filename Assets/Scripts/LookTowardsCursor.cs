using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookTowardsCursor : MonoBehaviour
{
    private void Update()
    {
        LookAtCursor();
        ConstrainAngle();
    }

    private void LookAtCursor()
    {
        transform.up = new Vector2(
            Input.mousePosition.x - transform.position.x,
            Input.mousePosition.y - transform.position.y);
    }

    private void ConstrainAngle()
    {
        if (transform.eulerAngles.z > 160f && transform.eulerAngles.z < 270f)
        {
            transform.eulerAngles = new Vector3(
                transform.eulerAngles.x,
                transform.eulerAngles.y,
                160f);
        }
        else if (transform.eulerAngles.z < 20f || transform.eulerAngles.z > 270f)
        {
            transform.eulerAngles = new Vector3(
                transform.eulerAngles.x,
                transform.eulerAngles.y,
                20f);
        }
    }
}
