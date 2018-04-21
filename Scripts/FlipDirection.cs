using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipDirection : MonoBehaviour {
    Animator anim;
	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        float movement = Input.GetAxisRaw("Horizontal");
        if (movement == -1)
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }
        else if (movement == 1)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        bool walking = movement != 0;
        anim.SetBool("Move", walking);
    }
}
