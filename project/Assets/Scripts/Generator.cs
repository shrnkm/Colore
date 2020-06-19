using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    public GameObject red;
    public GameObject terrain;
    
    public int numberOfColore;
    private MeshCollider col;
    
    
    // Start is called before the first frame update
    void Start() {
        col = red.GetComponent<MeshCollider>();
        GenerateObject(red, numberOfColore);
        GameObject tmp = Instantiate(red);
        tmp.transform.position = new Vector3(5.0f, tmp.transform.position.y, 5.0f);
    }

    void GenerateObject(GameObject go, int amount)
    {
        if (go == null) return;
        for(int i = 0; i < amount; i++)
        {
            GameObject tmp = Instantiate(go);
            
            Vector3 randomPoint = GetRandomPoint();
            tmp.gameObject.transform.position = new Vector3(randomPoint.x, 
                tmp.transform.position.y, randomPoint.z);
        }
    }
    
    
    Vector3 GetRandomPoint()
    {
        int xRandom = 0;
        int zRandom = 0;
        xRandom = (int)Random.Range(-100, 100);
        
        zRandom = (int)Random.Range(-100, 100);
        return new Vector3(xRandom, 0.0f, zRandom);
    }
    
    
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
