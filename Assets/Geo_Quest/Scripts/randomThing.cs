using System.Collections;
using System.Collections.Generic;
using Unity.Burst.Intrinsics;
using UnityEngine;
public class randomThing : MonoBehaviour
{
    int thing = 3;
    string variable1 = "Hello";
    // Start is called before the first frame update
    void Start()
    {
        string variable2 = " World";
        Debug.Log(variable1 + variable2);
    }

    // Update is called once per frame
    void Update()
    {
        thing++;
        Debug.Log(thing);
    }
}
