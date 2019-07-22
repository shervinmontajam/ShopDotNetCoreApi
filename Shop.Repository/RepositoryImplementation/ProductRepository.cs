using MongoDB.Bson;
using MongoDB.Driver;
using Shop.Model.DatabaseEntities.Product;
using Shop.Repository.ApplicationDbContext;
using Shop.Repository.RepositoryContract;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Shop.Repository.RepositoryImplementation
{
    public class ProductRepository : Repository<ProductEntity>, IProductRepository
    {

        public ProductRepository(ShopContext shopContext) : base(shopContext)
        {

        }


        //public async Task<IEnumerable<ProductEntity>> GetAllProducts()
        //{
        //    try
        //    {
        //        return await _shopContext.Products.Find(_ => true).ToListAsync();
        //    }
        //    catch (Exception exception)
        //    {
        //        // log or manage the exception
        //        throw exception;
        //    }
        //}

        //public async Task<ProductEntity> GetProduct(string id)
        //{
        //    try
        //    {
        //        ObjectId.TryParse(id, out var internalId);

        //        return await _shopContext.Products.Find(products => products.Id == internalId || products.InternalId == id).FirstOrDefaultAsync();
        //    }
        //    catch (Exception exception)
        //    {
        //        // log or manage the exception
        //        throw exception;
        //    }
        //}

        //public async Task<IEnumerable<ProductEntity>> GetProduct(string title, DateTime updatedFrom, long imageSizeLimit)
        //{
        //    try
        //    {
        //        var query = _shopContext.Products.Find(product => product.Title.Contains(title) &&
        //                                                product.UpdatedOn >= updatedFrom &&
        //                                                product.Image.ImageSize <= imageSizeLimit);

        //        return await query.ToListAsync();
        //    }
        //    catch (Exception exception)
        //    {
        //        // log or manage the exception
        //        throw exception;
        //    }
        //}

        //public async Task AddProduct(ProductEntity product)
        //{
        //    try
        //    {
        //        await _shopContext.Products.InsertOneAsync(product);
        //    }
        //    catch (Exception exception)
        //    {
        //        // log or manage the exception
        //        throw exception;
        //    }
        //}

        //public async Task<bool> RemoveProduct(string id)
        //{
        //    try
        //    {
        //        var filter = Builders<ProductEntity>.Filter.Eq("InternalId", id);
        //        var deleteResult = await _shopContext.Products.DeleteOneAsync(filter);

        //        return deleteResult.IsAcknowledged && deleteResult.DeletedCount > 0;
        //    }
        //    catch (Exception exception)
        //    {
        //        // log or manage the exception
        //        throw exception;
        //    }
        //}

        //public async Task<bool> UpdateProduct(string id, string title)
        //{
        //    var filter = Builders<ProductEntity>.Filter.Eq(s => s.InternalId, id);
        //    var update = Builders<ProductEntity>.Update.Set(s => s.Title, title).CurrentDate(s => s.UpdatedOn);

        //    try
        //    {
        //        var updateResult = await _shopContext.Products.UpdateOneAsync(filter, update);
        //        return updateResult.IsAcknowledged && updateResult.ModifiedCount > 0;
        //    }
        //    catch (Exception exception)
        //    {
        //        // log or manage the exception
        //        throw exception;
        //    }
        //}


        //public async Task<bool> UpdateProduct(string id, ProductEntity product)
        //{
        //    try
        //    {
        //        var actionResult = await _shopContext.Products.ReplaceOneAsync(n => n.InternalId.Equals(id), product, new UpdateOptions { IsUpsert = true });
        //        return actionResult.IsAcknowledged && actionResult.ModifiedCount > 0;
        //    }
        //    catch (Exception exception)
        //    {
        //        // log or manage the exception
        //        throw exception;
        //    }
        //}

        //public async Task<bool> UpdateProductDocument(string id, string title)
        //{
        //    var item = await GetProduct(id) ?? new ProductEntity();
        //    item.Title = title;
        //    item.UpdatedOn = DateTime.Now;

        //    return await UpdateProduct(id, item);
        //}

        //public async Task<bool> RemoveAllProducts()
        //{
        //    try
        //    {
        //        var actionResult = await _shopContext.Products.DeleteManyAsync(new BsonDocument());

        //        return actionResult.IsAcknowledged && actionResult.DeletedCount > 0;
        //    }
        //    catch (Exception exception)
        //    {
        //        // log or manage the exception
        //        throw exception;
        //    }
        //}

    }
}
