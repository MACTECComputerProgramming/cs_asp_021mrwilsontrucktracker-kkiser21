﻿using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;


namespace StringFormats
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void cal1(object sender, SelectionChangedEventArgs e) {
            Mouse.Capture(null);
        }
        private void cal2(object sender, SelectionChangedEventArgs e) {
            Mouse.Capture(null);
        }
        private void Button_Click(object sender, RoutedEventArgs e) {


            tDriverLbl.Content = $"Driver - {driverLbl.Text}";

            
            double ss = double.Parse(SSLbl.Text);
            tSSNLbl.Content = string.Format("SSN: {0:000-00-0000}", ss);

           
            double pn = double.Parse(phoneLbl.Text);
            tPNLbl.Content = string.Format("Phone #: {0:(000)000-0000}", pn);

            int miles = Convert.ToInt32(endMilesTxtBox.Text) - Convert.ToInt32(startMilesTxtBox.Text);
            tMilesLBL.Content = $"Total Miles: {miles}";

            int days = Convert.ToInt32((Cal2.SelectedDate.Value - Cal1.SelectedDate.Value).Days);
            tDaysOutLbl.Content = $"Days Out: {days}";

            double pay = (fridgeChk.IsChecked == true) ? miles * .37 : miles * .25;
            tPayDueLbl.Content = string.Format("Pay Due: {0:c}", pay);
           
            int vac = days / 5;
            tVacayLbl.Content = $"Vacation Earned: {vac} Days";
        }
    }
}
