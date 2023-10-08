using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tarea_3_ej_6 : MonoBehaviour
{
    Vector3 spherePosition = Vector3.zero;
    Vector3 sphereDirection = Vector3.zero;
    // Start is called before the first frame update
    void Start()
    {
        spherePosition = GameObject.Find("Sphere").transform.position;
        
        // Get vector between current transform and sphere transform
        sphereDirection = spherePosition - transform.position;
        sphereDirection.Normalize();
    }

    // Update is called once per frame
    void Update()
    {
        // Translate cube towards the sphere
        // Stop if it's close enough
        if (Vector3.Distance(transform.position, spherePosition) > 1.5f)
        {
            transform.Translate(sphereDirection * 10.0f * Time.deltaTime);
        }
    }
}
