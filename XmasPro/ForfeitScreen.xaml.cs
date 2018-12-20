using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XmasPro
{
	public partial class ForfeitScreen : ContentPage
	{
		public ForfeitScreen ()
		{
			InitializeComponent ();
		}

        private void HomeButtton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }

        private void MainScreenButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainScreen());
        }
    }
}