using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ChordProgression
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            //LabelLogo.FontFamily = Device.RuntimePlatform == Device.iOS ? "MuseJazz" : Device.RuntimePlatform == Device.Android ? "MuseJazz.ttf#MuseJazz" : "Assets/Fonts/MuseJazz.ttf#MuseJazz";
            //LabelLogo.FontSize = Device.RuntimePlatform == Device.iOS ? 24 : Device.RuntimePlatform == Device.Android ? Device.GetNamedSize(NamedSize.Medium, LabelLogo) : Device.GetNamedSize(NamedSize.Large, LabelLogo);
        }

        private async void Clicked_Button(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SettingsPage());
        }
    }
}
