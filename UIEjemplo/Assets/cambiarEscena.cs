using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cambiarEscena : MonoBehaviour
{
    public void CambiarEscena(int escenaID)
    {
        SceneManager.LoadScene(escenaID);
    }
}
