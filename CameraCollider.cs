using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCollider : MonoBehaviour {

    public Vector3 CameraPosition;
	
    private void OnTriggerEnter(Collider collision)
    {
        Camera.main.transform.position = CameraPosition;
    }
}
