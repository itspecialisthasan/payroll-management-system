using BOL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class User
    {
        private payroll_dbEntities payroll_DbEntities;

        public User() {
            payroll_DbEntities = new payroll_dbEntities();
        }

        public IEnumerable<tbl_user> GetUsers()
        {
            return payroll_DbEntities.tbl_user.ToList();
        }

        public tbl_user GetUser(int id)
        {
            return payroll_DbEntities.tbl_user.Find(id);
        }

        public void Create(tbl_user tbl_User)
        {
            payroll_DbEntities.tbl_user.Add(tbl_User);
            payroll_DbEntities.SaveChanges();
        }

        public void Update(tbl_user tbl_User)
        {
            payroll_DbEntities.Entry(tbl_User).State = System.Data.Entity.EntityState.Modified;
            payroll_DbEntities.SaveChanges();
        }

        public void Delete(int id)
        {
            tbl_user tbl_User = payroll_DbEntities.tbl_user.Find(id);
            payroll_DbEntities.tbl_user.Remove(tbl_User);
            payroll_DbEntities.SaveChanges();
        }
    }
}
