using UnityEngine;
using System.Collections;

public class Blink : MonoBehaviour {

    public Quaternion openTop, openBot, blinkTop, blinkBot, eyeRot;
    public GameObject toplid, botlid, eyeball;
    float tXRot, bXRot, smooth = 4f;
    public bool isOpen;

	// Use this for initialization
	void Start () {
        eyeRot = eyeball.transform.localRotation;
        tXRot = toplid.transform.localRotation.x;
        bXRot = botlid.transform.localRotation.x;
        openTop = Quaternion.Euler(tXRot,270, 0);
        openBot = Quaternion.Euler(bXRot, 270, 180);
        //StartCoroutine(Open());
        isOpen = false;
	
	}
	
	// Update is called once per frame
	void Update () {
        if (!isOpen) { gameObject.GetComponent<UnityStandardAssets.Cameras.LookatTarget>().enabled = false; }
        //else { gameObject.GetComponent<UnityStandardAssets.Cameras.LookatTarget>().enabled = true; }

        if (GameObject.FindGameObjectWithTag("Player").GetComponent<playerMove>().naked)
        {
            StartCoroutine(Open());
        }
        else { StartCoroutine(Close()); }

        
    }

    IEnumerator Blinking() { yield return null; }

    IEnumerator Open() {

        yield return new WaitForSeconds(.25f);
        //eyeball.transform.localRotation = Quaternion.Slerp(eyeball.transform.localRotation, GameObject.FindGameObjectWithTag("The D").transform.LookAt(), Time.deltaTime * smooth);
        gameObject.GetComponent<UnityStandardAssets.Cameras.LookatTarget>().enabled = true;
        tXRot = 65f;
        bXRot = 295f;
        openTop = Quaternion.Euler(tXRot, 270, 0);
        openBot = Quaternion.Euler(bXRot, 270, 180);
        toplid.transform.localRotation = Quaternion.Slerp(toplid.transform.localRotation, openTop, Time.deltaTime * smooth);
        botlid.transform.localRotation = Quaternion.Slerp(botlid.transform.localRotation, openBot, Time.deltaTime * smooth);
        StartCoroutine(IsOpen());
    }

    IEnumerator Close()
    {
        yield return new WaitForSeconds(.25f);
        gameObject.GetComponent<UnityStandardAssets.Cameras.LookatTarget>().enabled = false;
        eyeball.transform.localRotation = Quaternion.Slerp(eyeball.transform.localRotation, eyeRot, Time.deltaTime * smooth);
        tXRot = 0f;
        bXRot = 0f;
        openTop = Quaternion.Euler(tXRot, 270, 0);
        openBot = Quaternion.Euler(bXRot, 270, 180);
        toplid.transform.localRotation = Quaternion.Slerp(toplid.transform.localRotation, openTop, Time.deltaTime * smooth);
        botlid.transform.localRotation = Quaternion.Slerp(botlid.transform.localRotation, openBot, Time.deltaTime * smooth);
        isOpen = false;
    }

    IEnumerator IsOpen()
    {
        yield return new WaitForSeconds(.2f); isOpen = true;
    }
}
