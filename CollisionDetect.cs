using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetect : MonoBehaviour {

    public static bool Hit = false;
    public static Vector3 Wall = new Vector3(0, 0, 0);

    public void Awake()
    {
        Wall = new Vector3(0, 0, 0);
        Hit = false;
    }

    private void OnCollisionEnter(Collision collision)
    {
        ContactPoint contact = collision.contacts[0];
        Wall = contact.normal;
        Hit = true;
    }

    private void OnCollisionExit(Collision collision)
    {
        Hit = false;
    }
}
