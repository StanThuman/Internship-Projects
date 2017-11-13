using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameFixFinal.Models
{
    public class DBinitializer : System.Data.Entity.DropCreateDatabaseAlways<GameLibraryContext>{

        protected override void Seed(GameLibraryContext context)
        {
            context.GameLibraries.Add(new GameLibrary
            {
                Developer = new Developer { Name = "Nintendo"},
                Genre = new Genre { Name = "Platformer"},
                Year = 1991,
                Price = 49.99m,
                Title = "Super Mario World",
                Console = "Super Nintendo"
            });

            context.GameLibraries.Add(new GameLibrary
            {
                Developer = new Developer { Name = "Namco" },
                Genre = new Genre { Name = "RPG" },
                Year = 2008,
                Price = 49.99m,
                Title = "Tales of Vesperia",
                Console = "Xbox 360"
            });

            context.GameLibraries.Add(new GameLibrary
            {
                Developer = new Developer { Name = "Nintendo" },
                Genre = new Genre { Name = "RPG" },
                Year = 1994,
                Price = 49.99m,
                Title = "Earthbound",
                Console = "Super Nintendo"
            });

            context.GameLibraries.Add(new GameLibrary
            {
                Developer = new Developer { Name = "Nintendo" },
                Genre = new Genre { Name = "First-Person Shooter" },
                Year = 1997,
                Price = 49.99m,
                Title = "Goldeneye 007",
                Console = "Nintendo 64"
            });

            context.GameLibraries.Add(new GameLibrary
            {
                Developer = new Developer { Name = "Squaresoft" },
                Genre = new Genre { Name = "RPG" },
                Year = 1997,
                Price = 49.99m,
                Title = "Final Fantasy 7",
                Console = "PS One"
            });

            context.GameLibraries.Add(new GameLibrary
            {
                Developer = new Developer { Name = "Prokion" },
                Genre = new Genre { Name = "RPG" },
                Year = 1991,
                Price = 49.99m,
                Title = "Legend of Legaia",
                Console = "PS One"
            });

            context.GameLibraries.Add(new GameLibrary
            {
                Developer = new Developer { Name = "Mistwalker" },
                Genre = new Genre { Name = "Platformer" },
                Year = 2007,
                Price = 49.99m,
                Title = "Blue Dragon",
                Console = "Xbox 360"
            });

            context.GameLibraries.Add(new GameLibrary
            {
                Developer = new Developer { Name = "Nintendo" },
                Genre = new Genre { Name = "Platformer" },
                Year = 1991,
                Price = 49.99m,
                Title = "Super Mario World",
                Console = "Super Nintendo"
            });

            context.GameLibraries.Add(new GameLibrary
            {
                Developer = new Developer { Name = "Nintendo" },
                Genre = new Genre { Name = "Action/Adventure" },
                Year = 2006,
                Price = 49.99m,
                Title = "Legend of Zelda: Twilight Princess",
                Console = "Gamecube"
            });
            context.GameLibraries.Add(new GameLibrary
            {
                Developer = new Developer { Name = "Nintendo" },
                Genre = new Genre { Name = "Platformer" },
                Year = 2011,
                Price = 49.99m,
                Title = "Legend of Zelda: Skyward Sword",
                Console = "Wii"
            });
            base.Seed(context);
        }

    
    
    }
}