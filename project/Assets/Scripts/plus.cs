using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class plus : MonoBehaviour
{
    
    private Rigidbody plusPrf;
    private Renderer rendPP;
    private static Color pcls;
    
    Color[] colors = new Color[3];
    
    // Start is called before the first frame update
    void Start()
    {
        
        colors[0] = Color.red;
        colors[1] = Color.green;
        colors[2] = Color.blue;
        
        // get the player object
        plusPrf = GetComponent<Rigidbody>();
        rendPP = plusPrf.GetComponent<Renderer>();
        pcls = colors[Random.Range(0, colors.Length)];
        rendPP.material.color = pcls;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
