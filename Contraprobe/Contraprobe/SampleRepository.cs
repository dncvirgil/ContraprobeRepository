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
                return drugs.FindAll().ToList();
            }
        }

        public void  Add(SampleModel drug)
        {
            using (var db = new LiteDatabase(@"C:\ContraprobeDB\Contraprobe.db"))
            {
                // Get customer collection
                var drugs = db.GetCollection<SampleModel>("drugs");
                drugs.Insert(drug);
            }
        }

        public void Delete (int id)
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
    }
}