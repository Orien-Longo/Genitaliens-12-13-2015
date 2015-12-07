using UnityEngine;
using System.Collections;

public class OBJ_Interactable : MonoBehaviour {


	
	void Start () {
	
	}
	
	void Update () {


	}

	void Send_Dectected(){
		this.SendMessage ("Detected");
	}

	void Send_Activate(){
		this.SendMessage ("Activate");
	}



}
