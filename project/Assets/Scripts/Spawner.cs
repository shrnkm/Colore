using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Spawner : MonoBehaviour
{
    public GameObject plus;
    public GameObject minus;

    Vector3[] locations = new Vector3[8];

    void Start()
    {
        locations[0] = new Vector3(-15,2.5f,-15);
        locations[1] = new Vector3(-15,2.5f,15);
        locations[2] = new Vector3(15,2.5f,-15);
        locations[3] = new Vector3(15,2.5f,15);
        locations[4] = new Vector3(27,2,0);
        locations[5] = new Vector3(0,2,27);
        locations[6] = new Vector3(-27,2,0);
        locations[7] = new Vector3(0,2,-27);

        Vector3 vec = locations[3];
        
        Debug.Log(vec);
        //Instantiate(plus, locations[Random.Range(0, locations.Length)], Quaternion.identity);
        Instantiate(plus, vec, Quaternion.identity);
    }
    
}

