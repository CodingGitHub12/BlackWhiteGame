using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skippedToLevels : MonoBehaviour
{
    public Animator anim;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("a") || Input.GetKey(KeyCode.Joystick1Button0)) {
            anim.SetBool("skipped", true);
        }
    }
}
