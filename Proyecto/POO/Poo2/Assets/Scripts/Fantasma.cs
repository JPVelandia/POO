using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fantasma : MonoBehaviour
{
    
    public GameObject ruta;
    public GameObject ruta2;
    public GameObject ruta3;
    private int indice;
    private Vector3 posicion_inicial;
    private Vector3 posicion_siguiente;
    private float vel;
    private float distancia_punto;
    private float tiempo;
    private bool esta_viva;
    private Transform pos_fantasma_en_el_mundo;

    private GameObject[] rutas = new GameObject[3];
    private GameObject rutaActual;

    // Start is called before the first frame update
    void Start()
    {
        rutas[0] = ruta;  //Asignación de las rutas en las posiciones del arreglo
        rutas[1] = ruta2;
        rutas[2] = ruta3;

       
        posicion_inicial = this.transform.position;
        vel = 1;
        distancia_punto = 0.5f;
        rutaActual = GenerarRuta(rutas);
        posicion_siguiente = rutaActual.transform.GetChild(0).position;

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
                if (indice + 1 < rutaActual.transform.childCount)
                {
                    indice++;
                    posicion_siguiente = rutaActual.transform.GetChild(indice).position; // Permite el desplazamiento entre nodos
                   
                }
                else
                {
                    rutaActual = GenerarRuta(rutas);
                    indice = 0;
                    Volver_al_inicio();
                    posicion_siguiente = rutaActual.transform.GetChild(0).position;
                    
                }
            }
        //}

       
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
    
    private GameObject GenerarRuta(GameObject[] rutas)
    {
        return rutas[Random.Range(0, rutas.Length)];
    }

    public void Volver_al_inicio()
    {
        this.transform.position = posicion_inicial;
    }

}
