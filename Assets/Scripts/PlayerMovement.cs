using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody rigidBody;
    public float forwardVelocity;
    public float sidewaysVelocity;
    public float fallLimit;

	// Use this for initialization
	void Start () {

	}

    void Update() {
        if (Input.GetKey("d") || Input.GetKey("right"))
            rigidBody.AddForce(sidewaysVelocity * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

        if (Input.GetKey("a") || Input.GetKey("left"))
            rigidBody.AddForce(-1 * sidewaysVelocity * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

    }

    // Update function used to calculate physics
    void FixedUpdate() {
        rigidBody.AddForce(0, 0, forwardVelocity * Time.deltaTime, ForceMode.VelocityChange);

        if(rigidBody.position.y < fallLimit) {
            FindObjectOfType<LevelManager>().EndGame();
        }
    }
}
