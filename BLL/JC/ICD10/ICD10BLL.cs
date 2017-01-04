using Model.Common;
using Model.JC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.JC.ICD10
{
    public interface ICD10BLL
    {

        /// <summary>
        /// 根据参数条件，得到满足条件的JC_ICD10的所有对象列表,字母匹配ICD10及拼音码，中文名称匹配名称（使用分页的方式）
        /// 第一个参数是查询参数，如果查询参数为null则查询所有
        /// 第二个参数是分页参数，如果page参数为null,方法则会new一个默认的page，根据page中的pagesize参数查询出相应的条数
        /// 第三个参数是模糊查询参数，提供模糊查询功能，只适用于string类型的字段
        /// 第四个参数是排序的参数，传入排序的对象的集合，如果传null，则默认使用ID字段进行排序
        /// </summary>
        /// <param name="jc_icd10Param">查询参数</param>
        ///<param name="jc_icd10ParamLike">模糊查询参数</param>
        /// <param name="page">分页对象</param>
        ///<param name="sortList">排序对象的参数集合</param>
        /// <returns>List<object>,索引0为数据，索引1为分页对象</returns>
        List<object> getListByPageForFast(Jc_icd10 jc_icd10Param, Model.Common.PageInfo page, Jc_icd10 jc_icd10ParamLike, List<SortInfo> sortList);

    }
}
