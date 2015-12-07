using UnityEngine;
using System.Collections;

public class Scroll : MonoBehaviour {

	//public float rotateSpeed = 0.5f;
	public float scrollSpeed = .1f;
	public float offset;

	//public float rotate;
	public Renderer rend;

	void Start(){
	
		rend = GetComponent<Renderer> ();
		offset = 0;
	
	}
	
	void Update () {



		/*Quaternion rot = transform.rotation;
		float y = rot.eulerAngles.y;
		y += rotateSpeed * Time.deltaTime;
		rot = Quaternion.Euler (y,y,y);
		transform.rotation = rot;*/

		offset = (Time.time * scrollSpeed)/10000;
		rend.material.mainTextureOffset =  new Vector2(offset,0);
	}

//	void SetTextureOffset(string propertyName, Vector2 value, int coord); 
}
