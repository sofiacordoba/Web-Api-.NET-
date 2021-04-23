﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApiLibros.Models
{
    public partial class Publishers
    {
        public Publishers()
        {
            Employee = new HashSet<Employee>();
            Titles = new HashSet<Titles>();
        }

        public string PubId { get; set; }
        public string PubName { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }

        public virtual PubInfo PubInfo { get; set; }
        public virtual ICollection<Employee> Employee { get; set; }
        public virtual ICollection<Titles> Titles { get; set; }
    }
}
