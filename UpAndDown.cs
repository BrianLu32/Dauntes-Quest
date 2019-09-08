using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpAndDown : MonoBehaviour {
    private Vector3 MovingDirection = Vector3.up;
    public int ymin;
    public int ymax;
    private float speed = 200.0f;

    void Update()
    {
        gameObject.transform.Translate(MovingDirection * Time.deltaTime * speed);

        if (gameObject.transform.position.y > ymax)
        {
            MovingDirection = Vector3.down;
        }
        else if (gameObject.transform.position.y < ymin)
        {
            MovingDirection = Vector3.up;
        }
    }

    public Vector3 GetDirection()
    {
        return MovingDirection;
    }
}
