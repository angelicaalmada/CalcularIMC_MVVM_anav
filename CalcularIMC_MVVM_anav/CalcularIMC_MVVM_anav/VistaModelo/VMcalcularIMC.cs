using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace CalcularIMC_MVVM_anav.VistaModelo
{
    public class VMcalcularIMC : BaseViewModel
    {
        #region VARIABLES
        string _Mensaje;
        double _Peso;
        double _Altura;
        double _Imc;
        #endregion
        #region CONSTRUCTOR
        public VMcalcularIMC(INavigation navigation)
        {
            Navigation = navigation;
        }
        #endregion
        #region OBJETOS
        public string Mensaje
        {
            get { return _Mensaje; }
            set { SetValue(ref _Mensaje, value); }
        }
        public double Peso
        {
            get { return _Peso; }
            set { SetValue(ref _Peso, value); }
        }
        public double Altura
        {
            get { return _Altura; }
            set { SetValue(ref _Altura, value); }
        }
        public double Imc
        {
            get { return _Imc; }
            set { SetValue(ref _Imc, value); }
        }
        #endregion
        #region PROCESOS
        public async Task ProcesoAsyncrono()
        {
           
        }
        public void CalcularIMC(double p, double a)
        {
            Imc = (Peso) / (Math.Pow(a, 2));
        }

        public async void BtnCalcularIMC()
        {
            CalcularIMC(Peso, Altura);

           if(Imc < 18.5)
            {
                Mensaje = "Bajo peso";
            }
            else
            {
                 if (Imc >= 18.5 && Imc < 24.9)
                {
                    Mensaje = "Peso Normal";
                }
                else
                {
                    if (Imc >= 24.9 && Imc <= 29.9)
                    {
                        Mensaje = "Sobrepeso";
                    }
                    else
                    {
                        Mensaje = "Obesidad";
                    }
                }
            }

            await DisplayAlert("Estado", Mensaje, "Salir");
        }

        #endregion
        #region COMANDOS
        public ICommand ProcesoAsyncommand => new Command(async () => await ProcesoAsyncrono());
        public ICommand CalcularIMCCommand => new Command(BtnCalcularIMC);
        #endregion

    }
}