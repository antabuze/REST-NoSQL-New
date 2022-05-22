using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace REST_SQL_New.Models 
{ 
    public class Medal
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string ID { get; set; }
        [BsonElement("medal_type")]
        public string medal_type { get; set; }
        [BsonElement("medal_code")]
        public int medal_code { get; set; }
        [BsonElement("medal_date")]
        public DateTime? medal_date { get; set; }
        [BsonElement("athlete_short_name")]
        public string athlete_short_name { get; set; }
        [BsonElement("athlete_name")]
        public string athlete_name { get; set; }
        [BsonElement("athlete_sex")]
        public string athlete_sex { get; set; }
        [BsonElement("athlete_link")]
        public string athlete_link { get; set; }
        [BsonElement("event_type")]
        public string event_type { get; set; }
        [BsonElement("country")]
        public string country { get; set; }
        [BsonElement("country_code")]
        public string country_code { get; set; }
        [BsonElement("discipline")]
        public string discipline { get; set; }
        [BsonElement("discipline_code")]
        public string discipline_code { get; set; }

    }
}
