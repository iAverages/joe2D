using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class Dialouge
{
    
    public string npc_name;

    [TextArea(3, 10)]
    public string[] sentences;

}
