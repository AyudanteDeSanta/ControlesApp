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
	public partial class HamburguerMenuPage : MasterDetailPage
	{
		public HamburguerMenuPage ()
		{
			InitializeComponent ();

            IniciarDetail();
		}

        private void IniciarDetail()
        {
            List<Menu> menu = new List<Menu> {
                new Menu {Page = new PrincipalPage(), MenuTitle="Inicio", MenuDetail="Regresa a la página principal"},
                new Menu {Page = new SettingPage(), MenuTitle="Opciones", MenuDetail="Navegar a la página principal"}

            };

            ListMenu.ItemsSource = menu;

            //Device.OnPlatform(iOS: () => 
            //{
            //    ListMenu.Margin = new Thickness(0, 21, 0, 0);
            //}, Android: () => {
            //    ListMenu.Margin = new Thickness(0, 21, 0, 0);

            //});

            switch (Device.RuntimePlatform)
            {
                case "iOS":
                    ListMenu.Margin = new Thickness(0, 21, 0, 0);
                    break;
                case "Android":
                    ListMenu.Margin = new Thickness(0, 21, 0, 0);
                    break;
            }


            Detail = new NavigationPage(new PrincipalPage());
        }

        private void ListMenu_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var menu = e.SelectedItem as Menu;
            if (menu != null)
            {
                Detail = new NavigationPage(menu.Page);
                IsPresented = false;
            }
        }
    }

    internal class Menu
    {
        public string MenuTitle { get; set; }
        public string MenuDetail { get; set; }
        public Page Page { get; set; }

    }
}