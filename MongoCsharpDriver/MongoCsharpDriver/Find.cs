using System;
using MongoDB.Driver;
using MongoDB.Bson;
namespace MongoCsharpDriver
{
    public class Find
    {
        public void FindCount()
        {

            MongoClient client = new MongoClient();
            var db = client.GetDatabase("BankDB");
            var collection = db.GetCollection<BookStore>("BankData");

            //Count Number of Documents
            var count = collection.Count(new BsonDocument());
            Console.Write("Count = "+count);




        }
    }
}
