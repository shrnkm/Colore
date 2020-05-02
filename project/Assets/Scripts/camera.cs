using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    public GameObject plump;

    private Vector3 offset;

    void Start ()
    {
        offset = transform.position - plump.transform.position;
    }

    void LateUpdate ()
    {
        transform.position = plump.transform.position + offset;
    }
}
