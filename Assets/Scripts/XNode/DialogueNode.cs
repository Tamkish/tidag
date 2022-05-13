using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using XNode;

public class DialogueNode : BaseNode, IHasSingleExit
{
    public NodePort ExitPort

    {
        get
        {
            foreach (var port in Ports)
            {
                if (port.fieldName == "exit")
                {
                    return port;
                }
            }

            throw new Exception("exit does not exist");

        }
    }

    [Input] public bool entry;
    [Output] public bool exit;
    public string speakerName;
    public string dialogueLine;
    public Sprite sprite;

    /*public override string GetString()
    {
        return "string";
    }*/

    public override string ToString()
    {
        return $"Dialogue [{speakerName}:{dialogueLine[Range.EndAt(5)]}]";
    }
}