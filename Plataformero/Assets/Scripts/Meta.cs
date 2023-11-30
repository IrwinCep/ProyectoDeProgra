using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meta : MonoBehaviour
{
    public GameObject cavernicola;
    private ReproductorSonidos misSonidos;
    public GameObject metaPrefab;
    private Animator miAnimador;


    void Start()
    {
        misSonidos = GetComponent<ReproductorSonidos>();
        miAnimador = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject otroObjeto = collision.gameObject;
        if (otroObjeto.tag == "Player")
        {
            Personaje elPerso = otroObjeto.GetComponent<Personaje>(); 
            misSonidos.reproducir("Celebracion");

            GameObject celebracion = Instantiate(metaPrefab);
            celebracion.transform.position = this.transform.position;
        }
    }
}
