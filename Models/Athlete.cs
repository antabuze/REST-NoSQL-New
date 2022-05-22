using HotChocolate.Types.Relay;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace REST_SQL_New.Models
{
    public class Athlete
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string ID { get; set; }
        [BsonElement("name")]
        public string name { get; set; }
        [BsonElement("short_name")]
        public string short_name { get; set; }
        [BsonElement("gender")]
        public string gender { get; set; }
        [BsonElement("birth_date")]
        public DateTime? birth_date { get; set; }
        [BsonElement("birth_place")]
        public string birth_place { get; set; }
        [BsonElement("birth_country")]
        public string birth_country { get; set; }
        [BsonElement("country")]
        public string country { get; set; }
        [BsonElement("country_code")]
        public string country_code { get; set; }
        [BsonElement("discipline")]
        public string discipline { get; set; }
        [BsonElement("discipline_code")]
        public string discipline_code { get; set; }
        [BsonElement("residence_place")]
        public string residence_place { get; set; }
        [BsonElement("residence_country")]
        public string residence_country { get; set; }
        [BsonElement("height_m/ft")]
        public string height_m_ft { get; set; }
        [BsonElement("url")]
        public string url { get; set; }

    }
}
