using UnityEngine;
using System.Collections;

public class StartWHenNear : MonoBehaviour {

	public GameObject arc1, arc2, player;

	public bool triggered;

	void start(){
		triggered = false;
		arc1.SetActive (false);
		arc2.SetActive (false);

	}

	void OnTriggerEnter2D(Collider2D other){

		if(other.name == "Human" && triggered == false){

			arc1.SetActive(true);
			arc2.SetActive(true);
			triggered = true;
		}
	}

}
