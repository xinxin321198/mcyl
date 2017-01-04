using Model.JC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.JC.代码
{
    public interface CodeBLL
    {
        /// <summary>
        /// 根据代码类型的ID，删除该类型以及该类型下的所有代码
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        bool deleteAndCodeByCodeTypeId(string id);



        /// <summary>
        /// 根据传入CodeTypeValue和CodeValue值得到一个code对象
        /// </summary>
        /// <param name="value"></param>
        /// <param name="codeType"></param>
        /// <returns></returns>
        Jc_code getCodeByValue(string CodeValue, string codeTypeValue);

        /// <summary>
        /// 根据CodeTypeValue值，得到该类型下的所有代码对象
        /// </summary>
        /// <param name="value"></param>
        /// <param name="codeType"></param>
        /// <returns></returns>
        List<Jc_code> getListByCodeTypeValue(string codeTypeValue);
    }
}
