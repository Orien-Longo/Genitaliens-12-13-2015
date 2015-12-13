using UnityEngine;
using System.Collections;

public class elevateMe : MonoBehaviour
{


    public GameObject player;

    // public Vector3 pos1, pos2, pos3;

    public Transform startPoint, endPoint;

    public bool rider, goingUp, atStart, atEnd;

    //int p = 3;

    float x, y, z;

    public float speed = .01F;
    //private float startTime;
    //private float journeyLength1, journeyLength2, journeyLength3, journeyLength4, ePosY;
    //private Vector2 ePos;


    void Start()
    {

        //ePos = gameObject.transform.position;
        //ePosY = gameObject.transform.position.y;



        //startTime = Time.time;

        //x = -7.583f;
        //z = 0f;

        //pos1 = new Vector3(x, 0.082f, z);
        //pos2 = new Vector3(x, -2.50f, z);
        //pos3 = new Vector3(x, 4.75f, z);

        //journeyLength1 = Vector3.Distance(pos1, pos2);
        //journeyLength2 = Vector3.Distance(pos2, pos3);
        //journeyLength3 = Vector3.Distance(pos3, pos2);
        //journeyLength4 = Vector3.Distance(pos2, pos1);

        ////StartCoroutine (RideOn());

        //rider = false;
        //goingUp = true;
        //atStart = true;
        //atEnd = false;

    }


    void Update()
    {




        if (rider && goingUp && !atEnd)
        {
            StartCoroutine(Up(1f));
        }

        if ((!atStart && !goingUp) || !rider)
        {
            StartCoroutine(Down(1f));
        }
        //if (!rider && transform.position.y < (player.transform.position.y - (player.transform.position.y - endPoint.position.y)))
        //{
        //    //if (transform.position.y < endPoint.position.y)
        //    transform.Translate(Vector2.up * speed * Time.smoothDeltaTime);
        //    goingUp = false;
        //    atEnd = true;
        //    atStart = false;
        //}





    }

    void OnTriggerStay2D(Collider2D other)
    {

        if (other.CompareTag("Player"))
        {
            other.transform.parent = transform;

            rider = true;

        }


    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            other.transform.parent = null;
            goingUp = false;
            atEnd = true;
            rider = false;

        }
    }

    IEnumerator WaitASec(float secs)
    {
        yield return new WaitForSeconds(secs);


    }
    IEnumerator Up(float secs)
    {
        yield return new WaitForSeconds(secs);
        if (!atEnd && rider)
        {


            if (Input.GetKey(KeyCode.W) || Input.GetAxis("Vertical") > 0 )
            {
                transform.Translate(Vector2.up * speed * Time.smoothDeltaTime );
            }

            if (gameObject.transform.position.y >= endPoint.position.y)
            {
                //transform.position = endPoint.position;
                goingUp = false;
                atEnd = true;
                atStart = false;
            }
            else
            {
                //if (transform.position.y < endPoint.position.y)
                transform.Translate(Vector2.up * speed * Time.smoothDeltaTime);
                goingUp = false;
                atEnd = true;
                atStart = false;
            }
        }
        


    }
    IEnumerator Down(float secs)
    {
        yield return new WaitForSeconds(secs);
        if (!atStart)
        {
            if ((Input.GetKey(KeyCode.S) || Input.GetAxis("Vertical") < 0 )&& gameObject.transform.position.y > startPoint.position.y)
            {
                transform.Translate(Vector2.down * speed * Time.smoothDeltaTime);
            }

            if (gameObject.transform.position.y < startPoint.position.y)
            {
                gameObject.transform.position = startPoint.position;
                atStart = true;
                goingUp = true;
                atEnd = false;
            }

        }
        yield return new WaitForSeconds(2f);

    }



}
