using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AudioAction : SequenceAction
{
    AudioSource audioSource;
    AudioClip audioClip;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        audioClip = audioSource.clip;

        actionTime = audioClip.length;
    }

    public override IEnumerator Execute()
    {
        audioSource.Play();

        if (waitToFinish)
        {
            yield return new WaitForSeconds(actionTime);
        }
    }
}
