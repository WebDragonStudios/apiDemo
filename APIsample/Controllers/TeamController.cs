using APISample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;

namespace APISample.Controllers
{
    public class TeamController : ApiController
    {
        Team[] teams = new Team[]
        {
            new Team { Id = 1, Name = "New York Jets",   Sport = "Football",     Stadium = "Met Life" },
            new Team { Id = 2, Name = "New York Mets",   Sport = "Baseball",     Stadium = "Citi Field" },
            new Team { Id = 3, Name = "Buffalo Sabres",  Sport = "Hockey",       Stadium = "KeyBank Center" },
            new Team { Id = 4, Name = "Buffalo Bandits", Sport = "Lacrosse",     Stadium = "KeyBank Center" },
            new Team { Id = 5, Name = "Chicago Bulls",   Sport = "Basketball",   Stadium = "United Center" }
        };

        public IEnumerable<Team> GetAllTeams()
        {
            return teams;
        }

        public IHttpActionResult GetTeam(int id)
        {
            var team = teams.FirstOrDefault((p) => p.Id == id);
            if (team == null)
            {
                return NotFound();
            }
            return Ok(team);
        }
    }
}