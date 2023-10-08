using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tarea3_ej_11 : MonoBehaviour
{
    GameObject cylinder;
    // Start is called before the first frame update
    void Start()
    {
        cylinder = GameObject.FindGameObjectsWithTag("BasicCylinder")[0];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == cylinder)
        {
            Debug.Log(this.name + " has entered the Cylinder's trigger zone.");
        }
    }
}
