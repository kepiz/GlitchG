﻿using UnityEngine;
using System.Collections;

public class shredder : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other){
		Destroy (other.gameObject);
	}
}
