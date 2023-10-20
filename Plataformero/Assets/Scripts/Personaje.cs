using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje : MonoBehaviour
{
    public int hp = 60;
    public int hpMax = 100;
    public int score = 0;
    public int vidas = 3;
    public GameObject efectoSangrePrefab;
    Animator miAnimador;
    private ReproductorSonidos misSonido;
    
    // Start is called before the first frame update
    void Start()
    {
        miAnimador = GetComponent<Animator>();
        misSonido = GetComponent<ReproductorSonidos>();
    }

    // Update is called once per frame
    public void hacerDanio(int puntos, GameObject atacante)
    {
        print(name + "recibe da�o de "
            + puntos + " por " + atacante.name);

        //resto los puntos al HP actual
        hp = hp - puntos;
        miAnimador.SetTrigger("DA�AR");

        //Creo una instancia de la part de sangre
        GameObject sangre = Instantiate(
            efectoSangrePrefab, transform);

        misSonido.reproducir("DA�AR");
    }

    public void morirAgua(int vidaPerdida, GameObject atacante)
    {
        vidas = vidas - vidaPerdida;
        hp = 0;
        misSonido.reproducir("MORIR");
    }
}
