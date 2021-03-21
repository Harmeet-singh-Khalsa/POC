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
    [Route("api/products")]
    [ApiController]
    public class ProductsController : Controller
    {
        private readonly ILogger<ProductsController> logger;
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;

        public ProductsController(ILogger<ProductsController> logger,
            ApplicationDbContext context,
            IMapper mapper)
        {
            this.logger = logger;
            this.context = context;
            this.mapper = mapper;
        }

        [HttpGet] // api/users
        public async Task<ActionResult<List<ProductsDTO>>> Get()
        {
            var users = await context.Products.AsNoTracking().ToListAsync();
            var ProductsDTOs = mapper.Map<List<ProductsDTO>>(users);
            return ProductsDTOs;
        }
    }
}
