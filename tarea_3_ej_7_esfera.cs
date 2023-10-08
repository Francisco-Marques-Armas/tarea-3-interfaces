using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tarea3_ej_7_esfera : MonoBehaviour
{
    public float speed = 10.0f;    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow)) {
            transform.Translate(Vector3.up * speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.DownArrow)) {
            transform.Translate(Vector3.down * speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.LeftArrow)) {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.RightArrow)) {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
    }
}
