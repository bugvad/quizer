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
using System.Windows.Shapes;
using Lib;

namespace Quizer
{
    /// <summary>
    /// Логика взаимодействия для RegisterChooseWindow.xaml
    /// </summary>
    public partial class RegisterChooseWindow : Window
    {
        TeacherManager manager = new TeacherManager();

        public RegisterChooseWindow(TeacherManager manager)
        {
            this.manager = manager;
            InitializeComponent();
        }

        private void StudentButton_Click(object sender, RoutedEventArgs e)
        {
            var window = new RegisterWindow(manager);
            window.ShowDialog();
        }

        private void TeacherButton_Click(object sender, RoutedEventArgs e)
        {
           
        }
    }
}
