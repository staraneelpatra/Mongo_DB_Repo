using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace MongoCsharpDriver.EntityClasses
{
    public class Lockers
    {
        [BsonElement("LockerID")]
        public string _LockerId { get; set; }

        [BsonElement("LockerType")]
        public string _LockerType { get; set; }

        [BsonElement("Floor")]
        public int _Floor { get; set; }

        [BsonElement("NoOfKeys")]
        public int _NoOfKeys { get; set; }
    }
}
