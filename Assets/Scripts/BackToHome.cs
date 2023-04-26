using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToHome : MonoBehaviour
{
    public int gameStartScene;

    public void StartGame(){
        SceneManager.LoadScene(gameStartScene);
    }
}