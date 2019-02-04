using System;

namespace TimeStamp
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime currentTime;
            string[] ArticleTitles = new string[3];
            DateTime[] TimeStamp = new DateTime[ArticleTitles.Length];
            string[] ArticleContents = new string[ArticleTitles.Length];
            string Title = "";
            string articleDesc = "";

            Console.WriteLine("Articles Distribution Module");
            Console.WriteLine("-----------------------------");
            for (int i = 0; i < ArticleTitles.Length; i++)
            {
                currentTime = DateTime.Now;

                Console.Write($" Enter article Title # {i + 1}: ");
                Title = Console.ReadLine();
                TimeStamp[i] = currentTime;
                Console.Write($" Enter article Description # {i + 1}: ");
                articleDesc = Console.ReadLine();
                //  Adding Articles to the Arrays
                ArticleTitles[i] = Title;

            }
            Console.WriteLine();
            Console.WriteLine("\t List of Articles");
            Console.WriteLine();
            Console.WriteLine($"# \t Article \t {"Posted On",10}");
            Console.WriteLine("-------------------------------------");
            for (int i = 0; i < ArticleTitles.Length; i++)
            {
                Console.Write($"{i + 1} \t ");
                Console.WriteLine($"{ArticleTitles[i],5} \t {TimeStamp[i],30}");

            }
            Console.WriteLine();
            Console.WriteLine("\t ~End of articles~");
            Console.WriteLine("-------------------------------------");
            TimeSpan timeDiff = DateTime.Now - TimeStamp[0];
            Console.ReadLine();
            Console.WriteLine("article {0}, Posted {1} seconds ago, Date-Time {2}", ArticleTitles[0], timeDiff.Seconds, DateTime.Now);

            //foreach (var item in ListOfArticles)
            //{

            //    Console.WriteLine(item);
            //    //Console.WriteLine($"Articel posted {}");
            //}

        }
    }
}
