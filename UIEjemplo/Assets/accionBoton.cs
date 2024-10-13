using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class accionBoton : MonoBehaviour
{
    public Text textoPuntaje;

    public void BotonPresionado()
    {
        textoPuntaje.text = "Botón presionado";
    }
}
