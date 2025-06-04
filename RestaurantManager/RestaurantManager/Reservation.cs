using MongoDB.Bson.Serialization.Attributes;
using System;

namespace RestaurantManager
{
    [Serializable]
    public class Reservation
    {
        [BsonId, BsonElement("_id"), BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string ReservationID { get; set; }
        [BsonElement("userID"), BsonRepresentation(MongoDB.Bson.BsonType.String)]
        public string UserID { get; set; }
        [BsonElement("tableNumber"), BsonRepresentation(MongoDB.Bson.BsonType.Int32)]
        public int TableNumber { get; set; }
        [BsonElement("reservationDate"), BsonRepresentation(MongoDB.Bson.BsonType.DateTime)]
        public DateTime ReservationDate { get; set; }
        [BsonElement("numberOfPeople"), BsonRepresentation(MongoDB.Bson.BsonType.Int32)]
        public int NumberOfPeople { get; set; }
        [BsonElement("status")]
        public string Status { get; set; } = "Pending";
    }
}