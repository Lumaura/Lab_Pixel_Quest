using System.Collections;
using System.Collections.Generic;
using Unity.Burst.Intrinsics;
using UnityEngine;
public class randomThing : MonoBehaviour
{
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {

        float speed = 10;
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = 0;
        Vector3 direction = mousePosition - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, angle);
        float angleInRadians = angle * Mathf.Deg2Rad;
        Vector3 moveAngle = new Vector3(Mathf.Cos(angleInRadians), Mathf.Sin(angleInRadians), 0);
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += moveAngle * speed * Time.deltaTime;
        }
    }
}
