using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubo_Notificafor_Aproximacion : MonoBehaviour
{
    Vector3 prevPos;
    Vector3 actualPos;
    GameObject cilindro;
    GameObject cubo;
    public delegate void Mensaje();
    public event Mensaje OnAproximacion = delegate {};
    // Start is called before the first frame update
    void Start()
    {
        cilindro = GameObject.FindWithTag("Cilindro");
        cubo = GameObject.FindWithTag("Cubo");
        prevPos = cubo.transform.position;
    }

    // Update is called once per frame
    void Update()
    {   
        Vector3 cilindroPos = cilindro.transform.position;
        actualPos = cubo.transform.position;
        float prev = Vector3.Distance(cilindroPos, prevPos);
        float actual = Vector3.Distance(cilindroPos, actualPos);
        if (actual < prev) {
            OnAproximacion();
        }
        prevPos = actualPos;
    }
}
