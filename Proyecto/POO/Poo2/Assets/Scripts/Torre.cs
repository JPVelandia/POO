using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torre : MonoBehaviour
{
    public GameObject enemigo;
    private float distancia_max;
    private GameObject[] balas;
  
    // Start is called before the first frame update
    void Start()
    {
        distancia_max = 1;
        crearBalas(5);
       
    }

    // Update is called once per frame
    void Update()
    {
        Enemigo = BuscarEnemigoCercano();
        float dist = 0;
        if (Enemigo != null)
        {
           // Disparar();
            Debug.DrawLine(this.transform.position,enemigo.transform.position,Color.red);
            dist = (Enemigo.transform.position - this.transform.position).magnitude;
        }


        if (dist <= distancia_max)
        {
            
            //Disparar();
        }
        else
        {
            
        }

    }

   /* void Disparar()  Metodo Disparar anterior al refactoring
    {
        GameObject obj = (GameObject)Instantiate(GameObject.Find("Bala"), this.transform.position, Quaternion.identity);
        Bala bala = obj.GetComponent<Bala>();
        bala.Activar(this);
    } */


        private void crearBalas(int total_balas)
    {           
        balas = new GameObject[total_balas];
        for (int i = 0; i < balas.Length; i++)
        {
            balas[i] = Instantiate(GameObject.Find("bala"),this.transform.position,Quaternion.identity);
        }
    }

    private Bala DespacharBalaLibre()
    {
        Bala libre = null;
        for (int i = 0; i < balas.Length; i++)
        {
            libre = balas[i].GetComponent<Bala>();
            if (!libre/*.disparada*/)
            {
                break;
            }
        }
        return libre;
    }



    GameObject BuscarEnemigoCercano()
    {
        ArrayList enemigos = PoolingUnidades.unidades;
        GameObject temp;
        foreach (System.Object item in enemigos)
        {
            temp = (GameObject)item;
            if (Vector3.Distance(temp.transform.position, this.transform.position) < distancia_max)
            {
                float bar = Vector3.Distance(temp.transform.position, this.transform.position);
                Debug.Log("oe" + bar);
                return temp;
            }
               
        }
        return null;
    }

    public Single Distancia_max
    {
        get
        {
            return distancia_max;
        }

        set
        {
            distancia_max = value;
        }
    }

    public GameObject Enemigo
    {
        get
        {
            return enemigo;
        }

        set
        {
            enemigo = value;
        }
    }

}
