using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alıştırma3
{
    internal class Program
    {

        public struct Books
        {
            public string title;
            public string author;
            public string subject;
            public int book_id;

        }
        public struct BooksDetail
        {
            public string city;
            public Books B1;
        }
        enum Days { sun ,mon,tue,wed,thu,fri,sat};
        static void Main(string[] args)
        {
            BooksDetail bookd;
            bookd.B1.title = "Leyla ile Mecnun";
            bookd.B1.author = "Burak Aksak";
            bookd.B1.subject = "Komedi";
            bookd.B1.book_id = 242424;
            bookd.city = "İSTANBUL";

            Console.WriteLine("Book 1 title:{0}", bookd.B1.title);
            Console.WriteLine("Book 1 author:{0}", bookd.B1.author);
            Console.WriteLine("Book 1 subject:{0}", bookd.B1.subject);
            Console.WriteLine("Book 1 book_id:{0}", bookd.B1.book_id);
            Console.WriteLine("Book 1 book city:{0}", bookd.city);

            int WeekdayStart = (int)Days.mon;
            int WeekdayEnd = (int)Days.fri;

            Console.WriteLine("Monday:{0}", WeekdayStart);
            Console.WriteLine("Friday:{0}", WeekdayEnd);

            Console.ReadKey();


        }
    }
}
