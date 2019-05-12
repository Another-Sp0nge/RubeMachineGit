using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour {

	public Transform TeleportExit;
	public GameObject PlayerSphere;

	void OnTriggerEnter (Collider other)
	{
		PlayerSphere.transform.position = TeleportExit.transform.position;
	}
}
