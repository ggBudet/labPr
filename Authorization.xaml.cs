﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace lab
{
    /// <summary>
    /// Логика взаимодействия для Authorization.xaml
    /// </summary>
    public partial class Authorization : Window
    {
        public Authorization()
        {
            InitializeComponent();
        }

        private void CheckBox_Checked(object sender, EventArgs e)
        {
            noHiden.Visibility = Visibility.Hidden;
            Hidden.Visibility = Visibility.Visible;
            Hidden.Text = noHiden.Password;
        }
         
        private void CheckBox_UnChecked(object sender, EventArgs e)
        {
            noHiden.Visibility = Visibility.Visible;
            Hidden.Visibility = Visibility.Hidden;
            noHiden.Password = Hidden.Text;
        }



    }
}
