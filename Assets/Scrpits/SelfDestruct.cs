using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestruct : MonoBehaviour {

	public GameObject chamber;

	void OnTriggerEnter()
	{
		Destroy (chamber, 5f);
	}
}
