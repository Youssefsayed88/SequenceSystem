using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AudioAction : SequenceAction
{
    AudioSource audioSource;
    public AudioClip[] clips;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public override IEnumerator Execute(String clipName)
    {
        foreach(AudioClip clip in clips)
        {
            if(clip.name == clipName)
            {
                audioSource.clip = clip;
                actionTime = clip.length;
                audioSource.Play();
            }
        }

        if (waitToFinish)
        {
            yield return new WaitForSeconds(actionTime);
        }
    }
}
