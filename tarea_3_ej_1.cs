using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tarea_3_ej_1 : MonoBehaviour
{
    [SerializeField] public float speed = 1.1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            speed = speed * Input.GetAxis("Vertical");
            Debug.Log("UpArrow key was pressed. Current speed: " + speed);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            speed = speed * -Input.GetAxis("Vertical");
            Debug.Log("DownArrow key was pressed. Current speed: " + speed);
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            speed = speed * -Input.GetAxis("Horizontal");
            Debug.Log("LeftArrow key was pressed. Current speed: " + speed);
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            speed = speed * Input.GetAxis("Horizontal");
            Debug.Log("RightArrow key was pressed. Current speed: " + speed);
        }
    }
}
