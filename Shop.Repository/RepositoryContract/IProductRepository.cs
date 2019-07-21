using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Shop.Model.DatabaseEntities.Product;

namespace Shop.Repository.RepositoryContract
{
    public interface IProductRepository : IRepository<ProductEntity>
    {
        //Task<IEnumerable<ProductEntity>> GetAllProducts();

        //Task<ProductEntity> GetProduct(string id);

        //Task<IEnumerable<ProductEntity>> GetProduct(string title, DateTime updatedFrom, long imageSizeLimit);

        //Task AddProduct(ProductEntity product);

        //Task<bool> RemoveProduct(string id);

        //Task<bool> UpdateProduct(string id, string title);

        //Task<bool> UpdateProduct(string id, ProductEntity product);

        //Task<bool> UpdateProductDocument(string id, string title);

        //Task<bool> RemoveAllProducts();
    }
}