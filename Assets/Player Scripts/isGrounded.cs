using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class isGrounded : MonoBehaviour
{
    GameObject whiteblock;
 
    GameObject Player;
    void Start()
    {
       
        Player = gameObject.transform.parent.gameObject;
    }
    private void Update()
    {
    
    
    }
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "both")
        {
            Player.GetComponent<PlayerControl>().isGrounded = true;
        }
        else
        {
            Player.GetComponent<PlayerControl>().isGrounded = false;

        }



        if (other.tag == "WhiteGround" && Player.GetComponent<PlayerControl>().White)
        {
            Player.GetComponent<CircleCollider2D>().enabled = true;
            Player.GetComponent<BoxCollider2D>().enabled = true;
            Player.GetComponent<PlayerControl>().isGrounded = true;
            Debug.Log("true");
        }

        if (other.tag == "BlackGround" && Player.GetComponent<PlayerControl>().Black)
        {

            Player.GetComponent<CircleCollider2D>().enabled = true;
            Player.GetComponent<PlayerControl>().isGrounded = true;
            Player.GetComponent<PlayerControl>().isGrounded = true;
            Debug.Log("true");
        }
        if (other.tag == "WhiteGround" && Player.GetComponent<PlayerControl>().Black)
        {
            Player.GetComponent<CircleCollider2D>().enabled = false;
            Player.GetComponent<BoxCollider2D>().enabled = false;
            Debug.Log("fasle");
            Player.GetComponent<PlayerControl>().isGrounded = false;
        }
       
        if (other.tag == "BlackGround" && Player.GetComponent<PlayerControl>().White)
        {

            Player.GetComponent<CircleCollider2D>().enabled = false;
            Player.GetComponent<BoxCollider2D>().enabled = false;
            Debug.Log("false");
        Player.GetComponent<PlayerControl>().isGrounded = false;
        }
       

        if (other.tag == "WhiteGround" && other.tag == "BlackGround")
        {
            Player.GetComponent<PlayerControl>().isGrounded = true;
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == "both")
        {
            Player.GetComponent<PlayerControl>().isGrounded = true;
        }
        else
        {
            Player.GetComponent<PlayerControl>().isGrounded = false;

        }
        if (other.tag == "WhiteGround" && Player.GetComponent<PlayerControl>().White)
        {
            Player.GetComponent<CircleCollider2D>().enabled = true;
            Player.GetComponent<BoxCollider2D>().enabled = true;
            Player.GetComponent<PlayerControl>().isGrounded = true;
        }

        if (other.tag == "BlackGround" && Player.GetComponent<PlayerControl>().Black)
        {
            Player.GetComponent<CircleCollider2D>().enabled = true;
            Player.GetComponent<BoxCollider2D>().enabled = true;
            Player.GetComponent<PlayerControl>().isGrounded = true;
        }
        if (other.tag == "WhiteGround" && Player.GetComponent<PlayerControl>().Black)
        {
            Player.GetComponent<CircleCollider2D>().enabled = false;
            Player.GetComponent<BoxCollider2D>().enabled = false;
            Player.GetComponent<PlayerControl>().isGrounded = false;
        }
        if (other.tag == "BlackGround" && Player.GetComponent<PlayerControl>().White)
        {
            Player.GetComponent<CircleCollider2D>().enabled = false;
            Player.GetComponent<BoxCollider2D>().enabled = false;
            Player.GetComponent<PlayerControl>().isGrounded = false;
        }
        else
        {
            Player.GetComponent<CircleCollider2D>().enabled = true;
            Player.GetComponent<BoxCollider2D>().enabled = true;
            Player.GetComponent<PlayerControl>().isGrounded = false;
        }
        if ( other.tag == "BlackGround" && Player.GetComponent<PlayerControl>().Black)
        {
            Player.GetComponent<PlayerControl>().isGrounded = true;
        }
        else
        {
            Player.GetComponent<PlayerControl>().isGrounded = false;
        }
        if (other.tag == "WhiteGround"  && Player.GetComponent<PlayerControl>().White)
        {
            Player.GetComponent<PlayerControl>().isGrounded = true;
        }
        else
        {
            Player.GetComponent<PlayerControl>().isGrounded = false;
        }

        if (other.tag == "WhiteGround" && other.tag == "BlackGround")
        {
            Player.GetComponent<PlayerControl>().isGrounded = true;
        }
    }





    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "WhiteGround" || other.tag == "BlackGround")
        {
            Player.GetComponent<PlayerControl>().isGrounded = false;
     
        }
   
    if (other.CompareTag("both"))
            {
            Player.GetComponent<PlayerControl>().isGrounded = false;
        }
    
    }


  

}
