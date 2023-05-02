using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialougeSystem : MonoBehaviour
{
    public Queue<string> sentences;

    
    void Start()
    {
        sentences = new Queue<string>();
    }

    
}
