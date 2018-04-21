using Gamekit2D;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slow : MonoBehaviour {
    
    Rigidbody2D rb;
    private float speed;
    PlayerCharacter get = new PlayerCharacter();
    Animator anim;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {

        StartCoroutine(SlowTime());

    }

    //IEnumerator SlowTime()
    //{
    //    if (Input.GetKeyDown(KeyCode.W))
    //    {
    //        Time.timeScale = 0.5f;
    //        //get.maxSpeed = 2000f;
    //        rb.velocity *= 10;
    //        anim.speed = 40f;
    //        yield return new WaitForSeconds(5);
    //        Time.timeScale = 1f;
    //        get.maxSpeed = 10f;
    //        anim.speed = 1f;
    //    }
    //}
}
