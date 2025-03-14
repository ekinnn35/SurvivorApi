using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SurvivorApi.Context;
using SurvivorApi.Entities;
using SurvivorApi.Models.Competitor;

namespace SurvivorApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CompetitorsController : ControllerBase
    {
        private readonly SurvivorDbContext _context;

        public CompetitorsController(SurvivorDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetCompetitors()
        {
            var competitors = await _context.Competitors
                .Include(c => c.Category)
                .Select(c => new CompetitorListResponse
                {
                    Id = c.Id,
                    FirstName = c.FirstName,
                    LastName = c.LastName,
                    CategoryId = c.CategoryId
                })
                .ToListAsync();

            return Ok(competitors);
        }

        [HttpPost]
        public async Task<IActionResult> AddCompetitor(CompetitorCreateRequest request)
        {
            var competitor = new Competitor
            {
                FirstName = request.FirstName,
                LastName = request.LastName,
                CategoryId = request.CategoryId
            };

            _context.Competitors.Add(competitor);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetCompetitors), new { id = competitor.Id }, competitor);
        }
    }
}
