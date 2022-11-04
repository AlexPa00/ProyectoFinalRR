using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinPartida : MonoBehaviour
{
    [SerializeField]
    private GameObject finPartida;

    // Start is called before the first frame update
    void Start()
    {
        finPartida.SetActive(false); //Una vez iniciado el juego las particulas no se mostraran.
    }

     void OnCollisionEnter(Collision collision) //Una vez detectada la colision...
    {
        if(collision.gameObject.tag == "Punto4") //Si buscamos el gameObject con la etiqueta "Punto4" , entonces...
        {
            Debug.Log("FELICIDADES , FIN DE PARTIDA"); //Se mostrara por consola el siguiente mensaje.
            finPartida.SetActive(true); //Se activaran las particulas.
        }
    }
     void OnCollisionExit(Collision collision) //Si ya no se detecta colision...
    {
        if(collision.gameObject.tag == "Punto4") //Si buscamos el gameObject con la etiqueta "Punto4" , entonces...
        {
            finPartida.SetActive(false); //Se desactivaran las particulas.
        }
    }
}
