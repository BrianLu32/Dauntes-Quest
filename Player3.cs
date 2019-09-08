using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player3 : MonoBehaviour
{

    public Animator anim;
    public Control3 cont;

    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (cont.getVelocityX() > 0)
        {
            anim.SetBool("IsMovingRight", true);
            anim.SetBool("IsMovingLeft", false);
        }
        else if (cont.getVelocityX() < 0)
        {
            anim.SetBool("IsMovingLeft", true);
            anim.SetBool("IsMovingRight", false);
        }
        else if (cont.getVelocityX() == 0)
        {
            anim.SetBool("IsMovingRight", false);
            anim.SetBool("IsMovingLeft", false);
        }
        if (cont.getVelocityY() > 0)
        {
            anim.SetBool("IsMovingUp", true);
            anim.SetBool("IsMovingDown", false);
        }
        else if (cont.getVelocityY() < 0)
        {
            anim.SetBool("IsMovingUp", false);
            anim.SetBool("IsMovingDown", true);
        }
        else if (cont.getVelocityY() == 0)
        {
            anim.SetBool("IsMovingUp", false);
            anim.SetBool("IsMovingDown", false);
        }
    }
}
