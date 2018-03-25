using System;
using MongoDB.Bson;
using MongoDB.Driver;
namespace MongoCsharpDriver
{
    public class Update
    {
        public void UpdateOne()
        {
            MongoClient client = new MongoClient();
            var db = client.GetDatabase("LibraryDB");
            var collection = db.GetCollection<BookStore>("BookStore");
            var filterQ = Builders<BookStore>.Filter.Eq("Auther", "Anil");
            var update = Builders<BookStore>.Update.Set("BookTitle", "Mongo Advanced Pro");
            var isupdate=collection.UpdateOne(filterQ, update);
            if(isupdate.IsModifiedCountAvailable){
                Console.WriteLine("Updated "+ isupdate.ModifiedCount+" Docs");
            }

        }
    }
}
