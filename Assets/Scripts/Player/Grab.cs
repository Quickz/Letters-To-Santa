using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Grab : MonoBehaviour
{
    [SerializeField]
    private float radius = 1f;
    [SerializeField]
    private Transform holdingPoint = null;

    private DroppingLetter letter;

    private DroppingLetter ClosestNearbyLetter => Physics2D
        .OverlapCircleAll(holdingPoint.position, radius)
        .Select(x => x.GetComponent<DroppingLetter>())
        .Where(x => x != null)
        .OrderBy(x => Vector2.Distance(x.transform.position, holdingPoint.transform.position))
        .FirstOrDefault();

    private void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            if (letter == null)
            {
                letter = ClosestNearbyLetter;
            }

            if (letter != null)
            {
                letter.transform.position = holdingPoint.position;
            }
        }
        else
        {
            letter = null;
        }
    }

    private void OnDrawGizmos()
    {
        if (holdingPoint != null)
        {
            if (letter == null)
            {
                Gizmos.color = Color.red;
            }
            else
            {
                Gizmos.color = Color.green;
            }

            Gizmos.DrawWireSphere(holdingPoint.position, radius);
        }
    }
}
