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
   private float lastVolume; 
   [Header("Panels")]
   public GameObject mainPanel;
   public GameObject optionsPanel;
   public GameObject levelSelectPanel;

   private void Awake()
   {
      volumeFX.onValueChanged.AddListener(ChangeVolumeFX); //Cuando cambie el valor de slyder llame a esta funcion
      volumeMaster.onValueChanged.AddListener(ChangeVolumeMaster);
   }

   public void SetMute() //Funcion para activar el mute de musica de fondo
   {
    
     if(mute.isOn) //Si el mute esta encendido sucede esto
    {
       mixer.GetFloat("VolMaster" , out lastVolume);
        mixer.SetFloat("VolMaster" , -80);
    }
      else
      mixer.SetFloat("VolMaster" , lastVolume);
   }

   public void PlayLevel(string levelName) //Funcion para la seleccion de niveles
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

   public void ChangeVolumeMaster (float v) //Funcion que seteamos lo que queremos
   {
     mixer.SetFloat("VolMaster" ,v);
   }

    public void ChangeVolumeFX (float v) //Funcion donde colocamos que queremos que suceda
   {
     mixer.SetFloat("VolFX" ,v);
   }

   public void PlaySoundButton() //Funcion para el sonido de los botones
    {
      fxSource.PlayOneShot(clickSound);
      masterSource.PlayOneShot(clickSound);
    }
}
