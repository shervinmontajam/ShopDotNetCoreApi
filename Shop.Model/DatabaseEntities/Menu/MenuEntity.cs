using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Shop.Model.DatabaseEntities.Menu
{
    public class MenuEntity
    {
        [BsonId]
        public ObjectId Id { get; set; }

        public string Name { get; set; }

        public string Title { get; set; }
    }
}
