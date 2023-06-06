
namespace LINQ_Lab4;

public static class Program
{
    static void Main(string[] args)
    {
        Recipe recipe1 = new Recipe(doctorName: "Dr. Smith", expirationDate: DateTime.Now.AddDays(5));
        Recipe recipe2 = new Recipe(doctorName: "Dr. Josh", expirationDate: DateTime.Now.AddDays(11));
        Recipe recipe3 = new Recipe(doctorName: "Dr. Patel", expirationDate: DateTime.Now.AddDays(13));
        Recipe recipe4 = new Recipe(doctorName: "Dr. Lee", expirationDate: DateTime.Now.AddDays(14));
        Recipe recipe5 = new Recipe(doctorName: "Dr. Williams", expirationDate: DateTime.Now.AddDays(7));
        Recipe recipe6 = new Recipe(doctorName: "Dr. Garcia", expirationDate: DateTime.Now.AddDays(12));
        Recipe recipe7 = new Recipe(doctorName: "Dr. Kim", expirationDate: DateTime.Now.AddDays(6));
        Recipe recipe8 = new Recipe(doctorName: "Dr. Hernandez", expirationDate: DateTime.Now.AddDays(9));
        Recipe recipe9 = new Recipe(doctorName: "Dr. Davis", expirationDate: DateTime.Now.AddDays(8));
        Recipe recipe10 = new Recipe(doctorName: "Dr. Nguyen", expirationDate: DateTime.Now.AddDays(10));

        List<Recipe> recipes = new List<Recipe>();
        recipes.Add(recipe1);
        recipes.Add(recipe2);
        recipes.Add(recipe3);
        recipes.Add(recipe4);
        recipes.Add(recipe5);
        recipes.Add(recipe6);
        recipes.Add(recipe7);
        recipes.Add(recipe8);
        recipes.Add(recipe9);
        recipes.Add(recipe10);

        Console.Write("All recipes: \n");
        foreach (var recipe in recipes)
        {
            Console.WriteLine(recipe);
        }

        while (true)
        {
            Console.Write("Enter recipe number (1-10) or quit: ");
            string? recipeNumber = Console.ReadLine();
            if (recipeNumber == "quit")
            {
                break;
            }
            RecipeProxy recipeProxy = new RecipeProxy(recipes[Convert.ToInt32(recipeNumber)-1]);

            Console.Write("Enter number of days to extend: ");
            string? daysNumber = Console.ReadLine();
            recipeProxy.Extend(Convert.ToInt32(daysNumber));
        }
    }
}