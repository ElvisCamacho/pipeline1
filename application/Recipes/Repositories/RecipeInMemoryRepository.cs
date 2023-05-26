using Recipes.Dummies;
using Recipes.Models;
using Recipes.Interfaces;
namespace Recipes.Repositories
{
    public class RecipeInMemoryRepository : RecipeRepository
    {
        private IDictionary<int, Recipe> recipes = new RecipeDummy().recipes();

        public void Add(Recipe recipe)
        {
            recipes.Add(recipe.Id, recipe);
        }

        public void Delete(int id)
        {
            recipes.Remove(id);
        }

        public List<Recipe> Get()
        {
            return recipes.Values.ToList();
        }

        public Recipe Get(int id)
        {
            return recipes[id];
        }

        public void Update(Recipe recipe)
        {
            recipes[recipe.Id] = recipe;
        }
    }
}
