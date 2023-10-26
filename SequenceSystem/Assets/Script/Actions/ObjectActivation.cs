using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectActivation : SequenceAction
{
    public override IEnumerator Execute(String nullString)
    {
        gameObject.SetActive(true);
        yield return new WaitForSeconds(actionTime);
    }
}
