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
            BookStore bookStore = new BookStore
            {
                BookTitle = "MongoDB Basics",
                ISBN = "8767687689898yu",
                Auther = "Tanya",
                Category = "NoSQL DBMS"
            };
           
                collection.InsertOne(bookStore);
           
            Console.WriteLine("inserted");
        }
    }
}
