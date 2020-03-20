using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace HairSalon.Models
{
    public class Client
    {
        public string Name {get; set;}
        public int ClientId {get; set;}
        public int StylistId {get; set;}
        public virtual Stylist Stylists {get; set;}

    }
}