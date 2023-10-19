using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // Agregar esta línea
public class actualizarCanvas : MonoBehaviour
{
    int marcador = 0;
    GameObject esfera1;
    GameObject esfera2;
    esfera_Notif_Canvas notificador1;
    esfera_Notif_Canvas notificador2;
    public Text textoMarcador;
    // Start is called before the first frame update
    void Start()
    {
        textoMarcador = GameObject.FindWithTag("Marcador").GetComponent<Text>();;
        esfera1 = GameObject.FindWithTag("esferaT1");
        esfera2 = GameObject.FindWithTag("esferaT2");
        notificador1 = esfera1.GetComponent<esfera_Notif_Canvas>();
        notificador2 = esfera2.GetComponent<esfera_Notif_Canvas>();
        notificador1.OnColision += SumarPuntosEsferaT1;
        notificador2.OnColision += SumarPuntosEsferaT2;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SumarPuntosEsferaT1() {
        marcador += 5;
        textoMarcador.text = "Marcador: " + marcador;
    }

    void SumarPuntosEsferaT2() {
        marcador += 10;
        textoMarcador.text = "Marcador: " + marcador;
    }
}
