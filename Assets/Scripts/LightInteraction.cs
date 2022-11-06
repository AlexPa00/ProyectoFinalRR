using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightInteraction : MonoBehaviour
{
    public GameObject luzObjeto; // Se colocara el GameObject de la luz

    public bool luz;

    private bool luzOnOff; // Esta variable tiene la funcion de activar o desactivar la luz

    public void OnOffLuz()
    {
        luzOnOff = !luzOnOff; // nos indicara si la luz esta activada o no
        
        if(luzOnOff == true)
        {
            luzObjeto.SetActive(true); //Se encendera la luz
        }

        if(luzOnOff == false)
        {
            luzObjeto.SetActive(false); // Se apagara la luz
        }
    }
}
