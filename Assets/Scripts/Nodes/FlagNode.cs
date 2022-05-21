using Unity.VisualScripting;
using UnityEngine;
using XNode;

//[NodeWidth(400)]
[NodeTint(0.4f,0.4f,0.0f)]
public class FlagNode : Node
{
[InspectorWide]
    public FlagName flag;
    [Output] public bool output;
}