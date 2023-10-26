using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Base Class for the sequence action
public abstract class SequenceAction : MonoBehaviour
{
    [SerializeField]
    protected float actionTime; // amount of time to give to this action before continuing the sequence

    [SerializeField]
    protected bool waitToFinish = true; // Wait until it finishes or not
    
    public abstract IEnumerator Execute(String input);// abstract class that will contain each execute function
    
}
