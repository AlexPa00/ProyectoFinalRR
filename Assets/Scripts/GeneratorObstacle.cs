using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratorObstacle : MonoBehaviour
{
    [SerializeField] //Sirve para poder manipularla desde la ventana de Unity.
    private GameObject obstacle; //Como necesitamos generar dos tipos de obstaculos , le asignaremos cierto obstaculo al Generador que corresponda.
    [SerializeField]
    private float initTime;
    [SerializeField]
    private float repeatTime;
    [SerializeField]
    private int generatorType; //1 : Generador1 - 2: Generador2.
    private float speedZ = 2f; //Nos sirve para indicar la velocidad de movimiento del Generador1 en el eje "z".
    private int cantidadObstacle2 = 0;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("GenerateObstacle",initTime,repeatTime); //Se va a invocar este metodo a cierto tiempo inicial y repetirlo cada tantos segundos , todo a eleccion.
    }

    // Update is called once per frame
    void Update()
    {
        MoveGenerator(); //Invocamos al metodo que hara que el Generador se mueva como corresponda.
    }

     public void GenerateObstacle()
    {
        switch(generatorType)
        {
            case 1:
            {
                Instantiate(obstacle,transform.position,transform.rotation); //Instanciamos el objeto a clonar que en este caso es el obstaculo1, en la posicion y rotacion del generador 1.
                break;
            }
            case 2:
            {
                if(cantidadObstacle2 <= 0) //Si la cantidad de obstaculo2 es menor o igual a 0 entonces se ejecutara este condicional,lo que nos permite crear solamente 1 obstaculo2 en el Generador2.
                {
                Instantiate(obstacle,transform.position,transform.rotation); //Instanciamos el objeto a clonar que en este caso es el obstaculo2, en la posicion y rotacion del generador 2.
                cantidadObstacle2++; 
                }
                break;
            }
        } 
    }

    public void MoveGenerator()
    {
       switch(generatorType)
        {
            case 1:
            {
                if(transform.position.z < 15f || transform.position.z > 21f)
                 {
                  speedZ *= -1;
                 }
                transform.Translate(0,0,speedZ*Time.deltaTime); //Hara que el Generador1 se mueva de izquierda a derecha en el eje "z".
                break;
            }
             case 2:
            {
                break; //El Generador2 no se movera.
            }
        }
    } 

}
