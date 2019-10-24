using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{
    private GameObject objetivo;
    private float velocidad;
    private Vector3 posicion_inicial;
    private Vector3 PosBala;
    private bool disparada;
   


    // Start is called before the first frame update
    void Start()
    {
        posicion_inicial = this.transform.position;
        velocidad = 7;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direccion = objetivo.transform.position - this.transform.position;
        this.transform.position += velocidad * direccion * Time.deltaTime;
        PosBala = GameObject.FindGameObjectWithTag("Bala").transform.position;


    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            other.GetComponent<Fantasma>().Volver_al_inicio();
            Volver_al_inicio();
        }
    }


public void Activar(Torre torre)
    {
        disparada = true;
        objetivo = torre.Enemigo;
    }

    public void Volver_al_inicio()
    {
        this.transform.position = posicion_inicial;
    }
}
