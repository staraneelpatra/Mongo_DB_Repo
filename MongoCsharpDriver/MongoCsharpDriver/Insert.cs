using System;
using System.Linq;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoCsharpDriver.EntityClasses;

namespace MongoCsharpDriver
{
    public class Insert
    {
        public void InsertDB()
        {
            try
            {
                MongoClient client = new MongoClient();
                var db = client.GetDatabase("KeysDB");
                var collection = db.GetCollection<Employee>("Employees");

                Employee employeeobj = new Employee();
                employeeobj._Key = new Keys();
                employeeobj._Locker = new Lockers();
                employeeobj._Vehicle = new Vehicle();

                employeeobj._EmpId = 106752;
                employeeobj._EmpName = "Nautam Sanghani";
                employeeobj._ContactNo = "9090182938";
                employeeobj._Email = "Nautam.sanghani@slkgroup.com";
                employeeobj._Gender = "Male";
                employeeobj._HasVehicle = true;

                employeeobj._Key._KeyId = "1234";
                employeeobj._Key._DateOfIssue = DateTime.Now;

                employeeobj._Locker._Floor = 2;
                employeeobj._Locker._LockerId = "L002";
                employeeobj._Locker._LockerType = "PegionHole";
                employeeobj._Locker._NoOfKeys = 4;

                employeeobj._Vehicle._StickerId = "420";
                employeeobj._Vehicle._VehicleType = "16-Wheeler";
                employeeobj._Vehicle._VehicleId = "GJ-51-NS-420";


                collection.InsertOne(employeeobj);
                Console.WriteLine("inserted");
            }
            catch(Exception e){
                throw e;
            }
        }
    


        public void InsertData()
        {
            MongoClient client = new MongoClient();
            var db = client.GetDatabase("LibraryDB");
            var collection = db.GetCollection<BookStore>("BookStore");
            var collection1 = db.GetCollection<BsonDocument>("Data");

            BookStore bookStore = new BookStore
            {
                _BookTitle = "Angular Basics",
                ISBN = "8767687689898yu",
                Auther = "Tanya",
                Category = "NoSQL DBMS"
            };
            collection.InsertOne(bookStore);

            var doc = new BsonDocument()
            {
                { "name", "MongoDB" },
                { "type", "Database" },
                { "count", 1 },
                { "info", new BsonDocument
                    {
                        { "x", 203 },
                        { "y", 102 }
                    }}
               };
            collection1.InsertOne(doc);
            Console.WriteLine("inserted");
            
        }
    }

}

