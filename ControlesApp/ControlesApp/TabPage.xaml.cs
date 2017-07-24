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
	public partial class TabPage : TabbedPage
	{
		public TabPage ()
		{
			InitializeComponent ();
            Children.Add(new InicioTabPage());
            Children.Add(new PerfilTab());

        }
    }
}