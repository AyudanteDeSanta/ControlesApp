using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ControlesApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            SwitchSave.OnChanged += SwitchSave_OnChanged;
        }

        private void SwitchSave_OnChanged(object sender, ToggledEventArgs e)
        {
            if (e.Value)
            {
                var userName = BoxUsuario.Text;
                DisplayAlert("Message", userName, "Aceptar");
            }
        }
    }
}
