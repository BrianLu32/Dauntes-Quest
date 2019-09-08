using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAnimLR : MonoBehaviour
{

    public Animator anim;
    public LeftAndRight cont;

    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (cont.GetDirection() == Vector3.left)
        {
            anim.SetBool("Left", true);
        }
        else if (cont.GetDirection() == Vector3.right)
        {
            anim.SetBool("Left", false);
        }
    }
}
