namespace B.FractionCalculator
{
    using System;

    public struct Fraction
    {
        private long numerator;
        private long denominator;

        public Fraction(long numerator, long denominator) 
            : this()
        {
            this.Numerator = numerator;
            this.Denominator = denominator;
        }

        public long Numerator
        {
            get
            {
                return this.numerator;
            }

            set
            {
                this.numerator = value;
            }
        }

        public long Denominator
        {
            get
            {
                return this.denominator;
            }

            set
            {
                if (value == 0)
                {
                    throw new ArithmeticException("The denominator cannot be zero.");
                }

                this.denominator = value;
            }
        }

        public static Fraction operator +(Fraction frac1, Fraction frac2)
        {
            checked
            {
                long newNumerator = (frac1.Numerator * frac2.Denominator) + (frac2.Numerator * frac1.Denominator);
                long newDenominator = frac1.Denominator * frac2.Denominator;
                return new Fraction(newNumerator, newDenominator);
            }
        }

        public static Fraction operator -(Fraction frac1, Fraction frac2)
        {
            checked
            {
                long newNumerator = (frac1.Numerator * frac2.Denominator) - (frac2.Numerator * frac1.Denominator);
                long newDenominator = frac1.Denominator * frac2.Denominator;
                return new Fraction(newNumerator, newDenominator);
            }
        }

        public override string ToString()
        {
            return string.Format("{0}", (decimal)this.numerator / this.denominator);
        }
    }
}
