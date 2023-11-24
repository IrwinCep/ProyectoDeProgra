using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Veneno : MonoBehaviour
{
    public Personaje heroe;
    public int danioHecho = 5;
    public float danioRep = 2f;
    private Animator miAnimador;
    private Personaje victima;

    void Start()
    {
        miAnimador = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D veneno)
    {
        Veneno pocionV = GetComponent<Veneno>();
        print(name + "hizo colision con" + veneno.gameObject.name);
        GameObject otro = veneno.gameObject;
        if (otro.tag == "Player")
        {
            InvokeRepeating("DanioConstante", 0f, danioRep);
            GetComponent<Collider2D>().enabled = false;
            Destroy(this.gameObject, 6f);
            miAnimador.SetTrigger("Envenenado");
        }
    }
    private void envenenar()
    {
        victima.hacerDanio(
            danioHecho,
            this.gameObject,
            Personaje.TipoDanio.Magico);
    }

    void DanioConstante()
    {
        if (heroe != null)
        {
            heroe.hacerDanio(danioHecho, this.gameObject);
        }
    }
}