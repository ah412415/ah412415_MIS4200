﻿using System;
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
        public DbSet<Appointment1> Appointment1 { get; set; }
        public DbSet<Patient1> Patient1 { get; set; }
        public DbSet<Doctor1> Doctor1 { get; set; }


    }
}