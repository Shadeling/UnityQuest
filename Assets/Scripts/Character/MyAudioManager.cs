using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyAudioManager : MonoBehaviour
{
    [SerializeField] AudioSource MainSource;

    [SerializeField] AudioClip hurtSound;
    [SerializeField] AudioClip keyPickUpSound;
    [SerializeField] AudioClip MedKitPickUpSound;

    public bool GetPlaying()
    {
        return MainSource.isPlaying;
    }

    public void PlayHurtSound()
    {
        MainSource.PlayOneShot(hurtSound, 0.5f);
    }
    public void PlayKeyPickUpSound()
    {
        MainSource.PlayOneShot(keyPickUpSound, 0.8f);
    }

    public void PlayMedKitPickUpSound()
    {
        MainSource.PlayOneShot(MedKitPickUpSound, 0.3f);
    }
}
