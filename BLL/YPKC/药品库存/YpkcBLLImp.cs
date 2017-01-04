using DAL.MZ.门诊_挂号;
using DAL.MZ.门诊_医嘱;
using DAL.YPKC.药品库存_库存表;
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
    public class YpkcBLLImp : YpkcBLL
    {
        private Ypkc_kcDAL ypkc_kcDal = new Ypkc_kcDALImp();
        private Mz_yzDAL yzDal = new Mz_yzDALImp();
        private Mz_ghDAL ghDal = new Mz_ghDALImp();

        public List<object> getListByPageForFast(Ypkc_kc ypkc_kcParam, PageInfo page, Ypkc_kc ypkc_kcParamLike, List<SortInfo> sortList)
        {
            //如果没有传分页对象，构建一个对应的分页对象（重点是必须给AllCount属性赋值）
            if (null == page)
            {
                page = new Model.Common.PageInfo();
                page.AllCount = ypkc_kcDal.getCount(ypkc_kcParam, ypkc_kcParamLike);
            }
            return ypkc_kcDal.findForFast(ypkc_kcParam, page, ypkc_kcParamLike, sortList);

        }


        public List<object> getListByPageForYzFast(Ypkc_kc ypkc_kcParam, PageInfo page, Ypkc_kc ypkc_kcParamLike, List<SortInfo> sortList)
        {


            if (null == page)
            {
                page = new Model.Common.PageInfo();
                page.AllCount = ypkc_kcDal.getCount(ypkc_kcParam, ypkc_kcParamLike);
            }
            List<object> objs = ypkc_kcDal.findForFast(ypkc_kcParam, page, ypkc_kcParamLike, sortList);
            List<Ypkc_kc> kcList = (List<Ypkc_kc>)objs[0];//1.药的总库存


            Mz_gh ghParam = new Mz_gh();
            ghParam.State_code = CommonCode.门诊_挂号状态.未收费;
            List<Mz_gh> ghList = (List<Mz_gh>)ghDal.find(ghParam, null, null, null)[0];//2.得到未领药的挂号单

            for (int i = 0; i < kcList.Count; i++)//3.遍历药的总库存
            {
                Ypkc_kc kcTemp = kcList[i];
                for (int j = 0; j < ghList.Count; j++)//4.遍历未领药的挂号单
                {
                    Mz_gh ghTemp = ghList[j];
                    Mz_yz yzParam = new Mz_yz();
                    yzParam.Fk_gh_id = ghTemp.Id;
                    yzParam.Fk_yp = kcTemp.Fk_yp_id;
                    yzParam.Yzlx_code = CommonCode.门诊_医嘱类型.药品;

                    //批号相同，进价相同，零售价相同的药，才能减少库存，不然就不是同一个库存不能排除数量
                    yzParam.Ph = kcTemp.Ph;
                    yzParam.Jj = kcTemp.Jj;
                    yzParam.Lsj = kcTemp.Lsj;
                    List<Mz_yz> yzList = (List<Mz_yz>)yzDal.find(yzParam, null, null, null)[0];//5.得到挂号单下的医嘱单

                    for (int k = 0; k < yzList.Count; k++)//6.遍历医嘱单
                    {
                        kcList[i].Sl = kcList[i].Sl - yzList[k].Sl;//药品库存的数量=此药品库存的数量-其它医嘱单下此药的数量
                    }

                }
            }
            return objs;
        }


        public Ypkc_kc getByYpIdForYz(Mz_yz yz)
        {

            if (yz.Yzlx_code!=CommonCode.门诊_医嘱类型.药品)
            {
                throw new Exception("医嘱必须是药品类型才可以查询可开药的库存");
            }
            //1.根据医嘱中药品的科室，id，批号，进价，零售价，查出此药的总库存
            //2.查出其它未领药的挂号单下的此种药品的数量科室，id，批号，进价，零售价 = 已开的药的数量
            //3.可开药的库存量=此药的总库存-已开的数量

            Ypkc_kc kcParam = new Ypkc_kc();
            kcParam.Fk_keshi_id = yz.Fk_keshi_id;
            kcParam.Fk_yp_id = yz.Fk_yp;
             //批号相同，进价相同，零售价相同的药，才能减少库存，不然就不是同一个库存不能排除数量
            kcParam.Ph = yz.Ph;
            kcParam.Jj = yz.Jj;
            kcParam.Lsj = yz.Lsj;
            List<Ypkc_kc> kcList = (List<Ypkc_kc>)ypkc_kcDal.find(kcParam,null,null,null)[0];
            if (kcList.Count>1)
            {
                throw new Exception("库存表中存在多条药品“ID”、“批号”和“进价”相同的数据，请联系管理员，名称为" + yz.Xmmc + "");
            }
            Ypkc_kc ypkc = kcList[0];

            Mz_gh ghParam = new Mz_gh();
            ghParam.State_code = CommonCode.门诊_挂号状态.未收费;
            List<Mz_gh> ghList = (List<Mz_gh>)ghDal.find(ghParam, null, null, null)[0];//2.得到未领药的挂号单
            for (int j = 0; j < ghList.Count; j++)//4.遍历未领药的挂号单
            {
                Mz_gh ghTemp = ghList[j];
                Mz_yz yzParam = new Mz_yz();
                yz.Fk_keshi_id = yz.Fk_keshi_id;
                yzParam.Fk_gh_id = ghTemp.Id;
                yzParam.Fk_yp = yz.Fk_yp;
                yzParam.Yzlx_code = CommonCode.门诊_医嘱类型.药品;

                //批号相同，进价相同，零售价相同的药，才能减少库存，不然就不是同一个库存不能排除数量
                yzParam.Ph = yz.Ph;
                yzParam.Jj = yz.Jj;
                yzParam.Lsj = yz.Lsj;
                List<Mz_yz> yzList = (List<Mz_yz>)yzDal.find(yzParam, null, null, null)[0];//5.得到挂号单下的医嘱单

                for (int k = 0; k < yzList.Count; k++)//6.遍历医嘱单
                {
                    ypkc.Sl = ypkc.Sl - yzList[k].Sl;//药品库存的数量=此药品库存的数量-其它医嘱单下此药的数量
                }
            }

            return ypkc;
        }


    
    }
}
