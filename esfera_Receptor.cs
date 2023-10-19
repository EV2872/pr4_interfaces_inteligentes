using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class esfera_Receptor : MonoBehaviour
{
    public float speed = 3;
    public float aumentoDeEscala = 2;
    public float jump = 4;
    private bool enSuelo = true;

    Cubo_Notificador notificador;
    cubo_Notificafor_Aproximacion aprox;
    Vector3 posAnterior;
    GameObject cilindro;
    GameObject cubo;
    // Start is called before the first frame update
    void Start()
    {
        cilindro = GameObject.FindWithTag("Cilindro");
        cubo = GameObject.FindWithTag("Cubo");
        posAnterior = cubo.transform.position;
        // notificador = GameObject.FindWithTag("Cubo").GetComponent<Cubo_Notificador>();
        notificador = cubo.GetComponent<Cubo_Notificador>();
        aprox = cubo.GetComponent<cubo_Notificafor_Aproximacion>();
        aprox.OnAproximacion += aproximar;
        //notificador.OnColision += ejecutarEventos;
        //notificador.OnColisionNoT1 += acercarEsferasT1AlCilindro;
        //notificador.OnColisionT1 += aumentarTamEsferasT2;
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, Vector3.down, out hit, 0.5f)) {
            enSuelo = true; // La esfera está en el suelo
        }
    }

    void ejecutarEventos() {
        switch (tag)
        {
            case "esferaT1":
                cambiarDeColor();
                break;
            case "esferaT2":
                moverHaciaElCilindro();
                break;
            default:
                break;
        }
    }

    void aproximar() {
        float previo = Vector3.Distance(cilindro.transform.position, posAnterior);
        float actual = Vector3.Distance(cilindro.transform.position, cubo.transform.position);
        if (actual < previo && enSuelo) {
            if (tag == "esferaT1") {
                GetComponent<Rigidbody>().AddForce(Vector3.up * jump, ForceMode.Impulse);
                 enSuelo = false;
                cambiarDeColor();
            }
            if (tag == "esferaT2") {
                transform.LookAt(cubo.transform);
            }
        }
       // previo = actual;
    }

    void cambiarDeColor() {
        Material material = GetComponent<Renderer>().material;
        material.color = new Color(Random.value, Random.value, Random.value);
    }

    void moverHaciaElCilindro() {
        Vector3 direccion =  cilindro.transform.position - transform.position;
        direccion = direccion.normalized;
        GetComponent<Rigidbody>().AddForce(direccion * speed, ForceMode.Impulse);
    }

    void acercarEsferasT1AlCilindro() {
        if (tag == "esferaT1") {
            moverHaciaElCilindro();
        }
    }

    void aumentarTamEsferasT2() {
        if (tag == "esferaT2") {
            transform.localScale *= aumentoDeEscala;
        }
    }

    void cuboAproximado() {
        
    }
}
