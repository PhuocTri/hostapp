﻿using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace KamooniHost.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BookingsPage : ContentPage
    {
        public BookingsPage()
        {
            InitializeComponent();
        }

        protected override bool OnBackButtonPressed()
        {
            Application.Current.MainPage = new MainPage();
            return true;
        }
    }
}