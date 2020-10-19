using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PhranksArt.Models;
using PhranksArt.Services;

namespace PhranksArt.Controllers
{
  [Route("[controller]")]
  [ApiController]
  public class ProductsController : ControllerBase
  {
    public JsonFileProductService ProductService { get; }

    public ProductsController(JsonFileProductService productService)
    {
      ProductService = productService;
    }
    [HttpGet]
    public IEnumerable<Product> Get()
    {
      return ProductService.GetProducts();
    }
    //[HttpPatch "[FromBody]}
    [Route("Rate")]
    [HttpGet ]
    public ActionResult Get([FromQuery]string ProductId, [FromQuery]int Rating)
    {
      ProductService.AddRating(ProductId, Rating);
      return Ok();
    }
  }
}
