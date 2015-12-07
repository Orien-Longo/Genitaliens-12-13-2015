using UnityEngine;
using System.Collections;

public class Scale_And_Power : MonoBehaviour
{

    private Collider2D beamCol;
    public Ray2D laserTip;
    Renderer beamVis;



    public Vector2 beamStart, beamHit/*, beamArrive, beamLeave*/;

    //float scalePosX, scalePosY;

    public float xScale, newScale, yPos, newY, scaleRatio, moveSpeed;

    private GameObject redLaser;

    bool on;


    void Start()
    {
        redLaser = this.gameObject;
        //moveSpeed = 5f;
        xScale = redLaser.transform.localScale.x;
        newScale = .925f;
        yPos = redLaser.transform.localPosition.y;
        newY = .5f;
        beamVis = redLaser.gameObject.GetComponent<Renderer>();
        beamCol = redLaser.GetComponent<BoxCollider2D>();

        //beamStart = new Vector2();
        //beamHit = hit.transform.localPosition;        

        // if  a/(x + 1) = ay - 1, y = 1 and x = 0, and when y = .5, x = (y-1) (-1.85), and when y = 0, x = 1.85, what is the ratio?
        //     .5a - 1 = .925
        //     .5a = 1.925
        //       a = 1.925/.5
        //       a = 3.85

        //      3.85x - 1 = 0 

        StartCoroutine(PowerDown());
    }


    void FixedUpdate()
    {        

        //float rayL = xScale;

        //Vector2 lasPos = GetComponent<Vector2>();

        //beamStart.y = lasPos.y + (lasPos.y / 2);
        //beamStart.x = transform.position.x;

        //Ray2D lRay = new Ray2D(beamStart, Vector3.down);

        //RaycastHit2D hit = Physics2D.Raycast(beamStart, Vector2.down, rayL);

        //if (hit.collider != null)
        //{

        //    transform.position = beamStart + (hit.point/2);

        //}
        
        //if (on)
        //{
        //    scaleRatio = -1.85f;
        //    xScale = scaleRatio * (yPos - 1);

        //}
        //else
        //{
        //    scaleRatio = 1.85f;
        //    xScale = scaleRatio * (yPos + 1);


        //}
    }

    void OnCollisionEnter2D(Collision2D other)
    {

        if (other.gameObject.GetComponent<BoxCollider2D>()/*.CompareTag("Green Laser")*/)
        {
            Debug.Log("hit");
            redLaser.transform.localScale = new Vector3(newScale, redLaser.transform.localScale.y, redLaser.transform.localScale.z);
        }


    }


    IEnumerator PowerDown()
    {
        //float waitTime;
        //waitTime = Time.deltaTime * moveSpeed;
        Component[] childRends;
        Component[] childLights;
        childRends = beamVis.GetComponentsInChildren<Renderer>();
        childLights = beamVis.GetComponentsInChildren<Light>();

        //beamArrive = (beamStart - beamHit) / 2;

        yield return new WaitForSeconds(1f);
        on = false;

        //hit = Physics2D.Raycast(transform.position, -Vector2.up);
        //if (hit.collider != null){
        //    beamHit = hit.transform.position;
        //    transform.position = Vector2.Lerp(transform.position, beamArrive, .25f);
        yield return new WaitForSeconds(.25f);
        beamCol.enabled = false;
        beamVis.enabled = false;
        foreach (Renderer rend in childRends) { rend.enabled = false; }
        foreach (Light light in childLights) { light.enabled = false; }
        //}


        yield return new WaitForSeconds(2f);
        on = true;
        //transform.position = Vector2.Lerp(transform.position, beamHit, .25f);
        //yield return new WaitForSeconds(.25f);
        beamCol.enabled = true;
        beamVis.enabled = true;
        foreach (Renderer rend in childRends) { rend.enabled = true; }
        foreach (Light light in childLights) { light.enabled = true; }


        //xScale = 0f;

        //redLaser.transform.position = beamStart;

        StartCoroutine(PowerDown());

    }

}
