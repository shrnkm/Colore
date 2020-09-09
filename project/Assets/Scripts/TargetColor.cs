using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class TargetColor : MonoBehaviour
{

    public static Color target;
    public Image targetImage;
    
    void Start()
    {
        var red = Random.value;
        var green = Random.value;
        var blue = Random.value;
        
        target = new Color (red, green, blue);
        target = new Color (.3f, .2f, .4f);
        targetImage.color = target;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
