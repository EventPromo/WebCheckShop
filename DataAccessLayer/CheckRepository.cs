using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities;

namespace DataAccessLayer
{
    public class CheckRepository : Repository
    {
        public List<Check> GetCheck()
        {
            return new List<Check>();
        }

        public void SaveCheck()
        {
            
        }

    }
}
