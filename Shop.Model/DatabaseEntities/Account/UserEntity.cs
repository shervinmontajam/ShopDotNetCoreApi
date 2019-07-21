using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Shop.Model.DatabaseEntities.Account
{
    public class UserEntity
    {
        [BsonId]
        public ObjectId Id { get; set; }

        public string FirstName { get; set; } = string.Empty;
    }
}
