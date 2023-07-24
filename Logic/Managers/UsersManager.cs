using Logic.Models;
using Logic.Helpers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Managers
{
    internal class UsersManager
    {
        private List<Users> users = new List<Users>();
        public UsersManager()
        {
            Directory.CreateDirectory(Path.Combine(Directory.GetCurrentDirectory(), "Users"));
            users = FileHandler.LoadUsers();
            users.Add(new Users("admin", "admin", true));
        }

        internal Users FindUser(string username, string password, bool librarian)
        {
            foreach (var user in users)
            {
                if (user.Name == username && user.Password == password && user.IsLibrarian == librarian)
                {
                    return user;
                }
            }
            return null;
        }
        internal Users RegisterUser(string username, string password, bool isLibrarian)
        {
            if (FindUser(username, password, isLibrarian) != null)
            {
                return null;
            }
            Users currentUser = new Users(username, password, isLibrarian);
            users.Add(currentUser);
            string json = JsonConvert.SerializeObject(currentUser);
            FileHandler.SaveItem(json, currentUser.Name+".txt", 1);
            return currentUser;
        }             
    }
}
