using MongoDB.Bson.Serialization.Attributes;
using System;

namespace RestaurantManager
{
    [Serializable]
    public class Item
    {
        [BsonId, BsonElement("_id"), BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string ItemID { get; set; }
        [BsonElement("name"), BsonRepresentation(MongoDB.Bson.BsonType.String)]
        public string Name { get; set; }
        [BsonElement("description"), BsonRepresentation(MongoDB.Bson.BsonType.String)]
        public string Description { get; set; }
        [BsonElement("price"), BsonRepresentation(MongoDB.Bson.BsonType.Decimal128)]
        public decimal Price { get; set; }
        [BsonElement("category"), BsonRepresentation(MongoDB.Bson.BsonType.String)]
        public string Category { get; set; }
    }
}