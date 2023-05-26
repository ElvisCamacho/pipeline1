namespace Recipes.Dummies;

using Recipes.Models;

public class RecipeDummy
{
    public Dictionary<int, Recipe> recipes()
    {

        return new Dictionary<int, Recipe>(){

            {1, new Recipe(id:1, name:"Pasta", description:"Pasta with tomato sauce",
                    new List<Ingredient>(){
                        new Ingredient(name:"Pasta", quantity: 1, unit: "mg"),
                        new Ingredient(name:"Tomato", quantity: 2, unit: "mg"),
                })},
            {2, new Recipe(id:2, name:"Pizza", "Bread with toppings",
                    new List<Ingredient>(){
                        new Ingredient(name:"Bread", quantity: 1, unit: "mg"),
                        new Ingredient(name:"Cheese", quantity: 2, unit: "mg"),
                        new Ingredient(name:"Ham", quantity: 2, unit: "mg"),
                        new Ingredient(name:"Tomato Sauce", quantity: 2, unit: "mg"),

                    })},
            {3, new Recipe(id:3, name: "Sandwich", "Bread with stuffing",
                    new List<Ingredient>(){
                        new Ingredient(name:"Bread", quantity: 1, unit: "mg"),
                        new Ingredient(name:"Cheese", quantity: 2, unit: "mg"),
                        new Ingredient(name:"Ham", quantity: 2, unit: "mg"),
                        new Ingredient(name:"Tomato", quantity: 2, unit: "mg"),
                        new Ingredient(name:"Mustard", quantity: 2, unit: "mg"),
                        new Ingredient(name:"Iceberg", quantity: 2, unit: "mg"),
                        new Ingredient(name:"Cucumber", quantity: 2, unit: "mg"),
                    })},

        };


    }

}
