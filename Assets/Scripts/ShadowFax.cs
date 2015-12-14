using UnityEngine;
using System.Collections;

public class ShadowFax : MonoBehaviour {

	public GameObject player;


	void Update ()
	{
		/*if(Input.GetKeyUp(KeyCode.T))
		{
			StartCoroutine(FadeTo(0.0f, 1.0f));
		}
		if(Input.GetKeyUp(KeyCode.F))
		{
			StartCoroutine(FadeTo(1.0f, 1.0f));
		}*/
	}
	
	IEnumerator FadeTo(float aValue, float aTime)
	{
		float alpha = transform.GetComponent<Renderer>().material.color.a;
		for (float t = 0.0f; t < 1.0f; t += Time.deltaTime / aTime)
		{
			Color newColor = transform.GetComponent<Renderer>().material.color;
			newColor.a = Mathf.Lerp(alpha,aValue,t);
			transform.GetComponent<Renderer>().material.color = newColor;
			yield return null;
		}
	}

	void OnTriggerEnter2D(Collider2D player){
		StartCoroutine(FadeTo(0.0f, 1.0f));
	}
}

// Referenced from: http://answers.unity3d.com/questions/225438/slowly-fades-from-opaque-to-alpha.html
