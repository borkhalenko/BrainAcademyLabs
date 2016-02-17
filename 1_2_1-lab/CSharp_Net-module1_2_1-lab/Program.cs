using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Net_module1_2_1_lab {
    abstract class Cl {
        public string str;

    }
    class Program {
        static void Main(string[] args) {
            // 8) declare 2 objects. Use default and paremeter constructors
            LibraryUser unnamed = new LibraryUser();
            LibraryUser user1 = new LibraryUser("Mike", "Tyson", 100);

            // 9) do operations with books for all users: run all methods for both objects
            unnamed.AddBook("Some book 1");
            Console.WriteLine("User \"Unnamed\" - "+unnamed.ToString());
            Console.WriteLine("Using indexers - "+unnamed[0]);
            Console.WriteLine("Using BookInfo -"+unnamed.BookInfo(0));
            Console.WriteLine("Book count - "+unnamed.BookCount());
            unnamed.RemoveBook("Some book 1");
            Console.WriteLine("Book count after removing the one - "+unnamed.BookCount());
            Console.WriteLine();

            user1.AddBook("Some book 1");
            user1.AddBook("Some book 2");
            user1.AddBook("Some book 3");

            Console.WriteLine("User \"User1\" - " + user1.ToString());
            Console.WriteLine("Using indexers - " + user1[1]);
            Console.WriteLine("Using BookInfo -" + user1.BookInfo(1));
            Console.WriteLine("Book count - " + user1.BookCount());
            user1.RemoveBook("Some book 1");
            Console.WriteLine("Book count after removing the one - " + user1.BookCount());
        }
    }
}
