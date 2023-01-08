using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
namespace MobileApp.Models
{
    public class Client
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        [NotNull]
        public string Client_Name { get; set; }
        [NotNull]
        public string Email { get; set; }
        [MaxLength(10)]
        [NotNull]
        public string Phone { get; set; }
 
    }
}
