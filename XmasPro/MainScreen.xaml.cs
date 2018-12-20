using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XmasPro
{
	public partial class MainScreen : ContentPage
	{
		public MainScreen ()
		{
			InitializeComponent ();
		}

        private void TruthButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TaskScreen());
        }

        private void DareButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DareScreen());
        }

        private void HomeButtton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }
    }
}