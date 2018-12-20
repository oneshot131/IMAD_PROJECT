using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XmasPro
{
	public partial class TaskScreen : ContentPage
	{
		public TaskScreen ()
		{
			InitializeComponent ();
		}

        private void HomeButtton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }

        private void Yes_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainScreen());
        } 

        private void No_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ForfeitScreen());
        }

    }
}