using System.Collections;
using System.Collections.Generic;
using Unity.Burst.Intrinsics;
using UnityEngine;
public class randomThing : MonoBehaviour
{
    float thing = 1;
    string variable1 = "Hello";
    // Start is called before the first frame update
    void Start()
    {
        string variable2 = " World";
        Debug.Log(variable1 + variable2);
        Debug.Log(transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        thing *= (float)1.01;
        Debug.Log(transform.position);
        transform.position = new Vector3(thing, thing, thing);
    }
}
