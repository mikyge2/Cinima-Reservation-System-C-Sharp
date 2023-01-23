using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Cinema_reservation_system.storedata;

namespace Cinema_reservation_system
{
    public class storedata
    {
        public struct Movie
        {
            public int Id { get; set; }
            public string Title { get; set; }
            public string Rating { get; set; }
            public string [] takenseats { get; set; }
        }

        public struct Showtime
        {
            public string Theater { get; set; }
            public string Time { get; set; }
        }

        public struct Reservation
        {
            public string Theater { get; set; }
            public string Time { get; set; }
            public string CustomerName { get; set; }
            public string seatnumber { get; set; }
        }
        public static Stack<Movie> movies = new Stack<Movie>();
        public static void loadmovies()
        {            
            Movie mov1 = new Movie()
            {
                Id = 1,
                Title = "Avatar",
                Rating = "R",
                takenseats = new string[] { "A1", "A2", "A3", "A4", "A5" }
            };
            movies.Push(mov1);
            Movie mov2 = new Movie()
            {
                Id = 2,
                Title = "Black Adam",
                Rating = "R",
                takenseats = new string[] { "A2", "A4", "A6", "A9", "VIP4" }
            };
            movies.Push(mov2);
            Movie mov3 = new Movie()
            {
                Id = 3,
                Title = "Lost City",
                Rating = "R",
                takenseats = new string[] { "A7", "A9", "A11", "B3", "B5" }
            };
            movies.Push(mov3);
            Movie mov4 = new Movie()
            {
                Id = 4,
                Title = "Beast",
                Rating = "R",
                takenseats = new string[] { "A7", "A9", "A12", "B4", "VIP3" }
            };
            movies.Push(mov4);
            Movie mov5 = new Movie()
            {
                Id = 5,
                Title = "Joker",
                Rating = "R",
                takenseats = new string[] { "B1", "B6", "B7", "B8", "B12" }
            };
            movies.Push(mov5);
            Movie mov6 = new Movie()
            {
                Id = 6,
                Title = "Wood",
                Rating = "R",
                takenseats = new string[] { "A1", "A2", "B3", "B4", "B5" }
            };
            movies.Push(mov6);
            Movie mov7 = new Movie()
            {
                Id = 7,
                Title = "Matrix: The Ressurection",
                Rating = "R",
                takenseats = new string[] { "A6", "A9", "A10", "B4", "VIP2" }
            };
            movies.Push(mov7);
        }
        public static string [] whichreserved(String movname)
        {
            String[] reserved = new string[20];
            while(movies.Count > 0)
            {
                if (movies.Peek().Title == movname)
                {
                    reserved = movies.Peek().takenseats.ToArray<string>();
                    break;
                }
                else
                {
                    movies.Pop();
                }
            }
            loadmovies();
            return reserved;
        }
        public static bool addreserve(String movname, string noseat)
        {
            String[] reserved = whichreserved(movname);
            reserved = reserved.Append(noseat).ToArray();
            return true;
        }
    }
}