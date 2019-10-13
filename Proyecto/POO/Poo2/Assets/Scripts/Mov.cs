using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mov : MonoBehaviour
{
    
    public GameObject ruta;
    public GameObject ruta2;
    private int indice;
    private Vector3 posicion_inicial;
    private Vector3 posicion_siguiente;
    private float vel;
    private float distancia_punto;
    private float tiempo;
    private bool esta_viva;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(ruta.transform.childCount);
        posicion_inicial = this.transform.position;
        vel = 1;
        distancia_punto = 0.5f;
        posicion_siguiente = ruta.transform.GetChild(0).position;
    }

    // Update is called once per frame
    void Update()
    {
       // if (esta_viva)
        //{
            Vector3 dir = posicion_siguiente - this.transform.position;
            this.transform.position += dir * vel * Time.deltaTime;

            //Debug.Log(Time.deltaTime);
            // if (tiempo > 0.5)
            // {

            if (dir.magnitude <= distancia_punto)
            {
                if (indice + 1 < ruta.transform.childCount)
                {
                    indice++;
                    posicion_siguiente = ruta.transform.GetChild(indice).position;
                    Debug.Log("xs" + posicion_siguiente.x + "ys" + posicion_siguiente.y);
                }
                else
                {
                    indice = 0;
                    this.transform.position = posicion_inicial;
                    posicion_siguiente = ruta.transform.GetChild(0).position;

                }
            }
        //}

       
    }

    

    private void OnTriggerEnter2D(Collider2D otro)
    {
        if(otro.gameObject.tag == "Bala")
        {
            Destroy(otro.gameObject);
        }
    }

    public bool Esta_viva
    {
        get
        {
            return esta_viva;
        }

        set
        {
            esta_viva = value;
        }
    }
    
}
