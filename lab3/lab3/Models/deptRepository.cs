using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab3.Models
{
    public class deptRepository
    {
        plogDbContext db;
        public deptRepository(plogDbContext _db)
        {
            db = _db;
                
        }
        public List<category> getAll() {
            return db.categorys.Find();

        }
        public category getByID(int id)
        {
            return db.categorys.Find(id);
        }
    }
}
