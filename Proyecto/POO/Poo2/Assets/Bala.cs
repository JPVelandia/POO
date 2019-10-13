using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{
    private GameObject objetivo;
    private float velocidad;
    private float posicion_inicial;
    private Vector3 PosBala;
   


    // Start is called before the first frame update
    void Start()
    {
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
        if (other.gameObject.tag == "Bala")
        {
            GameObject.FindGameObjectWithTag("Bala").transform.position = GuardarPosBala.Cargar();
        }
    }


public void Activar(Torre torre)
    {
        objetivo = torre.Enemigo;
    }

}
