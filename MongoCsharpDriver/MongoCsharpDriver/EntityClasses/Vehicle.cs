using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace MongoCsharpDriver.EntityClasses
{
    public class Vehicle
    {
        [BsonElement("VehicleId")]
        public string _VehicleId { get; set; }

        [BsonElement("VehicleType")]
        public string _VehicleType { get; set; }

        [BsonElement("StickerId")]
        public string _StickerId { get; set; }
    }
}
