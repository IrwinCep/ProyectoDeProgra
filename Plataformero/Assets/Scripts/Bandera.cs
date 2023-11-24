using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bandera : MonoBehaviour
{
    private Animator miAnimador;
    private ReproductorSonidos misSonido;
    GameController gameController;
    // Start is called before the first frame update
    void Start()
    {
        miAnimador = GetComponent<Animator>();
        misSonido = GetComponent<ReproductorSonidos>();
    }
    private void Awake()
    {
        gameController = GameObject.FindGameObjectWithTag("Player").GetComponent<GameController>();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D llego)
    {
        Bandera bandera = GetComponent<Bandera>();
        print(name + "hizo colision con" + llego.gameObject.name);
        GameObject otro = llego.gameObject;
        if(otro.tag == "Player")
        {
            miAnimador.SetTrigger("llega");
            GameController.UpdateBandera(transform.position);
        }
    }
}
