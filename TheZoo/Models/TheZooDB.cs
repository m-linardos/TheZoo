using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TheZoo.Models
{
    public class TheZooDB : DbContext

    {
        public DbSet<Cat> Cats { get; set; }
        public DbSet<WaterFowl> WaterFowlGroup { get; set; }
        public DbSet<PettingZoo> PettingZooAnimals { get; set; }
        
        
        // constructor to allow .NET Core to do dependency injection 
        public TheZooDB(DbContextOptions options) : base(options)    { }
    
    }
}
