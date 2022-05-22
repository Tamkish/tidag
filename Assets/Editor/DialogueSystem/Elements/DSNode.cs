using System;
using System.Collections.Generic;
using DialogueSystem.Enums;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UIElements;


namespace DialogueSystem.Elements
{
    public class DSNode: Node
    {
        public string DialogueName { get; set; }
        public List<string> Choices { get; set; }
        public string Text { get; set; }
        public DSDialogueType DialogueType { get; set; }

        public void Initialize(Vector2 position)
        {
            DialogueName = "DialogueName";
            Choices = new List<string>();
            Text = "Dialogue text";
            
            SetPosition(new Rect(position,Vector2.zero));
        }

        public void Draw()
        {
            /* TITLE CONTAINER */
            TextField dialogueNameTextField = new TextField()
            {
                value = DialogueName
            };
            titleContainer.Insert(0,dialogueNameTextField);

            Port inputPort = InstantiatePort(Orientation.Horizontal, Direction.Input, Port.Capacity.Multi, typeof(Byte));

            inputPort.portName = "Dialogue  Connection";
            
            inputContainer.Add(inputPort);

            /* EXTENSIONS CONTAINER*/
            VisualElement customDataContainer = new VisualElement();

            Foldout textFoldout = new Foldout()
            {
                text = "Dialogue Text"
            };
            TextField textTextField = new TextField()
            {
                value = Text
            };
            textFoldout.Add(textTextField);
            customDataContainer.Add(textFoldout);
            extensionContainer.Add(customDataContainer);
            
            RefreshExpandedState();
        }
        
    }
}