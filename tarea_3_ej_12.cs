using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tarea_3_ej_12 : MonoBehaviour
{
    public float speed = 10.0f;    
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
        if (Input.GetKey(KeyCode.W)) {
            transform.Translate(Vector3.up * speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.S)) {
            transform.Translate(Vector3.down * speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.A)) {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.D)) {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
        // Translate cube towards the sphere
        if (Input.GetKey(KeyCode.T))
        {
            Debug.Log("T key pressed");
            transform.Translate(sphereDirection * 10.0f * Time.deltaTime);
        }
    }
}
