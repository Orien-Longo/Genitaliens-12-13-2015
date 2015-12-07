using UnityEngine;
using System.Collections;

public class elevateMe : MonoBehaviour {


	public GameObject player;

	public Vector3 pos1,pos2,pos3;

	bool rider, goingUp;

	//int p = 3;

	float x,y,z;

	public float speed = 1.0F;
	private float startTime;
	private float journeyLength1,journeyLength2,journeyLength3,journeyLength4;

	void Start () {



		startTime = Time.time;

		x = -7.583f;
		z = 0f;

		pos1 = new Vector3 (x, 0.082f, z);
		pos2 = new Vector3 (x, -2.50f, z);
		pos3 = new Vector3 (x, 4.75f, z);

		journeyLength1 = Vector3.Distance (pos1, pos2); 
		journeyLength2 = Vector3.Distance (pos2, pos3);
		journeyLength3 = Vector3.Distance (pos3, pos2);
		journeyLength4 = Vector3.Distance (pos2, pos1);

		//StartCoroutine (RideOn());

		rider = false;
		goingUp = false;
	
	}
	

	void Update () {
		



	
	
	}

	void OnTriggerEnter2D(Collider2D other){

		if (other.name == "Human") {
			rider = true;
		//	StartCoroutine (RideOn());
		} else {
			rider = false;
		}

	}

	/*IEnumerator RideOn(float distCovered, float fracJourney){
	
		int p = 3;

		if (goingUp == false){
			yield return new WaitForSeconds(2.5f);
			if(rider == true && p > 0){
				for(p == 3; y > pos2.y; y -= Time.deltaTime/fracJourney){
					Vector3 newVec
					yield return new WaitForSeconds(2.5f);
					p--;

				}for (p == 2){

					p--;
					goingUp = true;
				}
			}
		}
	}*/

	void Journey1(){
		/*float distCovered = (Time.time - startTime) * speed;
		float fracJourney = distCovered / journeyLength1;
		for ( y > pos2.y; y -= Time.deltaTime/fracJourney ) {
			transform.position = Vector3.Lerp (pos1, (x,y,z) , fracJourney);
		}*/

		
	}


}
