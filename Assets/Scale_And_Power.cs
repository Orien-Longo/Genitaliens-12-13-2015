using UnityEngine;
using System.Collections;

public class Scale_And_Power : MonoBehaviour
{

    private Collider2D beamCol;
    
    Renderer beamVis;

    private GameObject redLaser;


    void Start()
    {
        redLaser = this.gameObject;

        beamVis = redLaser.gameObject.GetComponent<Renderer>();
        beamCol = redLaser.GetComponent<BoxCollider2D>();

        StartCoroutine(PowerDown());
    }


    void FixedUpdate()
    {

    }



    IEnumerator PowerDown()
    {

        Component[] childRends;
        Component[] childLights;
        childRends = beamVis.GetComponentsInChildren<Renderer>();
        childLights = beamVis.GetComponentsInChildren<Light>();

        yield return new WaitForSeconds(1.75f);

        yield return new WaitForSeconds(.25f);
        beamCol.enabled = false;
        beamVis.enabled = false;
        foreach (Renderer rend in childRends) { rend.enabled = false; }
        foreach (Light light in childLights) { light.enabled = false; }

        yield return new WaitForSeconds(2f);
        beamCol.enabled = true;
        beamVis.enabled = true;
        foreach (Renderer rend in childRends) { rend.enabled = true; }
        foreach (Light light in childLights) { light.enabled = true; }


        StartCoroutine(PowerDown());

    }

}
