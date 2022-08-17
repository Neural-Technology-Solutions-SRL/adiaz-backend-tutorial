using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace SuperHeroApi.Controllers
{
    [Route("[controller]")][ApiController]
    public class SuperHeroController : ControllerBase
    {
        private static List<SuperHero> heroes = new List<SuperHero>
            {
                new SuperHero { Id = 0, Name = "Spider Man", F_Name = "Peter", L_Name = "Parker", Place = "New York City" },
                new SuperHero { Id = 1, Name = "Iron Man", F_Name = "Tony", L_Name = "Stark", Place = "New York City" },
                new SuperHero { Id = 2, Name = "Hulk", F_Name = "Robert", L_Name = "Bruce Banner", Place = "New York City" },
            };

        [HttpGet] // GET
        public async Task<ActionResult<List<SuperHero>>> Get()
        {
            Console.Clear();
            foreach(SuperHero hero in heroes)
            {
                Console.WriteLine(hero.Name);
            }
            return Ok(heroes);
        }

        [HttpGet("{id}")] // GET
        public async Task<ActionResult<SuperHero>> Get(int id)
        {
            var hero = heroes.Find(hero => hero.Id == id);

            if (hero is null) return BadRequest("Hero not found");

            return Ok(hero);
        }

        [HttpPost] // POST
        public async Task<ActionResult<List<SuperHero>>> AddHero(SuperHero hero)
        {
            heroes.Add(hero);
            return Ok(heroes);
        }

        [HttpPut] // PUT
        public async Task<ActionResult<List<SuperHero>>> UpdateHero(SuperHero request)
        {
            var hero = heroes.Find(hero => hero.Id == request.Id);

            if (hero is null) return BadRequest("Hero not found");
            
            hero.Name = request.Name;
            hero.F_Name = request.F_Name;
            hero.L_Name = request.L_Name;
            hero.Place = request.Place;
            
            return Ok(hero);
        }
    }
}
