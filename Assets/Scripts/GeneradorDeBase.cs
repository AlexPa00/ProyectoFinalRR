using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorDeBase : MonoBehaviour
{ 
    [SerializeField]
    private GameObject puerta; //Llamaremos la puerta que corresponda.
   
    void Start()
    {
        puerta.SetActive(true); //Una vez inicie el juego la puerta asignada se mostrara.
         
    }

     void OnCollisionEnter(Collision collision) //Una vez detectada la colision...
    {
        if(collision.gameObject.tag == "Player") //Si buscamos el gameObject con la etiqueta "Player" , entonces...
        {
             
            puerta.SetActive(false); //La puerta asignada no se mostrara.
        }
    }
}
