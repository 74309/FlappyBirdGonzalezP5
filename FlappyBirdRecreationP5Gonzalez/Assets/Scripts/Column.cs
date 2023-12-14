using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Column : MonoBehaviour
{
    AudioSource audioSource;
    public AudioClip Score;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

        private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<Bird> () != null)
        {
            GameControl.Instance.BirdScored();
            PlaySound(Score);
        }
    }

    public void PlaySound(AudioClip clip)
    {
        audioSource.PlayOneShot(clip);
    }
}

