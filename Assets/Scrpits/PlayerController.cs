using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	Rigidbody rb;
	public float speed = 5.0f;

	void Start () 
	{
		rb = GetComponent<Rigidbody> ();

	}
		
	void Update () 
	{
		if (Input.GetKey (KeyCode.RightArrow)) 
		{
			rb.velocity = transform.right * speed; 
		}
		if (Input.GetKey(KeyCode.LeftArrow))
		{
			rb.velocity = -transform.right * speed;
		}
	}
}
