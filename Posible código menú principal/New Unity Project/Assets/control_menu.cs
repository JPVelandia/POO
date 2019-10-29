using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class control_menu : MonoBehaviour
{
    public void Jugar()
    {
        SceneManager.LoadScene(1);
    }

    public void Regresar()
    {
        SceneManager.LoadScene(0);
    }

    public void Instrucciones()
    {
        SceneManager.LoadScene(2);
    }

    public void Creditos()
    {
        SceneManager.LoadScene(3);
    }

    public void Salir()
    {
        Debug.Log("Se ha cerrado el juego");
        Application.Quit();
    }
}
