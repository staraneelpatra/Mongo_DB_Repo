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

                employeeobj._EmpId = 100001;
                employeeobj._EmpName = "Nautam Sanghani";
                employeeobj._Key._KeyId = "1234";
                employeeobj._Key._DateOfIssue = DateTime.Now;
                    //_Locker={}

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

