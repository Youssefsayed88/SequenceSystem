using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class AnimationAction : SequenceAction
{
    public Animator animator;

    string clipName;

    void Start()
    {
        AnimationClip clip = animator.runtimeAnimatorController.animationClips[0];

        clipName = clip.name;
        actionTime = clip.length;
    }

    //play the first clip in the animator's animationClips
    public override IEnumerator Execute(){
        animator.Play(clipName);

        if (waitToFinish)
        {
            yield return new WaitForSeconds(actionTime);
        }
    }
}
