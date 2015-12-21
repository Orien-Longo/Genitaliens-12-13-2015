using UnityEngine;
using System.Collections;

public class CameraChange : MonoBehaviour
{

    public GameObject watcher, player;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Human")
        {
            watcher = GameObject.FindGameObjectWithTag("Watcher");

            watcher.GetComponent<UnityStandardAssets.Utility.SmoothFollow>().target = gameObject.transform;

        }
    }
    void OnTriggerStay2D(Collider2D other)
    {

        if (other.name == "Human")
        {
            watcher = GameObject.FindGameObjectWithTag("Watcher");

            watcher.GetComponent<UnityStandardAssets.Utility.SmoothFollow>().target = gameObject.transform;

        }
        //else { watcher.GetComponent<UnityStandardAssets.Utility.SmoothFollow>().target = GameObject.FindGameObjectWithTag("Player").transform; }

    }
    void OnTriggerExit2D(Collider2D other)
    {
        //if (other.name == "Human")
        //{

            watcher = GameObject.FindGameObjectWithTag("Watcher");
            //player = GameObject.FindGameObjectWithTag("Player");
            watcher.GetComponent<UnityStandardAssets.Utility.SmoothFollow>().target = GameObject.FindGameObjectWithTag("Player").transform;

        //}
    }
}
