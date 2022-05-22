using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace REST_SQL_New.Models 
{ 
    public class MedalTotal
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string ID { get; set; }
        [BsonElement("Order")]
        public int Order { get; set; }
        [BsonElement("Country")]
        public string Country { get; set; }
        [BsonElement("Gold")]
        public int Gold { get; set; }
        [BsonElement("Silver")]
        public int Silver { get; set; }
        [BsonElement("Bronze")]
        public int Bronze { get; set; }
        [BsonElement("Total")]
        public int Total { get; set; }
        [BsonElement("Order_by_total")]
        public int Order_by_total { get; set; }
        [BsonElement("Country Code")]
        public string CountryCode { get; set; }

    }
}
