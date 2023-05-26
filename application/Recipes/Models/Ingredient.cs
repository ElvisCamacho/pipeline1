namespace Recipes.Models;

public class Ingredient
{

    public string Name { get; set; }
    public int Quantity { get; set; }
    public string Unit { get; set; }

    public Ingredient(string name, int quantity, string unit)
    {

        this.Name = name;
        this.Quantity = quantity;
        this.Unit = unit;
    }
}
