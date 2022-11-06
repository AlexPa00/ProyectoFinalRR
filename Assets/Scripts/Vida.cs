using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Vida : MonoBehaviour
{
    // Start is called before the first frame update
    public float maxVida = 100.0f;
    public float actualVida;
    public Text vidaText;

    private void Start()
    {
        actualVida = maxVida;
    }

    private void Update()
    {
        if (actualVida > maxVida)
            actualVida = maxVida;

        if (actualVida <= 0)
            Muerte();

        // UI
        vidaText.text = actualVida.ToString();
    }
    public void QuitarVida(float daño)
    {

        actualVida -= daño;
    }
    public void Muerte()
    {
        SceneManager.LoadScene("Game Over");
    }
}
