using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaminoTemporal : MonoBehaviour
{ 
     void OnCollisionEnter(Collision collision) //Una vez detectada la colision...
    {
        if(collision.gameObject.tag == "Player") //Si buscamos el gameObject con la etiqueta "Player" , entonces...
        {
            Destroy(gameObject,1f); //Cada vez que un bloque del camino entre en contacto con el jugador , este se destruira al cumplir 1 segundo.
        }
    }
}
