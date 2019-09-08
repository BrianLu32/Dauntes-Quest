using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class SceneEnd : MonoBehaviour {

    public Animator anim;
    private bool Loading = false;
    private float atLoading = 34.5f;
    private float atLoad;

    void Start()
    {
        atLoad = Time.time + atLoading;
        Loading = true;
    }
    // Update is called once per frame
    void Update () {
		if(anim.GetCurrentAnimatorStateInfo(0).IsName("lease"))
        {
            if(Loading && Time.time > atLoad)
            {
                SceneManager.LoadScene("Instructions");
                Loading = false;
            }
        }
	}
}
