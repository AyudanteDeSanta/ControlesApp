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
    public partial class SliderPage : ContentPage
    {
        List<ColorItem> colors;
        DateTime ultimaFecha;
        public SliderPage()
        {
            InitializeComponent();
            InitApp();


        }

        private void InitApp()
        {
            colors = new List<ColorItem>();
            colors.Add(new ColorItem { Color = Color.Azure, Name = "Azure" });
            colors.Add(new ColorItem { Color = Color.Black, Name = "Black" });
            colors.Add(new ColorItem { Color = Color.Blue, Name = "Blue" });
            colors.Add(new ColorItem { Color = Color.Fuchsia, Name = "Fuchsia" });
            colors.Add(new ColorItem { Color = Color.Green, Name = "Green" });

            foreach(var color in colors)
            {
                pickerColor.Items.Add(color.Name);
            }


            indicator_image.SetBinding(ActivityIndicator.IsRunningProperty, "IsLoading");
            indicator_image.BindingContext = image_loading;
        }

        private void PickerColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            int position = pickerColor.SelectedIndex;
            if (position > -1)
            {
                boxColor.Color = colors[position].Color;
            }

        }

        private void DatePicker_DateSelected(object sender, DateChangedEventArgs e)
        {
            var fechaMostrar = e.NewDate.ToString("D");
            DisplayAlert("DatePicker", fechaMostrar, "Aceptar");
        }
    }
}