using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema_reservation_system
{
    internal class store
    {
        public struct Movie
        {
            public string Title { get; set; }
            public string Rating { get; set; }
        }

        public struct Showtime
        {
            public string Theater { get; set; }
            public int Time { get; set; }
        }

        public struct Reservation
        {
            public string Theater { get; set; }
            public int Time { get; set; }
            public string CustomerName { get; set; }
            public int NumTickets { get; set; }
        }

        class Program
        {
            static void Main(string[] args)
            {
                var movies = new Stack<Movie>();
                var showtimes = new Stack<Showtime>();
                var reservations = new Stack<Reservation>();

                // Add a movie to the stack
                var movie = new Movie()
                {
                    Title = "The Shawshank Redemption",
                    Rating = "R"
                };
                movies.Push(movie);

                // Add a showtime to the stack
                var showtime = new Showtime()
                {
                    Theater = "AMC 12",
                    Time = 1200
                };
                showtimes.Push(showtime);

                // Add a reservation to the stack
                var reservation = new Reservation()
                {
                    Theater = "AMC 12",
                    Time = 1200,
                    CustomerName = "John Smith",
                    NumTickets = 2
                };
                reservations.Push(reservation);

                // Access the top element of the stack
                //Console.WriteLine("Top element: " + reservations.Peek().CustomerName);
                //reservations.Pop();
                //Remove the

            }
        }
    }
}