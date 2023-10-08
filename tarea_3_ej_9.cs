using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tarea_3_ej_9 : MonoBehaviour
{
    GameObject sphere;
    GameObject cube;
    GameObject cylinder;
    // Start is called before the first frame update
    void Start()
    {
        cube = GameObject.Find("Cube");
        sphere = GameObject.Find("Sphere");
        cylinder = GameObject.Find("Cylinder");
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == cube)
        {
            Debug.Log("Cylinder has collided with the Cube.");
        }
        else if (collision.gameObject == sphere)
        {
            Debug.Log("Cylinder has collided with the Sphere.");
        }
    }
    // Update is called once per frame
    void Update()
    {
        // Print if the cylinder has collided with the cube or the sphere
    }
}
