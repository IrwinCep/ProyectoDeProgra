using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje : MonoBehaviour
{
    public int hp = 60;
    public int hpMax = 100;
    public int score = 0;
    public int vidas = 3;
    Animator miAnimador;
    // Start is called before the first frame update
    void Start()
    {
        miAnimador = GetComponent<Animator>();
    }

    // Update is called once per frame
    public void hacerDanio(int puntos, GameObject atacante)
    {
        print(name + "recibe daño de "
            + puntos + " por " + atacante.name);

        //resto los puntos al HP actual
        hp = hp - puntos;
        miAnimador.SetTrigger("DAÑAR");
    }

    public void morirAgua(int vidaPerdida, GameObject atacante)
    {
        vidas = vidas - vidaPerdida;
        hp = 0;
    }
}
