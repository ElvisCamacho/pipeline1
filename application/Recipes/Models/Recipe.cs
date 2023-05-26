namespace Recipes.Models;

public class Recipe
{

    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public List<Ingredient> Ingredients { get; set; }

    public Recipe(int id, string name, string description, List<Ingredient> ingredients)
    {

        this.Id = id;
        this.Name = name;
        this.Description = description;
        this.Ingredients = ingredients;
    }

}
