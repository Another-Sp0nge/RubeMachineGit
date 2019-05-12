using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	private Rigidbody rb;
	public float speed = 5.0f;

	void Start () 
	{
		rb = GetComponent<Rigidbody> ();

	}
		
	void Update () 
	{
		float movehorizontal = Input.GetAxis ("Horizontal");
		float movevertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (movehorizontal, 0, movevertical);
		rb.AddForce (movement * speed);
	}
}
