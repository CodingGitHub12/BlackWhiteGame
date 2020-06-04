using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{

    public GameObject dust;
    public GameObject white;
    public GameObject black;


    public Animator anim;
    private float velocity;
    public bool White;
    public bool Black;
    public float runningVelocity;
   
    public bool isGrounded;
  public  Rigidbody2D rb;
    public float jumpheight;
    public float speed;
    private bool landed;
    void Start()
    {
        
       
    }

    // Update is called once per frame
    void Update()
    {
        velocity = rb.velocity.y;
        float horizontal = Input.GetAxis("Horizontal");

        if (horizontal != 0 )
        {
            anim.SetBool("runningRight", true);
        }
        else
        {
            anim.SetBool("runningRight", false);
            
        }
               if (White == true)
        {
            white.SetActive(true);
            black.SetActive(false);
            White = true;
            anim.SetBool("white", true);
            Black = false;
        }
        else
        {
            White = false;
            Black = true;
          
            anim.SetBool("white", false);
        }
      
        if (Black == true)
        {
           white.SetActive( false);
            black.SetActive(true);
            Black = true;
            anim.SetBool("black", true);
            White = false;
        }
        else
        {
            White = true;
            Black = false;
            anim.SetBool("black", false);
        }
       
        
        //move right
        if (horizontal > 0)
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
            transform.localScale = new Vector3(1, 1, 0);
        }
    //move left
    if (horizontal < 0 ) 
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
            transform.localScale = new Vector3(-1, 1, 0);
        }
      
    if (isGrounded)
        {

            anim.SetBool("land", true);
            if (Input.GetKey(KeyCode.Joystick1Button0 )|| (Input.GetKey(KeyCode.Space)))
                { rb.velocity = new Vector2(0, jumpheight); }
        }
        else
        {
            anim.SetBool("land", false);
        }
  
        if (Input.GetKey("x") || Input.GetKey(KeyCode.Joystick1Button2))
        {
            Black = false;
            White = true;
        }
        
        if (  Input.GetKey ("b") || Input.GetKey(KeyCode.Joystick1Button1))
        {
            white.SetActive(false);
            black.SetActive(true);
            Black = true;
            anim.SetBool("black", true);
            White = false;
            Black = true;
            White = false;
        }
        
        if (velocity != 0)
        {
            anim.SetBool("inAir", true);


        }
        else
        {
            anim.SetBool("inAir", false);
        }






    }
}
