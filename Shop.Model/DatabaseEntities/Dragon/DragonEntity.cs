using MongoDB.Bson;
using System;

namespace Shop.Model.DatabaseEntities.Dragon
{
    public class DragonEntity
    {
        public ObjectId Id { get; private set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Description { get; set; }
        public int Gold { get; set; }
        public int MaxHP { get; set; }
        public int HP { get; set; }
        public BreathEntity Weapon { get; set; }
        public DateTime DateBorn { get; set; }
        public DateTime? DateDied { get; set; }

        public DragonEntity()
        {
            DateBorn = DateTime.Now;
        }
    }
}
