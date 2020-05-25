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
using ChatApp.Model;

namespace ChatApp
{
    public partial class ApiData : ContentPage
    {
        public ApiData()
        {
            InitializeComponent();

            GetApiContacts();
        }

        private async void GetApiContacts()
        {

            if (NetworkCheck.IsInternet())
            {
                HttpClient client = new HttpClient();

                var response = await client.GetStringAsync("https://jsonplaceholder.typicode.com/users");

                var data = JsonConvert.DeserializeObject<List<ApiContacts>>(response);

                apiContactsListView.ItemsSource = data;
            }
            else
            {
                await DisplayAlert("JSONParsing", "No network is available.", "Ok");
            }
        }
    }
}