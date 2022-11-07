using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    [SerializeField]
    private float speedObstacle1 = 3f; //Nos sirve para indicar la velocidad de movimiento del obstaculo1 en el eje "x".
    [SerializeField]
    private int obstacleType; //1 : obstaculo1 - 2: obstaculo2.
    private float speedZ = 6f; //Nos sirve para indicar la velocidad de movimiento del obstaculo2 en el eje "z".

    // Start is called before the first frame update
    void Start()
    {
        switch(obstacleType)
        {
        case 1:
        {
        Destroy(gameObject,9f); //Cada vez que un Obstaculo1 se instancie , este se destruira al cumplir los 9 segundos(Al llegar al final del plano).
        break;
        }
        case 2:
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
        }
    }
}
