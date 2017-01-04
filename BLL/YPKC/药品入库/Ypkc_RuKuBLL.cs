using Model.YPKC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.YPKC.药品入库
{
    /// <summary>
    /// 药品入库（新增入库单，修改入库单，入库单记账）
    /// </summary>
    public interface Ypkc_RuKuBLL
    {
        /// <summary>
        /// 添加一个入库单据(包括单据明细)
        /// </summary>
        /// <param name="dj"></param>
        /// <param name="djmxList"></param>
        /// <returns></returns>
        bool addRuKuDj(Ypkc_dj dj, List<Ypkc_djmx> djmxList);

        /// <summary>
        /// 修改一个入库单据（包括单据明细；修改单据信息，删除相关单据字表信息，重新添加）
        /// </summary>
        /// <param name="dj"></param>
        /// <param name="djmxList"></param>
        /// <returns></returns>
        bool modifyRuKuDj(Ypkc_dj dj, List<Ypkc_djmx> djmxList);

        /// <summary>
        /// 删除入库单，包括入库单明细的信息
        /// </summary>
        /// <param name="djId"></param>
        /// <returns></returns>
        bool deleteRuKuDjById(string djId);

        /// <summary>
        /// 入库单记账（计算库存，如果此单据下的科室ID，药品ID，药品编码，药品批号，药品进价，都相同，才能在原有基础上新增数量，否则就新增）
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        bool jizhangRuKuDjById(string id);
    }
}
