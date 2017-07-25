using ControlesApp.Result;
using ControlesApp.Services;
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
	public partial class InicioTabPage : ContentPage
	{
		public InicioTabPage ()
		{
			InitializeComponent ();
		}

        protected override void OnAppearing()
        {
            base.OnAppearing();            
        }

        private void BtnSolicitar_Clicked(object sender, EventArgs e)
        {
            Device.BeginInvokeOnMainThread(async () => {
                RestClient client = new RestClient();
                var weatherResult = await client.Get<WeatherTo>("http://samples.openweathermap.org/data/2.5/forecast?id=524901&appid=b1b15e88fa797225412429c1c50c122a1");

                if (weatherResult != null)
                {
                    LabelCiudad.Text = weatherResult.city.name;
                }
            });
        }
    }
}