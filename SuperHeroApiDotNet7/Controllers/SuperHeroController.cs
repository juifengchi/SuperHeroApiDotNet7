using Microsoft.AspNetCore.Mvc;
using SuperHeroApiDotNet7.Services.SuperHeroService;

namespace SuperHeroApiDotNet7.Controllers;

[ApiController]
[Route("[controller]")]
public class SuperHeroController : ControllerBase
{
    private readonly ISuperHeroService _superHeroService;

    public SuperHeroController(ISuperHeroService superHeroService)
    {
        _superHeroService = superHeroService;
    }
    
    [HttpGet]
    public async Task<ActionResult<List<SuperHero>>> GetAllHeroes()
    {
        return _superHeroService.GetAllHeroes();
    }
    
    [HttpGet("{id}")]
    public async Task<ActionResult<SuperHero>> GetSingleHeroes(int id)
    {
        var result = _superHeroService.GetSingleHeroes(id);
        if (result is null)
            return NotFound("Hero not found.");
        return Ok(result);
    }
    
    [HttpPost()]
    public async Task<ActionResult<List<SuperHero>>> AddHeroes(SuperHero hero)
    {
        var result = _superHeroService.AddHeroes(hero);
        return Ok(result);
    }
    
    [HttpPut("{id}")]
    public async Task<ActionResult<List<SuperHero>>> UpdateHeroes(int id, SuperHero request)
    {
        var result = _superHeroService.UpdateHeroes(id, request);
        if (result is null)
            return NotFound("Hero not found.");
        return Ok(result);
    }
    
    [HttpDelete("{id}")]
    public async Task<ActionResult<List<SuperHero>>> DeleteHeroes(int id)
    {
        var result = _superHeroService.DeleteHeroes(id);
        if (result is null)
            return NotFound("Hero not found.");
        return Ok(result);
    }
}