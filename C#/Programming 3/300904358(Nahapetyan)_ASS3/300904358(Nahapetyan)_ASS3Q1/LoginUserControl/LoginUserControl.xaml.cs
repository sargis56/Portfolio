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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LoginUserControl
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class LoginUserControl : UserControl
    {
        public LoginUserControl()
        {
            InitializeComponent();
        }

        public string UserName
        {
            get { return (string)GetValue(UserNameProperty); }
            set { SetValue(UserNameProperty, value); }
        }

        public static DependencyProperty UserNameProperty =
           DependencyProperty.Register(nameof(UserName), typeof(string), typeof(LoginUserControl), new PropertyMetadata(""));


        public string Password
        {
            get { return (string)GetValue(PasswordProperty); }
            set { SetValue(PasswordProperty, value); }        
    }

        public static DependencyProperty PasswordProperty =
           DependencyProperty.Register(nameof(Password), typeof(string), typeof(LoginUserControl), new PropertyMetadata(""));

        public bool CheckLogin()
        {
            if ((Password == textBoxPassword.Text) && (UserName == textBoxUserName.Text))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
