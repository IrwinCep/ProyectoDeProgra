using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TesoroMoneda : MonoBehaviour
{
    private Animator miAnimador;
    public int vMoneda = 10;
    // Start is called before the first frame update
    void Start()
    {
        miAnimador = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        print(name + "hizo colisión con "
            + other.gameObject.name);

        GameObject otro = other.gameObject;
        if (otro.tag == "Player")
        {
            Personaje elPerso = otro.GetComponent<Personaje>();
            elPerso.score = elPerso.score + vMoneda;
            miAnimador.SetTrigger("Desaparece");
            GetComponent<Collider2D>().enabled = false;
            Destroy(gameObject, 1.5f);
        }
    }
}
