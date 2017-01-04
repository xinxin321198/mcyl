
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.JC;
using Model.Common;

namespace BLL.JC.发票领用管理
{
    public interface  FplyBLL
    {
        /// <summary>
        /// 验证发票号是否可以领取
        /// </summary>
        /// <param name="lx"></param>
        /// <param name="fph1"></param>
        /// <param name="fph2"></param>
        /// <returns></returns>
        bool yzfp(string lx, long fph1, long fph2);

    }
}
