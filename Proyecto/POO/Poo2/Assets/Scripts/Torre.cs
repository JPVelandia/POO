using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torre : MonoBehaviour
{
    public GameObject enemigo;
    private float distancia_max = 2;
    private bool contacto;
    private SpriteRenderer spriteRenderer2D;  


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float dist = (enemigo.transform.position - this.transform.position).magnitude;

        if (dist <= distancia_max)
        {
            Debug.DrawLine(this.transform.position, enemigo.transform.position, Color.red);

        }
    }


    void OnCollisionEnter2D(Collision2D col)
    {

        Debug.Log("OnCollisionEnter2D");
    }

    /* private void OnCollisionEnter2D(Collider2D collision)
     {

         spriteRenderer2D.enabled = false;
         Debug.Log("Lo toca");

         if (collision.tag == "Enemy")
         {
             Object.Destroy(gameObject);
             Debug.Log("Lo toca");
         }
     }
     */


}
