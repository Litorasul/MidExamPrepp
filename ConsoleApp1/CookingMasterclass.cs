using System;


namespace ConsoleApp1
{
    class CookingMasterclass
    {
        static void Main(string[] args)
        {
            decimal budget = decimal.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            decimal flourPerPackage = decimal.Parse(Console.ReadLine());
            decimal eggPerPiece = decimal.Parse(Console.ReadLine());
            decimal apronPerPiece = decimal.Parse(Console.ReadLine());

            decimal flourBudget = 0;
            if (students < 5)
            {
                flourBudget = students * flourPerPackage;
            }
            else
            {
                flourBudget = students * (flourPerPackage - (flourPerPackage * (decimal)0.2));
            }
            
            decimal eggBudget = eggPerPiece * 10 * students;
            decimal apronsNeeded = Math.Ceiling(students +(decimal)(students * 0.2));
            decimal apronBudget = apronPerPiece * apronsNeeded ;
            

            decimal budgetNeeded = flourBudget + eggBudget + apronBudget;

            if (budget >= budgetNeeded)
            {
                Console.WriteLine($"Items purchased for {budgetNeeded:F2}$.");
            }
            else
            {
                decimal notEnough = budgetNeeded - budget;
                Console.WriteLine($"{notEnough:F2}$ more needed.");
            }
        }
    }
}
