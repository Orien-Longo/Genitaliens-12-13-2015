using UnityEngine;
using System.Collections;

public class rayTest2D : MonoBehaviour
{
    private LineRenderer lineRenderer;
    public Transform laserHit;
   
    void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
        lineRenderer.enabled = true;
        lineRenderer.useWorldSpace = true;

    }

    
    void Update()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.localPosition, -transform.right);
        Debug.DrawLine(transform.position, hit.point);
        laserHit.position = hit.point;
        lineRenderer.SetPosition(0, transform.localPosition);
        lineRenderer.SetPosition(1, hit.point);

    }
}
