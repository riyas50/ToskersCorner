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

namespace WPFCustomUserControlDependencyProperties
{
    /// <summary>
    /// Interaction logic for CustomUserControl.xaml
    /// </summary>
    public partial class CustomUserControl : UserControl
    {


        public object Secret
        {
            get { return (object)GetValue(SecretProperty); }
            set { SetValue(SecretProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Secret.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SecretProperty =
            DependencyProperty.Register("Secret", typeof(object), typeof(CustomUserControl), new PropertyMetadata("Secret content"));


        public CustomUserControl()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (spoilerGrid.Visibility == Visibility.Visible)
            {
                contentGrid.Visibility = Visibility.Visible;
                spoilerGrid.Visibility = Visibility.Collapsed;
            }
            else
            {
                contentGrid.Visibility = Visibility.Collapsed;
                spoilerGrid.Visibility = Visibility.Visible;
            }
        }
    }
}
