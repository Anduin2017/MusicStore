using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicStore.Models
{
    public class Music
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public int GenreId { get; set; }
        public Genre Context { get; set; }

        public int SingerId { get; set; }
        public Singer Owner { get; set; }
    }

    public class Genre
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public IEnumerable<Music> Musics { get; set; }
    }

    public class Singer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int BirthYear { get; set; }
        public IEnumerable<Music> Musics { get; set; }
    }
}
