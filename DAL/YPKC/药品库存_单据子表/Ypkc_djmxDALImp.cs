

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

namespace DAL.YPKC.药品库存_单据子表
{
    /// <summary>
    ///数据库访问层的Ypkc_djmx实现类
    ///此类由代码生成器生成
    ///表名：YPKC_DJMX
    ///生成日期：2015-12-24 16:04:56
    /// 

    ///作者：罗新鑫
    ///联系电话：15087010221
    ///联系邮箱：362527240@qq.com
        
    /// </summary>
    public class Ypkc_djmxDALImp :Base.BasDAL,Ypkc_djmxDAL
    {

        /// <summary>
        /// 插入一条数据（如果需要供事务使用就传入OracleConnection对象，如果不供就传入null，方法自动生成OracleConnection对象）
        /// 主键为null时，自动生成主键guid，一般不直接调用此方法，请调用save方法进行单条数据的插入和修改       
        /// </summary>
        /// <param name="ypkc_djmxParam">要插入的ypkc_djmxParam对象</param>
        /// <param name="con">Oracle连接对象（为null时自动生成）</param>
        /// <returns>是否添加成功（影响的行数为1时成功）</returns>
        public bool insert(Ypkc_djmx ypkc_djmxParam,OracleConnection con)
        {
            if (""==ypkc_djmxParam.Id||null==ypkc_djmxParam.Id)
            {
                ypkc_djmxParam.Id = Model.Common.GUIDHelper.getGuid();
            }
            List<OracleParameter> sqlparams = new List<OracleParameter>();
            
            StringBuilder sql = new StringBuilder("INSERT INTO YPKC_DJMX(id,djh,fk_dj_id,fk_yp,ypbh,ypmc,yptymc,ddw,xdw,hsbl,pzwh,gyzz,jx,ypgg,cjmc,pym,ph,yxq,jj,lsj,sl,jjje,lsjje,zfbz) VALUES(:id,:djh,:fk_dj_id,:fk_yp,:ypbh,:ypmc,:yptymc,:ddw,:xdw,:hsbl,:pzwh,:gyzz,:jx,:ypgg,:cjmc,:pym,:ph,:yxq,:jj,:lsj,:sl,:jjje,:lsjje,:zfbz)");
            
            OracleParameter pId = new OracleParameter(":id", OracleDbType.Varchar2);
            pId.Direction = ParameterDirection.Input;
            pId.Value = ypkc_djmxParam.Id;
            sqlparams.Add(pId);
            OracleParameter pDjh = new OracleParameter(":djh", OracleDbType.Decimal);
            pDjh.Direction = ParameterDirection.Input;
            pDjh.Value = ypkc_djmxParam.Djh;
            sqlparams.Add(pDjh);
            OracleParameter pFk_dj_id = new OracleParameter(":fk_dj_id", OracleDbType.Varchar2);
            pFk_dj_id.Direction = ParameterDirection.Input;
            pFk_dj_id.Value = ypkc_djmxParam.Fk_dj_id;
            sqlparams.Add(pFk_dj_id);
            OracleParameter pFk_yp = new OracleParameter(":fk_yp", OracleDbType.Varchar2);
            pFk_yp.Direction = ParameterDirection.Input;
            pFk_yp.Value = ypkc_djmxParam.Fk_yp;
            sqlparams.Add(pFk_yp);
            OracleParameter pYpbh = new OracleParameter(":ypbh", OracleDbType.Varchar2);
            pYpbh.Direction = ParameterDirection.Input;
            pYpbh.Value = ypkc_djmxParam.Ypbh;
            sqlparams.Add(pYpbh);
            OracleParameter pYpmc = new OracleParameter(":ypmc", OracleDbType.Varchar2);
            pYpmc.Direction = ParameterDirection.Input;
            pYpmc.Value = ypkc_djmxParam.Ypmc;
            sqlparams.Add(pYpmc);
            OracleParameter pYptymc = new OracleParameter(":yptymc", OracleDbType.NVarchar2);
            pYptymc.Direction = ParameterDirection.Input;
            pYptymc.Value = ypkc_djmxParam.Yptymc;
            sqlparams.Add(pYptymc);
            OracleParameter pDdw = new OracleParameter(":ddw", OracleDbType.Varchar2);
            pDdw.Direction = ParameterDirection.Input;
            pDdw.Value = ypkc_djmxParam.Ddw;
            sqlparams.Add(pDdw);
            OracleParameter pXdw = new OracleParameter(":xdw", OracleDbType.Varchar2);
            pXdw.Direction = ParameterDirection.Input;
            pXdw.Value = ypkc_djmxParam.Xdw;
            sqlparams.Add(pXdw);
            OracleParameter pHsbl = new OracleParameter(":hsbl", OracleDbType.Decimal);
            pHsbl.Direction = ParameterDirection.Input;
            pHsbl.Value = ypkc_djmxParam.Hsbl;
            sqlparams.Add(pHsbl);
            OracleParameter pPzwh = new OracleParameter(":pzwh", OracleDbType.Varchar2);
            pPzwh.Direction = ParameterDirection.Input;
            pPzwh.Value = ypkc_djmxParam.Pzwh;
            sqlparams.Add(pPzwh);
            OracleParameter pGyzz = new OracleParameter(":gyzz", OracleDbType.Varchar2);
            pGyzz.Direction = ParameterDirection.Input;
            pGyzz.Value = ypkc_djmxParam.Gyzz;
            sqlparams.Add(pGyzz);
            OracleParameter pJx = new OracleParameter(":jx", OracleDbType.NVarchar2);
            pJx.Direction = ParameterDirection.Input;
            pJx.Value = ypkc_djmxParam.Jx;
            sqlparams.Add(pJx);
            OracleParameter pYpgg = new OracleParameter(":ypgg", OracleDbType.NVarchar2);
            pYpgg.Direction = ParameterDirection.Input;
            pYpgg.Value = ypkc_djmxParam.Ypgg;
            sqlparams.Add(pYpgg);
            OracleParameter pCjmc = new OracleParameter(":cjmc", OracleDbType.NVarchar2);
            pCjmc.Direction = ParameterDirection.Input;
            pCjmc.Value = ypkc_djmxParam.Cjmc;
            sqlparams.Add(pCjmc);
            OracleParameter pPym = new OracleParameter(":pym", OracleDbType.NVarchar2);
            pPym.Direction = ParameterDirection.Input;
            pPym.Value = ypkc_djmxParam.Pym;
            sqlparams.Add(pPym);
            OracleParameter pPh = new OracleParameter(":ph", OracleDbType.Varchar2);
            pPh.Direction = ParameterDirection.Input;
            pPh.Value = ypkc_djmxParam.Ph;
            sqlparams.Add(pPh);
            OracleParameter pYxq = new OracleParameter(":yxq", OracleDbType.Date);
            pYxq.Direction = ParameterDirection.Input;
            pYxq.Value = ypkc_djmxParam.Yxq;
            sqlparams.Add(pYxq);
            OracleParameter pJj = new OracleParameter(":jj", OracleDbType.Decimal);
            pJj.Direction = ParameterDirection.Input;
            pJj.Value = ypkc_djmxParam.Jj;
            sqlparams.Add(pJj);
            OracleParameter pLsj = new OracleParameter(":lsj", OracleDbType.Decimal);
            pLsj.Direction = ParameterDirection.Input;
            pLsj.Value = ypkc_djmxParam.Lsj;
            sqlparams.Add(pLsj);
            OracleParameter pSl = new OracleParameter(":sl", OracleDbType.Decimal);
            pSl.Direction = ParameterDirection.Input;
            pSl.Value = ypkc_djmxParam.Sl;
            sqlparams.Add(pSl);
            OracleParameter pJjje = new OracleParameter(":jjje", OracleDbType.Decimal);
            pJjje.Direction = ParameterDirection.Input;
            pJjje.Value = ypkc_djmxParam.Jjje;
            sqlparams.Add(pJjje);
            OracleParameter pLsjje = new OracleParameter(":lsjje", OracleDbType.Decimal);
            pLsjje.Direction = ParameterDirection.Input;
            pLsjje.Value = ypkc_djmxParam.Lsjje;
            sqlparams.Add(pLsjje);
            OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
            pZfbz.Direction = ParameterDirection.Input;
            pZfbz.Value = ypkc_djmxParam.Zfbz;
            sqlparams.Add(pZfbz);
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
        /// <param name="ypkc_djmxParamList">要插入的ypkc_djmxParam对象的集合</param>
        /// <param name="con">Oracle连接对象（为null时自动生成）</param>
        /// <returns>是否添加成功（影响的行数等于保存的对象的数量时成功）</returns>
        public bool inertBatch(List<Ypkc_djmx> ypkc_djmxParamList, OracleConnection con)
        {
            if (ypkc_djmxParamList.Count == 0)
            {
                return true;
            }
            List<string> idList = new List<string>();

            List<decimal?> djhList = new List<decimal?>();

            List<string> fk_dj_idList = new List<string>();

            List<string> fk_ypList = new List<string>();

            List<string> ypbhList = new List<string>();

            List<string> ypmcList = new List<string>();

            List<string> yptymcList = new List<string>();

            List<string> ddwList = new List<string>();

            List<string> xdwList = new List<string>();

            List<decimal?> hsblList = new List<decimal?>();

            List<string> pzwhList = new List<string>();

            List<string> gyzzList = new List<string>();

            List<string> jxList = new List<string>();

            List<string> ypggList = new List<string>();

            List<string> cjmcList = new List<string>();

            List<string> pymList = new List<string>();

            List<string> phList = new List<string>();

            List<DateTime?> yxqList = new List<DateTime?>();

            List<decimal?> jjList = new List<decimal?>();

            List<decimal?> lsjList = new List<decimal?>();

            List<decimal?> slList = new List<decimal?>();

            List<decimal?> jjjeList = new List<decimal?>();

            List<decimal?> lsjjeList = new List<decimal?>();

            List<string> zfbzList = new List<string>();

            for (int i = 0; i < ypkc_djmxParamList.Count; i++)
            {
                Ypkc_djmx ypkc_djmxParam = ypkc_djmxParamList[i];
                if ("" == ypkc_djmxParam.Id || null == ypkc_djmxParam.Id)
                {
                    ypkc_djmxParam.Id = Model.Common.GUIDHelper.getGuid();
                }

            idList.Add(ypkc_djmxParam.Id);

            djhList.Add(ypkc_djmxParam.Djh);

            fk_dj_idList.Add(ypkc_djmxParam.Fk_dj_id);

            fk_ypList.Add(ypkc_djmxParam.Fk_yp);

            ypbhList.Add(ypkc_djmxParam.Ypbh);

            ypmcList.Add(ypkc_djmxParam.Ypmc);

            yptymcList.Add(ypkc_djmxParam.Yptymc);

            ddwList.Add(ypkc_djmxParam.Ddw);

            xdwList.Add(ypkc_djmxParam.Xdw);

            hsblList.Add(ypkc_djmxParam.Hsbl);

            pzwhList.Add(ypkc_djmxParam.Pzwh);

            gyzzList.Add(ypkc_djmxParam.Gyzz);

            jxList.Add(ypkc_djmxParam.Jx);

            ypggList.Add(ypkc_djmxParam.Ypgg);

            cjmcList.Add(ypkc_djmxParam.Cjmc);

            pymList.Add(ypkc_djmxParam.Pym);

            phList.Add(ypkc_djmxParam.Ph);

            yxqList.Add(ypkc_djmxParam.Yxq);

            jjList.Add(ypkc_djmxParam.Jj);

            lsjList.Add(ypkc_djmxParam.Lsj);

            slList.Add(ypkc_djmxParam.Sl);

            jjjeList.Add(ypkc_djmxParam.Jjje);

            lsjjeList.Add(ypkc_djmxParam.Lsjje);

            zfbzList.Add(ypkc_djmxParam.Zfbz);

            }

            List<OracleParameter> sqlparams = new List<OracleParameter>();

            StringBuilder sql = new StringBuilder("INSERT INTO YPKC_DJMX(id,djh,fk_dj_id,fk_yp,ypbh,ypmc,yptymc,ddw,xdw,hsbl,pzwh,gyzz,jx,ypgg,cjmc,pym,ph,yxq,jj,lsj,sl,jjje,lsjje,zfbz) VALUES(:id,:djh,:fk_dj_id,:fk_yp,:ypbh,:ypmc,:yptymc,:ddw,:xdw,:hsbl,:pzwh,:gyzz,:jx,:ypgg,:cjmc,:pym,:ph,:yxq,:jj,:lsj,:sl,:jjje,:lsjje,:zfbz)");
            
            OracleParameter pId = new OracleParameter(":id", OracleDbType.Varchar2);
            pId.Direction = ParameterDirection.Input;
            pId.Value = idList.ToArray();
            sqlparams.Add(pId);
            OracleParameter pDjh = new OracleParameter(":djh", OracleDbType.Decimal);
            pDjh.Direction = ParameterDirection.Input;
            pDjh.Value = djhList.ToArray();
            sqlparams.Add(pDjh);
            OracleParameter pFk_dj_id = new OracleParameter(":fk_dj_id", OracleDbType.Varchar2);
            pFk_dj_id.Direction = ParameterDirection.Input;
            pFk_dj_id.Value = fk_dj_idList.ToArray();
            sqlparams.Add(pFk_dj_id);
            OracleParameter pFk_yp = new OracleParameter(":fk_yp", OracleDbType.Varchar2);
            pFk_yp.Direction = ParameterDirection.Input;
            pFk_yp.Value = fk_ypList.ToArray();
            sqlparams.Add(pFk_yp);
            OracleParameter pYpbh = new OracleParameter(":ypbh", OracleDbType.Varchar2);
            pYpbh.Direction = ParameterDirection.Input;
            pYpbh.Value = ypbhList.ToArray();
            sqlparams.Add(pYpbh);
            OracleParameter pYpmc = new OracleParameter(":ypmc", OracleDbType.Varchar2);
            pYpmc.Direction = ParameterDirection.Input;
            pYpmc.Value = ypmcList.ToArray();
            sqlparams.Add(pYpmc);
            OracleParameter pYptymc = new OracleParameter(":yptymc", OracleDbType.NVarchar2);
            pYptymc.Direction = ParameterDirection.Input;
            pYptymc.Value = yptymcList.ToArray();
            sqlparams.Add(pYptymc);
            OracleParameter pDdw = new OracleParameter(":ddw", OracleDbType.Varchar2);
            pDdw.Direction = ParameterDirection.Input;
            pDdw.Value = ddwList.ToArray();
            sqlparams.Add(pDdw);
            OracleParameter pXdw = new OracleParameter(":xdw", OracleDbType.Varchar2);
            pXdw.Direction = ParameterDirection.Input;
            pXdw.Value = xdwList.ToArray();
            sqlparams.Add(pXdw);
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
            OracleParameter pJx = new OracleParameter(":jx", OracleDbType.NVarchar2);
            pJx.Direction = ParameterDirection.Input;
            pJx.Value = jxList.ToArray();
            sqlparams.Add(pJx);
            OracleParameter pYpgg = new OracleParameter(":ypgg", OracleDbType.NVarchar2);
            pYpgg.Direction = ParameterDirection.Input;
            pYpgg.Value = ypggList.ToArray();
            sqlparams.Add(pYpgg);
            OracleParameter pCjmc = new OracleParameter(":cjmc", OracleDbType.NVarchar2);
            pCjmc.Direction = ParameterDirection.Input;
            pCjmc.Value = cjmcList.ToArray();
            sqlparams.Add(pCjmc);
            OracleParameter pPym = new OracleParameter(":pym", OracleDbType.NVarchar2);
            pPym.Direction = ParameterDirection.Input;
            pPym.Value = pymList.ToArray();
            sqlparams.Add(pPym);
            OracleParameter pPh = new OracleParameter(":ph", OracleDbType.Varchar2);
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
            OracleParameter pJjje = new OracleParameter(":jjje", OracleDbType.Decimal);
            pJjje.Direction = ParameterDirection.Input;
            pJjje.Value = jjjeList.ToArray();
            sqlparams.Add(pJjje);
            OracleParameter pLsjje = new OracleParameter(":lsjje", OracleDbType.Decimal);
            pLsjje.Direction = ParameterDirection.Input;
            pLsjje.Value = lsjjeList.ToArray();
            sqlparams.Add(pLsjje);
            OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
            pZfbz.Direction = ParameterDirection.Input;
            pZfbz.Value = zfbzList.ToArray();
            sqlparams.Add(pZfbz);
            bool result = false;
            int flag = -1;
            flag = OracleHelper.ExecuteBatch(sql.ToString(), con, ypkc_djmxParamList.Count, sqlparams.ToArray());
            if (ypkc_djmxParamList.Count == flag)
            {
                result  = true;
            }
            return result;
        }

        /// <summary>
        /// 插入多条数据，流水号使用当前sequences号ypkc_djh.currval（如果需要供事务使用就传入OracleConnection对象，如果不供就传入null，方法自动生成OracleConnection对象,并且自动使用事务）
        /// 主键为null时，自动生成主键guid
        /// </summary>
        /// <param name="ypkc_djmxParamList">要插入的ypkc_djmxParam对象的集合</param>
        /// <param name="con">Oracle连接对象（为null时自动生成）</param>
        /// <returns>是否添加成功（影响的行数等于保存的对象的数量时成功）</returns>
        public bool inertBatchForLshSequences(List<Ypkc_djmx> ypkc_djmxParamList, OracleConnection con)
        {
            if (ypkc_djmxParamList.Count == 0)
            {
                return true;
            }
            List<string> idList = new List<string>();

            List<decimal?> djhList = new List<decimal?>();

            List<string> fk_dj_idList = new List<string>();

            List<string> fk_ypList = new List<string>();

            List<string> ypbhList = new List<string>();

            List<string> ypmcList = new List<string>();

            List<string> yptymcList = new List<string>();

            List<string> ddwList = new List<string>();

            List<string> xdwList = new List<string>();

            List<decimal?> hsblList = new List<decimal?>();

            List<string> pzwhList = new List<string>();

            List<string> gyzzList = new List<string>();

            List<string> jxList = new List<string>();

            List<string> ypggList = new List<string>();

            List<string> cjmcList = new List<string>();

            List<string> pymList = new List<string>();

            List<string> phList = new List<string>();

            List<DateTime?> yxqList = new List<DateTime?>();

            List<decimal?> jjList = new List<decimal?>();

            List<decimal?> lsjList = new List<decimal?>();

            List<decimal?> slList = new List<decimal?>();

            List<decimal?> jjjeList = new List<decimal?>();

            List<decimal?> lsjjeList = new List<decimal?>();

            List<string> zfbzList = new List<string>();

            for (int i = 0; i < ypkc_djmxParamList.Count; i++)
            {
                Ypkc_djmx ypkc_djmxParam = ypkc_djmxParamList[i];
                if ("" == ypkc_djmxParam.Id || null == ypkc_djmxParam.Id)
                {
                    ypkc_djmxParam.Id = Model.Common.GUIDHelper.getGuid();
                }

                idList.Add(ypkc_djmxParam.Id);

                djhList.Add(ypkc_djmxParam.Djh);

                fk_dj_idList.Add(ypkc_djmxParam.Fk_dj_id);

                fk_ypList.Add(ypkc_djmxParam.Fk_yp);

                ypbhList.Add(ypkc_djmxParam.Ypbh);

                ypmcList.Add(ypkc_djmxParam.Ypmc);

                yptymcList.Add(ypkc_djmxParam.Yptymc);

                ddwList.Add(ypkc_djmxParam.Ddw);

                xdwList.Add(ypkc_djmxParam.Xdw);

                hsblList.Add(ypkc_djmxParam.Hsbl);

                pzwhList.Add(ypkc_djmxParam.Pzwh);

                gyzzList.Add(ypkc_djmxParam.Gyzz);

                jxList.Add(ypkc_djmxParam.Jx);

                ypggList.Add(ypkc_djmxParam.Ypgg);

                cjmcList.Add(ypkc_djmxParam.Cjmc);

                pymList.Add(ypkc_djmxParam.Pym);

                phList.Add(ypkc_djmxParam.Ph);

                yxqList.Add(ypkc_djmxParam.Yxq);

                jjList.Add(ypkc_djmxParam.Jj);

                lsjList.Add(ypkc_djmxParam.Lsj);

                slList.Add(ypkc_djmxParam.Sl);

                jjjeList.Add(ypkc_djmxParam.Jjje);

                lsjjeList.Add(ypkc_djmxParam.Lsjje);

                zfbzList.Add(ypkc_djmxParam.Zfbz);

            }

            List<OracleParameter> sqlparams = new List<OracleParameter>();

            StringBuilder sql = new StringBuilder("INSERT INTO YPKC_DJMX(id,djh,fk_dj_id,fk_yp,ypbh,ypmc,yptymc,ddw,xdw,hsbl,pzwh,gyzz,jx,ypgg,cjmc,pym,ph,yxq,jj,lsj,sl,jjje,lsjje,zfbz) VALUES(:id,ypkc_djh.currval,:fk_dj_id,:fk_yp,:ypbh,:ypmc,:yptymc,:ddw,:xdw,:hsbl,:pzwh,:gyzz,:jx,:ypgg,:cjmc,:pym,:ph,:yxq,:jj,:lsj,:sl,:jjje,:lsjje,:zfbz)");

            OracleParameter pId = new OracleParameter(":id", OracleDbType.Varchar2);
            pId.Direction = ParameterDirection.Input;
            pId.Value = idList.ToArray();
            sqlparams.Add(pId);
            //OracleParameter pDjh = new OracleParameter(":djh", OracleDbType.Decimal);
            //pDjh.Direction = ParameterDirection.Input;
            //pDjh.Value = djhList.ToArray();
            //sqlparams.Add(pDjh);
            OracleParameter pFk_dj_id = new OracleParameter(":fk_dj_id", OracleDbType.Varchar2);
            pFk_dj_id.Direction = ParameterDirection.Input;
            pFk_dj_id.Value = fk_dj_idList.ToArray();
            sqlparams.Add(pFk_dj_id);
            OracleParameter pFk_yp = new OracleParameter(":fk_yp", OracleDbType.Varchar2);
            pFk_yp.Direction = ParameterDirection.Input;
            pFk_yp.Value = fk_ypList.ToArray();
            sqlparams.Add(pFk_yp);
            OracleParameter pYpbh = new OracleParameter(":ypbh", OracleDbType.Varchar2);
            pYpbh.Direction = ParameterDirection.Input;
            pYpbh.Value = ypbhList.ToArray();
            sqlparams.Add(pYpbh);
            OracleParameter pYpmc = new OracleParameter(":ypmc", OracleDbType.Varchar2);
            pYpmc.Direction = ParameterDirection.Input;
            pYpmc.Value = ypmcList.ToArray();
            sqlparams.Add(pYpmc);
            OracleParameter pYptymc = new OracleParameter(":yptymc", OracleDbType.NVarchar2);
            pYptymc.Direction = ParameterDirection.Input;
            pYptymc.Value = yptymcList.ToArray();
            sqlparams.Add(pYptymc);
            OracleParameter pDdw = new OracleParameter(":ddw", OracleDbType.Varchar2);
            pDdw.Direction = ParameterDirection.Input;
            pDdw.Value = ddwList.ToArray();
            sqlparams.Add(pDdw);
            OracleParameter pXdw = new OracleParameter(":xdw", OracleDbType.Varchar2);
            pXdw.Direction = ParameterDirection.Input;
            pXdw.Value = xdwList.ToArray();
            sqlparams.Add(pXdw);
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
            OracleParameter pJx = new OracleParameter(":jx", OracleDbType.NVarchar2);
            pJx.Direction = ParameterDirection.Input;
            pJx.Value = jxList.ToArray();
            sqlparams.Add(pJx);
            OracleParameter pYpgg = new OracleParameter(":ypgg", OracleDbType.NVarchar2);
            pYpgg.Direction = ParameterDirection.Input;
            pYpgg.Value = ypggList.ToArray();
            sqlparams.Add(pYpgg);
            OracleParameter pCjmc = new OracleParameter(":cjmc", OracleDbType.NVarchar2);
            pCjmc.Direction = ParameterDirection.Input;
            pCjmc.Value = cjmcList.ToArray();
            sqlparams.Add(pCjmc);
            OracleParameter pPym = new OracleParameter(":pym", OracleDbType.NVarchar2);
            pPym.Direction = ParameterDirection.Input;
            pPym.Value = pymList.ToArray();
            sqlparams.Add(pPym);
            OracleParameter pPh = new OracleParameter(":ph", OracleDbType.Varchar2);
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
            OracleParameter pJjje = new OracleParameter(":jjje", OracleDbType.Decimal);
            pJjje.Direction = ParameterDirection.Input;
            pJjje.Value = jjjeList.ToArray();
            sqlparams.Add(pJjje);
            OracleParameter pLsjje = new OracleParameter(":lsjje", OracleDbType.Decimal);
            pLsjje.Direction = ParameterDirection.Input;
            pLsjje.Value = lsjjeList.ToArray();
            sqlparams.Add(pLsjje);
            OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
            pZfbz.Direction = ParameterDirection.Input;
            pZfbz.Value = zfbzList.ToArray();
            sqlparams.Add(pZfbz);
            bool result = false;
            int flag = -1;
            flag = OracleHelper.ExecuteBatch(sql.ToString(), con, ypkc_djmxParamList.Count, sqlparams.ToArray());
            if (ypkc_djmxParamList.Count == flag)
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
        public bool deleteById(string id,OracleConnection con)
        {
            if ("" == id || null == id)
            {
                throw new Exception("ID不允许为空，请赋值后调用；错误出自：deleteById");
            }
            StringBuilder sql = new StringBuilder("DELETE YPKC_DJMX WHERE ID=:id");
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
            StringBuilder sql = new StringBuilder("DELETE YPKC_DJMX WHERE ID=:id");
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
        /// <param name="ypkc_djmxParamCondition">删除的条件</param>
        /// <param name="con">Oracle连接对象（为null时自动生成）</param>
        /// <returns>无法确定删除的行数（影响行数大于等于0就算成功）</returns>
        public bool deleteByOtherCondition(Ypkc_djmx ypkc_djmxParamCondition, OracleConnection con)
        {
            if (null!=ypkc_djmxParamCondition.Id&&""!=ypkc_djmxParamCondition.Id)
            {
                throw new Exception("不允许指定参数的ID，如果要根据ID删除数据请调用deleteById或者deleteByIdBatch方法；错误出自：deleteByOtherCondition");
            }
            List<OracleParameter> sqlparams = new List<OracleParameter>();
            StringBuilder sql = new StringBuilder("DELETE YPKC_DJMX ");

            if (null != ypkc_djmxParamCondition.Djh)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" DJH=:djh ");
                OracleParameter pDjh = new OracleParameter(":djh", OracleDbType.Decimal);
                pDjh.Direction = ParameterDirection.Input;
                pDjh.Value = ypkc_djmxParamCondition.Djh;
                sqlparams.Add(pDjh);

            }
                        
            if (null != ypkc_djmxParamCondition.Fk_dj_id &&  ""!= ypkc_djmxParamCondition.Fk_dj_id)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" FK_DJ_ID=:fk_dj_id ");
                OracleParameter pFk_dj_id = new OracleParameter(":fk_dj_id", OracleDbType.Varchar2);
                pFk_dj_id.Direction = ParameterDirection.Input;
                pFk_dj_id.Value = ypkc_djmxParamCondition.Fk_dj_id;
                sqlparams.Add(pFk_dj_id);

            }
                        
            if (null != ypkc_djmxParamCondition.Fk_yp &&  ""!= ypkc_djmxParamCondition.Fk_yp)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" FK_YP=:fk_yp ");
                OracleParameter pFk_yp = new OracleParameter(":fk_yp", OracleDbType.Varchar2);
                pFk_yp.Direction = ParameterDirection.Input;
                pFk_yp.Value = ypkc_djmxParamCondition.Fk_yp;
                sqlparams.Add(pFk_yp);

            }
                        
            if (null != ypkc_djmxParamCondition.Ypbh &&  ""!= ypkc_djmxParamCondition.Ypbh)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" YPBH=:ypbh ");
                OracleParameter pYpbh = new OracleParameter(":ypbh", OracleDbType.Varchar2);
                pYpbh.Direction = ParameterDirection.Input;
                pYpbh.Value = ypkc_djmxParamCondition.Ypbh;
                sqlparams.Add(pYpbh);

            }
                        
            if (null != ypkc_djmxParamCondition.Ypmc &&  ""!= ypkc_djmxParamCondition.Ypmc)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" YPMC=:ypmc ");
                OracleParameter pYpmc = new OracleParameter(":ypmc", OracleDbType.Varchar2);
                pYpmc.Direction = ParameterDirection.Input;
                pYpmc.Value = ypkc_djmxParamCondition.Ypmc;
                sqlparams.Add(pYpmc);

            }
                        
            if (null != ypkc_djmxParamCondition.Yptymc &&  ""!= ypkc_djmxParamCondition.Yptymc)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" YPTYMC=:yptymc ");
                OracleParameter pYptymc = new OracleParameter(":yptymc", OracleDbType.NVarchar2);
                pYptymc.Direction = ParameterDirection.Input;
                pYptymc.Value = ypkc_djmxParamCondition.Yptymc;
                sqlparams.Add(pYptymc);

            }
                        
            if (null != ypkc_djmxParamCondition.Ddw &&  ""!= ypkc_djmxParamCondition.Ddw)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" DDW=:ddw ");
                OracleParameter pDdw = new OracleParameter(":ddw", OracleDbType.Varchar2);
                pDdw.Direction = ParameterDirection.Input;
                pDdw.Value = ypkc_djmxParamCondition.Ddw;
                sqlparams.Add(pDdw);

            }
                        
            if (null != ypkc_djmxParamCondition.Xdw &&  ""!= ypkc_djmxParamCondition.Xdw)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" XDW=:xdw ");
                OracleParameter pXdw = new OracleParameter(":xdw", OracleDbType.Varchar2);
                pXdw.Direction = ParameterDirection.Input;
                pXdw.Value = ypkc_djmxParamCondition.Xdw;
                sqlparams.Add(pXdw);

            }
                        
            if (null != ypkc_djmxParamCondition.Hsbl)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" HSBL=:hsbl ");
                OracleParameter pHsbl = new OracleParameter(":hsbl", OracleDbType.Decimal);
                pHsbl.Direction = ParameterDirection.Input;
                pHsbl.Value = ypkc_djmxParamCondition.Hsbl;
                sqlparams.Add(pHsbl);

            }
                        
            if (null != ypkc_djmxParamCondition.Pzwh &&  ""!= ypkc_djmxParamCondition.Pzwh)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" PZWH=:pzwh ");
                OracleParameter pPzwh = new OracleParameter(":pzwh", OracleDbType.Varchar2);
                pPzwh.Direction = ParameterDirection.Input;
                pPzwh.Value = ypkc_djmxParamCondition.Pzwh;
                sqlparams.Add(pPzwh);

            }
                        
            if (null != ypkc_djmxParamCondition.Gyzz &&  ""!= ypkc_djmxParamCondition.Gyzz)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" GYZZ=:gyzz ");
                OracleParameter pGyzz = new OracleParameter(":gyzz", OracleDbType.Varchar2);
                pGyzz.Direction = ParameterDirection.Input;
                pGyzz.Value = ypkc_djmxParamCondition.Gyzz;
                sqlparams.Add(pGyzz);

            }
                        
            if (null != ypkc_djmxParamCondition.Jx &&  ""!= ypkc_djmxParamCondition.Jx)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" JX=:jx ");
                OracleParameter pJx = new OracleParameter(":jx", OracleDbType.NVarchar2);
                pJx.Direction = ParameterDirection.Input;
                pJx.Value = ypkc_djmxParamCondition.Jx;
                sqlparams.Add(pJx);

            }
                        
            if (null != ypkc_djmxParamCondition.Ypgg &&  ""!= ypkc_djmxParamCondition.Ypgg)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" YPGG=:ypgg ");
                OracleParameter pYpgg = new OracleParameter(":ypgg", OracleDbType.NVarchar2);
                pYpgg.Direction = ParameterDirection.Input;
                pYpgg.Value = ypkc_djmxParamCondition.Ypgg;
                sqlparams.Add(pYpgg);

            }
                        
            if (null != ypkc_djmxParamCondition.Cjmc &&  ""!= ypkc_djmxParamCondition.Cjmc)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" CJMC=:cjmc ");
                OracleParameter pCjmc = new OracleParameter(":cjmc", OracleDbType.NVarchar2);
                pCjmc.Direction = ParameterDirection.Input;
                pCjmc.Value = ypkc_djmxParamCondition.Cjmc;
                sqlparams.Add(pCjmc);

            }
                        
            if (null != ypkc_djmxParamCondition.Pym &&  ""!= ypkc_djmxParamCondition.Pym)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" PYM=:pym ");
                OracleParameter pPym = new OracleParameter(":pym", OracleDbType.NVarchar2);
                pPym.Direction = ParameterDirection.Input;
                pPym.Value = ypkc_djmxParamCondition.Pym;
                sqlparams.Add(pPym);

            }
                        
            if (null != ypkc_djmxParamCondition.Ph &&  ""!= ypkc_djmxParamCondition.Ph)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" PH=:ph ");
                OracleParameter pPh = new OracleParameter(":ph", OracleDbType.Varchar2);
                pPh.Direction = ParameterDirection.Input;
                pPh.Value = ypkc_djmxParamCondition.Ph;
                sqlparams.Add(pPh);

            }
                        
            if (DateTime.MinValue != ypkc_djmxParamCondition.Yxq &&null != ypkc_djmxParamCondition.Yxq)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" YXQ=:yxq ");
                OracleParameter pYxq = new OracleParameter(":yxq", OracleDbType.Date);
                pYxq.Direction = ParameterDirection.Input;
                pYxq.Value = ypkc_djmxParamCondition.Yxq;
                sqlparams.Add(pYxq);

            }
                        
            if (null != ypkc_djmxParamCondition.Jj)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" JJ=:jj ");
                OracleParameter pJj = new OracleParameter(":jj", OracleDbType.Decimal);
                pJj.Direction = ParameterDirection.Input;
                pJj.Value = ypkc_djmxParamCondition.Jj;
                sqlparams.Add(pJj);

            }
                        
            if (null != ypkc_djmxParamCondition.Lsj)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" LSJ=:lsj ");
                OracleParameter pLsj = new OracleParameter(":lsj", OracleDbType.Decimal);
                pLsj.Direction = ParameterDirection.Input;
                pLsj.Value = ypkc_djmxParamCondition.Lsj;
                sqlparams.Add(pLsj);

            }
                        
            if (null != ypkc_djmxParamCondition.Sl)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" SL=:sl ");
                OracleParameter pSl = new OracleParameter(":sl", OracleDbType.Decimal);
                pSl.Direction = ParameterDirection.Input;
                pSl.Value = ypkc_djmxParamCondition.Sl;
                sqlparams.Add(pSl);

            }
                        
            if (null != ypkc_djmxParamCondition.Jjje)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" JJJE=:jjje ");
                OracleParameter pJjje = new OracleParameter(":jjje", OracleDbType.Decimal);
                pJjje.Direction = ParameterDirection.Input;
                pJjje.Value = ypkc_djmxParamCondition.Jjje;
                sqlparams.Add(pJjje);

            }
                        
            if (null != ypkc_djmxParamCondition.Lsjje)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" LSJJE=:lsjje ");
                OracleParameter pLsjje = new OracleParameter(":lsjje", OracleDbType.Decimal);
                pLsjje.Direction = ParameterDirection.Input;
                pLsjje.Value = ypkc_djmxParamCondition.Lsjje;
                sqlparams.Add(pLsjje);

            }
                        
            if (null != ypkc_djmxParamCondition.Zfbz &&  ""!= ypkc_djmxParamCondition.Zfbz)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" ZFBZ=:zfbz ");
                OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                pZfbz.Direction = ParameterDirection.Input;
                pZfbz.Value = ypkc_djmxParamCondition.Zfbz;
                sqlparams.Add(pZfbz);

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
        /// <param name="ypkc_djmxParam"></param>
        /// <returns>影响的行数</returns>
        public bool updateById(Ypkc_djmx ypkc_djmxParam,OracleConnection con)
        {
            if ("" == ypkc_djmxParam.Id || null == ypkc_djmxParam.Id)
            {
                throw new Exception("ID不允许为空，请赋值后调用；错误出自：updateById");
            }
            List<OracleParameter> sqlparams = new List<OracleParameter>();

            StringBuilder sql = new StringBuilder("UPDATE YPKC_DJMX SET ");
            if (null != ypkc_djmxParam.Djh)
            {
                this.isComma(sql);
                sql.Append(" DJH=:djh ");
                OracleParameter pDjh = new OracleParameter(":djh", OracleDbType.Decimal);
                pDjh.Direction = ParameterDirection.Input;
                pDjh.Value = ypkc_djmxParam.Djh;
                sqlparams.Add(pDjh);

            }
                        
            if (null != ypkc_djmxParam.Fk_dj_id &&  ""!= ypkc_djmxParam.Fk_dj_id)
            {
                this.isComma(sql);
                sql.Append(" FK_DJ_ID=:fk_dj_id ");
                OracleParameter pFk_dj_id = new OracleParameter(":fk_dj_id", OracleDbType.Varchar2);
                pFk_dj_id.Direction = ParameterDirection.Input;
                pFk_dj_id.Value = ypkc_djmxParam.Fk_dj_id;
                sqlparams.Add(pFk_dj_id);

            }
                        
            if (null != ypkc_djmxParam.Fk_yp &&  ""!= ypkc_djmxParam.Fk_yp)
            {
                this.isComma(sql);
                sql.Append(" FK_YP=:fk_yp ");
                OracleParameter pFk_yp = new OracleParameter(":fk_yp", OracleDbType.Varchar2);
                pFk_yp.Direction = ParameterDirection.Input;
                pFk_yp.Value = ypkc_djmxParam.Fk_yp;
                sqlparams.Add(pFk_yp);

            }
                        
            if (null != ypkc_djmxParam.Ypbh &&  ""!= ypkc_djmxParam.Ypbh)
            {
                this.isComma(sql);
                sql.Append(" YPBH=:ypbh ");
                OracleParameter pYpbh = new OracleParameter(":ypbh", OracleDbType.Varchar2);
                pYpbh.Direction = ParameterDirection.Input;
                pYpbh.Value = ypkc_djmxParam.Ypbh;
                sqlparams.Add(pYpbh);

            }
                        
            if (null != ypkc_djmxParam.Ypmc &&  ""!= ypkc_djmxParam.Ypmc)
            {
                this.isComma(sql);
                sql.Append(" YPMC=:ypmc ");
                OracleParameter pYpmc = new OracleParameter(":ypmc", OracleDbType.Varchar2);
                pYpmc.Direction = ParameterDirection.Input;
                pYpmc.Value = ypkc_djmxParam.Ypmc;
                sqlparams.Add(pYpmc);

            }
                        
            if (null != ypkc_djmxParam.Yptymc &&  ""!= ypkc_djmxParam.Yptymc)
            {
                this.isComma(sql);
                sql.Append(" YPTYMC=:yptymc ");
                OracleParameter pYptymc = new OracleParameter(":yptymc", OracleDbType.NVarchar2);
                pYptymc.Direction = ParameterDirection.Input;
                pYptymc.Value = ypkc_djmxParam.Yptymc;
                sqlparams.Add(pYptymc);

            }
                        
            if (null != ypkc_djmxParam.Ddw &&  ""!= ypkc_djmxParam.Ddw)
            {
                this.isComma(sql);
                sql.Append(" DDW=:ddw ");
                OracleParameter pDdw = new OracleParameter(":ddw", OracleDbType.Varchar2);
                pDdw.Direction = ParameterDirection.Input;
                pDdw.Value = ypkc_djmxParam.Ddw;
                sqlparams.Add(pDdw);

            }
                        
            if (null != ypkc_djmxParam.Xdw &&  ""!= ypkc_djmxParam.Xdw)
            {
                this.isComma(sql);
                sql.Append(" XDW=:xdw ");
                OracleParameter pXdw = new OracleParameter(":xdw", OracleDbType.Varchar2);
                pXdw.Direction = ParameterDirection.Input;
                pXdw.Value = ypkc_djmxParam.Xdw;
                sqlparams.Add(pXdw);

            }
                        
            if (null != ypkc_djmxParam.Hsbl)
            {
                this.isComma(sql);
                sql.Append(" HSBL=:hsbl ");
                OracleParameter pHsbl = new OracleParameter(":hsbl", OracleDbType.Decimal);
                pHsbl.Direction = ParameterDirection.Input;
                pHsbl.Value = ypkc_djmxParam.Hsbl;
                sqlparams.Add(pHsbl);

            }
                        
            if (null != ypkc_djmxParam.Pzwh &&  ""!= ypkc_djmxParam.Pzwh)
            {
                this.isComma(sql);
                sql.Append(" PZWH=:pzwh ");
                OracleParameter pPzwh = new OracleParameter(":pzwh", OracleDbType.Varchar2);
                pPzwh.Direction = ParameterDirection.Input;
                pPzwh.Value = ypkc_djmxParam.Pzwh;
                sqlparams.Add(pPzwh);

            }
                        
            if (null != ypkc_djmxParam.Gyzz &&  ""!= ypkc_djmxParam.Gyzz)
            {
                this.isComma(sql);
                sql.Append(" GYZZ=:gyzz ");
                OracleParameter pGyzz = new OracleParameter(":gyzz", OracleDbType.Varchar2);
                pGyzz.Direction = ParameterDirection.Input;
                pGyzz.Value = ypkc_djmxParam.Gyzz;
                sqlparams.Add(pGyzz);

            }
                        
            if (null != ypkc_djmxParam.Jx &&  ""!= ypkc_djmxParam.Jx)
            {
                this.isComma(sql);
                sql.Append(" JX=:jx ");
                OracleParameter pJx = new OracleParameter(":jx", OracleDbType.NVarchar2);
                pJx.Direction = ParameterDirection.Input;
                pJx.Value = ypkc_djmxParam.Jx;
                sqlparams.Add(pJx);

            }
                        
            if (null != ypkc_djmxParam.Ypgg &&  ""!= ypkc_djmxParam.Ypgg)
            {
                this.isComma(sql);
                sql.Append(" YPGG=:ypgg ");
                OracleParameter pYpgg = new OracleParameter(":ypgg", OracleDbType.NVarchar2);
                pYpgg.Direction = ParameterDirection.Input;
                pYpgg.Value = ypkc_djmxParam.Ypgg;
                sqlparams.Add(pYpgg);

            }
                        
            if (null != ypkc_djmxParam.Cjmc &&  ""!= ypkc_djmxParam.Cjmc)
            {
                this.isComma(sql);
                sql.Append(" CJMC=:cjmc ");
                OracleParameter pCjmc = new OracleParameter(":cjmc", OracleDbType.NVarchar2);
                pCjmc.Direction = ParameterDirection.Input;
                pCjmc.Value = ypkc_djmxParam.Cjmc;
                sqlparams.Add(pCjmc);

            }
                        
            if (null != ypkc_djmxParam.Pym &&  ""!= ypkc_djmxParam.Pym)
            {
                this.isComma(sql);
                sql.Append(" PYM=:pym ");
                OracleParameter pPym = new OracleParameter(":pym", OracleDbType.NVarchar2);
                pPym.Direction = ParameterDirection.Input;
                pPym.Value = ypkc_djmxParam.Pym;
                sqlparams.Add(pPym);

            }
                        
            if (null != ypkc_djmxParam.Ph &&  ""!= ypkc_djmxParam.Ph)
            {
                this.isComma(sql);
                sql.Append(" PH=:ph ");
                OracleParameter pPh = new OracleParameter(":ph", OracleDbType.Varchar2);
                pPh.Direction = ParameterDirection.Input;
                pPh.Value = ypkc_djmxParam.Ph;
                sqlparams.Add(pPh);

            }
                        
            if (DateTime.MinValue != ypkc_djmxParam.Yxq &&null != ypkc_djmxParam.Yxq)
            {
                this.isComma(sql);
                sql.Append(" YXQ=:yxq ");
                OracleParameter pYxq = new OracleParameter(":yxq", OracleDbType.Date);
                pYxq.Direction = ParameterDirection.Input;
                pYxq.Value = ypkc_djmxParam.Yxq;
                sqlparams.Add(pYxq);

            }
                        
            if (null != ypkc_djmxParam.Jj)
            {
                this.isComma(sql);
                sql.Append(" JJ=:jj ");
                OracleParameter pJj = new OracleParameter(":jj", OracleDbType.Decimal);
                pJj.Direction = ParameterDirection.Input;
                pJj.Value = ypkc_djmxParam.Jj;
                sqlparams.Add(pJj);

            }
                        
            if (null != ypkc_djmxParam.Lsj)
            {
                this.isComma(sql);
                sql.Append(" LSJ=:lsj ");
                OracleParameter pLsj = new OracleParameter(":lsj", OracleDbType.Decimal);
                pLsj.Direction = ParameterDirection.Input;
                pLsj.Value = ypkc_djmxParam.Lsj;
                sqlparams.Add(pLsj);

            }
                        
            if (null != ypkc_djmxParam.Sl)
            {
                this.isComma(sql);
                sql.Append(" SL=:sl ");
                OracleParameter pSl = new OracleParameter(":sl", OracleDbType.Decimal);
                pSl.Direction = ParameterDirection.Input;
                pSl.Value = ypkc_djmxParam.Sl;
                sqlparams.Add(pSl);

            }
                        
            if (null != ypkc_djmxParam.Jjje)
            {
                this.isComma(sql);
                sql.Append(" JJJE=:jjje ");
                OracleParameter pJjje = new OracleParameter(":jjje", OracleDbType.Decimal);
                pJjje.Direction = ParameterDirection.Input;
                pJjje.Value = ypkc_djmxParam.Jjje;
                sqlparams.Add(pJjje);

            }
                        
            if (null != ypkc_djmxParam.Lsjje)
            {
                this.isComma(sql);
                sql.Append(" LSJJE=:lsjje ");
                OracleParameter pLsjje = new OracleParameter(":lsjje", OracleDbType.Decimal);
                pLsjje.Direction = ParameterDirection.Input;
                pLsjje.Value = ypkc_djmxParam.Lsjje;
                sqlparams.Add(pLsjje);

            }
                        
            if (null != ypkc_djmxParam.Zfbz &&  ""!= ypkc_djmxParam.Zfbz)
            {
                this.isComma(sql);
                sql.Append(" ZFBZ=:zfbz ");
                OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                pZfbz.Direction = ParameterDirection.Input;
                pZfbz.Value = ypkc_djmxParam.Zfbz;
                sqlparams.Add(pZfbz);

            }
                        
            sql.Append(" WHERE ID=:id ");
            OracleParameter pId = new OracleParameter(":id", OracleDbType.Varchar2);
            pId.Value = ypkc_djmxParam.Id;
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
        /// <param name="ypkc_djmxParamList">要修改的Ypkc_djmx对象集合</param>
        /// <param name="con">Oracle连接对象（为null时自动生成）</param>
        /// <returns>是否删除成功（影响的行数等于要修改的对象数量时成功）</returns>
        public bool updateByIdBatch(List<Ypkc_djmx> ypkc_djmxParamList, OracleConnection con)
        {


            List<string> idList = new List<string>();

            List<decimal?> djhList = new List<decimal?>();

            List<string> fk_dj_idList = new List<string>();

            List<string> fk_ypList = new List<string>();

            List<string> ypbhList = new List<string>();

            List<string> ypmcList = new List<string>();

            List<string> yptymcList = new List<string>();

            List<string> ddwList = new List<string>();

            List<string> xdwList = new List<string>();

            List<decimal?> hsblList = new List<decimal?>();

            List<string> pzwhList = new List<string>();

            List<string> gyzzList = new List<string>();

            List<string> jxList = new List<string>();

            List<string> ypggList = new List<string>();

            List<string> cjmcList = new List<string>();

            List<string> pymList = new List<string>();

            List<string> phList = new List<string>();

            List<DateTime?> yxqList = new List<DateTime?>();

            List<decimal?> jjList = new List<decimal?>();

            List<decimal?> lsjList = new List<decimal?>();

            List<decimal?> slList = new List<decimal?>();

            List<decimal?> jjjeList = new List<decimal?>();

            List<decimal?> lsjjeList = new List<decimal?>();

            List<string> zfbzList = new List<string>();

            for (int i = 0; i < ypkc_djmxParamList.Count; i++)
            {
                Ypkc_djmx ypkc_djmxParam = ypkc_djmxParamList[i];
                if ("" == ypkc_djmxParam.Id || null == ypkc_djmxParam.Id)
                {
                    throw new Exception("下标为" + i + "的数据，ID不能为空，请赋值后调用；错误出自：updateByIdBatch");
                }

            idList.Add(ypkc_djmxParam.Id);

            djhList.Add(ypkc_djmxParam.Djh);

            fk_dj_idList.Add(ypkc_djmxParam.Fk_dj_id);

            fk_ypList.Add(ypkc_djmxParam.Fk_yp);

            ypbhList.Add(ypkc_djmxParam.Ypbh);

            ypmcList.Add(ypkc_djmxParam.Ypmc);

            yptymcList.Add(ypkc_djmxParam.Yptymc);

            ddwList.Add(ypkc_djmxParam.Ddw);

            xdwList.Add(ypkc_djmxParam.Xdw);

            hsblList.Add(ypkc_djmxParam.Hsbl);

            pzwhList.Add(ypkc_djmxParam.Pzwh);

            gyzzList.Add(ypkc_djmxParam.Gyzz);

            jxList.Add(ypkc_djmxParam.Jx);

            ypggList.Add(ypkc_djmxParam.Ypgg);

            cjmcList.Add(ypkc_djmxParam.Cjmc);

            pymList.Add(ypkc_djmxParam.Pym);

            phList.Add(ypkc_djmxParam.Ph);

            yxqList.Add(ypkc_djmxParam.Yxq);

            jjList.Add(ypkc_djmxParam.Jj);

            lsjList.Add(ypkc_djmxParam.Lsj);

            slList.Add(ypkc_djmxParam.Sl);

            jjjeList.Add(ypkc_djmxParam.Jjje);

            lsjjeList.Add(ypkc_djmxParam.Lsjje);

            zfbzList.Add(ypkc_djmxParam.Zfbz);

            }


            
            List<OracleParameter> sqlparams = new List<OracleParameter>();

            StringBuilder sql = new StringBuilder("UPDATE YPKC_DJMX SET ");
            this.isComma(sql);
            sql.Append(" DJH=:djh ");
            OracleParameter pDjh = new OracleParameter(":djh", OracleDbType.Decimal);
            pDjh.Direction = ParameterDirection.Input;
            pDjh.Value = djhList.ToArray();
            sqlparams.Add(pDjh);

            this.isComma(sql);
            sql.Append(" FK_DJ_ID=:fk_dj_id ");
            OracleParameter pFk_dj_id = new OracleParameter(":fk_dj_id", OracleDbType.Varchar2);
            pFk_dj_id.Direction = ParameterDirection.Input;
            pFk_dj_id.Value = fk_dj_idList.ToArray();
            sqlparams.Add(pFk_dj_id);

            this.isComma(sql);
            sql.Append(" FK_YP=:fk_yp ");
            OracleParameter pFk_yp = new OracleParameter(":fk_yp", OracleDbType.Varchar2);
            pFk_yp.Direction = ParameterDirection.Input;
            pFk_yp.Value = fk_ypList.ToArray();
            sqlparams.Add(pFk_yp);

            this.isComma(sql);
            sql.Append(" YPBH=:ypbh ");
            OracleParameter pYpbh = new OracleParameter(":ypbh", OracleDbType.Varchar2);
            pYpbh.Direction = ParameterDirection.Input;
            pYpbh.Value = ypbhList.ToArray();
            sqlparams.Add(pYpbh);

            this.isComma(sql);
            sql.Append(" YPMC=:ypmc ");
            OracleParameter pYpmc = new OracleParameter(":ypmc", OracleDbType.Varchar2);
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
            sql.Append(" DDW=:ddw ");
            OracleParameter pDdw = new OracleParameter(":ddw", OracleDbType.Varchar2);
            pDdw.Direction = ParameterDirection.Input;
            pDdw.Value = ddwList.ToArray();
            sqlparams.Add(pDdw);

            this.isComma(sql);
            sql.Append(" XDW=:xdw ");
            OracleParameter pXdw = new OracleParameter(":xdw", OracleDbType.Varchar2);
            pXdw.Direction = ParameterDirection.Input;
            pXdw.Value = xdwList.ToArray();
            sqlparams.Add(pXdw);

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
            sql.Append(" JX=:jx ");
            OracleParameter pJx = new OracleParameter(":jx", OracleDbType.NVarchar2);
            pJx.Direction = ParameterDirection.Input;
            pJx.Value = jxList.ToArray();
            sqlparams.Add(pJx);

            this.isComma(sql);
            sql.Append(" YPGG=:ypgg ");
            OracleParameter pYpgg = new OracleParameter(":ypgg", OracleDbType.NVarchar2);
            pYpgg.Direction = ParameterDirection.Input;
            pYpgg.Value = ypggList.ToArray();
            sqlparams.Add(pYpgg);

            this.isComma(sql);
            sql.Append(" CJMC=:cjmc ");
            OracleParameter pCjmc = new OracleParameter(":cjmc", OracleDbType.NVarchar2);
            pCjmc.Direction = ParameterDirection.Input;
            pCjmc.Value = cjmcList.ToArray();
            sqlparams.Add(pCjmc);

            this.isComma(sql);
            sql.Append(" PYM=:pym ");
            OracleParameter pPym = new OracleParameter(":pym", OracleDbType.NVarchar2);
            pPym.Direction = ParameterDirection.Input;
            pPym.Value = pymList.ToArray();
            sqlparams.Add(pPym);

            this.isComma(sql);
            sql.Append(" PH=:ph ");
            OracleParameter pPh = new OracleParameter(":ph", OracleDbType.Varchar2);
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
            sql.Append(" JJJE=:jjje ");
            OracleParameter pJjje = new OracleParameter(":jjje", OracleDbType.Decimal);
            pJjje.Direction = ParameterDirection.Input;
            pJjje.Value = jjjeList.ToArray();
            sqlparams.Add(pJjje);

            this.isComma(sql);
            sql.Append(" LSJJE=:lsjje ");
            OracleParameter pLsjje = new OracleParameter(":lsjje", OracleDbType.Decimal);
            pLsjje.Direction = ParameterDirection.Input;
            pLsjje.Value = lsjjeList.ToArray();
            sqlparams.Add(pLsjje);

            this.isComma(sql);
            sql.Append(" ZFBZ=:zfbz ");
            OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
            pZfbz.Direction = ParameterDirection.Input;
            pZfbz.Value = zfbzList.ToArray();
            sqlparams.Add(pZfbz);

            sql.Append(" WHERE ID=:id ");
            OracleParameter pId = new OracleParameter(":id", OracleDbType.Varchar2);
            pId.Value = idList.ToArray();
            sqlparams.Add(pId);
            bool result = false;
            int flag = OracleHelper.ExecuteBatch(sql.ToString(), con,ypkc_djmxParamList.Count, sqlparams.ToArray());
            if (ypkc_djmxParamList.Count == flag)
            {
                result = true;
            }
            return result;
        }

        /// <summary>
        /// 根据更新的条件，更新数据（如果需要供事务使用就传入OracleConnection对象，如果不供就传入null，方法自动生成OracleConnection对象）
        /// 不指定ID，如果要根据ID来更新数据，请使用updateForId方法
        /// </summary>
        /// <param name="ypkc_djmxParamCondition">条件对象</param>
        /// <param name="ypkc_djmxParamUpdate">要更新的数据对象</param>
        /// <param name="con">Oracle连接对象（为null时自动生成）</param>
        /// <returns>影响的行数不确定（不为-1就正确）</returns>
        public bool updateByOtherCondition(Ypkc_djmx ypkc_djmxParamCondition, Ypkc_djmx ypkc_djmxParamUpdate, OracleConnection con)
        {
            if ((null!=ypkc_djmxParamCondition.Id&&"!=ypkc_djmxParamCondition.Id)||(null!=ypkc_djmxParamUpdate.Id&&"!=ypkc_djmxParamUpdate.Id))
            {
                throw new Exception("此方法不允许指定参数的ID，数据库中的ID不允许修改，如需根据ID修改数据，请调用updateById或updateByIdBatch方法；错误出自：updateByOtherCondition");
            }
            List<OracleParameter> sqlparams = new List<OracleParameter>();
            //添加要修改的值
            StringBuilder sql = new StringBuilder("UPDATE YPKC_DJMX SET ");
            if (null != ypkc_djmxParamUpdate.Djh)
            {
                this.isComma(sql);
                sql.Append(" DJH=:djh ");
                OracleParameter pDjh = new OracleParameter(":djh", OracleDbType.Decimal);
                pDjh.Direction = ParameterDirection.Input;
                pDjh.Value = ypkc_djmxParamUpdate.Djh;
                sqlparams.Add(pDjh);

            }
                        
            if (null != ypkc_djmxParamUpdate.Fk_dj_id &&  ""!= ypkc_djmxParamUpdate.Fk_dj_id)
            {
                this.isComma(sql);
                sql.Append(" FK_DJ_ID=:fk_dj_id ");
                OracleParameter pFk_dj_id = new OracleParameter(":fk_dj_id", OracleDbType.Varchar2);
                pFk_dj_id.Direction = ParameterDirection.Input;
                pFk_dj_id.Value = ypkc_djmxParamUpdate.Fk_dj_id;
                sqlparams.Add(pFk_dj_id);

            }
                        
            if (null != ypkc_djmxParamUpdate.Fk_yp &&  ""!= ypkc_djmxParamUpdate.Fk_yp)
            {
                this.isComma(sql);
                sql.Append(" FK_YP=:fk_yp ");
                OracleParameter pFk_yp = new OracleParameter(":fk_yp", OracleDbType.Varchar2);
                pFk_yp.Direction = ParameterDirection.Input;
                pFk_yp.Value = ypkc_djmxParamUpdate.Fk_yp;
                sqlparams.Add(pFk_yp);

            }
                        
            if (null != ypkc_djmxParamUpdate.Ypbh &&  ""!= ypkc_djmxParamUpdate.Ypbh)
            {
                this.isComma(sql);
                sql.Append(" YPBH=:ypbh ");
                OracleParameter pYpbh = new OracleParameter(":ypbh", OracleDbType.Varchar2);
                pYpbh.Direction = ParameterDirection.Input;
                pYpbh.Value = ypkc_djmxParamUpdate.Ypbh;
                sqlparams.Add(pYpbh);

            }
                        
            if (null != ypkc_djmxParamUpdate.Ypmc &&  ""!= ypkc_djmxParamUpdate.Ypmc)
            {
                this.isComma(sql);
                sql.Append(" YPMC=:ypmc ");
                OracleParameter pYpmc = new OracleParameter(":ypmc", OracleDbType.Varchar2);
                pYpmc.Direction = ParameterDirection.Input;
                pYpmc.Value = ypkc_djmxParamUpdate.Ypmc;
                sqlparams.Add(pYpmc);

            }
                        
            if (null != ypkc_djmxParamUpdate.Yptymc &&  ""!= ypkc_djmxParamUpdate.Yptymc)
            {
                this.isComma(sql);
                sql.Append(" YPTYMC=:yptymc ");
                OracleParameter pYptymc = new OracleParameter(":yptymc", OracleDbType.NVarchar2);
                pYptymc.Direction = ParameterDirection.Input;
                pYptymc.Value = ypkc_djmxParamUpdate.Yptymc;
                sqlparams.Add(pYptymc);

            }
                        
            if (null != ypkc_djmxParamUpdate.Ddw &&  ""!= ypkc_djmxParamUpdate.Ddw)
            {
                this.isComma(sql);
                sql.Append(" DDW=:ddw ");
                OracleParameter pDdw = new OracleParameter(":ddw", OracleDbType.Varchar2);
                pDdw.Direction = ParameterDirection.Input;
                pDdw.Value = ypkc_djmxParamUpdate.Ddw;
                sqlparams.Add(pDdw);

            }
                        
            if (null != ypkc_djmxParamUpdate.Xdw &&  ""!= ypkc_djmxParamUpdate.Xdw)
            {
                this.isComma(sql);
                sql.Append(" XDW=:xdw ");
                OracleParameter pXdw = new OracleParameter(":xdw", OracleDbType.Varchar2);
                pXdw.Direction = ParameterDirection.Input;
                pXdw.Value = ypkc_djmxParamUpdate.Xdw;
                sqlparams.Add(pXdw);

            }
                        
            if (null != ypkc_djmxParamUpdate.Hsbl)
            {
                this.isComma(sql);
                sql.Append(" HSBL=:hsbl ");
                OracleParameter pHsbl = new OracleParameter(":hsbl", OracleDbType.Decimal);
                pHsbl.Direction = ParameterDirection.Input;
                pHsbl.Value = ypkc_djmxParamUpdate.Hsbl;
                sqlparams.Add(pHsbl);

            }
                        
            if (null != ypkc_djmxParamUpdate.Pzwh &&  ""!= ypkc_djmxParamUpdate.Pzwh)
            {
                this.isComma(sql);
                sql.Append(" PZWH=:pzwh ");
                OracleParameter pPzwh = new OracleParameter(":pzwh", OracleDbType.Varchar2);
                pPzwh.Direction = ParameterDirection.Input;
                pPzwh.Value = ypkc_djmxParamUpdate.Pzwh;
                sqlparams.Add(pPzwh);

            }
                        
            if (null != ypkc_djmxParamUpdate.Gyzz &&  ""!= ypkc_djmxParamUpdate.Gyzz)
            {
                this.isComma(sql);
                sql.Append(" GYZZ=:gyzz ");
                OracleParameter pGyzz = new OracleParameter(":gyzz", OracleDbType.Varchar2);
                pGyzz.Direction = ParameterDirection.Input;
                pGyzz.Value = ypkc_djmxParamUpdate.Gyzz;
                sqlparams.Add(pGyzz);

            }
                        
            if (null != ypkc_djmxParamUpdate.Jx &&  ""!= ypkc_djmxParamUpdate.Jx)
            {
                this.isComma(sql);
                sql.Append(" JX=:jx ");
                OracleParameter pJx = new OracleParameter(":jx", OracleDbType.NVarchar2);
                pJx.Direction = ParameterDirection.Input;
                pJx.Value = ypkc_djmxParamUpdate.Jx;
                sqlparams.Add(pJx);

            }
                        
            if (null != ypkc_djmxParamUpdate.Ypgg &&  ""!= ypkc_djmxParamUpdate.Ypgg)
            {
                this.isComma(sql);
                sql.Append(" YPGG=:ypgg ");
                OracleParameter pYpgg = new OracleParameter(":ypgg", OracleDbType.NVarchar2);
                pYpgg.Direction = ParameterDirection.Input;
                pYpgg.Value = ypkc_djmxParamUpdate.Ypgg;
                sqlparams.Add(pYpgg);

            }
                        
            if (null != ypkc_djmxParamUpdate.Cjmc &&  ""!= ypkc_djmxParamUpdate.Cjmc)
            {
                this.isComma(sql);
                sql.Append(" CJMC=:cjmc ");
                OracleParameter pCjmc = new OracleParameter(":cjmc", OracleDbType.NVarchar2);
                pCjmc.Direction = ParameterDirection.Input;
                pCjmc.Value = ypkc_djmxParamUpdate.Cjmc;
                sqlparams.Add(pCjmc);

            }
                        
            if (null != ypkc_djmxParamUpdate.Pym &&  ""!= ypkc_djmxParamUpdate.Pym)
            {
                this.isComma(sql);
                sql.Append(" PYM=:pym ");
                OracleParameter pPym = new OracleParameter(":pym", OracleDbType.NVarchar2);
                pPym.Direction = ParameterDirection.Input;
                pPym.Value = ypkc_djmxParamUpdate.Pym;
                sqlparams.Add(pPym);

            }
                        
            if (null != ypkc_djmxParamUpdate.Ph &&  ""!= ypkc_djmxParamUpdate.Ph)
            {
                this.isComma(sql);
                sql.Append(" PH=:ph ");
                OracleParameter pPh = new OracleParameter(":ph", OracleDbType.Varchar2);
                pPh.Direction = ParameterDirection.Input;
                pPh.Value = ypkc_djmxParamUpdate.Ph;
                sqlparams.Add(pPh);

            }
                        
            if (DateTime.MinValue != ypkc_djmxParamUpdate.Yxq &&null != ypkc_djmxParamUpdate.Yxq)
            {
                this.isComma(sql);
                sql.Append(" YXQ=:yxq ");
                OracleParameter pYxq = new OracleParameter(":yxq", OracleDbType.Date);
                pYxq.Direction = ParameterDirection.Input;
                pYxq.Value = ypkc_djmxParamUpdate.Yxq;
                sqlparams.Add(pYxq);

            }
                        
            if (null != ypkc_djmxParamUpdate.Jj)
            {
                this.isComma(sql);
                sql.Append(" JJ=:jj ");
                OracleParameter pJj = new OracleParameter(":jj", OracleDbType.Decimal);
                pJj.Direction = ParameterDirection.Input;
                pJj.Value = ypkc_djmxParamUpdate.Jj;
                sqlparams.Add(pJj);

            }
                        
            if (null != ypkc_djmxParamUpdate.Lsj)
            {
                this.isComma(sql);
                sql.Append(" LSJ=:lsj ");
                OracleParameter pLsj = new OracleParameter(":lsj", OracleDbType.Decimal);
                pLsj.Direction = ParameterDirection.Input;
                pLsj.Value = ypkc_djmxParamUpdate.Lsj;
                sqlparams.Add(pLsj);

            }
                        
            if (null != ypkc_djmxParamUpdate.Sl)
            {
                this.isComma(sql);
                sql.Append(" SL=:sl ");
                OracleParameter pSl = new OracleParameter(":sl", OracleDbType.Decimal);
                pSl.Direction = ParameterDirection.Input;
                pSl.Value = ypkc_djmxParamUpdate.Sl;
                sqlparams.Add(pSl);

            }
                        
            if (null != ypkc_djmxParamUpdate.Jjje)
            {
                this.isComma(sql);
                sql.Append(" JJJE=:jjje ");
                OracleParameter pJjje = new OracleParameter(":jjje", OracleDbType.Decimal);
                pJjje.Direction = ParameterDirection.Input;
                pJjje.Value = ypkc_djmxParamUpdate.Jjje;
                sqlparams.Add(pJjje);

            }
                        
            if (null != ypkc_djmxParamUpdate.Lsjje)
            {
                this.isComma(sql);
                sql.Append(" LSJJE=:lsjje ");
                OracleParameter pLsjje = new OracleParameter(":lsjje", OracleDbType.Decimal);
                pLsjje.Direction = ParameterDirection.Input;
                pLsjje.Value = ypkc_djmxParamUpdate.Lsjje;
                sqlparams.Add(pLsjje);

            }
                        
            if (null != ypkc_djmxParamUpdate.Zfbz &&  ""!= ypkc_djmxParamUpdate.Zfbz)
            {
                this.isComma(sql);
                sql.Append(" ZFBZ=:zfbz ");
                OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                pZfbz.Direction = ParameterDirection.Input;
                pZfbz.Value = ypkc_djmxParamUpdate.Zfbz;
                sqlparams.Add(pZfbz);

            }
                        
            //添加条件的参数
            
            if (null != ypkc_djmxParamCondition.Djh)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" DJH=:djh ");
                OracleParameter pDjh = new OracleParameter(":djh", OracleDbType.Decimal);
                pDjh.Direction = ParameterDirection.Input;
                pDjh.Value = ypkc_djmxParamCondition.Djh;
                sqlparams.Add(pDjh);

            }
                        
            if (null != ypkc_djmxParamCondition.Fk_dj_id &&  ""!= ypkc_djmxParamCondition.Fk_dj_id)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" FK_DJ_ID=:fk_dj_id ");
                OracleParameter pFk_dj_id = new OracleParameter(":fk_dj_id", OracleDbType.Varchar2);
                pFk_dj_id.Direction = ParameterDirection.Input;
                pFk_dj_id.Value = ypkc_djmxParamCondition.Fk_dj_id;
                sqlparams.Add(pFk_dj_id);

            }
                        
            if (null != ypkc_djmxParamCondition.Fk_yp &&  ""!= ypkc_djmxParamCondition.Fk_yp)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" FK_YP=:fk_yp ");
                OracleParameter pFk_yp = new OracleParameter(":fk_yp", OracleDbType.Varchar2);
                pFk_yp.Direction = ParameterDirection.Input;
                pFk_yp.Value = ypkc_djmxParamCondition.Fk_yp;
                sqlparams.Add(pFk_yp);

            }
                        
            if (null != ypkc_djmxParamCondition.Ypbh &&  ""!= ypkc_djmxParamCondition.Ypbh)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" YPBH=:ypbh ");
                OracleParameter pYpbh = new OracleParameter(":ypbh", OracleDbType.Varchar2);
                pYpbh.Direction = ParameterDirection.Input;
                pYpbh.Value = ypkc_djmxParamCondition.Ypbh;
                sqlparams.Add(pYpbh);

            }
                        
            if (null != ypkc_djmxParamCondition.Ypmc &&  ""!= ypkc_djmxParamCondition.Ypmc)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" YPMC=:ypmc ");
                OracleParameter pYpmc = new OracleParameter(":ypmc", OracleDbType.Varchar2);
                pYpmc.Direction = ParameterDirection.Input;
                pYpmc.Value = ypkc_djmxParamCondition.Ypmc;
                sqlparams.Add(pYpmc);

            }
                        
            if (null != ypkc_djmxParamCondition.Yptymc &&  ""!= ypkc_djmxParamCondition.Yptymc)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" YPTYMC=:yptymc ");
                OracleParameter pYptymc = new OracleParameter(":yptymc", OracleDbType.NVarchar2);
                pYptymc.Direction = ParameterDirection.Input;
                pYptymc.Value = ypkc_djmxParamCondition.Yptymc;
                sqlparams.Add(pYptymc);

            }
                        
            if (null != ypkc_djmxParamCondition.Ddw &&  ""!= ypkc_djmxParamCondition.Ddw)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" DDW=:ddw ");
                OracleParameter pDdw = new OracleParameter(":ddw", OracleDbType.Varchar2);
                pDdw.Direction = ParameterDirection.Input;
                pDdw.Value = ypkc_djmxParamCondition.Ddw;
                sqlparams.Add(pDdw);

            }
                        
            if (null != ypkc_djmxParamCondition.Xdw &&  ""!= ypkc_djmxParamCondition.Xdw)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" XDW=:xdw ");
                OracleParameter pXdw = new OracleParameter(":xdw", OracleDbType.Varchar2);
                pXdw.Direction = ParameterDirection.Input;
                pXdw.Value = ypkc_djmxParamCondition.Xdw;
                sqlparams.Add(pXdw);

            }
                        
            if (null != ypkc_djmxParamCondition.Hsbl)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" HSBL=:hsbl ");
                OracleParameter pHsbl = new OracleParameter(":hsbl", OracleDbType.Decimal);
                pHsbl.Direction = ParameterDirection.Input;
                pHsbl.Value = ypkc_djmxParamCondition.Hsbl;
                sqlparams.Add(pHsbl);

            }
                        
            if (null != ypkc_djmxParamCondition.Pzwh &&  ""!= ypkc_djmxParamCondition.Pzwh)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" PZWH=:pzwh ");
                OracleParameter pPzwh = new OracleParameter(":pzwh", OracleDbType.Varchar2);
                pPzwh.Direction = ParameterDirection.Input;
                pPzwh.Value = ypkc_djmxParamCondition.Pzwh;
                sqlparams.Add(pPzwh);

            }
                        
            if (null != ypkc_djmxParamCondition.Gyzz &&  ""!= ypkc_djmxParamCondition.Gyzz)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" GYZZ=:gyzz ");
                OracleParameter pGyzz = new OracleParameter(":gyzz", OracleDbType.Varchar2);
                pGyzz.Direction = ParameterDirection.Input;
                pGyzz.Value = ypkc_djmxParamCondition.Gyzz;
                sqlparams.Add(pGyzz);

            }
                        
            if (null != ypkc_djmxParamCondition.Jx &&  ""!= ypkc_djmxParamCondition.Jx)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" JX=:jx ");
                OracleParameter pJx = new OracleParameter(":jx", OracleDbType.NVarchar2);
                pJx.Direction = ParameterDirection.Input;
                pJx.Value = ypkc_djmxParamCondition.Jx;
                sqlparams.Add(pJx);

            }
                        
            if (null != ypkc_djmxParamCondition.Ypgg &&  ""!= ypkc_djmxParamCondition.Ypgg)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" YPGG=:ypgg ");
                OracleParameter pYpgg = new OracleParameter(":ypgg", OracleDbType.NVarchar2);
                pYpgg.Direction = ParameterDirection.Input;
                pYpgg.Value = ypkc_djmxParamCondition.Ypgg;
                sqlparams.Add(pYpgg);

            }
                        
            if (null != ypkc_djmxParamCondition.Cjmc &&  ""!= ypkc_djmxParamCondition.Cjmc)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" CJMC=:cjmc ");
                OracleParameter pCjmc = new OracleParameter(":cjmc", OracleDbType.NVarchar2);
                pCjmc.Direction = ParameterDirection.Input;
                pCjmc.Value = ypkc_djmxParamCondition.Cjmc;
                sqlparams.Add(pCjmc);

            }
                        
            if (null != ypkc_djmxParamCondition.Pym &&  ""!= ypkc_djmxParamCondition.Pym)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" PYM=:pym ");
                OracleParameter pPym = new OracleParameter(":pym", OracleDbType.NVarchar2);
                pPym.Direction = ParameterDirection.Input;
                pPym.Value = ypkc_djmxParamCondition.Pym;
                sqlparams.Add(pPym);

            }
                        
            if (null != ypkc_djmxParamCondition.Ph &&  ""!= ypkc_djmxParamCondition.Ph)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" PH=:ph ");
                OracleParameter pPh = new OracleParameter(":ph", OracleDbType.Varchar2);
                pPh.Direction = ParameterDirection.Input;
                pPh.Value = ypkc_djmxParamCondition.Ph;
                sqlparams.Add(pPh);

            }
                        
            if (DateTime.MinValue != ypkc_djmxParamCondition.Yxq &&null != ypkc_djmxParamCondition.Yxq)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" YXQ=:yxq ");
                OracleParameter pYxq = new OracleParameter(":yxq", OracleDbType.Date);
                pYxq.Direction = ParameterDirection.Input;
                pYxq.Value = ypkc_djmxParamCondition.Yxq;
                sqlparams.Add(pYxq);

            }
                        
            if (null != ypkc_djmxParamCondition.Jj)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" JJ=:jj ");
                OracleParameter pJj = new OracleParameter(":jj", OracleDbType.Decimal);
                pJj.Direction = ParameterDirection.Input;
                pJj.Value = ypkc_djmxParamCondition.Jj;
                sqlparams.Add(pJj);

            }
                        
            if (null != ypkc_djmxParamCondition.Lsj)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" LSJ=:lsj ");
                OracleParameter pLsj = new OracleParameter(":lsj", OracleDbType.Decimal);
                pLsj.Direction = ParameterDirection.Input;
                pLsj.Value = ypkc_djmxParamCondition.Lsj;
                sqlparams.Add(pLsj);

            }
                        
            if (null != ypkc_djmxParamCondition.Sl)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" SL=:sl ");
                OracleParameter pSl = new OracleParameter(":sl", OracleDbType.Decimal);
                pSl.Direction = ParameterDirection.Input;
                pSl.Value = ypkc_djmxParamCondition.Sl;
                sqlparams.Add(pSl);

            }
                        
            if (null != ypkc_djmxParamCondition.Jjje)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" JJJE=:jjje ");
                OracleParameter pJjje = new OracleParameter(":jjje", OracleDbType.Decimal);
                pJjje.Direction = ParameterDirection.Input;
                pJjje.Value = ypkc_djmxParamCondition.Jjje;
                sqlparams.Add(pJjje);

            }
                        
            if (null != ypkc_djmxParamCondition.Lsjje)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" LSJJE=:lsjje ");
                OracleParameter pLsjje = new OracleParameter(":lsjje", OracleDbType.Decimal);
                pLsjje.Direction = ParameterDirection.Input;
                pLsjje.Value = ypkc_djmxParamCondition.Lsjje;
                sqlparams.Add(pLsjje);

            }
                        
            if (null != ypkc_djmxParamCondition.Zfbz &&  ""!= ypkc_djmxParamCondition.Zfbz)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" ZFBZ=:zfbz ");
                OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                pZfbz.Direction = ParameterDirection.Input;
                pZfbz.Value = ypkc_djmxParamCondition.Zfbz;
                sqlparams.Add(pZfbz);

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
        /// 查找指定ID的用户
        /// </summary>
        /// <remarks>id为null、id重复、id未找到，抛异常</remarks>
        /// <returns>Ypkc_djmx</returns>
        public Ypkc_djmx findById(string id)
        {
            if (""==id||null==id)
            {
                throw new Exception("ID不能为空，请赋值后调用；错误出自：findById");
            }
            StringBuilder sql = new StringBuilder("SELECT A.* ");
            //新建方法findContactObjectsById，在此加入多表连接要显示的项start
            //sql.Append(",B.字段一,B.字段二,B.字段三");
            //新建方法，在此加入多表连接要显示的项end
            sql.Append(" FROM YPKC_DJMX A ");
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
        /// <param name="ypkc_djmxParam"></param>
        /// <param name="page">分页对象</param>
        ///<param name="ypkc_djmxParamLike">模糊查询参数</param>
        ///<param name="sortList">排序参数对象的集合</param>
        /// <returns>满足条件的所有Ypkc_djmx对象集合list</returns>
        public List<object> find(Ypkc_djmx ypkc_djmxParam, Model.Common.PageInfo page,Ypkc_djmx ypkc_djmxParamLike,List<SortInfo> sortList)
        {

            //如果没有传查询条件参数，就new一个空的Ypkc_djmx对象，标示查询所有数据
            if (null == ypkc_djmxParam)
            {
                ypkc_djmxParam = new Ypkc_djmx();
            }
            if (null!=ypkc_djmxParam.Id&&""!=ypkc_djmxParam.Id)
            {
                throw new Exception("此方法不允许指定参数ID，如果需要根据ID查询数据，请调用findById方法；错误出自：find");
            }
            List<Ypkc_djmx> ypkc_djmxParamList = new List<Ypkc_djmx>();//接收查询出的Ypkc_djmx对象集合
            List<OracleParameter> sqlparams = new List<OracleParameter>();//保存参数的集合
            StringBuilder sql = new StringBuilder("SELECT A.* ");
            //新建方法findContactObjects(Ypkc_djmx ypkc_djmxParam, Model.Common.PageInfo page)，在此加入多表连接要显示的项start
            //sql.Append(",B.字段一,B.字段二,B.字段三");
            //新建方法，在此加入多表连接要显示的项end
            sql.Append(" FROM YPKC_DJMX A ");
            //新建一个方法，在此加入多表连接的语句start
            ////sql.Append(" LEFT JOIN 表名 B ON A.外键=B.ID");
            //新建一个方法，在此加入多表连接的语句end
            
            
            if (null != ypkc_djmxParam.Djh)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.DJH=:djh ");
                OracleParameter pDjh = new OracleParameter(":djh", OracleDbType.Decimal);
                pDjh.Direction = ParameterDirection.Input;
                pDjh.Value = ypkc_djmxParam.Djh;
                sqlparams.Add(pDjh);

            }
                        
            if (null != ypkc_djmxParam.Fk_dj_id && "" != ypkc_djmxParam.Fk_dj_id)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.FK_DJ_ID=:fk_dj_id ");
                OracleParameter pFk_dj_id = new OracleParameter(":fk_dj_id", OracleDbType.Varchar2);
                pFk_dj_id.Direction = ParameterDirection.Input;
                pFk_dj_id.Value = ypkc_djmxParam.Fk_dj_id;
                sqlparams.Add(pFk_dj_id);
            }
                
            if (null != ypkc_djmxParam.Fk_yp && "" != ypkc_djmxParam.Fk_yp)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.FK_YP=:fk_yp ");
                OracleParameter pFk_yp = new OracleParameter(":fk_yp", OracleDbType.Varchar2);
                pFk_yp.Direction = ParameterDirection.Input;
                pFk_yp.Value = ypkc_djmxParam.Fk_yp;
                sqlparams.Add(pFk_yp);
            }
                
            if (null != ypkc_djmxParam.Ypbh && "" != ypkc_djmxParam.Ypbh)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.YPBH=:ypbh ");
                OracleParameter pYpbh = new OracleParameter(":ypbh", OracleDbType.Varchar2);
                pYpbh.Direction = ParameterDirection.Input;
                pYpbh.Value = ypkc_djmxParam.Ypbh;
                sqlparams.Add(pYpbh);
            }
                
            if (null != ypkc_djmxParam.Ypmc && "" != ypkc_djmxParam.Ypmc)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.YPMC=:ypmc ");
                OracleParameter pYpmc = new OracleParameter(":ypmc", OracleDbType.Varchar2);
                pYpmc.Direction = ParameterDirection.Input;
                pYpmc.Value = ypkc_djmxParam.Ypmc;
                sqlparams.Add(pYpmc);
            }
                
            if (null != ypkc_djmxParam.Yptymc && "" != ypkc_djmxParam.Yptymc)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.YPTYMC=:yptymc ");
                OracleParameter pYptymc = new OracleParameter(":yptymc", OracleDbType.NVarchar2);
                pYptymc.Direction = ParameterDirection.Input;
                pYptymc.Value = ypkc_djmxParam.Yptymc;
                sqlparams.Add(pYptymc);
            }
                
            if (null != ypkc_djmxParam.Ddw && "" != ypkc_djmxParam.Ddw)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.DDW=:ddw ");
                OracleParameter pDdw = new OracleParameter(":ddw", OracleDbType.Varchar2);
                pDdw.Direction = ParameterDirection.Input;
                pDdw.Value = ypkc_djmxParam.Ddw;
                sqlparams.Add(pDdw);
            }
                
            if (null != ypkc_djmxParam.Xdw && "" != ypkc_djmxParam.Xdw)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.XDW=:xdw ");
                OracleParameter pXdw = new OracleParameter(":xdw", OracleDbType.Varchar2);
                pXdw.Direction = ParameterDirection.Input;
                pXdw.Value = ypkc_djmxParam.Xdw;
                sqlparams.Add(pXdw);
            }
                
            if (null != ypkc_djmxParam.Hsbl)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.HSBL=:hsbl ");
                OracleParameter pHsbl = new OracleParameter(":hsbl", OracleDbType.Decimal);
                pHsbl.Direction = ParameterDirection.Input;
                pHsbl.Value = ypkc_djmxParam.Hsbl;
                sqlparams.Add(pHsbl);

            }
                        
            if (null != ypkc_djmxParam.Pzwh && "" != ypkc_djmxParam.Pzwh)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.PZWH=:pzwh ");
                OracleParameter pPzwh = new OracleParameter(":pzwh", OracleDbType.Varchar2);
                pPzwh.Direction = ParameterDirection.Input;
                pPzwh.Value = ypkc_djmxParam.Pzwh;
                sqlparams.Add(pPzwh);
            }
                
            if (null != ypkc_djmxParam.Gyzz && "" != ypkc_djmxParam.Gyzz)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.GYZZ=:gyzz ");
                OracleParameter pGyzz = new OracleParameter(":gyzz", OracleDbType.Varchar2);
                pGyzz.Direction = ParameterDirection.Input;
                pGyzz.Value = ypkc_djmxParam.Gyzz;
                sqlparams.Add(pGyzz);
            }
                
            if (null != ypkc_djmxParam.Jx && "" != ypkc_djmxParam.Jx)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.JX=:jx ");
                OracleParameter pJx = new OracleParameter(":jx", OracleDbType.NVarchar2);
                pJx.Direction = ParameterDirection.Input;
                pJx.Value = ypkc_djmxParam.Jx;
                sqlparams.Add(pJx);
            }
                
            if (null != ypkc_djmxParam.Ypgg && "" != ypkc_djmxParam.Ypgg)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.YPGG=:ypgg ");
                OracleParameter pYpgg = new OracleParameter(":ypgg", OracleDbType.NVarchar2);
                pYpgg.Direction = ParameterDirection.Input;
                pYpgg.Value = ypkc_djmxParam.Ypgg;
                sqlparams.Add(pYpgg);
            }
                
            if (null != ypkc_djmxParam.Cjmc && "" != ypkc_djmxParam.Cjmc)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.CJMC=:cjmc ");
                OracleParameter pCjmc = new OracleParameter(":cjmc", OracleDbType.NVarchar2);
                pCjmc.Direction = ParameterDirection.Input;
                pCjmc.Value = ypkc_djmxParam.Cjmc;
                sqlparams.Add(pCjmc);
            }
                
            if (null != ypkc_djmxParam.Pym && "" != ypkc_djmxParam.Pym)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.PYM=:pym ");
                OracleParameter pPym = new OracleParameter(":pym", OracleDbType.NVarchar2);
                pPym.Direction = ParameterDirection.Input;
                pPym.Value = ypkc_djmxParam.Pym;
                sqlparams.Add(pPym);
            }
                
            if (null != ypkc_djmxParam.Ph && "" != ypkc_djmxParam.Ph)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.PH=:ph ");
                OracleParameter pPh = new OracleParameter(":ph", OracleDbType.Varchar2);
                pPh.Direction = ParameterDirection.Input;
                pPh.Value = ypkc_djmxParam.Ph;
                sqlparams.Add(pPh);
            }
                
                if (DateTime.MinValue != ypkc_djmxParam.Yxq &&null != ypkc_djmxParam.Yxq)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YXQ=:yxq ");
                    OracleParameter pYxq = new OracleParameter(":yxq", OracleDbType.Date);
                pYxq.Direction = ParameterDirection.Input;
                pYxq.Value = ypkc_djmxParam.Yxq;
                sqlparams.Add(pYxq);
                }
                
            if (null != ypkc_djmxParam.Jj)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.JJ=:jj ");
                OracleParameter pJj = new OracleParameter(":jj", OracleDbType.Decimal);
                pJj.Direction = ParameterDirection.Input;
                pJj.Value = ypkc_djmxParam.Jj;
                sqlparams.Add(pJj);

            }
                        
            if (null != ypkc_djmxParam.Lsj)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.LSJ=:lsj ");
                OracleParameter pLsj = new OracleParameter(":lsj", OracleDbType.Decimal);
                pLsj.Direction = ParameterDirection.Input;
                pLsj.Value = ypkc_djmxParam.Lsj;
                sqlparams.Add(pLsj);

            }
                        
            if (null != ypkc_djmxParam.Sl)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.SL=:sl ");
                OracleParameter pSl = new OracleParameter(":sl", OracleDbType.Decimal);
                pSl.Direction = ParameterDirection.Input;
                pSl.Value = ypkc_djmxParam.Sl;
                sqlparams.Add(pSl);

            }
                        
            if (null != ypkc_djmxParam.Jjje)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.JJJE=:jjje ");
                OracleParameter pJjje = new OracleParameter(":jjje", OracleDbType.Decimal);
                pJjje.Direction = ParameterDirection.Input;
                pJjje.Value = ypkc_djmxParam.Jjje;
                sqlparams.Add(pJjje);

            }
                        
            if (null != ypkc_djmxParam.Lsjje)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.LSJJE=:lsjje ");
                OracleParameter pLsjje = new OracleParameter(":lsjje", OracleDbType.Decimal);
                pLsjje.Direction = ParameterDirection.Input;
                pLsjje.Value = ypkc_djmxParam.Lsjje;
                sqlparams.Add(pLsjje);

            }
                        
            if (null != ypkc_djmxParam.Zfbz && "" != ypkc_djmxParam.Zfbz)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.ZFBZ=:zfbz ");
                OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                pZfbz.Direction = ParameterDirection.Input;
                pZfbz.Value = ypkc_djmxParam.Zfbz;
                sqlparams.Add(pZfbz);
            }
                
            if(ypkc_djmxParamLike!=null)
            {

                if (null != ypkc_djmxParamLike.Fk_dj_id && "" != ypkc_djmxParamLike.Fk_dj_id)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.FK_DJ_ID LIKE '%'||:fk_dj_id||'%' ");
                    OracleParameter pFk_dj_id = new OracleParameter(":fk_dj_id", OracleDbType.Varchar2);
                    pFk_dj_id.Direction = ParameterDirection.Input;
                    pFk_dj_id.Value = ypkc_djmxParamLike.Fk_dj_id;
                    sqlparams.Add(pFk_dj_id);
                }
                
                if (null != ypkc_djmxParamLike.Fk_yp && "" != ypkc_djmxParamLike.Fk_yp)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.FK_YP LIKE '%'||:fk_yp||'%' ");
                    OracleParameter pFk_yp = new OracleParameter(":fk_yp", OracleDbType.Varchar2);
                    pFk_yp.Direction = ParameterDirection.Input;
                    pFk_yp.Value = ypkc_djmxParamLike.Fk_yp;
                    sqlparams.Add(pFk_yp);
                }
                
                if (null != ypkc_djmxParamLike.Ypbh && "" != ypkc_djmxParamLike.Ypbh)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YPBH LIKE '%'||:ypbh||'%' ");
                    OracleParameter pYpbh = new OracleParameter(":ypbh", OracleDbType.Varchar2);
                    pYpbh.Direction = ParameterDirection.Input;
                    pYpbh.Value = ypkc_djmxParamLike.Ypbh;
                    sqlparams.Add(pYpbh);
                }
                
                if (null != ypkc_djmxParamLike.Ypmc && "" != ypkc_djmxParamLike.Ypmc)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YPMC LIKE '%'||:ypmc||'%' ");
                    OracleParameter pYpmc = new OracleParameter(":ypmc", OracleDbType.Varchar2);
                    pYpmc.Direction = ParameterDirection.Input;
                    pYpmc.Value = ypkc_djmxParamLike.Ypmc;
                    sqlparams.Add(pYpmc);
                }
                
                if (null != ypkc_djmxParamLike.Yptymc && "" != ypkc_djmxParamLike.Yptymc)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YPTYMC LIKE '%'||:yptymc||'%' ");
                    OracleParameter pYptymc = new OracleParameter(":yptymc", OracleDbType.NVarchar2);
                    pYptymc.Direction = ParameterDirection.Input;
                    pYptymc.Value = ypkc_djmxParamLike.Yptymc;
                    sqlparams.Add(pYptymc);
                }
                
                if (null != ypkc_djmxParamLike.Ddw && "" != ypkc_djmxParamLike.Ddw)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.DDW LIKE '%'||:ddw||'%' ");
                    OracleParameter pDdw = new OracleParameter(":ddw", OracleDbType.Varchar2);
                    pDdw.Direction = ParameterDirection.Input;
                    pDdw.Value = ypkc_djmxParamLike.Ddw;
                    sqlparams.Add(pDdw);
                }
                
                if (null != ypkc_djmxParamLike.Xdw && "" != ypkc_djmxParamLike.Xdw)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.XDW LIKE '%'||:xdw||'%' ");
                    OracleParameter pXdw = new OracleParameter(":xdw", OracleDbType.Varchar2);
                    pXdw.Direction = ParameterDirection.Input;
                    pXdw.Value = ypkc_djmxParamLike.Xdw;
                    sqlparams.Add(pXdw);
                }
                
                if (null != ypkc_djmxParamLike.Pzwh && "" != ypkc_djmxParamLike.Pzwh)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.PZWH LIKE '%'||:pzwh||'%' ");
                    OracleParameter pPzwh = new OracleParameter(":pzwh", OracleDbType.Varchar2);
                    pPzwh.Direction = ParameterDirection.Input;
                    pPzwh.Value = ypkc_djmxParamLike.Pzwh;
                    sqlparams.Add(pPzwh);
                }
                
                if (null != ypkc_djmxParamLike.Gyzz && "" != ypkc_djmxParamLike.Gyzz)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.GYZZ LIKE '%'||:gyzz||'%' ");
                    OracleParameter pGyzz = new OracleParameter(":gyzz", OracleDbType.Varchar2);
                    pGyzz.Direction = ParameterDirection.Input;
                    pGyzz.Value = ypkc_djmxParamLike.Gyzz;
                    sqlparams.Add(pGyzz);
                }
                
                if (null != ypkc_djmxParamLike.Jx && "" != ypkc_djmxParamLike.Jx)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.JX LIKE '%'||:jx||'%' ");
                    OracleParameter pJx = new OracleParameter(":jx", OracleDbType.NVarchar2);
                    pJx.Direction = ParameterDirection.Input;
                    pJx.Value = ypkc_djmxParamLike.Jx;
                    sqlparams.Add(pJx);
                }
                
                if (null != ypkc_djmxParamLike.Ypgg && "" != ypkc_djmxParamLike.Ypgg)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YPGG LIKE '%'||:ypgg||'%' ");
                    OracleParameter pYpgg = new OracleParameter(":ypgg", OracleDbType.NVarchar2);
                    pYpgg.Direction = ParameterDirection.Input;
                    pYpgg.Value = ypkc_djmxParamLike.Ypgg;
                    sqlparams.Add(pYpgg);
                }
                
                if (null != ypkc_djmxParamLike.Cjmc && "" != ypkc_djmxParamLike.Cjmc)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.CJMC LIKE '%'||:cjmc||'%' ");
                    OracleParameter pCjmc = new OracleParameter(":cjmc", OracleDbType.NVarchar2);
                    pCjmc.Direction = ParameterDirection.Input;
                    pCjmc.Value = ypkc_djmxParamLike.Cjmc;
                    sqlparams.Add(pCjmc);
                }
                
                if (null != ypkc_djmxParamLike.Pym && "" != ypkc_djmxParamLike.Pym)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.PYM LIKE '%'||:pym||'%' ");
                    OracleParameter pPym = new OracleParameter(":pym", OracleDbType.NVarchar2);
                    pPym.Direction = ParameterDirection.Input;
                    pPym.Value = ypkc_djmxParamLike.Pym;
                    sqlparams.Add(pPym);
                }
                
                if (null != ypkc_djmxParamLike.Ph && "" != ypkc_djmxParamLike.Ph)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.PH LIKE '%'||:ph||'%' ");
                    OracleParameter pPh = new OracleParameter(":ph", OracleDbType.Varchar2);
                    pPh.Direction = ParameterDirection.Input;
                    pPh.Value = ypkc_djmxParamLike.Ph;
                    sqlparams.Add(pPh);
                }
                
                if (null != ypkc_djmxParamLike.Zfbz && "" != ypkc_djmxParamLike.Zfbz)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.ZFBZ LIKE '%'||:zfbz||'%' ");
                    OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                    pZfbz.Direction = ParameterDirection.Input;
                    pZfbz.Value = ypkc_djmxParamLike.Zfbz;
                    sqlparams.Add(pZfbz);
                }
                
            }

            this.b_isWhere = false;
            this.addSort(sql, sortList);//排序
            //*******分页start1*********如果分页对象为空，则全部数据查出，如果不为空
            List<object> returnList = new List<object>();//返回的List,索引0为List<Ypkc_djmx>对象,索引1为Model.Common.PageInfo分页信息对象
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
            //把每一行数据转换为一个对象放入List<Ypkc_djmx>中
            for (int i = 0; i < rows.Count; i++)
            {
                DataRow row = rows[i];
                //ypkc_djmxParamList.Add(this.dataSetContactObjectsToModel(row));
                ypkc_djmxParamList.Add(this.dataSetToModel(row));
            }
            
             //*******分页start2*********如果没有传入分页对象，则新建一个分页对象当做返回值
            if (null == page)
            {
                page = new Model.Common.PageInfo();
                page.AllCount = rows.Count;
            }
            returnList.Add(ypkc_djmxParamList);//把List<Ypkc_djmx>放入List<object>中第一个
            returnList.Add(page);//把page对象放入List<object>中第二个
            //*******分页end2*********
            return returnList;
        }

        
        
        /// <summary>
        /// 根据条件得到集合的数量
        /// 第二个条件是模糊查询的条件
        /// </summary>
        /// <returns>int</returns>
        public int getCount(Ypkc_djmx ypkc_djmxParam,Ypkc_djmx ypkc_djmxParamLike)
        {
            //如果没有传查询条件参数，就new一个空的Ypkc_djmx对象，标示查询所有数据
            if (null == ypkc_djmxParam)
            {
                ypkc_djmxParam = new Ypkc_djmx();
            }
            List<OracleParameter> sqlparams = new List<OracleParameter>();//保存参数的集合
            StringBuilder sql = new StringBuilder("SELECT COUNT(ID) FROM YPKC_DJMX A");
            if (null != ypkc_djmxParam.Djh)
            {
                this.isComma(sql);
                sql.Append(" DJH=:djh ");
                OracleParameter pDjh = new OracleParameter(":djh", OracleDbType.Decimal);
                pDjh.Value = ypkc_djmxParam.Djh;
                sqlparams.Add(pDjh);

            }
                        
                if (null != ypkc_djmxParam.Fk_dj_id && "" != ypkc_djmxParam.Fk_dj_id)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.FK_DJ_ID=:fk_dj_id ");
                    OracleParameter pFk_dj_id = new OracleParameter(":fk_dj_id", OracleDbType.Varchar2);
                pFk_dj_id.Value = ypkc_djmxParam.Fk_dj_id;
                sqlparams.Add(pFk_dj_id);
                }
                
                if (null != ypkc_djmxParam.Fk_yp && "" != ypkc_djmxParam.Fk_yp)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.FK_YP=:fk_yp ");
                    OracleParameter pFk_yp = new OracleParameter(":fk_yp", OracleDbType.Varchar2);
                pFk_yp.Value = ypkc_djmxParam.Fk_yp;
                sqlparams.Add(pFk_yp);
                }
                
                if (null != ypkc_djmxParam.Ypbh && "" != ypkc_djmxParam.Ypbh)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YPBH=:ypbh ");
                    OracleParameter pYpbh = new OracleParameter(":ypbh", OracleDbType.Varchar2);
                pYpbh.Value = ypkc_djmxParam.Ypbh;
                sqlparams.Add(pYpbh);
                }
                
                if (null != ypkc_djmxParam.Ypmc && "" != ypkc_djmxParam.Ypmc)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YPMC=:ypmc ");
                    OracleParameter pYpmc = new OracleParameter(":ypmc", OracleDbType.Varchar2);
                pYpmc.Value = ypkc_djmxParam.Ypmc;
                sqlparams.Add(pYpmc);
                }
                
                if (null != ypkc_djmxParam.Yptymc && "" != ypkc_djmxParam.Yptymc)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YPTYMC=:yptymc ");
                    OracleParameter pYptymc = new OracleParameter(":yptymc", OracleDbType.NVarchar2);
                pYptymc.Value = ypkc_djmxParam.Yptymc;
                sqlparams.Add(pYptymc);
                }
                
                if (null != ypkc_djmxParam.Ddw && "" != ypkc_djmxParam.Ddw)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.DDW=:ddw ");
                    OracleParameter pDdw = new OracleParameter(":ddw", OracleDbType.Varchar2);
                pDdw.Value = ypkc_djmxParam.Ddw;
                sqlparams.Add(pDdw);
                }
                
                if (null != ypkc_djmxParam.Xdw && "" != ypkc_djmxParam.Xdw)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.XDW=:xdw ");
                    OracleParameter pXdw = new OracleParameter(":xdw", OracleDbType.Varchar2);
                pXdw.Value = ypkc_djmxParam.Xdw;
                sqlparams.Add(pXdw);
                }
                
            if (null != ypkc_djmxParam.Hsbl)
            {
                this.isComma(sql);
                sql.Append(" HSBL=:hsbl ");
                OracleParameter pHsbl = new OracleParameter(":hsbl", OracleDbType.Decimal);
                pHsbl.Value = ypkc_djmxParam.Hsbl;
                sqlparams.Add(pHsbl);

            }
                        
                if (null != ypkc_djmxParam.Pzwh && "" != ypkc_djmxParam.Pzwh)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.PZWH=:pzwh ");
                    OracleParameter pPzwh = new OracleParameter(":pzwh", OracleDbType.Varchar2);
                pPzwh.Value = ypkc_djmxParam.Pzwh;
                sqlparams.Add(pPzwh);
                }
                
                if (null != ypkc_djmxParam.Gyzz && "" != ypkc_djmxParam.Gyzz)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.GYZZ=:gyzz ");
                    OracleParameter pGyzz = new OracleParameter(":gyzz", OracleDbType.Varchar2);
                pGyzz.Value = ypkc_djmxParam.Gyzz;
                sqlparams.Add(pGyzz);
                }
                
                if (null != ypkc_djmxParam.Jx && "" != ypkc_djmxParam.Jx)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.JX=:jx ");
                    OracleParameter pJx = new OracleParameter(":jx", OracleDbType.NVarchar2);
                pJx.Value = ypkc_djmxParam.Jx;
                sqlparams.Add(pJx);
                }
                
                if (null != ypkc_djmxParam.Ypgg && "" != ypkc_djmxParam.Ypgg)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YPGG=:ypgg ");
                    OracleParameter pYpgg = new OracleParameter(":ypgg", OracleDbType.NVarchar2);
                pYpgg.Value = ypkc_djmxParam.Ypgg;
                sqlparams.Add(pYpgg);
                }
                
                if (null != ypkc_djmxParam.Cjmc && "" != ypkc_djmxParam.Cjmc)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.CJMC=:cjmc ");
                    OracleParameter pCjmc = new OracleParameter(":cjmc", OracleDbType.NVarchar2);
                pCjmc.Value = ypkc_djmxParam.Cjmc;
                sqlparams.Add(pCjmc);
                }
                
                if (null != ypkc_djmxParam.Pym && "" != ypkc_djmxParam.Pym)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.PYM=:pym ");
                    OracleParameter pPym = new OracleParameter(":pym", OracleDbType.NVarchar2);
                pPym.Value = ypkc_djmxParam.Pym;
                sqlparams.Add(pPym);
                }
                
                if (null != ypkc_djmxParam.Ph && "" != ypkc_djmxParam.Ph)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.PH=:ph ");
                    OracleParameter pPh = new OracleParameter(":ph", OracleDbType.Varchar2);
                pPh.Value = ypkc_djmxParam.Ph;
                sqlparams.Add(pPh);
                }
                
                if (DateTime.MinValue != ypkc_djmxParam.Yxq &&null != ypkc_djmxParam.Yxq)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YXQ=:yxq ");
                    OracleParameter pYxq = new OracleParameter(":yxq", OracleDbType.Date);
                pYxq.Value = ypkc_djmxParam.Yxq;
                sqlparams.Add(pYxq);
                }
                
            if (null != ypkc_djmxParam.Jj)
            {
                this.isComma(sql);
                sql.Append(" JJ=:jj ");
                OracleParameter pJj = new OracleParameter(":jj", OracleDbType.Decimal);
                pJj.Value = ypkc_djmxParam.Jj;
                sqlparams.Add(pJj);

            }
                        
            if (null != ypkc_djmxParam.Lsj)
            {
                this.isComma(sql);
                sql.Append(" LSJ=:lsj ");
                OracleParameter pLsj = new OracleParameter(":lsj", OracleDbType.Decimal);
                pLsj.Value = ypkc_djmxParam.Lsj;
                sqlparams.Add(pLsj);

            }
                        
            if (null != ypkc_djmxParam.Sl)
            {
                this.isComma(sql);
                sql.Append(" SL=:sl ");
                OracleParameter pSl = new OracleParameter(":sl", OracleDbType.Decimal);
                pSl.Value = ypkc_djmxParam.Sl;
                sqlparams.Add(pSl);

            }
                        
            if (null != ypkc_djmxParam.Jjje)
            {
                this.isComma(sql);
                sql.Append(" JJJE=:jjje ");
                OracleParameter pJjje = new OracleParameter(":jjje", OracleDbType.Decimal);
                pJjje.Value = ypkc_djmxParam.Jjje;
                sqlparams.Add(pJjje);

            }
                        
            if (null != ypkc_djmxParam.Lsjje)
            {
                this.isComma(sql);
                sql.Append(" LSJJE=:lsjje ");
                OracleParameter pLsjje = new OracleParameter(":lsjje", OracleDbType.Decimal);
                pLsjje.Value = ypkc_djmxParam.Lsjje;
                sqlparams.Add(pLsjje);

            }
                        
                if (null != ypkc_djmxParam.Zfbz && "" != ypkc_djmxParam.Zfbz)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.ZFBZ=:zfbz ");
                    OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                pZfbz.Value = ypkc_djmxParam.Zfbz;
                sqlparams.Add(pZfbz);
                }
                
            if(ypkc_djmxParamLike!=null)
            {

                if (null != ypkc_djmxParamLike.Fk_dj_id && "" != ypkc_djmxParamLike.Fk_dj_id)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.FK_DJ_ID LIKE '%'||:fk_dj_id||'%' ");
                    OracleParameter pFk_dj_id = new OracleParameter(":fk_dj_id", OracleDbType.Varchar2);
                    pFk_dj_id.Direction = ParameterDirection.Input;
                    pFk_dj_id.Value = ypkc_djmxParamLike.Fk_dj_id;
                    sqlparams.Add(pFk_dj_id);
                }
                
                if (null != ypkc_djmxParamLike.Fk_yp && "" != ypkc_djmxParamLike.Fk_yp)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.FK_YP LIKE '%'||:fk_yp||'%' ");
                    OracleParameter pFk_yp = new OracleParameter(":fk_yp", OracleDbType.Varchar2);
                    pFk_yp.Direction = ParameterDirection.Input;
                    pFk_yp.Value = ypkc_djmxParamLike.Fk_yp;
                    sqlparams.Add(pFk_yp);
                }
                
                if (null != ypkc_djmxParamLike.Ypbh && "" != ypkc_djmxParamLike.Ypbh)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YPBH LIKE '%'||:ypbh||'%' ");
                    OracleParameter pYpbh = new OracleParameter(":ypbh", OracleDbType.Varchar2);
                    pYpbh.Direction = ParameterDirection.Input;
                    pYpbh.Value = ypkc_djmxParamLike.Ypbh;
                    sqlparams.Add(pYpbh);
                }
                
                if (null != ypkc_djmxParamLike.Ypmc && "" != ypkc_djmxParamLike.Ypmc)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YPMC LIKE '%'||:ypmc||'%' ");
                    OracleParameter pYpmc = new OracleParameter(":ypmc", OracleDbType.Varchar2);
                    pYpmc.Direction = ParameterDirection.Input;
                    pYpmc.Value = ypkc_djmxParamLike.Ypmc;
                    sqlparams.Add(pYpmc);
                }
                
                if (null != ypkc_djmxParamLike.Yptymc && "" != ypkc_djmxParamLike.Yptymc)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YPTYMC LIKE '%'||:yptymc||'%' ");
                    OracleParameter pYptymc = new OracleParameter(":yptymc", OracleDbType.NVarchar2);
                    pYptymc.Direction = ParameterDirection.Input;
                    pYptymc.Value = ypkc_djmxParamLike.Yptymc;
                    sqlparams.Add(pYptymc);
                }
                
                if (null != ypkc_djmxParamLike.Ddw && "" != ypkc_djmxParamLike.Ddw)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.DDW LIKE '%'||:ddw||'%' ");
                    OracleParameter pDdw = new OracleParameter(":ddw", OracleDbType.Varchar2);
                    pDdw.Direction = ParameterDirection.Input;
                    pDdw.Value = ypkc_djmxParamLike.Ddw;
                    sqlparams.Add(pDdw);
                }
                
                if (null != ypkc_djmxParamLike.Xdw && "" != ypkc_djmxParamLike.Xdw)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.XDW LIKE '%'||:xdw||'%' ");
                    OracleParameter pXdw = new OracleParameter(":xdw", OracleDbType.Varchar2);
                    pXdw.Direction = ParameterDirection.Input;
                    pXdw.Value = ypkc_djmxParamLike.Xdw;
                    sqlparams.Add(pXdw);
                }
                
                if (null != ypkc_djmxParamLike.Pzwh && "" != ypkc_djmxParamLike.Pzwh)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.PZWH LIKE '%'||:pzwh||'%' ");
                    OracleParameter pPzwh = new OracleParameter(":pzwh", OracleDbType.Varchar2);
                    pPzwh.Direction = ParameterDirection.Input;
                    pPzwh.Value = ypkc_djmxParamLike.Pzwh;
                    sqlparams.Add(pPzwh);
                }
                
                if (null != ypkc_djmxParamLike.Gyzz && "" != ypkc_djmxParamLike.Gyzz)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.GYZZ LIKE '%'||:gyzz||'%' ");
                    OracleParameter pGyzz = new OracleParameter(":gyzz", OracleDbType.Varchar2);
                    pGyzz.Direction = ParameterDirection.Input;
                    pGyzz.Value = ypkc_djmxParamLike.Gyzz;
                    sqlparams.Add(pGyzz);
                }
                
                if (null != ypkc_djmxParamLike.Jx && "" != ypkc_djmxParamLike.Jx)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.JX LIKE '%'||:jx||'%' ");
                    OracleParameter pJx = new OracleParameter(":jx", OracleDbType.NVarchar2);
                    pJx.Direction = ParameterDirection.Input;
                    pJx.Value = ypkc_djmxParamLike.Jx;
                    sqlparams.Add(pJx);
                }
                
                if (null != ypkc_djmxParamLike.Ypgg && "" != ypkc_djmxParamLike.Ypgg)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YPGG LIKE '%'||:ypgg||'%' ");
                    OracleParameter pYpgg = new OracleParameter(":ypgg", OracleDbType.NVarchar2);
                    pYpgg.Direction = ParameterDirection.Input;
                    pYpgg.Value = ypkc_djmxParamLike.Ypgg;
                    sqlparams.Add(pYpgg);
                }
                
                if (null != ypkc_djmxParamLike.Cjmc && "" != ypkc_djmxParamLike.Cjmc)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.CJMC LIKE '%'||:cjmc||'%' ");
                    OracleParameter pCjmc = new OracleParameter(":cjmc", OracleDbType.NVarchar2);
                    pCjmc.Direction = ParameterDirection.Input;
                    pCjmc.Value = ypkc_djmxParamLike.Cjmc;
                    sqlparams.Add(pCjmc);
                }
                
                if (null != ypkc_djmxParamLike.Pym && "" != ypkc_djmxParamLike.Pym)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.PYM LIKE '%'||:pym||'%' ");
                    OracleParameter pPym = new OracleParameter(":pym", OracleDbType.NVarchar2);
                    pPym.Direction = ParameterDirection.Input;
                    pPym.Value = ypkc_djmxParamLike.Pym;
                    sqlparams.Add(pPym);
                }
                
                if (null != ypkc_djmxParamLike.Ph && "" != ypkc_djmxParamLike.Ph)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.PH LIKE '%'||:ph||'%' ");
                    OracleParameter pPh = new OracleParameter(":ph", OracleDbType.Varchar2);
                    pPh.Direction = ParameterDirection.Input;
                    pPh.Value = ypkc_djmxParamLike.Ph;
                    sqlparams.Add(pPh);
                }
                
                if (null != ypkc_djmxParamLike.Zfbz && "" != ypkc_djmxParamLike.Zfbz)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.ZFBZ LIKE '%'||:zfbz||'%' ");
                    OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                    pZfbz.Direction = ParameterDirection.Input;
                    pZfbz.Value = ypkc_djmxParamLike.Zfbz;
                    sqlparams.Add(pZfbz);
                }
                
            }

            this.b_isWhere = false;
            return Int32.Parse(OracleHelper.ExecuteScalar(sql.ToString(),sqlparams.ToArray()).ToString());
        }


        /// <summary>
        /// 通用的保存方法，根据用户传入的参数，有ID为修改，没有ID为新增(手动生成OracleConnection对象，此方法用于事务，使用事务必须使用同一个OracleConnection对象)
        /// </summary>
        /// <param name="ypkc_djmxParam"></param>
        /// <returns></returns>
        public bool save(Ypkc_djmx ypkc_djmxParam,OracleConnection con)
        {
            if ("" != ypkc_djmxParam.Id && null != ypkc_djmxParam.Id)
            {
                //修改
                return this.updateById(ypkc_djmxParam,con);
            }
            else
            {
                //新增
                return this.insert(ypkc_djmxParam,con);
            }
        }

        /// <summary>
        /// 把dataset中的一行转换为model
        /// </summary>
        /// <param name="row"></param>
        /// <returns></returns>
        private Ypkc_djmx dataSetToModel(DataRow row)
        {
            Ypkc_djmx ypkc_djmxParam = new Ypkc_djmx();
            ypkc_djmxParam.Id = Convert.ToString(row["ID"]).Trim(); 
            ypkc_djmxParam.Djh =  (decimal?)this.convertDBNullValue(row["DJH"]);
            ypkc_djmxParam.Fk_dj_id = Convert.ToString(row["FK_DJ_ID"]).Trim(); 
            ypkc_djmxParam.Fk_yp = Convert.ToString(row["FK_YP"]).Trim(); 
            ypkc_djmxParam.Ypbh = Convert.ToString(row["YPBH"]).Trim(); 
            ypkc_djmxParam.Ypmc = Convert.ToString(row["YPMC"]).Trim(); 
            ypkc_djmxParam.Yptymc = Convert.ToString(row["YPTYMC"]).Trim(); 
            ypkc_djmxParam.Ddw = Convert.ToString(row["DDW"]).Trim(); 
            ypkc_djmxParam.Xdw = Convert.ToString(row["XDW"]).Trim(); 
            ypkc_djmxParam.Hsbl =  (decimal?)this.convertDBNullValue(row["HSBL"]);
            ypkc_djmxParam.Pzwh = Convert.ToString(row["PZWH"]).Trim(); 
            ypkc_djmxParam.Gyzz = Convert.ToString(row["GYZZ"]).Trim(); 
            ypkc_djmxParam.Jx = Convert.ToString(row["JX"]).Trim(); 
            ypkc_djmxParam.Ypgg = Convert.ToString(row["YPGG"]).Trim(); 
            ypkc_djmxParam.Cjmc = Convert.ToString(row["CJMC"]).Trim(); 
            ypkc_djmxParam.Pym = Convert.ToString(row["PYM"]).Trim(); 
            ypkc_djmxParam.Ph = Convert.ToString(row["PH"]).Trim(); 
            ypkc_djmxParam.Yxq =  (DateTime?)this.convertDBNullValue(row["YXQ"]);
            ypkc_djmxParam.Jj =  (decimal?)this.convertDBNullValue(row["JJ"]);
            ypkc_djmxParam.Lsj =  (decimal?)this.convertDBNullValue(row["LSJ"]);
            ypkc_djmxParam.Sl =  (decimal?)this.convertDBNullValue(row["SL"]);
            ypkc_djmxParam.Jjje =  (decimal?)this.convertDBNullValue(row["JJJE"]);
            ypkc_djmxParam.Lsjje =  (decimal?)this.convertDBNullValue(row["LSJJE"]);
            ypkc_djmxParam.Zfbz = Convert.ToString(row["ZFBZ"]).Trim(); 
            
            return ypkc_djmxParam;
        }

       
        
        //*******************在此以后添加新的方法start

        //*******************在此以后添加新的方法end
        
    }
}


