using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class esfera_Notif_Canvas : MonoBehaviour
{
    public delegate void Mensaje();
    public event Mensaje OnColision = delegate {};
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Cubo")) {
           OnColision();
        }
    }
}
