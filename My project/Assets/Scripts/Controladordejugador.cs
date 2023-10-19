using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controladordejugador : MonoBehaviour
{
    public float jumpforce = 10f;
    public float velocidadCaminar = 3f;
    private Rigidbody2D miCuerpo;
    private Animator miAnimador;
    void Start()
    {
        //Al atributo MiCuerpo le asigno
        //el componente rigid body 2d de
        //este personaje
        miCuerpo = GetComponent<Rigidbody2D>();
        miAnimador = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float velActualVert = miCuerpo.velocity.y;
        //Leo si el jugador essta presionando un
        //eje horizontal en las flechas
        float movHoriz = Input.GetAxis("Horizontal");
        if (movHoriz > 0)//a la derecha
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
            miCuerpo.velocity = new Vector3(velocidadCaminar, velActualVert, 0);
            miAnimador.SetBool("Caminando", true);
        }
        else if (movHoriz < 0)//a la izquierda
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);
            miCuerpo.velocity = new Vector3(-velocidadCaminar, velActualVert, 0);
            miAnimador.SetBool("Caminando", true);
        }
        else//quieto
        {
            miCuerpo.velocity = new Vector3(0, velActualVert, 0);
            miAnimador.SetBool("Caminando", false);
        }
        if(Input.GetButtonDown("Jump"))
        {
            print("Se presiono el botòn de salto");
            miCuerpo.AddForce(new Vector3(0, jumpforce, 0), ForceMode2D.Impulse);
        }
        miAnimador.SetFloat("vel_vert", velActualVert);
    }
}
