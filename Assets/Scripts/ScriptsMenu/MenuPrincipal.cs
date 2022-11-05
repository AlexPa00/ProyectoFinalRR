using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Audio;


public class MenuPrincipal : MonoBehaviour
{
   [Header("Options")]
   public Slider volumeFX;
   public Slider volumeMaster;
   public Toggle mute;
   public AudioMixer mixer;  
   public AudioSource fxSource;
   public AudioSource masterSource;
   public AudioClip clickSound;
   [Header("Panels")]
   public GameObject mainPanel;
   public GameObject optionsPanel;
   public GameObject levelSelectPanel;

   private void Awake()
   {
      volumeFX.onValueChanged.AddListener(ChangeVolumeFX); //Cuando cambie el valor de slyder llame a esta funcion
      volumeMaster.onValueChanged.AddListener(ChangeVolumeMaster);
   }

   public void PlayLevel(string levelName)
   {
     SceneManager.LoadScene(levelName);
   }

   public void OpenPanel(GameObject panel) //Funcion para el intercambio de paneles.
   {
    mainPanel.SetActive(false);
    optionsPanel.SetActive(false);
    levelSelectPanel.SetActive(false);

    panel.SetActive(true);
    PlaySoundButton(); 
   }

   public void ChangeVolumeMaster (float v) //Funsion que seteamos lo que queremos
   {
     mixer.SetFloat("VolMaster" ,v);
   }

    public void ChangeVolumeFX (float v)
   {
     mixer.SetFloat("VolFX" ,v);
   }

   public void PlaySoundButton()
    {
      fxSource.PlayOneShot(clickSound);
      masterSource.PlayOneShot(clickSound);
    }
}
