using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
            public void OnTriggerEnter(Collider other)
             {
              if(other.tag == "Player") //Se cumple solo si , aquel que tiene como tag "Player" entra en colision.
              {
               SceneManager.LoadScene("Game Over"); //Cambio de escena.
              }
             }
}