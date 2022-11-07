using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene4 : MonoBehaviour
{
            public void OnTriggerEnter(Collider other)
             {
              if(other.tag == "Player") //Se cumple solo si , aquel que tiene como tag "Player" entra en colision.
              {
               SceneManager.LoadScene("Game Over4"); //Cambio de escena.
              }
             }
}

