using System;
using MongoDB.Bson;
using MongoDB.Driver;
namespace MongoCsharpDriver
{
    public class Insert
    {
        public Insert()
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
