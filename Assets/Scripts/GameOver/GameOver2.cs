using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameOver2 : MonoBehaviour
{
  public void RestartButton()
  {
        SceneManager.LoadScene("Level2");
    }


    public void RestartMainMenu()
    {
        SceneManager.LoadScene("MenuPrincipal");
    }
}

