using System;
using System.Collections.ObjectModel;

namespace WpfExercise
{
    public class Node
    {
        public string Text { get; set; }
        public ObservableCollection<Node> Children { get; } = new ObservableCollection<Node>();
    }
}
