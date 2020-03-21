using System;
using System.Collections.Generic;
using System.Linq;

namespace AnythingButCreed
{
    class Program
    {
        static void Main(string[] args)
        {
            var Queen = new Song("Queen", "Don't Stop Me Now");
            var MollyParden = new Song("Molly Parden", "Losing My Religion");
            var ModestMouse = new Song("Modest Mouse", "Cowboy Dan");
            var MotherMother = new Song("Mother Mother", "Baby Don't Dance");
            var Creed = new Song("Creed", "Arms Wide Open");
            var AlsoCreed = new Song("Creed", "Something Else From Creed");
            var Ciara = new Song("Ciara", "Like a Boy");
            var HER = new Song("H.E.R.", "Focus");
            var StephenMarley = new Song("Stephen Marley", "You're Gonna Leave");
            var StMotel = new Song("Saint Motel", "My Type");
            var Starbenders = new Song("Starbenders", "Blood");
            var Pokey = new Song("Pokey LaFarge", "Something in the Water");

            var goodSongs = new List<Song>();
            var allSongs = new List<Song>() 
            { 
                Queen,
                MollyParden, 
                ModestMouse, 
                MotherMother, 
                Creed, 
                AlsoCreed, 
                Ciara, 
                HER, 
                Starbenders, 
                StephenMarley, 
                StMotel, 
                Pokey
            };

            goodSongs = allSongs.Where(Song => Song.Artist != "Creed").ToList();

            foreach (var song in goodSongs)
            {
                Console.WriteLine($"{song.Artist} : {song.Name}");
            }
        }
    }
}
