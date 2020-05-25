using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using SQLite;
using System.Net.Http;
using Newtonsoft.Json;

namespace ChatApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            GetApiContacts();
        }

        private async void GetApiContacts()
        {
            HttpClient client = new HttpClient();

            var response = await client.GetStringAsync("https://jsonplaceholder.typicode.com/users");

            var data = JsonConvert.DeserializeObject<List<ApiContacts>>(response);

            contactsListView.ItemsSource = data;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            using(SQLite.SQLiteConnection conn = new SQLite.SQLiteConnection(App.DB_PATH))
            {
                conn.CreateTable<Contact>();

                var contacts = conn.Table<Contact>().ToList();
                contactsListView.ItemsSource = contacts;
            }
        }

        private void APIContacts_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ApiData());
        }
        private void AddContacts_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AddContactPage());
        }
    }
}
