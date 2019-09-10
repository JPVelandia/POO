using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mov : MonoBehaviour
{
    
    public GameObject ruta;
    private int indice;
    private Vector3 posicion_siguiente;
    public float vel = 1;
    private float distancia_punto = 0.05f;

    private float tiempo;
    // Start is called before the first frame update
    void Start()
    {
        posicion_siguiente = ruta.transform.GetChild(0).position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 dir = posicion_siguiente - this.transform.position;
        this.transform.position += dir * vel * Time.deltaTime;

        if (dir.magnitude <= distancia_punto)
        {
            if (indice+1 <ruta.transform.childCount)
            {
                indice++;
                posicion_siguiente = ruta.transform.GetChild(indice).position;
            }
        }
    }
}
