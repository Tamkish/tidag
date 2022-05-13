
    using System.Linq;
    using XNode;

    public class StartNode: BaseNode, IHasSingleExit
    {
        [Output] public bool exit;

        public NodePort ExitPort => Ports.First();

        public override object GetValue(NodePort port)
        {
            return null;
        }
    }
