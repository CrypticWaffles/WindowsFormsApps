using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace RestaurantManager
{
    [Serializable]
    public class Order
    {
        [BsonId, BsonElement("_id"), BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string OrderID { get; set; }

        [BsonElement("userID")]
        public string UserID { get; set; }

        [BsonElement("items")]
        public List<OrderItemDetail> Items { get; set; } = new List<OrderItemDetail>();

        [BsonElement("orderDate"), BsonRepresentation(MongoDB.Bson.BsonType.DateTime)]
        public DateTime OrderDate { get; set; }

        [BsonElement("status")]
        public string Status { get; set; }

        [BsonElement("totalAmount")]
        public decimal TotalAmount { get; set; }
    }
}