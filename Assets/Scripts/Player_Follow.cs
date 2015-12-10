using UnityEngine;
using System.Collections;

public class Player_Follow : MonoBehaviour
{

    public GameObject player, camera1;
    public Vector3 pivot, centerPoint, currentPos, playerPos;
    public float div = 10.0f;
    bool facingRight = true;


    void Start()
    {


    }


    void Update()
    {
        //Cursor.visible = false;
        //this.transform.LookAt (centerPoint);
        player.GetComponent<Vector3>();
        playerPos = new Vector3 (player.transform.position.x, player.transform.position.y - 200, player.transform.position.z - 10);
        camera1.transform.position = Vector3.Lerp(gameObject.transform.position, (playerPos*10), Time.deltaTime);
        //if (Input.GetAxis("Horizontal") > 0 && !facingRight)
        //{
            
        //    gameObject.transform.localScale *= -1;
        //    facingRight = true;

        //}
        //else if (Input.GetAxis("Horizontal") < 0 && facingRight)
        //{
        //    gameObject.transform.localScale *= -1;
        //    facingRight = true;
        //}


        //camera1.transform.position = new Vector3 ();

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
