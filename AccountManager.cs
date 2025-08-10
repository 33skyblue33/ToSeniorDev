using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libraly
{
    internal class AccountManager
    {
        public List<Account> Accounts {  get; set; }

        public Account? Login(string username, string password)
        {
            return Accounts.FirstOrDefault(a => a.Username == username && a.Password == password);
        }

        public bool Register(string username, string password, bool isAdmin)
        {
            if (Accounts.Any(a => a.Username == username))
            {
                return false;
            }

            Account account = new()
            {
                Username = username,
                Password = password,
                IsAdmin = isAdmin,
                FavouriteProduct = new List<Product>()
            };

            Accounts.Add(account);
            return true;
        }
    }
}
