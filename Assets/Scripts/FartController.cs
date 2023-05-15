using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FartController : MonoBehaviour
{
    [SerializeField]
    AudioClip[] sounds;
    AudioSource audioSource;
    Animator animator;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            PlayRandomSound();
        }

        AnimatorStateInfo animatorStateInfo = animator.GetCurrentAnimatorStateInfo(0);
        // Check if fart animation is running
        if (animator.GetCurrentAnimatorStateInfo(0).IsName("player_fart"))
        {
            float animationTime = animatorStateInfo.normalizedTime;

            // If animationTime is more than 1 then the animation has finsihed running
            // (Animation does not loop)
            if (animationTime > 1.0f)
            {
                animator.Play("player_idle");
            }
        }
    }

    public void PlayRandomSound()
    {
        AudioClip clip = sounds[UnityEngine.Random.Range(0, sounds.Length)];
        audioSource.PlayOneShot(clip);
        animator.Play("player_fart");
    }
}
