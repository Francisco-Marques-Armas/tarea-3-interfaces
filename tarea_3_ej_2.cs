using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class tarea_3_ej_2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        // Show message when fire1 is pressed and h key is pressed
        if (Input.GetKeyDown(KeyCode.H) && Input.GetButtonDown("Fire1"))
        {
            Debug.Log("Fire1 pressed and H key pressed");
        }
    }
}
