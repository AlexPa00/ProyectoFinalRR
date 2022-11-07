using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ZonaFinal: MonoBehaviour
{ 
     public void OnTriggerEnter(Collider other)
     { //Una vez detectada la colision...
        if(other.tag == "ZonaFinal") //Si buscamos el gameObject con la etiqueta "Player" , entonces...
        {
            SceneManager.LoadScene("Winner");
            //winner.SetActive(false); //La puerta asignada no se mostrara.
        }
    }
}

