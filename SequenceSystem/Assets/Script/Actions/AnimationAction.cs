using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class AnimationAction : SequenceAction
{
    Animator animator;

    public AnimationClip[] clips;


    void Start()
    {
        animator =  GetComponent<Animator>();
    }

    //play the first clip in the animator's animationClips
    public override IEnumerator Execute(String clipName){

        foreach(AnimationClip clip in clips)
        {
            if(clip.name == clipName){
                actionTime = clip.length;
                animator.Play(clip.name);
            }
        }

        if (waitToFinish)
        {
            yield return new WaitForSeconds(actionTime);
        }
    }
}
