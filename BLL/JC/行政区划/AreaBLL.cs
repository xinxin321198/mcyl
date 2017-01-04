using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.JC.行政区划
{
    public interface AreaBLL
    {

        /// <summary>
        /// 根据ID删除节点，并且删除相关的下级节点
        /// </summary>
        /// <param Name="id"></param>
        /// <returns></returns>
        bool deleteAndChildNodeById(string id);
    }
}
