using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tarea_3_ej_3 : MonoBehaviour
{
    public Vector3 moveDirection = Vector3.zero;
    public float speed = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(speed * moveDirection * Time.deltaTime);
    }
}
