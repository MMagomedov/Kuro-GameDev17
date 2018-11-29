using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {
		print("Hello World !!!");
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.touches.Length > 0) {
			print(Input.touches);
		}
	}
}
