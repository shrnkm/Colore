using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plump : MonoBehaviour
{

    private Rigidbody pl;
    
    // Start is called before the first frame update
    void Start()
    {
        pl = GetComponent<Rigidbody>();
        pl.GetComponent<Renderer>().material.color = new Color(250, 0, 0, 0);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis ("Horizontal");
        float moveVertical = Input.GetAxis ("Vertical");

        Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

        pl.AddForce (movement * 10);

    }
}
