using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;
using Random = System.Random;

public class Plump : MonoBehaviour
{

    // player
    private Rigidbody pl;
    private Renderer rend;


    void Start()
    {
        // get the player object
        pl = GetComponent<Rigidbody>();
        rend = pl.GetComponent<Renderer>();
        rend.material.color = new Color(0f, 0f, 0f);

    }
    
    void Update()
    {
        // player movement
        float moveHorizontal = Input.GetAxis ("Horizontal");
        float moveVertical = Input.GetAxis ("Vertical");
        Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
        pl.position = pl.position + 0.2f * 2 * movement;
        
        
        
    }

    void FixedUpdate()
    {
        
    }
}
