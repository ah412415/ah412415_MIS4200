using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ah412415_MIS4200.Models;
using System.Data.Entity;


namespace ah412415_MIS4200.Models.DAL
{
    public class MIS4200Context : DbContext // inherits from DbContext
    {
        public MIS4200Context() : base ("name=DefaultConnection")
        {

        }
        public DbSet<Appointment> Appointment { get; set; }
        public DbSet<Patient> Patient { get; set; }
        public DbSet<Doctor> Doctor { get; set; }


    }
}