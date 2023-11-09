using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoQuieto : MonoBehaviour
{
    public float distanciaAgro = 5;
    private GameObject heroe;
    private Rigidbody2D yoCuerpo;
    public float velHongo = 1f;
    private Animator miAnimador;
    public int puntosDanio = 20;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        print(name + "hizo colisi�n con "
            + collision.gameObject.name);

        GameObject otro = collision.gameObject;
        if (otro.tag == "Player")
        {
            //Accedo al componente de tipo Personaje
            //del objeto con el que choqu�
            Personaje elPerso = otro.GetComponent<Personaje>();
            //Aplico el da�o al otro invocando al metodo hacer da�o
            elPerso.hacerDanio(puntosDanio, this.gameObject);
        }
    }
    void Start()
    {
        heroe = GameObject.FindWithTag("Player");
        yoCuerpo = GetComponent<Rigidbody2D>();
        miAnimador = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 posHeroe = heroe.transform.position;
        Vector3 posYo = this.transform.position;

        float distancia = (posYo - posHeroe).magnitude;
        if(distancia < distanciaAgro)
        { //el heroe esta dentro de la zona de agro
            if(posHeroe.x > posYo.x)
            { //el heroe esta a la derecha

                transform.rotation = Quaternion.Euler(0, 180, 0);
                yoCuerpo.velocity = new Vector3(velHongo, 0, 0);
                miAnimador.SetBool("Picos", true);
            }
            else
            { //el heroe esta a la izquierda
                transform.rotation = Quaternion.Euler(0, 0, 0);
                yoCuerpo.velocity = new Vector3(-velHongo, 0, 0);
            }


        }
        else
        {
            //el heroe esta fuera de la zona de agro
            yoCuerpo.velocity = new Vector3(0, 0, 0);
            miAnimador.SetBool("Picos", false);
        }
    }
}
