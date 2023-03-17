using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Principal;
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
using System.Text.Json;
using System.Xml.Linq;
using System.Diagnostics;

namespace money
{


    public partial class MainWindow : Window
    {
        List<string> spisok = new List<string>();
        List<string> opisanie = new List<string>();

        public string zametka;


        public MainWindow()
        {
            InitializeComponent();
            DataContext = new[] { 1, 2, 3, 4, 5 };
            ListBox_SelectionChanged(null, null);
        }


        private void Button1_Click(object sender, RoutedEventArgs e)
        {

            zametka = Txtbox1.Text;
            spisok.Add(zametka);



            Listbox.ItemsSource = null;
            Listbox.ItemsSource = spisok;
        }
        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            spisok.Remove(zametka);
            var window = Application.Current.MainWindow as MainWindow;
            window.pageFrame.content = new SecondPage();

        }

        /* private void Button3_Click(object sender, RoutedEventArgs e)
        {
        spisok.RemoveAt(Listbox.SelectedIndex);
        spisok.Clear();
        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {

        }*/

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            /* string selected = Listbox.SelectedItem.ToString();
            for (int i = 0; i < spisok.Count; i++)
            {
            if (selected == spisok[i].ToString())
            {
            Txtbox1.Text = spisok[i].ToString();
            Txtbox2.Text = opisanie[i].ToString();
            }
            }*/
        }

        private void Txtbox1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtbox2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void Datepick_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            DateTime? selectedDate = Datepick.SelectedDate;

            selectedDate.Value.Date.ToShortDateString();

            spisok.Clear();
            zametka = Txtbox1.Text;
            spisok.Add(zametka);
            Listbox.ItemsSource = null;
            Listbox.ItemsSource = spisok;
        }


    }
    /* public partial class FirstPage : Page
    {

    private void Button2_Click(object sender, RoutedEventArgs e)
    {
    *//*spisok.Remove(zametka);*//*
    var window = Application.Current.MainWindow as MainWindow;
    window.pageFrame.content = new SecondPage();

    }
    }*/
}