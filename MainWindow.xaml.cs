using System.Text;
using System.Windows;

namespace WpfExercise
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var node = Generator.GenerateRandomStructure();
            UpdateTextBlockControl(node);
            UpdateUIControl(node);
        }

        private void UpdateTextBlockControl(Node node)
        {
            var buffer = new StringBuilder();
            foreach (var child in node.Children)
            {
                Walker.Walk(child, buffer);
            }

            textBlock.Text = buffer.ToString();
        }

        private void UpdateUIControl(Node node)
        {
            // TODO
        }
    }
}
