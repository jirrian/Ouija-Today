﻿using UnityEngine;
using System.Collections;

public class finderMovement : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(Input.acceleration.x * 0.3f, Input.acceleration.y * 0.3f, 0);
	}
}
