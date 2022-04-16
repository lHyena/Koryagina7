using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class AudioMen : MonoBehaviour
{
    [SerializeField] private AudioClip _fire;
    private AudioSource _source;

    public void PlayAudio (AudioClip clip)
    {
        if (Input.GetMouseButtonDown(0))
        {
            GetComponent<AudioSource>().PlayOneShot(clip);

        }
       
    }
    
}
