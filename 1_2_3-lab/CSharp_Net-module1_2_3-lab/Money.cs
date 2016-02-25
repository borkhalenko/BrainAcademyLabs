using System;

namespace CSharp_Net_module1_2_3_lab {
    // 1) declare enumeration CurrencyTypes, values UAH, USD, EU
    public enum CurrencyTypes { UAH, USD, EU };

    public class DifferentCurrencyTypesException: ApplicationException {
        public DifferentCurrencyTypesException() { }
        public DifferentCurrencyTypesException(string description) : base(description) { }
        public DifferentCurrencyTypesException(string description, Exception innerException) : base(description, innerException) { }
    }

    public class AmountLessThanZeroException : ApplicationException {
        public AmountLessThanZeroException() { }
        public AmountLessThanZeroException(string description) : base(description) { }
        public AmountLessThanZeroException(string description, Exception innerException) : base(description, innerException) { }
    }

    class Money {
        // 2) declare 2 properties Amount, CurrencyType
        private Decimal amount;
        public Decimal Amount {
            get { return amount; }
            set {
                if (value < 0)
                    //throw new ArgumentOutOfRangeException("value", value.ToString(), "The value must be greater than or equal to 0");
                    throw new AmountLessThanZeroException("The value must be greater than or equal to 0");
                amount = value;
            }
        }
        public CurrencyTypes CurrencyType { get; private set; }

        // 3) declare parameter constructor for properties initialization
        public Money(Decimal amount, CurrencyTypes currType = CurrencyTypes.UAH) {
            Amount = amount;
            CurrencyType = currType;
        }

        public Money(double amount, CurrencyTypes currType = CurrencyTypes.UAH) : this((decimal)amount, currType) { }

        // 4) declare overloading of operator + to add 2 objects of Money
        public static Money operator+(Money op1, Money op2) {
            if (op1.CurrencyType != op2.CurrencyType) {
                throw new DifferentCurrencyTypesException("Operands have different currency type.");
            }
            return new Money(op1.Amount + op2.Amount, op1.CurrencyType); 
        }

        // 5) declare overloading of operator -- to decrease object of Money by 1
        public static Money operator--(Money op1) {
            if (op1.Amount - 1 < 0) {
                throw new AmountLessThanZeroException("operator--: result cannot be less then 0.");
            }
            return new Money(op1.Amount - 1, op1.CurrencyType);
        }

        // 6) declare overloading of operator * to increase object of Money 3 times
        public static Money operator*(Money op1, int op2) {
            return new Money(op1.Amount * 3, op1.CurrencyType);
        }

        // 7) declare overloading of operator > and < to compare 2 objects of Money
        public static bool operator>(Money op1, Money op2) {
            if (op1.CurrencyType != op2.CurrencyType) {
                throw new DifferentCurrencyTypesException("Operands have different currency type.");
            }
            return op1.Amount > op2.Amount;
        }

        public static bool operator<(Money op1, Money op2) {
            return op2 > op1;
        }

        // 8) declare overloading of operator true and false to check CurrencyType of object
        public static bool operator true(Money op1) {
            return op1.Amount > 0;
        }

        public static bool operator false(Money op1) {
            return op1.Amount <= 0;
        }

        // 9) declare overloading of implicit/ explicit conversion  to convert Money to double, string and vice versa
        public static implicit operator double(Money op1) {
            return (double)op1.Amount;
        }

        public static explicit operator string(Money op1) {
            return op1.Amount.ToString();
        }

        public static implicit operator Money(double op1) {
            return new Money(new Decimal(op1));
        }

        public static explicit operator Money(string op1) {
            return new Money(Decimal.Parse(op1));
        }

        public override string ToString() {
            return Amount.ToString() + " " + CurrencyType.ToString();
        }
    }
}
