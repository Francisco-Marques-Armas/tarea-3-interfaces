using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tarea3_ej_8 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Make sphere rotate along the horizontal axis
        transform.Rotate(transform.forward * 20.0f * Time.deltaTime);
        transform.Translate(transform.forward * 10.0f * Time.deltaTime);
    }
}
