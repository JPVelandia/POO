using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuardarPosBala : MonoBehaviour
{
   public static void Guardar(Vector3 Posicion)
    {
        PlayerPrefs.SetFloat("x", Posicion.x);
        PlayerPrefs.SetFloat("y", Posicion.y);
        PlayerPrefs.SetFloat("z", Posicion.z);
    }

    public static Vector3 Cargar()
    {
        Vector3 Posicion;
        Posicion.x = PlayerPrefs.GetFloat("x");
        Posicion.y = PlayerPrefs.GetFloat("y");
        Posicion.z = PlayerPrefs.GetFloat("z");

        return Posicion;
    }

}
