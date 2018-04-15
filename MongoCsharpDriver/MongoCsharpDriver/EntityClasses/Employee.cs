using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace MongoCsharpDriver.EntityClasses
{
    public class Employee
    {
        //[BsonId]
        //public ObjectId Id {get;set;}

        [BsonElement("EmpId")]
        public int _EmpId { get; set; }

       [BsonElement("EmpName")]
        public string _EmpName { get; set; }

        [BsonElement("Key")]
        public Keys  _Key {get;set;}

        //BsonElement("Locker")]
        //public Lockers _Locker { get; set; }
    }
}
