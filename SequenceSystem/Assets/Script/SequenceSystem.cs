using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SequenceSystem : MonoBehaviour
{
    public List<SequenceAction> sequence;

    void Start()
    {
        StartCoroutine(ExecuteSequence());
    }

    //For Scalability this function can be transformed into an event
    IEnumerator ExecuteSequence(){
        foreach (SequenceAction action in sequence)
        {
            yield return action.Execute(); // This will call the specific Execute method of the derived class.
        }
    }
}
