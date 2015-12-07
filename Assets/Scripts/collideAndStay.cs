using UnityEngine;
using System.Collections;

public class collideAndStay : MonoBehaviour {


	//public GameObject player;
	//public Component rigid2d;
	//public Component col2d;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D (Collider2D other){

		if (other.name == "Human") {
			this.GetComponent <BoxCollider2D> ().enabled = false;
			this.GetComponent <CircleCollider2D> ().enabled = false;
			gameObject.GetComponent <Rigidbody2D>().isKinematic = true;
		}
	}
}
