﻿using System;
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

        public EnterWindow()
        {
            InitializeComponent();
        }

        public EnterWindow(TeacherManager manager)
        {
            this.manager = manager;
        }
    }
}
