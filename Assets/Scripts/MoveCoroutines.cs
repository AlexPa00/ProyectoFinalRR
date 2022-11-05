using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCoroutines : MonoBehaviour
{
    [SerializeField] GameObject Objeto;
    [SerializeField] Transform[] puntosControl;
    [SerializeField] float velocidad = 1;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("MueveObjeto");
    }

    IEnumerator MueveObjeto()
    {
        int i = 1;
        Vector3 nuevaPosicion = new Vector3(puntosControl[i].position.x, Objeto.transform.position.y, puntosControl[i].position.z);
        while (true)
        {
            while (Objeto.transform.position != nuevaPosicion)
            {
                Objeto.transform.position = Vector3.MoveTowards(Objeto.transform.position, nuevaPosicion, velocidad * Time.deltaTime);
                yield return null;
            }
            yield return StartCoroutine("RotarObjeto");
            if (i < 7) i++; else i = 0;
            nuevaPosicion = new Vector3(puntosControl[i].position.x, Objeto.transform.position.y, puntosControl[i].position.z);
        }
    }

    IEnumerator RotarObjeto()
    {
        yield return new WaitForSecondsRealtime(8f);
        for(int i = 1; i <= 90; i++)
        {
            Objeto.transform.Rotate(0, -1, 0);
            yield return null;
        }
    }

}
