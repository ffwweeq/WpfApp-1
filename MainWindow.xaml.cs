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

namespace WpfApp1
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void txtCM_KeyUp(object sender, KeyEventArgs e)
        {
            double douCM;

            douCM = Convert.ToDouble(txtCM.Text);

            txtM.Text = string.Format("{0:0.##########}", douCM / 100);
            txtKM.Text = string.Format("{0:0.##########}", douCM / 100000);
            txtIn.Text = string.Format("{0:0.##########}", douCM / 2.54);
            txtFt.Text = string.Format("{0:0.##########}", douCM / 30.48);
            txtYard.Text = string.Format("{0:0.##########}", douCM / 91.44);
        }

        private void txtM_KeyUp(object sender, KeyEventArgs e)
        {
            double douM;

            douM = Convert.ToDouble(txtM.Text);

            txtCM.Text = string.Format("{0:0.##########}", douM * 100);
            txtKM.Text = string.Format("{0:0.##########}", douM * 0.001);
            txtIn.Text = string.Format("{0:0.##########}", douM * 39.37);
            txtFt.Text = string.Format("{0:0.##########}", douM * 3.28);
            txtYard.Text = string.Format("{0:0.##########}", douM * 1.09);
        }

        private void txtKM_KeyUp(object sender, KeyEventArgs e)
        {
            double douKM;

            douKM = Convert.ToDouble(txtKM.Text);

            txtCM.Text = string.Format("{0:0.##########}", douKM * 100000);
            txtM.Text = string.Format("{0:0.##########}", douKM * 1000);
            txtIn.Text = string.Format("{0:0.##########}", douKM * 39370.1);
            txtFt.Text = string.Format("{0:0.##########}", douKM * 3280.84);
            txtYard.Text = string.Format("{0:0.##########}", douKM * 1093.61);
        }
    }
}
