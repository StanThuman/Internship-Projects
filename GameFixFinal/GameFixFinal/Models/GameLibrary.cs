using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace GameFixFinal.Models
{
    public class GameLibrary
    {
        public virtual int GameLibraryId { get; set; }

        //name annotations only work if I am not using a helper with a "For" suffix
        //        [DisplayName("Genre123")]
        public virtual int GenreId { get; set; }

        public virtual int DeveloperId { get; set; }
        public virtual string Title { get; set; }
        public virtual int Year { get; set; }
        public virtual decimal Price { get; set; }
        public virtual string GameArtUrl { get; set; }
        public virtual string Console { get; set; }

        //navigation properties
        public virtual Genre Genre { get; set; }
        public virtual Developer Developer { get; set; }

    }
}