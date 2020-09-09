using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using TMPro;
using UnityEngine;
using Random = System.Random;

public class Plump : MonoBehaviour
{

    // player
    private Rigidbody pl;
    private Renderer rend;
    public static Color clr;
    
    public TextMeshProUGUI movesStr;
    public RectTransform win;
    public RectTransform ctrl;
    private int moves = 0;
    
    public AudioSource plusSource;
    public AudioClip positive;
    
    public AudioSource negSource;
    public AudioClip negative;

    public AudioSource feliciSource;
    public AudioClip felicidades;

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
        
        movesStr.text = "Moves: " + moves;
        
        
        if (TargetColor.target == StateColor.state)
        {
            Timer.playing = false;
            win.gameObject.SetActive(true);
            pl.gameObject.SetActive(false);
            ctrl.gameObject.SetActive(false);
            feliciSource.PlayOneShot(felicidades);
            
        }

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
                    moves += 1;
                    plusSource.PlayOneShot(positive);
                    Debug.Log(clr);
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
                    moves += 1;
                    plusSource.PlayOneShot(positive);
                    Debug.Log(clr);
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
                    moves += 1;
                    plusSource.PlayOneShot(positive);
                    Debug.Log(clr);
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
                if (other.transform.GetComponent<Renderer>().material.color == Color.red)
                {
                    if (clr[0] > 0)
                    {
                        clr = new Color(clr[0] - .1f, clr[1], clr[2]);
                        Destroy(other.gameObject);
                        moves += 1;
                        negSource.PlayOneShot(negative);
                        Debug.Log(clr);
                    }
                    else
                    {
                        // show a message that the lowest red level is already reached
                    }
                }

                if (other.transform.GetComponent<Renderer>().material.color == Color.green)
                {
                    if (clr[1] > 0)
                    {
                        clr = new Color(clr[0], clr[1] - .1f, clr[2]);
                        Destroy(other.gameObject);
                        moves += 1;
                        negSource.PlayOneShot(negative);
                        Debug.Log(clr);
                    }
                    else
                    {
                        // show a message that the lowest green level is already reached
                    }
                }

                if (other.transform.GetComponent<Renderer>().material.color == Color.blue)
                {
                    if (clr[2] > 0)
                    {
                        clr = new Color(clr[0], clr[1], clr[2] - .1f);
                        Destroy(other.gameObject);
                        moves += 1;
                        negSource.PlayOneShot(negative);
                        Debug.Log(clr);
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
