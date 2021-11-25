using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseGame : MonoBehaviour
{
    public static bool GameCanBePaused = true; 
    public static bool IsntPaused = true;
    public GameObject pauseMenuUI;
    public GameObject OptionsMenuUI;
    bunny_scr bunny_scr;
    
    void Start() 
    {
        bunny_scr = GameObject.FindGameObjectWithTag("Player").GetComponent<bunny_scr>();
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.P))
        {
            if(GameCanBePaused)
            {
                if(IsntPaused)
                Pause();
                else
                Resume();
            }
        }
    }
    public void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        IsntPaused = false;
        bunny_scr.bunnycanmove = false;
        
    }
    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        IsntPaused = true;
        bunny_scr.bunnycanmove = true; 
    }
    public void QuitGame ()
    {
        IsntPaused = true;
        Time.timeScale = 1f;
        SceneManager.LoadScene("StartScreen");      
    }

    public void ChangePause()
    {
        GameCanBePaused = !GameCanBePaused;
    }
}

