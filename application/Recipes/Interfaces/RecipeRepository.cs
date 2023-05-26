namespace Recipes.Interfaces;
using Recipes.Models;

public interface RecipeRepository
{

    public List<Recipe> Get();
    public Recipe Get(int id);
    public void Add(Recipe recipe);
    public void Update(Recipe recipe);
    public void Delete(int id);

}
