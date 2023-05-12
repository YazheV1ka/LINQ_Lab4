
namespace LINQ_Lab4;

public static class Program
{
    static void Main(string[] args)
    {
        // Create a new recipe with a 5-day expiration date
        Recipe recipe = new Recipe("Dr. Smith", DateTime.Now.AddDays(5));
        Console.WriteLine(recipe.ToString());
        // Create a proxy for the recipe
        RecipeProxy recipeProxy = new RecipeProxy(recipe);

        // Try to extend the expiration date by 3 days
        recipeProxy.Extend(3);

        // Try to extend the expiration date by 7 days
        recipeProxy.Extend(7);

        Console.ReadLine();
    }
}