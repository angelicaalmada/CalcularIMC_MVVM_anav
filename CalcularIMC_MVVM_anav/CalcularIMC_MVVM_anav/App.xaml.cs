using CalcularIMC_MVVM_anav.Vista;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CalcularIMC_MVVM_anav
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new VcalcularIMC();
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
