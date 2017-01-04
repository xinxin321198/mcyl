

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAL.Common;
using System.Transactions;//引入事务
using Oracle.DataAccess.Client;//引入oracle驱动
using Model.YPKC;
using Model.Common;
using Model.JC;

namespace DAL.YPKC.药品库存_库存表
{
    /// <summary>
    ///数据库访问层的Ypkc_kc实现类
    ///此类由代码生成器生成
    ///表名：YPKC_KC
    ///生成日期：2016-01-13 16:50:53
    /// 

    ///作者：罗新鑫
    ///联系电话：15087010221
    ///联系邮箱：362527240@qq.com

    /// </summary>
    public class Ypkc_kcDALImp : Base.BasDAL, Ypkc_kcDAL
    {

        /// <summary>
        /// 插入一条数据（如果需要供事务使用就传入OracleConnection对象，如果不供就传入null，方法自动生成OracleConnection对象）
        /// 主键为null时，自动生成主键guid，一般不直接调用此方法，请调用save方法进行单条数据的插入和修改       
        /// </summary>
        /// <param name="ypkc_kcParam">要插入的ypkc_kcParam对象</param>
        /// <param name="con">Oracle连接对象（为null时自动生成）</param>
        /// <returns>是否添加成功（影响的行数为1时成功）</returns>
        public bool insert(Ypkc_kc ypkc_kcParam, OracleConnection con)
        {
            if ("" == ypkc_kcParam.Id || null == ypkc_kcParam.Id)
            {
                ypkc_kcParam.Id = Model.Common.GUIDHelper.getGuid();
            }
            List<OracleParameter> sqlparams = new List<OracleParameter>();

            StringBuilder sql = new StringBuilder("INSERT INTO YPKC_KC(id,fk_keshi_id,ksbh,ksmc,fk_yp_id,ypbh,ypmc,yptymc,ypgg,jx,pym,ddw,xdw,dwlx_code,hsbl,pzwh,gyzz,cjmc,ph,yxq,jj,lsj,sl,yksl,zfbz,ypfl_code) VALUES(:id,:fk_keshi_id,:ksbh,:ksmc,:fk_yp_id,:ypbh,:ypmc,:yptymc,:ypgg,:jx,:pym,:ddw,:xdw,:dwlx_code,:hsbl,:pzwh,:gyzz,:cjmc,:ph,:yxq,:jj,:lsj,:sl,:yksl,:zfbz,:ypfl_code)");

            OracleParameter pId = new OracleParameter(":id", OracleDbType.Varchar2);
            pId.Direction = ParameterDirection.Input;
            pId.Value = ypkc_kcParam.Id;
            sqlparams.Add(pId);
            OracleParameter pFk_keshi_id = new OracleParameter(":fk_keshi_id", OracleDbType.Varchar2);
            pFk_keshi_id.Direction = ParameterDirection.Input;
            pFk_keshi_id.Value = ypkc_kcParam.Fk_keshi_id;
            sqlparams.Add(pFk_keshi_id);
            OracleParameter pKsbh = new OracleParameter(":ksbh", OracleDbType.NVarchar2);
            pKsbh.Direction = ParameterDirection.Input;
            pKsbh.Value = ypkc_kcParam.Ksbh;
            sqlparams.Add(pKsbh);
            OracleParameter pKsmc = new OracleParameter(":ksmc", OracleDbType.NVarchar2);
            pKsmc.Direction = ParameterDirection.Input;
            pKsmc.Value = ypkc_kcParam.Ksmc;
            sqlparams.Add(pKsmc);
            OracleParameter pFk_yp_id = new OracleParameter(":fk_yp_id", OracleDbType.Varchar2);
            pFk_yp_id.Direction = ParameterDirection.Input;
            pFk_yp_id.Value = ypkc_kcParam.Fk_yp_id;
            sqlparams.Add(pFk_yp_id);
            OracleParameter pYpbh = new OracleParameter(":ypbh", OracleDbType.NVarchar2);
            pYpbh.Direction = ParameterDirection.Input;
            pYpbh.Value = ypkc_kcParam.Ypbh;
            sqlparams.Add(pYpbh);
            OracleParameter pYpmc = new OracleParameter(":ypmc", OracleDbType.NVarchar2);
            pYpmc.Direction = ParameterDirection.Input;
            pYpmc.Value = ypkc_kcParam.Ypmc;
            sqlparams.Add(pYpmc);
            OracleParameter pYptymc = new OracleParameter(":yptymc", OracleDbType.NVarchar2);
            pYptymc.Direction = ParameterDirection.Input;
            pYptymc.Value = ypkc_kcParam.Yptymc;
            sqlparams.Add(pYptymc);
            OracleParameter pYpgg = new OracleParameter(":ypgg", OracleDbType.NVarchar2);
            pYpgg.Direction = ParameterDirection.Input;
            pYpgg.Value = ypkc_kcParam.Ypgg;
            sqlparams.Add(pYpgg);
            OracleParameter pJx = new OracleParameter(":jx", OracleDbType.NVarchar2);
            pJx.Direction = ParameterDirection.Input;
            pJx.Value = ypkc_kcParam.Jx;
            sqlparams.Add(pJx);
            OracleParameter pPym = new OracleParameter(":pym", OracleDbType.NVarchar2);
            pPym.Direction = ParameterDirection.Input;
            pPym.Value = ypkc_kcParam.Pym;
            sqlparams.Add(pPym);
            OracleParameter pDdw = new OracleParameter(":ddw", OracleDbType.NVarchar2);
            pDdw.Direction = ParameterDirection.Input;
            pDdw.Value = ypkc_kcParam.Ddw;
            sqlparams.Add(pDdw);
            OracleParameter pXdw = new OracleParameter(":xdw", OracleDbType.NVarchar2);
            pXdw.Direction = ParameterDirection.Input;
            pXdw.Value = ypkc_kcParam.Xdw;
            sqlparams.Add(pXdw);
            OracleParameter pDwlx_code = new OracleParameter(":dwlx_code", OracleDbType.NVarchar2);
            pDwlx_code.Direction = ParameterDirection.Input;
            pDwlx_code.Value = ypkc_kcParam.Dwlx_code;
            sqlparams.Add(pDwlx_code);
            OracleParameter pHsbl = new OracleParameter(":hsbl", OracleDbType.Decimal);
            pHsbl.Direction = ParameterDirection.Input;
            pHsbl.Value = ypkc_kcParam.Hsbl;
            sqlparams.Add(pHsbl);
            OracleParameter pPzwh = new OracleParameter(":pzwh", OracleDbType.Varchar2);
            pPzwh.Direction = ParameterDirection.Input;
            pPzwh.Value = ypkc_kcParam.Pzwh;
            sqlparams.Add(pPzwh);
            OracleParameter pGyzz = new OracleParameter(":gyzz", OracleDbType.Varchar2);
            pGyzz.Direction = ParameterDirection.Input;
            pGyzz.Value = ypkc_kcParam.Gyzz;
            sqlparams.Add(pGyzz);
            OracleParameter pCjmc = new OracleParameter(":cjmc", OracleDbType.NVarchar2);
            pCjmc.Direction = ParameterDirection.Input;
            pCjmc.Value = ypkc_kcParam.Cjmc;
            sqlparams.Add(pCjmc);
            OracleParameter pPh = new OracleParameter(":ph", OracleDbType.NVarchar2);
            pPh.Direction = ParameterDirection.Input;
            pPh.Value = ypkc_kcParam.Ph;
            sqlparams.Add(pPh);
            OracleParameter pYxq = new OracleParameter(":yxq", OracleDbType.Date);
            pYxq.Direction = ParameterDirection.Input;
            pYxq.Value = ypkc_kcParam.Yxq;
            sqlparams.Add(pYxq);
            OracleParameter pJj = new OracleParameter(":jj", OracleDbType.Decimal);
            pJj.Direction = ParameterDirection.Input;
            pJj.Value = ypkc_kcParam.Jj;
            sqlparams.Add(pJj);
            OracleParameter pLsj = new OracleParameter(":lsj", OracleDbType.Decimal);
            pLsj.Direction = ParameterDirection.Input;
            pLsj.Value = ypkc_kcParam.Lsj;
            sqlparams.Add(pLsj);
            OracleParameter pSl = new OracleParameter(":sl", OracleDbType.Decimal);
            pSl.Direction = ParameterDirection.Input;
            pSl.Value = ypkc_kcParam.Sl;
            sqlparams.Add(pSl);
            OracleParameter pYksl = new OracleParameter(":yksl", OracleDbType.Decimal);
            pYksl.Direction = ParameterDirection.Input;
            pYksl.Value = ypkc_kcParam.Yksl;
            sqlparams.Add(pYksl);
            OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
            pZfbz.Direction = ParameterDirection.Input;
            pZfbz.Value = ypkc_kcParam.Zfbz;
            sqlparams.Add(pZfbz);
            OracleParameter pYpfl_code = new OracleParameter(":ypfl_code", OracleDbType.NVarchar2);
            pYpfl_code.Direction = ParameterDirection.Input;
            pYpfl_code.Value = ypkc_kcParam.Ypfl_code;
            sqlparams.Add(pYpfl_code);
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
        /// <param name="ypkc_kcParamList">要插入的ypkc_kcParam对象的集合</param>
        /// <param name="con">Oracle连接对象（为null时自动生成）</param>
        /// <returns>是否添加成功（影响的行数等于保存的对象的数量时成功）</returns>
        public bool inertBatch(List<Ypkc_kc> ypkc_kcParamList, OracleConnection con)
        {
            if (ypkc_kcParamList.Count == 0)
            {
                return true;
            }

            List<string> idList = new List<string>();

            List<string> fk_keshi_idList = new List<string>();

            List<string> ksbhList = new List<string>();

            List<string> ksmcList = new List<string>();

            List<string> fk_yp_idList = new List<string>();

            List<string> ypbhList = new List<string>();

            List<string> ypmcList = new List<string>();

            List<string> yptymcList = new List<string>();

            List<string> ypggList = new List<string>();

            List<string> jxList = new List<string>();

            List<string> pymList = new List<string>();

            List<string> ddwList = new List<string>();

            List<string> xdwList = new List<string>();

            List<string> dwlx_codeList = new List<string>();

            List<decimal?> hsblList = new List<decimal?>();

            List<string> pzwhList = new List<string>();

            List<string> gyzzList = new List<string>();

            List<string> cjmcList = new List<string>();

            List<string> phList = new List<string>();

            List<DateTime?> yxqList = new List<DateTime?>();

            List<decimal?> jjList = new List<decimal?>();

            List<decimal?> lsjList = new List<decimal?>();

            List<decimal?> slList = new List<decimal?>();

            List<decimal?> ykslList = new List<decimal?>();

            List<string> zfbzList = new List<string>();

            List<string> ypfl_codeList = new List<string>();

            for (int i = 0; i < ypkc_kcParamList.Count; i++)
            {
                Ypkc_kc ypkc_kcParam = ypkc_kcParamList[i];
                if ("" == ypkc_kcParam.Id || null == ypkc_kcParam.Id)
                {
                    ypkc_kcParam.Id = Model.Common.GUIDHelper.getGuid();
                }

                idList.Add(ypkc_kcParam.Id);

                fk_keshi_idList.Add(ypkc_kcParam.Fk_keshi_id);

                ksbhList.Add(ypkc_kcParam.Ksbh);

                ksmcList.Add(ypkc_kcParam.Ksmc);

                fk_yp_idList.Add(ypkc_kcParam.Fk_yp_id);

                ypbhList.Add(ypkc_kcParam.Ypbh);

                ypmcList.Add(ypkc_kcParam.Ypmc);

                yptymcList.Add(ypkc_kcParam.Yptymc);

                ypggList.Add(ypkc_kcParam.Ypgg);

                jxList.Add(ypkc_kcParam.Jx);

                pymList.Add(ypkc_kcParam.Pym);

                ddwList.Add(ypkc_kcParam.Ddw);

                xdwList.Add(ypkc_kcParam.Xdw);

                dwlx_codeList.Add(ypkc_kcParam.Dwlx_code);

                hsblList.Add(ypkc_kcParam.Hsbl);

                pzwhList.Add(ypkc_kcParam.Pzwh);

                gyzzList.Add(ypkc_kcParam.Gyzz);

                cjmcList.Add(ypkc_kcParam.Cjmc);

                phList.Add(ypkc_kcParam.Ph);

                yxqList.Add(ypkc_kcParam.Yxq);

                jjList.Add(ypkc_kcParam.Jj);

                lsjList.Add(ypkc_kcParam.Lsj);

                slList.Add(ypkc_kcParam.Sl);

                ykslList.Add(ypkc_kcParam.Yksl);

                zfbzList.Add(ypkc_kcParam.Zfbz);

                ypfl_codeList.Add(ypkc_kcParam.Ypfl_code);

            }

            List<OracleParameter> sqlparams = new List<OracleParameter>();

            StringBuilder sql = new StringBuilder("INSERT INTO YPKC_KC(id,fk_keshi_id,ksbh,ksmc,fk_yp_id,ypbh,ypmc,yptymc,ypgg,jx,pym,ddw,xdw,dwlx_code,hsbl,pzwh,gyzz,cjmc,ph,yxq,jj,lsj,sl,yksl,zfbz,ypfl_code) VALUES(:id,:fk_keshi_id,:ksbh,:ksmc,:fk_yp_id,:ypbh,:ypmc,:yptymc,:ypgg,:jx,:pym,:ddw,:xdw,:dwlx_code,:hsbl,:pzwh,:gyzz,:cjmc,:ph,:yxq,:jj,:lsj,:sl,:yksl,:zfbz,:ypfl_code)");

            OracleParameter pId = new OracleParameter(":id", OracleDbType.Varchar2);
            pId.Direction = ParameterDirection.Input;
            pId.Value = idList.ToArray();
            sqlparams.Add(pId);
            OracleParameter pFk_keshi_id = new OracleParameter(":fk_keshi_id", OracleDbType.Varchar2);
            pFk_keshi_id.Direction = ParameterDirection.Input;
            pFk_keshi_id.Value = fk_keshi_idList.ToArray();
            sqlparams.Add(pFk_keshi_id);
            OracleParameter pKsbh = new OracleParameter(":ksbh", OracleDbType.NVarchar2);
            pKsbh.Direction = ParameterDirection.Input;
            pKsbh.Value = ksbhList.ToArray();
            sqlparams.Add(pKsbh);
            OracleParameter pKsmc = new OracleParameter(":ksmc", OracleDbType.NVarchar2);
            pKsmc.Direction = ParameterDirection.Input;
            pKsmc.Value = ksmcList.ToArray();
            sqlparams.Add(pKsmc);
            OracleParameter pFk_yp_id = new OracleParameter(":fk_yp_id", OracleDbType.Varchar2);
            pFk_yp_id.Direction = ParameterDirection.Input;
            pFk_yp_id.Value = fk_yp_idList.ToArray();
            sqlparams.Add(pFk_yp_id);
            OracleParameter pYpbh = new OracleParameter(":ypbh", OracleDbType.NVarchar2);
            pYpbh.Direction = ParameterDirection.Input;
            pYpbh.Value = ypbhList.ToArray();
            sqlparams.Add(pYpbh);
            OracleParameter pYpmc = new OracleParameter(":ypmc", OracleDbType.NVarchar2);
            pYpmc.Direction = ParameterDirection.Input;
            pYpmc.Value = ypmcList.ToArray();
            sqlparams.Add(pYpmc);
            OracleParameter pYptymc = new OracleParameter(":yptymc", OracleDbType.NVarchar2);
            pYptymc.Direction = ParameterDirection.Input;
            pYptymc.Value = yptymcList.ToArray();
            sqlparams.Add(pYptymc);
            OracleParameter pYpgg = new OracleParameter(":ypgg", OracleDbType.NVarchar2);
            pYpgg.Direction = ParameterDirection.Input;
            pYpgg.Value = ypggList.ToArray();
            sqlparams.Add(pYpgg);
            OracleParameter pJx = new OracleParameter(":jx", OracleDbType.NVarchar2);
            pJx.Direction = ParameterDirection.Input;
            pJx.Value = jxList.ToArray();
            sqlparams.Add(pJx);
            OracleParameter pPym = new OracleParameter(":pym", OracleDbType.NVarchar2);
            pPym.Direction = ParameterDirection.Input;
            pPym.Value = pymList.ToArray();
            sqlparams.Add(pPym);
            OracleParameter pDdw = new OracleParameter(":ddw", OracleDbType.NVarchar2);
            pDdw.Direction = ParameterDirection.Input;
            pDdw.Value = ddwList.ToArray();
            sqlparams.Add(pDdw);
            OracleParameter pXdw = new OracleParameter(":xdw", OracleDbType.NVarchar2);
            pXdw.Direction = ParameterDirection.Input;
            pXdw.Value = xdwList.ToArray();
            sqlparams.Add(pXdw);
            OracleParameter pDwlx_code = new OracleParameter(":dwlx_code", OracleDbType.NVarchar2);
            pDwlx_code.Direction = ParameterDirection.Input;
            pDwlx_code.Value = dwlx_codeList.ToArray();
            sqlparams.Add(pDwlx_code);
            OracleParameter pHsbl = new OracleParameter(":hsbl", OracleDbType.Decimal);
            pHsbl.Direction = ParameterDirection.Input;
            pHsbl.Value = hsblList.ToArray();
            sqlparams.Add(pHsbl);
            OracleParameter pPzwh = new OracleParameter(":pzwh", OracleDbType.Varchar2);
            pPzwh.Direction = ParameterDirection.Input;
            pPzwh.Value = pzwhList.ToArray();
            sqlparams.Add(pPzwh);
            OracleParameter pGyzz = new OracleParameter(":gyzz", OracleDbType.Varchar2);
            pGyzz.Direction = ParameterDirection.Input;
            pGyzz.Value = gyzzList.ToArray();
            sqlparams.Add(pGyzz);
            OracleParameter pCjmc = new OracleParameter(":cjmc", OracleDbType.NVarchar2);
            pCjmc.Direction = ParameterDirection.Input;
            pCjmc.Value = cjmcList.ToArray();
            sqlparams.Add(pCjmc);
            OracleParameter pPh = new OracleParameter(":ph", OracleDbType.NVarchar2);
            pPh.Direction = ParameterDirection.Input;
            pPh.Value = phList.ToArray();
            sqlparams.Add(pPh);
            OracleParameter pYxq = new OracleParameter(":yxq", OracleDbType.Date);
            pYxq.Direction = ParameterDirection.Input;
            pYxq.Value = yxqList.ToArray();
            sqlparams.Add(pYxq);
            OracleParameter pJj = new OracleParameter(":jj", OracleDbType.Decimal);
            pJj.Direction = ParameterDirection.Input;
            pJj.Value = jjList.ToArray();
            sqlparams.Add(pJj);
            OracleParameter pLsj = new OracleParameter(":lsj", OracleDbType.Decimal);
            pLsj.Direction = ParameterDirection.Input;
            pLsj.Value = lsjList.ToArray();
            sqlparams.Add(pLsj);
            OracleParameter pSl = new OracleParameter(":sl", OracleDbType.Decimal);
            pSl.Direction = ParameterDirection.Input;
            pSl.Value = slList.ToArray();
            sqlparams.Add(pSl);
            OracleParameter pYksl = new OracleParameter(":yksl", OracleDbType.Decimal);
            pYksl.Direction = ParameterDirection.Input;
            pYksl.Value = ykslList.ToArray();
            sqlparams.Add(pYksl);
            OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
            pZfbz.Direction = ParameterDirection.Input;
            pZfbz.Value = zfbzList.ToArray();
            sqlparams.Add(pZfbz);
            OracleParameter pYpfl_code = new OracleParameter(":ypfl_code", OracleDbType.NVarchar2);
            pYpfl_code.Direction = ParameterDirection.Input;
            pYpfl_code.Value = ypfl_codeList.ToArray();
            sqlparams.Add(pYpfl_code);
            bool result = false;
            int flag = -1;
            flag = OracleHelper.ExecuteBatch(sql.ToString(), con, ypkc_kcParamList.Count, sqlparams.ToArray());
            if (ypkc_kcParamList.Count == flag)
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
            StringBuilder sql = new StringBuilder("DELETE YPKC_KC WHERE ID=:id");
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
            StringBuilder sql = new StringBuilder("DELETE YPKC_KC WHERE ID=:id");
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
        /// <param name="ypkc_kcParamCondition">删除的条件</param>
        /// <param name="con">Oracle连接对象（为null时自动生成）</param>
        /// <returns>无法确定删除的行数（影响行数大于等于0就算成功）</returns>
        public bool deleteByOtherCondition(Ypkc_kc ypkc_kcParamCondition, OracleConnection con)
        {
            if (null != ypkc_kcParamCondition.Id && "" != ypkc_kcParamCondition.Id)
            {
                throw new Exception("不允许指定参数的ID，如果要根据ID删除数据请调用deleteById或者deleteByIdBatch方法；错误出自：deleteByOtherCondition");
            }
            List<OracleParameter> sqlparams = new List<OracleParameter>();
            StringBuilder sql = new StringBuilder("DELETE YPKC_KC ");

            if (null != ypkc_kcParamCondition.Fk_keshi_id && "" != ypkc_kcParamCondition.Fk_keshi_id)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" FK_KESHI_ID=:fk_keshi_id ");
                OracleParameter pFk_keshi_id = new OracleParameter(":fk_keshi_id", OracleDbType.Varchar2);
                pFk_keshi_id.Direction = ParameterDirection.Input;
                pFk_keshi_id.Value = ypkc_kcParamCondition.Fk_keshi_id;
                sqlparams.Add(pFk_keshi_id);

            }

            if (null != ypkc_kcParamCondition.Ksbh && "" != ypkc_kcParamCondition.Ksbh)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" KSBH=:ksbh ");
                OracleParameter pKsbh = new OracleParameter(":ksbh", OracleDbType.NVarchar2);
                pKsbh.Direction = ParameterDirection.Input;
                pKsbh.Value = ypkc_kcParamCondition.Ksbh;
                sqlparams.Add(pKsbh);

            }

            if (null != ypkc_kcParamCondition.Ksmc && "" != ypkc_kcParamCondition.Ksmc)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" KSMC=:ksmc ");
                OracleParameter pKsmc = new OracleParameter(":ksmc", OracleDbType.NVarchar2);
                pKsmc.Direction = ParameterDirection.Input;
                pKsmc.Value = ypkc_kcParamCondition.Ksmc;
                sqlparams.Add(pKsmc);

            }

            if (null != ypkc_kcParamCondition.Fk_yp_id && "" != ypkc_kcParamCondition.Fk_yp_id)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" FK_YP_ID=:fk_yp_id ");
                OracleParameter pFk_yp_id = new OracleParameter(":fk_yp_id", OracleDbType.Varchar2);
                pFk_yp_id.Direction = ParameterDirection.Input;
                pFk_yp_id.Value = ypkc_kcParamCondition.Fk_yp_id;
                sqlparams.Add(pFk_yp_id);

            }

            if (null != ypkc_kcParamCondition.Ypbh && "" != ypkc_kcParamCondition.Ypbh)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" YPBH=:ypbh ");
                OracleParameter pYpbh = new OracleParameter(":ypbh", OracleDbType.NVarchar2);
                pYpbh.Direction = ParameterDirection.Input;
                pYpbh.Value = ypkc_kcParamCondition.Ypbh;
                sqlparams.Add(pYpbh);

            }

            if (null != ypkc_kcParamCondition.Ypmc && "" != ypkc_kcParamCondition.Ypmc)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" YPMC=:ypmc ");
                OracleParameter pYpmc = new OracleParameter(":ypmc", OracleDbType.NVarchar2);
                pYpmc.Direction = ParameterDirection.Input;
                pYpmc.Value = ypkc_kcParamCondition.Ypmc;
                sqlparams.Add(pYpmc);

            }

            if (null != ypkc_kcParamCondition.Yptymc && "" != ypkc_kcParamCondition.Yptymc)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" YPTYMC=:yptymc ");
                OracleParameter pYptymc = new OracleParameter(":yptymc", OracleDbType.NVarchar2);
                pYptymc.Direction = ParameterDirection.Input;
                pYptymc.Value = ypkc_kcParamCondition.Yptymc;
                sqlparams.Add(pYptymc);

            }

            if (null != ypkc_kcParamCondition.Ypgg && "" != ypkc_kcParamCondition.Ypgg)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" YPGG=:ypgg ");
                OracleParameter pYpgg = new OracleParameter(":ypgg", OracleDbType.NVarchar2);
                pYpgg.Direction = ParameterDirection.Input;
                pYpgg.Value = ypkc_kcParamCondition.Ypgg;
                sqlparams.Add(pYpgg);

            }

            if (null != ypkc_kcParamCondition.Jx && "" != ypkc_kcParamCondition.Jx)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" JX=:jx ");
                OracleParameter pJx = new OracleParameter(":jx", OracleDbType.NVarchar2);
                pJx.Direction = ParameterDirection.Input;
                pJx.Value = ypkc_kcParamCondition.Jx;
                sqlparams.Add(pJx);

            }

            if (null != ypkc_kcParamCondition.Pym && "" != ypkc_kcParamCondition.Pym)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" PYM=:pym ");
                OracleParameter pPym = new OracleParameter(":pym", OracleDbType.NVarchar2);
                pPym.Direction = ParameterDirection.Input;
                pPym.Value = ypkc_kcParamCondition.Pym;
                sqlparams.Add(pPym);

            }

            if (null != ypkc_kcParamCondition.Ddw && "" != ypkc_kcParamCondition.Ddw)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" DDW=:ddw ");
                OracleParameter pDdw = new OracleParameter(":ddw", OracleDbType.NVarchar2);
                pDdw.Direction = ParameterDirection.Input;
                pDdw.Value = ypkc_kcParamCondition.Ddw;
                sqlparams.Add(pDdw);

            }

            if (null != ypkc_kcParamCondition.Xdw && "" != ypkc_kcParamCondition.Xdw)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" XDW=:xdw ");
                OracleParameter pXdw = new OracleParameter(":xdw", OracleDbType.NVarchar2);
                pXdw.Direction = ParameterDirection.Input;
                pXdw.Value = ypkc_kcParamCondition.Xdw;
                sqlparams.Add(pXdw);

            }

            if (null != ypkc_kcParamCondition.Dwlx_code && "" != ypkc_kcParamCondition.Dwlx_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" DWLX_CODE=:dwlx_code ");
                OracleParameter pDwlx_code = new OracleParameter(":dwlx_code", OracleDbType.NVarchar2);
                pDwlx_code.Direction = ParameterDirection.Input;
                pDwlx_code.Value = ypkc_kcParamCondition.Dwlx_code;
                sqlparams.Add(pDwlx_code);

            }

            if (null != ypkc_kcParamCondition.Hsbl)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" HSBL=:hsbl ");
                OracleParameter pHsbl = new OracleParameter(":hsbl", OracleDbType.Decimal);
                pHsbl.Direction = ParameterDirection.Input;
                pHsbl.Value = ypkc_kcParamCondition.Hsbl;
                sqlparams.Add(pHsbl);

            }

            if (null != ypkc_kcParamCondition.Pzwh && "" != ypkc_kcParamCondition.Pzwh)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" PZWH=:pzwh ");
                OracleParameter pPzwh = new OracleParameter(":pzwh", OracleDbType.Varchar2);
                pPzwh.Direction = ParameterDirection.Input;
                pPzwh.Value = ypkc_kcParamCondition.Pzwh;
                sqlparams.Add(pPzwh);

            }

            if (null != ypkc_kcParamCondition.Gyzz && "" != ypkc_kcParamCondition.Gyzz)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" GYZZ=:gyzz ");
                OracleParameter pGyzz = new OracleParameter(":gyzz", OracleDbType.Varchar2);
                pGyzz.Direction = ParameterDirection.Input;
                pGyzz.Value = ypkc_kcParamCondition.Gyzz;
                sqlparams.Add(pGyzz);

            }

            if (null != ypkc_kcParamCondition.Cjmc && "" != ypkc_kcParamCondition.Cjmc)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" CJMC=:cjmc ");
                OracleParameter pCjmc = new OracleParameter(":cjmc", OracleDbType.NVarchar2);
                pCjmc.Direction = ParameterDirection.Input;
                pCjmc.Value = ypkc_kcParamCondition.Cjmc;
                sqlparams.Add(pCjmc);

            }

            if (null != ypkc_kcParamCondition.Ph && "" != ypkc_kcParamCondition.Ph)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" PH=:ph ");
                OracleParameter pPh = new OracleParameter(":ph", OracleDbType.NVarchar2);
                pPh.Direction = ParameterDirection.Input;
                pPh.Value = ypkc_kcParamCondition.Ph;
                sqlparams.Add(pPh);

            }

            if (DateTime.MinValue != ypkc_kcParamCondition.Yxq && null != ypkc_kcParamCondition.Yxq)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" YXQ=:yxq ");
                OracleParameter pYxq = new OracleParameter(":yxq", OracleDbType.Date);
                pYxq.Direction = ParameterDirection.Input;
                pYxq.Value = ypkc_kcParamCondition.Yxq;
                sqlparams.Add(pYxq);

            }

            if (null != ypkc_kcParamCondition.Jj)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" JJ=:jj ");
                OracleParameter pJj = new OracleParameter(":jj", OracleDbType.Decimal);
                pJj.Direction = ParameterDirection.Input;
                pJj.Value = ypkc_kcParamCondition.Jj;
                sqlparams.Add(pJj);

            }

            if (null != ypkc_kcParamCondition.Lsj)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" LSJ=:lsj ");
                OracleParameter pLsj = new OracleParameter(":lsj", OracleDbType.Decimal);
                pLsj.Direction = ParameterDirection.Input;
                pLsj.Value = ypkc_kcParamCondition.Lsj;
                sqlparams.Add(pLsj);

            }

            if (null != ypkc_kcParamCondition.Sl)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" SL=:sl ");
                OracleParameter pSl = new OracleParameter(":sl", OracleDbType.Decimal);
                pSl.Direction = ParameterDirection.Input;
                pSl.Value = ypkc_kcParamCondition.Sl;
                sqlparams.Add(pSl);

            }

            if (null != ypkc_kcParamCondition.Yksl)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" YKSL=:yksl ");
                OracleParameter pYksl = new OracleParameter(":yksl", OracleDbType.Decimal);
                pYksl.Direction = ParameterDirection.Input;
                pYksl.Value = ypkc_kcParamCondition.Yksl;
                sqlparams.Add(pYksl);

            }

            if (null != ypkc_kcParamCondition.Zfbz && "" != ypkc_kcParamCondition.Zfbz)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" ZFBZ=:zfbz ");
                OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                pZfbz.Direction = ParameterDirection.Input;
                pZfbz.Value = ypkc_kcParamCondition.Zfbz;
                sqlparams.Add(pZfbz);

            }

            if (null != ypkc_kcParamCondition.Ypfl_code && "" != ypkc_kcParamCondition.Ypfl_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" YPFL_CODE=:ypfl_code ");
                OracleParameter pYpfl_code = new OracleParameter(":ypfl_code", OracleDbType.NVarchar2);
                pYpfl_code.Direction = ParameterDirection.Input;
                pYpfl_code.Value = ypkc_kcParamCondition.Ypfl_code;
                sqlparams.Add(pYpfl_code);

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
        /// <param name="ypkc_kcParam"></param>
        /// <returns>影响的行数</returns>
        public bool updateById(Ypkc_kc ypkc_kcParam, OracleConnection con)
        {
            if ("" == ypkc_kcParam.Id || null == ypkc_kcParam.Id)
            {
                throw new Exception("ID不允许为空，请赋值后调用；错误出自：updateById");
            }
            List<OracleParameter> sqlparams = new List<OracleParameter>();

            StringBuilder sql = new StringBuilder("UPDATE YPKC_KC SET ");
            if (null != ypkc_kcParam.Fk_keshi_id && "" != ypkc_kcParam.Fk_keshi_id)
            {
                this.isComma(sql);
                sql.Append(" FK_KESHI_ID=:fk_keshi_id ");
                OracleParameter pFk_keshi_id = new OracleParameter(":fk_keshi_id", OracleDbType.Varchar2);
                pFk_keshi_id.Direction = ParameterDirection.Input;
                pFk_keshi_id.Value = ypkc_kcParam.Fk_keshi_id;
                sqlparams.Add(pFk_keshi_id);

            }

            if (null != ypkc_kcParam.Ksbh && "" != ypkc_kcParam.Ksbh)
            {
                this.isComma(sql);
                sql.Append(" KSBH=:ksbh ");
                OracleParameter pKsbh = new OracleParameter(":ksbh", OracleDbType.NVarchar2);
                pKsbh.Direction = ParameterDirection.Input;
                pKsbh.Value = ypkc_kcParam.Ksbh;
                sqlparams.Add(pKsbh);

            }

            if (null != ypkc_kcParam.Ksmc && "" != ypkc_kcParam.Ksmc)
            {
                this.isComma(sql);
                sql.Append(" KSMC=:ksmc ");
                OracleParameter pKsmc = new OracleParameter(":ksmc", OracleDbType.NVarchar2);
                pKsmc.Direction = ParameterDirection.Input;
                pKsmc.Value = ypkc_kcParam.Ksmc;
                sqlparams.Add(pKsmc);

            }

            if (null != ypkc_kcParam.Fk_yp_id && "" != ypkc_kcParam.Fk_yp_id)
            {
                this.isComma(sql);
                sql.Append(" FK_YP_ID=:fk_yp_id ");
                OracleParameter pFk_yp_id = new OracleParameter(":fk_yp_id", OracleDbType.Varchar2);
                pFk_yp_id.Direction = ParameterDirection.Input;
                pFk_yp_id.Value = ypkc_kcParam.Fk_yp_id;
                sqlparams.Add(pFk_yp_id);

            }

            if (null != ypkc_kcParam.Ypbh && "" != ypkc_kcParam.Ypbh)
            {
                this.isComma(sql);
                sql.Append(" YPBH=:ypbh ");
                OracleParameter pYpbh = new OracleParameter(":ypbh", OracleDbType.NVarchar2);
                pYpbh.Direction = ParameterDirection.Input;
                pYpbh.Value = ypkc_kcParam.Ypbh;
                sqlparams.Add(pYpbh);

            }

            if (null != ypkc_kcParam.Ypmc && "" != ypkc_kcParam.Ypmc)
            {
                this.isComma(sql);
                sql.Append(" YPMC=:ypmc ");
                OracleParameter pYpmc = new OracleParameter(":ypmc", OracleDbType.NVarchar2);
                pYpmc.Direction = ParameterDirection.Input;
                pYpmc.Value = ypkc_kcParam.Ypmc;
                sqlparams.Add(pYpmc);

            }

            if (null != ypkc_kcParam.Yptymc && "" != ypkc_kcParam.Yptymc)
            {
                this.isComma(sql);
                sql.Append(" YPTYMC=:yptymc ");
                OracleParameter pYptymc = new OracleParameter(":yptymc", OracleDbType.NVarchar2);
                pYptymc.Direction = ParameterDirection.Input;
                pYptymc.Value = ypkc_kcParam.Yptymc;
                sqlparams.Add(pYptymc);

            }

            if (null != ypkc_kcParam.Ypgg && "" != ypkc_kcParam.Ypgg)
            {
                this.isComma(sql);
                sql.Append(" YPGG=:ypgg ");
                OracleParameter pYpgg = new OracleParameter(":ypgg", OracleDbType.NVarchar2);
                pYpgg.Direction = ParameterDirection.Input;
                pYpgg.Value = ypkc_kcParam.Ypgg;
                sqlparams.Add(pYpgg);

            }

            if (null != ypkc_kcParam.Jx && "" != ypkc_kcParam.Jx)
            {
                this.isComma(sql);
                sql.Append(" JX=:jx ");
                OracleParameter pJx = new OracleParameter(":jx", OracleDbType.NVarchar2);
                pJx.Direction = ParameterDirection.Input;
                pJx.Value = ypkc_kcParam.Jx;
                sqlparams.Add(pJx);

            }

            if (null != ypkc_kcParam.Pym && "" != ypkc_kcParam.Pym)
            {
                this.isComma(sql);
                sql.Append(" PYM=:pym ");
                OracleParameter pPym = new OracleParameter(":pym", OracleDbType.NVarchar2);
                pPym.Direction = ParameterDirection.Input;
                pPym.Value = ypkc_kcParam.Pym;
                sqlparams.Add(pPym);

            }

            if (null != ypkc_kcParam.Ddw && "" != ypkc_kcParam.Ddw)
            {
                this.isComma(sql);
                sql.Append(" DDW=:ddw ");
                OracleParameter pDdw = new OracleParameter(":ddw", OracleDbType.NVarchar2);
                pDdw.Direction = ParameterDirection.Input;
                pDdw.Value = ypkc_kcParam.Ddw;
                sqlparams.Add(pDdw);

            }

            if (null != ypkc_kcParam.Xdw && "" != ypkc_kcParam.Xdw)
            {
                this.isComma(sql);
                sql.Append(" XDW=:xdw ");
                OracleParameter pXdw = new OracleParameter(":xdw", OracleDbType.NVarchar2);
                pXdw.Direction = ParameterDirection.Input;
                pXdw.Value = ypkc_kcParam.Xdw;
                sqlparams.Add(pXdw);

            }

            if (null != ypkc_kcParam.Dwlx_code && "" != ypkc_kcParam.Dwlx_code)
            {
                this.isComma(sql);
                sql.Append(" DWLX_CODE=:dwlx_code ");
                OracleParameter pDwlx_code = new OracleParameter(":dwlx_code", OracleDbType.NVarchar2);
                pDwlx_code.Direction = ParameterDirection.Input;
                pDwlx_code.Value = ypkc_kcParam.Dwlx_code;
                sqlparams.Add(pDwlx_code);

            }

            if (null != ypkc_kcParam.Hsbl)
            {
                this.isComma(sql);
                sql.Append(" HSBL=:hsbl ");
                OracleParameter pHsbl = new OracleParameter(":hsbl", OracleDbType.Decimal);
                pHsbl.Direction = ParameterDirection.Input;
                pHsbl.Value = ypkc_kcParam.Hsbl;
                sqlparams.Add(pHsbl);

            }

            if (null != ypkc_kcParam.Pzwh && "" != ypkc_kcParam.Pzwh)
            {
                this.isComma(sql);
                sql.Append(" PZWH=:pzwh ");
                OracleParameter pPzwh = new OracleParameter(":pzwh", OracleDbType.Varchar2);
                pPzwh.Direction = ParameterDirection.Input;
                pPzwh.Value = ypkc_kcParam.Pzwh;
                sqlparams.Add(pPzwh);

            }

            if (null != ypkc_kcParam.Gyzz && "" != ypkc_kcParam.Gyzz)
            {
                this.isComma(sql);
                sql.Append(" GYZZ=:gyzz ");
                OracleParameter pGyzz = new OracleParameter(":gyzz", OracleDbType.Varchar2);
                pGyzz.Direction = ParameterDirection.Input;
                pGyzz.Value = ypkc_kcParam.Gyzz;
                sqlparams.Add(pGyzz);

            }

            if (null != ypkc_kcParam.Cjmc && "" != ypkc_kcParam.Cjmc)
            {
                this.isComma(sql);
                sql.Append(" CJMC=:cjmc ");
                OracleParameter pCjmc = new OracleParameter(":cjmc", OracleDbType.NVarchar2);
                pCjmc.Direction = ParameterDirection.Input;
                pCjmc.Value = ypkc_kcParam.Cjmc;
                sqlparams.Add(pCjmc);

            }

            if (null != ypkc_kcParam.Ph && "" != ypkc_kcParam.Ph)
            {
                this.isComma(sql);
                sql.Append(" PH=:ph ");
                OracleParameter pPh = new OracleParameter(":ph", OracleDbType.NVarchar2);
                pPh.Direction = ParameterDirection.Input;
                pPh.Value = ypkc_kcParam.Ph;
                sqlparams.Add(pPh);

            }

            if (DateTime.MinValue != ypkc_kcParam.Yxq && null != ypkc_kcParam.Yxq)
            {
                this.isComma(sql);
                sql.Append(" YXQ=:yxq ");
                OracleParameter pYxq = new OracleParameter(":yxq", OracleDbType.Date);
                pYxq.Direction = ParameterDirection.Input;
                pYxq.Value = ypkc_kcParam.Yxq;
                sqlparams.Add(pYxq);

            }

            if (null != ypkc_kcParam.Jj)
            {
                this.isComma(sql);
                sql.Append(" JJ=:jj ");
                OracleParameter pJj = new OracleParameter(":jj", OracleDbType.Decimal);
                pJj.Direction = ParameterDirection.Input;
                pJj.Value = ypkc_kcParam.Jj;
                sqlparams.Add(pJj);

            }

            if (null != ypkc_kcParam.Lsj)
            {
                this.isComma(sql);
                sql.Append(" LSJ=:lsj ");
                OracleParameter pLsj = new OracleParameter(":lsj", OracleDbType.Decimal);
                pLsj.Direction = ParameterDirection.Input;
                pLsj.Value = ypkc_kcParam.Lsj;
                sqlparams.Add(pLsj);

            }

            if (null != ypkc_kcParam.Sl)
            {
                this.isComma(sql);
                sql.Append(" SL=:sl ");
                OracleParameter pSl = new OracleParameter(":sl", OracleDbType.Decimal);
                pSl.Direction = ParameterDirection.Input;
                pSl.Value = ypkc_kcParam.Sl;
                sqlparams.Add(pSl);

            }

            if (null != ypkc_kcParam.Yksl)
            {
                this.isComma(sql);
                sql.Append(" YKSL=:yksl ");
                OracleParameter pYksl = new OracleParameter(":yksl", OracleDbType.Decimal);
                pYksl.Direction = ParameterDirection.Input;
                pYksl.Value = ypkc_kcParam.Yksl;
                sqlparams.Add(pYksl);

            }

            if (null != ypkc_kcParam.Zfbz && "" != ypkc_kcParam.Zfbz)
            {
                this.isComma(sql);
                sql.Append(" ZFBZ=:zfbz ");
                OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                pZfbz.Direction = ParameterDirection.Input;
                pZfbz.Value = ypkc_kcParam.Zfbz;
                sqlparams.Add(pZfbz);

            }

            if (null != ypkc_kcParam.Ypfl_code && "" != ypkc_kcParam.Ypfl_code)
            {
                this.isComma(sql);
                sql.Append(" YPFL_CODE=:ypfl_code ");
                OracleParameter pYpfl_code = new OracleParameter(":ypfl_code", OracleDbType.NVarchar2);
                pYpfl_code.Direction = ParameterDirection.Input;
                pYpfl_code.Value = ypkc_kcParam.Ypfl_code;
                sqlparams.Add(pYpfl_code);

            }

            sql.Append(" WHERE ID=:id ");
            OracleParameter pId = new OracleParameter(":id", OracleDbType.Varchar2);
            pId.Value = ypkc_kcParam.Id;
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
        /// <param name="ypkc_kcParamList">要修改的Ypkc_kc对象集合</param>
        /// <param name="con">Oracle连接对象（为null时自动生成）</param>
        /// <returns>是否删除成功（影响的行数等于要修改的对象数量时成功）</returns>
        public bool updateByIdBatch(List<Ypkc_kc> ypkc_kcParamList, OracleConnection con)
        {


            List<string> idList = new List<string>();

            List<string> fk_keshi_idList = new List<string>();

            List<string> ksbhList = new List<string>();

            List<string> ksmcList = new List<string>();

            List<string> fk_yp_idList = new List<string>();

            List<string> ypbhList = new List<string>();

            List<string> ypmcList = new List<string>();

            List<string> yptymcList = new List<string>();

            List<string> ypggList = new List<string>();

            List<string> jxList = new List<string>();

            List<string> pymList = new List<string>();

            List<string> ddwList = new List<string>();

            List<string> xdwList = new List<string>();

            List<string> dwlx_codeList = new List<string>();

            List<decimal?> hsblList = new List<decimal?>();

            List<string> pzwhList = new List<string>();

            List<string> gyzzList = new List<string>();

            List<string> cjmcList = new List<string>();

            List<string> phList = new List<string>();

            List<DateTime?> yxqList = new List<DateTime?>();

            List<decimal?> jjList = new List<decimal?>();

            List<decimal?> lsjList = new List<decimal?>();

            List<decimal?> slList = new List<decimal?>();

            List<decimal?> ykslList = new List<decimal?>();

            List<string> zfbzList = new List<string>();

            List<string> ypfl_codeList = new List<string>();

            for (int i = 0; i < ypkc_kcParamList.Count; i++)
            {
                Ypkc_kc ypkc_kcParam = ypkc_kcParamList[i];
                if ("" == ypkc_kcParam.Id || null == ypkc_kcParam.Id)
                {
                    throw new Exception("下标为" + i + "的数据，ID不能为空，请赋值后调用；错误出自：updateByIdBatch");
                }

                idList.Add(ypkc_kcParam.Id);

                fk_keshi_idList.Add(ypkc_kcParam.Fk_keshi_id);

                ksbhList.Add(ypkc_kcParam.Ksbh);

                ksmcList.Add(ypkc_kcParam.Ksmc);

                fk_yp_idList.Add(ypkc_kcParam.Fk_yp_id);

                ypbhList.Add(ypkc_kcParam.Ypbh);

                ypmcList.Add(ypkc_kcParam.Ypmc);

                yptymcList.Add(ypkc_kcParam.Yptymc);

                ypggList.Add(ypkc_kcParam.Ypgg);

                jxList.Add(ypkc_kcParam.Jx);

                pymList.Add(ypkc_kcParam.Pym);

                ddwList.Add(ypkc_kcParam.Ddw);

                xdwList.Add(ypkc_kcParam.Xdw);

                dwlx_codeList.Add(ypkc_kcParam.Dwlx_code);

                hsblList.Add(ypkc_kcParam.Hsbl);

                pzwhList.Add(ypkc_kcParam.Pzwh);

                gyzzList.Add(ypkc_kcParam.Gyzz);

                cjmcList.Add(ypkc_kcParam.Cjmc);

                phList.Add(ypkc_kcParam.Ph);

                yxqList.Add(ypkc_kcParam.Yxq);

                jjList.Add(ypkc_kcParam.Jj);

                lsjList.Add(ypkc_kcParam.Lsj);

                slList.Add(ypkc_kcParam.Sl);

                ykslList.Add(ypkc_kcParam.Yksl);

                zfbzList.Add(ypkc_kcParam.Zfbz);

                ypfl_codeList.Add(ypkc_kcParam.Ypfl_code);

            }



            List<OracleParameter> sqlparams = new List<OracleParameter>();

            StringBuilder sql = new StringBuilder("UPDATE YPKC_KC SET ");
            this.isComma(sql);
            sql.Append(" FK_KESHI_ID=:fk_keshi_id ");
            OracleParameter pFk_keshi_id = new OracleParameter(":fk_keshi_id", OracleDbType.Varchar2);
            pFk_keshi_id.Direction = ParameterDirection.Input;
            pFk_keshi_id.Value = fk_keshi_idList.ToArray();
            sqlparams.Add(pFk_keshi_id);

            this.isComma(sql);
            sql.Append(" KSBH=:ksbh ");
            OracleParameter pKsbh = new OracleParameter(":ksbh", OracleDbType.NVarchar2);
            pKsbh.Direction = ParameterDirection.Input;
            pKsbh.Value = ksbhList.ToArray();
            sqlparams.Add(pKsbh);

            this.isComma(sql);
            sql.Append(" KSMC=:ksmc ");
            OracleParameter pKsmc = new OracleParameter(":ksmc", OracleDbType.NVarchar2);
            pKsmc.Direction = ParameterDirection.Input;
            pKsmc.Value = ksmcList.ToArray();
            sqlparams.Add(pKsmc);

            this.isComma(sql);
            sql.Append(" FK_YP_ID=:fk_yp_id ");
            OracleParameter pFk_yp_id = new OracleParameter(":fk_yp_id", OracleDbType.Varchar2);
            pFk_yp_id.Direction = ParameterDirection.Input;
            pFk_yp_id.Value = fk_yp_idList.ToArray();
            sqlparams.Add(pFk_yp_id);

            this.isComma(sql);
            sql.Append(" YPBH=:ypbh ");
            OracleParameter pYpbh = new OracleParameter(":ypbh", OracleDbType.NVarchar2);
            pYpbh.Direction = ParameterDirection.Input;
            pYpbh.Value = ypbhList.ToArray();
            sqlparams.Add(pYpbh);

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
            sql.Append(" YPGG=:ypgg ");
            OracleParameter pYpgg = new OracleParameter(":ypgg", OracleDbType.NVarchar2);
            pYpgg.Direction = ParameterDirection.Input;
            pYpgg.Value = ypggList.ToArray();
            sqlparams.Add(pYpgg);

            this.isComma(sql);
            sql.Append(" JX=:jx ");
            OracleParameter pJx = new OracleParameter(":jx", OracleDbType.NVarchar2);
            pJx.Direction = ParameterDirection.Input;
            pJx.Value = jxList.ToArray();
            sqlparams.Add(pJx);

            this.isComma(sql);
            sql.Append(" PYM=:pym ");
            OracleParameter pPym = new OracleParameter(":pym", OracleDbType.NVarchar2);
            pPym.Direction = ParameterDirection.Input;
            pPym.Value = pymList.ToArray();
            sqlparams.Add(pPym);

            this.isComma(sql);
            sql.Append(" DDW=:ddw ");
            OracleParameter pDdw = new OracleParameter(":ddw", OracleDbType.NVarchar2);
            pDdw.Direction = ParameterDirection.Input;
            pDdw.Value = ddwList.ToArray();
            sqlparams.Add(pDdw);

            this.isComma(sql);
            sql.Append(" XDW=:xdw ");
            OracleParameter pXdw = new OracleParameter(":xdw", OracleDbType.NVarchar2);
            pXdw.Direction = ParameterDirection.Input;
            pXdw.Value = xdwList.ToArray();
            sqlparams.Add(pXdw);

            this.isComma(sql);
            sql.Append(" DWLX_CODE=:dwlx_code ");
            OracleParameter pDwlx_code = new OracleParameter(":dwlx_code", OracleDbType.NVarchar2);
            pDwlx_code.Direction = ParameterDirection.Input;
            pDwlx_code.Value = dwlx_codeList.ToArray();
            sqlparams.Add(pDwlx_code);

            this.isComma(sql);
            sql.Append(" HSBL=:hsbl ");
            OracleParameter pHsbl = new OracleParameter(":hsbl", OracleDbType.Decimal);
            pHsbl.Direction = ParameterDirection.Input;
            pHsbl.Value = hsblList.ToArray();
            sqlparams.Add(pHsbl);

            this.isComma(sql);
            sql.Append(" PZWH=:pzwh ");
            OracleParameter pPzwh = new OracleParameter(":pzwh", OracleDbType.Varchar2);
            pPzwh.Direction = ParameterDirection.Input;
            pPzwh.Value = pzwhList.ToArray();
            sqlparams.Add(pPzwh);

            this.isComma(sql);
            sql.Append(" GYZZ=:gyzz ");
            OracleParameter pGyzz = new OracleParameter(":gyzz", OracleDbType.Varchar2);
            pGyzz.Direction = ParameterDirection.Input;
            pGyzz.Value = gyzzList.ToArray();
            sqlparams.Add(pGyzz);

            this.isComma(sql);
            sql.Append(" CJMC=:cjmc ");
            OracleParameter pCjmc = new OracleParameter(":cjmc", OracleDbType.NVarchar2);
            pCjmc.Direction = ParameterDirection.Input;
            pCjmc.Value = cjmcList.ToArray();
            sqlparams.Add(pCjmc);

            this.isComma(sql);
            sql.Append(" PH=:ph ");
            OracleParameter pPh = new OracleParameter(":ph", OracleDbType.NVarchar2);
            pPh.Direction = ParameterDirection.Input;
            pPh.Value = phList.ToArray();
            sqlparams.Add(pPh);

            this.isComma(sql);
            sql.Append(" YXQ=:yxq ");
            OracleParameter pYxq = new OracleParameter(":yxq", OracleDbType.Date);
            pYxq.Direction = ParameterDirection.Input;
            pYxq.Value = yxqList.ToArray();
            sqlparams.Add(pYxq);

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
            sql.Append(" SL=:sl ");
            OracleParameter pSl = new OracleParameter(":sl", OracleDbType.Decimal);
            pSl.Direction = ParameterDirection.Input;
            pSl.Value = slList.ToArray();
            sqlparams.Add(pSl);

            this.isComma(sql);
            sql.Append(" YKSL=:yksl ");
            OracleParameter pYksl = new OracleParameter(":yksl", OracleDbType.Decimal);
            pYksl.Direction = ParameterDirection.Input;
            pYksl.Value = ykslList.ToArray();
            sqlparams.Add(pYksl);

            this.isComma(sql);
            sql.Append(" ZFBZ=:zfbz ");
            OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
            pZfbz.Direction = ParameterDirection.Input;
            pZfbz.Value = zfbzList.ToArray();
            sqlparams.Add(pZfbz);

            this.isComma(sql);
            sql.Append(" YPFL_CODE=:ypfl_code ");
            OracleParameter pYpfl_code = new OracleParameter(":ypfl_code", OracleDbType.NVarchar2);
            pYpfl_code.Direction = ParameterDirection.Input;
            pYpfl_code.Value = ypfl_codeList.ToArray();
            sqlparams.Add(pYpfl_code);

            sql.Append(" WHERE ID=:id ");
            OracleParameter pId = new OracleParameter(":id", OracleDbType.Varchar2);
            pId.Value = idList.ToArray();
            sqlparams.Add(pId);
            this.b_isComma = false;
            bool result = false;
            int flag = OracleHelper.ExecuteBatch(sql.ToString(), con, ypkc_kcParamList.Count, sqlparams.ToArray());
            if (ypkc_kcParamList.Count == flag)
            {
                result = true;
            }
            return result;
        }

        /// <summary>
        /// 根据更新的条件，更新数据（如果需要供事务使用就传入OracleConnection对象，如果不供就传入null，方法自动生成OracleConnection对象）
        /// 不指定ID，如果要根据ID来更新数据，请使用updateForId方法
        /// </summary>
        /// <param name="ypkc_kcParamCondition">条件对象</param>
        /// <param name="ypkc_kcParamUpdate">要更新的数据对象</param>
        /// <param name="con">Oracle连接对象（为null时自动生成）</param>
        /// <returns>影响的行数不确定（不为-1就正确）</returns>
        public bool updateByOtherCondition(Ypkc_kc ypkc_kcParamCondition, Ypkc_kc ypkc_kcParamUpdate, OracleConnection con)
        {
            if ((null != ypkc_kcParamCondition.Id && "!=ypkc_kcParamCondition.Id)||(null!=ypkc_kcParamUpdate.Id&&" != ypkc_kcParamUpdate.Id))
            {
                throw new Exception("此方法不允许指定参数的ID，数据库中的ID不允许修改，如需根据ID修改数据，请调用updateById或updateByIdBatch方法；错误出自：updateByOtherCondition");
            }
            List<OracleParameter> sqlparams = new List<OracleParameter>();
            //添加要修改的值
            StringBuilder sql = new StringBuilder("UPDATE YPKC_KC SET ");
            if (null != ypkc_kcParamUpdate.Fk_keshi_id && "" != ypkc_kcParamUpdate.Fk_keshi_id)
            {
                this.isComma(sql);
                sql.Append(" FK_KESHI_ID=:fk_keshi_id ");
                OracleParameter pFk_keshi_id = new OracleParameter(":fk_keshi_id", OracleDbType.Varchar2);
                pFk_keshi_id.Direction = ParameterDirection.Input;
                pFk_keshi_id.Value = ypkc_kcParamUpdate.Fk_keshi_id;
                sqlparams.Add(pFk_keshi_id);

            }

            if (null != ypkc_kcParamUpdate.Ksbh && "" != ypkc_kcParamUpdate.Ksbh)
            {
                this.isComma(sql);
                sql.Append(" KSBH=:ksbh ");
                OracleParameter pKsbh = new OracleParameter(":ksbh", OracleDbType.NVarchar2);
                pKsbh.Direction = ParameterDirection.Input;
                pKsbh.Value = ypkc_kcParamUpdate.Ksbh;
                sqlparams.Add(pKsbh);

            }

            if (null != ypkc_kcParamUpdate.Ksmc && "" != ypkc_kcParamUpdate.Ksmc)
            {
                this.isComma(sql);
                sql.Append(" KSMC=:ksmc ");
                OracleParameter pKsmc = new OracleParameter(":ksmc", OracleDbType.NVarchar2);
                pKsmc.Direction = ParameterDirection.Input;
                pKsmc.Value = ypkc_kcParamUpdate.Ksmc;
                sqlparams.Add(pKsmc);

            }

            if (null != ypkc_kcParamUpdate.Fk_yp_id && "" != ypkc_kcParamUpdate.Fk_yp_id)
            {
                this.isComma(sql);
                sql.Append(" FK_YP_ID=:fk_yp_id ");
                OracleParameter pFk_yp_id = new OracleParameter(":fk_yp_id", OracleDbType.Varchar2);
                pFk_yp_id.Direction = ParameterDirection.Input;
                pFk_yp_id.Value = ypkc_kcParamUpdate.Fk_yp_id;
                sqlparams.Add(pFk_yp_id);

            }

            if (null != ypkc_kcParamUpdate.Ypbh && "" != ypkc_kcParamUpdate.Ypbh)
            {
                this.isComma(sql);
                sql.Append(" YPBH=:ypbh ");
                OracleParameter pYpbh = new OracleParameter(":ypbh", OracleDbType.NVarchar2);
                pYpbh.Direction = ParameterDirection.Input;
                pYpbh.Value = ypkc_kcParamUpdate.Ypbh;
                sqlparams.Add(pYpbh);

            }

            if (null != ypkc_kcParamUpdate.Ypmc && "" != ypkc_kcParamUpdate.Ypmc)
            {
                this.isComma(sql);
                sql.Append(" YPMC=:ypmc ");
                OracleParameter pYpmc = new OracleParameter(":ypmc", OracleDbType.NVarchar2);
                pYpmc.Direction = ParameterDirection.Input;
                pYpmc.Value = ypkc_kcParamUpdate.Ypmc;
                sqlparams.Add(pYpmc);

            }

            if (null != ypkc_kcParamUpdate.Yptymc && "" != ypkc_kcParamUpdate.Yptymc)
            {
                this.isComma(sql);
                sql.Append(" YPTYMC=:yptymc ");
                OracleParameter pYptymc = new OracleParameter(":yptymc", OracleDbType.NVarchar2);
                pYptymc.Direction = ParameterDirection.Input;
                pYptymc.Value = ypkc_kcParamUpdate.Yptymc;
                sqlparams.Add(pYptymc);

            }

            if (null != ypkc_kcParamUpdate.Ypgg && "" != ypkc_kcParamUpdate.Ypgg)
            {
                this.isComma(sql);
                sql.Append(" YPGG=:ypgg ");
                OracleParameter pYpgg = new OracleParameter(":ypgg", OracleDbType.NVarchar2);
                pYpgg.Direction = ParameterDirection.Input;
                pYpgg.Value = ypkc_kcParamUpdate.Ypgg;
                sqlparams.Add(pYpgg);

            }

            if (null != ypkc_kcParamUpdate.Jx && "" != ypkc_kcParamUpdate.Jx)
            {
                this.isComma(sql);
                sql.Append(" JX=:jx ");
                OracleParameter pJx = new OracleParameter(":jx", OracleDbType.NVarchar2);
                pJx.Direction = ParameterDirection.Input;
                pJx.Value = ypkc_kcParamUpdate.Jx;
                sqlparams.Add(pJx);

            }

            if (null != ypkc_kcParamUpdate.Pym && "" != ypkc_kcParamUpdate.Pym)
            {
                this.isComma(sql);
                sql.Append(" PYM=:pym ");
                OracleParameter pPym = new OracleParameter(":pym", OracleDbType.NVarchar2);
                pPym.Direction = ParameterDirection.Input;
                pPym.Value = ypkc_kcParamUpdate.Pym;
                sqlparams.Add(pPym);

            }

            if (null != ypkc_kcParamUpdate.Ddw && "" != ypkc_kcParamUpdate.Ddw)
            {
                this.isComma(sql);
                sql.Append(" DDW=:ddw ");
                OracleParameter pDdw = new OracleParameter(":ddw", OracleDbType.NVarchar2);
                pDdw.Direction = ParameterDirection.Input;
                pDdw.Value = ypkc_kcParamUpdate.Ddw;
                sqlparams.Add(pDdw);

            }

            if (null != ypkc_kcParamUpdate.Xdw && "" != ypkc_kcParamUpdate.Xdw)
            {
                this.isComma(sql);
                sql.Append(" XDW=:xdw ");
                OracleParameter pXdw = new OracleParameter(":xdw", OracleDbType.NVarchar2);
                pXdw.Direction = ParameterDirection.Input;
                pXdw.Value = ypkc_kcParamUpdate.Xdw;
                sqlparams.Add(pXdw);

            }

            if (null != ypkc_kcParamUpdate.Dwlx_code && "" != ypkc_kcParamUpdate.Dwlx_code)
            {
                this.isComma(sql);
                sql.Append(" DWLX_CODE=:dwlx_code ");
                OracleParameter pDwlx_code = new OracleParameter(":dwlx_code", OracleDbType.NVarchar2);
                pDwlx_code.Direction = ParameterDirection.Input;
                pDwlx_code.Value = ypkc_kcParamUpdate.Dwlx_code;
                sqlparams.Add(pDwlx_code);

            }

            if (null != ypkc_kcParamUpdate.Hsbl)
            {
                this.isComma(sql);
                sql.Append(" HSBL=:hsbl ");
                OracleParameter pHsbl = new OracleParameter(":hsbl", OracleDbType.Decimal);
                pHsbl.Direction = ParameterDirection.Input;
                pHsbl.Value = ypkc_kcParamUpdate.Hsbl;
                sqlparams.Add(pHsbl);

            }

            if (null != ypkc_kcParamUpdate.Pzwh && "" != ypkc_kcParamUpdate.Pzwh)
            {
                this.isComma(sql);
                sql.Append(" PZWH=:pzwh ");
                OracleParameter pPzwh = new OracleParameter(":pzwh", OracleDbType.Varchar2);
                pPzwh.Direction = ParameterDirection.Input;
                pPzwh.Value = ypkc_kcParamUpdate.Pzwh;
                sqlparams.Add(pPzwh);

            }

            if (null != ypkc_kcParamUpdate.Gyzz && "" != ypkc_kcParamUpdate.Gyzz)
            {
                this.isComma(sql);
                sql.Append(" GYZZ=:gyzz ");
                OracleParameter pGyzz = new OracleParameter(":gyzz", OracleDbType.Varchar2);
                pGyzz.Direction = ParameterDirection.Input;
                pGyzz.Value = ypkc_kcParamUpdate.Gyzz;
                sqlparams.Add(pGyzz);

            }

            if (null != ypkc_kcParamUpdate.Cjmc && "" != ypkc_kcParamUpdate.Cjmc)
            {
                this.isComma(sql);
                sql.Append(" CJMC=:cjmc ");
                OracleParameter pCjmc = new OracleParameter(":cjmc", OracleDbType.NVarchar2);
                pCjmc.Direction = ParameterDirection.Input;
                pCjmc.Value = ypkc_kcParamUpdate.Cjmc;
                sqlparams.Add(pCjmc);

            }

            if (null != ypkc_kcParamUpdate.Ph && "" != ypkc_kcParamUpdate.Ph)
            {
                this.isComma(sql);
                sql.Append(" PH=:ph ");
                OracleParameter pPh = new OracleParameter(":ph", OracleDbType.NVarchar2);
                pPh.Direction = ParameterDirection.Input;
                pPh.Value = ypkc_kcParamUpdate.Ph;
                sqlparams.Add(pPh);

            }

            if (DateTime.MinValue != ypkc_kcParamUpdate.Yxq && null != ypkc_kcParamUpdate.Yxq)
            {
                this.isComma(sql);
                sql.Append(" YXQ=:yxq ");
                OracleParameter pYxq = new OracleParameter(":yxq", OracleDbType.Date);
                pYxq.Direction = ParameterDirection.Input;
                pYxq.Value = ypkc_kcParamUpdate.Yxq;
                sqlparams.Add(pYxq);

            }

            if (null != ypkc_kcParamUpdate.Jj)
            {
                this.isComma(sql);
                sql.Append(" JJ=:jj ");
                OracleParameter pJj = new OracleParameter(":jj", OracleDbType.Decimal);
                pJj.Direction = ParameterDirection.Input;
                pJj.Value = ypkc_kcParamUpdate.Jj;
                sqlparams.Add(pJj);

            }

            if (null != ypkc_kcParamUpdate.Lsj)
            {
                this.isComma(sql);
                sql.Append(" LSJ=:lsj ");
                OracleParameter pLsj = new OracleParameter(":lsj", OracleDbType.Decimal);
                pLsj.Direction = ParameterDirection.Input;
                pLsj.Value = ypkc_kcParamUpdate.Lsj;
                sqlparams.Add(pLsj);

            }

            if (null != ypkc_kcParamUpdate.Sl)
            {
                this.isComma(sql);
                sql.Append(" SL=:sl ");
                OracleParameter pSl = new OracleParameter(":sl", OracleDbType.Decimal);
                pSl.Direction = ParameterDirection.Input;
                pSl.Value = ypkc_kcParamUpdate.Sl;
                sqlparams.Add(pSl);

            }

            if (null != ypkc_kcParamUpdate.Yksl)
            {
                this.isComma(sql);
                sql.Append(" YKSL=:yksl ");
                OracleParameter pYksl = new OracleParameter(":yksl", OracleDbType.Decimal);
                pYksl.Direction = ParameterDirection.Input;
                pYksl.Value = ypkc_kcParamUpdate.Yksl;
                sqlparams.Add(pYksl);

            }

            if (null != ypkc_kcParamUpdate.Zfbz && "" != ypkc_kcParamUpdate.Zfbz)
            {
                this.isComma(sql);
                sql.Append(" ZFBZ=:zfbz ");
                OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                pZfbz.Direction = ParameterDirection.Input;
                pZfbz.Value = ypkc_kcParamUpdate.Zfbz;
                sqlparams.Add(pZfbz);

            }

            if (null != ypkc_kcParamUpdate.Ypfl_code && "" != ypkc_kcParamUpdate.Ypfl_code)
            {
                this.isComma(sql);
                sql.Append(" YPFL_CODE=:ypfl_code ");
                OracleParameter pYpfl_code = new OracleParameter(":ypfl_code", OracleDbType.NVarchar2);
                pYpfl_code.Direction = ParameterDirection.Input;
                pYpfl_code.Value = ypkc_kcParamUpdate.Ypfl_code;
                sqlparams.Add(pYpfl_code);

            }

            //添加条件的参数

            if (null != ypkc_kcParamCondition.Fk_keshi_id && "" != ypkc_kcParamCondition.Fk_keshi_id)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" FK_KESHI_ID=:fk_keshi_id ");
                OracleParameter pFk_keshi_id = new OracleParameter(":fk_keshi_id", OracleDbType.Varchar2);
                pFk_keshi_id.Direction = ParameterDirection.Input;
                pFk_keshi_id.Value = ypkc_kcParamCondition.Fk_keshi_id;
                sqlparams.Add(pFk_keshi_id);

            }

            if (null != ypkc_kcParamCondition.Ksbh && "" != ypkc_kcParamCondition.Ksbh)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" KSBH=:ksbh ");
                OracleParameter pKsbh = new OracleParameter(":ksbh", OracleDbType.NVarchar2);
                pKsbh.Direction = ParameterDirection.Input;
                pKsbh.Value = ypkc_kcParamCondition.Ksbh;
                sqlparams.Add(pKsbh);

            }

            if (null != ypkc_kcParamCondition.Ksmc && "" != ypkc_kcParamCondition.Ksmc)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" KSMC=:ksmc ");
                OracleParameter pKsmc = new OracleParameter(":ksmc", OracleDbType.NVarchar2);
                pKsmc.Direction = ParameterDirection.Input;
                pKsmc.Value = ypkc_kcParamCondition.Ksmc;
                sqlparams.Add(pKsmc);

            }

            if (null != ypkc_kcParamCondition.Fk_yp_id && "" != ypkc_kcParamCondition.Fk_yp_id)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" FK_YP_ID=:fk_yp_id ");
                OracleParameter pFk_yp_id = new OracleParameter(":fk_yp_id", OracleDbType.Varchar2);
                pFk_yp_id.Direction = ParameterDirection.Input;
                pFk_yp_id.Value = ypkc_kcParamCondition.Fk_yp_id;
                sqlparams.Add(pFk_yp_id);

            }

            if (null != ypkc_kcParamCondition.Ypbh && "" != ypkc_kcParamCondition.Ypbh)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" YPBH=:ypbh ");
                OracleParameter pYpbh = new OracleParameter(":ypbh", OracleDbType.NVarchar2);
                pYpbh.Direction = ParameterDirection.Input;
                pYpbh.Value = ypkc_kcParamCondition.Ypbh;
                sqlparams.Add(pYpbh);

            }

            if (null != ypkc_kcParamCondition.Ypmc && "" != ypkc_kcParamCondition.Ypmc)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" YPMC=:ypmc ");
                OracleParameter pYpmc = new OracleParameter(":ypmc", OracleDbType.NVarchar2);
                pYpmc.Direction = ParameterDirection.Input;
                pYpmc.Value = ypkc_kcParamCondition.Ypmc;
                sqlparams.Add(pYpmc);

            }

            if (null != ypkc_kcParamCondition.Yptymc && "" != ypkc_kcParamCondition.Yptymc)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" YPTYMC=:yptymc ");
                OracleParameter pYptymc = new OracleParameter(":yptymc", OracleDbType.NVarchar2);
                pYptymc.Direction = ParameterDirection.Input;
                pYptymc.Value = ypkc_kcParamCondition.Yptymc;
                sqlparams.Add(pYptymc);

            }

            if (null != ypkc_kcParamCondition.Ypgg && "" != ypkc_kcParamCondition.Ypgg)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" YPGG=:ypgg ");
                OracleParameter pYpgg = new OracleParameter(":ypgg", OracleDbType.NVarchar2);
                pYpgg.Direction = ParameterDirection.Input;
                pYpgg.Value = ypkc_kcParamCondition.Ypgg;
                sqlparams.Add(pYpgg);

            }

            if (null != ypkc_kcParamCondition.Jx && "" != ypkc_kcParamCondition.Jx)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" JX=:jx ");
                OracleParameter pJx = new OracleParameter(":jx", OracleDbType.NVarchar2);
                pJx.Direction = ParameterDirection.Input;
                pJx.Value = ypkc_kcParamCondition.Jx;
                sqlparams.Add(pJx);

            }

            if (null != ypkc_kcParamCondition.Pym && "" != ypkc_kcParamCondition.Pym)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" PYM=:pym ");
                OracleParameter pPym = new OracleParameter(":pym", OracleDbType.NVarchar2);
                pPym.Direction = ParameterDirection.Input;
                pPym.Value = ypkc_kcParamCondition.Pym;
                sqlparams.Add(pPym);

            }

            if (null != ypkc_kcParamCondition.Ddw && "" != ypkc_kcParamCondition.Ddw)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" DDW=:ddw ");
                OracleParameter pDdw = new OracleParameter(":ddw", OracleDbType.NVarchar2);
                pDdw.Direction = ParameterDirection.Input;
                pDdw.Value = ypkc_kcParamCondition.Ddw;
                sqlparams.Add(pDdw);

            }

            if (null != ypkc_kcParamCondition.Xdw && "" != ypkc_kcParamCondition.Xdw)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" XDW=:xdw ");
                OracleParameter pXdw = new OracleParameter(":xdw", OracleDbType.NVarchar2);
                pXdw.Direction = ParameterDirection.Input;
                pXdw.Value = ypkc_kcParamCondition.Xdw;
                sqlparams.Add(pXdw);

            }

            if (null != ypkc_kcParamCondition.Dwlx_code && "" != ypkc_kcParamCondition.Dwlx_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" DWLX_CODE=:dwlx_code ");
                OracleParameter pDwlx_code = new OracleParameter(":dwlx_code", OracleDbType.NVarchar2);
                pDwlx_code.Direction = ParameterDirection.Input;
                pDwlx_code.Value = ypkc_kcParamCondition.Dwlx_code;
                sqlparams.Add(pDwlx_code);

            }

            if (null != ypkc_kcParamCondition.Hsbl)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" HSBL=:hsbl ");
                OracleParameter pHsbl = new OracleParameter(":hsbl", OracleDbType.Decimal);
                pHsbl.Direction = ParameterDirection.Input;
                pHsbl.Value = ypkc_kcParamCondition.Hsbl;
                sqlparams.Add(pHsbl);

            }

            if (null != ypkc_kcParamCondition.Pzwh && "" != ypkc_kcParamCondition.Pzwh)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" PZWH=:pzwh ");
                OracleParameter pPzwh = new OracleParameter(":pzwh", OracleDbType.Varchar2);
                pPzwh.Direction = ParameterDirection.Input;
                pPzwh.Value = ypkc_kcParamCondition.Pzwh;
                sqlparams.Add(pPzwh);

            }

            if (null != ypkc_kcParamCondition.Gyzz && "" != ypkc_kcParamCondition.Gyzz)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" GYZZ=:gyzz ");
                OracleParameter pGyzz = new OracleParameter(":gyzz", OracleDbType.Varchar2);
                pGyzz.Direction = ParameterDirection.Input;
                pGyzz.Value = ypkc_kcParamCondition.Gyzz;
                sqlparams.Add(pGyzz);

            }

            if (null != ypkc_kcParamCondition.Cjmc && "" != ypkc_kcParamCondition.Cjmc)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" CJMC=:cjmc ");
                OracleParameter pCjmc = new OracleParameter(":cjmc", OracleDbType.NVarchar2);
                pCjmc.Direction = ParameterDirection.Input;
                pCjmc.Value = ypkc_kcParamCondition.Cjmc;
                sqlparams.Add(pCjmc);

            }

            if (null != ypkc_kcParamCondition.Ph && "" != ypkc_kcParamCondition.Ph)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" PH=:ph ");
                OracleParameter pPh = new OracleParameter(":ph", OracleDbType.NVarchar2);
                pPh.Direction = ParameterDirection.Input;
                pPh.Value = ypkc_kcParamCondition.Ph;
                sqlparams.Add(pPh);

            }

            if (DateTime.MinValue != ypkc_kcParamCondition.Yxq && null != ypkc_kcParamCondition.Yxq)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" YXQ=:yxq ");
                OracleParameter pYxq = new OracleParameter(":yxq", OracleDbType.Date);
                pYxq.Direction = ParameterDirection.Input;
                pYxq.Value = ypkc_kcParamCondition.Yxq;
                sqlparams.Add(pYxq);

            }

            if (null != ypkc_kcParamCondition.Jj)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" JJ=:jj ");
                OracleParameter pJj = new OracleParameter(":jj", OracleDbType.Decimal);
                pJj.Direction = ParameterDirection.Input;
                pJj.Value = ypkc_kcParamCondition.Jj;
                sqlparams.Add(pJj);

            }

            if (null != ypkc_kcParamCondition.Lsj)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" LSJ=:lsj ");
                OracleParameter pLsj = new OracleParameter(":lsj", OracleDbType.Decimal);
                pLsj.Direction = ParameterDirection.Input;
                pLsj.Value = ypkc_kcParamCondition.Lsj;
                sqlparams.Add(pLsj);

            }

            if (null != ypkc_kcParamCondition.Sl)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" SL=:sl ");
                OracleParameter pSl = new OracleParameter(":sl", OracleDbType.Decimal);
                pSl.Direction = ParameterDirection.Input;
                pSl.Value = ypkc_kcParamCondition.Sl;
                sqlparams.Add(pSl);

            }

            if (null != ypkc_kcParamCondition.Yksl)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" YKSL=:yksl ");
                OracleParameter pYksl = new OracleParameter(":yksl", OracleDbType.Decimal);
                pYksl.Direction = ParameterDirection.Input;
                pYksl.Value = ypkc_kcParamCondition.Yksl;
                sqlparams.Add(pYksl);

            }

            if (null != ypkc_kcParamCondition.Zfbz && "" != ypkc_kcParamCondition.Zfbz)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" ZFBZ=:zfbz ");
                OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                pZfbz.Direction = ParameterDirection.Input;
                pZfbz.Value = ypkc_kcParamCondition.Zfbz;
                sqlparams.Add(pZfbz);

            }

            if (null != ypkc_kcParamCondition.Ypfl_code && "" != ypkc_kcParamCondition.Ypfl_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" YPFL_CODE=:ypfl_code ");
                OracleParameter pYpfl_code = new OracleParameter(":ypfl_code", OracleDbType.NVarchar2);
                pYpfl_code.Direction = ParameterDirection.Input;
                pYpfl_code.Value = ypkc_kcParamCondition.Ypfl_code;
                sqlparams.Add(pYpfl_code);

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
        /// <returns>Ypkc_kc</returns>
        public Ypkc_kc findById(string id)
        {
            if ("" == id || null == id)
            {
                throw new Exception("ID不能为空，请赋值后调用；错误出自：findById");
            }
            StringBuilder sql = new StringBuilder("SELECT A.* ");
            //新建方法findContactObjectsById，在此加入多表连接要显示的项start
            //sql.Append(",B.字段一,B.字段二,B.字段三");
            //新建方法，在此加入多表连接要显示的项end
            sql.Append(" FROM YPKC_KC A ");
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
        /// <param name="ypkc_kcParam"></param>
        /// <param name="page">分页对象</param>
        ///<param name="ypkc_kcParamLike">模糊查询参数</param>
        ///<param name="sortList">排序参数对象的集合</param>
        /// <returns>满足条件的所有Ypkc_kc对象集合list</returns>
        public List<object> find(Ypkc_kc ypkc_kcParam, Model.Common.PageInfo page, Ypkc_kc ypkc_kcParamLike, List<SortInfo> sortList)
        {

            //如果没有传查询条件参数，就new一个空的Ypkc_kc对象，标示查询所有数据
            if (null == ypkc_kcParam)
            {
                ypkc_kcParam = new Ypkc_kc();
            }
            if (null != ypkc_kcParam.Id && "" != ypkc_kcParam.Id)
            {
                throw new Exception("此方法不允许指定参数ID，如果需要根据ID查询数据，请调用findById方法；错误出自：find");
            }
            List<Ypkc_kc> ypkc_kcParamList = new List<Ypkc_kc>();//接收查询出的Ypkc_kc对象集合
            List<OracleParameter> sqlparams = new List<OracleParameter>();//保存参数的集合
            StringBuilder sql = new StringBuilder("SELECT A.* ");
            //新建方法findContactObjects(Ypkc_kc ypkc_kcParam, Model.Common.PageInfo page)，在此加入多表连接要显示的项start
            //sql.Append(",B.字段一,B.字段二,B.字段三");
            //新建方法，在此加入多表连接要显示的项end
            sql.Append(" FROM YPKC_KC A ");
            //新建一个方法，在此加入多表连接的语句start
            ////sql.Append(" LEFT JOIN 表名 B ON A.外键=B.ID");
            //新建一个方法，在此加入多表连接的语句end


            if (null != ypkc_kcParam.Fk_keshi_id && "" != ypkc_kcParam.Fk_keshi_id)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.FK_KESHI_ID=:fk_keshi_id ");
                OracleParameter pFk_keshi_id = new OracleParameter(":fk_keshi_id", OracleDbType.Varchar2);
                pFk_keshi_id.Direction = ParameterDirection.Input;
                pFk_keshi_id.Value = ypkc_kcParam.Fk_keshi_id;
                sqlparams.Add(pFk_keshi_id);
            }

            if (null != ypkc_kcParam.Ksbh && "" != ypkc_kcParam.Ksbh)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.KSBH=:ksbh ");
                OracleParameter pKsbh = new OracleParameter(":ksbh", OracleDbType.NVarchar2);
                pKsbh.Direction = ParameterDirection.Input;
                pKsbh.Value = ypkc_kcParam.Ksbh;
                sqlparams.Add(pKsbh);
            }

            if (null != ypkc_kcParam.Ksmc && "" != ypkc_kcParam.Ksmc)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.KSMC=:ksmc ");
                OracleParameter pKsmc = new OracleParameter(":ksmc", OracleDbType.NVarchar2);
                pKsmc.Direction = ParameterDirection.Input;
                pKsmc.Value = ypkc_kcParam.Ksmc;
                sqlparams.Add(pKsmc);
            }

            if (null != ypkc_kcParam.Fk_yp_id && "" != ypkc_kcParam.Fk_yp_id)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.FK_YP_ID=:fk_yp_id ");
                OracleParameter pFk_yp_id = new OracleParameter(":fk_yp_id", OracleDbType.Varchar2);
                pFk_yp_id.Direction = ParameterDirection.Input;
                pFk_yp_id.Value = ypkc_kcParam.Fk_yp_id;
                sqlparams.Add(pFk_yp_id);
            }

            if (null != ypkc_kcParam.Ypbh && "" != ypkc_kcParam.Ypbh)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.YPBH=:ypbh ");
                OracleParameter pYpbh = new OracleParameter(":ypbh", OracleDbType.NVarchar2);
                pYpbh.Direction = ParameterDirection.Input;
                pYpbh.Value = ypkc_kcParam.Ypbh;
                sqlparams.Add(pYpbh);
            }

            if (null != ypkc_kcParam.Ypmc && "" != ypkc_kcParam.Ypmc)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.YPMC=:ypmc ");
                OracleParameter pYpmc = new OracleParameter(":ypmc", OracleDbType.NVarchar2);
                pYpmc.Direction = ParameterDirection.Input;
                pYpmc.Value = ypkc_kcParam.Ypmc;
                sqlparams.Add(pYpmc);
            }

            if (null != ypkc_kcParam.Yptymc && "" != ypkc_kcParam.Yptymc)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.YPTYMC=:yptymc ");
                OracleParameter pYptymc = new OracleParameter(":yptymc", OracleDbType.NVarchar2);
                pYptymc.Direction = ParameterDirection.Input;
                pYptymc.Value = ypkc_kcParam.Yptymc;
                sqlparams.Add(pYptymc);
            }

            if (null != ypkc_kcParam.Ypgg && "" != ypkc_kcParam.Ypgg)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.YPGG=:ypgg ");
                OracleParameter pYpgg = new OracleParameter(":ypgg", OracleDbType.NVarchar2);
                pYpgg.Direction = ParameterDirection.Input;
                pYpgg.Value = ypkc_kcParam.Ypgg;
                sqlparams.Add(pYpgg);
            }

            if (null != ypkc_kcParam.Jx && "" != ypkc_kcParam.Jx)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.JX=:jx ");
                OracleParameter pJx = new OracleParameter(":jx", OracleDbType.NVarchar2);
                pJx.Direction = ParameterDirection.Input;
                pJx.Value = ypkc_kcParam.Jx;
                sqlparams.Add(pJx);
            }

            if (null != ypkc_kcParam.Pym && "" != ypkc_kcParam.Pym)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.PYM=:pym ");
                OracleParameter pPym = new OracleParameter(":pym", OracleDbType.NVarchar2);
                pPym.Direction = ParameterDirection.Input;
                pPym.Value = ypkc_kcParam.Pym;
                sqlparams.Add(pPym);
            }

            if (null != ypkc_kcParam.Ddw && "" != ypkc_kcParam.Ddw)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.DDW=:ddw ");
                OracleParameter pDdw = new OracleParameter(":ddw", OracleDbType.NVarchar2);
                pDdw.Direction = ParameterDirection.Input;
                pDdw.Value = ypkc_kcParam.Ddw;
                sqlparams.Add(pDdw);
            }

            if (null != ypkc_kcParam.Xdw && "" != ypkc_kcParam.Xdw)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.XDW=:xdw ");
                OracleParameter pXdw = new OracleParameter(":xdw", OracleDbType.NVarchar2);
                pXdw.Direction = ParameterDirection.Input;
                pXdw.Value = ypkc_kcParam.Xdw;
                sqlparams.Add(pXdw);
            }

            if (null != ypkc_kcParam.Dwlx_code && "" != ypkc_kcParam.Dwlx_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.DWLX_CODE=:dwlx_code ");
                OracleParameter pDwlx_code = new OracleParameter(":dwlx_code", OracleDbType.NVarchar2);
                pDwlx_code.Direction = ParameterDirection.Input;
                pDwlx_code.Value = ypkc_kcParam.Dwlx_code;
                sqlparams.Add(pDwlx_code);
            }

            if (null != ypkc_kcParam.Hsbl)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.HSBL=:hsbl ");
                OracleParameter pHsbl = new OracleParameter(":hsbl", OracleDbType.Decimal);
                pHsbl.Direction = ParameterDirection.Input;
                pHsbl.Value = ypkc_kcParam.Hsbl;
                sqlparams.Add(pHsbl);

            }

            if (null != ypkc_kcParam.Pzwh && "" != ypkc_kcParam.Pzwh)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.PZWH=:pzwh ");
                OracleParameter pPzwh = new OracleParameter(":pzwh", OracleDbType.Varchar2);
                pPzwh.Direction = ParameterDirection.Input;
                pPzwh.Value = ypkc_kcParam.Pzwh;
                sqlparams.Add(pPzwh);
            }

            if (null != ypkc_kcParam.Gyzz && "" != ypkc_kcParam.Gyzz)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.GYZZ=:gyzz ");
                OracleParameter pGyzz = new OracleParameter(":gyzz", OracleDbType.Varchar2);
                pGyzz.Direction = ParameterDirection.Input;
                pGyzz.Value = ypkc_kcParam.Gyzz;
                sqlparams.Add(pGyzz);
            }

            if (null != ypkc_kcParam.Cjmc && "" != ypkc_kcParam.Cjmc)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.CJMC=:cjmc ");
                OracleParameter pCjmc = new OracleParameter(":cjmc", OracleDbType.NVarchar2);
                pCjmc.Direction = ParameterDirection.Input;
                pCjmc.Value = ypkc_kcParam.Cjmc;
                sqlparams.Add(pCjmc);
            }

            if (null != ypkc_kcParam.Ph && "" != ypkc_kcParam.Ph)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.PH=:ph ");
                OracleParameter pPh = new OracleParameter(":ph", OracleDbType.NVarchar2);
                pPh.Direction = ParameterDirection.Input;
                pPh.Value = ypkc_kcParam.Ph;
                sqlparams.Add(pPh);
            }

            if (DateTime.MinValue != ypkc_kcParam.Yxq && null != ypkc_kcParam.Yxq)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.YXQ=:yxq ");
                OracleParameter pYxq = new OracleParameter(":yxq", OracleDbType.Date);
                pYxq.Direction = ParameterDirection.Input;
                pYxq.Value = ypkc_kcParam.Yxq;
                sqlparams.Add(pYxq);
            }

            if (null != ypkc_kcParam.Jj)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.JJ=:jj ");
                OracleParameter pJj = new OracleParameter(":jj", OracleDbType.Decimal);
                pJj.Direction = ParameterDirection.Input;
                pJj.Value = ypkc_kcParam.Jj;
                sqlparams.Add(pJj);

            }

            if (null != ypkc_kcParam.Lsj)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.LSJ=:lsj ");
                OracleParameter pLsj = new OracleParameter(":lsj", OracleDbType.Decimal);
                pLsj.Direction = ParameterDirection.Input;
                pLsj.Value = ypkc_kcParam.Lsj;
                sqlparams.Add(pLsj);

            }

            if (null != ypkc_kcParam.Sl)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.SL=:sl ");
                OracleParameter pSl = new OracleParameter(":sl", OracleDbType.Decimal);
                pSl.Direction = ParameterDirection.Input;
                pSl.Value = ypkc_kcParam.Sl;
                sqlparams.Add(pSl);

            }

            if (null != ypkc_kcParam.Yksl)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.YKSL=:yksl ");
                OracleParameter pYksl = new OracleParameter(":yksl", OracleDbType.Decimal);
                pYksl.Direction = ParameterDirection.Input;
                pYksl.Value = ypkc_kcParam.Yksl;
                sqlparams.Add(pYksl);

            }

            if (null != ypkc_kcParam.Zfbz && "" != ypkc_kcParam.Zfbz)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.ZFBZ=:zfbz ");
                OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                pZfbz.Direction = ParameterDirection.Input;
                pZfbz.Value = ypkc_kcParam.Zfbz;
                sqlparams.Add(pZfbz);
            }

            if (null != ypkc_kcParam.Ypfl_code && "" != ypkc_kcParam.Ypfl_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.YPFL_CODE=:ypfl_code ");
                OracleParameter pYpfl_code = new OracleParameter(":ypfl_code", OracleDbType.NVarchar2);
                pYpfl_code.Direction = ParameterDirection.Input;
                pYpfl_code.Value = ypkc_kcParam.Ypfl_code;
                sqlparams.Add(pYpfl_code);
            }

            if (ypkc_kcParamLike != null)
            {

                if (null != ypkc_kcParamLike.Fk_keshi_id && "" != ypkc_kcParamLike.Fk_keshi_id)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.FK_KESHI_ID LIKE '%'||:fk_keshi_id||'%' ");
                    OracleParameter pFk_keshi_id = new OracleParameter(":fk_keshi_id", OracleDbType.Varchar2);
                    pFk_keshi_id.Direction = ParameterDirection.Input;
                    pFk_keshi_id.Value = ypkc_kcParamLike.Fk_keshi_id;
                    sqlparams.Add(pFk_keshi_id);
                }

                if (null != ypkc_kcParamLike.Ksbh && "" != ypkc_kcParamLike.Ksbh)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.KSBH LIKE '%'||:ksbh||'%' ");
                    OracleParameter pKsbh = new OracleParameter(":ksbh", OracleDbType.NVarchar2);
                    pKsbh.Direction = ParameterDirection.Input;
                    pKsbh.Value = ypkc_kcParamLike.Ksbh;
                    sqlparams.Add(pKsbh);
                }

                if (null != ypkc_kcParamLike.Ksmc && "" != ypkc_kcParamLike.Ksmc)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.KSMC LIKE '%'||:ksmc||'%' ");
                    OracleParameter pKsmc = new OracleParameter(":ksmc", OracleDbType.NVarchar2);
                    pKsmc.Direction = ParameterDirection.Input;
                    pKsmc.Value = ypkc_kcParamLike.Ksmc;
                    sqlparams.Add(pKsmc);
                }

                if (null != ypkc_kcParamLike.Fk_yp_id && "" != ypkc_kcParamLike.Fk_yp_id)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.FK_YP_ID LIKE '%'||:fk_yp_id||'%' ");
                    OracleParameter pFk_yp_id = new OracleParameter(":fk_yp_id", OracleDbType.Varchar2);
                    pFk_yp_id.Direction = ParameterDirection.Input;
                    pFk_yp_id.Value = ypkc_kcParamLike.Fk_yp_id;
                    sqlparams.Add(pFk_yp_id);
                }

                if (null != ypkc_kcParamLike.Ypbh && "" != ypkc_kcParamLike.Ypbh)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YPBH LIKE '%'||:ypbh||'%' ");
                    OracleParameter pYpbh = new OracleParameter(":ypbh", OracleDbType.NVarchar2);
                    pYpbh.Direction = ParameterDirection.Input;
                    pYpbh.Value = ypkc_kcParamLike.Ypbh;
                    sqlparams.Add(pYpbh);
                }

                if (null != ypkc_kcParamLike.Ypmc && "" != ypkc_kcParamLike.Ypmc)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YPMC LIKE '%'||:ypmc||'%' ");
                    OracleParameter pYpmc = new OracleParameter(":ypmc", OracleDbType.NVarchar2);
                    pYpmc.Direction = ParameterDirection.Input;
                    pYpmc.Value = ypkc_kcParamLike.Ypmc;
                    sqlparams.Add(pYpmc);
                }

                if (null != ypkc_kcParamLike.Yptymc && "" != ypkc_kcParamLike.Yptymc)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YPTYMC LIKE '%'||:yptymc||'%' ");
                    OracleParameter pYptymc = new OracleParameter(":yptymc", OracleDbType.NVarchar2);
                    pYptymc.Direction = ParameterDirection.Input;
                    pYptymc.Value = ypkc_kcParamLike.Yptymc;
                    sqlparams.Add(pYptymc);
                }

                if (null != ypkc_kcParamLike.Ypgg && "" != ypkc_kcParamLike.Ypgg)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YPGG LIKE '%'||:ypgg||'%' ");
                    OracleParameter pYpgg = new OracleParameter(":ypgg", OracleDbType.NVarchar2);
                    pYpgg.Direction = ParameterDirection.Input;
                    pYpgg.Value = ypkc_kcParamLike.Ypgg;
                    sqlparams.Add(pYpgg);
                }

                if (null != ypkc_kcParamLike.Jx && "" != ypkc_kcParamLike.Jx)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.JX LIKE '%'||:jx||'%' ");
                    OracleParameter pJx = new OracleParameter(":jx", OracleDbType.NVarchar2);
                    pJx.Direction = ParameterDirection.Input;
                    pJx.Value = ypkc_kcParamLike.Jx;
                    sqlparams.Add(pJx);
                }

                if (null != ypkc_kcParamLike.Pym && "" != ypkc_kcParamLike.Pym)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.PYM LIKE '%'||:pym||'%' ");
                    OracleParameter pPym = new OracleParameter(":pym", OracleDbType.NVarchar2);
                    pPym.Direction = ParameterDirection.Input;
                    pPym.Value = ypkc_kcParamLike.Pym;
                    sqlparams.Add(pPym);
                }

                if (null != ypkc_kcParamLike.Ddw && "" != ypkc_kcParamLike.Ddw)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.DDW LIKE '%'||:ddw||'%' ");
                    OracleParameter pDdw = new OracleParameter(":ddw", OracleDbType.NVarchar2);
                    pDdw.Direction = ParameterDirection.Input;
                    pDdw.Value = ypkc_kcParamLike.Ddw;
                    sqlparams.Add(pDdw);
                }

                if (null != ypkc_kcParamLike.Xdw && "" != ypkc_kcParamLike.Xdw)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.XDW LIKE '%'||:xdw||'%' ");
                    OracleParameter pXdw = new OracleParameter(":xdw", OracleDbType.NVarchar2);
                    pXdw.Direction = ParameterDirection.Input;
                    pXdw.Value = ypkc_kcParamLike.Xdw;
                    sqlparams.Add(pXdw);
                }

                if (null != ypkc_kcParamLike.Dwlx_code && "" != ypkc_kcParamLike.Dwlx_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.DWLX_CODE LIKE '%'||:dwlx_code||'%' ");
                    OracleParameter pDwlx_code = new OracleParameter(":dwlx_code", OracleDbType.NVarchar2);
                    pDwlx_code.Direction = ParameterDirection.Input;
                    pDwlx_code.Value = ypkc_kcParamLike.Dwlx_code;
                    sqlparams.Add(pDwlx_code);
                }

                if (null != ypkc_kcParamLike.Pzwh && "" != ypkc_kcParamLike.Pzwh)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.PZWH LIKE '%'||:pzwh||'%' ");
                    OracleParameter pPzwh = new OracleParameter(":pzwh", OracleDbType.Varchar2);
                    pPzwh.Direction = ParameterDirection.Input;
                    pPzwh.Value = ypkc_kcParamLike.Pzwh;
                    sqlparams.Add(pPzwh);
                }

                if (null != ypkc_kcParamLike.Gyzz && "" != ypkc_kcParamLike.Gyzz)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.GYZZ LIKE '%'||:gyzz||'%' ");
                    OracleParameter pGyzz = new OracleParameter(":gyzz", OracleDbType.Varchar2);
                    pGyzz.Direction = ParameterDirection.Input;
                    pGyzz.Value = ypkc_kcParamLike.Gyzz;
                    sqlparams.Add(pGyzz);
                }

                if (null != ypkc_kcParamLike.Cjmc && "" != ypkc_kcParamLike.Cjmc)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.CJMC LIKE '%'||:cjmc||'%' ");
                    OracleParameter pCjmc = new OracleParameter(":cjmc", OracleDbType.NVarchar2);
                    pCjmc.Direction = ParameterDirection.Input;
                    pCjmc.Value = ypkc_kcParamLike.Cjmc;
                    sqlparams.Add(pCjmc);
                }

                if (null != ypkc_kcParamLike.Ph && "" != ypkc_kcParamLike.Ph)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.PH LIKE '%'||:ph||'%' ");
                    OracleParameter pPh = new OracleParameter(":ph", OracleDbType.NVarchar2);
                    pPh.Direction = ParameterDirection.Input;
                    pPh.Value = ypkc_kcParamLike.Ph;
                    sqlparams.Add(pPh);
                }

                if (null != ypkc_kcParamLike.Zfbz && "" != ypkc_kcParamLike.Zfbz)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.ZFBZ LIKE '%'||:zfbz||'%' ");
                    OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                    pZfbz.Direction = ParameterDirection.Input;
                    pZfbz.Value = ypkc_kcParamLike.Zfbz;
                    sqlparams.Add(pZfbz);
                }

                if (null != ypkc_kcParamLike.Ypfl_code && "" != ypkc_kcParamLike.Ypfl_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YPFL_CODE LIKE '%'||:ypfl_code||'%' ");
                    OracleParameter pYpfl_code = new OracleParameter(":ypfl_code", OracleDbType.NVarchar2);
                    pYpfl_code.Direction = ParameterDirection.Input;
                    pYpfl_code.Value = ypkc_kcParamLike.Ypfl_code;
                    sqlparams.Add(pYpfl_code);
                }

            }

            this.b_isWhere = false;
            this.addSort(sql, sortList);//排序
            //*******分页start1*********如果分页对象为空，则全部数据查出，如果不为空
            List<object> returnList = new List<object>();//返回的List,索引0为List<Ypkc_kc>对象,索引1为Model.Common.PageInfo分页信息对象
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
            //把每一行数据转换为一个对象放入List<Ypkc_kc>中
            for (int i = 0; i < rows.Count; i++)
            {
                DataRow row = rows[i];
                //ypkc_kcParamList.Add(this.dataSetContactObjectsToModel(row));
                ypkc_kcParamList.Add(this.dataSetToModel(row));
            }

            //*******分页start2*********如果没有传入分页对象，则新建一个分页对象当做返回值
            if (null == page)
            {
                page = new Model.Common.PageInfo();
                page.AllCount = rows.Count;
            }
            returnList.Add(ypkc_kcParamList);//把List<Ypkc_kc>放入List<object>中第一个
            returnList.Add(page);//把page对象放入List<object>中第二个
            //*******分页end2*********
            return returnList;
        }



        /// <summary>
        /// 根据条件得到集合的数量
        /// 第二个条件是模糊查询的条件
        /// </summary>
        /// <returns>int</returns>
        public int getCount(Ypkc_kc ypkc_kcParam, Ypkc_kc ypkc_kcParamLike)
        {
            //如果没有传查询条件参数，就new一个空的Ypkc_kc对象，标示查询所有数据
            if (null == ypkc_kcParam)
            {
                ypkc_kcParam = new Ypkc_kc();
            }
            List<OracleParameter> sqlparams = new List<OracleParameter>();//保存参数的集合
            StringBuilder sql = new StringBuilder("SELECT COUNT(ID) FROM YPKC_KC A");
            if (null != ypkc_kcParam.Fk_keshi_id && "" != ypkc_kcParam.Fk_keshi_id)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.FK_KESHI_ID=:fk_keshi_id ");
                OracleParameter pFk_keshi_id = new OracleParameter(":fk_keshi_id", OracleDbType.Varchar2);
                pFk_keshi_id.Value = ypkc_kcParam.Fk_keshi_id;
                sqlparams.Add(pFk_keshi_id);
            }

            if (null != ypkc_kcParam.Ksbh && "" != ypkc_kcParam.Ksbh)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.KSBH=:ksbh ");
                OracleParameter pKsbh = new OracleParameter(":ksbh", OracleDbType.NVarchar2);
                pKsbh.Value = ypkc_kcParam.Ksbh;
                sqlparams.Add(pKsbh);
            }

            if (null != ypkc_kcParam.Ksmc && "" != ypkc_kcParam.Ksmc)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.KSMC=:ksmc ");
                OracleParameter pKsmc = new OracleParameter(":ksmc", OracleDbType.NVarchar2);
                pKsmc.Value = ypkc_kcParam.Ksmc;
                sqlparams.Add(pKsmc);
            }

            if (null != ypkc_kcParam.Fk_yp_id && "" != ypkc_kcParam.Fk_yp_id)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.FK_YP_ID=:fk_yp_id ");
                OracleParameter pFk_yp_id = new OracleParameter(":fk_yp_id", OracleDbType.Varchar2);
                pFk_yp_id.Value = ypkc_kcParam.Fk_yp_id;
                sqlparams.Add(pFk_yp_id);
            }

            if (null != ypkc_kcParam.Ypbh && "" != ypkc_kcParam.Ypbh)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.YPBH=:ypbh ");
                OracleParameter pYpbh = new OracleParameter(":ypbh", OracleDbType.NVarchar2);
                pYpbh.Value = ypkc_kcParam.Ypbh;
                sqlparams.Add(pYpbh);
            }

            if (null != ypkc_kcParam.Ypmc && "" != ypkc_kcParam.Ypmc)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.YPMC=:ypmc ");
                OracleParameter pYpmc = new OracleParameter(":ypmc", OracleDbType.NVarchar2);
                pYpmc.Value = ypkc_kcParam.Ypmc;
                sqlparams.Add(pYpmc);
            }

            if (null != ypkc_kcParam.Yptymc && "" != ypkc_kcParam.Yptymc)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.YPTYMC=:yptymc ");
                OracleParameter pYptymc = new OracleParameter(":yptymc", OracleDbType.NVarchar2);
                pYptymc.Value = ypkc_kcParam.Yptymc;
                sqlparams.Add(pYptymc);
            }

            if (null != ypkc_kcParam.Ypgg && "" != ypkc_kcParam.Ypgg)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.YPGG=:ypgg ");
                OracleParameter pYpgg = new OracleParameter(":ypgg", OracleDbType.NVarchar2);
                pYpgg.Value = ypkc_kcParam.Ypgg;
                sqlparams.Add(pYpgg);
            }

            if (null != ypkc_kcParam.Jx && "" != ypkc_kcParam.Jx)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.JX=:jx ");
                OracleParameter pJx = new OracleParameter(":jx", OracleDbType.NVarchar2);
                pJx.Value = ypkc_kcParam.Jx;
                sqlparams.Add(pJx);
            }

            if (null != ypkc_kcParam.Pym && "" != ypkc_kcParam.Pym)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.PYM=:pym ");
                OracleParameter pPym = new OracleParameter(":pym", OracleDbType.NVarchar2);
                pPym.Value = ypkc_kcParam.Pym;
                sqlparams.Add(pPym);
            }

            if (null != ypkc_kcParam.Ddw && "" != ypkc_kcParam.Ddw)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.DDW=:ddw ");
                OracleParameter pDdw = new OracleParameter(":ddw", OracleDbType.NVarchar2);
                pDdw.Value = ypkc_kcParam.Ddw;
                sqlparams.Add(pDdw);
            }

            if (null != ypkc_kcParam.Xdw && "" != ypkc_kcParam.Xdw)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.XDW=:xdw ");
                OracleParameter pXdw = new OracleParameter(":xdw", OracleDbType.NVarchar2);
                pXdw.Value = ypkc_kcParam.Xdw;
                sqlparams.Add(pXdw);
            }

            if (null != ypkc_kcParam.Dwlx_code && "" != ypkc_kcParam.Dwlx_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.DWLX_CODE=:dwlx_code ");
                OracleParameter pDwlx_code = new OracleParameter(":dwlx_code", OracleDbType.NVarchar2);
                pDwlx_code.Value = ypkc_kcParam.Dwlx_code;
                sqlparams.Add(pDwlx_code);
            }

            if (null != ypkc_kcParam.Hsbl)
            {
                this.isComma(sql);
                sql.Append(" HSBL=:hsbl ");
                OracleParameter pHsbl = new OracleParameter(":hsbl", OracleDbType.Decimal);
                pHsbl.Value = ypkc_kcParam.Hsbl;
                sqlparams.Add(pHsbl);

            }

            if (null != ypkc_kcParam.Pzwh && "" != ypkc_kcParam.Pzwh)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.PZWH=:pzwh ");
                OracleParameter pPzwh = new OracleParameter(":pzwh", OracleDbType.Varchar2);
                pPzwh.Value = ypkc_kcParam.Pzwh;
                sqlparams.Add(pPzwh);
            }

            if (null != ypkc_kcParam.Gyzz && "" != ypkc_kcParam.Gyzz)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.GYZZ=:gyzz ");
                OracleParameter pGyzz = new OracleParameter(":gyzz", OracleDbType.Varchar2);
                pGyzz.Value = ypkc_kcParam.Gyzz;
                sqlparams.Add(pGyzz);
            }

            if (null != ypkc_kcParam.Cjmc && "" != ypkc_kcParam.Cjmc)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.CJMC=:cjmc ");
                OracleParameter pCjmc = new OracleParameter(":cjmc", OracleDbType.NVarchar2);
                pCjmc.Value = ypkc_kcParam.Cjmc;
                sqlparams.Add(pCjmc);
            }

            if (null != ypkc_kcParam.Ph && "" != ypkc_kcParam.Ph)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.PH=:ph ");
                OracleParameter pPh = new OracleParameter(":ph", OracleDbType.NVarchar2);
                pPh.Value = ypkc_kcParam.Ph;
                sqlparams.Add(pPh);
            }

            if (DateTime.MinValue != ypkc_kcParam.Yxq && null != ypkc_kcParam.Yxq)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.YXQ=:yxq ");
                OracleParameter pYxq = new OracleParameter(":yxq", OracleDbType.Date);
                pYxq.Value = ypkc_kcParam.Yxq;
                sqlparams.Add(pYxq);
            }

            if (null != ypkc_kcParam.Jj)
            {
                this.isComma(sql);
                sql.Append(" JJ=:jj ");
                OracleParameter pJj = new OracleParameter(":jj", OracleDbType.Decimal);
                pJj.Value = ypkc_kcParam.Jj;
                sqlparams.Add(pJj);

            }

            if (null != ypkc_kcParam.Lsj)
            {
                this.isComma(sql);
                sql.Append(" LSJ=:lsj ");
                OracleParameter pLsj = new OracleParameter(":lsj", OracleDbType.Decimal);
                pLsj.Value = ypkc_kcParam.Lsj;
                sqlparams.Add(pLsj);

            }

            if (null != ypkc_kcParam.Sl)
            {
                this.isComma(sql);
                sql.Append(" SL=:sl ");
                OracleParameter pSl = new OracleParameter(":sl", OracleDbType.Decimal);
                pSl.Value = ypkc_kcParam.Sl;
                sqlparams.Add(pSl);

            }

            if (null != ypkc_kcParam.Yksl)
            {
                this.isComma(sql);
                sql.Append(" YKSL=:yksl ");
                OracleParameter pYksl = new OracleParameter(":yksl", OracleDbType.Decimal);
                pYksl.Value = ypkc_kcParam.Yksl;
                sqlparams.Add(pYksl);

            }

            if (null != ypkc_kcParam.Zfbz && "" != ypkc_kcParam.Zfbz)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.ZFBZ=:zfbz ");
                OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                pZfbz.Value = ypkc_kcParam.Zfbz;
                sqlparams.Add(pZfbz);
            }

            if (null != ypkc_kcParam.Ypfl_code && "" != ypkc_kcParam.Ypfl_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.YPFL_CODE=:ypfl_code ");
                OracleParameter pYpfl_code = new OracleParameter(":ypfl_code", OracleDbType.NVarchar2);
                pYpfl_code.Value = ypkc_kcParam.Ypfl_code;
                sqlparams.Add(pYpfl_code);
            }

            if (ypkc_kcParamLike != null)
            {

                if (null != ypkc_kcParamLike.Fk_keshi_id && "" != ypkc_kcParamLike.Fk_keshi_id)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.FK_KESHI_ID LIKE '%'||:fk_keshi_id||'%' ");
                    OracleParameter pFk_keshi_id = new OracleParameter(":fk_keshi_id", OracleDbType.Varchar2);
                    pFk_keshi_id.Direction = ParameterDirection.Input;
                    pFk_keshi_id.Value = ypkc_kcParamLike.Fk_keshi_id;
                    sqlparams.Add(pFk_keshi_id);
                }

                if (null != ypkc_kcParamLike.Ksbh && "" != ypkc_kcParamLike.Ksbh)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.KSBH LIKE '%'||:ksbh||'%' ");
                    OracleParameter pKsbh = new OracleParameter(":ksbh", OracleDbType.NVarchar2);
                    pKsbh.Direction = ParameterDirection.Input;
                    pKsbh.Value = ypkc_kcParamLike.Ksbh;
                    sqlparams.Add(pKsbh);
                }

                if (null != ypkc_kcParamLike.Ksmc && "" != ypkc_kcParamLike.Ksmc)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.KSMC LIKE '%'||:ksmc||'%' ");
                    OracleParameter pKsmc = new OracleParameter(":ksmc", OracleDbType.NVarchar2);
                    pKsmc.Direction = ParameterDirection.Input;
                    pKsmc.Value = ypkc_kcParamLike.Ksmc;
                    sqlparams.Add(pKsmc);
                }

                if (null != ypkc_kcParamLike.Fk_yp_id && "" != ypkc_kcParamLike.Fk_yp_id)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.FK_YP_ID LIKE '%'||:fk_yp_id||'%' ");
                    OracleParameter pFk_yp_id = new OracleParameter(":fk_yp_id", OracleDbType.Varchar2);
                    pFk_yp_id.Direction = ParameterDirection.Input;
                    pFk_yp_id.Value = ypkc_kcParamLike.Fk_yp_id;
                    sqlparams.Add(pFk_yp_id);
                }

                if (null != ypkc_kcParamLike.Ypbh && "" != ypkc_kcParamLike.Ypbh)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YPBH LIKE '%'||:ypbh||'%' ");
                    OracleParameter pYpbh = new OracleParameter(":ypbh", OracleDbType.NVarchar2);
                    pYpbh.Direction = ParameterDirection.Input;
                    pYpbh.Value = ypkc_kcParamLike.Ypbh;
                    sqlparams.Add(pYpbh);
                }

                if (null != ypkc_kcParamLike.Ypmc && "" != ypkc_kcParamLike.Ypmc)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YPMC LIKE '%'||:ypmc||'%' ");
                    OracleParameter pYpmc = new OracleParameter(":ypmc", OracleDbType.NVarchar2);
                    pYpmc.Direction = ParameterDirection.Input;
                    pYpmc.Value = ypkc_kcParamLike.Ypmc;
                    sqlparams.Add(pYpmc);
                }

                if (null != ypkc_kcParamLike.Yptymc && "" != ypkc_kcParamLike.Yptymc)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YPTYMC LIKE '%'||:yptymc||'%' ");
                    OracleParameter pYptymc = new OracleParameter(":yptymc", OracleDbType.NVarchar2);
                    pYptymc.Direction = ParameterDirection.Input;
                    pYptymc.Value = ypkc_kcParamLike.Yptymc;
                    sqlparams.Add(pYptymc);
                }

                if (null != ypkc_kcParamLike.Ypgg && "" != ypkc_kcParamLike.Ypgg)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YPGG LIKE '%'||:ypgg||'%' ");
                    OracleParameter pYpgg = new OracleParameter(":ypgg", OracleDbType.NVarchar2);
                    pYpgg.Direction = ParameterDirection.Input;
                    pYpgg.Value = ypkc_kcParamLike.Ypgg;
                    sqlparams.Add(pYpgg);
                }

                if (null != ypkc_kcParamLike.Jx && "" != ypkc_kcParamLike.Jx)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.JX LIKE '%'||:jx||'%' ");
                    OracleParameter pJx = new OracleParameter(":jx", OracleDbType.NVarchar2);
                    pJx.Direction = ParameterDirection.Input;
                    pJx.Value = ypkc_kcParamLike.Jx;
                    sqlparams.Add(pJx);
                }

                if (null != ypkc_kcParamLike.Pym && "" != ypkc_kcParamLike.Pym)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.PYM LIKE '%'||:pym||'%' ");
                    OracleParameter pPym = new OracleParameter(":pym", OracleDbType.NVarchar2);
                    pPym.Direction = ParameterDirection.Input;
                    pPym.Value = ypkc_kcParamLike.Pym;
                    sqlparams.Add(pPym);
                }

                if (null != ypkc_kcParamLike.Ddw && "" != ypkc_kcParamLike.Ddw)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.DDW LIKE '%'||:ddw||'%' ");
                    OracleParameter pDdw = new OracleParameter(":ddw", OracleDbType.NVarchar2);
                    pDdw.Direction = ParameterDirection.Input;
                    pDdw.Value = ypkc_kcParamLike.Ddw;
                    sqlparams.Add(pDdw);
                }

                if (null != ypkc_kcParamLike.Xdw && "" != ypkc_kcParamLike.Xdw)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.XDW LIKE '%'||:xdw||'%' ");
                    OracleParameter pXdw = new OracleParameter(":xdw", OracleDbType.NVarchar2);
                    pXdw.Direction = ParameterDirection.Input;
                    pXdw.Value = ypkc_kcParamLike.Xdw;
                    sqlparams.Add(pXdw);
                }

                if (null != ypkc_kcParamLike.Dwlx_code && "" != ypkc_kcParamLike.Dwlx_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.DWLX_CODE LIKE '%'||:dwlx_code||'%' ");
                    OracleParameter pDwlx_code = new OracleParameter(":dwlx_code", OracleDbType.NVarchar2);
                    pDwlx_code.Direction = ParameterDirection.Input;
                    pDwlx_code.Value = ypkc_kcParamLike.Dwlx_code;
                    sqlparams.Add(pDwlx_code);
                }

                if (null != ypkc_kcParamLike.Pzwh && "" != ypkc_kcParamLike.Pzwh)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.PZWH LIKE '%'||:pzwh||'%' ");
                    OracleParameter pPzwh = new OracleParameter(":pzwh", OracleDbType.Varchar2);
                    pPzwh.Direction = ParameterDirection.Input;
                    pPzwh.Value = ypkc_kcParamLike.Pzwh;
                    sqlparams.Add(pPzwh);
                }

                if (null != ypkc_kcParamLike.Gyzz && "" != ypkc_kcParamLike.Gyzz)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.GYZZ LIKE '%'||:gyzz||'%' ");
                    OracleParameter pGyzz = new OracleParameter(":gyzz", OracleDbType.Varchar2);
                    pGyzz.Direction = ParameterDirection.Input;
                    pGyzz.Value = ypkc_kcParamLike.Gyzz;
                    sqlparams.Add(pGyzz);
                }

                if (null != ypkc_kcParamLike.Cjmc && "" != ypkc_kcParamLike.Cjmc)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.CJMC LIKE '%'||:cjmc||'%' ");
                    OracleParameter pCjmc = new OracleParameter(":cjmc", OracleDbType.NVarchar2);
                    pCjmc.Direction = ParameterDirection.Input;
                    pCjmc.Value = ypkc_kcParamLike.Cjmc;
                    sqlparams.Add(pCjmc);
                }

                if (null != ypkc_kcParamLike.Ph && "" != ypkc_kcParamLike.Ph)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.PH LIKE '%'||:ph||'%' ");
                    OracleParameter pPh = new OracleParameter(":ph", OracleDbType.NVarchar2);
                    pPh.Direction = ParameterDirection.Input;
                    pPh.Value = ypkc_kcParamLike.Ph;
                    sqlparams.Add(pPh);
                }

                if (null != ypkc_kcParamLike.Zfbz && "" != ypkc_kcParamLike.Zfbz)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.ZFBZ LIKE '%'||:zfbz||'%' ");
                    OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                    pZfbz.Direction = ParameterDirection.Input;
                    pZfbz.Value = ypkc_kcParamLike.Zfbz;
                    sqlparams.Add(pZfbz);
                }

                if (null != ypkc_kcParamLike.Ypfl_code && "" != ypkc_kcParamLike.Ypfl_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YPFL_CODE LIKE '%'||:ypfl_code||'%' ");
                    OracleParameter pYpfl_code = new OracleParameter(":ypfl_code", OracleDbType.NVarchar2);
                    pYpfl_code.Direction = ParameterDirection.Input;
                    pYpfl_code.Value = ypkc_kcParamLike.Ypfl_code;
                    sqlparams.Add(pYpfl_code);
                }

            }

            this.b_isWhere = false;
            return Int32.Parse(OracleHelper.ExecuteScalar(sql.ToString(), sqlparams.ToArray()).ToString());
        }


        /// <summary>
        /// 通用的保存方法，根据用户传入的参数，有ID为修改，没有ID为新增(手动生成OracleConnection对象，此方法用于事务，使用事务必须使用同一个OracleConnection对象)
        /// </summary>
        /// <param name="ypkc_kcParam"></param>
        /// <returns></returns>
        public bool save(Ypkc_kc ypkc_kcParam, OracleConnection con)
        {
            if ("" != ypkc_kcParam.Id && null != ypkc_kcParam.Id)
            {
                //修改
                return this.updateById(ypkc_kcParam, con);
            }
            else
            {
                //新增
                return this.insert(ypkc_kcParam, con);
            }
        }

        /// <summary>
        /// 把dataset中的一行转换为model
        /// </summary>
        /// <param name="row"></param>
        /// <returns></returns>
        private Ypkc_kc dataSetToModel(DataRow row)
        {
            Ypkc_kc ypkc_kcParam = new Ypkc_kc();
            ypkc_kcParam.Id = Convert.ToString(row["ID"]).Trim();
            ypkc_kcParam.Fk_keshi_id = Convert.ToString(row["FK_KESHI_ID"]).Trim();
            ypkc_kcParam.Ksbh = Convert.ToString(row["KSBH"]).Trim();
            ypkc_kcParam.Ksmc = Convert.ToString(row["KSMC"]).Trim();
            ypkc_kcParam.Fk_yp_id = Convert.ToString(row["FK_YP_ID"]).Trim();
            ypkc_kcParam.Ypbh = Convert.ToString(row["YPBH"]).Trim();
            ypkc_kcParam.Ypmc = Convert.ToString(row["YPMC"]).Trim();
            ypkc_kcParam.Yptymc = Convert.ToString(row["YPTYMC"]).Trim();
            ypkc_kcParam.Ypgg = Convert.ToString(row["YPGG"]).Trim();
            ypkc_kcParam.Jx = Convert.ToString(row["JX"]).Trim();
            ypkc_kcParam.Pym = Convert.ToString(row["PYM"]).Trim();
            ypkc_kcParam.Ddw = Convert.ToString(row["DDW"]).Trim();
            ypkc_kcParam.Xdw = Convert.ToString(row["XDW"]).Trim();
            ypkc_kcParam.Dwlx_code = Convert.ToString(row["DWLX_CODE"]).Trim();
            ypkc_kcParam.Hsbl = (decimal?)this.convertDBNullValue(row["HSBL"]);
            ypkc_kcParam.Pzwh = Convert.ToString(row["PZWH"]).Trim();
            ypkc_kcParam.Gyzz = Convert.ToString(row["GYZZ"]).Trim();
            ypkc_kcParam.Cjmc = Convert.ToString(row["CJMC"]).Trim();
            ypkc_kcParam.Ph = Convert.ToString(row["PH"]).Trim();
            ypkc_kcParam.Yxq = (DateTime?)this.convertDBNullValue(row["YXQ"]);
            ypkc_kcParam.Jj = (decimal?)this.convertDBNullValue(row["JJ"]);
            ypkc_kcParam.Lsj = (decimal?)this.convertDBNullValue(row["LSJ"]);
            ypkc_kcParam.Sl = (decimal?)this.convertDBNullValue(row["SL"]);
            ypkc_kcParam.Yksl = (decimal?)this.convertDBNullValue(row["YKSL"]);
            ypkc_kcParam.Zfbz = Convert.ToString(row["ZFBZ"]).Trim();
            ypkc_kcParam.Ypfl_code = Convert.ToString(row["YPFL_CODE"]).Trim();

            return ypkc_kcParam;
        }

       

        public List<object> findForFast(Ypkc_kc ypkc_kcParam, PageInfo page, Ypkc_kc ypkc_kcParamLike, List<SortInfo> sortList)
        {
            //如果没有传查询条件参数，就new一个空的Ypkc_kc对象，标示查询所有数据
            if (null == ypkc_kcParam)
            {
                ypkc_kcParam = new Ypkc_kc();
            }
            if (null != ypkc_kcParam.Id && "" != ypkc_kcParam.Id)
            {
                throw new Exception("此方法不允许指定参数ID，如果需要根据ID查询数据，请调用findById方法；错误出自：find");
            }
            List<Ypkc_kc> ypkc_kcParamList = new List<Ypkc_kc>();//接收查询出的Ypkc_kc对象集合
            List<OracleParameter> sqlparams = new List<OracleParameter>();//保存参数的集合
            StringBuilder sql = new StringBuilder("SELECT A.* ");
            //新建方法findContactObjects(Ypkc_kc ypkc_kcParam, Model.Common.PageInfo page)，在此加入多表连接要显示的项start
            //sql.Append(",B.字段一,B.字段二,B.字段三");
            //新建方法，在此加入多表连接要显示的项end
            sql.Append(" FROM YPKC_KC A ");
            //新建一个方法，在此加入多表连接的语句start
            ////sql.Append(" LEFT JOIN 表名 B ON A.外键=B.ID");
            //新建一个方法，在此加入多表连接的语句end


            if (null != ypkc_kcParam.Fk_keshi_id && "" != ypkc_kcParam.Fk_keshi_id)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.FK_KESHI_ID=:fk_keshi_id ");
                OracleParameter pFk_keshi_id = new OracleParameter(":fk_keshi_id", OracleDbType.Varchar2);
                pFk_keshi_id.Direction = ParameterDirection.Input;
                pFk_keshi_id.Value = ypkc_kcParam.Fk_keshi_id;
                sqlparams.Add(pFk_keshi_id);
            }

            if (null != ypkc_kcParam.Ksbh && "" != ypkc_kcParam.Ksbh)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.KSBH=:ksbh ");
                OracleParameter pKsbh = new OracleParameter(":ksbh", OracleDbType.NVarchar2);
                pKsbh.Direction = ParameterDirection.Input;
                pKsbh.Value = ypkc_kcParam.Ksbh;
                sqlparams.Add(pKsbh);
            }

            if (null != ypkc_kcParam.Ksmc && "" != ypkc_kcParam.Ksmc)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.KSMC=:ksmc ");
                OracleParameter pKsmc = new OracleParameter(":ksmc", OracleDbType.NVarchar2);
                pKsmc.Direction = ParameterDirection.Input;
                pKsmc.Value = ypkc_kcParam.Ksmc;
                sqlparams.Add(pKsmc);
            }

            if (null != ypkc_kcParam.Fk_yp_id && "" != ypkc_kcParam.Fk_yp_id)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.FK_YP_ID=:fk_yp_id ");
                OracleParameter pFk_yp_id = new OracleParameter(":fk_yp_id", OracleDbType.Varchar2);
                pFk_yp_id.Direction = ParameterDirection.Input;
                pFk_yp_id.Value = ypkc_kcParam.Fk_yp_id;
                sqlparams.Add(pFk_yp_id);
            }

            if (null != ypkc_kcParam.Ypbh && "" != ypkc_kcParam.Ypbh)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.YPBH=:ypbh ");
                OracleParameter pYpbh = new OracleParameter(":ypbh", OracleDbType.NVarchar2);
                pYpbh.Direction = ParameterDirection.Input;
                pYpbh.Value = ypkc_kcParam.Ypbh;
                sqlparams.Add(pYpbh);
            }

            if (null != ypkc_kcParam.Ypmc && "" != ypkc_kcParam.Ypmc)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.YPMC=:ypmc ");
                OracleParameter pYpmc = new OracleParameter(":ypmc", OracleDbType.NVarchar2);
                pYpmc.Direction = ParameterDirection.Input;
                pYpmc.Value = ypkc_kcParam.Ypmc;
                sqlparams.Add(pYpmc);
            }

            if (null != ypkc_kcParam.Yptymc && "" != ypkc_kcParam.Yptymc)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.YPTYMC=:yptymc ");
                OracleParameter pYptymc = new OracleParameter(":yptymc", OracleDbType.NVarchar2);
                pYptymc.Direction = ParameterDirection.Input;
                pYptymc.Value = ypkc_kcParam.Yptymc;
                sqlparams.Add(pYptymc);
            }

            if (null != ypkc_kcParam.Ypgg && "" != ypkc_kcParam.Ypgg)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.YPGG=:ypgg ");
                OracleParameter pYpgg = new OracleParameter(":ypgg", OracleDbType.NVarchar2);
                pYpgg.Direction = ParameterDirection.Input;
                pYpgg.Value = ypkc_kcParam.Ypgg;
                sqlparams.Add(pYpgg);
            }

            if (null != ypkc_kcParam.Jx && "" != ypkc_kcParam.Jx)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.JX=:jx ");
                OracleParameter pJx = new OracleParameter(":jx", OracleDbType.NVarchar2);
                pJx.Direction = ParameterDirection.Input;
                pJx.Value = ypkc_kcParam.Jx;
                sqlparams.Add(pJx);
            }

            if (null != ypkc_kcParam.Pym && "" != ypkc_kcParam.Pym)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.PYM=:pym ");
                OracleParameter pPym = new OracleParameter(":pym", OracleDbType.NVarchar2);
                pPym.Direction = ParameterDirection.Input;
                pPym.Value = ypkc_kcParam.Pym;
                sqlparams.Add(pPym);
            }

            if (null != ypkc_kcParam.Ddw && "" != ypkc_kcParam.Ddw)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.DDW=:ddw ");
                OracleParameter pDdw = new OracleParameter(":ddw", OracleDbType.NVarchar2);
                pDdw.Direction = ParameterDirection.Input;
                pDdw.Value = ypkc_kcParam.Ddw;
                sqlparams.Add(pDdw);
            }

            if (null != ypkc_kcParam.Xdw && "" != ypkc_kcParam.Xdw)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.XDW=:xdw ");
                OracleParameter pXdw = new OracleParameter(":xdw", OracleDbType.NVarchar2);
                pXdw.Direction = ParameterDirection.Input;
                pXdw.Value = ypkc_kcParam.Xdw;
                sqlparams.Add(pXdw);
            }

            if (null != ypkc_kcParam.Dwlx_code && "" != ypkc_kcParam.Dwlx_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.DWLX_CODE=:dwlx_code ");
                OracleParameter pDwlx_code = new OracleParameter(":dwlx_code", OracleDbType.NVarchar2);
                pDwlx_code.Direction = ParameterDirection.Input;
                pDwlx_code.Value = ypkc_kcParam.Dwlx_code;
                sqlparams.Add(pDwlx_code);
            }

            if (null != ypkc_kcParam.Hsbl)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.HSBL=:hsbl ");
                OracleParameter pHsbl = new OracleParameter(":hsbl", OracleDbType.Decimal);
                pHsbl.Direction = ParameterDirection.Input;
                pHsbl.Value = ypkc_kcParam.Hsbl;
                sqlparams.Add(pHsbl);

            }

            if (null != ypkc_kcParam.Pzwh && "" != ypkc_kcParam.Pzwh)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.PZWH=:pzwh ");
                OracleParameter pPzwh = new OracleParameter(":pzwh", OracleDbType.Varchar2);
                pPzwh.Direction = ParameterDirection.Input;
                pPzwh.Value = ypkc_kcParam.Pzwh;
                sqlparams.Add(pPzwh);
            }

            if (null != ypkc_kcParam.Gyzz && "" != ypkc_kcParam.Gyzz)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.GYZZ=:gyzz ");
                OracleParameter pGyzz = new OracleParameter(":gyzz", OracleDbType.Varchar2);
                pGyzz.Direction = ParameterDirection.Input;
                pGyzz.Value = ypkc_kcParam.Gyzz;
                sqlparams.Add(pGyzz);
            }

            if (null != ypkc_kcParam.Cjmc && "" != ypkc_kcParam.Cjmc)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.CJMC=:cjmc ");
                OracleParameter pCjmc = new OracleParameter(":cjmc", OracleDbType.NVarchar2);
                pCjmc.Direction = ParameterDirection.Input;
                pCjmc.Value = ypkc_kcParam.Cjmc;
                sqlparams.Add(pCjmc);
            }

            if (null != ypkc_kcParam.Ph && "" != ypkc_kcParam.Ph)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.PH=:ph ");
                OracleParameter pPh = new OracleParameter(":ph", OracleDbType.NVarchar2);
                pPh.Direction = ParameterDirection.Input;
                pPh.Value = ypkc_kcParam.Ph;
                sqlparams.Add(pPh);
            }

            if (DateTime.MinValue != ypkc_kcParam.Yxq && null != ypkc_kcParam.Yxq)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.YXQ=:yxq ");
                OracleParameter pYxq = new OracleParameter(":yxq", OracleDbType.Date);
                pYxq.Direction = ParameterDirection.Input;
                pYxq.Value = ypkc_kcParam.Yxq;
                sqlparams.Add(pYxq);
            }

            if (null != ypkc_kcParam.Jj)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.JJ=:jj ");
                OracleParameter pJj = new OracleParameter(":jj", OracleDbType.Decimal);
                pJj.Direction = ParameterDirection.Input;
                pJj.Value = ypkc_kcParam.Jj;
                sqlparams.Add(pJj);

            }

            if (null != ypkc_kcParam.Lsj)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.LSJ=:lsj ");
                OracleParameter pLsj = new OracleParameter(":lsj", OracleDbType.Decimal);
                pLsj.Direction = ParameterDirection.Input;
                pLsj.Value = ypkc_kcParam.Lsj;
                sqlparams.Add(pLsj);

            }

            if (null != ypkc_kcParam.Sl)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.SL=:sl ");
                OracleParameter pSl = new OracleParameter(":sl", OracleDbType.Decimal);
                pSl.Direction = ParameterDirection.Input;
                pSl.Value = ypkc_kcParam.Sl;
                sqlparams.Add(pSl);

            }

            if (null != ypkc_kcParam.Yksl)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.YKSL=:yksl ");
                OracleParameter pYksl = new OracleParameter(":yksl", OracleDbType.Decimal);
                pYksl.Direction = ParameterDirection.Input;
                pYksl.Value = ypkc_kcParam.Yksl;
                sqlparams.Add(pYksl);

            }

            if (null != ypkc_kcParam.Zfbz && "" != ypkc_kcParam.Zfbz)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.ZFBZ=:zfbz ");
                OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                pZfbz.Direction = ParameterDirection.Input;
                pZfbz.Value = ypkc_kcParam.Zfbz;
                sqlparams.Add(pZfbz);
            }

            if (null != ypkc_kcParam.Ypfl_code && "" != ypkc_kcParam.Ypfl_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.YPFL_CODE=:ypfl_code ");
                OracleParameter pYpfl_code = new OracleParameter(":ypfl_code", OracleDbType.NVarchar2);
                pYpfl_code.Direction = ParameterDirection.Input;
                pYpfl_code.Value = ypkc_kcParam.Ypfl_code;
                sqlparams.Add(pYpfl_code);
            }

            if (ypkc_kcParamLike != null)
            {

                if (null != ypkc_kcParamLike.Fk_keshi_id && "" != ypkc_kcParamLike.Fk_keshi_id)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.FK_KESHI_ID LIKE '%'||:fk_keshi_id||'%' ");
                    OracleParameter pFk_keshi_id = new OracleParameter(":fk_keshi_id", OracleDbType.Varchar2);
                    pFk_keshi_id.Direction = ParameterDirection.Input;
                    pFk_keshi_id.Value = ypkc_kcParamLike.Fk_keshi_id;
                    sqlparams.Add(pFk_keshi_id);
                }

                if (null != ypkc_kcParamLike.Ksbh && "" != ypkc_kcParamLike.Ksbh)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.KSBH LIKE '%'||:ksbh||'%' ");
                    OracleParameter pKsbh = new OracleParameter(":ksbh", OracleDbType.NVarchar2);
                    pKsbh.Direction = ParameterDirection.Input;
                    pKsbh.Value = ypkc_kcParamLike.Ksbh;
                    sqlparams.Add(pKsbh);
                }

                if (null != ypkc_kcParamLike.Ksmc && "" != ypkc_kcParamLike.Ksmc)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.KSMC LIKE '%'||:ksmc||'%' ");
                    OracleParameter pKsmc = new OracleParameter(":ksmc", OracleDbType.NVarchar2);
                    pKsmc.Direction = ParameterDirection.Input;
                    pKsmc.Value = ypkc_kcParamLike.Ksmc;
                    sqlparams.Add(pKsmc);
                }

                if (null != ypkc_kcParamLike.Fk_yp_id && "" != ypkc_kcParamLike.Fk_yp_id)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.FK_YP_ID LIKE '%'||:fk_yp_id||'%' ");
                    OracleParameter pFk_yp_id = new OracleParameter(":fk_yp_id", OracleDbType.Varchar2);
                    pFk_yp_id.Direction = ParameterDirection.Input;
                    pFk_yp_id.Value = ypkc_kcParamLike.Fk_yp_id;
                    sqlparams.Add(pFk_yp_id);
                }

                if (null != ypkc_kcParamLike.Ypbh && "" != ypkc_kcParamLike.Ypbh)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YPBH LIKE :ypbh||'%' ");
                    OracleParameter pYpbh = new OracleParameter(":ypbh", OracleDbType.NVarchar2);
                    pYpbh.Direction = ParameterDirection.Input;
                    pYpbh.Value = ypkc_kcParamLike.Ypbh;
                    sqlparams.Add(pYpbh);
                }

                if (null != ypkc_kcParamLike.Ypmc && "" != ypkc_kcParamLike.Ypmc)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YPMC LIKE '%'||:ypmc||'%'  OR A.YPTYMC LIKE '%'||:yptymc||'%'");
                    OracleParameter pYpmc = new OracleParameter(":ypmc", OracleDbType.NVarchar2);
                    pYpmc.Direction = ParameterDirection.Input;
                    pYpmc.Value = ypkc_kcParamLike.Ypmc;
                    sqlparams.Add(pYpmc);

                    OracleParameter pYptymc = new OracleParameter(":yptymc", OracleDbType.NVarchar2);
                    pYptymc.Direction = ParameterDirection.Input;
                    pYptymc.Value = ypkc_kcParamLike.Yptymc;
                    sqlparams.Add(pYptymc);
                }

                //if (null != ypkc_kcParamLike.Yptymc && "" != ypkc_kcParamLike.Yptymc)
                //{
                //    this.isAnd(sql);
                //    this.isWhere(sql);
                //    sql.Append(" A.YPTYMC LIKE '%'||:yptymc||'%' ");
                //    OracleParameter pYptymc = new OracleParameter(":yptymc", OracleDbType.NVarchar2);
                //    pYptymc.Direction = ParameterDirection.Input;
                //    pYptymc.Value = ypkc_kcParamLike.Yptymc;
                //    sqlparams.Add(pYptymc);
                //}

                if (null != ypkc_kcParamLike.Ypgg && "" != ypkc_kcParamLike.Ypgg)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YPGG LIKE '%'||:ypgg||'%' ");
                    OracleParameter pYpgg = new OracleParameter(":ypgg", OracleDbType.NVarchar2);
                    pYpgg.Direction = ParameterDirection.Input;
                    pYpgg.Value = ypkc_kcParamLike.Ypgg;
                    sqlparams.Add(pYpgg);
                }

                if (null != ypkc_kcParamLike.Jx && "" != ypkc_kcParamLike.Jx)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.JX LIKE '%'||:jx||'%' ");
                    OracleParameter pJx = new OracleParameter(":jx", OracleDbType.NVarchar2);
                    pJx.Direction = ParameterDirection.Input;
                    pJx.Value = ypkc_kcParamLike.Jx;
                    sqlparams.Add(pJx);
                }

                if (null != ypkc_kcParamLike.Pym && "" != ypkc_kcParamLike.Pym)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.PYM LIKE '%'||:pym||'%' ");
                    OracleParameter pPym = new OracleParameter(":pym", OracleDbType.NVarchar2);
                    pPym.Direction = ParameterDirection.Input;
                    pPym.Value = ypkc_kcParamLike.Pym;
                    sqlparams.Add(pPym);
                }

                if (null != ypkc_kcParamLike.Ddw && "" != ypkc_kcParamLike.Ddw)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.DDW LIKE '%'||:ddw||'%' ");
                    OracleParameter pDdw = new OracleParameter(":ddw", OracleDbType.NVarchar2);
                    pDdw.Direction = ParameterDirection.Input;
                    pDdw.Value = ypkc_kcParamLike.Ddw;
                    sqlparams.Add(pDdw);
                }

                if (null != ypkc_kcParamLike.Xdw && "" != ypkc_kcParamLike.Xdw)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.XDW LIKE '%'||:xdw||'%' ");
                    OracleParameter pXdw = new OracleParameter(":xdw", OracleDbType.NVarchar2);
                    pXdw.Direction = ParameterDirection.Input;
                    pXdw.Value = ypkc_kcParamLike.Xdw;
                    sqlparams.Add(pXdw);
                }

                if (null != ypkc_kcParamLike.Dwlx_code && "" != ypkc_kcParamLike.Dwlx_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.DWLX_CODE LIKE '%'||:dwlx_code||'%' ");
                    OracleParameter pDwlx_code = new OracleParameter(":dwlx_code", OracleDbType.NVarchar2);
                    pDwlx_code.Direction = ParameterDirection.Input;
                    pDwlx_code.Value = ypkc_kcParamLike.Dwlx_code;
                    sqlparams.Add(pDwlx_code);
                }

                if (null != ypkc_kcParamLike.Pzwh && "" != ypkc_kcParamLike.Pzwh)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.PZWH LIKE '%'||:pzwh||'%' ");
                    OracleParameter pPzwh = new OracleParameter(":pzwh", OracleDbType.Varchar2);
                    pPzwh.Direction = ParameterDirection.Input;
                    pPzwh.Value = ypkc_kcParamLike.Pzwh;
                    sqlparams.Add(pPzwh);
                }

                if (null != ypkc_kcParamLike.Gyzz && "" != ypkc_kcParamLike.Gyzz)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.GYZZ LIKE '%'||:gyzz||'%' ");
                    OracleParameter pGyzz = new OracleParameter(":gyzz", OracleDbType.Varchar2);
                    pGyzz.Direction = ParameterDirection.Input;
                    pGyzz.Value = ypkc_kcParamLike.Gyzz;
                    sqlparams.Add(pGyzz);
                }

                if (null != ypkc_kcParamLike.Cjmc && "" != ypkc_kcParamLike.Cjmc)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.CJMC LIKE '%'||:cjmc||'%' ");
                    OracleParameter pCjmc = new OracleParameter(":cjmc", OracleDbType.NVarchar2);
                    pCjmc.Direction = ParameterDirection.Input;
                    pCjmc.Value = ypkc_kcParamLike.Cjmc;
                    sqlparams.Add(pCjmc);
                }

                if (null != ypkc_kcParamLike.Ph && "" != ypkc_kcParamLike.Ph)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.PH LIKE '%'||:ph||'%' ");
                    OracleParameter pPh = new OracleParameter(":ph", OracleDbType.NVarchar2);
                    pPh.Direction = ParameterDirection.Input;
                    pPh.Value = ypkc_kcParamLike.Ph;
                    sqlparams.Add(pPh);
                }

                if (null != ypkc_kcParamLike.Zfbz && "" != ypkc_kcParamLike.Zfbz)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.ZFBZ LIKE '%'||:zfbz||'%' ");
                    OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                    pZfbz.Direction = ParameterDirection.Input;
                    pZfbz.Value = ypkc_kcParamLike.Zfbz;
                    sqlparams.Add(pZfbz);
                }
                if (null != ypkc_kcParamLike.Ypfl_code && "" != ypkc_kcParamLike.Ypfl_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YPFL_CODE LIKE '%'||:ypfl_code||'%' ");
                    OracleParameter pYpfl_code = new OracleParameter(":ypfl_code", OracleDbType.NVarchar2);
                    pYpfl_code.Direction = ParameterDirection.Input;
                    pYpfl_code.Value = ypkc_kcParamLike.Ypfl_code;
                    sqlparams.Add(pYpfl_code);
                }

            }

            this.b_isWhere = false;
            this.addSort(sql, sortList);//排序
            //*******分页start1*********如果分页对象为空，则全部数据查出，如果不为空
            List<object> returnList = new List<object>();//返回的List,索引0为List<Ypkc_kc>对象,索引1为Model.Common.PageInfo分页信息对象
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
            //把每一行数据转换为一个对象放入List<Ypkc_kc>中
            for (int i = 0; i < rows.Count; i++)
            {
                DataRow row = rows[i];
                //ypkc_kcParamList.Add(this.dataSetContactObjectsToModel(row));
                ypkc_kcParamList.Add(this.dataSetToModel(row));
            }

            //*******分页start2*********如果没有传入分页对象，则新建一个分页对象当做返回值
            if (null == page)
            {
                page = new Model.Common.PageInfo();
                page.AllCount = rows.Count;
            }
            returnList.Add(ypkc_kcParamList);//把List<Ypkc_kc>放入List<object>中第一个
            returnList.Add(page);//把page对象放入List<object>中第二个
            //*******分页end2*********
            return returnList;
        }

        //*******************在此以后添加新的方法start
        #region DAL层的implement,实现，start

        /// <summary>
        /// 把dataset中的一行转换为model, 包括相关联的外键对象
        /// </summary>
        /// <param name="row"></param>
        /// <returns></returns>
        private Ypkc_kc dataSetContactObjectsToModel(DataRow row)
        {
            Ypkc_kc ypkc_kcParam = this.dataSetToModel(row);

            //添加代码类别实体对象,药品单位类型（关联代码表，单位类型）对象
            Jc_code dwlxCode = new Jc_code();
            dwlxCode.Id = Convert.ToString(row["DWLX_CODE_ID"]).Trim();
            dwlxCode.Name = Convert.ToString(row["DWLX_CODE_NAME"]).Trim();
            dwlxCode.Value = Convert.ToString(row["DWLX_CODE_VALUE"]).Trim();
            dwlxCode.Fk_code_type = Convert.ToString(row["DWLX_CODE_FKCODETYPE"]).Trim();
            dwlxCode.Zfbz = Convert.ToString(row["DWLX_CODE_ZFBZ"]).Trim();
            dwlxCode.Remark = Convert.ToString(row["DWLX_CODE_REMARK"]).Trim();
            ypkc_kcParam.DwlxCode = dwlxCode;

            //添加代码类别实体对象,药品类型（关联代码表，西药、成药、中药、卫材）对象
            Jc_code ypflCode = new Jc_code();
            ypflCode.Id = Convert.ToString(row["YPFL_CODE_ID"]).Trim();
            ypflCode.Name = Convert.ToString(row["YPFL_CODE_NAME"]).Trim();
            ypflCode.Value = Convert.ToString(row["YPFL_CODE_VALUE"]).Trim();
            ypflCode.Fk_code_type = Convert.ToString(row["YPFL_CODE_FKCODETYPE"]).Trim();
            ypflCode.Zfbz = Convert.ToString(row["YPFL_CODE_ZFBZ"]).Trim();
            ypflCode.Remark = Convert.ToString(row["YPFL_CODE_REMARK"]).Trim();
            ypkc_kcParam.YpflCode = ypflCode;

            return ypkc_kcParam;
        }



        /// <summary>
        /// 查找指定ID的用户,得到相关联的外键对象的方法
        /// </summary>
        /// <remarks>如果id为null、id重复、id未找到就抛异常</remarks>
        /// <returns>Ypkc_kc</returns>
        public Ypkc_kc findContactObjectsById(string id)
        {
            if ("" == id || null == id)
            {
                throw new Exception("主键ID不能为空，请赋值");
            }
            StringBuilder sql = new StringBuilder("SELECT A.* ");
            //新建方法findContactObjectsById，在此加入多表连接要显示的项start
            //sql.Append(",B.字段一,B.字段二,B.字段三");

            sql.Append(@"
            ,TT_DWLX_CODE.ID AS DWLX_CODE_ID,TT_DWLX_CODE.NAME AS DWLX_CODE_NAME,TT_DWLX_CODE.VALUE AS DWLX_CODE_VALUE,TT_DWLX_CODE.FK_CODE_TYPE AS DWLX_CODE_FKCODETYPE,TT_DWLX_CODE.ZFBZ AS DWLX_CODE_ZFBZ,TT_DWLX_CODE.REMARK AS DWLX_CODE_REMARK
            ");

            sql.Append(@"
            ,TT_YPFL_CODE.ID AS YPFL_CODE_ID,TT_YPFL_CODE.NAME AS YPFL_CODE_NAME,TT_YPFL_CODE.VALUE AS YPFL_CODE_VALUE,TT_YPFL_CODE.FK_CODE_TYPE AS YPFL_CODE_FKCODETYPE,TT_YPFL_CODE.ZFBZ AS YPFL_CODE_ZFBZ,TT_YPFL_CODE.REMARK AS YPFL_CODE_REMARK
            ");

            //新建方法，在此加入多表连接要显示的项end
            sql.Append(" FROM YPKC_KC A ");
            //新建一个方法，在此加入多表连接的语句start
            //sql.Append("LEFT JOIN 外键表名 B ON A.外键=B.ID");

            sql.Append(@" 
                        LEFT JOIN 
                        (SELECT X.* FROM JC_CODE X WHERE X.FK_CODE_TYPE IN (SELECT Y.ID FROM JC_CODE_TYPE Y WHERE Y.VALUE='" + Model.Common.CommonCode.代码类型值.库存_药品单位类型 + @"')) TT_DWLX_CODE
                        ON A.DWLX_CODE = TT_DWLX_CODE.VALUE
            ");

            sql.Append(@" 
                        LEFT JOIN 
                        (SELECT X.* FROM JC_CODE X WHERE X.FK_CODE_TYPE IN (SELECT Y.ID FROM JC_CODE_TYPE Y WHERE Y.VALUE='" + Model.Common.CommonCode.代码类型值.药品_分类 + @"')) TT_YPFL_CODE
                        ON A.YPFL_CODE = TT_YPFL_CODE.VALUE
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
        /// <param name="ypkc_kcParam"></param>
        /// <param name="page">分页对象</param>
        ///<param name="ypkc_kcParamLike">模糊查询参数</param>
        ///<param name="sortList">排序参数对象的集合</param>
        /// <returns>满足条件的所有Ypkc_kc对象集合list</returns>
        public List<object> findContactObjects(Ypkc_kc ypkc_kcParam, Model.Common.PageInfo page, Ypkc_kc ypkc_kcParamLike, List<SortInfo> sortList)
        {
            //如果没有传查询条件参数，就new一个空的Ypkc_kc对象，标示查询所有数据
            if (null == ypkc_kcParam)
            {
                ypkc_kcParam = new Ypkc_kc();
            }
            if (null != ypkc_kcParam.Id && "" != ypkc_kcParam.Id)
            {
                throw new Exception("此方法不允许指定参数ID，如果需要根据ID查询数据，请调用findById方法；错误出自：find");
            }

            List<Ypkc_kc> ypkc_kcParamList = new List<Ypkc_kc>();//接收查询出的Ypkc_kc对象集合
            List<OracleParameter> sqlparams = new List<OracleParameter>();//保存参数的集合
            StringBuilder sql = new StringBuilder("SELECT A.* ");
            //新建方法findAllContactObjects(Ypkc_kc ypkc_kcParam, Model.Common.PageInfo page)，在此加入多表连接要显示的项start
            //sql.Append(",B.字段一,B.字段二,B.字段三");

            sql.Append(@"
            ,TT_DWLX_CODE.ID AS DWLX_CODE_ID,TT_DWLX_CODE.NAME AS DWLX_CODE_NAME,TT_DWLX_CODE.VALUE AS DWLX_CODE_VALUE,TT_DWLX_CODE.FK_CODE_TYPE AS DWLX_CODE_FKCODETYPE,TT_DWLX_CODE.ZFBZ AS DWLX_CODE_ZFBZ,TT_DWLX_CODE.REMARK AS DWLX_CODE_REMARK
            ");

            sql.Append(@"
            ,TT_YPFL_CODE.ID AS YPFL_CODE_ID,TT_YPFL_CODE.NAME AS YPFL_CODE_NAME,TT_YPFL_CODE.VALUE AS YPFL_CODE_VALUE,TT_YPFL_CODE.FK_CODE_TYPE AS YPFL_CODE_FKCODETYPE,TT_YPFL_CODE.ZFBZ AS YPFL_CODE_ZFBZ,TT_YPFL_CODE.REMARK AS YPFL_CODE_REMARK
            ");

            //新建方法，在此加入多表连接要显示的项end
            sql.Append(" FROM YPKC_KC A ");
            //新建一个方法，在此加入多表连接的语句start
            ////sql.Append(" LEFT JOIN 表名 B ON A.外键=B.ID");

            sql.Append(@" 
                        LEFT JOIN 
                        (SELECT X.* FROM JC_CODE X WHERE X.FK_CODE_TYPE IN (SELECT Y.ID FROM JC_CODE_TYPE Y WHERE Y.VALUE='" + Model.Common.CommonCode.代码类型值.库存_药品单位类型 + @"')) TT_DWLX_CODE
                        ON A.DWLX_CODE = TT_DWLX_CODE.VALUE
            ");

            sql.Append(@" 
                        LEFT JOIN 
                        (SELECT X.* FROM JC_CODE X WHERE X.FK_CODE_TYPE IN (SELECT Y.ID FROM JC_CODE_TYPE Y WHERE Y.VALUE='" + Model.Common.CommonCode.代码类型值.药品_分类 + @"')) TT_YPFL_CODE
                        ON A.YPFL_CODE = TT_YPFL_CODE.VALUE
            ");

            //新建一个方法，在此加入多表连接的语句end


            if (null != ypkc_kcParam.Fk_keshi_id && "" != ypkc_kcParam.Fk_keshi_id)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.FK_KESHI_ID=:fk_keshi_id ");
                OracleParameter pFk_keshi_id = new OracleParameter(":fk_keshi_id", OracleDbType.Varchar2);
                pFk_keshi_id.Value = ypkc_kcParam.Fk_keshi_id;
                sqlparams.Add(pFk_keshi_id);
            }

            if (null != ypkc_kcParam.Ksbh && "" != ypkc_kcParam.Ksbh)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.KSBH=:ksbh ");
                OracleParameter pKsbh = new OracleParameter(":ksbh", OracleDbType.NVarchar2);
                pKsbh.Value = ypkc_kcParam.Ksbh;
                sqlparams.Add(pKsbh);
            }

            if (null != ypkc_kcParam.Ksmc && "" != ypkc_kcParam.Ksmc)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.KSMC=:ksmc ");
                OracleParameter pKsmc = new OracleParameter(":ksmc", OracleDbType.NVarchar2);
                pKsmc.Value = ypkc_kcParam.Ksmc;
                sqlparams.Add(pKsmc);
            }

            if (null != ypkc_kcParam.Fk_yp_id && "" != ypkc_kcParam.Fk_yp_id)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.FK_YP_ID=:fk_yp_id ");
                OracleParameter pFk_yp_id = new OracleParameter(":fk_yp_id", OracleDbType.Varchar2);
                pFk_yp_id.Value = ypkc_kcParam.Fk_yp_id;
                sqlparams.Add(pFk_yp_id);
            }

            if (null != ypkc_kcParam.Ypbh && "" != ypkc_kcParam.Ypbh)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.YPBH=:ypbh ");
                OracleParameter pYpbh = new OracleParameter(":ypbh", OracleDbType.NVarchar2);
                pYpbh.Value = ypkc_kcParam.Ypbh;
                sqlparams.Add(pYpbh);
            }

            if (null != ypkc_kcParam.Ypmc && "" != ypkc_kcParam.Ypmc)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.YPMC=:ypmc ");
                OracleParameter pYpmc = new OracleParameter(":ypmc", OracleDbType.NVarchar2);
                pYpmc.Value = ypkc_kcParam.Ypmc;
                sqlparams.Add(pYpmc);
            }

            if (null != ypkc_kcParam.Yptymc && "" != ypkc_kcParam.Yptymc)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.YPTYMC=:yptymc ");
                OracleParameter pYptymc = new OracleParameter(":yptymc", OracleDbType.NVarchar2);
                pYptymc.Value = ypkc_kcParam.Yptymc;
                sqlparams.Add(pYptymc);
            }

            if (null != ypkc_kcParam.Ypgg && "" != ypkc_kcParam.Ypgg)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.YPGG=:ypgg ");
                OracleParameter pYpgg = new OracleParameter(":ypgg", OracleDbType.NVarchar2);
                pYpgg.Value = ypkc_kcParam.Ypgg;
                sqlparams.Add(pYpgg);
            }

            if (null != ypkc_kcParam.Jx && "" != ypkc_kcParam.Jx)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.JX=:jx ");
                OracleParameter pJx = new OracleParameter(":jx", OracleDbType.NVarchar2);
                pJx.Value = ypkc_kcParam.Jx;
                sqlparams.Add(pJx);
            }

            if (null != ypkc_kcParam.Pym && "" != ypkc_kcParam.Pym)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.PYM=:pym ");
                OracleParameter pPym = new OracleParameter(":pym", OracleDbType.NVarchar2);
                pPym.Value = ypkc_kcParam.Pym;
                sqlparams.Add(pPym);
            }

            if (null != ypkc_kcParam.Ddw && "" != ypkc_kcParam.Ddw)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.DDW=:ddw ");
                OracleParameter pDdw = new OracleParameter(":ddw", OracleDbType.NVarchar2);
                pDdw.Value = ypkc_kcParam.Ddw;
                sqlparams.Add(pDdw);
            }

            if (null != ypkc_kcParam.Xdw && "" != ypkc_kcParam.Xdw)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.XDW=:xdw ");
                OracleParameter pXdw = new OracleParameter(":xdw", OracleDbType.NVarchar2);
                pXdw.Value = ypkc_kcParam.Xdw;
                sqlparams.Add(pXdw);
            }

            if (null != ypkc_kcParam.Dwlx_code && "" != ypkc_kcParam.Dwlx_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.DWLX_CODE=:dwlx_code ");
                OracleParameter pDwlx_code = new OracleParameter(":dwlx_code", OracleDbType.NVarchar2);
                pDwlx_code.Value = ypkc_kcParam.Dwlx_code;
                sqlparams.Add(pDwlx_code);
            }

            if (null != ypkc_kcParam.Hsbl)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" HSBL=:hsbl ");
                OracleParameter pHsbl = new OracleParameter(":hsbl", OracleDbType.Decimal);
                pHsbl.Value = ypkc_kcParam.Hsbl;
                sqlparams.Add(pHsbl);

            }

            if (null != ypkc_kcParam.Pzwh && "" != ypkc_kcParam.Pzwh)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.PZWH=:pzwh ");
                OracleParameter pPzwh = new OracleParameter(":pzwh", OracleDbType.Varchar2);
                pPzwh.Value = ypkc_kcParam.Pzwh;
                sqlparams.Add(pPzwh);
            }

            if (null != ypkc_kcParam.Gyzz && "" != ypkc_kcParam.Gyzz)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.GYZZ=:gyzz ");
                OracleParameter pGyzz = new OracleParameter(":gyzz", OracleDbType.Varchar2);
                pGyzz.Value = ypkc_kcParam.Gyzz;
                sqlparams.Add(pGyzz);
            }

            if (null != ypkc_kcParam.Cjmc && "" != ypkc_kcParam.Cjmc)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.CJMC=:cjmc ");
                OracleParameter pCjmc = new OracleParameter(":cjmc", OracleDbType.NVarchar2);
                pCjmc.Value = ypkc_kcParam.Cjmc;
                sqlparams.Add(pCjmc);
            }

            if (null != ypkc_kcParam.Ph && "" != ypkc_kcParam.Ph)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.PH=:ph ");
                OracleParameter pPh = new OracleParameter(":ph", OracleDbType.NVarchar2);
                pPh.Value = ypkc_kcParam.Ph;
                sqlparams.Add(pPh);
            }

            if (DateTime.MinValue != ypkc_kcParam.Yxq && null != ypkc_kcParam.Yxq)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.YXQ=:yxq ");
                OracleParameter pYxq = new OracleParameter(":yxq", OracleDbType.Date);
                pYxq.Value = ypkc_kcParam.Yxq;
                sqlparams.Add(pYxq);
            }

            if (null != ypkc_kcParam.Jj)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" JJ=:jj ");
                OracleParameter pJj = new OracleParameter(":jj", OracleDbType.Decimal);
                pJj.Value = ypkc_kcParam.Jj;
                sqlparams.Add(pJj);

            }

            if (null != ypkc_kcParam.Lsj)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" LSJ=:lsj ");
                OracleParameter pLsj = new OracleParameter(":lsj", OracleDbType.Decimal);
                pLsj.Value = ypkc_kcParam.Lsj;
                sqlparams.Add(pLsj);

            }

            if (null != ypkc_kcParam.Sl)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" SL=:sl ");
                OracleParameter pSl = new OracleParameter(":sl", OracleDbType.Decimal);
                pSl.Value = ypkc_kcParam.Sl;
                sqlparams.Add(pSl);

            }

            if (null != ypkc_kcParam.Yksl)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" YKSL=:yksl ");
                OracleParameter pYksl = new OracleParameter(":yksl", OracleDbType.Decimal);
                pYksl.Value = ypkc_kcParam.Yksl;
                sqlparams.Add(pYksl);

            }

            if (null != ypkc_kcParam.Zfbz && "" != ypkc_kcParam.Zfbz)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.ZFBZ=:zfbz ");
                OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                pZfbz.Value = ypkc_kcParam.Zfbz;
                sqlparams.Add(pZfbz);
            }

            if (null != ypkc_kcParam.Ypfl_code && "" != ypkc_kcParam.Ypfl_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.YPFL_CODE=:ypfl_code ");
                OracleParameter pYpfl_code = new OracleParameter(":ypfl_code", OracleDbType.NVarchar2);
                pYpfl_code.Value = ypkc_kcParam.Ypfl_code;
                sqlparams.Add(pYpfl_code);
            }

            if (ypkc_kcParamLike != null)
            {

                if (null != ypkc_kcParamLike.Fk_keshi_id && "" != ypkc_kcParamLike.Fk_keshi_id)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.FK_KESHI_ID LIKE '%'||:fk_keshi_id||'%' ");
                    OracleParameter pFk_keshi_id = new OracleParameter(":fk_keshi_id", OracleDbType.Varchar2);
                    pFk_keshi_id.Direction = ParameterDirection.Input;
                    pFk_keshi_id.Value = ypkc_kcParamLike.Fk_keshi_id;
                    sqlparams.Add(pFk_keshi_id);
                }

                if (null != ypkc_kcParamLike.Ksbh && "" != ypkc_kcParamLike.Ksbh)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.KSBH LIKE '%'||:ksbh||'%' ");
                    OracleParameter pKsbh = new OracleParameter(":ksbh", OracleDbType.NVarchar2);
                    pKsbh.Direction = ParameterDirection.Input;
                    pKsbh.Value = ypkc_kcParamLike.Ksbh;
                    sqlparams.Add(pKsbh);
                }

                if (null != ypkc_kcParamLike.Ksmc && "" != ypkc_kcParamLike.Ksmc)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.KSMC LIKE '%'||:ksmc||'%' ");
                    OracleParameter pKsmc = new OracleParameter(":ksmc", OracleDbType.NVarchar2);
                    pKsmc.Direction = ParameterDirection.Input;
                    pKsmc.Value = ypkc_kcParamLike.Ksmc;
                    sqlparams.Add(pKsmc);
                }

                if (null != ypkc_kcParamLike.Fk_yp_id && "" != ypkc_kcParamLike.Fk_yp_id)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.FK_YP_ID LIKE '%'||:fk_yp_id||'%' ");
                    OracleParameter pFk_yp_id = new OracleParameter(":fk_yp_id", OracleDbType.Varchar2);
                    pFk_yp_id.Direction = ParameterDirection.Input;
                    pFk_yp_id.Value = ypkc_kcParamLike.Fk_yp_id;
                    sqlparams.Add(pFk_yp_id);
                }

                if (null != ypkc_kcParamLike.Ypbh && "" != ypkc_kcParamLike.Ypbh)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YPBH LIKE '%'||:ypbh||'%' ");
                    OracleParameter pYpbh = new OracleParameter(":ypbh", OracleDbType.NVarchar2);
                    pYpbh.Direction = ParameterDirection.Input;
                    pYpbh.Value = ypkc_kcParamLike.Ypbh;
                    sqlparams.Add(pYpbh);
                }

                if (null != ypkc_kcParamLike.Ypmc && "" != ypkc_kcParamLike.Ypmc)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YPMC LIKE '%'||:ypmc||'%' ");
                    OracleParameter pYpmc = new OracleParameter(":ypmc", OracleDbType.NVarchar2);
                    pYpmc.Direction = ParameterDirection.Input;
                    pYpmc.Value = ypkc_kcParamLike.Ypmc;
                    sqlparams.Add(pYpmc);
                }

                if (null != ypkc_kcParamLike.Yptymc && "" != ypkc_kcParamLike.Yptymc)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YPTYMC LIKE '%'||:yptymc||'%' ");
                    OracleParameter pYptymc = new OracleParameter(":yptymc", OracleDbType.NVarchar2);
                    pYptymc.Direction = ParameterDirection.Input;
                    pYptymc.Value = ypkc_kcParamLike.Yptymc;
                    sqlparams.Add(pYptymc);
                }

                if (null != ypkc_kcParamLike.Ypgg && "" != ypkc_kcParamLike.Ypgg)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YPGG LIKE '%'||:ypgg||'%' ");
                    OracleParameter pYpgg = new OracleParameter(":ypgg", OracleDbType.NVarchar2);
                    pYpgg.Direction = ParameterDirection.Input;
                    pYpgg.Value = ypkc_kcParamLike.Ypgg;
                    sqlparams.Add(pYpgg);
                }

                if (null != ypkc_kcParamLike.Jx && "" != ypkc_kcParamLike.Jx)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.JX LIKE '%'||:jx||'%' ");
                    OracleParameter pJx = new OracleParameter(":jx", OracleDbType.NVarchar2);
                    pJx.Direction = ParameterDirection.Input;
                    pJx.Value = ypkc_kcParamLike.Jx;
                    sqlparams.Add(pJx);
                }

                if (null != ypkc_kcParamLike.Pym && "" != ypkc_kcParamLike.Pym)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.PYM LIKE '%'||:pym||'%' ");
                    OracleParameter pPym = new OracleParameter(":pym", OracleDbType.NVarchar2);
                    pPym.Direction = ParameterDirection.Input;
                    pPym.Value = ypkc_kcParamLike.Pym;
                    sqlparams.Add(pPym);
                }

                if (null != ypkc_kcParamLike.Ddw && "" != ypkc_kcParamLike.Ddw)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.DDW LIKE '%'||:ddw||'%' ");
                    OracleParameter pDdw = new OracleParameter(":ddw", OracleDbType.NVarchar2);
                    pDdw.Direction = ParameterDirection.Input;
                    pDdw.Value = ypkc_kcParamLike.Ddw;
                    sqlparams.Add(pDdw);
                }

                if (null != ypkc_kcParamLike.Xdw && "" != ypkc_kcParamLike.Xdw)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.XDW LIKE '%'||:xdw||'%' ");
                    OracleParameter pXdw = new OracleParameter(":xdw", OracleDbType.NVarchar2);
                    pXdw.Direction = ParameterDirection.Input;
                    pXdw.Value = ypkc_kcParamLike.Xdw;
                    sqlparams.Add(pXdw);
                }

                if (null != ypkc_kcParamLike.Dwlx_code && "" != ypkc_kcParamLike.Dwlx_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.DWLX_CODE LIKE '%'||:dwlx_code||'%' ");
                    OracleParameter pDwlx_code = new OracleParameter(":dwlx_code", OracleDbType.NVarchar2);
                    pDwlx_code.Direction = ParameterDirection.Input;
                    pDwlx_code.Value = ypkc_kcParamLike.Dwlx_code;
                    sqlparams.Add(pDwlx_code);
                }

                if (null != ypkc_kcParamLike.Pzwh && "" != ypkc_kcParamLike.Pzwh)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.PZWH LIKE '%'||:pzwh||'%' ");
                    OracleParameter pPzwh = new OracleParameter(":pzwh", OracleDbType.Varchar2);
                    pPzwh.Direction = ParameterDirection.Input;
                    pPzwh.Value = ypkc_kcParamLike.Pzwh;
                    sqlparams.Add(pPzwh);
                }

                if (null != ypkc_kcParamLike.Gyzz && "" != ypkc_kcParamLike.Gyzz)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.GYZZ LIKE '%'||:gyzz||'%' ");
                    OracleParameter pGyzz = new OracleParameter(":gyzz", OracleDbType.Varchar2);
                    pGyzz.Direction = ParameterDirection.Input;
                    pGyzz.Value = ypkc_kcParamLike.Gyzz;
                    sqlparams.Add(pGyzz);
                }

                if (null != ypkc_kcParamLike.Cjmc && "" != ypkc_kcParamLike.Cjmc)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.CJMC LIKE '%'||:cjmc||'%' ");
                    OracleParameter pCjmc = new OracleParameter(":cjmc", OracleDbType.NVarchar2);
                    pCjmc.Direction = ParameterDirection.Input;
                    pCjmc.Value = ypkc_kcParamLike.Cjmc;
                    sqlparams.Add(pCjmc);
                }

                if (null != ypkc_kcParamLike.Ph && "" != ypkc_kcParamLike.Ph)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.PH LIKE '%'||:ph||'%' ");
                    OracleParameter pPh = new OracleParameter(":ph", OracleDbType.NVarchar2);
                    pPh.Direction = ParameterDirection.Input;
                    pPh.Value = ypkc_kcParamLike.Ph;
                    sqlparams.Add(pPh);
                }

                if (null != ypkc_kcParamLike.Zfbz && "" != ypkc_kcParamLike.Zfbz)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.ZFBZ LIKE '%'||:zfbz||'%' ");
                    OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                    pZfbz.Direction = ParameterDirection.Input;
                    pZfbz.Value = ypkc_kcParamLike.Zfbz;
                    sqlparams.Add(pZfbz);
                }

                if (null != ypkc_kcParamLike.Ypfl_code && "" != ypkc_kcParamLike.Ypfl_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YPFL_CODE LIKE '%'||:ypfl_code||'%' ");
                    OracleParameter pYpfl_code = new OracleParameter(":ypfl_code", OracleDbType.NVarchar2);
                    pYpfl_code.Direction = ParameterDirection.Input;
                    pYpfl_code.Value = ypkc_kcParamLike.Ypfl_code;
                    sqlparams.Add(pYpfl_code);
                }

            }

            this.b_isWhere = false;
            //排序
            this.addSort(sql, sortList);
            //*******分页start1*********如果分页对象为空，则全部数据查出，如果不为空
            List<object> returnList = new List<object>();//返回的List,索引0为List<Ypkc_kc>对象,索引1为Model.Common.PageInfo分页信息对象
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
            //把每一行数据转换为一个对象放入List<Ypkc_kc>中
            for (int i = 0; i < rows.Count; i++)
            {
                DataRow row = rows[i];
                ypkc_kcParamList.Add(this.dataSetContactObjectsToModel(row));
                //ypkc_kcParamList.Add(this.dataSetToModel(row));
            }

            //*******分页start2*********如果没有传入分页对象，则新建一个分页对象当做返回值
            if (null == page)
            {
                page = new Model.Common.PageInfo();
                page.AllCount = rows.Count;
            }
            returnList.Add(ypkc_kcParamList);//把List<Ypkc_kc>放入List<object>中第一个
            returnList.Add(page);//把page对象放入List<object>中第二个
            //*******分页end2*********
            return returnList;
        }
        #endregion DAL层的implement,实现，end

        

        //*******************在此以后添加新的方法end

    }
}


