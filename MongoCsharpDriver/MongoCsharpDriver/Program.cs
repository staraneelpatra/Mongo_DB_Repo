using System;
using MongoDB.Driver;
using MongoDB.Bson;

namespace MongoCsharpDriver
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            MongoClient client = new MongoClient();
            var db = client.GetDatabase("LibraryDB");
            var collection = db.GetCollection<BookStore>("BookStore");
            var collection1 = db.GetCollection<BsonDocument>("Data");
            BookStore bookStore = new BookStore
            {
                BookTitle = "MongoDB Basics",
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
