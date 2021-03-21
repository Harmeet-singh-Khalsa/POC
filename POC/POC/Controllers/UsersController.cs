
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using POC.DTOs;
using POC.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace POC.Controllers
{
    [Route("api/users")]
    [ApiController]

    public class UsersController 
    {
        private readonly ILogger<UsersController> logger;
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;

        public UsersController(ILogger<UsersController> logger,
            ApplicationDbContext context,
            IMapper mapper)
        {
            this.logger = logger;
            this.context = context;
            this.mapper = mapper;
        }

        [HttpGet] // api/users
        public async Task<ActionResult<List<UsersDTO>>> Get()
        {
            var users = await context.Users.AsNoTracking().ToListAsync();
            var UserDTOS = mapper.Map<List<UsersDTO>>(users);
            return UserDTOS;
        }

        [HttpGet("{Id:int}", Name = "getUsers")] // api/users/getUsers
        public async Task<ActionResult<UsersDTO>> Get(int Id)
        {
            var genre = await context.Users.FirstOrDefaultAsync(x => x.user_id == Id);

            if (genre == null)
            {
               // return NotFound();
            }

            var genreDTO = mapper.Map<UsersDTO>(genre);

            return genreDTO;
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] UsersCreationDTO genreCreation)
        {
            var genre = mapper.Map<Users>(genreCreation);
            context.Add(genre);
            await context.SaveChangesAsync();
            var genreDTO = mapper.Map<UsersDTO>(genre);

            return new CreatedAtRouteResult("getGenre", new { genreDTO.user_id }, genreDTO);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] UsersCreationDTO genreCreation)
        {
            var genre = mapper.Map<Users>(genreCreation);
            genre.user_id = id;
            context.Entry(genre).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var exists = await context.Users.AnyAsync(x => x.user_id == id);
            if (!exists)
            {
                //return NotFound();
            }

            context.Remove(new Users() { user_id = id });
            await context.SaveChangesAsync();

            return NoContent();
        }





    }
}
