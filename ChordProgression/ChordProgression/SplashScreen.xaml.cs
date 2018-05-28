﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ChordProgression
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SplashScreen : ContentPage
	{
		public SplashScreen()
		{
			InitializeComponent();
		}

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await Task.Delay(2000);
            await Navigation.PushAsync(new MainPage());
            Navigation.RemovePage(this);
        }
	}
}