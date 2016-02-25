using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Net_module1_2_3_lab {
    class Program {
        static void Main(string[] args) {
            // 10) declare 2 objects
            Money m1 = new Money(2.3);
            Money m2 = new Money(3.5M);

            // 11) do operations
            // add 2 objects of Money
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Adding m1:" + m1 + " and m2:" + m2);
            Money mSum = m1 + m2;
            Console.WriteLine(mSum.ToString());

            Money m3 = new Money(4.0M, CurrencyTypes.USD);
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Adding m1:" + m1 + " and m3:" + m3);
            try {
                Money res = m1 + m3;
                Console.WriteLine(m3.ToString());
            }
            catch (DifferentCurrencyTypesException) {
                Console.WriteLine("Ok. We're expecting for an exception.");
            }

            // add 1st object of Money and double
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Adding m1:" + m1 + " to 3.2");
            mSum = m1 + 3.2;
            Console.WriteLine(mSum.ToString());

            // decrease 2nd object of Money by 1 
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("m2 before decreasing: " + m2.ToString());
            Console.WriteLine("m2--");
            Console.WriteLine(m2--);
            Console.WriteLine("--m2");
            Console.WriteLine(--m2);

            // increase 1st object of Money
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("m1 before increasing: " + m1.ToString());
            Console.WriteLine("m1*3");
            Console.WriteLine(m1 * 3);

            // compare 2 objects of Money
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Comparing: " + m1 + ">" + m2);
            Console.WriteLine(m1 > m2);
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Comparing: " + m1 + "<" + m2);
            Console.WriteLine(m1 < m2);
            // compare 2nd object of Money and string
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Comparing: " + m1 + ">" + (Money)"2.5" + " (string)");
            Console.WriteLine(m1 > (Money)"2.5");

            // check CurrencyType of every object
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Checking CurrencyType of m1:" + m1);
            Console.WriteLine(m1.CurrencyType);

            Console.WriteLine("Checking CurrencyType of m2:" + m2);
            Console.WriteLine(m2.CurrencyType);

            Console.WriteLine("Checking CurrencyType of m3:" + m3);
            Console.WriteLine(m3.CurrencyType);

            // testing true and false operators
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("m1:" + m1 + " is True?");
            if (m1)
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");

            Money m4 = new Money(0M);

            Console.WriteLine("m4:" + m4 + " is False?");
            if (m4)
                Console.WriteLine("No");
            else
                Console.WriteLine("Yes");

            // convert 1st object of Money to string
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Converting m1:" + m1 + " to string value:");
            Console.WriteLine((string)m1);

        }
    }
}
