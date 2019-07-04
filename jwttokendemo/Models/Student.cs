using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace jwttokendemo.Models
{
    public class Student
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("Name")]
        public string Name { get; set; }

        public string Sex { get; set; }

        public string City { get; set; }

        public string school { get; set; }

        public string grade { get; set; }

        public string number { get; set; }

        public string phone { get; set; }
        public string mobile { get; set; }

        public string mail { get; set; }

        public string note { get; set; }

    }
}