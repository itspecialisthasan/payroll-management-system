using BOL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class MillUnitBL
    {
        private MillUnitDb millUnitDb;

        public MillUnitBL()
        {
            millUnitDb = new MillUnitDb();
        }

        public IEnumerable<tbl_millUnit> GetAll()
        {
            return millUnitDb.GetAllTbl_MillUnits();
        }

        public tbl_millUnit GetById(int id)
        {
            return millUnitDb.GetByIdTbl_MillUnits(id);
        }

        public void Create(tbl_millUnit tbl_MillUnit)
        {
            millUnitDb.Create(tbl_MillUnit);
        }

        public void Update(tbl_millUnit tbl_MillUnit)
        {
            millUnitDb.Update(tbl_MillUnit);
        }

        public void Delete(int id)
        {
            millUnitDb.Delete(id);
        }
    }
}
