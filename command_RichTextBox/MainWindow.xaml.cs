using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace command_RichTextBox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Clear_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            TextBox.Document.Blocks.Clear();
        }
    }
    public class ColorCommands
    {
        static ColorCommands()
        {
            Clear = new RoutedCommand("Clear", typeof(ColorCommands));
        }
        public static RoutedCommand Clear { get; set; }
    }
}
