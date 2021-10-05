using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Escalamiento : MonoBehaviour
{
    float escalaActual = 1.0f;
    float velEscala = 0.75f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        escalaActual = escalaActual + (velEscala * Time.deltaTime);
        transform.localScale = new Vector3(escalaActual, escalaActual, escalaActual);
        if (escalaActual > 2.0)
        {
            escalaActual = 2.0f;
            velEscala *= -1.0f;
        }
        if (escalaActual < 0.5)
        {
            // Hacemos trim al valor
            escalaActual = 0.5f;

            // Invertimos la direccion del cambio de escala
            velEscala *= -1.0f;
        }
    }
}
