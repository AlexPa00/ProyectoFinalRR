using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    [SerializeField]
    private float speedObstacle1 = 3f; //Nos sirve para indicar la velocidad de movimiento del obstaculo1 en el eje "x".
    [SerializeField]
    private int obstacleType; //1 : obstaculo1 - 2: obstaculo2 - 3: obstaculo 3 - 4: obstaculo 4 - 5: obstaculo 5 - 6: obstaculo 6.
    private float speedZ = 6f; //Nos sirve para indicar la velocidad de movimiento del obstaculo2 en el eje "z".
    private float speedParedType5 = 4f; //Velocidad de movimiento de la pared tipo 5.
    private float speedParedType6 = 4.5f; //Velocidad de movimiento de la pared tipo 6.
    private float speedParedType7 = 2f; //Velocidad de movimiento del obstaculo tipo 7.

    // Start is called before the first frame update
    void Start()
    {
        switch(obstacleType)
        {
        
        //Nivel 1

        case 1:
        {
        Destroy(gameObject,9f); //Cada vez que un Obstaculo1 se instancie , este se destruira al cumplir los 9 segundos(Al llegar al final del plano).
        break;
        }
        case 2:
        {
        break;
        }

        //Nivel 4 -- Calabazas(case3), Fantasmas y bruja(case4).

        case 3:
        {
            Destroy(gameObject,2.8f); //Cada vez que un Obstaculo3 se instancie , este se destruira al cumplir los 2.8 segundos.
        break; 
        }
        case 4:
        {
        break;
        }

        //Paredes Moviles -- Nivel 4

         case 5:
        {
        break;
        }
         case 6:
        {
        break;
        }
         case 7:
        {
        break;
        }
    }
    }

    // Update is called once per frame
    void Update()
    {
        MoveObstacle();
    }


     public void MoveObstacle()
    {
         switch(obstacleType)
        {
            //Nivel 1 --

            case 1:
            {
            transform.Translate(speedObstacle1*Time.deltaTime,0,0); //Hara que el obstaculo1 se mueva hacia adelante en el eje "x".
            break;
            }
            case 2:
            {
            if(transform.position.z > -23f || transform.position.z < -31.14f)
                 {
                  speedZ *= -1;
                 }
                transform.Translate(0,0,speedZ*Time.deltaTime); //Hara que el obstaculo2 se mueva de izquierda a derecha en el eje "z".
                break;
            }

            //Nivel 4 -- Calabazas(case3), Fantasmas y bruja(case4).
            case 3:
            {
                transform.Translate(speedObstacle1*Time.deltaTime,0,0); //Hara que el obstaculo3 se mueva hacia un lado en el eje "x".
            break;
            }
            case 4:
            {
            if(transform.position.z > -5.34f || transform.position.z < -15.5f)
                 {
                  speedZ *= -1;
                 }
                transform.Translate(0,0,speedZ*Time.deltaTime); //Hara que el obstaculo5 se mueva de izquierda a derecha en el eje "z".
                break;
            }

            //Paredes Moviles -- Nivel 4

            case 5:
            {
            if(transform.position.y > 12.58f || transform.position.y < 8.84f)
                 {
                  speedParedType5 *= -1;
                 }
                transform.Translate(0,speedParedType5*Time.deltaTime,0); //Hara que el obstaculo6 se mueva de arriba hacia abajo en el eje "y".
                break;
            }
             case 6:
            {
            if(transform.position.z > -7.49f || transform.position.z < -16.67f)
                 {
                  speedParedType6 *= -1;
                 }
                transform.Translate(0,0,speedParedType6*Time.deltaTime); //Hara que el obstaculo7 se mueva de izquierda a derecha en el eje "z".
                break;
            }
            case 7:
            {
                transform.Translate(0,speedParedType7*Time.deltaTime,0); //Hara que el obstaculo7 se mueva de izquierda a derecha en el eje "z".
                break;
            }

        }
        
    }

}
