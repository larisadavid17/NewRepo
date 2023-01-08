using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using SQLiteNetExtensions.Attributes;
namespace MobileApp.Models
{
    public class Appointment
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public DateTime From {get;set;}
        public DateTime To { get; set; }

        [ForeignKey(typeof(Employee))]
        public int Employee_ID { get; set; }
        [ForeignKey(typeof(Client))]
        public int Client_ID { get; set; }
        [ForeignKey(typeof(Service))]
        public int Service_ID { get; set; }

    }
}
