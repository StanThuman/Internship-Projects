using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace GameFixFinal.Models
{
    public class GameLibraryContext : DbContext
    {

        
        //used to access models
        public System.Data.Entity.DbSet<Genre> Genres { get; set; }

        public System.Data.Entity.DbSet<GameLibrary> GameLibraries { get; set; }

        public System.Data.Entity.DbSet<Developer> Developers { get; set; }

    }
}