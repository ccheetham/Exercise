using System.Text;

namespace WpfExercise
{
    internal static class Walker
    {
        internal static void Walk(Node node, StringBuilder buffer, string indent = null)
        {
            indent = indent ?? string.Empty;
            buffer.Append($"{indent}{node.Text}\n");
            indent += "  ";
            foreach (var child in node.Children)
            {
                Walk(child, buffer, indent);
            }
        }
    }
}
