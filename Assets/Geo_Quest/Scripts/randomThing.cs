using System.Collections;
using System.Collections.Generic;
using Unity.Burst.Intrinsics;
using UnityEngine;
public class randomThing : MonoBehaviour
{
    float thing = 1.0f;
    string variable1 = "Hello";
    private int invert = -1;
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
        thing *= 1.01f;
        thing *= invert;
        Debug.Log(transform.position);
        transform.position = new Vector3(thing, thing, thing);
    }
}
