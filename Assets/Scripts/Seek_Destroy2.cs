using UnityEngine;
using System.Collections;

public class Seek_Destroy2 : MonoBehaviour {

	private float rSpeed, distDif;
	public GameObject player, robot;
	public Vector3 playerPos, robotPos;
	bool isFacing;


	void Start () {
		//rSpeed = 1.0f;

	}
	
	// Update is called once per frame
	void Update () {
		//robotPos.z = -0.357f;
		//robotPos.y = 3.6f;

		//playerPos = new Vector3 (player.transform.position.x,player.transform.position.y,0f);
		//robotPos = new Vector3 (robot.transform.position.x, robot.transform.position.y, this.transform.position.z);
		//this.transform.LookAt (playerPos);
		//distDif = (player.transform.position.x - robot.transform.position.x);
		//Debug.Log (distDif);
		//transform.position += transform.forward * rSpeed * Time.deltaTime;
		//transform.position += transform.right * rSpeed;

	}

	void OnCollisionEnter2d (Collision2D col){

		//if (col.name = 


	}

}
