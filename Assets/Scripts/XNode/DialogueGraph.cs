using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using XNode;

[CreateAssetMenu]
public class DialogueGraph : NodeGraph
{
    public StartNode Start => nodes.Find(node => node is StartNode) as StartNode;
    
}