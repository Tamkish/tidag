using System;
using UnityEditor;
using UnityEngine.UIElements;

namespace DialogueSystem.Windows
{
    public class DSEditorWindow : EditorWindow
    {
        [MenuItem("Dialogue/Dialogue Graph")]
        public static void ShowExample()
        {
            DSEditorWindow wnd = GetWindow<DSEditorWindow>("DialogueGraph");
        }

        private void OnEnable()
        {
            AddGraphView();
            AddStyles();
        }

        private void AddStyles()
        {
            StyleSheet styleSheet = (StyleSheet)EditorGUIUtility.Load("DialogueSystem/DSVariables.uss");
            
            rootVisualElement.styleSheets.Add(styleSheet);
        }

        private void AddGraphView()
        {
            DSGraphView graphView = new DSGraphView();

            graphView.StretchToParentSize();
            
            rootVisualElement.Add(graphView);
        }
        
        
        /*public void CreateGUI()
        {
            // Each editor window contains a root VisualElement object
            VisualElement root = rootVisualElement;

            // VisualElements objects can contain other VisualElement following a tree hierarchy.
            VisualElement label = new Label("Hello World! From C#");
            root.Add(label);
        }*/
    }
}