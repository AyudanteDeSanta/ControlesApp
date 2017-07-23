using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ControlesApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PersitenciaPage : ContentPage
    {
        public PersitenciaPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            BtnSaveData.Clicked += BtnSaveData_Clicked;

            if (Application.Current.Properties.ContainsKey("nombre"))
            {
                BoxName.Text = Application.Current.Properties["nombre"] as string;
            }
            if (Application.Current.Properties.ContainsKey("edad"))
            {
                BoxAge.Text = Application.Current.Properties["edad"] as string;
            }
        }

        private async void BtnSaveData_Clicked(object sender, EventArgs e)
        {
            string nombre = BoxName.Text;
            string edad = BoxAge.Text;

            Application.Current.Properties["nombre"] = nombre;
            Application.Current.Properties["edad"] = edad;

            await Application.Current.SavePropertiesAsync();

            await DisplayAlert("DictionaryProperties", $"{nombre} {edad}", "Aceptar");
        }
    }
}