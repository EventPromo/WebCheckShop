using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities;

namespace DataAccessLayer
{
    public class RequestRepository : Repository
    {
        public List<Request> GetRequest()
        {
            return new List<Request>();
        }

        public void SaveRequest()
        {

        }
    }
}
