using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightRaycast : MonoBehaviour
{
    public int rango; // tamaño del rayo entre la camara y el impacto
    public Camera camara;

    void Update()
    {
        RaycastHit hit;
        if(Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit, rango))
            // creamos un rayo en la posicion de la camara hacien el frente en un determinado rango
        {
            if(hit.collider.GetComponent<LightInteraction>() == true)
            // si el rayo colisiona en el objeto donde esta el script LightInteraction
            {
                if (Input.GetKeyDown(KeyCode.E))
            // Si apretamos la tecla E
                {
                    if(hit.collider.GetComponent<LightInteraction>().luz == true)
                    {
                        hit.collider.GetComponent<LightInteraction>().OnOffLuz();
                        // llamara a la funcion OnoffLuz del script LightInteraction
                    }
                }
            }
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.blue; // El rayo tendra el color azul
        Gizmos.DrawRay(Camera.main.transform.position, Camera.main.transform.forward * rango);
        // se dibujara en la misma posicion que se creo el rayo
    }
}
