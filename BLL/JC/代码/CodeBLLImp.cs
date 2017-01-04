using DAL.JC.基础_代码类型字典;
using DAL.JC.基础_代码字典;
using Model.JC;
using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace BLL.JC.代码
{
    public class CodeBLLImp:CodeBLL
    {
        private Jc_code_typeDAL jc_code_typeDal = new Jc_code_typeDALImp();
        private Jc_codeDAL jc_codeDal = new Jc_codeDALImp();


        /// <summary>
        /// 根据代码类型的ID，删除该类型以及该类型下的所有代码
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool deleteAndCodeByCodeTypeId(string id)
        {
            bool flag1 = false;//指示第一个数据访问是否成功
            bool flag2 = false;//指示第二个数据访问是否成功
            bool flagResul = false//最终返回的结果
                ;
            using (TransactionScope ts = new TransactionScope())//创建一个事务对象
            {
                using (OracleConnection con = DAL.Common.OracleHelper.getConnection())//在这个事务对象中创建OracleConnection，使用事务时必须得使用同一个OracleConnection，否则达不到数据完整性的要求
                {
                    //删除type
                    Jc_code deleteCode = new Jc_code();
                    deleteCode.Fk_code_type = id;
                    flag1 = jc_codeDal.deleteByOtherCondition(deleteCode, con);//调用数据访问层的方法
                    //删除属于此type类型的所有code
                    flag2 = jc_code_typeDal.deleteById(id, con);//调用数据访问层的方法
                    if (flag1 && flag2)
                    {
                        flagResul = true;
                        ts.Complete();//执行成功之后提交整个事务
                    }
                    return flagResul;
                }
            }
        }




        /// <summary>
        /// 根据传入CodeTypeValue和CodeValue值得到一个code对象
        /// </summary>
        /// <param name="value"></param>
        /// <param name="codeType"></param>
        /// <returns></returns>
        public Jc_code getCodeByValue(string codeValue, string codeTypeValue)
        {
            Jc_code codeParam = new Jc_code();
            codeParam.Value = codeValue;
            Jc_code_type codeTypeParam = new Jc_code_type();
            codeTypeParam.Value = codeTypeValue;
            codeParam.Jc_code_type = codeTypeParam;
            List<Jc_code> codeList = (List<Jc_code>)jc_codeDal.findContactObjects(codeParam, null, null, null)[0];
            if (codeList.Count > 1)
            {
                throw new Exception(codeTypeValue + " 代码类型里有重复的代码值，请联系管理员");
            }
            return codeList[0];
        }

        /// <summary>
        /// 根据CodeTypeValue值，得到该类型下的所有代码对象
        /// </summary>
        /// <param name="value"></param>
        /// <param name="codeType"></param>
        /// <returns></returns>
        public List<Jc_code> getListByCodeTypeValue(string codeTypeValue)
        {
            Jc_code codeParam = new Jc_code();
            Jc_code_type codeTypeParam = new Jc_code_type();
            codeTypeParam.Value = codeTypeValue;
            codeParam.Jc_code_type = codeTypeParam;
            List<Jc_code> codeList = (List<Jc_code>)jc_codeDal.findContactObjects(codeParam, null, null, null)[0];

            return codeList;
        }
        
    }
}
