using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // Agregar esta línea
public class setSCore : MonoBehaviour
{
    GameObject cubo;
    notificador notificador_;
    public Text textoMarcador;
    int puntos = 0;
    // Start is called before the first frame update
    void Start()
    {
        textoMarcador = GameObject.FindWithTag("Marcador").GetComponent<Text>();
        cubo = GameObject.FindWithTag("Cubo");
        notificador_ = cubo.GetComponent<notificador>();
        notificador_.OnSetScore += aumentarMarcador;
        notificador_.OnReduceScore += reduceScore;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void aumentarMarcador() {
        puntos += 1;
        textoMarcador.text = "Times: " + puntos;
    }
    void reduceScore() {
        puntos -= 1;
        textoMarcador.text = "Times: " + puntos;
    }
}
