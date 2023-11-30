using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bandera : MonoBehaviour
{
    private ReproductorSonidos misSonidos;
    private GameObject checkpoint;
    public GameObject reaparecePrefab;
    void Start()
    {
        misSonidos = GetComponent<ReproductorSonidos>();
        checkpoint = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject otro = collision.gameObject;


        if (otro.tag == "Player")
        {
            print("El " + name + " colisiona con " + collision);
            misSonidos.reproducir("Llegar");
            GameController.x = transform.position.x;
            GameController.y = transform.position.y;
            GetComponent<BoxCollider2D>().enabled = false;
            GameObject reaparece = Instantiate(reaparecePrefab);
            reaparece.transform.position = this.transform.position;
            Destroy(reaparece, 3f);

        }
    }
}