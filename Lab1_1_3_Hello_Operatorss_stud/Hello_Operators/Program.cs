using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloOperators_stud
{
    class Program
    {
        static void Main(string[] args)
        {
            long a;
            Console.WriteLine(@"Please,  type the number:
            1. Farmer, wolf, goat and cabbage puzzle
            2. Console calculator
            3. Factirial calculation
            ");
            
            a = long.Parse(Console.ReadLine());
            switch (a)
            {
                case 1:
                    Farmer_puzzle();
                    Console.WriteLine("");
                    break;
                case 2:
                    Calculator();
                    Console.WriteLine("");
                    break;
                case 3:
                    Factorial_calculation();
                    Console.WriteLine("");
                    break;
                default:
                    Console.WriteLine("Exit");
                    break;
            }
            Console.WriteLine("Press any key");
            Console.ReadLine();
        }
        #region farmer
        static void Farmer_puzzle(){
            string help = @"There: farmer and wolf -1
                            There: farmer and cabbage - 2
                            There: farmer and goat -3
                            There: farmer - 4
                            Back: farmer and wolf - 5
                            Back: farmer and cabbage - 6
                            Back: farmer and goat - 7
                            Back: farmer - 8";
            

            //int thereFarmerWolf = 1;
            //int thereFarmerCabbage = 2;
            //int thereFarmerGoat = 3;
            //int thereFarmer = 4;
            //int backFarmerWolf = 5;
            //int backFarmerCabbage = 6;
            //int backFarmerGoat = 7;
            //int backFarmer = 8;
            
             

        }
        #endregion

        #region calculator
        static void Calculator(){
           
        }
        #endregion

        #region factorial
        static void Factorial_calculation(){
            int n = 0;
            Console.WriteLine("Enter arguments: ");
            
            if (int.TryParse(Console.ReadLine(), out n)== false) {
                Console.WriteLine("Can't parse input to Int32 number.");
                return;
            }
            int result = 1;
            if (n < 0){
                throw new ArgumentException("Input argument must be greather than 0.");
            }
            if (n == 0){
                result = 1;
                Console.WriteLine("factorial =" + result);
                return;
            }
            while (n > 1){
                result *= n--;
            }
            Console.WriteLine("factorial = " + result);
        }
        #endregion
    }
}
