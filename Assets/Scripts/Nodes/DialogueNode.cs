using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using XNode;

[NodeTint(0.0f,0.4f,0.0f)]
public class DialogueNode : Node, IHasNextNode
{
    public Node NextNode => Outputs.First().Connection.node;

    [Input] public byte entry;

    [Output] public byte exit;
    public string speakerName;

    [TextArea(1, 10)] public string dialogueLine;
    public Sprite sprite;

    public override string ToString()
    {
        return $"Dialogue [{speakerName}:{dialogueLine[Range.EndAt(5)]}]";
    }

    public override object GetValue(NodePort port)
    {
        return null;
    }
}