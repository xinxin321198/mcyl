using Model.YPKC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.YPKC.药品调拨
{
    /// <summary>
    /// 药品调拨
    /// </summary>
    public interface Ypkc_DiaoBoBLL
    {
        /// <summary>
        /// 新增药品调拨单
        /// </summary>
        /// <param name="dj"></param>
        /// <param name="djmxList"></param>
        /// <returns></returns>
        bool addDiaoboDj(Ypkc_dj dj,List<Ypkc_djmx> djmxList);

        /// <summary>
        /// 修改调拨单据
        /// </summary>
        /// <param name="dj"></param>
        /// <param name="djmxList"></param>
        /// <returns></returns>
        bool modifyDiaoboDj(Ypkc_dj dj, List<Ypkc_djmx> djmxList);

        bool deleteDiaoboDjById(string djId);

        /// <summary>
        /// 记账调拨单据，传入单据的主键（来源科室的药品库存数量减少，目的科室的药品库存数量增加），（计算库存，如果药的编码和批号和价格相同，才能在原有基础上新增数量，否则就新增）
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        bool jizhangDiaoboDjById(string id);

        /// <summary>
        /// 检测某科室可调拨的药品数量（根据科室ID和药品ID来查询）
        /// </summary>
        /// <param name="keshiId"></param>
        /// <param name="ypId"></param>
        /// <returns></returns>
        int checkDiaoboCount(string keshiId,string ypId);

        Ypkc_kc getByKeshiIdAndYpId(string keshiId, string ypId,string ypPh, decimal ypJj);

        /// <summary>
        /// 单位数量换算（大单位的数量换算为小单位的数量，即大单位数量X换算比例=小单位数量）
        /// </summary>
        /// <param name="kc"></param>
        /// <returns></returns>
        decimal ddwConvertToXdwCount(Ypkc_djmx djmx);

    }
}
