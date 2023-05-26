using Xunit;
using Recipes.Models;

namespace Recipes.Tests;

public class IngredientTest
{
    [Fact]
    public void TestIngredientName()
    {

        var ingredient = new Ingredient(name: "Pasta", quantity: 1, unit: "mg");

        Assert.Equal("Pasta", ingredient.Name);
    }
}
