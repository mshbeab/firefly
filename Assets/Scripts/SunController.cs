﻿using UnityEngine;
using System.Collections;

public class SunController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void onTriggerEnter(Collider coll) {
		Debug.Log ("You winnn");
		if (coll.gameObject.tag == "Player")
			Application.LoadLevel (1);
	} 
}
