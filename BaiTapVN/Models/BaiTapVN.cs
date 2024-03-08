using System.Collections.Generic;
using System.Linq;

namespace BaiTapVN.Models
{
    public static class UserRepository
    {
        private static List<RegisterModel> _users = new List<RegisterModel>();

        public static void AddUser(RegisterModel user)
        {
            _users.Add(user);
        }

        public static RegisterModel GetUserByUsernameAndPassword(string username, string password)
        {
            return _users.FirstOrDefault(u => u.Username == username && u.Password == password);
        }
    }
}
