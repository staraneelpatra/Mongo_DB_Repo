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
            //insert.InsertData();
            insert.InsertDB();
            Find find = new Find();
            //find.FindCount();
            //find.Findfirst();
            //find.Findall();
            //find.Findany();
            //find.FindCursor();
            //find.FindFilter();
            //find.FindFilterMultiDoc();
            //find.Sorting();
            //find.Projection();

            //Update _update = new Update();
            //_update.UpdateOne();



        }
    }
}
