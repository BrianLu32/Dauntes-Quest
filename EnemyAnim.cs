using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAnim : MonoBehaviour
{

    public Animator anim;
    public UpAndDown cont;

    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(cont.GetDirection() == Vector3.up)
        {
            anim.SetBool("Up", true);
        }
        else if(cont.GetDirection() == Vector3.down)
        {
            anim.SetBool("Up", false);
        }
    }
}
