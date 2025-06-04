using MongoDB.Bson.Serialization.Attributes;
using System;

namespace BookManagement
{
    [Serializable]
    public class Book
    {
        [BsonId, BsonElement("_id"),  BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string BookID { get; set; }
        [BsonElement("title"), BsonRepresentation(MongoDB.Bson.BsonType.String)]
        public string Title { get; set; }
        [BsonElement("author"), BsonRepresentation(MongoDB.Bson.BsonType.String)]
        public string Author { get; set; }
        [BsonElement("pages"), BsonRepresentation(MongoDB.Bson.BsonType.Decimal128)]
        public decimal Pages { get; set; }
        [BsonElement("genre"), BsonRepresentation(MongoDB.Bson.BsonType.String)]
        public string Genre { get; set; }
    }
}