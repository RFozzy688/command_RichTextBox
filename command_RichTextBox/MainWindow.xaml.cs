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
        private void Font15_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            TextBox.FontSize = 15;
        }
        private void Font30_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            TextBox.FontSize = 30;
        }
        private void Red_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            TextBox.Foreground = Brushes.Red;
        }
        private void Green_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            TextBox.Foreground = Brushes.Green;
        }
        private void Blue_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            TextBox.Foreground = Brushes.Blue;
        }
    }
    public class MyCommands
    {
        public static RoutedCommand Clear { get; set; }
        public static RoutedCommand Font15 { get; set; }
        public static RoutedCommand Font30 { get; set; }
        public static RoutedCommand Red { get; set; }
        public static RoutedCommand Green { get; set; }
        public static RoutedCommand Blue { get; set; }
        static MyCommands()
        {
            Clear = new RoutedCommand("Clear", typeof(MyCommands));
            Font15 = new RoutedCommand("Font15", typeof(MyCommands));
            Font30 = new RoutedCommand("Font30", typeof(MyCommands));
            Red = new RoutedCommand("Red", typeof(MyCommands));
            Green = new RoutedCommand("Green", typeof(MyCommands));
            Blue = new RoutedCommand("Blue", typeof(MyCommands));
        }
    }
}
