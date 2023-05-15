using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneInteractable : InteractionSystem
{
    private bool Interacted = false;
    public int gameStartScene;
    public GameObject PlayerPrompt;

    protected override void OnCollided(GameObject collidedObject)
    {
        DisplayPrompt();

        if (Input.GetKey(KeyCode.E))
        {
            OnInteract();
            ChangeScene();
        }
    }

    protected override void OnCollidedExit()
    {
        HidePrompt();
    }

    protected virtual void OnInteract()
    {
        if (!Interacted)
        {
            Interacted = true;
            Debug.Log("Interact with " + name);
        }
    }

    public void ChangeScene()
    {
        SceneManager.LoadScene(gameStartScene);
        Time.timeScale = 1f;
    }

    public void DisplayPrompt()
    {
        PlayerPrompt.SetActive(true);
        hasCollided = true;
    }

    public void HidePrompt()
    {
        PlayerPrompt.SetActive(false);
        hasCollided = false;
    }
}
