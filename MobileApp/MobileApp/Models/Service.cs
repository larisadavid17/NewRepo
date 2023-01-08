using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using SQLiteNetExtensions.Attributes;
namespace MobileApp.Models
{
    public class Service
    {

        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Name { get; set; }

        [ForeignKey(typeof(Employee))]
        public int Employee_ID { get; set; }
        public float Price { get; set; }
        public int Time { get; set; }

    }
}
