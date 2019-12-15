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
    /// Логика взаимодействия для EnterWindow.xaml
    /// </summary>
    public partial class EnterWindow : Window
    {
        private TeacherManager manager;

        public EnterWindow(TeacherManager manager)
        {
            this.manager = manager;
            InitializeComponent();
        }

        private void OkButtonClick(object sender, RoutedEventArgs e)
        {
            if (textBoxLogin.Text == "" | textBoxPassword.Text == "")
            {
                MessageBox.Show("Please fill all gaps");
            }
            else
            {
                if (manager.CheckIfUserExists(textBoxLogin.Text))
                {
                    if (manager.CheckPassword(textBoxLogin.Text, textBoxPassword.Text))
                    {
                        var window = new EnterWindow(manager);
                        window.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Wrong password");
                    }
                }
                else
                {
                    MessageBox.Show("User with this login don't exist");
                }
            }
        }

        private void CancelButtonClick(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }
    }
}
