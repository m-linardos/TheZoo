using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheZoo.Models
{
    public class WaterFowl
    {
        public int Id { get; set; }       
        public int age { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
        public string HeathStatus { get; set; }
    }
}
