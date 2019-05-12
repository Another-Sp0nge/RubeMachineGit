using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReleaseSwing : MonoBehaviour {

	public GameObject DestroyTarget;

	void OnTriggerEnter (Collider other)
	{
		Destroy (DestroyTarget);
	}
}
