using DAL.JC.基础_行政区划;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.JC.行政区划
{
    public class AreaBLLImp:AreaBLL
    {
        private Jc_areaDAL jc_areaDal = new Jc_areaDALImp();

        public bool deleteAndChildNodeById(string id)
        {

            return jc_areaDal.deleteCurrentAndChildNode(id);
        }
    }
}
