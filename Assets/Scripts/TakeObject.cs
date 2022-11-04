using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeObject : MonoBehaviour
{
    public GameObject TakeThisObject;
    private GameObject PickedObject; //Sera el objeto que vamos a recoger.
    [SerializeField]
    private Transform Interaction; //Escogemos el transform de la zona donde queremos que se aloje el objeto que recojamos.

    // Update is called once per frame
    void Update()
    {
        if(TakeThisObject != null && TakeThisObject.GetComponent<Object>().isObject == true && PickedObject == null) //Si el objeto que queremos recoger sea diferente de nada y de este objeto,buscamos en su script, la variable isObject es un objeto que se puede recoger... y ademas y el objeto que queremos recoger es igual a null.... 
        {
            if(Input.GetKeyDown(KeyCode.R)) //Si presionamos la tecla R...
            {
             PickedObject = TakeThisObject; //El objeto que recogimos es igual al objeto que tenemos que tomar.
             PickedObject.GetComponent<Object>().isObject = false; // Si ya tomamos el objeto que queriamos y en el Script de Object la variable isObject es falsa , es decir , no podemos volver a tomarlo...
             PickedObject.transform.SetParent(Interaction); //Le asignsmos como padre la caja vacia "Interaction".
             PickedObject.transform.position = Interaction.position; //Ese objeto tendra la misma posicion que la caja de "Interaction".
             PickedObject.GetComponent<Rigidbody>().useGravity = false; //Ya no le estaria afectando la gravedad.
             PickedObject.GetComponent<Rigidbody>().isKinematic = true; //Ya no le afectara la fisica.

            }
        }
        else if(PickedObject != null) //Si tenemos el objeto ...
        {
            if(Input.GetKeyDown(KeyCode.R)) //Y pulsamos nuevamente la tecla "R" ...
            {
             PickedObject.GetComponent<Object>().isObject = true; // Podemos recoger el objeto de nuevo.
             PickedObject.transform.SetParent(null); //Seria su propio padre.
             PickedObject.GetComponent<Rigidbody>().useGravity = true; //La gravedad volveria a ser verdadera.
             PickedObject.GetComponent<Rigidbody>().isKinematic = false;
             PickedObject = null; //Ya no estaria sosteniendo el objeto.
            }
        }
    }
}
