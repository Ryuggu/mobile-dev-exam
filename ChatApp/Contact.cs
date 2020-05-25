using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChatApp
{
    public class Contact
    {

        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string PhoneNumber { get; set; }

    }
}
