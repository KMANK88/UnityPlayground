using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Alien")
        {
            other.GetComponent<Canvas>().enabled = true;
        }
        else if (other.gameObject.tag == "Alien (1)")
        {
            other.GetComponent<Canvas>().enabled = true;
        }
        else if (other.gameObject.tag == "Alien (2)")
        {
            other.GetComponent<Canvas>().enabled = true;
        }
        else if (other.gameObject.tag == "Alien (3)")
        {
            other.GetComponent<Canvas>().enabled = true;
        }
        else if (other.gameObject.tag == "Alien (4)")
        {
            other.GetComponent<Canvas>().enabled = true;
        }
    }
}
