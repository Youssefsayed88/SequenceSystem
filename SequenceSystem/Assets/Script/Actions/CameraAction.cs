using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Scripting.APIUpdating;


public class CameraAction : SequenceAction
{
    public Transform target;

    public float speed = 5f;

    Vector3 velocity =  Vector3.zero;

    public bool move = false;

    void Update()
    {
        if(move)
        {
            transform.position = Vector3.SmoothDamp(transform.position, target.position, ref velocity, speed * Time.deltaTime);        
        }
    }

    public override IEnumerator Execute(String nullString)
    {
        move = true;
        
        if(waitToFinish)
        {
            yield return new WaitForSeconds(actionTime);
            move = false;
        }
    }
}
