using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouse : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed;  
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis(" Horizontal");
        float vertical = Input.GetAxis("Vertical");

        if(horizontal > 0)
        {
           rb.AddForce(Vector2.right * speed * Time.deltaTime);
        }
       
        if (horizontal > 0)
        {
            rb.AddForce(Vector2.left * speed * Time.deltaTime);
        }

        if (vertical > 0)
        {
           rb.AddForce(Vector2.up * speed * Time.deltaTime);
        }

        if (vertical < 0)
        {
           rb.AddForce(Vector2.down * speed * Time.deltaTime);
        }
    }
}
