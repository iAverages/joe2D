using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGameController : MonoBehaviour
{     

    public static bool isPaused = false;

    public GameObject PauseMenu;

    
    void Start()
    {
        isPaused = false;
        PauseMenu.SetActive(false);
    }

    
    void Update()
    {
        //if(Input.GetKey(KeyCode.Escape))
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if(isPaused)
            {
                ResumeGame();        
            }else
            {
                PauseGame();
            }
        }
    }

    public void PauseGame()
    {
    PauseMenu.SetActive(true);
    Time.timeScale = 0f;
    isPaused = true;
    }

    public void ResumeGame()
    {
    PauseMenu.SetActive(false);
    Time.timeScale = 1f;
    isPaused = false;
    }   
}

