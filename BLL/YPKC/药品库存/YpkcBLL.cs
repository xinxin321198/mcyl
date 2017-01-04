using Model.Common;
using Model.MZ;
using Model.YPKC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.YPKC.药品库存
{
    public interface YpkcBLL
    {
        /// <summary>
        /// 快速查询（药品编号匹配第一位，药品名称匹配名称和通用名称，拼音码匹配所有）
        /// </summary>
        /// <param name="ypkc_kcParam"></param>
        /// <param name="page"></param>
        /// <param name="ypkc_kcParamLike"></param>
        /// <param name="sortList"></param>
        /// <returns></returns>
        List<object> getListByPageForFast(Ypkc_kc ypkc_kcParam, Model.Common.PageInfo page, Ypkc_kc ypkc_kcParamLike, List<SortInfo> sortList);

        /// <summary>
        /// 快速查询,针对开医嘱时查询药品，过滤出可以开药的数量（药品编号匹配第一位，药品名称匹配名称和通用名称，拼音码匹配所有）
        /// </summary>
        /// <param name="ypkc_kcParam"></param>
        /// <param name="page"></param>
        /// <param name="ypkc_kcParamLike"></param>
        /// <param name="sortList"></param>
        /// <returns></returns>
        List<object> getListByPageForYzFast(Ypkc_kc ypkc_kcParam, Model.Common.PageInfo page, Ypkc_kc ypkc_kcParamLike, List<SortInfo> sortList);


        /// <summary>
        /// 根据药品id，查询此药可以开的数量
        /// </summary>
        /// <param name="ypbh"></param>
        /// <returns></returns>
        Ypkc_kc getByYpIdForYz(Mz_yz yz);
    }
}
