using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenuAttribute(fileName = "New_Sequence", menuName = "My Assets/Sequence")]
public class SequenceSO : ScriptableObject
{
    public List<SequenceAction> actions;
}
