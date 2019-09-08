using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {

    public float speed = 100f; //set speed of character
    public Rigidbody rb;

    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.A))
        {
            //transform.position += Vector3.left * speed * Time.deltaTime;
            //rb.AddForce(Vector3.left * speed * Time.deltaTime);
            rb.velocity = Vector3.left * speed * Time.deltaTime;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            //transform.position += Vector3.right * speed * Time.deltaTime;
            rb.velocity = Vector3.right * speed * Time.deltaTime;
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            //transform.position += Vector3.up * speed * Time.deltaTime;
            rb.velocity = Vector3.up * speed * Time.deltaTime;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            //transform.position += Vector3.down * speed * Time.deltaTime;
            rb.velocity = Vector3.down * speed * Time.deltaTime;
        }

	}
}
