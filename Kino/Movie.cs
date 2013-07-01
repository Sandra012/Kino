using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kino
{
    public class Movie
    {
        public string MovieId { get; set; }
        public string MovieName { get; set; }
        public string Duration { get; set; }
        public string Year { get; set; }
        public string Genre { get; set; }
        public string Rating { get; set; }
        public Movie(string movieId, string movieName, string duration, string year, string genre, string rating) {
            MovieId = movieId;
            MovieName = movieName;
            Duration = duration;
            Year = year;
            Genre = genre;
            Rating = rating;
        }
        public override string ToString()
        {
            return String.Format("       {0}                              {1}                                      {2}                                        {3}                                     {4}                                      {5}       ", MovieId, MovieName, Duration, Year, Genre, Rating);

        }
    }
}
