using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using SQLiteNetExtensions.Attributes;
namespace MobileApp.Models
{
    public class Employee
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        [NotNull]
        public string First_Name { get; set; }
        [NotNull]
        public string Last_Name { get; set; }
        [MaxLength(10)]
        [NotNull]
        public string Phone { get; set; }
        [ForeignKey(typeof(Schedule))]
        public int Schedule_ID { get; set; }
        [ForeignKey(typeof(Service))]
        public int Service_ID { get; set; }
        [ForeignKey(typeof(Appointment))]
        public int Appointment_ID { get; set; }


        [OneToOne(CascadeOperations = CascadeOperation.CascadeDelete)]
        public Schedule Schedule { get; set; }
        [OneToOne(CascadeOperations = CascadeOperation.CascadeDelete)]
        public Service Service { get; set; }

        [OneToOne(CascadeOperations = CascadeOperation.CascadeDelete)]
        public Appointment Appointment { get; set; }
    }
}
