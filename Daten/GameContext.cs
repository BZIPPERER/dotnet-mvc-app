using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using gameapplication.Models;

namespace gameapplication.Daten
{
    public class GameContext : DbContext
    {
        public GameContext(DbContextOptions<GameContext> options) : base(options)
        {
            string test = null;
            
        }
        public DbSet<Game> Games { get; set; }
    }
}