﻿using UnityEngine;
using System.Collections;

public class ToLevel2 : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnTriggerEnter(){
		Application.LoadLevel (0);
		
	}
}
