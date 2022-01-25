using System;
using MultiMath.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MultiMath
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MultiPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
