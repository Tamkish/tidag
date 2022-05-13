using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class test_input : MonoBehaviour
{
    public TextMeshProUGUI speaker;
    public TextMeshProUGUI text;

    public Image imag;
    //public Sprite sprite;
    
    public DialogueGraph will_xellos;

    public NodeReader reader;
    // Start is called before the first frame update
    void Start()
    {
        reader.StartDialogue(will_xellos);
        DisplayDialogue(reader.GetDialogue());
    }


    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            reader.Continue();
            DisplayDialogue(reader.GetDialogue());
        }
    }

    void DisplayDialogue(DialogueNode dialogueNode)
    {
        if (dialogueNode == null)
        {
            Application.Quit();
        }
        
        speaker.SetText(dialogueNode.speakerName);
        text.SetText(dialogueNode.dialogueLine);
        imag.sprite = dialogueNode.sprite;
    }
    
}
