using UnityEngine;
using System.Collections;

public class playerMove : MonoBehaviour
{

    public float speed = 6.5f, sec;
    public string axisName = "Horizontal";
    public Animator anim;
    public bool naked, firstPress, active, death, on;
    public GameObject genitals, forcefield, robot, teleporter, gasbeast, conveyorbelt, laser /*electric_floor*/;
    public GameObject[] greenLasers;

    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        naked = true;
        active = true;
        sec = 2f;
        firstPress = false;
        genitals.SetActive(false);

        greenLasers = GameObject.FindGameObjectsWithTag("Green Laser");

        on = true;
        
    }

   


    void Update()
    {
        coverGenitals();
        anim.SetFloat("speed", Mathf.Abs(Input.GetAxis("Horizontal")));
        if (Input.GetAxisRaw(axisName) < 0)
        {
            //Vector3 newScale = transform.localScale;
            //newScale.y = 1.0f;
            //newScale.x = 1.0f;
            transform.localScale = new Vector3(-1f, 1f, 1f);
        }
        else if (Input.GetAxisRaw(axisName) > 0)
        {
            //Vector3 newScale =transform.localScale;
            //newScale.x = 1.0f;
            transform.localScale = new Vector3(1f, 1f, 1f);
        }
        
        //if (naked) {

        transform.position += transform.right * Input.GetAxis(axisName) * speed * Time.smoothDeltaTime/4;
        coverGenitals();
        //}
    }

    void coverGenitals()
    {

        //Component[] laserbeams;
        //Component[] elefloor;
        //laserbeams = laser.GetComponentsInChildren<BoxCollider2D>();
        //elefloor = electric_floor.GetComponentsInChildren<SpriteRenderer>();
        // Security Does NOT detect you
        if (Input.GetButton("Jump") && naked)
        {
            //genitals.SetActive (true);
            naked = false;
            firstPress = true;

            if (!naked && active == true/* && Input.GetButtonDown("Jump")*/)
            {
                StartCoroutine(SecurityDeActive());

            }

            
            anim.SetTrigger("pressed");

            teleporter.SetActive(false);

           


        }

        // Security DOES detect you
        else if (Input.GetButtonUp("Jump") && naked != true)
        {
            naked = true;
            //genitals.SetActive (false);
            //sec = 2f;
            StartCoroutine(SecurityActive());


            anim.SetTrigger("released");
            teleporter.SetActive(true);

           // Lasers On.


            //electric_floor.GetComponent<BoxCollider2D>().enabled = true;

            //foreach (SpriteRenderer arc in elefloor)
            //{
            //    arc.enabled = true;
            //}
            

        }
        if (naked != true && speed >= 1f)
        {
            if (speed != 1f)
            {
                speed -= 1f;
                if (speed < 1f)
                {
                    speed = 1f;

                }
            }

        }
        else if (naked != false && speed < 6.5f)
        {
            speed = 6.5f;
        }
        
    }

    IEnumerator SecurityActive()
    {

        float startScale, endScale;


        yield return new WaitForSeconds(.25f);

        if (naked)
        {

            
            foreach (GameObject greenLaser in greenLasers) { greenLaser.SetActive(true); }

            active = true;
        }
        

    }

    IEnumerator SecurityDeActive()
    {

        if (firstPress)
        {
            yield return new WaitForSeconds(1f);
            if (active && !naked)
            {

                foreach (GameObject greenLaser in greenLasers) { greenLaser.SetActive(false); }
                
                active = false;


            }
            else { StartCoroutine(SecurityActive()); }
            
        }
        
    }

}
