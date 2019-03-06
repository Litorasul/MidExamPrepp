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

            int freeFlour = freeFlour = students / 5;
            double flourBudget = 0;

            if (students > 5)
            {
                flourBudget =  flourPerPackage * (students - freeFlour);
            }
            else if (students == 5)
            {
                flourBudget = flourPerPackage * 4;
            }
            else
            {
                flourBudget = flourPerPackage * students;
            }
                     
            double eggBudget = eggPerPiece * 10 * students;
            double apronsNeeded = Math.Ceiling(students + (students * 1.2));
            double apronBudget = apronPerPiece * apronsNeeded;
            double budgetNeeded = flourBudget + eggBudget + apronBudget;

            if (budget > budgetNeeded)
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
