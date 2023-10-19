using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class notificador : MonoBehaviour
{
    public delegate void Mensaje();
    public event Mensaje OnColision = delegate {};
    public event Mensaje OnSetScore = delegate {};
    public event Mensaje OnReduceScore = delegate {};
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
        if (collision.gameObject.CompareTag("esfera")) {
           OnColision();
           OnSetScore();
        } else if (collision.gameObject.CompareTag("CuboMalo")) {
            OnReduceScore();
        }
    }
}
