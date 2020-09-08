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
        
        InvokeRepeating(nameof(CreateColors), 0, 5f);
    }

    void CreateColors()
    {
        var plus1 = Instantiate(plus, new Vector3(Random.Range(-90,90), 2.5f, Random.Range(-90,90)),
                        Quaternion.Euler(45,4,300));
        Destroy(plus1.gameObject, 5);
        var plus2 = Instantiate(plus, new Vector3(Random.Range(-90,90), 2.5f, Random.Range(-90,90)),
                        Quaternion.Inverse(default));
        Destroy(plus2.gameObject, 5);
        var plus3 = Instantiate(plus, new Vector3(Random.Range(-90,90), 2.5f, Random.Range(-90,90)),
                                Quaternion.identity);
        Destroy(plus3.gameObject, 5);
        var plus4 = Instantiate(plus, new Vector3(Random.Range(-90,90), 2.5f, Random.Range(-90,90)),
                        Quaternion.Inverse(default));
        Destroy(plus4.gameObject, 5);
        var plus5 = Instantiate(plus, new Vector3(Random.Range(-90,90), 2.5f, Random.Range(-90,90)),
            Quaternion.Euler(45,4,300));
        Destroy(plus5.gameObject, 5);
        var plus6 = Instantiate(plus, new Vector3(Random.Range(-90,90), 2.5f, Random.Range(-90,90)),
            Quaternion.Inverse(default));
        Destroy(plus6.gameObject, 5);
        var plus7 = Instantiate(plus, new Vector3(Random.Range(-90,90), 2.5f, Random.Range(-90,90)),
            Quaternion.identity);
        Destroy(plus7.gameObject, 5);
        var plus8 = Instantiate(plus, new Vector3(Random.Range(-90,90), 2.5f, Random.Range(-90,90)),
            Quaternion.Inverse(default));
        Destroy(plus8.gameObject, 5);
        
        var minus1 = Instantiate(minus, new Vector3(Random.Range(-90,90), 2.5f, Random.Range(-90,90)),
                         Quaternion.Inverse(default));
        Destroy(minus1.gameObject, 5);
        var minus2 = Instantiate(minus, new Vector3(Random.Range(-90,90), 2.5f, Random.Range(-90,90)),
                                 Quaternion.identity);
        Destroy(minus2.gameObject, 5);
        var minus3 = Instantiate(minus, new Vector3(Random.Range(-90,90), 2.5f, Random.Range(-90,90)),
                         Quaternion.Inverse(default));
        Destroy(minus3.gameObject, 5);
        var minus4 = Instantiate(minus, new Vector3(Random.Range(-90,90), 2.5f, Random.Range(-90,90)),
                                 Quaternion.identity);
        Destroy(minus4.gameObject, 5);
    }
    
}

