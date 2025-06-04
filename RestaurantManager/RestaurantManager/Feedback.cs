using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager
{
    public class Feedback
    {
        [BsonId, BsonElement("_id"), BsonRepresentation(BsonType.ObjectId)]
        public string FeedbackID { get; set; } 

        [BsonElement("orderID")]
        public string OrderID { get; set; } 

        [BsonElement("rating")]
        public int Rating { get; set; } 

        [BsonElement("comment")]
        public string Comment { get; set; }

        [BsonElement("submissionDate"), BsonRepresentation(BsonType.DateTime)]
        public DateTime SubmissionDate { get; set; }

        [BsonElement("userID")]
        public string UserID { get; set; }
    }
}
