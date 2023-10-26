using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SequenceSystem : MonoBehaviour
{
    public Sequence[] sequences;

    void Start()
    {
        StartCoroutine(ExecuteSequence());
    }

    //For Scalability this function can be transformed into an event
    IEnumerator ExecuteSequence(){
        foreach (Sequence sequence in sequences)
        {
            yield return sequence.action.Execute(sequence.input); // This will call the specific Execute method of the derived class.
        }
    }
}
