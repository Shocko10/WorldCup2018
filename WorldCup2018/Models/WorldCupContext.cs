using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WorldCup2018.Models
{
    public class WorldCupContext : DbContext
    {
        public WorldCupContext() : base("WorldCup")
        {

        }

        public DbSet<Player> Players { get; set; }

        public DbSet<Player> Teams { get; set; }

        public DbSet<Player> Groups { get; set; }

        public DbSet<Player> Matches { get; set; }

        public DbSet<Player> Venues { get; set; }

    }
}