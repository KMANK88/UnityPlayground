using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class alienMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start(){
        int rand = Random.Range(0, 4);
        if(rand == 0)
        {
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(0f, -5f);
        }else if (rand == 1)
        {
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(0f, 5f);

        }
        else if (rand == 2)
        {
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(5f, 0f);

        }
        else if (rand == 3)
        {
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(-5f, 0f);

        }
    }

    // Update is called once per frame
    void Update(){
       
    }


    private void OnCollisionEnter2D(Collision2D hit){

        int rand = Random.Range(0, 4);
        if (rand == 0)
        {
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(2f, -5f);
        }
        else if (rand == 1)
        {
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(3f, 5f);

        }
        else if (rand == 2)
        {
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(5f, -4f);

        }
        else if (rand == 3)
        {
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(-5f, -2f);

        }
  
    }
}
