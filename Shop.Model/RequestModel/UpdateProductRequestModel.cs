using System;
using Shop.Model.DatabaseEntities.Common;

namespace Shop.Model.RequestModel
{
    public class UpdateProductRequestModel
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public ImageEntity Image { get; set; }

        public decimal Price { get; set; }
    }
}
