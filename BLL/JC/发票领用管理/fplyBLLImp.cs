
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;//引入事务
using Oracle.DataAccess.Client;//引入oracle驱动
using BLL.JC.基础_发票领用管理;
using Model.JC;
using DAL.JC.基础_发票领用管理;
using Model.Common;

namespace BLL.JC.发票领用管理
{


    public class FplyBLLImp : FplyBLL
    {
        private Jc_fplyDAL jc_fplyDal = new Jc_fplyDALImp();
        
    
        public bool yzfp(string lx, long fph1, long fph2)
        {
            if (fph1 > fph2)
            {
                throw new Exception("终止号不能大于起始号！");
            }

            Jc_fply fplyParam = new Jc_fply();
            fplyParam.Fplx = lx;
            List<object> objs = jc_fplyDal.find(fplyParam, null, null, null);
            List<Jc_fply> fpList = (List<Jc_fply>)objs[0];
            int n = 0;
            for (int i = 0; i < fpList.Count; i++)
            {
                Jc_fply fp = fpList[i];
                int start = Convert.ToInt32(fp.Fph_start);
                int end = Convert.ToInt32(fp.Fph_end);
                if (!(end < fph1) || (start > fph2))
                {
                    n++;
                }
            }

            if (n <= 0)
            {
                return true;
            }
            else
            {
                throw new Exception("输入的发票段中有已经领用的发票！");
            }



            //return false;
        }
    }
}

