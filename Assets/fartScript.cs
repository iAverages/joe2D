using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fartScript : MonoBehaviour
{

    public AudioSource fart;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.F))
        {     
            PlayRandomSound();
            
        }
    }

    public void PlayRandomSound(){
        // Debug.Log("F key was pressed.");
    }
}
