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
        _recipe.Extend(days);
    }

    public override string ToString()
    {
        return _recipe.ToString();
    }
}
