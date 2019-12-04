using Lib;
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

namespace Quizer
{
    
    public partial class MainWindow : Window
    {
        TeacherManager manager = new TeacherManager();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void SignInButton_Click(object sender, RoutedEventArgs e)
        {
            var window = new EnterWindow(manager);
            window.ShowDialog();
        }

        private void SignUpButton_Click(object sender, RoutedEventArgs e)
        {
            var window = new RegisterWindow(manager);
            window.ShowDialog();
        }
    }
}
