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

namespace Labrat8._1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            int nro = int.Parse(txtTrucks.Text) + 1;
            txtTrucks.Text = nro.ToString();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            int nro = int.Parse(txtCars.Text) + 1;
            txtCars.Text = nro.ToString();
        }
    }
}
