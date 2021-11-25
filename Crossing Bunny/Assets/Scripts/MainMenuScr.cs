using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using UnityEngine.UI;

public class MainMenuScr : MonoBehaviour
{
    public AudioMixer audioMixer;
    static float volumelock;
    public float volume; 
    public Slider slider;


    private void Awake() {
           
        slider.value = volumelock;
    }

    public void SetVolume (float volume)
    { 
        //Debug.Log(volumelock);
        audioMixer.SetFloat("volume", volume);
        if(volume <= -40)
        {
            audioMixer.SetFloat("volume", -80);
        }
        volumelock = volume;
    }
    public void StartGame ()
    {
        SceneManager.LoadScene("Level1");
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void QuitGame()
    {
        Application.Quit();
    }


}
