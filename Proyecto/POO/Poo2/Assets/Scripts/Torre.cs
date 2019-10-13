using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torre : MonoBehaviour
{
    private GameObject enemigo;
    private float distancia_max = 1;
    private SpriteRenderer spriteRenderer2D;
    

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


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Enemigo = BuscarEnemigoCercano();
        if (Enemigo != null)
        {
            Disparar();
            Debug.DrawLine(this.transform.position,enemigo.transform.position,Color.red);
        }

       float dist = (Enemigo.transform.position - this.transform.position).magnitude;

        if (dist <= distancia_max)
        {

            Debug.DrawLine(this.transform.position, Enemigo.transform.position, Color.red);

        }
    }

    void Disparar()
    {
        GameObject obj = (GameObject)Instantiate(GameObject.Find("Bala"), this.transform.position, Quaternion.identity);
        Bala bala = obj.GetComponent<Bala>();
        bala.ActivarBala(this);
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
                return temp;
            }
               
        }
        return null;
    }
}
