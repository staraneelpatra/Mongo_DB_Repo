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
            var collection = db.GetCollection<BsonDocument>("BankData");

            //Count Number of Documents
            var count = collection.Count(new BsonDocument());
            Console.Write("Count = "+count);
        }

        public void Findfirst(){
            MongoClient client = new MongoClient();
            var db = client.GetDatabase("BankDB");
            var collection = db.GetCollection<BsonDocument>("BankData");

            //Retrive Data

            var document = collection.Find(new BsonDocument()).FirstOrDefault();
            Console.WriteLine(document);
        }

        public void Findall(){
            MongoClient client = new MongoClient();
            var db = client.GetDatabase("BankDB");
            var collection = db.GetCollection<BsonDocument>("BankData");
            var document = collection.Find(new BsonDocument()).ToList();
            foreach (var item in document)
            {
                Console.WriteLine(item);
            }


        }

    }
}
