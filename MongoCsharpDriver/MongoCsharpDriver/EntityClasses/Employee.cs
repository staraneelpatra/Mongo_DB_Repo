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

        [BsonElement("Gender")]
        public string _Gender { get; set; }

        [BsonElement("HasVehicle")]
        public bool _HasVehicle { get; set; }

        [BsonElement("Email")]
        public string _Email { get; set; }

        [BsonElement("ContactNo")]
        public string _ContactNo { get; set; }


        [BsonElement("Key")]
        public Keys  _Key {get;set;}

        [BsonElement("Locker")]
        public Lockers _Locker { get; set; }

        [BsonElement("Vehicle")]
        public Vehicle _Vehicle { get; set; }
    }
}
