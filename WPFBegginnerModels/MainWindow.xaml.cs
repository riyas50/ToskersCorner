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
using WPFBegginnerModels.Models;

namespace WPFBegginnerModels
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MyModelObject myButton1DataContext = new MyModelObject() { Name = "I'm Button 01" };
            MyModelObject myButton2DataContext = new MyModelObject() { Name = "I'm Button 02" };
            Button1.Content = myButton1DataContext.Name;
            Button2.Content = myButton2DataContext.Name;
        }
    }
}
