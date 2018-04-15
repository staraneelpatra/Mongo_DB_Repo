using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace MongoCsharpDriver.EntityClasses
{
    public class Keys
    {
        [BsonElement("KeyId")]
        public string _KeyId { get; set; }

        [BsonElement("DateOfIssue")]
        public DateTime _DateOfIssue { get; set; }
    }
}
