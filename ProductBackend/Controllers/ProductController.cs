using Microsoft.AspNetCore.Mvc;
using ProductBackend.Models;

namespace ProductBackend.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductController : ControllerBase
{
    [HttpGet]
    public List<Product> Get(string search)
    {
        var res = new List<Product>();
        var product1 = new Product() { Id = Guid.NewGuid(), Name = "Alma", UnitPrice = 123.4, Rating = 3, Active = true };
        res.Add(product1);
        var product2 = new Product() { Id = Guid.NewGuid(), Name = "Körte", UnitPrice = 324523.4, Rating = 2, Active = true };
        res.Add(product2);
        var product3 = new Product() { Id = Guid.NewGuid(), Name = "Barack", UnitPrice = 3434, Rating = 1, Active = true };
        res.Add(product3);


        var res2 = res
            .Where(x => x.Name.ToLower().Contains(search.ToLower()))
            .OrderBy(x => x.Rating)
            .ToList();

        return res2;

    }

}
