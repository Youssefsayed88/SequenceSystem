using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Acts like a switch, if active then disable if disabled then activate
public class ObjectActivation : SequenceAction
{
    bool isActive;

    void Start()
    {
        isActive = gameObject.activeInHierarchy;
    }
    public override IEnumerator Execute(String nullString)
    {
        if(isActive){gameObject.SetActive(false);}
        else{gameObject.SetActive(true);}

        yield return new WaitForSeconds(actionTime);
    }
}
