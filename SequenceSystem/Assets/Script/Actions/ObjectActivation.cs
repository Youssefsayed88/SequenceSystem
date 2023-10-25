using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectActivation : SequenceAction
{
    public override IEnumerator Execute()
    {
        gameObject.SetActive(false);
        yield return new WaitForSeconds(actionTime);
    }
}
