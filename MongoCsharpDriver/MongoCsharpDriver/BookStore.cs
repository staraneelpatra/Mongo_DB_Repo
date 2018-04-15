//Created by anil
using System;
using MongoDB.Bson;
namespace MongoCsharpDriver
{
    public class BookStore
    {
        
            public ObjectId Id { get; set; }
            public string _BookTitle { get; set; }
            public string Auther { get; set; }
            public string Category { get; set; }
            public string ISBN { get; set; }

    }
}
