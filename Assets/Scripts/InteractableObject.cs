using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InteractableObject : InteractionSystem
{
    private bool Interacted = false;


    protected override void OnCollided(GameObject collidedObject)
    {
        if (collidedObject == null)
        {
            HidePrompt();
            return;
        }

        DisplayPrompt();
        FindObjectOfType<DialogueTrigger>().TriggerDialogue();
        if (Input.GetKey(KeyCode.E))
        {
            OnInteract();
            StartGame();
        }
    }

    protected virtual void OnInteract()
    {
        if (!Interacted)
        {
            Interacted = true;
            Debug.Log("Interact with " + name);
        }
    }

    public void DisplayPrompt()
    {
        PlayerPrompt.SetActive(true);
        isDisplayed = true;
    }

    public void HidePrompt()
    {
        PlayerPrompt.SetActive(false);
        isDisplayed = false;
    }


    public void StartGame()
    {
        SceneManager.LoadScene(gameStartScene);
        ResumeGame();
    }


    public void ResumeGame()
    {
        Time.timeScale = 1f;
    }
}
