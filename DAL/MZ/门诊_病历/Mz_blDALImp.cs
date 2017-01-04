

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

namespace DAL.MZ.门诊_病历
{
    /// <summary>
    ///数据库访问层的Mz_bl实现类
    ///此类由代码生成器生成
    ///表名：MZ_BL
    ///生成日期：2015-12-31 10:42:53
    /// 

    ///作者：罗新鑫
    ///联系电话：15087010221
    ///联系邮箱：362527240@qq.com
        
    /// </summary>
    public class Mz_blDALImp :Base.BasDAL,Mz_blDAL
    {

        /// <summary>
        /// 插入一条数据（如果需要供事务使用就传入OracleConnection对象，如果不供就传入null，方法自动生成OracleConnection对象）
        /// 主键为null时，自动生成主键guid，一般不直接调用此方法，请调用save方法进行单条数据的插入和修改       
        /// </summary>
        /// <param name="mz_blParam">要插入的mz_blParam对象</param>
        /// <param name="con">Oracle连接对象（为null时自动生成）</param>
        /// <returns>是否添加成功（影响的行数为1时成功）</returns>
        public bool insert(Mz_bl mz_blParam,OracleConnection con)
        {
            if (""==mz_blParam.Id||null==mz_blParam.Id)
            {
                mz_blParam.Id = Model.Common.GUIDHelper.getGuid();
            }
            List<OracleParameter> sqlparams = new List<OracleParameter>();
            
            StringBuilder sql = new StringBuilder("INSERT INTO MZ_BL(id,zfbz,zs,xbs,jws,gms,tw,hx,mb,ssxy,szxy,xl,kfxtz,cha_ti,fk_gh_id,gh_lsh,clyj) VALUES(:id,:zfbz,:zs,:xbs,:jws,:gms,:tw,:hx,:mb,:ssxy,:szxy,:xl,:kfxtz,:cha_ti,:fk_gh_id,:gh_lsh,:clyj)");
            
            OracleParameter pId = new OracleParameter(":id", OracleDbType.Varchar2);
            pId.Direction = ParameterDirection.Input;
            pId.Value = mz_blParam.Id;
            sqlparams.Add(pId);
            OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
            pZfbz.Direction = ParameterDirection.Input;
            pZfbz.Value = mz_blParam.Zfbz;
            sqlparams.Add(pZfbz);
            OracleParameter pZs = new OracleParameter(":zs", OracleDbType.NVarchar2);
            pZs.Direction = ParameterDirection.Input;
            pZs.Value = mz_blParam.Zs;
            sqlparams.Add(pZs);
            OracleParameter pXbs = new OracleParameter(":xbs", OracleDbType.NVarchar2);
            pXbs.Direction = ParameterDirection.Input;
            pXbs.Value = mz_blParam.Xbs;
            sqlparams.Add(pXbs);
            OracleParameter pJws = new OracleParameter(":jws", OracleDbType.NVarchar2);
            pJws.Direction = ParameterDirection.Input;
            pJws.Value = mz_blParam.Jws;
            sqlparams.Add(pJws);
            OracleParameter pGms = new OracleParameter(":gms", OracleDbType.NVarchar2);
            pGms.Direction = ParameterDirection.Input;
            pGms.Value = mz_blParam.Gms;
            sqlparams.Add(pGms);
            OracleParameter pTw = new OracleParameter(":tw", OracleDbType.Decimal);
            pTw.Direction = ParameterDirection.Input;
            pTw.Value = mz_blParam.Tw;
            sqlparams.Add(pTw);
            OracleParameter pHx = new OracleParameter(":hx", OracleDbType.Decimal);
            pHx.Direction = ParameterDirection.Input;
            pHx.Value = mz_blParam.Hx;
            sqlparams.Add(pHx);
            OracleParameter pMb = new OracleParameter(":mb", OracleDbType.Decimal);
            pMb.Direction = ParameterDirection.Input;
            pMb.Value = mz_blParam.Mb;
            sqlparams.Add(pMb);
            OracleParameter pSsxy = new OracleParameter(":ssxy", OracleDbType.Decimal);
            pSsxy.Direction = ParameterDirection.Input;
            pSsxy.Value = mz_blParam.Ssxy;
            sqlparams.Add(pSsxy);
            OracleParameter pSzxy = new OracleParameter(":szxy", OracleDbType.Decimal);
            pSzxy.Direction = ParameterDirection.Input;
            pSzxy.Value = mz_blParam.Szxy;
            sqlparams.Add(pSzxy);
            OracleParameter pXl = new OracleParameter(":xl", OracleDbType.Decimal);
            pXl.Direction = ParameterDirection.Input;
            pXl.Value = mz_blParam.Xl;
            sqlparams.Add(pXl);
            OracleParameter pKfxtz = new OracleParameter(":kfxtz", OracleDbType.Decimal);
            pKfxtz.Direction = ParameterDirection.Input;
            pKfxtz.Value = mz_blParam.Kfxtz;
            sqlparams.Add(pKfxtz);
            OracleParameter pCha_ti = new OracleParameter(":cha_ti", OracleDbType.NVarchar2);
            pCha_ti.Direction = ParameterDirection.Input;
            pCha_ti.Value = mz_blParam.Cha_ti;
            sqlparams.Add(pCha_ti);
            OracleParameter pFk_gh_id = new OracleParameter(":fk_gh_id", OracleDbType.Varchar2);
            pFk_gh_id.Direction = ParameterDirection.Input;
            pFk_gh_id.Value = mz_blParam.Fk_gh_id;
            sqlparams.Add(pFk_gh_id);
            OracleParameter pGh_lsh = new OracleParameter(":gh_lsh", OracleDbType.Decimal);
            pGh_lsh.Direction = ParameterDirection.Input;
            pGh_lsh.Value = mz_blParam.Gh_lsh;
            sqlparams.Add(pGh_lsh);
            OracleParameter pClyj = new OracleParameter(":clyj", OracleDbType.NVarchar2);
            pClyj.Direction = ParameterDirection.Input;
            pClyj.Value = mz_blParam.Clyj;
            sqlparams.Add(pClyj);
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
        /// <param name="mz_blParamList">要插入的mz_blParam对象的集合</param>
        /// <param name="con">Oracle连接对象（为null时自动生成）</param>
        /// <returns>是否添加成功（影响的行数等于保存的对象的数量时成功）</returns>
        public bool inertBatch(List<Mz_bl> mz_blParamList, OracleConnection con)
        {
            if (mz_blParamList.Count == 0)
            {
                return true;
            }

            List<string> idList = new List<string>();

            List<string> zfbzList = new List<string>();

            List<string> zsList = new List<string>();

            List<string> xbsList = new List<string>();

            List<string> jwsList = new List<string>();

            List<string> gmsList = new List<string>();

            List<decimal?> twList = new List<decimal?>();

            List<decimal?> hxList = new List<decimal?>();

            List<decimal?> mbList = new List<decimal?>();

            List<decimal?> ssxyList = new List<decimal?>();

            List<decimal?> szxyList = new List<decimal?>();

            List<decimal?> xlList = new List<decimal?>();

            List<decimal?> kfxtzList = new List<decimal?>();

            List<string> cha_tiList = new List<string>();

            List<string> fk_gh_idList = new List<string>();

            List<decimal?> gh_lshList = new List<decimal?>();

            List<string> clyjList = new List<string>();

            for (int i = 0; i < mz_blParamList.Count; i++)
            {
                Mz_bl mz_blParam = mz_blParamList[i];
                if ("" == mz_blParam.Id || null == mz_blParam.Id)
                {
                    mz_blParam.Id = Model.Common.GUIDHelper.getGuid();
                }

            idList.Add(mz_blParam.Id);

            zfbzList.Add(mz_blParam.Zfbz);

            zsList.Add(mz_blParam.Zs);

            xbsList.Add(mz_blParam.Xbs);

            jwsList.Add(mz_blParam.Jws);

            gmsList.Add(mz_blParam.Gms);

            twList.Add(mz_blParam.Tw);

            hxList.Add(mz_blParam.Hx);

            mbList.Add(mz_blParam.Mb);

            ssxyList.Add(mz_blParam.Ssxy);

            szxyList.Add(mz_blParam.Szxy);

            xlList.Add(mz_blParam.Xl);

            kfxtzList.Add(mz_blParam.Kfxtz);

            cha_tiList.Add(mz_blParam.Cha_ti);

            fk_gh_idList.Add(mz_blParam.Fk_gh_id);

            gh_lshList.Add(mz_blParam.Gh_lsh);

            clyjList.Add(mz_blParam.Clyj);

            }

            List<OracleParameter> sqlparams = new List<OracleParameter>();

            StringBuilder sql = new StringBuilder("INSERT INTO MZ_BL(id,zfbz,zs,xbs,jws,gms,tw,hx,mb,ssxy,szxy,xl,kfxtz,cha_ti,fk_gh_id,gh_lsh,clyj) VALUES(:id,:zfbz,:zs,:xbs,:jws,:gms,:tw,:hx,:mb,:ssxy,:szxy,:xl,:kfxtz,:cha_ti,:fk_gh_id,:gh_lsh,:clyj)");
            
            OracleParameter pId = new OracleParameter(":id", OracleDbType.Varchar2);
            pId.Direction = ParameterDirection.Input;
            pId.Value = idList.ToArray();
            sqlparams.Add(pId);
            OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
            pZfbz.Direction = ParameterDirection.Input;
            pZfbz.Value = zfbzList.ToArray();
            sqlparams.Add(pZfbz);
            OracleParameter pZs = new OracleParameter(":zs", OracleDbType.NVarchar2);
            pZs.Direction = ParameterDirection.Input;
            pZs.Value = zsList.ToArray();
            sqlparams.Add(pZs);
            OracleParameter pXbs = new OracleParameter(":xbs", OracleDbType.NVarchar2);
            pXbs.Direction = ParameterDirection.Input;
            pXbs.Value = xbsList.ToArray();
            sqlparams.Add(pXbs);
            OracleParameter pJws = new OracleParameter(":jws", OracleDbType.NVarchar2);
            pJws.Direction = ParameterDirection.Input;
            pJws.Value = jwsList.ToArray();
            sqlparams.Add(pJws);
            OracleParameter pGms = new OracleParameter(":gms", OracleDbType.NVarchar2);
            pGms.Direction = ParameterDirection.Input;
            pGms.Value = gmsList.ToArray();
            sqlparams.Add(pGms);
            OracleParameter pTw = new OracleParameter(":tw", OracleDbType.Decimal);
            pTw.Direction = ParameterDirection.Input;
            pTw.Value = twList.ToArray();
            sqlparams.Add(pTw);
            OracleParameter pHx = new OracleParameter(":hx", OracleDbType.Decimal);
            pHx.Direction = ParameterDirection.Input;
            pHx.Value = hxList.ToArray();
            sqlparams.Add(pHx);
            OracleParameter pMb = new OracleParameter(":mb", OracleDbType.Decimal);
            pMb.Direction = ParameterDirection.Input;
            pMb.Value = mbList.ToArray();
            sqlparams.Add(pMb);
            OracleParameter pSsxy = new OracleParameter(":ssxy", OracleDbType.Decimal);
            pSsxy.Direction = ParameterDirection.Input;
            pSsxy.Value = ssxyList.ToArray();
            sqlparams.Add(pSsxy);
            OracleParameter pSzxy = new OracleParameter(":szxy", OracleDbType.Decimal);
            pSzxy.Direction = ParameterDirection.Input;
            pSzxy.Value = szxyList.ToArray();
            sqlparams.Add(pSzxy);
            OracleParameter pXl = new OracleParameter(":xl", OracleDbType.Decimal);
            pXl.Direction = ParameterDirection.Input;
            pXl.Value = xlList.ToArray();
            sqlparams.Add(pXl);
            OracleParameter pKfxtz = new OracleParameter(":kfxtz", OracleDbType.Decimal);
            pKfxtz.Direction = ParameterDirection.Input;
            pKfxtz.Value = kfxtzList.ToArray();
            sqlparams.Add(pKfxtz);
            OracleParameter pCha_ti = new OracleParameter(":cha_ti", OracleDbType.NVarchar2);
            pCha_ti.Direction = ParameterDirection.Input;
            pCha_ti.Value = cha_tiList.ToArray();
            sqlparams.Add(pCha_ti);
            OracleParameter pFk_gh_id = new OracleParameter(":fk_gh_id", OracleDbType.Varchar2);
            pFk_gh_id.Direction = ParameterDirection.Input;
            pFk_gh_id.Value = fk_gh_idList.ToArray();
            sqlparams.Add(pFk_gh_id);
            OracleParameter pGh_lsh = new OracleParameter(":gh_lsh", OracleDbType.Decimal);
            pGh_lsh.Direction = ParameterDirection.Input;
            pGh_lsh.Value = gh_lshList.ToArray();
            sqlparams.Add(pGh_lsh);
            OracleParameter pClyj = new OracleParameter(":clyj", OracleDbType.NVarchar2);
            pClyj.Direction = ParameterDirection.Input;
            pClyj.Value = clyjList.ToArray();
            sqlparams.Add(pClyj);
            bool result = false;
            int flag = -1;
            flag = OracleHelper.ExecuteBatch(sql.ToString(), con, mz_blParamList.Count, sqlparams.ToArray());
            if (mz_blParamList.Count == flag)
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
            StringBuilder sql = new StringBuilder("DELETE MZ_BL WHERE ID=:id");
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
            StringBuilder sql = new StringBuilder("DELETE MZ_BL WHERE ID=:id");
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
        /// <param name="mz_blParamCondition">删除的条件</param>
        /// <param name="con">Oracle连接对象（为null时自动生成）</param>
        /// <returns>无法确定删除的行数（影响行数大于等于0就算成功）</returns>
        public bool deleteByOtherCondition(Mz_bl mz_blParamCondition, OracleConnection con)
        {
            if (null!=mz_blParamCondition.Id&&""!=mz_blParamCondition.Id)
            {
                throw new Exception("不允许指定参数的ID，如果要根据ID删除数据请调用deleteById或者deleteByIdBatch方法；错误出自：deleteByOtherCondition");
            }
            List<OracleParameter> sqlparams = new List<OracleParameter>();
            StringBuilder sql = new StringBuilder("DELETE MZ_BL ");

            if (null != mz_blParamCondition.Zfbz &&  ""!= mz_blParamCondition.Zfbz)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" ZFBZ=:zfbz ");
                OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                pZfbz.Direction = ParameterDirection.Input;
                pZfbz.Value = mz_blParamCondition.Zfbz;
                sqlparams.Add(pZfbz);

            }
                        
            if (null != mz_blParamCondition.Zs &&  ""!= mz_blParamCondition.Zs)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" ZS=:zs ");
                OracleParameter pZs = new OracleParameter(":zs", OracleDbType.NVarchar2);
                pZs.Direction = ParameterDirection.Input;
                pZs.Value = mz_blParamCondition.Zs;
                sqlparams.Add(pZs);

            }
                        
            if (null != mz_blParamCondition.Xbs &&  ""!= mz_blParamCondition.Xbs)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" XBS=:xbs ");
                OracleParameter pXbs = new OracleParameter(":xbs", OracleDbType.NVarchar2);
                pXbs.Direction = ParameterDirection.Input;
                pXbs.Value = mz_blParamCondition.Xbs;
                sqlparams.Add(pXbs);

            }
                        
            if (null != mz_blParamCondition.Jws &&  ""!= mz_blParamCondition.Jws)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" JWS=:jws ");
                OracleParameter pJws = new OracleParameter(":jws", OracleDbType.NVarchar2);
                pJws.Direction = ParameterDirection.Input;
                pJws.Value = mz_blParamCondition.Jws;
                sqlparams.Add(pJws);

            }
                        
            if (null != mz_blParamCondition.Gms &&  ""!= mz_blParamCondition.Gms)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" GMS=:gms ");
                OracleParameter pGms = new OracleParameter(":gms", OracleDbType.NVarchar2);
                pGms.Direction = ParameterDirection.Input;
                pGms.Value = mz_blParamCondition.Gms;
                sqlparams.Add(pGms);

            }
                        
            if (null != mz_blParamCondition.Tw)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" TW=:tw ");
                OracleParameter pTw = new OracleParameter(":tw", OracleDbType.Decimal);
                pTw.Direction = ParameterDirection.Input;
                pTw.Value = mz_blParamCondition.Tw;
                sqlparams.Add(pTw);

            }
                        
            if (null != mz_blParamCondition.Hx)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" HX=:hx ");
                OracleParameter pHx = new OracleParameter(":hx", OracleDbType.Decimal);
                pHx.Direction = ParameterDirection.Input;
                pHx.Value = mz_blParamCondition.Hx;
                sqlparams.Add(pHx);

            }
                        
            if (null != mz_blParamCondition.Mb)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" MB=:mb ");
                OracleParameter pMb = new OracleParameter(":mb", OracleDbType.Decimal);
                pMb.Direction = ParameterDirection.Input;
                pMb.Value = mz_blParamCondition.Mb;
                sqlparams.Add(pMb);

            }
                        
            if (null != mz_blParamCondition.Ssxy)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" SSXY=:ssxy ");
                OracleParameter pSsxy = new OracleParameter(":ssxy", OracleDbType.Decimal);
                pSsxy.Direction = ParameterDirection.Input;
                pSsxy.Value = mz_blParamCondition.Ssxy;
                sqlparams.Add(pSsxy);

            }
                        
            if (null != mz_blParamCondition.Szxy)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" SZXY=:szxy ");
                OracleParameter pSzxy = new OracleParameter(":szxy", OracleDbType.Decimal);
                pSzxy.Direction = ParameterDirection.Input;
                pSzxy.Value = mz_blParamCondition.Szxy;
                sqlparams.Add(pSzxy);

            }
                        
            if (null != mz_blParamCondition.Xl)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" XL=:xl ");
                OracleParameter pXl = new OracleParameter(":xl", OracleDbType.Decimal);
                pXl.Direction = ParameterDirection.Input;
                pXl.Value = mz_blParamCondition.Xl;
                sqlparams.Add(pXl);

            }
                        
            if (null != mz_blParamCondition.Kfxtz)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" KFXTZ=:kfxtz ");
                OracleParameter pKfxtz = new OracleParameter(":kfxtz", OracleDbType.Decimal);
                pKfxtz.Direction = ParameterDirection.Input;
                pKfxtz.Value = mz_blParamCondition.Kfxtz;
                sqlparams.Add(pKfxtz);

            }
                        
            if (null != mz_blParamCondition.Cha_ti &&  ""!= mz_blParamCondition.Cha_ti)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" CHA_TI=:cha_ti ");
                OracleParameter pCha_ti = new OracleParameter(":cha_ti", OracleDbType.NVarchar2);
                pCha_ti.Direction = ParameterDirection.Input;
                pCha_ti.Value = mz_blParamCondition.Cha_ti;
                sqlparams.Add(pCha_ti);

            }
                        
            if (null != mz_blParamCondition.Fk_gh_id &&  ""!= mz_blParamCondition.Fk_gh_id)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" FK_GH_ID=:fk_gh_id ");
                OracleParameter pFk_gh_id = new OracleParameter(":fk_gh_id", OracleDbType.Varchar2);
                pFk_gh_id.Direction = ParameterDirection.Input;
                pFk_gh_id.Value = mz_blParamCondition.Fk_gh_id;
                sqlparams.Add(pFk_gh_id);

            }
                        
            if (null != mz_blParamCondition.Gh_lsh)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" GH_LSH=:gh_lsh ");
                OracleParameter pGh_lsh = new OracleParameter(":gh_lsh", OracleDbType.Decimal);
                pGh_lsh.Direction = ParameterDirection.Input;
                pGh_lsh.Value = mz_blParamCondition.Gh_lsh;
                sqlparams.Add(pGh_lsh);

            }
                        
            if (null != mz_blParamCondition.Clyj &&  ""!= mz_blParamCondition.Clyj)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" CLYJ=:clyj ");
                OracleParameter pClyj = new OracleParameter(":clyj", OracleDbType.NVarchar2);
                pClyj.Direction = ParameterDirection.Input;
                pClyj.Value = mz_blParamCondition.Clyj;
                sqlparams.Add(pClyj);

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
        /// <param name="mz_blParam"></param>
        /// <returns>影响的行数</returns>
        public bool updateById(Mz_bl mz_blParam,OracleConnection con)
        {
            if ("" == mz_blParam.Id || null == mz_blParam.Id)
            {
                throw new Exception("ID不允许为空，请赋值后调用；错误出自：updateById");
            }
            List<OracleParameter> sqlparams = new List<OracleParameter>();

            StringBuilder sql = new StringBuilder("UPDATE MZ_BL SET ");
            if (null != mz_blParam.Zfbz &&  ""!= mz_blParam.Zfbz)
            {
                this.isComma(sql);
                sql.Append(" ZFBZ=:zfbz ");
                OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                pZfbz.Direction = ParameterDirection.Input;
                pZfbz.Value = mz_blParam.Zfbz;
                sqlparams.Add(pZfbz);

            }
                        
            if (null != mz_blParam.Zs &&  ""!= mz_blParam.Zs)
            {
                this.isComma(sql);
                sql.Append(" ZS=:zs ");
                OracleParameter pZs = new OracleParameter(":zs", OracleDbType.NVarchar2);
                pZs.Direction = ParameterDirection.Input;
                pZs.Value = mz_blParam.Zs;
                sqlparams.Add(pZs);

            }
                        
            if (null != mz_blParam.Xbs &&  ""!= mz_blParam.Xbs)
            {
                this.isComma(sql);
                sql.Append(" XBS=:xbs ");
                OracleParameter pXbs = new OracleParameter(":xbs", OracleDbType.NVarchar2);
                pXbs.Direction = ParameterDirection.Input;
                pXbs.Value = mz_blParam.Xbs;
                sqlparams.Add(pXbs);

            }
                        
            if (null != mz_blParam.Jws &&  ""!= mz_blParam.Jws)
            {
                this.isComma(sql);
                sql.Append(" JWS=:jws ");
                OracleParameter pJws = new OracleParameter(":jws", OracleDbType.NVarchar2);
                pJws.Direction = ParameterDirection.Input;
                pJws.Value = mz_blParam.Jws;
                sqlparams.Add(pJws);

            }
                        
            if (null != mz_blParam.Gms &&  ""!= mz_blParam.Gms)
            {
                this.isComma(sql);
                sql.Append(" GMS=:gms ");
                OracleParameter pGms = new OracleParameter(":gms", OracleDbType.NVarchar2);
                pGms.Direction = ParameterDirection.Input;
                pGms.Value = mz_blParam.Gms;
                sqlparams.Add(pGms);

            }
                        
            if (null != mz_blParam.Tw)
            {
                this.isComma(sql);
                sql.Append(" TW=:tw ");
                OracleParameter pTw = new OracleParameter(":tw", OracleDbType.Decimal);
                pTw.Direction = ParameterDirection.Input;
                pTw.Value = mz_blParam.Tw;
                sqlparams.Add(pTw);

            }
                        
            if (null != mz_blParam.Hx)
            {
                this.isComma(sql);
                sql.Append(" HX=:hx ");
                OracleParameter pHx = new OracleParameter(":hx", OracleDbType.Decimal);
                pHx.Direction = ParameterDirection.Input;
                pHx.Value = mz_blParam.Hx;
                sqlparams.Add(pHx);

            }
                        
            if (null != mz_blParam.Mb)
            {
                this.isComma(sql);
                sql.Append(" MB=:mb ");
                OracleParameter pMb = new OracleParameter(":mb", OracleDbType.Decimal);
                pMb.Direction = ParameterDirection.Input;
                pMb.Value = mz_blParam.Mb;
                sqlparams.Add(pMb);

            }
                        
            if (null != mz_blParam.Ssxy)
            {
                this.isComma(sql);
                sql.Append(" SSXY=:ssxy ");
                OracleParameter pSsxy = new OracleParameter(":ssxy", OracleDbType.Decimal);
                pSsxy.Direction = ParameterDirection.Input;
                pSsxy.Value = mz_blParam.Ssxy;
                sqlparams.Add(pSsxy);

            }
                        
            if (null != mz_blParam.Szxy)
            {
                this.isComma(sql);
                sql.Append(" SZXY=:szxy ");
                OracleParameter pSzxy = new OracleParameter(":szxy", OracleDbType.Decimal);
                pSzxy.Direction = ParameterDirection.Input;
                pSzxy.Value = mz_blParam.Szxy;
                sqlparams.Add(pSzxy);

            }
                        
            if (null != mz_blParam.Xl)
            {
                this.isComma(sql);
                sql.Append(" XL=:xl ");
                OracleParameter pXl = new OracleParameter(":xl", OracleDbType.Decimal);
                pXl.Direction = ParameterDirection.Input;
                pXl.Value = mz_blParam.Xl;
                sqlparams.Add(pXl);

            }
                        
            if (null != mz_blParam.Kfxtz)
            {
                this.isComma(sql);
                sql.Append(" KFXTZ=:kfxtz ");
                OracleParameter pKfxtz = new OracleParameter(":kfxtz", OracleDbType.Decimal);
                pKfxtz.Direction = ParameterDirection.Input;
                pKfxtz.Value = mz_blParam.Kfxtz;
                sqlparams.Add(pKfxtz);

            }
                        
            if (null != mz_blParam.Cha_ti &&  ""!= mz_blParam.Cha_ti)
            {
                this.isComma(sql);
                sql.Append(" CHA_TI=:cha_ti ");
                OracleParameter pCha_ti = new OracleParameter(":cha_ti", OracleDbType.NVarchar2);
                pCha_ti.Direction = ParameterDirection.Input;
                pCha_ti.Value = mz_blParam.Cha_ti;
                sqlparams.Add(pCha_ti);

            }
                        
            if (null != mz_blParam.Fk_gh_id &&  ""!= mz_blParam.Fk_gh_id)
            {
                this.isComma(sql);
                sql.Append(" FK_GH_ID=:fk_gh_id ");
                OracleParameter pFk_gh_id = new OracleParameter(":fk_gh_id", OracleDbType.Varchar2);
                pFk_gh_id.Direction = ParameterDirection.Input;
                pFk_gh_id.Value = mz_blParam.Fk_gh_id;
                sqlparams.Add(pFk_gh_id);

            }
                        
            if (null != mz_blParam.Gh_lsh)
            {
                this.isComma(sql);
                sql.Append(" GH_LSH=:gh_lsh ");
                OracleParameter pGh_lsh = new OracleParameter(":gh_lsh", OracleDbType.Decimal);
                pGh_lsh.Direction = ParameterDirection.Input;
                pGh_lsh.Value = mz_blParam.Gh_lsh;
                sqlparams.Add(pGh_lsh);

            }
                        
            if (null != mz_blParam.Clyj &&  ""!= mz_blParam.Clyj)
            {
                this.isComma(sql);
                sql.Append(" CLYJ=:clyj ");
                OracleParameter pClyj = new OracleParameter(":clyj", OracleDbType.NVarchar2);
                pClyj.Direction = ParameterDirection.Input;
                pClyj.Value = mz_blParam.Clyj;
                sqlparams.Add(pClyj);

            }
                        
            sql.Append(" WHERE ID=:id ");
            OracleParameter pId = new OracleParameter(":id", OracleDbType.Varchar2);
            pId.Value = mz_blParam.Id;
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
        /// <param name="mz_blParamList">要修改的Mz_bl对象集合</param>
        /// <param name="con">Oracle连接对象（为null时自动生成）</param>
        /// <returns>是否删除成功（影响的行数等于要修改的对象数量时成功）</returns>
        public bool updateByIdBatch(List<Mz_bl> mz_blParamList, OracleConnection con)
        {


            List<string> idList = new List<string>();

            List<string> zfbzList = new List<string>();

            List<string> zsList = new List<string>();

            List<string> xbsList = new List<string>();

            List<string> jwsList = new List<string>();

            List<string> gmsList = new List<string>();

            List<decimal?> twList = new List<decimal?>();

            List<decimal?> hxList = new List<decimal?>();

            List<decimal?> mbList = new List<decimal?>();

            List<decimal?> ssxyList = new List<decimal?>();

            List<decimal?> szxyList = new List<decimal?>();

            List<decimal?> xlList = new List<decimal?>();

            List<decimal?> kfxtzList = new List<decimal?>();

            List<string> cha_tiList = new List<string>();

            List<string> fk_gh_idList = new List<string>();

            List<decimal?> gh_lshList = new List<decimal?>();

            List<string> clyjList = new List<string>();

            for (int i = 0; i < mz_blParamList.Count; i++)
            {
                Mz_bl mz_blParam = mz_blParamList[i];
                if ("" == mz_blParam.Id || null == mz_blParam.Id)
                {
                    throw new Exception("下标为" + i + "的数据，ID不能为空，请赋值后调用；错误出自：updateByIdBatch");
                }

            idList.Add(mz_blParam.Id);

            zfbzList.Add(mz_blParam.Zfbz);

            zsList.Add(mz_blParam.Zs);

            xbsList.Add(mz_blParam.Xbs);

            jwsList.Add(mz_blParam.Jws);

            gmsList.Add(mz_blParam.Gms);

            twList.Add(mz_blParam.Tw);

            hxList.Add(mz_blParam.Hx);

            mbList.Add(mz_blParam.Mb);

            ssxyList.Add(mz_blParam.Ssxy);

            szxyList.Add(mz_blParam.Szxy);

            xlList.Add(mz_blParam.Xl);

            kfxtzList.Add(mz_blParam.Kfxtz);

            cha_tiList.Add(mz_blParam.Cha_ti);

            fk_gh_idList.Add(mz_blParam.Fk_gh_id);

            gh_lshList.Add(mz_blParam.Gh_lsh);

            clyjList.Add(mz_blParam.Clyj);

            }


            
            List<OracleParameter> sqlparams = new List<OracleParameter>();

            StringBuilder sql = new StringBuilder("UPDATE MZ_BL SET ");
            this.isComma(sql);
            sql.Append(" ZFBZ=:zfbz ");
            OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
            pZfbz.Direction = ParameterDirection.Input;
            pZfbz.Value = zfbzList.ToArray();
            sqlparams.Add(pZfbz);

            this.isComma(sql);
            sql.Append(" ZS=:zs ");
            OracleParameter pZs = new OracleParameter(":zs", OracleDbType.NVarchar2);
            pZs.Direction = ParameterDirection.Input;
            pZs.Value = zsList.ToArray();
            sqlparams.Add(pZs);

            this.isComma(sql);
            sql.Append(" XBS=:xbs ");
            OracleParameter pXbs = new OracleParameter(":xbs", OracleDbType.NVarchar2);
            pXbs.Direction = ParameterDirection.Input;
            pXbs.Value = xbsList.ToArray();
            sqlparams.Add(pXbs);

            this.isComma(sql);
            sql.Append(" JWS=:jws ");
            OracleParameter pJws = new OracleParameter(":jws", OracleDbType.NVarchar2);
            pJws.Direction = ParameterDirection.Input;
            pJws.Value = jwsList.ToArray();
            sqlparams.Add(pJws);

            this.isComma(sql);
            sql.Append(" GMS=:gms ");
            OracleParameter pGms = new OracleParameter(":gms", OracleDbType.NVarchar2);
            pGms.Direction = ParameterDirection.Input;
            pGms.Value = gmsList.ToArray();
            sqlparams.Add(pGms);

            this.isComma(sql);
            sql.Append(" TW=:tw ");
            OracleParameter pTw = new OracleParameter(":tw", OracleDbType.Decimal);
            pTw.Direction = ParameterDirection.Input;
            pTw.Value = twList.ToArray();
            sqlparams.Add(pTw);

            this.isComma(sql);
            sql.Append(" HX=:hx ");
            OracleParameter pHx = new OracleParameter(":hx", OracleDbType.Decimal);
            pHx.Direction = ParameterDirection.Input;
            pHx.Value = hxList.ToArray();
            sqlparams.Add(pHx);

            this.isComma(sql);
            sql.Append(" MB=:mb ");
            OracleParameter pMb = new OracleParameter(":mb", OracleDbType.Decimal);
            pMb.Direction = ParameterDirection.Input;
            pMb.Value = mbList.ToArray();
            sqlparams.Add(pMb);

            this.isComma(sql);
            sql.Append(" SSXY=:ssxy ");
            OracleParameter pSsxy = new OracleParameter(":ssxy", OracleDbType.Decimal);
            pSsxy.Direction = ParameterDirection.Input;
            pSsxy.Value = ssxyList.ToArray();
            sqlparams.Add(pSsxy);

            this.isComma(sql);
            sql.Append(" SZXY=:szxy ");
            OracleParameter pSzxy = new OracleParameter(":szxy", OracleDbType.Decimal);
            pSzxy.Direction = ParameterDirection.Input;
            pSzxy.Value = szxyList.ToArray();
            sqlparams.Add(pSzxy);

            this.isComma(sql);
            sql.Append(" XL=:xl ");
            OracleParameter pXl = new OracleParameter(":xl", OracleDbType.Decimal);
            pXl.Direction = ParameterDirection.Input;
            pXl.Value = xlList.ToArray();
            sqlparams.Add(pXl);

            this.isComma(sql);
            sql.Append(" KFXTZ=:kfxtz ");
            OracleParameter pKfxtz = new OracleParameter(":kfxtz", OracleDbType.Decimal);
            pKfxtz.Direction = ParameterDirection.Input;
            pKfxtz.Value = kfxtzList.ToArray();
            sqlparams.Add(pKfxtz);

            this.isComma(sql);
            sql.Append(" CHA_TI=:cha_ti ");
            OracleParameter pCha_ti = new OracleParameter(":cha_ti", OracleDbType.NVarchar2);
            pCha_ti.Direction = ParameterDirection.Input;
            pCha_ti.Value = cha_tiList.ToArray();
            sqlparams.Add(pCha_ti);

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
            sql.Append(" CLYJ=:clyj ");
            OracleParameter pClyj = new OracleParameter(":clyj", OracleDbType.NVarchar2);
            pClyj.Direction = ParameterDirection.Input;
            pClyj.Value = clyjList.ToArray();
            sqlparams.Add(pClyj);

            sql.Append(" WHERE ID=:id ");
            OracleParameter pId = new OracleParameter(":id", OracleDbType.Varchar2);
            pId.Value = idList.ToArray();
            sqlparams.Add(pId);
            bool result = false;
            int flag = OracleHelper.ExecuteBatch(sql.ToString(), con,mz_blParamList.Count, sqlparams.ToArray());
            if (mz_blParamList.Count == flag)
            {
                result = true;
            }
            return result;
        }

        /// <summary>
        /// 根据更新的条件，更新数据（如果需要供事务使用就传入OracleConnection对象，如果不供就传入null，方法自动生成OracleConnection对象）
        /// 不指定ID，如果要根据ID来更新数据，请使用updateForId方法
        /// </summary>
        /// <param name="mz_blParamCondition">条件对象</param>
        /// <param name="mz_blParamUpdate">要更新的数据对象</param>
        /// <param name="con">Oracle连接对象（为null时自动生成）</param>
        /// <returns>影响的行数不确定（不为-1就正确）</returns>
        public bool updateByOtherCondition(Mz_bl mz_blParamCondition, Mz_bl mz_blParamUpdate, OracleConnection con)
        {
            if ((null!=mz_blParamCondition.Id&&"!=mz_blParamCondition.Id)||(null!=mz_blParamUpdate.Id&&"!=mz_blParamUpdate.Id))
            {
                throw new Exception("此方法不允许指定参数的ID，数据库中的ID不允许修改，如需根据ID修改数据，请调用updateById或updateByIdBatch方法；错误出自：updateByOtherCondition");
            }
            List<OracleParameter> sqlparams = new List<OracleParameter>();
            //添加要修改的值
            StringBuilder sql = new StringBuilder("UPDATE MZ_BL SET ");
            if (null != mz_blParamUpdate.Zfbz &&  ""!= mz_blParamUpdate.Zfbz)
            {
                this.isComma(sql);
                sql.Append(" ZFBZ=:zfbz ");
                OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                pZfbz.Direction = ParameterDirection.Input;
                pZfbz.Value = mz_blParamUpdate.Zfbz;
                sqlparams.Add(pZfbz);

            }
                        
            if (null != mz_blParamUpdate.Zs &&  ""!= mz_blParamUpdate.Zs)
            {
                this.isComma(sql);
                sql.Append(" ZS=:zs ");
                OracleParameter pZs = new OracleParameter(":zs", OracleDbType.NVarchar2);
                pZs.Direction = ParameterDirection.Input;
                pZs.Value = mz_blParamUpdate.Zs;
                sqlparams.Add(pZs);

            }
                        
            if (null != mz_blParamUpdate.Xbs &&  ""!= mz_blParamUpdate.Xbs)
            {
                this.isComma(sql);
                sql.Append(" XBS=:xbs ");
                OracleParameter pXbs = new OracleParameter(":xbs", OracleDbType.NVarchar2);
                pXbs.Direction = ParameterDirection.Input;
                pXbs.Value = mz_blParamUpdate.Xbs;
                sqlparams.Add(pXbs);

            }
                        
            if (null != mz_blParamUpdate.Jws &&  ""!= mz_blParamUpdate.Jws)
            {
                this.isComma(sql);
                sql.Append(" JWS=:jws ");
                OracleParameter pJws = new OracleParameter(":jws", OracleDbType.NVarchar2);
                pJws.Direction = ParameterDirection.Input;
                pJws.Value = mz_blParamUpdate.Jws;
                sqlparams.Add(pJws);

            }
                        
            if (null != mz_blParamUpdate.Gms &&  ""!= mz_blParamUpdate.Gms)
            {
                this.isComma(sql);
                sql.Append(" GMS=:gms ");
                OracleParameter pGms = new OracleParameter(":gms", OracleDbType.NVarchar2);
                pGms.Direction = ParameterDirection.Input;
                pGms.Value = mz_blParamUpdate.Gms;
                sqlparams.Add(pGms);

            }
                        
            if (null != mz_blParamUpdate.Tw)
            {
                this.isComma(sql);
                sql.Append(" TW=:tw ");
                OracleParameter pTw = new OracleParameter(":tw", OracleDbType.Decimal);
                pTw.Direction = ParameterDirection.Input;
                pTw.Value = mz_blParamUpdate.Tw;
                sqlparams.Add(pTw);

            }
                        
            if (null != mz_blParamUpdate.Hx)
            {
                this.isComma(sql);
                sql.Append(" HX=:hx ");
                OracleParameter pHx = new OracleParameter(":hx", OracleDbType.Decimal);
                pHx.Direction = ParameterDirection.Input;
                pHx.Value = mz_blParamUpdate.Hx;
                sqlparams.Add(pHx);

            }
                        
            if (null != mz_blParamUpdate.Mb)
            {
                this.isComma(sql);
                sql.Append(" MB=:mb ");
                OracleParameter pMb = new OracleParameter(":mb", OracleDbType.Decimal);
                pMb.Direction = ParameterDirection.Input;
                pMb.Value = mz_blParamUpdate.Mb;
                sqlparams.Add(pMb);

            }
                        
            if (null != mz_blParamUpdate.Ssxy)
            {
                this.isComma(sql);
                sql.Append(" SSXY=:ssxy ");
                OracleParameter pSsxy = new OracleParameter(":ssxy", OracleDbType.Decimal);
                pSsxy.Direction = ParameterDirection.Input;
                pSsxy.Value = mz_blParamUpdate.Ssxy;
                sqlparams.Add(pSsxy);

            }
                        
            if (null != mz_blParamUpdate.Szxy)
            {
                this.isComma(sql);
                sql.Append(" SZXY=:szxy ");
                OracleParameter pSzxy = new OracleParameter(":szxy", OracleDbType.Decimal);
                pSzxy.Direction = ParameterDirection.Input;
                pSzxy.Value = mz_blParamUpdate.Szxy;
                sqlparams.Add(pSzxy);

            }
                        
            if (null != mz_blParamUpdate.Xl)
            {
                this.isComma(sql);
                sql.Append(" XL=:xl ");
                OracleParameter pXl = new OracleParameter(":xl", OracleDbType.Decimal);
                pXl.Direction = ParameterDirection.Input;
                pXl.Value = mz_blParamUpdate.Xl;
                sqlparams.Add(pXl);

            }
                        
            if (null != mz_blParamUpdate.Kfxtz)
            {
                this.isComma(sql);
                sql.Append(" KFXTZ=:kfxtz ");
                OracleParameter pKfxtz = new OracleParameter(":kfxtz", OracleDbType.Decimal);
                pKfxtz.Direction = ParameterDirection.Input;
                pKfxtz.Value = mz_blParamUpdate.Kfxtz;
                sqlparams.Add(pKfxtz);

            }
                        
            if (null != mz_blParamUpdate.Cha_ti &&  ""!= mz_blParamUpdate.Cha_ti)
            {
                this.isComma(sql);
                sql.Append(" CHA_TI=:cha_ti ");
                OracleParameter pCha_ti = new OracleParameter(":cha_ti", OracleDbType.NVarchar2);
                pCha_ti.Direction = ParameterDirection.Input;
                pCha_ti.Value = mz_blParamUpdate.Cha_ti;
                sqlparams.Add(pCha_ti);

            }
                        
            if (null != mz_blParamUpdate.Fk_gh_id &&  ""!= mz_blParamUpdate.Fk_gh_id)
            {
                this.isComma(sql);
                sql.Append(" FK_GH_ID=:fk_gh_id ");
                OracleParameter pFk_gh_id = new OracleParameter(":fk_gh_id", OracleDbType.Varchar2);
                pFk_gh_id.Direction = ParameterDirection.Input;
                pFk_gh_id.Value = mz_blParamUpdate.Fk_gh_id;
                sqlparams.Add(pFk_gh_id);

            }
                        
            if (null != mz_blParamUpdate.Gh_lsh)
            {
                this.isComma(sql);
                sql.Append(" GH_LSH=:gh_lsh ");
                OracleParameter pGh_lsh = new OracleParameter(":gh_lsh", OracleDbType.Decimal);
                pGh_lsh.Direction = ParameterDirection.Input;
                pGh_lsh.Value = mz_blParamUpdate.Gh_lsh;
                sqlparams.Add(pGh_lsh);

            }
                        
            if (null != mz_blParamUpdate.Clyj &&  ""!= mz_blParamUpdate.Clyj)
            {
                this.isComma(sql);
                sql.Append(" CLYJ=:clyj ");
                OracleParameter pClyj = new OracleParameter(":clyj", OracleDbType.NVarchar2);
                pClyj.Direction = ParameterDirection.Input;
                pClyj.Value = mz_blParamUpdate.Clyj;
                sqlparams.Add(pClyj);

            }
                        
            //添加条件的参数
            
            if (null != mz_blParamCondition.Zfbz &&  ""!= mz_blParamCondition.Zfbz)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" ZFBZ=:zfbz ");
                OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                pZfbz.Direction = ParameterDirection.Input;
                pZfbz.Value = mz_blParamCondition.Zfbz;
                sqlparams.Add(pZfbz);

            }
                        
            if (null != mz_blParamCondition.Zs &&  ""!= mz_blParamCondition.Zs)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" ZS=:zs ");
                OracleParameter pZs = new OracleParameter(":zs", OracleDbType.NVarchar2);
                pZs.Direction = ParameterDirection.Input;
                pZs.Value = mz_blParamCondition.Zs;
                sqlparams.Add(pZs);

            }
                        
            if (null != mz_blParamCondition.Xbs &&  ""!= mz_blParamCondition.Xbs)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" XBS=:xbs ");
                OracleParameter pXbs = new OracleParameter(":xbs", OracleDbType.NVarchar2);
                pXbs.Direction = ParameterDirection.Input;
                pXbs.Value = mz_blParamCondition.Xbs;
                sqlparams.Add(pXbs);

            }
                        
            if (null != mz_blParamCondition.Jws &&  ""!= mz_blParamCondition.Jws)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" JWS=:jws ");
                OracleParameter pJws = new OracleParameter(":jws", OracleDbType.NVarchar2);
                pJws.Direction = ParameterDirection.Input;
                pJws.Value = mz_blParamCondition.Jws;
                sqlparams.Add(pJws);

            }
                        
            if (null != mz_blParamCondition.Gms &&  ""!= mz_blParamCondition.Gms)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" GMS=:gms ");
                OracleParameter pGms = new OracleParameter(":gms", OracleDbType.NVarchar2);
                pGms.Direction = ParameterDirection.Input;
                pGms.Value = mz_blParamCondition.Gms;
                sqlparams.Add(pGms);

            }
                        
            if (null != mz_blParamCondition.Tw)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" TW=:tw ");
                OracleParameter pTw = new OracleParameter(":tw", OracleDbType.Decimal);
                pTw.Direction = ParameterDirection.Input;
                pTw.Value = mz_blParamCondition.Tw;
                sqlparams.Add(pTw);

            }
                        
            if (null != mz_blParamCondition.Hx)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" HX=:hx ");
                OracleParameter pHx = new OracleParameter(":hx", OracleDbType.Decimal);
                pHx.Direction = ParameterDirection.Input;
                pHx.Value = mz_blParamCondition.Hx;
                sqlparams.Add(pHx);

            }
                        
            if (null != mz_blParamCondition.Mb)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" MB=:mb ");
                OracleParameter pMb = new OracleParameter(":mb", OracleDbType.Decimal);
                pMb.Direction = ParameterDirection.Input;
                pMb.Value = mz_blParamCondition.Mb;
                sqlparams.Add(pMb);

            }
                        
            if (null != mz_blParamCondition.Ssxy)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" SSXY=:ssxy ");
                OracleParameter pSsxy = new OracleParameter(":ssxy", OracleDbType.Decimal);
                pSsxy.Direction = ParameterDirection.Input;
                pSsxy.Value = mz_blParamCondition.Ssxy;
                sqlparams.Add(pSsxy);

            }
                        
            if (null != mz_blParamCondition.Szxy)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" SZXY=:szxy ");
                OracleParameter pSzxy = new OracleParameter(":szxy", OracleDbType.Decimal);
                pSzxy.Direction = ParameterDirection.Input;
                pSzxy.Value = mz_blParamCondition.Szxy;
                sqlparams.Add(pSzxy);

            }
                        
            if (null != mz_blParamCondition.Xl)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" XL=:xl ");
                OracleParameter pXl = new OracleParameter(":xl", OracleDbType.Decimal);
                pXl.Direction = ParameterDirection.Input;
                pXl.Value = mz_blParamCondition.Xl;
                sqlparams.Add(pXl);

            }
                        
            if (null != mz_blParamCondition.Kfxtz)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" KFXTZ=:kfxtz ");
                OracleParameter pKfxtz = new OracleParameter(":kfxtz", OracleDbType.Decimal);
                pKfxtz.Direction = ParameterDirection.Input;
                pKfxtz.Value = mz_blParamCondition.Kfxtz;
                sqlparams.Add(pKfxtz);

            }
                        
            if (null != mz_blParamCondition.Cha_ti &&  ""!= mz_blParamCondition.Cha_ti)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" CHA_TI=:cha_ti ");
                OracleParameter pCha_ti = new OracleParameter(":cha_ti", OracleDbType.NVarchar2);
                pCha_ti.Direction = ParameterDirection.Input;
                pCha_ti.Value = mz_blParamCondition.Cha_ti;
                sqlparams.Add(pCha_ti);

            }
                        
            if (null != mz_blParamCondition.Fk_gh_id &&  ""!= mz_blParamCondition.Fk_gh_id)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" FK_GH_ID=:fk_gh_id ");
                OracleParameter pFk_gh_id = new OracleParameter(":fk_gh_id", OracleDbType.Varchar2);
                pFk_gh_id.Direction = ParameterDirection.Input;
                pFk_gh_id.Value = mz_blParamCondition.Fk_gh_id;
                sqlparams.Add(pFk_gh_id);

            }
                        
            if (null != mz_blParamCondition.Gh_lsh)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" GH_LSH=:gh_lsh ");
                OracleParameter pGh_lsh = new OracleParameter(":gh_lsh", OracleDbType.Decimal);
                pGh_lsh.Direction = ParameterDirection.Input;
                pGh_lsh.Value = mz_blParamCondition.Gh_lsh;
                sqlparams.Add(pGh_lsh);

            }
                        
            if (null != mz_blParamCondition.Clyj &&  ""!= mz_blParamCondition.Clyj)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" CLYJ=:clyj ");
                OracleParameter pClyj = new OracleParameter(":clyj", OracleDbType.NVarchar2);
                pClyj.Direction = ParameterDirection.Input;
                pClyj.Value = mz_blParamCondition.Clyj;
                sqlparams.Add(pClyj);

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
        /// <returns>Mz_bl</returns>
        public Mz_bl findById(string id)
        {
            if (""==id||null==id)
            {
                throw new Exception("ID不能为空，请赋值后调用；错误出自：findById");
            }
            StringBuilder sql = new StringBuilder("SELECT A.* ");
            //新建方法findContactObjectsById，在此加入多表连接要显示的项start
            //sql.Append(",B.字段一,B.字段二,B.字段三");
            //新建方法，在此加入多表连接要显示的项end
            sql.Append(" FROM MZ_BL A ");
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
        /// <param name="mz_blParam"></param>
        /// <param name="page">分页对象</param>
        ///<param name="mz_blParamLike">模糊查询参数</param>
        ///<param name="sortList">排序参数对象的集合</param>
        /// <returns>满足条件的所有Mz_bl对象集合list</returns>
        public List<object> find(Mz_bl mz_blParam, Model.Common.PageInfo page,Mz_bl mz_blParamLike,List<SortInfo> sortList)
        {

            //如果没有传查询条件参数，就new一个空的Mz_bl对象，标示查询所有数据
            if (null == mz_blParam)
            {
                mz_blParam = new Mz_bl();
            }
            if (null!=mz_blParam.Id&&""!=mz_blParam.Id)
            {
                throw new Exception("此方法不允许指定参数ID，如果需要根据ID查询数据，请调用findById方法；错误出自：find");
            }
            List<Mz_bl> mz_blParamList = new List<Mz_bl>();//接收查询出的Mz_bl对象集合
            List<OracleParameter> sqlparams = new List<OracleParameter>();//保存参数的集合
            StringBuilder sql = new StringBuilder("SELECT A.* ");
            //新建方法findContactObjects(Mz_bl mz_blParam, Model.Common.PageInfo page)，在此加入多表连接要显示的项start
            //sql.Append(",B.字段一,B.字段二,B.字段三");
            //新建方法，在此加入多表连接要显示的项end
            sql.Append(" FROM MZ_BL A ");
            //新建一个方法，在此加入多表连接的语句start
            ////sql.Append(" LEFT JOIN 表名 B ON A.外键=B.ID");
            //新建一个方法，在此加入多表连接的语句end
            
            
            if (null != mz_blParam.Zfbz && "" != mz_blParam.Zfbz)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.ZFBZ=:zfbz ");
                OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                pZfbz.Direction = ParameterDirection.Input;
                pZfbz.Value = mz_blParam.Zfbz;
                sqlparams.Add(pZfbz);
            }
                
            if (null != mz_blParam.Zs && "" != mz_blParam.Zs)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.ZS=:zs ");
                OracleParameter pZs = new OracleParameter(":zs", OracleDbType.NVarchar2);
                pZs.Direction = ParameterDirection.Input;
                pZs.Value = mz_blParam.Zs;
                sqlparams.Add(pZs);
            }
                
            if (null != mz_blParam.Xbs && "" != mz_blParam.Xbs)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.XBS=:xbs ");
                OracleParameter pXbs = new OracleParameter(":xbs", OracleDbType.NVarchar2);
                pXbs.Direction = ParameterDirection.Input;
                pXbs.Value = mz_blParam.Xbs;
                sqlparams.Add(pXbs);
            }
                
            if (null != mz_blParam.Jws && "" != mz_blParam.Jws)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.JWS=:jws ");
                OracleParameter pJws = new OracleParameter(":jws", OracleDbType.NVarchar2);
                pJws.Direction = ParameterDirection.Input;
                pJws.Value = mz_blParam.Jws;
                sqlparams.Add(pJws);
            }
                
            if (null != mz_blParam.Gms && "" != mz_blParam.Gms)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.GMS=:gms ");
                OracleParameter pGms = new OracleParameter(":gms", OracleDbType.NVarchar2);
                pGms.Direction = ParameterDirection.Input;
                pGms.Value = mz_blParam.Gms;
                sqlparams.Add(pGms);
            }
                
            if (null != mz_blParam.Tw)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.TW=:tw ");
                OracleParameter pTw = new OracleParameter(":tw", OracleDbType.Decimal);
                pTw.Direction = ParameterDirection.Input;
                pTw.Value = mz_blParam.Tw;
                sqlparams.Add(pTw);

            }
                        
            if (null != mz_blParam.Hx)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.HX=:hx ");
                OracleParameter pHx = new OracleParameter(":hx", OracleDbType.Decimal);
                pHx.Direction = ParameterDirection.Input;
                pHx.Value = mz_blParam.Hx;
                sqlparams.Add(pHx);

            }
                        
            if (null != mz_blParam.Mb)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.MB=:mb ");
                OracleParameter pMb = new OracleParameter(":mb", OracleDbType.Decimal);
                pMb.Direction = ParameterDirection.Input;
                pMb.Value = mz_blParam.Mb;
                sqlparams.Add(pMb);

            }
                        
            if (null != mz_blParam.Ssxy)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.SSXY=:ssxy ");
                OracleParameter pSsxy = new OracleParameter(":ssxy", OracleDbType.Decimal);
                pSsxy.Direction = ParameterDirection.Input;
                pSsxy.Value = mz_blParam.Ssxy;
                sqlparams.Add(pSsxy);

            }
                        
            if (null != mz_blParam.Szxy)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.SZXY=:szxy ");
                OracleParameter pSzxy = new OracleParameter(":szxy", OracleDbType.Decimal);
                pSzxy.Direction = ParameterDirection.Input;
                pSzxy.Value = mz_blParam.Szxy;
                sqlparams.Add(pSzxy);

            }
                        
            if (null != mz_blParam.Xl)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.XL=:xl ");
                OracleParameter pXl = new OracleParameter(":xl", OracleDbType.Decimal);
                pXl.Direction = ParameterDirection.Input;
                pXl.Value = mz_blParam.Xl;
                sqlparams.Add(pXl);

            }
                        
            if (null != mz_blParam.Kfxtz)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.KFXTZ=:kfxtz ");
                OracleParameter pKfxtz = new OracleParameter(":kfxtz", OracleDbType.Decimal);
                pKfxtz.Direction = ParameterDirection.Input;
                pKfxtz.Value = mz_blParam.Kfxtz;
                sqlparams.Add(pKfxtz);

            }
                        
            if (null != mz_blParam.Cha_ti && "" != mz_blParam.Cha_ti)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.CHA_TI=:cha_ti ");
                OracleParameter pCha_ti = new OracleParameter(":cha_ti", OracleDbType.NVarchar2);
                pCha_ti.Direction = ParameterDirection.Input;
                pCha_ti.Value = mz_blParam.Cha_ti;
                sqlparams.Add(pCha_ti);
            }
                
            if (null != mz_blParam.Fk_gh_id && "" != mz_blParam.Fk_gh_id)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.FK_GH_ID=:fk_gh_id ");
                OracleParameter pFk_gh_id = new OracleParameter(":fk_gh_id", OracleDbType.Varchar2);
                pFk_gh_id.Direction = ParameterDirection.Input;
                pFk_gh_id.Value = mz_blParam.Fk_gh_id;
                sqlparams.Add(pFk_gh_id);
            }
                
            if (null != mz_blParam.Gh_lsh)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.GH_LSH=:gh_lsh ");
                OracleParameter pGh_lsh = new OracleParameter(":gh_lsh", OracleDbType.Decimal);
                pGh_lsh.Direction = ParameterDirection.Input;
                pGh_lsh.Value = mz_blParam.Gh_lsh;
                sqlparams.Add(pGh_lsh);

            }
                        
            if (null != mz_blParam.Clyj && "" != mz_blParam.Clyj)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.CLYJ=:clyj ");
                OracleParameter pClyj = new OracleParameter(":clyj", OracleDbType.NVarchar2);
                pClyj.Direction = ParameterDirection.Input;
                pClyj.Value = mz_blParam.Clyj;
                sqlparams.Add(pClyj);
            }
                
            if(mz_blParamLike!=null)
            {

                if (null != mz_blParamLike.Zfbz && "" != mz_blParamLike.Zfbz)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.ZFBZ LIKE '%'||:zfbz||'%' ");
                    OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                    pZfbz.Direction = ParameterDirection.Input;
                    pZfbz.Value = mz_blParamLike.Zfbz;
                    sqlparams.Add(pZfbz);
                }
                
                if (null != mz_blParamLike.Zs && "" != mz_blParamLike.Zs)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.ZS LIKE '%'||:zs||'%' ");
                    OracleParameter pZs = new OracleParameter(":zs", OracleDbType.NVarchar2);
                    pZs.Direction = ParameterDirection.Input;
                    pZs.Value = mz_blParamLike.Zs;
                    sqlparams.Add(pZs);
                }
                
                if (null != mz_blParamLike.Xbs && "" != mz_blParamLike.Xbs)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.XBS LIKE '%'||:xbs||'%' ");
                    OracleParameter pXbs = new OracleParameter(":xbs", OracleDbType.NVarchar2);
                    pXbs.Direction = ParameterDirection.Input;
                    pXbs.Value = mz_blParamLike.Xbs;
                    sqlparams.Add(pXbs);
                }
                
                if (null != mz_blParamLike.Jws && "" != mz_blParamLike.Jws)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.JWS LIKE '%'||:jws||'%' ");
                    OracleParameter pJws = new OracleParameter(":jws", OracleDbType.NVarchar2);
                    pJws.Direction = ParameterDirection.Input;
                    pJws.Value = mz_blParamLike.Jws;
                    sqlparams.Add(pJws);
                }
                
                if (null != mz_blParamLike.Gms && "" != mz_blParamLike.Gms)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.GMS LIKE '%'||:gms||'%' ");
                    OracleParameter pGms = new OracleParameter(":gms", OracleDbType.NVarchar2);
                    pGms.Direction = ParameterDirection.Input;
                    pGms.Value = mz_blParamLike.Gms;
                    sqlparams.Add(pGms);
                }
                
                if (null != mz_blParamLike.Cha_ti && "" != mz_blParamLike.Cha_ti)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.CHA_TI LIKE '%'||:cha_ti||'%' ");
                    OracleParameter pCha_ti = new OracleParameter(":cha_ti", OracleDbType.NVarchar2);
                    pCha_ti.Direction = ParameterDirection.Input;
                    pCha_ti.Value = mz_blParamLike.Cha_ti;
                    sqlparams.Add(pCha_ti);
                }
                
                if (null != mz_blParamLike.Fk_gh_id && "" != mz_blParamLike.Fk_gh_id)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.FK_GH_ID LIKE '%'||:fk_gh_id||'%' ");
                    OracleParameter pFk_gh_id = new OracleParameter(":fk_gh_id", OracleDbType.Varchar2);
                    pFk_gh_id.Direction = ParameterDirection.Input;
                    pFk_gh_id.Value = mz_blParamLike.Fk_gh_id;
                    sqlparams.Add(pFk_gh_id);
                }
                
                if (null != mz_blParamLike.Clyj && "" != mz_blParamLike.Clyj)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.CLYJ LIKE '%'||:clyj||'%' ");
                    OracleParameter pClyj = new OracleParameter(":clyj", OracleDbType.NVarchar2);
                    pClyj.Direction = ParameterDirection.Input;
                    pClyj.Value = mz_blParamLike.Clyj;
                    sqlparams.Add(pClyj);
                }
                
            }

            this.b_isWhere = false;
            this.addSort(sql, sortList);//排序
            //*******分页start1*********如果分页对象为空，则全部数据查出，如果不为空
            List<object> returnList = new List<object>();//返回的List,索引0为List<Mz_bl>对象,索引1为Model.Common.PageInfo分页信息对象
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
            //把每一行数据转换为一个对象放入List<Mz_bl>中
            for (int i = 0; i < rows.Count; i++)
            {
                DataRow row = rows[i];
                //mz_blParamList.Add(this.dataSetContactObjectsToModel(row));
                mz_blParamList.Add(this.dataSetToModel(row));
            }
            
             //*******分页start2*********如果没有传入分页对象，则新建一个分页对象当做返回值
            if (null == page)
            {
                page = new Model.Common.PageInfo();
                page.AllCount = rows.Count;
            }
            returnList.Add(mz_blParamList);//把List<Mz_bl>放入List<object>中第一个
            returnList.Add(page);//把page对象放入List<object>中第二个
            //*******分页end2*********
            return returnList;
        }

        
        
        /// <summary>
        /// 根据条件得到集合的数量
        /// 第二个条件是模糊查询的条件
        /// </summary>
        /// <returns>int</returns>
        public int getCount(Mz_bl mz_blParam,Mz_bl mz_blParamLike)
        {
            //如果没有传查询条件参数，就new一个空的Mz_bl对象，标示查询所有数据
            if (null == mz_blParam)
            {
                mz_blParam = new Mz_bl();
            }
            List<OracleParameter> sqlparams = new List<OracleParameter>();//保存参数的集合
            StringBuilder sql = new StringBuilder("SELECT COUNT(ID) FROM MZ_BL A");
                if (null != mz_blParam.Zfbz && "" != mz_blParam.Zfbz)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.ZFBZ=:zfbz ");
                    OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                pZfbz.Value = mz_blParam.Zfbz;
                sqlparams.Add(pZfbz);
                }
                
                if (null != mz_blParam.Zs && "" != mz_blParam.Zs)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.ZS=:zs ");
                    OracleParameter pZs = new OracleParameter(":zs", OracleDbType.NVarchar2);
                pZs.Value = mz_blParam.Zs;
                sqlparams.Add(pZs);
                }
                
                if (null != mz_blParam.Xbs && "" != mz_blParam.Xbs)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.XBS=:xbs ");
                    OracleParameter pXbs = new OracleParameter(":xbs", OracleDbType.NVarchar2);
                pXbs.Value = mz_blParam.Xbs;
                sqlparams.Add(pXbs);
                }
                
                if (null != mz_blParam.Jws && "" != mz_blParam.Jws)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.JWS=:jws ");
                    OracleParameter pJws = new OracleParameter(":jws", OracleDbType.NVarchar2);
                pJws.Value = mz_blParam.Jws;
                sqlparams.Add(pJws);
                }
                
                if (null != mz_blParam.Gms && "" != mz_blParam.Gms)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.GMS=:gms ");
                    OracleParameter pGms = new OracleParameter(":gms", OracleDbType.NVarchar2);
                pGms.Value = mz_blParam.Gms;
                sqlparams.Add(pGms);
                }
                
            if (null != mz_blParam.Tw)
            {
                this.isComma(sql);
                sql.Append(" TW=:tw ");
                OracleParameter pTw = new OracleParameter(":tw", OracleDbType.Decimal);
                pTw.Value = mz_blParam.Tw;
                sqlparams.Add(pTw);

            }
                        
            if (null != mz_blParam.Hx)
            {
                this.isComma(sql);
                sql.Append(" HX=:hx ");
                OracleParameter pHx = new OracleParameter(":hx", OracleDbType.Decimal);
                pHx.Value = mz_blParam.Hx;
                sqlparams.Add(pHx);

            }
                        
            if (null != mz_blParam.Mb)
            {
                this.isComma(sql);
                sql.Append(" MB=:mb ");
                OracleParameter pMb = new OracleParameter(":mb", OracleDbType.Decimal);
                pMb.Value = mz_blParam.Mb;
                sqlparams.Add(pMb);

            }
                        
            if (null != mz_blParam.Ssxy)
            {
                this.isComma(sql);
                sql.Append(" SSXY=:ssxy ");
                OracleParameter pSsxy = new OracleParameter(":ssxy", OracleDbType.Decimal);
                pSsxy.Value = mz_blParam.Ssxy;
                sqlparams.Add(pSsxy);

            }
                        
            if (null != mz_blParam.Szxy)
            {
                this.isComma(sql);
                sql.Append(" SZXY=:szxy ");
                OracleParameter pSzxy = new OracleParameter(":szxy", OracleDbType.Decimal);
                pSzxy.Value = mz_blParam.Szxy;
                sqlparams.Add(pSzxy);

            }
                        
            if (null != mz_blParam.Xl)
            {
                this.isComma(sql);
                sql.Append(" XL=:xl ");
                OracleParameter pXl = new OracleParameter(":xl", OracleDbType.Decimal);
                pXl.Value = mz_blParam.Xl;
                sqlparams.Add(pXl);

            }
                        
            if (null != mz_blParam.Kfxtz)
            {
                this.isComma(sql);
                sql.Append(" KFXTZ=:kfxtz ");
                OracleParameter pKfxtz = new OracleParameter(":kfxtz", OracleDbType.Decimal);
                pKfxtz.Value = mz_blParam.Kfxtz;
                sqlparams.Add(pKfxtz);

            }
                        
                if (null != mz_blParam.Cha_ti && "" != mz_blParam.Cha_ti)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.CHA_TI=:cha_ti ");
                    OracleParameter pCha_ti = new OracleParameter(":cha_ti", OracleDbType.NVarchar2);
                pCha_ti.Value = mz_blParam.Cha_ti;
                sqlparams.Add(pCha_ti);
                }
                
                if (null != mz_blParam.Fk_gh_id && "" != mz_blParam.Fk_gh_id)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.FK_GH_ID=:fk_gh_id ");
                    OracleParameter pFk_gh_id = new OracleParameter(":fk_gh_id", OracleDbType.Varchar2);
                pFk_gh_id.Value = mz_blParam.Fk_gh_id;
                sqlparams.Add(pFk_gh_id);
                }
                
            if (null != mz_blParam.Gh_lsh)
            {
                this.isComma(sql);
                sql.Append(" GH_LSH=:gh_lsh ");
                OracleParameter pGh_lsh = new OracleParameter(":gh_lsh", OracleDbType.Decimal);
                pGh_lsh.Value = mz_blParam.Gh_lsh;
                sqlparams.Add(pGh_lsh);

            }
                        
                if (null != mz_blParam.Clyj && "" != mz_blParam.Clyj)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.CLYJ=:clyj ");
                    OracleParameter pClyj = new OracleParameter(":clyj", OracleDbType.NVarchar2);
                pClyj.Value = mz_blParam.Clyj;
                sqlparams.Add(pClyj);
                }
                
            if(mz_blParamLike!=null)
            {

                if (null != mz_blParamLike.Zfbz && "" != mz_blParamLike.Zfbz)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.ZFBZ LIKE '%'||:zfbz||'%' ");
                    OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                    pZfbz.Direction = ParameterDirection.Input;
                    pZfbz.Value = mz_blParamLike.Zfbz;
                    sqlparams.Add(pZfbz);
                }
                
                if (null != mz_blParamLike.Zs && "" != mz_blParamLike.Zs)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.ZS LIKE '%'||:zs||'%' ");
                    OracleParameter pZs = new OracleParameter(":zs", OracleDbType.NVarchar2);
                    pZs.Direction = ParameterDirection.Input;
                    pZs.Value = mz_blParamLike.Zs;
                    sqlparams.Add(pZs);
                }
                
                if (null != mz_blParamLike.Xbs && "" != mz_blParamLike.Xbs)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.XBS LIKE '%'||:xbs||'%' ");
                    OracleParameter pXbs = new OracleParameter(":xbs", OracleDbType.NVarchar2);
                    pXbs.Direction = ParameterDirection.Input;
                    pXbs.Value = mz_blParamLike.Xbs;
                    sqlparams.Add(pXbs);
                }
                
                if (null != mz_blParamLike.Jws && "" != mz_blParamLike.Jws)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.JWS LIKE '%'||:jws||'%' ");
                    OracleParameter pJws = new OracleParameter(":jws", OracleDbType.NVarchar2);
                    pJws.Direction = ParameterDirection.Input;
                    pJws.Value = mz_blParamLike.Jws;
                    sqlparams.Add(pJws);
                }
                
                if (null != mz_blParamLike.Gms && "" != mz_blParamLike.Gms)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.GMS LIKE '%'||:gms||'%' ");
                    OracleParameter pGms = new OracleParameter(":gms", OracleDbType.NVarchar2);
                    pGms.Direction = ParameterDirection.Input;
                    pGms.Value = mz_blParamLike.Gms;
                    sqlparams.Add(pGms);
                }
                
                if (null != mz_blParamLike.Cha_ti && "" != mz_blParamLike.Cha_ti)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.CHA_TI LIKE '%'||:cha_ti||'%' ");
                    OracleParameter pCha_ti = new OracleParameter(":cha_ti", OracleDbType.NVarchar2);
                    pCha_ti.Direction = ParameterDirection.Input;
                    pCha_ti.Value = mz_blParamLike.Cha_ti;
                    sqlparams.Add(pCha_ti);
                }
                
                if (null != mz_blParamLike.Fk_gh_id && "" != mz_blParamLike.Fk_gh_id)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.FK_GH_ID LIKE '%'||:fk_gh_id||'%' ");
                    OracleParameter pFk_gh_id = new OracleParameter(":fk_gh_id", OracleDbType.Varchar2);
                    pFk_gh_id.Direction = ParameterDirection.Input;
                    pFk_gh_id.Value = mz_blParamLike.Fk_gh_id;
                    sqlparams.Add(pFk_gh_id);
                }
                
                if (null != mz_blParamLike.Clyj && "" != mz_blParamLike.Clyj)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.CLYJ LIKE '%'||:clyj||'%' ");
                    OracleParameter pClyj = new OracleParameter(":clyj", OracleDbType.NVarchar2);
                    pClyj.Direction = ParameterDirection.Input;
                    pClyj.Value = mz_blParamLike.Clyj;
                    sqlparams.Add(pClyj);
                }
                
            }

            this.b_isWhere = false;
            return Int32.Parse(OracleHelper.ExecuteScalar(sql.ToString(),sqlparams.ToArray()).ToString());
        }


        /// <summary>
        /// 通用的保存方法，根据用户传入的参数，有ID为修改，没有ID为新增(手动生成OracleConnection对象，此方法用于事务，使用事务必须使用同一个OracleConnection对象)
        /// </summary>
        /// <param name="mz_blParam"></param>
        /// <returns></returns>
        public bool save(Mz_bl mz_blParam,OracleConnection con)
        {
            if ("" != mz_blParam.Id && null != mz_blParam.Id)
            {
                //修改
                return this.updateById(mz_blParam,con);
            }
            else
            {
                //新增
                return this.insert(mz_blParam,con);
            }
        }

        /// <summary>
        /// 把dataset中的一行转换为model
        /// </summary>
        /// <param name="row"></param>
        /// <returns></returns>
        private Mz_bl dataSetToModel(DataRow row)
        {
            Mz_bl mz_blParam = new Mz_bl();
            mz_blParam.Id = Convert.ToString(row["ID"]).Trim(); 
            mz_blParam.Zfbz = Convert.ToString(row["ZFBZ"]).Trim(); 
            mz_blParam.Zs = Convert.ToString(row["ZS"]).Trim(); 
            mz_blParam.Xbs = Convert.ToString(row["XBS"]).Trim(); 
            mz_blParam.Jws = Convert.ToString(row["JWS"]).Trim(); 
            mz_blParam.Gms = Convert.ToString(row["GMS"]).Trim(); 
            mz_blParam.Tw =  (decimal?)this.convertDBNullValue(row["TW"]);
            mz_blParam.Hx =  (decimal?)this.convertDBNullValue(row["HX"]);
            mz_blParam.Mb =  (decimal?)this.convertDBNullValue(row["MB"]);
            mz_blParam.Ssxy =  (decimal?)this.convertDBNullValue(row["SSXY"]);
            mz_blParam.Szxy =  (decimal?)this.convertDBNullValue(row["SZXY"]);
            mz_blParam.Xl =  (decimal?)this.convertDBNullValue(row["XL"]);
            mz_blParam.Kfxtz =  (decimal?)this.convertDBNullValue(row["KFXTZ"]);
            mz_blParam.Cha_ti = Convert.ToString(row["CHA_TI"]).Trim(); 
            mz_blParam.Fk_gh_id = Convert.ToString(row["FK_GH_ID"]).Trim(); 
            mz_blParam.Gh_lsh =  (decimal?)this.convertDBNullValue(row["GH_LSH"]);
            mz_blParam.Clyj = Convert.ToString(row["CLYJ"]).Trim(); 
            
            return mz_blParam;
        }

       
        
        //*******************在此以后添加新的方法start

        //*******************在此以后添加新的方法end
        
    }
}


