using System;

namespace Hello_Cons_Dr_Methods {
    public static class FactorialClass {
        public static long Factorial(int n) {
            if (n == 0)//The condition that limites the method for calling itself
                return 1;
            return n * Factorial(n - 1);
        }
    }
}