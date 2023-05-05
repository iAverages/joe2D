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

    public void StartDialouge(Dialouge dialouge)
    {
<<<<<<< HEAD
        nameBox.text = dialouge.npc_name;
=======
        // nameBox.Text = dialouge.npc_name;
>>>>>>> 97d901a106528c82cac2998813e9d4aa2f7ebf17

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
<<<<<<< HEAD
        dialougeBox.text = sentence;
=======
        // dialougeBox.TextMeshProUGUI = sentence;
>>>>>>> 97d901a106528c82cac2998813e9d4aa2f7ebf17
    }

    void EndDialouge()
    {
        Debug.Log("End of conversation");
    }
}
