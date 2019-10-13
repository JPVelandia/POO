using System.Collections;
using UnityEngine;

public class PoolingUnidades : MonoBehaviour
{
    public static ArrayList unidades = new ArrayList();

    // Start is called before the first frame update
    void Start()
    {
        GameObject unidad = GameObject.Find("Fantasma");
        GameObject temp;
        Vector3 incremento = new Vector3(0, 1);
        Vector3 posicion_inicial = unidad.transform.position;

        for (int i = 0; i < 10; i++)
        {
            temp = Instantiate(unidad, posicion_inicial + incremento, Quaternion.identity);
            posicion_inicial = temp.transform.position;
            unidades.Add(temp);
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}