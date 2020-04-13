using System;

namespace PersonalProjectLab
{
    class Program
    {
        static void Main(string[] args)
        {
			decimal TotalCheck = 0.00m;
			string Input = "";
			Console.WriteLine("Please enter the Total Check amount");
			Input = Console.ReadLine();
			TotalCheck = decimal.Parse(Input);
			Console.WriteLine("Are you splitting the check? Enter yes or no");
			Input = Console.ReadLine();
			if (Input == "yes")
			{
				int NumPeople;
				Console.WriteLine("How many people are sharing the Bill?");
				Input = Console.ReadLine();
				NumPeople = int.Parse(Input);
				MoneyCalculations Numbers = new MoneyCalculations();
				decimal DOC = Numbers.CalculatesDivisionOfCost(NumPeople, TotalCheck);
				Console.WriteLine("Your share of the check is " + DOC);
				Console.WriteLine("Would you like to tip for your portion of the meal? Enter yes or no");
				Input = Console.ReadLine();
				if (Input == "yes")
				{
					TotalCheck = DOC;
					string Rating;
					Console.WriteLine("Please rate your meal and service on an arbitrary scale of 1-5 (no half stars)");
					Rating = Console.ReadLine();
					MoneyCalculations TipAmount = new MoneyCalculations();
					decimal Tip = TipAmount.CalculatesTipAmount(TotalCheck, Rating);
					decimal Everything = Tip + TotalCheck;
					Console.WriteLine("You tip is " + Tip);
					Console.WriteLine("Your new total check is " + Everything);
					Console.WriteLine("Thank you, and good night");
				}
				else
				{
					Console.WriteLine("Enjoy your Evening");
				}
			}
			else 
			{
				Console.WriteLine("Would you like to leave a tip? Enter yes or no");
				Input = Console.ReadLine();
				if (Input == "yes")
				{
					string Rating;
					Console.WriteLine("Please rate your meal and service on an arbitrary scale of 1-5 (no half stars)");
					Rating = Console.ReadLine();
					MoneyCalculations TipAmount = new MoneyCalculations();
					decimal Tip = TipAmount.CalculatesTipAmount(TotalCheck, Rating);
					decimal Everything = Tip + TotalCheck;
					Console.WriteLine("You tip is " + Tip);
					Console.WriteLine("Your new total check is " + Everything);
					Console.WriteLine("Thank you, and good night");
				}
				else
				{
					Console.WriteLine("Enjoy your Evening");
				}
			}


			


		}
	}
}