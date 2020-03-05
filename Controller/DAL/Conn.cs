using System;
using MongoDB.Bson;
using MongoDB.Driver;

namespace DAL
{
    class Conn
    {
        static void Main(string[] args)
        {
            MongoClient dbClient = new MongoClient("");

            var database = dbClient.GetDatabase("sample_training");
            var collection = database.GetCollection<BsonDocument>("grades");

        }
    }
}
