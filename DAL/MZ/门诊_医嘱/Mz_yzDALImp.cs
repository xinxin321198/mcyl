

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAL.Common;
using System.Transactions;//引入事务
using Oracle.DataAccess.Client;//引入oracle驱动
using Model.MZ;
using Model.Common;

namespace DAL.MZ.门诊_医嘱
{
    /// <summary>
    ///数据库访问层的Mz_yz实现类
    ///此类由代码生成器生成
    ///表名：MZ_YZ
    ///生成日期：2016-02-05 17:29:54
    /// 

    ///作者：罗新鑫
    ///联系电话：15087010221
    ///联系邮箱：362527240@qq.com
        
    /// </summary>
    public class Mz_yzDALImp :Base.BasDAL,Mz_yzDAL
    {

        /// <summary>
        /// 插入一条数据（如果需要供事务使用就传入OracleConnection对象，如果不供就传入null，方法自动生成OracleConnection对象）
        /// 主键为null时，自动生成主键guid，一般不直接调用此方法，请调用save方法进行单条数据的插入和修改       
        /// </summary>
        /// <param name="mz_yzParam">要插入的mz_yzParam对象</param>
        /// <param name="con">Oracle连接对象（为null时自动生成）</param>
        /// <returns>是否添加成功（影响的行数为1时成功）</returns>
        public bool insert(Mz_yz mz_yzParam,OracleConnection con)
        {
            if (""==mz_yzParam.Id||null==mz_yzParam.Id)
            {
                mz_yzParam.Id = Model.Common.GUIDHelper.getGuid();
            }
            List<OracleParameter> sqlparams = new List<OracleParameter>();
            
            StringBuilder sql = new StringBuilder("INSERT INTO MZ_YZ(id,zfbz,yznr,yzlx_code,fk_yp,fk_zlxm,xmbh,xmmc,xdw,gg,jx,sl,yytj,yypl_code,dcyl,dcyldw,ts,yypl,fk_gh_id,gh_lsh,ds,ph,jj,lsj,dcyldwbl,fk_keshi_id,sfwc_code,sfwc,keshi) VALUES(:id,:zfbz,:yznr,:yzlx_code,:fk_yp,:fk_zlxm,:xmbh,:xmmc,:xdw,:gg,:jx,:sl,:yytj,:yypl_code,:dcyl,:dcyldw,:ts,:yypl,:fk_gh_id,:gh_lsh,:ds,:ph,:jj,:lsj,:dcyldwbl,:fk_keshi_id,:sfwc_code,:sfwc,:keshi)");
            
            OracleParameter pId = new OracleParameter(":id", OracleDbType.Varchar2);
            pId.Direction = ParameterDirection.Input;
            pId.Value = mz_yzParam.Id;
            sqlparams.Add(pId);
            OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
            pZfbz.Direction = ParameterDirection.Input;
            pZfbz.Value = mz_yzParam.Zfbz;
            sqlparams.Add(pZfbz);
            OracleParameter pYznr = new OracleParameter(":yznr", OracleDbType.NVarchar2);
            pYznr.Direction = ParameterDirection.Input;
            pYznr.Value = mz_yzParam.Yznr;
            sqlparams.Add(pYznr);
            OracleParameter pYzlx_code = new OracleParameter(":yzlx_code", OracleDbType.NVarchar2);
            pYzlx_code.Direction = ParameterDirection.Input;
            pYzlx_code.Value = mz_yzParam.Yzlx_code;
            sqlparams.Add(pYzlx_code);
            OracleParameter pFk_yp = new OracleParameter(":fk_yp", OracleDbType.Varchar2);
            pFk_yp.Direction = ParameterDirection.Input;
            pFk_yp.Value = mz_yzParam.Fk_yp;
            sqlparams.Add(pFk_yp);
            OracleParameter pFk_zlxm = new OracleParameter(":fk_zlxm", OracleDbType.Varchar2);
            pFk_zlxm.Direction = ParameterDirection.Input;
            pFk_zlxm.Value = mz_yzParam.Fk_zlxm;
            sqlparams.Add(pFk_zlxm);
            OracleParameter pXmbh = new OracleParameter(":xmbh", OracleDbType.NVarchar2);
            pXmbh.Direction = ParameterDirection.Input;
            pXmbh.Value = mz_yzParam.Xmbh;
            sqlparams.Add(pXmbh);
            OracleParameter pXmmc = new OracleParameter(":xmmc", OracleDbType.NVarchar2);
            pXmmc.Direction = ParameterDirection.Input;
            pXmmc.Value = mz_yzParam.Xmmc;
            sqlparams.Add(pXmmc);
            OracleParameter pXdw = new OracleParameter(":xdw", OracleDbType.NVarchar2);
            pXdw.Direction = ParameterDirection.Input;
            pXdw.Value = mz_yzParam.Xdw;
            sqlparams.Add(pXdw);
            OracleParameter pGg = new OracleParameter(":gg", OracleDbType.NVarchar2);
            pGg.Direction = ParameterDirection.Input;
            pGg.Value = mz_yzParam.Gg;
            sqlparams.Add(pGg);
            OracleParameter pJx = new OracleParameter(":jx", OracleDbType.NVarchar2);
            pJx.Direction = ParameterDirection.Input;
            pJx.Value = mz_yzParam.Jx;
            sqlparams.Add(pJx);
            OracleParameter pSl = new OracleParameter(":sl", OracleDbType.Decimal);
            pSl.Direction = ParameterDirection.Input;
            pSl.Value = mz_yzParam.Sl;
            sqlparams.Add(pSl);
            OracleParameter pYytj = new OracleParameter(":yytj", OracleDbType.NVarchar2);
            pYytj.Direction = ParameterDirection.Input;
            pYytj.Value = mz_yzParam.Yytj;
            sqlparams.Add(pYytj);
            OracleParameter pYypl_code = new OracleParameter(":yypl_code", OracleDbType.NVarchar2);
            pYypl_code.Direction = ParameterDirection.Input;
            pYypl_code.Value = mz_yzParam.Yypl_code;
            sqlparams.Add(pYypl_code);
            OracleParameter pDcyl = new OracleParameter(":dcyl", OracleDbType.Decimal);
            pDcyl.Direction = ParameterDirection.Input;
            pDcyl.Value = mz_yzParam.Dcyl;
            sqlparams.Add(pDcyl);
            OracleParameter pDcyldw = new OracleParameter(":dcyldw", OracleDbType.NVarchar2);
            pDcyldw.Direction = ParameterDirection.Input;
            pDcyldw.Value = mz_yzParam.Dcyldw;
            sqlparams.Add(pDcyldw);
            OracleParameter pTs = new OracleParameter(":ts", OracleDbType.Decimal);
            pTs.Direction = ParameterDirection.Input;
            pTs.Value = mz_yzParam.Ts;
            sqlparams.Add(pTs);
            OracleParameter pYypl = new OracleParameter(":yypl", OracleDbType.NVarchar2);
            pYypl.Direction = ParameterDirection.Input;
            pYypl.Value = mz_yzParam.Yypl;
            sqlparams.Add(pYypl);
            OracleParameter pFk_gh_id = new OracleParameter(":fk_gh_id", OracleDbType.Varchar2);
            pFk_gh_id.Direction = ParameterDirection.Input;
            pFk_gh_id.Value = mz_yzParam.Fk_gh_id;
            sqlparams.Add(pFk_gh_id);
            OracleParameter pGh_lsh = new OracleParameter(":gh_lsh", OracleDbType.Decimal);
            pGh_lsh.Direction = ParameterDirection.Input;
            pGh_lsh.Value = mz_yzParam.Gh_lsh;
            sqlparams.Add(pGh_lsh);
            OracleParameter pDs = new OracleParameter(":ds", OracleDbType.NVarchar2);
            pDs.Direction = ParameterDirection.Input;
            pDs.Value = mz_yzParam.Ds;
            sqlparams.Add(pDs);
            OracleParameter pPh = new OracleParameter(":ph", OracleDbType.NVarchar2);
            pPh.Direction = ParameterDirection.Input;
            pPh.Value = mz_yzParam.Ph;
            sqlparams.Add(pPh);
            OracleParameter pJj = new OracleParameter(":jj", OracleDbType.Decimal);
            pJj.Direction = ParameterDirection.Input;
            pJj.Value = mz_yzParam.Jj;
            sqlparams.Add(pJj);
            OracleParameter pLsj = new OracleParameter(":lsj", OracleDbType.Decimal);
            pLsj.Direction = ParameterDirection.Input;
            pLsj.Value = mz_yzParam.Lsj;
            sqlparams.Add(pLsj);
            OracleParameter pDcyldwbl = new OracleParameter(":dcyldwbl", OracleDbType.Decimal);
            pDcyldwbl.Direction = ParameterDirection.Input;
            pDcyldwbl.Value = mz_yzParam.Dcyldwbl;
            sqlparams.Add(pDcyldwbl);
            OracleParameter pFk_keshi_id = new OracleParameter(":fk_keshi_id", OracleDbType.Varchar2);
            pFk_keshi_id.Direction = ParameterDirection.Input;
            pFk_keshi_id.Value = mz_yzParam.Fk_keshi_id;
            sqlparams.Add(pFk_keshi_id);
            OracleParameter pSfwc_code = new OracleParameter(":sfwc_code", OracleDbType.NVarchar2);
            pSfwc_code.Direction = ParameterDirection.Input;
            pSfwc_code.Value = mz_yzParam.Sfwc_code;
            sqlparams.Add(pSfwc_code);
            OracleParameter pSfwc = new OracleParameter(":sfwc", OracleDbType.NVarchar2);
            pSfwc.Direction = ParameterDirection.Input;
            pSfwc.Value = mz_yzParam.Sfwc;
            sqlparams.Add(pSfwc);
            OracleParameter pKeshi = new OracleParameter(":keshi", OracleDbType.NVarchar2);
            pKeshi.Direction = ParameterDirection.Input;
            pKeshi.Value = mz_yzParam.Keshi;
            sqlparams.Add(pKeshi);
            bool result = false;
            int flag = OracleHelper.ExecuteNonQuery(sql.ToString(), con, sqlparams.ToArray());
            if (1 == flag)
            {
                result =  true;
            }
            return result;

        }

        /// <summary>
        /// 插入多条数据（如果需要供事务使用就传入OracleConnection对象，如果不供就传入null，方法自动生成OracleConnection对象,并且自动使用事务）
        /// 主键为null时，自动生成主键guid
        /// </summary>
        /// <param name="mz_yzParamList">要插入的mz_yzParam对象的集合</param>
        /// <param name="con">Oracle连接对象（为null时自动生成）</param>
        /// <returns>是否添加成功（影响的行数等于保存的对象的数量时成功）</returns>
        public bool inertBatch(List<Mz_yz> mz_yzParamList, OracleConnection con)
        {
            if (mz_yzParamList.Count == 0)
            {
                return true;
            }

            List<string> idList = new List<string>();

            List<string> zfbzList = new List<string>();

            List<string> yznrList = new List<string>();

            List<string> yzlx_codeList = new List<string>();

            List<string> fk_ypList = new List<string>();

            List<string> fk_zlxmList = new List<string>();

            List<string> xmbhList = new List<string>();

            List<string> xmmcList = new List<string>();

            List<string> xdwList = new List<string>();

            List<string> ggList = new List<string>();

            List<string> jxList = new List<string>();

            List<decimal?> slList = new List<decimal?>();

            List<string> yytjList = new List<string>();

            List<string> yypl_codeList = new List<string>();

            List<decimal?> dcylList = new List<decimal?>();

            List<string> dcyldwList = new List<string>();

            List<decimal?> tsList = new List<decimal?>();

            List<string> yyplList = new List<string>();

            List<string> fk_gh_idList = new List<string>();

            List<decimal?> gh_lshList = new List<decimal?>();

            List<string> dsList = new List<string>();

            List<string> phList = new List<string>();

            List<decimal?> jjList = new List<decimal?>();

            List<decimal?> lsjList = new List<decimal?>();

            List<decimal?> dcyldwblList = new List<decimal?>();

            List<string> fk_keshi_idList = new List<string>();

            List<string> sfwc_codeList = new List<string>();

            List<string> sfwcList = new List<string>();

            List<string> keshiList = new List<string>();

            for (int i = 0; i < mz_yzParamList.Count; i++)
            {
                Mz_yz mz_yzParam = mz_yzParamList[i];
                if ("" == mz_yzParam.Id || null == mz_yzParam.Id)
                {
                    mz_yzParam.Id = Model.Common.GUIDHelper.getGuid();
                }

            idList.Add(mz_yzParam.Id);

            zfbzList.Add(mz_yzParam.Zfbz);

            yznrList.Add(mz_yzParam.Yznr);

            yzlx_codeList.Add(mz_yzParam.Yzlx_code);

            fk_ypList.Add(mz_yzParam.Fk_yp);

            fk_zlxmList.Add(mz_yzParam.Fk_zlxm);

            xmbhList.Add(mz_yzParam.Xmbh);

            xmmcList.Add(mz_yzParam.Xmmc);

            xdwList.Add(mz_yzParam.Xdw);

            ggList.Add(mz_yzParam.Gg);

            jxList.Add(mz_yzParam.Jx);

            slList.Add(mz_yzParam.Sl);

            yytjList.Add(mz_yzParam.Yytj);

            yypl_codeList.Add(mz_yzParam.Yypl_code);

            dcylList.Add(mz_yzParam.Dcyl);

            dcyldwList.Add(mz_yzParam.Dcyldw);

            tsList.Add(mz_yzParam.Ts);

            yyplList.Add(mz_yzParam.Yypl);

            fk_gh_idList.Add(mz_yzParam.Fk_gh_id);

            gh_lshList.Add(mz_yzParam.Gh_lsh);

            dsList.Add(mz_yzParam.Ds);

            phList.Add(mz_yzParam.Ph);

            jjList.Add(mz_yzParam.Jj);

            lsjList.Add(mz_yzParam.Lsj);

            dcyldwblList.Add(mz_yzParam.Dcyldwbl);

            fk_keshi_idList.Add(mz_yzParam.Fk_keshi_id);

            sfwc_codeList.Add(mz_yzParam.Sfwc_code);

            sfwcList.Add(mz_yzParam.Sfwc);

            keshiList.Add(mz_yzParam.Keshi);

            }

            List<OracleParameter> sqlparams = new List<OracleParameter>();

            StringBuilder sql = new StringBuilder("INSERT INTO MZ_YZ(id,zfbz,yznr,yzlx_code,fk_yp,fk_zlxm,xmbh,xmmc,xdw,gg,jx,sl,yytj,yypl_code,dcyl,dcyldw,ts,yypl,fk_gh_id,gh_lsh,ds,ph,jj,lsj,dcyldwbl,fk_keshi_id,sfwc_code,sfwc,keshi) VALUES(:id,:zfbz,:yznr,:yzlx_code,:fk_yp,:fk_zlxm,:xmbh,:xmmc,:xdw,:gg,:jx,:sl,:yytj,:yypl_code,:dcyl,:dcyldw,:ts,:yypl,:fk_gh_id,:gh_lsh,:ds,:ph,:jj,:lsj,:dcyldwbl,:fk_keshi_id,:sfwc_code,:sfwc,:keshi)");
            
            OracleParameter pId = new OracleParameter(":id", OracleDbType.Varchar2);
            pId.Direction = ParameterDirection.Input;
            pId.Value = idList.ToArray();
            sqlparams.Add(pId);
            OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
            pZfbz.Direction = ParameterDirection.Input;
            pZfbz.Value = zfbzList.ToArray();
            sqlparams.Add(pZfbz);
            OracleParameter pYznr = new OracleParameter(":yznr", OracleDbType.NVarchar2);
            pYznr.Direction = ParameterDirection.Input;
            pYznr.Value = yznrList.ToArray();
            sqlparams.Add(pYznr);
            OracleParameter pYzlx_code = new OracleParameter(":yzlx_code", OracleDbType.NVarchar2);
            pYzlx_code.Direction = ParameterDirection.Input;
            pYzlx_code.Value = yzlx_codeList.ToArray();
            sqlparams.Add(pYzlx_code);
            OracleParameter pFk_yp = new OracleParameter(":fk_yp", OracleDbType.Varchar2);
            pFk_yp.Direction = ParameterDirection.Input;
            pFk_yp.Value = fk_ypList.ToArray();
            sqlparams.Add(pFk_yp);
            OracleParameter pFk_zlxm = new OracleParameter(":fk_zlxm", OracleDbType.Varchar2);
            pFk_zlxm.Direction = ParameterDirection.Input;
            pFk_zlxm.Value = fk_zlxmList.ToArray();
            sqlparams.Add(pFk_zlxm);
            OracleParameter pXmbh = new OracleParameter(":xmbh", OracleDbType.NVarchar2);
            pXmbh.Direction = ParameterDirection.Input;
            pXmbh.Value = xmbhList.ToArray();
            sqlparams.Add(pXmbh);
            OracleParameter pXmmc = new OracleParameter(":xmmc", OracleDbType.NVarchar2);
            pXmmc.Direction = ParameterDirection.Input;
            pXmmc.Value = xmmcList.ToArray();
            sqlparams.Add(pXmmc);
            OracleParameter pXdw = new OracleParameter(":xdw", OracleDbType.NVarchar2);
            pXdw.Direction = ParameterDirection.Input;
            pXdw.Value = xdwList.ToArray();
            sqlparams.Add(pXdw);
            OracleParameter pGg = new OracleParameter(":gg", OracleDbType.NVarchar2);
            pGg.Direction = ParameterDirection.Input;
            pGg.Value = ggList.ToArray();
            sqlparams.Add(pGg);
            OracleParameter pJx = new OracleParameter(":jx", OracleDbType.NVarchar2);
            pJx.Direction = ParameterDirection.Input;
            pJx.Value = jxList.ToArray();
            sqlparams.Add(pJx);
            OracleParameter pSl = new OracleParameter(":sl", OracleDbType.Decimal);
            pSl.Direction = ParameterDirection.Input;
            pSl.Value = slList.ToArray();
            sqlparams.Add(pSl);
            OracleParameter pYytj = new OracleParameter(":yytj", OracleDbType.NVarchar2);
            pYytj.Direction = ParameterDirection.Input;
            pYytj.Value = yytjList.ToArray();
            sqlparams.Add(pYytj);
            OracleParameter pYypl_code = new OracleParameter(":yypl_code", OracleDbType.NVarchar2);
            pYypl_code.Direction = ParameterDirection.Input;
            pYypl_code.Value = yypl_codeList.ToArray();
            sqlparams.Add(pYypl_code);
            OracleParameter pDcyl = new OracleParameter(":dcyl", OracleDbType.Decimal);
            pDcyl.Direction = ParameterDirection.Input;
            pDcyl.Value = dcylList.ToArray();
            sqlparams.Add(pDcyl);
            OracleParameter pDcyldw = new OracleParameter(":dcyldw", OracleDbType.NVarchar2);
            pDcyldw.Direction = ParameterDirection.Input;
            pDcyldw.Value = dcyldwList.ToArray();
            sqlparams.Add(pDcyldw);
            OracleParameter pTs = new OracleParameter(":ts", OracleDbType.Decimal);
            pTs.Direction = ParameterDirection.Input;
            pTs.Value = tsList.ToArray();
            sqlparams.Add(pTs);
            OracleParameter pYypl = new OracleParameter(":yypl", OracleDbType.NVarchar2);
            pYypl.Direction = ParameterDirection.Input;
            pYypl.Value = yyplList.ToArray();
            sqlparams.Add(pYypl);
            OracleParameter pFk_gh_id = new OracleParameter(":fk_gh_id", OracleDbType.Varchar2);
            pFk_gh_id.Direction = ParameterDirection.Input;
            pFk_gh_id.Value = fk_gh_idList.ToArray();
            sqlparams.Add(pFk_gh_id);
            OracleParameter pGh_lsh = new OracleParameter(":gh_lsh", OracleDbType.Decimal);
            pGh_lsh.Direction = ParameterDirection.Input;
            pGh_lsh.Value = gh_lshList.ToArray();
            sqlparams.Add(pGh_lsh);
            OracleParameter pDs = new OracleParameter(":ds", OracleDbType.NVarchar2);
            pDs.Direction = ParameterDirection.Input;
            pDs.Value = dsList.ToArray();
            sqlparams.Add(pDs);
            OracleParameter pPh = new OracleParameter(":ph", OracleDbType.NVarchar2);
            pPh.Direction = ParameterDirection.Input;
            pPh.Value = phList.ToArray();
            sqlparams.Add(pPh);
            OracleParameter pJj = new OracleParameter(":jj", OracleDbType.Decimal);
            pJj.Direction = ParameterDirection.Input;
            pJj.Value = jjList.ToArray();
            sqlparams.Add(pJj);
            OracleParameter pLsj = new OracleParameter(":lsj", OracleDbType.Decimal);
            pLsj.Direction = ParameterDirection.Input;
            pLsj.Value = lsjList.ToArray();
            sqlparams.Add(pLsj);
            OracleParameter pDcyldwbl = new OracleParameter(":dcyldwbl", OracleDbType.Decimal);
            pDcyldwbl.Direction = ParameterDirection.Input;
            pDcyldwbl.Value = dcyldwblList.ToArray();
            sqlparams.Add(pDcyldwbl);
            OracleParameter pFk_keshi_id = new OracleParameter(":fk_keshi_id", OracleDbType.Varchar2);
            pFk_keshi_id.Direction = ParameterDirection.Input;
            pFk_keshi_id.Value = fk_keshi_idList.ToArray();
            sqlparams.Add(pFk_keshi_id);
            OracleParameter pSfwc_code = new OracleParameter(":sfwc_code", OracleDbType.NVarchar2);
            pSfwc_code.Direction = ParameterDirection.Input;
            pSfwc_code.Value = sfwc_codeList.ToArray();
            sqlparams.Add(pSfwc_code);
            OracleParameter pSfwc = new OracleParameter(":sfwc", OracleDbType.NVarchar2);
            pSfwc.Direction = ParameterDirection.Input;
            pSfwc.Value = sfwcList.ToArray();
            sqlparams.Add(pSfwc);
            OracleParameter pKeshi = new OracleParameter(":keshi", OracleDbType.NVarchar2);
            pKeshi.Direction = ParameterDirection.Input;
            pKeshi.Value = keshiList.ToArray();
            sqlparams.Add(pKeshi);
            bool result = false;
            int flag = -1;
            flag = OracleHelper.ExecuteBatch(sql.ToString(), con, mz_yzParamList.Count, sqlparams.ToArray());
            if (mz_yzParamList.Count == flag)
            {
                result  = true;
            }
            return result;
        }


        /// <summary>
        /// 删除指定ID的一条数据（如果需要供事务使用就传入OracleConnection对象，如果不供就传入null，方法自动生成OracleConnection对象）
        /// </summary>
        /// <param Name="id">要删除的数据的guid</param>
        /// <param Name="con">Oracle连接对象（为null时自动生成）</param>
        /// <returns>是否删除成功（影响的行数为1时成功）</returns>
        public bool deleteById(string id,OracleConnection con)
        {
            if ("" == id || null == id)
            {
                throw new Exception("ID不允许为空，请赋值后调用；错误出自：deleteById");
            }
            StringBuilder sql = new StringBuilder("DELETE MZ_YZ WHERE ID=:id");
            OracleParameter pId = new OracleParameter(":id", OracleDbType.Varchar2);
            pId.Value = id;
            bool result = false;
            int flag = OracleHelper.ExecuteNonQuery(sql.ToString(), con, pId);
            if (1 == flag)
            {
                result =  true;
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
            if (null==idList||0==idList.Count)
            {
                throw new Exception("ID的集合不允许为空或者数量为0，请赋值后调用；错误出自：deleteByIdBatch");
            }
            StringBuilder sql = new StringBuilder("DELETE MZ_YZ WHERE ID=:id");
            OracleParameter pId = new OracleParameter(":id", OracleDbType.Varchar2);
            pId.Value = idList.ToArray();
            bool result = false;
            int flag = OracleHelper.ExecuteBatch(sql.ToString(), con,idList.Count, pId);
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
        /// <param name="mz_yzParamCondition">删除的条件</param>
        /// <param name="con">Oracle连接对象（为null时自动生成）</param>
        /// <returns>无法确定删除的行数（影响行数大于等于0就算成功）</returns>
        public bool deleteByOtherCondition(Mz_yz mz_yzParamCondition, OracleConnection con)
        {
            if (null!=mz_yzParamCondition.Id&&""!=mz_yzParamCondition.Id)
            {
                throw new Exception("不允许指定参数的ID，如果要根据ID删除数据请调用deleteById或者deleteByIdBatch方法；错误出自：deleteByOtherCondition");
            }
            List<OracleParameter> sqlparams = new List<OracleParameter>();
            StringBuilder sql = new StringBuilder("DELETE MZ_YZ ");

            if (null != mz_yzParamCondition.Zfbz &&  ""!= mz_yzParamCondition.Zfbz)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" ZFBZ=:zfbz ");
                OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                pZfbz.Direction = ParameterDirection.Input;
                pZfbz.Value = mz_yzParamCondition.Zfbz;
                sqlparams.Add(pZfbz);

            }
                        
            if (null != mz_yzParamCondition.Yznr &&  ""!= mz_yzParamCondition.Yznr)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" YZNR=:yznr ");
                OracleParameter pYznr = new OracleParameter(":yznr", OracleDbType.NVarchar2);
                pYznr.Direction = ParameterDirection.Input;
                pYznr.Value = mz_yzParamCondition.Yznr;
                sqlparams.Add(pYznr);

            }
                        
            if (null != mz_yzParamCondition.Yzlx_code &&  ""!= mz_yzParamCondition.Yzlx_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" YZLX_CODE=:yzlx_code ");
                OracleParameter pYzlx_code = new OracleParameter(":yzlx_code", OracleDbType.NVarchar2);
                pYzlx_code.Direction = ParameterDirection.Input;
                pYzlx_code.Value = mz_yzParamCondition.Yzlx_code;
                sqlparams.Add(pYzlx_code);

            }
                        
            if (null != mz_yzParamCondition.Fk_yp &&  ""!= mz_yzParamCondition.Fk_yp)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" FK_YP=:fk_yp ");
                OracleParameter pFk_yp = new OracleParameter(":fk_yp", OracleDbType.Varchar2);
                pFk_yp.Direction = ParameterDirection.Input;
                pFk_yp.Value = mz_yzParamCondition.Fk_yp;
                sqlparams.Add(pFk_yp);

            }
                        
            if (null != mz_yzParamCondition.Fk_zlxm &&  ""!= mz_yzParamCondition.Fk_zlxm)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" FK_ZLXM=:fk_zlxm ");
                OracleParameter pFk_zlxm = new OracleParameter(":fk_zlxm", OracleDbType.Varchar2);
                pFk_zlxm.Direction = ParameterDirection.Input;
                pFk_zlxm.Value = mz_yzParamCondition.Fk_zlxm;
                sqlparams.Add(pFk_zlxm);

            }
                        
            if (null != mz_yzParamCondition.Xmbh &&  ""!= mz_yzParamCondition.Xmbh)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" XMBH=:xmbh ");
                OracleParameter pXmbh = new OracleParameter(":xmbh", OracleDbType.NVarchar2);
                pXmbh.Direction = ParameterDirection.Input;
                pXmbh.Value = mz_yzParamCondition.Xmbh;
                sqlparams.Add(pXmbh);

            }
                        
            if (null != mz_yzParamCondition.Xmmc &&  ""!= mz_yzParamCondition.Xmmc)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" XMMC=:xmmc ");
                OracleParameter pXmmc = new OracleParameter(":xmmc", OracleDbType.NVarchar2);
                pXmmc.Direction = ParameterDirection.Input;
                pXmmc.Value = mz_yzParamCondition.Xmmc;
                sqlparams.Add(pXmmc);

            }
                        
            if (null != mz_yzParamCondition.Xdw &&  ""!= mz_yzParamCondition.Xdw)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" XDW=:xdw ");
                OracleParameter pXdw = new OracleParameter(":xdw", OracleDbType.NVarchar2);
                pXdw.Direction = ParameterDirection.Input;
                pXdw.Value = mz_yzParamCondition.Xdw;
                sqlparams.Add(pXdw);

            }
                        
            if (null != mz_yzParamCondition.Gg &&  ""!= mz_yzParamCondition.Gg)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" GG=:gg ");
                OracleParameter pGg = new OracleParameter(":gg", OracleDbType.NVarchar2);
                pGg.Direction = ParameterDirection.Input;
                pGg.Value = mz_yzParamCondition.Gg;
                sqlparams.Add(pGg);

            }
                        
            if (null != mz_yzParamCondition.Jx &&  ""!= mz_yzParamCondition.Jx)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" JX=:jx ");
                OracleParameter pJx = new OracleParameter(":jx", OracleDbType.NVarchar2);
                pJx.Direction = ParameterDirection.Input;
                pJx.Value = mz_yzParamCondition.Jx;
                sqlparams.Add(pJx);

            }
                        
            if (null != mz_yzParamCondition.Sl)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" SL=:sl ");
                OracleParameter pSl = new OracleParameter(":sl", OracleDbType.Decimal);
                pSl.Direction = ParameterDirection.Input;
                pSl.Value = mz_yzParamCondition.Sl;
                sqlparams.Add(pSl);

            }
                        
            if (null != mz_yzParamCondition.Yytj &&  ""!= mz_yzParamCondition.Yytj)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" YYTJ=:yytj ");
                OracleParameter pYytj = new OracleParameter(":yytj", OracleDbType.NVarchar2);
                pYytj.Direction = ParameterDirection.Input;
                pYytj.Value = mz_yzParamCondition.Yytj;
                sqlparams.Add(pYytj);

            }
                        
            if (null != mz_yzParamCondition.Yypl_code &&  ""!= mz_yzParamCondition.Yypl_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" YYPL_CODE=:yypl_code ");
                OracleParameter pYypl_code = new OracleParameter(":yypl_code", OracleDbType.NVarchar2);
                pYypl_code.Direction = ParameterDirection.Input;
                pYypl_code.Value = mz_yzParamCondition.Yypl_code;
                sqlparams.Add(pYypl_code);

            }
                        
            if (null != mz_yzParamCondition.Dcyl)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" DCYL=:dcyl ");
                OracleParameter pDcyl = new OracleParameter(":dcyl", OracleDbType.Decimal);
                pDcyl.Direction = ParameterDirection.Input;
                pDcyl.Value = mz_yzParamCondition.Dcyl;
                sqlparams.Add(pDcyl);

            }
                        
            if (null != mz_yzParamCondition.Dcyldw &&  ""!= mz_yzParamCondition.Dcyldw)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" DCYLDW=:dcyldw ");
                OracleParameter pDcyldw = new OracleParameter(":dcyldw", OracleDbType.NVarchar2);
                pDcyldw.Direction = ParameterDirection.Input;
                pDcyldw.Value = mz_yzParamCondition.Dcyldw;
                sqlparams.Add(pDcyldw);

            }
                        
            if (null != mz_yzParamCondition.Ts)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" TS=:ts ");
                OracleParameter pTs = new OracleParameter(":ts", OracleDbType.Decimal);
                pTs.Direction = ParameterDirection.Input;
                pTs.Value = mz_yzParamCondition.Ts;
                sqlparams.Add(pTs);

            }
                        
            if (null != mz_yzParamCondition.Yypl &&  ""!= mz_yzParamCondition.Yypl)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" YYPL=:yypl ");
                OracleParameter pYypl = new OracleParameter(":yypl", OracleDbType.NVarchar2);
                pYypl.Direction = ParameterDirection.Input;
                pYypl.Value = mz_yzParamCondition.Yypl;
                sqlparams.Add(pYypl);

            }
                        
            if (null != mz_yzParamCondition.Fk_gh_id &&  ""!= mz_yzParamCondition.Fk_gh_id)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" FK_GH_ID=:fk_gh_id ");
                OracleParameter pFk_gh_id = new OracleParameter(":fk_gh_id", OracleDbType.Varchar2);
                pFk_gh_id.Direction = ParameterDirection.Input;
                pFk_gh_id.Value = mz_yzParamCondition.Fk_gh_id;
                sqlparams.Add(pFk_gh_id);

            }
                        
            if (null != mz_yzParamCondition.Gh_lsh)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" GH_LSH=:gh_lsh ");
                OracleParameter pGh_lsh = new OracleParameter(":gh_lsh", OracleDbType.Decimal);
                pGh_lsh.Direction = ParameterDirection.Input;
                pGh_lsh.Value = mz_yzParamCondition.Gh_lsh;
                sqlparams.Add(pGh_lsh);

            }
                        
            if (null != mz_yzParamCondition.Ds &&  ""!= mz_yzParamCondition.Ds)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" DS=:ds ");
                OracleParameter pDs = new OracleParameter(":ds", OracleDbType.NVarchar2);
                pDs.Direction = ParameterDirection.Input;
                pDs.Value = mz_yzParamCondition.Ds;
                sqlparams.Add(pDs);

            }
                        
            if (null != mz_yzParamCondition.Ph &&  ""!= mz_yzParamCondition.Ph)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" PH=:ph ");
                OracleParameter pPh = new OracleParameter(":ph", OracleDbType.NVarchar2);
                pPh.Direction = ParameterDirection.Input;
                pPh.Value = mz_yzParamCondition.Ph;
                sqlparams.Add(pPh);

            }
                        
            if (null != mz_yzParamCondition.Jj)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" JJ=:jj ");
                OracleParameter pJj = new OracleParameter(":jj", OracleDbType.Decimal);
                pJj.Direction = ParameterDirection.Input;
                pJj.Value = mz_yzParamCondition.Jj;
                sqlparams.Add(pJj);

            }
                        
            if (null != mz_yzParamCondition.Lsj)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" LSJ=:lsj ");
                OracleParameter pLsj = new OracleParameter(":lsj", OracleDbType.Decimal);
                pLsj.Direction = ParameterDirection.Input;
                pLsj.Value = mz_yzParamCondition.Lsj;
                sqlparams.Add(pLsj);

            }
                        
            if (null != mz_yzParamCondition.Dcyldwbl)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" DCYLDWBL=:dcyldwbl ");
                OracleParameter pDcyldwbl = new OracleParameter(":dcyldwbl", OracleDbType.Decimal);
                pDcyldwbl.Direction = ParameterDirection.Input;
                pDcyldwbl.Value = mz_yzParamCondition.Dcyldwbl;
                sqlparams.Add(pDcyldwbl);

            }
                        
            if (null != mz_yzParamCondition.Fk_keshi_id &&  ""!= mz_yzParamCondition.Fk_keshi_id)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" FK_KESHI_ID=:fk_keshi_id ");
                OracleParameter pFk_keshi_id = new OracleParameter(":fk_keshi_id", OracleDbType.Varchar2);
                pFk_keshi_id.Direction = ParameterDirection.Input;
                pFk_keshi_id.Value = mz_yzParamCondition.Fk_keshi_id;
                sqlparams.Add(pFk_keshi_id);

            }
                        
            if (null != mz_yzParamCondition.Sfwc_code &&  ""!= mz_yzParamCondition.Sfwc_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" SFWC_CODE=:sfwc_code ");
                OracleParameter pSfwc_code = new OracleParameter(":sfwc_code", OracleDbType.NVarchar2);
                pSfwc_code.Direction = ParameterDirection.Input;
                pSfwc_code.Value = mz_yzParamCondition.Sfwc_code;
                sqlparams.Add(pSfwc_code);

            }
                        
            if (null != mz_yzParamCondition.Sfwc &&  ""!= mz_yzParamCondition.Sfwc)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" SFWC=:sfwc ");
                OracleParameter pSfwc = new OracleParameter(":sfwc", OracleDbType.NVarchar2);
                pSfwc.Direction = ParameterDirection.Input;
                pSfwc.Value = mz_yzParamCondition.Sfwc;
                sqlparams.Add(pSfwc);

            }
                        
            if (null != mz_yzParamCondition.Keshi &&  ""!= mz_yzParamCondition.Keshi)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" KESHI=:keshi ");
                OracleParameter pKeshi = new OracleParameter(":keshi", OracleDbType.NVarchar2);
                pKeshi.Direction = ParameterDirection.Input;
                pKeshi.Value = mz_yzParamCondition.Keshi;
                sqlparams.Add(pKeshi);

            }
                        
            this.b_isWhere = false;
            bool result = false;
            int flag = OracleHelper.ExecuteNonQuery(sql.ToString(), con, sqlparams.ToArray());
            if (flag>=0)
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
        /// <param name="mz_yzParam"></param>
        /// <returns>影响的行数</returns>
        public bool updateById(Mz_yz mz_yzParam,OracleConnection con)
        {
            if ("" == mz_yzParam.Id || null == mz_yzParam.Id)
            {
                throw new Exception("ID不允许为空，请赋值后调用；错误出自：updateById");
            }
            List<OracleParameter> sqlparams = new List<OracleParameter>();

            StringBuilder sql = new StringBuilder("UPDATE MZ_YZ SET ");
            if (null != mz_yzParam.Zfbz &&  ""!= mz_yzParam.Zfbz)
            {
                this.isComma(sql);
                sql.Append(" ZFBZ=:zfbz ");
                OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                pZfbz.Direction = ParameterDirection.Input;
                pZfbz.Value = mz_yzParam.Zfbz;
                sqlparams.Add(pZfbz);

            }
                        
            if (null != mz_yzParam.Yznr &&  ""!= mz_yzParam.Yznr)
            {
                this.isComma(sql);
                sql.Append(" YZNR=:yznr ");
                OracleParameter pYznr = new OracleParameter(":yznr", OracleDbType.NVarchar2);
                pYznr.Direction = ParameterDirection.Input;
                pYznr.Value = mz_yzParam.Yznr;
                sqlparams.Add(pYznr);

            }
                        
            if (null != mz_yzParam.Yzlx_code &&  ""!= mz_yzParam.Yzlx_code)
            {
                this.isComma(sql);
                sql.Append(" YZLX_CODE=:yzlx_code ");
                OracleParameter pYzlx_code = new OracleParameter(":yzlx_code", OracleDbType.NVarchar2);
                pYzlx_code.Direction = ParameterDirection.Input;
                pYzlx_code.Value = mz_yzParam.Yzlx_code;
                sqlparams.Add(pYzlx_code);

            }
                        
            if (null != mz_yzParam.Fk_yp &&  ""!= mz_yzParam.Fk_yp)
            {
                this.isComma(sql);
                sql.Append(" FK_YP=:fk_yp ");
                OracleParameter pFk_yp = new OracleParameter(":fk_yp", OracleDbType.Varchar2);
                pFk_yp.Direction = ParameterDirection.Input;
                pFk_yp.Value = mz_yzParam.Fk_yp;
                sqlparams.Add(pFk_yp);

            }
                        
            if (null != mz_yzParam.Fk_zlxm &&  ""!= mz_yzParam.Fk_zlxm)
            {
                this.isComma(sql);
                sql.Append(" FK_ZLXM=:fk_zlxm ");
                OracleParameter pFk_zlxm = new OracleParameter(":fk_zlxm", OracleDbType.Varchar2);
                pFk_zlxm.Direction = ParameterDirection.Input;
                pFk_zlxm.Value = mz_yzParam.Fk_zlxm;
                sqlparams.Add(pFk_zlxm);

            }
                        
            if (null != mz_yzParam.Xmbh &&  ""!= mz_yzParam.Xmbh)
            {
                this.isComma(sql);
                sql.Append(" XMBH=:xmbh ");
                OracleParameter pXmbh = new OracleParameter(":xmbh", OracleDbType.NVarchar2);
                pXmbh.Direction = ParameterDirection.Input;
                pXmbh.Value = mz_yzParam.Xmbh;
                sqlparams.Add(pXmbh);

            }
                        
            if (null != mz_yzParam.Xmmc &&  ""!= mz_yzParam.Xmmc)
            {
                this.isComma(sql);
                sql.Append(" XMMC=:xmmc ");
                OracleParameter pXmmc = new OracleParameter(":xmmc", OracleDbType.NVarchar2);
                pXmmc.Direction = ParameterDirection.Input;
                pXmmc.Value = mz_yzParam.Xmmc;
                sqlparams.Add(pXmmc);

            }
                        
            if (null != mz_yzParam.Xdw &&  ""!= mz_yzParam.Xdw)
            {
                this.isComma(sql);
                sql.Append(" XDW=:xdw ");
                OracleParameter pXdw = new OracleParameter(":xdw", OracleDbType.NVarchar2);
                pXdw.Direction = ParameterDirection.Input;
                pXdw.Value = mz_yzParam.Xdw;
                sqlparams.Add(pXdw);

            }
                        
            if (null != mz_yzParam.Gg &&  ""!= mz_yzParam.Gg)
            {
                this.isComma(sql);
                sql.Append(" GG=:gg ");
                OracleParameter pGg = new OracleParameter(":gg", OracleDbType.NVarchar2);
                pGg.Direction = ParameterDirection.Input;
                pGg.Value = mz_yzParam.Gg;
                sqlparams.Add(pGg);

            }
                        
            if (null != mz_yzParam.Jx &&  ""!= mz_yzParam.Jx)
            {
                this.isComma(sql);
                sql.Append(" JX=:jx ");
                OracleParameter pJx = new OracleParameter(":jx", OracleDbType.NVarchar2);
                pJx.Direction = ParameterDirection.Input;
                pJx.Value = mz_yzParam.Jx;
                sqlparams.Add(pJx);

            }
                        
            if (null != mz_yzParam.Sl)
            {
                this.isComma(sql);
                sql.Append(" SL=:sl ");
                OracleParameter pSl = new OracleParameter(":sl", OracleDbType.Decimal);
                pSl.Direction = ParameterDirection.Input;
                pSl.Value = mz_yzParam.Sl;
                sqlparams.Add(pSl);

            }
                        
            if (null != mz_yzParam.Yytj &&  ""!= mz_yzParam.Yytj)
            {
                this.isComma(sql);
                sql.Append(" YYTJ=:yytj ");
                OracleParameter pYytj = new OracleParameter(":yytj", OracleDbType.NVarchar2);
                pYytj.Direction = ParameterDirection.Input;
                pYytj.Value = mz_yzParam.Yytj;
                sqlparams.Add(pYytj);

            }
                        
            if (null != mz_yzParam.Yypl_code &&  ""!= mz_yzParam.Yypl_code)
            {
                this.isComma(sql);
                sql.Append(" YYPL_CODE=:yypl_code ");
                OracleParameter pYypl_code = new OracleParameter(":yypl_code", OracleDbType.NVarchar2);
                pYypl_code.Direction = ParameterDirection.Input;
                pYypl_code.Value = mz_yzParam.Yypl_code;
                sqlparams.Add(pYypl_code);

            }
                        
            if (null != mz_yzParam.Dcyl)
            {
                this.isComma(sql);
                sql.Append(" DCYL=:dcyl ");
                OracleParameter pDcyl = new OracleParameter(":dcyl", OracleDbType.Decimal);
                pDcyl.Direction = ParameterDirection.Input;
                pDcyl.Value = mz_yzParam.Dcyl;
                sqlparams.Add(pDcyl);

            }
                        
            if (null != mz_yzParam.Dcyldw &&  ""!= mz_yzParam.Dcyldw)
            {
                this.isComma(sql);
                sql.Append(" DCYLDW=:dcyldw ");
                OracleParameter pDcyldw = new OracleParameter(":dcyldw", OracleDbType.NVarchar2);
                pDcyldw.Direction = ParameterDirection.Input;
                pDcyldw.Value = mz_yzParam.Dcyldw;
                sqlparams.Add(pDcyldw);

            }
                        
            if (null != mz_yzParam.Ts)
            {
                this.isComma(sql);
                sql.Append(" TS=:ts ");
                OracleParameter pTs = new OracleParameter(":ts", OracleDbType.Decimal);
                pTs.Direction = ParameterDirection.Input;
                pTs.Value = mz_yzParam.Ts;
                sqlparams.Add(pTs);

            }
                        
            if (null != mz_yzParam.Yypl &&  ""!= mz_yzParam.Yypl)
            {
                this.isComma(sql);
                sql.Append(" YYPL=:yypl ");
                OracleParameter pYypl = new OracleParameter(":yypl", OracleDbType.NVarchar2);
                pYypl.Direction = ParameterDirection.Input;
                pYypl.Value = mz_yzParam.Yypl;
                sqlparams.Add(pYypl);

            }
                        
            if (null != mz_yzParam.Fk_gh_id &&  ""!= mz_yzParam.Fk_gh_id)
            {
                this.isComma(sql);
                sql.Append(" FK_GH_ID=:fk_gh_id ");
                OracleParameter pFk_gh_id = new OracleParameter(":fk_gh_id", OracleDbType.Varchar2);
                pFk_gh_id.Direction = ParameterDirection.Input;
                pFk_gh_id.Value = mz_yzParam.Fk_gh_id;
                sqlparams.Add(pFk_gh_id);

            }
                        
            if (null != mz_yzParam.Gh_lsh)
            {
                this.isComma(sql);
                sql.Append(" GH_LSH=:gh_lsh ");
                OracleParameter pGh_lsh = new OracleParameter(":gh_lsh", OracleDbType.Decimal);
                pGh_lsh.Direction = ParameterDirection.Input;
                pGh_lsh.Value = mz_yzParam.Gh_lsh;
                sqlparams.Add(pGh_lsh);

            }
                        
            if (null != mz_yzParam.Ds &&  ""!= mz_yzParam.Ds)
            {
                this.isComma(sql);
                sql.Append(" DS=:ds ");
                OracleParameter pDs = new OracleParameter(":ds", OracleDbType.NVarchar2);
                pDs.Direction = ParameterDirection.Input;
                pDs.Value = mz_yzParam.Ds;
                sqlparams.Add(pDs);

            }
                        
            if (null != mz_yzParam.Ph &&  ""!= mz_yzParam.Ph)
            {
                this.isComma(sql);
                sql.Append(" PH=:ph ");
                OracleParameter pPh = new OracleParameter(":ph", OracleDbType.NVarchar2);
                pPh.Direction = ParameterDirection.Input;
                pPh.Value = mz_yzParam.Ph;
                sqlparams.Add(pPh);

            }
                        
            if (null != mz_yzParam.Jj)
            {
                this.isComma(sql);
                sql.Append(" JJ=:jj ");
                OracleParameter pJj = new OracleParameter(":jj", OracleDbType.Decimal);
                pJj.Direction = ParameterDirection.Input;
                pJj.Value = mz_yzParam.Jj;
                sqlparams.Add(pJj);

            }
                        
            if (null != mz_yzParam.Lsj)
            {
                this.isComma(sql);
                sql.Append(" LSJ=:lsj ");
                OracleParameter pLsj = new OracleParameter(":lsj", OracleDbType.Decimal);
                pLsj.Direction = ParameterDirection.Input;
                pLsj.Value = mz_yzParam.Lsj;
                sqlparams.Add(pLsj);

            }
                        
            if (null != mz_yzParam.Dcyldwbl)
            {
                this.isComma(sql);
                sql.Append(" DCYLDWBL=:dcyldwbl ");
                OracleParameter pDcyldwbl = new OracleParameter(":dcyldwbl", OracleDbType.Decimal);
                pDcyldwbl.Direction = ParameterDirection.Input;
                pDcyldwbl.Value = mz_yzParam.Dcyldwbl;
                sqlparams.Add(pDcyldwbl);

            }
                        
            if (null != mz_yzParam.Fk_keshi_id &&  ""!= mz_yzParam.Fk_keshi_id)
            {
                this.isComma(sql);
                sql.Append(" FK_KESHI_ID=:fk_keshi_id ");
                OracleParameter pFk_keshi_id = new OracleParameter(":fk_keshi_id", OracleDbType.Varchar2);
                pFk_keshi_id.Direction = ParameterDirection.Input;
                pFk_keshi_id.Value = mz_yzParam.Fk_keshi_id;
                sqlparams.Add(pFk_keshi_id);

            }
                        
            if (null != mz_yzParam.Sfwc_code &&  ""!= mz_yzParam.Sfwc_code)
            {
                this.isComma(sql);
                sql.Append(" SFWC_CODE=:sfwc_code ");
                OracleParameter pSfwc_code = new OracleParameter(":sfwc_code", OracleDbType.NVarchar2);
                pSfwc_code.Direction = ParameterDirection.Input;
                pSfwc_code.Value = mz_yzParam.Sfwc_code;
                sqlparams.Add(pSfwc_code);

            }
                        
            if (null != mz_yzParam.Sfwc &&  ""!= mz_yzParam.Sfwc)
            {
                this.isComma(sql);
                sql.Append(" SFWC=:sfwc ");
                OracleParameter pSfwc = new OracleParameter(":sfwc", OracleDbType.NVarchar2);
                pSfwc.Direction = ParameterDirection.Input;
                pSfwc.Value = mz_yzParam.Sfwc;
                sqlparams.Add(pSfwc);

            }
                        
            if (null != mz_yzParam.Keshi &&  ""!= mz_yzParam.Keshi)
            {
                this.isComma(sql);
                sql.Append(" KESHI=:keshi ");
                OracleParameter pKeshi = new OracleParameter(":keshi", OracleDbType.NVarchar2);
                pKeshi.Direction = ParameterDirection.Input;
                pKeshi.Value = mz_yzParam.Keshi;
                sqlparams.Add(pKeshi);

            }
                        
            sql.Append(" WHERE ID=:id ");
            OracleParameter pId = new OracleParameter(":id", OracleDbType.Varchar2);
            pId.Value = mz_yzParam.Id;
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
        /// <param name="mz_yzParamList">要修改的Mz_yz对象集合</param>
        /// <param name="con">Oracle连接对象（为null时自动生成）</param>
        /// <returns>是否删除成功（影响的行数等于要修改的对象数量时成功）</returns>
        public bool updateByIdBatch(List<Mz_yz> mz_yzParamList, OracleConnection con)
        {


            List<string> idList = new List<string>();

            List<string> zfbzList = new List<string>();

            List<string> yznrList = new List<string>();

            List<string> yzlx_codeList = new List<string>();

            List<string> fk_ypList = new List<string>();

            List<string> fk_zlxmList = new List<string>();

            List<string> xmbhList = new List<string>();

            List<string> xmmcList = new List<string>();

            List<string> xdwList = new List<string>();

            List<string> ggList = new List<string>();

            List<string> jxList = new List<string>();

            List<decimal?> slList = new List<decimal?>();

            List<string> yytjList = new List<string>();

            List<string> yypl_codeList = new List<string>();

            List<decimal?> dcylList = new List<decimal?>();

            List<string> dcyldwList = new List<string>();

            List<decimal?> tsList = new List<decimal?>();

            List<string> yyplList = new List<string>();

            List<string> fk_gh_idList = new List<string>();

            List<decimal?> gh_lshList = new List<decimal?>();

            List<string> dsList = new List<string>();

            List<string> phList = new List<string>();

            List<decimal?> jjList = new List<decimal?>();

            List<decimal?> lsjList = new List<decimal?>();

            List<decimal?> dcyldwblList = new List<decimal?>();

            List<string> fk_keshi_idList = new List<string>();

            List<string> sfwc_codeList = new List<string>();

            List<string> sfwcList = new List<string>();

            List<string> keshiList = new List<string>();

            for (int i = 0; i < mz_yzParamList.Count; i++)
            {
                Mz_yz mz_yzParam = mz_yzParamList[i];
                if ("" == mz_yzParam.Id || null == mz_yzParam.Id)
                {
                    throw new Exception("下标为" + i + "的数据，ID不能为空，请赋值后调用；错误出自：updateByIdBatch");
                }

            idList.Add(mz_yzParam.Id);

            zfbzList.Add(mz_yzParam.Zfbz);

            yznrList.Add(mz_yzParam.Yznr);

            yzlx_codeList.Add(mz_yzParam.Yzlx_code);

            fk_ypList.Add(mz_yzParam.Fk_yp);

            fk_zlxmList.Add(mz_yzParam.Fk_zlxm);

            xmbhList.Add(mz_yzParam.Xmbh);

            xmmcList.Add(mz_yzParam.Xmmc);

            xdwList.Add(mz_yzParam.Xdw);

            ggList.Add(mz_yzParam.Gg);

            jxList.Add(mz_yzParam.Jx);

            slList.Add(mz_yzParam.Sl);

            yytjList.Add(mz_yzParam.Yytj);

            yypl_codeList.Add(mz_yzParam.Yypl_code);

            dcylList.Add(mz_yzParam.Dcyl);

            dcyldwList.Add(mz_yzParam.Dcyldw);

            tsList.Add(mz_yzParam.Ts);

            yyplList.Add(mz_yzParam.Yypl);

            fk_gh_idList.Add(mz_yzParam.Fk_gh_id);

            gh_lshList.Add(mz_yzParam.Gh_lsh);

            dsList.Add(mz_yzParam.Ds);

            phList.Add(mz_yzParam.Ph);

            jjList.Add(mz_yzParam.Jj);

            lsjList.Add(mz_yzParam.Lsj);

            dcyldwblList.Add(mz_yzParam.Dcyldwbl);

            fk_keshi_idList.Add(mz_yzParam.Fk_keshi_id);

            sfwc_codeList.Add(mz_yzParam.Sfwc_code);

            sfwcList.Add(mz_yzParam.Sfwc);

            keshiList.Add(mz_yzParam.Keshi);

            }


            
            List<OracleParameter> sqlparams = new List<OracleParameter>();

            StringBuilder sql = new StringBuilder("UPDATE MZ_YZ SET ");
            this.isComma(sql);
            sql.Append(" ZFBZ=:zfbz ");
            OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
            pZfbz.Direction = ParameterDirection.Input;
            pZfbz.Value = zfbzList.ToArray();
            sqlparams.Add(pZfbz);

            this.isComma(sql);
            sql.Append(" YZNR=:yznr ");
            OracleParameter pYznr = new OracleParameter(":yznr", OracleDbType.NVarchar2);
            pYznr.Direction = ParameterDirection.Input;
            pYznr.Value = yznrList.ToArray();
            sqlparams.Add(pYznr);

            this.isComma(sql);
            sql.Append(" YZLX_CODE=:yzlx_code ");
            OracleParameter pYzlx_code = new OracleParameter(":yzlx_code", OracleDbType.NVarchar2);
            pYzlx_code.Direction = ParameterDirection.Input;
            pYzlx_code.Value = yzlx_codeList.ToArray();
            sqlparams.Add(pYzlx_code);

            this.isComma(sql);
            sql.Append(" FK_YP=:fk_yp ");
            OracleParameter pFk_yp = new OracleParameter(":fk_yp", OracleDbType.Varchar2);
            pFk_yp.Direction = ParameterDirection.Input;
            pFk_yp.Value = fk_ypList.ToArray();
            sqlparams.Add(pFk_yp);

            this.isComma(sql);
            sql.Append(" FK_ZLXM=:fk_zlxm ");
            OracleParameter pFk_zlxm = new OracleParameter(":fk_zlxm", OracleDbType.Varchar2);
            pFk_zlxm.Direction = ParameterDirection.Input;
            pFk_zlxm.Value = fk_zlxmList.ToArray();
            sqlparams.Add(pFk_zlxm);

            this.isComma(sql);
            sql.Append(" XMBH=:xmbh ");
            OracleParameter pXmbh = new OracleParameter(":xmbh", OracleDbType.NVarchar2);
            pXmbh.Direction = ParameterDirection.Input;
            pXmbh.Value = xmbhList.ToArray();
            sqlparams.Add(pXmbh);

            this.isComma(sql);
            sql.Append(" XMMC=:xmmc ");
            OracleParameter pXmmc = new OracleParameter(":xmmc", OracleDbType.NVarchar2);
            pXmmc.Direction = ParameterDirection.Input;
            pXmmc.Value = xmmcList.ToArray();
            sqlparams.Add(pXmmc);

            this.isComma(sql);
            sql.Append(" XDW=:xdw ");
            OracleParameter pXdw = new OracleParameter(":xdw", OracleDbType.NVarchar2);
            pXdw.Direction = ParameterDirection.Input;
            pXdw.Value = xdwList.ToArray();
            sqlparams.Add(pXdw);

            this.isComma(sql);
            sql.Append(" GG=:gg ");
            OracleParameter pGg = new OracleParameter(":gg", OracleDbType.NVarchar2);
            pGg.Direction = ParameterDirection.Input;
            pGg.Value = ggList.ToArray();
            sqlparams.Add(pGg);

            this.isComma(sql);
            sql.Append(" JX=:jx ");
            OracleParameter pJx = new OracleParameter(":jx", OracleDbType.NVarchar2);
            pJx.Direction = ParameterDirection.Input;
            pJx.Value = jxList.ToArray();
            sqlparams.Add(pJx);

            this.isComma(sql);
            sql.Append(" SL=:sl ");
            OracleParameter pSl = new OracleParameter(":sl", OracleDbType.Decimal);
            pSl.Direction = ParameterDirection.Input;
            pSl.Value = slList.ToArray();
            sqlparams.Add(pSl);

            this.isComma(sql);
            sql.Append(" YYTJ=:yytj ");
            OracleParameter pYytj = new OracleParameter(":yytj", OracleDbType.NVarchar2);
            pYytj.Direction = ParameterDirection.Input;
            pYytj.Value = yytjList.ToArray();
            sqlparams.Add(pYytj);

            this.isComma(sql);
            sql.Append(" YYPL_CODE=:yypl_code ");
            OracleParameter pYypl_code = new OracleParameter(":yypl_code", OracleDbType.NVarchar2);
            pYypl_code.Direction = ParameterDirection.Input;
            pYypl_code.Value = yypl_codeList.ToArray();
            sqlparams.Add(pYypl_code);

            this.isComma(sql);
            sql.Append(" DCYL=:dcyl ");
            OracleParameter pDcyl = new OracleParameter(":dcyl", OracleDbType.Decimal);
            pDcyl.Direction = ParameterDirection.Input;
            pDcyl.Value = dcylList.ToArray();
            sqlparams.Add(pDcyl);

            this.isComma(sql);
            sql.Append(" DCYLDW=:dcyldw ");
            OracleParameter pDcyldw = new OracleParameter(":dcyldw", OracleDbType.NVarchar2);
            pDcyldw.Direction = ParameterDirection.Input;
            pDcyldw.Value = dcyldwList.ToArray();
            sqlparams.Add(pDcyldw);

            this.isComma(sql);
            sql.Append(" TS=:ts ");
            OracleParameter pTs = new OracleParameter(":ts", OracleDbType.Decimal);
            pTs.Direction = ParameterDirection.Input;
            pTs.Value = tsList.ToArray();
            sqlparams.Add(pTs);

            this.isComma(sql);
            sql.Append(" YYPL=:yypl ");
            OracleParameter pYypl = new OracleParameter(":yypl", OracleDbType.NVarchar2);
            pYypl.Direction = ParameterDirection.Input;
            pYypl.Value = yyplList.ToArray();
            sqlparams.Add(pYypl);

            this.isComma(sql);
            sql.Append(" FK_GH_ID=:fk_gh_id ");
            OracleParameter pFk_gh_id = new OracleParameter(":fk_gh_id", OracleDbType.Varchar2);
            pFk_gh_id.Direction = ParameterDirection.Input;
            pFk_gh_id.Value = fk_gh_idList.ToArray();
            sqlparams.Add(pFk_gh_id);

            this.isComma(sql);
            sql.Append(" GH_LSH=:gh_lsh ");
            OracleParameter pGh_lsh = new OracleParameter(":gh_lsh", OracleDbType.Decimal);
            pGh_lsh.Direction = ParameterDirection.Input;
            pGh_lsh.Value = gh_lshList.ToArray();
            sqlparams.Add(pGh_lsh);

            this.isComma(sql);
            sql.Append(" DS=:ds ");
            OracleParameter pDs = new OracleParameter(":ds", OracleDbType.NVarchar2);
            pDs.Direction = ParameterDirection.Input;
            pDs.Value = dsList.ToArray();
            sqlparams.Add(pDs);

            this.isComma(sql);
            sql.Append(" PH=:ph ");
            OracleParameter pPh = new OracleParameter(":ph", OracleDbType.NVarchar2);
            pPh.Direction = ParameterDirection.Input;
            pPh.Value = phList.ToArray();
            sqlparams.Add(pPh);

            this.isComma(sql);
            sql.Append(" JJ=:jj ");
            OracleParameter pJj = new OracleParameter(":jj", OracleDbType.Decimal);
            pJj.Direction = ParameterDirection.Input;
            pJj.Value = jjList.ToArray();
            sqlparams.Add(pJj);

            this.isComma(sql);
            sql.Append(" LSJ=:lsj ");
            OracleParameter pLsj = new OracleParameter(":lsj", OracleDbType.Decimal);
            pLsj.Direction = ParameterDirection.Input;
            pLsj.Value = lsjList.ToArray();
            sqlparams.Add(pLsj);

            this.isComma(sql);
            sql.Append(" DCYLDWBL=:dcyldwbl ");
            OracleParameter pDcyldwbl = new OracleParameter(":dcyldwbl", OracleDbType.Decimal);
            pDcyldwbl.Direction = ParameterDirection.Input;
            pDcyldwbl.Value = dcyldwblList.ToArray();
            sqlparams.Add(pDcyldwbl);

            this.isComma(sql);
            sql.Append(" FK_KESHI_ID=:fk_keshi_id ");
            OracleParameter pFk_keshi_id = new OracleParameter(":fk_keshi_id", OracleDbType.Varchar2);
            pFk_keshi_id.Direction = ParameterDirection.Input;
            pFk_keshi_id.Value = fk_keshi_idList.ToArray();
            sqlparams.Add(pFk_keshi_id);

            this.isComma(sql);
            sql.Append(" SFWC_CODE=:sfwc_code ");
            OracleParameter pSfwc_code = new OracleParameter(":sfwc_code", OracleDbType.NVarchar2);
            pSfwc_code.Direction = ParameterDirection.Input;
            pSfwc_code.Value = sfwc_codeList.ToArray();
            sqlparams.Add(pSfwc_code);

            this.isComma(sql);
            sql.Append(" SFWC=:sfwc ");
            OracleParameter pSfwc = new OracleParameter(":sfwc", OracleDbType.NVarchar2);
            pSfwc.Direction = ParameterDirection.Input;
            pSfwc.Value = sfwcList.ToArray();
            sqlparams.Add(pSfwc);

            this.isComma(sql);
            sql.Append(" KESHI=:keshi ");
            OracleParameter pKeshi = new OracleParameter(":keshi", OracleDbType.NVarchar2);
            pKeshi.Direction = ParameterDirection.Input;
            pKeshi.Value = keshiList.ToArray();
            sqlparams.Add(pKeshi);

            sql.Append(" WHERE ID=:id ");
            OracleParameter pId = new OracleParameter(":id", OracleDbType.Varchar2);
            pId.Value = idList.ToArray();
            sqlparams.Add(pId);
            this.b_isComma = false;
            bool result = false;
            int flag = OracleHelper.ExecuteBatch(sql.ToString(), con,mz_yzParamList.Count, sqlparams.ToArray());
            if (mz_yzParamList.Count == flag)
            {
                result = true;
            }
            return result;
        }

        /// <summary>
        /// 根据更新的条件，更新数据（如果需要供事务使用就传入OracleConnection对象，如果不供就传入null，方法自动生成OracleConnection对象）
        /// 不指定ID，如果要根据ID来更新数据，请使用updateForId方法
        /// </summary>
        /// <param name="mz_yzParamCondition">条件对象</param>
        /// <param name="mz_yzParamUpdate">要更新的数据对象</param>
        /// <param name="con">Oracle连接对象（为null时自动生成）</param>
        /// <returns>影响的行数不确定（不为-1就正确）</returns>
        public bool updateByOtherCondition(Mz_yz mz_yzParamCondition, Mz_yz mz_yzParamUpdate, OracleConnection con)
        {
            if ((null!=mz_yzParamCondition.Id&&"!=mz_yzParamCondition.Id)||(null!=mz_yzParamUpdate.Id&&"!=mz_yzParamUpdate.Id))
            {
                throw new Exception("此方法不允许指定参数的ID，数据库中的ID不允许修改，如需根据ID修改数据，请调用updateById或updateByIdBatch方法；错误出自：updateByOtherCondition");
            }
            List<OracleParameter> sqlparams = new List<OracleParameter>();
            //添加要修改的值
            StringBuilder sql = new StringBuilder("UPDATE MZ_YZ SET ");
            if (null != mz_yzParamUpdate.Zfbz &&  ""!= mz_yzParamUpdate.Zfbz)
            {
                this.isComma(sql);
                sql.Append(" ZFBZ=:zfbz ");
                OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                pZfbz.Direction = ParameterDirection.Input;
                pZfbz.Value = mz_yzParamUpdate.Zfbz;
                sqlparams.Add(pZfbz);

            }
                        
            if (null != mz_yzParamUpdate.Yznr &&  ""!= mz_yzParamUpdate.Yznr)
            {
                this.isComma(sql);
                sql.Append(" YZNR=:yznr ");
                OracleParameter pYznr = new OracleParameter(":yznr", OracleDbType.NVarchar2);
                pYznr.Direction = ParameterDirection.Input;
                pYznr.Value = mz_yzParamUpdate.Yznr;
                sqlparams.Add(pYznr);

            }
                        
            if (null != mz_yzParamUpdate.Yzlx_code &&  ""!= mz_yzParamUpdate.Yzlx_code)
            {
                this.isComma(sql);
                sql.Append(" YZLX_CODE=:yzlx_code ");
                OracleParameter pYzlx_code = new OracleParameter(":yzlx_code", OracleDbType.NVarchar2);
                pYzlx_code.Direction = ParameterDirection.Input;
                pYzlx_code.Value = mz_yzParamUpdate.Yzlx_code;
                sqlparams.Add(pYzlx_code);

            }
                        
            if (null != mz_yzParamUpdate.Fk_yp &&  ""!= mz_yzParamUpdate.Fk_yp)
            {
                this.isComma(sql);
                sql.Append(" FK_YP=:fk_yp ");
                OracleParameter pFk_yp = new OracleParameter(":fk_yp", OracleDbType.Varchar2);
                pFk_yp.Direction = ParameterDirection.Input;
                pFk_yp.Value = mz_yzParamUpdate.Fk_yp;
                sqlparams.Add(pFk_yp);

            }
                        
            if (null != mz_yzParamUpdate.Fk_zlxm &&  ""!= mz_yzParamUpdate.Fk_zlxm)
            {
                this.isComma(sql);
                sql.Append(" FK_ZLXM=:fk_zlxm ");
                OracleParameter pFk_zlxm = new OracleParameter(":fk_zlxm", OracleDbType.Varchar2);
                pFk_zlxm.Direction = ParameterDirection.Input;
                pFk_zlxm.Value = mz_yzParamUpdate.Fk_zlxm;
                sqlparams.Add(pFk_zlxm);

            }
                        
            if (null != mz_yzParamUpdate.Xmbh &&  ""!= mz_yzParamUpdate.Xmbh)
            {
                this.isComma(sql);
                sql.Append(" XMBH=:xmbh ");
                OracleParameter pXmbh = new OracleParameter(":xmbh", OracleDbType.NVarchar2);
                pXmbh.Direction = ParameterDirection.Input;
                pXmbh.Value = mz_yzParamUpdate.Xmbh;
                sqlparams.Add(pXmbh);

            }
                        
            if (null != mz_yzParamUpdate.Xmmc &&  ""!= mz_yzParamUpdate.Xmmc)
            {
                this.isComma(sql);
                sql.Append(" XMMC=:xmmc ");
                OracleParameter pXmmc = new OracleParameter(":xmmc", OracleDbType.NVarchar2);
                pXmmc.Direction = ParameterDirection.Input;
                pXmmc.Value = mz_yzParamUpdate.Xmmc;
                sqlparams.Add(pXmmc);

            }
                        
            if (null != mz_yzParamUpdate.Xdw &&  ""!= mz_yzParamUpdate.Xdw)
            {
                this.isComma(sql);
                sql.Append(" XDW=:xdw ");
                OracleParameter pXdw = new OracleParameter(":xdw", OracleDbType.NVarchar2);
                pXdw.Direction = ParameterDirection.Input;
                pXdw.Value = mz_yzParamUpdate.Xdw;
                sqlparams.Add(pXdw);

            }
                        
            if (null != mz_yzParamUpdate.Gg &&  ""!= mz_yzParamUpdate.Gg)
            {
                this.isComma(sql);
                sql.Append(" GG=:gg ");
                OracleParameter pGg = new OracleParameter(":gg", OracleDbType.NVarchar2);
                pGg.Direction = ParameterDirection.Input;
                pGg.Value = mz_yzParamUpdate.Gg;
                sqlparams.Add(pGg);

            }
                        
            if (null != mz_yzParamUpdate.Jx &&  ""!= mz_yzParamUpdate.Jx)
            {
                this.isComma(sql);
                sql.Append(" JX=:jx ");
                OracleParameter pJx = new OracleParameter(":jx", OracleDbType.NVarchar2);
                pJx.Direction = ParameterDirection.Input;
                pJx.Value = mz_yzParamUpdate.Jx;
                sqlparams.Add(pJx);

            }
                        
            if (null != mz_yzParamUpdate.Sl)
            {
                this.isComma(sql);
                sql.Append(" SL=:sl ");
                OracleParameter pSl = new OracleParameter(":sl", OracleDbType.Decimal);
                pSl.Direction = ParameterDirection.Input;
                pSl.Value = mz_yzParamUpdate.Sl;
                sqlparams.Add(pSl);

            }
                        
            if (null != mz_yzParamUpdate.Yytj &&  ""!= mz_yzParamUpdate.Yytj)
            {
                this.isComma(sql);
                sql.Append(" YYTJ=:yytj ");
                OracleParameter pYytj = new OracleParameter(":yytj", OracleDbType.NVarchar2);
                pYytj.Direction = ParameterDirection.Input;
                pYytj.Value = mz_yzParamUpdate.Yytj;
                sqlparams.Add(pYytj);

            }
                        
            if (null != mz_yzParamUpdate.Yypl_code &&  ""!= mz_yzParamUpdate.Yypl_code)
            {
                this.isComma(sql);
                sql.Append(" YYPL_CODE=:yypl_code ");
                OracleParameter pYypl_code = new OracleParameter(":yypl_code", OracleDbType.NVarchar2);
                pYypl_code.Direction = ParameterDirection.Input;
                pYypl_code.Value = mz_yzParamUpdate.Yypl_code;
                sqlparams.Add(pYypl_code);

            }
                        
            if (null != mz_yzParamUpdate.Dcyl)
            {
                this.isComma(sql);
                sql.Append(" DCYL=:dcyl ");
                OracleParameter pDcyl = new OracleParameter(":dcyl", OracleDbType.Decimal);
                pDcyl.Direction = ParameterDirection.Input;
                pDcyl.Value = mz_yzParamUpdate.Dcyl;
                sqlparams.Add(pDcyl);

            }
                        
            if (null != mz_yzParamUpdate.Dcyldw &&  ""!= mz_yzParamUpdate.Dcyldw)
            {
                this.isComma(sql);
                sql.Append(" DCYLDW=:dcyldw ");
                OracleParameter pDcyldw = new OracleParameter(":dcyldw", OracleDbType.NVarchar2);
                pDcyldw.Direction = ParameterDirection.Input;
                pDcyldw.Value = mz_yzParamUpdate.Dcyldw;
                sqlparams.Add(pDcyldw);

            }
                        
            if (null != mz_yzParamUpdate.Ts)
            {
                this.isComma(sql);
                sql.Append(" TS=:ts ");
                OracleParameter pTs = new OracleParameter(":ts", OracleDbType.Decimal);
                pTs.Direction = ParameterDirection.Input;
                pTs.Value = mz_yzParamUpdate.Ts;
                sqlparams.Add(pTs);

            }
                        
            if (null != mz_yzParamUpdate.Yypl &&  ""!= mz_yzParamUpdate.Yypl)
            {
                this.isComma(sql);
                sql.Append(" YYPL=:yypl ");
                OracleParameter pYypl = new OracleParameter(":yypl", OracleDbType.NVarchar2);
                pYypl.Direction = ParameterDirection.Input;
                pYypl.Value = mz_yzParamUpdate.Yypl;
                sqlparams.Add(pYypl);

            }
                        
            if (null != mz_yzParamUpdate.Fk_gh_id &&  ""!= mz_yzParamUpdate.Fk_gh_id)
            {
                this.isComma(sql);
                sql.Append(" FK_GH_ID=:fk_gh_id ");
                OracleParameter pFk_gh_id = new OracleParameter(":fk_gh_id", OracleDbType.Varchar2);
                pFk_gh_id.Direction = ParameterDirection.Input;
                pFk_gh_id.Value = mz_yzParamUpdate.Fk_gh_id;
                sqlparams.Add(pFk_gh_id);

            }
                        
            if (null != mz_yzParamUpdate.Gh_lsh)
            {
                this.isComma(sql);
                sql.Append(" GH_LSH=:gh_lsh ");
                OracleParameter pGh_lsh = new OracleParameter(":gh_lsh", OracleDbType.Decimal);
                pGh_lsh.Direction = ParameterDirection.Input;
                pGh_lsh.Value = mz_yzParamUpdate.Gh_lsh;
                sqlparams.Add(pGh_lsh);

            }
                        
            if (null != mz_yzParamUpdate.Ds &&  ""!= mz_yzParamUpdate.Ds)
            {
                this.isComma(sql);
                sql.Append(" DS=:ds ");
                OracleParameter pDs = new OracleParameter(":ds", OracleDbType.NVarchar2);
                pDs.Direction = ParameterDirection.Input;
                pDs.Value = mz_yzParamUpdate.Ds;
                sqlparams.Add(pDs);

            }
                        
            if (null != mz_yzParamUpdate.Ph &&  ""!= mz_yzParamUpdate.Ph)
            {
                this.isComma(sql);
                sql.Append(" PH=:ph ");
                OracleParameter pPh = new OracleParameter(":ph", OracleDbType.NVarchar2);
                pPh.Direction = ParameterDirection.Input;
                pPh.Value = mz_yzParamUpdate.Ph;
                sqlparams.Add(pPh);

            }
                        
            if (null != mz_yzParamUpdate.Jj)
            {
                this.isComma(sql);
                sql.Append(" JJ=:jj ");
                OracleParameter pJj = new OracleParameter(":jj", OracleDbType.Decimal);
                pJj.Direction = ParameterDirection.Input;
                pJj.Value = mz_yzParamUpdate.Jj;
                sqlparams.Add(pJj);

            }
                        
            if (null != mz_yzParamUpdate.Lsj)
            {
                this.isComma(sql);
                sql.Append(" LSJ=:lsj ");
                OracleParameter pLsj = new OracleParameter(":lsj", OracleDbType.Decimal);
                pLsj.Direction = ParameterDirection.Input;
                pLsj.Value = mz_yzParamUpdate.Lsj;
                sqlparams.Add(pLsj);

            }
                        
            if (null != mz_yzParamUpdate.Dcyldwbl)
            {
                this.isComma(sql);
                sql.Append(" DCYLDWBL=:dcyldwbl ");
                OracleParameter pDcyldwbl = new OracleParameter(":dcyldwbl", OracleDbType.Decimal);
                pDcyldwbl.Direction = ParameterDirection.Input;
                pDcyldwbl.Value = mz_yzParamUpdate.Dcyldwbl;
                sqlparams.Add(pDcyldwbl);

            }
                        
            if (null != mz_yzParamUpdate.Fk_keshi_id &&  ""!= mz_yzParamUpdate.Fk_keshi_id)
            {
                this.isComma(sql);
                sql.Append(" FK_KESHI_ID=:fk_keshi_id ");
                OracleParameter pFk_keshi_id = new OracleParameter(":fk_keshi_id", OracleDbType.Varchar2);
                pFk_keshi_id.Direction = ParameterDirection.Input;
                pFk_keshi_id.Value = mz_yzParamUpdate.Fk_keshi_id;
                sqlparams.Add(pFk_keshi_id);

            }
                        
            if (null != mz_yzParamUpdate.Sfwc_code &&  ""!= mz_yzParamUpdate.Sfwc_code)
            {
                this.isComma(sql);
                sql.Append(" SFWC_CODE=:sfwc_code ");
                OracleParameter pSfwc_code = new OracleParameter(":sfwc_code", OracleDbType.NVarchar2);
                pSfwc_code.Direction = ParameterDirection.Input;
                pSfwc_code.Value = mz_yzParamUpdate.Sfwc_code;
                sqlparams.Add(pSfwc_code);

            }
                        
            if (null != mz_yzParamUpdate.Sfwc &&  ""!= mz_yzParamUpdate.Sfwc)
            {
                this.isComma(sql);
                sql.Append(" SFWC=:sfwc ");
                OracleParameter pSfwc = new OracleParameter(":sfwc", OracleDbType.NVarchar2);
                pSfwc.Direction = ParameterDirection.Input;
                pSfwc.Value = mz_yzParamUpdate.Sfwc;
                sqlparams.Add(pSfwc);

            }
                        
            if (null != mz_yzParamUpdate.Keshi &&  ""!= mz_yzParamUpdate.Keshi)
            {
                this.isComma(sql);
                sql.Append(" KESHI=:keshi ");
                OracleParameter pKeshi = new OracleParameter(":keshi", OracleDbType.NVarchar2);
                pKeshi.Direction = ParameterDirection.Input;
                pKeshi.Value = mz_yzParamUpdate.Keshi;
                sqlparams.Add(pKeshi);

            }
                        
            //添加条件的参数
            
            if (null != mz_yzParamCondition.Zfbz &&  ""!= mz_yzParamCondition.Zfbz)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" ZFBZ=:zfbz ");
                OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                pZfbz.Direction = ParameterDirection.Input;
                pZfbz.Value = mz_yzParamCondition.Zfbz;
                sqlparams.Add(pZfbz);

            }
                        
            if (null != mz_yzParamCondition.Yznr &&  ""!= mz_yzParamCondition.Yznr)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" YZNR=:yznr ");
                OracleParameter pYznr = new OracleParameter(":yznr", OracleDbType.NVarchar2);
                pYznr.Direction = ParameterDirection.Input;
                pYznr.Value = mz_yzParamCondition.Yznr;
                sqlparams.Add(pYznr);

            }
                        
            if (null != mz_yzParamCondition.Yzlx_code &&  ""!= mz_yzParamCondition.Yzlx_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" YZLX_CODE=:yzlx_code ");
                OracleParameter pYzlx_code = new OracleParameter(":yzlx_code", OracleDbType.NVarchar2);
                pYzlx_code.Direction = ParameterDirection.Input;
                pYzlx_code.Value = mz_yzParamCondition.Yzlx_code;
                sqlparams.Add(pYzlx_code);

            }
                        
            if (null != mz_yzParamCondition.Fk_yp &&  ""!= mz_yzParamCondition.Fk_yp)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" FK_YP=:fk_yp ");
                OracleParameter pFk_yp = new OracleParameter(":fk_yp", OracleDbType.Varchar2);
                pFk_yp.Direction = ParameterDirection.Input;
                pFk_yp.Value = mz_yzParamCondition.Fk_yp;
                sqlparams.Add(pFk_yp);

            }
                        
            if (null != mz_yzParamCondition.Fk_zlxm &&  ""!= mz_yzParamCondition.Fk_zlxm)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" FK_ZLXM=:fk_zlxm ");
                OracleParameter pFk_zlxm = new OracleParameter(":fk_zlxm", OracleDbType.Varchar2);
                pFk_zlxm.Direction = ParameterDirection.Input;
                pFk_zlxm.Value = mz_yzParamCondition.Fk_zlxm;
                sqlparams.Add(pFk_zlxm);

            }
                        
            if (null != mz_yzParamCondition.Xmbh &&  ""!= mz_yzParamCondition.Xmbh)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" XMBH=:xmbh ");
                OracleParameter pXmbh = new OracleParameter(":xmbh", OracleDbType.NVarchar2);
                pXmbh.Direction = ParameterDirection.Input;
                pXmbh.Value = mz_yzParamCondition.Xmbh;
                sqlparams.Add(pXmbh);

            }
                        
            if (null != mz_yzParamCondition.Xmmc &&  ""!= mz_yzParamCondition.Xmmc)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" XMMC=:xmmc ");
                OracleParameter pXmmc = new OracleParameter(":xmmc", OracleDbType.NVarchar2);
                pXmmc.Direction = ParameterDirection.Input;
                pXmmc.Value = mz_yzParamCondition.Xmmc;
                sqlparams.Add(pXmmc);

            }
                        
            if (null != mz_yzParamCondition.Xdw &&  ""!= mz_yzParamCondition.Xdw)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" XDW=:xdw ");
                OracleParameter pXdw = new OracleParameter(":xdw", OracleDbType.NVarchar2);
                pXdw.Direction = ParameterDirection.Input;
                pXdw.Value = mz_yzParamCondition.Xdw;
                sqlparams.Add(pXdw);

            }
                        
            if (null != mz_yzParamCondition.Gg &&  ""!= mz_yzParamCondition.Gg)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" GG=:gg ");
                OracleParameter pGg = new OracleParameter(":gg", OracleDbType.NVarchar2);
                pGg.Direction = ParameterDirection.Input;
                pGg.Value = mz_yzParamCondition.Gg;
                sqlparams.Add(pGg);

            }
                        
            if (null != mz_yzParamCondition.Jx &&  ""!= mz_yzParamCondition.Jx)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" JX=:jx ");
                OracleParameter pJx = new OracleParameter(":jx", OracleDbType.NVarchar2);
                pJx.Direction = ParameterDirection.Input;
                pJx.Value = mz_yzParamCondition.Jx;
                sqlparams.Add(pJx);

            }
                        
            if (null != mz_yzParamCondition.Sl)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" SL=:sl ");
                OracleParameter pSl = new OracleParameter(":sl", OracleDbType.Decimal);
                pSl.Direction = ParameterDirection.Input;
                pSl.Value = mz_yzParamCondition.Sl;
                sqlparams.Add(pSl);

            }
                        
            if (null != mz_yzParamCondition.Yytj &&  ""!= mz_yzParamCondition.Yytj)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" YYTJ=:yytj ");
                OracleParameter pYytj = new OracleParameter(":yytj", OracleDbType.NVarchar2);
                pYytj.Direction = ParameterDirection.Input;
                pYytj.Value = mz_yzParamCondition.Yytj;
                sqlparams.Add(pYytj);

            }
                        
            if (null != mz_yzParamCondition.Yypl_code &&  ""!= mz_yzParamCondition.Yypl_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" YYPL_CODE=:yypl_code ");
                OracleParameter pYypl_code = new OracleParameter(":yypl_code", OracleDbType.NVarchar2);
                pYypl_code.Direction = ParameterDirection.Input;
                pYypl_code.Value = mz_yzParamCondition.Yypl_code;
                sqlparams.Add(pYypl_code);

            }
                        
            if (null != mz_yzParamCondition.Dcyl)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" DCYL=:dcyl ");
                OracleParameter pDcyl = new OracleParameter(":dcyl", OracleDbType.Decimal);
                pDcyl.Direction = ParameterDirection.Input;
                pDcyl.Value = mz_yzParamCondition.Dcyl;
                sqlparams.Add(pDcyl);

            }
                        
            if (null != mz_yzParamCondition.Dcyldw &&  ""!= mz_yzParamCondition.Dcyldw)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" DCYLDW=:dcyldw ");
                OracleParameter pDcyldw = new OracleParameter(":dcyldw", OracleDbType.NVarchar2);
                pDcyldw.Direction = ParameterDirection.Input;
                pDcyldw.Value = mz_yzParamCondition.Dcyldw;
                sqlparams.Add(pDcyldw);

            }
                        
            if (null != mz_yzParamCondition.Ts)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" TS=:ts ");
                OracleParameter pTs = new OracleParameter(":ts", OracleDbType.Decimal);
                pTs.Direction = ParameterDirection.Input;
                pTs.Value = mz_yzParamCondition.Ts;
                sqlparams.Add(pTs);

            }
                        
            if (null != mz_yzParamCondition.Yypl &&  ""!= mz_yzParamCondition.Yypl)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" YYPL=:yypl ");
                OracleParameter pYypl = new OracleParameter(":yypl", OracleDbType.NVarchar2);
                pYypl.Direction = ParameterDirection.Input;
                pYypl.Value = mz_yzParamCondition.Yypl;
                sqlparams.Add(pYypl);

            }
                        
            if (null != mz_yzParamCondition.Fk_gh_id &&  ""!= mz_yzParamCondition.Fk_gh_id)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" FK_GH_ID=:fk_gh_id ");
                OracleParameter pFk_gh_id = new OracleParameter(":fk_gh_id", OracleDbType.Varchar2);
                pFk_gh_id.Direction = ParameterDirection.Input;
                pFk_gh_id.Value = mz_yzParamCondition.Fk_gh_id;
                sqlparams.Add(pFk_gh_id);

            }
                        
            if (null != mz_yzParamCondition.Gh_lsh)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" GH_LSH=:gh_lsh ");
                OracleParameter pGh_lsh = new OracleParameter(":gh_lsh", OracleDbType.Decimal);
                pGh_lsh.Direction = ParameterDirection.Input;
                pGh_lsh.Value = mz_yzParamCondition.Gh_lsh;
                sqlparams.Add(pGh_lsh);

            }
                        
            if (null != mz_yzParamCondition.Ds &&  ""!= mz_yzParamCondition.Ds)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" DS=:ds ");
                OracleParameter pDs = new OracleParameter(":ds", OracleDbType.NVarchar2);
                pDs.Direction = ParameterDirection.Input;
                pDs.Value = mz_yzParamCondition.Ds;
                sqlparams.Add(pDs);

            }
                        
            if (null != mz_yzParamCondition.Ph &&  ""!= mz_yzParamCondition.Ph)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" PH=:ph ");
                OracleParameter pPh = new OracleParameter(":ph", OracleDbType.NVarchar2);
                pPh.Direction = ParameterDirection.Input;
                pPh.Value = mz_yzParamCondition.Ph;
                sqlparams.Add(pPh);

            }
                        
            if (null != mz_yzParamCondition.Jj)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" JJ=:jj ");
                OracleParameter pJj = new OracleParameter(":jj", OracleDbType.Decimal);
                pJj.Direction = ParameterDirection.Input;
                pJj.Value = mz_yzParamCondition.Jj;
                sqlparams.Add(pJj);

            }
                        
            if (null != mz_yzParamCondition.Lsj)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" LSJ=:lsj ");
                OracleParameter pLsj = new OracleParameter(":lsj", OracleDbType.Decimal);
                pLsj.Direction = ParameterDirection.Input;
                pLsj.Value = mz_yzParamCondition.Lsj;
                sqlparams.Add(pLsj);

            }
                        
            if (null != mz_yzParamCondition.Dcyldwbl)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" DCYLDWBL=:dcyldwbl ");
                OracleParameter pDcyldwbl = new OracleParameter(":dcyldwbl", OracleDbType.Decimal);
                pDcyldwbl.Direction = ParameterDirection.Input;
                pDcyldwbl.Value = mz_yzParamCondition.Dcyldwbl;
                sqlparams.Add(pDcyldwbl);

            }
                        
            if (null != mz_yzParamCondition.Fk_keshi_id &&  ""!= mz_yzParamCondition.Fk_keshi_id)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" FK_KESHI_ID=:fk_keshi_id ");
                OracleParameter pFk_keshi_id = new OracleParameter(":fk_keshi_id", OracleDbType.Varchar2);
                pFk_keshi_id.Direction = ParameterDirection.Input;
                pFk_keshi_id.Value = mz_yzParamCondition.Fk_keshi_id;
                sqlparams.Add(pFk_keshi_id);

            }
                        
            if (null != mz_yzParamCondition.Sfwc_code &&  ""!= mz_yzParamCondition.Sfwc_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" SFWC_CODE=:sfwc_code ");
                OracleParameter pSfwc_code = new OracleParameter(":sfwc_code", OracleDbType.NVarchar2);
                pSfwc_code.Direction = ParameterDirection.Input;
                pSfwc_code.Value = mz_yzParamCondition.Sfwc_code;
                sqlparams.Add(pSfwc_code);

            }
                        
            if (null != mz_yzParamCondition.Sfwc &&  ""!= mz_yzParamCondition.Sfwc)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" SFWC=:sfwc ");
                OracleParameter pSfwc = new OracleParameter(":sfwc", OracleDbType.NVarchar2);
                pSfwc.Direction = ParameterDirection.Input;
                pSfwc.Value = mz_yzParamCondition.Sfwc;
                sqlparams.Add(pSfwc);

            }
                        
            if (null != mz_yzParamCondition.Keshi &&  ""!= mz_yzParamCondition.Keshi)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" KESHI=:keshi ");
                OracleParameter pKeshi = new OracleParameter(":keshi", OracleDbType.NVarchar2);
                pKeshi.Direction = ParameterDirection.Input;
                pKeshi.Value = mz_yzParamCondition.Keshi;
                sqlparams.Add(pKeshi);

            }
                        
            this.b_isComma = false;
            this.b_isWhere = false;
            bool result = false;
            int flag = OracleHelper.ExecuteNonQuery(sql.ToString(), con, sqlparams.ToArray());
            if (flag>=0)
            {
                result = true;
            }

            return result;
        }




        /// <summary>
        /// 查找指定ID的用户
        /// </summary>
        /// <remarks>id为null、id重复、id未找到，抛异常</remarks>
        /// <returns>Mz_yz</returns>
        public Mz_yz findById(string id)
        {
            if (""==id||null==id)
            {
                throw new Exception("ID不能为空，请赋值后调用；错误出自：findById");
            }
            StringBuilder sql = new StringBuilder("SELECT A.* ");
            //新建方法findContactObjectsById，在此加入多表连接要显示的项start
            //sql.Append(",B.字段一,B.字段二,B.字段三");
            //新建方法，在此加入多表连接要显示的项end
            sql.Append(" FROM MZ_YZ A ");
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
        /// <param name="mz_yzParam"></param>
        /// <param name="page">分页对象</param>
        ///<param name="mz_yzParamLike">模糊查询参数</param>
        ///<param name="sortList">排序参数对象的集合</param>
        /// <returns>满足条件的所有Mz_yz对象集合list</returns>
        public List<object> find(Mz_yz mz_yzParam, Model.Common.PageInfo page,Mz_yz mz_yzParamLike,List<SortInfo> sortList)
        {

            //如果没有传查询条件参数，就new一个空的Mz_yz对象，标示查询所有数据
            if (null == mz_yzParam)
            {
                mz_yzParam = new Mz_yz();
            }
            if (null!=mz_yzParam.Id&&""!=mz_yzParam.Id)
            {
                throw new Exception("此方法不允许指定参数ID，如果需要根据ID查询数据，请调用findById方法；错误出自：find");
            }
            List<Mz_yz> mz_yzParamList = new List<Mz_yz>();//接收查询出的Mz_yz对象集合
            List<OracleParameter> sqlparams = new List<OracleParameter>();//保存参数的集合
            StringBuilder sql = new StringBuilder("SELECT A.* ");
            //新建方法findContactObjects(Mz_yz mz_yzParam, Model.Common.PageInfo page)，在此加入多表连接要显示的项start
            //sql.Append(",B.字段一,B.字段二,B.字段三");
            //新建方法，在此加入多表连接要显示的项end
            sql.Append(" FROM MZ_YZ A ");
            //新建一个方法，在此加入多表连接的语句start
            ////sql.Append(" LEFT JOIN 表名 B ON A.外键=B.ID");
            //新建一个方法，在此加入多表连接的语句end
            
            
            if (null != mz_yzParam.Zfbz && "" != mz_yzParam.Zfbz)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.ZFBZ=:zfbz ");
                OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                pZfbz.Direction = ParameterDirection.Input;
                pZfbz.Value = mz_yzParam.Zfbz;
                sqlparams.Add(pZfbz);
            }
                
            if (null != mz_yzParam.Yznr && "" != mz_yzParam.Yznr)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.YZNR=:yznr ");
                OracleParameter pYznr = new OracleParameter(":yznr", OracleDbType.NVarchar2);
                pYznr.Direction = ParameterDirection.Input;
                pYznr.Value = mz_yzParam.Yznr;
                sqlparams.Add(pYznr);
            }
                
            if (null != mz_yzParam.Yzlx_code && "" != mz_yzParam.Yzlx_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.YZLX_CODE=:yzlx_code ");
                OracleParameter pYzlx_code = new OracleParameter(":yzlx_code", OracleDbType.NVarchar2);
                pYzlx_code.Direction = ParameterDirection.Input;
                pYzlx_code.Value = mz_yzParam.Yzlx_code;
                sqlparams.Add(pYzlx_code);
            }
                
            if (null != mz_yzParam.Fk_yp && "" != mz_yzParam.Fk_yp)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.FK_YP=:fk_yp ");
                OracleParameter pFk_yp = new OracleParameter(":fk_yp", OracleDbType.Varchar2);
                pFk_yp.Direction = ParameterDirection.Input;
                pFk_yp.Value = mz_yzParam.Fk_yp;
                sqlparams.Add(pFk_yp);
            }
                
            if (null != mz_yzParam.Fk_zlxm && "" != mz_yzParam.Fk_zlxm)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.FK_ZLXM=:fk_zlxm ");
                OracleParameter pFk_zlxm = new OracleParameter(":fk_zlxm", OracleDbType.Varchar2);
                pFk_zlxm.Direction = ParameterDirection.Input;
                pFk_zlxm.Value = mz_yzParam.Fk_zlxm;
                sqlparams.Add(pFk_zlxm);
            }
                
            if (null != mz_yzParam.Xmbh && "" != mz_yzParam.Xmbh)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.XMBH=:xmbh ");
                OracleParameter pXmbh = new OracleParameter(":xmbh", OracleDbType.NVarchar2);
                pXmbh.Direction = ParameterDirection.Input;
                pXmbh.Value = mz_yzParam.Xmbh;
                sqlparams.Add(pXmbh);
            }
                
            if (null != mz_yzParam.Xmmc && "" != mz_yzParam.Xmmc)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.XMMC=:xmmc ");
                OracleParameter pXmmc = new OracleParameter(":xmmc", OracleDbType.NVarchar2);
                pXmmc.Direction = ParameterDirection.Input;
                pXmmc.Value = mz_yzParam.Xmmc;
                sqlparams.Add(pXmmc);
            }
                
            if (null != mz_yzParam.Xdw && "" != mz_yzParam.Xdw)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.XDW=:xdw ");
                OracleParameter pXdw = new OracleParameter(":xdw", OracleDbType.NVarchar2);
                pXdw.Direction = ParameterDirection.Input;
                pXdw.Value = mz_yzParam.Xdw;
                sqlparams.Add(pXdw);
            }
                
            if (null != mz_yzParam.Gg && "" != mz_yzParam.Gg)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.GG=:gg ");
                OracleParameter pGg = new OracleParameter(":gg", OracleDbType.NVarchar2);
                pGg.Direction = ParameterDirection.Input;
                pGg.Value = mz_yzParam.Gg;
                sqlparams.Add(pGg);
            }
                
            if (null != mz_yzParam.Jx && "" != mz_yzParam.Jx)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.JX=:jx ");
                OracleParameter pJx = new OracleParameter(":jx", OracleDbType.NVarchar2);
                pJx.Direction = ParameterDirection.Input;
                pJx.Value = mz_yzParam.Jx;
                sqlparams.Add(pJx);
            }
                
            if (null != mz_yzParam.Sl)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.SL=:sl ");
                OracleParameter pSl = new OracleParameter(":sl", OracleDbType.Decimal);
                pSl.Direction = ParameterDirection.Input;
                pSl.Value = mz_yzParam.Sl;
                sqlparams.Add(pSl);

            }
                        
            if (null != mz_yzParam.Yytj && "" != mz_yzParam.Yytj)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.YYTJ=:yytj ");
                OracleParameter pYytj = new OracleParameter(":yytj", OracleDbType.NVarchar2);
                pYytj.Direction = ParameterDirection.Input;
                pYytj.Value = mz_yzParam.Yytj;
                sqlparams.Add(pYytj);
            }
                
            if (null != mz_yzParam.Yypl_code && "" != mz_yzParam.Yypl_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.YYPL_CODE=:yypl_code ");
                OracleParameter pYypl_code = new OracleParameter(":yypl_code", OracleDbType.NVarchar2);
                pYypl_code.Direction = ParameterDirection.Input;
                pYypl_code.Value = mz_yzParam.Yypl_code;
                sqlparams.Add(pYypl_code);
            }
                
            if (null != mz_yzParam.Dcyl)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.DCYL=:dcyl ");
                OracleParameter pDcyl = new OracleParameter(":dcyl", OracleDbType.Decimal);
                pDcyl.Direction = ParameterDirection.Input;
                pDcyl.Value = mz_yzParam.Dcyl;
                sqlparams.Add(pDcyl);

            }
                        
            if (null != mz_yzParam.Dcyldw && "" != mz_yzParam.Dcyldw)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.DCYLDW=:dcyldw ");
                OracleParameter pDcyldw = new OracleParameter(":dcyldw", OracleDbType.NVarchar2);
                pDcyldw.Direction = ParameterDirection.Input;
                pDcyldw.Value = mz_yzParam.Dcyldw;
                sqlparams.Add(pDcyldw);
            }
                
            if (null != mz_yzParam.Ts)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.TS=:ts ");
                OracleParameter pTs = new OracleParameter(":ts", OracleDbType.Decimal);
                pTs.Direction = ParameterDirection.Input;
                pTs.Value = mz_yzParam.Ts;
                sqlparams.Add(pTs);

            }
                        
            if (null != mz_yzParam.Yypl && "" != mz_yzParam.Yypl)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.YYPL=:yypl ");
                OracleParameter pYypl = new OracleParameter(":yypl", OracleDbType.NVarchar2);
                pYypl.Direction = ParameterDirection.Input;
                pYypl.Value = mz_yzParam.Yypl;
                sqlparams.Add(pYypl);
            }
                
            if (null != mz_yzParam.Fk_gh_id && "" != mz_yzParam.Fk_gh_id)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.FK_GH_ID=:fk_gh_id ");
                OracleParameter pFk_gh_id = new OracleParameter(":fk_gh_id", OracleDbType.Varchar2);
                pFk_gh_id.Direction = ParameterDirection.Input;
                pFk_gh_id.Value = mz_yzParam.Fk_gh_id;
                sqlparams.Add(pFk_gh_id);
            }
                
            if (null != mz_yzParam.Gh_lsh)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.GH_LSH=:gh_lsh ");
                OracleParameter pGh_lsh = new OracleParameter(":gh_lsh", OracleDbType.Decimal);
                pGh_lsh.Direction = ParameterDirection.Input;
                pGh_lsh.Value = mz_yzParam.Gh_lsh;
                sqlparams.Add(pGh_lsh);

            }
                        
            if (null != mz_yzParam.Ds && "" != mz_yzParam.Ds)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.DS=:ds ");
                OracleParameter pDs = new OracleParameter(":ds", OracleDbType.NVarchar2);
                pDs.Direction = ParameterDirection.Input;
                pDs.Value = mz_yzParam.Ds;
                sqlparams.Add(pDs);
            }
                
            if (null != mz_yzParam.Ph && "" != mz_yzParam.Ph)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.PH=:ph ");
                OracleParameter pPh = new OracleParameter(":ph", OracleDbType.NVarchar2);
                pPh.Direction = ParameterDirection.Input;
                pPh.Value = mz_yzParam.Ph;
                sqlparams.Add(pPh);
            }
                
            if (null != mz_yzParam.Jj)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.JJ=:jj ");
                OracleParameter pJj = new OracleParameter(":jj", OracleDbType.Decimal);
                pJj.Direction = ParameterDirection.Input;
                pJj.Value = mz_yzParam.Jj;
                sqlparams.Add(pJj);

            }
                        
            if (null != mz_yzParam.Lsj)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.LSJ=:lsj ");
                OracleParameter pLsj = new OracleParameter(":lsj", OracleDbType.Decimal);
                pLsj.Direction = ParameterDirection.Input;
                pLsj.Value = mz_yzParam.Lsj;
                sqlparams.Add(pLsj);

            }
                        
            if (null != mz_yzParam.Dcyldwbl)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.DCYLDWBL=:dcyldwbl ");
                OracleParameter pDcyldwbl = new OracleParameter(":dcyldwbl", OracleDbType.Decimal);
                pDcyldwbl.Direction = ParameterDirection.Input;
                pDcyldwbl.Value = mz_yzParam.Dcyldwbl;
                sqlparams.Add(pDcyldwbl);

            }
                        
            if (null != mz_yzParam.Fk_keshi_id && "" != mz_yzParam.Fk_keshi_id)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.FK_KESHI_ID=:fk_keshi_id ");
                OracleParameter pFk_keshi_id = new OracleParameter(":fk_keshi_id", OracleDbType.Varchar2);
                pFk_keshi_id.Direction = ParameterDirection.Input;
                pFk_keshi_id.Value = mz_yzParam.Fk_keshi_id;
                sqlparams.Add(pFk_keshi_id);
            }
                
            if (null != mz_yzParam.Sfwc_code && "" != mz_yzParam.Sfwc_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.SFWC_CODE=:sfwc_code ");
                OracleParameter pSfwc_code = new OracleParameter(":sfwc_code", OracleDbType.NVarchar2);
                pSfwc_code.Direction = ParameterDirection.Input;
                pSfwc_code.Value = mz_yzParam.Sfwc_code;
                sqlparams.Add(pSfwc_code);
            }
                
            if (null != mz_yzParam.Sfwc && "" != mz_yzParam.Sfwc)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.SFWC=:sfwc ");
                OracleParameter pSfwc = new OracleParameter(":sfwc", OracleDbType.NVarchar2);
                pSfwc.Direction = ParameterDirection.Input;
                pSfwc.Value = mz_yzParam.Sfwc;
                sqlparams.Add(pSfwc);
            }
                
            if (null != mz_yzParam.Keshi && "" != mz_yzParam.Keshi)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.KESHI=:keshi ");
                OracleParameter pKeshi = new OracleParameter(":keshi", OracleDbType.NVarchar2);
                pKeshi.Direction = ParameterDirection.Input;
                pKeshi.Value = mz_yzParam.Keshi;
                sqlparams.Add(pKeshi);
            }
                
            if(mz_yzParamLike!=null)
            {

                if (null != mz_yzParamLike.Zfbz && "" != mz_yzParamLike.Zfbz)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.ZFBZ LIKE '%'||:zfbz||'%' ");
                    OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                    pZfbz.Direction = ParameterDirection.Input;
                    pZfbz.Value = mz_yzParamLike.Zfbz;
                    sqlparams.Add(pZfbz);
                }
                
                if (null != mz_yzParamLike.Yznr && "" != mz_yzParamLike.Yznr)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YZNR LIKE '%'||:yznr||'%' ");
                    OracleParameter pYznr = new OracleParameter(":yznr", OracleDbType.NVarchar2);
                    pYznr.Direction = ParameterDirection.Input;
                    pYznr.Value = mz_yzParamLike.Yznr;
                    sqlparams.Add(pYznr);
                }
                
                if (null != mz_yzParamLike.Yzlx_code && "" != mz_yzParamLike.Yzlx_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YZLX_CODE LIKE '%'||:yzlx_code||'%' ");
                    OracleParameter pYzlx_code = new OracleParameter(":yzlx_code", OracleDbType.NVarchar2);
                    pYzlx_code.Direction = ParameterDirection.Input;
                    pYzlx_code.Value = mz_yzParamLike.Yzlx_code;
                    sqlparams.Add(pYzlx_code);
                }
                
                if (null != mz_yzParamLike.Fk_yp && "" != mz_yzParamLike.Fk_yp)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.FK_YP LIKE '%'||:fk_yp||'%' ");
                    OracleParameter pFk_yp = new OracleParameter(":fk_yp", OracleDbType.Varchar2);
                    pFk_yp.Direction = ParameterDirection.Input;
                    pFk_yp.Value = mz_yzParamLike.Fk_yp;
                    sqlparams.Add(pFk_yp);
                }
                
                if (null != mz_yzParamLike.Fk_zlxm && "" != mz_yzParamLike.Fk_zlxm)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.FK_ZLXM LIKE '%'||:fk_zlxm||'%' ");
                    OracleParameter pFk_zlxm = new OracleParameter(":fk_zlxm", OracleDbType.Varchar2);
                    pFk_zlxm.Direction = ParameterDirection.Input;
                    pFk_zlxm.Value = mz_yzParamLike.Fk_zlxm;
                    sqlparams.Add(pFk_zlxm);
                }
                
                if (null != mz_yzParamLike.Xmbh && "" != mz_yzParamLike.Xmbh)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.XMBH LIKE '%'||:xmbh||'%' ");
                    OracleParameter pXmbh = new OracleParameter(":xmbh", OracleDbType.NVarchar2);
                    pXmbh.Direction = ParameterDirection.Input;
                    pXmbh.Value = mz_yzParamLike.Xmbh;
                    sqlparams.Add(pXmbh);
                }
                
                if (null != mz_yzParamLike.Xmmc && "" != mz_yzParamLike.Xmmc)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.XMMC LIKE '%'||:xmmc||'%' ");
                    OracleParameter pXmmc = new OracleParameter(":xmmc", OracleDbType.NVarchar2);
                    pXmmc.Direction = ParameterDirection.Input;
                    pXmmc.Value = mz_yzParamLike.Xmmc;
                    sqlparams.Add(pXmmc);
                }
                
                if (null != mz_yzParamLike.Xdw && "" != mz_yzParamLike.Xdw)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.XDW LIKE '%'||:xdw||'%' ");
                    OracleParameter pXdw = new OracleParameter(":xdw", OracleDbType.NVarchar2);
                    pXdw.Direction = ParameterDirection.Input;
                    pXdw.Value = mz_yzParamLike.Xdw;
                    sqlparams.Add(pXdw);
                }
                
                if (null != mz_yzParamLike.Gg && "" != mz_yzParamLike.Gg)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.GG LIKE '%'||:gg||'%' ");
                    OracleParameter pGg = new OracleParameter(":gg", OracleDbType.NVarchar2);
                    pGg.Direction = ParameterDirection.Input;
                    pGg.Value = mz_yzParamLike.Gg;
                    sqlparams.Add(pGg);
                }
                
                if (null != mz_yzParamLike.Jx && "" != mz_yzParamLike.Jx)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.JX LIKE '%'||:jx||'%' ");
                    OracleParameter pJx = new OracleParameter(":jx", OracleDbType.NVarchar2);
                    pJx.Direction = ParameterDirection.Input;
                    pJx.Value = mz_yzParamLike.Jx;
                    sqlparams.Add(pJx);
                }
                
                if (null != mz_yzParamLike.Yytj && "" != mz_yzParamLike.Yytj)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YYTJ LIKE '%'||:yytj||'%' ");
                    OracleParameter pYytj = new OracleParameter(":yytj", OracleDbType.NVarchar2);
                    pYytj.Direction = ParameterDirection.Input;
                    pYytj.Value = mz_yzParamLike.Yytj;
                    sqlparams.Add(pYytj);
                }
                
                if (null != mz_yzParamLike.Yypl_code && "" != mz_yzParamLike.Yypl_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YYPL_CODE LIKE '%'||:yypl_code||'%' ");
                    OracleParameter pYypl_code = new OracleParameter(":yypl_code", OracleDbType.NVarchar2);
                    pYypl_code.Direction = ParameterDirection.Input;
                    pYypl_code.Value = mz_yzParamLike.Yypl_code;
                    sqlparams.Add(pYypl_code);
                }
                
                if (null != mz_yzParamLike.Dcyldw && "" != mz_yzParamLike.Dcyldw)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.DCYLDW LIKE '%'||:dcyldw||'%' ");
                    OracleParameter pDcyldw = new OracleParameter(":dcyldw", OracleDbType.NVarchar2);
                    pDcyldw.Direction = ParameterDirection.Input;
                    pDcyldw.Value = mz_yzParamLike.Dcyldw;
                    sqlparams.Add(pDcyldw);
                }
                
                if (null != mz_yzParamLike.Yypl && "" != mz_yzParamLike.Yypl)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YYPL LIKE '%'||:yypl||'%' ");
                    OracleParameter pYypl = new OracleParameter(":yypl", OracleDbType.NVarchar2);
                    pYypl.Direction = ParameterDirection.Input;
                    pYypl.Value = mz_yzParamLike.Yypl;
                    sqlparams.Add(pYypl);
                }
                
                if (null != mz_yzParamLike.Fk_gh_id && "" != mz_yzParamLike.Fk_gh_id)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.FK_GH_ID LIKE '%'||:fk_gh_id||'%' ");
                    OracleParameter pFk_gh_id = new OracleParameter(":fk_gh_id", OracleDbType.Varchar2);
                    pFk_gh_id.Direction = ParameterDirection.Input;
                    pFk_gh_id.Value = mz_yzParamLike.Fk_gh_id;
                    sqlparams.Add(pFk_gh_id);
                }
                
                if (null != mz_yzParamLike.Ds && "" != mz_yzParamLike.Ds)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.DS LIKE '%'||:ds||'%' ");
                    OracleParameter pDs = new OracleParameter(":ds", OracleDbType.NVarchar2);
                    pDs.Direction = ParameterDirection.Input;
                    pDs.Value = mz_yzParamLike.Ds;
                    sqlparams.Add(pDs);
                }
                
                if (null != mz_yzParamLike.Ph && "" != mz_yzParamLike.Ph)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.PH LIKE '%'||:ph||'%' ");
                    OracleParameter pPh = new OracleParameter(":ph", OracleDbType.NVarchar2);
                    pPh.Direction = ParameterDirection.Input;
                    pPh.Value = mz_yzParamLike.Ph;
                    sqlparams.Add(pPh);
                }
                
                if (null != mz_yzParamLike.Fk_keshi_id && "" != mz_yzParamLike.Fk_keshi_id)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.FK_KESHI_ID LIKE '%'||:fk_keshi_id||'%' ");
                    OracleParameter pFk_keshi_id = new OracleParameter(":fk_keshi_id", OracleDbType.Varchar2);
                    pFk_keshi_id.Direction = ParameterDirection.Input;
                    pFk_keshi_id.Value = mz_yzParamLike.Fk_keshi_id;
                    sqlparams.Add(pFk_keshi_id);
                }
                
                if (null != mz_yzParamLike.Sfwc_code && "" != mz_yzParamLike.Sfwc_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.SFWC_CODE LIKE '%'||:sfwc_code||'%' ");
                    OracleParameter pSfwc_code = new OracleParameter(":sfwc_code", OracleDbType.NVarchar2);
                    pSfwc_code.Direction = ParameterDirection.Input;
                    pSfwc_code.Value = mz_yzParamLike.Sfwc_code;
                    sqlparams.Add(pSfwc_code);
                }
                
                if (null != mz_yzParamLike.Sfwc && "" != mz_yzParamLike.Sfwc)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.SFWC LIKE '%'||:sfwc||'%' ");
                    OracleParameter pSfwc = new OracleParameter(":sfwc", OracleDbType.NVarchar2);
                    pSfwc.Direction = ParameterDirection.Input;
                    pSfwc.Value = mz_yzParamLike.Sfwc;
                    sqlparams.Add(pSfwc);
                }
                
                if (null != mz_yzParamLike.Keshi && "" != mz_yzParamLike.Keshi)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.KESHI LIKE '%'||:keshi||'%' ");
                    OracleParameter pKeshi = new OracleParameter(":keshi", OracleDbType.NVarchar2);
                    pKeshi.Direction = ParameterDirection.Input;
                    pKeshi.Value = mz_yzParamLike.Keshi;
                    sqlparams.Add(pKeshi);
                }
                
            }

            this.b_isWhere = false;
            this.addSort(sql, sortList);//排序
            //*******分页start1*********如果分页对象为空，则全部数据查出，如果不为空
            List<object> returnList = new List<object>();//返回的List,索引0为List<Mz_yz>对象,索引1为Model.Common.PageInfo分页信息对象
            if (null != page)
            {
                string sqlParam = sql.ToString();
                sql = new StringBuilder(@" SELECT * FROM 
                (
                SELECT A.*, ROWNUM RN 
                FROM ("+sqlParam+@") A 
                WHERE ROWNUM <= :maxIndex
                )
                WHERE RN >= :minIndex ");
                sqlparams.Add(new OracleParameter("maxIndex", page.MaxIndex));
                sqlparams.Add(new OracleParameter("minIndex", page.MinIndex));
            }
            //*******分页end1*********
            DataSet ds = OracleHelper.getDataSet(sql.ToString(), sqlparams.ToArray());
            DataRowCollection rows = ds.Tables[0].Rows;
            //把每一行数据转换为一个对象放入List<Mz_yz>中
            for (int i = 0; i < rows.Count; i++)
            {
                DataRow row = rows[i];
                //mz_yzParamList.Add(this.dataSetContactObjectsToModel(row));
                mz_yzParamList.Add(this.dataSetToModel(row));
            }
            
             //*******分页start2*********如果没有传入分页对象，则新建一个分页对象当做返回值
            if (null == page)
            {
                page = new Model.Common.PageInfo();
                page.AllCount = rows.Count;
            }
            returnList.Add(mz_yzParamList);//把List<Mz_yz>放入List<object>中第一个
            returnList.Add(page);//把page对象放入List<object>中第二个
            //*******分页end2*********
            return returnList;
        }

        
        
        /// <summary>
        /// 根据条件得到集合的数量
        /// 第二个条件是模糊查询的条件
        /// </summary>
        /// <returns>int</returns>
        public int getCount(Mz_yz mz_yzParam,Mz_yz mz_yzParamLike)
        {
            //如果没有传查询条件参数，就new一个空的Mz_yz对象，标示查询所有数据
            if (null == mz_yzParam)
            {
                mz_yzParam = new Mz_yz();
            }
            List<OracleParameter> sqlparams = new List<OracleParameter>();//保存参数的集合
            StringBuilder sql = new StringBuilder("SELECT COUNT(ID) FROM MZ_YZ A");
                if (null != mz_yzParam.Zfbz && "" != mz_yzParam.Zfbz)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.ZFBZ=:zfbz ");
                    OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                pZfbz.Value = mz_yzParam.Zfbz;
                sqlparams.Add(pZfbz);
                }
                
                if (null != mz_yzParam.Yznr && "" != mz_yzParam.Yznr)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YZNR=:yznr ");
                    OracleParameter pYznr = new OracleParameter(":yznr", OracleDbType.NVarchar2);
                pYznr.Value = mz_yzParam.Yznr;
                sqlparams.Add(pYznr);
                }
                
                if (null != mz_yzParam.Yzlx_code && "" != mz_yzParam.Yzlx_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YZLX_CODE=:yzlx_code ");
                    OracleParameter pYzlx_code = new OracleParameter(":yzlx_code", OracleDbType.NVarchar2);
                pYzlx_code.Value = mz_yzParam.Yzlx_code;
                sqlparams.Add(pYzlx_code);
                }
                
                if (null != mz_yzParam.Fk_yp && "" != mz_yzParam.Fk_yp)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.FK_YP=:fk_yp ");
                    OracleParameter pFk_yp = new OracleParameter(":fk_yp", OracleDbType.Varchar2);
                pFk_yp.Value = mz_yzParam.Fk_yp;
                sqlparams.Add(pFk_yp);
                }
                
                if (null != mz_yzParam.Fk_zlxm && "" != mz_yzParam.Fk_zlxm)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.FK_ZLXM=:fk_zlxm ");
                    OracleParameter pFk_zlxm = new OracleParameter(":fk_zlxm", OracleDbType.Varchar2);
                pFk_zlxm.Value = mz_yzParam.Fk_zlxm;
                sqlparams.Add(pFk_zlxm);
                }
                
                if (null != mz_yzParam.Xmbh && "" != mz_yzParam.Xmbh)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.XMBH=:xmbh ");
                    OracleParameter pXmbh = new OracleParameter(":xmbh", OracleDbType.NVarchar2);
                pXmbh.Value = mz_yzParam.Xmbh;
                sqlparams.Add(pXmbh);
                }
                
                if (null != mz_yzParam.Xmmc && "" != mz_yzParam.Xmmc)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.XMMC=:xmmc ");
                    OracleParameter pXmmc = new OracleParameter(":xmmc", OracleDbType.NVarchar2);
                pXmmc.Value = mz_yzParam.Xmmc;
                sqlparams.Add(pXmmc);
                }
                
                if (null != mz_yzParam.Xdw && "" != mz_yzParam.Xdw)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.XDW=:xdw ");
                    OracleParameter pXdw = new OracleParameter(":xdw", OracleDbType.NVarchar2);
                pXdw.Value = mz_yzParam.Xdw;
                sqlparams.Add(pXdw);
                }
                
                if (null != mz_yzParam.Gg && "" != mz_yzParam.Gg)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.GG=:gg ");
                    OracleParameter pGg = new OracleParameter(":gg", OracleDbType.NVarchar2);
                pGg.Value = mz_yzParam.Gg;
                sqlparams.Add(pGg);
                }
                
                if (null != mz_yzParam.Jx && "" != mz_yzParam.Jx)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.JX=:jx ");
                    OracleParameter pJx = new OracleParameter(":jx", OracleDbType.NVarchar2);
                pJx.Value = mz_yzParam.Jx;
                sqlparams.Add(pJx);
                }
                
            if (null != mz_yzParam.Sl)
            {
                this.isComma(sql);
                sql.Append(" SL=:sl ");
                OracleParameter pSl = new OracleParameter(":sl", OracleDbType.Decimal);
                pSl.Value = mz_yzParam.Sl;
                sqlparams.Add(pSl);

            }
                        
                if (null != mz_yzParam.Yytj && "" != mz_yzParam.Yytj)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YYTJ=:yytj ");
                    OracleParameter pYytj = new OracleParameter(":yytj", OracleDbType.NVarchar2);
                pYytj.Value = mz_yzParam.Yytj;
                sqlparams.Add(pYytj);
                }
                
                if (null != mz_yzParam.Yypl_code && "" != mz_yzParam.Yypl_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YYPL_CODE=:yypl_code ");
                    OracleParameter pYypl_code = new OracleParameter(":yypl_code", OracleDbType.NVarchar2);
                pYypl_code.Value = mz_yzParam.Yypl_code;
                sqlparams.Add(pYypl_code);
                }
                
            if (null != mz_yzParam.Dcyl)
            {
                this.isComma(sql);
                sql.Append(" DCYL=:dcyl ");
                OracleParameter pDcyl = new OracleParameter(":dcyl", OracleDbType.Decimal);
                pDcyl.Value = mz_yzParam.Dcyl;
                sqlparams.Add(pDcyl);

            }
                        
                if (null != mz_yzParam.Dcyldw && "" != mz_yzParam.Dcyldw)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.DCYLDW=:dcyldw ");
                    OracleParameter pDcyldw = new OracleParameter(":dcyldw", OracleDbType.NVarchar2);
                pDcyldw.Value = mz_yzParam.Dcyldw;
                sqlparams.Add(pDcyldw);
                }
                
            if (null != mz_yzParam.Ts)
            {
                this.isComma(sql);
                sql.Append(" TS=:ts ");
                OracleParameter pTs = new OracleParameter(":ts", OracleDbType.Decimal);
                pTs.Value = mz_yzParam.Ts;
                sqlparams.Add(pTs);

            }
                        
                if (null != mz_yzParam.Yypl && "" != mz_yzParam.Yypl)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YYPL=:yypl ");
                    OracleParameter pYypl = new OracleParameter(":yypl", OracleDbType.NVarchar2);
                pYypl.Value = mz_yzParam.Yypl;
                sqlparams.Add(pYypl);
                }
                
                if (null != mz_yzParam.Fk_gh_id && "" != mz_yzParam.Fk_gh_id)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.FK_GH_ID=:fk_gh_id ");
                    OracleParameter pFk_gh_id = new OracleParameter(":fk_gh_id", OracleDbType.Varchar2);
                pFk_gh_id.Value = mz_yzParam.Fk_gh_id;
                sqlparams.Add(pFk_gh_id);
                }
                
            if (null != mz_yzParam.Gh_lsh)
            {
                this.isComma(sql);
                sql.Append(" GH_LSH=:gh_lsh ");
                OracleParameter pGh_lsh = new OracleParameter(":gh_lsh", OracleDbType.Decimal);
                pGh_lsh.Value = mz_yzParam.Gh_lsh;
                sqlparams.Add(pGh_lsh);

            }
                        
                if (null != mz_yzParam.Ds && "" != mz_yzParam.Ds)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.DS=:ds ");
                    OracleParameter pDs = new OracleParameter(":ds", OracleDbType.NVarchar2);
                pDs.Value = mz_yzParam.Ds;
                sqlparams.Add(pDs);
                }
                
                if (null != mz_yzParam.Ph && "" != mz_yzParam.Ph)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.PH=:ph ");
                    OracleParameter pPh = new OracleParameter(":ph", OracleDbType.NVarchar2);
                pPh.Value = mz_yzParam.Ph;
                sqlparams.Add(pPh);
                }
                
            if (null != mz_yzParam.Jj)
            {
                this.isComma(sql);
                sql.Append(" JJ=:jj ");
                OracleParameter pJj = new OracleParameter(":jj", OracleDbType.Decimal);
                pJj.Value = mz_yzParam.Jj;
                sqlparams.Add(pJj);

            }
                        
            if (null != mz_yzParam.Lsj)
            {
                this.isComma(sql);
                sql.Append(" LSJ=:lsj ");
                OracleParameter pLsj = new OracleParameter(":lsj", OracleDbType.Decimal);
                pLsj.Value = mz_yzParam.Lsj;
                sqlparams.Add(pLsj);

            }
                        
            if (null != mz_yzParam.Dcyldwbl)
            {
                this.isComma(sql);
                sql.Append(" DCYLDWBL=:dcyldwbl ");
                OracleParameter pDcyldwbl = new OracleParameter(":dcyldwbl", OracleDbType.Decimal);
                pDcyldwbl.Value = mz_yzParam.Dcyldwbl;
                sqlparams.Add(pDcyldwbl);

            }
                        
                if (null != mz_yzParam.Fk_keshi_id && "" != mz_yzParam.Fk_keshi_id)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.FK_KESHI_ID=:fk_keshi_id ");
                    OracleParameter pFk_keshi_id = new OracleParameter(":fk_keshi_id", OracleDbType.Varchar2);
                pFk_keshi_id.Value = mz_yzParam.Fk_keshi_id;
                sqlparams.Add(pFk_keshi_id);
                }
                
                if (null != mz_yzParam.Sfwc_code && "" != mz_yzParam.Sfwc_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.SFWC_CODE=:sfwc_code ");
                    OracleParameter pSfwc_code = new OracleParameter(":sfwc_code", OracleDbType.NVarchar2);
                pSfwc_code.Value = mz_yzParam.Sfwc_code;
                sqlparams.Add(pSfwc_code);
                }
                
                if (null != mz_yzParam.Sfwc && "" != mz_yzParam.Sfwc)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.SFWC=:sfwc ");
                    OracleParameter pSfwc = new OracleParameter(":sfwc", OracleDbType.NVarchar2);
                pSfwc.Value = mz_yzParam.Sfwc;
                sqlparams.Add(pSfwc);
                }
                
                if (null != mz_yzParam.Keshi && "" != mz_yzParam.Keshi)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.KESHI=:keshi ");
                    OracleParameter pKeshi = new OracleParameter(":keshi", OracleDbType.NVarchar2);
                pKeshi.Value = mz_yzParam.Keshi;
                sqlparams.Add(pKeshi);
                }
                
            if(mz_yzParamLike!=null)
            {

                if (null != mz_yzParamLike.Zfbz && "" != mz_yzParamLike.Zfbz)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.ZFBZ LIKE '%'||:zfbz||'%' ");
                    OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                    pZfbz.Direction = ParameterDirection.Input;
                    pZfbz.Value = mz_yzParamLike.Zfbz;
                    sqlparams.Add(pZfbz);
                }
                
                if (null != mz_yzParamLike.Yznr && "" != mz_yzParamLike.Yznr)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YZNR LIKE '%'||:yznr||'%' ");
                    OracleParameter pYznr = new OracleParameter(":yznr", OracleDbType.NVarchar2);
                    pYznr.Direction = ParameterDirection.Input;
                    pYznr.Value = mz_yzParamLike.Yznr;
                    sqlparams.Add(pYznr);
                }
                
                if (null != mz_yzParamLike.Yzlx_code && "" != mz_yzParamLike.Yzlx_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YZLX_CODE LIKE '%'||:yzlx_code||'%' ");
                    OracleParameter pYzlx_code = new OracleParameter(":yzlx_code", OracleDbType.NVarchar2);
                    pYzlx_code.Direction = ParameterDirection.Input;
                    pYzlx_code.Value = mz_yzParamLike.Yzlx_code;
                    sqlparams.Add(pYzlx_code);
                }
                
                if (null != mz_yzParamLike.Fk_yp && "" != mz_yzParamLike.Fk_yp)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.FK_YP LIKE '%'||:fk_yp||'%' ");
                    OracleParameter pFk_yp = new OracleParameter(":fk_yp", OracleDbType.Varchar2);
                    pFk_yp.Direction = ParameterDirection.Input;
                    pFk_yp.Value = mz_yzParamLike.Fk_yp;
                    sqlparams.Add(pFk_yp);
                }
                
                if (null != mz_yzParamLike.Fk_zlxm && "" != mz_yzParamLike.Fk_zlxm)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.FK_ZLXM LIKE '%'||:fk_zlxm||'%' ");
                    OracleParameter pFk_zlxm = new OracleParameter(":fk_zlxm", OracleDbType.Varchar2);
                    pFk_zlxm.Direction = ParameterDirection.Input;
                    pFk_zlxm.Value = mz_yzParamLike.Fk_zlxm;
                    sqlparams.Add(pFk_zlxm);
                }
                
                if (null != mz_yzParamLike.Xmbh && "" != mz_yzParamLike.Xmbh)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.XMBH LIKE '%'||:xmbh||'%' ");
                    OracleParameter pXmbh = new OracleParameter(":xmbh", OracleDbType.NVarchar2);
                    pXmbh.Direction = ParameterDirection.Input;
                    pXmbh.Value = mz_yzParamLike.Xmbh;
                    sqlparams.Add(pXmbh);
                }
                
                if (null != mz_yzParamLike.Xmmc && "" != mz_yzParamLike.Xmmc)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.XMMC LIKE '%'||:xmmc||'%' ");
                    OracleParameter pXmmc = new OracleParameter(":xmmc", OracleDbType.NVarchar2);
                    pXmmc.Direction = ParameterDirection.Input;
                    pXmmc.Value = mz_yzParamLike.Xmmc;
                    sqlparams.Add(pXmmc);
                }
                
                if (null != mz_yzParamLike.Xdw && "" != mz_yzParamLike.Xdw)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.XDW LIKE '%'||:xdw||'%' ");
                    OracleParameter pXdw = new OracleParameter(":xdw", OracleDbType.NVarchar2);
                    pXdw.Direction = ParameterDirection.Input;
                    pXdw.Value = mz_yzParamLike.Xdw;
                    sqlparams.Add(pXdw);
                }
                
                if (null != mz_yzParamLike.Gg && "" != mz_yzParamLike.Gg)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.GG LIKE '%'||:gg||'%' ");
                    OracleParameter pGg = new OracleParameter(":gg", OracleDbType.NVarchar2);
                    pGg.Direction = ParameterDirection.Input;
                    pGg.Value = mz_yzParamLike.Gg;
                    sqlparams.Add(pGg);
                }
                
                if (null != mz_yzParamLike.Jx && "" != mz_yzParamLike.Jx)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.JX LIKE '%'||:jx||'%' ");
                    OracleParameter pJx = new OracleParameter(":jx", OracleDbType.NVarchar2);
                    pJx.Direction = ParameterDirection.Input;
                    pJx.Value = mz_yzParamLike.Jx;
                    sqlparams.Add(pJx);
                }
                
                if (null != mz_yzParamLike.Yytj && "" != mz_yzParamLike.Yytj)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YYTJ LIKE '%'||:yytj||'%' ");
                    OracleParameter pYytj = new OracleParameter(":yytj", OracleDbType.NVarchar2);
                    pYytj.Direction = ParameterDirection.Input;
                    pYytj.Value = mz_yzParamLike.Yytj;
                    sqlparams.Add(pYytj);
                }
                
                if (null != mz_yzParamLike.Yypl_code && "" != mz_yzParamLike.Yypl_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YYPL_CODE LIKE '%'||:yypl_code||'%' ");
                    OracleParameter pYypl_code = new OracleParameter(":yypl_code", OracleDbType.NVarchar2);
                    pYypl_code.Direction = ParameterDirection.Input;
                    pYypl_code.Value = mz_yzParamLike.Yypl_code;
                    sqlparams.Add(pYypl_code);
                }
                
                if (null != mz_yzParamLike.Dcyldw && "" != mz_yzParamLike.Dcyldw)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.DCYLDW LIKE '%'||:dcyldw||'%' ");
                    OracleParameter pDcyldw = new OracleParameter(":dcyldw", OracleDbType.NVarchar2);
                    pDcyldw.Direction = ParameterDirection.Input;
                    pDcyldw.Value = mz_yzParamLike.Dcyldw;
                    sqlparams.Add(pDcyldw);
                }
                
                if (null != mz_yzParamLike.Yypl && "" != mz_yzParamLike.Yypl)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YYPL LIKE '%'||:yypl||'%' ");
                    OracleParameter pYypl = new OracleParameter(":yypl", OracleDbType.NVarchar2);
                    pYypl.Direction = ParameterDirection.Input;
                    pYypl.Value = mz_yzParamLike.Yypl;
                    sqlparams.Add(pYypl);
                }
                
                if (null != mz_yzParamLike.Fk_gh_id && "" != mz_yzParamLike.Fk_gh_id)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.FK_GH_ID LIKE '%'||:fk_gh_id||'%' ");
                    OracleParameter pFk_gh_id = new OracleParameter(":fk_gh_id", OracleDbType.Varchar2);
                    pFk_gh_id.Direction = ParameterDirection.Input;
                    pFk_gh_id.Value = mz_yzParamLike.Fk_gh_id;
                    sqlparams.Add(pFk_gh_id);
                }
                
                if (null != mz_yzParamLike.Ds && "" != mz_yzParamLike.Ds)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.DS LIKE '%'||:ds||'%' ");
                    OracleParameter pDs = new OracleParameter(":ds", OracleDbType.NVarchar2);
                    pDs.Direction = ParameterDirection.Input;
                    pDs.Value = mz_yzParamLike.Ds;
                    sqlparams.Add(pDs);
                }
                
                if (null != mz_yzParamLike.Ph && "" != mz_yzParamLike.Ph)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.PH LIKE '%'||:ph||'%' ");
                    OracleParameter pPh = new OracleParameter(":ph", OracleDbType.NVarchar2);
                    pPh.Direction = ParameterDirection.Input;
                    pPh.Value = mz_yzParamLike.Ph;
                    sqlparams.Add(pPh);
                }
                
                if (null != mz_yzParamLike.Fk_keshi_id && "" != mz_yzParamLike.Fk_keshi_id)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.FK_KESHI_ID LIKE '%'||:fk_keshi_id||'%' ");
                    OracleParameter pFk_keshi_id = new OracleParameter(":fk_keshi_id", OracleDbType.Varchar2);
                    pFk_keshi_id.Direction = ParameterDirection.Input;
                    pFk_keshi_id.Value = mz_yzParamLike.Fk_keshi_id;
                    sqlparams.Add(pFk_keshi_id);
                }
                
                if (null != mz_yzParamLike.Sfwc_code && "" != mz_yzParamLike.Sfwc_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.SFWC_CODE LIKE '%'||:sfwc_code||'%' ");
                    OracleParameter pSfwc_code = new OracleParameter(":sfwc_code", OracleDbType.NVarchar2);
                    pSfwc_code.Direction = ParameterDirection.Input;
                    pSfwc_code.Value = mz_yzParamLike.Sfwc_code;
                    sqlparams.Add(pSfwc_code);
                }
                
                if (null != mz_yzParamLike.Sfwc && "" != mz_yzParamLike.Sfwc)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.SFWC LIKE '%'||:sfwc||'%' ");
                    OracleParameter pSfwc = new OracleParameter(":sfwc", OracleDbType.NVarchar2);
                    pSfwc.Direction = ParameterDirection.Input;
                    pSfwc.Value = mz_yzParamLike.Sfwc;
                    sqlparams.Add(pSfwc);
                }
                
                if (null != mz_yzParamLike.Keshi && "" != mz_yzParamLike.Keshi)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.KESHI LIKE '%'||:keshi||'%' ");
                    OracleParameter pKeshi = new OracleParameter(":keshi", OracleDbType.NVarchar2);
                    pKeshi.Direction = ParameterDirection.Input;
                    pKeshi.Value = mz_yzParamLike.Keshi;
                    sqlparams.Add(pKeshi);
                }
                
            }

            this.b_isWhere = false;
            return Int32.Parse(OracleHelper.ExecuteScalar(sql.ToString(),sqlparams.ToArray()).ToString());
        }


        /// <summary>
        /// 通用的保存方法，根据用户传入的参数，有ID为修改，没有ID为新增(手动生成OracleConnection对象，此方法用于事务，使用事务必须使用同一个OracleConnection对象)
        /// </summary>
        /// <param name="mz_yzParam"></param>
        /// <returns></returns>
        public bool save(Mz_yz mz_yzParam,OracleConnection con)
        {
            if ("" != mz_yzParam.Id && null != mz_yzParam.Id)
            {
                //修改
                return this.updateById(mz_yzParam,con);
            }
            else
            {
                //新增
                return this.insert(mz_yzParam,con);
            }
        }

        /// <summary>
        /// 把dataset中的一行转换为model
        /// </summary>
        /// <param name="row"></param>
        /// <returns></returns>
        private Mz_yz dataSetToModel(DataRow row)
        {
            Mz_yz mz_yzParam = new Mz_yz();
            mz_yzParam.Id = Convert.ToString(row["ID"]).Trim(); 
            mz_yzParam.Zfbz = Convert.ToString(row["ZFBZ"]).Trim(); 
            mz_yzParam.Yznr = Convert.ToString(row["YZNR"]).Trim(); 
            mz_yzParam.Yzlx_code = Convert.ToString(row["YZLX_CODE"]).Trim(); 
            mz_yzParam.Fk_yp = Convert.ToString(row["FK_YP"]).Trim(); 
            mz_yzParam.Fk_zlxm = Convert.ToString(row["FK_ZLXM"]).Trim(); 
            mz_yzParam.Xmbh = Convert.ToString(row["XMBH"]).Trim(); 
            mz_yzParam.Xmmc = Convert.ToString(row["XMMC"]).Trim(); 
            mz_yzParam.Xdw = Convert.ToString(row["XDW"]).Trim(); 
            mz_yzParam.Gg = Convert.ToString(row["GG"]).Trim(); 
            mz_yzParam.Jx = Convert.ToString(row["JX"]).Trim(); 
            mz_yzParam.Sl =  (decimal?)this.convertDBNullValue(row["SL"]);
            mz_yzParam.Yytj = Convert.ToString(row["YYTJ"]).Trim(); 
            mz_yzParam.Yypl_code = Convert.ToString(row["YYPL_CODE"]).Trim(); 
            mz_yzParam.Dcyl =  (decimal?)this.convertDBNullValue(row["DCYL"]);
            mz_yzParam.Dcyldw = Convert.ToString(row["DCYLDW"]).Trim(); 
            mz_yzParam.Ts =  (decimal?)this.convertDBNullValue(row["TS"]);
            mz_yzParam.Yypl = Convert.ToString(row["YYPL"]).Trim(); 
            mz_yzParam.Fk_gh_id = Convert.ToString(row["FK_GH_ID"]).Trim(); 
            mz_yzParam.Gh_lsh =  (decimal?)this.convertDBNullValue(row["GH_LSH"]);
            mz_yzParam.Ds = Convert.ToString(row["DS"]).Trim(); 
            mz_yzParam.Ph = Convert.ToString(row["PH"]).Trim(); 
            mz_yzParam.Jj =  (decimal?)this.convertDBNullValue(row["JJ"]);
            mz_yzParam.Lsj =  (decimal?)this.convertDBNullValue(row["LSJ"]);
            mz_yzParam.Dcyldwbl =  (decimal?)this.convertDBNullValue(row["DCYLDWBL"]);
            mz_yzParam.Fk_keshi_id = Convert.ToString(row["FK_KESHI_ID"]).Trim(); 
            mz_yzParam.Sfwc_code = Convert.ToString(row["SFWC_CODE"]).Trim(); 
            mz_yzParam.Sfwc = Convert.ToString(row["SFWC"]).Trim(); 
            mz_yzParam.Keshi = Convert.ToString(row["KESHI"]).Trim(); 
            
            return mz_yzParam;
        }

       
        
        //*******************在此以后添加新的方法start

        //*******************在此以后添加新的方法end
        
    }
}


