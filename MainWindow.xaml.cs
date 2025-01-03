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

namespace Triangle
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        
        private void proverka_Click(object sender, RoutedEventArgs e)
        {
            int a, b, c;
            try
            {
                 a = Convert.ToInt32(n1.Text);
                 b = Convert.ToInt32(n2.Text);
                 c = Convert.ToInt32(n3.Text);
            } catch(Exception ex)
            {
                MessageBox.Show("Введите числовое значение");
                return;
            }
            if (a+b < c || a+c<b || b+c <a) { MessageBox.Show("Такого треугольника не существует"); return; }
            if (a<0 || b<0 || c < 0) { MessageBox.Show("Введите положительные значения"); return; }
            if (a == 0 || b == 0 || c == 0) { MessageBox.Show("Такого треугольника не существует"); return; }
            if (a == b && b == c)
            {
                t.Content = "Треугольник равносторонний";
                proverka.Visibility = Visibility.Hidden;
                again.Visibility = Visibility.Visible;
                n1.Visibility = Visibility.Hidden;
                n2.Visibility = Visibility.Hidden;
                n3.Visibility = Visibility.Hidden;
                n1.Text = string.Empty;
                n2.Text = string.Empty;
                n3.Text = string.Empty;
            }
            if (a == b || b == c || a == c)
            {
                t.Content = "Треугольник равнобедренный";
                proverka.Visibility = Visibility.Hidden;
                again.Visibility = Visibility.Visible;
                n1.Visibility = Visibility.Hidden;
                n2.Visibility = Visibility.Hidden;
                n3.Visibility = Visibility.Hidden;
                n1.Text = string.Empty;
                n2.Text = string.Empty;
                n3.Text = string.Empty;
            }
            if (a != b && b != c && b != c)
            {
                t.Content = "Треугольник разносторонний";
                proverka.Visibility = Visibility.Hidden;
                again.Visibility = Visibility.Visible;
                n1.Visibility = Visibility.Hidden;
                n2.Visibility = Visibility.Hidden;
                n3.Visibility = Visibility.Hidden;
                n1.Text = string.Empty;
                n2.Text = string.Empty;
                n3.Text = string.Empty;
            }
        }

        private void again_Click(object sender, RoutedEventArgs e)
        {
            proverka.Visibility = Visibility.Visible;
            again.Visibility = Visibility.Hidden;
            n1.Visibility = Visibility.Visible;
            n2.Visibility = Visibility.Visible;
            n3.Visibility = Visibility.Visible;
            t.Content = "Введите длины сторон треугольника";
        }
    }
}
