using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameOver : MonoBehaviour
{
  public void RestartButton()
  {
    SceneManager.LoadScene("Level1");
  }


    public void RestartMainMenu()
    {
        SceneManager.LoadScene("MenuPrincipal");
    }
}
