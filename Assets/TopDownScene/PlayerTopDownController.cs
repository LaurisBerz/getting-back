using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTopDownController : MonoBehaviour {

    public float playerSpeed = 8f;

    private Rigidbody playerRigidbody;
    private Vector3 movement;

	void Start () {
        playerRigidbody = GetComponent<Rigidbody>();
	}
	
	void Update () {
        movement = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")) * playerSpeed * Time.deltaTime;

        playerRigidbody.transform.Translate(movement);
        Debug.Log(movement);
	}
}
