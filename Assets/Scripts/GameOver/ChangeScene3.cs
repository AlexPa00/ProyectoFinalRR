using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene3 : MonoBehaviour
{
            public void OnTriggerEnter(Collider other)
             {
              if(other.tag == "Player") //Se cumple solo si , aquel que tiene como tag "Player" entra en colision.
              {
               SceneManager.LoadScene("Game Over3"); //Cambio de escena.
              }
             }
}