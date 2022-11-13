using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonajeGameOver : MonoBehaviour
{

    [SerializeField]
    private int playerType; //1 : player1 - 2: player2.
    [SerializeField]
    private float speedY= 9f;


    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }


     public void MovePlayer()
    {
         switch(playerType)
        {
            case 1:
            {
            
            break;
            }
            case 2:
            {
            if( transform.position.y < 0.6f || transform.position.y > 1.6f)
                 {
                  speedY *= -1;
                 }
                transform.Translate(0,speedY*Time.deltaTime,0); //Hara que el player2 se mueva de arriba hacia abajo en el eje "y".
                break;
            }
        }
    }
}