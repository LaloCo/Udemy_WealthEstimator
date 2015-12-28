using System;

namespace WealthCalculator
{
    public class Wealth
    {
        public float CumulativeWealth
        {
            get;
            set;
        }

        public float CumulativeInvestment
        {
            get;
            set;
        }

        public float CumulativeInterest
        {
            get;
            set;
        }

        public Wealth()
        {
            
        }

        public void calculateWealth(float monthlyInvestment, int compundsPerYear, float annualInterest, int yearsToCompund)
        {
            annualInterest = annualInterest / 100;

            float interest = annualInterest / compundsPerYear;
            int compounds = compundsPerYear * yearsToCompund;

            CumulativeWealth = (monthlyInvestment * (12 / compundsPerYear)) * ((((float)Math.Pow((1 + interest), compounds)) - 1) / (interest));
            CumulativeInvestment = monthlyInvestment * yearsToCompund * 12;
            CumulativeInterest = CumulativeWealth - CumulativeInvestment;
        }
    }
}

