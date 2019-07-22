using System;

namespace Shop.Model.Metadata
{
    [AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = true)]
    public class MongoCollectionAttribute : Attribute
    {
        public MongoCollectionAttribute(string collectionName)
        {
            CollectionName = collectionName;
        }

        public string CollectionName { get; set; }

    }
}
