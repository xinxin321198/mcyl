

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

namespace DAL.JC.基础_诊疗项目管理
{
    /// <summary>
    ///数据库访问层的Jc_zlxm实现类
    ///此类由代码生成器生成
    ///表名：JC_ZLXM
    ///生成日期：2015/12/16 13:35:40
    /// 

    ///作者：罗新鑫
    ///联系电话：15087010221
    ///联系邮箱：362527240@qq.com
        
    /// </summary>
    public class Jc_zlxmDALImp :Base.BasDAL,Jc_zlxmDAL
    {

        /// <summary>
        /// 插入一条数据（如果需要供事务使用就传入OracleConnection对象，如果不供就传入null，方法自动生成OracleConnection对象）
        /// 主键为null时，自动生成主键guid，一般不直接调用此方法，请调用save方法进行单条数据的插入和修改       
        /// </summary>
        /// <param name="jc_zlxmParam">要插入的jc_zlxmParam对象</param>
        /// <param name="con">Oracle连接对象（为null时自动生成）</param>
        /// <returns>是否添加成功（影响的行数为1时成功）</returns>
        public bool insert(Jc_zlxm jc_zlxmParam,OracleConnection con)
        {
            if (""==jc_zlxmParam.Id||null==jc_zlxmParam.Id)
            {
                jc_zlxmParam.Id = Model.Common.GUIDHelper.getGuid();
            }
            List<OracleParameter> sqlparams = new List<OracleParameter>();
            
            StringBuilder sql = new StringBuilder("INSERT INTO JC_ZLXM(id,xmbh,xmmc,dw,dj,zgxj,fl_code,fygl_code,pym,wbm,szm,xmnr,cwnr,note,jcff,biaozhuan,jinjian,yinji,gbsj,gbjg,ybbm,nhbm,nhsflb_code,zfbz) VALUES(:id,:xmbh,:xmmc,:dw,:dj,:zgxj,:fl_code,:fygl_code,:pym,:wbm,:szm,:xmnr,:cwnr,:note,:jcff,:biaozhuan,:jinjian,:yinji,:gbsj,:gbjg,:ybbm,:nhbm,:nhsflb_code,:zfbz)");
            
            OracleParameter pId = new OracleParameter(":id", OracleDbType.Varchar2);
            pId.Direction = ParameterDirection.Input;
            pId.Value = jc_zlxmParam.Id;
            sqlparams.Add(pId);
            OracleParameter pXmbh = new OracleParameter(":xmbh", OracleDbType.NVarchar2);
            pXmbh.Direction = ParameterDirection.Input;
            pXmbh.Value = jc_zlxmParam.Xmbh;
            sqlparams.Add(pXmbh);
            OracleParameter pXmmc = new OracleParameter(":xmmc", OracleDbType.NVarchar2);
            pXmmc.Direction = ParameterDirection.Input;
            pXmmc.Value = jc_zlxmParam.Xmmc;
            sqlparams.Add(pXmmc);
            OracleParameter pDw = new OracleParameter(":dw", OracleDbType.NVarchar2);
            pDw.Direction = ParameterDirection.Input;
            pDw.Value = jc_zlxmParam.Dw;
            sqlparams.Add(pDw);
            OracleParameter pDj = new OracleParameter(":dj", OracleDbType.Decimal);
            pDj.Direction = ParameterDirection.Input;
            pDj.Value = jc_zlxmParam.Dj;
            sqlparams.Add(pDj);
            OracleParameter pZgxj = new OracleParameter(":zgxj", OracleDbType.Decimal);
            pZgxj.Direction = ParameterDirection.Input;
            pZgxj.Value = jc_zlxmParam.Zgxj;
            sqlparams.Add(pZgxj);
            OracleParameter pFl_code = new OracleParameter(":fl_code", OracleDbType.NVarchar2);
            pFl_code.Direction = ParameterDirection.Input;
            pFl_code.Value = jc_zlxmParam.Fl_code;
            sqlparams.Add(pFl_code);
            OracleParameter pFygl_code = new OracleParameter(":fygl_code", OracleDbType.NVarchar2);
            pFygl_code.Direction = ParameterDirection.Input;
            pFygl_code.Value = jc_zlxmParam.Fygl_code;
            sqlparams.Add(pFygl_code);
            OracleParameter pPym = new OracleParameter(":pym", OracleDbType.NVarchar2);
            pPym.Direction = ParameterDirection.Input;
            pPym.Value = jc_zlxmParam.Pym;
            sqlparams.Add(pPym);
            OracleParameter pWbm = new OracleParameter(":wbm", OracleDbType.NVarchar2);
            pWbm.Direction = ParameterDirection.Input;
            pWbm.Value = jc_zlxmParam.Wbm;
            sqlparams.Add(pWbm);
            OracleParameter pSzm = new OracleParameter(":szm", OracleDbType.NVarchar2);
            pSzm.Direction = ParameterDirection.Input;
            pSzm.Value = jc_zlxmParam.Szm;
            sqlparams.Add(pSzm);
            OracleParameter pXmnr = new OracleParameter(":xmnr", OracleDbType.NVarchar2);
            pXmnr.Direction = ParameterDirection.Input;
            pXmnr.Value = jc_zlxmParam.Xmnr;
            sqlparams.Add(pXmnr);
            OracleParameter pCwnr = new OracleParameter(":cwnr", OracleDbType.NVarchar2);
            pCwnr.Direction = ParameterDirection.Input;
            pCwnr.Value = jc_zlxmParam.Cwnr;
            sqlparams.Add(pCwnr);
            OracleParameter pNote = new OracleParameter(":note", OracleDbType.NVarchar2);
            pNote.Direction = ParameterDirection.Input;
            pNote.Value = jc_zlxmParam.Note;
            sqlparams.Add(pNote);
            OracleParameter pJcff = new OracleParameter(":jcff", OracleDbType.NVarchar2);
            pJcff.Direction = ParameterDirection.Input;
            pJcff.Value = jc_zlxmParam.Jcff;
            sqlparams.Add(pJcff);
            OracleParameter pBiaozhuan = new OracleParameter(":biaozhuan", OracleDbType.NVarchar2);
            pBiaozhuan.Direction = ParameterDirection.Input;
            pBiaozhuan.Value = jc_zlxmParam.Biaozhuan;
            sqlparams.Add(pBiaozhuan);
            OracleParameter pJinjian = new OracleParameter(":jinjian", OracleDbType.NVarchar2);
            pJinjian.Direction = ParameterDirection.Input;
            pJinjian.Value = jc_zlxmParam.Jinjian;
            sqlparams.Add(pJinjian);
            OracleParameter pYinji = new OracleParameter(":yinji", OracleDbType.NVarchar2);
            pYinji.Direction = ParameterDirection.Input;
            pYinji.Value = jc_zlxmParam.Yinji;
            sqlparams.Add(pYinji);
            OracleParameter pGbsj = new OracleParameter(":gbsj", OracleDbType.Date);
            pGbsj.Direction = ParameterDirection.Input;
            pGbsj.Value = jc_zlxmParam.Gbsj;
            sqlparams.Add(pGbsj);
            OracleParameter pGbjg = new OracleParameter(":gbjg", OracleDbType.NVarchar2);
            pGbjg.Direction = ParameterDirection.Input;
            pGbjg.Value = jc_zlxmParam.Gbjg;
            sqlparams.Add(pGbjg);
            OracleParameter pYbbm = new OracleParameter(":ybbm", OracleDbType.NVarchar2);
            pYbbm.Direction = ParameterDirection.Input;
            pYbbm.Value = jc_zlxmParam.Ybbm;
            sqlparams.Add(pYbbm);
            OracleParameter pNhbm = new OracleParameter(":nhbm", OracleDbType.NVarchar2);
            pNhbm.Direction = ParameterDirection.Input;
            pNhbm.Value = jc_zlxmParam.Nhbm;
            sqlparams.Add(pNhbm);
            OracleParameter pNhsflb_code = new OracleParameter(":nhsflb_code", OracleDbType.NVarchar2);
            pNhsflb_code.Direction = ParameterDirection.Input;
            pNhsflb_code.Value = jc_zlxmParam.Nhsflb_code;
            sqlparams.Add(pNhsflb_code);
            OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
            pZfbz.Direction = ParameterDirection.Input;
            pZfbz.Value = jc_zlxmParam.Zfbz;
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
        /// <param name="jc_zlxmParamList">要插入的jc_zlxmParam对象的集合</param>
        /// <param name="con">Oracle连接对象（为null时自动生成）</param>
        /// <returns>是否添加成功（影响的行数等于保存的对象的数量时成功）</returns>
        public bool inertBatch(List<Jc_zlxm> jc_zlxmParamList, OracleConnection con)
        {
            if (jc_zlxmParamList.Count == 0)
            {
                return true;
            }
            List<string> idList = new List<string>();

            List<string> xmbhList = new List<string>();

            List<string> xmmcList = new List<string>();

            List<string> dwList = new List<string>();

            List<decimal?> djList = new List<decimal?>();

            List<decimal?> zgxjList = new List<decimal?>();

            List<string> fl_codeList = new List<string>();

            List<string> fygl_codeList = new List<string>();

            List<string> pymList = new List<string>();

            List<string> wbmList = new List<string>();

            List<string> szmList = new List<string>();

            List<string> xmnrList = new List<string>();

            List<string> cwnrList = new List<string>();

            List<string> noteList = new List<string>();

            List<string> jcffList = new List<string>();

            List<string> biaozhuanList = new List<string>();

            List<string> jinjianList = new List<string>();

            List<string> yinjiList = new List<string>();

            List<DateTime?> gbsjList = new List<DateTime?>();

            List<string> gbjgList = new List<string>();

            List<string> ybbmList = new List<string>();

            List<string> nhbmList = new List<string>();

            List<string> nhsflb_codeList = new List<string>();

            List<string> zfbzList = new List<string>();

            for (int i = 0; i < jc_zlxmParamList.Count; i++)
            {
                Jc_zlxm jc_zlxmParam = jc_zlxmParamList[i];
                if ("" == jc_zlxmParam.Id || null == jc_zlxmParam.Id)
                {
                    jc_zlxmParam.Id = Model.Common.GUIDHelper.getGuid();
                }

            idList.Add(jc_zlxmParam.Id);

            xmbhList.Add(jc_zlxmParam.Xmbh);

            xmmcList.Add(jc_zlxmParam.Xmmc);

            dwList.Add(jc_zlxmParam.Dw);

            djList.Add(jc_zlxmParam.Dj);

            zgxjList.Add(jc_zlxmParam.Zgxj);

            fl_codeList.Add(jc_zlxmParam.Fl_code);

            fygl_codeList.Add(jc_zlxmParam.Fygl_code);

            pymList.Add(jc_zlxmParam.Pym);

            wbmList.Add(jc_zlxmParam.Wbm);

            szmList.Add(jc_zlxmParam.Szm);

            xmnrList.Add(jc_zlxmParam.Xmnr);

            cwnrList.Add(jc_zlxmParam.Cwnr);

            noteList.Add(jc_zlxmParam.Note);

            jcffList.Add(jc_zlxmParam.Jcff);

            biaozhuanList.Add(jc_zlxmParam.Biaozhuan);

            jinjianList.Add(jc_zlxmParam.Jinjian);

            yinjiList.Add(jc_zlxmParam.Yinji);

            gbsjList.Add(jc_zlxmParam.Gbsj);

            gbjgList.Add(jc_zlxmParam.Gbjg);

            ybbmList.Add(jc_zlxmParam.Ybbm);

            nhbmList.Add(jc_zlxmParam.Nhbm);

            nhsflb_codeList.Add(jc_zlxmParam.Nhsflb_code);

            zfbzList.Add(jc_zlxmParam.Zfbz);

            }

            List<OracleParameter> sqlparams = new List<OracleParameter>();

            StringBuilder sql = new StringBuilder("INSERT INTO JC_ZLXM(id,xmbh,xmmc,dw,dj,zgxj,fl_code,fygl_code,pym,wbm,szm,xmnr,cwnr,note,jcff,biaozhuan,jinjian,yinji,gbsj,gbjg,ybbm,nhbm,nhsflb_code,zfbz) VALUES(:id,:xmbh,:xmmc,:dw,:dj,:zgxj,:fl_code,:fygl_code,:pym,:wbm,:szm,:xmnr,:cwnr,:note,:jcff,:biaozhuan,:jinjian,:yinji,:gbsj,:gbjg,:ybbm,:nhbm,:nhsflb_code,:zfbz)");
            
            OracleParameter pId = new OracleParameter(":id", OracleDbType.Varchar2);
            pId.Direction = ParameterDirection.Input;
            pId.Value = idList.ToArray();
            sqlparams.Add(pId);
            OracleParameter pXmbh = new OracleParameter(":xmbh", OracleDbType.NVarchar2);
            pXmbh.Direction = ParameterDirection.Input;
            pXmbh.Value = xmbhList.ToArray();
            sqlparams.Add(pXmbh);
            OracleParameter pXmmc = new OracleParameter(":xmmc", OracleDbType.NVarchar2);
            pXmmc.Direction = ParameterDirection.Input;
            pXmmc.Value = xmmcList.ToArray();
            sqlparams.Add(pXmmc);
            OracleParameter pDw = new OracleParameter(":dw", OracleDbType.NVarchar2);
            pDw.Direction = ParameterDirection.Input;
            pDw.Value = dwList.ToArray();
            sqlparams.Add(pDw);
            OracleParameter pDj = new OracleParameter(":dj", OracleDbType.Decimal);
            pDj.Direction = ParameterDirection.Input;
            pDj.Value = djList.ToArray();
            sqlparams.Add(pDj);
            OracleParameter pZgxj = new OracleParameter(":zgxj", OracleDbType.Decimal);
            pZgxj.Direction = ParameterDirection.Input;
            pZgxj.Value = zgxjList.ToArray();
            sqlparams.Add(pZgxj);
            OracleParameter pFl_code = new OracleParameter(":fl_code", OracleDbType.NVarchar2);
            pFl_code.Direction = ParameterDirection.Input;
            pFl_code.Value = fl_codeList.ToArray();
            sqlparams.Add(pFl_code);
            OracleParameter pFygl_code = new OracleParameter(":fygl_code", OracleDbType.NVarchar2);
            pFygl_code.Direction = ParameterDirection.Input;
            pFygl_code.Value = fygl_codeList.ToArray();
            sqlparams.Add(pFygl_code);
            OracleParameter pPym = new OracleParameter(":pym", OracleDbType.NVarchar2);
            pPym.Direction = ParameterDirection.Input;
            pPym.Value = pymList.ToArray();
            sqlparams.Add(pPym);
            OracleParameter pWbm = new OracleParameter(":wbm", OracleDbType.NVarchar2);
            pWbm.Direction = ParameterDirection.Input;
            pWbm.Value = wbmList.ToArray();
            sqlparams.Add(pWbm);
            OracleParameter pSzm = new OracleParameter(":szm", OracleDbType.NVarchar2);
            pSzm.Direction = ParameterDirection.Input;
            pSzm.Value = szmList.ToArray();
            sqlparams.Add(pSzm);
            OracleParameter pXmnr = new OracleParameter(":xmnr", OracleDbType.NVarchar2);
            pXmnr.Direction = ParameterDirection.Input;
            pXmnr.Value = xmnrList.ToArray();
            sqlparams.Add(pXmnr);
            OracleParameter pCwnr = new OracleParameter(":cwnr", OracleDbType.NVarchar2);
            pCwnr.Direction = ParameterDirection.Input;
            pCwnr.Value = cwnrList.ToArray();
            sqlparams.Add(pCwnr);
            OracleParameter pNote = new OracleParameter(":note", OracleDbType.NVarchar2);
            pNote.Direction = ParameterDirection.Input;
            pNote.Value = noteList.ToArray();
            sqlparams.Add(pNote);
            OracleParameter pJcff = new OracleParameter(":jcff", OracleDbType.NVarchar2);
            pJcff.Direction = ParameterDirection.Input;
            pJcff.Value = jcffList.ToArray();
            sqlparams.Add(pJcff);
            OracleParameter pBiaozhuan = new OracleParameter(":biaozhuan", OracleDbType.NVarchar2);
            pBiaozhuan.Direction = ParameterDirection.Input;
            pBiaozhuan.Value = biaozhuanList.ToArray();
            sqlparams.Add(pBiaozhuan);
            OracleParameter pJinjian = new OracleParameter(":jinjian", OracleDbType.NVarchar2);
            pJinjian.Direction = ParameterDirection.Input;
            pJinjian.Value = jinjianList.ToArray();
            sqlparams.Add(pJinjian);
            OracleParameter pYinji = new OracleParameter(":yinji", OracleDbType.NVarchar2);
            pYinji.Direction = ParameterDirection.Input;
            pYinji.Value = yinjiList.ToArray();
            sqlparams.Add(pYinji);
            OracleParameter pGbsj = new OracleParameter(":gbsj", OracleDbType.Date);
            pGbsj.Direction = ParameterDirection.Input;
            pGbsj.Value = gbsjList.ToArray();
            sqlparams.Add(pGbsj);
            OracleParameter pGbjg = new OracleParameter(":gbjg", OracleDbType.NVarchar2);
            pGbjg.Direction = ParameterDirection.Input;
            pGbjg.Value = gbjgList.ToArray();
            sqlparams.Add(pGbjg);
            OracleParameter pYbbm = new OracleParameter(":ybbm", OracleDbType.NVarchar2);
            pYbbm.Direction = ParameterDirection.Input;
            pYbbm.Value = ybbmList.ToArray();
            sqlparams.Add(pYbbm);
            OracleParameter pNhbm = new OracleParameter(":nhbm", OracleDbType.NVarchar2);
            pNhbm.Direction = ParameterDirection.Input;
            pNhbm.Value = nhbmList.ToArray();
            sqlparams.Add(pNhbm);
            OracleParameter pNhsflb_code = new OracleParameter(":nhsflb_code", OracleDbType.NVarchar2);
            pNhsflb_code.Direction = ParameterDirection.Input;
            pNhsflb_code.Value = nhsflb_codeList.ToArray();
            sqlparams.Add(pNhsflb_code);
            OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
            pZfbz.Direction = ParameterDirection.Input;
            pZfbz.Value = zfbzList.ToArray();
            sqlparams.Add(pZfbz);
            bool result = false;
            int flag = -1;
            flag = OracleHelper.ExecuteBatch(sql.ToString(), con, jc_zlxmParamList.Count, sqlparams.ToArray());
            if (jc_zlxmParamList.Count == flag)
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
            StringBuilder sql = new StringBuilder("DELETE JC_ZLXM WHERE ID=:id");
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
            StringBuilder sql = new StringBuilder("DELETE JC_ZLXM WHERE ID=:id");
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
        /// <param name="jc_zlxmParamCondition">删除的条件</param>
        /// <param name="con">Oracle连接对象（为null时自动生成）</param>
        /// <returns>无法确定删除的行数（影响行数大于等于0就算成功）</returns>
        public bool deleteByOtherCondition(Jc_zlxm jc_zlxmParamCondition, OracleConnection con)
        {
            if (null!=jc_zlxmParamCondition.Id&&""!=jc_zlxmParamCondition.Id)
            {
                throw new Exception("不允许指定参数的ID，如果要根据ID删除数据请调用deleteById或者deleteByIdBatch方法；错误出自：deleteByOtherCondition");
            }
            List<OracleParameter> sqlparams = new List<OracleParameter>();
            StringBuilder sql = new StringBuilder("DELETE JC_ZLXM ");

            if (null != jc_zlxmParamCondition.Xmbh &&  ""!= jc_zlxmParamCondition.Xmbh)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" XMBH=:xmbh ");
                OracleParameter pXmbh = new OracleParameter(":xmbh", OracleDbType.NVarchar2);
                pXmbh.Direction = ParameterDirection.Input;
                pXmbh.Value = jc_zlxmParamCondition.Xmbh;
                sqlparams.Add(pXmbh);

            }
                        
            if (null != jc_zlxmParamCondition.Xmmc &&  ""!= jc_zlxmParamCondition.Xmmc)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" XMMC=:xmmc ");
                OracleParameter pXmmc = new OracleParameter(":xmmc", OracleDbType.NVarchar2);
                pXmmc.Direction = ParameterDirection.Input;
                pXmmc.Value = jc_zlxmParamCondition.Xmmc;
                sqlparams.Add(pXmmc);

            }
                        
            if (null != jc_zlxmParamCondition.Dw &&  ""!= jc_zlxmParamCondition.Dw)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" DW=:dw ");
                OracleParameter pDw = new OracleParameter(":dw", OracleDbType.NVarchar2);
                pDw.Direction = ParameterDirection.Input;
                pDw.Value = jc_zlxmParamCondition.Dw;
                sqlparams.Add(pDw);

            }
                        
            if (null != jc_zlxmParamCondition.Dj)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" DJ=:dj ");
                OracleParameter pDj = new OracleParameter(":dj", OracleDbType.Decimal);
                pDj.Direction = ParameterDirection.Input;
                pDj.Value = jc_zlxmParamCondition.Dj;
                sqlparams.Add(pDj);

            }
                        
            if (null != jc_zlxmParamCondition.Zgxj)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" ZGXJ=:zgxj ");
                OracleParameter pZgxj = new OracleParameter(":zgxj", OracleDbType.Decimal);
                pZgxj.Direction = ParameterDirection.Input;
                pZgxj.Value = jc_zlxmParamCondition.Zgxj;
                sqlparams.Add(pZgxj);

            }
                        
            if (null != jc_zlxmParamCondition.Fl_code &&  ""!= jc_zlxmParamCondition.Fl_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" FL_CODE=:fl_code ");
                OracleParameter pFl_code = new OracleParameter(":fl_code", OracleDbType.NVarchar2);
                pFl_code.Direction = ParameterDirection.Input;
                pFl_code.Value = jc_zlxmParamCondition.Fl_code;
                sqlparams.Add(pFl_code);

            }
                        
            if (null != jc_zlxmParamCondition.Fygl_code &&  ""!= jc_zlxmParamCondition.Fygl_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" FYGL_CODE=:fygl_code ");
                OracleParameter pFygl_code = new OracleParameter(":fygl_code", OracleDbType.NVarchar2);
                pFygl_code.Direction = ParameterDirection.Input;
                pFygl_code.Value = jc_zlxmParamCondition.Fygl_code;
                sqlparams.Add(pFygl_code);

            }
                        
            if (null != jc_zlxmParamCondition.Pym &&  ""!= jc_zlxmParamCondition.Pym)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" PYM=:pym ");
                OracleParameter pPym = new OracleParameter(":pym", OracleDbType.NVarchar2);
                pPym.Direction = ParameterDirection.Input;
                pPym.Value = jc_zlxmParamCondition.Pym;
                sqlparams.Add(pPym);

            }
                        
            if (null != jc_zlxmParamCondition.Wbm &&  ""!= jc_zlxmParamCondition.Wbm)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" WBM=:wbm ");
                OracleParameter pWbm = new OracleParameter(":wbm", OracleDbType.NVarchar2);
                pWbm.Direction = ParameterDirection.Input;
                pWbm.Value = jc_zlxmParamCondition.Wbm;
                sqlparams.Add(pWbm);

            }
                        
            if (null != jc_zlxmParamCondition.Szm &&  ""!= jc_zlxmParamCondition.Szm)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" SZM=:szm ");
                OracleParameter pSzm = new OracleParameter(":szm", OracleDbType.NVarchar2);
                pSzm.Direction = ParameterDirection.Input;
                pSzm.Value = jc_zlxmParamCondition.Szm;
                sqlparams.Add(pSzm);

            }
                        
            if (null != jc_zlxmParamCondition.Xmnr &&  ""!= jc_zlxmParamCondition.Xmnr)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" XMNR=:xmnr ");
                OracleParameter pXmnr = new OracleParameter(":xmnr", OracleDbType.NVarchar2);
                pXmnr.Direction = ParameterDirection.Input;
                pXmnr.Value = jc_zlxmParamCondition.Xmnr;
                sqlparams.Add(pXmnr);

            }
                        
            if (null != jc_zlxmParamCondition.Cwnr &&  ""!= jc_zlxmParamCondition.Cwnr)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" CWNR=:cwnr ");
                OracleParameter pCwnr = new OracleParameter(":cwnr", OracleDbType.NVarchar2);
                pCwnr.Direction = ParameterDirection.Input;
                pCwnr.Value = jc_zlxmParamCondition.Cwnr;
                sqlparams.Add(pCwnr);

            }
                        
            if (null != jc_zlxmParamCondition.Note &&  ""!= jc_zlxmParamCondition.Note)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" NOTE=:note ");
                OracleParameter pNote = new OracleParameter(":note", OracleDbType.NVarchar2);
                pNote.Direction = ParameterDirection.Input;
                pNote.Value = jc_zlxmParamCondition.Note;
                sqlparams.Add(pNote);

            }
                        
            if (null != jc_zlxmParamCondition.Jcff &&  ""!= jc_zlxmParamCondition.Jcff)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" JCFF=:jcff ");
                OracleParameter pJcff = new OracleParameter(":jcff", OracleDbType.NVarchar2);
                pJcff.Direction = ParameterDirection.Input;
                pJcff.Value = jc_zlxmParamCondition.Jcff;
                sqlparams.Add(pJcff);

            }
                        
            if (null != jc_zlxmParamCondition.Biaozhuan &&  ""!= jc_zlxmParamCondition.Biaozhuan)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" BIAOZHUAN=:biaozhuan ");
                OracleParameter pBiaozhuan = new OracleParameter(":biaozhuan", OracleDbType.NVarchar2);
                pBiaozhuan.Direction = ParameterDirection.Input;
                pBiaozhuan.Value = jc_zlxmParamCondition.Biaozhuan;
                sqlparams.Add(pBiaozhuan);

            }
                        
            if (null != jc_zlxmParamCondition.Jinjian &&  ""!= jc_zlxmParamCondition.Jinjian)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" JINJIAN=:jinjian ");
                OracleParameter pJinjian = new OracleParameter(":jinjian", OracleDbType.NVarchar2);
                pJinjian.Direction = ParameterDirection.Input;
                pJinjian.Value = jc_zlxmParamCondition.Jinjian;
                sqlparams.Add(pJinjian);

            }
                        
            if (null != jc_zlxmParamCondition.Yinji &&  ""!= jc_zlxmParamCondition.Yinji)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" YINJI=:yinji ");
                OracleParameter pYinji = new OracleParameter(":yinji", OracleDbType.NVarchar2);
                pYinji.Direction = ParameterDirection.Input;
                pYinji.Value = jc_zlxmParamCondition.Yinji;
                sqlparams.Add(pYinji);

            }
                        
            if (DateTime.MinValue != jc_zlxmParamCondition.Gbsj &&null != jc_zlxmParamCondition.Gbsj)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" GBSJ=:gbsj ");
                OracleParameter pGbsj = new OracleParameter(":gbsj", OracleDbType.Date);
                pGbsj.Direction = ParameterDirection.Input;
                pGbsj.Value = jc_zlxmParamCondition.Gbsj;
                sqlparams.Add(pGbsj);

            }
                        
            if (null != jc_zlxmParamCondition.Gbjg &&  ""!= jc_zlxmParamCondition.Gbjg)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" GBJG=:gbjg ");
                OracleParameter pGbjg = new OracleParameter(":gbjg", OracleDbType.NVarchar2);
                pGbjg.Direction = ParameterDirection.Input;
                pGbjg.Value = jc_zlxmParamCondition.Gbjg;
                sqlparams.Add(pGbjg);

            }
                        
            if (null != jc_zlxmParamCondition.Ybbm &&  ""!= jc_zlxmParamCondition.Ybbm)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" YBBM=:ybbm ");
                OracleParameter pYbbm = new OracleParameter(":ybbm", OracleDbType.NVarchar2);
                pYbbm.Direction = ParameterDirection.Input;
                pYbbm.Value = jc_zlxmParamCondition.Ybbm;
                sqlparams.Add(pYbbm);

            }
                        
            if (null != jc_zlxmParamCondition.Nhbm &&  ""!= jc_zlxmParamCondition.Nhbm)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" NHBM=:nhbm ");
                OracleParameter pNhbm = new OracleParameter(":nhbm", OracleDbType.NVarchar2);
                pNhbm.Direction = ParameterDirection.Input;
                pNhbm.Value = jc_zlxmParamCondition.Nhbm;
                sqlparams.Add(pNhbm);

            }
                        
            if (null != jc_zlxmParamCondition.Nhsflb_code &&  ""!= jc_zlxmParamCondition.Nhsflb_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" NHSFLB_CODE=:nhsflb_code ");
                OracleParameter pNhsflb_code = new OracleParameter(":nhsflb_code", OracleDbType.NVarchar2);
                pNhsflb_code.Direction = ParameterDirection.Input;
                pNhsflb_code.Value = jc_zlxmParamCondition.Nhsflb_code;
                sqlparams.Add(pNhsflb_code);

            }
                        
            if (null != jc_zlxmParamCondition.Zfbz &&  ""!= jc_zlxmParamCondition.Zfbz)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" ZFBZ=:zfbz ");
                OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                pZfbz.Direction = ParameterDirection.Input;
                pZfbz.Value = jc_zlxmParamCondition.Zfbz;
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
        /// <param name="jc_zlxmParam"></param>
        /// <returns>影响的行数</returns>
        public bool updateById(Jc_zlxm jc_zlxmParam,OracleConnection con)
        {
            if ("" == jc_zlxmParam.Id || null == jc_zlxmParam.Id)
            {
                throw new Exception("ID不允许为空，请赋值后调用；错误出自：updateById");
            }
            List<OracleParameter> sqlparams = new List<OracleParameter>();

            StringBuilder sql = new StringBuilder("UPDATE JC_ZLXM SET ");
            if (null != jc_zlxmParam.Xmbh &&  ""!= jc_zlxmParam.Xmbh)
            {
                this.isComma(sql);
                sql.Append(" XMBH=:xmbh ");
                OracleParameter pXmbh = new OracleParameter(":xmbh", OracleDbType.NVarchar2);
                pXmbh.Direction = ParameterDirection.Input;
                pXmbh.Value = jc_zlxmParam.Xmbh;
                sqlparams.Add(pXmbh);

            }
                        
            if (null != jc_zlxmParam.Xmmc &&  ""!= jc_zlxmParam.Xmmc)
            {
                this.isComma(sql);
                sql.Append(" XMMC=:xmmc ");
                OracleParameter pXmmc = new OracleParameter(":xmmc", OracleDbType.NVarchar2);
                pXmmc.Direction = ParameterDirection.Input;
                pXmmc.Value = jc_zlxmParam.Xmmc;
                sqlparams.Add(pXmmc);

            }
                        
            if (null != jc_zlxmParam.Dw &&  ""!= jc_zlxmParam.Dw)
            {
                this.isComma(sql);
                sql.Append(" DW=:dw ");
                OracleParameter pDw = new OracleParameter(":dw", OracleDbType.NVarchar2);
                pDw.Direction = ParameterDirection.Input;
                pDw.Value = jc_zlxmParam.Dw;
                sqlparams.Add(pDw);

            }
                        
            if (null != jc_zlxmParam.Dj)
            {
                this.isComma(sql);
                sql.Append(" DJ=:dj ");
                OracleParameter pDj = new OracleParameter(":dj", OracleDbType.Decimal);
                pDj.Direction = ParameterDirection.Input;
                pDj.Value = jc_zlxmParam.Dj;
                sqlparams.Add(pDj);

            }
                        
            if (null != jc_zlxmParam.Zgxj)
            {
                this.isComma(sql);
                sql.Append(" ZGXJ=:zgxj ");
                OracleParameter pZgxj = new OracleParameter(":zgxj", OracleDbType.Decimal);
                pZgxj.Direction = ParameterDirection.Input;
                pZgxj.Value = jc_zlxmParam.Zgxj;
                sqlparams.Add(pZgxj);

            }
                        
            if (null != jc_zlxmParam.Fl_code &&  ""!= jc_zlxmParam.Fl_code)
            {
                this.isComma(sql);
                sql.Append(" FL_CODE=:fl_code ");
                OracleParameter pFl_code = new OracleParameter(":fl_code", OracleDbType.NVarchar2);
                pFl_code.Direction = ParameterDirection.Input;
                pFl_code.Value = jc_zlxmParam.Fl_code;
                sqlparams.Add(pFl_code);

            }
                        
            if (null != jc_zlxmParam.Fygl_code &&  ""!= jc_zlxmParam.Fygl_code)
            {
                this.isComma(sql);
                sql.Append(" FYGL_CODE=:fygl_code ");
                OracleParameter pFygl_code = new OracleParameter(":fygl_code", OracleDbType.NVarchar2);
                pFygl_code.Direction = ParameterDirection.Input;
                pFygl_code.Value = jc_zlxmParam.Fygl_code;
                sqlparams.Add(pFygl_code);

            }
                        
            if (null != jc_zlxmParam.Pym &&  ""!= jc_zlxmParam.Pym)
            {
                this.isComma(sql);
                sql.Append(" PYM=:pym ");
                OracleParameter pPym = new OracleParameter(":pym", OracleDbType.NVarchar2);
                pPym.Direction = ParameterDirection.Input;
                pPym.Value = jc_zlxmParam.Pym;
                sqlparams.Add(pPym);

            }
                        
            if (null != jc_zlxmParam.Wbm &&  ""!= jc_zlxmParam.Wbm)
            {
                this.isComma(sql);
                sql.Append(" WBM=:wbm ");
                OracleParameter pWbm = new OracleParameter(":wbm", OracleDbType.NVarchar2);
                pWbm.Direction = ParameterDirection.Input;
                pWbm.Value = jc_zlxmParam.Wbm;
                sqlparams.Add(pWbm);

            }
                        
            if (null != jc_zlxmParam.Szm &&  ""!= jc_zlxmParam.Szm)
            {
                this.isComma(sql);
                sql.Append(" SZM=:szm ");
                OracleParameter pSzm = new OracleParameter(":szm", OracleDbType.NVarchar2);
                pSzm.Direction = ParameterDirection.Input;
                pSzm.Value = jc_zlxmParam.Szm;
                sqlparams.Add(pSzm);

            }
                        
            if (null != jc_zlxmParam.Xmnr &&  ""!= jc_zlxmParam.Xmnr)
            {
                this.isComma(sql);
                sql.Append(" XMNR=:xmnr ");
                OracleParameter pXmnr = new OracleParameter(":xmnr", OracleDbType.NVarchar2);
                pXmnr.Direction = ParameterDirection.Input;
                pXmnr.Value = jc_zlxmParam.Xmnr;
                sqlparams.Add(pXmnr);

            }
                        
            if (null != jc_zlxmParam.Cwnr &&  ""!= jc_zlxmParam.Cwnr)
            {
                this.isComma(sql);
                sql.Append(" CWNR=:cwnr ");
                OracleParameter pCwnr = new OracleParameter(":cwnr", OracleDbType.NVarchar2);
                pCwnr.Direction = ParameterDirection.Input;
                pCwnr.Value = jc_zlxmParam.Cwnr;
                sqlparams.Add(pCwnr);

            }
                        
            if (null != jc_zlxmParam.Note &&  ""!= jc_zlxmParam.Note)
            {
                this.isComma(sql);
                sql.Append(" NOTE=:note ");
                OracleParameter pNote = new OracleParameter(":note", OracleDbType.NVarchar2);
                pNote.Direction = ParameterDirection.Input;
                pNote.Value = jc_zlxmParam.Note;
                sqlparams.Add(pNote);

            }
                        
            if (null != jc_zlxmParam.Jcff &&  ""!= jc_zlxmParam.Jcff)
            {
                this.isComma(sql);
                sql.Append(" JCFF=:jcff ");
                OracleParameter pJcff = new OracleParameter(":jcff", OracleDbType.NVarchar2);
                pJcff.Direction = ParameterDirection.Input;
                pJcff.Value = jc_zlxmParam.Jcff;
                sqlparams.Add(pJcff);

            }
                        
            if (null != jc_zlxmParam.Biaozhuan &&  ""!= jc_zlxmParam.Biaozhuan)
            {
                this.isComma(sql);
                sql.Append(" BIAOZHUAN=:biaozhuan ");
                OracleParameter pBiaozhuan = new OracleParameter(":biaozhuan", OracleDbType.NVarchar2);
                pBiaozhuan.Direction = ParameterDirection.Input;
                pBiaozhuan.Value = jc_zlxmParam.Biaozhuan;
                sqlparams.Add(pBiaozhuan);

            }
                        
            if (null != jc_zlxmParam.Jinjian &&  ""!= jc_zlxmParam.Jinjian)
            {
                this.isComma(sql);
                sql.Append(" JINJIAN=:jinjian ");
                OracleParameter pJinjian = new OracleParameter(":jinjian", OracleDbType.NVarchar2);
                pJinjian.Direction = ParameterDirection.Input;
                pJinjian.Value = jc_zlxmParam.Jinjian;
                sqlparams.Add(pJinjian);

            }
                        
            if (null != jc_zlxmParam.Yinji &&  ""!= jc_zlxmParam.Yinji)
            {
                this.isComma(sql);
                sql.Append(" YINJI=:yinji ");
                OracleParameter pYinji = new OracleParameter(":yinji", OracleDbType.NVarchar2);
                pYinji.Direction = ParameterDirection.Input;
                pYinji.Value = jc_zlxmParam.Yinji;
                sqlparams.Add(pYinji);

            }
                        
            if (DateTime.MinValue != jc_zlxmParam.Gbsj &&null != jc_zlxmParam.Gbsj)
            {
                this.isComma(sql);
                sql.Append(" GBSJ=:gbsj ");
                OracleParameter pGbsj = new OracleParameter(":gbsj", OracleDbType.Date);
                pGbsj.Direction = ParameterDirection.Input;
                pGbsj.Value = jc_zlxmParam.Gbsj;
                sqlparams.Add(pGbsj);

            }
                        
            if (null != jc_zlxmParam.Gbjg &&  ""!= jc_zlxmParam.Gbjg)
            {
                this.isComma(sql);
                sql.Append(" GBJG=:gbjg ");
                OracleParameter pGbjg = new OracleParameter(":gbjg", OracleDbType.NVarchar2);
                pGbjg.Direction = ParameterDirection.Input;
                pGbjg.Value = jc_zlxmParam.Gbjg;
                sqlparams.Add(pGbjg);

            }
                        
            if (null != jc_zlxmParam.Ybbm &&  ""!= jc_zlxmParam.Ybbm)
            {
                this.isComma(sql);
                sql.Append(" YBBM=:ybbm ");
                OracleParameter pYbbm = new OracleParameter(":ybbm", OracleDbType.NVarchar2);
                pYbbm.Direction = ParameterDirection.Input;
                pYbbm.Value = jc_zlxmParam.Ybbm;
                sqlparams.Add(pYbbm);

            }
                        
            if (null != jc_zlxmParam.Nhbm &&  ""!= jc_zlxmParam.Nhbm)
            {
                this.isComma(sql);
                sql.Append(" NHBM=:nhbm ");
                OracleParameter pNhbm = new OracleParameter(":nhbm", OracleDbType.NVarchar2);
                pNhbm.Direction = ParameterDirection.Input;
                pNhbm.Value = jc_zlxmParam.Nhbm;
                sqlparams.Add(pNhbm);

            }
                        
            if (null != jc_zlxmParam.Nhsflb_code &&  ""!= jc_zlxmParam.Nhsflb_code)
            {
                this.isComma(sql);
                sql.Append(" NHSFLB_CODE=:nhsflb_code ");
                OracleParameter pNhsflb_code = new OracleParameter(":nhsflb_code", OracleDbType.NVarchar2);
                pNhsflb_code.Direction = ParameterDirection.Input;
                pNhsflb_code.Value = jc_zlxmParam.Nhsflb_code;
                sqlparams.Add(pNhsflb_code);

            }
                        
            if (null != jc_zlxmParam.Zfbz &&  ""!= jc_zlxmParam.Zfbz)
            {
                this.isComma(sql);
                sql.Append(" ZFBZ=:zfbz ");
                OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                pZfbz.Direction = ParameterDirection.Input;
                pZfbz.Value = jc_zlxmParam.Zfbz;
                sqlparams.Add(pZfbz);

            }
                        
            sql.Append(" WHERE ID=:id ");
            OracleParameter pId = new OracleParameter(":id", OracleDbType.Varchar2);
            pId.Value = jc_zlxmParam.Id;
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
        /// <param name="jc_zlxmParamList">要修改的Jc_zlxm对象集合</param>
        /// <param name="con">Oracle连接对象（为null时自动生成）</param>
        /// <returns>是否删除成功（影响的行数等于要修改的对象数量时成功）</returns>
        public bool updateByIdBatch(List<Jc_zlxm> jc_zlxmParamList, OracleConnection con)
        {


            List<string> idList = new List<string>();

            List<string> xmbhList = new List<string>();

            List<string> xmmcList = new List<string>();

            List<string> dwList = new List<string>();

            List<decimal?> djList = new List<decimal?>();

            List<decimal?> zgxjList = new List<decimal?>();

            List<string> fl_codeList = new List<string>();

            List<string> fygl_codeList = new List<string>();

            List<string> pymList = new List<string>();

            List<string> wbmList = new List<string>();

            List<string> szmList = new List<string>();

            List<string> xmnrList = new List<string>();

            List<string> cwnrList = new List<string>();

            List<string> noteList = new List<string>();

            List<string> jcffList = new List<string>();

            List<string> biaozhuanList = new List<string>();

            List<string> jinjianList = new List<string>();

            List<string> yinjiList = new List<string>();

            List<DateTime?> gbsjList = new List<DateTime?>();

            List<string> gbjgList = new List<string>();

            List<string> ybbmList = new List<string>();

            List<string> nhbmList = new List<string>();

            List<string> nhsflb_codeList = new List<string>();

            List<string> zfbzList = new List<string>();

            for (int i = 0; i < jc_zlxmParamList.Count; i++)
            {
                Jc_zlxm jc_zlxmParam = jc_zlxmParamList[i];
                if ("" == jc_zlxmParam.Id || null == jc_zlxmParam.Id)
                {
                    throw new Exception("下标为" + i + "的数据，ID不能为空，请赋值后调用；错误出自：updateByIdBatch");
                }

            idList.Add(jc_zlxmParam.Id);

            xmbhList.Add(jc_zlxmParam.Xmbh);

            xmmcList.Add(jc_zlxmParam.Xmmc);

            dwList.Add(jc_zlxmParam.Dw);

            djList.Add(jc_zlxmParam.Dj);

            zgxjList.Add(jc_zlxmParam.Zgxj);

            fl_codeList.Add(jc_zlxmParam.Fl_code);

            fygl_codeList.Add(jc_zlxmParam.Fygl_code);

            pymList.Add(jc_zlxmParam.Pym);

            wbmList.Add(jc_zlxmParam.Wbm);

            szmList.Add(jc_zlxmParam.Szm);

            xmnrList.Add(jc_zlxmParam.Xmnr);

            cwnrList.Add(jc_zlxmParam.Cwnr);

            noteList.Add(jc_zlxmParam.Note);

            jcffList.Add(jc_zlxmParam.Jcff);

            biaozhuanList.Add(jc_zlxmParam.Biaozhuan);

            jinjianList.Add(jc_zlxmParam.Jinjian);

            yinjiList.Add(jc_zlxmParam.Yinji);

            gbsjList.Add(jc_zlxmParam.Gbsj);

            gbjgList.Add(jc_zlxmParam.Gbjg);

            ybbmList.Add(jc_zlxmParam.Ybbm);

            nhbmList.Add(jc_zlxmParam.Nhbm);

            nhsflb_codeList.Add(jc_zlxmParam.Nhsflb_code);

            zfbzList.Add(jc_zlxmParam.Zfbz);

            }


            
            List<OracleParameter> sqlparams = new List<OracleParameter>();

            StringBuilder sql = new StringBuilder("UPDATE JC_ZLXM SET ");
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
            sql.Append(" DW=:dw ");
            OracleParameter pDw = new OracleParameter(":dw", OracleDbType.NVarchar2);
            pDw.Direction = ParameterDirection.Input;
            pDw.Value = dwList.ToArray();
            sqlparams.Add(pDw);

            this.isComma(sql);
            sql.Append(" DJ=:dj ");
            OracleParameter pDj = new OracleParameter(":dj", OracleDbType.Decimal);
            pDj.Direction = ParameterDirection.Input;
            pDj.Value = djList.ToArray();
            sqlparams.Add(pDj);

            this.isComma(sql);
            sql.Append(" ZGXJ=:zgxj ");
            OracleParameter pZgxj = new OracleParameter(":zgxj", OracleDbType.Decimal);
            pZgxj.Direction = ParameterDirection.Input;
            pZgxj.Value = zgxjList.ToArray();
            sqlparams.Add(pZgxj);

            this.isComma(sql);
            sql.Append(" FL_CODE=:fl_code ");
            OracleParameter pFl_code = new OracleParameter(":fl_code", OracleDbType.NVarchar2);
            pFl_code.Direction = ParameterDirection.Input;
            pFl_code.Value = fl_codeList.ToArray();
            sqlparams.Add(pFl_code);

            this.isComma(sql);
            sql.Append(" FYGL_CODE=:fygl_code ");
            OracleParameter pFygl_code = new OracleParameter(":fygl_code", OracleDbType.NVarchar2);
            pFygl_code.Direction = ParameterDirection.Input;
            pFygl_code.Value = fygl_codeList.ToArray();
            sqlparams.Add(pFygl_code);

            this.isComma(sql);
            sql.Append(" PYM=:pym ");
            OracleParameter pPym = new OracleParameter(":pym", OracleDbType.NVarchar2);
            pPym.Direction = ParameterDirection.Input;
            pPym.Value = pymList.ToArray();
            sqlparams.Add(pPym);

            this.isComma(sql);
            sql.Append(" WBM=:wbm ");
            OracleParameter pWbm = new OracleParameter(":wbm", OracleDbType.NVarchar2);
            pWbm.Direction = ParameterDirection.Input;
            pWbm.Value = wbmList.ToArray();
            sqlparams.Add(pWbm);

            this.isComma(sql);
            sql.Append(" SZM=:szm ");
            OracleParameter pSzm = new OracleParameter(":szm", OracleDbType.NVarchar2);
            pSzm.Direction = ParameterDirection.Input;
            pSzm.Value = szmList.ToArray();
            sqlparams.Add(pSzm);

            this.isComma(sql);
            sql.Append(" XMNR=:xmnr ");
            OracleParameter pXmnr = new OracleParameter(":xmnr", OracleDbType.NVarchar2);
            pXmnr.Direction = ParameterDirection.Input;
            pXmnr.Value = xmnrList.ToArray();
            sqlparams.Add(pXmnr);

            this.isComma(sql);
            sql.Append(" CWNR=:cwnr ");
            OracleParameter pCwnr = new OracleParameter(":cwnr", OracleDbType.NVarchar2);
            pCwnr.Direction = ParameterDirection.Input;
            pCwnr.Value = cwnrList.ToArray();
            sqlparams.Add(pCwnr);

            this.isComma(sql);
            sql.Append(" NOTE=:note ");
            OracleParameter pNote = new OracleParameter(":note", OracleDbType.NVarchar2);
            pNote.Direction = ParameterDirection.Input;
            pNote.Value = noteList.ToArray();
            sqlparams.Add(pNote);

            this.isComma(sql);
            sql.Append(" JCFF=:jcff ");
            OracleParameter pJcff = new OracleParameter(":jcff", OracleDbType.NVarchar2);
            pJcff.Direction = ParameterDirection.Input;
            pJcff.Value = jcffList.ToArray();
            sqlparams.Add(pJcff);

            this.isComma(sql);
            sql.Append(" BIAOZHUAN=:biaozhuan ");
            OracleParameter pBiaozhuan = new OracleParameter(":biaozhuan", OracleDbType.NVarchar2);
            pBiaozhuan.Direction = ParameterDirection.Input;
            pBiaozhuan.Value = biaozhuanList.ToArray();
            sqlparams.Add(pBiaozhuan);

            this.isComma(sql);
            sql.Append(" JINJIAN=:jinjian ");
            OracleParameter pJinjian = new OracleParameter(":jinjian", OracleDbType.NVarchar2);
            pJinjian.Direction = ParameterDirection.Input;
            pJinjian.Value = jinjianList.ToArray();
            sqlparams.Add(pJinjian);

            this.isComma(sql);
            sql.Append(" YINJI=:yinji ");
            OracleParameter pYinji = new OracleParameter(":yinji", OracleDbType.NVarchar2);
            pYinji.Direction = ParameterDirection.Input;
            pYinji.Value = yinjiList.ToArray();
            sqlparams.Add(pYinji);

            this.isComma(sql);
            sql.Append(" GBSJ=:gbsj ");
            OracleParameter pGbsj = new OracleParameter(":gbsj", OracleDbType.Date);
            pGbsj.Direction = ParameterDirection.Input;
            pGbsj.Value = gbsjList.ToArray();
            sqlparams.Add(pGbsj);

            this.isComma(sql);
            sql.Append(" GBJG=:gbjg ");
            OracleParameter pGbjg = new OracleParameter(":gbjg", OracleDbType.NVarchar2);
            pGbjg.Direction = ParameterDirection.Input;
            pGbjg.Value = gbjgList.ToArray();
            sqlparams.Add(pGbjg);

            this.isComma(sql);
            sql.Append(" YBBM=:ybbm ");
            OracleParameter pYbbm = new OracleParameter(":ybbm", OracleDbType.NVarchar2);
            pYbbm.Direction = ParameterDirection.Input;
            pYbbm.Value = ybbmList.ToArray();
            sqlparams.Add(pYbbm);

            this.isComma(sql);
            sql.Append(" NHBM=:nhbm ");
            OracleParameter pNhbm = new OracleParameter(":nhbm", OracleDbType.NVarchar2);
            pNhbm.Direction = ParameterDirection.Input;
            pNhbm.Value = nhbmList.ToArray();
            sqlparams.Add(pNhbm);

            this.isComma(sql);
            sql.Append(" NHSFLB_CODE=:nhsflb_code ");
            OracleParameter pNhsflb_code = new OracleParameter(":nhsflb_code", OracleDbType.NVarchar2);
            pNhsflb_code.Direction = ParameterDirection.Input;
            pNhsflb_code.Value = nhsflb_codeList.ToArray();
            sqlparams.Add(pNhsflb_code);

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
            int flag = OracleHelper.ExecuteBatch(sql.ToString(), con,jc_zlxmParamList.Count, sqlparams.ToArray());
            if (jc_zlxmParamList.Count == flag)
            {
                result = true;
            }
            return result;
        }

        /// <summary>
        /// 根据更新的条件，更新数据（如果需要供事务使用就传入OracleConnection对象，如果不供就传入null，方法自动生成OracleConnection对象）
        /// 不指定ID，如果要根据ID来更新数据，请使用updateForId方法
        /// </summary>
        /// <param name="jc_zlxmParamCondition">条件对象</param>
        /// <param name="jc_zlxmParamUpdate">要更新的数据对象</param>
        /// <param name="con">Oracle连接对象（为null时自动生成）</param>
        /// <returns>影响的行数不确定（不为-1就正确）</returns>
        public bool updateByOtherCondition(Jc_zlxm jc_zlxmParamCondition, Jc_zlxm jc_zlxmParamUpdate, OracleConnection con)
        {
            if ((null!=jc_zlxmParamCondition.Id&&"!=jc_zlxmParamCondition.Id)||(null!=jc_zlxmParamUpdate.Id&&"!=jc_zlxmParamUpdate.Id))
            {
                throw new Exception("此方法不允许指定参数的ID，数据库中的ID不允许修改，如需根据ID修改数据，请调用updateById或updateByIdBatch方法；错误出自：updateByOtherCondition");
            }
            List<OracleParameter> sqlparams = new List<OracleParameter>();
            //添加要修改的值
            StringBuilder sql = new StringBuilder("UPDATE JC_ZLXM SET ");
            if (null != jc_zlxmParamUpdate.Xmbh &&  ""!= jc_zlxmParamUpdate.Xmbh)
            {
                this.isComma(sql);
                sql.Append(" XMBH=:xmbh ");
                OracleParameter pXmbh = new OracleParameter(":xmbh", OracleDbType.NVarchar2);
                pXmbh.Direction = ParameterDirection.Input;
                pXmbh.Value = jc_zlxmParamUpdate.Xmbh;
                sqlparams.Add(pXmbh);

            }
                        
            if (null != jc_zlxmParamUpdate.Xmmc &&  ""!= jc_zlxmParamUpdate.Xmmc)
            {
                this.isComma(sql);
                sql.Append(" XMMC=:xmmc ");
                OracleParameter pXmmc = new OracleParameter(":xmmc", OracleDbType.NVarchar2);
                pXmmc.Direction = ParameterDirection.Input;
                pXmmc.Value = jc_zlxmParamUpdate.Xmmc;
                sqlparams.Add(pXmmc);

            }
                        
            if (null != jc_zlxmParamUpdate.Dw &&  ""!= jc_zlxmParamUpdate.Dw)
            {
                this.isComma(sql);
                sql.Append(" DW=:dw ");
                OracleParameter pDw = new OracleParameter(":dw", OracleDbType.NVarchar2);
                pDw.Direction = ParameterDirection.Input;
                pDw.Value = jc_zlxmParamUpdate.Dw;
                sqlparams.Add(pDw);

            }
                        
            if (null != jc_zlxmParamUpdate.Dj)
            {
                this.isComma(sql);
                sql.Append(" DJ=:dj ");
                OracleParameter pDj = new OracleParameter(":dj", OracleDbType.Decimal);
                pDj.Direction = ParameterDirection.Input;
                pDj.Value = jc_zlxmParamUpdate.Dj;
                sqlparams.Add(pDj);

            }
                        
            if (null != jc_zlxmParamUpdate.Zgxj)
            {
                this.isComma(sql);
                sql.Append(" ZGXJ=:zgxj ");
                OracleParameter pZgxj = new OracleParameter(":zgxj", OracleDbType.Decimal);
                pZgxj.Direction = ParameterDirection.Input;
                pZgxj.Value = jc_zlxmParamUpdate.Zgxj;
                sqlparams.Add(pZgxj);

            }
                        
            if (null != jc_zlxmParamUpdate.Fl_code &&  ""!= jc_zlxmParamUpdate.Fl_code)
            {
                this.isComma(sql);
                sql.Append(" FL_CODE=:fl_code ");
                OracleParameter pFl_code = new OracleParameter(":fl_code", OracleDbType.NVarchar2);
                pFl_code.Direction = ParameterDirection.Input;
                pFl_code.Value = jc_zlxmParamUpdate.Fl_code;
                sqlparams.Add(pFl_code);

            }
                        
            if (null != jc_zlxmParamUpdate.Fygl_code &&  ""!= jc_zlxmParamUpdate.Fygl_code)
            {
                this.isComma(sql);
                sql.Append(" FYGL_CODE=:fygl_code ");
                OracleParameter pFygl_code = new OracleParameter(":fygl_code", OracleDbType.NVarchar2);
                pFygl_code.Direction = ParameterDirection.Input;
                pFygl_code.Value = jc_zlxmParamUpdate.Fygl_code;
                sqlparams.Add(pFygl_code);

            }
                        
            if (null != jc_zlxmParamUpdate.Pym &&  ""!= jc_zlxmParamUpdate.Pym)
            {
                this.isComma(sql);
                sql.Append(" PYM=:pym ");
                OracleParameter pPym = new OracleParameter(":pym", OracleDbType.NVarchar2);
                pPym.Direction = ParameterDirection.Input;
                pPym.Value = jc_zlxmParamUpdate.Pym;
                sqlparams.Add(pPym);

            }
                        
            if (null != jc_zlxmParamUpdate.Wbm &&  ""!= jc_zlxmParamUpdate.Wbm)
            {
                this.isComma(sql);
                sql.Append(" WBM=:wbm ");
                OracleParameter pWbm = new OracleParameter(":wbm", OracleDbType.NVarchar2);
                pWbm.Direction = ParameterDirection.Input;
                pWbm.Value = jc_zlxmParamUpdate.Wbm;
                sqlparams.Add(pWbm);

            }
                        
            if (null != jc_zlxmParamUpdate.Szm &&  ""!= jc_zlxmParamUpdate.Szm)
            {
                this.isComma(sql);
                sql.Append(" SZM=:szm ");
                OracleParameter pSzm = new OracleParameter(":szm", OracleDbType.NVarchar2);
                pSzm.Direction = ParameterDirection.Input;
                pSzm.Value = jc_zlxmParamUpdate.Szm;
                sqlparams.Add(pSzm);

            }
                        
            if (null != jc_zlxmParamUpdate.Xmnr &&  ""!= jc_zlxmParamUpdate.Xmnr)
            {
                this.isComma(sql);
                sql.Append(" XMNR=:xmnr ");
                OracleParameter pXmnr = new OracleParameter(":xmnr", OracleDbType.NVarchar2);
                pXmnr.Direction = ParameterDirection.Input;
                pXmnr.Value = jc_zlxmParamUpdate.Xmnr;
                sqlparams.Add(pXmnr);

            }
                        
            if (null != jc_zlxmParamUpdate.Cwnr &&  ""!= jc_zlxmParamUpdate.Cwnr)
            {
                this.isComma(sql);
                sql.Append(" CWNR=:cwnr ");
                OracleParameter pCwnr = new OracleParameter(":cwnr", OracleDbType.NVarchar2);
                pCwnr.Direction = ParameterDirection.Input;
                pCwnr.Value = jc_zlxmParamUpdate.Cwnr;
                sqlparams.Add(pCwnr);

            }
                        
            if (null != jc_zlxmParamUpdate.Note &&  ""!= jc_zlxmParamUpdate.Note)
            {
                this.isComma(sql);
                sql.Append(" NOTE=:note ");
                OracleParameter pNote = new OracleParameter(":note", OracleDbType.NVarchar2);
                pNote.Direction = ParameterDirection.Input;
                pNote.Value = jc_zlxmParamUpdate.Note;
                sqlparams.Add(pNote);

            }
                        
            if (null != jc_zlxmParamUpdate.Jcff &&  ""!= jc_zlxmParamUpdate.Jcff)
            {
                this.isComma(sql);
                sql.Append(" JCFF=:jcff ");
                OracleParameter pJcff = new OracleParameter(":jcff", OracleDbType.NVarchar2);
                pJcff.Direction = ParameterDirection.Input;
                pJcff.Value = jc_zlxmParamUpdate.Jcff;
                sqlparams.Add(pJcff);

            }
                        
            if (null != jc_zlxmParamUpdate.Biaozhuan &&  ""!= jc_zlxmParamUpdate.Biaozhuan)
            {
                this.isComma(sql);
                sql.Append(" BIAOZHUAN=:biaozhuan ");
                OracleParameter pBiaozhuan = new OracleParameter(":biaozhuan", OracleDbType.NVarchar2);
                pBiaozhuan.Direction = ParameterDirection.Input;
                pBiaozhuan.Value = jc_zlxmParamUpdate.Biaozhuan;
                sqlparams.Add(pBiaozhuan);

            }
                        
            if (null != jc_zlxmParamUpdate.Jinjian &&  ""!= jc_zlxmParamUpdate.Jinjian)
            {
                this.isComma(sql);
                sql.Append(" JINJIAN=:jinjian ");
                OracleParameter pJinjian = new OracleParameter(":jinjian", OracleDbType.NVarchar2);
                pJinjian.Direction = ParameterDirection.Input;
                pJinjian.Value = jc_zlxmParamUpdate.Jinjian;
                sqlparams.Add(pJinjian);

            }
                        
            if (null != jc_zlxmParamUpdate.Yinji &&  ""!= jc_zlxmParamUpdate.Yinji)
            {
                this.isComma(sql);
                sql.Append(" YINJI=:yinji ");
                OracleParameter pYinji = new OracleParameter(":yinji", OracleDbType.NVarchar2);
                pYinji.Direction = ParameterDirection.Input;
                pYinji.Value = jc_zlxmParamUpdate.Yinji;
                sqlparams.Add(pYinji);

            }
                        
            if (DateTime.MinValue != jc_zlxmParamUpdate.Gbsj &&null != jc_zlxmParamUpdate.Gbsj)
            {
                this.isComma(sql);
                sql.Append(" GBSJ=:gbsj ");
                OracleParameter pGbsj = new OracleParameter(":gbsj", OracleDbType.Date);
                pGbsj.Direction = ParameterDirection.Input;
                pGbsj.Value = jc_zlxmParamUpdate.Gbsj;
                sqlparams.Add(pGbsj);

            }
                        
            if (null != jc_zlxmParamUpdate.Gbjg &&  ""!= jc_zlxmParamUpdate.Gbjg)
            {
                this.isComma(sql);
                sql.Append(" GBJG=:gbjg ");
                OracleParameter pGbjg = new OracleParameter(":gbjg", OracleDbType.NVarchar2);
                pGbjg.Direction = ParameterDirection.Input;
                pGbjg.Value = jc_zlxmParamUpdate.Gbjg;
                sqlparams.Add(pGbjg);

            }
                        
            if (null != jc_zlxmParamUpdate.Ybbm &&  ""!= jc_zlxmParamUpdate.Ybbm)
            {
                this.isComma(sql);
                sql.Append(" YBBM=:ybbm ");
                OracleParameter pYbbm = new OracleParameter(":ybbm", OracleDbType.NVarchar2);
                pYbbm.Direction = ParameterDirection.Input;
                pYbbm.Value = jc_zlxmParamUpdate.Ybbm;
                sqlparams.Add(pYbbm);

            }
                        
            if (null != jc_zlxmParamUpdate.Nhbm &&  ""!= jc_zlxmParamUpdate.Nhbm)
            {
                this.isComma(sql);
                sql.Append(" NHBM=:nhbm ");
                OracleParameter pNhbm = new OracleParameter(":nhbm", OracleDbType.NVarchar2);
                pNhbm.Direction = ParameterDirection.Input;
                pNhbm.Value = jc_zlxmParamUpdate.Nhbm;
                sqlparams.Add(pNhbm);

            }
                        
            if (null != jc_zlxmParamUpdate.Nhsflb_code &&  ""!= jc_zlxmParamUpdate.Nhsflb_code)
            {
                this.isComma(sql);
                sql.Append(" NHSFLB_CODE=:nhsflb_code ");
                OracleParameter pNhsflb_code = new OracleParameter(":nhsflb_code", OracleDbType.NVarchar2);
                pNhsflb_code.Direction = ParameterDirection.Input;
                pNhsflb_code.Value = jc_zlxmParamUpdate.Nhsflb_code;
                sqlparams.Add(pNhsflb_code);

            }
                        
            if (null != jc_zlxmParamUpdate.Zfbz &&  ""!= jc_zlxmParamUpdate.Zfbz)
            {
                this.isComma(sql);
                sql.Append(" ZFBZ=:zfbz ");
                OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                pZfbz.Direction = ParameterDirection.Input;
                pZfbz.Value = jc_zlxmParamUpdate.Zfbz;
                sqlparams.Add(pZfbz);

            }
                        
            //添加条件的参数
            
            if (null != jc_zlxmParamCondition.Xmbh &&  ""!= jc_zlxmParamCondition.Xmbh)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" XMBH=:xmbh ");
                OracleParameter pXmbh = new OracleParameter(":xmbh", OracleDbType.NVarchar2);
                pXmbh.Direction = ParameterDirection.Input;
                pXmbh.Value = jc_zlxmParamCondition.Xmbh;
                sqlparams.Add(pXmbh);

            }
                        
            if (null != jc_zlxmParamCondition.Xmmc &&  ""!= jc_zlxmParamCondition.Xmmc)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" XMMC=:xmmc ");
                OracleParameter pXmmc = new OracleParameter(":xmmc", OracleDbType.NVarchar2);
                pXmmc.Direction = ParameterDirection.Input;
                pXmmc.Value = jc_zlxmParamCondition.Xmmc;
                sqlparams.Add(pXmmc);

            }
                        
            if (null != jc_zlxmParamCondition.Dw &&  ""!= jc_zlxmParamCondition.Dw)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" DW=:dw ");
                OracleParameter pDw = new OracleParameter(":dw", OracleDbType.NVarchar2);
                pDw.Direction = ParameterDirection.Input;
                pDw.Value = jc_zlxmParamCondition.Dw;
                sqlparams.Add(pDw);

            }
                        
            if (null != jc_zlxmParamCondition.Dj)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" DJ=:dj ");
                OracleParameter pDj = new OracleParameter(":dj", OracleDbType.Decimal);
                pDj.Direction = ParameterDirection.Input;
                pDj.Value = jc_zlxmParamCondition.Dj;
                sqlparams.Add(pDj);

            }
                        
            if (null != jc_zlxmParamCondition.Zgxj)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" ZGXJ=:zgxj ");
                OracleParameter pZgxj = new OracleParameter(":zgxj", OracleDbType.Decimal);
                pZgxj.Direction = ParameterDirection.Input;
                pZgxj.Value = jc_zlxmParamCondition.Zgxj;
                sqlparams.Add(pZgxj);

            }
                        
            if (null != jc_zlxmParamCondition.Fl_code &&  ""!= jc_zlxmParamCondition.Fl_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" FL_CODE=:fl_code ");
                OracleParameter pFl_code = new OracleParameter(":fl_code", OracleDbType.NVarchar2);
                pFl_code.Direction = ParameterDirection.Input;
                pFl_code.Value = jc_zlxmParamCondition.Fl_code;
                sqlparams.Add(pFl_code);

            }
                        
            if (null != jc_zlxmParamCondition.Fygl_code &&  ""!= jc_zlxmParamCondition.Fygl_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" FYGL_CODE=:fygl_code ");
                OracleParameter pFygl_code = new OracleParameter(":fygl_code", OracleDbType.NVarchar2);
                pFygl_code.Direction = ParameterDirection.Input;
                pFygl_code.Value = jc_zlxmParamCondition.Fygl_code;
                sqlparams.Add(pFygl_code);

            }
                        
            if (null != jc_zlxmParamCondition.Pym &&  ""!= jc_zlxmParamCondition.Pym)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" PYM=:pym ");
                OracleParameter pPym = new OracleParameter(":pym", OracleDbType.NVarchar2);
                pPym.Direction = ParameterDirection.Input;
                pPym.Value = jc_zlxmParamCondition.Pym;
                sqlparams.Add(pPym);

            }
                        
            if (null != jc_zlxmParamCondition.Wbm &&  ""!= jc_zlxmParamCondition.Wbm)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" WBM=:wbm ");
                OracleParameter pWbm = new OracleParameter(":wbm", OracleDbType.NVarchar2);
                pWbm.Direction = ParameterDirection.Input;
                pWbm.Value = jc_zlxmParamCondition.Wbm;
                sqlparams.Add(pWbm);

            }
                        
            if (null != jc_zlxmParamCondition.Szm &&  ""!= jc_zlxmParamCondition.Szm)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" SZM=:szm ");
                OracleParameter pSzm = new OracleParameter(":szm", OracleDbType.NVarchar2);
                pSzm.Direction = ParameterDirection.Input;
                pSzm.Value = jc_zlxmParamCondition.Szm;
                sqlparams.Add(pSzm);

            }
                        
            if (null != jc_zlxmParamCondition.Xmnr &&  ""!= jc_zlxmParamCondition.Xmnr)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" XMNR=:xmnr ");
                OracleParameter pXmnr = new OracleParameter(":xmnr", OracleDbType.NVarchar2);
                pXmnr.Direction = ParameterDirection.Input;
                pXmnr.Value = jc_zlxmParamCondition.Xmnr;
                sqlparams.Add(pXmnr);

            }
                        
            if (null != jc_zlxmParamCondition.Cwnr &&  ""!= jc_zlxmParamCondition.Cwnr)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" CWNR=:cwnr ");
                OracleParameter pCwnr = new OracleParameter(":cwnr", OracleDbType.NVarchar2);
                pCwnr.Direction = ParameterDirection.Input;
                pCwnr.Value = jc_zlxmParamCondition.Cwnr;
                sqlparams.Add(pCwnr);

            }
                        
            if (null != jc_zlxmParamCondition.Note &&  ""!= jc_zlxmParamCondition.Note)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" NOTE=:note ");
                OracleParameter pNote = new OracleParameter(":note", OracleDbType.NVarchar2);
                pNote.Direction = ParameterDirection.Input;
                pNote.Value = jc_zlxmParamCondition.Note;
                sqlparams.Add(pNote);

            }
                        
            if (null != jc_zlxmParamCondition.Jcff &&  ""!= jc_zlxmParamCondition.Jcff)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" JCFF=:jcff ");
                OracleParameter pJcff = new OracleParameter(":jcff", OracleDbType.NVarchar2);
                pJcff.Direction = ParameterDirection.Input;
                pJcff.Value = jc_zlxmParamCondition.Jcff;
                sqlparams.Add(pJcff);

            }
                        
            if (null != jc_zlxmParamCondition.Biaozhuan &&  ""!= jc_zlxmParamCondition.Biaozhuan)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" BIAOZHUAN=:biaozhuan ");
                OracleParameter pBiaozhuan = new OracleParameter(":biaozhuan", OracleDbType.NVarchar2);
                pBiaozhuan.Direction = ParameterDirection.Input;
                pBiaozhuan.Value = jc_zlxmParamCondition.Biaozhuan;
                sqlparams.Add(pBiaozhuan);

            }
                        
            if (null != jc_zlxmParamCondition.Jinjian &&  ""!= jc_zlxmParamCondition.Jinjian)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" JINJIAN=:jinjian ");
                OracleParameter pJinjian = new OracleParameter(":jinjian", OracleDbType.NVarchar2);
                pJinjian.Direction = ParameterDirection.Input;
                pJinjian.Value = jc_zlxmParamCondition.Jinjian;
                sqlparams.Add(pJinjian);

            }
                        
            if (null != jc_zlxmParamCondition.Yinji &&  ""!= jc_zlxmParamCondition.Yinji)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" YINJI=:yinji ");
                OracleParameter pYinji = new OracleParameter(":yinji", OracleDbType.NVarchar2);
                pYinji.Direction = ParameterDirection.Input;
                pYinji.Value = jc_zlxmParamCondition.Yinji;
                sqlparams.Add(pYinji);

            }
                        
            if (DateTime.MinValue != jc_zlxmParamCondition.Gbsj &&null != jc_zlxmParamCondition.Gbsj)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" GBSJ=:gbsj ");
                OracleParameter pGbsj = new OracleParameter(":gbsj", OracleDbType.Date);
                pGbsj.Direction = ParameterDirection.Input;
                pGbsj.Value = jc_zlxmParamCondition.Gbsj;
                sqlparams.Add(pGbsj);

            }
                        
            if (null != jc_zlxmParamCondition.Gbjg &&  ""!= jc_zlxmParamCondition.Gbjg)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" GBJG=:gbjg ");
                OracleParameter pGbjg = new OracleParameter(":gbjg", OracleDbType.NVarchar2);
                pGbjg.Direction = ParameterDirection.Input;
                pGbjg.Value = jc_zlxmParamCondition.Gbjg;
                sqlparams.Add(pGbjg);

            }
                        
            if (null != jc_zlxmParamCondition.Ybbm &&  ""!= jc_zlxmParamCondition.Ybbm)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" YBBM=:ybbm ");
                OracleParameter pYbbm = new OracleParameter(":ybbm", OracleDbType.NVarchar2);
                pYbbm.Direction = ParameterDirection.Input;
                pYbbm.Value = jc_zlxmParamCondition.Ybbm;
                sqlparams.Add(pYbbm);

            }
                        
            if (null != jc_zlxmParamCondition.Nhbm &&  ""!= jc_zlxmParamCondition.Nhbm)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" NHBM=:nhbm ");
                OracleParameter pNhbm = new OracleParameter(":nhbm", OracleDbType.NVarchar2);
                pNhbm.Direction = ParameterDirection.Input;
                pNhbm.Value = jc_zlxmParamCondition.Nhbm;
                sqlparams.Add(pNhbm);

            }
                        
            if (null != jc_zlxmParamCondition.Nhsflb_code &&  ""!= jc_zlxmParamCondition.Nhsflb_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" NHSFLB_CODE=:nhsflb_code ");
                OracleParameter pNhsflb_code = new OracleParameter(":nhsflb_code", OracleDbType.NVarchar2);
                pNhsflb_code.Direction = ParameterDirection.Input;
                pNhsflb_code.Value = jc_zlxmParamCondition.Nhsflb_code;
                sqlparams.Add(pNhsflb_code);

            }
                        
            if (null != jc_zlxmParamCondition.Zfbz &&  ""!= jc_zlxmParamCondition.Zfbz)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" ZFBZ=:zfbz ");
                OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                pZfbz.Direction = ParameterDirection.Input;
                pZfbz.Value = jc_zlxmParamCondition.Zfbz;
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
        /// <returns>Jc_zlxm</returns>
        public Jc_zlxm findById(string id)
        {
            if (""==id||null==id)
            {
                throw new Exception("ID不能为空，请赋值后调用；错误出自：findById");
            }
            StringBuilder sql = new StringBuilder("SELECT A.* ");
            //新建方法findContactObjectsById，在此加入多表连接要显示的项start
            //sql.Append(",B.字段一,B.字段二,B.字段三");
            //新建方法，在此加入多表连接要显示的项end
            sql.Append(" FROM JC_ZLXM A ");
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
        /// <param name="jc_zlxmParam"></param>
        /// <param name="page">分页对象</param>
        ///<param name="jc_zlxmParamLike">模糊查询参数</param>
        ///<param name="sortList">排序参数对象的集合</param>
        /// <returns>满足条件的所有Jc_zlxm对象集合list</returns>
        public List<object> find(Jc_zlxm jc_zlxmParam, Model.Common.PageInfo page,Jc_zlxm jc_zlxmParamLike,List<SortInfo> sortList)
        {

            //如果没有传查询条件参数，就new一个空的Jc_zlxm对象，标示查询所有数据
            if (null == jc_zlxmParam)
            {
                jc_zlxmParam = new Jc_zlxm();
            }
            if (null!=jc_zlxmParam.Id&&""!=jc_zlxmParam.Id)
            {
                throw new Exception("此方法不允许指定参数ID，如果需要根据ID查询数据，请调用findById方法；错误出自：find");
            }
            List<Jc_zlxm> jc_zlxmParamList = new List<Jc_zlxm>();//接收查询出的Jc_zlxm对象集合
            List<OracleParameter> sqlparams = new List<OracleParameter>();//保存参数的集合
            StringBuilder sql = new StringBuilder("SELECT A.* ");
            //新建方法findContactObjects(Jc_zlxm jc_zlxmParam, Model.Common.PageInfo page)，在此加入多表连接要显示的项start
            //sql.Append(",B.字段一,B.字段二,B.字段三");
            //新建方法，在此加入多表连接要显示的项end
            sql.Append(" FROM JC_ZLXM A ");
            //新建一个方法，在此加入多表连接的语句start
            ////sql.Append(" LEFT JOIN 表名 B ON A.外键=B.ID");
            //新建一个方法，在此加入多表连接的语句end
            
            
            if (null != jc_zlxmParam.Xmbh && "" != jc_zlxmParam.Xmbh)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.XMBH=:xmbh ");
                OracleParameter pXmbh = new OracleParameter(":xmbh", OracleDbType.NVarchar2);
                pXmbh.Direction = ParameterDirection.Input;
                pXmbh.Value = jc_zlxmParam.Xmbh;
                sqlparams.Add(pXmbh);
            }
                
            if (null != jc_zlxmParam.Xmmc && "" != jc_zlxmParam.Xmmc)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.XMMC=:xmmc ");
                OracleParameter pXmmc = new OracleParameter(":xmmc", OracleDbType.NVarchar2);
                pXmmc.Direction = ParameterDirection.Input;
                pXmmc.Value = jc_zlxmParam.Xmmc;
                sqlparams.Add(pXmmc);
            }
                
            if (null != jc_zlxmParam.Dw && "" != jc_zlxmParam.Dw)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.DW=:dw ");
                OracleParameter pDw = new OracleParameter(":dw", OracleDbType.NVarchar2);
                pDw.Direction = ParameterDirection.Input;
                pDw.Value = jc_zlxmParam.Dw;
                sqlparams.Add(pDw);
            }
                
            if (null != jc_zlxmParam.Dj)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.DJ=:dj ");
                OracleParameter pDj = new OracleParameter(":dj", OracleDbType.Decimal);
                pDj.Direction = ParameterDirection.Input;
                pDj.Value = jc_zlxmParam.Dj;
                sqlparams.Add(pDj);

            }
                        
            if (null != jc_zlxmParam.Zgxj)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.ZGXJ=:zgxj ");
                OracleParameter pZgxj = new OracleParameter(":zgxj", OracleDbType.Decimal);
                pZgxj.Direction = ParameterDirection.Input;
                pZgxj.Value = jc_zlxmParam.Zgxj;
                sqlparams.Add(pZgxj);

            }
                        
            if (null != jc_zlxmParam.Fl_code && "" != jc_zlxmParam.Fl_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.FL_CODE=:fl_code ");
                OracleParameter pFl_code = new OracleParameter(":fl_code", OracleDbType.NVarchar2);
                pFl_code.Direction = ParameterDirection.Input;
                pFl_code.Value = jc_zlxmParam.Fl_code;
                sqlparams.Add(pFl_code);
            }
                
            if (null != jc_zlxmParam.Fygl_code && "" != jc_zlxmParam.Fygl_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.FYGL_CODE=:fygl_code ");
                OracleParameter pFygl_code = new OracleParameter(":fygl_code", OracleDbType.NVarchar2);
                pFygl_code.Direction = ParameterDirection.Input;
                pFygl_code.Value = jc_zlxmParam.Fygl_code;
                sqlparams.Add(pFygl_code);
            }
                
            if (null != jc_zlxmParam.Pym && "" != jc_zlxmParam.Pym)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.PYM=:pym ");
                OracleParameter pPym = new OracleParameter(":pym", OracleDbType.NVarchar2);
                pPym.Direction = ParameterDirection.Input;
                pPym.Value = jc_zlxmParam.Pym;
                sqlparams.Add(pPym);
            }
                
            if (null != jc_zlxmParam.Wbm && "" != jc_zlxmParam.Wbm)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.WBM=:wbm ");
                OracleParameter pWbm = new OracleParameter(":wbm", OracleDbType.NVarchar2);
                pWbm.Direction = ParameterDirection.Input;
                pWbm.Value = jc_zlxmParam.Wbm;
                sqlparams.Add(pWbm);
            }
                
            if (null != jc_zlxmParam.Szm && "" != jc_zlxmParam.Szm)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.SZM=:szm ");
                OracleParameter pSzm = new OracleParameter(":szm", OracleDbType.NVarchar2);
                pSzm.Direction = ParameterDirection.Input;
                pSzm.Value = jc_zlxmParam.Szm;
                sqlparams.Add(pSzm);
            }
                
            if (null != jc_zlxmParam.Xmnr && "" != jc_zlxmParam.Xmnr)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.XMNR=:xmnr ");
                OracleParameter pXmnr = new OracleParameter(":xmnr", OracleDbType.NVarchar2);
                pXmnr.Direction = ParameterDirection.Input;
                pXmnr.Value = jc_zlxmParam.Xmnr;
                sqlparams.Add(pXmnr);
            }
                
            if (null != jc_zlxmParam.Cwnr && "" != jc_zlxmParam.Cwnr)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.CWNR=:cwnr ");
                OracleParameter pCwnr = new OracleParameter(":cwnr", OracleDbType.NVarchar2);
                pCwnr.Direction = ParameterDirection.Input;
                pCwnr.Value = jc_zlxmParam.Cwnr;
                sqlparams.Add(pCwnr);
            }
                
            if (null != jc_zlxmParam.Note && "" != jc_zlxmParam.Note)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.NOTE=:note ");
                OracleParameter pNote = new OracleParameter(":note", OracleDbType.NVarchar2);
                pNote.Direction = ParameterDirection.Input;
                pNote.Value = jc_zlxmParam.Note;
                sqlparams.Add(pNote);
            }
                
            if (null != jc_zlxmParam.Jcff && "" != jc_zlxmParam.Jcff)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.JCFF=:jcff ");
                OracleParameter pJcff = new OracleParameter(":jcff", OracleDbType.NVarchar2);
                pJcff.Direction = ParameterDirection.Input;
                pJcff.Value = jc_zlxmParam.Jcff;
                sqlparams.Add(pJcff);
            }
                
            if (null != jc_zlxmParam.Biaozhuan && "" != jc_zlxmParam.Biaozhuan)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.BIAOZHUAN=:biaozhuan ");
                OracleParameter pBiaozhuan = new OracleParameter(":biaozhuan", OracleDbType.NVarchar2);
                pBiaozhuan.Direction = ParameterDirection.Input;
                pBiaozhuan.Value = jc_zlxmParam.Biaozhuan;
                sqlparams.Add(pBiaozhuan);
            }
                
            if (null != jc_zlxmParam.Jinjian && "" != jc_zlxmParam.Jinjian)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.JINJIAN=:jinjian ");
                OracleParameter pJinjian = new OracleParameter(":jinjian", OracleDbType.NVarchar2);
                pJinjian.Direction = ParameterDirection.Input;
                pJinjian.Value = jc_zlxmParam.Jinjian;
                sqlparams.Add(pJinjian);
            }
                
            if (null != jc_zlxmParam.Yinji && "" != jc_zlxmParam.Yinji)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.YINJI=:yinji ");
                OracleParameter pYinji = new OracleParameter(":yinji", OracleDbType.NVarchar2);
                pYinji.Direction = ParameterDirection.Input;
                pYinji.Value = jc_zlxmParam.Yinji;
                sqlparams.Add(pYinji);
            }
                
                if (DateTime.MinValue != jc_zlxmParam.Gbsj &&null != jc_zlxmParam.Gbsj)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.GBSJ=:gbsj ");
                    OracleParameter pGbsj = new OracleParameter(":gbsj", OracleDbType.Date);
                pGbsj.Direction = ParameterDirection.Input;
                pGbsj.Value = jc_zlxmParam.Gbsj;
                sqlparams.Add(pGbsj);
                }
                
            if (null != jc_zlxmParam.Gbjg && "" != jc_zlxmParam.Gbjg)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.GBJG=:gbjg ");
                OracleParameter pGbjg = new OracleParameter(":gbjg", OracleDbType.NVarchar2);
                pGbjg.Direction = ParameterDirection.Input;
                pGbjg.Value = jc_zlxmParam.Gbjg;
                sqlparams.Add(pGbjg);
            }
                
            if (null != jc_zlxmParam.Ybbm && "" != jc_zlxmParam.Ybbm)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.YBBM=:ybbm ");
                OracleParameter pYbbm = new OracleParameter(":ybbm", OracleDbType.NVarchar2);
                pYbbm.Direction = ParameterDirection.Input;
                pYbbm.Value = jc_zlxmParam.Ybbm;
                sqlparams.Add(pYbbm);
            }
                
            if (null != jc_zlxmParam.Nhbm && "" != jc_zlxmParam.Nhbm)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.NHBM=:nhbm ");
                OracleParameter pNhbm = new OracleParameter(":nhbm", OracleDbType.NVarchar2);
                pNhbm.Direction = ParameterDirection.Input;
                pNhbm.Value = jc_zlxmParam.Nhbm;
                sqlparams.Add(pNhbm);
            }
                
            if (null != jc_zlxmParam.Nhsflb_code && "" != jc_zlxmParam.Nhsflb_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.NHSFLB_CODE=:nhsflb_code ");
                OracleParameter pNhsflb_code = new OracleParameter(":nhsflb_code", OracleDbType.NVarchar2);
                pNhsflb_code.Direction = ParameterDirection.Input;
                pNhsflb_code.Value = jc_zlxmParam.Nhsflb_code;
                sqlparams.Add(pNhsflb_code);
            }
                
            if (null != jc_zlxmParam.Zfbz && "" != jc_zlxmParam.Zfbz)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.ZFBZ=:zfbz ");
                OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                pZfbz.Direction = ParameterDirection.Input;
                pZfbz.Value = jc_zlxmParam.Zfbz;
                sqlparams.Add(pZfbz);
            }
                
            if(jc_zlxmParamLike!=null)
            {

                if (null != jc_zlxmParamLike.Xmbh && "" != jc_zlxmParamLike.Xmbh)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.XMBH LIKE '%'||:xmbh||'%' ");
                    OracleParameter pXmbh = new OracleParameter(":xmbh", OracleDbType.NVarchar2);
                    pXmbh.Direction = ParameterDirection.Input;
                    pXmbh.Value = jc_zlxmParamLike.Xmbh;
                    sqlparams.Add(pXmbh);
                }
                
                if (null != jc_zlxmParamLike.Xmmc && "" != jc_zlxmParamLike.Xmmc)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.XMMC LIKE '%'||:xmmc||'%' ");
                    OracleParameter pXmmc = new OracleParameter(":xmmc", OracleDbType.NVarchar2);
                    pXmmc.Direction = ParameterDirection.Input;
                    pXmmc.Value = jc_zlxmParamLike.Xmmc;
                    sqlparams.Add(pXmmc);
                }
                
                if (null != jc_zlxmParamLike.Dw && "" != jc_zlxmParamLike.Dw)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.DW LIKE '%'||:dw||'%' ");
                    OracleParameter pDw = new OracleParameter(":dw", OracleDbType.NVarchar2);
                    pDw.Direction = ParameterDirection.Input;
                    pDw.Value = jc_zlxmParamLike.Dw;
                    sqlparams.Add(pDw);
                }
                
                if (null != jc_zlxmParamLike.Fl_code && "" != jc_zlxmParamLike.Fl_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.FL_CODE LIKE '%'||:fl_code||'%' ");
                    OracleParameter pFl_code = new OracleParameter(":fl_code", OracleDbType.NVarchar2);
                    pFl_code.Direction = ParameterDirection.Input;
                    pFl_code.Value = jc_zlxmParamLike.Fl_code;
                    sqlparams.Add(pFl_code);
                }
                
                if (null != jc_zlxmParamLike.Fygl_code && "" != jc_zlxmParamLike.Fygl_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.FYGL_CODE LIKE '%'||:fygl_code||'%' ");
                    OracleParameter pFygl_code = new OracleParameter(":fygl_code", OracleDbType.NVarchar2);
                    pFygl_code.Direction = ParameterDirection.Input;
                    pFygl_code.Value = jc_zlxmParamLike.Fygl_code;
                    sqlparams.Add(pFygl_code);
                }
                
                if (null != jc_zlxmParamLike.Pym && "" != jc_zlxmParamLike.Pym)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.PYM LIKE '%'||:pym||'%' ");
                    OracleParameter pPym = new OracleParameter(":pym", OracleDbType.NVarchar2);
                    pPym.Direction = ParameterDirection.Input;
                    pPym.Value = jc_zlxmParamLike.Pym;
                    sqlparams.Add(pPym);
                }
                
                if (null != jc_zlxmParamLike.Wbm && "" != jc_zlxmParamLike.Wbm)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.WBM LIKE '%'||:wbm||'%' ");
                    OracleParameter pWbm = new OracleParameter(":wbm", OracleDbType.NVarchar2);
                    pWbm.Direction = ParameterDirection.Input;
                    pWbm.Value = jc_zlxmParamLike.Wbm;
                    sqlparams.Add(pWbm);
                }
                
                if (null != jc_zlxmParamLike.Szm && "" != jc_zlxmParamLike.Szm)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.SZM LIKE '%'||:szm||'%' ");
                    OracleParameter pSzm = new OracleParameter(":szm", OracleDbType.NVarchar2);
                    pSzm.Direction = ParameterDirection.Input;
                    pSzm.Value = jc_zlxmParamLike.Szm;
                    sqlparams.Add(pSzm);
                }
                
                if (null != jc_zlxmParamLike.Xmnr && "" != jc_zlxmParamLike.Xmnr)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.XMNR LIKE '%'||:xmnr||'%' ");
                    OracleParameter pXmnr = new OracleParameter(":xmnr", OracleDbType.NVarchar2);
                    pXmnr.Direction = ParameterDirection.Input;
                    pXmnr.Value = jc_zlxmParamLike.Xmnr;
                    sqlparams.Add(pXmnr);
                }
                
                if (null != jc_zlxmParamLike.Cwnr && "" != jc_zlxmParamLike.Cwnr)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.CWNR LIKE '%'||:cwnr||'%' ");
                    OracleParameter pCwnr = new OracleParameter(":cwnr", OracleDbType.NVarchar2);
                    pCwnr.Direction = ParameterDirection.Input;
                    pCwnr.Value = jc_zlxmParamLike.Cwnr;
                    sqlparams.Add(pCwnr);
                }
                
                if (null != jc_zlxmParamLike.Note && "" != jc_zlxmParamLike.Note)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.NOTE LIKE '%'||:note||'%' ");
                    OracleParameter pNote = new OracleParameter(":note", OracleDbType.NVarchar2);
                    pNote.Direction = ParameterDirection.Input;
                    pNote.Value = jc_zlxmParamLike.Note;
                    sqlparams.Add(pNote);
                }
                
                if (null != jc_zlxmParamLike.Jcff && "" != jc_zlxmParamLike.Jcff)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.JCFF LIKE '%'||:jcff||'%' ");
                    OracleParameter pJcff = new OracleParameter(":jcff", OracleDbType.NVarchar2);
                    pJcff.Direction = ParameterDirection.Input;
                    pJcff.Value = jc_zlxmParamLike.Jcff;
                    sqlparams.Add(pJcff);
                }
                
                if (null != jc_zlxmParamLike.Biaozhuan && "" != jc_zlxmParamLike.Biaozhuan)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.BIAOZHUAN LIKE '%'||:biaozhuan||'%' ");
                    OracleParameter pBiaozhuan = new OracleParameter(":biaozhuan", OracleDbType.NVarchar2);
                    pBiaozhuan.Direction = ParameterDirection.Input;
                    pBiaozhuan.Value = jc_zlxmParamLike.Biaozhuan;
                    sqlparams.Add(pBiaozhuan);
                }
                
                if (null != jc_zlxmParamLike.Jinjian && "" != jc_zlxmParamLike.Jinjian)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.JINJIAN LIKE '%'||:jinjian||'%' ");
                    OracleParameter pJinjian = new OracleParameter(":jinjian", OracleDbType.NVarchar2);
                    pJinjian.Direction = ParameterDirection.Input;
                    pJinjian.Value = jc_zlxmParamLike.Jinjian;
                    sqlparams.Add(pJinjian);
                }
                
                if (null != jc_zlxmParamLike.Yinji && "" != jc_zlxmParamLike.Yinji)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YINJI LIKE '%'||:yinji||'%' ");
                    OracleParameter pYinji = new OracleParameter(":yinji", OracleDbType.NVarchar2);
                    pYinji.Direction = ParameterDirection.Input;
                    pYinji.Value = jc_zlxmParamLike.Yinji;
                    sqlparams.Add(pYinji);
                }
                
                if (null != jc_zlxmParamLike.Gbjg && "" != jc_zlxmParamLike.Gbjg)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.GBJG LIKE '%'||:gbjg||'%' ");
                    OracleParameter pGbjg = new OracleParameter(":gbjg", OracleDbType.NVarchar2);
                    pGbjg.Direction = ParameterDirection.Input;
                    pGbjg.Value = jc_zlxmParamLike.Gbjg;
                    sqlparams.Add(pGbjg);
                }
                
                if (null != jc_zlxmParamLike.Ybbm && "" != jc_zlxmParamLike.Ybbm)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YBBM LIKE '%'||:ybbm||'%' ");
                    OracleParameter pYbbm = new OracleParameter(":ybbm", OracleDbType.NVarchar2);
                    pYbbm.Direction = ParameterDirection.Input;
                    pYbbm.Value = jc_zlxmParamLike.Ybbm;
                    sqlparams.Add(pYbbm);
                }
                
                if (null != jc_zlxmParamLike.Nhbm && "" != jc_zlxmParamLike.Nhbm)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.NHBM LIKE '%'||:nhbm||'%' ");
                    OracleParameter pNhbm = new OracleParameter(":nhbm", OracleDbType.NVarchar2);
                    pNhbm.Direction = ParameterDirection.Input;
                    pNhbm.Value = jc_zlxmParamLike.Nhbm;
                    sqlparams.Add(pNhbm);
                }
                
                if (null != jc_zlxmParamLike.Nhsflb_code && "" != jc_zlxmParamLike.Nhsflb_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.NHSFLB_CODE LIKE '%'||:nhsflb_code||'%' ");
                    OracleParameter pNhsflb_code = new OracleParameter(":nhsflb_code", OracleDbType.NVarchar2);
                    pNhsflb_code.Direction = ParameterDirection.Input;
                    pNhsflb_code.Value = jc_zlxmParamLike.Nhsflb_code;
                    sqlparams.Add(pNhsflb_code);
                }
                
                if (null != jc_zlxmParamLike.Zfbz && "" != jc_zlxmParamLike.Zfbz)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.ZFBZ LIKE '%'||:zfbz||'%' ");
                    OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                    pZfbz.Direction = ParameterDirection.Input;
                    pZfbz.Value = jc_zlxmParamLike.Zfbz;
                    sqlparams.Add(pZfbz);
                }
                
            }

            this.b_isWhere = false;
            this.addSort(sql, sortList);//排序
            //*******分页start1*********如果分页对象为空，则全部数据查出，如果不为空
            List<object> returnList = new List<object>();//返回的List,索引0为List<Jc_zlxm>对象,索引1为Model.Common.PageInfo分页信息对象
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
            //把每一行数据转换为一个对象放入List<Jc_zlxm>中
            for (int i = 0; i < rows.Count; i++)
            {
                DataRow row = rows[i];
                //jc_zlxmParamList.Add(this.dataSetContactObjectsToModel(row));
                jc_zlxmParamList.Add(this.dataSetToModel(row));
            }
            
             //*******分页start2*********如果没有传入分页对象，则新建一个分页对象当做返回值
            if (null == page)
            {
                page = new Model.Common.PageInfo();
                page.AllCount = rows.Count;
            }
            returnList.Add(jc_zlxmParamList);//把List<Jc_zlxm>放入List<object>中第一个
            returnList.Add(page);//把page对象放入List<object>中第二个
            //*******分页end2*********
            return returnList;
        }

        
        
        /// <summary>
        /// 根据条件得到集合的数量
        /// 第二个条件是模糊查询的条件
        /// </summary>
        /// <returns>int</returns>
        public int getCount(Jc_zlxm jc_zlxmParam,Jc_zlxm jc_zlxmParamLike)
        {
            //如果没有传查询条件参数，就new一个空的Jc_zlxm对象，标示查询所有数据
            if (null == jc_zlxmParam)
            {
                jc_zlxmParam = new Jc_zlxm();
            }
            List<OracleParameter> sqlparams = new List<OracleParameter>();//保存参数的集合
            StringBuilder sql = new StringBuilder("SELECT COUNT(ID) FROM JC_ZLXM A");
                if (null != jc_zlxmParam.Xmbh && "" != jc_zlxmParam.Xmbh)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.XMBH=:xmbh ");
                    OracleParameter pXmbh = new OracleParameter(":xmbh", OracleDbType.NVarchar2);
                pXmbh.Value = jc_zlxmParam.Xmbh;
                sqlparams.Add(pXmbh);
                }
                
                if (null != jc_zlxmParam.Xmmc && "" != jc_zlxmParam.Xmmc)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.XMMC=:xmmc ");
                    OracleParameter pXmmc = new OracleParameter(":xmmc", OracleDbType.NVarchar2);
                pXmmc.Value = jc_zlxmParam.Xmmc;
                sqlparams.Add(pXmmc);
                }
                
                if (null != jc_zlxmParam.Dw && "" != jc_zlxmParam.Dw)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.DW=:dw ");
                    OracleParameter pDw = new OracleParameter(":dw", OracleDbType.NVarchar2);
                pDw.Value = jc_zlxmParam.Dw;
                sqlparams.Add(pDw);
                }
                
            if (null != jc_zlxmParam.Dj)
            {
                this.isComma(sql);
                sql.Append(" DJ=:dj ");
                OracleParameter pDj = new OracleParameter(":dj", OracleDbType.Decimal);
                pDj.Value = jc_zlxmParam.Dj;
                sqlparams.Add(pDj);

            }
                        
            if (null != jc_zlxmParam.Zgxj)
            {
                this.isComma(sql);
                sql.Append(" ZGXJ=:zgxj ");
                OracleParameter pZgxj = new OracleParameter(":zgxj", OracleDbType.Decimal);
                pZgxj.Value = jc_zlxmParam.Zgxj;
                sqlparams.Add(pZgxj);

            }
                        
                if (null != jc_zlxmParam.Fl_code && "" != jc_zlxmParam.Fl_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.FL_CODE=:fl_code ");
                    OracleParameter pFl_code = new OracleParameter(":fl_code", OracleDbType.NVarchar2);
                pFl_code.Value = jc_zlxmParam.Fl_code;
                sqlparams.Add(pFl_code);
                }
                
                if (null != jc_zlxmParam.Fygl_code && "" != jc_zlxmParam.Fygl_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.FYGL_CODE=:fygl_code ");
                    OracleParameter pFygl_code = new OracleParameter(":fygl_code", OracleDbType.NVarchar2);
                pFygl_code.Value = jc_zlxmParam.Fygl_code;
                sqlparams.Add(pFygl_code);
                }
                
                if (null != jc_zlxmParam.Pym && "" != jc_zlxmParam.Pym)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.PYM=:pym ");
                    OracleParameter pPym = new OracleParameter(":pym", OracleDbType.NVarchar2);
                pPym.Value = jc_zlxmParam.Pym;
                sqlparams.Add(pPym);
                }
                
                if (null != jc_zlxmParam.Wbm && "" != jc_zlxmParam.Wbm)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.WBM=:wbm ");
                    OracleParameter pWbm = new OracleParameter(":wbm", OracleDbType.NVarchar2);
                pWbm.Value = jc_zlxmParam.Wbm;
                sqlparams.Add(pWbm);
                }
                
                if (null != jc_zlxmParam.Szm && "" != jc_zlxmParam.Szm)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.SZM=:szm ");
                    OracleParameter pSzm = new OracleParameter(":szm", OracleDbType.NVarchar2);
                pSzm.Value = jc_zlxmParam.Szm;
                sqlparams.Add(pSzm);
                }
                
                if (null != jc_zlxmParam.Xmnr && "" != jc_zlxmParam.Xmnr)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.XMNR=:xmnr ");
                    OracleParameter pXmnr = new OracleParameter(":xmnr", OracleDbType.NVarchar2);
                pXmnr.Value = jc_zlxmParam.Xmnr;
                sqlparams.Add(pXmnr);
                }
                
                if (null != jc_zlxmParam.Cwnr && "" != jc_zlxmParam.Cwnr)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.CWNR=:cwnr ");
                    OracleParameter pCwnr = new OracleParameter(":cwnr", OracleDbType.NVarchar2);
                pCwnr.Value = jc_zlxmParam.Cwnr;
                sqlparams.Add(pCwnr);
                }
                
                if (null != jc_zlxmParam.Note && "" != jc_zlxmParam.Note)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.NOTE=:note ");
                    OracleParameter pNote = new OracleParameter(":note", OracleDbType.NVarchar2);
                pNote.Value = jc_zlxmParam.Note;
                sqlparams.Add(pNote);
                }
                
                if (null != jc_zlxmParam.Jcff && "" != jc_zlxmParam.Jcff)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.JCFF=:jcff ");
                    OracleParameter pJcff = new OracleParameter(":jcff", OracleDbType.NVarchar2);
                pJcff.Value = jc_zlxmParam.Jcff;
                sqlparams.Add(pJcff);
                }
                
                if (null != jc_zlxmParam.Biaozhuan && "" != jc_zlxmParam.Biaozhuan)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.BIAOZHUAN=:biaozhuan ");
                    OracleParameter pBiaozhuan = new OracleParameter(":biaozhuan", OracleDbType.NVarchar2);
                pBiaozhuan.Value = jc_zlxmParam.Biaozhuan;
                sqlparams.Add(pBiaozhuan);
                }
                
                if (null != jc_zlxmParam.Jinjian && "" != jc_zlxmParam.Jinjian)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.JINJIAN=:jinjian ");
                    OracleParameter pJinjian = new OracleParameter(":jinjian", OracleDbType.NVarchar2);
                pJinjian.Value = jc_zlxmParam.Jinjian;
                sqlparams.Add(pJinjian);
                }
                
                if (null != jc_zlxmParam.Yinji && "" != jc_zlxmParam.Yinji)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YINJI=:yinji ");
                    OracleParameter pYinji = new OracleParameter(":yinji", OracleDbType.NVarchar2);
                pYinji.Value = jc_zlxmParam.Yinji;
                sqlparams.Add(pYinji);
                }
                
                if (DateTime.MinValue != jc_zlxmParam.Gbsj &&null != jc_zlxmParam.Gbsj)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.GBSJ=:gbsj ");
                    OracleParameter pGbsj = new OracleParameter(":gbsj", OracleDbType.Date);
                pGbsj.Value = jc_zlxmParam.Gbsj;
                sqlparams.Add(pGbsj);
                }
                
                if (null != jc_zlxmParam.Gbjg && "" != jc_zlxmParam.Gbjg)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.GBJG=:gbjg ");
                    OracleParameter pGbjg = new OracleParameter(":gbjg", OracleDbType.NVarchar2);
                pGbjg.Value = jc_zlxmParam.Gbjg;
                sqlparams.Add(pGbjg);
                }
                
                if (null != jc_zlxmParam.Ybbm && "" != jc_zlxmParam.Ybbm)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YBBM=:ybbm ");
                    OracleParameter pYbbm = new OracleParameter(":ybbm", OracleDbType.NVarchar2);
                pYbbm.Value = jc_zlxmParam.Ybbm;
                sqlparams.Add(pYbbm);
                }
                
                if (null != jc_zlxmParam.Nhbm && "" != jc_zlxmParam.Nhbm)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.NHBM=:nhbm ");
                    OracleParameter pNhbm = new OracleParameter(":nhbm", OracleDbType.NVarchar2);
                pNhbm.Value = jc_zlxmParam.Nhbm;
                sqlparams.Add(pNhbm);
                }
                
                if (null != jc_zlxmParam.Nhsflb_code && "" != jc_zlxmParam.Nhsflb_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.NHSFLB_CODE=:nhsflb_code ");
                    OracleParameter pNhsflb_code = new OracleParameter(":nhsflb_code", OracleDbType.NVarchar2);
                pNhsflb_code.Value = jc_zlxmParam.Nhsflb_code;
                sqlparams.Add(pNhsflb_code);
                }
                
                if (null != jc_zlxmParam.Zfbz && "" != jc_zlxmParam.Zfbz)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.ZFBZ=:zfbz ");
                    OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                pZfbz.Value = jc_zlxmParam.Zfbz;
                sqlparams.Add(pZfbz);
                }
                
            if(jc_zlxmParamLike!=null)
            {

                if (null != jc_zlxmParamLike.Xmbh && "" != jc_zlxmParamLike.Xmbh)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.XMBH LIKE '%'||:xmbh||'%' ");
                    OracleParameter pXmbh = new OracleParameter(":xmbh", OracleDbType.NVarchar2);
                    pXmbh.Direction = ParameterDirection.Input;
                    pXmbh.Value = jc_zlxmParamLike.Xmbh;
                    sqlparams.Add(pXmbh);
                }
                
                if (null != jc_zlxmParamLike.Xmmc && "" != jc_zlxmParamLike.Xmmc)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.XMMC LIKE '%'||:xmmc||'%' ");
                    OracleParameter pXmmc = new OracleParameter(":xmmc", OracleDbType.NVarchar2);
                    pXmmc.Direction = ParameterDirection.Input;
                    pXmmc.Value = jc_zlxmParamLike.Xmmc;
                    sqlparams.Add(pXmmc);
                }
                
                if (null != jc_zlxmParamLike.Dw && "" != jc_zlxmParamLike.Dw)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.DW LIKE '%'||:dw||'%' ");
                    OracleParameter pDw = new OracleParameter(":dw", OracleDbType.NVarchar2);
                    pDw.Direction = ParameterDirection.Input;
                    pDw.Value = jc_zlxmParamLike.Dw;
                    sqlparams.Add(pDw);
                }
                
                if (null != jc_zlxmParamLike.Fl_code && "" != jc_zlxmParamLike.Fl_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.FL_CODE LIKE '%'||:fl_code||'%' ");
                    OracleParameter pFl_code = new OracleParameter(":fl_code", OracleDbType.NVarchar2);
                    pFl_code.Direction = ParameterDirection.Input;
                    pFl_code.Value = jc_zlxmParamLike.Fl_code;
                    sqlparams.Add(pFl_code);
                }
                
                if (null != jc_zlxmParamLike.Fygl_code && "" != jc_zlxmParamLike.Fygl_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.FYGL_CODE LIKE '%'||:fygl_code||'%' ");
                    OracleParameter pFygl_code = new OracleParameter(":fygl_code", OracleDbType.NVarchar2);
                    pFygl_code.Direction = ParameterDirection.Input;
                    pFygl_code.Value = jc_zlxmParamLike.Fygl_code;
                    sqlparams.Add(pFygl_code);
                }
                
                if (null != jc_zlxmParamLike.Pym && "" != jc_zlxmParamLike.Pym)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.PYM LIKE '%'||:pym||'%' ");
                    OracleParameter pPym = new OracleParameter(":pym", OracleDbType.NVarchar2);
                    pPym.Direction = ParameterDirection.Input;
                    pPym.Value = jc_zlxmParamLike.Pym;
                    sqlparams.Add(pPym);
                }
                
                if (null != jc_zlxmParamLike.Wbm && "" != jc_zlxmParamLike.Wbm)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.WBM LIKE '%'||:wbm||'%' ");
                    OracleParameter pWbm = new OracleParameter(":wbm", OracleDbType.NVarchar2);
                    pWbm.Direction = ParameterDirection.Input;
                    pWbm.Value = jc_zlxmParamLike.Wbm;
                    sqlparams.Add(pWbm);
                }
                
                if (null != jc_zlxmParamLike.Szm && "" != jc_zlxmParamLike.Szm)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.SZM LIKE '%'||:szm||'%' ");
                    OracleParameter pSzm = new OracleParameter(":szm", OracleDbType.NVarchar2);
                    pSzm.Direction = ParameterDirection.Input;
                    pSzm.Value = jc_zlxmParamLike.Szm;
                    sqlparams.Add(pSzm);
                }
                
                if (null != jc_zlxmParamLike.Xmnr && "" != jc_zlxmParamLike.Xmnr)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.XMNR LIKE '%'||:xmnr||'%' ");
                    OracleParameter pXmnr = new OracleParameter(":xmnr", OracleDbType.NVarchar2);
                    pXmnr.Direction = ParameterDirection.Input;
                    pXmnr.Value = jc_zlxmParamLike.Xmnr;
                    sqlparams.Add(pXmnr);
                }
                
                if (null != jc_zlxmParamLike.Cwnr && "" != jc_zlxmParamLike.Cwnr)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.CWNR LIKE '%'||:cwnr||'%' ");
                    OracleParameter pCwnr = new OracleParameter(":cwnr", OracleDbType.NVarchar2);
                    pCwnr.Direction = ParameterDirection.Input;
                    pCwnr.Value = jc_zlxmParamLike.Cwnr;
                    sqlparams.Add(pCwnr);
                }
                
                if (null != jc_zlxmParamLike.Note && "" != jc_zlxmParamLike.Note)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.NOTE LIKE '%'||:note||'%' ");
                    OracleParameter pNote = new OracleParameter(":note", OracleDbType.NVarchar2);
                    pNote.Direction = ParameterDirection.Input;
                    pNote.Value = jc_zlxmParamLike.Note;
                    sqlparams.Add(pNote);
                }
                
                if (null != jc_zlxmParamLike.Jcff && "" != jc_zlxmParamLike.Jcff)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.JCFF LIKE '%'||:jcff||'%' ");
                    OracleParameter pJcff = new OracleParameter(":jcff", OracleDbType.NVarchar2);
                    pJcff.Direction = ParameterDirection.Input;
                    pJcff.Value = jc_zlxmParamLike.Jcff;
                    sqlparams.Add(pJcff);
                }
                
                if (null != jc_zlxmParamLike.Biaozhuan && "" != jc_zlxmParamLike.Biaozhuan)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.BIAOZHUAN LIKE '%'||:biaozhuan||'%' ");
                    OracleParameter pBiaozhuan = new OracleParameter(":biaozhuan", OracleDbType.NVarchar2);
                    pBiaozhuan.Direction = ParameterDirection.Input;
                    pBiaozhuan.Value = jc_zlxmParamLike.Biaozhuan;
                    sqlparams.Add(pBiaozhuan);
                }
                
                if (null != jc_zlxmParamLike.Jinjian && "" != jc_zlxmParamLike.Jinjian)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.JINJIAN LIKE '%'||:jinjian||'%' ");
                    OracleParameter pJinjian = new OracleParameter(":jinjian", OracleDbType.NVarchar2);
                    pJinjian.Direction = ParameterDirection.Input;
                    pJinjian.Value = jc_zlxmParamLike.Jinjian;
                    sqlparams.Add(pJinjian);
                }
                
                if (null != jc_zlxmParamLike.Yinji && "" != jc_zlxmParamLike.Yinji)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YINJI LIKE '%'||:yinji||'%' ");
                    OracleParameter pYinji = new OracleParameter(":yinji", OracleDbType.NVarchar2);
                    pYinji.Direction = ParameterDirection.Input;
                    pYinji.Value = jc_zlxmParamLike.Yinji;
                    sqlparams.Add(pYinji);
                }
                
                if (null != jc_zlxmParamLike.Gbjg && "" != jc_zlxmParamLike.Gbjg)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.GBJG LIKE '%'||:gbjg||'%' ");
                    OracleParameter pGbjg = new OracleParameter(":gbjg", OracleDbType.NVarchar2);
                    pGbjg.Direction = ParameterDirection.Input;
                    pGbjg.Value = jc_zlxmParamLike.Gbjg;
                    sqlparams.Add(pGbjg);
                }
                
                if (null != jc_zlxmParamLike.Ybbm && "" != jc_zlxmParamLike.Ybbm)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YBBM LIKE '%'||:ybbm||'%' ");
                    OracleParameter pYbbm = new OracleParameter(":ybbm", OracleDbType.NVarchar2);
                    pYbbm.Direction = ParameterDirection.Input;
                    pYbbm.Value = jc_zlxmParamLike.Ybbm;
                    sqlparams.Add(pYbbm);
                }
                
                if (null != jc_zlxmParamLike.Nhbm && "" != jc_zlxmParamLike.Nhbm)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.NHBM LIKE '%'||:nhbm||'%' ");
                    OracleParameter pNhbm = new OracleParameter(":nhbm", OracleDbType.NVarchar2);
                    pNhbm.Direction = ParameterDirection.Input;
                    pNhbm.Value = jc_zlxmParamLike.Nhbm;
                    sqlparams.Add(pNhbm);
                }
                
                if (null != jc_zlxmParamLike.Nhsflb_code && "" != jc_zlxmParamLike.Nhsflb_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.NHSFLB_CODE LIKE '%'||:nhsflb_code||'%' ");
                    OracleParameter pNhsflb_code = new OracleParameter(":nhsflb_code", OracleDbType.NVarchar2);
                    pNhsflb_code.Direction = ParameterDirection.Input;
                    pNhsflb_code.Value = jc_zlxmParamLike.Nhsflb_code;
                    sqlparams.Add(pNhsflb_code);
                }
                
                if (null != jc_zlxmParamLike.Zfbz && "" != jc_zlxmParamLike.Zfbz)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.ZFBZ LIKE '%'||:zfbz||'%' ");
                    OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                    pZfbz.Direction = ParameterDirection.Input;
                    pZfbz.Value = jc_zlxmParamLike.Zfbz;
                    sqlparams.Add(pZfbz);
                }
                
            }

            this.b_isWhere = false;
            return Int32.Parse(OracleHelper.ExecuteScalar(sql.ToString(),sqlparams.ToArray()).ToString());
        }


        /// <summary>
        /// 通用的保存方法，根据用户传入的参数，有ID为修改，没有ID为新增(手动生成OracleConnection对象，此方法用于事务，使用事务必须使用同一个OracleConnection对象)
        /// </summary>
        /// <param name="jc_zlxmParam"></param>
        /// <returns></returns>
        public bool save(Jc_zlxm jc_zlxmParam,OracleConnection con)
        {
            if ("" != jc_zlxmParam.Id && null != jc_zlxmParam.Id)
            {
                //修改
                return this.updateById(jc_zlxmParam,con);
            }
            else
            {
                //新增
                return this.insert(jc_zlxmParam,con);
            }
        }

        /// <summary>
        /// 把dataset中的一行转换为model
        /// </summary>
        /// <param name="row"></param>
        /// <returns></returns>
        private Jc_zlxm dataSetToModel(DataRow row)
        {
            Jc_zlxm jc_zlxmParam = new Jc_zlxm();
            jc_zlxmParam.Id = Convert.ToString(row["ID"]).Trim(); 
            jc_zlxmParam.Xmbh = Convert.ToString(row["XMBH"]).Trim(); 
            jc_zlxmParam.Xmmc = Convert.ToString(row["XMMC"]).Trim(); 
            jc_zlxmParam.Dw = Convert.ToString(row["DW"]).Trim(); 
            jc_zlxmParam.Dj =  (decimal?)this.convertDBNullValue(row["DJ"]);
            jc_zlxmParam.Zgxj =  (decimal?)this.convertDBNullValue(row["ZGXJ"]);
            jc_zlxmParam.Fl_code = Convert.ToString(row["FL_CODE"]).Trim(); 
            jc_zlxmParam.Fygl_code = Convert.ToString(row["FYGL_CODE"]).Trim(); 
            jc_zlxmParam.Pym = Convert.ToString(row["PYM"]).Trim(); 
            jc_zlxmParam.Wbm = Convert.ToString(row["WBM"]).Trim(); 
            jc_zlxmParam.Szm = Convert.ToString(row["SZM"]).Trim(); 
            jc_zlxmParam.Xmnr = Convert.ToString(row["XMNR"]).Trim(); 
            jc_zlxmParam.Cwnr = Convert.ToString(row["CWNR"]).Trim(); 
            jc_zlxmParam.Note = Convert.ToString(row["NOTE"]).Trim(); 
            jc_zlxmParam.Jcff = Convert.ToString(row["JCFF"]).Trim(); 
            jc_zlxmParam.Biaozhuan = Convert.ToString(row["BIAOZHUAN"]).Trim(); 
            jc_zlxmParam.Jinjian = Convert.ToString(row["JINJIAN"]).Trim(); 
            jc_zlxmParam.Yinji = Convert.ToString(row["YINJI"]).Trim(); 
            jc_zlxmParam.Gbsj =  (DateTime?)this.convertDBNullValue(row["GBSJ"]);
            jc_zlxmParam.Gbjg = Convert.ToString(row["GBJG"]).Trim(); 
            jc_zlxmParam.Ybbm = Convert.ToString(row["YBBM"]).Trim(); 
            jc_zlxmParam.Nhbm = Convert.ToString(row["NHBM"]).Trim(); 
            jc_zlxmParam.Nhsflb_code = Convert.ToString(row["NHSFLB_CODE"]).Trim(); 
            jc_zlxmParam.Zfbz = Convert.ToString(row["ZFBZ"]).Trim(); 
            
            return jc_zlxmParam;
        }

       
        
        //*******************在此以后添加新的方法start
        #region DAL层的implement,实现，start

        /// <summary>
        /// 把dataset中的一行转换为model, 包括相关联的外键对象
        /// </summary>
        /// <param name="row"></param>
        /// <returns></returns>
        private Jc_zlxm dataSetContactObjectsToModel(DataRow row)
        {
            Jc_zlxm jc_zlxmParam = this.dataSetToModel(row);

            //添加代码类别实体对象,诊疗项目分类(关联代码表，诊疗项目分类)对象
            Jc_code flCode = new Jc_code();
            flCode.Id = Convert.ToString(row["FL_CODE_ID"]).Trim();
            flCode.Name = Convert.ToString(row["FL_CODE_NAME"]).Trim();
            flCode.Value = Convert.ToString(row["FL_CODE_VALUE"]).Trim();
            flCode.Fk_code_type = Convert.ToString(row["FL_CODE_FKCODETYPE"]).Trim();
            flCode.Zfbz = Convert.ToString(row["FL_CODE_ZFBZ"]).Trim();
            flCode.Remark = Convert.ToString(row["FL_CODE_REMARK"]).Trim();
            jc_zlxmParam.FlCode = flCode;

            //添加代码类别实体对象,费用归类(关联代码表，诊疗项目费用归类)对象
            Jc_code fyglCode = new Jc_code();
            fyglCode.Id = Convert.ToString(row["FYGL_CODE_ID"]).Trim();
            fyglCode.Name = Convert.ToString(row["FYGL_CODE_NAME"]).Trim();
            fyglCode.Value = Convert.ToString(row["FYGL_CODE_VALUE"]).Trim();
            fyglCode.Fk_code_type = Convert.ToString(row["FYGL_CODE_FKCODETYPE"]).Trim();
            fyglCode.Zfbz = Convert.ToString(row["FYGL_CODE_ZFBZ"]).Trim();
            fyglCode.Remark = Convert.ToString(row["FYGL_CODE_REMARK"]).Trim();
            jc_zlxmParam.FyglCode = fyglCode;

            //添加代码类别实体对象,农合收费类别（关联代码表）对象
            Jc_code nhsflbCode = new Jc_code();
            nhsflbCode.Id = Convert.ToString(row["NHSFLB_CODE_ID"]).Trim();
            nhsflbCode.Name = Convert.ToString(row["NHSFLB_CODE_NAME"]).Trim();
            nhsflbCode.Value = Convert.ToString(row["NHSFLB_CODE_VALUE"]).Trim();
            nhsflbCode.Fk_code_type = Convert.ToString(row["NHSFLB_CODE_FKCODETYPE"]).Trim();
            nhsflbCode.Zfbz = Convert.ToString(row["NHSFLB_CODE_ZFBZ"]).Trim();
            nhsflbCode.Remark = Convert.ToString(row["NHSFLB_CODE_REMARK"]).Trim();
            jc_zlxmParam.NhsflbCode = nhsflbCode;

            return jc_zlxmParam;
        }



        /// <summary>
        /// 查找指定ID的用户,得到相关联的外键对象的方法
        /// </summary>
        /// <remarks>如果id为null、id重复、id未找到就抛异常</remarks>
        /// <returns>Jc_zlxm</returns>
        public Jc_zlxm findContactObjectsById(string id)
        {
            if ("" == id || null == id)
            {
                throw new Exception("主键ID不能为空，请赋值");
            }
            StringBuilder sql = new StringBuilder("SELECT A.* ");
            //新建方法findContactObjectsById，在此加入多表连接要显示的项start
            //sql.Append(",B.字段一,B.字段二,B.字段三");

            sql.Append(@"
            ,TT_FL_CODE.ID AS FL_CODE_ID,TT_FL_CODE.NAME AS FL_CODE_NAME,TT_FL_CODE.VALUE AS FL_CODE_VALUE,TT_FL_CODE.FK_CODE_TYPE AS FL_CODE_FKCODETYPE,TT_FL_CODE.ZFBZ AS FL_CODE_ZFBZ,TT_FL_CODE.REMARK AS FL_CODE_REMARK
            ");

            sql.Append(@"
            ,TT_FYGL_CODE.ID AS FYGL_CODE_ID,TT_FYGL_CODE.NAME AS FYGL_CODE_NAME,TT_FYGL_CODE.VALUE AS FYGL_CODE_VALUE,TT_FYGL_CODE.FK_CODE_TYPE AS FYGL_CODE_FKCODETYPE,TT_FYGL_CODE.ZFBZ AS FYGL_CODE_ZFBZ,TT_FYGL_CODE.REMARK AS FYGL_CODE_REMARK
            ");

            sql.Append(@"
            ,TT_NHSFLB_CODE.ID AS NHSFLB_CODE_ID,TT_NHSFLB_CODE.NAME AS NHSFLB_CODE_NAME,TT_NHSFLB_CODE.VALUE AS NHSFLB_CODE_VALUE,TT_NHSFLB_CODE.FK_CODE_TYPE AS NHSFLB_CODE_FKCODETYPE,TT_NHSFLB_CODE.ZFBZ AS NHSFLB_CODE_ZFBZ,TT_NHSFLB_CODE.REMARK AS NHSFLB_CODE_REMARK
            ");

            //新建方法，在此加入多表连接要显示的项end
            sql.Append(" FROM JC_ZLXM A ");
            //新建一个方法，在此加入多表连接的语句start
            //sql.Append("LEFT JOIN 外键表名 B ON A.外键=B.ID");

            sql.Append(@" 
                        LEFT JOIN 
                        (SELECT X.* FROM JC_CODE X WHERE X.FK_CODE_TYPE IN (SELECT Y.ID FROM JC_CODE_TYPE Y WHERE Y.VALUE='" + Model.Common.CommonCode.代码类型值.诊疗项目分类 + @"')) TT_FL_CODE
                        ON A.FL_CODE = TT_FL_CODE.VALUE
            ");

            sql.Append(@" 
                        LEFT JOIN 
                        (SELECT X.* FROM JC_CODE X WHERE X.FK_CODE_TYPE IN (SELECT Y.ID FROM JC_CODE_TYPE Y WHERE Y.VALUE='" + Model.Common.CommonCode.代码类型值.费用归类 + @"')) TT_FYGL_CODE
                        ON A.FYGL_CODE = TT_FYGL_CODE.VALUE
            ");

            sql.Append(@" 
                        LEFT JOIN 
                        (SELECT X.* FROM JC_CODE X WHERE X.FK_CODE_TYPE IN (SELECT Y.ID FROM JC_CODE_TYPE Y WHERE Y.VALUE='" + Model.Common.CommonCode.代码类型值.诊疗项目_农合收费类别 + @"')) TT_NHSFLB_CODE
                        ON A.NHSFLB_CODE = TT_NHSFLB_CODE.VALUE
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
        /// <param name="jc_zlxmParam"></param>
        /// <param name="page">分页对象</param>
        ///<param name="jc_zlxmParamLike">模糊查询参数</param>
        ///<param name="sortList">排序参数对象的集合</param>
        /// <returns>满足条件的所有Jc_zlxm对象集合list</returns>
        public List<object> findContactObjects(Jc_zlxm jc_zlxmParam, Model.Common.PageInfo page, Jc_zlxm jc_zlxmParamLike, List<SortInfo> sortList)
        {
            //如果没有传查询条件参数，就new一个空的Jc_zlxm对象，标示查询所有数据
            if (null == jc_zlxmParam)
            {
                jc_zlxmParam = new Jc_zlxm();
            }
            if (null != jc_zlxmParam.Id && "" != jc_zlxmParam.Id)
            {
                throw new Exception("此方法不允许指定参数ID，如果需要根据ID查询数据，请调用findById方法；错误出自：find");
            }

            List<Jc_zlxm> jc_zlxmParamList = new List<Jc_zlxm>();//接收查询出的Jc_zlxm对象集合
            List<OracleParameter> sqlparams = new List<OracleParameter>();//保存参数的集合
            StringBuilder sql = new StringBuilder("SELECT A.* ");
            //新建方法findAllContactObjects(Jc_zlxm jc_zlxmParam, Model.Common.PageInfo page)，在此加入多表连接要显示的项start
            //sql.Append(",B.字段一,B.字段二,B.字段三");

            sql.Append(@"
            ,TT_FL_CODE.ID AS FL_CODE_ID,TT_FL_CODE.NAME AS FL_CODE_NAME,TT_FL_CODE.VALUE AS FL_CODE_VALUE,TT_FL_CODE.FK_CODE_TYPE AS FL_CODE_FKCODETYPE,TT_FL_CODE.ZFBZ AS FL_CODE_ZFBZ,TT_FL_CODE.REMARK AS FL_CODE_REMARK
            ");

            sql.Append(@"
            ,TT_FYGL_CODE.ID AS FYGL_CODE_ID,TT_FYGL_CODE.NAME AS FYGL_CODE_NAME,TT_FYGL_CODE.VALUE AS FYGL_CODE_VALUE,TT_FYGL_CODE.FK_CODE_TYPE AS FYGL_CODE_FKCODETYPE,TT_FYGL_CODE.ZFBZ AS FYGL_CODE_ZFBZ,TT_FYGL_CODE.REMARK AS FYGL_CODE_REMARK
            ");

            sql.Append(@"
            ,TT_NHSFLB_CODE.ID AS NHSFLB_CODE_ID,TT_NHSFLB_CODE.NAME AS NHSFLB_CODE_NAME,TT_NHSFLB_CODE.VALUE AS NHSFLB_CODE_VALUE,TT_NHSFLB_CODE.FK_CODE_TYPE AS NHSFLB_CODE_FKCODETYPE,TT_NHSFLB_CODE.ZFBZ AS NHSFLB_CODE_ZFBZ,TT_NHSFLB_CODE.REMARK AS NHSFLB_CODE_REMARK
            ");

            //新建方法，在此加入多表连接要显示的项end
            sql.Append(" FROM JC_ZLXM A ");
            //新建一个方法，在此加入多表连接的语句start
            ////sql.Append(" LEFT JOIN 表名 B ON A.外键=B.ID");

            sql.Append(@" 
                        LEFT JOIN 
                        (SELECT X.* FROM JC_CODE X WHERE X.FK_CODE_TYPE IN (SELECT Y.ID FROM JC_CODE_TYPE Y WHERE Y.VALUE='" + Model.Common.CommonCode.代码类型值.诊疗项目分类 + @"')) TT_FL_CODE
                        ON A.FL_CODE = TT_FL_CODE.VALUE
            ");

            sql.Append(@" 
                        LEFT JOIN 
                        (SELECT X.* FROM JC_CODE X WHERE X.FK_CODE_TYPE IN (SELECT Y.ID FROM JC_CODE_TYPE Y WHERE Y.VALUE='" + Model.Common.CommonCode.代码类型值.费用归类 + @"')) TT_FYGL_CODE
                        ON A.FYGL_CODE = TT_FYGL_CODE.VALUE
            ");

            sql.Append(@" 
                        LEFT JOIN 
                        (SELECT X.* FROM JC_CODE X WHERE X.FK_CODE_TYPE IN (SELECT Y.ID FROM JC_CODE_TYPE Y WHERE Y.VALUE='" + Model.Common.CommonCode.代码类型值.诊疗项目_农合收费类别 + @"')) TT_NHSFLB_CODE
                        ON A.NHSFLB_CODE = TT_NHSFLB_CODE.VALUE
            ");

            //新建一个方法，在此加入多表连接的语句end


            if (null != jc_zlxmParam.Xmbh && "" != jc_zlxmParam.Xmbh)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.XMBH=:xmbh ");
                OracleParameter pXmbh = new OracleParameter(":xmbh", OracleDbType.NVarchar2);
                pXmbh.Value = jc_zlxmParam.Xmbh;
                sqlparams.Add(pXmbh);
            }

            if (null != jc_zlxmParam.Xmmc && "" != jc_zlxmParam.Xmmc)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.XMMC=:xmmc ");
                OracleParameter pXmmc = new OracleParameter(":xmmc", OracleDbType.NVarchar2);
                pXmmc.Value = jc_zlxmParam.Xmmc;
                sqlparams.Add(pXmmc);
            }

            if (null != jc_zlxmParam.Dw && "" != jc_zlxmParam.Dw)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.DW=:dw ");
                OracleParameter pDw = new OracleParameter(":dw", OracleDbType.NVarchar2);
                pDw.Value = jc_zlxmParam.Dw;
                sqlparams.Add(pDw);
            }

            if (null != jc_zlxmParam.Dj)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" DJ=:dj ");
                OracleParameter pDj = new OracleParameter(":dj", OracleDbType.Decimal);
                pDj.Value = jc_zlxmParam.Dj;
                sqlparams.Add(pDj);

            }

            if (null != jc_zlxmParam.Zgxj)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" ZGXJ=:zgxj ");
                OracleParameter pZgxj = new OracleParameter(":zgxj", OracleDbType.Decimal);
                pZgxj.Value = jc_zlxmParam.Zgxj;
                sqlparams.Add(pZgxj);

            }

            if (null != jc_zlxmParam.Fl_code && "" != jc_zlxmParam.Fl_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.FL_CODE=:fl_code ");
                OracleParameter pFl_code = new OracleParameter(":fl_code", OracleDbType.NVarchar2);
                pFl_code.Value = jc_zlxmParam.Fl_code;
                sqlparams.Add(pFl_code);
            }

            if (null != jc_zlxmParam.Fygl_code && "" != jc_zlxmParam.Fygl_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.FYGL_CODE=:fygl_code ");
                OracleParameter pFygl_code = new OracleParameter(":fygl_code", OracleDbType.NVarchar2);
                pFygl_code.Value = jc_zlxmParam.Fygl_code;
                sqlparams.Add(pFygl_code);
            }

            if (null != jc_zlxmParam.Pym && "" != jc_zlxmParam.Pym)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.PYM=:pym ");
                OracleParameter pPym = new OracleParameter(":pym", OracleDbType.NVarchar2);
                pPym.Value = jc_zlxmParam.Pym;
                sqlparams.Add(pPym);
            }

            if (null != jc_zlxmParam.Wbm && "" != jc_zlxmParam.Wbm)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.WBM=:wbm ");
                OracleParameter pWbm = new OracleParameter(":wbm", OracleDbType.NVarchar2);
                pWbm.Value = jc_zlxmParam.Wbm;
                sqlparams.Add(pWbm);
            }

            if (null != jc_zlxmParam.Szm && "" != jc_zlxmParam.Szm)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.SZM=:szm ");
                OracleParameter pSzm = new OracleParameter(":szm", OracleDbType.NVarchar2);
                pSzm.Value = jc_zlxmParam.Szm;
                sqlparams.Add(pSzm);
            }

            if (null != jc_zlxmParam.Xmnr && "" != jc_zlxmParam.Xmnr)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.XMNR=:xmnr ");
                OracleParameter pXmnr = new OracleParameter(":xmnr", OracleDbType.NVarchar2);
                pXmnr.Value = jc_zlxmParam.Xmnr;
                sqlparams.Add(pXmnr);
            }

            if (null != jc_zlxmParam.Cwnr && "" != jc_zlxmParam.Cwnr)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.CWNR=:cwnr ");
                OracleParameter pCwnr = new OracleParameter(":cwnr", OracleDbType.NVarchar2);
                pCwnr.Value = jc_zlxmParam.Cwnr;
                sqlparams.Add(pCwnr);
            }

            if (null != jc_zlxmParam.Note && "" != jc_zlxmParam.Note)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.NOTE=:note ");
                OracleParameter pNote = new OracleParameter(":note", OracleDbType.NVarchar2);
                pNote.Value = jc_zlxmParam.Note;
                sqlparams.Add(pNote);
            }

            if (null != jc_zlxmParam.Jcff && "" != jc_zlxmParam.Jcff)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.JCFF=:jcff ");
                OracleParameter pJcff = new OracleParameter(":jcff", OracleDbType.NVarchar2);
                pJcff.Value = jc_zlxmParam.Jcff;
                sqlparams.Add(pJcff);
            }

            if (null != jc_zlxmParam.Biaozhuan && "" != jc_zlxmParam.Biaozhuan)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.BIAOZHUAN=:biaozhuan ");
                OracleParameter pBiaozhuan = new OracleParameter(":biaozhuan", OracleDbType.NVarchar2);
                pBiaozhuan.Value = jc_zlxmParam.Biaozhuan;
                sqlparams.Add(pBiaozhuan);
            }

            if (null != jc_zlxmParam.Jinjian && "" != jc_zlxmParam.Jinjian)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.JINJIAN=:jinjian ");
                OracleParameter pJinjian = new OracleParameter(":jinjian", OracleDbType.NVarchar2);
                pJinjian.Value = jc_zlxmParam.Jinjian;
                sqlparams.Add(pJinjian);
            }

            if (null != jc_zlxmParam.Yinji && "" != jc_zlxmParam.Yinji)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.YINJI=:yinji ");
                OracleParameter pYinji = new OracleParameter(":yinji", OracleDbType.NVarchar2);
                pYinji.Value = jc_zlxmParam.Yinji;
                sqlparams.Add(pYinji);
            }

            if (DateTime.MinValue != jc_zlxmParam.Gbsj && null != jc_zlxmParam.Gbsj)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.GBSJ=:gbsj ");
                OracleParameter pGbsj = new OracleParameter(":gbsj", OracleDbType.Date);
                pGbsj.Value = jc_zlxmParam.Gbsj;
                sqlparams.Add(pGbsj);
            }

            if (null != jc_zlxmParam.Gbjg && "" != jc_zlxmParam.Gbjg)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.GBJG=:gbjg ");
                OracleParameter pGbjg = new OracleParameter(":gbjg", OracleDbType.NVarchar2);
                pGbjg.Value = jc_zlxmParam.Gbjg;
                sqlparams.Add(pGbjg);
            }

            if (null != jc_zlxmParam.Ybbm && "" != jc_zlxmParam.Ybbm)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.YBBM=:ybbm ");
                OracleParameter pYbbm = new OracleParameter(":ybbm", OracleDbType.NVarchar2);
                pYbbm.Value = jc_zlxmParam.Ybbm;
                sqlparams.Add(pYbbm);
            }

            if (null != jc_zlxmParam.Nhbm && "" != jc_zlxmParam.Nhbm)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.NHBM=:nhbm ");
                OracleParameter pNhbm = new OracleParameter(":nhbm", OracleDbType.NVarchar2);
                pNhbm.Value = jc_zlxmParam.Nhbm;
                sqlparams.Add(pNhbm);
            }

            if (null != jc_zlxmParam.Nhsflb_code && "" != jc_zlxmParam.Nhsflb_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.NHSFLB_CODE=:nhsflb_code ");
                OracleParameter pNhsflb_code = new OracleParameter(":nhsflb_code", OracleDbType.NVarchar2);
                pNhsflb_code.Value = jc_zlxmParam.Nhsflb_code;
                sqlparams.Add(pNhsflb_code);
            }

            if (null != jc_zlxmParam.Zfbz && "" != jc_zlxmParam.Zfbz)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.ZFBZ=:zfbz ");
                OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                pZfbz.Value = jc_zlxmParam.Zfbz;
                sqlparams.Add(pZfbz);
            }

            if (jc_zlxmParamLike != null)
            {

                if (null != jc_zlxmParamLike.Xmbh && "" != jc_zlxmParamLike.Xmbh)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.XMBH LIKE '%'||:xmbh||'%' ");
                    OracleParameter pXmbh = new OracleParameter(":xmbh", OracleDbType.NVarchar2);
                    pXmbh.Direction = ParameterDirection.Input;
                    pXmbh.Value = jc_zlxmParamLike.Xmbh;
                    sqlparams.Add(pXmbh);
                }

                if (null != jc_zlxmParamLike.Xmmc && "" != jc_zlxmParamLike.Xmmc)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.XMMC LIKE '%'||:xmmc||'%' ");
                    OracleParameter pXmmc = new OracleParameter(":xmmc", OracleDbType.NVarchar2);
                    pXmmc.Direction = ParameterDirection.Input;
                    pXmmc.Value = jc_zlxmParamLike.Xmmc;
                    sqlparams.Add(pXmmc);
                }

                if (null != jc_zlxmParamLike.Dw && "" != jc_zlxmParamLike.Dw)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.DW LIKE '%'||:dw||'%' ");
                    OracleParameter pDw = new OracleParameter(":dw", OracleDbType.NVarchar2);
                    pDw.Direction = ParameterDirection.Input;
                    pDw.Value = jc_zlxmParamLike.Dw;
                    sqlparams.Add(pDw);
                }

                if (null != jc_zlxmParamLike.Fl_code && "" != jc_zlxmParamLike.Fl_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.FL_CODE LIKE '%'||:fl_code||'%' ");
                    OracleParameter pFl_code = new OracleParameter(":fl_code", OracleDbType.NVarchar2);
                    pFl_code.Direction = ParameterDirection.Input;
                    pFl_code.Value = jc_zlxmParamLike.Fl_code;
                    sqlparams.Add(pFl_code);
                }

                if (null != jc_zlxmParamLike.Fygl_code && "" != jc_zlxmParamLike.Fygl_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.FYGL_CODE LIKE '%'||:fygl_code||'%' ");
                    OracleParameter pFygl_code = new OracleParameter(":fygl_code", OracleDbType.NVarchar2);
                    pFygl_code.Direction = ParameterDirection.Input;
                    pFygl_code.Value = jc_zlxmParamLike.Fygl_code;
                    sqlparams.Add(pFygl_code);
                }

                if (null != jc_zlxmParamLike.Pym && "" != jc_zlxmParamLike.Pym)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.PYM LIKE '%'||:pym||'%' ");
                    OracleParameter pPym = new OracleParameter(":pym", OracleDbType.NVarchar2);
                    pPym.Direction = ParameterDirection.Input;
                    pPym.Value = jc_zlxmParamLike.Pym;
                    sqlparams.Add(pPym);
                }

                if (null != jc_zlxmParamLike.Wbm && "" != jc_zlxmParamLike.Wbm)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.WBM LIKE '%'||:wbm||'%' ");
                    OracleParameter pWbm = new OracleParameter(":wbm", OracleDbType.NVarchar2);
                    pWbm.Direction = ParameterDirection.Input;
                    pWbm.Value = jc_zlxmParamLike.Wbm;
                    sqlparams.Add(pWbm);
                }

                if (null != jc_zlxmParamLike.Szm && "" != jc_zlxmParamLike.Szm)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.SZM LIKE '%'||:szm||'%' ");
                    OracleParameter pSzm = new OracleParameter(":szm", OracleDbType.NVarchar2);
                    pSzm.Direction = ParameterDirection.Input;
                    pSzm.Value = jc_zlxmParamLike.Szm;
                    sqlparams.Add(pSzm);
                }

                if (null != jc_zlxmParamLike.Xmnr && "" != jc_zlxmParamLike.Xmnr)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.XMNR LIKE '%'||:xmnr||'%' ");
                    OracleParameter pXmnr = new OracleParameter(":xmnr", OracleDbType.NVarchar2);
                    pXmnr.Direction = ParameterDirection.Input;
                    pXmnr.Value = jc_zlxmParamLike.Xmnr;
                    sqlparams.Add(pXmnr);
                }

                if (null != jc_zlxmParamLike.Cwnr && "" != jc_zlxmParamLike.Cwnr)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.CWNR LIKE '%'||:cwnr||'%' ");
                    OracleParameter pCwnr = new OracleParameter(":cwnr", OracleDbType.NVarchar2);
                    pCwnr.Direction = ParameterDirection.Input;
                    pCwnr.Value = jc_zlxmParamLike.Cwnr;
                    sqlparams.Add(pCwnr);
                }

                if (null != jc_zlxmParamLike.Note && "" != jc_zlxmParamLike.Note)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.NOTE LIKE '%'||:note||'%' ");
                    OracleParameter pNote = new OracleParameter(":note", OracleDbType.NVarchar2);
                    pNote.Direction = ParameterDirection.Input;
                    pNote.Value = jc_zlxmParamLike.Note;
                    sqlparams.Add(pNote);
                }

                if (null != jc_zlxmParamLike.Jcff && "" != jc_zlxmParamLike.Jcff)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.JCFF LIKE '%'||:jcff||'%' ");
                    OracleParameter pJcff = new OracleParameter(":jcff", OracleDbType.NVarchar2);
                    pJcff.Direction = ParameterDirection.Input;
                    pJcff.Value = jc_zlxmParamLike.Jcff;
                    sqlparams.Add(pJcff);
                }

                if (null != jc_zlxmParamLike.Biaozhuan && "" != jc_zlxmParamLike.Biaozhuan)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.BIAOZHUAN LIKE '%'||:biaozhuan||'%' ");
                    OracleParameter pBiaozhuan = new OracleParameter(":biaozhuan", OracleDbType.NVarchar2);
                    pBiaozhuan.Direction = ParameterDirection.Input;
                    pBiaozhuan.Value = jc_zlxmParamLike.Biaozhuan;
                    sqlparams.Add(pBiaozhuan);
                }

                if (null != jc_zlxmParamLike.Jinjian && "" != jc_zlxmParamLike.Jinjian)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.JINJIAN LIKE '%'||:jinjian||'%' ");
                    OracleParameter pJinjian = new OracleParameter(":jinjian", OracleDbType.NVarchar2);
                    pJinjian.Direction = ParameterDirection.Input;
                    pJinjian.Value = jc_zlxmParamLike.Jinjian;
                    sqlparams.Add(pJinjian);
                }

                if (null != jc_zlxmParamLike.Yinji && "" != jc_zlxmParamLike.Yinji)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YINJI LIKE '%'||:yinji||'%' ");
                    OracleParameter pYinji = new OracleParameter(":yinji", OracleDbType.NVarchar2);
                    pYinji.Direction = ParameterDirection.Input;
                    pYinji.Value = jc_zlxmParamLike.Yinji;
                    sqlparams.Add(pYinji);
                }

                if (null != jc_zlxmParamLike.Gbjg && "" != jc_zlxmParamLike.Gbjg)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.GBJG LIKE '%'||:gbjg||'%' ");
                    OracleParameter pGbjg = new OracleParameter(":gbjg", OracleDbType.NVarchar2);
                    pGbjg.Direction = ParameterDirection.Input;
                    pGbjg.Value = jc_zlxmParamLike.Gbjg;
                    sqlparams.Add(pGbjg);
                }

                if (null != jc_zlxmParamLike.Ybbm && "" != jc_zlxmParamLike.Ybbm)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YBBM LIKE '%'||:ybbm||'%' ");
                    OracleParameter pYbbm = new OracleParameter(":ybbm", OracleDbType.NVarchar2);
                    pYbbm.Direction = ParameterDirection.Input;
                    pYbbm.Value = jc_zlxmParamLike.Ybbm;
                    sqlparams.Add(pYbbm);
                }

                if (null != jc_zlxmParamLike.Nhbm && "" != jc_zlxmParamLike.Nhbm)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.NHBM LIKE '%'||:nhbm||'%' ");
                    OracleParameter pNhbm = new OracleParameter(":nhbm", OracleDbType.NVarchar2);
                    pNhbm.Direction = ParameterDirection.Input;
                    pNhbm.Value = jc_zlxmParamLike.Nhbm;
                    sqlparams.Add(pNhbm);
                }

                if (null != jc_zlxmParamLike.Nhsflb_code && "" != jc_zlxmParamLike.Nhsflb_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.NHSFLB_CODE LIKE '%'||:nhsflb_code||'%' ");
                    OracleParameter pNhsflb_code = new OracleParameter(":nhsflb_code", OracleDbType.NVarchar2);
                    pNhsflb_code.Direction = ParameterDirection.Input;
                    pNhsflb_code.Value = jc_zlxmParamLike.Nhsflb_code;
                    sqlparams.Add(pNhsflb_code);
                }

                if (null != jc_zlxmParamLike.Zfbz && "" != jc_zlxmParamLike.Zfbz)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.ZFBZ LIKE '%'||:zfbz||'%' ");
                    OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                    pZfbz.Direction = ParameterDirection.Input;
                    pZfbz.Value = jc_zlxmParamLike.Zfbz;
                    sqlparams.Add(pZfbz);
                }

            }

            this.b_isWhere = false;
            //排序
            this.addSort(sql, sortList);
            //*******分页start1*********如果分页对象为空，则全部数据查出，如果不为空
            List<object> returnList = new List<object>();//返回的List,索引0为List<Jc_zlxm>对象,索引1为Model.Common.PageInfo分页信息对象
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
            //把每一行数据转换为一个对象放入List<Jc_zlxm>中
            for (int i = 0; i < rows.Count; i++)
            {
                DataRow row = rows[i];
                jc_zlxmParamList.Add(this.dataSetContactObjectsToModel(row));
                //jc_zlxmParamList.Add(this.dataSetToModel(row));
            }

            //*******分页start2*********如果没有传入分页对象，则新建一个分页对象当做返回值
            if (null == page)
            {
                page = new Model.Common.PageInfo();
                page.AllCount = rows.Count;
            }
            returnList.Add(jc_zlxmParamList);//把List<Jc_zlxm>放入List<object>中第一个
            returnList.Add(page);//把page对象放入List<object>中第二个
            //*******分页end2*********
            return returnList;
        }
        #endregion DAL层的implement,实现，end

        //*******************在此以后添加新的方法end
        
    }
}


