using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;
using XNode;

namespace Tidag.Dialogues
{
    public class StartNode : Node, IHasOneExit
    {
        [Output] public byte exit;

        public Node NextNode
        {
            get
            {
 return               Outputs.First().node;
            }
        }
    }
}
