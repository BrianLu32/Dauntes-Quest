using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftAndRight : MonoBehaviour
{
    private Vector3 MovingDirection = Vector3.right;
    public int xmin;
    public int xmax;
    private float speed = 200.0f;

    void Update()
    {
        gameObject.transform.Translate(MovingDirection * Time.deltaTime * speed);

        if (gameObject.transform.position.x > xmax)
        {
            MovingDirection = Vector3.left;
            if(transform.localScale.x < 0.0f)
            {
                Flip();
            }
        }
        else if (gameObject.transform.position.x < xmin)
        {
            MovingDirection = Vector3.right;
            Flip();
        }
    }

    public Vector3 GetDirection()
    {
        return MovingDirection;
    }

    void Flip()
    {
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
}
