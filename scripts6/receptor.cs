using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class receptor : MonoBehaviour
{
    GameObject cubo;
    notificador notificador_;
    Renderer esferaRenderer;
    // Start is called before the first frame update
    void Start()
    {
        cubo = GameObject.FindWithTag("Cubo");
        notificador_ = cubo.GetComponent<notificador>();
        notificador_.OnColision += cambiarColor;
        esferaRenderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void cambiarColor() {
        Material material = esferaRenderer.material;
        material.color = new Color(Random.value, Random.value, Random.value);
    }
}
