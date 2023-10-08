using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tarea3_ej_7_cubo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.LookAt(GameObject.Find("Sphere").transform);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * 10.0f * Time.deltaTime);
        // Make cube spin
        transform.Rotate(Vector3.up * 20.0f * Time.deltaTime);
        // transform.Rotate(Vector3.right * 10.0f * Time.deltaTime);
        transform.Rotate(Vector3.forward * 20.0f * Time.deltaTime);        
    }
}
