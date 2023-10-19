using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubo_Notificador : MonoBehaviour
{
    public delegate void Mensaje();
    public event Mensaje OnColision = delegate {};
    public event Mensaje OnColisionNoT1 = delegate {};
    public event Mensaje OnColisionT1 = delegate {};
    public event Mensaje OnCloser = delegate {};
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
        if (collision.gameObject.CompareTag("Cilindro"))
        {
           // Debug.Log("Colision con Cilindro");
           // OnColision();
        }
        if (!collision.gameObject.CompareTag("esferaT1") && !collision.gameObject.CompareTag("Plano")) {
           // OnColisionNoT1();
        }
        if (collision.gameObject.CompareTag("esferaT1")) {
           // OnColisionT1();
        }
    }
}
