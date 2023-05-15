using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DialogTriggerInteractable : InteractionSystem
{
    private bool interacted = false;
    public Dialogue dialogue;

    public void TriggerDialogue()
    {
        GetComponent<DialogueSystem>().StartDialogue(dialogue);
    }

    protected override void OnCollided(GameObject collidedObject)
    {
        if (!interacted)
        {
            interacted = true;
            Debug.Log("Interact with " + name);
            TriggerDialogue();
        }
    }

    protected override void OnCollidedExit()
    {
        interacted = false;
    }
}
