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

        [HttpGet]
        public async Task<ActionResult<List<ProductsDTO>>> Get()
        {
            var product = await context.Products.AsNoTracking().ToListAsync();
            var ProductsDTOs = mapper.Map<List<ProductsDTO>>(product);
            return ProductsDTOs;
        }

        [HttpGet("{Id:int}", Name = "getProducts")] // api/users/getUsers
        public async Task<ActionResult<ProductsDTO>> Get(int Id)
        {
            var product = await context.Products.FirstOrDefaultAsync(x => x.product_id == Id);

            if (product == null)
            {
                return NotFound();
            }

            var ProductsDTOs = mapper.Map<ProductsDTO>(product);

            return ProductsDTOs;
        }
    }
}
