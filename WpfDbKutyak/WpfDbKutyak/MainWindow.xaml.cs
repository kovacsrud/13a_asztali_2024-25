﻿using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfDbKutyak.Views;

namespace WpfDbKutyak
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

        private void menuitemKilepes_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void menuitemKutyanevek_Click(object sender, RoutedEventArgs e)
        {
            ViewKutyanev kutyanevek = new ViewKutyanev();
            kutyanevek.ShowDialog();
        }

        private void menuitemRendelesek_Click(object sender, RoutedEventArgs e)
        {
            ViewRendeles rendelesek = new ViewRendeles();
            rendelesek.ShowDialog();
        }
    }
}