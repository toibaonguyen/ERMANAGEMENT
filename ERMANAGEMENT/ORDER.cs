using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERMANAGEMENT
{

    public class ORDER
    {
        private string tablename;
        private List<string> DSmamonan=new List<string> { };

        public ORDER(string t, List<string> d)
        {
            tablename = t;
            DSmamonan=d;
        }
        public void settablename(string t)
        {
            tablename=t;
        }
        public void setDSmamonan(List<string>d)
        {
            DSmamonan= d;
        }
        public string gettablename()
        {
            return tablename;
        }
        public List<string> getDSmamonan()
        {
            if (DSmamonan==null)
            {
               DSmamonan = new List<string> { };

            }
            return DSmamonan;
        }

    }
}
