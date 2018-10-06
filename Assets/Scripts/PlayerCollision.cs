﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour {

    public PlayerMovement movement;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    // Unity's collision function
    private void OnCollisionEnter(Collision collision) {
        if(collision.collider.tag == "Obstacle") {
            movement.enabled = false;
            FindObjectOfType<LevelManager>().EndGame();
        }
    }
}
