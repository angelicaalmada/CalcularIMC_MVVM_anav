using CalcularIMC_MVVM_anav.VistaModelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CalcularIMC_MVVM_anav.Vista
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VcalcularIMC : ContentPage
    {
        public VcalcularIMC()
        {
            InitializeComponent();
            BindingContext = new VMcalcularIMC(Navigation);
        }
    }
}