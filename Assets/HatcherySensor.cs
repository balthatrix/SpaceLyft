﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HatcherySensor : MonoBehaviour {


	public MiteHatchery owner;
	void OnTriggerEnter2D(Collider2D other) {

		//		Debug.Log ("something came close to a hatchery: " + other.name);
		if (other.CompareTag ("Player")) {
			Debug.Log ("player is now in vicinity");
			owner.playerInVicinity = true;
		}
	}

	void OnTriggerExit2D(Collider2D other) {
		//		Debug.Log ("something left proximity to hatchery: " + other.name);
		if (other.CompareTag ("Player")) {
			Debug.Log ("player is now out of vicinity");
			owner.playerInVicinity = false;
		}
	}
}
