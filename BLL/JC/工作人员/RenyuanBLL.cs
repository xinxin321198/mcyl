using Model.JC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.JC.工作人员
{
    public interface RenyuanBLL
    {

        /// <summary>
        /// 根据工作人员的ID，删除工作人员删除相关的关系（工作人员所属科室，工作人员的账户记录）
        /// </summary>
        /// <param name="jc_renyuanParam"></param>
        /// <returns></returns>
        bool deleteRenyuanContactRecordById(string jc_renyuanId);

        /// <summary>
        /// 校验身份证号的唯一性
        /// </summary>
        void checkSfzh(Jc_renyuan jc_renyuanParam);


        /// <summary>
        /// 刷新人员科室的关系，根据人员ID（删除此人员的所有关系，重新添加）
        /// </summary>
        /// <param name="ry_ksListSave"></param>
        /// <param name="renyuanId"></param>
        /// <returns></returns>
        bool refreshRy_ksByRenyuanId(List<Jc_ry_ks> ry_ksListSave, string renyuanId);

        /// <summary>
        /// 刷新人员科室的关系，根据科室ID（删除此科室的所有关系，重新添加）
        /// </summary>
        /// <param name="ry_ksListSave"></param>
        /// <param name="renyuanId"></param>
        /// <returns></returns>
        bool refreshRy_ksByKeshiId(List<Jc_ry_ks> ry_ksListSave, string keshiId);


        /// <summary>
        /// 根据用户的主键ID，得到相关联的人员的对象
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        Jc_renyuan getRenyuanByUserId(string userId);



        /// <summary>
        /// 刷新人员用户的关系，根据人员ID（删除此人员的所有关系，重新添加）
        /// </summary>
        /// <param name="ry_ksListSave"></param>
        /// <param name="renyuanId"></param>
        /// <returns></returns>
        bool refreshRenyuanUserByRenyuanId(List<Jc_renyuan_user> renyuanUserList, string renyuanId);
    }
}
