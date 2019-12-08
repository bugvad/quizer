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
    /// Логика взаимодействия для RegisterWindow.xaml
    /// </summary>
    public partial class RegisterWindow : Window
    {
        private TeacherManager manager;

        public RegisterWindow(TeacherManager manager)
        {
            this.manager = manager;
            InitializeComponent();
        }

        private void OkButtonClick(object sender, RoutedEventArgs e)
        {
            if (textBoxLogin.Text == "" | textBoxFullName.Text == "" | textBoxUniversity.Text == "" | textBoxGroup.Text == "" | textBoxPassword.Text == "")
            {
                MessageBox.Show("Please fill all gaps");
            }
            else
            {
                if (manager.CheckIfUserExists(textBoxLogin.Text))
                {
                    MessageBox.Show("User with this login is already exists");
                }
                else
                {
                    manager.RegisterUser(textBoxLogin.Text, textBoxFullName.Text, textBoxUniversity.Text, textBoxGroup.Text, textBoxPassword.Text);
                    //window.ShowDialog();
                }
            }
        }

        private void CancelButtonClick(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }
    }
}
