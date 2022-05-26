using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using Tidag.Dialogues;


namespace Tidag
{
    [CreateAssetMenu]
    public class Character : ScriptableObject
    {
        [InspectorName("Name")]
        public string displayName;

        public List<DialogueGraph> dialogues;
    }
}