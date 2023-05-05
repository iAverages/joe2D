using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialougeSystem : MonoBehaviour
{
    public TextMeshProUGUI nameBox;
    public TextMeshProUGUI dialougeBox;

    public Queue<string> sentences;
    
    void Start()
    {
        sentences = new Queue<string>();
    }

    public void StartDialouge (Dialouge dialouge)
    {
        nameBox.Text = dialouge.npc_name;

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
        dialougeBox.TextMeshProUGUI = sentence;
    }

    void EndDialouge()
    {
        Debug.Log("End of conversation");
    }

}
