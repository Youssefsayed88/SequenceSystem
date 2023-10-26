using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Simple stuct that holds both the sequence action and a string which is either the name of an animation or audio clip
[Serializable]
public struct Sequence
{
    public SequenceAction action;

    public String input;
}
