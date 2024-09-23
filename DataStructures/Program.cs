using System.Diagnostics;

namespace DataStructures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MainMenu();  

            Console.ReadKey();


        }

        public static void ListMovies()
        {

            Movie deadpool3;
            deadpool3.title = "Deadpool & Wolverine";
            deadpool3.releaseYear = 2024;
            deadpool3.price = 19.99;
            deadpool3.rating = MovieRating._15;

            Console.Clear();
            Console.WriteLine(deadpool3.title + " (" + deadpool3.releaseYear + ") Rated " + deadpool3.rating);

        }

        public static void ListShows()
        {
            List<TVshow> shows = new List<TVshow>();
            shows.Add(new TVshow(" The Lord Of The Rings: The Rings of Power", 2022, 0, MovieRating._15));
            shows.Add(new TVshow(" The Boys", 2019, 7.99, MovieRating._18));
            shows.Add(new TVshow(" The Matrix", 1999, 5.99, MovieRating._18));

            Console.Clear();
            for (int i = 0; i < shows.Count; i++)
            {
                Console.Write(shows[i].ToString());
            }
        }

        public static void MainMenu()
        {
            // infinite until app is exited 
            while (true)
            {
                Console.Clear();
                Console.WriteLine(" Please choose from the following options:  \n");
                Console.WriteLine("(1) List Movies");
                Console.WriteLine("(2) List TV Shows");
                Console.WriteLine("\n");
                Console.WriteLine("(0) Exit");
                Console.WriteLine("\n");

                string userInput = Console.ReadLine();

                // did the user input a int?
                if (int.TryParse(userInput, out int integerInput)) 
                {
                    switch (integerInput)
                    {
                        case 0: 
                            Environment.Exit(0);
                            break;
                        case 1:
                            ListMovies();
                            Console.ReadKey();
                            break;
                        case 2:
                            ListShows();
                            Console.ReadKey();
                            break;

                    }
                
                }
            }

        }

        public enum MovieRating
        {
            _U,
            _12A,
            _12,
            _15,
            _18
        }

        public struct Movie 
        {
            public string title;
            public int releaseYear;
            public double price;
            public MovieRating rating;
        
        }
    }
}
