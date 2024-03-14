﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.Models
{
     public class User
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public User(string name, string surname, string email, string password) { 
            Name = name;
            Surname = surname; 
            Email = email;
            Password = password;
        }

        public User()
        {

        }

        public virtual List<string> getInfo()
        {
            List<string> info = new List<string>();
            info.Add(Name);
            info.Add(Surname);
            info.Add(Email);

            return info;
        }

    }
}
