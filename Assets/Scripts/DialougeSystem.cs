using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialougeSystem : MonoBehaviour
{
    public TMP_Text npcName;
    public TMP_Text dialouge;

    public Queue<string> sentences;

    
    void Start()
    {
        sentences = new Queue<string>();
    }

    public void StartDialouge (Dialouge dialouge)
    {
        npcName.TMP_Text = dialouge.npc_name;

        sentences.Clear();

        foreach (string sentence in dialouge.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }
    
    public void DisplayNextSentence()
    {
        if (sentences.Count == 0)
        {
            EndDialouge();
            return;
        }
        string sentence = sentences.Dequeue();
        dialouge.TMP_Text = sentence;
    }

    void EndDialouge()
    {
        Debug.Log("End of conversation");
    }

}
