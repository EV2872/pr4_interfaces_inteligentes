using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class esfera_Receptor_Points : MonoBehaviour
{
    float puntos = 0;
    GameObject cubo;
    cubo_Notificador_Colision notificacion;
    // Start is called before the first frame update
    void Start()
    {
        cubo = GameObject.FindWithTag("Cubo");
        notificacion = cubo.GetComponent<cubo_Notificador_Colision>();
        notificacion.OnColision += sumarPuntos;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void sumarPuntos() {
        if (gameObject.CompareTag("esferaT1")) {
            puntos += 5;
            Debug.Log(puntos);
        } else if (gameObject.CompareTag("esferaT2")) {
            puntos += 10;
            Debug.Log(puntos);
        }
    }
}
