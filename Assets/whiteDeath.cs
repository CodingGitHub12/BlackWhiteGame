using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class whiteDeath : MonoBehaviour
{
    public GameObject StartPoint;
    public GameObject Player;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player" && Player.GetComponent<PlayerControl>().White)
        {
            Player.transform.position = StartPoint.transform.position;
            Debug.Log("spike!");
        }
    }
   




}
