﻿using Requital;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Requital.Windows;

namespace TestUserControls
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

        private void Menu_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Menu.Visibility == Visibility.Hidden)
                CreationS.Visibility = Visibility.Visible;
        }

        private void CreationS_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (CreationS.Visibility == Visibility.Collapsed)
            {
                CombatScreen cs = new CombatScreen(CreationS.DreamTeam);
                cs.Visibility = Visibility.Visible;
                MainGrid.Children.Add(cs);
            }
        }

    }
}
