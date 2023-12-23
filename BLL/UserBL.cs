using BOL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class UserBL
    {
        private User userdb;

        public UserBL() {
            userdb = new User();
        }

        public IEnumerable<tbl_user> GetAllUsers() {
            return userdb.GetUsers();
        }

        public tbl_user GetUser(int id)
        {
            return userdb.GetUser(id);
        }

        public void Create(tbl_user user)
        {
            userdb.Create(user);
        }
        public void Update(tbl_user user)
        {
            userdb.Update(user);
        }
        public void Delete(int id)
        {
            userdb.Delete(id);
        }
    }
}
