using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tarea_3_ej_10 : MonoBehaviour
{
    GameObject sphere;
    GameObject cube;
    GameObject cylinder;

    void Start()
    {
        cube = GameObject.Find("Cube");
        sphere = GameObject.Find("Sphere");
        cylinder = GameObject.Find("Cylinder");
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject == cube)
        {
            Debug.Log("Cube is has collided with cylinder.");
        }
        else if (other.gameObject == sphere)
        {
            Debug.Log("Sphere is has collided with cylinder.");
        }
    }
}
