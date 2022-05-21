
    using System;
    using UnityEngine;
    using XNode;
    
    
    [NodeTint(0.0f,0.3f,0.2f)]
    public class PathNode: Node, IHasNextNode
    {
        [Output] public byte pass;
        [Input(ShowBackingValue.Never)] public byte entry;
        [Input] public bool condition;
        [Output] public byte fail;

        public Node NextNode
        {
            get
            {
                var portname = condition ? "pass" : "fail";

                foreach (NodePort port in Outputs)
                {
                    if (port.fieldName ==  portname)
                    {
                        return port.node;
                    }
                }

                throw new Exception("condition did " + portname + " and port wasn't found??");
            }
            
        }
    }
