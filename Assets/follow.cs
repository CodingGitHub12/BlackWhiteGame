using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow : MonoBehaviour
{

    public bool following;
    public float speed;
    private GameObject Player;
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            following = true;
   transform.position = Vector2.MoveTowards(transform.position, Player.transform.position, speed * Time.deltaTime);
     }
    }
    void Update()
    {
        
    }
}
