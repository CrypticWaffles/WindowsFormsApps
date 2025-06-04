using MongoDB.Bson.Serialization.Attributes;
using System;

namespace BookManagementPractice
{
    [Serializable]
    public class Movie
    {
            [BsonId, BsonElement("_id"), BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
            public string MovieID { get; set; }

            [BsonElement("Title"), BsonRepresentation(MongoDB.Bson.BsonType.String)]
            public string Title { get; set; }

            [BsonElement("Director"), BsonRepresentation(MongoDB.Bson.BsonType.String)]
            public string Director { get; set; }

            [BsonElement("Runtime"), BsonRepresentation(MongoDB.Bson.BsonType.Decimal128)]
            public decimal Runtime { get; set; }

            [BsonElement("Genre"), BsonRepresentation(MongoDB.Bson.BsonType.String)]
            public string Genre { get; set; }

            [BsonElement("Year"), BsonRepresentation(MongoDB.Bson.BsonType.Decimal128)]
            public decimal Year { get; set; }
    }
}