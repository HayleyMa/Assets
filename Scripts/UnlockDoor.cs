using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockDoor : MonoBehaviour {
    public GameObject lockedDoor;
    public GameObject unlockedDoor;
    AudioSource lever;
	// Use this for initialization
	void Start () {
        lever = GetComponent<AudioSource>();
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        lever.Play();
        lockedDoor.SetActive(false);
        unlockedDoor.SetActive(true);
    }
    

    // Update is called once per frame
    void Update () {
		
	}
}
