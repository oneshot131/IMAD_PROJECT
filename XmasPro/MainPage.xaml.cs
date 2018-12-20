using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XmasPro
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

        }

        private void ExitButtton_Clicked(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void StartGame_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainScreen());
        }

        private void Enter_Clicked(object sender, EventArgs e)
        {   
            //calling the class Player
            Player player = new Player()
            {
                Name = namePlayer.Text
            };

            //using using method so that the dispose() will not overload. 
            using (SQLite.SQLiteConnection conn = new SQLite.SQLiteConnection( App.DATABASE_PATH))
            {
                conn.CreateTable<Player>();
                var numberOfRows = conn.Insert(player);

                
                if(numberOfRows > 0 )
                {
                    DisplayAlert("Success!", "Player successfully added ", "Great!");
                }
                else
                    DisplayAlert("Failure!", "Player not added ", "Oh Dang!");

            }
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();

            using (SQLite.SQLiteConnection conn = new SQLite.SQLiteConnection(App.DATABASE_PATH))
            {
                conn.CreateTable<Player>();

                var players = conn.Table<Player>().ToList();
                playersListView.ItemsSource = players;
            }

        }

    }    
}
