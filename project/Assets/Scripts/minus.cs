using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Minus : MonoBehaviour
{
    private Rigidbody minusPrf;
    private Renderer rendMP;
    public static Color mclr;
    
    Color[] colors = new Color[3];
    
    // Start is called before the first frame update
    void Start()
    {
        
        colors[0] = Color.red;
        colors[1] = Color.green;
        colors[2] = Color.blue;
        
        // get the player object
        minusPrf = GetComponent<Rigidbody>();
        rendMP = minusPrf.GetComponent<Renderer>();
        mclr = colors[Random.Range(0, colors.Length)];
        rendMP.material.color = mclr;
    }
}
