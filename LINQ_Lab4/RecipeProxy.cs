namespace LINQ_Lab4;

public class RecipeProxy : IRecipe
{
    private readonly Recipe _recipe;

    public RecipeProxy(Recipe recipe)
    {
        _recipe = recipe;
    }

    public void Extend(int days)
    {
        if (DateTime.Now.AddDays(days) > _recipe._expirationDate)
        {
            Console.WriteLine("Error: cannot extend expiration date beyond original expiration date.");
        }
        else
        {
            _recipe.Extend(days);
        }
    }

    public override string ToString()
    {
        return _recipe.ToString();
    }
}
