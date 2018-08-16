using Contraprobe.Models;
using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Contraprobe
{
    public class SampleRepository
    {
        public List<SampleModel> GetAll()
        {
            using (var db = new LiteDatabase(@"C:\ContraprobeDB\Contraprobe.db"))
            {
                // Get customer collection
                var drugs = db.GetCollection<SampleModel>("drugs");
                var drugList = drugs.FindAll().ToList();
                return drugList;
            }
        }

        public void Add(SampleModel drug)
        {
            using (var db = new LiteDatabase(@"C:\ContraprobeDB\Contraprobe.db"))
            {
                // Get customer collection
                var drugs = db.GetCollection<SampleModel>("drugs");
                drugs.Insert(drug);
            }
        }

        public void Delete(int id)
        {
            using (var db = new LiteDatabase(@"C:\ContraprobeDB\Contraprobe.db"))
            {
                // Get customer collection
                var drugs = db.GetCollection<SampleModel>("drugs");
                drugs.Delete(id);
            }
        }

        public SampleModel Details(int id)
        {
            using (var db = new LiteDatabase(@"C:\ContraprobeDB\Contraprobe.db"))
            {
                // Get customer collection
                var drugs = db.GetCollection<SampleModel>("drugs");
                return drugs.FindById(id);
            }
        }

        public void Edit(SampleModel drug)
        {
            using (var db = new LiteDatabase(@"C:\ContraprobeDB\Contraprobe.db"))
            {
                var drugs = db.GetCollection<SampleModel>("drugs");
                drugs.Update(drug);
            }
        }

        public List<SampleModel> Search(SearchModel searchData)
        {
            var db = new LiteDatabase(@"C:\ContraprobeDB\Contraprobe.db");
            var listSample = db.GetCollection<SampleModel>("drugs");


            if (searchData.Product != null && searchData.Series == null)
            {
                return listSample.Find(Query.EQ("Product", searchData.Product)).ToList();
            }
            else if (searchData.Product == null && searchData.Series != null)
            {
                return listSample.Find(Query.EQ("Series", searchData.Series)).ToList();
            }
            else if (searchData.Product != null && searchData.Series != null)
            {
                return listSample.Find(
                    Query.Or(
                    Query.Contains("Product", searchData.Product),
                    Query.Contains("Series", searchData.Series)
                    )
                    ).ToList();
            }
            else
            {
                var l = listSample.FindAll().ToList();
                return l;
            }
        }
    }
}