using Contraprobe.Models;
using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Contraprobe
{
    public class UserRepository
    {
        public void Add (UserModel user)
        {
            using (var db = new LiteDatabase(@"C:\ContraprobeDB\Contraprobe.db"))
            {
                // Get customer collection
                var users = db.GetCollection<UserModel>("users");
                users.Insert(user);
            }
        }

        public List<UserModel> GetAll()
        {
            using (var db = new LiteDatabase(@"C:\ContraprobeDB\Contraprobe.db"))
            {
                // Get customer collection
                var users = db.GetCollection<UserModel>("users");
                return users.FindAll().ToList();
            }
        }

        public void Delete(int id)
        {
            using (var db = new LiteDatabase(@"C:\ContraprobeDB\Contraprobe.db"))
            {
                // Get customer collection
                var users = db.GetCollection<UserModel>("users");
                users.Delete(id);
            }
        }

        public void Edit (UserModel user)
        {
            using (var db = new LiteDatabase(@"C:\ContraprobeDB\Contraprobe.db"))
            {
                // Get customer collection
                var users = db.GetCollection<UserModel>("users");
                users.Update(user);
            }
        }


        public UserModel Details (int id)
        {
            using (var db = new LiteDatabase(@"C:\ContraprobeDB\Contraprobe.db"))
            {
                // Get customer collection
                var users = db.GetCollection<UserModel>("users");
                return users.FindById(id);
            }
        }

    }
}