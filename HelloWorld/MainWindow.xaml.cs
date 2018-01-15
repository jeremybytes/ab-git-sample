using System.Windows;
using System.Windows.Controls;

namespace HelloWorld
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ClickMeButton.Click += 
                (object sender, RoutedEventArgs e) =>
                {
                    MessageBox.Show("Hello World");
                };
        }
    }
}
