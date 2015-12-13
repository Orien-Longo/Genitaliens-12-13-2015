using UnityEngine;
using System.Collections;

public class mover : MonoBehaviour
{

    float speed = 2f;
    bool wallSwitch = false;
    Vector2 move;
    public GameObject scalePoint;

    // Use this for initialization
    void Start()
    {
        move = Vector2.right;


    }

    // Update is called once per frame
    void Update()
    {
        //Component[] laserparts;
        //laserparts = gameObject.GetComponentsInChildren<Transform>();
        //Transform STAY = gameObject.GetComponent<Transform>();
        //transform.position = STAY.position;

        //foreach (Transform trans in laserparts)
        //{
        //    if (trans.CompareTag( "Red Laser"))
        //    {
        //        move = Vector2.up;
        //        trans.transform.Translate(move * speed * Time.smoothDeltaTime); 
        //    }
        //    else /*if (!trans.CompareTag("Red Laser"))*/
        //    {
        //        move = Vector2.right;
        //        trans.transform.Translate(move * speed * Time.smoothDeltaTime);
        //    }

        //}11.67 22.75
        transform.Translate(move * speed * Time.smoothDeltaTime);
        if (transform.position.x >= 22.75f && transform.localScale.x > 0)
        {
            move = Vector2.left;
            float xScale = scalePoint.transform.localScale.x;
            transform.localScale = new Vector3(-xScale, 1f, 1f);
        }
        else if (transform.position.x <= 11.67f && transform.localScale.x < 0)
        {
            move = Vector2.right;
            float xScale = scalePoint.transform.localScale.x;
            transform.localScale = new Vector3(xScale, 1f, 1f);
        }




    }

    //void OnTriggerEnter2D(Collider2D other)
    //{
    //    if (other.CompareTag("Wall"))
    //    {
    //        Debug.Log(wallSwitch);

    //        wallSwitch = !wallSwitch;
    //    }
    //}

}
