using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collect : MonoBehaviour {

    public Animator Leaf;
    public Control cont;

	// Use this for initialization
	void Start () {
        Leaf = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
		if(cont.getCount() == 0)
        {
            Leaf.SetBool("Empty", true);
        }
        else if(cont.getCount() == 1)
        {
            Leaf.SetBool("One Third", true);
        }
        else if (cont.getCount() == 2)
        {
            Leaf.SetBool("Two Thirds", true);
        }
        else if (cont.getCount() == 3)
        {
            Leaf.SetBool("Full", true);
        }
    }
}
