using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace OakIsland.Models
{
    public class Business
    {
        public int Id { get; set;}
        public string BusinessName { get; set; }
        public string Address { get; set; }
        public string Address1 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zip { get; set; }
        public string Phone { get; set; }
        public string Website { get; set; }
    }
}
