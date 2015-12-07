using UnityEngine;
using System.Collections;

public class InstantiateOnDeath : MonoBehaviour {

	public GameObject burnt, suff, poke, tips;
	// Use this for initialization
	void Start () {

		GetComponent <playerMove>();
		GetComponent <teleport> ();
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown(KeyCode.E)) {
			Instantiate(burnt, transform.localPosition, transform.localRotation);
		}
	
	}
}
