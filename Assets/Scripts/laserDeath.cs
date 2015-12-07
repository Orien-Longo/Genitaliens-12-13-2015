using UnityEngine;
using System.Collections;

public class laserDeath : MonoBehaviour
{

    public GameObject burnt, player;

    public GameObject[] bodies;

    public Component[] colliders;



    void Start()
    {

    }


    void Update()
    {
        bodies = GameObject.FindGameObjectsWithTag("Corpse");
        if (bodies.Length == 1)
        {
            foreach (GameObject body in bodies)
            {

                DestroyObject(body, 3f);
                bodies = null;
            }
        }
        else { bodies = null; }

    }

    void OnTriggerEnter2D(Collider2D otherother)
    {
        if (otherother.name == "Human")
        {
            StartCoroutine(Trigger2D(player.GetComponent<Collider2D>()));
        }
    }

    IEnumerator Trigger2D(Collider2D other)
    {

        yield return null;

        bodies = GameObject.FindGameObjectsWithTag("Corpse");


        float xrot = 0;
        float yrot = Random.Range(-45f, 45f);
        float zrot = Random.Range(-45f, 45f);
        Quaternion allrot = Quaternion.Euler(xrot, yrot, zrot);

        if (bodies.Length < 1)
        {

            //if (other.name == "Human" && this.enabled == true)
            //{

            other.GetComponent<Renderer>().enabled = false;
            other.GetComponent<playerMove>().enabled = false;
            other.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeAll;



            colliders = other.GetComponents<Collider2D>();
            foreach (Collider2D collider in colliders) { collider.enabled = false; }

            Instantiate(burnt, new Vector3(player.transform.localPosition.x, player.transform.localPosition.y, player.transform.localPosition.z), allrot);

            //bodies = GameObject.FindGameObjectsWithTag("Corpse");

            yield return new WaitForSeconds(3f);



            //Application.LoadLevel(0);

            other.transform.position = new Vector3(-5.93f, 3.291f, -0.07f);
            other.GetComponent<Renderer>().enabled = true;
            other.GetComponent<playerMove>().enabled = true;
            foreach (Collider2D collider in colliders) { collider.enabled = true; }
            other.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.None;
            other.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeRotation;
            

            //}



        }
    }
}
