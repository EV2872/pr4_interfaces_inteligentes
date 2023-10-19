using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubo_Desplazarse : MonoBehaviour
{
    public float speed = 1;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        float movement = speed * Time.deltaTime;
        transform.Translate(
            movement * Input.GetAxis("Horizontal"), 
            0, 
            movement * Input.GetAxis("Vertical")
        );
    }
}

