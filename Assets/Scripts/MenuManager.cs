using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public void QuitGame(){
        Application.Quit();
    }

    public void ExitGame(){
    if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
    }
    
}
