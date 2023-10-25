using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraAction : SequenceAction
{
    void Start()
    {
        
    }

    void Update()
    {

    }

    public override IEnumerator Execute()
    {
        yield return new WaitForSeconds(actionTime);
    }
}
