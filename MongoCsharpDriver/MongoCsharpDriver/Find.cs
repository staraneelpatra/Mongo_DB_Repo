//Created By anil
using System;
using MongoDB.Driver;
using MongoDB.Bson;
using System.Linq;
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

        public void Findany()
        {
            try
            {
                MongoClient client = new MongoClient();
                var db = client.GetDatabase("LibraryDB");
                var collection = db.GetCollection<BookStore>("BookStore");
                var info = collection.Find(new BsonDocument()).ToList();
                var name = info.Where(x => x.Auther == "Anil").Select(x => x.Category).FirstOrDefault();
                Console.WriteLine("Name is " + name);
                var desc = info.Select(x => x.Category);
                foreach (var q in desc)
                {
                    Console.WriteLine("Name is " + q);
                }
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }  

        public void FindCursor(){
            try
            {
                MongoClient client = new MongoClient();
                var db = client.GetDatabase("LibraryDB");
                var collections = db.GetCollection<BookStore>("BookStore");
                var cursor=collections.Find(new BsonDocument()).ToCursor();
               
                    foreach (var doc1 in cursor.ToEnumerable())
                    {
                        Console.WriteLine("Output is " + doc1.ToJson());
                    }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void FindFilter(){
            MongoClient client = new MongoClient();
            var db = client.GetDatabase("BankDB");
            var collections = db.GetCollection<BsonDocument>("BankData");
            var filter = Builders<BsonDocument>.Filter.Eq("last_name", "SMITH");
            var doc = collections.Find(filter).First();
            Console.WriteLine(doc.ToJson());
        }

        public void FindFilterMultiDoc(){
            try
            {
                MongoClient client = new MongoClient();
                var db = client.GetDatabase("BankDB");
                var collection = db.GetCollection<BsonDocument>("BankData");
                var builder = Builders<BsonDocument>.Filter;
                var filter = builder.Eq("first_name", "ANIL") | builder.Eq("last_name", "SMITH");
                var cursor = collection.Find(filter).ToCursor();
                foreach(var doc in cursor.ToEnumerable()){
                    Console.WriteLine(doc.ToJson());
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Sorting()
        {
            MongoClient client = new MongoClient();
            var db = client.GetDatabase("BankDB");
            var collection = db.GetCollection<BsonDocument>("BankData");
            var filterbuilder = Builders<BsonDocument>.Filter;
           // var sortbuilder = Builders<BsonDocument>.Sort.Ascending("first_name");
            var filterbyname = filterbuilder.Eq("last_name", "JOHNSON");
            var sortbuilder = Builders<BsonDocument>.Sort;
            var sortasc = sortbuilder.Descending("first_name");
           // var cursor = collection.Find(filterbyname).Sort(sortbuilder).ToCursor();
            var cursor = collection.Find(filterbyname).Sort(sortasc).ToCursor();
            foreach(var doc in cursor.ToEnumerable()){
                Console.WriteLine(doc.ToJson());
            }
        }

        public void Projection(){
            MongoClient client = new MongoClient();
            var db = client.GetDatabase("BankDB");
            var collection = db.GetCollection<BsonDocument>("BankData");
            var projection = Builders<BsonDocument>.Projection.Exclude("accounts");
            var cursor = collection.Find(new BsonDocument()).Project(projection).ToCursor();
            foreach (var doc in cursor.ToEnumerable()) {
                Console.WriteLine(doc);
            }
        }

    }
}
 
