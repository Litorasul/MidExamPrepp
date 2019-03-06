using System;


namespace ConsoleApp1
{
    class CookingMasterclass
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double flourPerPackage = double.Parse(Console.ReadLine());
            double eggPerPiece = double.Parse(Console.ReadLine());
            double apronPerPiece = double.Parse(Console.ReadLine());

            double flourBudget = 0;
            if (students < 5)
            {
                flourBudget = students * flourPerPackage;
            }
            else
            {
                flourBudget = students * (flourPerPackage - (flourPerPackage * 0.2));
            }
            
            double eggBudget = eggPerPiece * 10 * students;
            double apronBudget = apronPerPiece * (students + (students * 0.2));
            apronBudget = Math.Ceiling(apronBudget);

            double budgetNeeded = flourBudget + eggBudget + apronBudget;

            if (budget >= budgetNeeded)
            {
                Console.WriteLine($"Items purchased for {budgetNeeded:F2}$.");
            }
            else
            {
                double notEnough = budgetNeeded - budget;
                Console.WriteLine($"{notEnough:F2}$ more needed.");
            }
        }
    }
}
