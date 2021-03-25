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
    [Route("api/categories")]
    [ApiController]
    public class CategoriesController : Controller
    {

        private readonly ILogger<CartController> logger;
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;

        public CategoriesController(
            ApplicationDbContext context,
            IMapper mapper)
        {
          
            this.context = context;
            this.mapper = mapper;
        }


        [HttpGet("{Id:int}", Name = "getCategory")]
            public async Task<ActionResult<ProductsDTO>> Get(int Id)
            {
                var products
                = await context.Products.FirstOrDefaultAsync(x => x.category_id == Id);

                if (products == null)
                {
                    return NotFound();
                }

                var productDTO = mapper.Map<ProductsDTO>(products);

                return productDTO;
            }
       
    }
}
