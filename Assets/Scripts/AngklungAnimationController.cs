using UnityEngine;

public class AngklungAnimationController : MonoBehaviour
{
    private Animator AngklungAnimator;  // Reference to the Animator component
    private AudioSource AngklungAudioSource;  // Reference to the AudioSource component

    void Start()
    {
        // Automatically find and assign the Animator component
        AngklungAnimator = GetComponent<Animator>();
        // Automatically find and assign the AudioSource component
        AngklungAudioSource = GetComponent<AudioSource>();
    }

    public void PlayAnimationAndSound()
    {
        // Play the animation
        if (AngklungAnimator != null)
        {
            Debug.Log("Setting PlayAngklung trigger");
            AngklungAnimator.SetTrigger("PlayAngklung");
        }
        else
        {
            Debug.LogError("AngklungAnimator is null");
        }

        // Play the sound
        if (AngklungAudioSource != null)
        {
            AngklungAudioSource.Play();
        }
        else
        {
            Debug.LogError("AngklungAudioSource is null");
        }
    }
}
