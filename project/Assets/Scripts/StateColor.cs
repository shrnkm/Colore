using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class StateColor : MonoBehaviour
{
    public static Color state;
    public Image stateImage;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        state = Plump.clr;
        stateImage.color = state;
    }
}
