using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playMusica : MonoBehaviour
{
    public AudioSource miMusica;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (miMusica != null)
            {
                if (miMusica.isPlaying)
                {
                    miMusica.Stop();
                }
                else
                {
                    miMusica.Play();
                }
                
            }
        }
    }
}
