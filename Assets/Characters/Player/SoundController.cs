using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{
    [SerializeField] AudioClip[] sounds;
    AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {

    }

    public void PlayRandomSound()
    {
        AudioClip clip = sounds[UnityEngine.Random.Range(0, sounds.Length)];
        audioSource.PlayOneShot(clip);
    }
}
