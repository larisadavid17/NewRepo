using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using SQLiteNetExtensions.Attributes;
namespace MobileApp.Models
{
    public class Schedule
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        
        public int Start { get; set; }
        public int End { get; set; }
        [ForeignKey(typeof(Employee))]
        public int Employee_ID { get; set; }

    }
}
