
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using jwttokendemo.Models;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Configuration;

namespace jwttokendemo.Helpers
{
    

    public class Mongohelp
    {
      
       private readonly IMongoCollection<Student> _students;
        public Mongohelp()
        {          
            MongoClient client = new MongoClient(MongoUrl.Create(ConfigurationManager.AppSettings["MongodbUrl"]));
            IMongoDatabase db = client.GetDatabase("minclass");
            _students=db.GetCollection<Student>("student");
        }

        public  bool getstudent(string user,string pwd)
        {
            bool status = false;

            var query = _students.Find<Student>(p => p.mail==user && p.mobile ==pwd);
            if (query != null)
            {
                status = true;
            }

            return status;
        }

      //     
    }
}