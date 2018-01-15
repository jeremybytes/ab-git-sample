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
                (sender, e) =>
                {
                    MessageBox.Show("Hello World");
                };
        }
    }
}
