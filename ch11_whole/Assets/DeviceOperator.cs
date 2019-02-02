﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeviceOperator : MonoBehaviour {
	public float radius = 1.5f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Fire3")) {
			Collider[] hitColliders = Physics.OverlapSphere (transform.position, radius);
			foreach (Collider hitCollider in hitColliders) {
				hitCollider.SendMessage ("Operate", SendMessageOptions.DontRequireReceiver);
			}
		}
	}
}
