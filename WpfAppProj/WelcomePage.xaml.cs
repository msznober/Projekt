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

namespace WpfAppProj
{
    /// <summary>
    /// Logika interakcji dla klasy WelcomePage.xaml
    /// </summary>
    public partial class WelcomePage : Window
    {
        public WelcomePage()
        {
            InitializeComponent();
        }

    /// <summary>
    /// Wyświetlenie okna użytkowników
    /// </summary>
        private void goBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow Ipage = new MainWindow();
            Ipage.ShowDialog();
        }
    }
}
