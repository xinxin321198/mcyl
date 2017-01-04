using DAL.JC.基础_ICD10;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.JC.ICD10
{
    public class ICD10BLLImp:ICD10BLL
    {
        private Jc_icd10DAL jc_icd10Dal = new Jc_icd10DALImp();


        public List<object> getListByPageForFast(Model.JC.Jc_icd10 jc_icd10Param, Model.Common.PageInfo page, Model.JC.Jc_icd10 jc_icd10ParamLike, List<Model.Common.SortInfo> sortList)
        {
            //如果没有传分页对象，构建一个对应的分页对象（重点是必须给AllCount属性赋值）
            if (null == page)
            {
                page = new Model.Common.PageInfo();
                page.AllCount = jc_icd10Dal.getCount(jc_icd10Param, jc_icd10ParamLike);
            }
            return jc_icd10Dal.findForFast(jc_icd10Param, page, jc_icd10ParamLike, sortList);
             
        }
    }
}
