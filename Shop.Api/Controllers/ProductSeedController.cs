using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Shop.Model.DatabaseEntities.Common;
using Shop.Model.DatabaseEntities.Product;
using Shop.Repository.RepositoryContract;

namespace Shop.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductSeedController : ControllerBase
    {
        private readonly IProductRepository _productRepository;

        public ProductSeedController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }



        // Call an initialization - api/ProductSeed/init
        [HttpGet("{setting}")]
        public ActionResult<string> Get(string setting)
        {
            if (setting == "init")
            {
                //_productRepository.RemoveAllProducts();

                //_productRepository.AddProduct(new ProductEntity()
                //{
                //    InternalId =  "1",
                //    Title = "Test product 1",
                //    UpdatedOn = DateTime.Now,
                //    Price = 25,
                //    Image = new ImageEntity
                //    {
                //        ImageSize = 10,
                //        Url = "http://localhost/image1.png",
                //        ThumbnailUrl = "http://localhost/image1_small.png"
                //    }
                //});

                //_productRepository.AddProduct(new ProductEntity()
                //{
                //    InternalId = "2",
                //    Title = "Test product 2",
                //    UpdatedOn = DateTime.Now,
                //    Price = 34,
                //    Image = new ImageEntity
                //    {
                //        ImageSize = 152,
                //        Url = "http://localhost/image2.png",
                //        ThumbnailUrl = "http://localhost/image2_small.png"
                //    }
                //});

                //_productRepository.AddProduct(new ProductEntity()
                //{
                //    InternalId = "3",
                //    Title = "Test product 3",
                //    UpdatedOn = DateTime.Now,
                //    Price = 58,
                //    Image = new ImageEntity
                //    {
                //        ImageSize = 78,
                //        Url = "http://localhost/image3.png",
                //        ThumbnailUrl = "http://localhost/image3_small.png"
                //    }
                //});

                //_productRepository.AddProduct(new ProductEntity()
                //{
                //    InternalId = "4",
                //    Title = "Test product 4",
                //    UpdatedOn = DateTime.Now,
                //    Price = 102,
                //    Image = new ImageEntity
                //    {
                //        ImageSize = 29,
                //        Url = "http://localhost/image4.png",
                //        ThumbnailUrl = "http://localhost/image4_small.png"
                //    }
                //});

                return "Database ProductEntitysDb was created, and collection 'ProductEntitys' was filled with 4 sample items";
            }

            return "Unknown";
        }

    }
}
