using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Common;

namespace BLL.Common
{
    public class CommonBLLImp:CommonBLL
    {
        public DateTime getCurrenDateTime()
        {
            DateTime currenDateTime = (DateTime)OracleHelper.ExecuteScalar("select sysdate from dual");
            return currenDateTime;
        }
    }
}
