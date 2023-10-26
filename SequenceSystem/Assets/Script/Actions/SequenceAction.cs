using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class SequenceAction : MonoBehaviour
{
    [SerializeField]
    protected float actionTime;

    [SerializeField]
    protected bool waitToFinish = true;
    
    public abstract IEnumerator Execute(String input);
    
}
