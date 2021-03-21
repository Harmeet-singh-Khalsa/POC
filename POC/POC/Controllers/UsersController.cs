
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using POC.DTOs;
using Microsoft.EntityFrameworkCore;

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

      

    }
}
