using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using XNode;

public class NodeReader : MonoBehaviour
{
    //private Coroutine _reader;
    private DialogueGraph _graph;
    private Node _current;

    public void StartDialogue(DialogueGraph graph)
    {
        //end current dialogue 
        //...

        _graph = graph;
        var start = _graph.Start;
        _current = start.Ports.First().Connection.node;
    }

    public void Continue()
    {
        if (_current is IHasNextNode exit)
        {
            _current = exit.NextNode;
        }
    }

    public DialogueNode GetDialogue()
    {
        if (_current is DialogueNode dialogue)
        {
            return dialogue;
        }
        else
        { 
            return null;
        }
    }

/*
    public DialogueGraph graph;
    private Coroutine _reader;

    private void Start()
    {
        foreach (BaseNode b in graph.nodes)
        {
            graph.current = b;
            break;
        }

        _reader = StartCoroutine(ParseNode());

        IEnumerator ParseNode()
        {
            BaseNode b = graph.current;
            string data = b.GetString();
            string[] dataParts = data.Split('/');
        }
    }
    */
}