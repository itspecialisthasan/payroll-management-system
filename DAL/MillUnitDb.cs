using BOL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MillUnitDb
    {
        private payroll_dbEntities payroll_Db;
        public MillUnitDb()
        {
            payroll_Db = new payroll_dbEntities();
        }

        public IEnumerable<tbl_millUnit> GetAllTbl_MillUnits()
        {

            return payroll_Db.tbl_millUnit.ToList();
        }
        public tbl_millUnit GetByIdTbl_MillUnits(int id)
        {
            return payroll_Db.tbl_millUnit.Find(id);
        }
        public void Create(tbl_millUnit tbl_MillUnit)
        {
            payroll_Db.tbl_millUnit.Add(tbl_MillUnit);
            payroll_Db.SaveChanges();
        }
        public void Update(tbl_millUnit tbl_MillUnit)
        {
            payroll_Db.Entry(tbl_MillUnit).State = System.Data.Entity.EntityState.Modified;
            payroll_Db.SaveChanges();
        }
        public void Delete(int id)
        {
            tbl_millUnit tbl_MillUnit = payroll_Db.tbl_millUnit.Find(id);
            payroll_Db.tbl_millUnit.Remove(tbl_MillUnit);
            payroll_Db.SaveChanges();
        }
    }
}
