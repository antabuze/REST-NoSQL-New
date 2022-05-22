using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace REST_SQL_New.Models
{
    public class Coach
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string ID { get; set; }
        [BsonElement("name")]
        public string name { get; set; }
        [BsonElement("gender")]
        public string gender { get; set; }
        [BsonElement("birth_date")]
        public DateTime? birth_date { get; set; }
        [BsonElement("country")]
        public string country { get; set; }
        [BsonElement("discipline")]
        public string discipline { get; set; }
        [BsonElement("function")]
        public string function { get; set; }
        [BsonElement("event_type")]
        public string event_type { get; set; }
        [BsonElement("url")]
        public string url { get; set; }


    }
}
