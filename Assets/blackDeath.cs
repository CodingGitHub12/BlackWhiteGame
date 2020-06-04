using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blackDeath : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    public GameObject StartPoint;
    public GameObject Player;


    // Update is called once per frame
    void Update()
    {

    }
   
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player" && Player.GetComponent<PlayerControl>().Black)
        {
            Player.transform.position = StartPoint.transform.position;
            Debug.Log("spike!");
        }
    }
}
