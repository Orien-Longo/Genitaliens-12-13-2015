using UnityEngine;
using System.Collections;

public class Player_Follow : MonoBehaviour {

	public GameObject player, camera1;
	public Vector3 pivot, centerPoint, currentPos, playerPos;
	public float div = 10.0f;


	void Start () {
		centerPoint = new Vector3 (0, 0, 0);

	}
	

	void Update () {
		Cursor.visible = false;
		this.transform.LookAt (centerPoint);
		playerPos = player.transform.position;
		camera1.transform.position = new Vector3 (playerPos.x / 10, playerPos.y / 10, -10);

		/*currentPos = camera.transform.position;
		playerPos = player.transform.position;
		pivot = new Vector3 (playerPos.x / 10, playerPos.y / 10, -10);
		//this.transform.position = pivot;
		if (camera.transform.position.x > player.transform.position.x) {
			camera.transform.position.x += .01f;
		} else if (camera.transform.position.x < player.transform.position.x) {
			camera.transform.position.x -= .01f;
		}*/

	}
}
