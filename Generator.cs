using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfExercise
{
    static internal class Generator
    {

        internal static Node GenerateRandomStructure()
        {
            var random = new Random();
            var node = new Node
            {
                Text = "root",
            };

            var iMax = random.Next(5) + 2;
            for (var i = 1; i <= iMax; ++i)
            {
                var iNode = new Node
                {
                    Text = $"{i}",
                };
                node.Children.Add(iNode);
                var jMax = random.Next(5) + 2;
                for (var j = 1; j <= jMax; ++j)
                {
                    var jNode = new Node
                    {
                        Text = $"{i}:{j}",
                    };
                    iNode.Children.Add(jNode);
                    var kMax = random.Next(5) + 2;
                    for (var k = 1; k <= kMax; ++k)
                    {
                        var kNode = new Node
                        {
                            Text = $"{i}:{j}:{k}",
                        };
                        jNode.Children.Add(kNode);
                    }
                }
            }

            return node;
        }
    }
}
