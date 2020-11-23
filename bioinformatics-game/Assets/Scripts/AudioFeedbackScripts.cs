using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioFeedbackScripts : MonoBehaviour
{
    public AudioClip animalCollectedSound;
    public AudioClip positiveSound;
    public AudioClip negativeSound;
    public AudioClip moduleCompletedSound;

    public AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void PlayAnimalCollected()
    {
        audioSource.PlayOneShot(animalCollectedSound);
    }

    public void PlayCorrectAnswer()
    {
        audioSource.PlayOneShot(positiveSound);
    }

    public void PlayWrongAnswer()
    {
        audioSource.PlayOneShot(negativeSound);
    }

    public void PlayModuleCompleted()
    {
        audioSource.PlayOneShot(moduleCompletedSound);
    }
}
