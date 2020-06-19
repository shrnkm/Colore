using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public class Plump : MonoBehaviour
{

    // player
    private Rigidbody pl;
    // movement sound effect
    public AudioSource roll;
    private AudioClip rolling;
    bool isRolling = false;
    
    
    void Start()
    {
        // get the player object
        pl = GetComponent<Rigidbody>();
        //pl.GetComponent<Renderer>().material.color = new Color(6, 194, 172, 0);
        pl.GetComponent<Material>().color = new Color(166, 194, 172, 0);
    }
    
    void Update()
    {
        // player movement
        float moveHorizontal = Input.GetAxis ("Horizontal");
        float moveVertical = Input.GetAxis ("Vertical");
        Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
        pl.position = pl.position + 0.2f * movement;
        
        
        // player movement sound effect
        //if ((moveHorizontal != 0) || (moveVertical != 0))
        //    isRolling = true;
        //else
        //    isRolling = false;
        //    
        //if (isRolling)
        //{
        //    if (!roll.isPlaying)
        //        roll.Play();
        //}
        //else
        //    roll.Stop();

    }

    void FixedUpdate()
    {
        
    }
}
