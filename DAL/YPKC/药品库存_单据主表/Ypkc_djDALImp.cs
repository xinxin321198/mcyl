

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

namespace DAL.YPKC.药品库存_单据主表
{
    /// <summary>
    ///数据库访问层的Ypkc_dj实现类
    ///此类由代码生成器生成
    ///表名：YPKC_DJ
    ///生成日期：2015-12-17 16:58:01
    /// 

    ///作者：罗新鑫
    ///联系电话：15087010221
    ///联系邮箱：362527240@qq.com
        
    /// </summary>
    public class Ypkc_djDALImp :Base.BasDAL,Ypkc_djDAL
    {
        /// <summary>
        /// 插入一条数据（如果需要供事务使用就传入OracleConnection对象，如果不供就传入null，方法自动生成OracleConnection对象）
        /// 主键为null时，自动生成主键guid，一般不直接调用此方法，请调用save方法进行单条数据的插入和修改       
        /// </summary>
        /// <param name="ypkc_djParam">要插入的ypkc_djParam对象</param>
        /// <param name="con">Oracle连接对象（为null时自动生成）</param>
        /// <returns>是否添加成功（影响的行数为1时成功）</returns>
        public bool insert(Ypkc_dj ypkc_djParam, OracleConnection con)
        {
            if ("" == ypkc_djParam.Id || null == ypkc_djParam.Id)
            {
                ypkc_djParam.Id = Model.Common.GUIDHelper.getGuid();
            }
            List<OracleParameter> sqlparams = new List<OracleParameter>();

            StringBuilder sql = new StringBuilder("INSERT INTO YPKC_DJ(id,djh,djlx_code,ypfl_code,fk_lygys,fk_lyks,lybh,lymc,fk_mdks,fk_mdgys,mdbh,mdmc,zdr,fk_renyuan_zdr,jzr,fk_renyuan_jzr,zdsj,jzsj,jzzt_code,remark,caigoufs_code,peisongfs_code,goujinsj,yanshou_code,chuliyj,chulijg,tuihuozt_code,fk_shr,shrxm,shsj,zfbz) VALUES(:id,:djh,:djlx_code,:ypfl_code,:fk_lygys,:fk_lyks,:lybh,:lymc,:fk_mdks,:fk_mdgys,:mdbh,:mdmc,:zdr,:fk_renyuan_zdr,:jzr,:fk_renyuan_jzr,:zdsj,:jzsj,:jzzt_code,:remark,:caigoufs_code,:peisongfs_code,:goujinsj,:yanshou_code,:chuliyj,:chulijg,:tuihuozt_code,:fk_shr,:shrxm,:shsj,:zfbz)");

            OracleParameter pId = new OracleParameter(":id", OracleDbType.Varchar2);
            pId.Direction = ParameterDirection.Input;
            pId.Value = ypkc_djParam.Id;
            sqlparams.Add(pId);
            OracleParameter pDjh = new OracleParameter(":djh", OracleDbType.Decimal);
            pDjh.Direction = ParameterDirection.Input;
            pDjh.Value = ypkc_djParam.Djh;
            sqlparams.Add(pDjh);
            OracleParameter pDjlx_code = new OracleParameter(":djlx_code", OracleDbType.NVarchar2);
            pDjlx_code.Direction = ParameterDirection.Input;
            pDjlx_code.Value = ypkc_djParam.Djlx_code;
            sqlparams.Add(pDjlx_code);
            OracleParameter pYpfl_code = new OracleParameter(":ypfl_code", OracleDbType.NVarchar2);
            pYpfl_code.Direction = ParameterDirection.Input;
            pYpfl_code.Value = ypkc_djParam.Ypfl_code;
            sqlparams.Add(pYpfl_code);
            OracleParameter pFk_lygys = new OracleParameter(":fk_lygys", OracleDbType.Varchar2);
            pFk_lygys.Direction = ParameterDirection.Input;
            pFk_lygys.Value = ypkc_djParam.Fk_lygys;
            sqlparams.Add(pFk_lygys);
            OracleParameter pFk_lyks = new OracleParameter(":fk_lyks", OracleDbType.Varchar2);
            pFk_lyks.Direction = ParameterDirection.Input;
            pFk_lyks.Value = ypkc_djParam.Fk_lyks;
            sqlparams.Add(pFk_lyks);
            OracleParameter pLybh = new OracleParameter(":lybh", OracleDbType.Varchar2);
            pLybh.Direction = ParameterDirection.Input;
            pLybh.Value = ypkc_djParam.Lybh;
            sqlparams.Add(pLybh);
            OracleParameter pLymc = new OracleParameter(":lymc", OracleDbType.NVarchar2);
            pLymc.Direction = ParameterDirection.Input;
            pLymc.Value = ypkc_djParam.Lymc;
            sqlparams.Add(pLymc);
            OracleParameter pFk_mdks = new OracleParameter(":fk_mdks", OracleDbType.Varchar2);
            pFk_mdks.Direction = ParameterDirection.Input;
            pFk_mdks.Value = ypkc_djParam.Fk_mdks;
            sqlparams.Add(pFk_mdks);
            OracleParameter pFk_mdgys = new OracleParameter(":fk_mdgys", OracleDbType.Varchar2);
            pFk_mdgys.Direction = ParameterDirection.Input;
            pFk_mdgys.Value = ypkc_djParam.Fk_mdgys;
            sqlparams.Add(pFk_mdgys);
            OracleParameter pMdbh = new OracleParameter(":mdbh", OracleDbType.Varchar2);
            pMdbh.Direction = ParameterDirection.Input;
            pMdbh.Value = ypkc_djParam.Mdbh;
            sqlparams.Add(pMdbh);
            OracleParameter pMdmc = new OracleParameter(":mdmc", OracleDbType.NVarchar2);
            pMdmc.Direction = ParameterDirection.Input;
            pMdmc.Value = ypkc_djParam.Mdmc;
            sqlparams.Add(pMdmc);
            OracleParameter pZdr = new OracleParameter(":zdr", OracleDbType.Varchar2);
            pZdr.Direction = ParameterDirection.Input;
            pZdr.Value = ypkc_djParam.Zdr;
            sqlparams.Add(pZdr);
            OracleParameter pFk_renyuan_zdr = new OracleParameter(":fk_renyuan_zdr", OracleDbType.Varchar2);
            pFk_renyuan_zdr.Direction = ParameterDirection.Input;
            pFk_renyuan_zdr.Value = ypkc_djParam.Fk_renyuan_zdr;
            sqlparams.Add(pFk_renyuan_zdr);
            OracleParameter pJzr = new OracleParameter(":jzr", OracleDbType.Varchar2);
            pJzr.Direction = ParameterDirection.Input;
            pJzr.Value = ypkc_djParam.Jzr;
            sqlparams.Add(pJzr);
            OracleParameter pFk_renyuan_jzr = new OracleParameter(":fk_renyuan_jzr", OracleDbType.Varchar2);
            pFk_renyuan_jzr.Direction = ParameterDirection.Input;
            pFk_renyuan_jzr.Value = ypkc_djParam.Fk_renyuan_jzr;
            sqlparams.Add(pFk_renyuan_jzr);
            OracleParameter pZdsj = new OracleParameter(":zdsj", OracleDbType.Date);
            pZdsj.Direction = ParameterDirection.Input;
            pZdsj.Value = ypkc_djParam.Zdsj;
            sqlparams.Add(pZdsj);
            OracleParameter pJzsj = new OracleParameter(":jzsj", OracleDbType.Date);
            pJzsj.Direction = ParameterDirection.Input;
            pJzsj.Value = ypkc_djParam.Jzsj;
            sqlparams.Add(pJzsj);
            OracleParameter pJzzt_code = new OracleParameter(":jzzt_code", OracleDbType.Varchar2);
            pJzzt_code.Direction = ParameterDirection.Input;
            pJzzt_code.Value = ypkc_djParam.Jzzt_code;
            sqlparams.Add(pJzzt_code);
            OracleParameter pRemark = new OracleParameter(":remark", OracleDbType.Varchar2);
            pRemark.Direction = ParameterDirection.Input;
            pRemark.Value = ypkc_djParam.Remark;
            sqlparams.Add(pRemark);
            OracleParameter pCaigoufs_code = new OracleParameter(":caigoufs_code", OracleDbType.NVarchar2);
            pCaigoufs_code.Direction = ParameterDirection.Input;
            pCaigoufs_code.Value = ypkc_djParam.Caigoufs_code;
            sqlparams.Add(pCaigoufs_code);
            OracleParameter pPeisongfs_code = new OracleParameter(":peisongfs_code", OracleDbType.NVarchar2);
            pPeisongfs_code.Direction = ParameterDirection.Input;
            pPeisongfs_code.Value = ypkc_djParam.Peisongfs_code;
            sqlparams.Add(pPeisongfs_code);
            OracleParameter pGoujinsj = new OracleParameter(":goujinsj", OracleDbType.Date);
            pGoujinsj.Direction = ParameterDirection.Input;
            pGoujinsj.Value = ypkc_djParam.Goujinsj;
            sqlparams.Add(pGoujinsj);
            OracleParameter pYanshou_code = new OracleParameter(":yanshou_code", OracleDbType.NVarchar2);
            pYanshou_code.Direction = ParameterDirection.Input;
            pYanshou_code.Value = ypkc_djParam.Yanshou_code;
            sqlparams.Add(pYanshou_code);
            OracleParameter pChuliyj = new OracleParameter(":chuliyj", OracleDbType.NVarchar2);
            pChuliyj.Direction = ParameterDirection.Input;
            pChuliyj.Value = ypkc_djParam.Chuliyj;
            sqlparams.Add(pChuliyj);
            OracleParameter pChulijg = new OracleParameter(":chulijg", OracleDbType.NVarchar2);
            pChulijg.Direction = ParameterDirection.Input;
            pChulijg.Value = ypkc_djParam.Chulijg;
            sqlparams.Add(pChulijg);
            OracleParameter pTuihuozt_code = new OracleParameter(":tuihuozt_code", OracleDbType.NVarchar2);
            pTuihuozt_code.Direction = ParameterDirection.Input;
            pTuihuozt_code.Value = ypkc_djParam.Tuihuozt_code;
            sqlparams.Add(pTuihuozt_code);
            OracleParameter pFk_shr = new OracleParameter(":fk_shr", OracleDbType.Varchar2);
            pFk_shr.Direction = ParameterDirection.Input;
            pFk_shr.Value = ypkc_djParam.Fk_shr;
            sqlparams.Add(pFk_shr);
            OracleParameter pShrxm = new OracleParameter(":shrxm", OracleDbType.NVarchar2);
            pShrxm.Direction = ParameterDirection.Input;
            pShrxm.Value = ypkc_djParam.Shrxm;
            sqlparams.Add(pShrxm);
            OracleParameter pShsj = new OracleParameter(":shsj", OracleDbType.Date);
            pShsj.Direction = ParameterDirection.Input;
            pShsj.Value = ypkc_djParam.Shsj;
            sqlparams.Add(pShsj);
            OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
            pZfbz.Direction = ParameterDirection.Input;
            pZfbz.Value = ypkc_djParam.Zfbz;
            sqlparams.Add(pZfbz);
            bool result = false;
            int flag = OracleHelper.ExecuteNonQuery(sql.ToString(), con, sqlparams.ToArray());
            if (1 == flag)
            {
                result = true;
            }
            return result;

        }


        /// <summary>
        /// 插入一条数据，单据号使用sequences，制单时间和购入时间为当前数据插入的时间（如果需要供事务使用就传入OracleConnection对象，如果不供就传入null，方法自动生成OracleConnection对象）
        /// 主键为null时，自动生成主键guid，一般不直接调用此方法，请调用save方法进行单条数据的插入和修改       
        /// </summary>
        /// <param name="ypkc_djParam">要插入的ypkc_djParam对象</param>
        /// <param name="con">Oracle连接对象（为null时自动生成）</param>
        /// <returns>是否添加成功（影响的行数为1时成功）</returns>
        public bool insertForLshSequences(Ypkc_dj ypkc_djParam,OracleConnection con)
        {
            if (""==ypkc_djParam.Id||null==ypkc_djParam.Id)
            {
                ypkc_djParam.Id = Model.Common.GUIDHelper.getGuid();
            }
            List<OracleParameter> sqlparams = new List<OracleParameter>();

            StringBuilder sql = new StringBuilder("INSERT INTO YPKC_DJ(id,djh,djlx_code,ypfl_code,fk_lygys,fk_lyks,lybh,lymc,fk_mdks,fk_mdgys,mdbh,mdmc,zdr,fk_renyuan_zdr,jzr,fk_renyuan_jzr,zdsj,jzsj,jzzt_code,remark,caigoufs_code,peisongfs_code,goujinsj,yanshou_code,chuliyj,chulijg,tuihuozt_code,fk_shr,shrxm,shsj,zfbz) VALUES(:id,ypkc_djh.nextval,:djlx_code,:ypfl_code,:fk_lygys,:fk_lyks,:lybh,:lymc,:fk_mdks,:fk_mdgys,:mdbh,:mdmc,:zdr,:fk_renyuan_zdr,:jzr,:fk_renyuan_jzr,SYSDATE,:jzsj,:jzzt_code,:remark,:caigoufs_code,:peisongfs_code,SYSDATE,:yanshou_code,:chuliyj,:chulijg,:tuihuozt_code,:fk_shr,:shrxm,:shsj,:zfbz)");
            
            OracleParameter pId = new OracleParameter(":id", OracleDbType.Varchar2);
            pId.Direction = ParameterDirection.Input;
            pId.Value = ypkc_djParam.Id;
            sqlparams.Add(pId);
            //OracleParameter pDjh = new OracleParameter(":djh", OracleDbType.Decimal);使用sequences
            //pDjh.Direction = ParameterDirection.Input;
            //pDjh.Value = ypkc_djParam.Djh;
            //sqlparams.Add(pDjh);
            OracleParameter pDjlx_code = new OracleParameter(":djlx_code", OracleDbType.NVarchar2);
            pDjlx_code.Direction = ParameterDirection.Input;
            pDjlx_code.Value = ypkc_djParam.Djlx_code;
            sqlparams.Add(pDjlx_code);
            OracleParameter pYpfl_code = new OracleParameter(":ypfl_code", OracleDbType.NVarchar2);
            pYpfl_code.Direction = ParameterDirection.Input;
            pYpfl_code.Value = ypkc_djParam.Ypfl_code;
            sqlparams.Add(pYpfl_code);
            OracleParameter pFk_lygys = new OracleParameter(":fk_lygys", OracleDbType.Varchar2);
            pFk_lygys.Direction = ParameterDirection.Input;
            pFk_lygys.Value = ypkc_djParam.Fk_lygys;
            sqlparams.Add(pFk_lygys);
            OracleParameter pFk_lyks = new OracleParameter(":fk_lyks", OracleDbType.Varchar2);
            pFk_lyks.Direction = ParameterDirection.Input;
            pFk_lyks.Value = ypkc_djParam.Fk_lyks;
            sqlparams.Add(pFk_lyks);
            OracleParameter pLybh = new OracleParameter(":lybh", OracleDbType.Varchar2);
            pLybh.Direction = ParameterDirection.Input;
            pLybh.Value = ypkc_djParam.Lybh;
            sqlparams.Add(pLybh);
            OracleParameter pLymc = new OracleParameter(":lymc", OracleDbType.NVarchar2);
            pLymc.Direction = ParameterDirection.Input;
            pLymc.Value = ypkc_djParam.Lymc;
            sqlparams.Add(pLymc);
            OracleParameter pFk_mdks = new OracleParameter(":fk_mdks", OracleDbType.Varchar2);
            pFk_mdks.Direction = ParameterDirection.Input;
            pFk_mdks.Value = ypkc_djParam.Fk_mdks;
            sqlparams.Add(pFk_mdks);
            OracleParameter pFk_mdgys = new OracleParameter(":fk_mdgys", OracleDbType.Varchar2);
            pFk_mdgys.Direction = ParameterDirection.Input;
            pFk_mdgys.Value = ypkc_djParam.Fk_mdgys;
            sqlparams.Add(pFk_mdgys);
            OracleParameter pMdbh = new OracleParameter(":mdbh", OracleDbType.Varchar2);
            pMdbh.Direction = ParameterDirection.Input;
            pMdbh.Value = ypkc_djParam.Mdbh;
            sqlparams.Add(pMdbh);
            OracleParameter pMdmc = new OracleParameter(":mdmc", OracleDbType.NVarchar2);
            pMdmc.Direction = ParameterDirection.Input;
            pMdmc.Value = ypkc_djParam.Mdmc;
            sqlparams.Add(pMdmc);
            OracleParameter pZdr = new OracleParameter(":zdr", OracleDbType.Varchar2);
            pZdr.Direction = ParameterDirection.Input;
            pZdr.Value = ypkc_djParam.Zdr;
            sqlparams.Add(pZdr);
            OracleParameter pFk_renyuan_zdr = new OracleParameter(":fk_renyuan_zdr", OracleDbType.Varchar2);
            pFk_renyuan_zdr.Direction = ParameterDirection.Input;
            pFk_renyuan_zdr.Value = ypkc_djParam.Fk_renyuan_zdr;
            sqlparams.Add(pFk_renyuan_zdr);
            OracleParameter pJzr = new OracleParameter(":jzr", OracleDbType.Varchar2);
            pJzr.Direction = ParameterDirection.Input;
            pJzr.Value = ypkc_djParam.Jzr;
            sqlparams.Add(pJzr);
            OracleParameter pFk_renyuan_jzr = new OracleParameter(":fk_renyuan_jzr", OracleDbType.Varchar2);
            pFk_renyuan_jzr.Direction = ParameterDirection.Input;
            pFk_renyuan_jzr.Value = ypkc_djParam.Fk_renyuan_jzr;
            sqlparams.Add(pFk_renyuan_jzr);
            //OracleParameter pZdsj = new OracleParameter(":zdsj", OracleDbType.Date);
            //pZdsj.Direction = ParameterDirection.Input;
            //pZdsj.Value = ypkc_djParam.Zdsj;
            //sqlparams.Add(pZdsj);
            OracleParameter pJzsj = new OracleParameter(":jzsj", OracleDbType.Date);
            pJzsj.Direction = ParameterDirection.Input;
            pJzsj.Value = ypkc_djParam.Jzsj;
            sqlparams.Add(pJzsj);
            OracleParameter pJzzt_code = new OracleParameter(":jzzt_code", OracleDbType.Varchar2);
            pJzzt_code.Direction = ParameterDirection.Input;
            pJzzt_code.Value = ypkc_djParam.Jzzt_code;
            sqlparams.Add(pJzzt_code);
            OracleParameter pRemark = new OracleParameter(":remark", OracleDbType.Varchar2);
            pRemark.Direction = ParameterDirection.Input;
            pRemark.Value = ypkc_djParam.Remark;
            sqlparams.Add(pRemark);
            OracleParameter pCaigoufs_code = new OracleParameter(":caigoufs_code", OracleDbType.NVarchar2);
            pCaigoufs_code.Direction = ParameterDirection.Input;
            pCaigoufs_code.Value = ypkc_djParam.Caigoufs_code;
            sqlparams.Add(pCaigoufs_code);
            OracleParameter pPeisongfs_code = new OracleParameter(":peisongfs_code", OracleDbType.NVarchar2);
            pPeisongfs_code.Direction = ParameterDirection.Input;
            pPeisongfs_code.Value = ypkc_djParam.Peisongfs_code;
            sqlparams.Add(pPeisongfs_code);
            //OracleParameter pGoujinsj = new OracleParameter(":goujinsj", OracleDbType.Date);
            //pGoujinsj.Direction = ParameterDirection.Input;
            //pGoujinsj.Value = ypkc_djParam.Goujinsj;
            //sqlparams.Add(pGoujinsj);
            OracleParameter pYanshou_code = new OracleParameter(":yanshou_code", OracleDbType.NVarchar2);
            pYanshou_code.Direction = ParameterDirection.Input;
            pYanshou_code.Value = ypkc_djParam.Yanshou_code;
            sqlparams.Add(pYanshou_code);
            OracleParameter pChuliyj = new OracleParameter(":chuliyj", OracleDbType.NVarchar2);
            pChuliyj.Direction = ParameterDirection.Input;
            pChuliyj.Value = ypkc_djParam.Chuliyj;
            sqlparams.Add(pChuliyj);
            OracleParameter pChulijg = new OracleParameter(":chulijg", OracleDbType.NVarchar2);
            pChulijg.Direction = ParameterDirection.Input;
            pChulijg.Value = ypkc_djParam.Chulijg;
            sqlparams.Add(pChulijg);
            OracleParameter pTuihuozt_code = new OracleParameter(":tuihuozt_code", OracleDbType.NVarchar2);
            pTuihuozt_code.Direction = ParameterDirection.Input;
            pTuihuozt_code.Value = ypkc_djParam.Tuihuozt_code;
            sqlparams.Add(pTuihuozt_code);
            OracleParameter pFk_shr = new OracleParameter(":fk_shr", OracleDbType.Varchar2);
            pFk_shr.Direction = ParameterDirection.Input;
            pFk_shr.Value = ypkc_djParam.Fk_shr;
            sqlparams.Add(pFk_shr);
            OracleParameter pShrxm = new OracleParameter(":shrxm", OracleDbType.NVarchar2);
            pShrxm.Direction = ParameterDirection.Input;
            pShrxm.Value = ypkc_djParam.Shrxm;
            sqlparams.Add(pShrxm);
            OracleParameter pShsj = new OracleParameter(":shsj", OracleDbType.Date);
            pShsj.Direction = ParameterDirection.Input;
            pShsj.Value = ypkc_djParam.Shsj;
            sqlparams.Add(pShsj);
            OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
            pZfbz.Direction = ParameterDirection.Input;
            pZfbz.Value = ypkc_djParam.Zfbz;
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
        /// <param name="ypkc_djParamList">要插入的ypkc_djParam对象的集合</param>
        /// <param name="con">Oracle连接对象（为null时自动生成）</param>
        /// <returns>是否添加成功（影响的行数等于保存的对象的数量时成功）</returns>
        public bool inertBatch(List<Ypkc_dj> ypkc_djParamList, OracleConnection con)
        {
            if (ypkc_djParamList.Count == 0)
            {
                return true;
            }
            List<string> idList = new List<string>();

            List<decimal?> djhList = new List<decimal?>();

            List<string> djlx_codeList = new List<string>();

            List<string> ypfl_codeList = new List<string>();

            List<string> fk_lygysList = new List<string>();

            List<string> fk_lyksList = new List<string>();

            List<string> lybhList = new List<string>();

            List<string> lymcList = new List<string>();

            List<string> fk_mdksList = new List<string>();

            List<string> fk_mdgysList = new List<string>();

            List<string> mdbhList = new List<string>();

            List<string> mdmcList = new List<string>();

            List<string> zdrList = new List<string>();

            List<string> fk_renyuan_zdrList = new List<string>();

            List<string> jzrList = new List<string>();

            List<string> fk_renyuan_jzrList = new List<string>();

            List<DateTime?> zdsjList = new List<DateTime?>();

            List<DateTime?> jzsjList = new List<DateTime?>();

            List<string> jzzt_codeList = new List<string>();

            List<string> remarkList = new List<string>();

            List<string> caigoufs_codeList = new List<string>();

            List<string> peisongfs_codeList = new List<string>();

            List<DateTime?> goujinsjList = new List<DateTime?>();

            List<string> yanshou_codeList = new List<string>();

            List<string> chuliyjList = new List<string>();

            List<string> chulijgList = new List<string>();

            List<string> tuihuozt_codeList = new List<string>();

            List<string> fk_shrList = new List<string>();

            List<string> shrxmList = new List<string>();

            List<DateTime?> shsjList = new List<DateTime?>();

            List<string> zfbzList = new List<string>();

            for (int i = 0; i < ypkc_djParamList.Count; i++)
            {
                Ypkc_dj ypkc_djParam = ypkc_djParamList[i];
                if ("" == ypkc_djParam.Id || null == ypkc_djParam.Id)
                {
                    ypkc_djParam.Id = Model.Common.GUIDHelper.getGuid();
                }

            idList.Add(ypkc_djParam.Id);

            djhList.Add(ypkc_djParam.Djh);

            djlx_codeList.Add(ypkc_djParam.Djlx_code);

            ypfl_codeList.Add(ypkc_djParam.Ypfl_code);

            fk_lygysList.Add(ypkc_djParam.Fk_lygys);

            fk_lyksList.Add(ypkc_djParam.Fk_lyks);

            lybhList.Add(ypkc_djParam.Lybh);

            lymcList.Add(ypkc_djParam.Lymc);

            fk_mdksList.Add(ypkc_djParam.Fk_mdks);

            fk_mdgysList.Add(ypkc_djParam.Fk_mdgys);

            mdbhList.Add(ypkc_djParam.Mdbh);

            mdmcList.Add(ypkc_djParam.Mdmc);

            zdrList.Add(ypkc_djParam.Zdr);

            fk_renyuan_zdrList.Add(ypkc_djParam.Fk_renyuan_zdr);

            jzrList.Add(ypkc_djParam.Jzr);

            fk_renyuan_jzrList.Add(ypkc_djParam.Fk_renyuan_jzr);

            zdsjList.Add(ypkc_djParam.Zdsj);

            jzsjList.Add(ypkc_djParam.Jzsj);

            jzzt_codeList.Add(ypkc_djParam.Jzzt_code);

            remarkList.Add(ypkc_djParam.Remark);

            caigoufs_codeList.Add(ypkc_djParam.Caigoufs_code);

            peisongfs_codeList.Add(ypkc_djParam.Peisongfs_code);

            goujinsjList.Add(ypkc_djParam.Goujinsj);

            yanshou_codeList.Add(ypkc_djParam.Yanshou_code);

            chuliyjList.Add(ypkc_djParam.Chuliyj);

            chulijgList.Add(ypkc_djParam.Chulijg);

            tuihuozt_codeList.Add(ypkc_djParam.Tuihuozt_code);

            fk_shrList.Add(ypkc_djParam.Fk_shr);

            shrxmList.Add(ypkc_djParam.Shrxm);

            shsjList.Add(ypkc_djParam.Shsj);

            zfbzList.Add(ypkc_djParam.Zfbz);

            }

            List<OracleParameter> sqlparams = new List<OracleParameter>();

            StringBuilder sql = new StringBuilder("INSERT INTO YPKC_DJ(id,djh,djlx_code,ypfl_code,fk_lygys,fk_lyks,lybh,lymc,fk_mdks,fk_mdgys,mdbh,mdmc,zdr,fk_renyuan_zdr,jzr,fk_renyuan_jzr,zdsj,jzsj,jzzt_code,remark,caigoufs_code,peisongfs_code,goujinsj,yanshou_code,chuliyj,chulijg,tuihuozt_code,fk_shr,shrxm,shsj,zfbz) VALUES(:id,:djh,:djlx_code,:ypfl_code,:fk_lygys,:fk_lyks,:lybh,:lymc,:fk_mdks,:fk_mdgys,:mdbh,:mdmc,:zdr,:fk_renyuan_zdr,:jzr,:fk_renyuan_jzr,:zdsj,:jzsj,:jzzt_code,:remark,:caigoufs_code,:peisongfs_code,:goujinsj,:yanshou_code,:chuliyj,:chulijg,:tuihuozt_code,:fk_shr,:shrxm,:shsj,:zfbz)");
         
            OracleParameter pId = new OracleParameter(":id", OracleDbType.Varchar2);
            pId.Direction = ParameterDirection.Input;
            pId.Value = idList.ToArray();
            sqlparams.Add(pId);
            OracleParameter pDjh = new OracleParameter(":djh", OracleDbType.Decimal);
            pDjh.Direction = ParameterDirection.Input;
            pDjh.Value = djhList.ToArray();
            sqlparams.Add(pDjh);
            OracleParameter pDjlx_code = new OracleParameter(":djlx_code", OracleDbType.NVarchar2);
            pDjlx_code.Direction = ParameterDirection.Input;
            pDjlx_code.Value = djlx_codeList.ToArray();
            sqlparams.Add(pDjlx_code);
            OracleParameter pYpfl_code = new OracleParameter(":ypfl_code", OracleDbType.NVarchar2);
            pYpfl_code.Direction = ParameterDirection.Input;
            pYpfl_code.Value = ypfl_codeList.ToArray();
            sqlparams.Add(pYpfl_code);
            OracleParameter pFk_lygys = new OracleParameter(":fk_lygys", OracleDbType.Varchar2);
            pFk_lygys.Direction = ParameterDirection.Input;
            pFk_lygys.Value = fk_lygysList.ToArray();
            sqlparams.Add(pFk_lygys);
            OracleParameter pFk_lyks = new OracleParameter(":fk_lyks", OracleDbType.Varchar2);
            pFk_lyks.Direction = ParameterDirection.Input;
            pFk_lyks.Value = fk_lyksList.ToArray();
            sqlparams.Add(pFk_lyks);
            OracleParameter pLybh = new OracleParameter(":lybh", OracleDbType.Varchar2);
            pLybh.Direction = ParameterDirection.Input;
            pLybh.Value = lybhList.ToArray();
            sqlparams.Add(pLybh);
            OracleParameter pLymc = new OracleParameter(":lymc", OracleDbType.NVarchar2);
            pLymc.Direction = ParameterDirection.Input;
            pLymc.Value = lymcList.ToArray();
            sqlparams.Add(pLymc);
            OracleParameter pFk_mdks = new OracleParameter(":fk_mdks", OracleDbType.Varchar2);
            pFk_mdks.Direction = ParameterDirection.Input;
            pFk_mdks.Value = fk_mdksList.ToArray();
            sqlparams.Add(pFk_mdks);
            OracleParameter pFk_mdgys = new OracleParameter(":fk_mdgys", OracleDbType.Varchar2);
            pFk_mdgys.Direction = ParameterDirection.Input;
            pFk_mdgys.Value = fk_mdgysList.ToArray();
            sqlparams.Add(pFk_mdgys);
            OracleParameter pMdbh = new OracleParameter(":mdbh", OracleDbType.Varchar2);
            pMdbh.Direction = ParameterDirection.Input;
            pMdbh.Value = mdbhList.ToArray();
            sqlparams.Add(pMdbh);
            OracleParameter pMdmc = new OracleParameter(":mdmc", OracleDbType.NVarchar2);
            pMdmc.Direction = ParameterDirection.Input;
            pMdmc.Value = mdmcList.ToArray();
            sqlparams.Add(pMdmc);
            OracleParameter pZdr = new OracleParameter(":zdr", OracleDbType.Varchar2);
            pZdr.Direction = ParameterDirection.Input;
            pZdr.Value = zdrList.ToArray();
            sqlparams.Add(pZdr);
            OracleParameter pFk_renyuan_zdr = new OracleParameter(":fk_renyuan_zdr", OracleDbType.Varchar2);
            pFk_renyuan_zdr.Direction = ParameterDirection.Input;
            pFk_renyuan_zdr.Value = fk_renyuan_zdrList.ToArray();
            sqlparams.Add(pFk_renyuan_zdr);
            OracleParameter pJzr = new OracleParameter(":jzr", OracleDbType.Varchar2);
            pJzr.Direction = ParameterDirection.Input;
            pJzr.Value = jzrList.ToArray();
            sqlparams.Add(pJzr);
            OracleParameter pFk_renyuan_jzr = new OracleParameter(":fk_renyuan_jzr", OracleDbType.Varchar2);
            pFk_renyuan_jzr.Direction = ParameterDirection.Input;
            pFk_renyuan_jzr.Value = fk_renyuan_jzrList.ToArray();
            sqlparams.Add(pFk_renyuan_jzr);
            OracleParameter pZdsj = new OracleParameter(":zdsj", OracleDbType.Date);
            pZdsj.Direction = ParameterDirection.Input;
            pZdsj.Value = zdsjList.ToArray();
            sqlparams.Add(pZdsj);
            OracleParameter pJzsj = new OracleParameter(":jzsj", OracleDbType.Date);
            pJzsj.Direction = ParameterDirection.Input;
            pJzsj.Value = jzsjList.ToArray();
            sqlparams.Add(pJzsj);
            OracleParameter pJzzt_code = new OracleParameter(":jzzt_code", OracleDbType.Varchar2);
            pJzzt_code.Direction = ParameterDirection.Input;
            pJzzt_code.Value = jzzt_codeList.ToArray();
            sqlparams.Add(pJzzt_code);
            OracleParameter pRemark = new OracleParameter(":remark", OracleDbType.Varchar2);
            pRemark.Direction = ParameterDirection.Input;
            pRemark.Value = remarkList.ToArray();
            sqlparams.Add(pRemark);
            OracleParameter pCaigoufs_code = new OracleParameter(":caigoufs_code", OracleDbType.NVarchar2);
            pCaigoufs_code.Direction = ParameterDirection.Input;
            pCaigoufs_code.Value = caigoufs_codeList.ToArray();
            sqlparams.Add(pCaigoufs_code);
            OracleParameter pPeisongfs_code = new OracleParameter(":peisongfs_code", OracleDbType.NVarchar2);
            pPeisongfs_code.Direction = ParameterDirection.Input;
            pPeisongfs_code.Value = peisongfs_codeList.ToArray();
            sqlparams.Add(pPeisongfs_code);
            OracleParameter pGoujinsj = new OracleParameter(":goujinsj", OracleDbType.Date);
            pGoujinsj.Direction = ParameterDirection.Input;
            pGoujinsj.Value = goujinsjList.ToArray();
            sqlparams.Add(pGoujinsj);
            OracleParameter pYanshou_code = new OracleParameter(":yanshou_code", OracleDbType.NVarchar2);
            pYanshou_code.Direction = ParameterDirection.Input;
            pYanshou_code.Value = yanshou_codeList.ToArray();
            sqlparams.Add(pYanshou_code);
            OracleParameter pChuliyj = new OracleParameter(":chuliyj", OracleDbType.NVarchar2);
            pChuliyj.Direction = ParameterDirection.Input;
            pChuliyj.Value = chuliyjList.ToArray();
            sqlparams.Add(pChuliyj);
            OracleParameter pChulijg = new OracleParameter(":chulijg", OracleDbType.NVarchar2);
            pChulijg.Direction = ParameterDirection.Input;
            pChulijg.Value = chulijgList.ToArray();
            sqlparams.Add(pChulijg);
            OracleParameter pTuihuozt_code = new OracleParameter(":tuihuozt_code", OracleDbType.NVarchar2);
            pTuihuozt_code.Direction = ParameterDirection.Input;
            pTuihuozt_code.Value = tuihuozt_codeList.ToArray();
            sqlparams.Add(pTuihuozt_code);
            OracleParameter pFk_shr = new OracleParameter(":fk_shr", OracleDbType.Varchar2);
            pFk_shr.Direction = ParameterDirection.Input;
            pFk_shr.Value = fk_shrList.ToArray();
            sqlparams.Add(pFk_shr);
            OracleParameter pShrxm = new OracleParameter(":shrxm", OracleDbType.NVarchar2);
            pShrxm.Direction = ParameterDirection.Input;
            pShrxm.Value = shrxmList.ToArray();
            sqlparams.Add(pShrxm);
            OracleParameter pShsj = new OracleParameter(":shsj", OracleDbType.Date);
            pShsj.Direction = ParameterDirection.Input;
            pShsj.Value = shsjList.ToArray();
            sqlparams.Add(pShsj);
            OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
            pZfbz.Direction = ParameterDirection.Input;
            pZfbz.Value = zfbzList.ToArray();
            sqlparams.Add(pZfbz);
            bool result = false;
            int flag = -1;
            flag = OracleHelper.ExecuteBatch(sql.ToString(), con, ypkc_djParamList.Count, sqlparams.ToArray());
            if (ypkc_djParamList.Count == flag)
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
            StringBuilder sql = new StringBuilder("DELETE YPKC_DJ WHERE ID=:id");
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
            StringBuilder sql = new StringBuilder("DELETE YPKC_DJ WHERE ID=:id");
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
        /// <param name="ypkc_djParamCondition">删除的条件</param>
        /// <param name="con">Oracle连接对象（为null时自动生成）</param>
        /// <returns>无法确定删除的行数（影响行数大于等于0就算成功）</returns>
        public bool deleteByOtherCondition(Ypkc_dj ypkc_djParamCondition, OracleConnection con)
        {
            if (null!=ypkc_djParamCondition.Id&&""!=ypkc_djParamCondition.Id)
            {
                throw new Exception("不允许指定参数的ID，如果要根据ID删除数据请调用deleteById或者deleteByIdBatch方法；错误出自：deleteByOtherCondition");
            }
            List<OracleParameter> sqlparams = new List<OracleParameter>();
            StringBuilder sql = new StringBuilder("DELETE YPKC_DJ ");

            if (null != ypkc_djParamCondition.Djh)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" DJH=:djh ");
                OracleParameter pDjh = new OracleParameter(":djh", OracleDbType.Decimal);
                pDjh.Direction = ParameterDirection.Input;
                pDjh.Value = ypkc_djParamCondition.Djh;
                sqlparams.Add(pDjh);

            }
                        
            if (null != ypkc_djParamCondition.Djlx_code &&  ""!= ypkc_djParamCondition.Djlx_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" DJLX_CODE=:djlx_code ");
                OracleParameter pDjlx_code = new OracleParameter(":djlx_code", OracleDbType.NVarchar2);
                pDjlx_code.Direction = ParameterDirection.Input;
                pDjlx_code.Value = ypkc_djParamCondition.Djlx_code;
                sqlparams.Add(pDjlx_code);

            }
                        
            if (null != ypkc_djParamCondition.Ypfl_code &&  ""!= ypkc_djParamCondition.Ypfl_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" YPFL_CODE=:ypfl_code ");
                OracleParameter pYpfl_code = new OracleParameter(":ypfl_code", OracleDbType.NVarchar2);
                pYpfl_code.Direction = ParameterDirection.Input;
                pYpfl_code.Value = ypkc_djParamCondition.Ypfl_code;
                sqlparams.Add(pYpfl_code);

            }
                        
            if (null != ypkc_djParamCondition.Fk_lygys &&  ""!= ypkc_djParamCondition.Fk_lygys)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" FK_LYGYS=:fk_lygys ");
                OracleParameter pFk_lygys = new OracleParameter(":fk_lygys", OracleDbType.Varchar2);
                pFk_lygys.Direction = ParameterDirection.Input;
                pFk_lygys.Value = ypkc_djParamCondition.Fk_lygys;
                sqlparams.Add(pFk_lygys);

            }
                        
            if (null != ypkc_djParamCondition.Fk_lyks &&  ""!= ypkc_djParamCondition.Fk_lyks)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" FK_LYKS=:fk_lyks ");
                OracleParameter pFk_lyks = new OracleParameter(":fk_lyks", OracleDbType.Varchar2);
                pFk_lyks.Direction = ParameterDirection.Input;
                pFk_lyks.Value = ypkc_djParamCondition.Fk_lyks;
                sqlparams.Add(pFk_lyks);

            }
                        
            if (null != ypkc_djParamCondition.Lybh &&  ""!= ypkc_djParamCondition.Lybh)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" LYBH=:lybh ");
                OracleParameter pLybh = new OracleParameter(":lybh", OracleDbType.Varchar2);
                pLybh.Direction = ParameterDirection.Input;
                pLybh.Value = ypkc_djParamCondition.Lybh;
                sqlparams.Add(pLybh);

            }
                        
            if (null != ypkc_djParamCondition.Lymc &&  ""!= ypkc_djParamCondition.Lymc)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" LYMC=:lymc ");
                OracleParameter pLymc = new OracleParameter(":lymc", OracleDbType.NVarchar2);
                pLymc.Direction = ParameterDirection.Input;
                pLymc.Value = ypkc_djParamCondition.Lymc;
                sqlparams.Add(pLymc);

            }
                        
            if (null != ypkc_djParamCondition.Fk_mdks &&  ""!= ypkc_djParamCondition.Fk_mdks)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" FK_MDKS=:fk_mdks ");
                OracleParameter pFk_mdks = new OracleParameter(":fk_mdks", OracleDbType.Varchar2);
                pFk_mdks.Direction = ParameterDirection.Input;
                pFk_mdks.Value = ypkc_djParamCondition.Fk_mdks;
                sqlparams.Add(pFk_mdks);

            }
                        
            if (null != ypkc_djParamCondition.Fk_mdgys &&  ""!= ypkc_djParamCondition.Fk_mdgys)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" FK_MDGYS=:fk_mdgys ");
                OracleParameter pFk_mdgys = new OracleParameter(":fk_mdgys", OracleDbType.Varchar2);
                pFk_mdgys.Direction = ParameterDirection.Input;
                pFk_mdgys.Value = ypkc_djParamCondition.Fk_mdgys;
                sqlparams.Add(pFk_mdgys);

            }
                        
            if (null != ypkc_djParamCondition.Mdbh &&  ""!= ypkc_djParamCondition.Mdbh)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" MDBH=:mdbh ");
                OracleParameter pMdbh = new OracleParameter(":mdbh", OracleDbType.Varchar2);
                pMdbh.Direction = ParameterDirection.Input;
                pMdbh.Value = ypkc_djParamCondition.Mdbh;
                sqlparams.Add(pMdbh);

            }
                        
            if (null != ypkc_djParamCondition.Mdmc &&  ""!= ypkc_djParamCondition.Mdmc)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" MDMC=:mdmc ");
                OracleParameter pMdmc = new OracleParameter(":mdmc", OracleDbType.NVarchar2);
                pMdmc.Direction = ParameterDirection.Input;
                pMdmc.Value = ypkc_djParamCondition.Mdmc;
                sqlparams.Add(pMdmc);

            }
                        
            if (null != ypkc_djParamCondition.Zdr &&  ""!= ypkc_djParamCondition.Zdr)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" ZDR=:zdr ");
                OracleParameter pZdr = new OracleParameter(":zdr", OracleDbType.Varchar2);
                pZdr.Direction = ParameterDirection.Input;
                pZdr.Value = ypkc_djParamCondition.Zdr;
                sqlparams.Add(pZdr);

            }
                        
            if (null != ypkc_djParamCondition.Fk_renyuan_zdr &&  ""!= ypkc_djParamCondition.Fk_renyuan_zdr)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" FK_RENYUAN_ZDR=:fk_renyuan_zdr ");
                OracleParameter pFk_renyuan_zdr = new OracleParameter(":fk_renyuan_zdr", OracleDbType.Varchar2);
                pFk_renyuan_zdr.Direction = ParameterDirection.Input;
                pFk_renyuan_zdr.Value = ypkc_djParamCondition.Fk_renyuan_zdr;
                sqlparams.Add(pFk_renyuan_zdr);

            }
                        
            if (null != ypkc_djParamCondition.Jzr &&  ""!= ypkc_djParamCondition.Jzr)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" JZR=:jzr ");
                OracleParameter pJzr = new OracleParameter(":jzr", OracleDbType.Varchar2);
                pJzr.Direction = ParameterDirection.Input;
                pJzr.Value = ypkc_djParamCondition.Jzr;
                sqlparams.Add(pJzr);

            }
                        
            if (null != ypkc_djParamCondition.Fk_renyuan_jzr &&  ""!= ypkc_djParamCondition.Fk_renyuan_jzr)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" FK_RENYUAN_JZR=:fk_renyuan_jzr ");
                OracleParameter pFk_renyuan_jzr = new OracleParameter(":fk_renyuan_jzr", OracleDbType.Varchar2);
                pFk_renyuan_jzr.Direction = ParameterDirection.Input;
                pFk_renyuan_jzr.Value = ypkc_djParamCondition.Fk_renyuan_jzr;
                sqlparams.Add(pFk_renyuan_jzr);

            }
                        
            if (DateTime.MinValue != ypkc_djParamCondition.Zdsj &&null != ypkc_djParamCondition.Zdsj)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" ZDSJ=:zdsj ");
                OracleParameter pZdsj = new OracleParameter(":zdsj", OracleDbType.Date);
                pZdsj.Direction = ParameterDirection.Input;
                pZdsj.Value = ypkc_djParamCondition.Zdsj;
                sqlparams.Add(pZdsj);

            }
                        
            if (DateTime.MinValue != ypkc_djParamCondition.Jzsj &&null != ypkc_djParamCondition.Jzsj)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" JZSJ=:jzsj ");
                OracleParameter pJzsj = new OracleParameter(":jzsj", OracleDbType.Date);
                pJzsj.Direction = ParameterDirection.Input;
                pJzsj.Value = ypkc_djParamCondition.Jzsj;
                sqlparams.Add(pJzsj);

            }
                        
            if (null != ypkc_djParamCondition.Jzzt_code &&  ""!= ypkc_djParamCondition.Jzzt_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" JZZT_CODE=:jzzt_code ");
                OracleParameter pJzzt_code = new OracleParameter(":jzzt_code", OracleDbType.Varchar2);
                pJzzt_code.Direction = ParameterDirection.Input;
                pJzzt_code.Value = ypkc_djParamCondition.Jzzt_code;
                sqlparams.Add(pJzzt_code);

            }
                        
            if (null != ypkc_djParamCondition.Remark &&  ""!= ypkc_djParamCondition.Remark)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" REMARK=:remark ");
                OracleParameter pRemark = new OracleParameter(":remark", OracleDbType.Varchar2);
                pRemark.Direction = ParameterDirection.Input;
                pRemark.Value = ypkc_djParamCondition.Remark;
                sqlparams.Add(pRemark);

            }
                        
            if (null != ypkc_djParamCondition.Caigoufs_code &&  ""!= ypkc_djParamCondition.Caigoufs_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" CAIGOUFS_CODE=:caigoufs_code ");
                OracleParameter pCaigoufs_code = new OracleParameter(":caigoufs_code", OracleDbType.NVarchar2);
                pCaigoufs_code.Direction = ParameterDirection.Input;
                pCaigoufs_code.Value = ypkc_djParamCondition.Caigoufs_code;
                sqlparams.Add(pCaigoufs_code);

            }
                        
            if (null != ypkc_djParamCondition.Peisongfs_code &&  ""!= ypkc_djParamCondition.Peisongfs_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" PEISONGFS_CODE=:peisongfs_code ");
                OracleParameter pPeisongfs_code = new OracleParameter(":peisongfs_code", OracleDbType.NVarchar2);
                pPeisongfs_code.Direction = ParameterDirection.Input;
                pPeisongfs_code.Value = ypkc_djParamCondition.Peisongfs_code;
                sqlparams.Add(pPeisongfs_code);

            }
                        
            if (DateTime.MinValue != ypkc_djParamCondition.Goujinsj &&null != ypkc_djParamCondition.Goujinsj)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" GOUJINSJ=:goujinsj ");
                OracleParameter pGoujinsj = new OracleParameter(":goujinsj", OracleDbType.Date);
                pGoujinsj.Direction = ParameterDirection.Input;
                pGoujinsj.Value = ypkc_djParamCondition.Goujinsj;
                sqlparams.Add(pGoujinsj);

            }
                        
            if (null != ypkc_djParamCondition.Yanshou_code &&  ""!= ypkc_djParamCondition.Yanshou_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" YANSHOU_CODE=:yanshou_code ");
                OracleParameter pYanshou_code = new OracleParameter(":yanshou_code", OracleDbType.NVarchar2);
                pYanshou_code.Direction = ParameterDirection.Input;
                pYanshou_code.Value = ypkc_djParamCondition.Yanshou_code;
                sqlparams.Add(pYanshou_code);

            }
                        
            if (null != ypkc_djParamCondition.Chuliyj &&  ""!= ypkc_djParamCondition.Chuliyj)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" CHULIYJ=:chuliyj ");
                OracleParameter pChuliyj = new OracleParameter(":chuliyj", OracleDbType.NVarchar2);
                pChuliyj.Direction = ParameterDirection.Input;
                pChuliyj.Value = ypkc_djParamCondition.Chuliyj;
                sqlparams.Add(pChuliyj);

            }
                        
            if (null != ypkc_djParamCondition.Chulijg &&  ""!= ypkc_djParamCondition.Chulijg)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" CHULIJG=:chulijg ");
                OracleParameter pChulijg = new OracleParameter(":chulijg", OracleDbType.NVarchar2);
                pChulijg.Direction = ParameterDirection.Input;
                pChulijg.Value = ypkc_djParamCondition.Chulijg;
                sqlparams.Add(pChulijg);

            }
                        
            if (null != ypkc_djParamCondition.Tuihuozt_code &&  ""!= ypkc_djParamCondition.Tuihuozt_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" TUIHUOZT_CODE=:tuihuozt_code ");
                OracleParameter pTuihuozt_code = new OracleParameter(":tuihuozt_code", OracleDbType.NVarchar2);
                pTuihuozt_code.Direction = ParameterDirection.Input;
                pTuihuozt_code.Value = ypkc_djParamCondition.Tuihuozt_code;
                sqlparams.Add(pTuihuozt_code);

            }
                        
            if (null != ypkc_djParamCondition.Fk_shr &&  ""!= ypkc_djParamCondition.Fk_shr)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" FK_SHR=:fk_shr ");
                OracleParameter pFk_shr = new OracleParameter(":fk_shr", OracleDbType.Varchar2);
                pFk_shr.Direction = ParameterDirection.Input;
                pFk_shr.Value = ypkc_djParamCondition.Fk_shr;
                sqlparams.Add(pFk_shr);

            }
                        
            if (null != ypkc_djParamCondition.Shrxm &&  ""!= ypkc_djParamCondition.Shrxm)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" SHRXM=:shrxm ");
                OracleParameter pShrxm = new OracleParameter(":shrxm", OracleDbType.NVarchar2);
                pShrxm.Direction = ParameterDirection.Input;
                pShrxm.Value = ypkc_djParamCondition.Shrxm;
                sqlparams.Add(pShrxm);

            }
                        
            if (DateTime.MinValue != ypkc_djParamCondition.Shsj &&null != ypkc_djParamCondition.Shsj)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" SHSJ=:shsj ");
                OracleParameter pShsj = new OracleParameter(":shsj", OracleDbType.Date);
                pShsj.Direction = ParameterDirection.Input;
                pShsj.Value = ypkc_djParamCondition.Shsj;
                sqlparams.Add(pShsj);

            }
                        
            if (null != ypkc_djParamCondition.Zfbz &&  ""!= ypkc_djParamCondition.Zfbz)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" ZFBZ=:zfbz ");
                OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                pZfbz.Direction = ParameterDirection.Input;
                pZfbz.Value = ypkc_djParamCondition.Zfbz;
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
        /// <param name="ypkc_djParam"></param>
        /// <returns>影响的行数</returns>
        public bool updateById(Ypkc_dj ypkc_djParam,OracleConnection con)
        {
            if ("" == ypkc_djParam.Id || null == ypkc_djParam.Id)
            {
                throw new Exception("ID不允许为空，请赋值后调用；错误出自：updateById");
            }
            List<OracleParameter> sqlparams = new List<OracleParameter>();

            StringBuilder sql = new StringBuilder("UPDATE YPKC_DJ SET ");
            if (null != ypkc_djParam.Djh)
            {
                this.isComma(sql);
                sql.Append(" DJH=:djh ");
                OracleParameter pDjh = new OracleParameter(":djh", OracleDbType.Decimal);
                pDjh.Direction = ParameterDirection.Input;
                pDjh.Value = ypkc_djParam.Djh;
                sqlparams.Add(pDjh);

            }
                        
            if (null != ypkc_djParam.Djlx_code &&  ""!= ypkc_djParam.Djlx_code)
            {
                this.isComma(sql);
                sql.Append(" DJLX_CODE=:djlx_code ");
                OracleParameter pDjlx_code = new OracleParameter(":djlx_code", OracleDbType.NVarchar2);
                pDjlx_code.Direction = ParameterDirection.Input;
                pDjlx_code.Value = ypkc_djParam.Djlx_code;
                sqlparams.Add(pDjlx_code);

            }
                        
            if (null != ypkc_djParam.Ypfl_code &&  ""!= ypkc_djParam.Ypfl_code)
            {
                this.isComma(sql);
                sql.Append(" YPFL_CODE=:ypfl_code ");
                OracleParameter pYpfl_code = new OracleParameter(":ypfl_code", OracleDbType.NVarchar2);
                pYpfl_code.Direction = ParameterDirection.Input;
                pYpfl_code.Value = ypkc_djParam.Ypfl_code;
                sqlparams.Add(pYpfl_code);

            }
                        
            if (null != ypkc_djParam.Fk_lygys &&  ""!= ypkc_djParam.Fk_lygys)
            {
                this.isComma(sql);
                sql.Append(" FK_LYGYS=:fk_lygys ");
                OracleParameter pFk_lygys = new OracleParameter(":fk_lygys", OracleDbType.Varchar2);
                pFk_lygys.Direction = ParameterDirection.Input;
                pFk_lygys.Value = ypkc_djParam.Fk_lygys;
                sqlparams.Add(pFk_lygys);

            }
                        
            if (null != ypkc_djParam.Fk_lyks &&  ""!= ypkc_djParam.Fk_lyks)
            {
                this.isComma(sql);
                sql.Append(" FK_LYKS=:fk_lyks ");
                OracleParameter pFk_lyks = new OracleParameter(":fk_lyks", OracleDbType.Varchar2);
                pFk_lyks.Direction = ParameterDirection.Input;
                pFk_lyks.Value = ypkc_djParam.Fk_lyks;
                sqlparams.Add(pFk_lyks);

            }
                        
            if (null != ypkc_djParam.Lybh &&  ""!= ypkc_djParam.Lybh)
            {
                this.isComma(sql);
                sql.Append(" LYBH=:lybh ");
                OracleParameter pLybh = new OracleParameter(":lybh", OracleDbType.Varchar2);
                pLybh.Direction = ParameterDirection.Input;
                pLybh.Value = ypkc_djParam.Lybh;
                sqlparams.Add(pLybh);

            }
                        
            if (null != ypkc_djParam.Lymc &&  ""!= ypkc_djParam.Lymc)
            {
                this.isComma(sql);
                sql.Append(" LYMC=:lymc ");
                OracleParameter pLymc = new OracleParameter(":lymc", OracleDbType.NVarchar2);
                pLymc.Direction = ParameterDirection.Input;
                pLymc.Value = ypkc_djParam.Lymc;
                sqlparams.Add(pLymc);

            }
                        
            if (null != ypkc_djParam.Fk_mdks &&  ""!= ypkc_djParam.Fk_mdks)
            {
                this.isComma(sql);
                sql.Append(" FK_MDKS=:fk_mdks ");
                OracleParameter pFk_mdks = new OracleParameter(":fk_mdks", OracleDbType.Varchar2);
                pFk_mdks.Direction = ParameterDirection.Input;
                pFk_mdks.Value = ypkc_djParam.Fk_mdks;
                sqlparams.Add(pFk_mdks);

            }
                        
            if (null != ypkc_djParam.Fk_mdgys &&  ""!= ypkc_djParam.Fk_mdgys)
            {
                this.isComma(sql);
                sql.Append(" FK_MDGYS=:fk_mdgys ");
                OracleParameter pFk_mdgys = new OracleParameter(":fk_mdgys", OracleDbType.Varchar2);
                pFk_mdgys.Direction = ParameterDirection.Input;
                pFk_mdgys.Value = ypkc_djParam.Fk_mdgys;
                sqlparams.Add(pFk_mdgys);

            }
                        
            if (null != ypkc_djParam.Mdbh &&  ""!= ypkc_djParam.Mdbh)
            {
                this.isComma(sql);
                sql.Append(" MDBH=:mdbh ");
                OracleParameter pMdbh = new OracleParameter(":mdbh", OracleDbType.Varchar2);
                pMdbh.Direction = ParameterDirection.Input;
                pMdbh.Value = ypkc_djParam.Mdbh;
                sqlparams.Add(pMdbh);

            }
                        
            if (null != ypkc_djParam.Mdmc &&  ""!= ypkc_djParam.Mdmc)
            {
                this.isComma(sql);
                sql.Append(" MDMC=:mdmc ");
                OracleParameter pMdmc = new OracleParameter(":mdmc", OracleDbType.NVarchar2);
                pMdmc.Direction = ParameterDirection.Input;
                pMdmc.Value = ypkc_djParam.Mdmc;
                sqlparams.Add(pMdmc);

            }
                        
            if (null != ypkc_djParam.Zdr &&  ""!= ypkc_djParam.Zdr)
            {
                this.isComma(sql);
                sql.Append(" ZDR=:zdr ");
                OracleParameter pZdr = new OracleParameter(":zdr", OracleDbType.Varchar2);
                pZdr.Direction = ParameterDirection.Input;
                pZdr.Value = ypkc_djParam.Zdr;
                sqlparams.Add(pZdr);

            }
                        
            if (null != ypkc_djParam.Fk_renyuan_zdr &&  ""!= ypkc_djParam.Fk_renyuan_zdr)
            {
                this.isComma(sql);
                sql.Append(" FK_RENYUAN_ZDR=:fk_renyuan_zdr ");
                OracleParameter pFk_renyuan_zdr = new OracleParameter(":fk_renyuan_zdr", OracleDbType.Varchar2);
                pFk_renyuan_zdr.Direction = ParameterDirection.Input;
                pFk_renyuan_zdr.Value = ypkc_djParam.Fk_renyuan_zdr;
                sqlparams.Add(pFk_renyuan_zdr);

            }
                        
            if (null != ypkc_djParam.Jzr &&  ""!= ypkc_djParam.Jzr)
            {
                this.isComma(sql);
                sql.Append(" JZR=:jzr ");
                OracleParameter pJzr = new OracleParameter(":jzr", OracleDbType.Varchar2);
                pJzr.Direction = ParameterDirection.Input;
                pJzr.Value = ypkc_djParam.Jzr;
                sqlparams.Add(pJzr);

            }
                        
            if (null != ypkc_djParam.Fk_renyuan_jzr &&  ""!= ypkc_djParam.Fk_renyuan_jzr)
            {
                this.isComma(sql);
                sql.Append(" FK_RENYUAN_JZR=:fk_renyuan_jzr ");
                OracleParameter pFk_renyuan_jzr = new OracleParameter(":fk_renyuan_jzr", OracleDbType.Varchar2);
                pFk_renyuan_jzr.Direction = ParameterDirection.Input;
                pFk_renyuan_jzr.Value = ypkc_djParam.Fk_renyuan_jzr;
                sqlparams.Add(pFk_renyuan_jzr);

            }
                        
            if (DateTime.MinValue != ypkc_djParam.Zdsj &&null != ypkc_djParam.Zdsj)
            {
                this.isComma(sql);
                sql.Append(" ZDSJ=:zdsj ");
                OracleParameter pZdsj = new OracleParameter(":zdsj", OracleDbType.Date);
                pZdsj.Direction = ParameterDirection.Input;
                pZdsj.Value = ypkc_djParam.Zdsj;
                sqlparams.Add(pZdsj);

            }
                        
            if (DateTime.MinValue != ypkc_djParam.Jzsj &&null != ypkc_djParam.Jzsj)
            {
                this.isComma(sql);
                sql.Append(" JZSJ=:jzsj ");
                OracleParameter pJzsj = new OracleParameter(":jzsj", OracleDbType.Date);
                pJzsj.Direction = ParameterDirection.Input;
                pJzsj.Value = ypkc_djParam.Jzsj;
                sqlparams.Add(pJzsj);

            }
                        
            if (null != ypkc_djParam.Jzzt_code &&  ""!= ypkc_djParam.Jzzt_code)
            {
                this.isComma(sql);
                sql.Append(" JZZT_CODE=:jzzt_code ");
                OracleParameter pJzzt_code = new OracleParameter(":jzzt_code", OracleDbType.Varchar2);
                pJzzt_code.Direction = ParameterDirection.Input;
                pJzzt_code.Value = ypkc_djParam.Jzzt_code;
                sqlparams.Add(pJzzt_code);

            }
                        
            if (null != ypkc_djParam.Remark &&  ""!= ypkc_djParam.Remark)
            {
                this.isComma(sql);
                sql.Append(" REMARK=:remark ");
                OracleParameter pRemark = new OracleParameter(":remark", OracleDbType.Varchar2);
                pRemark.Direction = ParameterDirection.Input;
                pRemark.Value = ypkc_djParam.Remark;
                sqlparams.Add(pRemark);

            }
                        
            if (null != ypkc_djParam.Caigoufs_code &&  ""!= ypkc_djParam.Caigoufs_code)
            {
                this.isComma(sql);
                sql.Append(" CAIGOUFS_CODE=:caigoufs_code ");
                OracleParameter pCaigoufs_code = new OracleParameter(":caigoufs_code", OracleDbType.NVarchar2);
                pCaigoufs_code.Direction = ParameterDirection.Input;
                pCaigoufs_code.Value = ypkc_djParam.Caigoufs_code;
                sqlparams.Add(pCaigoufs_code);

            }
                        
            if (null != ypkc_djParam.Peisongfs_code &&  ""!= ypkc_djParam.Peisongfs_code)
            {
                this.isComma(sql);
                sql.Append(" PEISONGFS_CODE=:peisongfs_code ");
                OracleParameter pPeisongfs_code = new OracleParameter(":peisongfs_code", OracleDbType.NVarchar2);
                pPeisongfs_code.Direction = ParameterDirection.Input;
                pPeisongfs_code.Value = ypkc_djParam.Peisongfs_code;
                sqlparams.Add(pPeisongfs_code);

            }
                        
            if (DateTime.MinValue != ypkc_djParam.Goujinsj &&null != ypkc_djParam.Goujinsj)
            {
                this.isComma(sql);
                sql.Append(" GOUJINSJ=:goujinsj ");
                OracleParameter pGoujinsj = new OracleParameter(":goujinsj", OracleDbType.Date);
                pGoujinsj.Direction = ParameterDirection.Input;
                pGoujinsj.Value = ypkc_djParam.Goujinsj;
                sqlparams.Add(pGoujinsj);

            }
                        
            if (null != ypkc_djParam.Yanshou_code &&  ""!= ypkc_djParam.Yanshou_code)
            {
                this.isComma(sql);
                sql.Append(" YANSHOU_CODE=:yanshou_code ");
                OracleParameter pYanshou_code = new OracleParameter(":yanshou_code", OracleDbType.NVarchar2);
                pYanshou_code.Direction = ParameterDirection.Input;
                pYanshou_code.Value = ypkc_djParam.Yanshou_code;
                sqlparams.Add(pYanshou_code);

            }
                        
            if (null != ypkc_djParam.Chuliyj &&  ""!= ypkc_djParam.Chuliyj)
            {
                this.isComma(sql);
                sql.Append(" CHULIYJ=:chuliyj ");
                OracleParameter pChuliyj = new OracleParameter(":chuliyj", OracleDbType.NVarchar2);
                pChuliyj.Direction = ParameterDirection.Input;
                pChuliyj.Value = ypkc_djParam.Chuliyj;
                sqlparams.Add(pChuliyj);

            }
                        
            if (null != ypkc_djParam.Chulijg &&  ""!= ypkc_djParam.Chulijg)
            {
                this.isComma(sql);
                sql.Append(" CHULIJG=:chulijg ");
                OracleParameter pChulijg = new OracleParameter(":chulijg", OracleDbType.NVarchar2);
                pChulijg.Direction = ParameterDirection.Input;
                pChulijg.Value = ypkc_djParam.Chulijg;
                sqlparams.Add(pChulijg);

            }
                        
            if (null != ypkc_djParam.Tuihuozt_code &&  ""!= ypkc_djParam.Tuihuozt_code)
            {
                this.isComma(sql);
                sql.Append(" TUIHUOZT_CODE=:tuihuozt_code ");
                OracleParameter pTuihuozt_code = new OracleParameter(":tuihuozt_code", OracleDbType.NVarchar2);
                pTuihuozt_code.Direction = ParameterDirection.Input;
                pTuihuozt_code.Value = ypkc_djParam.Tuihuozt_code;
                sqlparams.Add(pTuihuozt_code);

            }
                        
            if (null != ypkc_djParam.Fk_shr &&  ""!= ypkc_djParam.Fk_shr)
            {
                this.isComma(sql);
                sql.Append(" FK_SHR=:fk_shr ");
                OracleParameter pFk_shr = new OracleParameter(":fk_shr", OracleDbType.Varchar2);
                pFk_shr.Direction = ParameterDirection.Input;
                pFk_shr.Value = ypkc_djParam.Fk_shr;
                sqlparams.Add(pFk_shr);

            }
                        
            if (null != ypkc_djParam.Shrxm &&  ""!= ypkc_djParam.Shrxm)
            {
                this.isComma(sql);
                sql.Append(" SHRXM=:shrxm ");
                OracleParameter pShrxm = new OracleParameter(":shrxm", OracleDbType.NVarchar2);
                pShrxm.Direction = ParameterDirection.Input;
                pShrxm.Value = ypkc_djParam.Shrxm;
                sqlparams.Add(pShrxm);

            }
                        
            if (DateTime.MinValue != ypkc_djParam.Shsj &&null != ypkc_djParam.Shsj)
            {
                this.isComma(sql);
                sql.Append(" SHSJ=:shsj ");
                OracleParameter pShsj = new OracleParameter(":shsj", OracleDbType.Date);
                pShsj.Direction = ParameterDirection.Input;
                pShsj.Value = ypkc_djParam.Shsj;
                sqlparams.Add(pShsj);

            }
                        
            if (null != ypkc_djParam.Zfbz &&  ""!= ypkc_djParam.Zfbz)
            {
                this.isComma(sql);
                sql.Append(" ZFBZ=:zfbz ");
                OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                pZfbz.Direction = ParameterDirection.Input;
                pZfbz.Value = ypkc_djParam.Zfbz;
                sqlparams.Add(pZfbz);

            }
                        
            sql.Append(" WHERE ID=:id ");
            OracleParameter pId = new OracleParameter(":id", OracleDbType.Varchar2);
            pId.Value = ypkc_djParam.Id;
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
        /// <param name="ypkc_djParamList">要修改的Ypkc_dj对象集合</param>
        /// <param name="con">Oracle连接对象（为null时自动生成）</param>
        /// <returns>是否删除成功（影响的行数等于要修改的对象数量时成功）</returns>
        public bool updateByIdBatch(List<Ypkc_dj> ypkc_djParamList, OracleConnection con)
        {


            List<string> idList = new List<string>();

            List<decimal?> djhList = new List<decimal?>();

            List<string> djlx_codeList = new List<string>();

            List<string> ypfl_codeList = new List<string>();

            List<string> fk_lygysList = new List<string>();

            List<string> fk_lyksList = new List<string>();

            List<string> lybhList = new List<string>();

            List<string> lymcList = new List<string>();

            List<string> fk_mdksList = new List<string>();

            List<string> fk_mdgysList = new List<string>();

            List<string> mdbhList = new List<string>();

            List<string> mdmcList = new List<string>();

            List<string> zdrList = new List<string>();

            List<string> fk_renyuan_zdrList = new List<string>();

            List<string> jzrList = new List<string>();

            List<string> fk_renyuan_jzrList = new List<string>();

            List<DateTime?> zdsjList = new List<DateTime?>();

            List<DateTime?> jzsjList = new List<DateTime?>();

            List<string> jzzt_codeList = new List<string>();

            List<string> remarkList = new List<string>();

            List<string> caigoufs_codeList = new List<string>();

            List<string> peisongfs_codeList = new List<string>();

            List<DateTime?> goujinsjList = new List<DateTime?>();

            List<string> yanshou_codeList = new List<string>();

            List<string> chuliyjList = new List<string>();

            List<string> chulijgList = new List<string>();

            List<string> tuihuozt_codeList = new List<string>();

            List<string> fk_shrList = new List<string>();

            List<string> shrxmList = new List<string>();

            List<DateTime?> shsjList = new List<DateTime?>();

            List<string> zfbzList = new List<string>();

            for (int i = 0; i < ypkc_djParamList.Count; i++)
            {
                Ypkc_dj ypkc_djParam = ypkc_djParamList[i];
                if ("" == ypkc_djParam.Id || null == ypkc_djParam.Id)
                {
                    throw new Exception("下标为" + i + "的数据，ID不能为空，请赋值后调用；错误出自：updateByIdBatch");
                }

            idList.Add(ypkc_djParam.Id);

            djhList.Add(ypkc_djParam.Djh);

            djlx_codeList.Add(ypkc_djParam.Djlx_code);

            ypfl_codeList.Add(ypkc_djParam.Ypfl_code);

            fk_lygysList.Add(ypkc_djParam.Fk_lygys);

            fk_lyksList.Add(ypkc_djParam.Fk_lyks);

            lybhList.Add(ypkc_djParam.Lybh);

            lymcList.Add(ypkc_djParam.Lymc);

            fk_mdksList.Add(ypkc_djParam.Fk_mdks);

            fk_mdgysList.Add(ypkc_djParam.Fk_mdgys);

            mdbhList.Add(ypkc_djParam.Mdbh);

            mdmcList.Add(ypkc_djParam.Mdmc);

            zdrList.Add(ypkc_djParam.Zdr);

            fk_renyuan_zdrList.Add(ypkc_djParam.Fk_renyuan_zdr);

            jzrList.Add(ypkc_djParam.Jzr);

            fk_renyuan_jzrList.Add(ypkc_djParam.Fk_renyuan_jzr);

            zdsjList.Add(ypkc_djParam.Zdsj);

            jzsjList.Add(ypkc_djParam.Jzsj);

            jzzt_codeList.Add(ypkc_djParam.Jzzt_code);

            remarkList.Add(ypkc_djParam.Remark);

            caigoufs_codeList.Add(ypkc_djParam.Caigoufs_code);

            peisongfs_codeList.Add(ypkc_djParam.Peisongfs_code);

            goujinsjList.Add(ypkc_djParam.Goujinsj);

            yanshou_codeList.Add(ypkc_djParam.Yanshou_code);

            chuliyjList.Add(ypkc_djParam.Chuliyj);

            chulijgList.Add(ypkc_djParam.Chulijg);

            tuihuozt_codeList.Add(ypkc_djParam.Tuihuozt_code);

            fk_shrList.Add(ypkc_djParam.Fk_shr);

            shrxmList.Add(ypkc_djParam.Shrxm);

            shsjList.Add(ypkc_djParam.Shsj);

            zfbzList.Add(ypkc_djParam.Zfbz);

            }


            
            List<OracleParameter> sqlparams = new List<OracleParameter>();

            StringBuilder sql = new StringBuilder("UPDATE YPKC_DJ SET ");
            this.isComma(sql);
            sql.Append(" DJH=:djh ");
            OracleParameter pDjh = new OracleParameter(":djh", OracleDbType.Decimal);
            pDjh.Direction = ParameterDirection.Input;
            pDjh.Value = djhList.ToArray();
            sqlparams.Add(pDjh);

            this.isComma(sql);
            sql.Append(" DJLX_CODE=:djlx_code ");
            OracleParameter pDjlx_code = new OracleParameter(":djlx_code", OracleDbType.NVarchar2);
            pDjlx_code.Direction = ParameterDirection.Input;
            pDjlx_code.Value = djlx_codeList.ToArray();
            sqlparams.Add(pDjlx_code);

            this.isComma(sql);
            sql.Append(" YPFL_CODE=:ypfl_code ");
            OracleParameter pYpfl_code = new OracleParameter(":ypfl_code", OracleDbType.NVarchar2);
            pYpfl_code.Direction = ParameterDirection.Input;
            pYpfl_code.Value = ypfl_codeList.ToArray();
            sqlparams.Add(pYpfl_code);

            this.isComma(sql);
            sql.Append(" FK_LYGYS=:fk_lygys ");
            OracleParameter pFk_lygys = new OracleParameter(":fk_lygys", OracleDbType.Varchar2);
            pFk_lygys.Direction = ParameterDirection.Input;
            pFk_lygys.Value = fk_lygysList.ToArray();
            sqlparams.Add(pFk_lygys);

            this.isComma(sql);
            sql.Append(" FK_LYKS=:fk_lyks ");
            OracleParameter pFk_lyks = new OracleParameter(":fk_lyks", OracleDbType.Varchar2);
            pFk_lyks.Direction = ParameterDirection.Input;
            pFk_lyks.Value = fk_lyksList.ToArray();
            sqlparams.Add(pFk_lyks);

            this.isComma(sql);
            sql.Append(" LYBH=:lybh ");
            OracleParameter pLybh = new OracleParameter(":lybh", OracleDbType.Varchar2);
            pLybh.Direction = ParameterDirection.Input;
            pLybh.Value = lybhList.ToArray();
            sqlparams.Add(pLybh);

            this.isComma(sql);
            sql.Append(" LYMC=:lymc ");
            OracleParameter pLymc = new OracleParameter(":lymc", OracleDbType.NVarchar2);
            pLymc.Direction = ParameterDirection.Input;
            pLymc.Value = lymcList.ToArray();
            sqlparams.Add(pLymc);

            this.isComma(sql);
            sql.Append(" FK_MDKS=:fk_mdks ");
            OracleParameter pFk_mdks = new OracleParameter(":fk_mdks", OracleDbType.Varchar2);
            pFk_mdks.Direction = ParameterDirection.Input;
            pFk_mdks.Value = fk_mdksList.ToArray();
            sqlparams.Add(pFk_mdks);

            this.isComma(sql);
            sql.Append(" FK_MDGYS=:fk_mdgys ");
            OracleParameter pFk_mdgys = new OracleParameter(":fk_mdgys", OracleDbType.Varchar2);
            pFk_mdgys.Direction = ParameterDirection.Input;
            pFk_mdgys.Value = fk_mdgysList.ToArray();
            sqlparams.Add(pFk_mdgys);

            this.isComma(sql);
            sql.Append(" MDBH=:mdbh ");
            OracleParameter pMdbh = new OracleParameter(":mdbh", OracleDbType.Varchar2);
            pMdbh.Direction = ParameterDirection.Input;
            pMdbh.Value = mdbhList.ToArray();
            sqlparams.Add(pMdbh);

            this.isComma(sql);
            sql.Append(" MDMC=:mdmc ");
            OracleParameter pMdmc = new OracleParameter(":mdmc", OracleDbType.NVarchar2);
            pMdmc.Direction = ParameterDirection.Input;
            pMdmc.Value = mdmcList.ToArray();
            sqlparams.Add(pMdmc);

            this.isComma(sql);
            sql.Append(" ZDR=:zdr ");
            OracleParameter pZdr = new OracleParameter(":zdr", OracleDbType.Varchar2);
            pZdr.Direction = ParameterDirection.Input;
            pZdr.Value = zdrList.ToArray();
            sqlparams.Add(pZdr);

            this.isComma(sql);
            sql.Append(" FK_RENYUAN_ZDR=:fk_renyuan_zdr ");
            OracleParameter pFk_renyuan_zdr = new OracleParameter(":fk_renyuan_zdr", OracleDbType.Varchar2);
            pFk_renyuan_zdr.Direction = ParameterDirection.Input;
            pFk_renyuan_zdr.Value = fk_renyuan_zdrList.ToArray();
            sqlparams.Add(pFk_renyuan_zdr);

            this.isComma(sql);
            sql.Append(" JZR=:jzr ");
            OracleParameter pJzr = new OracleParameter(":jzr", OracleDbType.Varchar2);
            pJzr.Direction = ParameterDirection.Input;
            pJzr.Value = jzrList.ToArray();
            sqlparams.Add(pJzr);

            this.isComma(sql);
            sql.Append(" FK_RENYUAN_JZR=:fk_renyuan_jzr ");
            OracleParameter pFk_renyuan_jzr = new OracleParameter(":fk_renyuan_jzr", OracleDbType.Varchar2);
            pFk_renyuan_jzr.Direction = ParameterDirection.Input;
            pFk_renyuan_jzr.Value = fk_renyuan_jzrList.ToArray();
            sqlparams.Add(pFk_renyuan_jzr);

            this.isComma(sql);
            sql.Append(" ZDSJ=:zdsj ");
            OracleParameter pZdsj = new OracleParameter(":zdsj", OracleDbType.Date);
            pZdsj.Direction = ParameterDirection.Input;
            pZdsj.Value = zdsjList.ToArray();
            sqlparams.Add(pZdsj);

            this.isComma(sql);
            sql.Append(" JZSJ=:jzsj ");
            OracleParameter pJzsj = new OracleParameter(":jzsj", OracleDbType.Date);
            pJzsj.Direction = ParameterDirection.Input;
            pJzsj.Value = jzsjList.ToArray();
            sqlparams.Add(pJzsj);

            this.isComma(sql);
            sql.Append(" JZZT_CODE=:jzzt_code ");
            OracleParameter pJzzt_code = new OracleParameter(":jzzt_code", OracleDbType.Varchar2);
            pJzzt_code.Direction = ParameterDirection.Input;
            pJzzt_code.Value = jzzt_codeList.ToArray();
            sqlparams.Add(pJzzt_code);

            this.isComma(sql);
            sql.Append(" REMARK=:remark ");
            OracleParameter pRemark = new OracleParameter(":remark", OracleDbType.Varchar2);
            pRemark.Direction = ParameterDirection.Input;
            pRemark.Value = remarkList.ToArray();
            sqlparams.Add(pRemark);

            this.isComma(sql);
            sql.Append(" CAIGOUFS_CODE=:caigoufs_code ");
            OracleParameter pCaigoufs_code = new OracleParameter(":caigoufs_code", OracleDbType.NVarchar2);
            pCaigoufs_code.Direction = ParameterDirection.Input;
            pCaigoufs_code.Value = caigoufs_codeList.ToArray();
            sqlparams.Add(pCaigoufs_code);

            this.isComma(sql);
            sql.Append(" PEISONGFS_CODE=:peisongfs_code ");
            OracleParameter pPeisongfs_code = new OracleParameter(":peisongfs_code", OracleDbType.NVarchar2);
            pPeisongfs_code.Direction = ParameterDirection.Input;
            pPeisongfs_code.Value = peisongfs_codeList.ToArray();
            sqlparams.Add(pPeisongfs_code);

            this.isComma(sql);
            sql.Append(" GOUJINSJ=:goujinsj ");
            OracleParameter pGoujinsj = new OracleParameter(":goujinsj", OracleDbType.Date);
            pGoujinsj.Direction = ParameterDirection.Input;
            pGoujinsj.Value = goujinsjList.ToArray();
            sqlparams.Add(pGoujinsj);

            this.isComma(sql);
            sql.Append(" YANSHOU_CODE=:yanshou_code ");
            OracleParameter pYanshou_code = new OracleParameter(":yanshou_code", OracleDbType.NVarchar2);
            pYanshou_code.Direction = ParameterDirection.Input;
            pYanshou_code.Value = yanshou_codeList.ToArray();
            sqlparams.Add(pYanshou_code);

            this.isComma(sql);
            sql.Append(" CHULIYJ=:chuliyj ");
            OracleParameter pChuliyj = new OracleParameter(":chuliyj", OracleDbType.NVarchar2);
            pChuliyj.Direction = ParameterDirection.Input;
            pChuliyj.Value = chuliyjList.ToArray();
            sqlparams.Add(pChuliyj);

            this.isComma(sql);
            sql.Append(" CHULIJG=:chulijg ");
            OracleParameter pChulijg = new OracleParameter(":chulijg", OracleDbType.NVarchar2);
            pChulijg.Direction = ParameterDirection.Input;
            pChulijg.Value = chulijgList.ToArray();
            sqlparams.Add(pChulijg);

            this.isComma(sql);
            sql.Append(" TUIHUOZT_CODE=:tuihuozt_code ");
            OracleParameter pTuihuozt_code = new OracleParameter(":tuihuozt_code", OracleDbType.NVarchar2);
            pTuihuozt_code.Direction = ParameterDirection.Input;
            pTuihuozt_code.Value = tuihuozt_codeList.ToArray();
            sqlparams.Add(pTuihuozt_code);

            this.isComma(sql);
            sql.Append(" FK_SHR=:fk_shr ");
            OracleParameter pFk_shr = new OracleParameter(":fk_shr", OracleDbType.Varchar2);
            pFk_shr.Direction = ParameterDirection.Input;
            pFk_shr.Value = fk_shrList.ToArray();
            sqlparams.Add(pFk_shr);

            this.isComma(sql);
            sql.Append(" SHRXM=:shrxm ");
            OracleParameter pShrxm = new OracleParameter(":shrxm", OracleDbType.NVarchar2);
            pShrxm.Direction = ParameterDirection.Input;
            pShrxm.Value = shrxmList.ToArray();
            sqlparams.Add(pShrxm);

            this.isComma(sql);
            sql.Append(" SHSJ=:shsj ");
            OracleParameter pShsj = new OracleParameter(":shsj", OracleDbType.Date);
            pShsj.Direction = ParameterDirection.Input;
            pShsj.Value = shsjList.ToArray();
            sqlparams.Add(pShsj);

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
            int flag = OracleHelper.ExecuteBatch(sql.ToString(), con,ypkc_djParamList.Count, sqlparams.ToArray());
            if (ypkc_djParamList.Count == flag)
            {
                result = true;
            }
            return result;
        }

        /// <summary>
        /// 根据更新的条件，更新数据（如果需要供事务使用就传入OracleConnection对象，如果不供就传入null，方法自动生成OracleConnection对象）
        /// 不指定ID，如果要根据ID来更新数据，请使用updateForId方法
        /// </summary>
        /// <param name="ypkc_djParamCondition">条件对象</param>
        /// <param name="ypkc_djParamUpdate">要更新的数据对象</param>
        /// <param name="con">Oracle连接对象（为null时自动生成）</param>
        /// <returns>影响的行数不确定（不为-1就正确）</returns>
        public bool updateByOtherCondition(Ypkc_dj ypkc_djParamCondition, Ypkc_dj ypkc_djParamUpdate, OracleConnection con)
        {
            if ((null!=ypkc_djParamCondition.Id&&"!=ypkc_djParamCondition.Id)||(null!=ypkc_djParamUpdate.Id&&"!=ypkc_djParamUpdate.Id))
            {
                throw new Exception("此方法不允许指定参数的ID，数据库中的ID不允许修改，如需根据ID修改数据，请调用updateById或updateByIdBatch方法；错误出自：updateByOtherCondition");
            }
            List<OracleParameter> sqlparams = new List<OracleParameter>();
            //添加要修改的值
            StringBuilder sql = new StringBuilder("UPDATE YPKC_DJ SET ");
            if (null != ypkc_djParamUpdate.Djh)
            {
                this.isComma(sql);
                sql.Append(" DJH=:djh ");
                OracleParameter pDjh = new OracleParameter(":djh", OracleDbType.Decimal);
                pDjh.Direction = ParameterDirection.Input;
                pDjh.Value = ypkc_djParamUpdate.Djh;
                sqlparams.Add(pDjh);

            }
                        
            if (null != ypkc_djParamUpdate.Djlx_code &&  ""!= ypkc_djParamUpdate.Djlx_code)
            {
                this.isComma(sql);
                sql.Append(" DJLX_CODE=:djlx_code ");
                OracleParameter pDjlx_code = new OracleParameter(":djlx_code", OracleDbType.NVarchar2);
                pDjlx_code.Direction = ParameterDirection.Input;
                pDjlx_code.Value = ypkc_djParamUpdate.Djlx_code;
                sqlparams.Add(pDjlx_code);

            }
                        
            if (null != ypkc_djParamUpdate.Ypfl_code &&  ""!= ypkc_djParamUpdate.Ypfl_code)
            {
                this.isComma(sql);
                sql.Append(" YPFL_CODE=:ypfl_code ");
                OracleParameter pYpfl_code = new OracleParameter(":ypfl_code", OracleDbType.NVarchar2);
                pYpfl_code.Direction = ParameterDirection.Input;
                pYpfl_code.Value = ypkc_djParamUpdate.Ypfl_code;
                sqlparams.Add(pYpfl_code);

            }
                        
            if (null != ypkc_djParamUpdate.Fk_lygys &&  ""!= ypkc_djParamUpdate.Fk_lygys)
            {
                this.isComma(sql);
                sql.Append(" FK_LYGYS=:fk_lygys ");
                OracleParameter pFk_lygys = new OracleParameter(":fk_lygys", OracleDbType.Varchar2);
                pFk_lygys.Direction = ParameterDirection.Input;
                pFk_lygys.Value = ypkc_djParamUpdate.Fk_lygys;
                sqlparams.Add(pFk_lygys);

            }
                        
            if (null != ypkc_djParamUpdate.Fk_lyks &&  ""!= ypkc_djParamUpdate.Fk_lyks)
            {
                this.isComma(sql);
                sql.Append(" FK_LYKS=:fk_lyks ");
                OracleParameter pFk_lyks = new OracleParameter(":fk_lyks", OracleDbType.Varchar2);
                pFk_lyks.Direction = ParameterDirection.Input;
                pFk_lyks.Value = ypkc_djParamUpdate.Fk_lyks;
                sqlparams.Add(pFk_lyks);

            }
                        
            if (null != ypkc_djParamUpdate.Lybh &&  ""!= ypkc_djParamUpdate.Lybh)
            {
                this.isComma(sql);
                sql.Append(" LYBH=:lybh ");
                OracleParameter pLybh = new OracleParameter(":lybh", OracleDbType.Varchar2);
                pLybh.Direction = ParameterDirection.Input;
                pLybh.Value = ypkc_djParamUpdate.Lybh;
                sqlparams.Add(pLybh);

            }
                        
            if (null != ypkc_djParamUpdate.Lymc &&  ""!= ypkc_djParamUpdate.Lymc)
            {
                this.isComma(sql);
                sql.Append(" LYMC=:lymc ");
                OracleParameter pLymc = new OracleParameter(":lymc", OracleDbType.NVarchar2);
                pLymc.Direction = ParameterDirection.Input;
                pLymc.Value = ypkc_djParamUpdate.Lymc;
                sqlparams.Add(pLymc);

            }
                        
            if (null != ypkc_djParamUpdate.Fk_mdks &&  ""!= ypkc_djParamUpdate.Fk_mdks)
            {
                this.isComma(sql);
                sql.Append(" FK_MDKS=:fk_mdks ");
                OracleParameter pFk_mdks = new OracleParameter(":fk_mdks", OracleDbType.Varchar2);
                pFk_mdks.Direction = ParameterDirection.Input;
                pFk_mdks.Value = ypkc_djParamUpdate.Fk_mdks;
                sqlparams.Add(pFk_mdks);

            }
                        
            if (null != ypkc_djParamUpdate.Fk_mdgys &&  ""!= ypkc_djParamUpdate.Fk_mdgys)
            {
                this.isComma(sql);
                sql.Append(" FK_MDGYS=:fk_mdgys ");
                OracleParameter pFk_mdgys = new OracleParameter(":fk_mdgys", OracleDbType.Varchar2);
                pFk_mdgys.Direction = ParameterDirection.Input;
                pFk_mdgys.Value = ypkc_djParamUpdate.Fk_mdgys;
                sqlparams.Add(pFk_mdgys);

            }
                        
            if (null != ypkc_djParamUpdate.Mdbh &&  ""!= ypkc_djParamUpdate.Mdbh)
            {
                this.isComma(sql);
                sql.Append(" MDBH=:mdbh ");
                OracleParameter pMdbh = new OracleParameter(":mdbh", OracleDbType.Varchar2);
                pMdbh.Direction = ParameterDirection.Input;
                pMdbh.Value = ypkc_djParamUpdate.Mdbh;
                sqlparams.Add(pMdbh);

            }
                        
            if (null != ypkc_djParamUpdate.Mdmc &&  ""!= ypkc_djParamUpdate.Mdmc)
            {
                this.isComma(sql);
                sql.Append(" MDMC=:mdmc ");
                OracleParameter pMdmc = new OracleParameter(":mdmc", OracleDbType.NVarchar2);
                pMdmc.Direction = ParameterDirection.Input;
                pMdmc.Value = ypkc_djParamUpdate.Mdmc;
                sqlparams.Add(pMdmc);

            }
                        
            if (null != ypkc_djParamUpdate.Zdr &&  ""!= ypkc_djParamUpdate.Zdr)
            {
                this.isComma(sql);
                sql.Append(" ZDR=:zdr ");
                OracleParameter pZdr = new OracleParameter(":zdr", OracleDbType.Varchar2);
                pZdr.Direction = ParameterDirection.Input;
                pZdr.Value = ypkc_djParamUpdate.Zdr;
                sqlparams.Add(pZdr);

            }
                        
            if (null != ypkc_djParamUpdate.Fk_renyuan_zdr &&  ""!= ypkc_djParamUpdate.Fk_renyuan_zdr)
            {
                this.isComma(sql);
                sql.Append(" FK_RENYUAN_ZDR=:fk_renyuan_zdr ");
                OracleParameter pFk_renyuan_zdr = new OracleParameter(":fk_renyuan_zdr", OracleDbType.Varchar2);
                pFk_renyuan_zdr.Direction = ParameterDirection.Input;
                pFk_renyuan_zdr.Value = ypkc_djParamUpdate.Fk_renyuan_zdr;
                sqlparams.Add(pFk_renyuan_zdr);

            }
                        
            if (null != ypkc_djParamUpdate.Jzr &&  ""!= ypkc_djParamUpdate.Jzr)
            {
                this.isComma(sql);
                sql.Append(" JZR=:jzr ");
                OracleParameter pJzr = new OracleParameter(":jzr", OracleDbType.Varchar2);
                pJzr.Direction = ParameterDirection.Input;
                pJzr.Value = ypkc_djParamUpdate.Jzr;
                sqlparams.Add(pJzr);

            }
                        
            if (null != ypkc_djParamUpdate.Fk_renyuan_jzr &&  ""!= ypkc_djParamUpdate.Fk_renyuan_jzr)
            {
                this.isComma(sql);
                sql.Append(" FK_RENYUAN_JZR=:fk_renyuan_jzr ");
                OracleParameter pFk_renyuan_jzr = new OracleParameter(":fk_renyuan_jzr", OracleDbType.Varchar2);
                pFk_renyuan_jzr.Direction = ParameterDirection.Input;
                pFk_renyuan_jzr.Value = ypkc_djParamUpdate.Fk_renyuan_jzr;
                sqlparams.Add(pFk_renyuan_jzr);

            }
                        
            if (DateTime.MinValue != ypkc_djParamUpdate.Zdsj &&null != ypkc_djParamUpdate.Zdsj)
            {
                this.isComma(sql);
                sql.Append(" ZDSJ=:zdsj ");
                OracleParameter pZdsj = new OracleParameter(":zdsj", OracleDbType.Date);
                pZdsj.Direction = ParameterDirection.Input;
                pZdsj.Value = ypkc_djParamUpdate.Zdsj;
                sqlparams.Add(pZdsj);

            }
                        
            if (DateTime.MinValue != ypkc_djParamUpdate.Jzsj &&null != ypkc_djParamUpdate.Jzsj)
            {
                this.isComma(sql);
                sql.Append(" JZSJ=:jzsj ");
                OracleParameter pJzsj = new OracleParameter(":jzsj", OracleDbType.Date);
                pJzsj.Direction = ParameterDirection.Input;
                pJzsj.Value = ypkc_djParamUpdate.Jzsj;
                sqlparams.Add(pJzsj);

            }
                        
            if (null != ypkc_djParamUpdate.Jzzt_code &&  ""!= ypkc_djParamUpdate.Jzzt_code)
            {
                this.isComma(sql);
                sql.Append(" JZZT_CODE=:jzzt_code ");
                OracleParameter pJzzt_code = new OracleParameter(":jzzt_code", OracleDbType.Varchar2);
                pJzzt_code.Direction = ParameterDirection.Input;
                pJzzt_code.Value = ypkc_djParamUpdate.Jzzt_code;
                sqlparams.Add(pJzzt_code);

            }
                        
            if (null != ypkc_djParamUpdate.Remark &&  ""!= ypkc_djParamUpdate.Remark)
            {
                this.isComma(sql);
                sql.Append(" REMARK=:remark ");
                OracleParameter pRemark = new OracleParameter(":remark", OracleDbType.Varchar2);
                pRemark.Direction = ParameterDirection.Input;
                pRemark.Value = ypkc_djParamUpdate.Remark;
                sqlparams.Add(pRemark);

            }
                        
            if (null != ypkc_djParamUpdate.Caigoufs_code &&  ""!= ypkc_djParamUpdate.Caigoufs_code)
            {
                this.isComma(sql);
                sql.Append(" CAIGOUFS_CODE=:caigoufs_code ");
                OracleParameter pCaigoufs_code = new OracleParameter(":caigoufs_code", OracleDbType.NVarchar2);
                pCaigoufs_code.Direction = ParameterDirection.Input;
                pCaigoufs_code.Value = ypkc_djParamUpdate.Caigoufs_code;
                sqlparams.Add(pCaigoufs_code);

            }
                        
            if (null != ypkc_djParamUpdate.Peisongfs_code &&  ""!= ypkc_djParamUpdate.Peisongfs_code)
            {
                this.isComma(sql);
                sql.Append(" PEISONGFS_CODE=:peisongfs_code ");
                OracleParameter pPeisongfs_code = new OracleParameter(":peisongfs_code", OracleDbType.NVarchar2);
                pPeisongfs_code.Direction = ParameterDirection.Input;
                pPeisongfs_code.Value = ypkc_djParamUpdate.Peisongfs_code;
                sqlparams.Add(pPeisongfs_code);

            }
                        
            if (DateTime.MinValue != ypkc_djParamUpdate.Goujinsj &&null != ypkc_djParamUpdate.Goujinsj)
            {
                this.isComma(sql);
                sql.Append(" GOUJINSJ=:goujinsj ");
                OracleParameter pGoujinsj = new OracleParameter(":goujinsj", OracleDbType.Date);
                pGoujinsj.Direction = ParameterDirection.Input;
                pGoujinsj.Value = ypkc_djParamUpdate.Goujinsj;
                sqlparams.Add(pGoujinsj);

            }
                        
            if (null != ypkc_djParamUpdate.Yanshou_code &&  ""!= ypkc_djParamUpdate.Yanshou_code)
            {
                this.isComma(sql);
                sql.Append(" YANSHOU_CODE=:yanshou_code ");
                OracleParameter pYanshou_code = new OracleParameter(":yanshou_code", OracleDbType.NVarchar2);
                pYanshou_code.Direction = ParameterDirection.Input;
                pYanshou_code.Value = ypkc_djParamUpdate.Yanshou_code;
                sqlparams.Add(pYanshou_code);

            }
                        
            if (null != ypkc_djParamUpdate.Chuliyj &&  ""!= ypkc_djParamUpdate.Chuliyj)
            {
                this.isComma(sql);
                sql.Append(" CHULIYJ=:chuliyj ");
                OracleParameter pChuliyj = new OracleParameter(":chuliyj", OracleDbType.NVarchar2);
                pChuliyj.Direction = ParameterDirection.Input;
                pChuliyj.Value = ypkc_djParamUpdate.Chuliyj;
                sqlparams.Add(pChuliyj);

            }
                        
            if (null != ypkc_djParamUpdate.Chulijg &&  ""!= ypkc_djParamUpdate.Chulijg)
            {
                this.isComma(sql);
                sql.Append(" CHULIJG=:chulijg ");
                OracleParameter pChulijg = new OracleParameter(":chulijg", OracleDbType.NVarchar2);
                pChulijg.Direction = ParameterDirection.Input;
                pChulijg.Value = ypkc_djParamUpdate.Chulijg;
                sqlparams.Add(pChulijg);

            }
                        
            if (null != ypkc_djParamUpdate.Tuihuozt_code &&  ""!= ypkc_djParamUpdate.Tuihuozt_code)
            {
                this.isComma(sql);
                sql.Append(" TUIHUOZT_CODE=:tuihuozt_code ");
                OracleParameter pTuihuozt_code = new OracleParameter(":tuihuozt_code", OracleDbType.NVarchar2);
                pTuihuozt_code.Direction = ParameterDirection.Input;
                pTuihuozt_code.Value = ypkc_djParamUpdate.Tuihuozt_code;
                sqlparams.Add(pTuihuozt_code);

            }
                        
            if (null != ypkc_djParamUpdate.Fk_shr &&  ""!= ypkc_djParamUpdate.Fk_shr)
            {
                this.isComma(sql);
                sql.Append(" FK_SHR=:fk_shr ");
                OracleParameter pFk_shr = new OracleParameter(":fk_shr", OracleDbType.Varchar2);
                pFk_shr.Direction = ParameterDirection.Input;
                pFk_shr.Value = ypkc_djParamUpdate.Fk_shr;
                sqlparams.Add(pFk_shr);

            }
                        
            if (null != ypkc_djParamUpdate.Shrxm &&  ""!= ypkc_djParamUpdate.Shrxm)
            {
                this.isComma(sql);
                sql.Append(" SHRXM=:shrxm ");
                OracleParameter pShrxm = new OracleParameter(":shrxm", OracleDbType.NVarchar2);
                pShrxm.Direction = ParameterDirection.Input;
                pShrxm.Value = ypkc_djParamUpdate.Shrxm;
                sqlparams.Add(pShrxm);

            }
                        
            if (DateTime.MinValue != ypkc_djParamUpdate.Shsj &&null != ypkc_djParamUpdate.Shsj)
            {
                this.isComma(sql);
                sql.Append(" SHSJ=:shsj ");
                OracleParameter pShsj = new OracleParameter(":shsj", OracleDbType.Date);
                pShsj.Direction = ParameterDirection.Input;
                pShsj.Value = ypkc_djParamUpdate.Shsj;
                sqlparams.Add(pShsj);

            }
                        
            if (null != ypkc_djParamUpdate.Zfbz &&  ""!= ypkc_djParamUpdate.Zfbz)
            {
                this.isComma(sql);
                sql.Append(" ZFBZ=:zfbz ");
                OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                pZfbz.Direction = ParameterDirection.Input;
                pZfbz.Value = ypkc_djParamUpdate.Zfbz;
                sqlparams.Add(pZfbz);

            }
                        
            //添加条件的参数
            
            if (null != ypkc_djParamCondition.Djh)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" DJH=:djh ");
                OracleParameter pDjh = new OracleParameter(":djh", OracleDbType.Decimal);
                pDjh.Direction = ParameterDirection.Input;
                pDjh.Value = ypkc_djParamCondition.Djh;
                sqlparams.Add(pDjh);

            }
                        
            if (null != ypkc_djParamCondition.Djlx_code &&  ""!= ypkc_djParamCondition.Djlx_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" DJLX_CODE=:djlx_code ");
                OracleParameter pDjlx_code = new OracleParameter(":djlx_code", OracleDbType.NVarchar2);
                pDjlx_code.Direction = ParameterDirection.Input;
                pDjlx_code.Value = ypkc_djParamCondition.Djlx_code;
                sqlparams.Add(pDjlx_code);

            }
                        
            if (null != ypkc_djParamCondition.Ypfl_code &&  ""!= ypkc_djParamCondition.Ypfl_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" YPFL_CODE=:ypfl_code ");
                OracleParameter pYpfl_code = new OracleParameter(":ypfl_code", OracleDbType.NVarchar2);
                pYpfl_code.Direction = ParameterDirection.Input;
                pYpfl_code.Value = ypkc_djParamCondition.Ypfl_code;
                sqlparams.Add(pYpfl_code);

            }
                        
            if (null != ypkc_djParamCondition.Fk_lygys &&  ""!= ypkc_djParamCondition.Fk_lygys)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" FK_LYGYS=:fk_lygys ");
                OracleParameter pFk_lygys = new OracleParameter(":fk_lygys", OracleDbType.Varchar2);
                pFk_lygys.Direction = ParameterDirection.Input;
                pFk_lygys.Value = ypkc_djParamCondition.Fk_lygys;
                sqlparams.Add(pFk_lygys);

            }
                        
            if (null != ypkc_djParamCondition.Fk_lyks &&  ""!= ypkc_djParamCondition.Fk_lyks)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" FK_LYKS=:fk_lyks ");
                OracleParameter pFk_lyks = new OracleParameter(":fk_lyks", OracleDbType.Varchar2);
                pFk_lyks.Direction = ParameterDirection.Input;
                pFk_lyks.Value = ypkc_djParamCondition.Fk_lyks;
                sqlparams.Add(pFk_lyks);

            }
                        
            if (null != ypkc_djParamCondition.Lybh &&  ""!= ypkc_djParamCondition.Lybh)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" LYBH=:lybh ");
                OracleParameter pLybh = new OracleParameter(":lybh", OracleDbType.Varchar2);
                pLybh.Direction = ParameterDirection.Input;
                pLybh.Value = ypkc_djParamCondition.Lybh;
                sqlparams.Add(pLybh);

            }
                        
            if (null != ypkc_djParamCondition.Lymc &&  ""!= ypkc_djParamCondition.Lymc)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" LYMC=:lymc ");
                OracleParameter pLymc = new OracleParameter(":lymc", OracleDbType.NVarchar2);
                pLymc.Direction = ParameterDirection.Input;
                pLymc.Value = ypkc_djParamCondition.Lymc;
                sqlparams.Add(pLymc);

            }
                        
            if (null != ypkc_djParamCondition.Fk_mdks &&  ""!= ypkc_djParamCondition.Fk_mdks)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" FK_MDKS=:fk_mdks ");
                OracleParameter pFk_mdks = new OracleParameter(":fk_mdks", OracleDbType.Varchar2);
                pFk_mdks.Direction = ParameterDirection.Input;
                pFk_mdks.Value = ypkc_djParamCondition.Fk_mdks;
                sqlparams.Add(pFk_mdks);

            }
                        
            if (null != ypkc_djParamCondition.Fk_mdgys &&  ""!= ypkc_djParamCondition.Fk_mdgys)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" FK_MDGYS=:fk_mdgys ");
                OracleParameter pFk_mdgys = new OracleParameter(":fk_mdgys", OracleDbType.Varchar2);
                pFk_mdgys.Direction = ParameterDirection.Input;
                pFk_mdgys.Value = ypkc_djParamCondition.Fk_mdgys;
                sqlparams.Add(pFk_mdgys);

            }
                        
            if (null != ypkc_djParamCondition.Mdbh &&  ""!= ypkc_djParamCondition.Mdbh)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" MDBH=:mdbh ");
                OracleParameter pMdbh = new OracleParameter(":mdbh", OracleDbType.Varchar2);
                pMdbh.Direction = ParameterDirection.Input;
                pMdbh.Value = ypkc_djParamCondition.Mdbh;
                sqlparams.Add(pMdbh);

            }
                        
            if (null != ypkc_djParamCondition.Mdmc &&  ""!= ypkc_djParamCondition.Mdmc)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" MDMC=:mdmc ");
                OracleParameter pMdmc = new OracleParameter(":mdmc", OracleDbType.NVarchar2);
                pMdmc.Direction = ParameterDirection.Input;
                pMdmc.Value = ypkc_djParamCondition.Mdmc;
                sqlparams.Add(pMdmc);

            }
                        
            if (null != ypkc_djParamCondition.Zdr &&  ""!= ypkc_djParamCondition.Zdr)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" ZDR=:zdr ");
                OracleParameter pZdr = new OracleParameter(":zdr", OracleDbType.Varchar2);
                pZdr.Direction = ParameterDirection.Input;
                pZdr.Value = ypkc_djParamCondition.Zdr;
                sqlparams.Add(pZdr);

            }
                        
            if (null != ypkc_djParamCondition.Fk_renyuan_zdr &&  ""!= ypkc_djParamCondition.Fk_renyuan_zdr)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" FK_RENYUAN_ZDR=:fk_renyuan_zdr ");
                OracleParameter pFk_renyuan_zdr = new OracleParameter(":fk_renyuan_zdr", OracleDbType.Varchar2);
                pFk_renyuan_zdr.Direction = ParameterDirection.Input;
                pFk_renyuan_zdr.Value = ypkc_djParamCondition.Fk_renyuan_zdr;
                sqlparams.Add(pFk_renyuan_zdr);

            }
                        
            if (null != ypkc_djParamCondition.Jzr &&  ""!= ypkc_djParamCondition.Jzr)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" JZR=:jzr ");
                OracleParameter pJzr = new OracleParameter(":jzr", OracleDbType.Varchar2);
                pJzr.Direction = ParameterDirection.Input;
                pJzr.Value = ypkc_djParamCondition.Jzr;
                sqlparams.Add(pJzr);

            }
                        
            if (null != ypkc_djParamCondition.Fk_renyuan_jzr &&  ""!= ypkc_djParamCondition.Fk_renyuan_jzr)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" FK_RENYUAN_JZR=:fk_renyuan_jzr ");
                OracleParameter pFk_renyuan_jzr = new OracleParameter(":fk_renyuan_jzr", OracleDbType.Varchar2);
                pFk_renyuan_jzr.Direction = ParameterDirection.Input;
                pFk_renyuan_jzr.Value = ypkc_djParamCondition.Fk_renyuan_jzr;
                sqlparams.Add(pFk_renyuan_jzr);

            }
                        
            if (DateTime.MinValue != ypkc_djParamCondition.Zdsj &&null != ypkc_djParamCondition.Zdsj)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" ZDSJ=:zdsj ");
                OracleParameter pZdsj = new OracleParameter(":zdsj", OracleDbType.Date);
                pZdsj.Direction = ParameterDirection.Input;
                pZdsj.Value = ypkc_djParamCondition.Zdsj;
                sqlparams.Add(pZdsj);

            }
                        
            if (DateTime.MinValue != ypkc_djParamCondition.Jzsj &&null != ypkc_djParamCondition.Jzsj)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" JZSJ=:jzsj ");
                OracleParameter pJzsj = new OracleParameter(":jzsj", OracleDbType.Date);
                pJzsj.Direction = ParameterDirection.Input;
                pJzsj.Value = ypkc_djParamCondition.Jzsj;
                sqlparams.Add(pJzsj);

            }
                        
            if (null != ypkc_djParamCondition.Jzzt_code &&  ""!= ypkc_djParamCondition.Jzzt_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" JZZT_CODE=:jzzt_code ");
                OracleParameter pJzzt_code = new OracleParameter(":jzzt_code", OracleDbType.Varchar2);
                pJzzt_code.Direction = ParameterDirection.Input;
                pJzzt_code.Value = ypkc_djParamCondition.Jzzt_code;
                sqlparams.Add(pJzzt_code);

            }
                        
            if (null != ypkc_djParamCondition.Remark &&  ""!= ypkc_djParamCondition.Remark)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" REMARK=:remark ");
                OracleParameter pRemark = new OracleParameter(":remark", OracleDbType.Varchar2);
                pRemark.Direction = ParameterDirection.Input;
                pRemark.Value = ypkc_djParamCondition.Remark;
                sqlparams.Add(pRemark);

            }
                        
            if (null != ypkc_djParamCondition.Caigoufs_code &&  ""!= ypkc_djParamCondition.Caigoufs_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" CAIGOUFS_CODE=:caigoufs_code ");
                OracleParameter pCaigoufs_code = new OracleParameter(":caigoufs_code", OracleDbType.NVarchar2);
                pCaigoufs_code.Direction = ParameterDirection.Input;
                pCaigoufs_code.Value = ypkc_djParamCondition.Caigoufs_code;
                sqlparams.Add(pCaigoufs_code);

            }
                        
            if (null != ypkc_djParamCondition.Peisongfs_code &&  ""!= ypkc_djParamCondition.Peisongfs_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" PEISONGFS_CODE=:peisongfs_code ");
                OracleParameter pPeisongfs_code = new OracleParameter(":peisongfs_code", OracleDbType.NVarchar2);
                pPeisongfs_code.Direction = ParameterDirection.Input;
                pPeisongfs_code.Value = ypkc_djParamCondition.Peisongfs_code;
                sqlparams.Add(pPeisongfs_code);

            }
                        
            if (DateTime.MinValue != ypkc_djParamCondition.Goujinsj &&null != ypkc_djParamCondition.Goujinsj)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" GOUJINSJ=:goujinsj ");
                OracleParameter pGoujinsj = new OracleParameter(":goujinsj", OracleDbType.Date);
                pGoujinsj.Direction = ParameterDirection.Input;
                pGoujinsj.Value = ypkc_djParamCondition.Goujinsj;
                sqlparams.Add(pGoujinsj);

            }
                        
            if (null != ypkc_djParamCondition.Yanshou_code &&  ""!= ypkc_djParamCondition.Yanshou_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" YANSHOU_CODE=:yanshou_code ");
                OracleParameter pYanshou_code = new OracleParameter(":yanshou_code", OracleDbType.NVarchar2);
                pYanshou_code.Direction = ParameterDirection.Input;
                pYanshou_code.Value = ypkc_djParamCondition.Yanshou_code;
                sqlparams.Add(pYanshou_code);

            }
                        
            if (null != ypkc_djParamCondition.Chuliyj &&  ""!= ypkc_djParamCondition.Chuliyj)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" CHULIYJ=:chuliyj ");
                OracleParameter pChuliyj = new OracleParameter(":chuliyj", OracleDbType.NVarchar2);
                pChuliyj.Direction = ParameterDirection.Input;
                pChuliyj.Value = ypkc_djParamCondition.Chuliyj;
                sqlparams.Add(pChuliyj);

            }
                        
            if (null != ypkc_djParamCondition.Chulijg &&  ""!= ypkc_djParamCondition.Chulijg)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" CHULIJG=:chulijg ");
                OracleParameter pChulijg = new OracleParameter(":chulijg", OracleDbType.NVarchar2);
                pChulijg.Direction = ParameterDirection.Input;
                pChulijg.Value = ypkc_djParamCondition.Chulijg;
                sqlparams.Add(pChulijg);

            }
                        
            if (null != ypkc_djParamCondition.Tuihuozt_code &&  ""!= ypkc_djParamCondition.Tuihuozt_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" TUIHUOZT_CODE=:tuihuozt_code ");
                OracleParameter pTuihuozt_code = new OracleParameter(":tuihuozt_code", OracleDbType.NVarchar2);
                pTuihuozt_code.Direction = ParameterDirection.Input;
                pTuihuozt_code.Value = ypkc_djParamCondition.Tuihuozt_code;
                sqlparams.Add(pTuihuozt_code);

            }
                        
            if (null != ypkc_djParamCondition.Fk_shr &&  ""!= ypkc_djParamCondition.Fk_shr)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" FK_SHR=:fk_shr ");
                OracleParameter pFk_shr = new OracleParameter(":fk_shr", OracleDbType.Varchar2);
                pFk_shr.Direction = ParameterDirection.Input;
                pFk_shr.Value = ypkc_djParamCondition.Fk_shr;
                sqlparams.Add(pFk_shr);

            }
                        
            if (null != ypkc_djParamCondition.Shrxm &&  ""!= ypkc_djParamCondition.Shrxm)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" SHRXM=:shrxm ");
                OracleParameter pShrxm = new OracleParameter(":shrxm", OracleDbType.NVarchar2);
                pShrxm.Direction = ParameterDirection.Input;
                pShrxm.Value = ypkc_djParamCondition.Shrxm;
                sqlparams.Add(pShrxm);

            }
                        
            if (DateTime.MinValue != ypkc_djParamCondition.Shsj &&null != ypkc_djParamCondition.Shsj)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" SHSJ=:shsj ");
                OracleParameter pShsj = new OracleParameter(":shsj", OracleDbType.Date);
                pShsj.Direction = ParameterDirection.Input;
                pShsj.Value = ypkc_djParamCondition.Shsj;
                sqlparams.Add(pShsj);

            }
                        
            if (null != ypkc_djParamCondition.Zfbz &&  ""!= ypkc_djParamCondition.Zfbz)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" ZFBZ=:zfbz ");
                OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                pZfbz.Direction = ParameterDirection.Input;
                pZfbz.Value = ypkc_djParamCondition.Zfbz;
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
        /// <returns>Ypkc_dj</returns>
        public Ypkc_dj findById(string id)
        {
            if (""==id||null==id)
            {
                throw new Exception("ID不能为空，请赋值后调用；错误出自：findById");
            }
            StringBuilder sql = new StringBuilder("SELECT A.* ");
            //新建方法findContactObjectsById，在此加入多表连接要显示的项start
            //sql.Append(",B.字段一,B.字段二,B.字段三");
            //新建方法，在此加入多表连接要显示的项end
            sql.Append(" FROM YPKC_DJ A ");
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
        /// <param name="ypkc_djParam"></param>
        /// <param name="page">分页对象</param>
        ///<param name="ypkc_djParamLike">模糊查询参数</param>
        ///<param name="sortList">排序参数对象的集合</param>
        /// <returns>满足条件的所有Ypkc_dj对象集合list</returns>
        public List<object> find(Ypkc_dj ypkc_djParam, Model.Common.PageInfo page,Ypkc_dj ypkc_djParamLike,List<SortInfo> sortList)
        {

            //如果没有传查询条件参数，就new一个空的Ypkc_dj对象，标示查询所有数据
            if (null == ypkc_djParam)
            {
                ypkc_djParam = new Ypkc_dj();
            }
            if (null!=ypkc_djParam.Id&&""!=ypkc_djParam.Id)
            {
                throw new Exception("此方法不允许指定参数ID，如果需要根据ID查询数据，请调用findById方法；错误出自：find");
            }
            List<Ypkc_dj> ypkc_djParamList = new List<Ypkc_dj>();//接收查询出的Ypkc_dj对象集合
            List<OracleParameter> sqlparams = new List<OracleParameter>();//保存参数的集合
            StringBuilder sql = new StringBuilder("SELECT A.* ");
            //新建方法findContactObjects(Ypkc_dj ypkc_djParam, Model.Common.PageInfo page)，在此加入多表连接要显示的项start
            //sql.Append(",B.字段一,B.字段二,B.字段三");
            //新建方法，在此加入多表连接要显示的项end
            sql.Append(" FROM YPKC_DJ A ");
            //新建一个方法，在此加入多表连接的语句start
            ////sql.Append(" LEFT JOIN 表名 B ON A.外键=B.ID");
            //新建一个方法，在此加入多表连接的语句end
            
            
            if (null != ypkc_djParam.Djh)
            {
                this.isComma(sql);
                sql.Append(" A.DJH=:djh ");
                OracleParameter pDjh = new OracleParameter(":djh", OracleDbType.Decimal);
                pDjh.Direction = ParameterDirection.Input;
                pDjh.Value = ypkc_djParam.Djh;
                sqlparams.Add(pDjh);

            }
                        
            if (null != ypkc_djParam.Djlx_code && "" != ypkc_djParam.Djlx_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.DJLX_CODE=:djlx_code ");
                OracleParameter pDjlx_code = new OracleParameter(":djlx_code", OracleDbType.NVarchar2);
                pDjlx_code.Direction = ParameterDirection.Input;
                pDjlx_code.Value = ypkc_djParam.Djlx_code;
                sqlparams.Add(pDjlx_code);
            }
                
            if (null != ypkc_djParam.Ypfl_code && "" != ypkc_djParam.Ypfl_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.YPFL_CODE=:ypfl_code ");
                OracleParameter pYpfl_code = new OracleParameter(":ypfl_code", OracleDbType.NVarchar2);
                pYpfl_code.Direction = ParameterDirection.Input;
                pYpfl_code.Value = ypkc_djParam.Ypfl_code;
                sqlparams.Add(pYpfl_code);
            }
                
            if (null != ypkc_djParam.Fk_lygys && "" != ypkc_djParam.Fk_lygys)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.FK_LYGYS=:fk_lygys ");
                OracleParameter pFk_lygys = new OracleParameter(":fk_lygys", OracleDbType.Varchar2);
                pFk_lygys.Direction = ParameterDirection.Input;
                pFk_lygys.Value = ypkc_djParam.Fk_lygys;
                sqlparams.Add(pFk_lygys);
            }
                
            if (null != ypkc_djParam.Fk_lyks && "" != ypkc_djParam.Fk_lyks)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.FK_LYKS=:fk_lyks ");
                OracleParameter pFk_lyks = new OracleParameter(":fk_lyks", OracleDbType.Varchar2);
                pFk_lyks.Direction = ParameterDirection.Input;
                pFk_lyks.Value = ypkc_djParam.Fk_lyks;
                sqlparams.Add(pFk_lyks);
            }
                
            if (null != ypkc_djParam.Lybh && "" != ypkc_djParam.Lybh)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.LYBH=:lybh ");
                OracleParameter pLybh = new OracleParameter(":lybh", OracleDbType.Varchar2);
                pLybh.Direction = ParameterDirection.Input;
                pLybh.Value = ypkc_djParam.Lybh;
                sqlparams.Add(pLybh);
            }
                
            if (null != ypkc_djParam.Lymc && "" != ypkc_djParam.Lymc)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.LYMC=:lymc ");
                OracleParameter pLymc = new OracleParameter(":lymc", OracleDbType.NVarchar2);
                pLymc.Direction = ParameterDirection.Input;
                pLymc.Value = ypkc_djParam.Lymc;
                sqlparams.Add(pLymc);
            }
                
            if (null != ypkc_djParam.Fk_mdks && "" != ypkc_djParam.Fk_mdks)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.FK_MDKS=:fk_mdks ");
                OracleParameter pFk_mdks = new OracleParameter(":fk_mdks", OracleDbType.Varchar2);
                pFk_mdks.Direction = ParameterDirection.Input;
                pFk_mdks.Value = ypkc_djParam.Fk_mdks;
                sqlparams.Add(pFk_mdks);
            }
                
            if (null != ypkc_djParam.Fk_mdgys && "" != ypkc_djParam.Fk_mdgys)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.FK_MDGYS=:fk_mdgys ");
                OracleParameter pFk_mdgys = new OracleParameter(":fk_mdgys", OracleDbType.Varchar2);
                pFk_mdgys.Direction = ParameterDirection.Input;
                pFk_mdgys.Value = ypkc_djParam.Fk_mdgys;
                sqlparams.Add(pFk_mdgys);
            }
                
            if (null != ypkc_djParam.Mdbh && "" != ypkc_djParam.Mdbh)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.MDBH=:mdbh ");
                OracleParameter pMdbh = new OracleParameter(":mdbh", OracleDbType.Varchar2);
                pMdbh.Direction = ParameterDirection.Input;
                pMdbh.Value = ypkc_djParam.Mdbh;
                sqlparams.Add(pMdbh);
            }
                
            if (null != ypkc_djParam.Mdmc && "" != ypkc_djParam.Mdmc)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.MDMC=:mdmc ");
                OracleParameter pMdmc = new OracleParameter(":mdmc", OracleDbType.NVarchar2);
                pMdmc.Direction = ParameterDirection.Input;
                pMdmc.Value = ypkc_djParam.Mdmc;
                sqlparams.Add(pMdmc);
            }
                
            if (null != ypkc_djParam.Zdr && "" != ypkc_djParam.Zdr)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.ZDR=:zdr ");
                OracleParameter pZdr = new OracleParameter(":zdr", OracleDbType.Varchar2);
                pZdr.Direction = ParameterDirection.Input;
                pZdr.Value = ypkc_djParam.Zdr;
                sqlparams.Add(pZdr);
            }
                
            if (null != ypkc_djParam.Fk_renyuan_zdr && "" != ypkc_djParam.Fk_renyuan_zdr)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.FK_RENYUAN_ZDR=:fk_renyuan_zdr ");
                OracleParameter pFk_renyuan_zdr = new OracleParameter(":fk_renyuan_zdr", OracleDbType.Varchar2);
                pFk_renyuan_zdr.Direction = ParameterDirection.Input;
                pFk_renyuan_zdr.Value = ypkc_djParam.Fk_renyuan_zdr;
                sqlparams.Add(pFk_renyuan_zdr);
            }
                
            if (null != ypkc_djParam.Jzr && "" != ypkc_djParam.Jzr)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.JZR=:jzr ");
                OracleParameter pJzr = new OracleParameter(":jzr", OracleDbType.Varchar2);
                pJzr.Direction = ParameterDirection.Input;
                pJzr.Value = ypkc_djParam.Jzr;
                sqlparams.Add(pJzr);
            }
                
            if (null != ypkc_djParam.Fk_renyuan_jzr && "" != ypkc_djParam.Fk_renyuan_jzr)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.FK_RENYUAN_JZR=:fk_renyuan_jzr ");
                OracleParameter pFk_renyuan_jzr = new OracleParameter(":fk_renyuan_jzr", OracleDbType.Varchar2);
                pFk_renyuan_jzr.Direction = ParameterDirection.Input;
                pFk_renyuan_jzr.Value = ypkc_djParam.Fk_renyuan_jzr;
                sqlparams.Add(pFk_renyuan_jzr);
            }
                
                if (DateTime.MinValue != ypkc_djParam.Zdsj &&null != ypkc_djParam.Zdsj)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.ZDSJ=:zdsj ");
                    OracleParameter pZdsj = new OracleParameter(":zdsj", OracleDbType.Date);
                pZdsj.Direction = ParameterDirection.Input;
                pZdsj.Value = ypkc_djParam.Zdsj;
                sqlparams.Add(pZdsj);
                }
                
                if (DateTime.MinValue != ypkc_djParam.Jzsj &&null != ypkc_djParam.Jzsj)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.JZSJ=:jzsj ");
                    OracleParameter pJzsj = new OracleParameter(":jzsj", OracleDbType.Date);
                pJzsj.Direction = ParameterDirection.Input;
                pJzsj.Value = ypkc_djParam.Jzsj;
                sqlparams.Add(pJzsj);
                }
                
            if (null != ypkc_djParam.Jzzt_code && "" != ypkc_djParam.Jzzt_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.JZZT_CODE=:jzzt_code ");
                OracleParameter pJzzt_code = new OracleParameter(":jzzt_code", OracleDbType.Varchar2);
                pJzzt_code.Direction = ParameterDirection.Input;
                pJzzt_code.Value = ypkc_djParam.Jzzt_code;
                sqlparams.Add(pJzzt_code);
            }
                
            if (null != ypkc_djParam.Remark && "" != ypkc_djParam.Remark)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.REMARK=:remark ");
                OracleParameter pRemark = new OracleParameter(":remark", OracleDbType.Varchar2);
                pRemark.Direction = ParameterDirection.Input;
                pRemark.Value = ypkc_djParam.Remark;
                sqlparams.Add(pRemark);
            }
                
            if (null != ypkc_djParam.Caigoufs_code && "" != ypkc_djParam.Caigoufs_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.CAIGOUFS_CODE=:caigoufs_code ");
                OracleParameter pCaigoufs_code = new OracleParameter(":caigoufs_code", OracleDbType.NVarchar2);
                pCaigoufs_code.Direction = ParameterDirection.Input;
                pCaigoufs_code.Value = ypkc_djParam.Caigoufs_code;
                sqlparams.Add(pCaigoufs_code);
            }
                
            if (null != ypkc_djParam.Peisongfs_code && "" != ypkc_djParam.Peisongfs_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.PEISONGFS_CODE=:peisongfs_code ");
                OracleParameter pPeisongfs_code = new OracleParameter(":peisongfs_code", OracleDbType.NVarchar2);
                pPeisongfs_code.Direction = ParameterDirection.Input;
                pPeisongfs_code.Value = ypkc_djParam.Peisongfs_code;
                sqlparams.Add(pPeisongfs_code);
            }
                
                if (DateTime.MinValue != ypkc_djParam.Goujinsj &&null != ypkc_djParam.Goujinsj)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.GOUJINSJ=:goujinsj ");
                    OracleParameter pGoujinsj = new OracleParameter(":goujinsj", OracleDbType.Date);
                pGoujinsj.Direction = ParameterDirection.Input;
                pGoujinsj.Value = ypkc_djParam.Goujinsj;
                sqlparams.Add(pGoujinsj);
                }
                
            if (null != ypkc_djParam.Yanshou_code && "" != ypkc_djParam.Yanshou_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.YANSHOU_CODE=:yanshou_code ");
                OracleParameter pYanshou_code = new OracleParameter(":yanshou_code", OracleDbType.NVarchar2);
                pYanshou_code.Direction = ParameterDirection.Input;
                pYanshou_code.Value = ypkc_djParam.Yanshou_code;
                sqlparams.Add(pYanshou_code);
            }
                
            if (null != ypkc_djParam.Chuliyj && "" != ypkc_djParam.Chuliyj)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.CHULIYJ=:chuliyj ");
                OracleParameter pChuliyj = new OracleParameter(":chuliyj", OracleDbType.NVarchar2);
                pChuliyj.Direction = ParameterDirection.Input;
                pChuliyj.Value = ypkc_djParam.Chuliyj;
                sqlparams.Add(pChuliyj);
            }
                
            if (null != ypkc_djParam.Chulijg && "" != ypkc_djParam.Chulijg)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.CHULIJG=:chulijg ");
                OracleParameter pChulijg = new OracleParameter(":chulijg", OracleDbType.NVarchar2);
                pChulijg.Direction = ParameterDirection.Input;
                pChulijg.Value = ypkc_djParam.Chulijg;
                sqlparams.Add(pChulijg);
            }
                
            if (null != ypkc_djParam.Tuihuozt_code && "" != ypkc_djParam.Tuihuozt_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.TUIHUOZT_CODE=:tuihuozt_code ");
                OracleParameter pTuihuozt_code = new OracleParameter(":tuihuozt_code", OracleDbType.NVarchar2);
                pTuihuozt_code.Direction = ParameterDirection.Input;
                pTuihuozt_code.Value = ypkc_djParam.Tuihuozt_code;
                sqlparams.Add(pTuihuozt_code);
            }
                
            if (null != ypkc_djParam.Fk_shr && "" != ypkc_djParam.Fk_shr)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.FK_SHR=:fk_shr ");
                OracleParameter pFk_shr = new OracleParameter(":fk_shr", OracleDbType.Varchar2);
                pFk_shr.Direction = ParameterDirection.Input;
                pFk_shr.Value = ypkc_djParam.Fk_shr;
                sqlparams.Add(pFk_shr);
            }
                
            if (null != ypkc_djParam.Shrxm && "" != ypkc_djParam.Shrxm)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.SHRXM=:shrxm ");
                OracleParameter pShrxm = new OracleParameter(":shrxm", OracleDbType.NVarchar2);
                pShrxm.Direction = ParameterDirection.Input;
                pShrxm.Value = ypkc_djParam.Shrxm;
                sqlparams.Add(pShrxm);
            }
                
                if (DateTime.MinValue != ypkc_djParam.Shsj &&null != ypkc_djParam.Shsj)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.SHSJ=:shsj ");
                    OracleParameter pShsj = new OracleParameter(":shsj", OracleDbType.Date);
                pShsj.Direction = ParameterDirection.Input;
                pShsj.Value = ypkc_djParam.Shsj;
                sqlparams.Add(pShsj);
                }
                
            if (null != ypkc_djParam.Zfbz && "" != ypkc_djParam.Zfbz)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.ZFBZ=:zfbz ");
                OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                pZfbz.Direction = ParameterDirection.Input;
                pZfbz.Value = ypkc_djParam.Zfbz;
                sqlparams.Add(pZfbz);
            }
                
            if(ypkc_djParamLike!=null)
            {

                if (null != ypkc_djParamLike.Djlx_code && "" != ypkc_djParamLike.Djlx_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.DJLX_CODE LIKE '%'||:djlx_code||'%' ");
                    OracleParameter pDjlx_code = new OracleParameter(":djlx_code", OracleDbType.NVarchar2);
                    pDjlx_code.Direction = ParameterDirection.Input;
                    pDjlx_code.Value = ypkc_djParamLike.Djlx_code;
                    sqlparams.Add(pDjlx_code);
                }
                
                if (null != ypkc_djParamLike.Ypfl_code && "" != ypkc_djParamLike.Ypfl_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YPFL_CODE LIKE '%'||:ypfl_code||'%' ");
                    OracleParameter pYpfl_code = new OracleParameter(":ypfl_code", OracleDbType.NVarchar2);
                    pYpfl_code.Direction = ParameterDirection.Input;
                    pYpfl_code.Value = ypkc_djParamLike.Ypfl_code;
                    sqlparams.Add(pYpfl_code);
                }
                
                if (null != ypkc_djParamLike.Fk_lygys && "" != ypkc_djParamLike.Fk_lygys)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.FK_LYGYS LIKE '%'||:fk_lygys||'%' ");
                    OracleParameter pFk_lygys = new OracleParameter(":fk_lygys", OracleDbType.Varchar2);
                    pFk_lygys.Direction = ParameterDirection.Input;
                    pFk_lygys.Value = ypkc_djParamLike.Fk_lygys;
                    sqlparams.Add(pFk_lygys);
                }
                
                if (null != ypkc_djParamLike.Fk_lyks && "" != ypkc_djParamLike.Fk_lyks)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.FK_LYKS LIKE '%'||:fk_lyks||'%' ");
                    OracleParameter pFk_lyks = new OracleParameter(":fk_lyks", OracleDbType.Varchar2);
                    pFk_lyks.Direction = ParameterDirection.Input;
                    pFk_lyks.Value = ypkc_djParamLike.Fk_lyks;
                    sqlparams.Add(pFk_lyks);
                }
                
                if (null != ypkc_djParamLike.Lybh && "" != ypkc_djParamLike.Lybh)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.LYBH LIKE '%'||:lybh||'%' ");
                    OracleParameter pLybh = new OracleParameter(":lybh", OracleDbType.Varchar2);
                    pLybh.Direction = ParameterDirection.Input;
                    pLybh.Value = ypkc_djParamLike.Lybh;
                    sqlparams.Add(pLybh);
                }
                
                if (null != ypkc_djParamLike.Lymc && "" != ypkc_djParamLike.Lymc)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.LYMC LIKE '%'||:lymc||'%' ");
                    OracleParameter pLymc = new OracleParameter(":lymc", OracleDbType.NVarchar2);
                    pLymc.Direction = ParameterDirection.Input;
                    pLymc.Value = ypkc_djParamLike.Lymc;
                    sqlparams.Add(pLymc);
                }
                
                if (null != ypkc_djParamLike.Fk_mdks && "" != ypkc_djParamLike.Fk_mdks)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.FK_MDKS LIKE '%'||:fk_mdks||'%' ");
                    OracleParameter pFk_mdks = new OracleParameter(":fk_mdks", OracleDbType.Varchar2);
                    pFk_mdks.Direction = ParameterDirection.Input;
                    pFk_mdks.Value = ypkc_djParamLike.Fk_mdks;
                    sqlparams.Add(pFk_mdks);
                }
                
                if (null != ypkc_djParamLike.Fk_mdgys && "" != ypkc_djParamLike.Fk_mdgys)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.FK_MDGYS LIKE '%'||:fk_mdgys||'%' ");
                    OracleParameter pFk_mdgys = new OracleParameter(":fk_mdgys", OracleDbType.Varchar2);
                    pFk_mdgys.Direction = ParameterDirection.Input;
                    pFk_mdgys.Value = ypkc_djParamLike.Fk_mdgys;
                    sqlparams.Add(pFk_mdgys);
                }
                
                if (null != ypkc_djParamLike.Mdbh && "" != ypkc_djParamLike.Mdbh)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.MDBH LIKE '%'||:mdbh||'%' ");
                    OracleParameter pMdbh = new OracleParameter(":mdbh", OracleDbType.Varchar2);
                    pMdbh.Direction = ParameterDirection.Input;
                    pMdbh.Value = ypkc_djParamLike.Mdbh;
                    sqlparams.Add(pMdbh);
                }
                
                if (null != ypkc_djParamLike.Mdmc && "" != ypkc_djParamLike.Mdmc)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.MDMC LIKE '%'||:mdmc||'%' ");
                    OracleParameter pMdmc = new OracleParameter(":mdmc", OracleDbType.NVarchar2);
                    pMdmc.Direction = ParameterDirection.Input;
                    pMdmc.Value = ypkc_djParamLike.Mdmc;
                    sqlparams.Add(pMdmc);
                }
                
                if (null != ypkc_djParamLike.Zdr && "" != ypkc_djParamLike.Zdr)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.ZDR LIKE '%'||:zdr||'%' ");
                    OracleParameter pZdr = new OracleParameter(":zdr", OracleDbType.Varchar2);
                    pZdr.Direction = ParameterDirection.Input;
                    pZdr.Value = ypkc_djParamLike.Zdr;
                    sqlparams.Add(pZdr);
                }
                
                if (null != ypkc_djParamLike.Fk_renyuan_zdr && "" != ypkc_djParamLike.Fk_renyuan_zdr)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.FK_RENYUAN_ZDR LIKE '%'||:fk_renyuan_zdr||'%' ");
                    OracleParameter pFk_renyuan_zdr = new OracleParameter(":fk_renyuan_zdr", OracleDbType.Varchar2);
                    pFk_renyuan_zdr.Direction = ParameterDirection.Input;
                    pFk_renyuan_zdr.Value = ypkc_djParamLike.Fk_renyuan_zdr;
                    sqlparams.Add(pFk_renyuan_zdr);
                }
                
                if (null != ypkc_djParamLike.Jzr && "" != ypkc_djParamLike.Jzr)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.JZR LIKE '%'||:jzr||'%' ");
                    OracleParameter pJzr = new OracleParameter(":jzr", OracleDbType.Varchar2);
                    pJzr.Direction = ParameterDirection.Input;
                    pJzr.Value = ypkc_djParamLike.Jzr;
                    sqlparams.Add(pJzr);
                }
                
                if (null != ypkc_djParamLike.Fk_renyuan_jzr && "" != ypkc_djParamLike.Fk_renyuan_jzr)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.FK_RENYUAN_JZR LIKE '%'||:fk_renyuan_jzr||'%' ");
                    OracleParameter pFk_renyuan_jzr = new OracleParameter(":fk_renyuan_jzr", OracleDbType.Varchar2);
                    pFk_renyuan_jzr.Direction = ParameterDirection.Input;
                    pFk_renyuan_jzr.Value = ypkc_djParamLike.Fk_renyuan_jzr;
                    sqlparams.Add(pFk_renyuan_jzr);
                }
                
                if (null != ypkc_djParamLike.Jzzt_code && "" != ypkc_djParamLike.Jzzt_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.JZZT_CODE LIKE '%'||:jzzt_code||'%' ");
                    OracleParameter pJzzt_code = new OracleParameter(":jzzt_code", OracleDbType.Varchar2);
                    pJzzt_code.Direction = ParameterDirection.Input;
                    pJzzt_code.Value = ypkc_djParamLike.Jzzt_code;
                    sqlparams.Add(pJzzt_code);
                }
                
                if (null != ypkc_djParamLike.Remark && "" != ypkc_djParamLike.Remark)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.REMARK LIKE '%'||:remark||'%' ");
                    OracleParameter pRemark = new OracleParameter(":remark", OracleDbType.Varchar2);
                    pRemark.Direction = ParameterDirection.Input;
                    pRemark.Value = ypkc_djParamLike.Remark;
                    sqlparams.Add(pRemark);
                }
                
                if (null != ypkc_djParamLike.Caigoufs_code && "" != ypkc_djParamLike.Caigoufs_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.CAIGOUFS_CODE LIKE '%'||:caigoufs_code||'%' ");
                    OracleParameter pCaigoufs_code = new OracleParameter(":caigoufs_code", OracleDbType.NVarchar2);
                    pCaigoufs_code.Direction = ParameterDirection.Input;
                    pCaigoufs_code.Value = ypkc_djParamLike.Caigoufs_code;
                    sqlparams.Add(pCaigoufs_code);
                }
                
                if (null != ypkc_djParamLike.Peisongfs_code && "" != ypkc_djParamLike.Peisongfs_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.PEISONGFS_CODE LIKE '%'||:peisongfs_code||'%' ");
                    OracleParameter pPeisongfs_code = new OracleParameter(":peisongfs_code", OracleDbType.NVarchar2);
                    pPeisongfs_code.Direction = ParameterDirection.Input;
                    pPeisongfs_code.Value = ypkc_djParamLike.Peisongfs_code;
                    sqlparams.Add(pPeisongfs_code);
                }
                
                if (null != ypkc_djParamLike.Yanshou_code && "" != ypkc_djParamLike.Yanshou_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YANSHOU_CODE LIKE '%'||:yanshou_code||'%' ");
                    OracleParameter pYanshou_code = new OracleParameter(":yanshou_code", OracleDbType.NVarchar2);
                    pYanshou_code.Direction = ParameterDirection.Input;
                    pYanshou_code.Value = ypkc_djParamLike.Yanshou_code;
                    sqlparams.Add(pYanshou_code);
                }
                
                if (null != ypkc_djParamLike.Chuliyj && "" != ypkc_djParamLike.Chuliyj)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.CHULIYJ LIKE '%'||:chuliyj||'%' ");
                    OracleParameter pChuliyj = new OracleParameter(":chuliyj", OracleDbType.NVarchar2);
                    pChuliyj.Direction = ParameterDirection.Input;
                    pChuliyj.Value = ypkc_djParamLike.Chuliyj;
                    sqlparams.Add(pChuliyj);
                }
                
                if (null != ypkc_djParamLike.Chulijg && "" != ypkc_djParamLike.Chulijg)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.CHULIJG LIKE '%'||:chulijg||'%' ");
                    OracleParameter pChulijg = new OracleParameter(":chulijg", OracleDbType.NVarchar2);
                    pChulijg.Direction = ParameterDirection.Input;
                    pChulijg.Value = ypkc_djParamLike.Chulijg;
                    sqlparams.Add(pChulijg);
                }
                
                if (null != ypkc_djParamLike.Tuihuozt_code && "" != ypkc_djParamLike.Tuihuozt_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.TUIHUOZT_CODE LIKE '%'||:tuihuozt_code||'%' ");
                    OracleParameter pTuihuozt_code = new OracleParameter(":tuihuozt_code", OracleDbType.NVarchar2);
                    pTuihuozt_code.Direction = ParameterDirection.Input;
                    pTuihuozt_code.Value = ypkc_djParamLike.Tuihuozt_code;
                    sqlparams.Add(pTuihuozt_code);
                }
                
                if (null != ypkc_djParamLike.Fk_shr && "" != ypkc_djParamLike.Fk_shr)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.FK_SHR LIKE '%'||:fk_shr||'%' ");
                    OracleParameter pFk_shr = new OracleParameter(":fk_shr", OracleDbType.Varchar2);
                    pFk_shr.Direction = ParameterDirection.Input;
                    pFk_shr.Value = ypkc_djParamLike.Fk_shr;
                    sqlparams.Add(pFk_shr);
                }
                
                if (null != ypkc_djParamLike.Shrxm && "" != ypkc_djParamLike.Shrxm)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.SHRXM LIKE '%'||:shrxm||'%' ");
                    OracleParameter pShrxm = new OracleParameter(":shrxm", OracleDbType.NVarchar2);
                    pShrxm.Direction = ParameterDirection.Input;
                    pShrxm.Value = ypkc_djParamLike.Shrxm;
                    sqlparams.Add(pShrxm);
                }
                
                if (null != ypkc_djParamLike.Zfbz && "" != ypkc_djParamLike.Zfbz)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.ZFBZ LIKE '%'||:zfbz||'%' ");
                    OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                    pZfbz.Direction = ParameterDirection.Input;
                    pZfbz.Value = ypkc_djParamLike.Zfbz;
                    sqlparams.Add(pZfbz);
                }
                
            }

            this.b_isWhere = false;
            this.addSort(sql, sortList);//排序
            //*******分页start1*********如果分页对象为空，则全部数据查出，如果不为空
            List<object> returnList = new List<object>();//返回的List,索引0为List<Ypkc_dj>对象,索引1为Model.Common.PageInfo分页信息对象
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
            //把每一行数据转换为一个对象放入List<Ypkc_dj>中
            for (int i = 0; i < rows.Count; i++)
            {
                DataRow row = rows[i];
                //ypkc_djParamList.Add(this.dataSetContactObjectsToModel(row));
                ypkc_djParamList.Add(this.dataSetToModel(row));
            }
            
             //*******分页start2*********如果没有传入分页对象，则新建一个分页对象当做返回值
            if (null == page)
            {
                page = new Model.Common.PageInfo();
                page.AllCount = rows.Count;
            }
            returnList.Add(ypkc_djParamList);//把List<Ypkc_dj>放入List<object>中第一个
            returnList.Add(page);//把page对象放入List<object>中第二个
            //*******分页end2*********
            return returnList;
        }

        
        
        /// <summary>
        /// 根据条件得到集合的数量
        /// 第二个条件是模糊查询的条件
        /// </summary>
        /// <returns>int</returns>
        public int getCount(Ypkc_dj ypkc_djParam,Ypkc_dj ypkc_djParamLike)
        {
            //如果没有传查询条件参数，就new一个空的Ypkc_dj对象，标示查询所有数据
            if (null == ypkc_djParam)
            {
                ypkc_djParam = new Ypkc_dj();
            }
            List<OracleParameter> sqlparams = new List<OracleParameter>();//保存参数的集合
            StringBuilder sql = new StringBuilder("SELECT COUNT(ID) FROM YPKC_DJ A");
            if (null != ypkc_djParam.Djh)
            {
                this.isComma(sql);
                sql.Append(" DJH=:djh ");
                OracleParameter pDjh = new OracleParameter(":djh", OracleDbType.Decimal);
                pDjh.Value = ypkc_djParam.Djh;
                sqlparams.Add(pDjh);

            }
                        
                if (null != ypkc_djParam.Djlx_code && "" != ypkc_djParam.Djlx_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.DJLX_CODE=:djlx_code ");
                    OracleParameter pDjlx_code = new OracleParameter(":djlx_code", OracleDbType.NVarchar2);
                pDjlx_code.Value = ypkc_djParam.Djlx_code;
                sqlparams.Add(pDjlx_code);
                }
                
                if (null != ypkc_djParam.Ypfl_code && "" != ypkc_djParam.Ypfl_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YPFL_CODE=:ypfl_code ");
                    OracleParameter pYpfl_code = new OracleParameter(":ypfl_code", OracleDbType.NVarchar2);
                pYpfl_code.Value = ypkc_djParam.Ypfl_code;
                sqlparams.Add(pYpfl_code);
                }
                
                if (null != ypkc_djParam.Fk_lygys && "" != ypkc_djParam.Fk_lygys)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.FK_LYGYS=:fk_lygys ");
                    OracleParameter pFk_lygys = new OracleParameter(":fk_lygys", OracleDbType.Varchar2);
                pFk_lygys.Value = ypkc_djParam.Fk_lygys;
                sqlparams.Add(pFk_lygys);
                }
                
                if (null != ypkc_djParam.Fk_lyks && "" != ypkc_djParam.Fk_lyks)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.FK_LYKS=:fk_lyks ");
                    OracleParameter pFk_lyks = new OracleParameter(":fk_lyks", OracleDbType.Varchar2);
                pFk_lyks.Value = ypkc_djParam.Fk_lyks;
                sqlparams.Add(pFk_lyks);
                }
                
                if (null != ypkc_djParam.Lybh && "" != ypkc_djParam.Lybh)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.LYBH=:lybh ");
                    OracleParameter pLybh = new OracleParameter(":lybh", OracleDbType.Varchar2);
                pLybh.Value = ypkc_djParam.Lybh;
                sqlparams.Add(pLybh);
                }
                
                if (null != ypkc_djParam.Lymc && "" != ypkc_djParam.Lymc)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.LYMC=:lymc ");
                    OracleParameter pLymc = new OracleParameter(":lymc", OracleDbType.NVarchar2);
                pLymc.Value = ypkc_djParam.Lymc;
                sqlparams.Add(pLymc);
                }
                
                if (null != ypkc_djParam.Fk_mdks && "" != ypkc_djParam.Fk_mdks)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.FK_MDKS=:fk_mdks ");
                    OracleParameter pFk_mdks = new OracleParameter(":fk_mdks", OracleDbType.Varchar2);
                pFk_mdks.Value = ypkc_djParam.Fk_mdks;
                sqlparams.Add(pFk_mdks);
                }
                
                if (null != ypkc_djParam.Fk_mdgys && "" != ypkc_djParam.Fk_mdgys)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.FK_MDGYS=:fk_mdgys ");
                    OracleParameter pFk_mdgys = new OracleParameter(":fk_mdgys", OracleDbType.Varchar2);
                pFk_mdgys.Value = ypkc_djParam.Fk_mdgys;
                sqlparams.Add(pFk_mdgys);
                }
                
                if (null != ypkc_djParam.Mdbh && "" != ypkc_djParam.Mdbh)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.MDBH=:mdbh ");
                    OracleParameter pMdbh = new OracleParameter(":mdbh", OracleDbType.Varchar2);
                pMdbh.Value = ypkc_djParam.Mdbh;
                sqlparams.Add(pMdbh);
                }
                
                if (null != ypkc_djParam.Mdmc && "" != ypkc_djParam.Mdmc)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.MDMC=:mdmc ");
                    OracleParameter pMdmc = new OracleParameter(":mdmc", OracleDbType.NVarchar2);
                pMdmc.Value = ypkc_djParam.Mdmc;
                sqlparams.Add(pMdmc);
                }
                
                if (null != ypkc_djParam.Zdr && "" != ypkc_djParam.Zdr)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.ZDR=:zdr ");
                    OracleParameter pZdr = new OracleParameter(":zdr", OracleDbType.Varchar2);
                pZdr.Value = ypkc_djParam.Zdr;
                sqlparams.Add(pZdr);
                }
                
                if (null != ypkc_djParam.Fk_renyuan_zdr && "" != ypkc_djParam.Fk_renyuan_zdr)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.FK_RENYUAN_ZDR=:fk_renyuan_zdr ");
                    OracleParameter pFk_renyuan_zdr = new OracleParameter(":fk_renyuan_zdr", OracleDbType.Varchar2);
                pFk_renyuan_zdr.Value = ypkc_djParam.Fk_renyuan_zdr;
                sqlparams.Add(pFk_renyuan_zdr);
                }
                
                if (null != ypkc_djParam.Jzr && "" != ypkc_djParam.Jzr)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.JZR=:jzr ");
                    OracleParameter pJzr = new OracleParameter(":jzr", OracleDbType.Varchar2);
                pJzr.Value = ypkc_djParam.Jzr;
                sqlparams.Add(pJzr);
                }
                
                if (null != ypkc_djParam.Fk_renyuan_jzr && "" != ypkc_djParam.Fk_renyuan_jzr)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.FK_RENYUAN_JZR=:fk_renyuan_jzr ");
                    OracleParameter pFk_renyuan_jzr = new OracleParameter(":fk_renyuan_jzr", OracleDbType.Varchar2);
                pFk_renyuan_jzr.Value = ypkc_djParam.Fk_renyuan_jzr;
                sqlparams.Add(pFk_renyuan_jzr);
                }
                
                if (DateTime.MinValue != ypkc_djParam.Zdsj &&null != ypkc_djParam.Zdsj)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.ZDSJ=:zdsj ");
                    OracleParameter pZdsj = new OracleParameter(":zdsj", OracleDbType.Date);
                pZdsj.Value = ypkc_djParam.Zdsj;
                sqlparams.Add(pZdsj);
                }
                
                if (DateTime.MinValue != ypkc_djParam.Jzsj &&null != ypkc_djParam.Jzsj)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.JZSJ=:jzsj ");
                    OracleParameter pJzsj = new OracleParameter(":jzsj", OracleDbType.Date);
                pJzsj.Value = ypkc_djParam.Jzsj;
                sqlparams.Add(pJzsj);
                }
                
                if (null != ypkc_djParam.Jzzt_code && "" != ypkc_djParam.Jzzt_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.JZZT_CODE=:jzzt_code ");
                    OracleParameter pJzzt_code = new OracleParameter(":jzzt_code", OracleDbType.Varchar2);
                pJzzt_code.Value = ypkc_djParam.Jzzt_code;
                sqlparams.Add(pJzzt_code);
                }
                
                if (null != ypkc_djParam.Remark && "" != ypkc_djParam.Remark)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.REMARK=:remark ");
                    OracleParameter pRemark = new OracleParameter(":remark", OracleDbType.Varchar2);
                pRemark.Value = ypkc_djParam.Remark;
                sqlparams.Add(pRemark);
                }
                
                if (null != ypkc_djParam.Caigoufs_code && "" != ypkc_djParam.Caigoufs_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.CAIGOUFS_CODE=:caigoufs_code ");
                    OracleParameter pCaigoufs_code = new OracleParameter(":caigoufs_code", OracleDbType.NVarchar2);
                pCaigoufs_code.Value = ypkc_djParam.Caigoufs_code;
                sqlparams.Add(pCaigoufs_code);
                }
                
                if (null != ypkc_djParam.Peisongfs_code && "" != ypkc_djParam.Peisongfs_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.PEISONGFS_CODE=:peisongfs_code ");
                    OracleParameter pPeisongfs_code = new OracleParameter(":peisongfs_code", OracleDbType.NVarchar2);
                pPeisongfs_code.Value = ypkc_djParam.Peisongfs_code;
                sqlparams.Add(pPeisongfs_code);
                }
                
                if (DateTime.MinValue != ypkc_djParam.Goujinsj &&null != ypkc_djParam.Goujinsj)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.GOUJINSJ=:goujinsj ");
                    OracleParameter pGoujinsj = new OracleParameter(":goujinsj", OracleDbType.Date);
                pGoujinsj.Value = ypkc_djParam.Goujinsj;
                sqlparams.Add(pGoujinsj);
                }
                
                if (null != ypkc_djParam.Yanshou_code && "" != ypkc_djParam.Yanshou_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YANSHOU_CODE=:yanshou_code ");
                    OracleParameter pYanshou_code = new OracleParameter(":yanshou_code", OracleDbType.NVarchar2);
                pYanshou_code.Value = ypkc_djParam.Yanshou_code;
                sqlparams.Add(pYanshou_code);
                }
                
                if (null != ypkc_djParam.Chuliyj && "" != ypkc_djParam.Chuliyj)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.CHULIYJ=:chuliyj ");
                    OracleParameter pChuliyj = new OracleParameter(":chuliyj", OracleDbType.NVarchar2);
                pChuliyj.Value = ypkc_djParam.Chuliyj;
                sqlparams.Add(pChuliyj);
                }
                
                if (null != ypkc_djParam.Chulijg && "" != ypkc_djParam.Chulijg)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.CHULIJG=:chulijg ");
                    OracleParameter pChulijg = new OracleParameter(":chulijg", OracleDbType.NVarchar2);
                pChulijg.Value = ypkc_djParam.Chulijg;
                sqlparams.Add(pChulijg);
                }
                
                if (null != ypkc_djParam.Tuihuozt_code && "" != ypkc_djParam.Tuihuozt_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.TUIHUOZT_CODE=:tuihuozt_code ");
                    OracleParameter pTuihuozt_code = new OracleParameter(":tuihuozt_code", OracleDbType.NVarchar2);
                pTuihuozt_code.Value = ypkc_djParam.Tuihuozt_code;
                sqlparams.Add(pTuihuozt_code);
                }
                
                if (null != ypkc_djParam.Fk_shr && "" != ypkc_djParam.Fk_shr)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.FK_SHR=:fk_shr ");
                    OracleParameter pFk_shr = new OracleParameter(":fk_shr", OracleDbType.Varchar2);
                pFk_shr.Value = ypkc_djParam.Fk_shr;
                sqlparams.Add(pFk_shr);
                }
                
                if (null != ypkc_djParam.Shrxm && "" != ypkc_djParam.Shrxm)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.SHRXM=:shrxm ");
                    OracleParameter pShrxm = new OracleParameter(":shrxm", OracleDbType.NVarchar2);
                pShrxm.Value = ypkc_djParam.Shrxm;
                sqlparams.Add(pShrxm);
                }
                
                if (DateTime.MinValue != ypkc_djParam.Shsj &&null != ypkc_djParam.Shsj)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.SHSJ=:shsj ");
                    OracleParameter pShsj = new OracleParameter(":shsj", OracleDbType.Date);
                pShsj.Value = ypkc_djParam.Shsj;
                sqlparams.Add(pShsj);
                }
                
                if (null != ypkc_djParam.Zfbz && "" != ypkc_djParam.Zfbz)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.ZFBZ=:zfbz ");
                    OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                pZfbz.Value = ypkc_djParam.Zfbz;
                sqlparams.Add(pZfbz);
                }
                
            if(ypkc_djParamLike!=null)
            {

                if (null != ypkc_djParamLike.Djlx_code && "" != ypkc_djParamLike.Djlx_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.DJLX_CODE LIKE '%'||:djlx_code||'%' ");
                    OracleParameter pDjlx_code = new OracleParameter(":djlx_code", OracleDbType.NVarchar2);
                    pDjlx_code.Direction = ParameterDirection.Input;
                    pDjlx_code.Value = ypkc_djParamLike.Djlx_code;
                    sqlparams.Add(pDjlx_code);
                }
                
                if (null != ypkc_djParamLike.Ypfl_code && "" != ypkc_djParamLike.Ypfl_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YPFL_CODE LIKE '%'||:ypfl_code||'%' ");
                    OracleParameter pYpfl_code = new OracleParameter(":ypfl_code", OracleDbType.NVarchar2);
                    pYpfl_code.Direction = ParameterDirection.Input;
                    pYpfl_code.Value = ypkc_djParamLike.Ypfl_code;
                    sqlparams.Add(pYpfl_code);
                }
                
                if (null != ypkc_djParamLike.Fk_lygys && "" != ypkc_djParamLike.Fk_lygys)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.FK_LYGYS LIKE '%'||:fk_lygys||'%' ");
                    OracleParameter pFk_lygys = new OracleParameter(":fk_lygys", OracleDbType.Varchar2);
                    pFk_lygys.Direction = ParameterDirection.Input;
                    pFk_lygys.Value = ypkc_djParamLike.Fk_lygys;
                    sqlparams.Add(pFk_lygys);
                }
                
                if (null != ypkc_djParamLike.Fk_lyks && "" != ypkc_djParamLike.Fk_lyks)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.FK_LYKS LIKE '%'||:fk_lyks||'%' ");
                    OracleParameter pFk_lyks = new OracleParameter(":fk_lyks", OracleDbType.Varchar2);
                    pFk_lyks.Direction = ParameterDirection.Input;
                    pFk_lyks.Value = ypkc_djParamLike.Fk_lyks;
                    sqlparams.Add(pFk_lyks);
                }
                
                if (null != ypkc_djParamLike.Lybh && "" != ypkc_djParamLike.Lybh)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.LYBH LIKE '%'||:lybh||'%' ");
                    OracleParameter pLybh = new OracleParameter(":lybh", OracleDbType.Varchar2);
                    pLybh.Direction = ParameterDirection.Input;
                    pLybh.Value = ypkc_djParamLike.Lybh;
                    sqlparams.Add(pLybh);
                }
                
                if (null != ypkc_djParamLike.Lymc && "" != ypkc_djParamLike.Lymc)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.LYMC LIKE '%'||:lymc||'%' ");
                    OracleParameter pLymc = new OracleParameter(":lymc", OracleDbType.NVarchar2);
                    pLymc.Direction = ParameterDirection.Input;
                    pLymc.Value = ypkc_djParamLike.Lymc;
                    sqlparams.Add(pLymc);
                }
                
                if (null != ypkc_djParamLike.Fk_mdks && "" != ypkc_djParamLike.Fk_mdks)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.FK_MDKS LIKE '%'||:fk_mdks||'%' ");
                    OracleParameter pFk_mdks = new OracleParameter(":fk_mdks", OracleDbType.Varchar2);
                    pFk_mdks.Direction = ParameterDirection.Input;
                    pFk_mdks.Value = ypkc_djParamLike.Fk_mdks;
                    sqlparams.Add(pFk_mdks);
                }
                
                if (null != ypkc_djParamLike.Fk_mdgys && "" != ypkc_djParamLike.Fk_mdgys)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.FK_MDGYS LIKE '%'||:fk_mdgys||'%' ");
                    OracleParameter pFk_mdgys = new OracleParameter(":fk_mdgys", OracleDbType.Varchar2);
                    pFk_mdgys.Direction = ParameterDirection.Input;
                    pFk_mdgys.Value = ypkc_djParamLike.Fk_mdgys;
                    sqlparams.Add(pFk_mdgys);
                }
                
                if (null != ypkc_djParamLike.Mdbh && "" != ypkc_djParamLike.Mdbh)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.MDBH LIKE '%'||:mdbh||'%' ");
                    OracleParameter pMdbh = new OracleParameter(":mdbh", OracleDbType.Varchar2);
                    pMdbh.Direction = ParameterDirection.Input;
                    pMdbh.Value = ypkc_djParamLike.Mdbh;
                    sqlparams.Add(pMdbh);
                }
                
                if (null != ypkc_djParamLike.Mdmc && "" != ypkc_djParamLike.Mdmc)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.MDMC LIKE '%'||:mdmc||'%' ");
                    OracleParameter pMdmc = new OracleParameter(":mdmc", OracleDbType.NVarchar2);
                    pMdmc.Direction = ParameterDirection.Input;
                    pMdmc.Value = ypkc_djParamLike.Mdmc;
                    sqlparams.Add(pMdmc);
                }
                
                if (null != ypkc_djParamLike.Zdr && "" != ypkc_djParamLike.Zdr)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.ZDR LIKE '%'||:zdr||'%' ");
                    OracleParameter pZdr = new OracleParameter(":zdr", OracleDbType.Varchar2);
                    pZdr.Direction = ParameterDirection.Input;
                    pZdr.Value = ypkc_djParamLike.Zdr;
                    sqlparams.Add(pZdr);
                }
                
                if (null != ypkc_djParamLike.Fk_renyuan_zdr && "" != ypkc_djParamLike.Fk_renyuan_zdr)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.FK_RENYUAN_ZDR LIKE '%'||:fk_renyuan_zdr||'%' ");
                    OracleParameter pFk_renyuan_zdr = new OracleParameter(":fk_renyuan_zdr", OracleDbType.Varchar2);
                    pFk_renyuan_zdr.Direction = ParameterDirection.Input;
                    pFk_renyuan_zdr.Value = ypkc_djParamLike.Fk_renyuan_zdr;
                    sqlparams.Add(pFk_renyuan_zdr);
                }
                
                if (null != ypkc_djParamLike.Jzr && "" != ypkc_djParamLike.Jzr)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.JZR LIKE '%'||:jzr||'%' ");
                    OracleParameter pJzr = new OracleParameter(":jzr", OracleDbType.Varchar2);
                    pJzr.Direction = ParameterDirection.Input;
                    pJzr.Value = ypkc_djParamLike.Jzr;
                    sqlparams.Add(pJzr);
                }
                
                if (null != ypkc_djParamLike.Fk_renyuan_jzr && "" != ypkc_djParamLike.Fk_renyuan_jzr)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.FK_RENYUAN_JZR LIKE '%'||:fk_renyuan_jzr||'%' ");
                    OracleParameter pFk_renyuan_jzr = new OracleParameter(":fk_renyuan_jzr", OracleDbType.Varchar2);
                    pFk_renyuan_jzr.Direction = ParameterDirection.Input;
                    pFk_renyuan_jzr.Value = ypkc_djParamLike.Fk_renyuan_jzr;
                    sqlparams.Add(pFk_renyuan_jzr);
                }
                
                if (null != ypkc_djParamLike.Jzzt_code && "" != ypkc_djParamLike.Jzzt_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.JZZT_CODE LIKE '%'||:jzzt_code||'%' ");
                    OracleParameter pJzzt_code = new OracleParameter(":jzzt_code", OracleDbType.Varchar2);
                    pJzzt_code.Direction = ParameterDirection.Input;
                    pJzzt_code.Value = ypkc_djParamLike.Jzzt_code;
                    sqlparams.Add(pJzzt_code);
                }
                
                if (null != ypkc_djParamLike.Remark && "" != ypkc_djParamLike.Remark)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.REMARK LIKE '%'||:remark||'%' ");
                    OracleParameter pRemark = new OracleParameter(":remark", OracleDbType.Varchar2);
                    pRemark.Direction = ParameterDirection.Input;
                    pRemark.Value = ypkc_djParamLike.Remark;
                    sqlparams.Add(pRemark);
                }
                
                if (null != ypkc_djParamLike.Caigoufs_code && "" != ypkc_djParamLike.Caigoufs_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.CAIGOUFS_CODE LIKE '%'||:caigoufs_code||'%' ");
                    OracleParameter pCaigoufs_code = new OracleParameter(":caigoufs_code", OracleDbType.NVarchar2);
                    pCaigoufs_code.Direction = ParameterDirection.Input;
                    pCaigoufs_code.Value = ypkc_djParamLike.Caigoufs_code;
                    sqlparams.Add(pCaigoufs_code);
                }
                
                if (null != ypkc_djParamLike.Peisongfs_code && "" != ypkc_djParamLike.Peisongfs_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.PEISONGFS_CODE LIKE '%'||:peisongfs_code||'%' ");
                    OracleParameter pPeisongfs_code = new OracleParameter(":peisongfs_code", OracleDbType.NVarchar2);
                    pPeisongfs_code.Direction = ParameterDirection.Input;
                    pPeisongfs_code.Value = ypkc_djParamLike.Peisongfs_code;
                    sqlparams.Add(pPeisongfs_code);
                }
                
                if (null != ypkc_djParamLike.Yanshou_code && "" != ypkc_djParamLike.Yanshou_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YANSHOU_CODE LIKE '%'||:yanshou_code||'%' ");
                    OracleParameter pYanshou_code = new OracleParameter(":yanshou_code", OracleDbType.NVarchar2);
                    pYanshou_code.Direction = ParameterDirection.Input;
                    pYanshou_code.Value = ypkc_djParamLike.Yanshou_code;
                    sqlparams.Add(pYanshou_code);
                }
                
                if (null != ypkc_djParamLike.Chuliyj && "" != ypkc_djParamLike.Chuliyj)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.CHULIYJ LIKE '%'||:chuliyj||'%' ");
                    OracleParameter pChuliyj = new OracleParameter(":chuliyj", OracleDbType.NVarchar2);
                    pChuliyj.Direction = ParameterDirection.Input;
                    pChuliyj.Value = ypkc_djParamLike.Chuliyj;
                    sqlparams.Add(pChuliyj);
                }
                
                if (null != ypkc_djParamLike.Chulijg && "" != ypkc_djParamLike.Chulijg)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.CHULIJG LIKE '%'||:chulijg||'%' ");
                    OracleParameter pChulijg = new OracleParameter(":chulijg", OracleDbType.NVarchar2);
                    pChulijg.Direction = ParameterDirection.Input;
                    pChulijg.Value = ypkc_djParamLike.Chulijg;
                    sqlparams.Add(pChulijg);
                }
                
                if (null != ypkc_djParamLike.Tuihuozt_code && "" != ypkc_djParamLike.Tuihuozt_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.TUIHUOZT_CODE LIKE '%'||:tuihuozt_code||'%' ");
                    OracleParameter pTuihuozt_code = new OracleParameter(":tuihuozt_code", OracleDbType.NVarchar2);
                    pTuihuozt_code.Direction = ParameterDirection.Input;
                    pTuihuozt_code.Value = ypkc_djParamLike.Tuihuozt_code;
                    sqlparams.Add(pTuihuozt_code);
                }
                
                if (null != ypkc_djParamLike.Fk_shr && "" != ypkc_djParamLike.Fk_shr)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.FK_SHR LIKE '%'||:fk_shr||'%' ");
                    OracleParameter pFk_shr = new OracleParameter(":fk_shr", OracleDbType.Varchar2);
                    pFk_shr.Direction = ParameterDirection.Input;
                    pFk_shr.Value = ypkc_djParamLike.Fk_shr;
                    sqlparams.Add(pFk_shr);
                }
                
                if (null != ypkc_djParamLike.Shrxm && "" != ypkc_djParamLike.Shrxm)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.SHRXM LIKE '%'||:shrxm||'%' ");
                    OracleParameter pShrxm = new OracleParameter(":shrxm", OracleDbType.NVarchar2);
                    pShrxm.Direction = ParameterDirection.Input;
                    pShrxm.Value = ypkc_djParamLike.Shrxm;
                    sqlparams.Add(pShrxm);
                }
                
                if (null != ypkc_djParamLike.Zfbz && "" != ypkc_djParamLike.Zfbz)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.ZFBZ LIKE '%'||:zfbz||'%' ");
                    OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                    pZfbz.Direction = ParameterDirection.Input;
                    pZfbz.Value = ypkc_djParamLike.Zfbz;
                    sqlparams.Add(pZfbz);
                }
                
            }

            this.b_isWhere = false;
            return Int32.Parse(OracleHelper.ExecuteScalar(sql.ToString(),sqlparams.ToArray()).ToString());
        }


        /// <summary>
        /// 通用的保存方法，根据用户传入的参数，有ID为修改，没有ID为新增(手动生成OracleConnection对象，此方法用于事务，使用事务必须使用同一个OracleConnection对象)
        /// </summary>
        /// <param name="ypkc_djParam"></param>
        /// <returns></returns>
        public bool save(Ypkc_dj ypkc_djParam,OracleConnection con)
        {
            if ("" != ypkc_djParam.Id && null != ypkc_djParam.Id)
            {
                //修改
                return this.updateById(ypkc_djParam,con);
            }
            else
            {
                //新增
                return this.insert(ypkc_djParam,con);
            }
        }

        /// <summary>
        /// 把dataset中的一行转换为model
        /// </summary>
        /// <param name="row"></param>
        /// <returns></returns>
        private Ypkc_dj dataSetToModel(DataRow row)
        {
            Ypkc_dj ypkc_djParam = new Ypkc_dj();
            ypkc_djParam.Id = Convert.ToString(row["ID"]).Trim(); 
            ypkc_djParam.Djh =  (decimal?)this.convertDBNullValue(row["DJH"]);
            ypkc_djParam.Djlx_code = Convert.ToString(row["DJLX_CODE"]).Trim(); 
            ypkc_djParam.Ypfl_code = Convert.ToString(row["YPFL_CODE"]).Trim(); 
            ypkc_djParam.Fk_lygys = Convert.ToString(row["FK_LYGYS"]).Trim(); 
            ypkc_djParam.Fk_lyks = Convert.ToString(row["FK_LYKS"]).Trim(); 
            ypkc_djParam.Lybh = Convert.ToString(row["LYBH"]).Trim(); 
            ypkc_djParam.Lymc = Convert.ToString(row["LYMC"]).Trim(); 
            ypkc_djParam.Fk_mdks = Convert.ToString(row["FK_MDKS"]).Trim(); 
            ypkc_djParam.Fk_mdgys = Convert.ToString(row["FK_MDGYS"]).Trim(); 
            ypkc_djParam.Mdbh = Convert.ToString(row["MDBH"]).Trim(); 
            ypkc_djParam.Mdmc = Convert.ToString(row["MDMC"]).Trim(); 
            ypkc_djParam.Zdr = Convert.ToString(row["ZDR"]).Trim(); 
            ypkc_djParam.Fk_renyuan_zdr = Convert.ToString(row["FK_RENYUAN_ZDR"]).Trim(); 
            ypkc_djParam.Jzr = Convert.ToString(row["JZR"]).Trim(); 
            ypkc_djParam.Fk_renyuan_jzr = Convert.ToString(row["FK_RENYUAN_JZR"]).Trim(); 
            ypkc_djParam.Zdsj =  (DateTime?)this.convertDBNullValue(row["ZDSJ"]);
            ypkc_djParam.Jzsj =  (DateTime?)this.convertDBNullValue(row["JZSJ"]);
            ypkc_djParam.Jzzt_code = Convert.ToString(row["JZZT_CODE"]).Trim(); 
            ypkc_djParam.Remark = Convert.ToString(row["REMARK"]).Trim(); 
            ypkc_djParam.Caigoufs_code = Convert.ToString(row["CAIGOUFS_CODE"]).Trim(); 
            ypkc_djParam.Peisongfs_code = Convert.ToString(row["PEISONGFS_CODE"]).Trim(); 
            ypkc_djParam.Goujinsj =  (DateTime?)this.convertDBNullValue(row["GOUJINSJ"]);
            ypkc_djParam.Yanshou_code = Convert.ToString(row["YANSHOU_CODE"]).Trim(); 
            ypkc_djParam.Chuliyj = Convert.ToString(row["CHULIYJ"]).Trim(); 
            ypkc_djParam.Chulijg = Convert.ToString(row["CHULIJG"]).Trim(); 
            ypkc_djParam.Tuihuozt_code = Convert.ToString(row["TUIHUOZT_CODE"]).Trim(); 
            ypkc_djParam.Fk_shr = Convert.ToString(row["FK_SHR"]).Trim(); 
            ypkc_djParam.Shrxm = Convert.ToString(row["SHRXM"]).Trim(); 
            ypkc_djParam.Shsj =  (DateTime?)this.convertDBNullValue(row["SHSJ"]);
            ypkc_djParam.Zfbz = Convert.ToString(row["ZFBZ"]).Trim(); 
            
            return ypkc_djParam;
        }

       
        
        //*******************在此以后添加新的方法start
        #region DAL层的implement,实现，start

        /// <summary>
        /// 把dataset中的一行转换为model, 包括相关联的外键对象
        /// </summary>
        /// <param name="row"></param>
        /// <returns></returns>
        private Ypkc_dj dataSetContactObjectsToModel(DataRow row)
        {
            Ypkc_dj ypkc_djParam = this.dataSetToModel(row);

            //添加代码类别实体对象,单据类型（关联代码表，入库、退货）对象
            Jc_code djlxCode = new Jc_code();
            djlxCode.Id = Convert.ToString(row["DJLX_CODE_ID"]).Trim();
            djlxCode.Name = Convert.ToString(row["DJLX_CODE_NAME"]).Trim();
            djlxCode.Value = Convert.ToString(row["DJLX_CODE_VALUE"]).Trim();
            djlxCode.Fk_code_type = Convert.ToString(row["DJLX_CODE_FKCODETYPE"]).Trim();
            djlxCode.Zfbz = Convert.ToString(row["DJLX_CODE_ZFBZ"]).Trim();
            djlxCode.Remark = Convert.ToString(row["DJLX_CODE_REMARK"]).Trim();
            ypkc_djParam.DjlxCode = djlxCode;

            //添加代码类别实体对象,库存药品类型（关联代码表，西药、成药、中药、卫材）对象
            Jc_code ypflCode = new Jc_code();
            ypflCode.Id = Convert.ToString(row["YPFL_CODE_ID"]).Trim();
            ypflCode.Name = Convert.ToString(row["YPFL_CODE_NAME"]).Trim();
            ypflCode.Value = Convert.ToString(row["YPFL_CODE_VALUE"]).Trim();
            ypflCode.Fk_code_type = Convert.ToString(row["YPFL_CODE_FKCODETYPE"]).Trim();
            ypflCode.Zfbz = Convert.ToString(row["YPFL_CODE_ZFBZ"]).Trim();
            ypflCode.Remark = Convert.ToString(row["YPFL_CODE_REMARK"]).Trim();
            ypkc_djParam.YpflCode = ypflCode;

            //添加代码类别实体对象,是否记帐（关联代码表，是否）对象
            Jc_code jzztCode = new Jc_code();
            jzztCode.Id = Convert.ToString(row["JZZT_CODE_ID"]).Trim();
            jzztCode.Name = Convert.ToString(row["JZZT_CODE_NAME"]).Trim();
            jzztCode.Value = Convert.ToString(row["JZZT_CODE_VALUE"]).Trim();
            jzztCode.Fk_code_type = Convert.ToString(row["JZZT_CODE_FKCODETYPE"]).Trim();
            jzztCode.Zfbz = Convert.ToString(row["JZZT_CODE_ZFBZ"]).Trim();
            jzztCode.Remark = Convert.ToString(row["JZZT_CODE_REMARK"]).Trim();
            ypkc_djParam.JzztCode = jzztCode;

            //添加代码类别实体对象,采购方式（关联代码表）对象
            Jc_code caigoufsCode = new Jc_code();
            caigoufsCode.Id = Convert.ToString(row["CAIGOUFS_CODE_ID"]).Trim();
            caigoufsCode.Name = Convert.ToString(row["CAIGOUFS_CODE_NAME"]).Trim();
            caigoufsCode.Value = Convert.ToString(row["CAIGOUFS_CODE_VALUE"]).Trim();
            caigoufsCode.Fk_code_type = Convert.ToString(row["CAIGOUFS_CODE_FKCODETYPE"]).Trim();
            caigoufsCode.Zfbz = Convert.ToString(row["CAIGOUFS_CODE_ZFBZ"]).Trim();
            caigoufsCode.Remark = Convert.ToString(row["CAIGOUFS_CODE_REMARK"]).Trim();
            ypkc_djParam.CaigoufsCode = caigoufsCode;

            //添加代码类别实体对象,配送方式（关联代码表）对象
            Jc_code peisongfsCode = new Jc_code();
            peisongfsCode.Id = Convert.ToString(row["PEISONGFS_CODE_ID"]).Trim();
            peisongfsCode.Name = Convert.ToString(row["PEISONGFS_CODE_NAME"]).Trim();
            peisongfsCode.Value = Convert.ToString(row["PEISONGFS_CODE_VALUE"]).Trim();
            peisongfsCode.Fk_code_type = Convert.ToString(row["PEISONGFS_CODE_FKCODETYPE"]).Trim();
            peisongfsCode.Zfbz = Convert.ToString(row["PEISONGFS_CODE_ZFBZ"]).Trim();
            peisongfsCode.Remark = Convert.ToString(row["PEISONGFS_CODE_REMARK"]).Trim();
            ypkc_djParam.PeisongfsCode = peisongfsCode;

            //添加代码类别实体对象,验收（合格，不合格）对象
            Jc_code yanshouCode = new Jc_code();
            yanshouCode.Id = Convert.ToString(row["YANSHOU_CODE_ID"]).Trim();
            yanshouCode.Name = Convert.ToString(row["YANSHOU_CODE_NAME"]).Trim();
            yanshouCode.Value = Convert.ToString(row["YANSHOU_CODE_VALUE"]).Trim();
            yanshouCode.Fk_code_type = Convert.ToString(row["YANSHOU_CODE_FKCODETYPE"]).Trim();
            yanshouCode.Zfbz = Convert.ToString(row["YANSHOU_CODE_ZFBZ"]).Trim();
            yanshouCode.Remark = Convert.ToString(row["YANSHOU_CODE_REMARK"]).Trim();
            ypkc_djParam.YanshouCode = yanshouCode;

            //添加代码类别实体对象,退货状态（药品采购，退货状态）对象
            Jc_code tuihuoztCode = new Jc_code();
            tuihuoztCode.Id = Convert.ToString(row["TUIHUOZT_CODE_ID"]).Trim();
            tuihuoztCode.Name = Convert.ToString(row["TUIHUOZT_CODE_NAME"]).Trim();
            tuihuoztCode.Value = Convert.ToString(row["TUIHUOZT_CODE_VALUE"]).Trim();
            tuihuoztCode.Fk_code_type = Convert.ToString(row["TUIHUOZT_CODE_FKCODETYPE"]).Trim();
            tuihuoztCode.Zfbz = Convert.ToString(row["TUIHUOZT_CODE_ZFBZ"]).Trim();
            tuihuoztCode.Remark = Convert.ToString(row["TUIHUOZT_CODE_REMARK"]).Trim();
            ypkc_djParam.TuihuoztCode = tuihuoztCode;

            return ypkc_djParam;
        }



        /// <summary>
        /// 查找指定ID的用户,得到相关联的外键对象的方法
        /// </summary>
        /// <remarks>如果id为null、id重复、id未找到就抛异常</remarks>
        /// <returns>Ypkc_dj</returns>
        public Ypkc_dj findContactObjectsById(string id)
        {
            if ("" == id || null == id)
            {
                throw new Exception("主键ID不能为空，请赋值");
            }
            StringBuilder sql = new StringBuilder("SELECT A.* ");
            //新建方法findContactObjectsById，在此加入多表连接要显示的项start
            //sql.Append(",B.字段一,B.字段二,B.字段三");

            sql.Append(@"
            ,TT_DJLX_CODE.ID AS DJLX_CODE_ID,TT_DJLX_CODE.NAME AS DJLX_CODE_NAME,TT_DJLX_CODE.VALUE AS DJLX_CODE_VALUE,TT_DJLX_CODE.FK_CODE_TYPE AS DJLX_CODE_FKCODETYPE,TT_DJLX_CODE.ZFBZ AS DJLX_CODE_ZFBZ,TT_DJLX_CODE.REMARK AS DJLX_CODE_REMARK
            ");

            sql.Append(@"
            ,TT_YPFL_CODE.ID AS YPFL_CODE_ID,TT_YPFL_CODE.NAME AS YPFL_CODE_NAME,TT_YPFL_CODE.VALUE AS YPFL_CODE_VALUE,TT_YPFL_CODE.FK_CODE_TYPE AS YPFL_CODE_FKCODETYPE,TT_YPFL_CODE.ZFBZ AS YPFL_CODE_ZFBZ,TT_YPFL_CODE.REMARK AS YPFL_CODE_REMARK
            ");

            sql.Append(@"
            ,TT_JZZT_CODE.ID AS JZZT_CODE_ID,TT_JZZT_CODE.NAME AS JZZT_CODE_NAME,TT_JZZT_CODE.VALUE AS JZZT_CODE_VALUE,TT_JZZT_CODE.FK_CODE_TYPE AS JZZT_CODE_FKCODETYPE,TT_JZZT_CODE.ZFBZ AS JZZT_CODE_ZFBZ,TT_JZZT_CODE.REMARK AS JZZT_CODE_REMARK
            ");

            sql.Append(@"
            ,TT_CAIGOUFS_CODE.ID AS CAIGOUFS_CODE_ID,TT_CAIGOUFS_CODE.NAME AS CAIGOUFS_CODE_NAME,TT_CAIGOUFS_CODE.VALUE AS CAIGOUFS_CODE_VALUE,TT_CAIGOUFS_CODE.FK_CODE_TYPE AS CAIGOUFS_CODE_FKCODETYPE,TT_CAIGOUFS_CODE.ZFBZ AS CAIGOUFS_CODE_ZFBZ,TT_CAIGOUFS_CODE.REMARK AS CAIGOUFS_CODE_REMARK
            ");

            sql.Append(@"
            ,TT_PEISONGFS_CODE.ID AS PEISONGFS_CODE_ID,TT_PEISONGFS_CODE.NAME AS PEISONGFS_CODE_NAME,TT_PEISONGFS_CODE.VALUE AS PEISONGFS_CODE_VALUE,TT_PEISONGFS_CODE.FK_CODE_TYPE AS PEISONGFS_CODE_FKCODETYPE,TT_PEISONGFS_CODE.ZFBZ AS PEISONGFS_CODE_ZFBZ,TT_PEISONGFS_CODE.REMARK AS PEISONGFS_CODE_REMARK
            ");

            sql.Append(@"
            ,TT_YANSHOU_CODE.ID AS YANSHOU_CODE_ID,TT_YANSHOU_CODE.NAME AS YANSHOU_CODE_NAME,TT_YANSHOU_CODE.VALUE AS YANSHOU_CODE_VALUE,TT_YANSHOU_CODE.FK_CODE_TYPE AS YANSHOU_CODE_FKCODETYPE,TT_YANSHOU_CODE.ZFBZ AS YANSHOU_CODE_ZFBZ,TT_YANSHOU_CODE.REMARK AS YANSHOU_CODE_REMARK
            ");

            sql.Append(@"
            ,TT_TUIHUOZT_CODE.ID AS TUIHUOZT_CODE_ID,TT_TUIHUOZT_CODE.NAME AS TUIHUOZT_CODE_NAME,TT_TUIHUOZT_CODE.VALUE AS TUIHUOZT_CODE_VALUE,TT_TUIHUOZT_CODE.FK_CODE_TYPE AS TUIHUOZT_CODE_FKCODETYPE,TT_TUIHUOZT_CODE.ZFBZ AS TUIHUOZT_CODE_ZFBZ,TT_TUIHUOZT_CODE.REMARK AS TUIHUOZT_CODE_REMARK
            ");

            //新建方法，在此加入多表连接要显示的项end
            sql.Append(" FROM YPKC_DJ A ");
            //新建一个方法，在此加入多表连接的语句start
            //sql.Append("LEFT JOIN 外键表名 B ON A.外键=B.ID");

            sql.Append(@" 
                        LEFT JOIN 
                        (SELECT X.* FROM JC_CODE X WHERE X.FK_CODE_TYPE IN (SELECT Y.ID FROM JC_CODE_TYPE Y WHERE Y.VALUE='" + Model.Common.CommonCode.代码类型值.库存_单据类型 + @"')) TT_DJLX_CODE
                        ON A.DJLX_CODE = TT_DJLX_CODE.VALUE
            ");

            sql.Append(@" 
                        LEFT JOIN 
                        (SELECT X.* FROM JC_CODE X WHERE X.FK_CODE_TYPE IN (SELECT Y.ID FROM JC_CODE_TYPE Y WHERE Y.VALUE='" + Model.Common.CommonCode.代码类型值.药品_分类 + @"')) TT_YPFL_CODE
                        ON A.YPFL_CODE = TT_YPFL_CODE.VALUE
            ");

            sql.Append(@" 
                        LEFT JOIN 
                        (SELECT X.* FROM JC_CODE X WHERE X.FK_CODE_TYPE IN (SELECT Y.ID FROM JC_CODE_TYPE Y WHERE Y.VALUE='" + Model.Common.CommonCode.代码类型值.基础_是否 + @"')) TT_JZZT_CODE
                        ON A.JZZT_CODE = TT_JZZT_CODE.VALUE
            ");

            sql.Append(@" 
                        LEFT JOIN 
                        (SELECT X.* FROM JC_CODE X WHERE X.FK_CODE_TYPE IN (SELECT Y.ID FROM JC_CODE_TYPE Y WHERE Y.VALUE='" + Model.Common.CommonCode.代码类型值.库存_采购方式 + @"')) TT_CAIGOUFS_CODE
                        ON A.CAIGOUFS_CODE = TT_CAIGOUFS_CODE.VALUE
            ");

            sql.Append(@" 
                        LEFT JOIN 
                        (SELECT X.* FROM JC_CODE X WHERE X.FK_CODE_TYPE IN (SELECT Y.ID FROM JC_CODE_TYPE Y WHERE Y.VALUE='" + Model.Common.CommonCode.代码类型值.库存_配送方式 + @"')) TT_PEISONGFS_CODE
                        ON A.PEISONGFS_CODE = TT_PEISONGFS_CODE.VALUE
            ");

            sql.Append(@" 
                        LEFT JOIN 
                        (SELECT X.* FROM JC_CODE X WHERE X.FK_CODE_TYPE IN (SELECT Y.ID FROM JC_CODE_TYPE Y WHERE Y.VALUE='" + Model.Common.CommonCode.代码类型值.库存_验收 + @"')) TT_YANSHOU_CODE
                        ON A.YANSHOU_CODE = TT_YANSHOU_CODE.VALUE
            ");

            sql.Append(@" 
                        LEFT JOIN 
                        (SELECT X.* FROM JC_CODE X WHERE X.FK_CODE_TYPE IN (SELECT Y.ID FROM JC_CODE_TYPE Y WHERE Y.VALUE='" + Model.Common.CommonCode.代码类型值.库存_退货状态 + @"')) TT_TUIHUOZT_CODE
                        ON A.TUIHUOZT_CODE = TT_TUIHUOZT_CODE.VALUE
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
        /// <param name="ypkc_djParam"></param>
        /// <param name="page">分页对象</param>
        ///<param name="ypkc_djParamLike">模糊查询参数</param>
        ///<param name="sortList">排序参数对象的集合</param>
        /// <returns>满足条件的所有Ypkc_dj对象集合list</returns>
        public List<object> findContactObjects(Ypkc_dj ypkc_djParam, Model.Common.PageInfo page, Ypkc_dj ypkc_djParamLike, List<SortInfo> sortList)
        {
            //如果没有传查询条件参数，就new一个空的Ypkc_dj对象，标示查询所有数据
            if (null == ypkc_djParam)
            {
                ypkc_djParam = new Ypkc_dj();
            }
            if (null != ypkc_djParam.Id && "" != ypkc_djParam.Id)
            {
                throw new Exception("此方法不允许指定参数ID，如果需要根据ID查询数据，请调用findById方法；错误出自：find");
            }

            List<Ypkc_dj> ypkc_djParamList = new List<Ypkc_dj>();//接收查询出的Ypkc_dj对象集合
            List<OracleParameter> sqlparams = new List<OracleParameter>();//保存参数的集合
            StringBuilder sql = new StringBuilder("SELECT A.* ");
            //新建方法findAllContactObjects(Ypkc_dj ypkc_djParam, Model.Common.PageInfo page)，在此加入多表连接要显示的项start
            //sql.Append(",B.字段一,B.字段二,B.字段三");

            sql.Append(@"
            ,TT_DJLX_CODE.ID AS DJLX_CODE_ID,TT_DJLX_CODE.NAME AS DJLX_CODE_NAME,TT_DJLX_CODE.VALUE AS DJLX_CODE_VALUE,TT_DJLX_CODE.FK_CODE_TYPE AS DJLX_CODE_FKCODETYPE,TT_DJLX_CODE.ZFBZ AS DJLX_CODE_ZFBZ,TT_DJLX_CODE.REMARK AS DJLX_CODE_REMARK
            ");

            sql.Append(@"
            ,TT_YPFL_CODE.ID AS YPFL_CODE_ID,TT_YPFL_CODE.NAME AS YPFL_CODE_NAME,TT_YPFL_CODE.VALUE AS YPFL_CODE_VALUE,TT_YPFL_CODE.FK_CODE_TYPE AS YPFL_CODE_FKCODETYPE,TT_YPFL_CODE.ZFBZ AS YPFL_CODE_ZFBZ,TT_YPFL_CODE.REMARK AS YPFL_CODE_REMARK
            ");

            sql.Append(@"
            ,TT_JZZT_CODE.ID AS JZZT_CODE_ID,TT_JZZT_CODE.NAME AS JZZT_CODE_NAME,TT_JZZT_CODE.VALUE AS JZZT_CODE_VALUE,TT_JZZT_CODE.FK_CODE_TYPE AS JZZT_CODE_FKCODETYPE,TT_JZZT_CODE.ZFBZ AS JZZT_CODE_ZFBZ,TT_JZZT_CODE.REMARK AS JZZT_CODE_REMARK
            ");

            sql.Append(@"
            ,TT_CAIGOUFS_CODE.ID AS CAIGOUFS_CODE_ID,TT_CAIGOUFS_CODE.NAME AS CAIGOUFS_CODE_NAME,TT_CAIGOUFS_CODE.VALUE AS CAIGOUFS_CODE_VALUE,TT_CAIGOUFS_CODE.FK_CODE_TYPE AS CAIGOUFS_CODE_FKCODETYPE,TT_CAIGOUFS_CODE.ZFBZ AS CAIGOUFS_CODE_ZFBZ,TT_CAIGOUFS_CODE.REMARK AS CAIGOUFS_CODE_REMARK
            ");

            sql.Append(@"
            ,TT_PEISONGFS_CODE.ID AS PEISONGFS_CODE_ID,TT_PEISONGFS_CODE.NAME AS PEISONGFS_CODE_NAME,TT_PEISONGFS_CODE.VALUE AS PEISONGFS_CODE_VALUE,TT_PEISONGFS_CODE.FK_CODE_TYPE AS PEISONGFS_CODE_FKCODETYPE,TT_PEISONGFS_CODE.ZFBZ AS PEISONGFS_CODE_ZFBZ,TT_PEISONGFS_CODE.REMARK AS PEISONGFS_CODE_REMARK
            ");

            sql.Append(@"
            ,TT_YANSHOU_CODE.ID AS YANSHOU_CODE_ID,TT_YANSHOU_CODE.NAME AS YANSHOU_CODE_NAME,TT_YANSHOU_CODE.VALUE AS YANSHOU_CODE_VALUE,TT_YANSHOU_CODE.FK_CODE_TYPE AS YANSHOU_CODE_FKCODETYPE,TT_YANSHOU_CODE.ZFBZ AS YANSHOU_CODE_ZFBZ,TT_YANSHOU_CODE.REMARK AS YANSHOU_CODE_REMARK
            ");

            sql.Append(@"
            ,TT_TUIHUOZT_CODE.ID AS TUIHUOZT_CODE_ID,TT_TUIHUOZT_CODE.NAME AS TUIHUOZT_CODE_NAME,TT_TUIHUOZT_CODE.VALUE AS TUIHUOZT_CODE_VALUE,TT_TUIHUOZT_CODE.FK_CODE_TYPE AS TUIHUOZT_CODE_FKCODETYPE,TT_TUIHUOZT_CODE.ZFBZ AS TUIHUOZT_CODE_ZFBZ,TT_TUIHUOZT_CODE.REMARK AS TUIHUOZT_CODE_REMARK
            ");

            //新建方法，在此加入多表连接要显示的项end
            sql.Append(" FROM YPKC_DJ A ");
            //新建一个方法，在此加入多表连接的语句start
            ////sql.Append(" LEFT JOIN 表名 B ON A.外键=B.ID");

            sql.Append(@" 
                        LEFT JOIN 
                        (SELECT X.* FROM JC_CODE X WHERE X.FK_CODE_TYPE IN (SELECT Y.ID FROM JC_CODE_TYPE Y WHERE Y.VALUE='" + Model.Common.CommonCode.代码类型值.库存_单据类型 + @"')) TT_DJLX_CODE
                        ON A.DJLX_CODE = TT_DJLX_CODE.VALUE
            ");

            sql.Append(@" 
                        LEFT JOIN 
                        (SELECT X.* FROM JC_CODE X WHERE X.FK_CODE_TYPE IN (SELECT Y.ID FROM JC_CODE_TYPE Y WHERE Y.VALUE='" + Model.Common.CommonCode.代码类型值.药品_分类 + @"')) TT_YPFL_CODE
                        ON A.YPFL_CODE = TT_YPFL_CODE.VALUE
            ");

            sql.Append(@" 
                        LEFT JOIN 
                        (SELECT X.* FROM JC_CODE X WHERE X.FK_CODE_TYPE IN (SELECT Y.ID FROM JC_CODE_TYPE Y WHERE Y.VALUE='" + Model.Common.CommonCode.代码类型值.基础_是否 + @"')) TT_JZZT_CODE
                        ON A.JZZT_CODE = TT_JZZT_CODE.VALUE
            ");

            sql.Append(@" 
                        LEFT JOIN 
                        (SELECT X.* FROM JC_CODE X WHERE X.FK_CODE_TYPE IN (SELECT Y.ID FROM JC_CODE_TYPE Y WHERE Y.VALUE='" + Model.Common.CommonCode.代码类型值.库存_采购方式 + @"')) TT_CAIGOUFS_CODE
                        ON A.CAIGOUFS_CODE = TT_CAIGOUFS_CODE.VALUE
            ");

            sql.Append(@" 
                        LEFT JOIN 
                        (SELECT X.* FROM JC_CODE X WHERE X.FK_CODE_TYPE IN (SELECT Y.ID FROM JC_CODE_TYPE Y WHERE Y.VALUE='" + Model.Common.CommonCode.代码类型值.库存_配送方式 + @"')) TT_PEISONGFS_CODE
                        ON A.PEISONGFS_CODE = TT_PEISONGFS_CODE.VALUE
            ");

            sql.Append(@" 
                        LEFT JOIN 
                        (SELECT X.* FROM JC_CODE X WHERE X.FK_CODE_TYPE IN (SELECT Y.ID FROM JC_CODE_TYPE Y WHERE Y.VALUE='" + Model.Common.CommonCode.代码类型值.库存_验收 + @"')) TT_YANSHOU_CODE
                        ON A.YANSHOU_CODE = TT_YANSHOU_CODE.VALUE
            ");

            sql.Append(@" 
                        LEFT JOIN 
                        (SELECT X.* FROM JC_CODE X WHERE X.FK_CODE_TYPE IN (SELECT Y.ID FROM JC_CODE_TYPE Y WHERE Y.VALUE='" + Model.Common.CommonCode.代码类型值.库存_退货状态 + @"')) TT_TUIHUOZT_CODE
                        ON A.TUIHUOZT_CODE = TT_TUIHUOZT_CODE.VALUE
            ");

            //新建一个方法，在此加入多表连接的语句end


            if (null != ypkc_djParam.Djh)
            {
                this.isComma(sql);
                sql.Append(" DJH=:djh ");
                OracleParameter pDjh = new OracleParameter(":djh", OracleDbType.Decimal);
                pDjh.Value = ypkc_djParam.Djh;
                sqlparams.Add(pDjh);

            }

            if (null != ypkc_djParam.Djlx_code && "" != ypkc_djParam.Djlx_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.DJLX_CODE=:djlx_code ");
                OracleParameter pDjlx_code = new OracleParameter(":djlx_code", OracleDbType.NVarchar2);
                pDjlx_code.Value = ypkc_djParam.Djlx_code;
                sqlparams.Add(pDjlx_code);
            }

            if (null != ypkc_djParam.Ypfl_code && "" != ypkc_djParam.Ypfl_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.YPFL_CODE=:ypfl_code ");
                OracleParameter pYpfl_code = new OracleParameter(":ypfl_code", OracleDbType.NVarchar2);
                pYpfl_code.Value = ypkc_djParam.Ypfl_code;
                sqlparams.Add(pYpfl_code);
            }

            if (null != ypkc_djParam.Fk_lygys && "" != ypkc_djParam.Fk_lygys)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.FK_LYGYS=:fk_lygys ");
                OracleParameter pFk_lygys = new OracleParameter(":fk_lygys", OracleDbType.Varchar2);
                pFk_lygys.Value = ypkc_djParam.Fk_lygys;
                sqlparams.Add(pFk_lygys);
            }

            if (null != ypkc_djParam.Fk_lyks && "" != ypkc_djParam.Fk_lyks)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.FK_LYKS=:fk_lyks ");
                OracleParameter pFk_lyks = new OracleParameter(":fk_lyks", OracleDbType.Varchar2);
                pFk_lyks.Value = ypkc_djParam.Fk_lyks;
                sqlparams.Add(pFk_lyks);
            }

            if (null != ypkc_djParam.Lybh && "" != ypkc_djParam.Lybh)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.LYBH=:lybh ");
                OracleParameter pLybh = new OracleParameter(":lybh", OracleDbType.Varchar2);
                pLybh.Value = ypkc_djParam.Lybh;
                sqlparams.Add(pLybh);
            }

            if (null != ypkc_djParam.Lymc && "" != ypkc_djParam.Lymc)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.LYMC=:lymc ");
                OracleParameter pLymc = new OracleParameter(":lymc", OracleDbType.NVarchar2);
                pLymc.Value = ypkc_djParam.Lymc;
                sqlparams.Add(pLymc);
            }

            if (null != ypkc_djParam.Fk_mdks && "" != ypkc_djParam.Fk_mdks)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.FK_MDKS=:fk_mdks ");
                OracleParameter pFk_mdks = new OracleParameter(":fk_mdks", OracleDbType.Varchar2);
                pFk_mdks.Value = ypkc_djParam.Fk_mdks;
                sqlparams.Add(pFk_mdks);
            }

            if (null != ypkc_djParam.Fk_mdgys && "" != ypkc_djParam.Fk_mdgys)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.FK_MDGYS=:fk_mdgys ");
                OracleParameter pFk_mdgys = new OracleParameter(":fk_mdgys", OracleDbType.Varchar2);
                pFk_mdgys.Value = ypkc_djParam.Fk_mdgys;
                sqlparams.Add(pFk_mdgys);
            }

            if (null != ypkc_djParam.Mdbh && "" != ypkc_djParam.Mdbh)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.MDBH=:mdbh ");
                OracleParameter pMdbh = new OracleParameter(":mdbh", OracleDbType.Varchar2);
                pMdbh.Value = ypkc_djParam.Mdbh;
                sqlparams.Add(pMdbh);
            }

            if (null != ypkc_djParam.Mdmc && "" != ypkc_djParam.Mdmc)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.MDMC=:mdmc ");
                OracleParameter pMdmc = new OracleParameter(":mdmc", OracleDbType.NVarchar2);
                pMdmc.Value = ypkc_djParam.Mdmc;
                sqlparams.Add(pMdmc);
            }

            if (null != ypkc_djParam.Zdr && "" != ypkc_djParam.Zdr)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.ZDR=:zdr ");
                OracleParameter pZdr = new OracleParameter(":zdr", OracleDbType.Varchar2);
                pZdr.Value = ypkc_djParam.Zdr;
                sqlparams.Add(pZdr);
            }

            if (null != ypkc_djParam.Fk_renyuan_zdr && "" != ypkc_djParam.Fk_renyuan_zdr)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.FK_RENYUAN_ZDR=:fk_renyuan_zdr ");
                OracleParameter pFk_renyuan_zdr = new OracleParameter(":fk_renyuan_zdr", OracleDbType.Varchar2);
                pFk_renyuan_zdr.Value = ypkc_djParam.Fk_renyuan_zdr;
                sqlparams.Add(pFk_renyuan_zdr);
            }

            if (null != ypkc_djParam.Jzr && "" != ypkc_djParam.Jzr)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.JZR=:jzr ");
                OracleParameter pJzr = new OracleParameter(":jzr", OracleDbType.Varchar2);
                pJzr.Value = ypkc_djParam.Jzr;
                sqlparams.Add(pJzr);
            }

            if (null != ypkc_djParam.Fk_renyuan_jzr && "" != ypkc_djParam.Fk_renyuan_jzr)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.FK_RENYUAN_JZR=:fk_renyuan_jzr ");
                OracleParameter pFk_renyuan_jzr = new OracleParameter(":fk_renyuan_jzr", OracleDbType.Varchar2);
                pFk_renyuan_jzr.Value = ypkc_djParam.Fk_renyuan_jzr;
                sqlparams.Add(pFk_renyuan_jzr);
            }

            if (DateTime.MinValue != ypkc_djParam.Zdsj && null != ypkc_djParam.Zdsj)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.ZDSJ=:zdsj ");
                OracleParameter pZdsj = new OracleParameter(":zdsj", OracleDbType.Date);
                pZdsj.Value = ypkc_djParam.Zdsj;
                sqlparams.Add(pZdsj);
            }

            if (DateTime.MinValue != ypkc_djParam.Jzsj && null != ypkc_djParam.Jzsj)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.JZSJ=:jzsj ");
                OracleParameter pJzsj = new OracleParameter(":jzsj", OracleDbType.Date);
                pJzsj.Value = ypkc_djParam.Jzsj;
                sqlparams.Add(pJzsj);
            }

            if (null != ypkc_djParam.Jzzt_code && "" != ypkc_djParam.Jzzt_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.JZZT_CODE=:jzzt_code ");
                OracleParameter pJzzt_code = new OracleParameter(":jzzt_code", OracleDbType.Varchar2);
                pJzzt_code.Value = ypkc_djParam.Jzzt_code;
                sqlparams.Add(pJzzt_code);
            }

            if (null != ypkc_djParam.Remark && "" != ypkc_djParam.Remark)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.REMARK=:remark ");
                OracleParameter pRemark = new OracleParameter(":remark", OracleDbType.Varchar2);
                pRemark.Value = ypkc_djParam.Remark;
                sqlparams.Add(pRemark);
            }

            if (null != ypkc_djParam.Caigoufs_code && "" != ypkc_djParam.Caigoufs_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.CAIGOUFS_CODE=:caigoufs_code ");
                OracleParameter pCaigoufs_code = new OracleParameter(":caigoufs_code", OracleDbType.NVarchar2);
                pCaigoufs_code.Value = ypkc_djParam.Caigoufs_code;
                sqlparams.Add(pCaigoufs_code);
            }

            if (null != ypkc_djParam.Peisongfs_code && "" != ypkc_djParam.Peisongfs_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.PEISONGFS_CODE=:peisongfs_code ");
                OracleParameter pPeisongfs_code = new OracleParameter(":peisongfs_code", OracleDbType.NVarchar2);
                pPeisongfs_code.Value = ypkc_djParam.Peisongfs_code;
                sqlparams.Add(pPeisongfs_code);
            }

            if (DateTime.MinValue != ypkc_djParam.Goujinsj && null != ypkc_djParam.Goujinsj)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.GOUJINSJ=:goujinsj ");
                OracleParameter pGoujinsj = new OracleParameter(":goujinsj", OracleDbType.Date);
                pGoujinsj.Value = ypkc_djParam.Goujinsj;
                sqlparams.Add(pGoujinsj);
            }

            if (null != ypkc_djParam.Yanshou_code && "" != ypkc_djParam.Yanshou_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.YANSHOU_CODE=:yanshou_code ");
                OracleParameter pYanshou_code = new OracleParameter(":yanshou_code", OracleDbType.NVarchar2);
                pYanshou_code.Value = ypkc_djParam.Yanshou_code;
                sqlparams.Add(pYanshou_code);
            }

            if (null != ypkc_djParam.Chuliyj && "" != ypkc_djParam.Chuliyj)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.CHULIYJ=:chuliyj ");
                OracleParameter pChuliyj = new OracleParameter(":chuliyj", OracleDbType.NVarchar2);
                pChuliyj.Value = ypkc_djParam.Chuliyj;
                sqlparams.Add(pChuliyj);
            }

            if (null != ypkc_djParam.Chulijg && "" != ypkc_djParam.Chulijg)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.CHULIJG=:chulijg ");
                OracleParameter pChulijg = new OracleParameter(":chulijg", OracleDbType.NVarchar2);
                pChulijg.Value = ypkc_djParam.Chulijg;
                sqlparams.Add(pChulijg);
            }

            if (null != ypkc_djParam.Tuihuozt_code && "" != ypkc_djParam.Tuihuozt_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.TUIHUOZT_CODE=:tuihuozt_code ");
                OracleParameter pTuihuozt_code = new OracleParameter(":tuihuozt_code", OracleDbType.NVarchar2);
                pTuihuozt_code.Value = ypkc_djParam.Tuihuozt_code;
                sqlparams.Add(pTuihuozt_code);
            }

            if (null != ypkc_djParam.Fk_shr && "" != ypkc_djParam.Fk_shr)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.FK_SHR=:fk_shr ");
                OracleParameter pFk_shr = new OracleParameter(":fk_shr", OracleDbType.Varchar2);
                pFk_shr.Value = ypkc_djParam.Fk_shr;
                sqlparams.Add(pFk_shr);
            }

            if (null != ypkc_djParam.Shrxm && "" != ypkc_djParam.Shrxm)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.SHRXM=:shrxm ");
                OracleParameter pShrxm = new OracleParameter(":shrxm", OracleDbType.NVarchar2);
                pShrxm.Value = ypkc_djParam.Shrxm;
                sqlparams.Add(pShrxm);
            }

            if (DateTime.MinValue != ypkc_djParam.Shsj && null != ypkc_djParam.Shsj)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.SHSJ=:shsj ");
                OracleParameter pShsj = new OracleParameter(":shsj", OracleDbType.Date);
                pShsj.Value = ypkc_djParam.Shsj;
                sqlparams.Add(pShsj);
            }

            if (null != ypkc_djParam.Zfbz && "" != ypkc_djParam.Zfbz)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.ZFBZ=:zfbz ");
                OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                pZfbz.Value = ypkc_djParam.Zfbz;
                sqlparams.Add(pZfbz);
            }

            if (ypkc_djParamLike != null)
            {

                if (null != ypkc_djParamLike.Djlx_code && "" != ypkc_djParamLike.Djlx_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.DJLX_CODE LIKE '%'||:djlx_code||'%' ");
                    OracleParameter pDjlx_code = new OracleParameter(":djlx_code", OracleDbType.NVarchar2);
                    pDjlx_code.Direction = ParameterDirection.Input;
                    pDjlx_code.Value = ypkc_djParamLike.Djlx_code;
                    sqlparams.Add(pDjlx_code);
                }

                if (null != ypkc_djParamLike.Ypfl_code && "" != ypkc_djParamLike.Ypfl_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YPFL_CODE LIKE '%'||:ypfl_code||'%' ");
                    OracleParameter pYpfl_code = new OracleParameter(":ypfl_code", OracleDbType.NVarchar2);
                    pYpfl_code.Direction = ParameterDirection.Input;
                    pYpfl_code.Value = ypkc_djParamLike.Ypfl_code;
                    sqlparams.Add(pYpfl_code);
                }

                if (null != ypkc_djParamLike.Fk_lygys && "" != ypkc_djParamLike.Fk_lygys)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.FK_LYGYS LIKE '%'||:fk_lygys||'%' ");
                    OracleParameter pFk_lygys = new OracleParameter(":fk_lygys", OracleDbType.Varchar2);
                    pFk_lygys.Direction = ParameterDirection.Input;
                    pFk_lygys.Value = ypkc_djParamLike.Fk_lygys;
                    sqlparams.Add(pFk_lygys);
                }

                if (null != ypkc_djParamLike.Fk_lyks && "" != ypkc_djParamLike.Fk_lyks)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.FK_LYKS LIKE '%'||:fk_lyks||'%' ");
                    OracleParameter pFk_lyks = new OracleParameter(":fk_lyks", OracleDbType.Varchar2);
                    pFk_lyks.Direction = ParameterDirection.Input;
                    pFk_lyks.Value = ypkc_djParamLike.Fk_lyks;
                    sqlparams.Add(pFk_lyks);
                }

                if (null != ypkc_djParamLike.Lybh && "" != ypkc_djParamLike.Lybh)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.LYBH LIKE '%'||:lybh||'%' ");
                    OracleParameter pLybh = new OracleParameter(":lybh", OracleDbType.Varchar2);
                    pLybh.Direction = ParameterDirection.Input;
                    pLybh.Value = ypkc_djParamLike.Lybh;
                    sqlparams.Add(pLybh);
                }

                if (null != ypkc_djParamLike.Lymc && "" != ypkc_djParamLike.Lymc)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.LYMC LIKE '%'||:lymc||'%' ");
                    OracleParameter pLymc = new OracleParameter(":lymc", OracleDbType.NVarchar2);
                    pLymc.Direction = ParameterDirection.Input;
                    pLymc.Value = ypkc_djParamLike.Lymc;
                    sqlparams.Add(pLymc);
                }

                if (null != ypkc_djParamLike.Fk_mdks && "" != ypkc_djParamLike.Fk_mdks)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.FK_MDKS LIKE '%'||:fk_mdks||'%' ");
                    OracleParameter pFk_mdks = new OracleParameter(":fk_mdks", OracleDbType.Varchar2);
                    pFk_mdks.Direction = ParameterDirection.Input;
                    pFk_mdks.Value = ypkc_djParamLike.Fk_mdks;
                    sqlparams.Add(pFk_mdks);
                }

                if (null != ypkc_djParamLike.Fk_mdgys && "" != ypkc_djParamLike.Fk_mdgys)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.FK_MDGYS LIKE '%'||:fk_mdgys||'%' ");
                    OracleParameter pFk_mdgys = new OracleParameter(":fk_mdgys", OracleDbType.Varchar2);
                    pFk_mdgys.Direction = ParameterDirection.Input;
                    pFk_mdgys.Value = ypkc_djParamLike.Fk_mdgys;
                    sqlparams.Add(pFk_mdgys);
                }

                if (null != ypkc_djParamLike.Mdbh && "" != ypkc_djParamLike.Mdbh)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.MDBH LIKE '%'||:mdbh||'%' ");
                    OracleParameter pMdbh = new OracleParameter(":mdbh", OracleDbType.Varchar2);
                    pMdbh.Direction = ParameterDirection.Input;
                    pMdbh.Value = ypkc_djParamLike.Mdbh;
                    sqlparams.Add(pMdbh);
                }

                if (null != ypkc_djParamLike.Mdmc && "" != ypkc_djParamLike.Mdmc)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.MDMC LIKE '%'||:mdmc||'%' ");
                    OracleParameter pMdmc = new OracleParameter(":mdmc", OracleDbType.NVarchar2);
                    pMdmc.Direction = ParameterDirection.Input;
                    pMdmc.Value = ypkc_djParamLike.Mdmc;
                    sqlparams.Add(pMdmc);
                }

                if (null != ypkc_djParamLike.Zdr && "" != ypkc_djParamLike.Zdr)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.ZDR LIKE '%'||:zdr||'%' ");
                    OracleParameter pZdr = new OracleParameter(":zdr", OracleDbType.Varchar2);
                    pZdr.Direction = ParameterDirection.Input;
                    pZdr.Value = ypkc_djParamLike.Zdr;
                    sqlparams.Add(pZdr);
                }

                if (null != ypkc_djParamLike.Fk_renyuan_zdr && "" != ypkc_djParamLike.Fk_renyuan_zdr)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.FK_RENYUAN_ZDR LIKE '%'||:fk_renyuan_zdr||'%' ");
                    OracleParameter pFk_renyuan_zdr = new OracleParameter(":fk_renyuan_zdr", OracleDbType.Varchar2);
                    pFk_renyuan_zdr.Direction = ParameterDirection.Input;
                    pFk_renyuan_zdr.Value = ypkc_djParamLike.Fk_renyuan_zdr;
                    sqlparams.Add(pFk_renyuan_zdr);
                }

                if (null != ypkc_djParamLike.Jzr && "" != ypkc_djParamLike.Jzr)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.JZR LIKE '%'||:jzr||'%' ");
                    OracleParameter pJzr = new OracleParameter(":jzr", OracleDbType.Varchar2);
                    pJzr.Direction = ParameterDirection.Input;
                    pJzr.Value = ypkc_djParamLike.Jzr;
                    sqlparams.Add(pJzr);
                }

                if (null != ypkc_djParamLike.Fk_renyuan_jzr && "" != ypkc_djParamLike.Fk_renyuan_jzr)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.FK_RENYUAN_JZR LIKE '%'||:fk_renyuan_jzr||'%' ");
                    OracleParameter pFk_renyuan_jzr = new OracleParameter(":fk_renyuan_jzr", OracleDbType.Varchar2);
                    pFk_renyuan_jzr.Direction = ParameterDirection.Input;
                    pFk_renyuan_jzr.Value = ypkc_djParamLike.Fk_renyuan_jzr;
                    sqlparams.Add(pFk_renyuan_jzr);
                }

                if (null != ypkc_djParamLike.Jzzt_code && "" != ypkc_djParamLike.Jzzt_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.JZZT_CODE LIKE '%'||:jzzt_code||'%' ");
                    OracleParameter pJzzt_code = new OracleParameter(":jzzt_code", OracleDbType.Varchar2);
                    pJzzt_code.Direction = ParameterDirection.Input;
                    pJzzt_code.Value = ypkc_djParamLike.Jzzt_code;
                    sqlparams.Add(pJzzt_code);
                }

                if (null != ypkc_djParamLike.Remark && "" != ypkc_djParamLike.Remark)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.REMARK LIKE '%'||:remark||'%' ");
                    OracleParameter pRemark = new OracleParameter(":remark", OracleDbType.Varchar2);
                    pRemark.Direction = ParameterDirection.Input;
                    pRemark.Value = ypkc_djParamLike.Remark;
                    sqlparams.Add(pRemark);
                }

                if (null != ypkc_djParamLike.Caigoufs_code && "" != ypkc_djParamLike.Caigoufs_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.CAIGOUFS_CODE LIKE '%'||:caigoufs_code||'%' ");
                    OracleParameter pCaigoufs_code = new OracleParameter(":caigoufs_code", OracleDbType.NVarchar2);
                    pCaigoufs_code.Direction = ParameterDirection.Input;
                    pCaigoufs_code.Value = ypkc_djParamLike.Caigoufs_code;
                    sqlparams.Add(pCaigoufs_code);
                }

                if (null != ypkc_djParamLike.Peisongfs_code && "" != ypkc_djParamLike.Peisongfs_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.PEISONGFS_CODE LIKE '%'||:peisongfs_code||'%' ");
                    OracleParameter pPeisongfs_code = new OracleParameter(":peisongfs_code", OracleDbType.NVarchar2);
                    pPeisongfs_code.Direction = ParameterDirection.Input;
                    pPeisongfs_code.Value = ypkc_djParamLike.Peisongfs_code;
                    sqlparams.Add(pPeisongfs_code);
                }

                if (null != ypkc_djParamLike.Yanshou_code && "" != ypkc_djParamLike.Yanshou_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YANSHOU_CODE LIKE '%'||:yanshou_code||'%' ");
                    OracleParameter pYanshou_code = new OracleParameter(":yanshou_code", OracleDbType.NVarchar2);
                    pYanshou_code.Direction = ParameterDirection.Input;
                    pYanshou_code.Value = ypkc_djParamLike.Yanshou_code;
                    sqlparams.Add(pYanshou_code);
                }

                if (null != ypkc_djParamLike.Chuliyj && "" != ypkc_djParamLike.Chuliyj)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.CHULIYJ LIKE '%'||:chuliyj||'%' ");
                    OracleParameter pChuliyj = new OracleParameter(":chuliyj", OracleDbType.NVarchar2);
                    pChuliyj.Direction = ParameterDirection.Input;
                    pChuliyj.Value = ypkc_djParamLike.Chuliyj;
                    sqlparams.Add(pChuliyj);
                }

                if (null != ypkc_djParamLike.Chulijg && "" != ypkc_djParamLike.Chulijg)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.CHULIJG LIKE '%'||:chulijg||'%' ");
                    OracleParameter pChulijg = new OracleParameter(":chulijg", OracleDbType.NVarchar2);
                    pChulijg.Direction = ParameterDirection.Input;
                    pChulijg.Value = ypkc_djParamLike.Chulijg;
                    sqlparams.Add(pChulijg);
                }

                if (null != ypkc_djParamLike.Tuihuozt_code && "" != ypkc_djParamLike.Tuihuozt_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.TUIHUOZT_CODE LIKE '%'||:tuihuozt_code||'%' ");
                    OracleParameter pTuihuozt_code = new OracleParameter(":tuihuozt_code", OracleDbType.NVarchar2);
                    pTuihuozt_code.Direction = ParameterDirection.Input;
                    pTuihuozt_code.Value = ypkc_djParamLike.Tuihuozt_code;
                    sqlparams.Add(pTuihuozt_code);
                }

                if (null != ypkc_djParamLike.Fk_shr && "" != ypkc_djParamLike.Fk_shr)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.FK_SHR LIKE '%'||:fk_shr||'%' ");
                    OracleParameter pFk_shr = new OracleParameter(":fk_shr", OracleDbType.Varchar2);
                    pFk_shr.Direction = ParameterDirection.Input;
                    pFk_shr.Value = ypkc_djParamLike.Fk_shr;
                    sqlparams.Add(pFk_shr);
                }

                if (null != ypkc_djParamLike.Shrxm && "" != ypkc_djParamLike.Shrxm)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.SHRXM LIKE '%'||:shrxm||'%' ");
                    OracleParameter pShrxm = new OracleParameter(":shrxm", OracleDbType.NVarchar2);
                    pShrxm.Direction = ParameterDirection.Input;
                    pShrxm.Value = ypkc_djParamLike.Shrxm;
                    sqlparams.Add(pShrxm);
                }

                if (null != ypkc_djParamLike.Zfbz && "" != ypkc_djParamLike.Zfbz)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.ZFBZ LIKE '%'||:zfbz||'%' ");
                    OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                    pZfbz.Direction = ParameterDirection.Input;
                    pZfbz.Value = ypkc_djParamLike.Zfbz;
                    sqlparams.Add(pZfbz);
                }

            }

            this.b_isWhere = false;
            //排序
            this.addSort(sql, sortList);
            //*******分页start1*********如果分页对象为空，则全部数据查出，如果不为空
            List<object> returnList = new List<object>();//返回的List,索引0为List<Ypkc_dj>对象,索引1为Model.Common.PageInfo分页信息对象
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
            //把每一行数据转换为一个对象放入List<Ypkc_dj>中
            for (int i = 0; i < rows.Count; i++)
            {
                DataRow row = rows[i];
                ypkc_djParamList.Add(this.dataSetContactObjectsToModel(row));
                //ypkc_djParamList.Add(this.dataSetToModel(row));
            }

            //*******分页start2*********如果没有传入分页对象，则新建一个分页对象当做返回值
            if (null == page)
            {
                page = new Model.Common.PageInfo();
                page.AllCount = rows.Count;
            }
            returnList.Add(ypkc_djParamList);//把List<Ypkc_dj>放入List<object>中第一个
            returnList.Add(page);//把page对象放入List<object>中第二个
            //*******分页end2*********
            return returnList;
        }
        #endregion DAL层的implement,实现，end

        


        //*******************在此以后添加新的方法end
        
    }
}


