using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorBloques : MonoBehaviour
{ 
    [SerializeField]
    private GameObject generador; //Llamaremos al generador que corresponda.
   
    void Start()
    {
        generador.SetActive(false); //Una vez inicie el juego el generador4 asignado no se movera y por lo tanto, los bloques no se mostraran.
         
    }

     void OnCollisionEnter(Collision collision) //Una vez detectada la colision...
    {
        if(collision.gameObject.tag == "Player") //Si buscamos el gameObject con la etiqueta "Player" , entonces...
        {
             
            generador.SetActive(true); //El generador4 asignado empezara a generar los bloques.
        }
    }
}

