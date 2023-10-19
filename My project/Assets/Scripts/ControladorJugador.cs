using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorJugador : MonoBehaviour
{
    // Declaro una referencia al rigid body
    private Rigidbody2D MiCuerpo;

    void Start()
    {   //Obtengo el componente rigid body
        //y lo guardo en la variable
        MiCuerpo = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            print("Se presionó salto");
            MiCuerpo.AddForce(
                new Vector3(0, 20, 0),
                ForceMode2D.Impulse);
        }
    }
}
