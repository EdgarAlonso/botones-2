using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Ejercicio2.Resources;
using System.Windows.Media;

namespace Ejercicio2
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

        }

        private void uno(object sender, RoutedEventArgs e)
        {
            SolidColorBrush nuevo=new SolidColorBrush();
           
            if((Amarillo.IsChecked == true) && (Azul.IsChecked == true) && (Rojo.IsChecked == true))
            {
                nuevo.Color = Colors.White;
                r1.Fill = nuevo;
            }
            
            if((Amarillo.IsChecked == false) && (Azul.IsChecked == false) && (Rojo.IsChecked == false))
            {
                nuevo.Color = Colors.Transparent;
                r1.Fill = nuevo;
            }
           
            if ((Amarillo.IsChecked == true) && (Azul.IsChecked == false) && (Rojo.IsChecked == false))
            {
                nuevo.Color = Colors.Yellow;
                r1.Fill = nuevo;
            }
            
            if ((Amarillo.IsChecked == false) && (Azul.IsChecked == true) && (Rojo.IsChecked == false))
            {
                nuevo.Color = Colors.Blue;
                r1.Fill = nuevo;
            }
            
            if ((Amarillo.IsChecked == false) && (Azul.IsChecked == false) && (Rojo.IsChecked == true))
            {
                nuevo.Color = Colors.Red;
                r1.Fill = nuevo;
            }
                       
            if ((Amarillo.IsChecked == false) && (Azul.IsChecked == true) && (Rojo.IsChecked == true))
            {
                nuevo.Color = Colors.Purple;
                r1.Fill = nuevo;
            }
            if ((Amarillo.IsChecked == true) && (Azul.IsChecked == false) && (Rojo.IsChecked == true))
            {
                nuevo.Color = Colors.Orange;
                r1.Fill = nuevo;
            }
            if ((Amarillo.IsChecked == true) && (Azul.IsChecked == true) && (Rojo.IsChecked == false))
            {
                nuevo.Color = Colors.Green;
                r1.Fill = nuevo;
            }     
        }

         

       
    }
}