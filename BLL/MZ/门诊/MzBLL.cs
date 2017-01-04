using Model.JC;
using Model.MZ;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.MZ.门诊
{
    public interface MzBLL
    {

        /// <summary>
        /// 挂号：保存挂号，保存到两张表，居民表和挂号表，正常挂号和门诊医生挂号(已挂号)
        /// </summary>
        /// <param Name="jm"></param>
        /// <param Name="gh"></param>
        /// <returns></returns>
        bool saveGh(Jc_jm jm, Mz_gh gh);

        /// <summary>
        ///挂号： 划价收费的挂号（划价收费挂号）
        /// </summary>
        /// <param name="jm"></param>
        /// <param name="gh"></param>
        /// <returns></returns>
        bool saveGhForShouFei(Jc_jm jm, Mz_gh gh);

        /// <summary>
        /// 挂号：根据挂号ID，退号（已退号）
        /// </summary>
        /// <returns></returns>
        bool ghTuiHaoById(string ghId);

        /// <summary>
        /// 接诊：根据挂号ID，开始接诊病人（接诊中）
        /// </summary>
        /// <param name="ghId"></param>
        /// <returns></returns>
        bool ghJieZhenStart(string ghId);

        /// <summary>
        /// 接诊：根据挂号ID，未收费（未收费）
        /// </summary>
        /// <param name="ghId"></param>
        /// <returns></returns>
        bool ghJieZhenEnd(string ghId);




        /// <summary>
        /// 接诊：保存门诊病历信息（包括门诊病历表和门诊病历诊断表）
        /// </summary>
        /// <param name="bl"></param>
        /// <param name="blzdList"></param>
        /// <returns></returns>
        bool SaveMzbl(Mz_bl bl, List<Mz_blzd> blzdList);

        /// <summary>
        /// 接诊：修改门诊病历信息（修改门诊病历表，删除对应的门诊病历诊断表信息后再重新添加）
        /// </summary>
        /// <param name="bl"></param>
        /// <param name="blzdList"></param>
        /// <returns></returns>
        bool modifyMzbl(Mz_bl bl, List<Mz_blzd> blzdList);

        /// <summary>
        /// 接诊：根据挂号的ID，得到此号相关联的门诊病历
        /// </summary>
        /// <param name="ghId"></param>
        /// <returns></returns>
        Mz_bl getMzblByGhId(string ghId);


        /// <summary>
        /// 收费：根据挂号ID，收费记账
        /// </summary>
        /// <param name="ghId"></param>
        /// <returns></returns>
        bool shouFeiJiZhang(string ghId);

        /// <summary>
        /// 发药：根据传入的医嘱集合，修改是否完成的字段
        /// </summary>
        /// <param name="yzList"></param>
        /// <returns></returns>
        bool faYao(List<Mz_yz> yzList);

        /// <summary>
        /// 得到规定时间内已就诊未付费的挂号集合
        /// 第一个参数是查询参数，如果查询参数为null则查询所有
        /// 第二个参数是模糊查询参数，提供模糊查询功能，只适用于string类型的字段
        /// 第三个参数是排序的参数，传入排序的对象的集合，如果传null，则默认使用ID字段进行排序
        /// </summary>
        ///<param name="mz_ghParam">查询参数</param>
        ///<param name="mz_ghParamLike">模糊查询参数</param>
        ///<param name="sortList">排序参数对象的集合</param>
        /// <returns>List<object>,索引0为数据，索引1为分页对象</returns>
        List<Mz_gh> getWeiShouFeiGhListContactObject();
    }
}
