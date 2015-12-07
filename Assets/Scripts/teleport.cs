using UnityEngine;
using System.Collections;

public class teleport : MonoBehaviour {



	public GameObject player;
	public bool teleported;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D other){

		if (other.name == "Human" && this.enabled == true) {
			other.transform.position = new Vector3 (-5.93f, 3.291f,-0.07f);
			//teleported = true;
		}

	}
}
