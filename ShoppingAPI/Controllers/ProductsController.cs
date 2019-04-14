using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShoppingAPI.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ShoppingAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/Products")]
    public class ProductsController : Controller
    {
        Product[] products = new Product[] {
            new Product{Id=1, Name = "LED Bulb", Category="Electronics", Price=33.99m, Photo = "https://images-na.ssl-images-amazon.com/images/I/31c0CSq8edL.jpg"},
            new Product{Id=2, Name = "Computer Printers", Category="Electronics", Price=44.99m, Photo = "https://4.imimg.com/data4/UR/NV/MY-2687261/computer-printer-500x500.jpg"},
            new Product{Id=3, Name = "Computer Mouse", Category="Electronics", Price=55.99m, Photo = "https://images-na.ssl-images-amazon.com/images/I/517DkQEkBlL._SY355_.jpg"},
            new Product{Id=4, Name = "Guitar", Category="Music", Price=66.99m, Photo = "https://media.guitarcenter.com/is/image/MMGS7/LX1E-Little-Martin-Acoustic-Electric-Guitar-Natural/J29802000001000-00-500x500.jpg"},
            new Product{Id=5, Name = "Saxophone", Category="Music", Price=77.99m, Photo = "http://www.allegromusichouse.com/uploads/product/gallery/big/31_3.jpg"}
        };

        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return products;
        }

        [HttpGet("{id}", Name = "GetProduct")]
        public IActionResult GetById(int id)
        {
            var product = products.FirstOrDefault(p => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

    }
}
