using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace webAPII.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {

         IProductService productService;

        public ProductController(IProductService productService)
        {
            this.productService = productService; 
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var result = productService.GetAll();

            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest("Veri Getirilemedi");
           
        }


        [HttpPost]
        public IActionResult Post(Product product )
        {
              var result = productService.Add(product);

              if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest("Product Eklenemedi");
        }


        [HttpGet("GetById")]
        public IActionResult getById(int id)
        {
            var result = productService.GetById(id);

            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest("ELEMAN bulunamadı");
        }
        

    }
}
