using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Xml.Linq;

namespace SuperHeroApi.Controllers
{
    [Route("[controller]")][ApiController]
    public class SuperHeroController : ControllerBase
    {
        private static List<SuperHero> heroes = new();/*
            {
                new SuperHero { Id = 0, Name = "Spider Man", F_Name = "Peter", L_Name = "Parker", Place = "New York City" },
                new SuperHero { Id = 1, Name = "Iron Man", F_Name = "Tony", L_Name = "Stark", Place = "New York City" },
                new SuperHero { Id = 2, Name = "Hulk", F_Name = "Robert", L_Name = "Bruce Banner", Place = "New York City" },
            };*/

        [HttpGet] // GET
        public async Task<ActionResult<List<SuperHero>>> GetHeroes()
        {
            
            foreach(SuperHero hero in heroes)
            {
                Console.WriteLine(hero.Name);
            }
            return Ok(heroes);
        }

        [HttpGet("{id}")] // GET
        public async Task<ActionResult<SuperHero>> GetHero(int id)
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

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<SuperHero>>> DeleteHero(int id)
        {
            var hero = heroes.Find(h => h.Id == id);
            if (hero is null) return BadRequest("Hero not found");

            heroes.Remove(hero);
            return Ok(heroes);

        }

        [HttpGet("lastHero")] // GET The last registered hero 
        public async Task<ActionResult<SuperHero>> GetLastHero()
        {
            var last_heroe = heroes.OrderByDescending(hero => hero.Id).FirstOrDefault();
            return Ok(last_heroe);
        }
    }
}
