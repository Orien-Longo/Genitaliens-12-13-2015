using UnityEngine;
using System.Collections;

public class rayTest2D : MonoBehaviour
{
    private LineRenderer lineRenderer;
    public Transform laserHit, drawFrom, laser, human;
    float lYPos, lXPos, hitY, scaleRatio, xScale;
    private Transform newLaser;
    private Ray2D rayBan;
    RaycastHit2D rayBanHit;

    void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
        lineRenderer.enabled = true;
        lineRenderer.useWorldSpace = true;
        
        scaleRatio = 1.9f;
        


    }


    void Update()
    {
        lXPos = laser.position.x;
        lYPos = laser.position.y;
        RaycastHit2D hit = Physics2D.Raycast(drawFrom.position, -transform.up);
        Physics2D.IgnoreCollision(hit.collider, laser.GetComponent<Collider2D>());

        //Physics2D.IgnoreCollision(hit.collider, human.transform.GetComponent<BoxCollider2D>(), true);



        Debug.DrawLine(drawFrom.position, hit.point);
        laserHit.position = hit.point;
        lineRenderer.SetPosition(0, transform.position);
        lineRenderer.SetPosition(1, hit.point);
        hitY = Vector3.Distance(drawFrom.position, hit.point);
        lYPos = hit.point.y + hitY / 2;
        laser.position = new Vector3(lXPos, lYPos, -0.2830469f);
        xScale = (hitY / 2) * scaleRatio;
        laser.localScale = new Vector3(xScale, laser.localScale.y, laser.localScale.z);


    }
    //void OnTriggerEnter2D(Collider2D other)
    //{
    //    if (other.transform.GetComponent<BoxCollider2D>().name == ("Human"))
    //    {
    //        Physics2D.IgnoreCollision(rayBanHit.collider, other.transform.GetComponent<BoxCollider2D>(), true);
            
    //    }
        
    //        //Physics2D.IgnoreCollision(rayBanHit.collider, other.transform.GetComponent<BoxCollider2D>(), false);

        


    //}


}
