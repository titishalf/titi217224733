using System;

namespace VideoWeb.NewDb
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new VideoContext())
            {
                Console.WriteLine("Enter movie title:");
                string title = Console.ReadLine();
                Console.WriteLine("Enter movie year:");
                string year = Console.ReadLine();
                Console.WriteLine("Enter movie category:");
                string category = Console.ReadLine();
                db.Videos.Add(new Videotbl { title = title });
                db.Videos.Add(new Videotbl { year = year});
                db.Videos.Add(new Videotbl { category_name = category });
                var count = db.SaveChanges();
                Console.WriteLine("{0} records saved to database", count);

                Console.WriteLine();
                Console.WriteLine("All blogs in database:");
                foreach (var Videotbl in db.Videos)
                {
                    Console.WriteLine(" #{0} {1} {2}", Videotbl.title, Videotbl.year, Videotbl.category_name);
                }
            }
        }
    }
}