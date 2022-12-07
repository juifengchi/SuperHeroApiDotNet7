namespace SuperHeroApiDotNet7.Services.SuperHeroService;

public interface ISuperHeroService
{
    List<SuperHero> GetAllHeroes();
    SuperHero? GetSingleHeroes(int id);
    List<SuperHero> AddHeroes(SuperHero hero);
    List<SuperHero>? UpdateHeroes(int id, SuperHero request);
    List<SuperHero>? DeleteHeroes(int id);
}