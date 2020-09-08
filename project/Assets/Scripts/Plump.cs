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
    public static Color clr;


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

        rend.material.color = clr;

    }
    
    
    private void OnTriggerEnter(Collider other) {
        if(other.CompareTag("pplus"))
        {
            if (other.transform.GetComponent<Renderer>().material.color == Color.red)
            {
                if (clr[0] < 1)
                {
                    clr = new Color (clr[0]+.1f, clr[1],clr[2]);
                    Destroy(other.gameObject);
                }
                else
                {
                    // show a message that the highest red level is already reached
                    // or play a beep sound
                }
            }

            if (other.transform.GetComponent<Renderer>().material.color == Color.green)
            {
                if (clr[1] < 1)
                {
                    clr = new Color(clr[0], clr[1] + .1f, clr[2]);
                    Destroy(other.gameObject);
                }
                else
                {
                    // show a message that the highest green level is already reached
                }
            }
            
            if (other.transform.GetComponent<Renderer>().material.color == Color.blue)
            {
                if (clr[2] < 1)
                {
                    clr = new Color(clr[0], clr[1], clr[2] + .1f);
                    Destroy(other.gameObject);
                }
                else
                {
                    // show a message that the highest blue level is already reached
                }
            }
        }
        else
        {
            if (other.CompareTag("pminus"))
            {
                if (Minus.mclr.Equals(Color.red))
                {
                    if (clr[0] > 0)
                    {
                        clr = new Color(clr[0] - .1f, clr[1], clr[2]);
                        Destroy(other.gameObject);
                    }
                    else
                    {
                        // show a message that the lowest red level is already reached
                    }
                }

                if (Minus.mclr.Equals(Color.green))
                {
                    if (clr[1] > 0)
                    {
                        clr = new Color(clr[0], clr[1] - .1f, clr[2]);
                        Destroy(other.gameObject);
                    }
                    else
                    {
                        // show a message that the lowest green level is already reached
                    }
                }

                if (Minus.mclr.Equals(Color.blue))
                {
                    if (clr[2] > 0)
                    {
                        clr = new Color(clr[0], clr[1], clr[2] - .1f);
                        Destroy(other.gameObject);
                    }
                    else
                    {
                        // show a message that the highest blue level is already reached
                    }
                }
            }
        }
    }
}
