using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class actualizarTexto : MonoBehaviour
{
    public Text texto;
    int contador = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    
        if(Input.GetKeyDown(KeyCode.LeftAlt))
        {
            contador++;
            texto.text=contador.ToString();
        }
    }
}
