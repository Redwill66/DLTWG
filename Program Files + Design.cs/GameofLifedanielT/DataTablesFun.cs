using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameofLifedanielT
{
    class DataTablesFun
    {
        public DataTable dt()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Id", typeof(int));
       
            dt.Columns.Add("PlayerNr", typeof(string));
            return dt;
        }
    }
}
