using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object : MonoBehaviour
{
    public bool isObject = true; //Indica si es un objeto que se puede tomar.

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "PlayerInteraction") //Si la etiqueta del Trigger que estamos colisionando es "PlayerInteraction", queremos que...
        {
            other.GetComponentInParent<TakeObject>().TakeThisObject = this.gameObject; //busque un componente en el padre (Script "TakeObject") y llamamos a la variable "TakeThisObject" .. y esta sera igual a este gameObject que vendia a ser "Object".
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "PlayerInteraction") //Si la etiqueta del Trigger que estamos colisionando es "PlayerInteraction", queremos que...
        {
            other.GetComponentInParent<TakeObject>().TakeThisObject = null; //busque un componente en el padre (Script "TakeObject") y llamamos a la variable "TakeThisObject" .. y esta sera igual a un valor vacio.
            /*cada vez que salgamos de la zona de interaccion , dejaria de detectarlo*/
        }
    }
}
