using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogTriggerInteractable : InteractionSystem
{
    private bool interacted = false;
    public Dialogue dialogue;
    public GameObject dialougeManager;

    public void TriggerDialogue()
    {
        dialougeManager.GetComponent<DialogueSystem>().StartDialogue(dialogue);
    }

    protected override void OnCollided(GameObject collidedObject)
    {
        if (!interacted)
        {
            interacted = true;
            TriggerDialogue();
        }
    }

    protected override void OnCollidedExit()
    {
        interacted = false;
    }
}
