using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCoroutines : MonoBehaviour
{
    [SerializeField] GameObject Objeto; // Se colocara el objeto que querramos mover
    [SerializeField] Transform[] puntosControl; // se guardara los puntos de controles
    [SerializeField] float velocidad = 1;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("MueveObjeto"); // se encarga de comenzar la corrutina
    }

    IEnumerator MueveObjeto() 
        // se intrega a traves de colecciones para detenernos en un punto o retornar un valos o ninguno
    {
        int i = 1;
        Vector3 nuevaPosicion = new Vector3(puntosControl[i].position.x, Objeto.transform.position.y, puntosControl[i].position.z);
        //Asignaremos una nueva posicion
        while (true)
        {
            while (Objeto.transform.position != nuevaPosicion) 
                //mientras que el enemigo no haya entrado a la nueva posicion
            {
                Objeto.transform.position = Vector3.MoveTowards(Objeto.transform.position, nuevaPosicion, velocidad * Time.deltaTime);
                // Se movera el objeto desde su posicion al siguiente punto de control
                yield return null; // la ejecucion se pausara y reanudara al siguiente
            }
            yield return StartCoroutine("RotarObjeto"); // ejecutaremos la corrutina rotarObjeto
            if (i < 7) i++; //si llega al punto de control 7 se suma para llegar al ultimo punto
            else i = 0; // sino volvera al puntoinicial
            nuevaPosicion = new Vector3(puntosControl[i].position.x, Objeto.transform.position.y, puntosControl[i].position.z);
        }
    }

    IEnumerator RotarObjeto()
    {
        yield return new WaitForSecondsRealtime(8f);
        //El objeto espera 8 segundo para que se mueva devuelta
        //WaitForSecondsRealtime utiliza tiempo no escalado, tiempo real
        for (int i = 1; i <= 90; i++) // se movera entre 1 a 90 unidades de su eje y
        {
            Objeto.transform.Rotate(0, -1, 0); // El objeto rotara 1 unidad antes de moverse
            yield return null;
        }
    }

}
