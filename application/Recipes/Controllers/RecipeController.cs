using Microsoft.AspNetCore.Mvc;
using Recipes.Interfaces;
using Recipes.Models;

namespace Recipes.Controllers;

[ApiController]
[Route("api/[controller]")]
public class RecipeController : ControllerBase
{

    private RecipeRepository repository;
    public RecipeController(RecipeRepository repository)
    {
        this.repository = repository;
    }

    [HttpGet("{id:int}", Name = "Get Recipe")]
    public IActionResult Get(int id)
    {
        var recipe = repository.Get(id);
        return Ok(recipe);
    }
    [HttpGet(Name = "Get Recipes")]
    public IActionResult Get()
    {
        var recipes = repository.Get();
        return Ok(recipes);
    }
    [HttpPost(Name = "Post Recipes")]
    public IActionResult Post(Recipe recipe)
    {
        repository.Add(recipe);
        return Ok(recipe);
    }
    [HttpPut(Name = "Put Recipes")]
    public IActionResult Put(Recipe recipe)
    {
        repository.Update(recipe);
        return Ok(recipe);
    }
    [HttpDelete("{id:int}", Name = "Delete Recipes")]
    public IActionResult Delete(int id)
    {
        repository.Delete(id);
        return Ok(id);
    }
}
