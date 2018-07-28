using Contraprobe.Models;
using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Contraprobe
{
    public class DrugRepository
    {
        public List<DrugModel> GetAll()
        {
            using (var db = new LiteDatabase(@"C:\ContraprobeDB\Contraprobe.db"))
            {
                // Get customer collection
                var drugs = db.GetCollection<DrugModel>("drugs");
                return drugs.FindAll().ToList();
            }
        }

        public void  Add(DrugModel drug)
        {
            using (var db = new LiteDatabase(@"C:\ContraprobeDB\Contraprobe.db"))
            {
                // Get customer collection
                var drugs = db.GetCollection<DrugModel>("drugs");
                drugs.Insert(drug);
            }
        }

        public void Delete (int id)
        {
            using (var db = new LiteDatabase(@"C:\ContraprobeDB\Contraprobe.db"))
            {
                // Get customer collection
                var drugs = db.GetCollection<DrugModel>("drugs");
                drugs.Delete(id);
            }
        }

        public DrugModel Details(int id)
        {
            using (var db = new LiteDatabase(@"C:\ContraprobeDB\Contraprobe.db"))
            {
                // Get customer collection
                var drugs = db.GetCollection<DrugModel>("drugs");
                return drugs.FindById(id);
            }
        }

        public void Edit(DrugModel drug)
        {
            using (var db = new LiteDatabase(@"C:\ContraprobeDB\Contraprobe.db"))
            {
                // Get customer collection
                var drugs = db.GetCollection<DrugModel>("drugs");
                drugs.Update(drug);
            }
        }
    }
}