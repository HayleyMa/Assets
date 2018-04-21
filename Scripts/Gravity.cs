using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour {
    private bool reversed = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if(reversed == false)
            {
                Physics2D.gravity = new Vector2(0, 1.0F);
                reversed = true;
            }
            else if(reversed == true)
            {
                Physics2D.gravity = new Vector2(0, -1.0F);
                reversed = false;
            }
        }
	}
}
