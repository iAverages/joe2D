using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableObject : InteractionSystem
{
    private bool Interacted = false;
    private bool isDisplayed = false;

    protected override void OnCollided(GameObject collidedObject)
    {
        if (collidedObject == null)
        {
            HidePrompt();
            return;
        } 

        DisplayPrompt();
        if (Input.GetKey(KeyCode.E))
        {
            OnInteract();
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

    public void DisplayPrompt(){
        PlayerPrompt.SetActive(true);
        isDisplayed = true;
    }

    public void HidePrompt(){
        PlayerPrompt.SetActive(false);
        isDisplayed = false;
    }
}
