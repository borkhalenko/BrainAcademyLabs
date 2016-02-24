using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_Cons_Dr_Methods {
    class Program {
        static void Main(string[] args) {
            try {
                Box box = new Box();
                box.draw(20, 5, 8, 5, '.', "Hello, world!");
                Console.WriteLine("Press any key...");

                //
                Console.WriteLine("The square of the box is: " + box.Square());
                //... and recursive factorial
                Console.WriteLine("Enter the integer to compute it's factorial:");
                int num = int.Parse(Console.ReadLine());
                Console.WriteLine("Factorial " + num + " is: "+FactorialClass.Factorial(num));
            }
            catch (Exception) {
                Console.WriteLine("Error!");
            }
        }
    }
}
