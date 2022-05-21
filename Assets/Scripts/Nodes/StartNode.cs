
    using System;
    using System.Linq;
    using XNode;

    [NodeWidth(80)]
    
    [NodeTint(0.0f, 0.3f, 0.0f)]
    public class StartNode: Node, IHasNextNode
    {
        [Output] public byte exit;

        public Node NextNode
        {
            get
            {
                foreach (var port in Ports)
                {
                    if (port.fieldName == "exit")
                    {
                        return port.Connection.node;
                    }
                }

                throw new Exception("dialogue has no exit???");
            }
        }

        public override object GetValue(NodePort port)
        {
            return null;
        }
    }
