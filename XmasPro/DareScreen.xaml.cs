using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XmasPro
{
    public partial class DareScreen : ContentPage
    {
        public DareScreen()
        {
            InitializeComponent();
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

        static void Main(string[] args)
        {
            RandomGenerator generator = new RandomGenerator();
            int rand = generator.RandomNumber(5, 100);
            Console.WriteLine($"Random number between 5 and 100 is {rand}");

            Console.ReadKey();
        }

        public class RandomGenerator
        {
            // Generate a random number between two numbers    
            public int RandomNumber(int min, int max)
            {
                Random random = new Random();
                return random.Next(min, max);
            }
   
        }
    }
}