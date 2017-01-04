

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAL.Common;
using System.Transactions;//引入事务
using Oracle.DataAccess.Client;//引入oracle驱动
using Model.JC;
using Model.Common;

namespace DAL.JC.基础_药品字典
{
    /// <summary>
    ///数据库访问层的Jc_yp实现类
    ///此类由代码生成器生成
    ///表名：JC_YP
    ///生成日期：2016-01-20 10:36:35
    /// 

    ///作者：罗新鑫
    ///联系电话：15087010221
    ///联系邮箱：362527240@qq.com

    /// </summary>
    public class Jc_ypDALImp : Base.BasDAL, Jc_ypDAL
    {

        /// <summary>
        /// 插入一条数据（如果需要供事务使用就传入OracleConnection对象，如果不供就传入null，方法自动生成OracleConnection对象）
        /// 主键为null时，自动生成主键guid，一般不直接调用此方法，请调用save方法进行单条数据的插入和修改       
        /// </summary>
        /// <param name="jc_ypParam">要插入的jc_ypParam对象</param>
        /// <param name="con">Oracle连接对象（为null时自动生成）</param>
        /// <returns>是否添加成功（影响的行数为1时成功）</returns>
        public bool insert(Jc_yp jc_ypParam, OracleConnection con)
        {
            if ("" == jc_ypParam.Id || null == jc_ypParam.Id)
            {
                jc_ypParam.Id = Model.Common.GUIDHelper.getGuid();
            }
            List<OracleParameter> sqlparams = new List<OracleParameter>();

            StringBuilder sql = new StringBuilder("INSERT INTO JC_YP(id,ypbm,ypmc,yptymc,ypcf,yppzwh,ypzczh,gyzz,ypjx_code,ypgg,ypdcyl,ypdcyldw_code,ypyytj_code,ddw_code,xdw_code,cfybz_code,cfqxjy_code,cfqxyb_code,cfqxdm_code,cfqxjs_code,cfqxgz_code,cfqxjk_code,cfqxzz_code,cfqxzf_code,cfqxts_code,ps_code,yplx_code,ypmssyz,ypmsjjz,ypmsyfhbrqjy_code,ypmsblfy,ypfl_code,yjjb_code,txm,ewm,pym,hsxs,sfcly_code,bzpfj,bzlsj,bzmzj,bzzyj,hsbl,sfclm_code,yxzt_code,dcsxyl,dcxxyl,lxylts,lxylcs,scqy,pzrq,sfkss_code,zfbz,dcyldwbl) VALUES(:id,:ypbm,:ypmc,:yptymc,:ypcf,:yppzwh,:ypzczh,:gyzz,:ypjx_code,:ypgg,:ypdcyl,:ypdcyldw_code,:ypyytj_code,:ddw_code,:xdw_code,:cfybz_code,:cfqxjy_code,:cfqxyb_code,:cfqxdm_code,:cfqxjs_code,:cfqxgz_code,:cfqxjk_code,:cfqxzz_code,:cfqxzf_code,:cfqxts_code,:ps_code,:yplx_code,:ypmssyz,:ypmsjjz,:ypmsyfhbrqjy_code,:ypmsblfy,:ypfl_code,:yjjb_code,:txm,:ewm,:pym,:hsxs,:sfcly_code,:bzpfj,:bzlsj,:bzmzj,:bzzyj,:hsbl,:sfclm_code,:yxzt_code,:dcsxyl,:dcxxyl,:lxylts,:lxylcs,:scqy,:pzrq,:sfkss_code,:zfbz,:dcyldwbl)");

            OracleParameter pId = new OracleParameter(":id", OracleDbType.Varchar2);
            pId.Direction = ParameterDirection.Input;
            pId.Value = jc_ypParam.Id;
            sqlparams.Add(pId);
            OracleParameter pYpbm = new OracleParameter(":ypbm", OracleDbType.NVarchar2);
            pYpbm.Direction = ParameterDirection.Input;
            pYpbm.Value = jc_ypParam.Ypbm;
            sqlparams.Add(pYpbm);
            OracleParameter pYpmc = new OracleParameter(":ypmc", OracleDbType.NVarchar2);
            pYpmc.Direction = ParameterDirection.Input;
            pYpmc.Value = jc_ypParam.Ypmc;
            sqlparams.Add(pYpmc);
            OracleParameter pYptymc = new OracleParameter(":yptymc", OracleDbType.NVarchar2);
            pYptymc.Direction = ParameterDirection.Input;
            pYptymc.Value = jc_ypParam.Yptymc;
            sqlparams.Add(pYptymc);
            OracleParameter pYpcf = new OracleParameter(":ypcf", OracleDbType.NVarchar2);
            pYpcf.Direction = ParameterDirection.Input;
            pYpcf.Value = jc_ypParam.Ypcf;
            sqlparams.Add(pYpcf);
            OracleParameter pYppzwh = new OracleParameter(":yppzwh", OracleDbType.NVarchar2);
            pYppzwh.Direction = ParameterDirection.Input;
            pYppzwh.Value = jc_ypParam.Yppzwh;
            sqlparams.Add(pYppzwh);
            OracleParameter pYpzczh = new OracleParameter(":ypzczh", OracleDbType.NVarchar2);
            pYpzczh.Direction = ParameterDirection.Input;
            pYpzczh.Value = jc_ypParam.Ypzczh;
            sqlparams.Add(pYpzczh);
            OracleParameter pGyzz = new OracleParameter(":gyzz", OracleDbType.NVarchar2);
            pGyzz.Direction = ParameterDirection.Input;
            pGyzz.Value = jc_ypParam.Gyzz;
            sqlparams.Add(pGyzz);
            OracleParameter pYpjx_code = new OracleParameter(":ypjx_code", OracleDbType.NVarchar2);
            pYpjx_code.Direction = ParameterDirection.Input;
            pYpjx_code.Value = jc_ypParam.Ypjx_code;
            sqlparams.Add(pYpjx_code);
            OracleParameter pYpgg = new OracleParameter(":ypgg", OracleDbType.NVarchar2);
            pYpgg.Direction = ParameterDirection.Input;
            pYpgg.Value = jc_ypParam.Ypgg;
            sqlparams.Add(pYpgg);
            OracleParameter pYpdcyl = new OracleParameter(":ypdcyl", OracleDbType.Decimal);
            pYpdcyl.Direction = ParameterDirection.Input;
            pYpdcyl.Value = jc_ypParam.Ypdcyl;
            sqlparams.Add(pYpdcyl);
            OracleParameter pYpdcyldw_code = new OracleParameter(":ypdcyldw_code", OracleDbType.NVarchar2);
            pYpdcyldw_code.Direction = ParameterDirection.Input;
            pYpdcyldw_code.Value = jc_ypParam.Ypdcyldw_code;
            sqlparams.Add(pYpdcyldw_code);
            OracleParameter pYpyytj_code = new OracleParameter(":ypyytj_code", OracleDbType.NVarchar2);
            pYpyytj_code.Direction = ParameterDirection.Input;
            pYpyytj_code.Value = jc_ypParam.Ypyytj_code;
            sqlparams.Add(pYpyytj_code);
            OracleParameter pDdw_code = new OracleParameter(":ddw_code", OracleDbType.NVarchar2);
            pDdw_code.Direction = ParameterDirection.Input;
            pDdw_code.Value = jc_ypParam.Ddw_code;
            sqlparams.Add(pDdw_code);
            OracleParameter pXdw_code = new OracleParameter(":xdw_code", OracleDbType.NVarchar2);
            pXdw_code.Direction = ParameterDirection.Input;
            pXdw_code.Value = jc_ypParam.Xdw_code;
            sqlparams.Add(pXdw_code);
            OracleParameter pCfybz_code = new OracleParameter(":cfybz_code", OracleDbType.NVarchar2);
            pCfybz_code.Direction = ParameterDirection.Input;
            pCfybz_code.Value = jc_ypParam.Cfybz_code;
            sqlparams.Add(pCfybz_code);
            OracleParameter pCfqxjy_code = new OracleParameter(":cfqxjy_code", OracleDbType.NVarchar2);
            pCfqxjy_code.Direction = ParameterDirection.Input;
            pCfqxjy_code.Value = jc_ypParam.Cfqxjy_code;
            sqlparams.Add(pCfqxjy_code);
            OracleParameter pCfqxyb_code = new OracleParameter(":cfqxyb_code", OracleDbType.NVarchar2);
            pCfqxyb_code.Direction = ParameterDirection.Input;
            pCfqxyb_code.Value = jc_ypParam.Cfqxyb_code;
            sqlparams.Add(pCfqxyb_code);
            OracleParameter pCfqxdm_code = new OracleParameter(":cfqxdm_code", OracleDbType.NVarchar2);
            pCfqxdm_code.Direction = ParameterDirection.Input;
            pCfqxdm_code.Value = jc_ypParam.Cfqxdm_code;
            sqlparams.Add(pCfqxdm_code);
            OracleParameter pCfqxjs_code = new OracleParameter(":cfqxjs_code", OracleDbType.NVarchar2);
            pCfqxjs_code.Direction = ParameterDirection.Input;
            pCfqxjs_code.Value = jc_ypParam.Cfqxjs_code;
            sqlparams.Add(pCfqxjs_code);
            OracleParameter pCfqxgz_code = new OracleParameter(":cfqxgz_code", OracleDbType.NVarchar2);
            pCfqxgz_code.Direction = ParameterDirection.Input;
            pCfqxgz_code.Value = jc_ypParam.Cfqxgz_code;
            sqlparams.Add(pCfqxgz_code);
            OracleParameter pCfqxjk_code = new OracleParameter(":cfqxjk_code", OracleDbType.NVarchar2);
            pCfqxjk_code.Direction = ParameterDirection.Input;
            pCfqxjk_code.Value = jc_ypParam.Cfqxjk_code;
            sqlparams.Add(pCfqxjk_code);
            OracleParameter pCfqxzz_code = new OracleParameter(":cfqxzz_code", OracleDbType.NVarchar2);
            pCfqxzz_code.Direction = ParameterDirection.Input;
            pCfqxzz_code.Value = jc_ypParam.Cfqxzz_code;
            sqlparams.Add(pCfqxzz_code);
            OracleParameter pCfqxzf_code = new OracleParameter(":cfqxzf_code", OracleDbType.NVarchar2);
            pCfqxzf_code.Direction = ParameterDirection.Input;
            pCfqxzf_code.Value = jc_ypParam.Cfqxzf_code;
            sqlparams.Add(pCfqxzf_code);
            OracleParameter pCfqxts_code = new OracleParameter(":cfqxts_code", OracleDbType.NVarchar2);
            pCfqxts_code.Direction = ParameterDirection.Input;
            pCfqxts_code.Value = jc_ypParam.Cfqxts_code;
            sqlparams.Add(pCfqxts_code);
            OracleParameter pPs_code = new OracleParameter(":ps_code", OracleDbType.NVarchar2);
            pPs_code.Direction = ParameterDirection.Input;
            pPs_code.Value = jc_ypParam.Ps_code;
            sqlparams.Add(pPs_code);
            OracleParameter pYplx_code = new OracleParameter(":yplx_code", OracleDbType.NVarchar2);
            pYplx_code.Direction = ParameterDirection.Input;
            pYplx_code.Value = jc_ypParam.Yplx_code;
            sqlparams.Add(pYplx_code);
            OracleParameter pYpmssyz = new OracleParameter(":ypmssyz", OracleDbType.NVarchar2);
            pYpmssyz.Direction = ParameterDirection.Input;
            pYpmssyz.Value = jc_ypParam.Ypmssyz;
            sqlparams.Add(pYpmssyz);
            OracleParameter pYpmsjjz = new OracleParameter(":ypmsjjz", OracleDbType.NVarchar2);
            pYpmsjjz.Direction = ParameterDirection.Input;
            pYpmsjjz.Value = jc_ypParam.Ypmsjjz;
            sqlparams.Add(pYpmsjjz);
            OracleParameter pYpmsyfhbrqjy_code = new OracleParameter(":ypmsyfhbrqjy_code", OracleDbType.NVarchar2);
            pYpmsyfhbrqjy_code.Direction = ParameterDirection.Input;
            pYpmsyfhbrqjy_code.Value = jc_ypParam.Ypmsyfhbrqjy_code;
            sqlparams.Add(pYpmsyfhbrqjy_code);
            OracleParameter pYpmsblfy = new OracleParameter(":ypmsblfy", OracleDbType.NVarchar2);
            pYpmsblfy.Direction = ParameterDirection.Input;
            pYpmsblfy.Value = jc_ypParam.Ypmsblfy;
            sqlparams.Add(pYpmsblfy);
            OracleParameter pYpfl_code = new OracleParameter(":ypfl_code", OracleDbType.NVarchar2);
            pYpfl_code.Direction = ParameterDirection.Input;
            pYpfl_code.Value = jc_ypParam.Ypfl_code;
            sqlparams.Add(pYpfl_code);
            OracleParameter pYjjb_code = new OracleParameter(":yjjb_code", OracleDbType.NVarchar2);
            pYjjb_code.Direction = ParameterDirection.Input;
            pYjjb_code.Value = jc_ypParam.Yjjb_code;
            sqlparams.Add(pYjjb_code);
            OracleParameter pTxm = new OracleParameter(":txm", OracleDbType.NVarchar2);
            pTxm.Direction = ParameterDirection.Input;
            pTxm.Value = jc_ypParam.Txm;
            sqlparams.Add(pTxm);
            OracleParameter pEwm = new OracleParameter(":ewm", OracleDbType.NVarchar2);
            pEwm.Direction = ParameterDirection.Input;
            pEwm.Value = jc_ypParam.Ewm;
            sqlparams.Add(pEwm);
            OracleParameter pPym = new OracleParameter(":pym", OracleDbType.NVarchar2);
            pPym.Direction = ParameterDirection.Input;
            pPym.Value = jc_ypParam.Pym;
            sqlparams.Add(pPym);
            OracleParameter pHsxs = new OracleParameter(":hsxs", OracleDbType.Decimal);
            pHsxs.Direction = ParameterDirection.Input;
            pHsxs.Value = jc_ypParam.Hsxs;
            sqlparams.Add(pHsxs);
            OracleParameter pSfcly_code = new OracleParameter(":sfcly_code", OracleDbType.NVarchar2);
            pSfcly_code.Direction = ParameterDirection.Input;
            pSfcly_code.Value = jc_ypParam.Sfcly_code;
            sqlparams.Add(pSfcly_code);
            OracleParameter pBzpfj = new OracleParameter(":bzpfj", OracleDbType.Decimal);
            pBzpfj.Direction = ParameterDirection.Input;
            pBzpfj.Value = jc_ypParam.Bzpfj;
            sqlparams.Add(pBzpfj);
            OracleParameter pBzlsj = new OracleParameter(":bzlsj", OracleDbType.Decimal);
            pBzlsj.Direction = ParameterDirection.Input;
            pBzlsj.Value = jc_ypParam.Bzlsj;
            sqlparams.Add(pBzlsj);
            OracleParameter pBzmzj = new OracleParameter(":bzmzj", OracleDbType.Decimal);
            pBzmzj.Direction = ParameterDirection.Input;
            pBzmzj.Value = jc_ypParam.Bzmzj;
            sqlparams.Add(pBzmzj);
            OracleParameter pBzzyj = new OracleParameter(":bzzyj", OracleDbType.Decimal);
            pBzzyj.Direction = ParameterDirection.Input;
            pBzzyj.Value = jc_ypParam.Bzzyj;
            sqlparams.Add(pBzzyj);
            OracleParameter pHsbl = new OracleParameter(":hsbl", OracleDbType.Decimal);
            pHsbl.Direction = ParameterDirection.Input;
            pHsbl.Value = jc_ypParam.Hsbl;
            sqlparams.Add(pHsbl);
            OracleParameter pSfclm_code = new OracleParameter(":sfclm_code", OracleDbType.NVarchar2);
            pSfclm_code.Direction = ParameterDirection.Input;
            pSfclm_code.Value = jc_ypParam.Sfclm_code;
            sqlparams.Add(pSfclm_code);
            OracleParameter pYxzt_code = new OracleParameter(":yxzt_code", OracleDbType.NVarchar2);
            pYxzt_code.Direction = ParameterDirection.Input;
            pYxzt_code.Value = jc_ypParam.Yxzt_code;
            sqlparams.Add(pYxzt_code);
            OracleParameter pDcsxyl = new OracleParameter(":dcsxyl", OracleDbType.Decimal);
            pDcsxyl.Direction = ParameterDirection.Input;
            pDcsxyl.Value = jc_ypParam.Dcsxyl;
            sqlparams.Add(pDcsxyl);
            OracleParameter pDcxxyl = new OracleParameter(":dcxxyl", OracleDbType.Decimal);
            pDcxxyl.Direction = ParameterDirection.Input;
            pDcxxyl.Value = jc_ypParam.Dcxxyl;
            sqlparams.Add(pDcxxyl);
            OracleParameter pLxylts = new OracleParameter(":lxylts", OracleDbType.Decimal);
            pLxylts.Direction = ParameterDirection.Input;
            pLxylts.Value = jc_ypParam.Lxylts;
            sqlparams.Add(pLxylts);
            OracleParameter pLxylcs = new OracleParameter(":lxylcs", OracleDbType.Decimal);
            pLxylcs.Direction = ParameterDirection.Input;
            pLxylcs.Value = jc_ypParam.Lxylcs;
            sqlparams.Add(pLxylcs);
            OracleParameter pScqy = new OracleParameter(":scqy", OracleDbType.NVarchar2);
            pScqy.Direction = ParameterDirection.Input;
            pScqy.Value = jc_ypParam.Scqy;
            sqlparams.Add(pScqy);
            OracleParameter pPzrq = new OracleParameter(":pzrq", OracleDbType.Date);
            pPzrq.Direction = ParameterDirection.Input;
            pPzrq.Value = jc_ypParam.Pzrq;
            sqlparams.Add(pPzrq);
            OracleParameter pSfkss_code = new OracleParameter(":sfkss_code", OracleDbType.NVarchar2);
            pSfkss_code.Direction = ParameterDirection.Input;
            pSfkss_code.Value = jc_ypParam.Sfkss_code;
            sqlparams.Add(pSfkss_code);
            OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
            pZfbz.Direction = ParameterDirection.Input;
            pZfbz.Value = jc_ypParam.Zfbz;
            sqlparams.Add(pZfbz);
            OracleParameter pDcyldwbl = new OracleParameter(":dcyldwbl", OracleDbType.Decimal);
            pDcyldwbl.Direction = ParameterDirection.Input;
            pDcyldwbl.Value = jc_ypParam.Dcyldwbl;
            sqlparams.Add(pDcyldwbl);
            bool result = false;
            int flag = OracleHelper.ExecuteNonQuery(sql.ToString(), con, sqlparams.ToArray());
            if (1 == flag)
            {
                result = true;
            }
            return result;

        }

        /// <summary>
        /// 插入多条数据（如果需要供事务使用就传入OracleConnection对象，如果不供就传入null，方法自动生成OracleConnection对象,并且自动使用事务）
        /// 主键为null时，自动生成主键guid
        /// </summary>
        /// <param name="jc_ypParamList">要插入的jc_ypParam对象的集合</param>
        /// <param name="con">Oracle连接对象（为null时自动生成）</param>
        /// <returns>是否添加成功（影响的行数等于保存的对象的数量时成功）</returns>
        public bool inertBatch(List<Jc_yp> jc_ypParamList, OracleConnection con)
        {
            if (jc_ypParamList.Count == 0)
            {
                return true;
            }

            List<string> idList = new List<string>();

            List<string> ypbmList = new List<string>();

            List<string> ypmcList = new List<string>();

            List<string> yptymcList = new List<string>();

            List<string> ypcfList = new List<string>();

            List<string> yppzwhList = new List<string>();

            List<string> ypzczhList = new List<string>();

            List<string> gyzzList = new List<string>();

            List<string> ypjx_codeList = new List<string>();

            List<string> ypggList = new List<string>();

            List<decimal?> ypdcylList = new List<decimal?>();

            List<string> ypdcyldw_codeList = new List<string>();

            List<string> ypyytj_codeList = new List<string>();

            List<string> ddw_codeList = new List<string>();

            List<string> xdw_codeList = new List<string>();

            List<string> cfybz_codeList = new List<string>();

            List<string> cfqxjy_codeList = new List<string>();

            List<string> cfqxyb_codeList = new List<string>();

            List<string> cfqxdm_codeList = new List<string>();

            List<string> cfqxjs_codeList = new List<string>();

            List<string> cfqxgz_codeList = new List<string>();

            List<string> cfqxjk_codeList = new List<string>();

            List<string> cfqxzz_codeList = new List<string>();

            List<string> cfqxzf_codeList = new List<string>();

            List<string> cfqxts_codeList = new List<string>();

            List<string> ps_codeList = new List<string>();

            List<string> yplx_codeList = new List<string>();

            List<string> ypmssyzList = new List<string>();

            List<string> ypmsjjzList = new List<string>();

            List<string> ypmsyfhbrqjy_codeList = new List<string>();

            List<string> ypmsblfyList = new List<string>();

            List<string> ypfl_codeList = new List<string>();

            List<string> yjjb_codeList = new List<string>();

            List<string> txmList = new List<string>();

            List<string> ewmList = new List<string>();

            List<string> pymList = new List<string>();

            List<decimal?> hsxsList = new List<decimal?>();

            List<string> sfcly_codeList = new List<string>();

            List<decimal?> bzpfjList = new List<decimal?>();

            List<decimal?> bzlsjList = new List<decimal?>();

            List<decimal?> bzmzjList = new List<decimal?>();

            List<decimal?> bzzyjList = new List<decimal?>();

            List<decimal?> hsblList = new List<decimal?>();

            List<string> sfclm_codeList = new List<string>();

            List<string> yxzt_codeList = new List<string>();

            List<decimal?> dcsxylList = new List<decimal?>();

            List<decimal?> dcxxylList = new List<decimal?>();

            List<decimal?> lxyltsList = new List<decimal?>();

            List<decimal?> lxylcsList = new List<decimal?>();

            List<string> scqyList = new List<string>();

            List<DateTime?> pzrqList = new List<DateTime?>();

            List<string> sfkss_codeList = new List<string>();

            List<string> zfbzList = new List<string>();

            List<decimal?> dcyldwblList = new List<decimal?>();

            for (int i = 0; i < jc_ypParamList.Count; i++)
            {
                Jc_yp jc_ypParam = jc_ypParamList[i];
                if ("" == jc_ypParam.Id || null == jc_ypParam.Id)
                {
                    jc_ypParam.Id = Model.Common.GUIDHelper.getGuid();
                }

                idList.Add(jc_ypParam.Id);

                ypbmList.Add(jc_ypParam.Ypbm);

                ypmcList.Add(jc_ypParam.Ypmc);

                yptymcList.Add(jc_ypParam.Yptymc);

                ypcfList.Add(jc_ypParam.Ypcf);

                yppzwhList.Add(jc_ypParam.Yppzwh);

                ypzczhList.Add(jc_ypParam.Ypzczh);

                gyzzList.Add(jc_ypParam.Gyzz);

                ypjx_codeList.Add(jc_ypParam.Ypjx_code);

                ypggList.Add(jc_ypParam.Ypgg);

                ypdcylList.Add(jc_ypParam.Ypdcyl);

                ypdcyldw_codeList.Add(jc_ypParam.Ypdcyldw_code);

                ypyytj_codeList.Add(jc_ypParam.Ypyytj_code);

                ddw_codeList.Add(jc_ypParam.Ddw_code);

                xdw_codeList.Add(jc_ypParam.Xdw_code);

                cfybz_codeList.Add(jc_ypParam.Cfybz_code);

                cfqxjy_codeList.Add(jc_ypParam.Cfqxjy_code);

                cfqxyb_codeList.Add(jc_ypParam.Cfqxyb_code);

                cfqxdm_codeList.Add(jc_ypParam.Cfqxdm_code);

                cfqxjs_codeList.Add(jc_ypParam.Cfqxjs_code);

                cfqxgz_codeList.Add(jc_ypParam.Cfqxgz_code);

                cfqxjk_codeList.Add(jc_ypParam.Cfqxjk_code);

                cfqxzz_codeList.Add(jc_ypParam.Cfqxzz_code);

                cfqxzf_codeList.Add(jc_ypParam.Cfqxzf_code);

                cfqxts_codeList.Add(jc_ypParam.Cfqxts_code);

                ps_codeList.Add(jc_ypParam.Ps_code);

                yplx_codeList.Add(jc_ypParam.Yplx_code);

                ypmssyzList.Add(jc_ypParam.Ypmssyz);

                ypmsjjzList.Add(jc_ypParam.Ypmsjjz);

                ypmsyfhbrqjy_codeList.Add(jc_ypParam.Ypmsyfhbrqjy_code);

                ypmsblfyList.Add(jc_ypParam.Ypmsblfy);

                ypfl_codeList.Add(jc_ypParam.Ypfl_code);

                yjjb_codeList.Add(jc_ypParam.Yjjb_code);

                txmList.Add(jc_ypParam.Txm);

                ewmList.Add(jc_ypParam.Ewm);

                pymList.Add(jc_ypParam.Pym);

                hsxsList.Add(jc_ypParam.Hsxs);

                sfcly_codeList.Add(jc_ypParam.Sfcly_code);

                bzpfjList.Add(jc_ypParam.Bzpfj);

                bzlsjList.Add(jc_ypParam.Bzlsj);

                bzmzjList.Add(jc_ypParam.Bzmzj);

                bzzyjList.Add(jc_ypParam.Bzzyj);

                hsblList.Add(jc_ypParam.Hsbl);

                sfclm_codeList.Add(jc_ypParam.Sfclm_code);

                yxzt_codeList.Add(jc_ypParam.Yxzt_code);

                dcsxylList.Add(jc_ypParam.Dcsxyl);

                dcxxylList.Add(jc_ypParam.Dcxxyl);

                lxyltsList.Add(jc_ypParam.Lxylts);

                lxylcsList.Add(jc_ypParam.Lxylcs);

                scqyList.Add(jc_ypParam.Scqy);

                pzrqList.Add(jc_ypParam.Pzrq);

                sfkss_codeList.Add(jc_ypParam.Sfkss_code);

                zfbzList.Add(jc_ypParam.Zfbz);

                dcyldwblList.Add(jc_ypParam.Dcyldwbl);

            }

            List<OracleParameter> sqlparams = new List<OracleParameter>();

            StringBuilder sql = new StringBuilder("INSERT INTO JC_YP(id,ypbm,ypmc,yptymc,ypcf,yppzwh,ypzczh,gyzz,ypjx_code,ypgg,ypdcyl,ypdcyldw_code,ypyytj_code,ddw_code,xdw_code,cfybz_code,cfqxjy_code,cfqxyb_code,cfqxdm_code,cfqxjs_code,cfqxgz_code,cfqxjk_code,cfqxzz_code,cfqxzf_code,cfqxts_code,ps_code,yplx_code,ypmssyz,ypmsjjz,ypmsyfhbrqjy_code,ypmsblfy,ypfl_code,yjjb_code,txm,ewm,pym,hsxs,sfcly_code,bzpfj,bzlsj,bzmzj,bzzyj,hsbl,sfclm_code,yxzt_code,dcsxyl,dcxxyl,lxylts,lxylcs,scqy,pzrq,sfkss_code,zfbz,dcyldwbl) VALUES(:id,:ypbm,:ypmc,:yptymc,:ypcf,:yppzwh,:ypzczh,:gyzz,:ypjx_code,:ypgg,:ypdcyl,:ypdcyldw_code,:ypyytj_code,:ddw_code,:xdw_code,:cfybz_code,:cfqxjy_code,:cfqxyb_code,:cfqxdm_code,:cfqxjs_code,:cfqxgz_code,:cfqxjk_code,:cfqxzz_code,:cfqxzf_code,:cfqxts_code,:ps_code,:yplx_code,:ypmssyz,:ypmsjjz,:ypmsyfhbrqjy_code,:ypmsblfy,:ypfl_code,:yjjb_code,:txm,:ewm,:pym,:hsxs,:sfcly_code,:bzpfj,:bzlsj,:bzmzj,:bzzyj,:hsbl,:sfclm_code,:yxzt_code,:dcsxyl,:dcxxyl,:lxylts,:lxylcs,:scqy,:pzrq,:sfkss_code,:zfbz,:dcyldwbl)");

            OracleParameter pId = new OracleParameter(":id", OracleDbType.Varchar2);
            pId.Direction = ParameterDirection.Input;
            pId.Value = idList.ToArray();
            sqlparams.Add(pId);
            OracleParameter pYpbm = new OracleParameter(":ypbm", OracleDbType.NVarchar2);
            pYpbm.Direction = ParameterDirection.Input;
            pYpbm.Value = ypbmList.ToArray();
            sqlparams.Add(pYpbm);
            OracleParameter pYpmc = new OracleParameter(":ypmc", OracleDbType.NVarchar2);
            pYpmc.Direction = ParameterDirection.Input;
            pYpmc.Value = ypmcList.ToArray();
            sqlparams.Add(pYpmc);
            OracleParameter pYptymc = new OracleParameter(":yptymc", OracleDbType.NVarchar2);
            pYptymc.Direction = ParameterDirection.Input;
            pYptymc.Value = yptymcList.ToArray();
            sqlparams.Add(pYptymc);
            OracleParameter pYpcf = new OracleParameter(":ypcf", OracleDbType.NVarchar2);
            pYpcf.Direction = ParameterDirection.Input;
            pYpcf.Value = ypcfList.ToArray();
            sqlparams.Add(pYpcf);
            OracleParameter pYppzwh = new OracleParameter(":yppzwh", OracleDbType.NVarchar2);
            pYppzwh.Direction = ParameterDirection.Input;
            pYppzwh.Value = yppzwhList.ToArray();
            sqlparams.Add(pYppzwh);
            OracleParameter pYpzczh = new OracleParameter(":ypzczh", OracleDbType.NVarchar2);
            pYpzczh.Direction = ParameterDirection.Input;
            pYpzczh.Value = ypzczhList.ToArray();
            sqlparams.Add(pYpzczh);
            OracleParameter pGyzz = new OracleParameter(":gyzz", OracleDbType.NVarchar2);
            pGyzz.Direction = ParameterDirection.Input;
            pGyzz.Value = gyzzList.ToArray();
            sqlparams.Add(pGyzz);
            OracleParameter pYpjx_code = new OracleParameter(":ypjx_code", OracleDbType.NVarchar2);
            pYpjx_code.Direction = ParameterDirection.Input;
            pYpjx_code.Value = ypjx_codeList.ToArray();
            sqlparams.Add(pYpjx_code);
            OracleParameter pYpgg = new OracleParameter(":ypgg", OracleDbType.NVarchar2);
            pYpgg.Direction = ParameterDirection.Input;
            pYpgg.Value = ypggList.ToArray();
            sqlparams.Add(pYpgg);
            OracleParameter pYpdcyl = new OracleParameter(":ypdcyl", OracleDbType.Decimal);
            pYpdcyl.Direction = ParameterDirection.Input;
            pYpdcyl.Value = ypdcylList.ToArray();
            sqlparams.Add(pYpdcyl);
            OracleParameter pYpdcyldw_code = new OracleParameter(":ypdcyldw_code", OracleDbType.NVarchar2);
            pYpdcyldw_code.Direction = ParameterDirection.Input;
            pYpdcyldw_code.Value = ypdcyldw_codeList.ToArray();
            sqlparams.Add(pYpdcyldw_code);
            OracleParameter pYpyytj_code = new OracleParameter(":ypyytj_code", OracleDbType.NVarchar2);
            pYpyytj_code.Direction = ParameterDirection.Input;
            pYpyytj_code.Value = ypyytj_codeList.ToArray();
            sqlparams.Add(pYpyytj_code);
            OracleParameter pDdw_code = new OracleParameter(":ddw_code", OracleDbType.NVarchar2);
            pDdw_code.Direction = ParameterDirection.Input;
            pDdw_code.Value = ddw_codeList.ToArray();
            sqlparams.Add(pDdw_code);
            OracleParameter pXdw_code = new OracleParameter(":xdw_code", OracleDbType.NVarchar2);
            pXdw_code.Direction = ParameterDirection.Input;
            pXdw_code.Value = xdw_codeList.ToArray();
            sqlparams.Add(pXdw_code);
            OracleParameter pCfybz_code = new OracleParameter(":cfybz_code", OracleDbType.NVarchar2);
            pCfybz_code.Direction = ParameterDirection.Input;
            pCfybz_code.Value = cfybz_codeList.ToArray();
            sqlparams.Add(pCfybz_code);
            OracleParameter pCfqxjy_code = new OracleParameter(":cfqxjy_code", OracleDbType.NVarchar2);
            pCfqxjy_code.Direction = ParameterDirection.Input;
            pCfqxjy_code.Value = cfqxjy_codeList.ToArray();
            sqlparams.Add(pCfqxjy_code);
            OracleParameter pCfqxyb_code = new OracleParameter(":cfqxyb_code", OracleDbType.NVarchar2);
            pCfqxyb_code.Direction = ParameterDirection.Input;
            pCfqxyb_code.Value = cfqxyb_codeList.ToArray();
            sqlparams.Add(pCfqxyb_code);
            OracleParameter pCfqxdm_code = new OracleParameter(":cfqxdm_code", OracleDbType.NVarchar2);
            pCfqxdm_code.Direction = ParameterDirection.Input;
            pCfqxdm_code.Value = cfqxdm_codeList.ToArray();
            sqlparams.Add(pCfqxdm_code);
            OracleParameter pCfqxjs_code = new OracleParameter(":cfqxjs_code", OracleDbType.NVarchar2);
            pCfqxjs_code.Direction = ParameterDirection.Input;
            pCfqxjs_code.Value = cfqxjs_codeList.ToArray();
            sqlparams.Add(pCfqxjs_code);
            OracleParameter pCfqxgz_code = new OracleParameter(":cfqxgz_code", OracleDbType.NVarchar2);
            pCfqxgz_code.Direction = ParameterDirection.Input;
            pCfqxgz_code.Value = cfqxgz_codeList.ToArray();
            sqlparams.Add(pCfqxgz_code);
            OracleParameter pCfqxjk_code = new OracleParameter(":cfqxjk_code", OracleDbType.NVarchar2);
            pCfqxjk_code.Direction = ParameterDirection.Input;
            pCfqxjk_code.Value = cfqxjk_codeList.ToArray();
            sqlparams.Add(pCfqxjk_code);
            OracleParameter pCfqxzz_code = new OracleParameter(":cfqxzz_code", OracleDbType.NVarchar2);
            pCfqxzz_code.Direction = ParameterDirection.Input;
            pCfqxzz_code.Value = cfqxzz_codeList.ToArray();
            sqlparams.Add(pCfqxzz_code);
            OracleParameter pCfqxzf_code = new OracleParameter(":cfqxzf_code", OracleDbType.NVarchar2);
            pCfqxzf_code.Direction = ParameterDirection.Input;
            pCfqxzf_code.Value = cfqxzf_codeList.ToArray();
            sqlparams.Add(pCfqxzf_code);
            OracleParameter pCfqxts_code = new OracleParameter(":cfqxts_code", OracleDbType.NVarchar2);
            pCfqxts_code.Direction = ParameterDirection.Input;
            pCfqxts_code.Value = cfqxts_codeList.ToArray();
            sqlparams.Add(pCfqxts_code);
            OracleParameter pPs_code = new OracleParameter(":ps_code", OracleDbType.NVarchar2);
            pPs_code.Direction = ParameterDirection.Input;
            pPs_code.Value = ps_codeList.ToArray();
            sqlparams.Add(pPs_code);
            OracleParameter pYplx_code = new OracleParameter(":yplx_code", OracleDbType.NVarchar2);
            pYplx_code.Direction = ParameterDirection.Input;
            pYplx_code.Value = yplx_codeList.ToArray();
            sqlparams.Add(pYplx_code);
            OracleParameter pYpmssyz = new OracleParameter(":ypmssyz", OracleDbType.NVarchar2);
            pYpmssyz.Direction = ParameterDirection.Input;
            pYpmssyz.Value = ypmssyzList.ToArray();
            sqlparams.Add(pYpmssyz);
            OracleParameter pYpmsjjz = new OracleParameter(":ypmsjjz", OracleDbType.NVarchar2);
            pYpmsjjz.Direction = ParameterDirection.Input;
            pYpmsjjz.Value = ypmsjjzList.ToArray();
            sqlparams.Add(pYpmsjjz);
            OracleParameter pYpmsyfhbrqjy_code = new OracleParameter(":ypmsyfhbrqjy_code", OracleDbType.NVarchar2);
            pYpmsyfhbrqjy_code.Direction = ParameterDirection.Input;
            pYpmsyfhbrqjy_code.Value = ypmsyfhbrqjy_codeList.ToArray();
            sqlparams.Add(pYpmsyfhbrqjy_code);
            OracleParameter pYpmsblfy = new OracleParameter(":ypmsblfy", OracleDbType.NVarchar2);
            pYpmsblfy.Direction = ParameterDirection.Input;
            pYpmsblfy.Value = ypmsblfyList.ToArray();
            sqlparams.Add(pYpmsblfy);
            OracleParameter pYpfl_code = new OracleParameter(":ypfl_code", OracleDbType.NVarchar2);
            pYpfl_code.Direction = ParameterDirection.Input;
            pYpfl_code.Value = ypfl_codeList.ToArray();
            sqlparams.Add(pYpfl_code);
            OracleParameter pYjjb_code = new OracleParameter(":yjjb_code", OracleDbType.NVarchar2);
            pYjjb_code.Direction = ParameterDirection.Input;
            pYjjb_code.Value = yjjb_codeList.ToArray();
            sqlparams.Add(pYjjb_code);
            OracleParameter pTxm = new OracleParameter(":txm", OracleDbType.NVarchar2);
            pTxm.Direction = ParameterDirection.Input;
            pTxm.Value = txmList.ToArray();
            sqlparams.Add(pTxm);
            OracleParameter pEwm = new OracleParameter(":ewm", OracleDbType.NVarchar2);
            pEwm.Direction = ParameterDirection.Input;
            pEwm.Value = ewmList.ToArray();
            sqlparams.Add(pEwm);
            OracleParameter pPym = new OracleParameter(":pym", OracleDbType.NVarchar2);
            pPym.Direction = ParameterDirection.Input;
            pPym.Value = pymList.ToArray();
            sqlparams.Add(pPym);
            OracleParameter pHsxs = new OracleParameter(":hsxs", OracleDbType.Decimal);
            pHsxs.Direction = ParameterDirection.Input;
            pHsxs.Value = hsxsList.ToArray();
            sqlparams.Add(pHsxs);
            OracleParameter pSfcly_code = new OracleParameter(":sfcly_code", OracleDbType.NVarchar2);
            pSfcly_code.Direction = ParameterDirection.Input;
            pSfcly_code.Value = sfcly_codeList.ToArray();
            sqlparams.Add(pSfcly_code);
            OracleParameter pBzpfj = new OracleParameter(":bzpfj", OracleDbType.Decimal);
            pBzpfj.Direction = ParameterDirection.Input;
            pBzpfj.Value = bzpfjList.ToArray();
            sqlparams.Add(pBzpfj);
            OracleParameter pBzlsj = new OracleParameter(":bzlsj", OracleDbType.Decimal);
            pBzlsj.Direction = ParameterDirection.Input;
            pBzlsj.Value = bzlsjList.ToArray();
            sqlparams.Add(pBzlsj);
            OracleParameter pBzmzj = new OracleParameter(":bzmzj", OracleDbType.Decimal);
            pBzmzj.Direction = ParameterDirection.Input;
            pBzmzj.Value = bzmzjList.ToArray();
            sqlparams.Add(pBzmzj);
            OracleParameter pBzzyj = new OracleParameter(":bzzyj", OracleDbType.Decimal);
            pBzzyj.Direction = ParameterDirection.Input;
            pBzzyj.Value = bzzyjList.ToArray();
            sqlparams.Add(pBzzyj);
            OracleParameter pHsbl = new OracleParameter(":hsbl", OracleDbType.Decimal);
            pHsbl.Direction = ParameterDirection.Input;
            pHsbl.Value = hsblList.ToArray();
            sqlparams.Add(pHsbl);
            OracleParameter pSfclm_code = new OracleParameter(":sfclm_code", OracleDbType.NVarchar2);
            pSfclm_code.Direction = ParameterDirection.Input;
            pSfclm_code.Value = sfclm_codeList.ToArray();
            sqlparams.Add(pSfclm_code);
            OracleParameter pYxzt_code = new OracleParameter(":yxzt_code", OracleDbType.NVarchar2);
            pYxzt_code.Direction = ParameterDirection.Input;
            pYxzt_code.Value = yxzt_codeList.ToArray();
            sqlparams.Add(pYxzt_code);
            OracleParameter pDcsxyl = new OracleParameter(":dcsxyl", OracleDbType.Decimal);
            pDcsxyl.Direction = ParameterDirection.Input;
            pDcsxyl.Value = dcsxylList.ToArray();
            sqlparams.Add(pDcsxyl);
            OracleParameter pDcxxyl = new OracleParameter(":dcxxyl", OracleDbType.Decimal);
            pDcxxyl.Direction = ParameterDirection.Input;
            pDcxxyl.Value = dcxxylList.ToArray();
            sqlparams.Add(pDcxxyl);
            OracleParameter pLxylts = new OracleParameter(":lxylts", OracleDbType.Decimal);
            pLxylts.Direction = ParameterDirection.Input;
            pLxylts.Value = lxyltsList.ToArray();
            sqlparams.Add(pLxylts);
            OracleParameter pLxylcs = new OracleParameter(":lxylcs", OracleDbType.Decimal);
            pLxylcs.Direction = ParameterDirection.Input;
            pLxylcs.Value = lxylcsList.ToArray();
            sqlparams.Add(pLxylcs);
            OracleParameter pScqy = new OracleParameter(":scqy", OracleDbType.NVarchar2);
            pScqy.Direction = ParameterDirection.Input;
            pScqy.Value = scqyList.ToArray();
            sqlparams.Add(pScqy);
            OracleParameter pPzrq = new OracleParameter(":pzrq", OracleDbType.Date);
            pPzrq.Direction = ParameterDirection.Input;
            pPzrq.Value = pzrqList.ToArray();
            sqlparams.Add(pPzrq);
            OracleParameter pSfkss_code = new OracleParameter(":sfkss_code", OracleDbType.NVarchar2);
            pSfkss_code.Direction = ParameterDirection.Input;
            pSfkss_code.Value = sfkss_codeList.ToArray();
            sqlparams.Add(pSfkss_code);
            OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
            pZfbz.Direction = ParameterDirection.Input;
            pZfbz.Value = zfbzList.ToArray();
            sqlparams.Add(pZfbz);
            OracleParameter pDcyldwbl = new OracleParameter(":dcyldwbl", OracleDbType.Decimal);
            pDcyldwbl.Direction = ParameterDirection.Input;
            pDcyldwbl.Value = dcyldwblList.ToArray();
            sqlparams.Add(pDcyldwbl);
            bool result = false;
            int flag = -1;
            flag = OracleHelper.ExecuteBatch(sql.ToString(), con, jc_ypParamList.Count, sqlparams.ToArray());
            if (jc_ypParamList.Count == flag)
            {
                result = true;
            }
            return result;
        }


        /// <summary>
        /// 删除指定ID的一条数据（如果需要供事务使用就传入OracleConnection对象，如果不供就传入null，方法自动生成OracleConnection对象）
        /// </summary>
        /// <param Name="id">要删除的数据的guid</param>
        /// <param Name="con">Oracle连接对象（为null时自动生成）</param>
        /// <returns>是否删除成功（影响的行数为1时成功）</returns>
        public bool deleteById(string id, OracleConnection con)
        {
            if ("" == id || null == id)
            {
                throw new Exception("ID不允许为空，请赋值后调用；错误出自：deleteById");
            }
            StringBuilder sql = new StringBuilder("DELETE JC_YP WHERE ID=:id");
            OracleParameter pId = new OracleParameter(":id", OracleDbType.Varchar2);
            pId.Value = id;
            bool result = false;
            int flag = OracleHelper.ExecuteNonQuery(sql.ToString(), con, pId);
            if (1 == flag)
            {
                result = true;
            }
            else if (0 == flag)
            {
                throw new Exception("删除了" + flag + "条数据，请检查ID是否在数据库中存在；错误出自：deleteById");
            }
            else if (flag > 1)
            {
                throw new Exception("删除了" + flag + "条数据，数据库中主键重复；错误出自：deleteById");
            }
            return result;
        }

        /// <summary>
        /// 删除指定id集合的多条数据（如果需要供事务使用就传入OracleConnection对象，如果不供就传入null，方法自动生成OracleConnection对象，并且自动使用事务）
        /// </summary>
        /// <param name="idlist">要删除的数据的guid的集合</param>
        /// <param name="con">Oracle连接对象（为null时自动生成）</param>
        /// <returns>是否删除成功（影响的行数等于要删除的id的数量时成功）</returns>
        public bool deleteByIdBatch(List<string> idList, OracleConnection con)
        {
            if (null == idList || 0 == idList.Count)
            {
                throw new Exception("ID的集合不允许为空或者数量为0，请赋值后调用；错误出自：deleteByIdBatch");
            }
            StringBuilder sql = new StringBuilder("DELETE JC_YP WHERE ID=:id");
            OracleParameter pId = new OracleParameter(":id", OracleDbType.Varchar2);
            pId.Value = idList.ToArray();
            bool result = false;
            int flag = OracleHelper.ExecuteBatch(sql.ToString(), con, idList.Count, pId);
            if (idList.Count == flag)
            {
                result = true;
            }
            return result;
        }

        /// <summary>
        /// 根据删除条件，删除多条数据（如果需要供事务使用就传入OracleConnection对象，如果不供就传入null，方法自动生成OracleConnection对象）
        /// 不指定ID，如果需要根据ID来删除数据，请调用deleteById或deleteByIdBatch方法
        /// </summary>
        /// <param name="jc_ypParamCondition">删除的条件</param>
        /// <param name="con">Oracle连接对象（为null时自动生成）</param>
        /// <returns>无法确定删除的行数（影响行数大于等于0就算成功）</returns>
        public bool deleteByOtherCondition(Jc_yp jc_ypParamCondition, OracleConnection con)
        {
            if (null != jc_ypParamCondition.Id && "" != jc_ypParamCondition.Id)
            {
                throw new Exception("不允许指定参数的ID，如果要根据ID删除数据请调用deleteById或者deleteByIdBatch方法；错误出自：deleteByOtherCondition");
            }
            List<OracleParameter> sqlparams = new List<OracleParameter>();
            StringBuilder sql = new StringBuilder("DELETE JC_YP ");

            if (null != jc_ypParamCondition.Ypbm && "" != jc_ypParamCondition.Ypbm)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" YPBM=:ypbm ");
                OracleParameter pYpbm = new OracleParameter(":ypbm", OracleDbType.NVarchar2);
                pYpbm.Direction = ParameterDirection.Input;
                pYpbm.Value = jc_ypParamCondition.Ypbm;
                sqlparams.Add(pYpbm);

            }

            if (null != jc_ypParamCondition.Ypmc && "" != jc_ypParamCondition.Ypmc)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" YPMC=:ypmc ");
                OracleParameter pYpmc = new OracleParameter(":ypmc", OracleDbType.NVarchar2);
                pYpmc.Direction = ParameterDirection.Input;
                pYpmc.Value = jc_ypParamCondition.Ypmc;
                sqlparams.Add(pYpmc);

            }

            if (null != jc_ypParamCondition.Yptymc && "" != jc_ypParamCondition.Yptymc)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" YPTYMC=:yptymc ");
                OracleParameter pYptymc = new OracleParameter(":yptymc", OracleDbType.NVarchar2);
                pYptymc.Direction = ParameterDirection.Input;
                pYptymc.Value = jc_ypParamCondition.Yptymc;
                sqlparams.Add(pYptymc);

            }

            if (null != jc_ypParamCondition.Ypcf && "" != jc_ypParamCondition.Ypcf)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" YPCF=:ypcf ");
                OracleParameter pYpcf = new OracleParameter(":ypcf", OracleDbType.NVarchar2);
                pYpcf.Direction = ParameterDirection.Input;
                pYpcf.Value = jc_ypParamCondition.Ypcf;
                sqlparams.Add(pYpcf);

            }

            if (null != jc_ypParamCondition.Yppzwh && "" != jc_ypParamCondition.Yppzwh)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" YPPZWH=:yppzwh ");
                OracleParameter pYppzwh = new OracleParameter(":yppzwh", OracleDbType.NVarchar2);
                pYppzwh.Direction = ParameterDirection.Input;
                pYppzwh.Value = jc_ypParamCondition.Yppzwh;
                sqlparams.Add(pYppzwh);

            }

            if (null != jc_ypParamCondition.Ypzczh && "" != jc_ypParamCondition.Ypzczh)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" YPZCZH=:ypzczh ");
                OracleParameter pYpzczh = new OracleParameter(":ypzczh", OracleDbType.NVarchar2);
                pYpzczh.Direction = ParameterDirection.Input;
                pYpzczh.Value = jc_ypParamCondition.Ypzczh;
                sqlparams.Add(pYpzczh);

            }

            if (null != jc_ypParamCondition.Gyzz && "" != jc_ypParamCondition.Gyzz)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" GYZZ=:gyzz ");
                OracleParameter pGyzz = new OracleParameter(":gyzz", OracleDbType.NVarchar2);
                pGyzz.Direction = ParameterDirection.Input;
                pGyzz.Value = jc_ypParamCondition.Gyzz;
                sqlparams.Add(pGyzz);

            }

            if (null != jc_ypParamCondition.Ypjx_code && "" != jc_ypParamCondition.Ypjx_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" YPJX_CODE=:ypjx_code ");
                OracleParameter pYpjx_code = new OracleParameter(":ypjx_code", OracleDbType.NVarchar2);
                pYpjx_code.Direction = ParameterDirection.Input;
                pYpjx_code.Value = jc_ypParamCondition.Ypjx_code;
                sqlparams.Add(pYpjx_code);

            }

            if (null != jc_ypParamCondition.Ypgg && "" != jc_ypParamCondition.Ypgg)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" YPGG=:ypgg ");
                OracleParameter pYpgg = new OracleParameter(":ypgg", OracleDbType.NVarchar2);
                pYpgg.Direction = ParameterDirection.Input;
                pYpgg.Value = jc_ypParamCondition.Ypgg;
                sqlparams.Add(pYpgg);

            }

            if (null != jc_ypParamCondition.Ypdcyl)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" YPDCYL=:ypdcyl ");
                OracleParameter pYpdcyl = new OracleParameter(":ypdcyl", OracleDbType.Decimal);
                pYpdcyl.Direction = ParameterDirection.Input;
                pYpdcyl.Value = jc_ypParamCondition.Ypdcyl;
                sqlparams.Add(pYpdcyl);

            }

            if (null != jc_ypParamCondition.Ypdcyldw_code && "" != jc_ypParamCondition.Ypdcyldw_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" YPDCYLDW_CODE=:ypdcyldw_code ");
                OracleParameter pYpdcyldw_code = new OracleParameter(":ypdcyldw_code", OracleDbType.NVarchar2);
                pYpdcyldw_code.Direction = ParameterDirection.Input;
                pYpdcyldw_code.Value = jc_ypParamCondition.Ypdcyldw_code;
                sqlparams.Add(pYpdcyldw_code);

            }

            if (null != jc_ypParamCondition.Ypyytj_code && "" != jc_ypParamCondition.Ypyytj_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" YPYYTJ_CODE=:ypyytj_code ");
                OracleParameter pYpyytj_code = new OracleParameter(":ypyytj_code", OracleDbType.NVarchar2);
                pYpyytj_code.Direction = ParameterDirection.Input;
                pYpyytj_code.Value = jc_ypParamCondition.Ypyytj_code;
                sqlparams.Add(pYpyytj_code);

            }

            if (null != jc_ypParamCondition.Ddw_code && "" != jc_ypParamCondition.Ddw_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" DDW_CODE=:ddw_code ");
                OracleParameter pDdw_code = new OracleParameter(":ddw_code", OracleDbType.NVarchar2);
                pDdw_code.Direction = ParameterDirection.Input;
                pDdw_code.Value = jc_ypParamCondition.Ddw_code;
                sqlparams.Add(pDdw_code);

            }

            if (null != jc_ypParamCondition.Xdw_code && "" != jc_ypParamCondition.Xdw_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" XDW_CODE=:xdw_code ");
                OracleParameter pXdw_code = new OracleParameter(":xdw_code", OracleDbType.NVarchar2);
                pXdw_code.Direction = ParameterDirection.Input;
                pXdw_code.Value = jc_ypParamCondition.Xdw_code;
                sqlparams.Add(pXdw_code);

            }

            if (null != jc_ypParamCondition.Cfybz_code && "" != jc_ypParamCondition.Cfybz_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" CFYBZ_CODE=:cfybz_code ");
                OracleParameter pCfybz_code = new OracleParameter(":cfybz_code", OracleDbType.NVarchar2);
                pCfybz_code.Direction = ParameterDirection.Input;
                pCfybz_code.Value = jc_ypParamCondition.Cfybz_code;
                sqlparams.Add(pCfybz_code);

            }

            if (null != jc_ypParamCondition.Cfqxjy_code && "" != jc_ypParamCondition.Cfqxjy_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" CFQXJY_CODE=:cfqxjy_code ");
                OracleParameter pCfqxjy_code = new OracleParameter(":cfqxjy_code", OracleDbType.NVarchar2);
                pCfqxjy_code.Direction = ParameterDirection.Input;
                pCfqxjy_code.Value = jc_ypParamCondition.Cfqxjy_code;
                sqlparams.Add(pCfqxjy_code);

            }

            if (null != jc_ypParamCondition.Cfqxyb_code && "" != jc_ypParamCondition.Cfqxyb_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" CFQXYB_CODE=:cfqxyb_code ");
                OracleParameter pCfqxyb_code = new OracleParameter(":cfqxyb_code", OracleDbType.NVarchar2);
                pCfqxyb_code.Direction = ParameterDirection.Input;
                pCfqxyb_code.Value = jc_ypParamCondition.Cfqxyb_code;
                sqlparams.Add(pCfqxyb_code);

            }

            if (null != jc_ypParamCondition.Cfqxdm_code && "" != jc_ypParamCondition.Cfqxdm_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" CFQXDM_CODE=:cfqxdm_code ");
                OracleParameter pCfqxdm_code = new OracleParameter(":cfqxdm_code", OracleDbType.NVarchar2);
                pCfqxdm_code.Direction = ParameterDirection.Input;
                pCfqxdm_code.Value = jc_ypParamCondition.Cfqxdm_code;
                sqlparams.Add(pCfqxdm_code);

            }

            if (null != jc_ypParamCondition.Cfqxjs_code && "" != jc_ypParamCondition.Cfqxjs_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" CFQXJS_CODE=:cfqxjs_code ");
                OracleParameter pCfqxjs_code = new OracleParameter(":cfqxjs_code", OracleDbType.NVarchar2);
                pCfqxjs_code.Direction = ParameterDirection.Input;
                pCfqxjs_code.Value = jc_ypParamCondition.Cfqxjs_code;
                sqlparams.Add(pCfqxjs_code);

            }

            if (null != jc_ypParamCondition.Cfqxgz_code && "" != jc_ypParamCondition.Cfqxgz_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" CFQXGZ_CODE=:cfqxgz_code ");
                OracleParameter pCfqxgz_code = new OracleParameter(":cfqxgz_code", OracleDbType.NVarchar2);
                pCfqxgz_code.Direction = ParameterDirection.Input;
                pCfqxgz_code.Value = jc_ypParamCondition.Cfqxgz_code;
                sqlparams.Add(pCfqxgz_code);

            }

            if (null != jc_ypParamCondition.Cfqxjk_code && "" != jc_ypParamCondition.Cfqxjk_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" CFQXJK_CODE=:cfqxjk_code ");
                OracleParameter pCfqxjk_code = new OracleParameter(":cfqxjk_code", OracleDbType.NVarchar2);
                pCfqxjk_code.Direction = ParameterDirection.Input;
                pCfqxjk_code.Value = jc_ypParamCondition.Cfqxjk_code;
                sqlparams.Add(pCfqxjk_code);

            }

            if (null != jc_ypParamCondition.Cfqxzz_code && "" != jc_ypParamCondition.Cfqxzz_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" CFQXZZ_CODE=:cfqxzz_code ");
                OracleParameter pCfqxzz_code = new OracleParameter(":cfqxzz_code", OracleDbType.NVarchar2);
                pCfqxzz_code.Direction = ParameterDirection.Input;
                pCfqxzz_code.Value = jc_ypParamCondition.Cfqxzz_code;
                sqlparams.Add(pCfqxzz_code);

            }

            if (null != jc_ypParamCondition.Cfqxzf_code && "" != jc_ypParamCondition.Cfqxzf_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" CFQXZF_CODE=:cfqxzf_code ");
                OracleParameter pCfqxzf_code = new OracleParameter(":cfqxzf_code", OracleDbType.NVarchar2);
                pCfqxzf_code.Direction = ParameterDirection.Input;
                pCfqxzf_code.Value = jc_ypParamCondition.Cfqxzf_code;
                sqlparams.Add(pCfqxzf_code);

            }

            if (null != jc_ypParamCondition.Cfqxts_code && "" != jc_ypParamCondition.Cfqxts_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" CFQXTS_CODE=:cfqxts_code ");
                OracleParameter pCfqxts_code = new OracleParameter(":cfqxts_code", OracleDbType.NVarchar2);
                pCfqxts_code.Direction = ParameterDirection.Input;
                pCfqxts_code.Value = jc_ypParamCondition.Cfqxts_code;
                sqlparams.Add(pCfqxts_code);

            }

            if (null != jc_ypParamCondition.Ps_code && "" != jc_ypParamCondition.Ps_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" PS_CODE=:ps_code ");
                OracleParameter pPs_code = new OracleParameter(":ps_code", OracleDbType.NVarchar2);
                pPs_code.Direction = ParameterDirection.Input;
                pPs_code.Value = jc_ypParamCondition.Ps_code;
                sqlparams.Add(pPs_code);

            }

            if (null != jc_ypParamCondition.Yplx_code && "" != jc_ypParamCondition.Yplx_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" YPLX_CODE=:yplx_code ");
                OracleParameter pYplx_code = new OracleParameter(":yplx_code", OracleDbType.NVarchar2);
                pYplx_code.Direction = ParameterDirection.Input;
                pYplx_code.Value = jc_ypParamCondition.Yplx_code;
                sqlparams.Add(pYplx_code);

            }

            if (null != jc_ypParamCondition.Ypmssyz && "" != jc_ypParamCondition.Ypmssyz)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" YPMSSYZ=:ypmssyz ");
                OracleParameter pYpmssyz = new OracleParameter(":ypmssyz", OracleDbType.NVarchar2);
                pYpmssyz.Direction = ParameterDirection.Input;
                pYpmssyz.Value = jc_ypParamCondition.Ypmssyz;
                sqlparams.Add(pYpmssyz);

            }

            if (null != jc_ypParamCondition.Ypmsjjz && "" != jc_ypParamCondition.Ypmsjjz)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" YPMSJJZ=:ypmsjjz ");
                OracleParameter pYpmsjjz = new OracleParameter(":ypmsjjz", OracleDbType.NVarchar2);
                pYpmsjjz.Direction = ParameterDirection.Input;
                pYpmsjjz.Value = jc_ypParamCondition.Ypmsjjz;
                sqlparams.Add(pYpmsjjz);

            }

            if (null != jc_ypParamCondition.Ypmsyfhbrqjy_code && "" != jc_ypParamCondition.Ypmsyfhbrqjy_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" YPMSYFHBRQJY_CODE=:ypmsyfhbrqjy_code ");
                OracleParameter pYpmsyfhbrqjy_code = new OracleParameter(":ypmsyfhbrqjy_code", OracleDbType.NVarchar2);
                pYpmsyfhbrqjy_code.Direction = ParameterDirection.Input;
                pYpmsyfhbrqjy_code.Value = jc_ypParamCondition.Ypmsyfhbrqjy_code;
                sqlparams.Add(pYpmsyfhbrqjy_code);

            }

            if (null != jc_ypParamCondition.Ypmsblfy && "" != jc_ypParamCondition.Ypmsblfy)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" YPMSBLFY=:ypmsblfy ");
                OracleParameter pYpmsblfy = new OracleParameter(":ypmsblfy", OracleDbType.NVarchar2);
                pYpmsblfy.Direction = ParameterDirection.Input;
                pYpmsblfy.Value = jc_ypParamCondition.Ypmsblfy;
                sqlparams.Add(pYpmsblfy);

            }

            if (null != jc_ypParamCondition.Ypfl_code && "" != jc_ypParamCondition.Ypfl_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" YPFL_CODE=:ypfl_code ");
                OracleParameter pYpfl_code = new OracleParameter(":ypfl_code", OracleDbType.NVarchar2);
                pYpfl_code.Direction = ParameterDirection.Input;
                pYpfl_code.Value = jc_ypParamCondition.Ypfl_code;
                sqlparams.Add(pYpfl_code);

            }

            if (null != jc_ypParamCondition.Yjjb_code && "" != jc_ypParamCondition.Yjjb_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" YJJB_CODE=:yjjb_code ");
                OracleParameter pYjjb_code = new OracleParameter(":yjjb_code", OracleDbType.NVarchar2);
                pYjjb_code.Direction = ParameterDirection.Input;
                pYjjb_code.Value = jc_ypParamCondition.Yjjb_code;
                sqlparams.Add(pYjjb_code);

            }

            if (null != jc_ypParamCondition.Txm && "" != jc_ypParamCondition.Txm)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" TXM=:txm ");
                OracleParameter pTxm = new OracleParameter(":txm", OracleDbType.NVarchar2);
                pTxm.Direction = ParameterDirection.Input;
                pTxm.Value = jc_ypParamCondition.Txm;
                sqlparams.Add(pTxm);

            }

            if (null != jc_ypParamCondition.Ewm && "" != jc_ypParamCondition.Ewm)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" EWM=:ewm ");
                OracleParameter pEwm = new OracleParameter(":ewm", OracleDbType.NVarchar2);
                pEwm.Direction = ParameterDirection.Input;
                pEwm.Value = jc_ypParamCondition.Ewm;
                sqlparams.Add(pEwm);

            }

            if (null != jc_ypParamCondition.Pym && "" != jc_ypParamCondition.Pym)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" PYM=:pym ");
                OracleParameter pPym = new OracleParameter(":pym", OracleDbType.NVarchar2);
                pPym.Direction = ParameterDirection.Input;
                pPym.Value = jc_ypParamCondition.Pym;
                sqlparams.Add(pPym);

            }

            if (null != jc_ypParamCondition.Hsxs)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" HSXS=:hsxs ");
                OracleParameter pHsxs = new OracleParameter(":hsxs", OracleDbType.Decimal);
                pHsxs.Direction = ParameterDirection.Input;
                pHsxs.Value = jc_ypParamCondition.Hsxs;
                sqlparams.Add(pHsxs);

            }

            if (null != jc_ypParamCondition.Sfcly_code && "" != jc_ypParamCondition.Sfcly_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" SFCLY_CODE=:sfcly_code ");
                OracleParameter pSfcly_code = new OracleParameter(":sfcly_code", OracleDbType.NVarchar2);
                pSfcly_code.Direction = ParameterDirection.Input;
                pSfcly_code.Value = jc_ypParamCondition.Sfcly_code;
                sqlparams.Add(pSfcly_code);

            }

            if (null != jc_ypParamCondition.Bzpfj)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" BZPFJ=:bzpfj ");
                OracleParameter pBzpfj = new OracleParameter(":bzpfj", OracleDbType.Decimal);
                pBzpfj.Direction = ParameterDirection.Input;
                pBzpfj.Value = jc_ypParamCondition.Bzpfj;
                sqlparams.Add(pBzpfj);

            }

            if (null != jc_ypParamCondition.Bzlsj)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" BZLSJ=:bzlsj ");
                OracleParameter pBzlsj = new OracleParameter(":bzlsj", OracleDbType.Decimal);
                pBzlsj.Direction = ParameterDirection.Input;
                pBzlsj.Value = jc_ypParamCondition.Bzlsj;
                sqlparams.Add(pBzlsj);

            }

            if (null != jc_ypParamCondition.Bzmzj)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" BZMZJ=:bzmzj ");
                OracleParameter pBzmzj = new OracleParameter(":bzmzj", OracleDbType.Decimal);
                pBzmzj.Direction = ParameterDirection.Input;
                pBzmzj.Value = jc_ypParamCondition.Bzmzj;
                sqlparams.Add(pBzmzj);

            }

            if (null != jc_ypParamCondition.Bzzyj)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" BZZYJ=:bzzyj ");
                OracleParameter pBzzyj = new OracleParameter(":bzzyj", OracleDbType.Decimal);
                pBzzyj.Direction = ParameterDirection.Input;
                pBzzyj.Value = jc_ypParamCondition.Bzzyj;
                sqlparams.Add(pBzzyj);

            }

            if (null != jc_ypParamCondition.Hsbl)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" HSBL=:hsbl ");
                OracleParameter pHsbl = new OracleParameter(":hsbl", OracleDbType.Decimal);
                pHsbl.Direction = ParameterDirection.Input;
                pHsbl.Value = jc_ypParamCondition.Hsbl;
                sqlparams.Add(pHsbl);

            }

            if (null != jc_ypParamCondition.Sfclm_code && "" != jc_ypParamCondition.Sfclm_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" SFCLM_CODE=:sfclm_code ");
                OracleParameter pSfclm_code = new OracleParameter(":sfclm_code", OracleDbType.NVarchar2);
                pSfclm_code.Direction = ParameterDirection.Input;
                pSfclm_code.Value = jc_ypParamCondition.Sfclm_code;
                sqlparams.Add(pSfclm_code);

            }

            if (null != jc_ypParamCondition.Yxzt_code && "" != jc_ypParamCondition.Yxzt_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" YXZT_CODE=:yxzt_code ");
                OracleParameter pYxzt_code = new OracleParameter(":yxzt_code", OracleDbType.NVarchar2);
                pYxzt_code.Direction = ParameterDirection.Input;
                pYxzt_code.Value = jc_ypParamCondition.Yxzt_code;
                sqlparams.Add(pYxzt_code);

            }

            if (null != jc_ypParamCondition.Dcsxyl)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" DCSXYL=:dcsxyl ");
                OracleParameter pDcsxyl = new OracleParameter(":dcsxyl", OracleDbType.Decimal);
                pDcsxyl.Direction = ParameterDirection.Input;
                pDcsxyl.Value = jc_ypParamCondition.Dcsxyl;
                sqlparams.Add(pDcsxyl);

            }

            if (null != jc_ypParamCondition.Dcxxyl)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" DCXXYL=:dcxxyl ");
                OracleParameter pDcxxyl = new OracleParameter(":dcxxyl", OracleDbType.Decimal);
                pDcxxyl.Direction = ParameterDirection.Input;
                pDcxxyl.Value = jc_ypParamCondition.Dcxxyl;
                sqlparams.Add(pDcxxyl);

            }

            if (null != jc_ypParamCondition.Lxylts)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" LXYLTS=:lxylts ");
                OracleParameter pLxylts = new OracleParameter(":lxylts", OracleDbType.Decimal);
                pLxylts.Direction = ParameterDirection.Input;
                pLxylts.Value = jc_ypParamCondition.Lxylts;
                sqlparams.Add(pLxylts);

            }

            if (null != jc_ypParamCondition.Lxylcs)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" LXYLCS=:lxylcs ");
                OracleParameter pLxylcs = new OracleParameter(":lxylcs", OracleDbType.Decimal);
                pLxylcs.Direction = ParameterDirection.Input;
                pLxylcs.Value = jc_ypParamCondition.Lxylcs;
                sqlparams.Add(pLxylcs);

            }

            if (null != jc_ypParamCondition.Scqy && "" != jc_ypParamCondition.Scqy)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" SCQY=:scqy ");
                OracleParameter pScqy = new OracleParameter(":scqy", OracleDbType.NVarchar2);
                pScqy.Direction = ParameterDirection.Input;
                pScqy.Value = jc_ypParamCondition.Scqy;
                sqlparams.Add(pScqy);

            }

            if (DateTime.MinValue != jc_ypParamCondition.Pzrq && null != jc_ypParamCondition.Pzrq)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" PZRQ=:pzrq ");
                OracleParameter pPzrq = new OracleParameter(":pzrq", OracleDbType.Date);
                pPzrq.Direction = ParameterDirection.Input;
                pPzrq.Value = jc_ypParamCondition.Pzrq;
                sqlparams.Add(pPzrq);

            }

            if (null != jc_ypParamCondition.Sfkss_code && "" != jc_ypParamCondition.Sfkss_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" SFKSS_CODE=:sfkss_code ");
                OracleParameter pSfkss_code = new OracleParameter(":sfkss_code", OracleDbType.NVarchar2);
                pSfkss_code.Direction = ParameterDirection.Input;
                pSfkss_code.Value = jc_ypParamCondition.Sfkss_code;
                sqlparams.Add(pSfkss_code);

            }

            if (null != jc_ypParamCondition.Zfbz && "" != jc_ypParamCondition.Zfbz)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" ZFBZ=:zfbz ");
                OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                pZfbz.Direction = ParameterDirection.Input;
                pZfbz.Value = jc_ypParamCondition.Zfbz;
                sqlparams.Add(pZfbz);

            }

            if (null != jc_ypParamCondition.Dcyldwbl)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" DCYLDWBL=:dcyldwbl ");
                OracleParameter pDcyldwbl = new OracleParameter(":dcyldwbl", OracleDbType.Decimal);
                pDcyldwbl.Direction = ParameterDirection.Input;
                pDcyldwbl.Value = jc_ypParamCondition.Dcyldwbl;
                sqlparams.Add(pDcyldwbl);

            }

            this.b_isWhere = false;
            bool result = false;
            int flag = OracleHelper.ExecuteNonQuery(sql.ToString(), con, sqlparams.ToArray());
            if (flag >= 0)
            {
                result = true;
            }
            return result;
        }

        /// <summary>
        /// 修改指定ID的一条数据（自动生成OracleConnection对象，直接修改）
        /// 一般不直接调用此方法，请调用save方法进行插入和修改
        /// </summary>
        /// <remarks>ID为空抛出异常</remarks>
        /// <param name="jc_ypParam"></param>
        /// <returns>影响的行数</returns>
        public bool updateById(Jc_yp jc_ypParam, OracleConnection con)
        {
            if ("" == jc_ypParam.Id || null == jc_ypParam.Id)
            {
                throw new Exception("ID不允许为空，请赋值后调用；错误出自：updateById");
            }
            List<OracleParameter> sqlparams = new List<OracleParameter>();

            StringBuilder sql = new StringBuilder("UPDATE JC_YP SET ");
            if (null != jc_ypParam.Ypbm && "" != jc_ypParam.Ypbm)
            {
                this.isComma(sql);
                sql.Append(" YPBM=:ypbm ");
                OracleParameter pYpbm = new OracleParameter(":ypbm", OracleDbType.NVarchar2);
                pYpbm.Direction = ParameterDirection.Input;
                pYpbm.Value = jc_ypParam.Ypbm;
                sqlparams.Add(pYpbm);

            }

            if (null != jc_ypParam.Ypmc && "" != jc_ypParam.Ypmc)
            {
                this.isComma(sql);
                sql.Append(" YPMC=:ypmc ");
                OracleParameter pYpmc = new OracleParameter(":ypmc", OracleDbType.NVarchar2);
                pYpmc.Direction = ParameterDirection.Input;
                pYpmc.Value = jc_ypParam.Ypmc;
                sqlparams.Add(pYpmc);

            }

            if (null != jc_ypParam.Yptymc && "" != jc_ypParam.Yptymc)
            {
                this.isComma(sql);
                sql.Append(" YPTYMC=:yptymc ");
                OracleParameter pYptymc = new OracleParameter(":yptymc", OracleDbType.NVarchar2);
                pYptymc.Direction = ParameterDirection.Input;
                pYptymc.Value = jc_ypParam.Yptymc;
                sqlparams.Add(pYptymc);

            }

            if (null != jc_ypParam.Ypcf && "" != jc_ypParam.Ypcf)
            {
                this.isComma(sql);
                sql.Append(" YPCF=:ypcf ");
                OracleParameter pYpcf = new OracleParameter(":ypcf", OracleDbType.NVarchar2);
                pYpcf.Direction = ParameterDirection.Input;
                pYpcf.Value = jc_ypParam.Ypcf;
                sqlparams.Add(pYpcf);

            }

            if (null != jc_ypParam.Yppzwh && "" != jc_ypParam.Yppzwh)
            {
                this.isComma(sql);
                sql.Append(" YPPZWH=:yppzwh ");
                OracleParameter pYppzwh = new OracleParameter(":yppzwh", OracleDbType.NVarchar2);
                pYppzwh.Direction = ParameterDirection.Input;
                pYppzwh.Value = jc_ypParam.Yppzwh;
                sqlparams.Add(pYppzwh);

            }

            if (null != jc_ypParam.Ypzczh && "" != jc_ypParam.Ypzczh)
            {
                this.isComma(sql);
                sql.Append(" YPZCZH=:ypzczh ");
                OracleParameter pYpzczh = new OracleParameter(":ypzczh", OracleDbType.NVarchar2);
                pYpzczh.Direction = ParameterDirection.Input;
                pYpzczh.Value = jc_ypParam.Ypzczh;
                sqlparams.Add(pYpzczh);

            }

            if (null != jc_ypParam.Gyzz && "" != jc_ypParam.Gyzz)
            {
                this.isComma(sql);
                sql.Append(" GYZZ=:gyzz ");
                OracleParameter pGyzz = new OracleParameter(":gyzz", OracleDbType.NVarchar2);
                pGyzz.Direction = ParameterDirection.Input;
                pGyzz.Value = jc_ypParam.Gyzz;
                sqlparams.Add(pGyzz);

            }

            if (null != jc_ypParam.Ypjx_code && "" != jc_ypParam.Ypjx_code)
            {
                this.isComma(sql);
                sql.Append(" YPJX_CODE=:ypjx_code ");
                OracleParameter pYpjx_code = new OracleParameter(":ypjx_code", OracleDbType.NVarchar2);
                pYpjx_code.Direction = ParameterDirection.Input;
                pYpjx_code.Value = jc_ypParam.Ypjx_code;
                sqlparams.Add(pYpjx_code);

            }

            if (null != jc_ypParam.Ypgg && "" != jc_ypParam.Ypgg)
            {
                this.isComma(sql);
                sql.Append(" YPGG=:ypgg ");
                OracleParameter pYpgg = new OracleParameter(":ypgg", OracleDbType.NVarchar2);
                pYpgg.Direction = ParameterDirection.Input;
                pYpgg.Value = jc_ypParam.Ypgg;
                sqlparams.Add(pYpgg);

            }

            if (null != jc_ypParam.Ypdcyl)
            {
                this.isComma(sql);
                sql.Append(" YPDCYL=:ypdcyl ");
                OracleParameter pYpdcyl = new OracleParameter(":ypdcyl", OracleDbType.Decimal);
                pYpdcyl.Direction = ParameterDirection.Input;
                pYpdcyl.Value = jc_ypParam.Ypdcyl;
                sqlparams.Add(pYpdcyl);

            }

            if (null != jc_ypParam.Ypdcyldw_code && "" != jc_ypParam.Ypdcyldw_code)
            {
                this.isComma(sql);
                sql.Append(" YPDCYLDW_CODE=:ypdcyldw_code ");
                OracleParameter pYpdcyldw_code = new OracleParameter(":ypdcyldw_code", OracleDbType.NVarchar2);
                pYpdcyldw_code.Direction = ParameterDirection.Input;
                pYpdcyldw_code.Value = jc_ypParam.Ypdcyldw_code;
                sqlparams.Add(pYpdcyldw_code);

            }

            if (null != jc_ypParam.Ypyytj_code && "" != jc_ypParam.Ypyytj_code)
            {
                this.isComma(sql);
                sql.Append(" YPYYTJ_CODE=:ypyytj_code ");
                OracleParameter pYpyytj_code = new OracleParameter(":ypyytj_code", OracleDbType.NVarchar2);
                pYpyytj_code.Direction = ParameterDirection.Input;
                pYpyytj_code.Value = jc_ypParam.Ypyytj_code;
                sqlparams.Add(pYpyytj_code);

            }

            if (null != jc_ypParam.Ddw_code && "" != jc_ypParam.Ddw_code)
            {
                this.isComma(sql);
                sql.Append(" DDW_CODE=:ddw_code ");
                OracleParameter pDdw_code = new OracleParameter(":ddw_code", OracleDbType.NVarchar2);
                pDdw_code.Direction = ParameterDirection.Input;
                pDdw_code.Value = jc_ypParam.Ddw_code;
                sqlparams.Add(pDdw_code);

            }

            if (null != jc_ypParam.Xdw_code && "" != jc_ypParam.Xdw_code)
            {
                this.isComma(sql);
                sql.Append(" XDW_CODE=:xdw_code ");
                OracleParameter pXdw_code = new OracleParameter(":xdw_code", OracleDbType.NVarchar2);
                pXdw_code.Direction = ParameterDirection.Input;
                pXdw_code.Value = jc_ypParam.Xdw_code;
                sqlparams.Add(pXdw_code);

            }

            if (null != jc_ypParam.Cfybz_code && "" != jc_ypParam.Cfybz_code)
            {
                this.isComma(sql);
                sql.Append(" CFYBZ_CODE=:cfybz_code ");
                OracleParameter pCfybz_code = new OracleParameter(":cfybz_code", OracleDbType.NVarchar2);
                pCfybz_code.Direction = ParameterDirection.Input;
                pCfybz_code.Value = jc_ypParam.Cfybz_code;
                sqlparams.Add(pCfybz_code);

            }

            if (null != jc_ypParam.Cfqxjy_code && "" != jc_ypParam.Cfqxjy_code)
            {
                this.isComma(sql);
                sql.Append(" CFQXJY_CODE=:cfqxjy_code ");
                OracleParameter pCfqxjy_code = new OracleParameter(":cfqxjy_code", OracleDbType.NVarchar2);
                pCfqxjy_code.Direction = ParameterDirection.Input;
                pCfqxjy_code.Value = jc_ypParam.Cfqxjy_code;
                sqlparams.Add(pCfqxjy_code);

            }

            if (null != jc_ypParam.Cfqxyb_code && "" != jc_ypParam.Cfqxyb_code)
            {
                this.isComma(sql);
                sql.Append(" CFQXYB_CODE=:cfqxyb_code ");
                OracleParameter pCfqxyb_code = new OracleParameter(":cfqxyb_code", OracleDbType.NVarchar2);
                pCfqxyb_code.Direction = ParameterDirection.Input;
                pCfqxyb_code.Value = jc_ypParam.Cfqxyb_code;
                sqlparams.Add(pCfqxyb_code);

            }

            if (null != jc_ypParam.Cfqxdm_code && "" != jc_ypParam.Cfqxdm_code)
            {
                this.isComma(sql);
                sql.Append(" CFQXDM_CODE=:cfqxdm_code ");
                OracleParameter pCfqxdm_code = new OracleParameter(":cfqxdm_code", OracleDbType.NVarchar2);
                pCfqxdm_code.Direction = ParameterDirection.Input;
                pCfqxdm_code.Value = jc_ypParam.Cfqxdm_code;
                sqlparams.Add(pCfqxdm_code);

            }

            if (null != jc_ypParam.Cfqxjs_code && "" != jc_ypParam.Cfqxjs_code)
            {
                this.isComma(sql);
                sql.Append(" CFQXJS_CODE=:cfqxjs_code ");
                OracleParameter pCfqxjs_code = new OracleParameter(":cfqxjs_code", OracleDbType.NVarchar2);
                pCfqxjs_code.Direction = ParameterDirection.Input;
                pCfqxjs_code.Value = jc_ypParam.Cfqxjs_code;
                sqlparams.Add(pCfqxjs_code);

            }

            if (null != jc_ypParam.Cfqxgz_code && "" != jc_ypParam.Cfqxgz_code)
            {
                this.isComma(sql);
                sql.Append(" CFQXGZ_CODE=:cfqxgz_code ");
                OracleParameter pCfqxgz_code = new OracleParameter(":cfqxgz_code", OracleDbType.NVarchar2);
                pCfqxgz_code.Direction = ParameterDirection.Input;
                pCfqxgz_code.Value = jc_ypParam.Cfqxgz_code;
                sqlparams.Add(pCfqxgz_code);

            }

            if (null != jc_ypParam.Cfqxjk_code && "" != jc_ypParam.Cfqxjk_code)
            {
                this.isComma(sql);
                sql.Append(" CFQXJK_CODE=:cfqxjk_code ");
                OracleParameter pCfqxjk_code = new OracleParameter(":cfqxjk_code", OracleDbType.NVarchar2);
                pCfqxjk_code.Direction = ParameterDirection.Input;
                pCfqxjk_code.Value = jc_ypParam.Cfqxjk_code;
                sqlparams.Add(pCfqxjk_code);

            }

            if (null != jc_ypParam.Cfqxzz_code && "" != jc_ypParam.Cfqxzz_code)
            {
                this.isComma(sql);
                sql.Append(" CFQXZZ_CODE=:cfqxzz_code ");
                OracleParameter pCfqxzz_code = new OracleParameter(":cfqxzz_code", OracleDbType.NVarchar2);
                pCfqxzz_code.Direction = ParameterDirection.Input;
                pCfqxzz_code.Value = jc_ypParam.Cfqxzz_code;
                sqlparams.Add(pCfqxzz_code);

            }

            if (null != jc_ypParam.Cfqxzf_code && "" != jc_ypParam.Cfqxzf_code)
            {
                this.isComma(sql);
                sql.Append(" CFQXZF_CODE=:cfqxzf_code ");
                OracleParameter pCfqxzf_code = new OracleParameter(":cfqxzf_code", OracleDbType.NVarchar2);
                pCfqxzf_code.Direction = ParameterDirection.Input;
                pCfqxzf_code.Value = jc_ypParam.Cfqxzf_code;
                sqlparams.Add(pCfqxzf_code);

            }

            if (null != jc_ypParam.Cfqxts_code && "" != jc_ypParam.Cfqxts_code)
            {
                this.isComma(sql);
                sql.Append(" CFQXTS_CODE=:cfqxts_code ");
                OracleParameter pCfqxts_code = new OracleParameter(":cfqxts_code", OracleDbType.NVarchar2);
                pCfqxts_code.Direction = ParameterDirection.Input;
                pCfqxts_code.Value = jc_ypParam.Cfqxts_code;
                sqlparams.Add(pCfqxts_code);

            }

            if (null != jc_ypParam.Ps_code && "" != jc_ypParam.Ps_code)
            {
                this.isComma(sql);
                sql.Append(" PS_CODE=:ps_code ");
                OracleParameter pPs_code = new OracleParameter(":ps_code", OracleDbType.NVarchar2);
                pPs_code.Direction = ParameterDirection.Input;
                pPs_code.Value = jc_ypParam.Ps_code;
                sqlparams.Add(pPs_code);

            }

            if (null != jc_ypParam.Yplx_code && "" != jc_ypParam.Yplx_code)
            {
                this.isComma(sql);
                sql.Append(" YPLX_CODE=:yplx_code ");
                OracleParameter pYplx_code = new OracleParameter(":yplx_code", OracleDbType.NVarchar2);
                pYplx_code.Direction = ParameterDirection.Input;
                pYplx_code.Value = jc_ypParam.Yplx_code;
                sqlparams.Add(pYplx_code);

            }

            if (null != jc_ypParam.Ypmssyz && "" != jc_ypParam.Ypmssyz)
            {
                this.isComma(sql);
                sql.Append(" YPMSSYZ=:ypmssyz ");
                OracleParameter pYpmssyz = new OracleParameter(":ypmssyz", OracleDbType.NVarchar2);
                pYpmssyz.Direction = ParameterDirection.Input;
                pYpmssyz.Value = jc_ypParam.Ypmssyz;
                sqlparams.Add(pYpmssyz);

            }

            if (null != jc_ypParam.Ypmsjjz && "" != jc_ypParam.Ypmsjjz)
            {
                this.isComma(sql);
                sql.Append(" YPMSJJZ=:ypmsjjz ");
                OracleParameter pYpmsjjz = new OracleParameter(":ypmsjjz", OracleDbType.NVarchar2);
                pYpmsjjz.Direction = ParameterDirection.Input;
                pYpmsjjz.Value = jc_ypParam.Ypmsjjz;
                sqlparams.Add(pYpmsjjz);

            }

            if (null != jc_ypParam.Ypmsyfhbrqjy_code && "" != jc_ypParam.Ypmsyfhbrqjy_code)
            {
                this.isComma(sql);
                sql.Append(" YPMSYFHBRQJY_CODE=:ypmsyfhbrqjy_code ");
                OracleParameter pYpmsyfhbrqjy_code = new OracleParameter(":ypmsyfhbrqjy_code", OracleDbType.NVarchar2);
                pYpmsyfhbrqjy_code.Direction = ParameterDirection.Input;
                pYpmsyfhbrqjy_code.Value = jc_ypParam.Ypmsyfhbrqjy_code;
                sqlparams.Add(pYpmsyfhbrqjy_code);

            }

            if (null != jc_ypParam.Ypmsblfy && "" != jc_ypParam.Ypmsblfy)
            {
                this.isComma(sql);
                sql.Append(" YPMSBLFY=:ypmsblfy ");
                OracleParameter pYpmsblfy = new OracleParameter(":ypmsblfy", OracleDbType.NVarchar2);
                pYpmsblfy.Direction = ParameterDirection.Input;
                pYpmsblfy.Value = jc_ypParam.Ypmsblfy;
                sqlparams.Add(pYpmsblfy);

            }

            if (null != jc_ypParam.Ypfl_code && "" != jc_ypParam.Ypfl_code)
            {
                this.isComma(sql);
                sql.Append(" YPFL_CODE=:ypfl_code ");
                OracleParameter pYpfl_code = new OracleParameter(":ypfl_code", OracleDbType.NVarchar2);
                pYpfl_code.Direction = ParameterDirection.Input;
                pYpfl_code.Value = jc_ypParam.Ypfl_code;
                sqlparams.Add(pYpfl_code);

            }

            if (null != jc_ypParam.Yjjb_code && "" != jc_ypParam.Yjjb_code)
            {
                this.isComma(sql);
                sql.Append(" YJJB_CODE=:yjjb_code ");
                OracleParameter pYjjb_code = new OracleParameter(":yjjb_code", OracleDbType.NVarchar2);
                pYjjb_code.Direction = ParameterDirection.Input;
                pYjjb_code.Value = jc_ypParam.Yjjb_code;
                sqlparams.Add(pYjjb_code);

            }

            if (null != jc_ypParam.Txm && "" != jc_ypParam.Txm)
            {
                this.isComma(sql);
                sql.Append(" TXM=:txm ");
                OracleParameter pTxm = new OracleParameter(":txm", OracleDbType.NVarchar2);
                pTxm.Direction = ParameterDirection.Input;
                pTxm.Value = jc_ypParam.Txm;
                sqlparams.Add(pTxm);

            }

            if (null != jc_ypParam.Ewm && "" != jc_ypParam.Ewm)
            {
                this.isComma(sql);
                sql.Append(" EWM=:ewm ");
                OracleParameter pEwm = new OracleParameter(":ewm", OracleDbType.NVarchar2);
                pEwm.Direction = ParameterDirection.Input;
                pEwm.Value = jc_ypParam.Ewm;
                sqlparams.Add(pEwm);

            }

            if (null != jc_ypParam.Pym && "" != jc_ypParam.Pym)
            {
                this.isComma(sql);
                sql.Append(" PYM=:pym ");
                OracleParameter pPym = new OracleParameter(":pym", OracleDbType.NVarchar2);
                pPym.Direction = ParameterDirection.Input;
                pPym.Value = jc_ypParam.Pym;
                sqlparams.Add(pPym);

            }

            if (null != jc_ypParam.Hsxs)
            {
                this.isComma(sql);
                sql.Append(" HSXS=:hsxs ");
                OracleParameter pHsxs = new OracleParameter(":hsxs", OracleDbType.Decimal);
                pHsxs.Direction = ParameterDirection.Input;
                pHsxs.Value = jc_ypParam.Hsxs;
                sqlparams.Add(pHsxs);

            }

            if (null != jc_ypParam.Sfcly_code && "" != jc_ypParam.Sfcly_code)
            {
                this.isComma(sql);
                sql.Append(" SFCLY_CODE=:sfcly_code ");
                OracleParameter pSfcly_code = new OracleParameter(":sfcly_code", OracleDbType.NVarchar2);
                pSfcly_code.Direction = ParameterDirection.Input;
                pSfcly_code.Value = jc_ypParam.Sfcly_code;
                sqlparams.Add(pSfcly_code);

            }

            if (null != jc_ypParam.Bzpfj)
            {
                this.isComma(sql);
                sql.Append(" BZPFJ=:bzpfj ");
                OracleParameter pBzpfj = new OracleParameter(":bzpfj", OracleDbType.Decimal);
                pBzpfj.Direction = ParameterDirection.Input;
                pBzpfj.Value = jc_ypParam.Bzpfj;
                sqlparams.Add(pBzpfj);

            }

            if (null != jc_ypParam.Bzlsj)
            {
                this.isComma(sql);
                sql.Append(" BZLSJ=:bzlsj ");
                OracleParameter pBzlsj = new OracleParameter(":bzlsj", OracleDbType.Decimal);
                pBzlsj.Direction = ParameterDirection.Input;
                pBzlsj.Value = jc_ypParam.Bzlsj;
                sqlparams.Add(pBzlsj);

            }

            if (null != jc_ypParam.Bzmzj)
            {
                this.isComma(sql);
                sql.Append(" BZMZJ=:bzmzj ");
                OracleParameter pBzmzj = new OracleParameter(":bzmzj", OracleDbType.Decimal);
                pBzmzj.Direction = ParameterDirection.Input;
                pBzmzj.Value = jc_ypParam.Bzmzj;
                sqlparams.Add(pBzmzj);

            }

            if (null != jc_ypParam.Bzzyj)
            {
                this.isComma(sql);
                sql.Append(" BZZYJ=:bzzyj ");
                OracleParameter pBzzyj = new OracleParameter(":bzzyj", OracleDbType.Decimal);
                pBzzyj.Direction = ParameterDirection.Input;
                pBzzyj.Value = jc_ypParam.Bzzyj;
                sqlparams.Add(pBzzyj);

            }

            if (null != jc_ypParam.Hsbl)
            {
                this.isComma(sql);
                sql.Append(" HSBL=:hsbl ");
                OracleParameter pHsbl = new OracleParameter(":hsbl", OracleDbType.Decimal);
                pHsbl.Direction = ParameterDirection.Input;
                pHsbl.Value = jc_ypParam.Hsbl;
                sqlparams.Add(pHsbl);

            }

            if (null != jc_ypParam.Sfclm_code && "" != jc_ypParam.Sfclm_code)
            {
                this.isComma(sql);
                sql.Append(" SFCLM_CODE=:sfclm_code ");
                OracleParameter pSfclm_code = new OracleParameter(":sfclm_code", OracleDbType.NVarchar2);
                pSfclm_code.Direction = ParameterDirection.Input;
                pSfclm_code.Value = jc_ypParam.Sfclm_code;
                sqlparams.Add(pSfclm_code);

            }

            if (null != jc_ypParam.Yxzt_code && "" != jc_ypParam.Yxzt_code)
            {
                this.isComma(sql);
                sql.Append(" YXZT_CODE=:yxzt_code ");
                OracleParameter pYxzt_code = new OracleParameter(":yxzt_code", OracleDbType.NVarchar2);
                pYxzt_code.Direction = ParameterDirection.Input;
                pYxzt_code.Value = jc_ypParam.Yxzt_code;
                sqlparams.Add(pYxzt_code);

            }

            if (null != jc_ypParam.Dcsxyl)
            {
                this.isComma(sql);
                sql.Append(" DCSXYL=:dcsxyl ");
                OracleParameter pDcsxyl = new OracleParameter(":dcsxyl", OracleDbType.Decimal);
                pDcsxyl.Direction = ParameterDirection.Input;
                pDcsxyl.Value = jc_ypParam.Dcsxyl;
                sqlparams.Add(pDcsxyl);

            }

            if (null != jc_ypParam.Dcxxyl)
            {
                this.isComma(sql);
                sql.Append(" DCXXYL=:dcxxyl ");
                OracleParameter pDcxxyl = new OracleParameter(":dcxxyl", OracleDbType.Decimal);
                pDcxxyl.Direction = ParameterDirection.Input;
                pDcxxyl.Value = jc_ypParam.Dcxxyl;
                sqlparams.Add(pDcxxyl);

            }

            if (null != jc_ypParam.Lxylts)
            {
                this.isComma(sql);
                sql.Append(" LXYLTS=:lxylts ");
                OracleParameter pLxylts = new OracleParameter(":lxylts", OracleDbType.Decimal);
                pLxylts.Direction = ParameterDirection.Input;
                pLxylts.Value = jc_ypParam.Lxylts;
                sqlparams.Add(pLxylts);

            }

            if (null != jc_ypParam.Lxylcs)
            {
                this.isComma(sql);
                sql.Append(" LXYLCS=:lxylcs ");
                OracleParameter pLxylcs = new OracleParameter(":lxylcs", OracleDbType.Decimal);
                pLxylcs.Direction = ParameterDirection.Input;
                pLxylcs.Value = jc_ypParam.Lxylcs;
                sqlparams.Add(pLxylcs);

            }

            if (null != jc_ypParam.Scqy && "" != jc_ypParam.Scqy)
            {
                this.isComma(sql);
                sql.Append(" SCQY=:scqy ");
                OracleParameter pScqy = new OracleParameter(":scqy", OracleDbType.NVarchar2);
                pScqy.Direction = ParameterDirection.Input;
                pScqy.Value = jc_ypParam.Scqy;
                sqlparams.Add(pScqy);

            }

            if (DateTime.MinValue != jc_ypParam.Pzrq && null != jc_ypParam.Pzrq)
            {
                this.isComma(sql);
                sql.Append(" PZRQ=:pzrq ");
                OracleParameter pPzrq = new OracleParameter(":pzrq", OracleDbType.Date);
                pPzrq.Direction = ParameterDirection.Input;
                pPzrq.Value = jc_ypParam.Pzrq;
                sqlparams.Add(pPzrq);

            }

            if (null != jc_ypParam.Sfkss_code && "" != jc_ypParam.Sfkss_code)
            {
                this.isComma(sql);
                sql.Append(" SFKSS_CODE=:sfkss_code ");
                OracleParameter pSfkss_code = new OracleParameter(":sfkss_code", OracleDbType.NVarchar2);
                pSfkss_code.Direction = ParameterDirection.Input;
                pSfkss_code.Value = jc_ypParam.Sfkss_code;
                sqlparams.Add(pSfkss_code);

            }

            if (null != jc_ypParam.Zfbz && "" != jc_ypParam.Zfbz)
            {
                this.isComma(sql);
                sql.Append(" ZFBZ=:zfbz ");
                OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                pZfbz.Direction = ParameterDirection.Input;
                pZfbz.Value = jc_ypParam.Zfbz;
                sqlparams.Add(pZfbz);

            }

            if (null != jc_ypParam.Dcyldwbl)
            {
                this.isComma(sql);
                sql.Append(" DCYLDWBL=:dcyldwbl ");
                OracleParameter pDcyldwbl = new OracleParameter(":dcyldwbl", OracleDbType.Decimal);
                pDcyldwbl.Direction = ParameterDirection.Input;
                pDcyldwbl.Value = jc_ypParam.Dcyldwbl;
                sqlparams.Add(pDcyldwbl);

            }

            sql.Append(" WHERE ID=:id ");
            OracleParameter pId = new OracleParameter(":id", OracleDbType.Varchar2);
            pId.Value = jc_ypParam.Id;
            sqlparams.Add(pId);
            this.b_isComma = false;
            bool result = false;
            int flag = OracleHelper.ExecuteNonQuery(sql.ToString(), con, sqlparams.ToArray());
            if (1 == flag)
            {
                result = true;
            }
            else if (0 == flag)
            {
                throw new Exception("更新" + flag + "条数据，请检查ID是否在数据库中存在；错误出自：updateById");
            }
            else if (flag > 1)
            {
                throw new Exception("更新了" + flag + "条数据，数据库中主键重复；错误出自：updateById");
            }

            return result;
        }

        /// <summary>
        /// 根据List中的ID修改多条数据（如果需要供事务使用就传入OracleConnection对象，如果不供就传入null，方法自动生成OracleConnection对象，并且自动使用事务）
        /// </summary>
        /// <param name="jc_ypParamList">要修改的Jc_yp对象集合</param>
        /// <param name="con">Oracle连接对象（为null时自动生成）</param>
        /// <returns>是否删除成功（影响的行数等于要修改的对象数量时成功）</returns>
        public bool updateByIdBatch(List<Jc_yp> jc_ypParamList, OracleConnection con)
        {


            List<string> idList = new List<string>();

            List<string> ypbmList = new List<string>();

            List<string> ypmcList = new List<string>();

            List<string> yptymcList = new List<string>();

            List<string> ypcfList = new List<string>();

            List<string> yppzwhList = new List<string>();

            List<string> ypzczhList = new List<string>();

            List<string> gyzzList = new List<string>();

            List<string> ypjx_codeList = new List<string>();

            List<string> ypggList = new List<string>();

            List<decimal?> ypdcylList = new List<decimal?>();

            List<string> ypdcyldw_codeList = new List<string>();

            List<string> ypyytj_codeList = new List<string>();

            List<string> ddw_codeList = new List<string>();

            List<string> xdw_codeList = new List<string>();

            List<string> cfybz_codeList = new List<string>();

            List<string> cfqxjy_codeList = new List<string>();

            List<string> cfqxyb_codeList = new List<string>();

            List<string> cfqxdm_codeList = new List<string>();

            List<string> cfqxjs_codeList = new List<string>();

            List<string> cfqxgz_codeList = new List<string>();

            List<string> cfqxjk_codeList = new List<string>();

            List<string> cfqxzz_codeList = new List<string>();

            List<string> cfqxzf_codeList = new List<string>();

            List<string> cfqxts_codeList = new List<string>();

            List<string> ps_codeList = new List<string>();

            List<string> yplx_codeList = new List<string>();

            List<string> ypmssyzList = new List<string>();

            List<string> ypmsjjzList = new List<string>();

            List<string> ypmsyfhbrqjy_codeList = new List<string>();

            List<string> ypmsblfyList = new List<string>();

            List<string> ypfl_codeList = new List<string>();

            List<string> yjjb_codeList = new List<string>();

            List<string> txmList = new List<string>();

            List<string> ewmList = new List<string>();

            List<string> pymList = new List<string>();

            List<decimal?> hsxsList = new List<decimal?>();

            List<string> sfcly_codeList = new List<string>();

            List<decimal?> bzpfjList = new List<decimal?>();

            List<decimal?> bzlsjList = new List<decimal?>();

            List<decimal?> bzmzjList = new List<decimal?>();

            List<decimal?> bzzyjList = new List<decimal?>();

            List<decimal?> hsblList = new List<decimal?>();

            List<string> sfclm_codeList = new List<string>();

            List<string> yxzt_codeList = new List<string>();

            List<decimal?> dcsxylList = new List<decimal?>();

            List<decimal?> dcxxylList = new List<decimal?>();

            List<decimal?> lxyltsList = new List<decimal?>();

            List<decimal?> lxylcsList = new List<decimal?>();

            List<string> scqyList = new List<string>();

            List<DateTime?> pzrqList = new List<DateTime?>();

            List<string> sfkss_codeList = new List<string>();

            List<string> zfbzList = new List<string>();

            List<decimal?> dcyldwblList = new List<decimal?>();

            for (int i = 0; i < jc_ypParamList.Count; i++)
            {
                Jc_yp jc_ypParam = jc_ypParamList[i];
                if ("" == jc_ypParam.Id || null == jc_ypParam.Id)
                {
                    throw new Exception("下标为" + i + "的数据，ID不能为空，请赋值后调用；错误出自：updateByIdBatch");
                }

                idList.Add(jc_ypParam.Id);

                ypbmList.Add(jc_ypParam.Ypbm);

                ypmcList.Add(jc_ypParam.Ypmc);

                yptymcList.Add(jc_ypParam.Yptymc);

                ypcfList.Add(jc_ypParam.Ypcf);

                yppzwhList.Add(jc_ypParam.Yppzwh);

                ypzczhList.Add(jc_ypParam.Ypzczh);

                gyzzList.Add(jc_ypParam.Gyzz);

                ypjx_codeList.Add(jc_ypParam.Ypjx_code);

                ypggList.Add(jc_ypParam.Ypgg);

                ypdcylList.Add(jc_ypParam.Ypdcyl);

                ypdcyldw_codeList.Add(jc_ypParam.Ypdcyldw_code);

                ypyytj_codeList.Add(jc_ypParam.Ypyytj_code);

                ddw_codeList.Add(jc_ypParam.Ddw_code);

                xdw_codeList.Add(jc_ypParam.Xdw_code);

                cfybz_codeList.Add(jc_ypParam.Cfybz_code);

                cfqxjy_codeList.Add(jc_ypParam.Cfqxjy_code);

                cfqxyb_codeList.Add(jc_ypParam.Cfqxyb_code);

                cfqxdm_codeList.Add(jc_ypParam.Cfqxdm_code);

                cfqxjs_codeList.Add(jc_ypParam.Cfqxjs_code);

                cfqxgz_codeList.Add(jc_ypParam.Cfqxgz_code);

                cfqxjk_codeList.Add(jc_ypParam.Cfqxjk_code);

                cfqxzz_codeList.Add(jc_ypParam.Cfqxzz_code);

                cfqxzf_codeList.Add(jc_ypParam.Cfqxzf_code);

                cfqxts_codeList.Add(jc_ypParam.Cfqxts_code);

                ps_codeList.Add(jc_ypParam.Ps_code);

                yplx_codeList.Add(jc_ypParam.Yplx_code);

                ypmssyzList.Add(jc_ypParam.Ypmssyz);

                ypmsjjzList.Add(jc_ypParam.Ypmsjjz);

                ypmsyfhbrqjy_codeList.Add(jc_ypParam.Ypmsyfhbrqjy_code);

                ypmsblfyList.Add(jc_ypParam.Ypmsblfy);

                ypfl_codeList.Add(jc_ypParam.Ypfl_code);

                yjjb_codeList.Add(jc_ypParam.Yjjb_code);

                txmList.Add(jc_ypParam.Txm);

                ewmList.Add(jc_ypParam.Ewm);

                pymList.Add(jc_ypParam.Pym);

                hsxsList.Add(jc_ypParam.Hsxs);

                sfcly_codeList.Add(jc_ypParam.Sfcly_code);

                bzpfjList.Add(jc_ypParam.Bzpfj);

                bzlsjList.Add(jc_ypParam.Bzlsj);

                bzmzjList.Add(jc_ypParam.Bzmzj);

                bzzyjList.Add(jc_ypParam.Bzzyj);

                hsblList.Add(jc_ypParam.Hsbl);

                sfclm_codeList.Add(jc_ypParam.Sfclm_code);

                yxzt_codeList.Add(jc_ypParam.Yxzt_code);

                dcsxylList.Add(jc_ypParam.Dcsxyl);

                dcxxylList.Add(jc_ypParam.Dcxxyl);

                lxyltsList.Add(jc_ypParam.Lxylts);

                lxylcsList.Add(jc_ypParam.Lxylcs);

                scqyList.Add(jc_ypParam.Scqy);

                pzrqList.Add(jc_ypParam.Pzrq);

                sfkss_codeList.Add(jc_ypParam.Sfkss_code);

                zfbzList.Add(jc_ypParam.Zfbz);

                dcyldwblList.Add(jc_ypParam.Dcyldwbl);

            }



            List<OracleParameter> sqlparams = new List<OracleParameter>();

            StringBuilder sql = new StringBuilder("UPDATE JC_YP SET ");
            this.isComma(sql);
            sql.Append(" YPBM=:ypbm ");
            OracleParameter pYpbm = new OracleParameter(":ypbm", OracleDbType.NVarchar2);
            pYpbm.Direction = ParameterDirection.Input;
            pYpbm.Value = ypbmList.ToArray();
            sqlparams.Add(pYpbm);

            this.isComma(sql);
            sql.Append(" YPMC=:ypmc ");
            OracleParameter pYpmc = new OracleParameter(":ypmc", OracleDbType.NVarchar2);
            pYpmc.Direction = ParameterDirection.Input;
            pYpmc.Value = ypmcList.ToArray();
            sqlparams.Add(pYpmc);

            this.isComma(sql);
            sql.Append(" YPTYMC=:yptymc ");
            OracleParameter pYptymc = new OracleParameter(":yptymc", OracleDbType.NVarchar2);
            pYptymc.Direction = ParameterDirection.Input;
            pYptymc.Value = yptymcList.ToArray();
            sqlparams.Add(pYptymc);

            this.isComma(sql);
            sql.Append(" YPCF=:ypcf ");
            OracleParameter pYpcf = new OracleParameter(":ypcf", OracleDbType.NVarchar2);
            pYpcf.Direction = ParameterDirection.Input;
            pYpcf.Value = ypcfList.ToArray();
            sqlparams.Add(pYpcf);

            this.isComma(sql);
            sql.Append(" YPPZWH=:yppzwh ");
            OracleParameter pYppzwh = new OracleParameter(":yppzwh", OracleDbType.NVarchar2);
            pYppzwh.Direction = ParameterDirection.Input;
            pYppzwh.Value = yppzwhList.ToArray();
            sqlparams.Add(pYppzwh);

            this.isComma(sql);
            sql.Append(" YPZCZH=:ypzczh ");
            OracleParameter pYpzczh = new OracleParameter(":ypzczh", OracleDbType.NVarchar2);
            pYpzczh.Direction = ParameterDirection.Input;
            pYpzczh.Value = ypzczhList.ToArray();
            sqlparams.Add(pYpzczh);

            this.isComma(sql);
            sql.Append(" GYZZ=:gyzz ");
            OracleParameter pGyzz = new OracleParameter(":gyzz", OracleDbType.NVarchar2);
            pGyzz.Direction = ParameterDirection.Input;
            pGyzz.Value = gyzzList.ToArray();
            sqlparams.Add(pGyzz);

            this.isComma(sql);
            sql.Append(" YPJX_CODE=:ypjx_code ");
            OracleParameter pYpjx_code = new OracleParameter(":ypjx_code", OracleDbType.NVarchar2);
            pYpjx_code.Direction = ParameterDirection.Input;
            pYpjx_code.Value = ypjx_codeList.ToArray();
            sqlparams.Add(pYpjx_code);

            this.isComma(sql);
            sql.Append(" YPGG=:ypgg ");
            OracleParameter pYpgg = new OracleParameter(":ypgg", OracleDbType.NVarchar2);
            pYpgg.Direction = ParameterDirection.Input;
            pYpgg.Value = ypggList.ToArray();
            sqlparams.Add(pYpgg);

            this.isComma(sql);
            sql.Append(" YPDCYL=:ypdcyl ");
            OracleParameter pYpdcyl = new OracleParameter(":ypdcyl", OracleDbType.Decimal);
            pYpdcyl.Direction = ParameterDirection.Input;
            pYpdcyl.Value = ypdcylList.ToArray();
            sqlparams.Add(pYpdcyl);

            this.isComma(sql);
            sql.Append(" YPDCYLDW_CODE=:ypdcyldw_code ");
            OracleParameter pYpdcyldw_code = new OracleParameter(":ypdcyldw_code", OracleDbType.NVarchar2);
            pYpdcyldw_code.Direction = ParameterDirection.Input;
            pYpdcyldw_code.Value = ypdcyldw_codeList.ToArray();
            sqlparams.Add(pYpdcyldw_code);

            this.isComma(sql);
            sql.Append(" YPYYTJ_CODE=:ypyytj_code ");
            OracleParameter pYpyytj_code = new OracleParameter(":ypyytj_code", OracleDbType.NVarchar2);
            pYpyytj_code.Direction = ParameterDirection.Input;
            pYpyytj_code.Value = ypyytj_codeList.ToArray();
            sqlparams.Add(pYpyytj_code);

            this.isComma(sql);
            sql.Append(" DDW_CODE=:ddw_code ");
            OracleParameter pDdw_code = new OracleParameter(":ddw_code", OracleDbType.NVarchar2);
            pDdw_code.Direction = ParameterDirection.Input;
            pDdw_code.Value = ddw_codeList.ToArray();
            sqlparams.Add(pDdw_code);

            this.isComma(sql);
            sql.Append(" XDW_CODE=:xdw_code ");
            OracleParameter pXdw_code = new OracleParameter(":xdw_code", OracleDbType.NVarchar2);
            pXdw_code.Direction = ParameterDirection.Input;
            pXdw_code.Value = xdw_codeList.ToArray();
            sqlparams.Add(pXdw_code);

            this.isComma(sql);
            sql.Append(" CFYBZ_CODE=:cfybz_code ");
            OracleParameter pCfybz_code = new OracleParameter(":cfybz_code", OracleDbType.NVarchar2);
            pCfybz_code.Direction = ParameterDirection.Input;
            pCfybz_code.Value = cfybz_codeList.ToArray();
            sqlparams.Add(pCfybz_code);

            this.isComma(sql);
            sql.Append(" CFQXJY_CODE=:cfqxjy_code ");
            OracleParameter pCfqxjy_code = new OracleParameter(":cfqxjy_code", OracleDbType.NVarchar2);
            pCfqxjy_code.Direction = ParameterDirection.Input;
            pCfqxjy_code.Value = cfqxjy_codeList.ToArray();
            sqlparams.Add(pCfqxjy_code);

            this.isComma(sql);
            sql.Append(" CFQXYB_CODE=:cfqxyb_code ");
            OracleParameter pCfqxyb_code = new OracleParameter(":cfqxyb_code", OracleDbType.NVarchar2);
            pCfqxyb_code.Direction = ParameterDirection.Input;
            pCfqxyb_code.Value = cfqxyb_codeList.ToArray();
            sqlparams.Add(pCfqxyb_code);

            this.isComma(sql);
            sql.Append(" CFQXDM_CODE=:cfqxdm_code ");
            OracleParameter pCfqxdm_code = new OracleParameter(":cfqxdm_code", OracleDbType.NVarchar2);
            pCfqxdm_code.Direction = ParameterDirection.Input;
            pCfqxdm_code.Value = cfqxdm_codeList.ToArray();
            sqlparams.Add(pCfqxdm_code);

            this.isComma(sql);
            sql.Append(" CFQXJS_CODE=:cfqxjs_code ");
            OracleParameter pCfqxjs_code = new OracleParameter(":cfqxjs_code", OracleDbType.NVarchar2);
            pCfqxjs_code.Direction = ParameterDirection.Input;
            pCfqxjs_code.Value = cfqxjs_codeList.ToArray();
            sqlparams.Add(pCfqxjs_code);

            this.isComma(sql);
            sql.Append(" CFQXGZ_CODE=:cfqxgz_code ");
            OracleParameter pCfqxgz_code = new OracleParameter(":cfqxgz_code", OracleDbType.NVarchar2);
            pCfqxgz_code.Direction = ParameterDirection.Input;
            pCfqxgz_code.Value = cfqxgz_codeList.ToArray();
            sqlparams.Add(pCfqxgz_code);

            this.isComma(sql);
            sql.Append(" CFQXJK_CODE=:cfqxjk_code ");
            OracleParameter pCfqxjk_code = new OracleParameter(":cfqxjk_code", OracleDbType.NVarchar2);
            pCfqxjk_code.Direction = ParameterDirection.Input;
            pCfqxjk_code.Value = cfqxjk_codeList.ToArray();
            sqlparams.Add(pCfqxjk_code);

            this.isComma(sql);
            sql.Append(" CFQXZZ_CODE=:cfqxzz_code ");
            OracleParameter pCfqxzz_code = new OracleParameter(":cfqxzz_code", OracleDbType.NVarchar2);
            pCfqxzz_code.Direction = ParameterDirection.Input;
            pCfqxzz_code.Value = cfqxzz_codeList.ToArray();
            sqlparams.Add(pCfqxzz_code);

            this.isComma(sql);
            sql.Append(" CFQXZF_CODE=:cfqxzf_code ");
            OracleParameter pCfqxzf_code = new OracleParameter(":cfqxzf_code", OracleDbType.NVarchar2);
            pCfqxzf_code.Direction = ParameterDirection.Input;
            pCfqxzf_code.Value = cfqxzf_codeList.ToArray();
            sqlparams.Add(pCfqxzf_code);

            this.isComma(sql);
            sql.Append(" CFQXTS_CODE=:cfqxts_code ");
            OracleParameter pCfqxts_code = new OracleParameter(":cfqxts_code", OracleDbType.NVarchar2);
            pCfqxts_code.Direction = ParameterDirection.Input;
            pCfqxts_code.Value = cfqxts_codeList.ToArray();
            sqlparams.Add(pCfqxts_code);

            this.isComma(sql);
            sql.Append(" PS_CODE=:ps_code ");
            OracleParameter pPs_code = new OracleParameter(":ps_code", OracleDbType.NVarchar2);
            pPs_code.Direction = ParameterDirection.Input;
            pPs_code.Value = ps_codeList.ToArray();
            sqlparams.Add(pPs_code);

            this.isComma(sql);
            sql.Append(" YPLX_CODE=:yplx_code ");
            OracleParameter pYplx_code = new OracleParameter(":yplx_code", OracleDbType.NVarchar2);
            pYplx_code.Direction = ParameterDirection.Input;
            pYplx_code.Value = yplx_codeList.ToArray();
            sqlparams.Add(pYplx_code);

            this.isComma(sql);
            sql.Append(" YPMSSYZ=:ypmssyz ");
            OracleParameter pYpmssyz = new OracleParameter(":ypmssyz", OracleDbType.NVarchar2);
            pYpmssyz.Direction = ParameterDirection.Input;
            pYpmssyz.Value = ypmssyzList.ToArray();
            sqlparams.Add(pYpmssyz);

            this.isComma(sql);
            sql.Append(" YPMSJJZ=:ypmsjjz ");
            OracleParameter pYpmsjjz = new OracleParameter(":ypmsjjz", OracleDbType.NVarchar2);
            pYpmsjjz.Direction = ParameterDirection.Input;
            pYpmsjjz.Value = ypmsjjzList.ToArray();
            sqlparams.Add(pYpmsjjz);

            this.isComma(sql);
            sql.Append(" YPMSYFHBRQJY_CODE=:ypmsyfhbrqjy_code ");
            OracleParameter pYpmsyfhbrqjy_code = new OracleParameter(":ypmsyfhbrqjy_code", OracleDbType.NVarchar2);
            pYpmsyfhbrqjy_code.Direction = ParameterDirection.Input;
            pYpmsyfhbrqjy_code.Value = ypmsyfhbrqjy_codeList.ToArray();
            sqlparams.Add(pYpmsyfhbrqjy_code);

            this.isComma(sql);
            sql.Append(" YPMSBLFY=:ypmsblfy ");
            OracleParameter pYpmsblfy = new OracleParameter(":ypmsblfy", OracleDbType.NVarchar2);
            pYpmsblfy.Direction = ParameterDirection.Input;
            pYpmsblfy.Value = ypmsblfyList.ToArray();
            sqlparams.Add(pYpmsblfy);

            this.isComma(sql);
            sql.Append(" YPFL_CODE=:ypfl_code ");
            OracleParameter pYpfl_code = new OracleParameter(":ypfl_code", OracleDbType.NVarchar2);
            pYpfl_code.Direction = ParameterDirection.Input;
            pYpfl_code.Value = ypfl_codeList.ToArray();
            sqlparams.Add(pYpfl_code);

            this.isComma(sql);
            sql.Append(" YJJB_CODE=:yjjb_code ");
            OracleParameter pYjjb_code = new OracleParameter(":yjjb_code", OracleDbType.NVarchar2);
            pYjjb_code.Direction = ParameterDirection.Input;
            pYjjb_code.Value = yjjb_codeList.ToArray();
            sqlparams.Add(pYjjb_code);

            this.isComma(sql);
            sql.Append(" TXM=:txm ");
            OracleParameter pTxm = new OracleParameter(":txm", OracleDbType.NVarchar2);
            pTxm.Direction = ParameterDirection.Input;
            pTxm.Value = txmList.ToArray();
            sqlparams.Add(pTxm);

            this.isComma(sql);
            sql.Append(" EWM=:ewm ");
            OracleParameter pEwm = new OracleParameter(":ewm", OracleDbType.NVarchar2);
            pEwm.Direction = ParameterDirection.Input;
            pEwm.Value = ewmList.ToArray();
            sqlparams.Add(pEwm);

            this.isComma(sql);
            sql.Append(" PYM=:pym ");
            OracleParameter pPym = new OracleParameter(":pym", OracleDbType.NVarchar2);
            pPym.Direction = ParameterDirection.Input;
            pPym.Value = pymList.ToArray();
            sqlparams.Add(pPym);

            this.isComma(sql);
            sql.Append(" HSXS=:hsxs ");
            OracleParameter pHsxs = new OracleParameter(":hsxs", OracleDbType.Decimal);
            pHsxs.Direction = ParameterDirection.Input;
            pHsxs.Value = hsxsList.ToArray();
            sqlparams.Add(pHsxs);

            this.isComma(sql);
            sql.Append(" SFCLY_CODE=:sfcly_code ");
            OracleParameter pSfcly_code = new OracleParameter(":sfcly_code", OracleDbType.NVarchar2);
            pSfcly_code.Direction = ParameterDirection.Input;
            pSfcly_code.Value = sfcly_codeList.ToArray();
            sqlparams.Add(pSfcly_code);

            this.isComma(sql);
            sql.Append(" BZPFJ=:bzpfj ");
            OracleParameter pBzpfj = new OracleParameter(":bzpfj", OracleDbType.Decimal);
            pBzpfj.Direction = ParameterDirection.Input;
            pBzpfj.Value = bzpfjList.ToArray();
            sqlparams.Add(pBzpfj);

            this.isComma(sql);
            sql.Append(" BZLSJ=:bzlsj ");
            OracleParameter pBzlsj = new OracleParameter(":bzlsj", OracleDbType.Decimal);
            pBzlsj.Direction = ParameterDirection.Input;
            pBzlsj.Value = bzlsjList.ToArray();
            sqlparams.Add(pBzlsj);

            this.isComma(sql);
            sql.Append(" BZMZJ=:bzmzj ");
            OracleParameter pBzmzj = new OracleParameter(":bzmzj", OracleDbType.Decimal);
            pBzmzj.Direction = ParameterDirection.Input;
            pBzmzj.Value = bzmzjList.ToArray();
            sqlparams.Add(pBzmzj);

            this.isComma(sql);
            sql.Append(" BZZYJ=:bzzyj ");
            OracleParameter pBzzyj = new OracleParameter(":bzzyj", OracleDbType.Decimal);
            pBzzyj.Direction = ParameterDirection.Input;
            pBzzyj.Value = bzzyjList.ToArray();
            sqlparams.Add(pBzzyj);

            this.isComma(sql);
            sql.Append(" HSBL=:hsbl ");
            OracleParameter pHsbl = new OracleParameter(":hsbl", OracleDbType.Decimal);
            pHsbl.Direction = ParameterDirection.Input;
            pHsbl.Value = hsblList.ToArray();
            sqlparams.Add(pHsbl);

            this.isComma(sql);
            sql.Append(" SFCLM_CODE=:sfclm_code ");
            OracleParameter pSfclm_code = new OracleParameter(":sfclm_code", OracleDbType.NVarchar2);
            pSfclm_code.Direction = ParameterDirection.Input;
            pSfclm_code.Value = sfclm_codeList.ToArray();
            sqlparams.Add(pSfclm_code);

            this.isComma(sql);
            sql.Append(" YXZT_CODE=:yxzt_code ");
            OracleParameter pYxzt_code = new OracleParameter(":yxzt_code", OracleDbType.NVarchar2);
            pYxzt_code.Direction = ParameterDirection.Input;
            pYxzt_code.Value = yxzt_codeList.ToArray();
            sqlparams.Add(pYxzt_code);

            this.isComma(sql);
            sql.Append(" DCSXYL=:dcsxyl ");
            OracleParameter pDcsxyl = new OracleParameter(":dcsxyl", OracleDbType.Decimal);
            pDcsxyl.Direction = ParameterDirection.Input;
            pDcsxyl.Value = dcsxylList.ToArray();
            sqlparams.Add(pDcsxyl);

            this.isComma(sql);
            sql.Append(" DCXXYL=:dcxxyl ");
            OracleParameter pDcxxyl = new OracleParameter(":dcxxyl", OracleDbType.Decimal);
            pDcxxyl.Direction = ParameterDirection.Input;
            pDcxxyl.Value = dcxxylList.ToArray();
            sqlparams.Add(pDcxxyl);

            this.isComma(sql);
            sql.Append(" LXYLTS=:lxylts ");
            OracleParameter pLxylts = new OracleParameter(":lxylts", OracleDbType.Decimal);
            pLxylts.Direction = ParameterDirection.Input;
            pLxylts.Value = lxyltsList.ToArray();
            sqlparams.Add(pLxylts);

            this.isComma(sql);
            sql.Append(" LXYLCS=:lxylcs ");
            OracleParameter pLxylcs = new OracleParameter(":lxylcs", OracleDbType.Decimal);
            pLxylcs.Direction = ParameterDirection.Input;
            pLxylcs.Value = lxylcsList.ToArray();
            sqlparams.Add(pLxylcs);

            this.isComma(sql);
            sql.Append(" SCQY=:scqy ");
            OracleParameter pScqy = new OracleParameter(":scqy", OracleDbType.NVarchar2);
            pScqy.Direction = ParameterDirection.Input;
            pScqy.Value = scqyList.ToArray();
            sqlparams.Add(pScqy);

            this.isComma(sql);
            sql.Append(" PZRQ=:pzrq ");
            OracleParameter pPzrq = new OracleParameter(":pzrq", OracleDbType.Date);
            pPzrq.Direction = ParameterDirection.Input;
            pPzrq.Value = pzrqList.ToArray();
            sqlparams.Add(pPzrq);

            this.isComma(sql);
            sql.Append(" SFKSS_CODE=:sfkss_code ");
            OracleParameter pSfkss_code = new OracleParameter(":sfkss_code", OracleDbType.NVarchar2);
            pSfkss_code.Direction = ParameterDirection.Input;
            pSfkss_code.Value = sfkss_codeList.ToArray();
            sqlparams.Add(pSfkss_code);

            this.isComma(sql);
            sql.Append(" ZFBZ=:zfbz ");
            OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
            pZfbz.Direction = ParameterDirection.Input;
            pZfbz.Value = zfbzList.ToArray();
            sqlparams.Add(pZfbz);

            this.isComma(sql);
            sql.Append(" DCYLDWBL=:dcyldwbl ");
            OracleParameter pDcyldwbl = new OracleParameter(":dcyldwbl", OracleDbType.Decimal);
            pDcyldwbl.Direction = ParameterDirection.Input;
            pDcyldwbl.Value = dcyldwblList.ToArray();
            sqlparams.Add(pDcyldwbl);

            sql.Append(" WHERE ID=:id ");
            OracleParameter pId = new OracleParameter(":id", OracleDbType.Varchar2);
            pId.Value = idList.ToArray();
            sqlparams.Add(pId);
            this.b_isComma = false;
            bool result = false;
            int flag = OracleHelper.ExecuteBatch(sql.ToString(), con, jc_ypParamList.Count, sqlparams.ToArray());
            if (jc_ypParamList.Count == flag)
            {
                result = true;
            }
            return result;
        }

        /// <summary>
        /// 根据更新的条件，更新数据（如果需要供事务使用就传入OracleConnection对象，如果不供就传入null，方法自动生成OracleConnection对象）
        /// 不指定ID，如果要根据ID来更新数据，请使用updateForId方法
        /// </summary>
        /// <param name="jc_ypParamCondition">条件对象</param>
        /// <param name="jc_ypParamUpdate">要更新的数据对象</param>
        /// <param name="con">Oracle连接对象（为null时自动生成）</param>
        /// <returns>影响的行数不确定（不为-1就正确）</returns>
        public bool updateByOtherCondition(Jc_yp jc_ypParamCondition, Jc_yp jc_ypParamUpdate, OracleConnection con)
        {
            if ((null != jc_ypParamCondition.Id && "!=jc_ypParamCondition.Id)||(null!=jc_ypParamUpdate.Id&&" != jc_ypParamUpdate.Id))
            {
                throw new Exception("此方法不允许指定参数的ID，数据库中的ID不允许修改，如需根据ID修改数据，请调用updateById或updateByIdBatch方法；错误出自：updateByOtherCondition");
            }
            List<OracleParameter> sqlparams = new List<OracleParameter>();
            //添加要修改的值
            StringBuilder sql = new StringBuilder("UPDATE JC_YP SET ");
            if (null != jc_ypParamUpdate.Ypbm && "" != jc_ypParamUpdate.Ypbm)
            {
                this.isComma(sql);
                sql.Append(" YPBM=:ypbm ");
                OracleParameter pYpbm = new OracleParameter(":ypbm", OracleDbType.NVarchar2);
                pYpbm.Direction = ParameterDirection.Input;
                pYpbm.Value = jc_ypParamUpdate.Ypbm;
                sqlparams.Add(pYpbm);

            }

            if (null != jc_ypParamUpdate.Ypmc && "" != jc_ypParamUpdate.Ypmc)
            {
                this.isComma(sql);
                sql.Append(" YPMC=:ypmc ");
                OracleParameter pYpmc = new OracleParameter(":ypmc", OracleDbType.NVarchar2);
                pYpmc.Direction = ParameterDirection.Input;
                pYpmc.Value = jc_ypParamUpdate.Ypmc;
                sqlparams.Add(pYpmc);

            }

            if (null != jc_ypParamUpdate.Yptymc && "" != jc_ypParamUpdate.Yptymc)
            {
                this.isComma(sql);
                sql.Append(" YPTYMC=:yptymc ");
                OracleParameter pYptymc = new OracleParameter(":yptymc", OracleDbType.NVarchar2);
                pYptymc.Direction = ParameterDirection.Input;
                pYptymc.Value = jc_ypParamUpdate.Yptymc;
                sqlparams.Add(pYptymc);

            }

            if (null != jc_ypParamUpdate.Ypcf && "" != jc_ypParamUpdate.Ypcf)
            {
                this.isComma(sql);
                sql.Append(" YPCF=:ypcf ");
                OracleParameter pYpcf = new OracleParameter(":ypcf", OracleDbType.NVarchar2);
                pYpcf.Direction = ParameterDirection.Input;
                pYpcf.Value = jc_ypParamUpdate.Ypcf;
                sqlparams.Add(pYpcf);

            }

            if (null != jc_ypParamUpdate.Yppzwh && "" != jc_ypParamUpdate.Yppzwh)
            {
                this.isComma(sql);
                sql.Append(" YPPZWH=:yppzwh ");
                OracleParameter pYppzwh = new OracleParameter(":yppzwh", OracleDbType.NVarchar2);
                pYppzwh.Direction = ParameterDirection.Input;
                pYppzwh.Value = jc_ypParamUpdate.Yppzwh;
                sqlparams.Add(pYppzwh);

            }

            if (null != jc_ypParamUpdate.Ypzczh && "" != jc_ypParamUpdate.Ypzczh)
            {
                this.isComma(sql);
                sql.Append(" YPZCZH=:ypzczh ");
                OracleParameter pYpzczh = new OracleParameter(":ypzczh", OracleDbType.NVarchar2);
                pYpzczh.Direction = ParameterDirection.Input;
                pYpzczh.Value = jc_ypParamUpdate.Ypzczh;
                sqlparams.Add(pYpzczh);

            }

            if (null != jc_ypParamUpdate.Gyzz && "" != jc_ypParamUpdate.Gyzz)
            {
                this.isComma(sql);
                sql.Append(" GYZZ=:gyzz ");
                OracleParameter pGyzz = new OracleParameter(":gyzz", OracleDbType.NVarchar2);
                pGyzz.Direction = ParameterDirection.Input;
                pGyzz.Value = jc_ypParamUpdate.Gyzz;
                sqlparams.Add(pGyzz);

            }

            if (null != jc_ypParamUpdate.Ypjx_code && "" != jc_ypParamUpdate.Ypjx_code)
            {
                this.isComma(sql);
                sql.Append(" YPJX_CODE=:ypjx_code ");
                OracleParameter pYpjx_code = new OracleParameter(":ypjx_code", OracleDbType.NVarchar2);
                pYpjx_code.Direction = ParameterDirection.Input;
                pYpjx_code.Value = jc_ypParamUpdate.Ypjx_code;
                sqlparams.Add(pYpjx_code);

            }

            if (null != jc_ypParamUpdate.Ypgg && "" != jc_ypParamUpdate.Ypgg)
            {
                this.isComma(sql);
                sql.Append(" YPGG=:ypgg ");
                OracleParameter pYpgg = new OracleParameter(":ypgg", OracleDbType.NVarchar2);
                pYpgg.Direction = ParameterDirection.Input;
                pYpgg.Value = jc_ypParamUpdate.Ypgg;
                sqlparams.Add(pYpgg);

            }

            if (null != jc_ypParamUpdate.Ypdcyl)
            {
                this.isComma(sql);
                sql.Append(" YPDCYL=:ypdcyl ");
                OracleParameter pYpdcyl = new OracleParameter(":ypdcyl", OracleDbType.Decimal);
                pYpdcyl.Direction = ParameterDirection.Input;
                pYpdcyl.Value = jc_ypParamUpdate.Ypdcyl;
                sqlparams.Add(pYpdcyl);

            }

            if (null != jc_ypParamUpdate.Ypdcyldw_code && "" != jc_ypParamUpdate.Ypdcyldw_code)
            {
                this.isComma(sql);
                sql.Append(" YPDCYLDW_CODE=:ypdcyldw_code ");
                OracleParameter pYpdcyldw_code = new OracleParameter(":ypdcyldw_code", OracleDbType.NVarchar2);
                pYpdcyldw_code.Direction = ParameterDirection.Input;
                pYpdcyldw_code.Value = jc_ypParamUpdate.Ypdcyldw_code;
                sqlparams.Add(pYpdcyldw_code);

            }

            if (null != jc_ypParamUpdate.Ypyytj_code && "" != jc_ypParamUpdate.Ypyytj_code)
            {
                this.isComma(sql);
                sql.Append(" YPYYTJ_CODE=:ypyytj_code ");
                OracleParameter pYpyytj_code = new OracleParameter(":ypyytj_code", OracleDbType.NVarchar2);
                pYpyytj_code.Direction = ParameterDirection.Input;
                pYpyytj_code.Value = jc_ypParamUpdate.Ypyytj_code;
                sqlparams.Add(pYpyytj_code);

            }

            if (null != jc_ypParamUpdate.Ddw_code && "" != jc_ypParamUpdate.Ddw_code)
            {
                this.isComma(sql);
                sql.Append(" DDW_CODE=:ddw_code ");
                OracleParameter pDdw_code = new OracleParameter(":ddw_code", OracleDbType.NVarchar2);
                pDdw_code.Direction = ParameterDirection.Input;
                pDdw_code.Value = jc_ypParamUpdate.Ddw_code;
                sqlparams.Add(pDdw_code);

            }

            if (null != jc_ypParamUpdate.Xdw_code && "" != jc_ypParamUpdate.Xdw_code)
            {
                this.isComma(sql);
                sql.Append(" XDW_CODE=:xdw_code ");
                OracleParameter pXdw_code = new OracleParameter(":xdw_code", OracleDbType.NVarchar2);
                pXdw_code.Direction = ParameterDirection.Input;
                pXdw_code.Value = jc_ypParamUpdate.Xdw_code;
                sqlparams.Add(pXdw_code);

            }

            if (null != jc_ypParamUpdate.Cfybz_code && "" != jc_ypParamUpdate.Cfybz_code)
            {
                this.isComma(sql);
                sql.Append(" CFYBZ_CODE=:cfybz_code ");
                OracleParameter pCfybz_code = new OracleParameter(":cfybz_code", OracleDbType.NVarchar2);
                pCfybz_code.Direction = ParameterDirection.Input;
                pCfybz_code.Value = jc_ypParamUpdate.Cfybz_code;
                sqlparams.Add(pCfybz_code);

            }

            if (null != jc_ypParamUpdate.Cfqxjy_code && "" != jc_ypParamUpdate.Cfqxjy_code)
            {
                this.isComma(sql);
                sql.Append(" CFQXJY_CODE=:cfqxjy_code ");
                OracleParameter pCfqxjy_code = new OracleParameter(":cfqxjy_code", OracleDbType.NVarchar2);
                pCfqxjy_code.Direction = ParameterDirection.Input;
                pCfqxjy_code.Value = jc_ypParamUpdate.Cfqxjy_code;
                sqlparams.Add(pCfqxjy_code);

            }

            if (null != jc_ypParamUpdate.Cfqxyb_code && "" != jc_ypParamUpdate.Cfqxyb_code)
            {
                this.isComma(sql);
                sql.Append(" CFQXYB_CODE=:cfqxyb_code ");
                OracleParameter pCfqxyb_code = new OracleParameter(":cfqxyb_code", OracleDbType.NVarchar2);
                pCfqxyb_code.Direction = ParameterDirection.Input;
                pCfqxyb_code.Value = jc_ypParamUpdate.Cfqxyb_code;
                sqlparams.Add(pCfqxyb_code);

            }

            if (null != jc_ypParamUpdate.Cfqxdm_code && "" != jc_ypParamUpdate.Cfqxdm_code)
            {
                this.isComma(sql);
                sql.Append(" CFQXDM_CODE=:cfqxdm_code ");
                OracleParameter pCfqxdm_code = new OracleParameter(":cfqxdm_code", OracleDbType.NVarchar2);
                pCfqxdm_code.Direction = ParameterDirection.Input;
                pCfqxdm_code.Value = jc_ypParamUpdate.Cfqxdm_code;
                sqlparams.Add(pCfqxdm_code);

            }

            if (null != jc_ypParamUpdate.Cfqxjs_code && "" != jc_ypParamUpdate.Cfqxjs_code)
            {
                this.isComma(sql);
                sql.Append(" CFQXJS_CODE=:cfqxjs_code ");
                OracleParameter pCfqxjs_code = new OracleParameter(":cfqxjs_code", OracleDbType.NVarchar2);
                pCfqxjs_code.Direction = ParameterDirection.Input;
                pCfqxjs_code.Value = jc_ypParamUpdate.Cfqxjs_code;
                sqlparams.Add(pCfqxjs_code);

            }

            if (null != jc_ypParamUpdate.Cfqxgz_code && "" != jc_ypParamUpdate.Cfqxgz_code)
            {
                this.isComma(sql);
                sql.Append(" CFQXGZ_CODE=:cfqxgz_code ");
                OracleParameter pCfqxgz_code = new OracleParameter(":cfqxgz_code", OracleDbType.NVarchar2);
                pCfqxgz_code.Direction = ParameterDirection.Input;
                pCfqxgz_code.Value = jc_ypParamUpdate.Cfqxgz_code;
                sqlparams.Add(pCfqxgz_code);

            }

            if (null != jc_ypParamUpdate.Cfqxjk_code && "" != jc_ypParamUpdate.Cfqxjk_code)
            {
                this.isComma(sql);
                sql.Append(" CFQXJK_CODE=:cfqxjk_code ");
                OracleParameter pCfqxjk_code = new OracleParameter(":cfqxjk_code", OracleDbType.NVarchar2);
                pCfqxjk_code.Direction = ParameterDirection.Input;
                pCfqxjk_code.Value = jc_ypParamUpdate.Cfqxjk_code;
                sqlparams.Add(pCfqxjk_code);

            }

            if (null != jc_ypParamUpdate.Cfqxzz_code && "" != jc_ypParamUpdate.Cfqxzz_code)
            {
                this.isComma(sql);
                sql.Append(" CFQXZZ_CODE=:cfqxzz_code ");
                OracleParameter pCfqxzz_code = new OracleParameter(":cfqxzz_code", OracleDbType.NVarchar2);
                pCfqxzz_code.Direction = ParameterDirection.Input;
                pCfqxzz_code.Value = jc_ypParamUpdate.Cfqxzz_code;
                sqlparams.Add(pCfqxzz_code);

            }

            if (null != jc_ypParamUpdate.Cfqxzf_code && "" != jc_ypParamUpdate.Cfqxzf_code)
            {
                this.isComma(sql);
                sql.Append(" CFQXZF_CODE=:cfqxzf_code ");
                OracleParameter pCfqxzf_code = new OracleParameter(":cfqxzf_code", OracleDbType.NVarchar2);
                pCfqxzf_code.Direction = ParameterDirection.Input;
                pCfqxzf_code.Value = jc_ypParamUpdate.Cfqxzf_code;
                sqlparams.Add(pCfqxzf_code);

            }

            if (null != jc_ypParamUpdate.Cfqxts_code && "" != jc_ypParamUpdate.Cfqxts_code)
            {
                this.isComma(sql);
                sql.Append(" CFQXTS_CODE=:cfqxts_code ");
                OracleParameter pCfqxts_code = new OracleParameter(":cfqxts_code", OracleDbType.NVarchar2);
                pCfqxts_code.Direction = ParameterDirection.Input;
                pCfqxts_code.Value = jc_ypParamUpdate.Cfqxts_code;
                sqlparams.Add(pCfqxts_code);

            }

            if (null != jc_ypParamUpdate.Ps_code && "" != jc_ypParamUpdate.Ps_code)
            {
                this.isComma(sql);
                sql.Append(" PS_CODE=:ps_code ");
                OracleParameter pPs_code = new OracleParameter(":ps_code", OracleDbType.NVarchar2);
                pPs_code.Direction = ParameterDirection.Input;
                pPs_code.Value = jc_ypParamUpdate.Ps_code;
                sqlparams.Add(pPs_code);

            }

            if (null != jc_ypParamUpdate.Yplx_code && "" != jc_ypParamUpdate.Yplx_code)
            {
                this.isComma(sql);
                sql.Append(" YPLX_CODE=:yplx_code ");
                OracleParameter pYplx_code = new OracleParameter(":yplx_code", OracleDbType.NVarchar2);
                pYplx_code.Direction = ParameterDirection.Input;
                pYplx_code.Value = jc_ypParamUpdate.Yplx_code;
                sqlparams.Add(pYplx_code);

            }

            if (null != jc_ypParamUpdate.Ypmssyz && "" != jc_ypParamUpdate.Ypmssyz)
            {
                this.isComma(sql);
                sql.Append(" YPMSSYZ=:ypmssyz ");
                OracleParameter pYpmssyz = new OracleParameter(":ypmssyz", OracleDbType.NVarchar2);
                pYpmssyz.Direction = ParameterDirection.Input;
                pYpmssyz.Value = jc_ypParamUpdate.Ypmssyz;
                sqlparams.Add(pYpmssyz);

            }

            if (null != jc_ypParamUpdate.Ypmsjjz && "" != jc_ypParamUpdate.Ypmsjjz)
            {
                this.isComma(sql);
                sql.Append(" YPMSJJZ=:ypmsjjz ");
                OracleParameter pYpmsjjz = new OracleParameter(":ypmsjjz", OracleDbType.NVarchar2);
                pYpmsjjz.Direction = ParameterDirection.Input;
                pYpmsjjz.Value = jc_ypParamUpdate.Ypmsjjz;
                sqlparams.Add(pYpmsjjz);

            }

            if (null != jc_ypParamUpdate.Ypmsyfhbrqjy_code && "" != jc_ypParamUpdate.Ypmsyfhbrqjy_code)
            {
                this.isComma(sql);
                sql.Append(" YPMSYFHBRQJY_CODE=:ypmsyfhbrqjy_code ");
                OracleParameter pYpmsyfhbrqjy_code = new OracleParameter(":ypmsyfhbrqjy_code", OracleDbType.NVarchar2);
                pYpmsyfhbrqjy_code.Direction = ParameterDirection.Input;
                pYpmsyfhbrqjy_code.Value = jc_ypParamUpdate.Ypmsyfhbrqjy_code;
                sqlparams.Add(pYpmsyfhbrqjy_code);

            }

            if (null != jc_ypParamUpdate.Ypmsblfy && "" != jc_ypParamUpdate.Ypmsblfy)
            {
                this.isComma(sql);
                sql.Append(" YPMSBLFY=:ypmsblfy ");
                OracleParameter pYpmsblfy = new OracleParameter(":ypmsblfy", OracleDbType.NVarchar2);
                pYpmsblfy.Direction = ParameterDirection.Input;
                pYpmsblfy.Value = jc_ypParamUpdate.Ypmsblfy;
                sqlparams.Add(pYpmsblfy);

            }

            if (null != jc_ypParamUpdate.Ypfl_code && "" != jc_ypParamUpdate.Ypfl_code)
            {
                this.isComma(sql);
                sql.Append(" YPFL_CODE=:ypfl_code ");
                OracleParameter pYpfl_code = new OracleParameter(":ypfl_code", OracleDbType.NVarchar2);
                pYpfl_code.Direction = ParameterDirection.Input;
                pYpfl_code.Value = jc_ypParamUpdate.Ypfl_code;
                sqlparams.Add(pYpfl_code);

            }

            if (null != jc_ypParamUpdate.Yjjb_code && "" != jc_ypParamUpdate.Yjjb_code)
            {
                this.isComma(sql);
                sql.Append(" YJJB_CODE=:yjjb_code ");
                OracleParameter pYjjb_code = new OracleParameter(":yjjb_code", OracleDbType.NVarchar2);
                pYjjb_code.Direction = ParameterDirection.Input;
                pYjjb_code.Value = jc_ypParamUpdate.Yjjb_code;
                sqlparams.Add(pYjjb_code);

            }

            if (null != jc_ypParamUpdate.Txm && "" != jc_ypParamUpdate.Txm)
            {
                this.isComma(sql);
                sql.Append(" TXM=:txm ");
                OracleParameter pTxm = new OracleParameter(":txm", OracleDbType.NVarchar2);
                pTxm.Direction = ParameterDirection.Input;
                pTxm.Value = jc_ypParamUpdate.Txm;
                sqlparams.Add(pTxm);

            }

            if (null != jc_ypParamUpdate.Ewm && "" != jc_ypParamUpdate.Ewm)
            {
                this.isComma(sql);
                sql.Append(" EWM=:ewm ");
                OracleParameter pEwm = new OracleParameter(":ewm", OracleDbType.NVarchar2);
                pEwm.Direction = ParameterDirection.Input;
                pEwm.Value = jc_ypParamUpdate.Ewm;
                sqlparams.Add(pEwm);

            }

            if (null != jc_ypParamUpdate.Pym && "" != jc_ypParamUpdate.Pym)
            {
                this.isComma(sql);
                sql.Append(" PYM=:pym ");
                OracleParameter pPym = new OracleParameter(":pym", OracleDbType.NVarchar2);
                pPym.Direction = ParameterDirection.Input;
                pPym.Value = jc_ypParamUpdate.Pym;
                sqlparams.Add(pPym);

            }

            if (null != jc_ypParamUpdate.Hsxs)
            {
                this.isComma(sql);
                sql.Append(" HSXS=:hsxs ");
                OracleParameter pHsxs = new OracleParameter(":hsxs", OracleDbType.Decimal);
                pHsxs.Direction = ParameterDirection.Input;
                pHsxs.Value = jc_ypParamUpdate.Hsxs;
                sqlparams.Add(pHsxs);

            }

            if (null != jc_ypParamUpdate.Sfcly_code && "" != jc_ypParamUpdate.Sfcly_code)
            {
                this.isComma(sql);
                sql.Append(" SFCLY_CODE=:sfcly_code ");
                OracleParameter pSfcly_code = new OracleParameter(":sfcly_code", OracleDbType.NVarchar2);
                pSfcly_code.Direction = ParameterDirection.Input;
                pSfcly_code.Value = jc_ypParamUpdate.Sfcly_code;
                sqlparams.Add(pSfcly_code);

            }

            if (null != jc_ypParamUpdate.Bzpfj)
            {
                this.isComma(sql);
                sql.Append(" BZPFJ=:bzpfj ");
                OracleParameter pBzpfj = new OracleParameter(":bzpfj", OracleDbType.Decimal);
                pBzpfj.Direction = ParameterDirection.Input;
                pBzpfj.Value = jc_ypParamUpdate.Bzpfj;
                sqlparams.Add(pBzpfj);

            }

            if (null != jc_ypParamUpdate.Bzlsj)
            {
                this.isComma(sql);
                sql.Append(" BZLSJ=:bzlsj ");
                OracleParameter pBzlsj = new OracleParameter(":bzlsj", OracleDbType.Decimal);
                pBzlsj.Direction = ParameterDirection.Input;
                pBzlsj.Value = jc_ypParamUpdate.Bzlsj;
                sqlparams.Add(pBzlsj);

            }

            if (null != jc_ypParamUpdate.Bzmzj)
            {
                this.isComma(sql);
                sql.Append(" BZMZJ=:bzmzj ");
                OracleParameter pBzmzj = new OracleParameter(":bzmzj", OracleDbType.Decimal);
                pBzmzj.Direction = ParameterDirection.Input;
                pBzmzj.Value = jc_ypParamUpdate.Bzmzj;
                sqlparams.Add(pBzmzj);

            }

            if (null != jc_ypParamUpdate.Bzzyj)
            {
                this.isComma(sql);
                sql.Append(" BZZYJ=:bzzyj ");
                OracleParameter pBzzyj = new OracleParameter(":bzzyj", OracleDbType.Decimal);
                pBzzyj.Direction = ParameterDirection.Input;
                pBzzyj.Value = jc_ypParamUpdate.Bzzyj;
                sqlparams.Add(pBzzyj);

            }

            if (null != jc_ypParamUpdate.Hsbl)
            {
                this.isComma(sql);
                sql.Append(" HSBL=:hsbl ");
                OracleParameter pHsbl = new OracleParameter(":hsbl", OracleDbType.Decimal);
                pHsbl.Direction = ParameterDirection.Input;
                pHsbl.Value = jc_ypParamUpdate.Hsbl;
                sqlparams.Add(pHsbl);

            }

            if (null != jc_ypParamUpdate.Sfclm_code && "" != jc_ypParamUpdate.Sfclm_code)
            {
                this.isComma(sql);
                sql.Append(" SFCLM_CODE=:sfclm_code ");
                OracleParameter pSfclm_code = new OracleParameter(":sfclm_code", OracleDbType.NVarchar2);
                pSfclm_code.Direction = ParameterDirection.Input;
                pSfclm_code.Value = jc_ypParamUpdate.Sfclm_code;
                sqlparams.Add(pSfclm_code);

            }

            if (null != jc_ypParamUpdate.Yxzt_code && "" != jc_ypParamUpdate.Yxzt_code)
            {
                this.isComma(sql);
                sql.Append(" YXZT_CODE=:yxzt_code ");
                OracleParameter pYxzt_code = new OracleParameter(":yxzt_code", OracleDbType.NVarchar2);
                pYxzt_code.Direction = ParameterDirection.Input;
                pYxzt_code.Value = jc_ypParamUpdate.Yxzt_code;
                sqlparams.Add(pYxzt_code);

            }

            if (null != jc_ypParamUpdate.Dcsxyl)
            {
                this.isComma(sql);
                sql.Append(" DCSXYL=:dcsxyl ");
                OracleParameter pDcsxyl = new OracleParameter(":dcsxyl", OracleDbType.Decimal);
                pDcsxyl.Direction = ParameterDirection.Input;
                pDcsxyl.Value = jc_ypParamUpdate.Dcsxyl;
                sqlparams.Add(pDcsxyl);

            }

            if (null != jc_ypParamUpdate.Dcxxyl)
            {
                this.isComma(sql);
                sql.Append(" DCXXYL=:dcxxyl ");
                OracleParameter pDcxxyl = new OracleParameter(":dcxxyl", OracleDbType.Decimal);
                pDcxxyl.Direction = ParameterDirection.Input;
                pDcxxyl.Value = jc_ypParamUpdate.Dcxxyl;
                sqlparams.Add(pDcxxyl);

            }

            if (null != jc_ypParamUpdate.Lxylts)
            {
                this.isComma(sql);
                sql.Append(" LXYLTS=:lxylts ");
                OracleParameter pLxylts = new OracleParameter(":lxylts", OracleDbType.Decimal);
                pLxylts.Direction = ParameterDirection.Input;
                pLxylts.Value = jc_ypParamUpdate.Lxylts;
                sqlparams.Add(pLxylts);

            }

            if (null != jc_ypParamUpdate.Lxylcs)
            {
                this.isComma(sql);
                sql.Append(" LXYLCS=:lxylcs ");
                OracleParameter pLxylcs = new OracleParameter(":lxylcs", OracleDbType.Decimal);
                pLxylcs.Direction = ParameterDirection.Input;
                pLxylcs.Value = jc_ypParamUpdate.Lxylcs;
                sqlparams.Add(pLxylcs);

            }

            if (null != jc_ypParamUpdate.Scqy && "" != jc_ypParamUpdate.Scqy)
            {
                this.isComma(sql);
                sql.Append(" SCQY=:scqy ");
                OracleParameter pScqy = new OracleParameter(":scqy", OracleDbType.NVarchar2);
                pScqy.Direction = ParameterDirection.Input;
                pScqy.Value = jc_ypParamUpdate.Scqy;
                sqlparams.Add(pScqy);

            }

            if (DateTime.MinValue != jc_ypParamUpdate.Pzrq && null != jc_ypParamUpdate.Pzrq)
            {
                this.isComma(sql);
                sql.Append(" PZRQ=:pzrq ");
                OracleParameter pPzrq = new OracleParameter(":pzrq", OracleDbType.Date);
                pPzrq.Direction = ParameterDirection.Input;
                pPzrq.Value = jc_ypParamUpdate.Pzrq;
                sqlparams.Add(pPzrq);

            }

            if (null != jc_ypParamUpdate.Sfkss_code && "" != jc_ypParamUpdate.Sfkss_code)
            {
                this.isComma(sql);
                sql.Append(" SFKSS_CODE=:sfkss_code ");
                OracleParameter pSfkss_code = new OracleParameter(":sfkss_code", OracleDbType.NVarchar2);
                pSfkss_code.Direction = ParameterDirection.Input;
                pSfkss_code.Value = jc_ypParamUpdate.Sfkss_code;
                sqlparams.Add(pSfkss_code);

            }

            if (null != jc_ypParamUpdate.Zfbz && "" != jc_ypParamUpdate.Zfbz)
            {
                this.isComma(sql);
                sql.Append(" ZFBZ=:zfbz ");
                OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                pZfbz.Direction = ParameterDirection.Input;
                pZfbz.Value = jc_ypParamUpdate.Zfbz;
                sqlparams.Add(pZfbz);

            }

            if (null != jc_ypParamUpdate.Dcyldwbl)
            {
                this.isComma(sql);
                sql.Append(" DCYLDWBL=:dcyldwbl ");
                OracleParameter pDcyldwbl = new OracleParameter(":dcyldwbl", OracleDbType.Decimal);
                pDcyldwbl.Direction = ParameterDirection.Input;
                pDcyldwbl.Value = jc_ypParamUpdate.Dcyldwbl;
                sqlparams.Add(pDcyldwbl);

            }

            //添加条件的参数

            if (null != jc_ypParamCondition.Ypbm && "" != jc_ypParamCondition.Ypbm)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" YPBM=:ypbm ");
                OracleParameter pYpbm = new OracleParameter(":ypbm", OracleDbType.NVarchar2);
                pYpbm.Direction = ParameterDirection.Input;
                pYpbm.Value = jc_ypParamCondition.Ypbm;
                sqlparams.Add(pYpbm);

            }

            if (null != jc_ypParamCondition.Ypmc && "" != jc_ypParamCondition.Ypmc)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" YPMC=:ypmc ");
                OracleParameter pYpmc = new OracleParameter(":ypmc", OracleDbType.NVarchar2);
                pYpmc.Direction = ParameterDirection.Input;
                pYpmc.Value = jc_ypParamCondition.Ypmc;
                sqlparams.Add(pYpmc);

            }

            if (null != jc_ypParamCondition.Yptymc && "" != jc_ypParamCondition.Yptymc)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" YPTYMC=:yptymc ");
                OracleParameter pYptymc = new OracleParameter(":yptymc", OracleDbType.NVarchar2);
                pYptymc.Direction = ParameterDirection.Input;
                pYptymc.Value = jc_ypParamCondition.Yptymc;
                sqlparams.Add(pYptymc);

            }

            if (null != jc_ypParamCondition.Ypcf && "" != jc_ypParamCondition.Ypcf)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" YPCF=:ypcf ");
                OracleParameter pYpcf = new OracleParameter(":ypcf", OracleDbType.NVarchar2);
                pYpcf.Direction = ParameterDirection.Input;
                pYpcf.Value = jc_ypParamCondition.Ypcf;
                sqlparams.Add(pYpcf);

            }

            if (null != jc_ypParamCondition.Yppzwh && "" != jc_ypParamCondition.Yppzwh)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" YPPZWH=:yppzwh ");
                OracleParameter pYppzwh = new OracleParameter(":yppzwh", OracleDbType.NVarchar2);
                pYppzwh.Direction = ParameterDirection.Input;
                pYppzwh.Value = jc_ypParamCondition.Yppzwh;
                sqlparams.Add(pYppzwh);

            }

            if (null != jc_ypParamCondition.Ypzczh && "" != jc_ypParamCondition.Ypzczh)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" YPZCZH=:ypzczh ");
                OracleParameter pYpzczh = new OracleParameter(":ypzczh", OracleDbType.NVarchar2);
                pYpzczh.Direction = ParameterDirection.Input;
                pYpzczh.Value = jc_ypParamCondition.Ypzczh;
                sqlparams.Add(pYpzczh);

            }

            if (null != jc_ypParamCondition.Gyzz && "" != jc_ypParamCondition.Gyzz)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" GYZZ=:gyzz ");
                OracleParameter pGyzz = new OracleParameter(":gyzz", OracleDbType.NVarchar2);
                pGyzz.Direction = ParameterDirection.Input;
                pGyzz.Value = jc_ypParamCondition.Gyzz;
                sqlparams.Add(pGyzz);

            }

            if (null != jc_ypParamCondition.Ypjx_code && "" != jc_ypParamCondition.Ypjx_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" YPJX_CODE=:ypjx_code ");
                OracleParameter pYpjx_code = new OracleParameter(":ypjx_code", OracleDbType.NVarchar2);
                pYpjx_code.Direction = ParameterDirection.Input;
                pYpjx_code.Value = jc_ypParamCondition.Ypjx_code;
                sqlparams.Add(pYpjx_code);

            }

            if (null != jc_ypParamCondition.Ypgg && "" != jc_ypParamCondition.Ypgg)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" YPGG=:ypgg ");
                OracleParameter pYpgg = new OracleParameter(":ypgg", OracleDbType.NVarchar2);
                pYpgg.Direction = ParameterDirection.Input;
                pYpgg.Value = jc_ypParamCondition.Ypgg;
                sqlparams.Add(pYpgg);

            }

            if (null != jc_ypParamCondition.Ypdcyl)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" YPDCYL=:ypdcyl ");
                OracleParameter pYpdcyl = new OracleParameter(":ypdcyl", OracleDbType.Decimal);
                pYpdcyl.Direction = ParameterDirection.Input;
                pYpdcyl.Value = jc_ypParamCondition.Ypdcyl;
                sqlparams.Add(pYpdcyl);

            }

            if (null != jc_ypParamCondition.Ypdcyldw_code && "" != jc_ypParamCondition.Ypdcyldw_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" YPDCYLDW_CODE=:ypdcyldw_code ");
                OracleParameter pYpdcyldw_code = new OracleParameter(":ypdcyldw_code", OracleDbType.NVarchar2);
                pYpdcyldw_code.Direction = ParameterDirection.Input;
                pYpdcyldw_code.Value = jc_ypParamCondition.Ypdcyldw_code;
                sqlparams.Add(pYpdcyldw_code);

            }

            if (null != jc_ypParamCondition.Ypyytj_code && "" != jc_ypParamCondition.Ypyytj_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" YPYYTJ_CODE=:ypyytj_code ");
                OracleParameter pYpyytj_code = new OracleParameter(":ypyytj_code", OracleDbType.NVarchar2);
                pYpyytj_code.Direction = ParameterDirection.Input;
                pYpyytj_code.Value = jc_ypParamCondition.Ypyytj_code;
                sqlparams.Add(pYpyytj_code);

            }

            if (null != jc_ypParamCondition.Ddw_code && "" != jc_ypParamCondition.Ddw_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" DDW_CODE=:ddw_code ");
                OracleParameter pDdw_code = new OracleParameter(":ddw_code", OracleDbType.NVarchar2);
                pDdw_code.Direction = ParameterDirection.Input;
                pDdw_code.Value = jc_ypParamCondition.Ddw_code;
                sqlparams.Add(pDdw_code);

            }

            if (null != jc_ypParamCondition.Xdw_code && "" != jc_ypParamCondition.Xdw_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" XDW_CODE=:xdw_code ");
                OracleParameter pXdw_code = new OracleParameter(":xdw_code", OracleDbType.NVarchar2);
                pXdw_code.Direction = ParameterDirection.Input;
                pXdw_code.Value = jc_ypParamCondition.Xdw_code;
                sqlparams.Add(pXdw_code);

            }

            if (null != jc_ypParamCondition.Cfybz_code && "" != jc_ypParamCondition.Cfybz_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" CFYBZ_CODE=:cfybz_code ");
                OracleParameter pCfybz_code = new OracleParameter(":cfybz_code", OracleDbType.NVarchar2);
                pCfybz_code.Direction = ParameterDirection.Input;
                pCfybz_code.Value = jc_ypParamCondition.Cfybz_code;
                sqlparams.Add(pCfybz_code);

            }

            if (null != jc_ypParamCondition.Cfqxjy_code && "" != jc_ypParamCondition.Cfqxjy_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" CFQXJY_CODE=:cfqxjy_code ");
                OracleParameter pCfqxjy_code = new OracleParameter(":cfqxjy_code", OracleDbType.NVarchar2);
                pCfqxjy_code.Direction = ParameterDirection.Input;
                pCfqxjy_code.Value = jc_ypParamCondition.Cfqxjy_code;
                sqlparams.Add(pCfqxjy_code);

            }

            if (null != jc_ypParamCondition.Cfqxyb_code && "" != jc_ypParamCondition.Cfqxyb_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" CFQXYB_CODE=:cfqxyb_code ");
                OracleParameter pCfqxyb_code = new OracleParameter(":cfqxyb_code", OracleDbType.NVarchar2);
                pCfqxyb_code.Direction = ParameterDirection.Input;
                pCfqxyb_code.Value = jc_ypParamCondition.Cfqxyb_code;
                sqlparams.Add(pCfqxyb_code);

            }

            if (null != jc_ypParamCondition.Cfqxdm_code && "" != jc_ypParamCondition.Cfqxdm_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" CFQXDM_CODE=:cfqxdm_code ");
                OracleParameter pCfqxdm_code = new OracleParameter(":cfqxdm_code", OracleDbType.NVarchar2);
                pCfqxdm_code.Direction = ParameterDirection.Input;
                pCfqxdm_code.Value = jc_ypParamCondition.Cfqxdm_code;
                sqlparams.Add(pCfqxdm_code);

            }

            if (null != jc_ypParamCondition.Cfqxjs_code && "" != jc_ypParamCondition.Cfqxjs_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" CFQXJS_CODE=:cfqxjs_code ");
                OracleParameter pCfqxjs_code = new OracleParameter(":cfqxjs_code", OracleDbType.NVarchar2);
                pCfqxjs_code.Direction = ParameterDirection.Input;
                pCfqxjs_code.Value = jc_ypParamCondition.Cfqxjs_code;
                sqlparams.Add(pCfqxjs_code);

            }

            if (null != jc_ypParamCondition.Cfqxgz_code && "" != jc_ypParamCondition.Cfqxgz_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" CFQXGZ_CODE=:cfqxgz_code ");
                OracleParameter pCfqxgz_code = new OracleParameter(":cfqxgz_code", OracleDbType.NVarchar2);
                pCfqxgz_code.Direction = ParameterDirection.Input;
                pCfqxgz_code.Value = jc_ypParamCondition.Cfqxgz_code;
                sqlparams.Add(pCfqxgz_code);

            }

            if (null != jc_ypParamCondition.Cfqxjk_code && "" != jc_ypParamCondition.Cfqxjk_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" CFQXJK_CODE=:cfqxjk_code ");
                OracleParameter pCfqxjk_code = new OracleParameter(":cfqxjk_code", OracleDbType.NVarchar2);
                pCfqxjk_code.Direction = ParameterDirection.Input;
                pCfqxjk_code.Value = jc_ypParamCondition.Cfqxjk_code;
                sqlparams.Add(pCfqxjk_code);

            }

            if (null != jc_ypParamCondition.Cfqxzz_code && "" != jc_ypParamCondition.Cfqxzz_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" CFQXZZ_CODE=:cfqxzz_code ");
                OracleParameter pCfqxzz_code = new OracleParameter(":cfqxzz_code", OracleDbType.NVarchar2);
                pCfqxzz_code.Direction = ParameterDirection.Input;
                pCfqxzz_code.Value = jc_ypParamCondition.Cfqxzz_code;
                sqlparams.Add(pCfqxzz_code);

            }

            if (null != jc_ypParamCondition.Cfqxzf_code && "" != jc_ypParamCondition.Cfqxzf_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" CFQXZF_CODE=:cfqxzf_code ");
                OracleParameter pCfqxzf_code = new OracleParameter(":cfqxzf_code", OracleDbType.NVarchar2);
                pCfqxzf_code.Direction = ParameterDirection.Input;
                pCfqxzf_code.Value = jc_ypParamCondition.Cfqxzf_code;
                sqlparams.Add(pCfqxzf_code);

            }

            if (null != jc_ypParamCondition.Cfqxts_code && "" != jc_ypParamCondition.Cfqxts_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" CFQXTS_CODE=:cfqxts_code ");
                OracleParameter pCfqxts_code = new OracleParameter(":cfqxts_code", OracleDbType.NVarchar2);
                pCfqxts_code.Direction = ParameterDirection.Input;
                pCfqxts_code.Value = jc_ypParamCondition.Cfqxts_code;
                sqlparams.Add(pCfqxts_code);

            }

            if (null != jc_ypParamCondition.Ps_code && "" != jc_ypParamCondition.Ps_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" PS_CODE=:ps_code ");
                OracleParameter pPs_code = new OracleParameter(":ps_code", OracleDbType.NVarchar2);
                pPs_code.Direction = ParameterDirection.Input;
                pPs_code.Value = jc_ypParamCondition.Ps_code;
                sqlparams.Add(pPs_code);

            }

            if (null != jc_ypParamCondition.Yplx_code && "" != jc_ypParamCondition.Yplx_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" YPLX_CODE=:yplx_code ");
                OracleParameter pYplx_code = new OracleParameter(":yplx_code", OracleDbType.NVarchar2);
                pYplx_code.Direction = ParameterDirection.Input;
                pYplx_code.Value = jc_ypParamCondition.Yplx_code;
                sqlparams.Add(pYplx_code);

            }

            if (null != jc_ypParamCondition.Ypmssyz && "" != jc_ypParamCondition.Ypmssyz)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" YPMSSYZ=:ypmssyz ");
                OracleParameter pYpmssyz = new OracleParameter(":ypmssyz", OracleDbType.NVarchar2);
                pYpmssyz.Direction = ParameterDirection.Input;
                pYpmssyz.Value = jc_ypParamCondition.Ypmssyz;
                sqlparams.Add(pYpmssyz);

            }

            if (null != jc_ypParamCondition.Ypmsjjz && "" != jc_ypParamCondition.Ypmsjjz)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" YPMSJJZ=:ypmsjjz ");
                OracleParameter pYpmsjjz = new OracleParameter(":ypmsjjz", OracleDbType.NVarchar2);
                pYpmsjjz.Direction = ParameterDirection.Input;
                pYpmsjjz.Value = jc_ypParamCondition.Ypmsjjz;
                sqlparams.Add(pYpmsjjz);

            }

            if (null != jc_ypParamCondition.Ypmsyfhbrqjy_code && "" != jc_ypParamCondition.Ypmsyfhbrqjy_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" YPMSYFHBRQJY_CODE=:ypmsyfhbrqjy_code ");
                OracleParameter pYpmsyfhbrqjy_code = new OracleParameter(":ypmsyfhbrqjy_code", OracleDbType.NVarchar2);
                pYpmsyfhbrqjy_code.Direction = ParameterDirection.Input;
                pYpmsyfhbrqjy_code.Value = jc_ypParamCondition.Ypmsyfhbrqjy_code;
                sqlparams.Add(pYpmsyfhbrqjy_code);

            }

            if (null != jc_ypParamCondition.Ypmsblfy && "" != jc_ypParamCondition.Ypmsblfy)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" YPMSBLFY=:ypmsblfy ");
                OracleParameter pYpmsblfy = new OracleParameter(":ypmsblfy", OracleDbType.NVarchar2);
                pYpmsblfy.Direction = ParameterDirection.Input;
                pYpmsblfy.Value = jc_ypParamCondition.Ypmsblfy;
                sqlparams.Add(pYpmsblfy);

            }

            if (null != jc_ypParamCondition.Ypfl_code && "" != jc_ypParamCondition.Ypfl_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" YPFL_CODE=:ypfl_code ");
                OracleParameter pYpfl_code = new OracleParameter(":ypfl_code", OracleDbType.NVarchar2);
                pYpfl_code.Direction = ParameterDirection.Input;
                pYpfl_code.Value = jc_ypParamCondition.Ypfl_code;
                sqlparams.Add(pYpfl_code);

            }

            if (null != jc_ypParamCondition.Yjjb_code && "" != jc_ypParamCondition.Yjjb_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" YJJB_CODE=:yjjb_code ");
                OracleParameter pYjjb_code = new OracleParameter(":yjjb_code", OracleDbType.NVarchar2);
                pYjjb_code.Direction = ParameterDirection.Input;
                pYjjb_code.Value = jc_ypParamCondition.Yjjb_code;
                sqlparams.Add(pYjjb_code);

            }

            if (null != jc_ypParamCondition.Txm && "" != jc_ypParamCondition.Txm)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" TXM=:txm ");
                OracleParameter pTxm = new OracleParameter(":txm", OracleDbType.NVarchar2);
                pTxm.Direction = ParameterDirection.Input;
                pTxm.Value = jc_ypParamCondition.Txm;
                sqlparams.Add(pTxm);

            }

            if (null != jc_ypParamCondition.Ewm && "" != jc_ypParamCondition.Ewm)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" EWM=:ewm ");
                OracleParameter pEwm = new OracleParameter(":ewm", OracleDbType.NVarchar2);
                pEwm.Direction = ParameterDirection.Input;
                pEwm.Value = jc_ypParamCondition.Ewm;
                sqlparams.Add(pEwm);

            }

            if (null != jc_ypParamCondition.Pym && "" != jc_ypParamCondition.Pym)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" PYM=:pym ");
                OracleParameter pPym = new OracleParameter(":pym", OracleDbType.NVarchar2);
                pPym.Direction = ParameterDirection.Input;
                pPym.Value = jc_ypParamCondition.Pym;
                sqlparams.Add(pPym);

            }

            if (null != jc_ypParamCondition.Hsxs)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" HSXS=:hsxs ");
                OracleParameter pHsxs = new OracleParameter(":hsxs", OracleDbType.Decimal);
                pHsxs.Direction = ParameterDirection.Input;
                pHsxs.Value = jc_ypParamCondition.Hsxs;
                sqlparams.Add(pHsxs);

            }

            if (null != jc_ypParamCondition.Sfcly_code && "" != jc_ypParamCondition.Sfcly_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" SFCLY_CODE=:sfcly_code ");
                OracleParameter pSfcly_code = new OracleParameter(":sfcly_code", OracleDbType.NVarchar2);
                pSfcly_code.Direction = ParameterDirection.Input;
                pSfcly_code.Value = jc_ypParamCondition.Sfcly_code;
                sqlparams.Add(pSfcly_code);

            }

            if (null != jc_ypParamCondition.Bzpfj)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" BZPFJ=:bzpfj ");
                OracleParameter pBzpfj = new OracleParameter(":bzpfj", OracleDbType.Decimal);
                pBzpfj.Direction = ParameterDirection.Input;
                pBzpfj.Value = jc_ypParamCondition.Bzpfj;
                sqlparams.Add(pBzpfj);

            }

            if (null != jc_ypParamCondition.Bzlsj)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" BZLSJ=:bzlsj ");
                OracleParameter pBzlsj = new OracleParameter(":bzlsj", OracleDbType.Decimal);
                pBzlsj.Direction = ParameterDirection.Input;
                pBzlsj.Value = jc_ypParamCondition.Bzlsj;
                sqlparams.Add(pBzlsj);

            }

            if (null != jc_ypParamCondition.Bzmzj)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" BZMZJ=:bzmzj ");
                OracleParameter pBzmzj = new OracleParameter(":bzmzj", OracleDbType.Decimal);
                pBzmzj.Direction = ParameterDirection.Input;
                pBzmzj.Value = jc_ypParamCondition.Bzmzj;
                sqlparams.Add(pBzmzj);

            }

            if (null != jc_ypParamCondition.Bzzyj)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" BZZYJ=:bzzyj ");
                OracleParameter pBzzyj = new OracleParameter(":bzzyj", OracleDbType.Decimal);
                pBzzyj.Direction = ParameterDirection.Input;
                pBzzyj.Value = jc_ypParamCondition.Bzzyj;
                sqlparams.Add(pBzzyj);

            }

            if (null != jc_ypParamCondition.Hsbl)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" HSBL=:hsbl ");
                OracleParameter pHsbl = new OracleParameter(":hsbl", OracleDbType.Decimal);
                pHsbl.Direction = ParameterDirection.Input;
                pHsbl.Value = jc_ypParamCondition.Hsbl;
                sqlparams.Add(pHsbl);

            }

            if (null != jc_ypParamCondition.Sfclm_code && "" != jc_ypParamCondition.Sfclm_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" SFCLM_CODE=:sfclm_code ");
                OracleParameter pSfclm_code = new OracleParameter(":sfclm_code", OracleDbType.NVarchar2);
                pSfclm_code.Direction = ParameterDirection.Input;
                pSfclm_code.Value = jc_ypParamCondition.Sfclm_code;
                sqlparams.Add(pSfclm_code);

            }

            if (null != jc_ypParamCondition.Yxzt_code && "" != jc_ypParamCondition.Yxzt_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" YXZT_CODE=:yxzt_code ");
                OracleParameter pYxzt_code = new OracleParameter(":yxzt_code", OracleDbType.NVarchar2);
                pYxzt_code.Direction = ParameterDirection.Input;
                pYxzt_code.Value = jc_ypParamCondition.Yxzt_code;
                sqlparams.Add(pYxzt_code);

            }

            if (null != jc_ypParamCondition.Dcsxyl)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" DCSXYL=:dcsxyl ");
                OracleParameter pDcsxyl = new OracleParameter(":dcsxyl", OracleDbType.Decimal);
                pDcsxyl.Direction = ParameterDirection.Input;
                pDcsxyl.Value = jc_ypParamCondition.Dcsxyl;
                sqlparams.Add(pDcsxyl);

            }

            if (null != jc_ypParamCondition.Dcxxyl)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" DCXXYL=:dcxxyl ");
                OracleParameter pDcxxyl = new OracleParameter(":dcxxyl", OracleDbType.Decimal);
                pDcxxyl.Direction = ParameterDirection.Input;
                pDcxxyl.Value = jc_ypParamCondition.Dcxxyl;
                sqlparams.Add(pDcxxyl);

            }

            if (null != jc_ypParamCondition.Lxylts)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" LXYLTS=:lxylts ");
                OracleParameter pLxylts = new OracleParameter(":lxylts", OracleDbType.Decimal);
                pLxylts.Direction = ParameterDirection.Input;
                pLxylts.Value = jc_ypParamCondition.Lxylts;
                sqlparams.Add(pLxylts);

            }

            if (null != jc_ypParamCondition.Lxylcs)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" LXYLCS=:lxylcs ");
                OracleParameter pLxylcs = new OracleParameter(":lxylcs", OracleDbType.Decimal);
                pLxylcs.Direction = ParameterDirection.Input;
                pLxylcs.Value = jc_ypParamCondition.Lxylcs;
                sqlparams.Add(pLxylcs);

            }

            if (null != jc_ypParamCondition.Scqy && "" != jc_ypParamCondition.Scqy)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" SCQY=:scqy ");
                OracleParameter pScqy = new OracleParameter(":scqy", OracleDbType.NVarchar2);
                pScqy.Direction = ParameterDirection.Input;
                pScqy.Value = jc_ypParamCondition.Scqy;
                sqlparams.Add(pScqy);

            }

            if (DateTime.MinValue != jc_ypParamCondition.Pzrq && null != jc_ypParamCondition.Pzrq)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" PZRQ=:pzrq ");
                OracleParameter pPzrq = new OracleParameter(":pzrq", OracleDbType.Date);
                pPzrq.Direction = ParameterDirection.Input;
                pPzrq.Value = jc_ypParamCondition.Pzrq;
                sqlparams.Add(pPzrq);

            }

            if (null != jc_ypParamCondition.Sfkss_code && "" != jc_ypParamCondition.Sfkss_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" SFKSS_CODE=:sfkss_code ");
                OracleParameter pSfkss_code = new OracleParameter(":sfkss_code", OracleDbType.NVarchar2);
                pSfkss_code.Direction = ParameterDirection.Input;
                pSfkss_code.Value = jc_ypParamCondition.Sfkss_code;
                sqlparams.Add(pSfkss_code);

            }

            if (null != jc_ypParamCondition.Zfbz && "" != jc_ypParamCondition.Zfbz)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" ZFBZ=:zfbz ");
                OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                pZfbz.Direction = ParameterDirection.Input;
                pZfbz.Value = jc_ypParamCondition.Zfbz;
                sqlparams.Add(pZfbz);

            }

            if (null != jc_ypParamCondition.Dcyldwbl)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" DCYLDWBL=:dcyldwbl ");
                OracleParameter pDcyldwbl = new OracleParameter(":dcyldwbl", OracleDbType.Decimal);
                pDcyldwbl.Direction = ParameterDirection.Input;
                pDcyldwbl.Value = jc_ypParamCondition.Dcyldwbl;
                sqlparams.Add(pDcyldwbl);

            }

            this.b_isComma = false;
            this.b_isWhere = false;
            bool result = false;
            int flag = OracleHelper.ExecuteNonQuery(sql.ToString(), con, sqlparams.ToArray());
            if (flag >= 0)
            {
                result = true;
            }

            return result;
        }




        /// <summary>
        /// 查找指定ID的用户
        /// </summary>
        /// <remarks>id为null、id重复、id未找到，抛异常</remarks>
        /// <returns>Jc_yp</returns>
        public Jc_yp findById(string id)
        {
            if ("" == id || null == id)
            {
                throw new Exception("ID不能为空，请赋值后调用；错误出自：findById");
            }
            StringBuilder sql = new StringBuilder("SELECT A.* ");
            //新建方法findContactObjectsById，在此加入多表连接要显示的项start
            //sql.Append(",B.字段一,B.字段二,B.字段三");
            //新建方法，在此加入多表连接要显示的项end
            sql.Append(" FROM JC_YP A ");
            //新建一个方法，在此加入多表连接的语句start
            //sql.Append("LEFT JOIN 外键表名 B ON A.外键=B.ID");
            //新建一个方法，在此加入多表连接的语句end
            sql.Append(" WHERE A.ID=:id ");
            OracleParameter pId = new OracleParameter(":id", OracleDbType.Varchar2);
            pId.Direction = ParameterDirection.Input;
            pId.Value = id;
            DataSet ds = OracleHelper.getDataSet(sql.ToString(), pId);
            DataRowCollection rows = ds.Tables[0].Rows;
            if (rows.Count > 1)
            {
                throw new Exception("此ID的数据有多个，主键不允许重复，请检查数据；错误出自：findById");
            }
            if (rows.Count == 0)
            {
                throw new Exception("此ID的数据不存在，请检查数据；错误出自：findById");
            }
            return this.dataSetToModel(rows[0]);
        }

        /// <summary>
        /// 根据用户传入的参数查询（id参数排除在外，如需查询id请使用findById方法）
        /// 第一个参数是查询参数，如果查询参数为null则查询所有
        /// 第二个参数是分页参数，传入带数据总行数的分页对象得到默认前PageSiz条数据（取决于page对象中的值），如果传null，则查出所有数据
        /// 第三个参数提供模糊查询功能，只适用于string类型的字段
        /// 第四个参数是排序的参数，传入排序的对象的集合，如果传null，则默认使用ID字段进行排序
        /// </summary>
        /// <param name="jc_ypParam"></param>
        /// <param name="page">分页对象</param>
        ///<param name="jc_ypParamLike">模糊查询参数</param>
        ///<param name="sortList">排序参数对象的集合</param>
        /// <returns>满足条件的所有Jc_yp对象集合list</returns>
        public List<object> find(Jc_yp jc_ypParam, Model.Common.PageInfo page, Jc_yp jc_ypParamLike, List<SortInfo> sortList)
        {

            //如果没有传查询条件参数，就new一个空的Jc_yp对象，标示查询所有数据
            if (null == jc_ypParam)
            {
                jc_ypParam = new Jc_yp();
            }
            if (null != jc_ypParam.Id && "" != jc_ypParam.Id)
            {
                throw new Exception("此方法不允许指定参数ID，如果需要根据ID查询数据，请调用findById方法；错误出自：find");
            }
            List<Jc_yp> jc_ypParamList = new List<Jc_yp>();//接收查询出的Jc_yp对象集合
            List<OracleParameter> sqlparams = new List<OracleParameter>();//保存参数的集合
            StringBuilder sql = new StringBuilder("SELECT A.* ");
            //新建方法findContactObjects(Jc_yp jc_ypParam, Model.Common.PageInfo page)，在此加入多表连接要显示的项start
            //sql.Append(",B.字段一,B.字段二,B.字段三");
            //新建方法，在此加入多表连接要显示的项end
            sql.Append(" FROM JC_YP A ");
            //新建一个方法，在此加入多表连接的语句start
            ////sql.Append(" LEFT JOIN 表名 B ON A.外键=B.ID");
            //新建一个方法，在此加入多表连接的语句end


            if (null != jc_ypParam.Ypbm && "" != jc_ypParam.Ypbm)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.YPBM=:ypbm ");
                OracleParameter pYpbm = new OracleParameter(":ypbm", OracleDbType.NVarchar2);
                pYpbm.Direction = ParameterDirection.Input;
                pYpbm.Value = jc_ypParam.Ypbm;
                sqlparams.Add(pYpbm);
            }

            if (null != jc_ypParam.Ypmc && "" != jc_ypParam.Ypmc)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.YPMC=:ypmc ");
                OracleParameter pYpmc = new OracleParameter(":ypmc", OracleDbType.NVarchar2);
                pYpmc.Direction = ParameterDirection.Input;
                pYpmc.Value = jc_ypParam.Ypmc;
                sqlparams.Add(pYpmc);
            }

            if (null != jc_ypParam.Yptymc && "" != jc_ypParam.Yptymc)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.YPTYMC=:yptymc ");
                OracleParameter pYptymc = new OracleParameter(":yptymc", OracleDbType.NVarchar2);
                pYptymc.Direction = ParameterDirection.Input;
                pYptymc.Value = jc_ypParam.Yptymc;
                sqlparams.Add(pYptymc);
            }

            if (null != jc_ypParam.Ypcf && "" != jc_ypParam.Ypcf)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.YPCF=:ypcf ");
                OracleParameter pYpcf = new OracleParameter(":ypcf", OracleDbType.NVarchar2);
                pYpcf.Direction = ParameterDirection.Input;
                pYpcf.Value = jc_ypParam.Ypcf;
                sqlparams.Add(pYpcf);
            }

            if (null != jc_ypParam.Yppzwh && "" != jc_ypParam.Yppzwh)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.YPPZWH=:yppzwh ");
                OracleParameter pYppzwh = new OracleParameter(":yppzwh", OracleDbType.NVarchar2);
                pYppzwh.Direction = ParameterDirection.Input;
                pYppzwh.Value = jc_ypParam.Yppzwh;
                sqlparams.Add(pYppzwh);
            }

            if (null != jc_ypParam.Ypzczh && "" != jc_ypParam.Ypzczh)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.YPZCZH=:ypzczh ");
                OracleParameter pYpzczh = new OracleParameter(":ypzczh", OracleDbType.NVarchar2);
                pYpzczh.Direction = ParameterDirection.Input;
                pYpzczh.Value = jc_ypParam.Ypzczh;
                sqlparams.Add(pYpzczh);
            }

            if (null != jc_ypParam.Gyzz && "" != jc_ypParam.Gyzz)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.GYZZ=:gyzz ");
                OracleParameter pGyzz = new OracleParameter(":gyzz", OracleDbType.NVarchar2);
                pGyzz.Direction = ParameterDirection.Input;
                pGyzz.Value = jc_ypParam.Gyzz;
                sqlparams.Add(pGyzz);
            }

            if (null != jc_ypParam.Ypjx_code && "" != jc_ypParam.Ypjx_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.YPJX_CODE=:ypjx_code ");
                OracleParameter pYpjx_code = new OracleParameter(":ypjx_code", OracleDbType.NVarchar2);
                pYpjx_code.Direction = ParameterDirection.Input;
                pYpjx_code.Value = jc_ypParam.Ypjx_code;
                sqlparams.Add(pYpjx_code);
            }

            if (null != jc_ypParam.Ypgg && "" != jc_ypParam.Ypgg)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.YPGG=:ypgg ");
                OracleParameter pYpgg = new OracleParameter(":ypgg", OracleDbType.NVarchar2);
                pYpgg.Direction = ParameterDirection.Input;
                pYpgg.Value = jc_ypParam.Ypgg;
                sqlparams.Add(pYpgg);
            }

            if (null != jc_ypParam.Ypdcyl)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.YPDCYL=:ypdcyl ");
                OracleParameter pYpdcyl = new OracleParameter(":ypdcyl", OracleDbType.Decimal);
                pYpdcyl.Direction = ParameterDirection.Input;
                pYpdcyl.Value = jc_ypParam.Ypdcyl;
                sqlparams.Add(pYpdcyl);

            }

            if (null != jc_ypParam.Ypdcyldw_code && "" != jc_ypParam.Ypdcyldw_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.YPDCYLDW_CODE=:ypdcyldw_code ");
                OracleParameter pYpdcyldw_code = new OracleParameter(":ypdcyldw_code", OracleDbType.NVarchar2);
                pYpdcyldw_code.Direction = ParameterDirection.Input;
                pYpdcyldw_code.Value = jc_ypParam.Ypdcyldw_code;
                sqlparams.Add(pYpdcyldw_code);
            }

            if (null != jc_ypParam.Ypyytj_code && "" != jc_ypParam.Ypyytj_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.YPYYTJ_CODE=:ypyytj_code ");
                OracleParameter pYpyytj_code = new OracleParameter(":ypyytj_code", OracleDbType.NVarchar2);
                pYpyytj_code.Direction = ParameterDirection.Input;
                pYpyytj_code.Value = jc_ypParam.Ypyytj_code;
                sqlparams.Add(pYpyytj_code);
            }

            if (null != jc_ypParam.Ddw_code && "" != jc_ypParam.Ddw_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.DDW_CODE=:ddw_code ");
                OracleParameter pDdw_code = new OracleParameter(":ddw_code", OracleDbType.NVarchar2);
                pDdw_code.Direction = ParameterDirection.Input;
                pDdw_code.Value = jc_ypParam.Ddw_code;
                sqlparams.Add(pDdw_code);
            }

            if (null != jc_ypParam.Xdw_code && "" != jc_ypParam.Xdw_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.XDW_CODE=:xdw_code ");
                OracleParameter pXdw_code = new OracleParameter(":xdw_code", OracleDbType.NVarchar2);
                pXdw_code.Direction = ParameterDirection.Input;
                pXdw_code.Value = jc_ypParam.Xdw_code;
                sqlparams.Add(pXdw_code);
            }

            if (null != jc_ypParam.Cfybz_code && "" != jc_ypParam.Cfybz_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.CFYBZ_CODE=:cfybz_code ");
                OracleParameter pCfybz_code = new OracleParameter(":cfybz_code", OracleDbType.NVarchar2);
                pCfybz_code.Direction = ParameterDirection.Input;
                pCfybz_code.Value = jc_ypParam.Cfybz_code;
                sqlparams.Add(pCfybz_code);
            }

            if (null != jc_ypParam.Cfqxjy_code && "" != jc_ypParam.Cfqxjy_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.CFQXJY_CODE=:cfqxjy_code ");
                OracleParameter pCfqxjy_code = new OracleParameter(":cfqxjy_code", OracleDbType.NVarchar2);
                pCfqxjy_code.Direction = ParameterDirection.Input;
                pCfqxjy_code.Value = jc_ypParam.Cfqxjy_code;
                sqlparams.Add(pCfqxjy_code);
            }

            if (null != jc_ypParam.Cfqxyb_code && "" != jc_ypParam.Cfqxyb_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.CFQXYB_CODE=:cfqxyb_code ");
                OracleParameter pCfqxyb_code = new OracleParameter(":cfqxyb_code", OracleDbType.NVarchar2);
                pCfqxyb_code.Direction = ParameterDirection.Input;
                pCfqxyb_code.Value = jc_ypParam.Cfqxyb_code;
                sqlparams.Add(pCfqxyb_code);
            }

            if (null != jc_ypParam.Cfqxdm_code && "" != jc_ypParam.Cfqxdm_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.CFQXDM_CODE=:cfqxdm_code ");
                OracleParameter pCfqxdm_code = new OracleParameter(":cfqxdm_code", OracleDbType.NVarchar2);
                pCfqxdm_code.Direction = ParameterDirection.Input;
                pCfqxdm_code.Value = jc_ypParam.Cfqxdm_code;
                sqlparams.Add(pCfqxdm_code);
            }

            if (null != jc_ypParam.Cfqxjs_code && "" != jc_ypParam.Cfqxjs_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.CFQXJS_CODE=:cfqxjs_code ");
                OracleParameter pCfqxjs_code = new OracleParameter(":cfqxjs_code", OracleDbType.NVarchar2);
                pCfqxjs_code.Direction = ParameterDirection.Input;
                pCfqxjs_code.Value = jc_ypParam.Cfqxjs_code;
                sqlparams.Add(pCfqxjs_code);
            }

            if (null != jc_ypParam.Cfqxgz_code && "" != jc_ypParam.Cfqxgz_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.CFQXGZ_CODE=:cfqxgz_code ");
                OracleParameter pCfqxgz_code = new OracleParameter(":cfqxgz_code", OracleDbType.NVarchar2);
                pCfqxgz_code.Direction = ParameterDirection.Input;
                pCfqxgz_code.Value = jc_ypParam.Cfqxgz_code;
                sqlparams.Add(pCfqxgz_code);
            }

            if (null != jc_ypParam.Cfqxjk_code && "" != jc_ypParam.Cfqxjk_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.CFQXJK_CODE=:cfqxjk_code ");
                OracleParameter pCfqxjk_code = new OracleParameter(":cfqxjk_code", OracleDbType.NVarchar2);
                pCfqxjk_code.Direction = ParameterDirection.Input;
                pCfqxjk_code.Value = jc_ypParam.Cfqxjk_code;
                sqlparams.Add(pCfqxjk_code);
            }

            if (null != jc_ypParam.Cfqxzz_code && "" != jc_ypParam.Cfqxzz_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.CFQXZZ_CODE=:cfqxzz_code ");
                OracleParameter pCfqxzz_code = new OracleParameter(":cfqxzz_code", OracleDbType.NVarchar2);
                pCfqxzz_code.Direction = ParameterDirection.Input;
                pCfqxzz_code.Value = jc_ypParam.Cfqxzz_code;
                sqlparams.Add(pCfqxzz_code);
            }

            if (null != jc_ypParam.Cfqxzf_code && "" != jc_ypParam.Cfqxzf_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.CFQXZF_CODE=:cfqxzf_code ");
                OracleParameter pCfqxzf_code = new OracleParameter(":cfqxzf_code", OracleDbType.NVarchar2);
                pCfqxzf_code.Direction = ParameterDirection.Input;
                pCfqxzf_code.Value = jc_ypParam.Cfqxzf_code;
                sqlparams.Add(pCfqxzf_code);
            }

            if (null != jc_ypParam.Cfqxts_code && "" != jc_ypParam.Cfqxts_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.CFQXTS_CODE=:cfqxts_code ");
                OracleParameter pCfqxts_code = new OracleParameter(":cfqxts_code", OracleDbType.NVarchar2);
                pCfqxts_code.Direction = ParameterDirection.Input;
                pCfqxts_code.Value = jc_ypParam.Cfqxts_code;
                sqlparams.Add(pCfqxts_code);
            }

            if (null != jc_ypParam.Ps_code && "" != jc_ypParam.Ps_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.PS_CODE=:ps_code ");
                OracleParameter pPs_code = new OracleParameter(":ps_code", OracleDbType.NVarchar2);
                pPs_code.Direction = ParameterDirection.Input;
                pPs_code.Value = jc_ypParam.Ps_code;
                sqlparams.Add(pPs_code);
            }

            if (null != jc_ypParam.Yplx_code && "" != jc_ypParam.Yplx_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.YPLX_CODE=:yplx_code ");
                OracleParameter pYplx_code = new OracleParameter(":yplx_code", OracleDbType.NVarchar2);
                pYplx_code.Direction = ParameterDirection.Input;
                pYplx_code.Value = jc_ypParam.Yplx_code;
                sqlparams.Add(pYplx_code);
            }

            if (null != jc_ypParam.Ypmssyz && "" != jc_ypParam.Ypmssyz)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.YPMSSYZ=:ypmssyz ");
                OracleParameter pYpmssyz = new OracleParameter(":ypmssyz", OracleDbType.NVarchar2);
                pYpmssyz.Direction = ParameterDirection.Input;
                pYpmssyz.Value = jc_ypParam.Ypmssyz;
                sqlparams.Add(pYpmssyz);
            }

            if (null != jc_ypParam.Ypmsjjz && "" != jc_ypParam.Ypmsjjz)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.YPMSJJZ=:ypmsjjz ");
                OracleParameter pYpmsjjz = new OracleParameter(":ypmsjjz", OracleDbType.NVarchar2);
                pYpmsjjz.Direction = ParameterDirection.Input;
                pYpmsjjz.Value = jc_ypParam.Ypmsjjz;
                sqlparams.Add(pYpmsjjz);
            }

            if (null != jc_ypParam.Ypmsyfhbrqjy_code && "" != jc_ypParam.Ypmsyfhbrqjy_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.YPMSYFHBRQJY_CODE=:ypmsyfhbrqjy_code ");
                OracleParameter pYpmsyfhbrqjy_code = new OracleParameter(":ypmsyfhbrqjy_code", OracleDbType.NVarchar2);
                pYpmsyfhbrqjy_code.Direction = ParameterDirection.Input;
                pYpmsyfhbrqjy_code.Value = jc_ypParam.Ypmsyfhbrqjy_code;
                sqlparams.Add(pYpmsyfhbrqjy_code);
            }

            if (null != jc_ypParam.Ypmsblfy && "" != jc_ypParam.Ypmsblfy)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.YPMSBLFY=:ypmsblfy ");
                OracleParameter pYpmsblfy = new OracleParameter(":ypmsblfy", OracleDbType.NVarchar2);
                pYpmsblfy.Direction = ParameterDirection.Input;
                pYpmsblfy.Value = jc_ypParam.Ypmsblfy;
                sqlparams.Add(pYpmsblfy);
            }

            if (null != jc_ypParam.Ypfl_code && "" != jc_ypParam.Ypfl_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.YPFL_CODE=:ypfl_code ");
                OracleParameter pYpfl_code = new OracleParameter(":ypfl_code", OracleDbType.NVarchar2);
                pYpfl_code.Direction = ParameterDirection.Input;
                pYpfl_code.Value = jc_ypParam.Ypfl_code;
                sqlparams.Add(pYpfl_code);
            }

            if (null != jc_ypParam.Yjjb_code && "" != jc_ypParam.Yjjb_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.YJJB_CODE=:yjjb_code ");
                OracleParameter pYjjb_code = new OracleParameter(":yjjb_code", OracleDbType.NVarchar2);
                pYjjb_code.Direction = ParameterDirection.Input;
                pYjjb_code.Value = jc_ypParam.Yjjb_code;
                sqlparams.Add(pYjjb_code);
            }

            if (null != jc_ypParam.Txm && "" != jc_ypParam.Txm)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.TXM=:txm ");
                OracleParameter pTxm = new OracleParameter(":txm", OracleDbType.NVarchar2);
                pTxm.Direction = ParameterDirection.Input;
                pTxm.Value = jc_ypParam.Txm;
                sqlparams.Add(pTxm);
            }

            if (null != jc_ypParam.Ewm && "" != jc_ypParam.Ewm)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.EWM=:ewm ");
                OracleParameter pEwm = new OracleParameter(":ewm", OracleDbType.NVarchar2);
                pEwm.Direction = ParameterDirection.Input;
                pEwm.Value = jc_ypParam.Ewm;
                sqlparams.Add(pEwm);
            }

            if (null != jc_ypParam.Pym && "" != jc_ypParam.Pym)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.PYM=:pym ");
                OracleParameter pPym = new OracleParameter(":pym", OracleDbType.NVarchar2);
                pPym.Direction = ParameterDirection.Input;
                pPym.Value = jc_ypParam.Pym;
                sqlparams.Add(pPym);
            }

            if (null != jc_ypParam.Hsxs)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.HSXS=:hsxs ");
                OracleParameter pHsxs = new OracleParameter(":hsxs", OracleDbType.Decimal);
                pHsxs.Direction = ParameterDirection.Input;
                pHsxs.Value = jc_ypParam.Hsxs;
                sqlparams.Add(pHsxs);

            }

            if (null != jc_ypParam.Sfcly_code && "" != jc_ypParam.Sfcly_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.SFCLY_CODE=:sfcly_code ");
                OracleParameter pSfcly_code = new OracleParameter(":sfcly_code", OracleDbType.NVarchar2);
                pSfcly_code.Direction = ParameterDirection.Input;
                pSfcly_code.Value = jc_ypParam.Sfcly_code;
                sqlparams.Add(pSfcly_code);
            }

            if (null != jc_ypParam.Bzpfj)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.BZPFJ=:bzpfj ");
                OracleParameter pBzpfj = new OracleParameter(":bzpfj", OracleDbType.Decimal);
                pBzpfj.Direction = ParameterDirection.Input;
                pBzpfj.Value = jc_ypParam.Bzpfj;
                sqlparams.Add(pBzpfj);

            }

            if (null != jc_ypParam.Bzlsj)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.BZLSJ=:bzlsj ");
                OracleParameter pBzlsj = new OracleParameter(":bzlsj", OracleDbType.Decimal);
                pBzlsj.Direction = ParameterDirection.Input;
                pBzlsj.Value = jc_ypParam.Bzlsj;
                sqlparams.Add(pBzlsj);

            }

            if (null != jc_ypParam.Bzmzj)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.BZMZJ=:bzmzj ");
                OracleParameter pBzmzj = new OracleParameter(":bzmzj", OracleDbType.Decimal);
                pBzmzj.Direction = ParameterDirection.Input;
                pBzmzj.Value = jc_ypParam.Bzmzj;
                sqlparams.Add(pBzmzj);

            }

            if (null != jc_ypParam.Bzzyj)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.BZZYJ=:bzzyj ");
                OracleParameter pBzzyj = new OracleParameter(":bzzyj", OracleDbType.Decimal);
                pBzzyj.Direction = ParameterDirection.Input;
                pBzzyj.Value = jc_ypParam.Bzzyj;
                sqlparams.Add(pBzzyj);

            }

            if (null != jc_ypParam.Hsbl)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.HSBL=:hsbl ");
                OracleParameter pHsbl = new OracleParameter(":hsbl", OracleDbType.Decimal);
                pHsbl.Direction = ParameterDirection.Input;
                pHsbl.Value = jc_ypParam.Hsbl;
                sqlparams.Add(pHsbl);

            }

            if (null != jc_ypParam.Sfclm_code && "" != jc_ypParam.Sfclm_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.SFCLM_CODE=:sfclm_code ");
                OracleParameter pSfclm_code = new OracleParameter(":sfclm_code", OracleDbType.NVarchar2);
                pSfclm_code.Direction = ParameterDirection.Input;
                pSfclm_code.Value = jc_ypParam.Sfclm_code;
                sqlparams.Add(pSfclm_code);
            }

            if (null != jc_ypParam.Yxzt_code && "" != jc_ypParam.Yxzt_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.YXZT_CODE=:yxzt_code ");
                OracleParameter pYxzt_code = new OracleParameter(":yxzt_code", OracleDbType.NVarchar2);
                pYxzt_code.Direction = ParameterDirection.Input;
                pYxzt_code.Value = jc_ypParam.Yxzt_code;
                sqlparams.Add(pYxzt_code);
            }

            if (null != jc_ypParam.Dcsxyl)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.DCSXYL=:dcsxyl ");
                OracleParameter pDcsxyl = new OracleParameter(":dcsxyl", OracleDbType.Decimal);
                pDcsxyl.Direction = ParameterDirection.Input;
                pDcsxyl.Value = jc_ypParam.Dcsxyl;
                sqlparams.Add(pDcsxyl);

            }

            if (null != jc_ypParam.Dcxxyl)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.DCXXYL=:dcxxyl ");
                OracleParameter pDcxxyl = new OracleParameter(":dcxxyl", OracleDbType.Decimal);
                pDcxxyl.Direction = ParameterDirection.Input;
                pDcxxyl.Value = jc_ypParam.Dcxxyl;
                sqlparams.Add(pDcxxyl);

            }

            if (null != jc_ypParam.Lxylts)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.LXYLTS=:lxylts ");
                OracleParameter pLxylts = new OracleParameter(":lxylts", OracleDbType.Decimal);
                pLxylts.Direction = ParameterDirection.Input;
                pLxylts.Value = jc_ypParam.Lxylts;
                sqlparams.Add(pLxylts);

            }

            if (null != jc_ypParam.Lxylcs)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.LXYLCS=:lxylcs ");
                OracleParameter pLxylcs = new OracleParameter(":lxylcs", OracleDbType.Decimal);
                pLxylcs.Direction = ParameterDirection.Input;
                pLxylcs.Value = jc_ypParam.Lxylcs;
                sqlparams.Add(pLxylcs);

            }

            if (null != jc_ypParam.Scqy && "" != jc_ypParam.Scqy)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.SCQY=:scqy ");
                OracleParameter pScqy = new OracleParameter(":scqy", OracleDbType.NVarchar2);
                pScqy.Direction = ParameterDirection.Input;
                pScqy.Value = jc_ypParam.Scqy;
                sqlparams.Add(pScqy);
            }

            if (DateTime.MinValue != jc_ypParam.Pzrq && null != jc_ypParam.Pzrq)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.PZRQ=:pzrq ");
                OracleParameter pPzrq = new OracleParameter(":pzrq", OracleDbType.Date);
                pPzrq.Direction = ParameterDirection.Input;
                pPzrq.Value = jc_ypParam.Pzrq;
                sqlparams.Add(pPzrq);
            }

            if (null != jc_ypParam.Sfkss_code && "" != jc_ypParam.Sfkss_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.SFKSS_CODE=:sfkss_code ");
                OracleParameter pSfkss_code = new OracleParameter(":sfkss_code", OracleDbType.NVarchar2);
                pSfkss_code.Direction = ParameterDirection.Input;
                pSfkss_code.Value = jc_ypParam.Sfkss_code;
                sqlparams.Add(pSfkss_code);
            }

            if (null != jc_ypParam.Zfbz && "" != jc_ypParam.Zfbz)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.ZFBZ=:zfbz ");
                OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                pZfbz.Direction = ParameterDirection.Input;
                pZfbz.Value = jc_ypParam.Zfbz;
                sqlparams.Add(pZfbz);
            }

            if (null != jc_ypParam.Dcyldwbl)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.DCYLDWBL=:dcyldwbl ");
                OracleParameter pDcyldwbl = new OracleParameter(":dcyldwbl", OracleDbType.Decimal);
                pDcyldwbl.Direction = ParameterDirection.Input;
                pDcyldwbl.Value = jc_ypParam.Dcyldwbl;
                sqlparams.Add(pDcyldwbl);

            }

            if (jc_ypParamLike != null)
            {

                if (null != jc_ypParamLike.Ypbm && "" != jc_ypParamLike.Ypbm)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YPBM LIKE '%'||:ypbm||'%' ");
                    OracleParameter pYpbm = new OracleParameter(":ypbm", OracleDbType.NVarchar2);
                    pYpbm.Direction = ParameterDirection.Input;
                    pYpbm.Value = jc_ypParamLike.Ypbm;
                    sqlparams.Add(pYpbm);
                }

                if (null != jc_ypParamLike.Ypmc && "" != jc_ypParamLike.Ypmc)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YPMC LIKE '%'||:ypmc||'%' ");
                    OracleParameter pYpmc = new OracleParameter(":ypmc", OracleDbType.NVarchar2);
                    pYpmc.Direction = ParameterDirection.Input;
                    pYpmc.Value = jc_ypParamLike.Ypmc;
                    sqlparams.Add(pYpmc);
                }

                if (null != jc_ypParamLike.Yptymc && "" != jc_ypParamLike.Yptymc)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YPTYMC LIKE '%'||:yptymc||'%' ");
                    OracleParameter pYptymc = new OracleParameter(":yptymc", OracleDbType.NVarchar2);
                    pYptymc.Direction = ParameterDirection.Input;
                    pYptymc.Value = jc_ypParamLike.Yptymc;
                    sqlparams.Add(pYptymc);
                }

                if (null != jc_ypParamLike.Ypcf && "" != jc_ypParamLike.Ypcf)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YPCF LIKE '%'||:ypcf||'%' ");
                    OracleParameter pYpcf = new OracleParameter(":ypcf", OracleDbType.NVarchar2);
                    pYpcf.Direction = ParameterDirection.Input;
                    pYpcf.Value = jc_ypParamLike.Ypcf;
                    sqlparams.Add(pYpcf);
                }

                if (null != jc_ypParamLike.Yppzwh && "" != jc_ypParamLike.Yppzwh)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YPPZWH LIKE '%'||:yppzwh||'%' ");
                    OracleParameter pYppzwh = new OracleParameter(":yppzwh", OracleDbType.NVarchar2);
                    pYppzwh.Direction = ParameterDirection.Input;
                    pYppzwh.Value = jc_ypParamLike.Yppzwh;
                    sqlparams.Add(pYppzwh);
                }

                if (null != jc_ypParamLike.Ypzczh && "" != jc_ypParamLike.Ypzczh)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YPZCZH LIKE '%'||:ypzczh||'%' ");
                    OracleParameter pYpzczh = new OracleParameter(":ypzczh", OracleDbType.NVarchar2);
                    pYpzczh.Direction = ParameterDirection.Input;
                    pYpzczh.Value = jc_ypParamLike.Ypzczh;
                    sqlparams.Add(pYpzczh);
                }

                if (null != jc_ypParamLike.Gyzz && "" != jc_ypParamLike.Gyzz)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.GYZZ LIKE '%'||:gyzz||'%' ");
                    OracleParameter pGyzz = new OracleParameter(":gyzz", OracleDbType.NVarchar2);
                    pGyzz.Direction = ParameterDirection.Input;
                    pGyzz.Value = jc_ypParamLike.Gyzz;
                    sqlparams.Add(pGyzz);
                }

                if (null != jc_ypParamLike.Ypjx_code && "" != jc_ypParamLike.Ypjx_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YPJX_CODE LIKE '%'||:ypjx_code||'%' ");
                    OracleParameter pYpjx_code = new OracleParameter(":ypjx_code", OracleDbType.NVarchar2);
                    pYpjx_code.Direction = ParameterDirection.Input;
                    pYpjx_code.Value = jc_ypParamLike.Ypjx_code;
                    sqlparams.Add(pYpjx_code);
                }

                if (null != jc_ypParamLike.Ypgg && "" != jc_ypParamLike.Ypgg)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YPGG LIKE '%'||:ypgg||'%' ");
                    OracleParameter pYpgg = new OracleParameter(":ypgg", OracleDbType.NVarchar2);
                    pYpgg.Direction = ParameterDirection.Input;
                    pYpgg.Value = jc_ypParamLike.Ypgg;
                    sqlparams.Add(pYpgg);
                }

                if (null != jc_ypParamLike.Ypdcyldw_code && "" != jc_ypParamLike.Ypdcyldw_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YPDCYLDW_CODE LIKE '%'||:ypdcyldw_code||'%' ");
                    OracleParameter pYpdcyldw_code = new OracleParameter(":ypdcyldw_code", OracleDbType.NVarchar2);
                    pYpdcyldw_code.Direction = ParameterDirection.Input;
                    pYpdcyldw_code.Value = jc_ypParamLike.Ypdcyldw_code;
                    sqlparams.Add(pYpdcyldw_code);
                }

                if (null != jc_ypParamLike.Ypyytj_code && "" != jc_ypParamLike.Ypyytj_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YPYYTJ_CODE LIKE '%'||:ypyytj_code||'%' ");
                    OracleParameter pYpyytj_code = new OracleParameter(":ypyytj_code", OracleDbType.NVarchar2);
                    pYpyytj_code.Direction = ParameterDirection.Input;
                    pYpyytj_code.Value = jc_ypParamLike.Ypyytj_code;
                    sqlparams.Add(pYpyytj_code);
                }

                if (null != jc_ypParamLike.Ddw_code && "" != jc_ypParamLike.Ddw_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.DDW_CODE LIKE '%'||:ddw_code||'%' ");
                    OracleParameter pDdw_code = new OracleParameter(":ddw_code", OracleDbType.NVarchar2);
                    pDdw_code.Direction = ParameterDirection.Input;
                    pDdw_code.Value = jc_ypParamLike.Ddw_code;
                    sqlparams.Add(pDdw_code);
                }

                if (null != jc_ypParamLike.Xdw_code && "" != jc_ypParamLike.Xdw_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.XDW_CODE LIKE '%'||:xdw_code||'%' ");
                    OracleParameter pXdw_code = new OracleParameter(":xdw_code", OracleDbType.NVarchar2);
                    pXdw_code.Direction = ParameterDirection.Input;
                    pXdw_code.Value = jc_ypParamLike.Xdw_code;
                    sqlparams.Add(pXdw_code);
                }

                if (null != jc_ypParamLike.Cfybz_code && "" != jc_ypParamLike.Cfybz_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.CFYBZ_CODE LIKE '%'||:cfybz_code||'%' ");
                    OracleParameter pCfybz_code = new OracleParameter(":cfybz_code", OracleDbType.NVarchar2);
                    pCfybz_code.Direction = ParameterDirection.Input;
                    pCfybz_code.Value = jc_ypParamLike.Cfybz_code;
                    sqlparams.Add(pCfybz_code);
                }

                if (null != jc_ypParamLike.Cfqxjy_code && "" != jc_ypParamLike.Cfqxjy_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.CFQXJY_CODE LIKE '%'||:cfqxjy_code||'%' ");
                    OracleParameter pCfqxjy_code = new OracleParameter(":cfqxjy_code", OracleDbType.NVarchar2);
                    pCfqxjy_code.Direction = ParameterDirection.Input;
                    pCfqxjy_code.Value = jc_ypParamLike.Cfqxjy_code;
                    sqlparams.Add(pCfqxjy_code);
                }

                if (null != jc_ypParamLike.Cfqxyb_code && "" != jc_ypParamLike.Cfqxyb_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.CFQXYB_CODE LIKE '%'||:cfqxyb_code||'%' ");
                    OracleParameter pCfqxyb_code = new OracleParameter(":cfqxyb_code", OracleDbType.NVarchar2);
                    pCfqxyb_code.Direction = ParameterDirection.Input;
                    pCfqxyb_code.Value = jc_ypParamLike.Cfqxyb_code;
                    sqlparams.Add(pCfqxyb_code);
                }

                if (null != jc_ypParamLike.Cfqxdm_code && "" != jc_ypParamLike.Cfqxdm_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.CFQXDM_CODE LIKE '%'||:cfqxdm_code||'%' ");
                    OracleParameter pCfqxdm_code = new OracleParameter(":cfqxdm_code", OracleDbType.NVarchar2);
                    pCfqxdm_code.Direction = ParameterDirection.Input;
                    pCfqxdm_code.Value = jc_ypParamLike.Cfqxdm_code;
                    sqlparams.Add(pCfqxdm_code);
                }

                if (null != jc_ypParamLike.Cfqxjs_code && "" != jc_ypParamLike.Cfqxjs_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.CFQXJS_CODE LIKE '%'||:cfqxjs_code||'%' ");
                    OracleParameter pCfqxjs_code = new OracleParameter(":cfqxjs_code", OracleDbType.NVarchar2);
                    pCfqxjs_code.Direction = ParameterDirection.Input;
                    pCfqxjs_code.Value = jc_ypParamLike.Cfqxjs_code;
                    sqlparams.Add(pCfqxjs_code);
                }

                if (null != jc_ypParamLike.Cfqxgz_code && "" != jc_ypParamLike.Cfqxgz_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.CFQXGZ_CODE LIKE '%'||:cfqxgz_code||'%' ");
                    OracleParameter pCfqxgz_code = new OracleParameter(":cfqxgz_code", OracleDbType.NVarchar2);
                    pCfqxgz_code.Direction = ParameterDirection.Input;
                    pCfqxgz_code.Value = jc_ypParamLike.Cfqxgz_code;
                    sqlparams.Add(pCfqxgz_code);
                }

                if (null != jc_ypParamLike.Cfqxjk_code && "" != jc_ypParamLike.Cfqxjk_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.CFQXJK_CODE LIKE '%'||:cfqxjk_code||'%' ");
                    OracleParameter pCfqxjk_code = new OracleParameter(":cfqxjk_code", OracleDbType.NVarchar2);
                    pCfqxjk_code.Direction = ParameterDirection.Input;
                    pCfqxjk_code.Value = jc_ypParamLike.Cfqxjk_code;
                    sqlparams.Add(pCfqxjk_code);
                }

                if (null != jc_ypParamLike.Cfqxzz_code && "" != jc_ypParamLike.Cfqxzz_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.CFQXZZ_CODE LIKE '%'||:cfqxzz_code||'%' ");
                    OracleParameter pCfqxzz_code = new OracleParameter(":cfqxzz_code", OracleDbType.NVarchar2);
                    pCfqxzz_code.Direction = ParameterDirection.Input;
                    pCfqxzz_code.Value = jc_ypParamLike.Cfqxzz_code;
                    sqlparams.Add(pCfqxzz_code);
                }

                if (null != jc_ypParamLike.Cfqxzf_code && "" != jc_ypParamLike.Cfqxzf_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.CFQXZF_CODE LIKE '%'||:cfqxzf_code||'%' ");
                    OracleParameter pCfqxzf_code = new OracleParameter(":cfqxzf_code", OracleDbType.NVarchar2);
                    pCfqxzf_code.Direction = ParameterDirection.Input;
                    pCfqxzf_code.Value = jc_ypParamLike.Cfqxzf_code;
                    sqlparams.Add(pCfqxzf_code);
                }

                if (null != jc_ypParamLike.Cfqxts_code && "" != jc_ypParamLike.Cfqxts_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.CFQXTS_CODE LIKE '%'||:cfqxts_code||'%' ");
                    OracleParameter pCfqxts_code = new OracleParameter(":cfqxts_code", OracleDbType.NVarchar2);
                    pCfqxts_code.Direction = ParameterDirection.Input;
                    pCfqxts_code.Value = jc_ypParamLike.Cfqxts_code;
                    sqlparams.Add(pCfqxts_code);
                }

                if (null != jc_ypParamLike.Ps_code && "" != jc_ypParamLike.Ps_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.PS_CODE LIKE '%'||:ps_code||'%' ");
                    OracleParameter pPs_code = new OracleParameter(":ps_code", OracleDbType.NVarchar2);
                    pPs_code.Direction = ParameterDirection.Input;
                    pPs_code.Value = jc_ypParamLike.Ps_code;
                    sqlparams.Add(pPs_code);
                }

                if (null != jc_ypParamLike.Yplx_code && "" != jc_ypParamLike.Yplx_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YPLX_CODE LIKE '%'||:yplx_code||'%' ");
                    OracleParameter pYplx_code = new OracleParameter(":yplx_code", OracleDbType.NVarchar2);
                    pYplx_code.Direction = ParameterDirection.Input;
                    pYplx_code.Value = jc_ypParamLike.Yplx_code;
                    sqlparams.Add(pYplx_code);
                }

                if (null != jc_ypParamLike.Ypmssyz && "" != jc_ypParamLike.Ypmssyz)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YPMSSYZ LIKE '%'||:ypmssyz||'%' ");
                    OracleParameter pYpmssyz = new OracleParameter(":ypmssyz", OracleDbType.NVarchar2);
                    pYpmssyz.Direction = ParameterDirection.Input;
                    pYpmssyz.Value = jc_ypParamLike.Ypmssyz;
                    sqlparams.Add(pYpmssyz);
                }

                if (null != jc_ypParamLike.Ypmsjjz && "" != jc_ypParamLike.Ypmsjjz)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YPMSJJZ LIKE '%'||:ypmsjjz||'%' ");
                    OracleParameter pYpmsjjz = new OracleParameter(":ypmsjjz", OracleDbType.NVarchar2);
                    pYpmsjjz.Direction = ParameterDirection.Input;
                    pYpmsjjz.Value = jc_ypParamLike.Ypmsjjz;
                    sqlparams.Add(pYpmsjjz);
                }

                if (null != jc_ypParamLike.Ypmsyfhbrqjy_code && "" != jc_ypParamLike.Ypmsyfhbrqjy_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YPMSYFHBRQJY_CODE LIKE '%'||:ypmsyfhbrqjy_code||'%' ");
                    OracleParameter pYpmsyfhbrqjy_code = new OracleParameter(":ypmsyfhbrqjy_code", OracleDbType.NVarchar2);
                    pYpmsyfhbrqjy_code.Direction = ParameterDirection.Input;
                    pYpmsyfhbrqjy_code.Value = jc_ypParamLike.Ypmsyfhbrqjy_code;
                    sqlparams.Add(pYpmsyfhbrqjy_code);
                }

                if (null != jc_ypParamLike.Ypmsblfy && "" != jc_ypParamLike.Ypmsblfy)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YPMSBLFY LIKE '%'||:ypmsblfy||'%' ");
                    OracleParameter pYpmsblfy = new OracleParameter(":ypmsblfy", OracleDbType.NVarchar2);
                    pYpmsblfy.Direction = ParameterDirection.Input;
                    pYpmsblfy.Value = jc_ypParamLike.Ypmsblfy;
                    sqlparams.Add(pYpmsblfy);
                }

                if (null != jc_ypParamLike.Ypfl_code && "" != jc_ypParamLike.Ypfl_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YPFL_CODE LIKE '%'||:ypfl_code||'%' ");
                    OracleParameter pYpfl_code = new OracleParameter(":ypfl_code", OracleDbType.NVarchar2);
                    pYpfl_code.Direction = ParameterDirection.Input;
                    pYpfl_code.Value = jc_ypParamLike.Ypfl_code;
                    sqlparams.Add(pYpfl_code);
                }

                if (null != jc_ypParamLike.Yjjb_code && "" != jc_ypParamLike.Yjjb_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YJJB_CODE LIKE '%'||:yjjb_code||'%' ");
                    OracleParameter pYjjb_code = new OracleParameter(":yjjb_code", OracleDbType.NVarchar2);
                    pYjjb_code.Direction = ParameterDirection.Input;
                    pYjjb_code.Value = jc_ypParamLike.Yjjb_code;
                    sqlparams.Add(pYjjb_code);
                }

                if (null != jc_ypParamLike.Txm && "" != jc_ypParamLike.Txm)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.TXM LIKE '%'||:txm||'%' ");
                    OracleParameter pTxm = new OracleParameter(":txm", OracleDbType.NVarchar2);
                    pTxm.Direction = ParameterDirection.Input;
                    pTxm.Value = jc_ypParamLike.Txm;
                    sqlparams.Add(pTxm);
                }

                if (null != jc_ypParamLike.Ewm && "" != jc_ypParamLike.Ewm)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.EWM LIKE '%'||:ewm||'%' ");
                    OracleParameter pEwm = new OracleParameter(":ewm", OracleDbType.NVarchar2);
                    pEwm.Direction = ParameterDirection.Input;
                    pEwm.Value = jc_ypParamLike.Ewm;
                    sqlparams.Add(pEwm);
                }

                if (null != jc_ypParamLike.Pym && "" != jc_ypParamLike.Pym)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.PYM LIKE '%'||:pym||'%' ");
                    OracleParameter pPym = new OracleParameter(":pym", OracleDbType.NVarchar2);
                    pPym.Direction = ParameterDirection.Input;
                    pPym.Value = jc_ypParamLike.Pym;
                    sqlparams.Add(pPym);
                }

                if (null != jc_ypParamLike.Sfcly_code && "" != jc_ypParamLike.Sfcly_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.SFCLY_CODE LIKE '%'||:sfcly_code||'%' ");
                    OracleParameter pSfcly_code = new OracleParameter(":sfcly_code", OracleDbType.NVarchar2);
                    pSfcly_code.Direction = ParameterDirection.Input;
                    pSfcly_code.Value = jc_ypParamLike.Sfcly_code;
                    sqlparams.Add(pSfcly_code);
                }

                if (null != jc_ypParamLike.Sfclm_code && "" != jc_ypParamLike.Sfclm_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.SFCLM_CODE LIKE '%'||:sfclm_code||'%' ");
                    OracleParameter pSfclm_code = new OracleParameter(":sfclm_code", OracleDbType.NVarchar2);
                    pSfclm_code.Direction = ParameterDirection.Input;
                    pSfclm_code.Value = jc_ypParamLike.Sfclm_code;
                    sqlparams.Add(pSfclm_code);
                }

                if (null != jc_ypParamLike.Yxzt_code && "" != jc_ypParamLike.Yxzt_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YXZT_CODE LIKE '%'||:yxzt_code||'%' ");
                    OracleParameter pYxzt_code = new OracleParameter(":yxzt_code", OracleDbType.NVarchar2);
                    pYxzt_code.Direction = ParameterDirection.Input;
                    pYxzt_code.Value = jc_ypParamLike.Yxzt_code;
                    sqlparams.Add(pYxzt_code);
                }

                if (null != jc_ypParamLike.Scqy && "" != jc_ypParamLike.Scqy)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.SCQY LIKE '%'||:scqy||'%' ");
                    OracleParameter pScqy = new OracleParameter(":scqy", OracleDbType.NVarchar2);
                    pScqy.Direction = ParameterDirection.Input;
                    pScqy.Value = jc_ypParamLike.Scqy;
                    sqlparams.Add(pScqy);
                }

                if (null != jc_ypParamLike.Sfkss_code && "" != jc_ypParamLike.Sfkss_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.SFKSS_CODE LIKE '%'||:sfkss_code||'%' ");
                    OracleParameter pSfkss_code = new OracleParameter(":sfkss_code", OracleDbType.NVarchar2);
                    pSfkss_code.Direction = ParameterDirection.Input;
                    pSfkss_code.Value = jc_ypParamLike.Sfkss_code;
                    sqlparams.Add(pSfkss_code);
                }

                if (null != jc_ypParamLike.Zfbz && "" != jc_ypParamLike.Zfbz)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.ZFBZ LIKE '%'||:zfbz||'%' ");
                    OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                    pZfbz.Direction = ParameterDirection.Input;
                    pZfbz.Value = jc_ypParamLike.Zfbz;
                    sqlparams.Add(pZfbz);
                }

            }

            this.b_isWhere = false;
            this.addSort(sql, sortList);//排序
            //*******分页start1*********如果分页对象为空，则全部数据查出，如果不为空
            List<object> returnList = new List<object>();//返回的List,索引0为List<Jc_yp>对象,索引1为Model.Common.PageInfo分页信息对象
            if (null != page)
            {
                string sqlParam = sql.ToString();
                sql = new StringBuilder(@" SELECT * FROM 
                (
                SELECT A.*, ROWNUM RN 
                FROM (" + sqlParam + @") A 
                WHERE ROWNUM <= :maxIndex
                )
                WHERE RN >= :minIndex ");
                sqlparams.Add(new OracleParameter("maxIndex", page.MaxIndex));
                sqlparams.Add(new OracleParameter("minIndex", page.MinIndex));
            }
            //*******分页end1*********
            DataSet ds = OracleHelper.getDataSet(sql.ToString(), sqlparams.ToArray());
            DataRowCollection rows = ds.Tables[0].Rows;
            //把每一行数据转换为一个对象放入List<Jc_yp>中
            for (int i = 0; i < rows.Count; i++)
            {
                DataRow row = rows[i];
                //jc_ypParamList.Add(this.dataSetContactObjectsToModel(row));
                jc_ypParamList.Add(this.dataSetToModel(row));
            }

            //*******分页start2*********如果没有传入分页对象，则新建一个分页对象当做返回值
            if (null == page)
            {
                page = new Model.Common.PageInfo();
                page.AllCount = rows.Count;
            }
            returnList.Add(jc_ypParamList);//把List<Jc_yp>放入List<object>中第一个
            returnList.Add(page);//把page对象放入List<object>中第二个
            //*******分页end2*********
            return returnList;
        }



        /// <summary>
        /// 根据条件得到集合的数量
        /// 第二个条件是模糊查询的条件
        /// </summary>
        /// <returns>int</returns>
        public int getCount(Jc_yp jc_ypParam, Jc_yp jc_ypParamLike)
        {
            //如果没有传查询条件参数，就new一个空的Jc_yp对象，标示查询所有数据
            if (null == jc_ypParam)
            {
                jc_ypParam = new Jc_yp();
            }
            List<OracleParameter> sqlparams = new List<OracleParameter>();//保存参数的集合
            StringBuilder sql = new StringBuilder("SELECT COUNT(ID) FROM JC_YP A");
            if (null != jc_ypParam.Ypbm && "" != jc_ypParam.Ypbm)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.YPBM=:ypbm ");
                OracleParameter pYpbm = new OracleParameter(":ypbm", OracleDbType.NVarchar2);
                pYpbm.Value = jc_ypParam.Ypbm;
                sqlparams.Add(pYpbm);
            }

            if (null != jc_ypParam.Ypmc && "" != jc_ypParam.Ypmc)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.YPMC=:ypmc ");
                OracleParameter pYpmc = new OracleParameter(":ypmc", OracleDbType.NVarchar2);
                pYpmc.Value = jc_ypParam.Ypmc;
                sqlparams.Add(pYpmc);
            }

            if (null != jc_ypParam.Yptymc && "" != jc_ypParam.Yptymc)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.YPTYMC=:yptymc ");
                OracleParameter pYptymc = new OracleParameter(":yptymc", OracleDbType.NVarchar2);
                pYptymc.Value = jc_ypParam.Yptymc;
                sqlparams.Add(pYptymc);
            }

            if (null != jc_ypParam.Ypcf && "" != jc_ypParam.Ypcf)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.YPCF=:ypcf ");
                OracleParameter pYpcf = new OracleParameter(":ypcf", OracleDbType.NVarchar2);
                pYpcf.Value = jc_ypParam.Ypcf;
                sqlparams.Add(pYpcf);
            }

            if (null != jc_ypParam.Yppzwh && "" != jc_ypParam.Yppzwh)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.YPPZWH=:yppzwh ");
                OracleParameter pYppzwh = new OracleParameter(":yppzwh", OracleDbType.NVarchar2);
                pYppzwh.Value = jc_ypParam.Yppzwh;
                sqlparams.Add(pYppzwh);
            }

            if (null != jc_ypParam.Ypzczh && "" != jc_ypParam.Ypzczh)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.YPZCZH=:ypzczh ");
                OracleParameter pYpzczh = new OracleParameter(":ypzczh", OracleDbType.NVarchar2);
                pYpzczh.Value = jc_ypParam.Ypzczh;
                sqlparams.Add(pYpzczh);
            }

            if (null != jc_ypParam.Gyzz && "" != jc_ypParam.Gyzz)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.GYZZ=:gyzz ");
                OracleParameter pGyzz = new OracleParameter(":gyzz", OracleDbType.NVarchar2);
                pGyzz.Value = jc_ypParam.Gyzz;
                sqlparams.Add(pGyzz);
            }

            if (null != jc_ypParam.Ypjx_code && "" != jc_ypParam.Ypjx_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.YPJX_CODE=:ypjx_code ");
                OracleParameter pYpjx_code = new OracleParameter(":ypjx_code", OracleDbType.NVarchar2);
                pYpjx_code.Value = jc_ypParam.Ypjx_code;
                sqlparams.Add(pYpjx_code);
            }

            if (null != jc_ypParam.Ypgg && "" != jc_ypParam.Ypgg)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.YPGG=:ypgg ");
                OracleParameter pYpgg = new OracleParameter(":ypgg", OracleDbType.NVarchar2);
                pYpgg.Value = jc_ypParam.Ypgg;
                sqlparams.Add(pYpgg);
            }

            if (null != jc_ypParam.Ypdcyl)
            {
                this.isComma(sql);
                sql.Append(" YPDCYL=:ypdcyl ");
                OracleParameter pYpdcyl = new OracleParameter(":ypdcyl", OracleDbType.Decimal);
                pYpdcyl.Value = jc_ypParam.Ypdcyl;
                sqlparams.Add(pYpdcyl);

            }

            if (null != jc_ypParam.Ypdcyldw_code && "" != jc_ypParam.Ypdcyldw_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.YPDCYLDW_CODE=:ypdcyldw_code ");
                OracleParameter pYpdcyldw_code = new OracleParameter(":ypdcyldw_code", OracleDbType.NVarchar2);
                pYpdcyldw_code.Value = jc_ypParam.Ypdcyldw_code;
                sqlparams.Add(pYpdcyldw_code);
            }

            if (null != jc_ypParam.Ypyytj_code && "" != jc_ypParam.Ypyytj_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.YPYYTJ_CODE=:ypyytj_code ");
                OracleParameter pYpyytj_code = new OracleParameter(":ypyytj_code", OracleDbType.NVarchar2);
                pYpyytj_code.Value = jc_ypParam.Ypyytj_code;
                sqlparams.Add(pYpyytj_code);
            }

            if (null != jc_ypParam.Ddw_code && "" != jc_ypParam.Ddw_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.DDW_CODE=:ddw_code ");
                OracleParameter pDdw_code = new OracleParameter(":ddw_code", OracleDbType.NVarchar2);
                pDdw_code.Value = jc_ypParam.Ddw_code;
                sqlparams.Add(pDdw_code);
            }

            if (null != jc_ypParam.Xdw_code && "" != jc_ypParam.Xdw_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.XDW_CODE=:xdw_code ");
                OracleParameter pXdw_code = new OracleParameter(":xdw_code", OracleDbType.NVarchar2);
                pXdw_code.Value = jc_ypParam.Xdw_code;
                sqlparams.Add(pXdw_code);
            }

            if (null != jc_ypParam.Cfybz_code && "" != jc_ypParam.Cfybz_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.CFYBZ_CODE=:cfybz_code ");
                OracleParameter pCfybz_code = new OracleParameter(":cfybz_code", OracleDbType.NVarchar2);
                pCfybz_code.Value = jc_ypParam.Cfybz_code;
                sqlparams.Add(pCfybz_code);
            }

            if (null != jc_ypParam.Cfqxjy_code && "" != jc_ypParam.Cfqxjy_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.CFQXJY_CODE=:cfqxjy_code ");
                OracleParameter pCfqxjy_code = new OracleParameter(":cfqxjy_code", OracleDbType.NVarchar2);
                pCfqxjy_code.Value = jc_ypParam.Cfqxjy_code;
                sqlparams.Add(pCfqxjy_code);
            }

            if (null != jc_ypParam.Cfqxyb_code && "" != jc_ypParam.Cfqxyb_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.CFQXYB_CODE=:cfqxyb_code ");
                OracleParameter pCfqxyb_code = new OracleParameter(":cfqxyb_code", OracleDbType.NVarchar2);
                pCfqxyb_code.Value = jc_ypParam.Cfqxyb_code;
                sqlparams.Add(pCfqxyb_code);
            }

            if (null != jc_ypParam.Cfqxdm_code && "" != jc_ypParam.Cfqxdm_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.CFQXDM_CODE=:cfqxdm_code ");
                OracleParameter pCfqxdm_code = new OracleParameter(":cfqxdm_code", OracleDbType.NVarchar2);
                pCfqxdm_code.Value = jc_ypParam.Cfqxdm_code;
                sqlparams.Add(pCfqxdm_code);
            }

            if (null != jc_ypParam.Cfqxjs_code && "" != jc_ypParam.Cfqxjs_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.CFQXJS_CODE=:cfqxjs_code ");
                OracleParameter pCfqxjs_code = new OracleParameter(":cfqxjs_code", OracleDbType.NVarchar2);
                pCfqxjs_code.Value = jc_ypParam.Cfqxjs_code;
                sqlparams.Add(pCfqxjs_code);
            }

            if (null != jc_ypParam.Cfqxgz_code && "" != jc_ypParam.Cfqxgz_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.CFQXGZ_CODE=:cfqxgz_code ");
                OracleParameter pCfqxgz_code = new OracleParameter(":cfqxgz_code", OracleDbType.NVarchar2);
                pCfqxgz_code.Value = jc_ypParam.Cfqxgz_code;
                sqlparams.Add(pCfqxgz_code);
            }

            if (null != jc_ypParam.Cfqxjk_code && "" != jc_ypParam.Cfqxjk_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.CFQXJK_CODE=:cfqxjk_code ");
                OracleParameter pCfqxjk_code = new OracleParameter(":cfqxjk_code", OracleDbType.NVarchar2);
                pCfqxjk_code.Value = jc_ypParam.Cfqxjk_code;
                sqlparams.Add(pCfqxjk_code);
            }

            if (null != jc_ypParam.Cfqxzz_code && "" != jc_ypParam.Cfqxzz_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.CFQXZZ_CODE=:cfqxzz_code ");
                OracleParameter pCfqxzz_code = new OracleParameter(":cfqxzz_code", OracleDbType.NVarchar2);
                pCfqxzz_code.Value = jc_ypParam.Cfqxzz_code;
                sqlparams.Add(pCfqxzz_code);
            }

            if (null != jc_ypParam.Cfqxzf_code && "" != jc_ypParam.Cfqxzf_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.CFQXZF_CODE=:cfqxzf_code ");
                OracleParameter pCfqxzf_code = new OracleParameter(":cfqxzf_code", OracleDbType.NVarchar2);
                pCfqxzf_code.Value = jc_ypParam.Cfqxzf_code;
                sqlparams.Add(pCfqxzf_code);
            }

            if (null != jc_ypParam.Cfqxts_code && "" != jc_ypParam.Cfqxts_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.CFQXTS_CODE=:cfqxts_code ");
                OracleParameter pCfqxts_code = new OracleParameter(":cfqxts_code", OracleDbType.NVarchar2);
                pCfqxts_code.Value = jc_ypParam.Cfqxts_code;
                sqlparams.Add(pCfqxts_code);
            }

            if (null != jc_ypParam.Ps_code && "" != jc_ypParam.Ps_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.PS_CODE=:ps_code ");
                OracleParameter pPs_code = new OracleParameter(":ps_code", OracleDbType.NVarchar2);
                pPs_code.Value = jc_ypParam.Ps_code;
                sqlparams.Add(pPs_code);
            }

            if (null != jc_ypParam.Yplx_code && "" != jc_ypParam.Yplx_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.YPLX_CODE=:yplx_code ");
                OracleParameter pYplx_code = new OracleParameter(":yplx_code", OracleDbType.NVarchar2);
                pYplx_code.Value = jc_ypParam.Yplx_code;
                sqlparams.Add(pYplx_code);
            }

            if (null != jc_ypParam.Ypmssyz && "" != jc_ypParam.Ypmssyz)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.YPMSSYZ=:ypmssyz ");
                OracleParameter pYpmssyz = new OracleParameter(":ypmssyz", OracleDbType.NVarchar2);
                pYpmssyz.Value = jc_ypParam.Ypmssyz;
                sqlparams.Add(pYpmssyz);
            }

            if (null != jc_ypParam.Ypmsjjz && "" != jc_ypParam.Ypmsjjz)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.YPMSJJZ=:ypmsjjz ");
                OracleParameter pYpmsjjz = new OracleParameter(":ypmsjjz", OracleDbType.NVarchar2);
                pYpmsjjz.Value = jc_ypParam.Ypmsjjz;
                sqlparams.Add(pYpmsjjz);
            }

            if (null != jc_ypParam.Ypmsyfhbrqjy_code && "" != jc_ypParam.Ypmsyfhbrqjy_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.YPMSYFHBRQJY_CODE=:ypmsyfhbrqjy_code ");
                OracleParameter pYpmsyfhbrqjy_code = new OracleParameter(":ypmsyfhbrqjy_code", OracleDbType.NVarchar2);
                pYpmsyfhbrqjy_code.Value = jc_ypParam.Ypmsyfhbrqjy_code;
                sqlparams.Add(pYpmsyfhbrqjy_code);
            }

            if (null != jc_ypParam.Ypmsblfy && "" != jc_ypParam.Ypmsblfy)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.YPMSBLFY=:ypmsblfy ");
                OracleParameter pYpmsblfy = new OracleParameter(":ypmsblfy", OracleDbType.NVarchar2);
                pYpmsblfy.Value = jc_ypParam.Ypmsblfy;
                sqlparams.Add(pYpmsblfy);
            }

            if (null != jc_ypParam.Ypfl_code && "" != jc_ypParam.Ypfl_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.YPFL_CODE=:ypfl_code ");
                OracleParameter pYpfl_code = new OracleParameter(":ypfl_code", OracleDbType.NVarchar2);
                pYpfl_code.Value = jc_ypParam.Ypfl_code;
                sqlparams.Add(pYpfl_code);
            }

            if (null != jc_ypParam.Yjjb_code && "" != jc_ypParam.Yjjb_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.YJJB_CODE=:yjjb_code ");
                OracleParameter pYjjb_code = new OracleParameter(":yjjb_code", OracleDbType.NVarchar2);
                pYjjb_code.Value = jc_ypParam.Yjjb_code;
                sqlparams.Add(pYjjb_code);
            }

            if (null != jc_ypParam.Txm && "" != jc_ypParam.Txm)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.TXM=:txm ");
                OracleParameter pTxm = new OracleParameter(":txm", OracleDbType.NVarchar2);
                pTxm.Value = jc_ypParam.Txm;
                sqlparams.Add(pTxm);
            }

            if (null != jc_ypParam.Ewm && "" != jc_ypParam.Ewm)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.EWM=:ewm ");
                OracleParameter pEwm = new OracleParameter(":ewm", OracleDbType.NVarchar2);
                pEwm.Value = jc_ypParam.Ewm;
                sqlparams.Add(pEwm);
            }

            if (null != jc_ypParam.Pym && "" != jc_ypParam.Pym)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.PYM=:pym ");
                OracleParameter pPym = new OracleParameter(":pym", OracleDbType.NVarchar2);
                pPym.Value = jc_ypParam.Pym;
                sqlparams.Add(pPym);
            }

            if (null != jc_ypParam.Hsxs)
            {
                this.isComma(sql);
                sql.Append(" HSXS=:hsxs ");
                OracleParameter pHsxs = new OracleParameter(":hsxs", OracleDbType.Decimal);
                pHsxs.Value = jc_ypParam.Hsxs;
                sqlparams.Add(pHsxs);

            }

            if (null != jc_ypParam.Sfcly_code && "" != jc_ypParam.Sfcly_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.SFCLY_CODE=:sfcly_code ");
                OracleParameter pSfcly_code = new OracleParameter(":sfcly_code", OracleDbType.NVarchar2);
                pSfcly_code.Value = jc_ypParam.Sfcly_code;
                sqlparams.Add(pSfcly_code);
            }

            if (null != jc_ypParam.Bzpfj)
            {
                this.isComma(sql);
                sql.Append(" BZPFJ=:bzpfj ");
                OracleParameter pBzpfj = new OracleParameter(":bzpfj", OracleDbType.Decimal);
                pBzpfj.Value = jc_ypParam.Bzpfj;
                sqlparams.Add(pBzpfj);

            }

            if (null != jc_ypParam.Bzlsj)
            {
                this.isComma(sql);
                sql.Append(" BZLSJ=:bzlsj ");
                OracleParameter pBzlsj = new OracleParameter(":bzlsj", OracleDbType.Decimal);
                pBzlsj.Value = jc_ypParam.Bzlsj;
                sqlparams.Add(pBzlsj);

            }

            if (null != jc_ypParam.Bzmzj)
            {
                this.isComma(sql);
                sql.Append(" BZMZJ=:bzmzj ");
                OracleParameter pBzmzj = new OracleParameter(":bzmzj", OracleDbType.Decimal);
                pBzmzj.Value = jc_ypParam.Bzmzj;
                sqlparams.Add(pBzmzj);

            }

            if (null != jc_ypParam.Bzzyj)
            {
                this.isComma(sql);
                sql.Append(" BZZYJ=:bzzyj ");
                OracleParameter pBzzyj = new OracleParameter(":bzzyj", OracleDbType.Decimal);
                pBzzyj.Value = jc_ypParam.Bzzyj;
                sqlparams.Add(pBzzyj);

            }

            if (null != jc_ypParam.Hsbl)
            {
                this.isComma(sql);
                sql.Append(" HSBL=:hsbl ");
                OracleParameter pHsbl = new OracleParameter(":hsbl", OracleDbType.Decimal);
                pHsbl.Value = jc_ypParam.Hsbl;
                sqlparams.Add(pHsbl);

            }

            if (null != jc_ypParam.Sfclm_code && "" != jc_ypParam.Sfclm_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.SFCLM_CODE=:sfclm_code ");
                OracleParameter pSfclm_code = new OracleParameter(":sfclm_code", OracleDbType.NVarchar2);
                pSfclm_code.Value = jc_ypParam.Sfclm_code;
                sqlparams.Add(pSfclm_code);
            }

            if (null != jc_ypParam.Yxzt_code && "" != jc_ypParam.Yxzt_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.YXZT_CODE=:yxzt_code ");
                OracleParameter pYxzt_code = new OracleParameter(":yxzt_code", OracleDbType.NVarchar2);
                pYxzt_code.Value = jc_ypParam.Yxzt_code;
                sqlparams.Add(pYxzt_code);
            }

            if (null != jc_ypParam.Dcsxyl)
            {
                this.isComma(sql);
                sql.Append(" DCSXYL=:dcsxyl ");
                OracleParameter pDcsxyl = new OracleParameter(":dcsxyl", OracleDbType.Decimal);
                pDcsxyl.Value = jc_ypParam.Dcsxyl;
                sqlparams.Add(pDcsxyl);

            }

            if (null != jc_ypParam.Dcxxyl)
            {
                this.isComma(sql);
                sql.Append(" DCXXYL=:dcxxyl ");
                OracleParameter pDcxxyl = new OracleParameter(":dcxxyl", OracleDbType.Decimal);
                pDcxxyl.Value = jc_ypParam.Dcxxyl;
                sqlparams.Add(pDcxxyl);

            }

            if (null != jc_ypParam.Lxylts)
            {
                this.isComma(sql);
                sql.Append(" LXYLTS=:lxylts ");
                OracleParameter pLxylts = new OracleParameter(":lxylts", OracleDbType.Decimal);
                pLxylts.Value = jc_ypParam.Lxylts;
                sqlparams.Add(pLxylts);

            }

            if (null != jc_ypParam.Lxylcs)
            {
                this.isComma(sql);
                sql.Append(" LXYLCS=:lxylcs ");
                OracleParameter pLxylcs = new OracleParameter(":lxylcs", OracleDbType.Decimal);
                pLxylcs.Value = jc_ypParam.Lxylcs;
                sqlparams.Add(pLxylcs);

            }

            if (null != jc_ypParam.Scqy && "" != jc_ypParam.Scqy)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.SCQY=:scqy ");
                OracleParameter pScqy = new OracleParameter(":scqy", OracleDbType.NVarchar2);
                pScqy.Value = jc_ypParam.Scqy;
                sqlparams.Add(pScqy);
            }

            if (DateTime.MinValue != jc_ypParam.Pzrq && null != jc_ypParam.Pzrq)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.PZRQ=:pzrq ");
                OracleParameter pPzrq = new OracleParameter(":pzrq", OracleDbType.Date);
                pPzrq.Value = jc_ypParam.Pzrq;
                sqlparams.Add(pPzrq);
            }

            if (null != jc_ypParam.Sfkss_code && "" != jc_ypParam.Sfkss_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.SFKSS_CODE=:sfkss_code ");
                OracleParameter pSfkss_code = new OracleParameter(":sfkss_code", OracleDbType.NVarchar2);
                pSfkss_code.Value = jc_ypParam.Sfkss_code;
                sqlparams.Add(pSfkss_code);
            }

            if (null != jc_ypParam.Zfbz && "" != jc_ypParam.Zfbz)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.ZFBZ=:zfbz ");
                OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                pZfbz.Value = jc_ypParam.Zfbz;
                sqlparams.Add(pZfbz);
            }

            if (null != jc_ypParam.Dcyldwbl)
            {
                this.isComma(sql);
                sql.Append(" DCYLDWBL=:dcyldwbl ");
                OracleParameter pDcyldwbl = new OracleParameter(":dcyldwbl", OracleDbType.Decimal);
                pDcyldwbl.Value = jc_ypParam.Dcyldwbl;
                sqlparams.Add(pDcyldwbl);

            }

            if (jc_ypParamLike != null)
            {

                if (null != jc_ypParamLike.Ypbm && "" != jc_ypParamLike.Ypbm)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YPBM LIKE '%'||:ypbm||'%' ");
                    OracleParameter pYpbm = new OracleParameter(":ypbm", OracleDbType.NVarchar2);
                    pYpbm.Direction = ParameterDirection.Input;
                    pYpbm.Value = jc_ypParamLike.Ypbm;
                    sqlparams.Add(pYpbm);
                }

                if (null != jc_ypParamLike.Ypmc && "" != jc_ypParamLike.Ypmc)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YPMC LIKE '%'||:ypmc||'%' ");
                    OracleParameter pYpmc = new OracleParameter(":ypmc", OracleDbType.NVarchar2);
                    pYpmc.Direction = ParameterDirection.Input;
                    pYpmc.Value = jc_ypParamLike.Ypmc;
                    sqlparams.Add(pYpmc);
                }

                if (null != jc_ypParamLike.Yptymc && "" != jc_ypParamLike.Yptymc)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YPTYMC LIKE '%'||:yptymc||'%' ");
                    OracleParameter pYptymc = new OracleParameter(":yptymc", OracleDbType.NVarchar2);
                    pYptymc.Direction = ParameterDirection.Input;
                    pYptymc.Value = jc_ypParamLike.Yptymc;
                    sqlparams.Add(pYptymc);
                }

                if (null != jc_ypParamLike.Ypcf && "" != jc_ypParamLike.Ypcf)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YPCF LIKE '%'||:ypcf||'%' ");
                    OracleParameter pYpcf = new OracleParameter(":ypcf", OracleDbType.NVarchar2);
                    pYpcf.Direction = ParameterDirection.Input;
                    pYpcf.Value = jc_ypParamLike.Ypcf;
                    sqlparams.Add(pYpcf);
                }

                if (null != jc_ypParamLike.Yppzwh && "" != jc_ypParamLike.Yppzwh)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YPPZWH LIKE '%'||:yppzwh||'%' ");
                    OracleParameter pYppzwh = new OracleParameter(":yppzwh", OracleDbType.NVarchar2);
                    pYppzwh.Direction = ParameterDirection.Input;
                    pYppzwh.Value = jc_ypParamLike.Yppzwh;
                    sqlparams.Add(pYppzwh);
                }

                if (null != jc_ypParamLike.Ypzczh && "" != jc_ypParamLike.Ypzczh)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YPZCZH LIKE '%'||:ypzczh||'%' ");
                    OracleParameter pYpzczh = new OracleParameter(":ypzczh", OracleDbType.NVarchar2);
                    pYpzczh.Direction = ParameterDirection.Input;
                    pYpzczh.Value = jc_ypParamLike.Ypzczh;
                    sqlparams.Add(pYpzczh);
                }

                if (null != jc_ypParamLike.Gyzz && "" != jc_ypParamLike.Gyzz)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.GYZZ LIKE '%'||:gyzz||'%' ");
                    OracleParameter pGyzz = new OracleParameter(":gyzz", OracleDbType.NVarchar2);
                    pGyzz.Direction = ParameterDirection.Input;
                    pGyzz.Value = jc_ypParamLike.Gyzz;
                    sqlparams.Add(pGyzz);
                }

                if (null != jc_ypParamLike.Ypjx_code && "" != jc_ypParamLike.Ypjx_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YPJX_CODE LIKE '%'||:ypjx_code||'%' ");
                    OracleParameter pYpjx_code = new OracleParameter(":ypjx_code", OracleDbType.NVarchar2);
                    pYpjx_code.Direction = ParameterDirection.Input;
                    pYpjx_code.Value = jc_ypParamLike.Ypjx_code;
                    sqlparams.Add(pYpjx_code);
                }

                if (null != jc_ypParamLike.Ypgg && "" != jc_ypParamLike.Ypgg)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YPGG LIKE '%'||:ypgg||'%' ");
                    OracleParameter pYpgg = new OracleParameter(":ypgg", OracleDbType.NVarchar2);
                    pYpgg.Direction = ParameterDirection.Input;
                    pYpgg.Value = jc_ypParamLike.Ypgg;
                    sqlparams.Add(pYpgg);
                }

                if (null != jc_ypParamLike.Ypdcyldw_code && "" != jc_ypParamLike.Ypdcyldw_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YPDCYLDW_CODE LIKE '%'||:ypdcyldw_code||'%' ");
                    OracleParameter pYpdcyldw_code = new OracleParameter(":ypdcyldw_code", OracleDbType.NVarchar2);
                    pYpdcyldw_code.Direction = ParameterDirection.Input;
                    pYpdcyldw_code.Value = jc_ypParamLike.Ypdcyldw_code;
                    sqlparams.Add(pYpdcyldw_code);
                }

                if (null != jc_ypParamLike.Ypyytj_code && "" != jc_ypParamLike.Ypyytj_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YPYYTJ_CODE LIKE '%'||:ypyytj_code||'%' ");
                    OracleParameter pYpyytj_code = new OracleParameter(":ypyytj_code", OracleDbType.NVarchar2);
                    pYpyytj_code.Direction = ParameterDirection.Input;
                    pYpyytj_code.Value = jc_ypParamLike.Ypyytj_code;
                    sqlparams.Add(pYpyytj_code);
                }

                if (null != jc_ypParamLike.Ddw_code && "" != jc_ypParamLike.Ddw_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.DDW_CODE LIKE '%'||:ddw_code||'%' ");
                    OracleParameter pDdw_code = new OracleParameter(":ddw_code", OracleDbType.NVarchar2);
                    pDdw_code.Direction = ParameterDirection.Input;
                    pDdw_code.Value = jc_ypParamLike.Ddw_code;
                    sqlparams.Add(pDdw_code);
                }

                if (null != jc_ypParamLike.Xdw_code && "" != jc_ypParamLike.Xdw_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.XDW_CODE LIKE '%'||:xdw_code||'%' ");
                    OracleParameter pXdw_code = new OracleParameter(":xdw_code", OracleDbType.NVarchar2);
                    pXdw_code.Direction = ParameterDirection.Input;
                    pXdw_code.Value = jc_ypParamLike.Xdw_code;
                    sqlparams.Add(pXdw_code);
                }

                if (null != jc_ypParamLike.Cfybz_code && "" != jc_ypParamLike.Cfybz_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.CFYBZ_CODE LIKE '%'||:cfybz_code||'%' ");
                    OracleParameter pCfybz_code = new OracleParameter(":cfybz_code", OracleDbType.NVarchar2);
                    pCfybz_code.Direction = ParameterDirection.Input;
                    pCfybz_code.Value = jc_ypParamLike.Cfybz_code;
                    sqlparams.Add(pCfybz_code);
                }

                if (null != jc_ypParamLike.Cfqxjy_code && "" != jc_ypParamLike.Cfqxjy_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.CFQXJY_CODE LIKE '%'||:cfqxjy_code||'%' ");
                    OracleParameter pCfqxjy_code = new OracleParameter(":cfqxjy_code", OracleDbType.NVarchar2);
                    pCfqxjy_code.Direction = ParameterDirection.Input;
                    pCfqxjy_code.Value = jc_ypParamLike.Cfqxjy_code;
                    sqlparams.Add(pCfqxjy_code);
                }

                if (null != jc_ypParamLike.Cfqxyb_code && "" != jc_ypParamLike.Cfqxyb_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.CFQXYB_CODE LIKE '%'||:cfqxyb_code||'%' ");
                    OracleParameter pCfqxyb_code = new OracleParameter(":cfqxyb_code", OracleDbType.NVarchar2);
                    pCfqxyb_code.Direction = ParameterDirection.Input;
                    pCfqxyb_code.Value = jc_ypParamLike.Cfqxyb_code;
                    sqlparams.Add(pCfqxyb_code);
                }

                if (null != jc_ypParamLike.Cfqxdm_code && "" != jc_ypParamLike.Cfqxdm_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.CFQXDM_CODE LIKE '%'||:cfqxdm_code||'%' ");
                    OracleParameter pCfqxdm_code = new OracleParameter(":cfqxdm_code", OracleDbType.NVarchar2);
                    pCfqxdm_code.Direction = ParameterDirection.Input;
                    pCfqxdm_code.Value = jc_ypParamLike.Cfqxdm_code;
                    sqlparams.Add(pCfqxdm_code);
                }

                if (null != jc_ypParamLike.Cfqxjs_code && "" != jc_ypParamLike.Cfqxjs_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.CFQXJS_CODE LIKE '%'||:cfqxjs_code||'%' ");
                    OracleParameter pCfqxjs_code = new OracleParameter(":cfqxjs_code", OracleDbType.NVarchar2);
                    pCfqxjs_code.Direction = ParameterDirection.Input;
                    pCfqxjs_code.Value = jc_ypParamLike.Cfqxjs_code;
                    sqlparams.Add(pCfqxjs_code);
                }

                if (null != jc_ypParamLike.Cfqxgz_code && "" != jc_ypParamLike.Cfqxgz_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.CFQXGZ_CODE LIKE '%'||:cfqxgz_code||'%' ");
                    OracleParameter pCfqxgz_code = new OracleParameter(":cfqxgz_code", OracleDbType.NVarchar2);
                    pCfqxgz_code.Direction = ParameterDirection.Input;
                    pCfqxgz_code.Value = jc_ypParamLike.Cfqxgz_code;
                    sqlparams.Add(pCfqxgz_code);
                }

                if (null != jc_ypParamLike.Cfqxjk_code && "" != jc_ypParamLike.Cfqxjk_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.CFQXJK_CODE LIKE '%'||:cfqxjk_code||'%' ");
                    OracleParameter pCfqxjk_code = new OracleParameter(":cfqxjk_code", OracleDbType.NVarchar2);
                    pCfqxjk_code.Direction = ParameterDirection.Input;
                    pCfqxjk_code.Value = jc_ypParamLike.Cfqxjk_code;
                    sqlparams.Add(pCfqxjk_code);
                }

                if (null != jc_ypParamLike.Cfqxzz_code && "" != jc_ypParamLike.Cfqxzz_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.CFQXZZ_CODE LIKE '%'||:cfqxzz_code||'%' ");
                    OracleParameter pCfqxzz_code = new OracleParameter(":cfqxzz_code", OracleDbType.NVarchar2);
                    pCfqxzz_code.Direction = ParameterDirection.Input;
                    pCfqxzz_code.Value = jc_ypParamLike.Cfqxzz_code;
                    sqlparams.Add(pCfqxzz_code);
                }

                if (null != jc_ypParamLike.Cfqxzf_code && "" != jc_ypParamLike.Cfqxzf_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.CFQXZF_CODE LIKE '%'||:cfqxzf_code||'%' ");
                    OracleParameter pCfqxzf_code = new OracleParameter(":cfqxzf_code", OracleDbType.NVarchar2);
                    pCfqxzf_code.Direction = ParameterDirection.Input;
                    pCfqxzf_code.Value = jc_ypParamLike.Cfqxzf_code;
                    sqlparams.Add(pCfqxzf_code);
                }

                if (null != jc_ypParamLike.Cfqxts_code && "" != jc_ypParamLike.Cfqxts_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.CFQXTS_CODE LIKE '%'||:cfqxts_code||'%' ");
                    OracleParameter pCfqxts_code = new OracleParameter(":cfqxts_code", OracleDbType.NVarchar2);
                    pCfqxts_code.Direction = ParameterDirection.Input;
                    pCfqxts_code.Value = jc_ypParamLike.Cfqxts_code;
                    sqlparams.Add(pCfqxts_code);
                }

                if (null != jc_ypParamLike.Ps_code && "" != jc_ypParamLike.Ps_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.PS_CODE LIKE '%'||:ps_code||'%' ");
                    OracleParameter pPs_code = new OracleParameter(":ps_code", OracleDbType.NVarchar2);
                    pPs_code.Direction = ParameterDirection.Input;
                    pPs_code.Value = jc_ypParamLike.Ps_code;
                    sqlparams.Add(pPs_code);
                }

                if (null != jc_ypParamLike.Yplx_code && "" != jc_ypParamLike.Yplx_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YPLX_CODE LIKE '%'||:yplx_code||'%' ");
                    OracleParameter pYplx_code = new OracleParameter(":yplx_code", OracleDbType.NVarchar2);
                    pYplx_code.Direction = ParameterDirection.Input;
                    pYplx_code.Value = jc_ypParamLike.Yplx_code;
                    sqlparams.Add(pYplx_code);
                }

                if (null != jc_ypParamLike.Ypmssyz && "" != jc_ypParamLike.Ypmssyz)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YPMSSYZ LIKE '%'||:ypmssyz||'%' ");
                    OracleParameter pYpmssyz = new OracleParameter(":ypmssyz", OracleDbType.NVarchar2);
                    pYpmssyz.Direction = ParameterDirection.Input;
                    pYpmssyz.Value = jc_ypParamLike.Ypmssyz;
                    sqlparams.Add(pYpmssyz);
                }

                if (null != jc_ypParamLike.Ypmsjjz && "" != jc_ypParamLike.Ypmsjjz)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YPMSJJZ LIKE '%'||:ypmsjjz||'%' ");
                    OracleParameter pYpmsjjz = new OracleParameter(":ypmsjjz", OracleDbType.NVarchar2);
                    pYpmsjjz.Direction = ParameterDirection.Input;
                    pYpmsjjz.Value = jc_ypParamLike.Ypmsjjz;
                    sqlparams.Add(pYpmsjjz);
                }

                if (null != jc_ypParamLike.Ypmsyfhbrqjy_code && "" != jc_ypParamLike.Ypmsyfhbrqjy_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YPMSYFHBRQJY_CODE LIKE '%'||:ypmsyfhbrqjy_code||'%' ");
                    OracleParameter pYpmsyfhbrqjy_code = new OracleParameter(":ypmsyfhbrqjy_code", OracleDbType.NVarchar2);
                    pYpmsyfhbrqjy_code.Direction = ParameterDirection.Input;
                    pYpmsyfhbrqjy_code.Value = jc_ypParamLike.Ypmsyfhbrqjy_code;
                    sqlparams.Add(pYpmsyfhbrqjy_code);
                }

                if (null != jc_ypParamLike.Ypmsblfy && "" != jc_ypParamLike.Ypmsblfy)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YPMSBLFY LIKE '%'||:ypmsblfy||'%' ");
                    OracleParameter pYpmsblfy = new OracleParameter(":ypmsblfy", OracleDbType.NVarchar2);
                    pYpmsblfy.Direction = ParameterDirection.Input;
                    pYpmsblfy.Value = jc_ypParamLike.Ypmsblfy;
                    sqlparams.Add(pYpmsblfy);
                }

                if (null != jc_ypParamLike.Ypfl_code && "" != jc_ypParamLike.Ypfl_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YPFL_CODE LIKE '%'||:ypfl_code||'%' ");
                    OracleParameter pYpfl_code = new OracleParameter(":ypfl_code", OracleDbType.NVarchar2);
                    pYpfl_code.Direction = ParameterDirection.Input;
                    pYpfl_code.Value = jc_ypParamLike.Ypfl_code;
                    sqlparams.Add(pYpfl_code);
                }

                if (null != jc_ypParamLike.Yjjb_code && "" != jc_ypParamLike.Yjjb_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YJJB_CODE LIKE '%'||:yjjb_code||'%' ");
                    OracleParameter pYjjb_code = new OracleParameter(":yjjb_code", OracleDbType.NVarchar2);
                    pYjjb_code.Direction = ParameterDirection.Input;
                    pYjjb_code.Value = jc_ypParamLike.Yjjb_code;
                    sqlparams.Add(pYjjb_code);
                }

                if (null != jc_ypParamLike.Txm && "" != jc_ypParamLike.Txm)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.TXM LIKE '%'||:txm||'%' ");
                    OracleParameter pTxm = new OracleParameter(":txm", OracleDbType.NVarchar2);
                    pTxm.Direction = ParameterDirection.Input;
                    pTxm.Value = jc_ypParamLike.Txm;
                    sqlparams.Add(pTxm);
                }

                if (null != jc_ypParamLike.Ewm && "" != jc_ypParamLike.Ewm)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.EWM LIKE '%'||:ewm||'%' ");
                    OracleParameter pEwm = new OracleParameter(":ewm", OracleDbType.NVarchar2);
                    pEwm.Direction = ParameterDirection.Input;
                    pEwm.Value = jc_ypParamLike.Ewm;
                    sqlparams.Add(pEwm);
                }

                if (null != jc_ypParamLike.Pym && "" != jc_ypParamLike.Pym)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.PYM LIKE '%'||:pym||'%' ");
                    OracleParameter pPym = new OracleParameter(":pym", OracleDbType.NVarchar2);
                    pPym.Direction = ParameterDirection.Input;
                    pPym.Value = jc_ypParamLike.Pym;
                    sqlparams.Add(pPym);
                }

                if (null != jc_ypParamLike.Sfcly_code && "" != jc_ypParamLike.Sfcly_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.SFCLY_CODE LIKE '%'||:sfcly_code||'%' ");
                    OracleParameter pSfcly_code = new OracleParameter(":sfcly_code", OracleDbType.NVarchar2);
                    pSfcly_code.Direction = ParameterDirection.Input;
                    pSfcly_code.Value = jc_ypParamLike.Sfcly_code;
                    sqlparams.Add(pSfcly_code);
                }

                if (null != jc_ypParamLike.Sfclm_code && "" != jc_ypParamLike.Sfclm_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.SFCLM_CODE LIKE '%'||:sfclm_code||'%' ");
                    OracleParameter pSfclm_code = new OracleParameter(":sfclm_code", OracleDbType.NVarchar2);
                    pSfclm_code.Direction = ParameterDirection.Input;
                    pSfclm_code.Value = jc_ypParamLike.Sfclm_code;
                    sqlparams.Add(pSfclm_code);
                }

                if (null != jc_ypParamLike.Yxzt_code && "" != jc_ypParamLike.Yxzt_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YXZT_CODE LIKE '%'||:yxzt_code||'%' ");
                    OracleParameter pYxzt_code = new OracleParameter(":yxzt_code", OracleDbType.NVarchar2);
                    pYxzt_code.Direction = ParameterDirection.Input;
                    pYxzt_code.Value = jc_ypParamLike.Yxzt_code;
                    sqlparams.Add(pYxzt_code);
                }

                if (null != jc_ypParamLike.Scqy && "" != jc_ypParamLike.Scqy)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.SCQY LIKE '%'||:scqy||'%' ");
                    OracleParameter pScqy = new OracleParameter(":scqy", OracleDbType.NVarchar2);
                    pScqy.Direction = ParameterDirection.Input;
                    pScqy.Value = jc_ypParamLike.Scqy;
                    sqlparams.Add(pScqy);
                }

                if (null != jc_ypParamLike.Sfkss_code && "" != jc_ypParamLike.Sfkss_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.SFKSS_CODE LIKE '%'||:sfkss_code||'%' ");
                    OracleParameter pSfkss_code = new OracleParameter(":sfkss_code", OracleDbType.NVarchar2);
                    pSfkss_code.Direction = ParameterDirection.Input;
                    pSfkss_code.Value = jc_ypParamLike.Sfkss_code;
                    sqlparams.Add(pSfkss_code);
                }

                if (null != jc_ypParamLike.Zfbz && "" != jc_ypParamLike.Zfbz)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.ZFBZ LIKE '%'||:zfbz||'%' ");
                    OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                    pZfbz.Direction = ParameterDirection.Input;
                    pZfbz.Value = jc_ypParamLike.Zfbz;
                    sqlparams.Add(pZfbz);
                }

            }

            this.b_isWhere = false;
            return Int32.Parse(OracleHelper.ExecuteScalar(sql.ToString(), sqlparams.ToArray()).ToString());
        }


        /// <summary>
        /// 通用的保存方法，根据用户传入的参数，有ID为修改，没有ID为新增(手动生成OracleConnection对象，此方法用于事务，使用事务必须使用同一个OracleConnection对象)
        /// </summary>
        /// <param name="jc_ypParam"></param>
        /// <returns></returns>
        public bool save(Jc_yp jc_ypParam, OracleConnection con)
        {
            if ("" != jc_ypParam.Id && null != jc_ypParam.Id)
            {
                //修改
                return this.updateById(jc_ypParam, con);
            }
            else
            {
                //新增
                return this.insert(jc_ypParam, con);
            }
        }

        /// <summary>
        /// 把dataset中的一行转换为model
        /// </summary>
        /// <param name="row"></param>
        /// <returns></returns>
        private Jc_yp dataSetToModel(DataRow row)
        {
            Jc_yp jc_ypParam = new Jc_yp();
            jc_ypParam.Id = Convert.ToString(row["ID"]).Trim();
            jc_ypParam.Ypbm = Convert.ToString(row["YPBM"]).Trim();
            jc_ypParam.Ypmc = Convert.ToString(row["YPMC"]).Trim();
            jc_ypParam.Yptymc = Convert.ToString(row["YPTYMC"]).Trim();
            jc_ypParam.Ypcf = Convert.ToString(row["YPCF"]).Trim();
            jc_ypParam.Yppzwh = Convert.ToString(row["YPPZWH"]).Trim();
            jc_ypParam.Ypzczh = Convert.ToString(row["YPZCZH"]).Trim();
            jc_ypParam.Gyzz = Convert.ToString(row["GYZZ"]).Trim();
            jc_ypParam.Ypjx_code = Convert.ToString(row["YPJX_CODE"]).Trim();
            jc_ypParam.Ypgg = Convert.ToString(row["YPGG"]).Trim();
            jc_ypParam.Ypdcyl = (decimal?)this.convertDBNullValue(row["YPDCYL"]);
            jc_ypParam.Ypdcyldw_code = Convert.ToString(row["YPDCYLDW_CODE"]).Trim();
            jc_ypParam.Ypyytj_code = Convert.ToString(row["YPYYTJ_CODE"]).Trim();
            jc_ypParam.Ddw_code = Convert.ToString(row["DDW_CODE"]).Trim();
            jc_ypParam.Xdw_code = Convert.ToString(row["XDW_CODE"]).Trim();
            jc_ypParam.Cfybz_code = Convert.ToString(row["CFYBZ_CODE"]).Trim();
            jc_ypParam.Cfqxjy_code = Convert.ToString(row["CFQXJY_CODE"]).Trim();
            jc_ypParam.Cfqxyb_code = Convert.ToString(row["CFQXYB_CODE"]).Trim();
            jc_ypParam.Cfqxdm_code = Convert.ToString(row["CFQXDM_CODE"]).Trim();
            jc_ypParam.Cfqxjs_code = Convert.ToString(row["CFQXJS_CODE"]).Trim();
            jc_ypParam.Cfqxgz_code = Convert.ToString(row["CFQXGZ_CODE"]).Trim();
            jc_ypParam.Cfqxjk_code = Convert.ToString(row["CFQXJK_CODE"]).Trim();
            jc_ypParam.Cfqxzz_code = Convert.ToString(row["CFQXZZ_CODE"]).Trim();
            jc_ypParam.Cfqxzf_code = Convert.ToString(row["CFQXZF_CODE"]).Trim();
            jc_ypParam.Cfqxts_code = Convert.ToString(row["CFQXTS_CODE"]).Trim();
            jc_ypParam.Ps_code = Convert.ToString(row["PS_CODE"]).Trim();
            jc_ypParam.Yplx_code = Convert.ToString(row["YPLX_CODE"]).Trim();
            jc_ypParam.Ypmssyz = Convert.ToString(row["YPMSSYZ"]).Trim();
            jc_ypParam.Ypmsjjz = Convert.ToString(row["YPMSJJZ"]).Trim();
            jc_ypParam.Ypmsyfhbrqjy_code = Convert.ToString(row["YPMSYFHBRQJY_CODE"]).Trim();
            jc_ypParam.Ypmsblfy = Convert.ToString(row["YPMSBLFY"]).Trim();
            jc_ypParam.Ypfl_code = Convert.ToString(row["YPFL_CODE"]).Trim();
            jc_ypParam.Yjjb_code = Convert.ToString(row["YJJB_CODE"]).Trim();
            jc_ypParam.Txm = Convert.ToString(row["TXM"]).Trim();
            jc_ypParam.Ewm = Convert.ToString(row["EWM"]).Trim();
            jc_ypParam.Pym = Convert.ToString(row["PYM"]).Trim();
            jc_ypParam.Hsxs = (decimal?)this.convertDBNullValue(row["HSXS"]);
            jc_ypParam.Sfcly_code = Convert.ToString(row["SFCLY_CODE"]).Trim();
            jc_ypParam.Bzpfj = (decimal?)this.convertDBNullValue(row["BZPFJ"]);
            jc_ypParam.Bzlsj = (decimal?)this.convertDBNullValue(row["BZLSJ"]);
            jc_ypParam.Bzmzj = (decimal?)this.convertDBNullValue(row["BZMZJ"]);
            jc_ypParam.Bzzyj = (decimal?)this.convertDBNullValue(row["BZZYJ"]);
            jc_ypParam.Hsbl = (decimal?)this.convertDBNullValue(row["HSBL"]);
            jc_ypParam.Sfclm_code = Convert.ToString(row["SFCLM_CODE"]).Trim();
            jc_ypParam.Yxzt_code = Convert.ToString(row["YXZT_CODE"]).Trim();
            jc_ypParam.Dcsxyl = (decimal?)this.convertDBNullValue(row["DCSXYL"]);
            jc_ypParam.Dcxxyl = (decimal?)this.convertDBNullValue(row["DCXXYL"]);
            jc_ypParam.Lxylts = (decimal?)this.convertDBNullValue(row["LXYLTS"]);
            jc_ypParam.Lxylcs = (decimal?)this.convertDBNullValue(row["LXYLCS"]);
            jc_ypParam.Scqy = Convert.ToString(row["SCQY"]).Trim();
            jc_ypParam.Pzrq = (DateTime?)this.convertDBNullValue(row["PZRQ"]);
            jc_ypParam.Sfkss_code = Convert.ToString(row["SFKSS_CODE"]).Trim();
            jc_ypParam.Zfbz = Convert.ToString(row["ZFBZ"]).Trim();
            jc_ypParam.Dcyldwbl = (decimal?)this.convertDBNullValue(row["DCYLDWBL"]);

            return jc_ypParam;
        }



        //*******************在此以后添加新的方法start
        #region DAL层的implement,实现，start

        /// <summary>
        /// 把dataset中的一行转换为model, 包括相关联的外键对象
        /// </summary>
        /// <param name="row"></param>
        /// <returns></returns>
        private Jc_yp dataSetContactObjectsToModel(DataRow row)
        {
            Jc_yp jc_ypParam = this.dataSetToModel(row);

            //添加代码类别实体对象,剂型,cv5301.01药物剂型代码(关联代码表)对象
            Jc_code ypjxCode = new Jc_code();
            ypjxCode.Id = Convert.ToString(row["YPJX_CODE_ID"]).Trim();
            ypjxCode.Name = Convert.ToString(row["YPJX_CODE_NAME"]).Trim();
            ypjxCode.Value = Convert.ToString(row["YPJX_CODE_VALUE"]).Trim();
            ypjxCode.Fk_code_type = Convert.ToString(row["YPJX_CODE_FKCODETYPE"]).Trim();
            ypjxCode.Zfbz = Convert.ToString(row["YPJX_CODE_ZFBZ"]).Trim();
            ypjxCode.Remark = Convert.ToString(row["YPJX_CODE_REMARK"]).Trim();
            jc_ypParam.YpjxCode = ypjxCode;

            //添加代码类别实体对象,药品单次用量单位(关联代码表)对象
            Jc_code ypdcyldwCode = new Jc_code();
            ypdcyldwCode.Id = Convert.ToString(row["YPDCYLDW_CODE_ID"]).Trim();
            ypdcyldwCode.Name = Convert.ToString(row["YPDCYLDW_CODE_NAME"]).Trim();
            ypdcyldwCode.Value = Convert.ToString(row["YPDCYLDW_CODE_VALUE"]).Trim();
            ypdcyldwCode.Fk_code_type = Convert.ToString(row["YPDCYLDW_CODE_FKCODETYPE"]).Trim();
            ypdcyldwCode.Zfbz = Convert.ToString(row["YPDCYLDW_CODE_ZFBZ"]).Trim();
            ypdcyldwCode.Remark = Convert.ToString(row["YPDCYLDW_CODE_REMARK"]).Trim();
            jc_ypParam.YpdcyldwCode = ypdcyldwCode;

            //添加代码类别实体对象,用量用法,cv5201.22用药途径代码(关联代码表)对象
            Jc_code ypyytjCode = new Jc_code();
            ypyytjCode.Id = Convert.ToString(row["YPYYTJ_CODE_ID"]).Trim();
            ypyytjCode.Name = Convert.ToString(row["YPYYTJ_CODE_NAME"]).Trim();
            ypyytjCode.Value = Convert.ToString(row["YPYYTJ_CODE_VALUE"]).Trim();
            ypyytjCode.Fk_code_type = Convert.ToString(row["YPYYTJ_CODE_FKCODETYPE"]).Trim();
            ypyytjCode.Zfbz = Convert.ToString(row["YPYYTJ_CODE_ZFBZ"]).Trim();
            ypyytjCode.Remark = Convert.ToString(row["YPYYTJ_CODE_REMARK"]).Trim();
            jc_ypParam.YpyytjCode = ypyytjCode;

            //添加代码类别实体对象,大单位(药品大单位，关联代码表)对象
            Jc_code ddwCode = new Jc_code();
            ddwCode.Id = Convert.ToString(row["DDW_CODE_ID"]).Trim();
            ddwCode.Name = Convert.ToString(row["DDW_CODE_NAME"]).Trim();
            ddwCode.Value = Convert.ToString(row["DDW_CODE_VALUE"]).Trim();
            ddwCode.Fk_code_type = Convert.ToString(row["DDW_CODE_FKCODETYPE"]).Trim();
            ddwCode.Zfbz = Convert.ToString(row["DDW_CODE_ZFBZ"]).Trim();
            ddwCode.Remark = Convert.ToString(row["DDW_CODE_REMARK"]).Trim();
            jc_ypParam.DdwCode = ddwCode;

            //添加代码类别实体对象,小单位(药品小单位，关联代码表)对象
            Jc_code xdwCode = new Jc_code();
            xdwCode.Id = Convert.ToString(row["XDW_CODE_ID"]).Trim();
            xdwCode.Name = Convert.ToString(row["XDW_CODE_NAME"]).Trim();
            xdwCode.Value = Convert.ToString(row["XDW_CODE_VALUE"]).Trim();
            xdwCode.Fk_code_type = Convert.ToString(row["XDW_CODE_FKCODETYPE"]).Trim();
            xdwCode.Zfbz = Convert.ToString(row["XDW_CODE_ZFBZ"]).Trim();
            xdwCode.Remark = Convert.ToString(row["XDW_CODE_REMARK"]).Trim();
            jc_ypParam.XdwCode = xdwCode;

            //添加代码类别实体对象,处方药标志（rx  otc）(是否，关联代码表)对象
            Jc_code cfybzCode = new Jc_code();
            cfybzCode.Id = Convert.ToString(row["CFYBZ_CODE_ID"]).Trim();
            cfybzCode.Name = Convert.ToString(row["CFYBZ_CODE_NAME"]).Trim();
            cfybzCode.Value = Convert.ToString(row["CFYBZ_CODE_VALUE"]).Trim();
            cfybzCode.Fk_code_type = Convert.ToString(row["CFYBZ_CODE_FKCODETYPE"]).Trim();
            cfybzCode.Zfbz = Convert.ToString(row["CFYBZ_CODE_ZFBZ"]).Trim();
            cfybzCode.Remark = Convert.ToString(row["CFYBZ_CODE_REMARK"]).Trim();
            jc_ypParam.CfybzCode = cfybzCode;

            //添加代码类别实体对象,处方权限基药(是否，关联代码表)对象
            Jc_code cfqxjyCode = new Jc_code();
            cfqxjyCode.Id = Convert.ToString(row["CFQXJY_CODE_ID"]).Trim();
            cfqxjyCode.Name = Convert.ToString(row["CFQXJY_CODE_NAME"]).Trim();
            cfqxjyCode.Value = Convert.ToString(row["CFQXJY_CODE_VALUE"]).Trim();
            cfqxjyCode.Fk_code_type = Convert.ToString(row["CFQXJY_CODE_FKCODETYPE"]).Trim();
            cfqxjyCode.Zfbz = Convert.ToString(row["CFQXJY_CODE_ZFBZ"]).Trim();
            cfqxjyCode.Remark = Convert.ToString(row["CFQXJY_CODE_REMARK"]).Trim();
            jc_ypParam.CfqxjyCode = cfqxjyCode;

            //添加代码类别实体对象,处方权限医保(是否，关联代码表)对象
            Jc_code cfqxybCode = new Jc_code();
            cfqxybCode.Id = Convert.ToString(row["CFQXYB_CODE_ID"]).Trim();
            cfqxybCode.Name = Convert.ToString(row["CFQXYB_CODE_NAME"]).Trim();
            cfqxybCode.Value = Convert.ToString(row["CFQXYB_CODE_VALUE"]).Trim();
            cfqxybCode.Fk_code_type = Convert.ToString(row["CFQXYB_CODE_FKCODETYPE"]).Trim();
            cfqxybCode.Zfbz = Convert.ToString(row["CFQXYB_CODE_ZFBZ"]).Trim();
            cfqxybCode.Remark = Convert.ToString(row["CFQXYB_CODE_REMARK"]).Trim();
            jc_ypParam.CfqxybCode = cfqxybCode;

            //添加代码类别实体对象,处方权限毒麻(是否，关联代码表)对象
            Jc_code cfqxdmCode = new Jc_code();
            cfqxdmCode.Id = Convert.ToString(row["CFQXDM_CODE_ID"]).Trim();
            cfqxdmCode.Name = Convert.ToString(row["CFQXDM_CODE_NAME"]).Trim();
            cfqxdmCode.Value = Convert.ToString(row["CFQXDM_CODE_VALUE"]).Trim();
            cfqxdmCode.Fk_code_type = Convert.ToString(row["CFQXDM_CODE_FKCODETYPE"]).Trim();
            cfqxdmCode.Zfbz = Convert.ToString(row["CFQXDM_CODE_ZFBZ"]).Trim();
            cfqxdmCode.Remark = Convert.ToString(row["CFQXDM_CODE_REMARK"]).Trim();
            jc_ypParam.CfqxdmCode = cfqxdmCode;

            //添加代码类别实体对象,处方权限精神(是否，关联代码表)对象
            Jc_code cfqxjsCode = new Jc_code();
            cfqxjsCode.Id = Convert.ToString(row["CFQXJS_CODE_ID"]).Trim();
            cfqxjsCode.Name = Convert.ToString(row["CFQXJS_CODE_NAME"]).Trim();
            cfqxjsCode.Value = Convert.ToString(row["CFQXJS_CODE_VALUE"]).Trim();
            cfqxjsCode.Fk_code_type = Convert.ToString(row["CFQXJS_CODE_FKCODETYPE"]).Trim();
            cfqxjsCode.Zfbz = Convert.ToString(row["CFQXJS_CODE_ZFBZ"]).Trim();
            cfqxjsCode.Remark = Convert.ToString(row["CFQXJS_CODE_REMARK"]).Trim();
            jc_ypParam.CfqxjsCode = cfqxjsCode;

            //添加代码类别实体对象,处方权限贵重(是否，关联代码表)对象
            Jc_code cfqxgzCode = new Jc_code();
            cfqxgzCode.Id = Convert.ToString(row["CFQXGZ_CODE_ID"]).Trim();
            cfqxgzCode.Name = Convert.ToString(row["CFQXGZ_CODE_NAME"]).Trim();
            cfqxgzCode.Value = Convert.ToString(row["CFQXGZ_CODE_VALUE"]).Trim();
            cfqxgzCode.Fk_code_type = Convert.ToString(row["CFQXGZ_CODE_FKCODETYPE"]).Trim();
            cfqxgzCode.Zfbz = Convert.ToString(row["CFQXGZ_CODE_ZFBZ"]).Trim();
            cfqxgzCode.Remark = Convert.ToString(row["CFQXGZ_CODE_REMARK"]).Trim();
            jc_ypParam.CfqxgzCode = cfqxgzCode;

            //添加代码类别实体对象,处方权限进口(是否，关联代码表)对象
            Jc_code cfqxjkCode = new Jc_code();
            cfqxjkCode.Id = Convert.ToString(row["CFQXJK_CODE_ID"]).Trim();
            cfqxjkCode.Name = Convert.ToString(row["CFQXJK_CODE_NAME"]).Trim();
            cfqxjkCode.Value = Convert.ToString(row["CFQXJK_CODE_VALUE"]).Trim();
            cfqxjkCode.Fk_code_type = Convert.ToString(row["CFQXJK_CODE_FKCODETYPE"]).Trim();
            cfqxjkCode.Zfbz = Convert.ToString(row["CFQXJK_CODE_ZFBZ"]).Trim();
            cfqxjkCode.Remark = Convert.ToString(row["CFQXJK_CODE_REMARK"]).Trim();
            jc_ypParam.CfqxjkCode = cfqxjkCode;

            //添加代码类别实体对象,处方权限自制(是否，关联代码表)对象
            Jc_code cfqxzzCode = new Jc_code();
            cfqxzzCode.Id = Convert.ToString(row["CFQXZZ_CODE_ID"]).Trim();
            cfqxzzCode.Name = Convert.ToString(row["CFQXZZ_CODE_NAME"]).Trim();
            cfqxzzCode.Value = Convert.ToString(row["CFQXZZ_CODE_VALUE"]).Trim();
            cfqxzzCode.Fk_code_type = Convert.ToString(row["CFQXZZ_CODE_FKCODETYPE"]).Trim();
            cfqxzzCode.Zfbz = Convert.ToString(row["CFQXZZ_CODE_ZFBZ"]).Trim();
            cfqxzzCode.Remark = Convert.ToString(row["CFQXZZ_CODE_REMARK"]).Trim();
            jc_ypParam.CfqxzzCode = cfqxzzCode;

            //添加代码类别实体对象,处方权限自费(是否，关联代码表)对象
            Jc_code cfqxzfCode = new Jc_code();
            cfqxzfCode.Id = Convert.ToString(row["CFQXZF_CODE_ID"]).Trim();
            cfqxzfCode.Name = Convert.ToString(row["CFQXZF_CODE_NAME"]).Trim();
            cfqxzfCode.Value = Convert.ToString(row["CFQXZF_CODE_VALUE"]).Trim();
            cfqxzfCode.Fk_code_type = Convert.ToString(row["CFQXZF_CODE_FKCODETYPE"]).Trim();
            cfqxzfCode.Zfbz = Convert.ToString(row["CFQXZF_CODE_ZFBZ"]).Trim();
            cfqxzfCode.Remark = Convert.ToString(row["CFQXZF_CODE_REMARK"]).Trim();
            jc_ypParam.CfqxzfCode = cfqxzfCode;

            //添加代码类别实体对象,处方权限特殊(是否，关联代码表)对象
            Jc_code cfqxtsCode = new Jc_code();
            cfqxtsCode.Id = Convert.ToString(row["CFQXTS_CODE_ID"]).Trim();
            cfqxtsCode.Name = Convert.ToString(row["CFQXTS_CODE_NAME"]).Trim();
            cfqxtsCode.Value = Convert.ToString(row["CFQXTS_CODE_VALUE"]).Trim();
            cfqxtsCode.Fk_code_type = Convert.ToString(row["CFQXTS_CODE_FKCODETYPE"]).Trim();
            cfqxtsCode.Zfbz = Convert.ToString(row["CFQXTS_CODE_ZFBZ"]).Trim();
            cfqxtsCode.Remark = Convert.ToString(row["CFQXTS_CODE_REMARK"]).Trim();
            jc_ypParam.CfqxtsCode = cfqxtsCode;

            //添加代码类别实体对象,皮试(是否，关联代码表)对象
            Jc_code psCode = new Jc_code();
            psCode.Id = Convert.ToString(row["PS_CODE_ID"]).Trim();
            psCode.Name = Convert.ToString(row["PS_CODE_NAME"]).Trim();
            psCode.Value = Convert.ToString(row["PS_CODE_VALUE"]).Trim();
            psCode.Fk_code_type = Convert.ToString(row["PS_CODE_FKCODETYPE"]).Trim();
            psCode.Zfbz = Convert.ToString(row["PS_CODE_ZFBZ"]).Trim();
            psCode.Remark = Convert.ToString(row["PS_CODE_REMARK"]).Trim();
            jc_ypParam.PsCode = psCode;

            //添加代码类别实体对象,cv5301.06药物类型代码(关联代码表)对象
            Jc_code yplxCode = new Jc_code();
            yplxCode.Id = Convert.ToString(row["YPLX_CODE_ID"]).Trim();
            yplxCode.Name = Convert.ToString(row["YPLX_CODE_NAME"]).Trim();
            yplxCode.Value = Convert.ToString(row["YPLX_CODE_VALUE"]).Trim();
            yplxCode.Fk_code_type = Convert.ToString(row["YPLX_CODE_FKCODETYPE"]).Trim();
            yplxCode.Zfbz = Convert.ToString(row["YPLX_CODE_ZFBZ"]).Trim();
            yplxCode.Remark = Convert.ToString(row["YPLX_CODE_REMARK"]).Trim();
            jc_ypParam.YplxCode = yplxCode;

            //添加代码类别实体对象,药品描述孕妇或哺乳期禁用(是否，关联代码表)对象
            Jc_code ypmsyfhbrqjyCode = new Jc_code();
            ypmsyfhbrqjyCode.Id = Convert.ToString(row["YPMSYFHBRQJY_CODE_ID"]).Trim();
            ypmsyfhbrqjyCode.Name = Convert.ToString(row["YPMSYFHBRQJY_CODE_NAME"]).Trim();
            ypmsyfhbrqjyCode.Value = Convert.ToString(row["YPMSYFHBRQJY_CODE_VALUE"]).Trim();
            ypmsyfhbrqjyCode.Fk_code_type = Convert.ToString(row["YPMSYFHBRQJY_CODE_FKCODETYPE"]).Trim();
            ypmsyfhbrqjyCode.Zfbz = Convert.ToString(row["YPMSYFHBRQJY_CODE_ZFBZ"]).Trim();
            ypmsyfhbrqjyCode.Remark = Convert.ToString(row["YPMSYFHBRQJY_CODE_REMARK"]).Trim();
            jc_ypParam.YpmsyfhbrqjyCode = ypmsyfhbrqjyCode;

            //添加代码类别实体对象,药品分类(关联代码表)对象
            Jc_code ypflCode = new Jc_code();
            ypflCode.Id = Convert.ToString(row["YPFL_CODE_ID"]).Trim();
            ypflCode.Name = Convert.ToString(row["YPFL_CODE_NAME"]).Trim();
            ypflCode.Value = Convert.ToString(row["YPFL_CODE_VALUE"]).Trim();
            ypflCode.Fk_code_type = Convert.ToString(row["YPFL_CODE_FKCODETYPE"]).Trim();
            ypflCode.Zfbz = Convert.ToString(row["YPFL_CODE_ZFBZ"]).Trim();
            ypflCode.Remark = Convert.ToString(row["YPFL_CODE_REMARK"]).Trim();
            jc_ypParam.YpflCode = ypflCode;

            //添加代码类别实体对象,药价级别(关联代码表)对象
            Jc_code yjjbCode = new Jc_code();
            yjjbCode.Id = Convert.ToString(row["YJJB_CODE_ID"]).Trim();
            yjjbCode.Name = Convert.ToString(row["YJJB_CODE_NAME"]).Trim();
            yjjbCode.Value = Convert.ToString(row["YJJB_CODE_VALUE"]).Trim();
            yjjbCode.Fk_code_type = Convert.ToString(row["YJJB_CODE_FKCODETYPE"]).Trim();
            yjjbCode.Zfbz = Convert.ToString(row["YJJB_CODE_ZFBZ"]).Trim();
            yjjbCode.Remark = Convert.ToString(row["YJJB_CODE_REMARK"]).Trim();
            jc_ypParam.YjjbCode = yjjbCode;

            //添加代码类别实体对象,是否拆零用(是否，关联代码表)对象
            Jc_code sfclyCode = new Jc_code();
            sfclyCode.Id = Convert.ToString(row["SFCLY_CODE_ID"]).Trim();
            sfclyCode.Name = Convert.ToString(row["SFCLY_CODE_NAME"]).Trim();
            sfclyCode.Value = Convert.ToString(row["SFCLY_CODE_VALUE"]).Trim();
            sfclyCode.Fk_code_type = Convert.ToString(row["SFCLY_CODE_FKCODETYPE"]).Trim();
            sfclyCode.Zfbz = Convert.ToString(row["SFCLY_CODE_ZFBZ"]).Trim();
            sfclyCode.Remark = Convert.ToString(row["SFCLY_CODE_REMARK"]).Trim();
            jc_ypParam.SfclyCode = sfclyCode;

            //添加代码类别实体对象,是否拆零卖(是否，关联代码表)对象
            Jc_code sfclmCode = new Jc_code();
            sfclmCode.Id = Convert.ToString(row["SFCLM_CODE_ID"]).Trim();
            sfclmCode.Name = Convert.ToString(row["SFCLM_CODE_NAME"]).Trim();
            sfclmCode.Value = Convert.ToString(row["SFCLM_CODE_VALUE"]).Trim();
            sfclmCode.Fk_code_type = Convert.ToString(row["SFCLM_CODE_FKCODETYPE"]).Trim();
            sfclmCode.Zfbz = Convert.ToString(row["SFCLM_CODE_ZFBZ"]).Trim();
            sfclmCode.Remark = Convert.ToString(row["SFCLM_CODE_REMARK"]).Trim();
            jc_ypParam.SfclmCode = sfclmCode;

            //添加代码类别实体对象,有效状态（0无效，1有效, 关联代码表）对象
            Jc_code yxztCode = new Jc_code();
            yxztCode.Id = Convert.ToString(row["YXZT_CODE_ID"]).Trim();
            yxztCode.Name = Convert.ToString(row["YXZT_CODE_NAME"]).Trim();
            yxztCode.Value = Convert.ToString(row["YXZT_CODE_VALUE"]).Trim();
            yxztCode.Fk_code_type = Convert.ToString(row["YXZT_CODE_FKCODETYPE"]).Trim();
            yxztCode.Zfbz = Convert.ToString(row["YXZT_CODE_ZFBZ"]).Trim();
            yxztCode.Remark = Convert.ToString(row["YXZT_CODE_REMARK"]).Trim();
            jc_ypParam.YxztCode = yxztCode;

            //添加代码类别实体对象,是否是抗生素（1是，0否，关联代码表）对象
            Jc_code sfkssCode = new Jc_code();
            sfkssCode.Id = Convert.ToString(row["SFKSS_CODE_ID"]).Trim();
            sfkssCode.Name = Convert.ToString(row["SFKSS_CODE_NAME"]).Trim();
            sfkssCode.Value = Convert.ToString(row["SFKSS_CODE_VALUE"]).Trim();
            sfkssCode.Fk_code_type = Convert.ToString(row["SFKSS_CODE_FKCODETYPE"]).Trim();
            sfkssCode.Zfbz = Convert.ToString(row["SFKSS_CODE_ZFBZ"]).Trim();
            sfkssCode.Remark = Convert.ToString(row["SFKSS_CODE_REMARK"]).Trim();
            jc_ypParam.SfkssCode = sfkssCode;

            return jc_ypParam;
        }



        /// <summary>
        /// 查找指定ID的用户,得到相关联的外键对象的方法
        /// </summary>
        /// <remarks>如果id为null、id重复、id未找到就抛异常</remarks>
        /// <returns>Jc_yp</returns>
        public Jc_yp findContactObjectsById(string id)
        {
            if ("" == id || null == id)
            {
                throw new Exception("主键ID不能为空，请赋值");
            }
            StringBuilder sql = new StringBuilder("SELECT A.* ");
            //新建方法findContactObjectsById，在此加入多表连接要显示的项start
            //sql.Append(",B.字段一,B.字段二,B.字段三");

            sql.Append(@"
            ,TT_YPJX_CODE.ID AS YPJX_CODE_ID,TT_YPJX_CODE.NAME AS YPJX_CODE_NAME,TT_YPJX_CODE.VALUE AS YPJX_CODE_VALUE,TT_YPJX_CODE.FK_CODE_TYPE AS YPJX_CODE_FKCODETYPE,TT_YPJX_CODE.ZFBZ AS YPJX_CODE_ZFBZ,TT_YPJX_CODE.REMARK AS YPJX_CODE_REMARK
            ");

            sql.Append(@"
            ,TT_YPDCYLDW_CODE.ID AS YPDCYLDW_CODE_ID,TT_YPDCYLDW_CODE.NAME AS YPDCYLDW_CODE_NAME,TT_YPDCYLDW_CODE.VALUE AS YPDCYLDW_CODE_VALUE,TT_YPDCYLDW_CODE.FK_CODE_TYPE AS YPDCYLDW_CODE_FKCODETYPE,TT_YPDCYLDW_CODE.ZFBZ AS YPDCYLDW_CODE_ZFBZ,TT_YPDCYLDW_CODE.REMARK AS YPDCYLDW_CODE_REMARK
            ");

            sql.Append(@"
            ,TT_YPYYTJ_CODE.ID AS YPYYTJ_CODE_ID,TT_YPYYTJ_CODE.NAME AS YPYYTJ_CODE_NAME,TT_YPYYTJ_CODE.VALUE AS YPYYTJ_CODE_VALUE,TT_YPYYTJ_CODE.FK_CODE_TYPE AS YPYYTJ_CODE_FKCODETYPE,TT_YPYYTJ_CODE.ZFBZ AS YPYYTJ_CODE_ZFBZ,TT_YPYYTJ_CODE.REMARK AS YPYYTJ_CODE_REMARK
            ");

            sql.Append(@"
            ,TT_DDW_CODE.ID AS DDW_CODE_ID,TT_DDW_CODE.NAME AS DDW_CODE_NAME,TT_DDW_CODE.VALUE AS DDW_CODE_VALUE,TT_DDW_CODE.FK_CODE_TYPE AS DDW_CODE_FKCODETYPE,TT_DDW_CODE.ZFBZ AS DDW_CODE_ZFBZ,TT_DDW_CODE.REMARK AS DDW_CODE_REMARK
            ");

            sql.Append(@"
            ,TT_XDW_CODE.ID AS XDW_CODE_ID,TT_XDW_CODE.NAME AS XDW_CODE_NAME,TT_XDW_CODE.VALUE AS XDW_CODE_VALUE,TT_XDW_CODE.FK_CODE_TYPE AS XDW_CODE_FKCODETYPE,TT_XDW_CODE.ZFBZ AS XDW_CODE_ZFBZ,TT_XDW_CODE.REMARK AS XDW_CODE_REMARK
            ");

            sql.Append(@"
            ,TT_CFYBZ_CODE.ID AS CFYBZ_CODE_ID,TT_CFYBZ_CODE.NAME AS CFYBZ_CODE_NAME,TT_CFYBZ_CODE.VALUE AS CFYBZ_CODE_VALUE,TT_CFYBZ_CODE.FK_CODE_TYPE AS CFYBZ_CODE_FKCODETYPE,TT_CFYBZ_CODE.ZFBZ AS CFYBZ_CODE_ZFBZ,TT_CFYBZ_CODE.REMARK AS CFYBZ_CODE_REMARK
            ");

            sql.Append(@"
            ,TT_CFQXJY_CODE.ID AS CFQXJY_CODE_ID,TT_CFQXJY_CODE.NAME AS CFQXJY_CODE_NAME,TT_CFQXJY_CODE.VALUE AS CFQXJY_CODE_VALUE,TT_CFQXJY_CODE.FK_CODE_TYPE AS CFQXJY_CODE_FKCODETYPE,TT_CFQXJY_CODE.ZFBZ AS CFQXJY_CODE_ZFBZ,TT_CFQXJY_CODE.REMARK AS CFQXJY_CODE_REMARK
            ");

            sql.Append(@"
            ,TT_CFQXYB_CODE.ID AS CFQXYB_CODE_ID,TT_CFQXYB_CODE.NAME AS CFQXYB_CODE_NAME,TT_CFQXYB_CODE.VALUE AS CFQXYB_CODE_VALUE,TT_CFQXYB_CODE.FK_CODE_TYPE AS CFQXYB_CODE_FKCODETYPE,TT_CFQXYB_CODE.ZFBZ AS CFQXYB_CODE_ZFBZ,TT_CFQXYB_CODE.REMARK AS CFQXYB_CODE_REMARK
            ");

            sql.Append(@"
            ,TT_CFQXDM_CODE.ID AS CFQXDM_CODE_ID,TT_CFQXDM_CODE.NAME AS CFQXDM_CODE_NAME,TT_CFQXDM_CODE.VALUE AS CFQXDM_CODE_VALUE,TT_CFQXDM_CODE.FK_CODE_TYPE AS CFQXDM_CODE_FKCODETYPE,TT_CFQXDM_CODE.ZFBZ AS CFQXDM_CODE_ZFBZ,TT_CFQXDM_CODE.REMARK AS CFQXDM_CODE_REMARK
            ");

            sql.Append(@"
            ,TT_CFQXJS_CODE.ID AS CFQXJS_CODE_ID,TT_CFQXJS_CODE.NAME AS CFQXJS_CODE_NAME,TT_CFQXJS_CODE.VALUE AS CFQXJS_CODE_VALUE,TT_CFQXJS_CODE.FK_CODE_TYPE AS CFQXJS_CODE_FKCODETYPE,TT_CFQXJS_CODE.ZFBZ AS CFQXJS_CODE_ZFBZ,TT_CFQXJS_CODE.REMARK AS CFQXJS_CODE_REMARK
            ");

            sql.Append(@"
            ,TT_CFQXGZ_CODE.ID AS CFQXGZ_CODE_ID,TT_CFQXGZ_CODE.NAME AS CFQXGZ_CODE_NAME,TT_CFQXGZ_CODE.VALUE AS CFQXGZ_CODE_VALUE,TT_CFQXGZ_CODE.FK_CODE_TYPE AS CFQXGZ_CODE_FKCODETYPE,TT_CFQXGZ_CODE.ZFBZ AS CFQXGZ_CODE_ZFBZ,TT_CFQXGZ_CODE.REMARK AS CFQXGZ_CODE_REMARK
            ");

            sql.Append(@"
            ,TT_CFQXJK_CODE.ID AS CFQXJK_CODE_ID,TT_CFQXJK_CODE.NAME AS CFQXJK_CODE_NAME,TT_CFQXJK_CODE.VALUE AS CFQXJK_CODE_VALUE,TT_CFQXJK_CODE.FK_CODE_TYPE AS CFQXJK_CODE_FKCODETYPE,TT_CFQXJK_CODE.ZFBZ AS CFQXJK_CODE_ZFBZ,TT_CFQXJK_CODE.REMARK AS CFQXJK_CODE_REMARK
            ");

            sql.Append(@"
            ,TT_CFQXZZ_CODE.ID AS CFQXZZ_CODE_ID,TT_CFQXZZ_CODE.NAME AS CFQXZZ_CODE_NAME,TT_CFQXZZ_CODE.VALUE AS CFQXZZ_CODE_VALUE,TT_CFQXZZ_CODE.FK_CODE_TYPE AS CFQXZZ_CODE_FKCODETYPE,TT_CFQXZZ_CODE.ZFBZ AS CFQXZZ_CODE_ZFBZ,TT_CFQXZZ_CODE.REMARK AS CFQXZZ_CODE_REMARK
            ");

            sql.Append(@"
            ,TT_CFQXZF_CODE.ID AS CFQXZF_CODE_ID,TT_CFQXZF_CODE.NAME AS CFQXZF_CODE_NAME,TT_CFQXZF_CODE.VALUE AS CFQXZF_CODE_VALUE,TT_CFQXZF_CODE.FK_CODE_TYPE AS CFQXZF_CODE_FKCODETYPE,TT_CFQXZF_CODE.ZFBZ AS CFQXZF_CODE_ZFBZ,TT_CFQXZF_CODE.REMARK AS CFQXZF_CODE_REMARK
            ");

            sql.Append(@"
            ,TT_CFQXTS_CODE.ID AS CFQXTS_CODE_ID,TT_CFQXTS_CODE.NAME AS CFQXTS_CODE_NAME,TT_CFQXTS_CODE.VALUE AS CFQXTS_CODE_VALUE,TT_CFQXTS_CODE.FK_CODE_TYPE AS CFQXTS_CODE_FKCODETYPE,TT_CFQXTS_CODE.ZFBZ AS CFQXTS_CODE_ZFBZ,TT_CFQXTS_CODE.REMARK AS CFQXTS_CODE_REMARK
            ");

            sql.Append(@"
            ,TT_PS_CODE.ID AS PS_CODE_ID,TT_PS_CODE.NAME AS PS_CODE_NAME,TT_PS_CODE.VALUE AS PS_CODE_VALUE,TT_PS_CODE.FK_CODE_TYPE AS PS_CODE_FKCODETYPE,TT_PS_CODE.ZFBZ AS PS_CODE_ZFBZ,TT_PS_CODE.REMARK AS PS_CODE_REMARK
            ");

            sql.Append(@"
            ,TT_YPLX_CODE.ID AS YPLX_CODE_ID,TT_YPLX_CODE.NAME AS YPLX_CODE_NAME,TT_YPLX_CODE.VALUE AS YPLX_CODE_VALUE,TT_YPLX_CODE.FK_CODE_TYPE AS YPLX_CODE_FKCODETYPE,TT_YPLX_CODE.ZFBZ AS YPLX_CODE_ZFBZ,TT_YPLX_CODE.REMARK AS YPLX_CODE_REMARK
            ");

            sql.Append(@"
            ,TT_YPMSYFHBRQJY_CODE.ID AS YPMSYFHBRQJY_CODE_ID,TT_YPMSYFHBRQJY_CODE.NAME AS YPMSYFHBRQJY_CODE_NAME,TT_YPMSYFHBRQJY_CODE.VALUE AS YPMSYFHBRQJY_CODE_VALUE,TT_YPMSYFHBRQJY_CODE.FK_CODE_TYPE AS YPMSYFHBRQJY_CODE_FKCODETYPE,TT_YPMSYFHBRQJY_CODE.ZFBZ AS YPMSYFHBRQJY_CODE_ZFBZ,TT_YPMSYFHBRQJY_CODE.REMARK AS YPMSYFHBRQJY_CODE_REMARK
            ");

            sql.Append(@"
            ,TT_YPFL_CODE.ID AS YPFL_CODE_ID,TT_YPFL_CODE.NAME AS YPFL_CODE_NAME,TT_YPFL_CODE.VALUE AS YPFL_CODE_VALUE,TT_YPFL_CODE.FK_CODE_TYPE AS YPFL_CODE_FKCODETYPE,TT_YPFL_CODE.ZFBZ AS YPFL_CODE_ZFBZ,TT_YPFL_CODE.REMARK AS YPFL_CODE_REMARK
            ");

            sql.Append(@"
            ,TT_YJJB_CODE.ID AS YJJB_CODE_ID,TT_YJJB_CODE.NAME AS YJJB_CODE_NAME,TT_YJJB_CODE.VALUE AS YJJB_CODE_VALUE,TT_YJJB_CODE.FK_CODE_TYPE AS YJJB_CODE_FKCODETYPE,TT_YJJB_CODE.ZFBZ AS YJJB_CODE_ZFBZ,TT_YJJB_CODE.REMARK AS YJJB_CODE_REMARK
            ");

            sql.Append(@"
            ,TT_SFCLY_CODE.ID AS SFCLY_CODE_ID,TT_SFCLY_CODE.NAME AS SFCLY_CODE_NAME,TT_SFCLY_CODE.VALUE AS SFCLY_CODE_VALUE,TT_SFCLY_CODE.FK_CODE_TYPE AS SFCLY_CODE_FKCODETYPE,TT_SFCLY_CODE.ZFBZ AS SFCLY_CODE_ZFBZ,TT_SFCLY_CODE.REMARK AS SFCLY_CODE_REMARK
            ");

            sql.Append(@"
            ,TT_SFCLM_CODE.ID AS SFCLM_CODE_ID,TT_SFCLM_CODE.NAME AS SFCLM_CODE_NAME,TT_SFCLM_CODE.VALUE AS SFCLM_CODE_VALUE,TT_SFCLM_CODE.FK_CODE_TYPE AS SFCLM_CODE_FKCODETYPE,TT_SFCLM_CODE.ZFBZ AS SFCLM_CODE_ZFBZ,TT_SFCLM_CODE.REMARK AS SFCLM_CODE_REMARK
            ");

            sql.Append(@"
            ,TT_YXZT_CODE.ID AS YXZT_CODE_ID,TT_YXZT_CODE.NAME AS YXZT_CODE_NAME,TT_YXZT_CODE.VALUE AS YXZT_CODE_VALUE,TT_YXZT_CODE.FK_CODE_TYPE AS YXZT_CODE_FKCODETYPE,TT_YXZT_CODE.ZFBZ AS YXZT_CODE_ZFBZ,TT_YXZT_CODE.REMARK AS YXZT_CODE_REMARK
            ");

            sql.Append(@"
            ,TT_SFKSS_CODE.ID AS SFKSS_CODE_ID,TT_SFKSS_CODE.NAME AS SFKSS_CODE_NAME,TT_SFKSS_CODE.VALUE AS SFKSS_CODE_VALUE,TT_SFKSS_CODE.FK_CODE_TYPE AS SFKSS_CODE_FKCODETYPE,TT_SFKSS_CODE.ZFBZ AS SFKSS_CODE_ZFBZ,TT_SFKSS_CODE.REMARK AS SFKSS_CODE_REMARK
            ");

            //新建方法，在此加入多表连接要显示的项end
            sql.Append(" FROM JC_YP A ");
            //新建一个方法，在此加入多表连接的语句start
            //sql.Append("LEFT JOIN 外键表名 B ON A.外键=B.ID");

            sql.Append(@" 
                        LEFT JOIN 
                        (SELECT X.* FROM JC_CODE X WHERE X.FK_CODE_TYPE IN (SELECT Y.ID FROM JC_CODE_TYPE Y WHERE Y.VALUE='" + Model.Common.CommonCode.代码类型值.CV5301_01药物剂型代码 + @"')) TT_YPJX_CODE
                        ON A.YPJX_CODE = TT_YPJX_CODE.VALUE
            ");

            sql.Append(@" 
                        LEFT JOIN 
                        (SELECT X.* FROM JC_CODE X WHERE X.FK_CODE_TYPE IN (SELECT Y.ID FROM JC_CODE_TYPE Y WHERE Y.VALUE='" + Model.Common.CommonCode.代码类型值.药品_单次用量单位 + @"')) TT_YPDCYLDW_CODE
                        ON A.YPDCYLDW_CODE = TT_YPDCYLDW_CODE.VALUE
            ");

            sql.Append(@" 
                        LEFT JOIN 
                        (SELECT X.* FROM JC_CODE X WHERE X.FK_CODE_TYPE IN (SELECT Y.ID FROM JC_CODE_TYPE Y WHERE Y.VALUE='" + Model.Common.CommonCode.代码类型值.CV5201_22用药途径代码 + @"')) TT_YPYYTJ_CODE
                        ON A.YPYYTJ_CODE = TT_YPYYTJ_CODE.VALUE
            ");

            sql.Append(@" 
                        LEFT JOIN 
                        (SELECT X.* FROM JC_CODE X WHERE X.FK_CODE_TYPE IN (SELECT Y.ID FROM JC_CODE_TYPE Y WHERE Y.VALUE='" + Model.Common.CommonCode.代码类型值.药品_大单位 + @"')) TT_DDW_CODE
                        ON A.DDW_CODE = TT_DDW_CODE.VALUE
            ");

            sql.Append(@" 
                        LEFT JOIN 
                        (SELECT X.* FROM JC_CODE X WHERE X.FK_CODE_TYPE IN (SELECT Y.ID FROM JC_CODE_TYPE Y WHERE Y.VALUE='" + Model.Common.CommonCode.代码类型值.药品_小单位 + @"')) TT_XDW_CODE
                        ON A.XDW_CODE = TT_XDW_CODE.VALUE
            ");

            sql.Append(@" 
                        LEFT JOIN 
                        (SELECT X.* FROM JC_CODE X WHERE X.FK_CODE_TYPE IN (SELECT Y.ID FROM JC_CODE_TYPE Y WHERE Y.VALUE='" + Model.Common.CommonCode.代码类型值.基础_是否 + @"')) TT_CFYBZ_CODE
                        ON A.CFYBZ_CODE = TT_CFYBZ_CODE.VALUE
            ");

            sql.Append(@" 
                        LEFT JOIN 
                        (SELECT X.* FROM JC_CODE X WHERE X.FK_CODE_TYPE IN (SELECT Y.ID FROM JC_CODE_TYPE Y WHERE Y.VALUE='" + Model.Common.CommonCode.代码类型值.基础_是否 + @"')) TT_CFQXJY_CODE
                        ON A.CFQXJY_CODE = TT_CFQXJY_CODE.VALUE
            ");

            sql.Append(@" 
                        LEFT JOIN 
                        (SELECT X.* FROM JC_CODE X WHERE X.FK_CODE_TYPE IN (SELECT Y.ID FROM JC_CODE_TYPE Y WHERE Y.VALUE='" + Model.Common.CommonCode.代码类型值.基础_是否 + @"')) TT_CFQXYB_CODE
                        ON A.CFQXYB_CODE = TT_CFQXYB_CODE.VALUE
            ");

            sql.Append(@" 
                        LEFT JOIN 
                        (SELECT X.* FROM JC_CODE X WHERE X.FK_CODE_TYPE IN (SELECT Y.ID FROM JC_CODE_TYPE Y WHERE Y.VALUE='" + Model.Common.CommonCode.代码类型值.基础_是否 + @"')) TT_CFQXDM_CODE
                        ON A.CFQXDM_CODE = TT_CFQXDM_CODE.VALUE
            ");

            sql.Append(@" 
                        LEFT JOIN 
                        (SELECT X.* FROM JC_CODE X WHERE X.FK_CODE_TYPE IN (SELECT Y.ID FROM JC_CODE_TYPE Y WHERE Y.VALUE='" + Model.Common.CommonCode.代码类型值.基础_是否 + @"')) TT_CFQXJS_CODE
                        ON A.CFQXJS_CODE = TT_CFQXJS_CODE.VALUE
            ");

            sql.Append(@" 
                        LEFT JOIN 
                        (SELECT X.* FROM JC_CODE X WHERE X.FK_CODE_TYPE IN (SELECT Y.ID FROM JC_CODE_TYPE Y WHERE Y.VALUE='" + Model.Common.CommonCode.代码类型值.基础_是否 + @"')) TT_CFQXGZ_CODE
                        ON A.CFQXGZ_CODE = TT_CFQXGZ_CODE.VALUE
            ");

            sql.Append(@" 
                        LEFT JOIN 
                        (SELECT X.* FROM JC_CODE X WHERE X.FK_CODE_TYPE IN (SELECT Y.ID FROM JC_CODE_TYPE Y WHERE Y.VALUE='" + Model.Common.CommonCode.代码类型值.基础_是否 + @"')) TT_CFQXJK_CODE
                        ON A.CFQXJK_CODE = TT_CFQXJK_CODE.VALUE
            ");

            sql.Append(@" 
                        LEFT JOIN 
                        (SELECT X.* FROM JC_CODE X WHERE X.FK_CODE_TYPE IN (SELECT Y.ID FROM JC_CODE_TYPE Y WHERE Y.VALUE='" + Model.Common.CommonCode.代码类型值.基础_是否 + @"')) TT_CFQXZZ_CODE
                        ON A.CFQXZZ_CODE = TT_CFQXZZ_CODE.VALUE
            ");

            sql.Append(@" 
                        LEFT JOIN 
                        (SELECT X.* FROM JC_CODE X WHERE X.FK_CODE_TYPE IN (SELECT Y.ID FROM JC_CODE_TYPE Y WHERE Y.VALUE='" + Model.Common.CommonCode.代码类型值.基础_是否 + @"')) TT_CFQXZF_CODE
                        ON A.CFQXZF_CODE = TT_CFQXZF_CODE.VALUE
            ");

            sql.Append(@" 
                        LEFT JOIN 
                        (SELECT X.* FROM JC_CODE X WHERE X.FK_CODE_TYPE IN (SELECT Y.ID FROM JC_CODE_TYPE Y WHERE Y.VALUE='" + Model.Common.CommonCode.代码类型值.基础_是否 + @"')) TT_CFQXTS_CODE
                        ON A.CFQXTS_CODE = TT_CFQXTS_CODE.VALUE
            ");

            sql.Append(@" 
                        LEFT JOIN 
                        (SELECT X.* FROM JC_CODE X WHERE X.FK_CODE_TYPE IN (SELECT Y.ID FROM JC_CODE_TYPE Y WHERE Y.VALUE='" + Model.Common.CommonCode.代码类型值.基础_是否 + @"')) TT_PS_CODE
                        ON A.PS_CODE = TT_PS_CODE.VALUE
            ");

            sql.Append(@" 
                        LEFT JOIN 
                        (SELECT X.* FROM JC_CODE X WHERE X.FK_CODE_TYPE IN (SELECT Y.ID FROM JC_CODE_TYPE Y WHERE Y.VALUE='" + Model.Common.CommonCode.代码类型值.CV5301_06药物类型代码 + @"')) TT_YPLX_CODE
                        ON A.YPLX_CODE = TT_YPLX_CODE.VALUE
            ");

            sql.Append(@" 
                        LEFT JOIN 
                        (SELECT X.* FROM JC_CODE X WHERE X.FK_CODE_TYPE IN (SELECT Y.ID FROM JC_CODE_TYPE Y WHERE Y.VALUE='" + Model.Common.CommonCode.代码类型值.基础_是否 + @"')) TT_YPMSYFHBRQJY_CODE
                        ON A.YPMSYFHBRQJY_CODE = TT_YPMSYFHBRQJY_CODE.VALUE
            ");

            sql.Append(@" 
                        LEFT JOIN 
                        (SELECT X.* FROM JC_CODE X WHERE X.FK_CODE_TYPE IN (SELECT Y.ID FROM JC_CODE_TYPE Y WHERE Y.VALUE='" + Model.Common.CommonCode.代码类型值.药品_分类 + @"')) TT_YPFL_CODE
                        ON A.YPFL_CODE = TT_YPFL_CODE.VALUE
            ");

            sql.Append(@" 
                        LEFT JOIN 
                        (SELECT X.* FROM JC_CODE X WHERE X.FK_CODE_TYPE IN (SELECT Y.ID FROM JC_CODE_TYPE Y WHERE Y.VALUE='" + Model.Common.CommonCode.代码类型值.药品_药价级别 + @"')) TT_YJJB_CODE
                        ON A.YJJB_CODE = TT_YJJB_CODE.VALUE
            ");

            sql.Append(@" 
                        LEFT JOIN 
                        (SELECT X.* FROM JC_CODE X WHERE X.FK_CODE_TYPE IN (SELECT Y.ID FROM JC_CODE_TYPE Y WHERE Y.VALUE='" + Model.Common.CommonCode.代码类型值.基础_是否 + @"')) TT_SFCLY_CODE
                        ON A.SFCLY_CODE = TT_SFCLY_CODE.VALUE
            ");

            sql.Append(@" 
                        LEFT JOIN 
                        (SELECT X.* FROM JC_CODE X WHERE X.FK_CODE_TYPE IN (SELECT Y.ID FROM JC_CODE_TYPE Y WHERE Y.VALUE='" + Model.Common.CommonCode.代码类型值.基础_是否 + @"')) TT_SFCLM_CODE
                        ON A.SFCLM_CODE = TT_SFCLM_CODE.VALUE
            ");

            sql.Append(@" 
                        LEFT JOIN 
                        (SELECT X.* FROM JC_CODE X WHERE X.FK_CODE_TYPE IN (SELECT Y.ID FROM JC_CODE_TYPE Y WHERE Y.VALUE='" + Model.Common.CommonCode.代码类型值.基础_有效状态 + @"')) TT_YXZT_CODE
                        ON A.YXZT_CODE = TT_YXZT_CODE.VALUE
            ");

            sql.Append(@" 
                        LEFT JOIN 
                        (SELECT X.* FROM JC_CODE X WHERE X.FK_CODE_TYPE IN (SELECT Y.ID FROM JC_CODE_TYPE Y WHERE Y.VALUE='" + Model.Common.CommonCode.代码类型值.基础_是否 + @"')) TT_SFKSS_CODE
                        ON A.SFKSS_CODE = TT_SFKSS_CODE.VALUE
            ");

            //新建一个方法，在此加入多表连接的语句end
            sql.Append(" WHERE A.ID=:id ");
            OracleParameter pId = new OracleParameter(":id", OracleDbType.Varchar2);
            pId.Value = id;
            DataSet ds = OracleHelper.getDataSet(sql.ToString(), pId);
            DataRowCollection rows = ds.Tables[0].Rows;
            if (rows.Count > 1)
            {
                throw new Exception("此ID的数据有多个，主键不允许重复，请检查数据");
            }
            if (rows.Count == 0)
            {
                throw new Exception("此ID的数据不存在，请检查数据");
            }
            return this.dataSetContactObjectsToModel(rows[0]);
        }

        /// <summary>
        /// 根据用户传入的参数查询（id参数排除在外，如需查询id请使用findById方法）
        /// 第一个参数是查询参数，如果查询参数为null则查询所有
        /// 第二个参数是分页参数，传入带数据总行数的分页对象得到默认前PageSiz条数据（取决于page对象中的值），如果传null，则查出所有数据
        /// 第三个参数提供模糊查询功能，只适用于string类型的字段
        /// 第四个参数是排序的参数，传入排序的对象的集合，如果传null，则默认使用ID字段进行排序
        /// </summary>
        /// <param name="jc_ypParam"></param>
        /// <param name="page">分页对象</param>
        ///<param name="jc_ypParamLike">模糊查询参数</param>
        ///<param name="sortList">排序参数对象的集合</param>
        /// <returns>满足条件的所有Jc_yp对象集合list</returns>
        public List<object> findContactObjects(Jc_yp jc_ypParam, Model.Common.PageInfo page, Jc_yp jc_ypParamLike, List<SortInfo> sortList)
        {
            //如果没有传查询条件参数，就new一个空的Jc_yp对象，标示查询所有数据
            if (null == jc_ypParam)
            {
                jc_ypParam = new Jc_yp();
            }
            if (null != jc_ypParam.Id && "" != jc_ypParam.Id)
            {
                throw new Exception("此方法不允许指定参数ID，如果需要根据ID查询数据，请调用findById方法；错误出自：find");
            }

            List<Jc_yp> jc_ypParamList = new List<Jc_yp>();//接收查询出的Jc_yp对象集合
            List<OracleParameter> sqlparams = new List<OracleParameter>();//保存参数的集合
            StringBuilder sql = new StringBuilder("SELECT A.* ");
            //新建方法findAllContactObjects(Jc_yp jc_ypParam, Model.Common.PageInfo page)，在此加入多表连接要显示的项start
            //sql.Append(",B.字段一,B.字段二,B.字段三");

            sql.Append(@"
            ,TT_YPJX_CODE.ID AS YPJX_CODE_ID,TT_YPJX_CODE.NAME AS YPJX_CODE_NAME,TT_YPJX_CODE.VALUE AS YPJX_CODE_VALUE,TT_YPJX_CODE.FK_CODE_TYPE AS YPJX_CODE_FKCODETYPE,TT_YPJX_CODE.ZFBZ AS YPJX_CODE_ZFBZ,TT_YPJX_CODE.REMARK AS YPJX_CODE_REMARK
            ");

            sql.Append(@"
            ,TT_YPDCYLDW_CODE.ID AS YPDCYLDW_CODE_ID,TT_YPDCYLDW_CODE.NAME AS YPDCYLDW_CODE_NAME,TT_YPDCYLDW_CODE.VALUE AS YPDCYLDW_CODE_VALUE,TT_YPDCYLDW_CODE.FK_CODE_TYPE AS YPDCYLDW_CODE_FKCODETYPE,TT_YPDCYLDW_CODE.ZFBZ AS YPDCYLDW_CODE_ZFBZ,TT_YPDCYLDW_CODE.REMARK AS YPDCYLDW_CODE_REMARK
            ");

            sql.Append(@"
            ,TT_YPYYTJ_CODE.ID AS YPYYTJ_CODE_ID,TT_YPYYTJ_CODE.NAME AS YPYYTJ_CODE_NAME,TT_YPYYTJ_CODE.VALUE AS YPYYTJ_CODE_VALUE,TT_YPYYTJ_CODE.FK_CODE_TYPE AS YPYYTJ_CODE_FKCODETYPE,TT_YPYYTJ_CODE.ZFBZ AS YPYYTJ_CODE_ZFBZ,TT_YPYYTJ_CODE.REMARK AS YPYYTJ_CODE_REMARK
            ");

            sql.Append(@"
            ,TT_DDW_CODE.ID AS DDW_CODE_ID,TT_DDW_CODE.NAME AS DDW_CODE_NAME,TT_DDW_CODE.VALUE AS DDW_CODE_VALUE,TT_DDW_CODE.FK_CODE_TYPE AS DDW_CODE_FKCODETYPE,TT_DDW_CODE.ZFBZ AS DDW_CODE_ZFBZ,TT_DDW_CODE.REMARK AS DDW_CODE_REMARK
            ");

            sql.Append(@"
            ,TT_XDW_CODE.ID AS XDW_CODE_ID,TT_XDW_CODE.NAME AS XDW_CODE_NAME,TT_XDW_CODE.VALUE AS XDW_CODE_VALUE,TT_XDW_CODE.FK_CODE_TYPE AS XDW_CODE_FKCODETYPE,TT_XDW_CODE.ZFBZ AS XDW_CODE_ZFBZ,TT_XDW_CODE.REMARK AS XDW_CODE_REMARK
            ");

            sql.Append(@"
            ,TT_CFYBZ_CODE.ID AS CFYBZ_CODE_ID,TT_CFYBZ_CODE.NAME AS CFYBZ_CODE_NAME,TT_CFYBZ_CODE.VALUE AS CFYBZ_CODE_VALUE,TT_CFYBZ_CODE.FK_CODE_TYPE AS CFYBZ_CODE_FKCODETYPE,TT_CFYBZ_CODE.ZFBZ AS CFYBZ_CODE_ZFBZ,TT_CFYBZ_CODE.REMARK AS CFYBZ_CODE_REMARK
            ");

            sql.Append(@"
            ,TT_CFQXJY_CODE.ID AS CFQXJY_CODE_ID,TT_CFQXJY_CODE.NAME AS CFQXJY_CODE_NAME,TT_CFQXJY_CODE.VALUE AS CFQXJY_CODE_VALUE,TT_CFQXJY_CODE.FK_CODE_TYPE AS CFQXJY_CODE_FKCODETYPE,TT_CFQXJY_CODE.ZFBZ AS CFQXJY_CODE_ZFBZ,TT_CFQXJY_CODE.REMARK AS CFQXJY_CODE_REMARK
            ");

            sql.Append(@"
            ,TT_CFQXYB_CODE.ID AS CFQXYB_CODE_ID,TT_CFQXYB_CODE.NAME AS CFQXYB_CODE_NAME,TT_CFQXYB_CODE.VALUE AS CFQXYB_CODE_VALUE,TT_CFQXYB_CODE.FK_CODE_TYPE AS CFQXYB_CODE_FKCODETYPE,TT_CFQXYB_CODE.ZFBZ AS CFQXYB_CODE_ZFBZ,TT_CFQXYB_CODE.REMARK AS CFQXYB_CODE_REMARK
            ");

            sql.Append(@"
            ,TT_CFQXDM_CODE.ID AS CFQXDM_CODE_ID,TT_CFQXDM_CODE.NAME AS CFQXDM_CODE_NAME,TT_CFQXDM_CODE.VALUE AS CFQXDM_CODE_VALUE,TT_CFQXDM_CODE.FK_CODE_TYPE AS CFQXDM_CODE_FKCODETYPE,TT_CFQXDM_CODE.ZFBZ AS CFQXDM_CODE_ZFBZ,TT_CFQXDM_CODE.REMARK AS CFQXDM_CODE_REMARK
            ");

            sql.Append(@"
            ,TT_CFQXJS_CODE.ID AS CFQXJS_CODE_ID,TT_CFQXJS_CODE.NAME AS CFQXJS_CODE_NAME,TT_CFQXJS_CODE.VALUE AS CFQXJS_CODE_VALUE,TT_CFQXJS_CODE.FK_CODE_TYPE AS CFQXJS_CODE_FKCODETYPE,TT_CFQXJS_CODE.ZFBZ AS CFQXJS_CODE_ZFBZ,TT_CFQXJS_CODE.REMARK AS CFQXJS_CODE_REMARK
            ");

            sql.Append(@"
            ,TT_CFQXGZ_CODE.ID AS CFQXGZ_CODE_ID,TT_CFQXGZ_CODE.NAME AS CFQXGZ_CODE_NAME,TT_CFQXGZ_CODE.VALUE AS CFQXGZ_CODE_VALUE,TT_CFQXGZ_CODE.FK_CODE_TYPE AS CFQXGZ_CODE_FKCODETYPE,TT_CFQXGZ_CODE.ZFBZ AS CFQXGZ_CODE_ZFBZ,TT_CFQXGZ_CODE.REMARK AS CFQXGZ_CODE_REMARK
            ");

            sql.Append(@"
            ,TT_CFQXJK_CODE.ID AS CFQXJK_CODE_ID,TT_CFQXJK_CODE.NAME AS CFQXJK_CODE_NAME,TT_CFQXJK_CODE.VALUE AS CFQXJK_CODE_VALUE,TT_CFQXJK_CODE.FK_CODE_TYPE AS CFQXJK_CODE_FKCODETYPE,TT_CFQXJK_CODE.ZFBZ AS CFQXJK_CODE_ZFBZ,TT_CFQXJK_CODE.REMARK AS CFQXJK_CODE_REMARK
            ");

            sql.Append(@"
            ,TT_CFQXZZ_CODE.ID AS CFQXZZ_CODE_ID,TT_CFQXZZ_CODE.NAME AS CFQXZZ_CODE_NAME,TT_CFQXZZ_CODE.VALUE AS CFQXZZ_CODE_VALUE,TT_CFQXZZ_CODE.FK_CODE_TYPE AS CFQXZZ_CODE_FKCODETYPE,TT_CFQXZZ_CODE.ZFBZ AS CFQXZZ_CODE_ZFBZ,TT_CFQXZZ_CODE.REMARK AS CFQXZZ_CODE_REMARK
            ");

            sql.Append(@"
            ,TT_CFQXZF_CODE.ID AS CFQXZF_CODE_ID,TT_CFQXZF_CODE.NAME AS CFQXZF_CODE_NAME,TT_CFQXZF_CODE.VALUE AS CFQXZF_CODE_VALUE,TT_CFQXZF_CODE.FK_CODE_TYPE AS CFQXZF_CODE_FKCODETYPE,TT_CFQXZF_CODE.ZFBZ AS CFQXZF_CODE_ZFBZ,TT_CFQXZF_CODE.REMARK AS CFQXZF_CODE_REMARK
            ");

            sql.Append(@"
            ,TT_CFQXTS_CODE.ID AS CFQXTS_CODE_ID,TT_CFQXTS_CODE.NAME AS CFQXTS_CODE_NAME,TT_CFQXTS_CODE.VALUE AS CFQXTS_CODE_VALUE,TT_CFQXTS_CODE.FK_CODE_TYPE AS CFQXTS_CODE_FKCODETYPE,TT_CFQXTS_CODE.ZFBZ AS CFQXTS_CODE_ZFBZ,TT_CFQXTS_CODE.REMARK AS CFQXTS_CODE_REMARK
            ");

            sql.Append(@"
            ,TT_PS_CODE.ID AS PS_CODE_ID,TT_PS_CODE.NAME AS PS_CODE_NAME,TT_PS_CODE.VALUE AS PS_CODE_VALUE,TT_PS_CODE.FK_CODE_TYPE AS PS_CODE_FKCODETYPE,TT_PS_CODE.ZFBZ AS PS_CODE_ZFBZ,TT_PS_CODE.REMARK AS PS_CODE_REMARK
            ");

            sql.Append(@"
            ,TT_YPLX_CODE.ID AS YPLX_CODE_ID,TT_YPLX_CODE.NAME AS YPLX_CODE_NAME,TT_YPLX_CODE.VALUE AS YPLX_CODE_VALUE,TT_YPLX_CODE.FK_CODE_TYPE AS YPLX_CODE_FKCODETYPE,TT_YPLX_CODE.ZFBZ AS YPLX_CODE_ZFBZ,TT_YPLX_CODE.REMARK AS YPLX_CODE_REMARK
            ");

            sql.Append(@"
            ,TT_YPMSYFHBRQJY_CODE.ID AS YPMSYFHBRQJY_CODE_ID,TT_YPMSYFHBRQJY_CODE.NAME AS YPMSYFHBRQJY_CODE_NAME,TT_YPMSYFHBRQJY_CODE.VALUE AS YPMSYFHBRQJY_CODE_VALUE,TT_YPMSYFHBRQJY_CODE.FK_CODE_TYPE AS YPMSYFHBRQJY_CODE_FKCODETYPE,TT_YPMSYFHBRQJY_CODE.ZFBZ AS YPMSYFHBRQJY_CODE_ZFBZ,TT_YPMSYFHBRQJY_CODE.REMARK AS YPMSYFHBRQJY_CODE_REMARK
            ");

            sql.Append(@"
            ,TT_YPFL_CODE.ID AS YPFL_CODE_ID,TT_YPFL_CODE.NAME AS YPFL_CODE_NAME,TT_YPFL_CODE.VALUE AS YPFL_CODE_VALUE,TT_YPFL_CODE.FK_CODE_TYPE AS YPFL_CODE_FKCODETYPE,TT_YPFL_CODE.ZFBZ AS YPFL_CODE_ZFBZ,TT_YPFL_CODE.REMARK AS YPFL_CODE_REMARK
            ");

            sql.Append(@"
            ,TT_YJJB_CODE.ID AS YJJB_CODE_ID,TT_YJJB_CODE.NAME AS YJJB_CODE_NAME,TT_YJJB_CODE.VALUE AS YJJB_CODE_VALUE,TT_YJJB_CODE.FK_CODE_TYPE AS YJJB_CODE_FKCODETYPE,TT_YJJB_CODE.ZFBZ AS YJJB_CODE_ZFBZ,TT_YJJB_CODE.REMARK AS YJJB_CODE_REMARK
            ");

            sql.Append(@"
            ,TT_SFCLY_CODE.ID AS SFCLY_CODE_ID,TT_SFCLY_CODE.NAME AS SFCLY_CODE_NAME,TT_SFCLY_CODE.VALUE AS SFCLY_CODE_VALUE,TT_SFCLY_CODE.FK_CODE_TYPE AS SFCLY_CODE_FKCODETYPE,TT_SFCLY_CODE.ZFBZ AS SFCLY_CODE_ZFBZ,TT_SFCLY_CODE.REMARK AS SFCLY_CODE_REMARK
            ");

            sql.Append(@"
            ,TT_SFCLM_CODE.ID AS SFCLM_CODE_ID,TT_SFCLM_CODE.NAME AS SFCLM_CODE_NAME,TT_SFCLM_CODE.VALUE AS SFCLM_CODE_VALUE,TT_SFCLM_CODE.FK_CODE_TYPE AS SFCLM_CODE_FKCODETYPE,TT_SFCLM_CODE.ZFBZ AS SFCLM_CODE_ZFBZ,TT_SFCLM_CODE.REMARK AS SFCLM_CODE_REMARK
            ");

            sql.Append(@"
            ,TT_YXZT_CODE.ID AS YXZT_CODE_ID,TT_YXZT_CODE.NAME AS YXZT_CODE_NAME,TT_YXZT_CODE.VALUE AS YXZT_CODE_VALUE,TT_YXZT_CODE.FK_CODE_TYPE AS YXZT_CODE_FKCODETYPE,TT_YXZT_CODE.ZFBZ AS YXZT_CODE_ZFBZ,TT_YXZT_CODE.REMARK AS YXZT_CODE_REMARK
            ");

            sql.Append(@"
            ,TT_SFKSS_CODE.ID AS SFKSS_CODE_ID,TT_SFKSS_CODE.NAME AS SFKSS_CODE_NAME,TT_SFKSS_CODE.VALUE AS SFKSS_CODE_VALUE,TT_SFKSS_CODE.FK_CODE_TYPE AS SFKSS_CODE_FKCODETYPE,TT_SFKSS_CODE.ZFBZ AS SFKSS_CODE_ZFBZ,TT_SFKSS_CODE.REMARK AS SFKSS_CODE_REMARK
            ");

            //新建方法，在此加入多表连接要显示的项end
            sql.Append(" FROM JC_YP A ");
            //新建一个方法，在此加入多表连接的语句start
            ////sql.Append(" LEFT JOIN 表名 B ON A.外键=B.ID");

            sql.Append(@" 
                        LEFT JOIN 
                        (SELECT X.* FROM JC_CODE X WHERE X.FK_CODE_TYPE IN (SELECT Y.ID FROM JC_CODE_TYPE Y WHERE Y.VALUE='" + Model.Common.CommonCode.代码类型值.CV5301_01药物剂型代码 + @"')) TT_YPJX_CODE
                        ON A.YPJX_CODE = TT_YPJX_CODE.VALUE
            ");

            sql.Append(@" 
                        LEFT JOIN 
                        (SELECT X.* FROM JC_CODE X WHERE X.FK_CODE_TYPE IN (SELECT Y.ID FROM JC_CODE_TYPE Y WHERE Y.VALUE='" + Model.Common.CommonCode.代码类型值.药品_单次用量单位 + @"')) TT_YPDCYLDW_CODE
                        ON A.YPDCYLDW_CODE = TT_YPDCYLDW_CODE.VALUE
            ");

            sql.Append(@" 
                        LEFT JOIN 
                        (SELECT X.* FROM JC_CODE X WHERE X.FK_CODE_TYPE IN (SELECT Y.ID FROM JC_CODE_TYPE Y WHERE Y.VALUE='" + Model.Common.CommonCode.代码类型值.CV5201_22用药途径代码 + @"')) TT_YPYYTJ_CODE
                        ON A.YPYYTJ_CODE = TT_YPYYTJ_CODE.VALUE
            ");

            sql.Append(@" 
                        LEFT JOIN 
                        (SELECT X.* FROM JC_CODE X WHERE X.FK_CODE_TYPE IN (SELECT Y.ID FROM JC_CODE_TYPE Y WHERE Y.VALUE='" + Model.Common.CommonCode.代码类型值.药品_大单位 + @"')) TT_DDW_CODE
                        ON A.DDW_CODE = TT_DDW_CODE.VALUE
            ");

            sql.Append(@" 
                        LEFT JOIN 
                        (SELECT X.* FROM JC_CODE X WHERE X.FK_CODE_TYPE IN (SELECT Y.ID FROM JC_CODE_TYPE Y WHERE Y.VALUE='" + Model.Common.CommonCode.代码类型值.药品_小单位 + @"')) TT_XDW_CODE
                        ON A.XDW_CODE = TT_XDW_CODE.VALUE
            ");

            sql.Append(@" 
                        LEFT JOIN 
                        (SELECT X.* FROM JC_CODE X WHERE X.FK_CODE_TYPE IN (SELECT Y.ID FROM JC_CODE_TYPE Y WHERE Y.VALUE='" + Model.Common.CommonCode.代码类型值.基础_是否 + @"')) TT_CFYBZ_CODE
                        ON A.CFYBZ_CODE = TT_CFYBZ_CODE.VALUE
            ");

            sql.Append(@" 
                        LEFT JOIN 
                        (SELECT X.* FROM JC_CODE X WHERE X.FK_CODE_TYPE IN (SELECT Y.ID FROM JC_CODE_TYPE Y WHERE Y.VALUE='" + Model.Common.CommonCode.代码类型值.基础_是否 + @"')) TT_CFQXJY_CODE
                        ON A.CFQXJY_CODE = TT_CFQXJY_CODE.VALUE
            ");

            sql.Append(@" 
                        LEFT JOIN 
                        (SELECT X.* FROM JC_CODE X WHERE X.FK_CODE_TYPE IN (SELECT Y.ID FROM JC_CODE_TYPE Y WHERE Y.VALUE='" + Model.Common.CommonCode.代码类型值.基础_是否 + @"')) TT_CFQXYB_CODE
                        ON A.CFQXYB_CODE = TT_CFQXYB_CODE.VALUE
            ");

            sql.Append(@" 
                        LEFT JOIN 
                        (SELECT X.* FROM JC_CODE X WHERE X.FK_CODE_TYPE IN (SELECT Y.ID FROM JC_CODE_TYPE Y WHERE Y.VALUE='" + Model.Common.CommonCode.代码类型值.基础_是否 + @"')) TT_CFQXDM_CODE
                        ON A.CFQXDM_CODE = TT_CFQXDM_CODE.VALUE
            ");

            sql.Append(@" 
                        LEFT JOIN 
                        (SELECT X.* FROM JC_CODE X WHERE X.FK_CODE_TYPE IN (SELECT Y.ID FROM JC_CODE_TYPE Y WHERE Y.VALUE='" + Model.Common.CommonCode.代码类型值.基础_是否 + @"')) TT_CFQXJS_CODE
                        ON A.CFQXJS_CODE = TT_CFQXJS_CODE.VALUE
            ");

            sql.Append(@" 
                        LEFT JOIN 
                        (SELECT X.* FROM JC_CODE X WHERE X.FK_CODE_TYPE IN (SELECT Y.ID FROM JC_CODE_TYPE Y WHERE Y.VALUE='" + Model.Common.CommonCode.代码类型值.基础_是否 + @"')) TT_CFQXGZ_CODE
                        ON A.CFQXGZ_CODE = TT_CFQXGZ_CODE.VALUE
            ");

            sql.Append(@" 
                        LEFT JOIN 
                        (SELECT X.* FROM JC_CODE X WHERE X.FK_CODE_TYPE IN (SELECT Y.ID FROM JC_CODE_TYPE Y WHERE Y.VALUE='" + Model.Common.CommonCode.代码类型值.基础_是否 + @"')) TT_CFQXJK_CODE
                        ON A.CFQXJK_CODE = TT_CFQXJK_CODE.VALUE
            ");

            sql.Append(@" 
                        LEFT JOIN 
                        (SELECT X.* FROM JC_CODE X WHERE X.FK_CODE_TYPE IN (SELECT Y.ID FROM JC_CODE_TYPE Y WHERE Y.VALUE='" + Model.Common.CommonCode.代码类型值.基础_是否 + @"')) TT_CFQXZZ_CODE
                        ON A.CFQXZZ_CODE = TT_CFQXZZ_CODE.VALUE
            ");

            sql.Append(@" 
                        LEFT JOIN 
                        (SELECT X.* FROM JC_CODE X WHERE X.FK_CODE_TYPE IN (SELECT Y.ID FROM JC_CODE_TYPE Y WHERE Y.VALUE='" + Model.Common.CommonCode.代码类型值.基础_是否 + @"')) TT_CFQXZF_CODE
                        ON A.CFQXZF_CODE = TT_CFQXZF_CODE.VALUE
            ");

            sql.Append(@" 
                        LEFT JOIN 
                        (SELECT X.* FROM JC_CODE X WHERE X.FK_CODE_TYPE IN (SELECT Y.ID FROM JC_CODE_TYPE Y WHERE Y.VALUE='" + Model.Common.CommonCode.代码类型值.基础_是否 + @"')) TT_CFQXTS_CODE
                        ON A.CFQXTS_CODE = TT_CFQXTS_CODE.VALUE
            ");

            sql.Append(@" 
                        LEFT JOIN 
                        (SELECT X.* FROM JC_CODE X WHERE X.FK_CODE_TYPE IN (SELECT Y.ID FROM JC_CODE_TYPE Y WHERE Y.VALUE='" + Model.Common.CommonCode.代码类型值.基础_是否 + @"')) TT_PS_CODE
                        ON A.PS_CODE = TT_PS_CODE.VALUE
            ");

            sql.Append(@" 
                        LEFT JOIN 
                        (SELECT X.* FROM JC_CODE X WHERE X.FK_CODE_TYPE IN (SELECT Y.ID FROM JC_CODE_TYPE Y WHERE Y.VALUE='" + Model.Common.CommonCode.代码类型值.CV5301_06药物类型代码 + @"')) TT_YPLX_CODE
                        ON A.YPLX_CODE = TT_YPLX_CODE.VALUE
            ");

            sql.Append(@" 
                        LEFT JOIN 
                        (SELECT X.* FROM JC_CODE X WHERE X.FK_CODE_TYPE IN (SELECT Y.ID FROM JC_CODE_TYPE Y WHERE Y.VALUE='" + Model.Common.CommonCode.代码类型值.基础_是否 + @"')) TT_YPMSYFHBRQJY_CODE
                        ON A.YPMSYFHBRQJY_CODE = TT_YPMSYFHBRQJY_CODE.VALUE
            ");

            sql.Append(@" 
                        LEFT JOIN 
                        (SELECT X.* FROM JC_CODE X WHERE X.FK_CODE_TYPE IN (SELECT Y.ID FROM JC_CODE_TYPE Y WHERE Y.VALUE='" + Model.Common.CommonCode.代码类型值.药品_分类 + @"')) TT_YPFL_CODE
                        ON A.YPFL_CODE = TT_YPFL_CODE.VALUE
            ");

            sql.Append(@" 
                        LEFT JOIN 
                        (SELECT X.* FROM JC_CODE X WHERE X.FK_CODE_TYPE IN (SELECT Y.ID FROM JC_CODE_TYPE Y WHERE Y.VALUE='" + Model.Common.CommonCode.代码类型值.药品_药价级别 + @"')) TT_YJJB_CODE
                        ON A.YJJB_CODE = TT_YJJB_CODE.VALUE
            ");

            sql.Append(@" 
                        LEFT JOIN 
                        (SELECT X.* FROM JC_CODE X WHERE X.FK_CODE_TYPE IN (SELECT Y.ID FROM JC_CODE_TYPE Y WHERE Y.VALUE='" + Model.Common.CommonCode.代码类型值.基础_是否 + @"')) TT_SFCLY_CODE
                        ON A.SFCLY_CODE = TT_SFCLY_CODE.VALUE
            ");

            sql.Append(@" 
                        LEFT JOIN 
                        (SELECT X.* FROM JC_CODE X WHERE X.FK_CODE_TYPE IN (SELECT Y.ID FROM JC_CODE_TYPE Y WHERE Y.VALUE='" + Model.Common.CommonCode.代码类型值.基础_是否 + @"')) TT_SFCLM_CODE
                        ON A.SFCLM_CODE = TT_SFCLM_CODE.VALUE
            ");

            sql.Append(@" 
                        LEFT JOIN 
                        (SELECT X.* FROM JC_CODE X WHERE X.FK_CODE_TYPE IN (SELECT Y.ID FROM JC_CODE_TYPE Y WHERE Y.VALUE='" + Model.Common.CommonCode.代码类型值.基础_有效状态 + @"')) TT_YXZT_CODE
                        ON A.YXZT_CODE = TT_YXZT_CODE.VALUE
            ");

            sql.Append(@" 
                        LEFT JOIN 
                        (SELECT X.* FROM JC_CODE X WHERE X.FK_CODE_TYPE IN (SELECT Y.ID FROM JC_CODE_TYPE Y WHERE Y.VALUE='" + Model.Common.CommonCode.代码类型值.基础_是否 + @"')) TT_SFKSS_CODE
                        ON A.SFKSS_CODE = TT_SFKSS_CODE.VALUE
            ");

            //新建一个方法，在此加入多表连接的语句end


            if (null != jc_ypParam.Ypbm && "" != jc_ypParam.Ypbm)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.YPBM=:ypbm ");
                OracleParameter pYpbm = new OracleParameter(":ypbm", OracleDbType.NVarchar2);
                pYpbm.Value = jc_ypParam.Ypbm;
                sqlparams.Add(pYpbm);
            }

            if (null != jc_ypParam.Ypmc && "" != jc_ypParam.Ypmc)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.YPMC=:ypmc ");
                OracleParameter pYpmc = new OracleParameter(":ypmc", OracleDbType.NVarchar2);
                pYpmc.Value = jc_ypParam.Ypmc;
                sqlparams.Add(pYpmc);
            }

            if (null != jc_ypParam.Yptymc && "" != jc_ypParam.Yptymc)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.YPTYMC=:yptymc ");
                OracleParameter pYptymc = new OracleParameter(":yptymc", OracleDbType.NVarchar2);
                pYptymc.Value = jc_ypParam.Yptymc;
                sqlparams.Add(pYptymc);
            }

            if (null != jc_ypParam.Ypcf && "" != jc_ypParam.Ypcf)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.YPCF=:ypcf ");
                OracleParameter pYpcf = new OracleParameter(":ypcf", OracleDbType.NVarchar2);
                pYpcf.Value = jc_ypParam.Ypcf;
                sqlparams.Add(pYpcf);
            }

            if (null != jc_ypParam.Yppzwh && "" != jc_ypParam.Yppzwh)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.YPPZWH=:yppzwh ");
                OracleParameter pYppzwh = new OracleParameter(":yppzwh", OracleDbType.NVarchar2);
                pYppzwh.Value = jc_ypParam.Yppzwh;
                sqlparams.Add(pYppzwh);
            }

            if (null != jc_ypParam.Ypzczh && "" != jc_ypParam.Ypzczh)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.YPZCZH=:ypzczh ");
                OracleParameter pYpzczh = new OracleParameter(":ypzczh", OracleDbType.NVarchar2);
                pYpzczh.Value = jc_ypParam.Ypzczh;
                sqlparams.Add(pYpzczh);
            }

            if (null != jc_ypParam.Gyzz && "" != jc_ypParam.Gyzz)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.GYZZ=:gyzz ");
                OracleParameter pGyzz = new OracleParameter(":gyzz", OracleDbType.NVarchar2);
                pGyzz.Value = jc_ypParam.Gyzz;
                sqlparams.Add(pGyzz);
            }

            if (null != jc_ypParam.Ypjx_code && "" != jc_ypParam.Ypjx_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.YPJX_CODE=:ypjx_code ");
                OracleParameter pYpjx_code = new OracleParameter(":ypjx_code", OracleDbType.NVarchar2);
                pYpjx_code.Value = jc_ypParam.Ypjx_code;
                sqlparams.Add(pYpjx_code);
            }

            if (null != jc_ypParam.Ypgg && "" != jc_ypParam.Ypgg)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.YPGG=:ypgg ");
                OracleParameter pYpgg = new OracleParameter(":ypgg", OracleDbType.NVarchar2);
                pYpgg.Value = jc_ypParam.Ypgg;
                sqlparams.Add(pYpgg);
            }

            if (null != jc_ypParam.Ypdcyl)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" YPDCYL=:ypdcyl ");
                OracleParameter pYpdcyl = new OracleParameter(":ypdcyl", OracleDbType.Decimal);
                pYpdcyl.Value = jc_ypParam.Ypdcyl;
                sqlparams.Add(pYpdcyl);

            }

            if (null != jc_ypParam.Ypdcyldw_code && "" != jc_ypParam.Ypdcyldw_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.YPDCYLDW_CODE=:ypdcyldw_code ");
                OracleParameter pYpdcyldw_code = new OracleParameter(":ypdcyldw_code", OracleDbType.NVarchar2);
                pYpdcyldw_code.Value = jc_ypParam.Ypdcyldw_code;
                sqlparams.Add(pYpdcyldw_code);
            }

            if (null != jc_ypParam.Ypyytj_code && "" != jc_ypParam.Ypyytj_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.YPYYTJ_CODE=:ypyytj_code ");
                OracleParameter pYpyytj_code = new OracleParameter(":ypyytj_code", OracleDbType.NVarchar2);
                pYpyytj_code.Value = jc_ypParam.Ypyytj_code;
                sqlparams.Add(pYpyytj_code);
            }

            if (null != jc_ypParam.Ddw_code && "" != jc_ypParam.Ddw_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.DDW_CODE=:ddw_code ");
                OracleParameter pDdw_code = new OracleParameter(":ddw_code", OracleDbType.NVarchar2);
                pDdw_code.Value = jc_ypParam.Ddw_code;
                sqlparams.Add(pDdw_code);
            }

            if (null != jc_ypParam.Xdw_code && "" != jc_ypParam.Xdw_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.XDW_CODE=:xdw_code ");
                OracleParameter pXdw_code = new OracleParameter(":xdw_code", OracleDbType.NVarchar2);
                pXdw_code.Value = jc_ypParam.Xdw_code;
                sqlparams.Add(pXdw_code);
            }

            if (null != jc_ypParam.Cfybz_code && "" != jc_ypParam.Cfybz_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.CFYBZ_CODE=:cfybz_code ");
                OracleParameter pCfybz_code = new OracleParameter(":cfybz_code", OracleDbType.NVarchar2);
                pCfybz_code.Value = jc_ypParam.Cfybz_code;
                sqlparams.Add(pCfybz_code);
            }

            if (null != jc_ypParam.Cfqxjy_code && "" != jc_ypParam.Cfqxjy_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.CFQXJY_CODE=:cfqxjy_code ");
                OracleParameter pCfqxjy_code = new OracleParameter(":cfqxjy_code", OracleDbType.NVarchar2);
                pCfqxjy_code.Value = jc_ypParam.Cfqxjy_code;
                sqlparams.Add(pCfqxjy_code);
            }

            if (null != jc_ypParam.Cfqxyb_code && "" != jc_ypParam.Cfqxyb_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.CFQXYB_CODE=:cfqxyb_code ");
                OracleParameter pCfqxyb_code = new OracleParameter(":cfqxyb_code", OracleDbType.NVarchar2);
                pCfqxyb_code.Value = jc_ypParam.Cfqxyb_code;
                sqlparams.Add(pCfqxyb_code);
            }

            if (null != jc_ypParam.Cfqxdm_code && "" != jc_ypParam.Cfqxdm_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.CFQXDM_CODE=:cfqxdm_code ");
                OracleParameter pCfqxdm_code = new OracleParameter(":cfqxdm_code", OracleDbType.NVarchar2);
                pCfqxdm_code.Value = jc_ypParam.Cfqxdm_code;
                sqlparams.Add(pCfqxdm_code);
            }

            if (null != jc_ypParam.Cfqxjs_code && "" != jc_ypParam.Cfqxjs_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.CFQXJS_CODE=:cfqxjs_code ");
                OracleParameter pCfqxjs_code = new OracleParameter(":cfqxjs_code", OracleDbType.NVarchar2);
                pCfqxjs_code.Value = jc_ypParam.Cfqxjs_code;
                sqlparams.Add(pCfqxjs_code);
            }

            if (null != jc_ypParam.Cfqxgz_code && "" != jc_ypParam.Cfqxgz_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.CFQXGZ_CODE=:cfqxgz_code ");
                OracleParameter pCfqxgz_code = new OracleParameter(":cfqxgz_code", OracleDbType.NVarchar2);
                pCfqxgz_code.Value = jc_ypParam.Cfqxgz_code;
                sqlparams.Add(pCfqxgz_code);
            }

            if (null != jc_ypParam.Cfqxjk_code && "" != jc_ypParam.Cfqxjk_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.CFQXJK_CODE=:cfqxjk_code ");
                OracleParameter pCfqxjk_code = new OracleParameter(":cfqxjk_code", OracleDbType.NVarchar2);
                pCfqxjk_code.Value = jc_ypParam.Cfqxjk_code;
                sqlparams.Add(pCfqxjk_code);
            }

            if (null != jc_ypParam.Cfqxzz_code && "" != jc_ypParam.Cfqxzz_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.CFQXZZ_CODE=:cfqxzz_code ");
                OracleParameter pCfqxzz_code = new OracleParameter(":cfqxzz_code", OracleDbType.NVarchar2);
                pCfqxzz_code.Value = jc_ypParam.Cfqxzz_code;
                sqlparams.Add(pCfqxzz_code);
            }

            if (null != jc_ypParam.Cfqxzf_code && "" != jc_ypParam.Cfqxzf_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.CFQXZF_CODE=:cfqxzf_code ");
                OracleParameter pCfqxzf_code = new OracleParameter(":cfqxzf_code", OracleDbType.NVarchar2);
                pCfqxzf_code.Value = jc_ypParam.Cfqxzf_code;
                sqlparams.Add(pCfqxzf_code);
            }

            if (null != jc_ypParam.Cfqxts_code && "" != jc_ypParam.Cfqxts_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.CFQXTS_CODE=:cfqxts_code ");
                OracleParameter pCfqxts_code = new OracleParameter(":cfqxts_code", OracleDbType.NVarchar2);
                pCfqxts_code.Value = jc_ypParam.Cfqxts_code;
                sqlparams.Add(pCfqxts_code);
            }

            if (null != jc_ypParam.Ps_code && "" != jc_ypParam.Ps_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.PS_CODE=:ps_code ");
                OracleParameter pPs_code = new OracleParameter(":ps_code", OracleDbType.NVarchar2);
                pPs_code.Value = jc_ypParam.Ps_code;
                sqlparams.Add(pPs_code);
            }

            if (null != jc_ypParam.Yplx_code && "" != jc_ypParam.Yplx_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.YPLX_CODE=:yplx_code ");
                OracleParameter pYplx_code = new OracleParameter(":yplx_code", OracleDbType.NVarchar2);
                pYplx_code.Value = jc_ypParam.Yplx_code;
                sqlparams.Add(pYplx_code);
            }

            if (null != jc_ypParam.Ypmssyz && "" != jc_ypParam.Ypmssyz)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.YPMSSYZ=:ypmssyz ");
                OracleParameter pYpmssyz = new OracleParameter(":ypmssyz", OracleDbType.NVarchar2);
                pYpmssyz.Value = jc_ypParam.Ypmssyz;
                sqlparams.Add(pYpmssyz);
            }

            if (null != jc_ypParam.Ypmsjjz && "" != jc_ypParam.Ypmsjjz)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.YPMSJJZ=:ypmsjjz ");
                OracleParameter pYpmsjjz = new OracleParameter(":ypmsjjz", OracleDbType.NVarchar2);
                pYpmsjjz.Value = jc_ypParam.Ypmsjjz;
                sqlparams.Add(pYpmsjjz);
            }

            if (null != jc_ypParam.Ypmsyfhbrqjy_code && "" != jc_ypParam.Ypmsyfhbrqjy_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.YPMSYFHBRQJY_CODE=:ypmsyfhbrqjy_code ");
                OracleParameter pYpmsyfhbrqjy_code = new OracleParameter(":ypmsyfhbrqjy_code", OracleDbType.NVarchar2);
                pYpmsyfhbrqjy_code.Value = jc_ypParam.Ypmsyfhbrqjy_code;
                sqlparams.Add(pYpmsyfhbrqjy_code);
            }

            if (null != jc_ypParam.Ypmsblfy && "" != jc_ypParam.Ypmsblfy)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.YPMSBLFY=:ypmsblfy ");
                OracleParameter pYpmsblfy = new OracleParameter(":ypmsblfy", OracleDbType.NVarchar2);
                pYpmsblfy.Value = jc_ypParam.Ypmsblfy;
                sqlparams.Add(pYpmsblfy);
            }

            if (null != jc_ypParam.Ypfl_code && "" != jc_ypParam.Ypfl_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.YPFL_CODE=:ypfl_code ");
                OracleParameter pYpfl_code = new OracleParameter(":ypfl_code", OracleDbType.NVarchar2);
                pYpfl_code.Value = jc_ypParam.Ypfl_code;
                sqlparams.Add(pYpfl_code);
            }

            if (null != jc_ypParam.Yjjb_code && "" != jc_ypParam.Yjjb_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.YJJB_CODE=:yjjb_code ");
                OracleParameter pYjjb_code = new OracleParameter(":yjjb_code", OracleDbType.NVarchar2);
                pYjjb_code.Value = jc_ypParam.Yjjb_code;
                sqlparams.Add(pYjjb_code);
            }

            if (null != jc_ypParam.Txm && "" != jc_ypParam.Txm)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.TXM=:txm ");
                OracleParameter pTxm = new OracleParameter(":txm", OracleDbType.NVarchar2);
                pTxm.Value = jc_ypParam.Txm;
                sqlparams.Add(pTxm);
            }

            if (null != jc_ypParam.Ewm && "" != jc_ypParam.Ewm)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.EWM=:ewm ");
                OracleParameter pEwm = new OracleParameter(":ewm", OracleDbType.NVarchar2);
                pEwm.Value = jc_ypParam.Ewm;
                sqlparams.Add(pEwm);
            }

            if (null != jc_ypParam.Pym && "" != jc_ypParam.Pym)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.PYM=:pym ");
                OracleParameter pPym = new OracleParameter(":pym", OracleDbType.NVarchar2);
                pPym.Value = jc_ypParam.Pym;
                sqlparams.Add(pPym);
            }

            if (null != jc_ypParam.Hsxs)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" HSXS=:hsxs ");
                OracleParameter pHsxs = new OracleParameter(":hsxs", OracleDbType.Decimal);
                pHsxs.Value = jc_ypParam.Hsxs;
                sqlparams.Add(pHsxs);

            }

            if (null != jc_ypParam.Sfcly_code && "" != jc_ypParam.Sfcly_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.SFCLY_CODE=:sfcly_code ");
                OracleParameter pSfcly_code = new OracleParameter(":sfcly_code", OracleDbType.NVarchar2);
                pSfcly_code.Value = jc_ypParam.Sfcly_code;
                sqlparams.Add(pSfcly_code);
            }

            if (null != jc_ypParam.Bzpfj)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" BZPFJ=:bzpfj ");
                OracleParameter pBzpfj = new OracleParameter(":bzpfj", OracleDbType.Decimal);
                pBzpfj.Value = jc_ypParam.Bzpfj;
                sqlparams.Add(pBzpfj);

            }

            if (null != jc_ypParam.Bzlsj)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" BZLSJ=:bzlsj ");
                OracleParameter pBzlsj = new OracleParameter(":bzlsj", OracleDbType.Decimal);
                pBzlsj.Value = jc_ypParam.Bzlsj;
                sqlparams.Add(pBzlsj);

            }

            if (null != jc_ypParam.Bzmzj)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" BZMZJ=:bzmzj ");
                OracleParameter pBzmzj = new OracleParameter(":bzmzj", OracleDbType.Decimal);
                pBzmzj.Value = jc_ypParam.Bzmzj;
                sqlparams.Add(pBzmzj);

            }

            if (null != jc_ypParam.Bzzyj)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" BZZYJ=:bzzyj ");
                OracleParameter pBzzyj = new OracleParameter(":bzzyj", OracleDbType.Decimal);
                pBzzyj.Value = jc_ypParam.Bzzyj;
                sqlparams.Add(pBzzyj);

            }

            if (null != jc_ypParam.Hsbl)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" HSBL=:hsbl ");
                OracleParameter pHsbl = new OracleParameter(":hsbl", OracleDbType.Decimal);
                pHsbl.Value = jc_ypParam.Hsbl;
                sqlparams.Add(pHsbl);

            }

            if (null != jc_ypParam.Sfclm_code && "" != jc_ypParam.Sfclm_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.SFCLM_CODE=:sfclm_code ");
                OracleParameter pSfclm_code = new OracleParameter(":sfclm_code", OracleDbType.NVarchar2);
                pSfclm_code.Value = jc_ypParam.Sfclm_code;
                sqlparams.Add(pSfclm_code);
            }

            if (null != jc_ypParam.Yxzt_code && "" != jc_ypParam.Yxzt_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.YXZT_CODE=:yxzt_code ");
                OracleParameter pYxzt_code = new OracleParameter(":yxzt_code", OracleDbType.NVarchar2);
                pYxzt_code.Value = jc_ypParam.Yxzt_code;
                sqlparams.Add(pYxzt_code);
            }

            if (null != jc_ypParam.Dcsxyl)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" DCSXYL=:dcsxyl ");
                OracleParameter pDcsxyl = new OracleParameter(":dcsxyl", OracleDbType.Decimal);
                pDcsxyl.Value = jc_ypParam.Dcsxyl;
                sqlparams.Add(pDcsxyl);

            }

            if (null != jc_ypParam.Dcxxyl)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" DCXXYL=:dcxxyl ");
                OracleParameter pDcxxyl = new OracleParameter(":dcxxyl", OracleDbType.Decimal);
                pDcxxyl.Value = jc_ypParam.Dcxxyl;
                sqlparams.Add(pDcxxyl);

            }

            if (null != jc_ypParam.Lxylts)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" LXYLTS=:lxylts ");
                OracleParameter pLxylts = new OracleParameter(":lxylts", OracleDbType.Decimal);
                pLxylts.Value = jc_ypParam.Lxylts;
                sqlparams.Add(pLxylts);

            }

            if (null != jc_ypParam.Lxylcs)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" LXYLCS=:lxylcs ");
                OracleParameter pLxylcs = new OracleParameter(":lxylcs", OracleDbType.Decimal);
                pLxylcs.Value = jc_ypParam.Lxylcs;
                sqlparams.Add(pLxylcs);

            }

            if (null != jc_ypParam.Scqy && "" != jc_ypParam.Scqy)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.SCQY=:scqy ");
                OracleParameter pScqy = new OracleParameter(":scqy", OracleDbType.NVarchar2);
                pScqy.Value = jc_ypParam.Scqy;
                sqlparams.Add(pScqy);
            }

            if (DateTime.MinValue != jc_ypParam.Pzrq && null != jc_ypParam.Pzrq)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.PZRQ=:pzrq ");
                OracleParameter pPzrq = new OracleParameter(":pzrq", OracleDbType.Date);
                pPzrq.Value = jc_ypParam.Pzrq;
                sqlparams.Add(pPzrq);
            }

            if (null != jc_ypParam.Sfkss_code && "" != jc_ypParam.Sfkss_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.SFKSS_CODE=:sfkss_code ");
                OracleParameter pSfkss_code = new OracleParameter(":sfkss_code", OracleDbType.NVarchar2);
                pSfkss_code.Value = jc_ypParam.Sfkss_code;
                sqlparams.Add(pSfkss_code);
            }

            if (null != jc_ypParam.Zfbz && "" != jc_ypParam.Zfbz)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.ZFBZ=:zfbz ");
                OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                pZfbz.Value = jc_ypParam.Zfbz;
                sqlparams.Add(pZfbz);
            }

            if (null != jc_ypParam.Dcyldwbl)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" DCYLDWBL=:dcyldwbl ");
                OracleParameter pDcyldwbl = new OracleParameter(":dcyldwbl", OracleDbType.Decimal);
                pDcyldwbl.Value = jc_ypParam.Dcyldwbl;
                sqlparams.Add(pDcyldwbl);

            }

            if (jc_ypParamLike != null)
            {

                if (null != jc_ypParamLike.Ypbm && "" != jc_ypParamLike.Ypbm)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YPBM LIKE '%'||:ypbm||'%' ");
                    OracleParameter pYpbm = new OracleParameter(":ypbm", OracleDbType.NVarchar2);
                    pYpbm.Direction = ParameterDirection.Input;
                    pYpbm.Value = jc_ypParamLike.Ypbm;
                    sqlparams.Add(pYpbm);
                }

                if (null != jc_ypParamLike.Ypmc && "" != jc_ypParamLike.Ypmc)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YPMC LIKE '%'||:ypmc||'%' ");
                    OracleParameter pYpmc = new OracleParameter(":ypmc", OracleDbType.NVarchar2);
                    pYpmc.Direction = ParameterDirection.Input;
                    pYpmc.Value = jc_ypParamLike.Ypmc;
                    sqlparams.Add(pYpmc);
                }

                if (null != jc_ypParamLike.Yptymc && "" != jc_ypParamLike.Yptymc)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YPTYMC LIKE '%'||:yptymc||'%' ");
                    OracleParameter pYptymc = new OracleParameter(":yptymc", OracleDbType.NVarchar2);
                    pYptymc.Direction = ParameterDirection.Input;
                    pYptymc.Value = jc_ypParamLike.Yptymc;
                    sqlparams.Add(pYptymc);
                }

                if (null != jc_ypParamLike.Ypcf && "" != jc_ypParamLike.Ypcf)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YPCF LIKE '%'||:ypcf||'%' ");
                    OracleParameter pYpcf = new OracleParameter(":ypcf", OracleDbType.NVarchar2);
                    pYpcf.Direction = ParameterDirection.Input;
                    pYpcf.Value = jc_ypParamLike.Ypcf;
                    sqlparams.Add(pYpcf);
                }

                if (null != jc_ypParamLike.Yppzwh && "" != jc_ypParamLike.Yppzwh)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YPPZWH LIKE '%'||:yppzwh||'%' ");
                    OracleParameter pYppzwh = new OracleParameter(":yppzwh", OracleDbType.NVarchar2);
                    pYppzwh.Direction = ParameterDirection.Input;
                    pYppzwh.Value = jc_ypParamLike.Yppzwh;
                    sqlparams.Add(pYppzwh);
                }

                if (null != jc_ypParamLike.Ypzczh && "" != jc_ypParamLike.Ypzczh)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YPZCZH LIKE '%'||:ypzczh||'%' ");
                    OracleParameter pYpzczh = new OracleParameter(":ypzczh", OracleDbType.NVarchar2);
                    pYpzczh.Direction = ParameterDirection.Input;
                    pYpzczh.Value = jc_ypParamLike.Ypzczh;
                    sqlparams.Add(pYpzczh);
                }

                if (null != jc_ypParamLike.Gyzz && "" != jc_ypParamLike.Gyzz)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.GYZZ LIKE '%'||:gyzz||'%' ");
                    OracleParameter pGyzz = new OracleParameter(":gyzz", OracleDbType.NVarchar2);
                    pGyzz.Direction = ParameterDirection.Input;
                    pGyzz.Value = jc_ypParamLike.Gyzz;
                    sqlparams.Add(pGyzz);
                }

                if (null != jc_ypParamLike.Ypjx_code && "" != jc_ypParamLike.Ypjx_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YPJX_CODE LIKE '%'||:ypjx_code||'%' ");
                    OracleParameter pYpjx_code = new OracleParameter(":ypjx_code", OracleDbType.NVarchar2);
                    pYpjx_code.Direction = ParameterDirection.Input;
                    pYpjx_code.Value = jc_ypParamLike.Ypjx_code;
                    sqlparams.Add(pYpjx_code);
                }

                if (null != jc_ypParamLike.Ypgg && "" != jc_ypParamLike.Ypgg)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YPGG LIKE '%'||:ypgg||'%' ");
                    OracleParameter pYpgg = new OracleParameter(":ypgg", OracleDbType.NVarchar2);
                    pYpgg.Direction = ParameterDirection.Input;
                    pYpgg.Value = jc_ypParamLike.Ypgg;
                    sqlparams.Add(pYpgg);
                }

                if (null != jc_ypParamLike.Ypdcyldw_code && "" != jc_ypParamLike.Ypdcyldw_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YPDCYLDW_CODE LIKE '%'||:ypdcyldw_code||'%' ");
                    OracleParameter pYpdcyldw_code = new OracleParameter(":ypdcyldw_code", OracleDbType.NVarchar2);
                    pYpdcyldw_code.Direction = ParameterDirection.Input;
                    pYpdcyldw_code.Value = jc_ypParamLike.Ypdcyldw_code;
                    sqlparams.Add(pYpdcyldw_code);
                }

                if (null != jc_ypParamLike.Ypyytj_code && "" != jc_ypParamLike.Ypyytj_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YPYYTJ_CODE LIKE '%'||:ypyytj_code||'%' ");
                    OracleParameter pYpyytj_code = new OracleParameter(":ypyytj_code", OracleDbType.NVarchar2);
                    pYpyytj_code.Direction = ParameterDirection.Input;
                    pYpyytj_code.Value = jc_ypParamLike.Ypyytj_code;
                    sqlparams.Add(pYpyytj_code);
                }

                if (null != jc_ypParamLike.Ddw_code && "" != jc_ypParamLike.Ddw_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.DDW_CODE LIKE '%'||:ddw_code||'%' ");
                    OracleParameter pDdw_code = new OracleParameter(":ddw_code", OracleDbType.NVarchar2);
                    pDdw_code.Direction = ParameterDirection.Input;
                    pDdw_code.Value = jc_ypParamLike.Ddw_code;
                    sqlparams.Add(pDdw_code);
                }

                if (null != jc_ypParamLike.Xdw_code && "" != jc_ypParamLike.Xdw_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.XDW_CODE LIKE '%'||:xdw_code||'%' ");
                    OracleParameter pXdw_code = new OracleParameter(":xdw_code", OracleDbType.NVarchar2);
                    pXdw_code.Direction = ParameterDirection.Input;
                    pXdw_code.Value = jc_ypParamLike.Xdw_code;
                    sqlparams.Add(pXdw_code);
                }

                if (null != jc_ypParamLike.Cfybz_code && "" != jc_ypParamLike.Cfybz_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.CFYBZ_CODE LIKE '%'||:cfybz_code||'%' ");
                    OracleParameter pCfybz_code = new OracleParameter(":cfybz_code", OracleDbType.NVarchar2);
                    pCfybz_code.Direction = ParameterDirection.Input;
                    pCfybz_code.Value = jc_ypParamLike.Cfybz_code;
                    sqlparams.Add(pCfybz_code);
                }

                if (null != jc_ypParamLike.Cfqxjy_code && "" != jc_ypParamLike.Cfqxjy_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.CFQXJY_CODE LIKE '%'||:cfqxjy_code||'%' ");
                    OracleParameter pCfqxjy_code = new OracleParameter(":cfqxjy_code", OracleDbType.NVarchar2);
                    pCfqxjy_code.Direction = ParameterDirection.Input;
                    pCfqxjy_code.Value = jc_ypParamLike.Cfqxjy_code;
                    sqlparams.Add(pCfqxjy_code);
                }

                if (null != jc_ypParamLike.Cfqxyb_code && "" != jc_ypParamLike.Cfqxyb_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.CFQXYB_CODE LIKE '%'||:cfqxyb_code||'%' ");
                    OracleParameter pCfqxyb_code = new OracleParameter(":cfqxyb_code", OracleDbType.NVarchar2);
                    pCfqxyb_code.Direction = ParameterDirection.Input;
                    pCfqxyb_code.Value = jc_ypParamLike.Cfqxyb_code;
                    sqlparams.Add(pCfqxyb_code);
                }

                if (null != jc_ypParamLike.Cfqxdm_code && "" != jc_ypParamLike.Cfqxdm_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.CFQXDM_CODE LIKE '%'||:cfqxdm_code||'%' ");
                    OracleParameter pCfqxdm_code = new OracleParameter(":cfqxdm_code", OracleDbType.NVarchar2);
                    pCfqxdm_code.Direction = ParameterDirection.Input;
                    pCfqxdm_code.Value = jc_ypParamLike.Cfqxdm_code;
                    sqlparams.Add(pCfqxdm_code);
                }

                if (null != jc_ypParamLike.Cfqxjs_code && "" != jc_ypParamLike.Cfqxjs_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.CFQXJS_CODE LIKE '%'||:cfqxjs_code||'%' ");
                    OracleParameter pCfqxjs_code = new OracleParameter(":cfqxjs_code", OracleDbType.NVarchar2);
                    pCfqxjs_code.Direction = ParameterDirection.Input;
                    pCfqxjs_code.Value = jc_ypParamLike.Cfqxjs_code;
                    sqlparams.Add(pCfqxjs_code);
                }

                if (null != jc_ypParamLike.Cfqxgz_code && "" != jc_ypParamLike.Cfqxgz_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.CFQXGZ_CODE LIKE '%'||:cfqxgz_code||'%' ");
                    OracleParameter pCfqxgz_code = new OracleParameter(":cfqxgz_code", OracleDbType.NVarchar2);
                    pCfqxgz_code.Direction = ParameterDirection.Input;
                    pCfqxgz_code.Value = jc_ypParamLike.Cfqxgz_code;
                    sqlparams.Add(pCfqxgz_code);
                }

                if (null != jc_ypParamLike.Cfqxjk_code && "" != jc_ypParamLike.Cfqxjk_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.CFQXJK_CODE LIKE '%'||:cfqxjk_code||'%' ");
                    OracleParameter pCfqxjk_code = new OracleParameter(":cfqxjk_code", OracleDbType.NVarchar2);
                    pCfqxjk_code.Direction = ParameterDirection.Input;
                    pCfqxjk_code.Value = jc_ypParamLike.Cfqxjk_code;
                    sqlparams.Add(pCfqxjk_code);
                }

                if (null != jc_ypParamLike.Cfqxzz_code && "" != jc_ypParamLike.Cfqxzz_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.CFQXZZ_CODE LIKE '%'||:cfqxzz_code||'%' ");
                    OracleParameter pCfqxzz_code = new OracleParameter(":cfqxzz_code", OracleDbType.NVarchar2);
                    pCfqxzz_code.Direction = ParameterDirection.Input;
                    pCfqxzz_code.Value = jc_ypParamLike.Cfqxzz_code;
                    sqlparams.Add(pCfqxzz_code);
                }

                if (null != jc_ypParamLike.Cfqxzf_code && "" != jc_ypParamLike.Cfqxzf_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.CFQXZF_CODE LIKE '%'||:cfqxzf_code||'%' ");
                    OracleParameter pCfqxzf_code = new OracleParameter(":cfqxzf_code", OracleDbType.NVarchar2);
                    pCfqxzf_code.Direction = ParameterDirection.Input;
                    pCfqxzf_code.Value = jc_ypParamLike.Cfqxzf_code;
                    sqlparams.Add(pCfqxzf_code);
                }

                if (null != jc_ypParamLike.Cfqxts_code && "" != jc_ypParamLike.Cfqxts_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.CFQXTS_CODE LIKE '%'||:cfqxts_code||'%' ");
                    OracleParameter pCfqxts_code = new OracleParameter(":cfqxts_code", OracleDbType.NVarchar2);
                    pCfqxts_code.Direction = ParameterDirection.Input;
                    pCfqxts_code.Value = jc_ypParamLike.Cfqxts_code;
                    sqlparams.Add(pCfqxts_code);
                }

                if (null != jc_ypParamLike.Ps_code && "" != jc_ypParamLike.Ps_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.PS_CODE LIKE '%'||:ps_code||'%' ");
                    OracleParameter pPs_code = new OracleParameter(":ps_code", OracleDbType.NVarchar2);
                    pPs_code.Direction = ParameterDirection.Input;
                    pPs_code.Value = jc_ypParamLike.Ps_code;
                    sqlparams.Add(pPs_code);
                }

                if (null != jc_ypParamLike.Yplx_code && "" != jc_ypParamLike.Yplx_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YPLX_CODE LIKE '%'||:yplx_code||'%' ");
                    OracleParameter pYplx_code = new OracleParameter(":yplx_code", OracleDbType.NVarchar2);
                    pYplx_code.Direction = ParameterDirection.Input;
                    pYplx_code.Value = jc_ypParamLike.Yplx_code;
                    sqlparams.Add(pYplx_code);
                }

                if (null != jc_ypParamLike.Ypmssyz && "" != jc_ypParamLike.Ypmssyz)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YPMSSYZ LIKE '%'||:ypmssyz||'%' ");
                    OracleParameter pYpmssyz = new OracleParameter(":ypmssyz", OracleDbType.NVarchar2);
                    pYpmssyz.Direction = ParameterDirection.Input;
                    pYpmssyz.Value = jc_ypParamLike.Ypmssyz;
                    sqlparams.Add(pYpmssyz);
                }

                if (null != jc_ypParamLike.Ypmsjjz && "" != jc_ypParamLike.Ypmsjjz)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YPMSJJZ LIKE '%'||:ypmsjjz||'%' ");
                    OracleParameter pYpmsjjz = new OracleParameter(":ypmsjjz", OracleDbType.NVarchar2);
                    pYpmsjjz.Direction = ParameterDirection.Input;
                    pYpmsjjz.Value = jc_ypParamLike.Ypmsjjz;
                    sqlparams.Add(pYpmsjjz);
                }

                if (null != jc_ypParamLike.Ypmsyfhbrqjy_code && "" != jc_ypParamLike.Ypmsyfhbrqjy_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YPMSYFHBRQJY_CODE LIKE '%'||:ypmsyfhbrqjy_code||'%' ");
                    OracleParameter pYpmsyfhbrqjy_code = new OracleParameter(":ypmsyfhbrqjy_code", OracleDbType.NVarchar2);
                    pYpmsyfhbrqjy_code.Direction = ParameterDirection.Input;
                    pYpmsyfhbrqjy_code.Value = jc_ypParamLike.Ypmsyfhbrqjy_code;
                    sqlparams.Add(pYpmsyfhbrqjy_code);
                }

                if (null != jc_ypParamLike.Ypmsblfy && "" != jc_ypParamLike.Ypmsblfy)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YPMSBLFY LIKE '%'||:ypmsblfy||'%' ");
                    OracleParameter pYpmsblfy = new OracleParameter(":ypmsblfy", OracleDbType.NVarchar2);
                    pYpmsblfy.Direction = ParameterDirection.Input;
                    pYpmsblfy.Value = jc_ypParamLike.Ypmsblfy;
                    sqlparams.Add(pYpmsblfy);
                }

                if (null != jc_ypParamLike.Ypfl_code && "" != jc_ypParamLike.Ypfl_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YPFL_CODE LIKE '%'||:ypfl_code||'%' ");
                    OracleParameter pYpfl_code = new OracleParameter(":ypfl_code", OracleDbType.NVarchar2);
                    pYpfl_code.Direction = ParameterDirection.Input;
                    pYpfl_code.Value = jc_ypParamLike.Ypfl_code;
                    sqlparams.Add(pYpfl_code);
                }

                if (null != jc_ypParamLike.Yjjb_code && "" != jc_ypParamLike.Yjjb_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YJJB_CODE LIKE '%'||:yjjb_code||'%' ");
                    OracleParameter pYjjb_code = new OracleParameter(":yjjb_code", OracleDbType.NVarchar2);
                    pYjjb_code.Direction = ParameterDirection.Input;
                    pYjjb_code.Value = jc_ypParamLike.Yjjb_code;
                    sqlparams.Add(pYjjb_code);
                }

                if (null != jc_ypParamLike.Txm && "" != jc_ypParamLike.Txm)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.TXM LIKE '%'||:txm||'%' ");
                    OracleParameter pTxm = new OracleParameter(":txm", OracleDbType.NVarchar2);
                    pTxm.Direction = ParameterDirection.Input;
                    pTxm.Value = jc_ypParamLike.Txm;
                    sqlparams.Add(pTxm);
                }

                if (null != jc_ypParamLike.Ewm && "" != jc_ypParamLike.Ewm)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.EWM LIKE '%'||:ewm||'%' ");
                    OracleParameter pEwm = new OracleParameter(":ewm", OracleDbType.NVarchar2);
                    pEwm.Direction = ParameterDirection.Input;
                    pEwm.Value = jc_ypParamLike.Ewm;
                    sqlparams.Add(pEwm);
                }

                if (null != jc_ypParamLike.Pym && "" != jc_ypParamLike.Pym)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.PYM LIKE '%'||:pym||'%' ");
                    OracleParameter pPym = new OracleParameter(":pym", OracleDbType.NVarchar2);
                    pPym.Direction = ParameterDirection.Input;
                    pPym.Value = jc_ypParamLike.Pym;
                    sqlparams.Add(pPym);
                }

                if (null != jc_ypParamLike.Sfcly_code && "" != jc_ypParamLike.Sfcly_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.SFCLY_CODE LIKE '%'||:sfcly_code||'%' ");
                    OracleParameter pSfcly_code = new OracleParameter(":sfcly_code", OracleDbType.NVarchar2);
                    pSfcly_code.Direction = ParameterDirection.Input;
                    pSfcly_code.Value = jc_ypParamLike.Sfcly_code;
                    sqlparams.Add(pSfcly_code);
                }

                if (null != jc_ypParamLike.Sfclm_code && "" != jc_ypParamLike.Sfclm_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.SFCLM_CODE LIKE '%'||:sfclm_code||'%' ");
                    OracleParameter pSfclm_code = new OracleParameter(":sfclm_code", OracleDbType.NVarchar2);
                    pSfclm_code.Direction = ParameterDirection.Input;
                    pSfclm_code.Value = jc_ypParamLike.Sfclm_code;
                    sqlparams.Add(pSfclm_code);
                }

                if (null != jc_ypParamLike.Yxzt_code && "" != jc_ypParamLike.Yxzt_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YXZT_CODE LIKE '%'||:yxzt_code||'%' ");
                    OracleParameter pYxzt_code = new OracleParameter(":yxzt_code", OracleDbType.NVarchar2);
                    pYxzt_code.Direction = ParameterDirection.Input;
                    pYxzt_code.Value = jc_ypParamLike.Yxzt_code;
                    sqlparams.Add(pYxzt_code);
                }

                if (null != jc_ypParamLike.Scqy && "" != jc_ypParamLike.Scqy)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.SCQY LIKE '%'||:scqy||'%' ");
                    OracleParameter pScqy = new OracleParameter(":scqy", OracleDbType.NVarchar2);
                    pScqy.Direction = ParameterDirection.Input;
                    pScqy.Value = jc_ypParamLike.Scqy;
                    sqlparams.Add(pScqy);
                }

                if (null != jc_ypParamLike.Sfkss_code && "" != jc_ypParamLike.Sfkss_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.SFKSS_CODE LIKE '%'||:sfkss_code||'%' ");
                    OracleParameter pSfkss_code = new OracleParameter(":sfkss_code", OracleDbType.NVarchar2);
                    pSfkss_code.Direction = ParameterDirection.Input;
                    pSfkss_code.Value = jc_ypParamLike.Sfkss_code;
                    sqlparams.Add(pSfkss_code);
                }

                if (null != jc_ypParamLike.Zfbz && "" != jc_ypParamLike.Zfbz)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.ZFBZ LIKE '%'||:zfbz||'%' ");
                    OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                    pZfbz.Direction = ParameterDirection.Input;
                    pZfbz.Value = jc_ypParamLike.Zfbz;
                    sqlparams.Add(pZfbz);
                }

            }

            this.b_isWhere = false;
            //排序
            this.addSort(sql, sortList);
            //*******分页start1*********如果分页对象为空，则全部数据查出，如果不为空
            List<object> returnList = new List<object>();//返回的List,索引0为List<Jc_yp>对象,索引1为Model.Common.PageInfo分页信息对象
            if (null != page)
            {
                string sqlParam = sql.ToString();
                sql = new StringBuilder(@" SELECT * FROM 
                (
                SELECT A.*, ROWNUM RN 
                FROM (" + sqlParam + @") A 
                WHERE ROWNUM <= :maxIndex
                )
                WHERE RN >= :minIndex ");
                sqlparams.Add(new OracleParameter("maxIndex", page.MaxIndex));
                sqlparams.Add(new OracleParameter("minIndex", page.MinIndex));
            }
            //*******分页end1*********
            DataSet ds = OracleHelper.getDataSet(sql.ToString(), sqlparams.ToArray());
            DataRowCollection rows = ds.Tables[0].Rows;
            //把每一行数据转换为一个对象放入List<Jc_yp>中
            for (int i = 0; i < rows.Count; i++)
            {
                DataRow row = rows[i];
                jc_ypParamList.Add(this.dataSetContactObjectsToModel(row));
                //jc_ypParamList.Add(this.dataSetToModel(row));
            }

            //*******分页start2*********如果没有传入分页对象，则新建一个分页对象当做返回值
            if (null == page)
            {
                page = new Model.Common.PageInfo();
                page.AllCount = rows.Count;
            }
            returnList.Add(jc_ypParamList);//把List<Jc_yp>放入List<object>中第一个
            returnList.Add(page);//把page对象放入List<object>中第二个
            //*******分页end2*********
            return returnList;
        }
        #endregion DAL层的implement,实现，end


        public List<object> findContactObjectsForFast(Jc_yp jc_ypParam, Model.Common.PageInfo page, Jc_yp jc_ypParamLike, List<SortInfo> sortList)
        {
            //如果没有传查询条件参数，就new一个空的Jc_yp对象，标示查询所有数据
            if (null == jc_ypParam)
            {
                jc_ypParam = new Jc_yp();
            }
            if (null != jc_ypParam.Id && "" != jc_ypParam.Id)
            {
                throw new Exception("此方法不允许指定参数ID，如果需要根据ID查询数据，请调用findById方法；错误出自：find");
            }

            List<Jc_yp> jc_ypParamList = new List<Jc_yp>();//接收查询出的Jc_yp对象集合
            List<OracleParameter> sqlparams = new List<OracleParameter>();//保存参数的集合
            StringBuilder sql = new StringBuilder("SELECT A.* ");
            //新建方法findAllContactObjects(Jc_yp jc_ypParam, Model.Common.PageInfo page)，在此加入多表连接要显示的项start
            //sql.Append(",B.字段一,B.字段二,B.字段三");

            sql.Append(@"
            ,TT_YPJX_CODE.ID AS YPJX_CODE_ID,TT_YPJX_CODE.NAME AS YPJX_CODE_NAME,TT_YPJX_CODE.VALUE AS YPJX_CODE_VALUE,TT_YPJX_CODE.FK_CODE_TYPE AS YPJX_CODE_FKCODETYPE,TT_YPJX_CODE.ZFBZ AS YPJX_CODE_ZFBZ,TT_YPJX_CODE.REMARK AS YPJX_CODE_REMARK
            ");

            sql.Append(@"
            ,TT_YPDCYLDW_CODE.ID AS YPDCYLDW_CODE_ID,TT_YPDCYLDW_CODE.NAME AS YPDCYLDW_CODE_NAME,TT_YPDCYLDW_CODE.VALUE AS YPDCYLDW_CODE_VALUE,TT_YPDCYLDW_CODE.FK_CODE_TYPE AS YPDCYLDW_CODE_FKCODETYPE,TT_YPDCYLDW_CODE.ZFBZ AS YPDCYLDW_CODE_ZFBZ,TT_YPDCYLDW_CODE.REMARK AS YPDCYLDW_CODE_REMARK
            ");

            sql.Append(@"
            ,TT_YPYYTJ_CODE.ID AS YPYYTJ_CODE_ID,TT_YPYYTJ_CODE.NAME AS YPYYTJ_CODE_NAME,TT_YPYYTJ_CODE.VALUE AS YPYYTJ_CODE_VALUE,TT_YPYYTJ_CODE.FK_CODE_TYPE AS YPYYTJ_CODE_FKCODETYPE,TT_YPYYTJ_CODE.ZFBZ AS YPYYTJ_CODE_ZFBZ,TT_YPYYTJ_CODE.REMARK AS YPYYTJ_CODE_REMARK
            ");

            sql.Append(@"
            ,TT_DDW_CODE.ID AS DDW_CODE_ID,TT_DDW_CODE.NAME AS DDW_CODE_NAME,TT_DDW_CODE.VALUE AS DDW_CODE_VALUE,TT_DDW_CODE.FK_CODE_TYPE AS DDW_CODE_FKCODETYPE,TT_DDW_CODE.ZFBZ AS DDW_CODE_ZFBZ,TT_DDW_CODE.REMARK AS DDW_CODE_REMARK
            ");

            sql.Append(@"
            ,TT_XDW_CODE.ID AS XDW_CODE_ID,TT_XDW_CODE.NAME AS XDW_CODE_NAME,TT_XDW_CODE.VALUE AS XDW_CODE_VALUE,TT_XDW_CODE.FK_CODE_TYPE AS XDW_CODE_FKCODETYPE,TT_XDW_CODE.ZFBZ AS XDW_CODE_ZFBZ,TT_XDW_CODE.REMARK AS XDW_CODE_REMARK
            ");

            sql.Append(@"
            ,TT_CFYBZ_CODE.ID AS CFYBZ_CODE_ID,TT_CFYBZ_CODE.NAME AS CFYBZ_CODE_NAME,TT_CFYBZ_CODE.VALUE AS CFYBZ_CODE_VALUE,TT_CFYBZ_CODE.FK_CODE_TYPE AS CFYBZ_CODE_FKCODETYPE,TT_CFYBZ_CODE.ZFBZ AS CFYBZ_CODE_ZFBZ,TT_CFYBZ_CODE.REMARK AS CFYBZ_CODE_REMARK
            ");

            sql.Append(@"
            ,TT_CFQXJY_CODE.ID AS CFQXJY_CODE_ID,TT_CFQXJY_CODE.NAME AS CFQXJY_CODE_NAME,TT_CFQXJY_CODE.VALUE AS CFQXJY_CODE_VALUE,TT_CFQXJY_CODE.FK_CODE_TYPE AS CFQXJY_CODE_FKCODETYPE,TT_CFQXJY_CODE.ZFBZ AS CFQXJY_CODE_ZFBZ,TT_CFQXJY_CODE.REMARK AS CFQXJY_CODE_REMARK
            ");

            sql.Append(@"
            ,TT_CFQXYB_CODE.ID AS CFQXYB_CODE_ID,TT_CFQXYB_CODE.NAME AS CFQXYB_CODE_NAME,TT_CFQXYB_CODE.VALUE AS CFQXYB_CODE_VALUE,TT_CFQXYB_CODE.FK_CODE_TYPE AS CFQXYB_CODE_FKCODETYPE,TT_CFQXYB_CODE.ZFBZ AS CFQXYB_CODE_ZFBZ,TT_CFQXYB_CODE.REMARK AS CFQXYB_CODE_REMARK
            ");

            sql.Append(@"
            ,TT_CFQXDM_CODE.ID AS CFQXDM_CODE_ID,TT_CFQXDM_CODE.NAME AS CFQXDM_CODE_NAME,TT_CFQXDM_CODE.VALUE AS CFQXDM_CODE_VALUE,TT_CFQXDM_CODE.FK_CODE_TYPE AS CFQXDM_CODE_FKCODETYPE,TT_CFQXDM_CODE.ZFBZ AS CFQXDM_CODE_ZFBZ,TT_CFQXDM_CODE.REMARK AS CFQXDM_CODE_REMARK
            ");

            sql.Append(@"
            ,TT_CFQXJS_CODE.ID AS CFQXJS_CODE_ID,TT_CFQXJS_CODE.NAME AS CFQXJS_CODE_NAME,TT_CFQXJS_CODE.VALUE AS CFQXJS_CODE_VALUE,TT_CFQXJS_CODE.FK_CODE_TYPE AS CFQXJS_CODE_FKCODETYPE,TT_CFQXJS_CODE.ZFBZ AS CFQXJS_CODE_ZFBZ,TT_CFQXJS_CODE.REMARK AS CFQXJS_CODE_REMARK
            ");

            sql.Append(@"
            ,TT_CFQXGZ_CODE.ID AS CFQXGZ_CODE_ID,TT_CFQXGZ_CODE.NAME AS CFQXGZ_CODE_NAME,TT_CFQXGZ_CODE.VALUE AS CFQXGZ_CODE_VALUE,TT_CFQXGZ_CODE.FK_CODE_TYPE AS CFQXGZ_CODE_FKCODETYPE,TT_CFQXGZ_CODE.ZFBZ AS CFQXGZ_CODE_ZFBZ,TT_CFQXGZ_CODE.REMARK AS CFQXGZ_CODE_REMARK
            ");

            sql.Append(@"
            ,TT_CFQXJK_CODE.ID AS CFQXJK_CODE_ID,TT_CFQXJK_CODE.NAME AS CFQXJK_CODE_NAME,TT_CFQXJK_CODE.VALUE AS CFQXJK_CODE_VALUE,TT_CFQXJK_CODE.FK_CODE_TYPE AS CFQXJK_CODE_FKCODETYPE,TT_CFQXJK_CODE.ZFBZ AS CFQXJK_CODE_ZFBZ,TT_CFQXJK_CODE.REMARK AS CFQXJK_CODE_REMARK
            ");

            sql.Append(@"
            ,TT_CFQXZZ_CODE.ID AS CFQXZZ_CODE_ID,TT_CFQXZZ_CODE.NAME AS CFQXZZ_CODE_NAME,TT_CFQXZZ_CODE.VALUE AS CFQXZZ_CODE_VALUE,TT_CFQXZZ_CODE.FK_CODE_TYPE AS CFQXZZ_CODE_FKCODETYPE,TT_CFQXZZ_CODE.ZFBZ AS CFQXZZ_CODE_ZFBZ,TT_CFQXZZ_CODE.REMARK AS CFQXZZ_CODE_REMARK
            ");

            sql.Append(@"
            ,TT_CFQXZF_CODE.ID AS CFQXZF_CODE_ID,TT_CFQXZF_CODE.NAME AS CFQXZF_CODE_NAME,TT_CFQXZF_CODE.VALUE AS CFQXZF_CODE_VALUE,TT_CFQXZF_CODE.FK_CODE_TYPE AS CFQXZF_CODE_FKCODETYPE,TT_CFQXZF_CODE.ZFBZ AS CFQXZF_CODE_ZFBZ,TT_CFQXZF_CODE.REMARK AS CFQXZF_CODE_REMARK
            ");

            sql.Append(@"
            ,TT_CFQXTS_CODE.ID AS CFQXTS_CODE_ID,TT_CFQXTS_CODE.NAME AS CFQXTS_CODE_NAME,TT_CFQXTS_CODE.VALUE AS CFQXTS_CODE_VALUE,TT_CFQXTS_CODE.FK_CODE_TYPE AS CFQXTS_CODE_FKCODETYPE,TT_CFQXTS_CODE.ZFBZ AS CFQXTS_CODE_ZFBZ,TT_CFQXTS_CODE.REMARK AS CFQXTS_CODE_REMARK
            ");

            sql.Append(@"
            ,TT_PS_CODE.ID AS PS_CODE_ID,TT_PS_CODE.NAME AS PS_CODE_NAME,TT_PS_CODE.VALUE AS PS_CODE_VALUE,TT_PS_CODE.FK_CODE_TYPE AS PS_CODE_FKCODETYPE,TT_PS_CODE.ZFBZ AS PS_CODE_ZFBZ,TT_PS_CODE.REMARK AS PS_CODE_REMARK
            ");

            sql.Append(@"
            ,TT_YPLX_CODE.ID AS YPLX_CODE_ID,TT_YPLX_CODE.NAME AS YPLX_CODE_NAME,TT_YPLX_CODE.VALUE AS YPLX_CODE_VALUE,TT_YPLX_CODE.FK_CODE_TYPE AS YPLX_CODE_FKCODETYPE,TT_YPLX_CODE.ZFBZ AS YPLX_CODE_ZFBZ,TT_YPLX_CODE.REMARK AS YPLX_CODE_REMARK
            ");

            sql.Append(@"
            ,TT_YPMSYFHBRQJY_CODE.ID AS YPMSYFHBRQJY_CODE_ID,TT_YPMSYFHBRQJY_CODE.NAME AS YPMSYFHBRQJY_CODE_NAME,TT_YPMSYFHBRQJY_CODE.VALUE AS YPMSYFHBRQJY_CODE_VALUE,TT_YPMSYFHBRQJY_CODE.FK_CODE_TYPE AS YPMSYFHBRQJY_CODE_FKCODETYPE,TT_YPMSYFHBRQJY_CODE.ZFBZ AS YPMSYFHBRQJY_CODE_ZFBZ,TT_YPMSYFHBRQJY_CODE.REMARK AS YPMSYFHBRQJY_CODE_REMARK
            ");

            sql.Append(@"
            ,TT_YPFL_CODE.ID AS YPFL_CODE_ID,TT_YPFL_CODE.NAME AS YPFL_CODE_NAME,TT_YPFL_CODE.VALUE AS YPFL_CODE_VALUE,TT_YPFL_CODE.FK_CODE_TYPE AS YPFL_CODE_FKCODETYPE,TT_YPFL_CODE.ZFBZ AS YPFL_CODE_ZFBZ,TT_YPFL_CODE.REMARK AS YPFL_CODE_REMARK
            ");

            sql.Append(@"
            ,TT_YJJB_CODE.ID AS YJJB_CODE_ID,TT_YJJB_CODE.NAME AS YJJB_CODE_NAME,TT_YJJB_CODE.VALUE AS YJJB_CODE_VALUE,TT_YJJB_CODE.FK_CODE_TYPE AS YJJB_CODE_FKCODETYPE,TT_YJJB_CODE.ZFBZ AS YJJB_CODE_ZFBZ,TT_YJJB_CODE.REMARK AS YJJB_CODE_REMARK
            ");

            sql.Append(@"
            ,TT_SFCLY_CODE.ID AS SFCLY_CODE_ID,TT_SFCLY_CODE.NAME AS SFCLY_CODE_NAME,TT_SFCLY_CODE.VALUE AS SFCLY_CODE_VALUE,TT_SFCLY_CODE.FK_CODE_TYPE AS SFCLY_CODE_FKCODETYPE,TT_SFCLY_CODE.ZFBZ AS SFCLY_CODE_ZFBZ,TT_SFCLY_CODE.REMARK AS SFCLY_CODE_REMARK
            ");

            sql.Append(@"
            ,TT_SFCLM_CODE.ID AS SFCLM_CODE_ID,TT_SFCLM_CODE.NAME AS SFCLM_CODE_NAME,TT_SFCLM_CODE.VALUE AS SFCLM_CODE_VALUE,TT_SFCLM_CODE.FK_CODE_TYPE AS SFCLM_CODE_FKCODETYPE,TT_SFCLM_CODE.ZFBZ AS SFCLM_CODE_ZFBZ,TT_SFCLM_CODE.REMARK AS SFCLM_CODE_REMARK
            ");

            sql.Append(@"
            ,TT_YXZT_CODE.ID AS YXZT_CODE_ID,TT_YXZT_CODE.NAME AS YXZT_CODE_NAME,TT_YXZT_CODE.VALUE AS YXZT_CODE_VALUE,TT_YXZT_CODE.FK_CODE_TYPE AS YXZT_CODE_FKCODETYPE,TT_YXZT_CODE.ZFBZ AS YXZT_CODE_ZFBZ,TT_YXZT_CODE.REMARK AS YXZT_CODE_REMARK
            ");

            sql.Append(@"
            ,TT_SFKSS_CODE.ID AS SFKSS_CODE_ID,TT_SFKSS_CODE.NAME AS SFKSS_CODE_NAME,TT_SFKSS_CODE.VALUE AS SFKSS_CODE_VALUE,TT_SFKSS_CODE.FK_CODE_TYPE AS SFKSS_CODE_FKCODETYPE,TT_SFKSS_CODE.ZFBZ AS SFKSS_CODE_ZFBZ,TT_SFKSS_CODE.REMARK AS SFKSS_CODE_REMARK
            ");

            //新建方法，在此加入多表连接要显示的项end
            sql.Append(" FROM JC_YP A ");
            //新建一个方法，在此加入多表连接的语句start
            ////sql.Append(" LEFT JOIN 表名 B ON A.外键=B.ID");

            sql.Append(@" 
                        LEFT JOIN 
                        (SELECT X.* FROM JC_CODE X WHERE X.FK_CODE_TYPE IN (SELECT Y.ID FROM JC_CODE_TYPE Y WHERE Y.VALUE='" + Model.Common.CommonCode.代码类型值.CV5301_01药物剂型代码 + @"')) TT_YPJX_CODE
                        ON A.YPJX_CODE = TT_YPJX_CODE.VALUE
            ");

            sql.Append(@" 
                        LEFT JOIN 
                        (SELECT X.* FROM JC_CODE X WHERE X.FK_CODE_TYPE IN (SELECT Y.ID FROM JC_CODE_TYPE Y WHERE Y.VALUE='" + Model.Common.CommonCode.代码类型值.药品_单次用量单位 + @"')) TT_YPDCYLDW_CODE
                        ON A.YPDCYLDW_CODE = TT_YPDCYLDW_CODE.VALUE
            ");

            sql.Append(@" 
                        LEFT JOIN 
                        (SELECT X.* FROM JC_CODE X WHERE X.FK_CODE_TYPE IN (SELECT Y.ID FROM JC_CODE_TYPE Y WHERE Y.VALUE='" + Model.Common.CommonCode.代码类型值.CV5201_22用药途径代码 + @"')) TT_YPYYTJ_CODE
                        ON A.YPYYTJ_CODE = TT_YPYYTJ_CODE.VALUE
            ");

            sql.Append(@" 
                        LEFT JOIN 
                        (SELECT X.* FROM JC_CODE X WHERE X.FK_CODE_TYPE IN (SELECT Y.ID FROM JC_CODE_TYPE Y WHERE Y.VALUE='" + Model.Common.CommonCode.代码类型值.药品_大单位 + @"')) TT_DDW_CODE
                        ON A.DDW_CODE = TT_DDW_CODE.VALUE
            ");

            sql.Append(@" 
                        LEFT JOIN 
                        (SELECT X.* FROM JC_CODE X WHERE X.FK_CODE_TYPE IN (SELECT Y.ID FROM JC_CODE_TYPE Y WHERE Y.VALUE='" + Model.Common.CommonCode.代码类型值.药品_小单位 + @"')) TT_XDW_CODE
                        ON A.XDW_CODE = TT_XDW_CODE.VALUE
            ");

            sql.Append(@" 
                        LEFT JOIN 
                        (SELECT X.* FROM JC_CODE X WHERE X.FK_CODE_TYPE IN (SELECT Y.ID FROM JC_CODE_TYPE Y WHERE Y.VALUE='" + Model.Common.CommonCode.代码类型值.基础_是否 + @"')) TT_CFYBZ_CODE
                        ON A.CFYBZ_CODE = TT_CFYBZ_CODE.VALUE
            ");

            sql.Append(@" 
                        LEFT JOIN 
                        (SELECT X.* FROM JC_CODE X WHERE X.FK_CODE_TYPE IN (SELECT Y.ID FROM JC_CODE_TYPE Y WHERE Y.VALUE='" + Model.Common.CommonCode.代码类型值.基础_是否 + @"')) TT_CFQXJY_CODE
                        ON A.CFQXJY_CODE = TT_CFQXJY_CODE.VALUE
            ");

            sql.Append(@" 
                        LEFT JOIN 
                        (SELECT X.* FROM JC_CODE X WHERE X.FK_CODE_TYPE IN (SELECT Y.ID FROM JC_CODE_TYPE Y WHERE Y.VALUE='" + Model.Common.CommonCode.代码类型值.基础_是否 + @"')) TT_CFQXYB_CODE
                        ON A.CFQXYB_CODE = TT_CFQXYB_CODE.VALUE
            ");

            sql.Append(@" 
                        LEFT JOIN 
                        (SELECT X.* FROM JC_CODE X WHERE X.FK_CODE_TYPE IN (SELECT Y.ID FROM JC_CODE_TYPE Y WHERE Y.VALUE='" + Model.Common.CommonCode.代码类型值.基础_是否 + @"')) TT_CFQXDM_CODE
                        ON A.CFQXDM_CODE = TT_CFQXDM_CODE.VALUE
            ");

            sql.Append(@" 
                        LEFT JOIN 
                        (SELECT X.* FROM JC_CODE X WHERE X.FK_CODE_TYPE IN (SELECT Y.ID FROM JC_CODE_TYPE Y WHERE Y.VALUE='" + Model.Common.CommonCode.代码类型值.基础_是否 + @"')) TT_CFQXJS_CODE
                        ON A.CFQXJS_CODE = TT_CFQXJS_CODE.VALUE
            ");

            sql.Append(@" 
                        LEFT JOIN 
                        (SELECT X.* FROM JC_CODE X WHERE X.FK_CODE_TYPE IN (SELECT Y.ID FROM JC_CODE_TYPE Y WHERE Y.VALUE='" + Model.Common.CommonCode.代码类型值.基础_是否 + @"')) TT_CFQXGZ_CODE
                        ON A.CFQXGZ_CODE = TT_CFQXGZ_CODE.VALUE
            ");

            sql.Append(@" 
                        LEFT JOIN 
                        (SELECT X.* FROM JC_CODE X WHERE X.FK_CODE_TYPE IN (SELECT Y.ID FROM JC_CODE_TYPE Y WHERE Y.VALUE='" + Model.Common.CommonCode.代码类型值.基础_是否 + @"')) TT_CFQXJK_CODE
                        ON A.CFQXJK_CODE = TT_CFQXJK_CODE.VALUE
            ");

            sql.Append(@" 
                        LEFT JOIN 
                        (SELECT X.* FROM JC_CODE X WHERE X.FK_CODE_TYPE IN (SELECT Y.ID FROM JC_CODE_TYPE Y WHERE Y.VALUE='" + Model.Common.CommonCode.代码类型值.基础_是否 + @"')) TT_CFQXZZ_CODE
                        ON A.CFQXZZ_CODE = TT_CFQXZZ_CODE.VALUE
            ");

            sql.Append(@" 
                        LEFT JOIN 
                        (SELECT X.* FROM JC_CODE X WHERE X.FK_CODE_TYPE IN (SELECT Y.ID FROM JC_CODE_TYPE Y WHERE Y.VALUE='" + Model.Common.CommonCode.代码类型值.基础_是否 + @"')) TT_CFQXZF_CODE
                        ON A.CFQXZF_CODE = TT_CFQXZF_CODE.VALUE
            ");

            sql.Append(@" 
                        LEFT JOIN 
                        (SELECT X.* FROM JC_CODE X WHERE X.FK_CODE_TYPE IN (SELECT Y.ID FROM JC_CODE_TYPE Y WHERE Y.VALUE='" + Model.Common.CommonCode.代码类型值.基础_是否 + @"')) TT_CFQXTS_CODE
                        ON A.CFQXTS_CODE = TT_CFQXTS_CODE.VALUE
            ");

            sql.Append(@" 
                        LEFT JOIN 
                        (SELECT X.* FROM JC_CODE X WHERE X.FK_CODE_TYPE IN (SELECT Y.ID FROM JC_CODE_TYPE Y WHERE Y.VALUE='" + Model.Common.CommonCode.代码类型值.基础_是否 + @"')) TT_PS_CODE
                        ON A.PS_CODE = TT_PS_CODE.VALUE
            ");

            sql.Append(@" 
                        LEFT JOIN 
                        (SELECT X.* FROM JC_CODE X WHERE X.FK_CODE_TYPE IN (SELECT Y.ID FROM JC_CODE_TYPE Y WHERE Y.VALUE='" + Model.Common.CommonCode.代码类型值.CV5301_06药物类型代码 + @"')) TT_YPLX_CODE
                        ON A.YPLX_CODE = TT_YPLX_CODE.VALUE
            ");

            sql.Append(@" 
                        LEFT JOIN 
                        (SELECT X.* FROM JC_CODE X WHERE X.FK_CODE_TYPE IN (SELECT Y.ID FROM JC_CODE_TYPE Y WHERE Y.VALUE='" + Model.Common.CommonCode.代码类型值.基础_是否 + @"')) TT_YPMSYFHBRQJY_CODE
                        ON A.YPMSYFHBRQJY_CODE = TT_YPMSYFHBRQJY_CODE.VALUE
            ");

            sql.Append(@" 
                        LEFT JOIN 
                        (SELECT X.* FROM JC_CODE X WHERE X.FK_CODE_TYPE IN (SELECT Y.ID FROM JC_CODE_TYPE Y WHERE Y.VALUE='" + Model.Common.CommonCode.代码类型值.药品_分类 + @"')) TT_YPFL_CODE
                        ON A.YPFL_CODE = TT_YPFL_CODE.VALUE
            ");

            sql.Append(@" 
                        LEFT JOIN 
                        (SELECT X.* FROM JC_CODE X WHERE X.FK_CODE_TYPE IN (SELECT Y.ID FROM JC_CODE_TYPE Y WHERE Y.VALUE='" + Model.Common.CommonCode.代码类型值.药品_药价级别 + @"')) TT_YJJB_CODE
                        ON A.YJJB_CODE = TT_YJJB_CODE.VALUE
            ");

            sql.Append(@" 
                        LEFT JOIN 
                        (SELECT X.* FROM JC_CODE X WHERE X.FK_CODE_TYPE IN (SELECT Y.ID FROM JC_CODE_TYPE Y WHERE Y.VALUE='" + Model.Common.CommonCode.代码类型值.基础_是否 + @"')) TT_SFCLY_CODE
                        ON A.SFCLY_CODE = TT_SFCLY_CODE.VALUE
            ");

            sql.Append(@" 
                        LEFT JOIN 
                        (SELECT X.* FROM JC_CODE X WHERE X.FK_CODE_TYPE IN (SELECT Y.ID FROM JC_CODE_TYPE Y WHERE Y.VALUE='" + Model.Common.CommonCode.代码类型值.基础_是否 + @"')) TT_SFCLM_CODE
                        ON A.SFCLM_CODE = TT_SFCLM_CODE.VALUE
            ");

            sql.Append(@" 
                        LEFT JOIN 
                        (SELECT X.* FROM JC_CODE X WHERE X.FK_CODE_TYPE IN (SELECT Y.ID FROM JC_CODE_TYPE Y WHERE Y.VALUE='" + Model.Common.CommonCode.代码类型值.基础_有效状态 + @"')) TT_YXZT_CODE
                        ON A.YXZT_CODE = TT_YXZT_CODE.VALUE
            ");

            sql.Append(@" 
                        LEFT JOIN 
                        (SELECT X.* FROM JC_CODE X WHERE X.FK_CODE_TYPE IN (SELECT Y.ID FROM JC_CODE_TYPE Y WHERE Y.VALUE='" + Model.Common.CommonCode.代码类型值.基础_是否 + @"')) TT_SFKSS_CODE
                        ON A.SFKSS_CODE = TT_SFKSS_CODE.VALUE
            ");

            //新建一个方法，在此加入多表连接的语句end


            if (null != jc_ypParam.Ypbm && "" != jc_ypParam.Ypbm)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.YPBM=:ypbm ");
                OracleParameter pYpbm = new OracleParameter(":ypbm", OracleDbType.NVarchar2);
                pYpbm.Value = jc_ypParam.Ypbm;
                sqlparams.Add(pYpbm);
            }

            if (null != jc_ypParam.Ypmc && "" != jc_ypParam.Ypmc)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.YPMC=:ypmc ");
                OracleParameter pYpmc = new OracleParameter(":ypmc", OracleDbType.NVarchar2);
                pYpmc.Value = jc_ypParam.Ypmc;
                sqlparams.Add(pYpmc);
            }

            if (null != jc_ypParam.Yptymc && "" != jc_ypParam.Yptymc)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.YPTYMC=:yptymc ");
                OracleParameter pYptymc = new OracleParameter(":yptymc", OracleDbType.NVarchar2);
                pYptymc.Value = jc_ypParam.Yptymc;
                sqlparams.Add(pYptymc);
            }

            if (null != jc_ypParam.Ypcf && "" != jc_ypParam.Ypcf)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.YPCF=:ypcf ");
                OracleParameter pYpcf = new OracleParameter(":ypcf", OracleDbType.NVarchar2);
                pYpcf.Value = jc_ypParam.Ypcf;
                sqlparams.Add(pYpcf);
            }

            if (null != jc_ypParam.Yppzwh && "" != jc_ypParam.Yppzwh)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.YPPZWH=:yppzwh ");
                OracleParameter pYppzwh = new OracleParameter(":yppzwh", OracleDbType.NVarchar2);
                pYppzwh.Value = jc_ypParam.Yppzwh;
                sqlparams.Add(pYppzwh);
            }

            if (null != jc_ypParam.Ypzczh && "" != jc_ypParam.Ypzczh)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.YPZCZH=:ypzczh ");
                OracleParameter pYpzczh = new OracleParameter(":ypzczh", OracleDbType.NVarchar2);
                pYpzczh.Value = jc_ypParam.Ypzczh;
                sqlparams.Add(pYpzczh);
            }

            if (null != jc_ypParam.Gyzz && "" != jc_ypParam.Gyzz)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.GYZZ=:gyzz ");
                OracleParameter pGyzz = new OracleParameter(":gyzz", OracleDbType.NVarchar2);
                pGyzz.Value = jc_ypParam.Gyzz;
                sqlparams.Add(pGyzz);
            }

            if (null != jc_ypParam.Ypjx_code && "" != jc_ypParam.Ypjx_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.YPJX_CODE=:ypjx_code ");
                OracleParameter pYpjx_code = new OracleParameter(":ypjx_code", OracleDbType.NVarchar2);
                pYpjx_code.Value = jc_ypParam.Ypjx_code;
                sqlparams.Add(pYpjx_code);
            }

            if (null != jc_ypParam.Ypgg && "" != jc_ypParam.Ypgg)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.YPGG=:ypgg ");
                OracleParameter pYpgg = new OracleParameter(":ypgg", OracleDbType.NVarchar2);
                pYpgg.Value = jc_ypParam.Ypgg;
                sqlparams.Add(pYpgg);
            }

            if (null != jc_ypParam.Ypdcyl)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" YPDCYL=:ypdcyl ");
                OracleParameter pYpdcyl = new OracleParameter(":ypdcyl", OracleDbType.Decimal);
                pYpdcyl.Value = jc_ypParam.Ypdcyl;
                sqlparams.Add(pYpdcyl);

            }

            if (null != jc_ypParam.Ypdcyldw_code && "" != jc_ypParam.Ypdcyldw_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.YPDCYLDW_CODE=:ypdcyldw_code ");
                OracleParameter pYpdcyldw_code = new OracleParameter(":ypdcyldw_code", OracleDbType.NVarchar2);
                pYpdcyldw_code.Value = jc_ypParam.Ypdcyldw_code;
                sqlparams.Add(pYpdcyldw_code);
            }

            if (null != jc_ypParam.Ypyytj_code && "" != jc_ypParam.Ypyytj_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.YPYYTJ_CODE=:ypyytj_code ");
                OracleParameter pYpyytj_code = new OracleParameter(":ypyytj_code", OracleDbType.NVarchar2);
                pYpyytj_code.Value = jc_ypParam.Ypyytj_code;
                sqlparams.Add(pYpyytj_code);
            }

            if (null != jc_ypParam.Ddw_code && "" != jc_ypParam.Ddw_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.DDW_CODE=:ddw_code ");
                OracleParameter pDdw_code = new OracleParameter(":ddw_code", OracleDbType.NVarchar2);
                pDdw_code.Value = jc_ypParam.Ddw_code;
                sqlparams.Add(pDdw_code);
            }

            if (null != jc_ypParam.Xdw_code && "" != jc_ypParam.Xdw_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.XDW_CODE=:xdw_code ");
                OracleParameter pXdw_code = new OracleParameter(":xdw_code", OracleDbType.NVarchar2);
                pXdw_code.Value = jc_ypParam.Xdw_code;
                sqlparams.Add(pXdw_code);
            }

            if (null != jc_ypParam.Cfybz_code && "" != jc_ypParam.Cfybz_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.CFYBZ_CODE=:cfybz_code ");
                OracleParameter pCfybz_code = new OracleParameter(":cfybz_code", OracleDbType.NVarchar2);
                pCfybz_code.Value = jc_ypParam.Cfybz_code;
                sqlparams.Add(pCfybz_code);
            }

            if (null != jc_ypParam.Cfqxjy_code && "" != jc_ypParam.Cfqxjy_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.CFQXJY_CODE=:cfqxjy_code ");
                OracleParameter pCfqxjy_code = new OracleParameter(":cfqxjy_code", OracleDbType.NVarchar2);
                pCfqxjy_code.Value = jc_ypParam.Cfqxjy_code;
                sqlparams.Add(pCfqxjy_code);
            }

            if (null != jc_ypParam.Cfqxyb_code && "" != jc_ypParam.Cfqxyb_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.CFQXYB_CODE=:cfqxyb_code ");
                OracleParameter pCfqxyb_code = new OracleParameter(":cfqxyb_code", OracleDbType.NVarchar2);
                pCfqxyb_code.Value = jc_ypParam.Cfqxyb_code;
                sqlparams.Add(pCfqxyb_code);
            }

            if (null != jc_ypParam.Cfqxdm_code && "" != jc_ypParam.Cfqxdm_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.CFQXDM_CODE=:cfqxdm_code ");
                OracleParameter pCfqxdm_code = new OracleParameter(":cfqxdm_code", OracleDbType.NVarchar2);
                pCfqxdm_code.Value = jc_ypParam.Cfqxdm_code;
                sqlparams.Add(pCfqxdm_code);
            }

            if (null != jc_ypParam.Cfqxjs_code && "" != jc_ypParam.Cfqxjs_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.CFQXJS_CODE=:cfqxjs_code ");
                OracleParameter pCfqxjs_code = new OracleParameter(":cfqxjs_code", OracleDbType.NVarchar2);
                pCfqxjs_code.Value = jc_ypParam.Cfqxjs_code;
                sqlparams.Add(pCfqxjs_code);
            }

            if (null != jc_ypParam.Cfqxgz_code && "" != jc_ypParam.Cfqxgz_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.CFQXGZ_CODE=:cfqxgz_code ");
                OracleParameter pCfqxgz_code = new OracleParameter(":cfqxgz_code", OracleDbType.NVarchar2);
                pCfqxgz_code.Value = jc_ypParam.Cfqxgz_code;
                sqlparams.Add(pCfqxgz_code);
            }

            if (null != jc_ypParam.Cfqxjk_code && "" != jc_ypParam.Cfqxjk_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.CFQXJK_CODE=:cfqxjk_code ");
                OracleParameter pCfqxjk_code = new OracleParameter(":cfqxjk_code", OracleDbType.NVarchar2);
                pCfqxjk_code.Value = jc_ypParam.Cfqxjk_code;
                sqlparams.Add(pCfqxjk_code);
            }

            if (null != jc_ypParam.Cfqxzz_code && "" != jc_ypParam.Cfqxzz_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.CFQXZZ_CODE=:cfqxzz_code ");
                OracleParameter pCfqxzz_code = new OracleParameter(":cfqxzz_code", OracleDbType.NVarchar2);
                pCfqxzz_code.Value = jc_ypParam.Cfqxzz_code;
                sqlparams.Add(pCfqxzz_code);
            }

            if (null != jc_ypParam.Cfqxzf_code && "" != jc_ypParam.Cfqxzf_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.CFQXZF_CODE=:cfqxzf_code ");
                OracleParameter pCfqxzf_code = new OracleParameter(":cfqxzf_code", OracleDbType.NVarchar2);
                pCfqxzf_code.Value = jc_ypParam.Cfqxzf_code;
                sqlparams.Add(pCfqxzf_code);
            }

            if (null != jc_ypParam.Cfqxts_code && "" != jc_ypParam.Cfqxts_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.CFQXTS_CODE=:cfqxts_code ");
                OracleParameter pCfqxts_code = new OracleParameter(":cfqxts_code", OracleDbType.NVarchar2);
                pCfqxts_code.Value = jc_ypParam.Cfqxts_code;
                sqlparams.Add(pCfqxts_code);
            }

            if (null != jc_ypParam.Ps_code && "" != jc_ypParam.Ps_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.PS_CODE=:ps_code ");
                OracleParameter pPs_code = new OracleParameter(":ps_code", OracleDbType.NVarchar2);
                pPs_code.Value = jc_ypParam.Ps_code;
                sqlparams.Add(pPs_code);
            }

            if (null != jc_ypParam.Yplx_code && "" != jc_ypParam.Yplx_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.YPLX_CODE=:yplx_code ");
                OracleParameter pYplx_code = new OracleParameter(":yplx_code", OracleDbType.NVarchar2);
                pYplx_code.Value = jc_ypParam.Yplx_code;
                sqlparams.Add(pYplx_code);
            }

            if (null != jc_ypParam.Ypmssyz && "" != jc_ypParam.Ypmssyz)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.YPMSSYZ=:ypmssyz ");
                OracleParameter pYpmssyz = new OracleParameter(":ypmssyz", OracleDbType.NVarchar2);
                pYpmssyz.Value = jc_ypParam.Ypmssyz;
                sqlparams.Add(pYpmssyz);
            }

            if (null != jc_ypParam.Ypmsjjz && "" != jc_ypParam.Ypmsjjz)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.YPMSJJZ=:ypmsjjz ");
                OracleParameter pYpmsjjz = new OracleParameter(":ypmsjjz", OracleDbType.NVarchar2);
                pYpmsjjz.Value = jc_ypParam.Ypmsjjz;
                sqlparams.Add(pYpmsjjz);
            }

            if (null != jc_ypParam.Ypmsyfhbrqjy_code && "" != jc_ypParam.Ypmsyfhbrqjy_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.YPMSYFHBRQJY_CODE=:ypmsyfhbrqjy_code ");
                OracleParameter pYpmsyfhbrqjy_code = new OracleParameter(":ypmsyfhbrqjy_code", OracleDbType.NVarchar2);
                pYpmsyfhbrqjy_code.Value = jc_ypParam.Ypmsyfhbrqjy_code;
                sqlparams.Add(pYpmsyfhbrqjy_code);
            }

            if (null != jc_ypParam.Ypmsblfy && "" != jc_ypParam.Ypmsblfy)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.YPMSBLFY=:ypmsblfy ");
                OracleParameter pYpmsblfy = new OracleParameter(":ypmsblfy", OracleDbType.NVarchar2);
                pYpmsblfy.Value = jc_ypParam.Ypmsblfy;
                sqlparams.Add(pYpmsblfy);
            }

            if (null != jc_ypParam.Ypfl_code && "" != jc_ypParam.Ypfl_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.YPFL_CODE=:ypfl_code ");
                OracleParameter pYpfl_code = new OracleParameter(":ypfl_code", OracleDbType.NVarchar2);
                pYpfl_code.Value = jc_ypParam.Ypfl_code;
                sqlparams.Add(pYpfl_code);
            }

            if (null != jc_ypParam.Yjjb_code && "" != jc_ypParam.Yjjb_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.YJJB_CODE=:yjjb_code ");
                OracleParameter pYjjb_code = new OracleParameter(":yjjb_code", OracleDbType.NVarchar2);
                pYjjb_code.Value = jc_ypParam.Yjjb_code;
                sqlparams.Add(pYjjb_code);
            }

            if (null != jc_ypParam.Txm && "" != jc_ypParam.Txm)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.TXM=:txm ");
                OracleParameter pTxm = new OracleParameter(":txm", OracleDbType.NVarchar2);
                pTxm.Value = jc_ypParam.Txm;
                sqlparams.Add(pTxm);
            }

            if (null != jc_ypParam.Ewm && "" != jc_ypParam.Ewm)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.EWM=:ewm ");
                OracleParameter pEwm = new OracleParameter(":ewm", OracleDbType.NVarchar2);
                pEwm.Value = jc_ypParam.Ewm;
                sqlparams.Add(pEwm);
            }

            if (null != jc_ypParam.Pym && "" != jc_ypParam.Pym)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.PYM=:pym ");
                OracleParameter pPym = new OracleParameter(":pym", OracleDbType.NVarchar2);
                pPym.Value = jc_ypParam.Pym;
                sqlparams.Add(pPym);
            }

            if (null != jc_ypParam.Hsxs)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" HSXS=:hsxs ");
                OracleParameter pHsxs = new OracleParameter(":hsxs", OracleDbType.Decimal);
                pHsxs.Value = jc_ypParam.Hsxs;
                sqlparams.Add(pHsxs);

            }

            if (null != jc_ypParam.Sfcly_code && "" != jc_ypParam.Sfcly_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.SFCLY_CODE=:sfcly_code ");
                OracleParameter pSfcly_code = new OracleParameter(":sfcly_code", OracleDbType.NVarchar2);
                pSfcly_code.Value = jc_ypParam.Sfcly_code;
                sqlparams.Add(pSfcly_code);
            }

            if (null != jc_ypParam.Bzpfj)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" BZPFJ=:bzpfj ");
                OracleParameter pBzpfj = new OracleParameter(":bzpfj", OracleDbType.Decimal);
                pBzpfj.Value = jc_ypParam.Bzpfj;
                sqlparams.Add(pBzpfj);

            }

            if (null != jc_ypParam.Bzlsj)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" BZLSJ=:bzlsj ");
                OracleParameter pBzlsj = new OracleParameter(":bzlsj", OracleDbType.Decimal);
                pBzlsj.Value = jc_ypParam.Bzlsj;
                sqlparams.Add(pBzlsj);

            }

            if (null != jc_ypParam.Bzmzj)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" BZMZJ=:bzmzj ");
                OracleParameter pBzmzj = new OracleParameter(":bzmzj", OracleDbType.Decimal);
                pBzmzj.Value = jc_ypParam.Bzmzj;
                sqlparams.Add(pBzmzj);

            }

            if (null != jc_ypParam.Bzzyj)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" BZZYJ=:bzzyj ");
                OracleParameter pBzzyj = new OracleParameter(":bzzyj", OracleDbType.Decimal);
                pBzzyj.Value = jc_ypParam.Bzzyj;
                sqlparams.Add(pBzzyj);

            }

            if (null != jc_ypParam.Hsbl)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" HSBL=:hsbl ");
                OracleParameter pHsbl = new OracleParameter(":hsbl", OracleDbType.Decimal);
                pHsbl.Value = jc_ypParam.Hsbl;
                sqlparams.Add(pHsbl);

            }

            if (null != jc_ypParam.Sfclm_code && "" != jc_ypParam.Sfclm_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.SFCLM_CODE=:sfclm_code ");
                OracleParameter pSfclm_code = new OracleParameter(":sfclm_code", OracleDbType.NVarchar2);
                pSfclm_code.Value = jc_ypParam.Sfclm_code;
                sqlparams.Add(pSfclm_code);
            }

            if (null != jc_ypParam.Yxzt_code && "" != jc_ypParam.Yxzt_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.YXZT_CODE=:yxzt_code ");
                OracleParameter pYxzt_code = new OracleParameter(":yxzt_code", OracleDbType.NVarchar2);
                pYxzt_code.Value = jc_ypParam.Yxzt_code;
                sqlparams.Add(pYxzt_code);
            }

            if (null != jc_ypParam.Dcsxyl)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" DCSXYL=:dcsxyl ");
                OracleParameter pDcsxyl = new OracleParameter(":dcsxyl", OracleDbType.Decimal);
                pDcsxyl.Value = jc_ypParam.Dcsxyl;
                sqlparams.Add(pDcsxyl);

            }

            if (null != jc_ypParam.Dcxxyl)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" DCXXYL=:dcxxyl ");
                OracleParameter pDcxxyl = new OracleParameter(":dcxxyl", OracleDbType.Decimal);
                pDcxxyl.Value = jc_ypParam.Dcxxyl;
                sqlparams.Add(pDcxxyl);

            }

            if (null != jc_ypParam.Lxylts)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" LXYLTS=:lxylts ");
                OracleParameter pLxylts = new OracleParameter(":lxylts", OracleDbType.Decimal);
                pLxylts.Value = jc_ypParam.Lxylts;
                sqlparams.Add(pLxylts);

            }

            if (null != jc_ypParam.Lxylcs)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" LXYLCS=:lxylcs ");
                OracleParameter pLxylcs = new OracleParameter(":lxylcs", OracleDbType.Decimal);
                pLxylcs.Value = jc_ypParam.Lxylcs;
                sqlparams.Add(pLxylcs);

            }

            if (null != jc_ypParam.Scqy && "" != jc_ypParam.Scqy)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.SCQY=:scqy ");
                OracleParameter pScqy = new OracleParameter(":scqy", OracleDbType.NVarchar2);
                pScqy.Value = jc_ypParam.Scqy;
                sqlparams.Add(pScqy);
            }

            if (DateTime.MinValue != jc_ypParam.Pzrq && null != jc_ypParam.Pzrq)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.PZRQ=:pzrq ");
                OracleParameter pPzrq = new OracleParameter(":pzrq", OracleDbType.Date);
                pPzrq.Value = jc_ypParam.Pzrq;
                sqlparams.Add(pPzrq);
            }

            if (null != jc_ypParam.Sfkss_code && "" != jc_ypParam.Sfkss_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.SFKSS_CODE=:sfkss_code ");
                OracleParameter pSfkss_code = new OracleParameter(":sfkss_code", OracleDbType.NVarchar2);
                pSfkss_code.Value = jc_ypParam.Sfkss_code;
                sqlparams.Add(pSfkss_code);
            }

            if (null != jc_ypParam.Zfbz && "" != jc_ypParam.Zfbz)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.ZFBZ=:zfbz ");
                OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                pZfbz.Value = jc_ypParam.Zfbz;
                sqlparams.Add(pZfbz);
            }

            if (null != jc_ypParam.Dcyldwbl)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" DCYLDWBL=:dcyldwbl ");
                OracleParameter pDcyldwbl = new OracleParameter(":dcyldwbl", OracleDbType.Decimal);
                pDcyldwbl.Value = jc_ypParam.Dcyldwbl;
                sqlparams.Add(pDcyldwbl);

            }

            if (jc_ypParamLike != null)
            {

                if (null != jc_ypParamLike.Ypbm && "" != jc_ypParamLike.Ypbm)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YPBM LIKE :ypbm||'%' ");
                    OracleParameter pYpbm = new OracleParameter(":ypbm", OracleDbType.NVarchar2);
                    pYpbm.Direction = ParameterDirection.Input;
                    pYpbm.Value = jc_ypParamLike.Ypbm;
                    sqlparams.Add(pYpbm);
                }

                if (null != jc_ypParamLike.Ypmc && "" != jc_ypParamLike.Ypmc)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YPMC LIKE '%'||:ypmc||'%' OR A.YPTYMC LIKE '%'||:yptymc||'%'");
                    OracleParameter pYpmc = new OracleParameter(":ypmc", OracleDbType.NVarchar2);
                    pYpmc.Direction = ParameterDirection.Input;
                    pYpmc.Value = jc_ypParamLike.Ypmc;
                    sqlparams.Add(pYpmc);
                    OracleParameter pYptymc = new OracleParameter(":yptymc", OracleDbType.NVarchar2);
                    pYptymc.Direction = ParameterDirection.Input;
                    pYptymc.Value = jc_ypParamLike.Yptymc;
                    sqlparams.Add(pYptymc);
                }

                //if (null != jc_ypParamLike.Yptymc && "" != jc_ypParamLike.Yptymc)
                //{
                //    this.isAnd(sql);
                //    this.isWhere(sql);
                //    sql.Append(" A.YPTYMC LIKE '%'||:yptymc||'%' ");
                //    OracleParameter pYptymc = new OracleParameter(":yptymc", OracleDbType.NVarchar2);
                //    pYptymc.Direction = ParameterDirection.Input;
                //    pYptymc.Value = jc_ypParamLike.Yptymc;
                //    sqlparams.Add(pYptymc);
                //}

                if (null != jc_ypParamLike.Ypcf && "" != jc_ypParamLike.Ypcf)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YPCF LIKE '%'||:ypcf||'%' ");
                    OracleParameter pYpcf = new OracleParameter(":ypcf", OracleDbType.NVarchar2);
                    pYpcf.Direction = ParameterDirection.Input;
                    pYpcf.Value = jc_ypParamLike.Ypcf;
                    sqlparams.Add(pYpcf);
                }

                if (null != jc_ypParamLike.Yppzwh && "" != jc_ypParamLike.Yppzwh)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YPPZWH LIKE '%'||:yppzwh||'%' ");
                    OracleParameter pYppzwh = new OracleParameter(":yppzwh", OracleDbType.NVarchar2);
                    pYppzwh.Direction = ParameterDirection.Input;
                    pYppzwh.Value = jc_ypParamLike.Yppzwh;
                    sqlparams.Add(pYppzwh);
                }

                if (null != jc_ypParamLike.Ypzczh && "" != jc_ypParamLike.Ypzczh)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YPZCZH LIKE '%'||:ypzczh||'%' ");
                    OracleParameter pYpzczh = new OracleParameter(":ypzczh", OracleDbType.NVarchar2);
                    pYpzczh.Direction = ParameterDirection.Input;
                    pYpzczh.Value = jc_ypParamLike.Ypzczh;
                    sqlparams.Add(pYpzczh);
                }

                if (null != jc_ypParamLike.Gyzz && "" != jc_ypParamLike.Gyzz)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.GYZZ LIKE '%'||:gyzz||'%' ");
                    OracleParameter pGyzz = new OracleParameter(":gyzz", OracleDbType.NVarchar2);
                    pGyzz.Direction = ParameterDirection.Input;
                    pGyzz.Value = jc_ypParamLike.Gyzz;
                    sqlparams.Add(pGyzz);
                }

                if (null != jc_ypParamLike.Ypjx_code && "" != jc_ypParamLike.Ypjx_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YPJX_CODE LIKE '%'||:ypjx_code||'%' ");
                    OracleParameter pYpjx_code = new OracleParameter(":ypjx_code", OracleDbType.NVarchar2);
                    pYpjx_code.Direction = ParameterDirection.Input;
                    pYpjx_code.Value = jc_ypParamLike.Ypjx_code;
                    sqlparams.Add(pYpjx_code);
                }

                if (null != jc_ypParamLike.Ypgg && "" != jc_ypParamLike.Ypgg)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YPGG LIKE '%'||:ypgg||'%' ");
                    OracleParameter pYpgg = new OracleParameter(":ypgg", OracleDbType.NVarchar2);
                    pYpgg.Direction = ParameterDirection.Input;
                    pYpgg.Value = jc_ypParamLike.Ypgg;
                    sqlparams.Add(pYpgg);
                }

                if (null != jc_ypParamLike.Ypdcyldw_code && "" != jc_ypParamLike.Ypdcyldw_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YPDCYLDW_CODE LIKE '%'||:ypdcyldw_code||'%' ");
                    OracleParameter pYpdcyldw_code = new OracleParameter(":ypdcyldw_code", OracleDbType.NVarchar2);
                    pYpdcyldw_code.Direction = ParameterDirection.Input;
                    pYpdcyldw_code.Value = jc_ypParamLike.Ypdcyldw_code;
                    sqlparams.Add(pYpdcyldw_code);
                }

                if (null != jc_ypParamLike.Ypyytj_code && "" != jc_ypParamLike.Ypyytj_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YPYYTJ_CODE LIKE '%'||:ypyytj_code||'%' ");
                    OracleParameter pYpyytj_code = new OracleParameter(":ypyytj_code", OracleDbType.NVarchar2);
                    pYpyytj_code.Direction = ParameterDirection.Input;
                    pYpyytj_code.Value = jc_ypParamLike.Ypyytj_code;
                    sqlparams.Add(pYpyytj_code);
                }

                if (null != jc_ypParamLike.Ddw_code && "" != jc_ypParamLike.Ddw_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.DDW_CODE LIKE '%'||:ddw_code||'%' ");
                    OracleParameter pDdw_code = new OracleParameter(":ddw_code", OracleDbType.NVarchar2);
                    pDdw_code.Direction = ParameterDirection.Input;
                    pDdw_code.Value = jc_ypParamLike.Ddw_code;
                    sqlparams.Add(pDdw_code);
                }

                if (null != jc_ypParamLike.Xdw_code && "" != jc_ypParamLike.Xdw_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.XDW_CODE LIKE '%'||:xdw_code||'%' ");
                    OracleParameter pXdw_code = new OracleParameter(":xdw_code", OracleDbType.NVarchar2);
                    pXdw_code.Direction = ParameterDirection.Input;
                    pXdw_code.Value = jc_ypParamLike.Xdw_code;
                    sqlparams.Add(pXdw_code);
                }

                if (null != jc_ypParamLike.Cfybz_code && "" != jc_ypParamLike.Cfybz_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.CFYBZ_CODE LIKE '%'||:cfybz_code||'%' ");
                    OracleParameter pCfybz_code = new OracleParameter(":cfybz_code", OracleDbType.NVarchar2);
                    pCfybz_code.Direction = ParameterDirection.Input;
                    pCfybz_code.Value = jc_ypParamLike.Cfybz_code;
                    sqlparams.Add(pCfybz_code);
                }

                if (null != jc_ypParamLike.Cfqxjy_code && "" != jc_ypParamLike.Cfqxjy_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.CFQXJY_CODE LIKE '%'||:cfqxjy_code||'%' ");
                    OracleParameter pCfqxjy_code = new OracleParameter(":cfqxjy_code", OracleDbType.NVarchar2);
                    pCfqxjy_code.Direction = ParameterDirection.Input;
                    pCfqxjy_code.Value = jc_ypParamLike.Cfqxjy_code;
                    sqlparams.Add(pCfqxjy_code);
                }

                if (null != jc_ypParamLike.Cfqxyb_code && "" != jc_ypParamLike.Cfqxyb_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.CFQXYB_CODE LIKE '%'||:cfqxyb_code||'%' ");
                    OracleParameter pCfqxyb_code = new OracleParameter(":cfqxyb_code", OracleDbType.NVarchar2);
                    pCfqxyb_code.Direction = ParameterDirection.Input;
                    pCfqxyb_code.Value = jc_ypParamLike.Cfqxyb_code;
                    sqlparams.Add(pCfqxyb_code);
                }

                if (null != jc_ypParamLike.Cfqxdm_code && "" != jc_ypParamLike.Cfqxdm_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.CFQXDM_CODE LIKE '%'||:cfqxdm_code||'%' ");
                    OracleParameter pCfqxdm_code = new OracleParameter(":cfqxdm_code", OracleDbType.NVarchar2);
                    pCfqxdm_code.Direction = ParameterDirection.Input;
                    pCfqxdm_code.Value = jc_ypParamLike.Cfqxdm_code;
                    sqlparams.Add(pCfqxdm_code);
                }

                if (null != jc_ypParamLike.Cfqxjs_code && "" != jc_ypParamLike.Cfqxjs_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.CFQXJS_CODE LIKE '%'||:cfqxjs_code||'%' ");
                    OracleParameter pCfqxjs_code = new OracleParameter(":cfqxjs_code", OracleDbType.NVarchar2);
                    pCfqxjs_code.Direction = ParameterDirection.Input;
                    pCfqxjs_code.Value = jc_ypParamLike.Cfqxjs_code;
                    sqlparams.Add(pCfqxjs_code);
                }

                if (null != jc_ypParamLike.Cfqxgz_code && "" != jc_ypParamLike.Cfqxgz_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.CFQXGZ_CODE LIKE '%'||:cfqxgz_code||'%' ");
                    OracleParameter pCfqxgz_code = new OracleParameter(":cfqxgz_code", OracleDbType.NVarchar2);
                    pCfqxgz_code.Direction = ParameterDirection.Input;
                    pCfqxgz_code.Value = jc_ypParamLike.Cfqxgz_code;
                    sqlparams.Add(pCfqxgz_code);
                }

                if (null != jc_ypParamLike.Cfqxjk_code && "" != jc_ypParamLike.Cfqxjk_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.CFQXJK_CODE LIKE '%'||:cfqxjk_code||'%' ");
                    OracleParameter pCfqxjk_code = new OracleParameter(":cfqxjk_code", OracleDbType.NVarchar2);
                    pCfqxjk_code.Direction = ParameterDirection.Input;
                    pCfqxjk_code.Value = jc_ypParamLike.Cfqxjk_code;
                    sqlparams.Add(pCfqxjk_code);
                }

                if (null != jc_ypParamLike.Cfqxzz_code && "" != jc_ypParamLike.Cfqxzz_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.CFQXZZ_CODE LIKE '%'||:cfqxzz_code||'%' ");
                    OracleParameter pCfqxzz_code = new OracleParameter(":cfqxzz_code", OracleDbType.NVarchar2);
                    pCfqxzz_code.Direction = ParameterDirection.Input;
                    pCfqxzz_code.Value = jc_ypParamLike.Cfqxzz_code;
                    sqlparams.Add(pCfqxzz_code);
                }

                if (null != jc_ypParamLike.Cfqxzf_code && "" != jc_ypParamLike.Cfqxzf_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.CFQXZF_CODE LIKE '%'||:cfqxzf_code||'%' ");
                    OracleParameter pCfqxzf_code = new OracleParameter(":cfqxzf_code", OracleDbType.NVarchar2);
                    pCfqxzf_code.Direction = ParameterDirection.Input;
                    pCfqxzf_code.Value = jc_ypParamLike.Cfqxzf_code;
                    sqlparams.Add(pCfqxzf_code);
                }

                if (null != jc_ypParamLike.Cfqxts_code && "" != jc_ypParamLike.Cfqxts_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.CFQXTS_CODE LIKE '%'||:cfqxts_code||'%' ");
                    OracleParameter pCfqxts_code = new OracleParameter(":cfqxts_code", OracleDbType.NVarchar2);
                    pCfqxts_code.Direction = ParameterDirection.Input;
                    pCfqxts_code.Value = jc_ypParamLike.Cfqxts_code;
                    sqlparams.Add(pCfqxts_code);
                }

                if (null != jc_ypParamLike.Ps_code && "" != jc_ypParamLike.Ps_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.PS_CODE LIKE '%'||:ps_code||'%' ");
                    OracleParameter pPs_code = new OracleParameter(":ps_code", OracleDbType.NVarchar2);
                    pPs_code.Direction = ParameterDirection.Input;
                    pPs_code.Value = jc_ypParamLike.Ps_code;
                    sqlparams.Add(pPs_code);
                }

                if (null != jc_ypParamLike.Yplx_code && "" != jc_ypParamLike.Yplx_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YPLX_CODE LIKE '%'||:yplx_code||'%' ");
                    OracleParameter pYplx_code = new OracleParameter(":yplx_code", OracleDbType.NVarchar2);
                    pYplx_code.Direction = ParameterDirection.Input;
                    pYplx_code.Value = jc_ypParamLike.Yplx_code;
                    sqlparams.Add(pYplx_code);
                }

                if (null != jc_ypParamLike.Ypmssyz && "" != jc_ypParamLike.Ypmssyz)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YPMSSYZ LIKE '%'||:ypmssyz||'%' ");
                    OracleParameter pYpmssyz = new OracleParameter(":ypmssyz", OracleDbType.NVarchar2);
                    pYpmssyz.Direction = ParameterDirection.Input;
                    pYpmssyz.Value = jc_ypParamLike.Ypmssyz;
                    sqlparams.Add(pYpmssyz);
                }

                if (null != jc_ypParamLike.Ypmsjjz && "" != jc_ypParamLike.Ypmsjjz)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YPMSJJZ LIKE '%'||:ypmsjjz||'%' ");
                    OracleParameter pYpmsjjz = new OracleParameter(":ypmsjjz", OracleDbType.NVarchar2);
                    pYpmsjjz.Direction = ParameterDirection.Input;
                    pYpmsjjz.Value = jc_ypParamLike.Ypmsjjz;
                    sqlparams.Add(pYpmsjjz);
                }

                if (null != jc_ypParamLike.Ypmsyfhbrqjy_code && "" != jc_ypParamLike.Ypmsyfhbrqjy_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YPMSYFHBRQJY_CODE LIKE '%'||:ypmsyfhbrqjy_code||'%' ");
                    OracleParameter pYpmsyfhbrqjy_code = new OracleParameter(":ypmsyfhbrqjy_code", OracleDbType.NVarchar2);
                    pYpmsyfhbrqjy_code.Direction = ParameterDirection.Input;
                    pYpmsyfhbrqjy_code.Value = jc_ypParamLike.Ypmsyfhbrqjy_code;
                    sqlparams.Add(pYpmsyfhbrqjy_code);
                }

                if (null != jc_ypParamLike.Ypmsblfy && "" != jc_ypParamLike.Ypmsblfy)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YPMSBLFY LIKE '%'||:ypmsblfy||'%' ");
                    OracleParameter pYpmsblfy = new OracleParameter(":ypmsblfy", OracleDbType.NVarchar2);
                    pYpmsblfy.Direction = ParameterDirection.Input;
                    pYpmsblfy.Value = jc_ypParamLike.Ypmsblfy;
                    sqlparams.Add(pYpmsblfy);
                }

                if (null != jc_ypParamLike.Ypfl_code && "" != jc_ypParamLike.Ypfl_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YPFL_CODE LIKE '%'||:ypfl_code||'%' ");
                    OracleParameter pYpfl_code = new OracleParameter(":ypfl_code", OracleDbType.NVarchar2);
                    pYpfl_code.Direction = ParameterDirection.Input;
                    pYpfl_code.Value = jc_ypParamLike.Ypfl_code;
                    sqlparams.Add(pYpfl_code);
                }

                if (null != jc_ypParamLike.Yjjb_code && "" != jc_ypParamLike.Yjjb_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YJJB_CODE LIKE '%'||:yjjb_code||'%' ");
                    OracleParameter pYjjb_code = new OracleParameter(":yjjb_code", OracleDbType.NVarchar2);
                    pYjjb_code.Direction = ParameterDirection.Input;
                    pYjjb_code.Value = jc_ypParamLike.Yjjb_code;
                    sqlparams.Add(pYjjb_code);
                }

                if (null != jc_ypParamLike.Txm && "" != jc_ypParamLike.Txm)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.TXM LIKE '%'||:txm||'%' ");
                    OracleParameter pTxm = new OracleParameter(":txm", OracleDbType.NVarchar2);
                    pTxm.Direction = ParameterDirection.Input;
                    pTxm.Value = jc_ypParamLike.Txm;
                    sqlparams.Add(pTxm);
                }

                if (null != jc_ypParamLike.Ewm && "" != jc_ypParamLike.Ewm)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.EWM LIKE '%'||:ewm||'%' ");
                    OracleParameter pEwm = new OracleParameter(":ewm", OracleDbType.NVarchar2);
                    pEwm.Direction = ParameterDirection.Input;
                    pEwm.Value = jc_ypParamLike.Ewm;
                    sqlparams.Add(pEwm);
                }

                if (null != jc_ypParamLike.Pym && "" != jc_ypParamLike.Pym)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.PYM LIKE '%'||:pym||'%' ");
                    OracleParameter pPym = new OracleParameter(":pym", OracleDbType.NVarchar2);
                    pPym.Direction = ParameterDirection.Input;
                    pPym.Value = jc_ypParamLike.Pym;
                    sqlparams.Add(pPym);
                }

                if (null != jc_ypParamLike.Sfcly_code && "" != jc_ypParamLike.Sfcly_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.SFCLY_CODE LIKE '%'||:sfcly_code||'%' ");
                    OracleParameter pSfcly_code = new OracleParameter(":sfcly_code", OracleDbType.NVarchar2);
                    pSfcly_code.Direction = ParameterDirection.Input;
                    pSfcly_code.Value = jc_ypParamLike.Sfcly_code;
                    sqlparams.Add(pSfcly_code);
                }

                if (null != jc_ypParamLike.Sfclm_code && "" != jc_ypParamLike.Sfclm_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.SFCLM_CODE LIKE '%'||:sfclm_code||'%' ");
                    OracleParameter pSfclm_code = new OracleParameter(":sfclm_code", OracleDbType.NVarchar2);
                    pSfclm_code.Direction = ParameterDirection.Input;
                    pSfclm_code.Value = jc_ypParamLike.Sfclm_code;
                    sqlparams.Add(pSfclm_code);
                }

                if (null != jc_ypParamLike.Yxzt_code && "" != jc_ypParamLike.Yxzt_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YXZT_CODE LIKE '%'||:yxzt_code||'%' ");
                    OracleParameter pYxzt_code = new OracleParameter(":yxzt_code", OracleDbType.NVarchar2);
                    pYxzt_code.Direction = ParameterDirection.Input;
                    pYxzt_code.Value = jc_ypParamLike.Yxzt_code;
                    sqlparams.Add(pYxzt_code);
                }

                if (null != jc_ypParamLike.Scqy && "" != jc_ypParamLike.Scqy)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.SCQY LIKE '%'||:scqy||'%' ");
                    OracleParameter pScqy = new OracleParameter(":scqy", OracleDbType.NVarchar2);
                    pScqy.Direction = ParameterDirection.Input;
                    pScqy.Value = jc_ypParamLike.Scqy;
                    sqlparams.Add(pScqy);
                }

                if (null != jc_ypParamLike.Sfkss_code && "" != jc_ypParamLike.Sfkss_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.SFKSS_CODE LIKE '%'||:sfkss_code||'%' ");
                    OracleParameter pSfkss_code = new OracleParameter(":sfkss_code", OracleDbType.NVarchar2);
                    pSfkss_code.Direction = ParameterDirection.Input;
                    pSfkss_code.Value = jc_ypParamLike.Sfkss_code;
                    sqlparams.Add(pSfkss_code);
                }

                if (null != jc_ypParamLike.Zfbz && "" != jc_ypParamLike.Zfbz)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.ZFBZ LIKE '%'||:zfbz||'%' ");
                    OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                    pZfbz.Direction = ParameterDirection.Input;
                    pZfbz.Value = jc_ypParamLike.Zfbz;
                    sqlparams.Add(pZfbz);
                }

            }

            this.b_isWhere = false;
            //排序
            this.addSort(sql, sortList);
            //*******分页start1*********如果分页对象为空，则全部数据查出，如果不为空
            List<object> returnList = new List<object>();//返回的List,索引0为List<Jc_yp>对象,索引1为Model.Common.PageInfo分页信息对象
            if (null != page)
            {
                string sqlParam = sql.ToString();
                sql = new StringBuilder(@" SELECT * FROM 
                (
                SELECT A.*, ROWNUM RN 
                FROM (" + sqlParam + @") A 
                WHERE ROWNUM <= :maxIndex
                )
                WHERE RN >= :minIndex ");
                sqlparams.Add(new OracleParameter("maxIndex", page.MaxIndex));
                sqlparams.Add(new OracleParameter("minIndex", page.MinIndex));
            }
            //*******分页end1*********
            DataSet ds = OracleHelper.getDataSet(sql.ToString(), sqlparams.ToArray());
            DataRowCollection rows = ds.Tables[0].Rows;
            //把每一行数据转换为一个对象放入List<Jc_yp>中
            for (int i = 0; i < rows.Count; i++)
            {
                DataRow row = rows[i];
                jc_ypParamList.Add(this.dataSetContactObjectsToModel(row));
                //jc_ypParamList.Add(this.dataSetToModel(row));
            }

            //*******分页start2*********如果没有传入分页对象，则新建一个分页对象当做返回值
            if (null == page)
            {
                page = new Model.Common.PageInfo();
                page.AllCount = rows.Count;
            }
            returnList.Add(jc_ypParamList);//把List<Jc_yp>放入List<object>中第一个
            returnList.Add(page);//把page对象放入List<object>中第二个
            //*******分页end2*********
            return returnList;
        }

        //*******************在此以后添加新的方法end



        public int getCountForFast(Jc_yp jc_ypParam, Jc_yp jc_ypParamLike)
        {
            //如果没有传查询条件参数，就new一个空的Jc_yp对象，标示查询所有数据
            if (null == jc_ypParam)
            {
                jc_ypParam = new Jc_yp();
            }
            List<OracleParameter> sqlparams = new List<OracleParameter>();//保存参数的集合
            StringBuilder sql = new StringBuilder("SELECT COUNT(ID) FROM JC_YP A");
            if (null != jc_ypParam.Ypbm && "" != jc_ypParam.Ypbm)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.YPBM=:ypbm ");
                OracleParameter pYpbm = new OracleParameter(":ypbm", OracleDbType.NVarchar2);
                pYpbm.Value = jc_ypParam.Ypbm;
                sqlparams.Add(pYpbm);
            }

            if (null != jc_ypParam.Ypmc && "" != jc_ypParam.Ypmc)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.YPMC=:ypmc ");
                OracleParameter pYpmc = new OracleParameter(":ypmc", OracleDbType.NVarchar2);
                pYpmc.Value = jc_ypParam.Ypmc;
                sqlparams.Add(pYpmc);
            }

            if (null != jc_ypParam.Yptymc && "" != jc_ypParam.Yptymc)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.YPTYMC=:yptymc ");
                OracleParameter pYptymc = new OracleParameter(":yptymc", OracleDbType.NVarchar2);
                pYptymc.Value = jc_ypParam.Yptymc;
                sqlparams.Add(pYptymc);
            }

            if (null != jc_ypParam.Ypcf && "" != jc_ypParam.Ypcf)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.YPCF=:ypcf ");
                OracleParameter pYpcf = new OracleParameter(":ypcf", OracleDbType.NVarchar2);
                pYpcf.Value = jc_ypParam.Ypcf;
                sqlparams.Add(pYpcf);
            }

            if (null != jc_ypParam.Yppzwh && "" != jc_ypParam.Yppzwh)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.YPPZWH=:yppzwh ");
                OracleParameter pYppzwh = new OracleParameter(":yppzwh", OracleDbType.NVarchar2);
                pYppzwh.Value = jc_ypParam.Yppzwh;
                sqlparams.Add(pYppzwh);
            }

            if (null != jc_ypParam.Ypzczh && "" != jc_ypParam.Ypzczh)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.YPZCZH=:ypzczh ");
                OracleParameter pYpzczh = new OracleParameter(":ypzczh", OracleDbType.NVarchar2);
                pYpzczh.Value = jc_ypParam.Ypzczh;
                sqlparams.Add(pYpzczh);
            }

            if (null != jc_ypParam.Gyzz && "" != jc_ypParam.Gyzz)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.GYZZ=:gyzz ");
                OracleParameter pGyzz = new OracleParameter(":gyzz", OracleDbType.NVarchar2);
                pGyzz.Value = jc_ypParam.Gyzz;
                sqlparams.Add(pGyzz);
            }

            if (null != jc_ypParam.Ypjx_code && "" != jc_ypParam.Ypjx_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.YPJX_CODE=:ypjx_code ");
                OracleParameter pYpjx_code = new OracleParameter(":ypjx_code", OracleDbType.NVarchar2);
                pYpjx_code.Value = jc_ypParam.Ypjx_code;
                sqlparams.Add(pYpjx_code);
            }

            if (null != jc_ypParam.Ypgg && "" != jc_ypParam.Ypgg)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.YPGG=:ypgg ");
                OracleParameter pYpgg = new OracleParameter(":ypgg", OracleDbType.NVarchar2);
                pYpgg.Value = jc_ypParam.Ypgg;
                sqlparams.Add(pYpgg);
            }

            if (null != jc_ypParam.Ypdcyl)
            {
                this.isComma(sql);
                sql.Append(" YPDCYL=:ypdcyl ");
                OracleParameter pYpdcyl = new OracleParameter(":ypdcyl", OracleDbType.Decimal);
                pYpdcyl.Value = jc_ypParam.Ypdcyl;
                sqlparams.Add(pYpdcyl);

            }

            if (null != jc_ypParam.Ypdcyldw_code && "" != jc_ypParam.Ypdcyldw_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.YPDCYLDW_CODE=:ypdcyldw_code ");
                OracleParameter pYpdcyldw_code = new OracleParameter(":ypdcyldw_code", OracleDbType.NVarchar2);
                pYpdcyldw_code.Value = jc_ypParam.Ypdcyldw_code;
                sqlparams.Add(pYpdcyldw_code);
            }

            if (null != jc_ypParam.Ypyytj_code && "" != jc_ypParam.Ypyytj_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.YPYYTJ_CODE=:ypyytj_code ");
                OracleParameter pYpyytj_code = new OracleParameter(":ypyytj_code", OracleDbType.NVarchar2);
                pYpyytj_code.Value = jc_ypParam.Ypyytj_code;
                sqlparams.Add(pYpyytj_code);
            }

            if (null != jc_ypParam.Ddw_code && "" != jc_ypParam.Ddw_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.DDW_CODE=:ddw_code ");
                OracleParameter pDdw_code = new OracleParameter(":ddw_code", OracleDbType.NVarchar2);
                pDdw_code.Value = jc_ypParam.Ddw_code;
                sqlparams.Add(pDdw_code);
            }

            if (null != jc_ypParam.Xdw_code && "" != jc_ypParam.Xdw_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.XDW_CODE=:xdw_code ");
                OracleParameter pXdw_code = new OracleParameter(":xdw_code", OracleDbType.NVarchar2);
                pXdw_code.Value = jc_ypParam.Xdw_code;
                sqlparams.Add(pXdw_code);
            }

            if (null != jc_ypParam.Cfybz_code && "" != jc_ypParam.Cfybz_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.CFYBZ_CODE=:cfybz_code ");
                OracleParameter pCfybz_code = new OracleParameter(":cfybz_code", OracleDbType.NVarchar2);
                pCfybz_code.Value = jc_ypParam.Cfybz_code;
                sqlparams.Add(pCfybz_code);
            }

            if (null != jc_ypParam.Cfqxjy_code && "" != jc_ypParam.Cfqxjy_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.CFQXJY_CODE=:cfqxjy_code ");
                OracleParameter pCfqxjy_code = new OracleParameter(":cfqxjy_code", OracleDbType.NVarchar2);
                pCfqxjy_code.Value = jc_ypParam.Cfqxjy_code;
                sqlparams.Add(pCfqxjy_code);
            }

            if (null != jc_ypParam.Cfqxyb_code && "" != jc_ypParam.Cfqxyb_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.CFQXYB_CODE=:cfqxyb_code ");
                OracleParameter pCfqxyb_code = new OracleParameter(":cfqxyb_code", OracleDbType.NVarchar2);
                pCfqxyb_code.Value = jc_ypParam.Cfqxyb_code;
                sqlparams.Add(pCfqxyb_code);
            }

            if (null != jc_ypParam.Cfqxdm_code && "" != jc_ypParam.Cfqxdm_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.CFQXDM_CODE=:cfqxdm_code ");
                OracleParameter pCfqxdm_code = new OracleParameter(":cfqxdm_code", OracleDbType.NVarchar2);
                pCfqxdm_code.Value = jc_ypParam.Cfqxdm_code;
                sqlparams.Add(pCfqxdm_code);
            }

            if (null != jc_ypParam.Cfqxjs_code && "" != jc_ypParam.Cfqxjs_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.CFQXJS_CODE=:cfqxjs_code ");
                OracleParameter pCfqxjs_code = new OracleParameter(":cfqxjs_code", OracleDbType.NVarchar2);
                pCfqxjs_code.Value = jc_ypParam.Cfqxjs_code;
                sqlparams.Add(pCfqxjs_code);
            }

            if (null != jc_ypParam.Cfqxgz_code && "" != jc_ypParam.Cfqxgz_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.CFQXGZ_CODE=:cfqxgz_code ");
                OracleParameter pCfqxgz_code = new OracleParameter(":cfqxgz_code", OracleDbType.NVarchar2);
                pCfqxgz_code.Value = jc_ypParam.Cfqxgz_code;
                sqlparams.Add(pCfqxgz_code);
            }

            if (null != jc_ypParam.Cfqxjk_code && "" != jc_ypParam.Cfqxjk_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.CFQXJK_CODE=:cfqxjk_code ");
                OracleParameter pCfqxjk_code = new OracleParameter(":cfqxjk_code", OracleDbType.NVarchar2);
                pCfqxjk_code.Value = jc_ypParam.Cfqxjk_code;
                sqlparams.Add(pCfqxjk_code);
            }

            if (null != jc_ypParam.Cfqxzz_code && "" != jc_ypParam.Cfqxzz_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.CFQXZZ_CODE=:cfqxzz_code ");
                OracleParameter pCfqxzz_code = new OracleParameter(":cfqxzz_code", OracleDbType.NVarchar2);
                pCfqxzz_code.Value = jc_ypParam.Cfqxzz_code;
                sqlparams.Add(pCfqxzz_code);
            }

            if (null != jc_ypParam.Cfqxzf_code && "" != jc_ypParam.Cfqxzf_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.CFQXZF_CODE=:cfqxzf_code ");
                OracleParameter pCfqxzf_code = new OracleParameter(":cfqxzf_code", OracleDbType.NVarchar2);
                pCfqxzf_code.Value = jc_ypParam.Cfqxzf_code;
                sqlparams.Add(pCfqxzf_code);
            }

            if (null != jc_ypParam.Cfqxts_code && "" != jc_ypParam.Cfqxts_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.CFQXTS_CODE=:cfqxts_code ");
                OracleParameter pCfqxts_code = new OracleParameter(":cfqxts_code", OracleDbType.NVarchar2);
                pCfqxts_code.Value = jc_ypParam.Cfqxts_code;
                sqlparams.Add(pCfqxts_code);
            }

            if (null != jc_ypParam.Ps_code && "" != jc_ypParam.Ps_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.PS_CODE=:ps_code ");
                OracleParameter pPs_code = new OracleParameter(":ps_code", OracleDbType.NVarchar2);
                pPs_code.Value = jc_ypParam.Ps_code;
                sqlparams.Add(pPs_code);
            }

            if (null != jc_ypParam.Yplx_code && "" != jc_ypParam.Yplx_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.YPLX_CODE=:yplx_code ");
                OracleParameter pYplx_code = new OracleParameter(":yplx_code", OracleDbType.NVarchar2);
                pYplx_code.Value = jc_ypParam.Yplx_code;
                sqlparams.Add(pYplx_code);
            }

            if (null != jc_ypParam.Ypmssyz && "" != jc_ypParam.Ypmssyz)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.YPMSSYZ=:ypmssyz ");
                OracleParameter pYpmssyz = new OracleParameter(":ypmssyz", OracleDbType.NVarchar2);
                pYpmssyz.Value = jc_ypParam.Ypmssyz;
                sqlparams.Add(pYpmssyz);
            }

            if (null != jc_ypParam.Ypmsjjz && "" != jc_ypParam.Ypmsjjz)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.YPMSJJZ=:ypmsjjz ");
                OracleParameter pYpmsjjz = new OracleParameter(":ypmsjjz", OracleDbType.NVarchar2);
                pYpmsjjz.Value = jc_ypParam.Ypmsjjz;
                sqlparams.Add(pYpmsjjz);
            }

            if (null != jc_ypParam.Ypmsyfhbrqjy_code && "" != jc_ypParam.Ypmsyfhbrqjy_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.YPMSYFHBRQJY_CODE=:ypmsyfhbrqjy_code ");
                OracleParameter pYpmsyfhbrqjy_code = new OracleParameter(":ypmsyfhbrqjy_code", OracleDbType.NVarchar2);
                pYpmsyfhbrqjy_code.Value = jc_ypParam.Ypmsyfhbrqjy_code;
                sqlparams.Add(pYpmsyfhbrqjy_code);
            }

            if (null != jc_ypParam.Ypmsblfy && "" != jc_ypParam.Ypmsblfy)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.YPMSBLFY=:ypmsblfy ");
                OracleParameter pYpmsblfy = new OracleParameter(":ypmsblfy", OracleDbType.NVarchar2);
                pYpmsblfy.Value = jc_ypParam.Ypmsblfy;
                sqlparams.Add(pYpmsblfy);
            }

            if (null != jc_ypParam.Ypfl_code && "" != jc_ypParam.Ypfl_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.YPFL_CODE=:ypfl_code ");
                OracleParameter pYpfl_code = new OracleParameter(":ypfl_code", OracleDbType.NVarchar2);
                pYpfl_code.Value = jc_ypParam.Ypfl_code;
                sqlparams.Add(pYpfl_code);
            }

            if (null != jc_ypParam.Yjjb_code && "" != jc_ypParam.Yjjb_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.YJJB_CODE=:yjjb_code ");
                OracleParameter pYjjb_code = new OracleParameter(":yjjb_code", OracleDbType.NVarchar2);
                pYjjb_code.Value = jc_ypParam.Yjjb_code;
                sqlparams.Add(pYjjb_code);
            }

            if (null != jc_ypParam.Txm && "" != jc_ypParam.Txm)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.TXM=:txm ");
                OracleParameter pTxm = new OracleParameter(":txm", OracleDbType.NVarchar2);
                pTxm.Value = jc_ypParam.Txm;
                sqlparams.Add(pTxm);
            }

            if (null != jc_ypParam.Ewm && "" != jc_ypParam.Ewm)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.EWM=:ewm ");
                OracleParameter pEwm = new OracleParameter(":ewm", OracleDbType.NVarchar2);
                pEwm.Value = jc_ypParam.Ewm;
                sqlparams.Add(pEwm);
            }

            if (null != jc_ypParam.Pym && "" != jc_ypParam.Pym)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.PYM=:pym ");
                OracleParameter pPym = new OracleParameter(":pym", OracleDbType.NVarchar2);
                pPym.Value = jc_ypParam.Pym;
                sqlparams.Add(pPym);
            }

            if (null != jc_ypParam.Hsxs)
            {
                this.isComma(sql);
                sql.Append(" HSXS=:hsxs ");
                OracleParameter pHsxs = new OracleParameter(":hsxs", OracleDbType.Decimal);
                pHsxs.Value = jc_ypParam.Hsxs;
                sqlparams.Add(pHsxs);

            }

            if (null != jc_ypParam.Sfcly_code && "" != jc_ypParam.Sfcly_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.SFCLY_CODE=:sfcly_code ");
                OracleParameter pSfcly_code = new OracleParameter(":sfcly_code", OracleDbType.NVarchar2);
                pSfcly_code.Value = jc_ypParam.Sfcly_code;
                sqlparams.Add(pSfcly_code);
            }

            if (null != jc_ypParam.Bzpfj)
            {
                this.isComma(sql);
                sql.Append(" BZPFJ=:bzpfj ");
                OracleParameter pBzpfj = new OracleParameter(":bzpfj", OracleDbType.Decimal);
                pBzpfj.Value = jc_ypParam.Bzpfj;
                sqlparams.Add(pBzpfj);

            }

            if (null != jc_ypParam.Bzlsj)
            {
                this.isComma(sql);
                sql.Append(" BZLSJ=:bzlsj ");
                OracleParameter pBzlsj = new OracleParameter(":bzlsj", OracleDbType.Decimal);
                pBzlsj.Value = jc_ypParam.Bzlsj;
                sqlparams.Add(pBzlsj);

            }

            if (null != jc_ypParam.Bzmzj)
            {
                this.isComma(sql);
                sql.Append(" BZMZJ=:bzmzj ");
                OracleParameter pBzmzj = new OracleParameter(":bzmzj", OracleDbType.Decimal);
                pBzmzj.Value = jc_ypParam.Bzmzj;
                sqlparams.Add(pBzmzj);

            }

            if (null != jc_ypParam.Bzzyj)
            {
                this.isComma(sql);
                sql.Append(" BZZYJ=:bzzyj ");
                OracleParameter pBzzyj = new OracleParameter(":bzzyj", OracleDbType.Decimal);
                pBzzyj.Value = jc_ypParam.Bzzyj;
                sqlparams.Add(pBzzyj);

            }

            if (null != jc_ypParam.Hsbl)
            {
                this.isComma(sql);
                sql.Append(" HSBL=:hsbl ");
                OracleParameter pHsbl = new OracleParameter(":hsbl", OracleDbType.Decimal);
                pHsbl.Value = jc_ypParam.Hsbl;
                sqlparams.Add(pHsbl);

            }

            if (null != jc_ypParam.Sfclm_code && "" != jc_ypParam.Sfclm_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.SFCLM_CODE=:sfclm_code ");
                OracleParameter pSfclm_code = new OracleParameter(":sfclm_code", OracleDbType.NVarchar2);
                pSfclm_code.Value = jc_ypParam.Sfclm_code;
                sqlparams.Add(pSfclm_code);
            }

            if (null != jc_ypParam.Yxzt_code && "" != jc_ypParam.Yxzt_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.YXZT_CODE=:yxzt_code ");
                OracleParameter pYxzt_code = new OracleParameter(":yxzt_code", OracleDbType.NVarchar2);
                pYxzt_code.Value = jc_ypParam.Yxzt_code;
                sqlparams.Add(pYxzt_code);
            }

            if (null != jc_ypParam.Dcsxyl)
            {
                this.isComma(sql);
                sql.Append(" DCSXYL=:dcsxyl ");
                OracleParameter pDcsxyl = new OracleParameter(":dcsxyl", OracleDbType.Decimal);
                pDcsxyl.Value = jc_ypParam.Dcsxyl;
                sqlparams.Add(pDcsxyl);

            }

            if (null != jc_ypParam.Dcxxyl)
            {
                this.isComma(sql);
                sql.Append(" DCXXYL=:dcxxyl ");
                OracleParameter pDcxxyl = new OracleParameter(":dcxxyl", OracleDbType.Decimal);
                pDcxxyl.Value = jc_ypParam.Dcxxyl;
                sqlparams.Add(pDcxxyl);

            }

            if (null != jc_ypParam.Lxylts)
            {
                this.isComma(sql);
                sql.Append(" LXYLTS=:lxylts ");
                OracleParameter pLxylts = new OracleParameter(":lxylts", OracleDbType.Decimal);
                pLxylts.Value = jc_ypParam.Lxylts;
                sqlparams.Add(pLxylts);

            }

            if (null != jc_ypParam.Lxylcs)
            {
                this.isComma(sql);
                sql.Append(" LXYLCS=:lxylcs ");
                OracleParameter pLxylcs = new OracleParameter(":lxylcs", OracleDbType.Decimal);
                pLxylcs.Value = jc_ypParam.Lxylcs;
                sqlparams.Add(pLxylcs);

            }

            if (null != jc_ypParam.Scqy && "" != jc_ypParam.Scqy)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.SCQY=:scqy ");
                OracleParameter pScqy = new OracleParameter(":scqy", OracleDbType.NVarchar2);
                pScqy.Value = jc_ypParam.Scqy;
                sqlparams.Add(pScqy);
            }

            if (DateTime.MinValue != jc_ypParam.Pzrq && null != jc_ypParam.Pzrq)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.PZRQ=:pzrq ");
                OracleParameter pPzrq = new OracleParameter(":pzrq", OracleDbType.Date);
                pPzrq.Value = jc_ypParam.Pzrq;
                sqlparams.Add(pPzrq);
            }

            if (null != jc_ypParam.Sfkss_code && "" != jc_ypParam.Sfkss_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.SFKSS_CODE=:sfkss_code ");
                OracleParameter pSfkss_code = new OracleParameter(":sfkss_code", OracleDbType.NVarchar2);
                pSfkss_code.Value = jc_ypParam.Sfkss_code;
                sqlparams.Add(pSfkss_code);
            }

            if (null != jc_ypParam.Zfbz && "" != jc_ypParam.Zfbz)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.ZFBZ=:zfbz ");
                OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                pZfbz.Value = jc_ypParam.Zfbz;
                sqlparams.Add(pZfbz);
            }

            if (null != jc_ypParam.Dcyldwbl)
            {
                this.isComma(sql);
                sql.Append(" DCYLDWBL=:dcyldwbl ");
                OracleParameter pDcyldwbl = new OracleParameter(":dcyldwbl", OracleDbType.Decimal);
                pDcyldwbl.Value = jc_ypParam.Dcyldwbl;
                sqlparams.Add(pDcyldwbl);

            }

            if (jc_ypParamLike != null)
            {

                if (null != jc_ypParamLike.Ypbm && "" != jc_ypParamLike.Ypbm)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YPBM LIKE :ypbm||'%' ");
                    OracleParameter pYpbm = new OracleParameter(":ypbm", OracleDbType.NVarchar2);
                    pYpbm.Direction = ParameterDirection.Input;
                    pYpbm.Value = jc_ypParamLike.Ypbm;
                    sqlparams.Add(pYpbm);
                }

                if (null != jc_ypParamLike.Ypmc && "" != jc_ypParamLike.Ypmc)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YPMC LIKE '%'||:ypmc||'%' OR A.YPTYMC LIKE '%'||:yptymc||'%'");
                    OracleParameter pYpmc = new OracleParameter(":ypmc", OracleDbType.NVarchar2);
                    pYpmc.Direction = ParameterDirection.Input;
                    pYpmc.Value = jc_ypParamLike.Ypmc;
                    sqlparams.Add(pYpmc);
                    OracleParameter pYptymc = new OracleParameter(":yptymc", OracleDbType.NVarchar2);
                    pYptymc.Direction = ParameterDirection.Input;
                    pYptymc.Value = jc_ypParamLike.Yptymc;
                    sqlparams.Add(pYptymc);
                }

                //if (null != jc_ypParamLike.Yptymc && "" != jc_ypParamLike.Yptymc)
                //{
                //    this.isAnd(sql);
                //    this.isWhere(sql);
                //    sql.Append(" A.YPTYMC LIKE '%'||:yptymc||'%' ");
                //    OracleParameter pYptymc = new OracleParameter(":yptymc", OracleDbType.NVarchar2);
                //    pYptymc.Direction = ParameterDirection.Input;
                //    pYptymc.Value = jc_ypParamLike.Yptymc;
                //    sqlparams.Add(pYptymc);
                //}

                if (null != jc_ypParamLike.Ypcf && "" != jc_ypParamLike.Ypcf)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YPCF LIKE '%'||:ypcf||'%' ");
                    OracleParameter pYpcf = new OracleParameter(":ypcf", OracleDbType.NVarchar2);
                    pYpcf.Direction = ParameterDirection.Input;
                    pYpcf.Value = jc_ypParamLike.Ypcf;
                    sqlparams.Add(pYpcf);
                }

                if (null != jc_ypParamLike.Yppzwh && "" != jc_ypParamLike.Yppzwh)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YPPZWH LIKE '%'||:yppzwh||'%' ");
                    OracleParameter pYppzwh = new OracleParameter(":yppzwh", OracleDbType.NVarchar2);
                    pYppzwh.Direction = ParameterDirection.Input;
                    pYppzwh.Value = jc_ypParamLike.Yppzwh;
                    sqlparams.Add(pYppzwh);
                }

                if (null != jc_ypParamLike.Ypzczh && "" != jc_ypParamLike.Ypzczh)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YPZCZH LIKE '%'||:ypzczh||'%' ");
                    OracleParameter pYpzczh = new OracleParameter(":ypzczh", OracleDbType.NVarchar2);
                    pYpzczh.Direction = ParameterDirection.Input;
                    pYpzczh.Value = jc_ypParamLike.Ypzczh;
                    sqlparams.Add(pYpzczh);
                }

                if (null != jc_ypParamLike.Gyzz && "" != jc_ypParamLike.Gyzz)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.GYZZ LIKE '%'||:gyzz||'%' ");
                    OracleParameter pGyzz = new OracleParameter(":gyzz", OracleDbType.NVarchar2);
                    pGyzz.Direction = ParameterDirection.Input;
                    pGyzz.Value = jc_ypParamLike.Gyzz;
                    sqlparams.Add(pGyzz);
                }

                if (null != jc_ypParamLike.Ypjx_code && "" != jc_ypParamLike.Ypjx_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YPJX_CODE LIKE '%'||:ypjx_code||'%' ");
                    OracleParameter pYpjx_code = new OracleParameter(":ypjx_code", OracleDbType.NVarchar2);
                    pYpjx_code.Direction = ParameterDirection.Input;
                    pYpjx_code.Value = jc_ypParamLike.Ypjx_code;
                    sqlparams.Add(pYpjx_code);
                }

                if (null != jc_ypParamLike.Ypgg && "" != jc_ypParamLike.Ypgg)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YPGG LIKE '%'||:ypgg||'%' ");
                    OracleParameter pYpgg = new OracleParameter(":ypgg", OracleDbType.NVarchar2);
                    pYpgg.Direction = ParameterDirection.Input;
                    pYpgg.Value = jc_ypParamLike.Ypgg;
                    sqlparams.Add(pYpgg);
                }

                if (null != jc_ypParamLike.Ypdcyldw_code && "" != jc_ypParamLike.Ypdcyldw_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YPDCYLDW_CODE LIKE '%'||:ypdcyldw_code||'%' ");
                    OracleParameter pYpdcyldw_code = new OracleParameter(":ypdcyldw_code", OracleDbType.NVarchar2);
                    pYpdcyldw_code.Direction = ParameterDirection.Input;
                    pYpdcyldw_code.Value = jc_ypParamLike.Ypdcyldw_code;
                    sqlparams.Add(pYpdcyldw_code);
                }

                if (null != jc_ypParamLike.Ypyytj_code && "" != jc_ypParamLike.Ypyytj_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YPYYTJ_CODE LIKE '%'||:ypyytj_code||'%' ");
                    OracleParameter pYpyytj_code = new OracleParameter(":ypyytj_code", OracleDbType.NVarchar2);
                    pYpyytj_code.Direction = ParameterDirection.Input;
                    pYpyytj_code.Value = jc_ypParamLike.Ypyytj_code;
                    sqlparams.Add(pYpyytj_code);
                }

                if (null != jc_ypParamLike.Ddw_code && "" != jc_ypParamLike.Ddw_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.DDW_CODE LIKE '%'||:ddw_code||'%' ");
                    OracleParameter pDdw_code = new OracleParameter(":ddw_code", OracleDbType.NVarchar2);
                    pDdw_code.Direction = ParameterDirection.Input;
                    pDdw_code.Value = jc_ypParamLike.Ddw_code;
                    sqlparams.Add(pDdw_code);
                }

                if (null != jc_ypParamLike.Xdw_code && "" != jc_ypParamLike.Xdw_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.XDW_CODE LIKE '%'||:xdw_code||'%' ");
                    OracleParameter pXdw_code = new OracleParameter(":xdw_code", OracleDbType.NVarchar2);
                    pXdw_code.Direction = ParameterDirection.Input;
                    pXdw_code.Value = jc_ypParamLike.Xdw_code;
                    sqlparams.Add(pXdw_code);
                }

                if (null != jc_ypParamLike.Cfybz_code && "" != jc_ypParamLike.Cfybz_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.CFYBZ_CODE LIKE '%'||:cfybz_code||'%' ");
                    OracleParameter pCfybz_code = new OracleParameter(":cfybz_code", OracleDbType.NVarchar2);
                    pCfybz_code.Direction = ParameterDirection.Input;
                    pCfybz_code.Value = jc_ypParamLike.Cfybz_code;
                    sqlparams.Add(pCfybz_code);
                }

                if (null != jc_ypParamLike.Cfqxjy_code && "" != jc_ypParamLike.Cfqxjy_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.CFQXJY_CODE LIKE '%'||:cfqxjy_code||'%' ");
                    OracleParameter pCfqxjy_code = new OracleParameter(":cfqxjy_code", OracleDbType.NVarchar2);
                    pCfqxjy_code.Direction = ParameterDirection.Input;
                    pCfqxjy_code.Value = jc_ypParamLike.Cfqxjy_code;
                    sqlparams.Add(pCfqxjy_code);
                }

                if (null != jc_ypParamLike.Cfqxyb_code && "" != jc_ypParamLike.Cfqxyb_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.CFQXYB_CODE LIKE '%'||:cfqxyb_code||'%' ");
                    OracleParameter pCfqxyb_code = new OracleParameter(":cfqxyb_code", OracleDbType.NVarchar2);
                    pCfqxyb_code.Direction = ParameterDirection.Input;
                    pCfqxyb_code.Value = jc_ypParamLike.Cfqxyb_code;
                    sqlparams.Add(pCfqxyb_code);
                }

                if (null != jc_ypParamLike.Cfqxdm_code && "" != jc_ypParamLike.Cfqxdm_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.CFQXDM_CODE LIKE '%'||:cfqxdm_code||'%' ");
                    OracleParameter pCfqxdm_code = new OracleParameter(":cfqxdm_code", OracleDbType.NVarchar2);
                    pCfqxdm_code.Direction = ParameterDirection.Input;
                    pCfqxdm_code.Value = jc_ypParamLike.Cfqxdm_code;
                    sqlparams.Add(pCfqxdm_code);
                }

                if (null != jc_ypParamLike.Cfqxjs_code && "" != jc_ypParamLike.Cfqxjs_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.CFQXJS_CODE LIKE '%'||:cfqxjs_code||'%' ");
                    OracleParameter pCfqxjs_code = new OracleParameter(":cfqxjs_code", OracleDbType.NVarchar2);
                    pCfqxjs_code.Direction = ParameterDirection.Input;
                    pCfqxjs_code.Value = jc_ypParamLike.Cfqxjs_code;
                    sqlparams.Add(pCfqxjs_code);
                }

                if (null != jc_ypParamLike.Cfqxgz_code && "" != jc_ypParamLike.Cfqxgz_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.CFQXGZ_CODE LIKE '%'||:cfqxgz_code||'%' ");
                    OracleParameter pCfqxgz_code = new OracleParameter(":cfqxgz_code", OracleDbType.NVarchar2);
                    pCfqxgz_code.Direction = ParameterDirection.Input;
                    pCfqxgz_code.Value = jc_ypParamLike.Cfqxgz_code;
                    sqlparams.Add(pCfqxgz_code);
                }

                if (null != jc_ypParamLike.Cfqxjk_code && "" != jc_ypParamLike.Cfqxjk_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.CFQXJK_CODE LIKE '%'||:cfqxjk_code||'%' ");
                    OracleParameter pCfqxjk_code = new OracleParameter(":cfqxjk_code", OracleDbType.NVarchar2);
                    pCfqxjk_code.Direction = ParameterDirection.Input;
                    pCfqxjk_code.Value = jc_ypParamLike.Cfqxjk_code;
                    sqlparams.Add(pCfqxjk_code);
                }

                if (null != jc_ypParamLike.Cfqxzz_code && "" != jc_ypParamLike.Cfqxzz_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.CFQXZZ_CODE LIKE '%'||:cfqxzz_code||'%' ");
                    OracleParameter pCfqxzz_code = new OracleParameter(":cfqxzz_code", OracleDbType.NVarchar2);
                    pCfqxzz_code.Direction = ParameterDirection.Input;
                    pCfqxzz_code.Value = jc_ypParamLike.Cfqxzz_code;
                    sqlparams.Add(pCfqxzz_code);
                }

                if (null != jc_ypParamLike.Cfqxzf_code && "" != jc_ypParamLike.Cfqxzf_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.CFQXZF_CODE LIKE '%'||:cfqxzf_code||'%' ");
                    OracleParameter pCfqxzf_code = new OracleParameter(":cfqxzf_code", OracleDbType.NVarchar2);
                    pCfqxzf_code.Direction = ParameterDirection.Input;
                    pCfqxzf_code.Value = jc_ypParamLike.Cfqxzf_code;
                    sqlparams.Add(pCfqxzf_code);
                }

                if (null != jc_ypParamLike.Cfqxts_code && "" != jc_ypParamLike.Cfqxts_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.CFQXTS_CODE LIKE '%'||:cfqxts_code||'%' ");
                    OracleParameter pCfqxts_code = new OracleParameter(":cfqxts_code", OracleDbType.NVarchar2);
                    pCfqxts_code.Direction = ParameterDirection.Input;
                    pCfqxts_code.Value = jc_ypParamLike.Cfqxts_code;
                    sqlparams.Add(pCfqxts_code);
                }

                if (null != jc_ypParamLike.Ps_code && "" != jc_ypParamLike.Ps_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.PS_CODE LIKE '%'||:ps_code||'%' ");
                    OracleParameter pPs_code = new OracleParameter(":ps_code", OracleDbType.NVarchar2);
                    pPs_code.Direction = ParameterDirection.Input;
                    pPs_code.Value = jc_ypParamLike.Ps_code;
                    sqlparams.Add(pPs_code);
                }

                if (null != jc_ypParamLike.Yplx_code && "" != jc_ypParamLike.Yplx_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YPLX_CODE LIKE '%'||:yplx_code||'%' ");
                    OracleParameter pYplx_code = new OracleParameter(":yplx_code", OracleDbType.NVarchar2);
                    pYplx_code.Direction = ParameterDirection.Input;
                    pYplx_code.Value = jc_ypParamLike.Yplx_code;
                    sqlparams.Add(pYplx_code);
                }

                if (null != jc_ypParamLike.Ypmssyz && "" != jc_ypParamLike.Ypmssyz)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YPMSSYZ LIKE '%'||:ypmssyz||'%' ");
                    OracleParameter pYpmssyz = new OracleParameter(":ypmssyz", OracleDbType.NVarchar2);
                    pYpmssyz.Direction = ParameterDirection.Input;
                    pYpmssyz.Value = jc_ypParamLike.Ypmssyz;
                    sqlparams.Add(pYpmssyz);
                }

                if (null != jc_ypParamLike.Ypmsjjz && "" != jc_ypParamLike.Ypmsjjz)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YPMSJJZ LIKE '%'||:ypmsjjz||'%' ");
                    OracleParameter pYpmsjjz = new OracleParameter(":ypmsjjz", OracleDbType.NVarchar2);
                    pYpmsjjz.Direction = ParameterDirection.Input;
                    pYpmsjjz.Value = jc_ypParamLike.Ypmsjjz;
                    sqlparams.Add(pYpmsjjz);
                }

                if (null != jc_ypParamLike.Ypmsyfhbrqjy_code && "" != jc_ypParamLike.Ypmsyfhbrqjy_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YPMSYFHBRQJY_CODE LIKE '%'||:ypmsyfhbrqjy_code||'%' ");
                    OracleParameter pYpmsyfhbrqjy_code = new OracleParameter(":ypmsyfhbrqjy_code", OracleDbType.NVarchar2);
                    pYpmsyfhbrqjy_code.Direction = ParameterDirection.Input;
                    pYpmsyfhbrqjy_code.Value = jc_ypParamLike.Ypmsyfhbrqjy_code;
                    sqlparams.Add(pYpmsyfhbrqjy_code);
                }

                if (null != jc_ypParamLike.Ypmsblfy && "" != jc_ypParamLike.Ypmsblfy)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YPMSBLFY LIKE '%'||:ypmsblfy||'%' ");
                    OracleParameter pYpmsblfy = new OracleParameter(":ypmsblfy", OracleDbType.NVarchar2);
                    pYpmsblfy.Direction = ParameterDirection.Input;
                    pYpmsblfy.Value = jc_ypParamLike.Ypmsblfy;
                    sqlparams.Add(pYpmsblfy);
                }

                if (null != jc_ypParamLike.Ypfl_code && "" != jc_ypParamLike.Ypfl_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YPFL_CODE LIKE '%'||:ypfl_code||'%' ");
                    OracleParameter pYpfl_code = new OracleParameter(":ypfl_code", OracleDbType.NVarchar2);
                    pYpfl_code.Direction = ParameterDirection.Input;
                    pYpfl_code.Value = jc_ypParamLike.Ypfl_code;
                    sqlparams.Add(pYpfl_code);
                }

                if (null != jc_ypParamLike.Yjjb_code && "" != jc_ypParamLike.Yjjb_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YJJB_CODE LIKE '%'||:yjjb_code||'%' ");
                    OracleParameter pYjjb_code = new OracleParameter(":yjjb_code", OracleDbType.NVarchar2);
                    pYjjb_code.Direction = ParameterDirection.Input;
                    pYjjb_code.Value = jc_ypParamLike.Yjjb_code;
                    sqlparams.Add(pYjjb_code);
                }

                if (null != jc_ypParamLike.Txm && "" != jc_ypParamLike.Txm)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.TXM LIKE '%'||:txm||'%' ");
                    OracleParameter pTxm = new OracleParameter(":txm", OracleDbType.NVarchar2);
                    pTxm.Direction = ParameterDirection.Input;
                    pTxm.Value = jc_ypParamLike.Txm;
                    sqlparams.Add(pTxm);
                }

                if (null != jc_ypParamLike.Ewm && "" != jc_ypParamLike.Ewm)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.EWM LIKE '%'||:ewm||'%' ");
                    OracleParameter pEwm = new OracleParameter(":ewm", OracleDbType.NVarchar2);
                    pEwm.Direction = ParameterDirection.Input;
                    pEwm.Value = jc_ypParamLike.Ewm;
                    sqlparams.Add(pEwm);
                }

                if (null != jc_ypParamLike.Pym && "" != jc_ypParamLike.Pym)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.PYM LIKE '%'||:pym||'%' ");
                    OracleParameter pPym = new OracleParameter(":pym", OracleDbType.NVarchar2);
                    pPym.Direction = ParameterDirection.Input;
                    pPym.Value = jc_ypParamLike.Pym;
                    sqlparams.Add(pPym);
                }

                if (null != jc_ypParamLike.Sfcly_code && "" != jc_ypParamLike.Sfcly_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.SFCLY_CODE LIKE '%'||:sfcly_code||'%' ");
                    OracleParameter pSfcly_code = new OracleParameter(":sfcly_code", OracleDbType.NVarchar2);
                    pSfcly_code.Direction = ParameterDirection.Input;
                    pSfcly_code.Value = jc_ypParamLike.Sfcly_code;
                    sqlparams.Add(pSfcly_code);
                }

                if (null != jc_ypParamLike.Sfclm_code && "" != jc_ypParamLike.Sfclm_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.SFCLM_CODE LIKE '%'||:sfclm_code||'%' ");
                    OracleParameter pSfclm_code = new OracleParameter(":sfclm_code", OracleDbType.NVarchar2);
                    pSfclm_code.Direction = ParameterDirection.Input;
                    pSfclm_code.Value = jc_ypParamLike.Sfclm_code;
                    sqlparams.Add(pSfclm_code);
                }

                if (null != jc_ypParamLike.Yxzt_code && "" != jc_ypParamLike.Yxzt_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YXZT_CODE LIKE '%'||:yxzt_code||'%' ");
                    OracleParameter pYxzt_code = new OracleParameter(":yxzt_code", OracleDbType.NVarchar2);
                    pYxzt_code.Direction = ParameterDirection.Input;
                    pYxzt_code.Value = jc_ypParamLike.Yxzt_code;
                    sqlparams.Add(pYxzt_code);
                }

                if (null != jc_ypParamLike.Scqy && "" != jc_ypParamLike.Scqy)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.SCQY LIKE '%'||:scqy||'%' ");
                    OracleParameter pScqy = new OracleParameter(":scqy", OracleDbType.NVarchar2);
                    pScqy.Direction = ParameterDirection.Input;
                    pScqy.Value = jc_ypParamLike.Scqy;
                    sqlparams.Add(pScqy);
                }

                if (null != jc_ypParamLike.Sfkss_code && "" != jc_ypParamLike.Sfkss_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.SFKSS_CODE LIKE '%'||:sfkss_code||'%' ");
                    OracleParameter pSfkss_code = new OracleParameter(":sfkss_code", OracleDbType.NVarchar2);
                    pSfkss_code.Direction = ParameterDirection.Input;
                    pSfkss_code.Value = jc_ypParamLike.Sfkss_code;
                    sqlparams.Add(pSfkss_code);
                }

                if (null != jc_ypParamLike.Zfbz && "" != jc_ypParamLike.Zfbz)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.ZFBZ LIKE '%'||:zfbz||'%' ");
                    OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                    pZfbz.Direction = ParameterDirection.Input;
                    pZfbz.Value = jc_ypParamLike.Zfbz;
                    sqlparams.Add(pZfbz);
                }

            }

            this.b_isWhere = false;
            return Int32.Parse(OracleHelper.ExecuteScalar(sql.ToString(), sqlparams.ToArray()).ToString());
        }
    }
}


