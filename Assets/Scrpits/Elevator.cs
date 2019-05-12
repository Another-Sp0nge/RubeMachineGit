using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator : MonoBehaviour {

	public GameObject Lift;

	void OnTriggerStay()
	{
		Lift.transform.position += Lift.transform.up * Time.deltaTime;
	}
}
