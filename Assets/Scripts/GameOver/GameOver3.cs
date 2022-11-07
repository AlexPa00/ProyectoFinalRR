using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameOver3 : MonoBehaviour
{
  public void RestartButton()
  {
        SceneManager.LoadScene("Level3");
  }
    public void RestartMainMenu()
    {
        SceneManager.LoadScene("MenuPrincipal");
    }

}
