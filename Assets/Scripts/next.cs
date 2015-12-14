using UnityEngine;
using System.Collections;

public class next : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnTriggerEnter2D() { Application.LoadLevel(2); }
}
