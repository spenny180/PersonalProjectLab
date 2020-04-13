using System;
namespace PersonalProjectLab
{
    public class MoneyCalculations
    {
        public MoneyCalculations()
        {
        }

        public decimal CalculatesDivisionOfCost(int NumPeople, decimal TotalCheck)
        {
            // Division of Cost equals total check amount / number of people
            decimal DOC = 0.00m;
            DOC = TotalCheck / NumPeople;
            return DOC;
        }
     
        public decimal CalculatesTipAmount(decimal TotalCheck, string Rating)
        {
            //Tip Amount equals total check x tip percent
            decimal Tip = 0.00m;
            decimal one = 0.05m;
            decimal two = 0.1m;
            decimal three = 0.2m;
            decimal four = 0.25m;
            decimal five = 0.3m;

            if (Rating == "1")
            {
                Tip = TotalCheck * one;
            }
            if (Rating == "2")
            {
                Tip = TotalCheck * two;
            }
            if (Rating == "3")
            {
                Tip = TotalCheck * three;
            }
            if (Rating == "4")
            {
                Tip = TotalCheck * four;
            }
            if (Rating == "5")
            {
                Tip = TotalCheck * five;
            }
            
            return Tip;
            
        }
    }
}
