using SqlSchema.Library.Models;
using System.Windows.Forms;

namespace GenClassesFromQuery.Controls.Nodes
{
    public class ParameterNode : TreeNode
    {
        public ParameterNode(Argument arg) : base(arg.Name)
        {
            ImageKey = "param-in";
            SelectedImageKey = "param-in";
            Argument = arg;
        }

        public Argument Argument { get; }
    }
}