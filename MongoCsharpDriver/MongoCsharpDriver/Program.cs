using System;
using MongoDB.Driver;
using MongoDB.Bson;

namespace MongoCsharpDriver
{
    class MainClass
    {
        public static void Main(string[] args)
        {   
            Insert insert = new Insert();
           // insert.InsertData();

            Find find = new Find();
            //find.FindCount();
            //find.Findfirst();
            //find.Findall();
            find.Findany();
        }
    }
}
