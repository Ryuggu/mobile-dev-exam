using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ChatApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddContactPage : ContentPage
    {
        public AddContactPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Contact contact = new Contact()
            {
                FirstName = firstNameEntry.Text,
                LastName = lastNameEntry.Text,
                PhoneNumber = phoneNumberEntry.Text
            };

            using (SQLite.SQLiteConnection conn = new SQLite.SQLiteConnection(App.DB_PATH))
            {
                conn.CreateTable<Contact>();
                var numberOfRows = conn.Insert(contact);

                if (numberOfRows > 0)
                    DisplayAlert("Contact added!", "Wow, good job!", "I'm awesome!");
                else
                    DisplayAlert("You're a failure...", "You suck!", "I hereby admit that I'm a loser...");
            }
        }
    }
}