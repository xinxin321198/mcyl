using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.YPKC;

namespace client.YPKC.Common
{
    public class YpkcCommon
    {
        /// <summary>
        /// 判断要保存的单据明细是否已经在list中存在，如果存在就报错
        /// </summary>
        /// <param name="djmxSave"></param>
        /// <param name="djmxList"></param>
        /// <param name="oldDjmxIndex"></param>
        public static void checkDjmxIsRepeat(Ypkc_djmx djmxSave,List<Ypkc_djmx> djmxList,int oldDjmxIndex)
        {
            for (int i = 0; i < djmxList.Count; i++)
            {
                if (i != oldDjmxIndex)
                {
                    Ypkc_djmx djmx = djmxList[i];
                    if (djmxSave.Fk_yp == djmx.Fk_yp && djmxSave.Ph == djmx.Ph && djmxSave.Jj == djmx.Jj)//如果药品的编号，批号，进价相同，则提示
                    {
                        throw new Exception(djmx.Ypmc + ",此药品已在列表中，不允许重复添加！");
                    }
                }
               
            }
        }

        /// <summary>
        /// 计算进价总金额
        /// </summary>
        /// <returns></returns>
        public static decimal figure_jjje(decimal jj, decimal count)
        {
            decimal temp = jj * count;
            return temp;
        }
        /// <summary>
        /// 计算零售价总金额
        /// </summary>
        /// <returns></returns>

        public static decimal figure_lsjje(decimal jj, decimal count)
        {
            decimal temp = jj * count;
            return temp;
        }
    }
}
