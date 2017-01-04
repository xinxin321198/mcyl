

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

namespace DAL.JC.基础_科室
{
    /// <summary>
    ///数据库访问层的Jc_kswh实现类
    ///此类由代码生成器生成
    ///表名：JC_KSWH
    ///生成日期：2015-12-02 16:21:45
    /// 

    ///作者：罗新鑫
    ///联系电话：15087010221
    ///联系邮箱：362527240@qq.com
        
    /// </summary>
    public class Jc_kswhDALImp :Base.BasDAL,Jc_kswhDAL
    {

        /// <summary>
        /// 插入一条数据（如果需要供事务使用就传入OracleConnection对象，如果不供就传入null，方法自动生成OracleConnection对象）
        /// 主键为null时，自动生成主键guid，一般不直接调用此方法，请调用save方法进行单条数据的插入和修改       
        /// </summary>
        /// <param name="jc_kswhParam">要插入的jc_kswhParam对象</param>
        /// <param name="con">Oracle连接对象（为null时自动生成）</param>
        /// <returns>是否添加成功（影响的行数为1时成功）</returns>
        public bool insert(Jc_kswh jc_kswhParam,OracleConnection con)
        {
            if (""==jc_kswhParam.Id||null==jc_kswhParam.Id)
            {
                jc_kswhParam.Id = Model.Common.GUIDHelper.getGuid();
            }
            List<OracleParameter> sqlparams = new List<OracleParameter>();
            
            StringBuilder sql = new StringBuilder("INSERT INTO JC_KSWH(id,ksbh,ksmc,mzbz_code,zybz_code,ykbz_code,yfbz_code,yjbz_code,ssbz_code,zfbz) VALUES(:id,:ksbh,:ksmc,:mzbz_code,:zybz_code,:ykbz_code,:yfbz_code,:yjbz_code,:ssbz_code,:zfbz)");
            
            OracleParameter pId = new OracleParameter(":id", OracleDbType.Varchar2);
            pId.Direction = ParameterDirection.Input;
            pId.Value = jc_kswhParam.Id;
            sqlparams.Add(pId);
            OracleParameter pKsbh = new OracleParameter(":ksbh", OracleDbType.NVarchar2);
            pKsbh.Direction = ParameterDirection.Input;
            pKsbh.Value = jc_kswhParam.Ksbh;
            sqlparams.Add(pKsbh);
            OracleParameter pKsmc = new OracleParameter(":ksmc", OracleDbType.NVarchar2);
            pKsmc.Direction = ParameterDirection.Input;
            pKsmc.Value = jc_kswhParam.Ksmc;
            sqlparams.Add(pKsmc);
            OracleParameter pMzbz_code = new OracleParameter(":mzbz_code", OracleDbType.NVarchar2);
            pMzbz_code.Direction = ParameterDirection.Input;
            pMzbz_code.Value = jc_kswhParam.Mzbz_code;
            sqlparams.Add(pMzbz_code);
            OracleParameter pZybz_code = new OracleParameter(":zybz_code", OracleDbType.NVarchar2);
            pZybz_code.Direction = ParameterDirection.Input;
            pZybz_code.Value = jc_kswhParam.Zybz_code;
            sqlparams.Add(pZybz_code);
            OracleParameter pYkbz_code = new OracleParameter(":ykbz_code", OracleDbType.NVarchar2);
            pYkbz_code.Direction = ParameterDirection.Input;
            pYkbz_code.Value = jc_kswhParam.Ykbz_code;
            sqlparams.Add(pYkbz_code);
            OracleParameter pYfbz_code = new OracleParameter(":yfbz_code", OracleDbType.NVarchar2);
            pYfbz_code.Direction = ParameterDirection.Input;
            pYfbz_code.Value = jc_kswhParam.Yfbz_code;
            sqlparams.Add(pYfbz_code);
            OracleParameter pYjbz_code = new OracleParameter(":yjbz_code", OracleDbType.NVarchar2);
            pYjbz_code.Direction = ParameterDirection.Input;
            pYjbz_code.Value = jc_kswhParam.Yjbz_code;
            sqlparams.Add(pYjbz_code);
            OracleParameter pSsbz_code = new OracleParameter(":ssbz_code", OracleDbType.NVarchar2);
            pSsbz_code.Direction = ParameterDirection.Input;
            pSsbz_code.Value = jc_kswhParam.Ssbz_code;
            sqlparams.Add(pSsbz_code);
            OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
            pZfbz.Direction = ParameterDirection.Input;
            pZfbz.Value = jc_kswhParam.Zfbz;
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
        /// <param name="jc_kswhParamList">要插入的jc_kswhParam对象的集合</param>
        /// <param name="con">Oracle连接对象（为null时自动生成）</param>
        /// <returns>是否添加成功（影响的行数等于保存的对象的数量时成功）</returns>
        public bool inertBatch(List<Jc_kswh> jc_kswhParamList, OracleConnection con)
        {
            if (jc_kswhParamList.Count == 0)
            {
                return true;
            }
            List<string> idList = new List<string>();

            List<string> ksbhList = new List<string>();

            List<string> ksmcList = new List<string>();

            List<string> mzbz_codeList = new List<string>();

            List<string> zybz_codeList = new List<string>();

            List<string> ykbz_codeList = new List<string>();

            List<string> yfbz_codeList = new List<string>();

            List<string> yjbz_codeList = new List<string>();

            List<string> ssbz_codeList = new List<string>();

            List<string> zfbzList = new List<string>();

            for (int i = 0; i < jc_kswhParamList.Count; i++)
            {
                Jc_kswh jc_kswhParam = jc_kswhParamList[i];
                if ("" == jc_kswhParam.Id || null == jc_kswhParam.Id)
                {
                    jc_kswhParam.Id = Model.Common.GUIDHelper.getGuid();
                }

            idList.Add(jc_kswhParam.Id);

            ksbhList.Add(jc_kswhParam.Ksbh);

            ksmcList.Add(jc_kswhParam.Ksmc);

            mzbz_codeList.Add(jc_kswhParam.Mzbz_code);

            zybz_codeList.Add(jc_kswhParam.Zybz_code);

            ykbz_codeList.Add(jc_kswhParam.Ykbz_code);

            yfbz_codeList.Add(jc_kswhParam.Yfbz_code);

            yjbz_codeList.Add(jc_kswhParam.Yjbz_code);

            ssbz_codeList.Add(jc_kswhParam.Ssbz_code);

            zfbzList.Add(jc_kswhParam.Zfbz);

            }

            List<OracleParameter> sqlparams = new List<OracleParameter>();

            StringBuilder sql = new StringBuilder("INSERT INTO JC_KSWH(id,ksbh,ksmc,mzbz_code,zybz_code,ykbz_code,yfbz_code,yjbz_code,ssbz_code,zfbz) VALUES(:id,:ksbh,:ksmc,:mzbz_code,:zybz_code,:ykbz_code,:yfbz_code,:yjbz_code,:ssbz_code,:zfbz)");
            
            OracleParameter pId = new OracleParameter(":id", OracleDbType.Varchar2);
            pId.Direction = ParameterDirection.Input;
            pId.Value = idList.ToArray();
            sqlparams.Add(pId);
            OracleParameter pKsbh = new OracleParameter(":ksbh", OracleDbType.NVarchar2);
            pKsbh.Direction = ParameterDirection.Input;
            pKsbh.Value = ksbhList.ToArray();
            sqlparams.Add(pKsbh);
            OracleParameter pKsmc = new OracleParameter(":ksmc", OracleDbType.NVarchar2);
            pKsmc.Direction = ParameterDirection.Input;
            pKsmc.Value = ksmcList.ToArray();
            sqlparams.Add(pKsmc);
            OracleParameter pMzbz_code = new OracleParameter(":mzbz_code", OracleDbType.NVarchar2);
            pMzbz_code.Direction = ParameterDirection.Input;
            pMzbz_code.Value = mzbz_codeList.ToArray();
            sqlparams.Add(pMzbz_code);
            OracleParameter pZybz_code = new OracleParameter(":zybz_code", OracleDbType.NVarchar2);
            pZybz_code.Direction = ParameterDirection.Input;
            pZybz_code.Value = zybz_codeList.ToArray();
            sqlparams.Add(pZybz_code);
            OracleParameter pYkbz_code = new OracleParameter(":ykbz_code", OracleDbType.NVarchar2);
            pYkbz_code.Direction = ParameterDirection.Input;
            pYkbz_code.Value = ykbz_codeList.ToArray();
            sqlparams.Add(pYkbz_code);
            OracleParameter pYfbz_code = new OracleParameter(":yfbz_code", OracleDbType.NVarchar2);
            pYfbz_code.Direction = ParameterDirection.Input;
            pYfbz_code.Value = yfbz_codeList.ToArray();
            sqlparams.Add(pYfbz_code);
            OracleParameter pYjbz_code = new OracleParameter(":yjbz_code", OracleDbType.NVarchar2);
            pYjbz_code.Direction = ParameterDirection.Input;
            pYjbz_code.Value = yjbz_codeList.ToArray();
            sqlparams.Add(pYjbz_code);
            OracleParameter pSsbz_code = new OracleParameter(":ssbz_code", OracleDbType.NVarchar2);
            pSsbz_code.Direction = ParameterDirection.Input;
            pSsbz_code.Value = ssbz_codeList.ToArray();
            sqlparams.Add(pSsbz_code);
            OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
            pZfbz.Direction = ParameterDirection.Input;
            pZfbz.Value = zfbzList.ToArray();
            sqlparams.Add(pZfbz);
            bool result = false;
            int flag = -1;
            flag = OracleHelper.ExecuteBatch(sql.ToString(), con, jc_kswhParamList.Count, sqlparams.ToArray());
            if (jc_kswhParamList.Count == flag)
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
            StringBuilder sql = new StringBuilder("DELETE JC_KSWH WHERE ID=:id");
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
            StringBuilder sql = new StringBuilder("DELETE JC_KSWH WHERE ID=:id");
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
        /// <param name="jc_kswhParamCondition">删除的条件</param>
        /// <param name="con">Oracle连接对象（为null时自动生成）</param>
        /// <returns>无法确定删除的行数（影响行数大于等于0就算成功）</returns>
        public bool deleteByOtherCondition(Jc_kswh jc_kswhParamCondition, OracleConnection con)
        {
            if (null!=jc_kswhParamCondition.Id&&""!=jc_kswhParamCondition.Id)
            {
                throw new Exception("不允许指定参数的ID，如果要根据ID删除数据请调用deleteById或者deleteByIdBatch方法；错误出自：deleteByOtherCondition");
            }
            List<OracleParameter> sqlparams = new List<OracleParameter>();
            StringBuilder sql = new StringBuilder("DELETE JC_KSWH ");

            if (null != jc_kswhParamCondition.Ksbh &&  ""!= jc_kswhParamCondition.Ksbh)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" KSBH=:ksbh ");
                OracleParameter pKsbh = new OracleParameter(":ksbh", OracleDbType.NVarchar2);
                pKsbh.Direction = ParameterDirection.Input;
                pKsbh.Value = jc_kswhParamCondition.Ksbh;
                sqlparams.Add(pKsbh);

            }
                        
            if (null != jc_kswhParamCondition.Ksmc &&  ""!= jc_kswhParamCondition.Ksmc)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" KSMC=:ksmc ");
                OracleParameter pKsmc = new OracleParameter(":ksmc", OracleDbType.NVarchar2);
                pKsmc.Direction = ParameterDirection.Input;
                pKsmc.Value = jc_kswhParamCondition.Ksmc;
                sqlparams.Add(pKsmc);

            }
                        
            if (null != jc_kswhParamCondition.Mzbz_code &&  ""!= jc_kswhParamCondition.Mzbz_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" MZBZ_CODE=:mzbz_code ");
                OracleParameter pMzbz_code = new OracleParameter(":mzbz_code", OracleDbType.NVarchar2);
                pMzbz_code.Direction = ParameterDirection.Input;
                pMzbz_code.Value = jc_kswhParamCondition.Mzbz_code;
                sqlparams.Add(pMzbz_code);

            }
                        
            if (null != jc_kswhParamCondition.Zybz_code &&  ""!= jc_kswhParamCondition.Zybz_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" ZYBZ_CODE=:zybz_code ");
                OracleParameter pZybz_code = new OracleParameter(":zybz_code", OracleDbType.NVarchar2);
                pZybz_code.Direction = ParameterDirection.Input;
                pZybz_code.Value = jc_kswhParamCondition.Zybz_code;
                sqlparams.Add(pZybz_code);

            }
                        
            if (null != jc_kswhParamCondition.Ykbz_code &&  ""!= jc_kswhParamCondition.Ykbz_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" YKBZ_CODE=:ykbz_code ");
                OracleParameter pYkbz_code = new OracleParameter(":ykbz_code", OracleDbType.NVarchar2);
                pYkbz_code.Direction = ParameterDirection.Input;
                pYkbz_code.Value = jc_kswhParamCondition.Ykbz_code;
                sqlparams.Add(pYkbz_code);

            }
                        
            if (null != jc_kswhParamCondition.Yfbz_code &&  ""!= jc_kswhParamCondition.Yfbz_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" YFBZ_CODE=:yfbz_code ");
                OracleParameter pYfbz_code = new OracleParameter(":yfbz_code", OracleDbType.NVarchar2);
                pYfbz_code.Direction = ParameterDirection.Input;
                pYfbz_code.Value = jc_kswhParamCondition.Yfbz_code;
                sqlparams.Add(pYfbz_code);

            }
                        
            if (null != jc_kswhParamCondition.Yjbz_code &&  ""!= jc_kswhParamCondition.Yjbz_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" YJBZ_CODE=:yjbz_code ");
                OracleParameter pYjbz_code = new OracleParameter(":yjbz_code", OracleDbType.NVarchar2);
                pYjbz_code.Direction = ParameterDirection.Input;
                pYjbz_code.Value = jc_kswhParamCondition.Yjbz_code;
                sqlparams.Add(pYjbz_code);

            }
                        
            if (null != jc_kswhParamCondition.Ssbz_code &&  ""!= jc_kswhParamCondition.Ssbz_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" SSBZ_CODE=:ssbz_code ");
                OracleParameter pSsbz_code = new OracleParameter(":ssbz_code", OracleDbType.NVarchar2);
                pSsbz_code.Direction = ParameterDirection.Input;
                pSsbz_code.Value = jc_kswhParamCondition.Ssbz_code;
                sqlparams.Add(pSsbz_code);

            }
                        
            if (null != jc_kswhParamCondition.Zfbz &&  ""!= jc_kswhParamCondition.Zfbz)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" ZFBZ=:zfbz ");
                OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                pZfbz.Direction = ParameterDirection.Input;
                pZfbz.Value = jc_kswhParamCondition.Zfbz;
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
        /// <param name="jc_kswhParam"></param>
        /// <returns>影响的行数</returns>
        public bool updateById(Jc_kswh jc_kswhParam,OracleConnection con)
        {
            if ("" == jc_kswhParam.Id || null == jc_kswhParam.Id)
            {
                throw new Exception("ID不允许为空，请赋值后调用；错误出自：updateById");
            }
            List<OracleParameter> sqlparams = new List<OracleParameter>();

            StringBuilder sql = new StringBuilder("UPDATE JC_KSWH SET ");
            if (null != jc_kswhParam.Ksbh &&  ""!= jc_kswhParam.Ksbh)
            {
                this.isComma(sql);
                sql.Append(" KSBH=:ksbh ");
                OracleParameter pKsbh = new OracleParameter(":ksbh", OracleDbType.NVarchar2);
                pKsbh.Direction = ParameterDirection.Input;
                pKsbh.Value = jc_kswhParam.Ksbh;
                sqlparams.Add(pKsbh);

            }
                        
            if (null != jc_kswhParam.Ksmc &&  ""!= jc_kswhParam.Ksmc)
            {
                this.isComma(sql);
                sql.Append(" KSMC=:ksmc ");
                OracleParameter pKsmc = new OracleParameter(":ksmc", OracleDbType.NVarchar2);
                pKsmc.Direction = ParameterDirection.Input;
                pKsmc.Value = jc_kswhParam.Ksmc;
                sqlparams.Add(pKsmc);

            }
                        
            if (null != jc_kswhParam.Mzbz_code &&  ""!= jc_kswhParam.Mzbz_code)
            {
                this.isComma(sql);
                sql.Append(" MZBZ_CODE=:mzbz_code ");
                OracleParameter pMzbz_code = new OracleParameter(":mzbz_code", OracleDbType.NVarchar2);
                pMzbz_code.Direction = ParameterDirection.Input;
                pMzbz_code.Value = jc_kswhParam.Mzbz_code;
                sqlparams.Add(pMzbz_code);

            }
                        
            if (null != jc_kswhParam.Zybz_code &&  ""!= jc_kswhParam.Zybz_code)
            {
                this.isComma(sql);
                sql.Append(" ZYBZ_CODE=:zybz_code ");
                OracleParameter pZybz_code = new OracleParameter(":zybz_code", OracleDbType.NVarchar2);
                pZybz_code.Direction = ParameterDirection.Input;
                pZybz_code.Value = jc_kswhParam.Zybz_code;
                sqlparams.Add(pZybz_code);

            }
                        
            if (null != jc_kswhParam.Ykbz_code &&  ""!= jc_kswhParam.Ykbz_code)
            {
                this.isComma(sql);
                sql.Append(" YKBZ_CODE=:ykbz_code ");
                OracleParameter pYkbz_code = new OracleParameter(":ykbz_code", OracleDbType.NVarchar2);
                pYkbz_code.Direction = ParameterDirection.Input;
                pYkbz_code.Value = jc_kswhParam.Ykbz_code;
                sqlparams.Add(pYkbz_code);

            }
                        
            if (null != jc_kswhParam.Yfbz_code &&  ""!= jc_kswhParam.Yfbz_code)
            {
                this.isComma(sql);
                sql.Append(" YFBZ_CODE=:yfbz_code ");
                OracleParameter pYfbz_code = new OracleParameter(":yfbz_code", OracleDbType.NVarchar2);
                pYfbz_code.Direction = ParameterDirection.Input;
                pYfbz_code.Value = jc_kswhParam.Yfbz_code;
                sqlparams.Add(pYfbz_code);

            }
                        
            if (null != jc_kswhParam.Yjbz_code &&  ""!= jc_kswhParam.Yjbz_code)
            {
                this.isComma(sql);
                sql.Append(" YJBZ_CODE=:yjbz_code ");
                OracleParameter pYjbz_code = new OracleParameter(":yjbz_code", OracleDbType.NVarchar2);
                pYjbz_code.Direction = ParameterDirection.Input;
                pYjbz_code.Value = jc_kswhParam.Yjbz_code;
                sqlparams.Add(pYjbz_code);

            }
                        
            if (null != jc_kswhParam.Ssbz_code &&  ""!= jc_kswhParam.Ssbz_code)
            {
                this.isComma(sql);
                sql.Append(" SSBZ_CODE=:ssbz_code ");
                OracleParameter pSsbz_code = new OracleParameter(":ssbz_code", OracleDbType.NVarchar2);
                pSsbz_code.Direction = ParameterDirection.Input;
                pSsbz_code.Value = jc_kswhParam.Ssbz_code;
                sqlparams.Add(pSsbz_code);

            }
                        
            if (null != jc_kswhParam.Zfbz &&  ""!= jc_kswhParam.Zfbz)
            {
                this.isComma(sql);
                sql.Append(" ZFBZ=:zfbz ");
                OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                pZfbz.Direction = ParameterDirection.Input;
                pZfbz.Value = jc_kswhParam.Zfbz;
                sqlparams.Add(pZfbz);

            }
                        
            sql.Append(" WHERE ID=:id ");
            OracleParameter pId = new OracleParameter(":id", OracleDbType.Varchar2);
            pId.Value = jc_kswhParam.Id;
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
        /// <param name="jc_kswhParamList">要修改的Jc_kswh对象集合</param>
        /// <param name="con">Oracle连接对象（为null时自动生成）</param>
        /// <returns>是否删除成功（影响的行数等于要修改的对象数量时成功）</returns>
        public bool updateByIdBatch(List<Jc_kswh> jc_kswhParamList, OracleConnection con)
        {


            List<string> idList = new List<string>();

            List<string> ksbhList = new List<string>();

            List<string> ksmcList = new List<string>();

            List<string> mzbz_codeList = new List<string>();

            List<string> zybz_codeList = new List<string>();

            List<string> ykbz_codeList = new List<string>();

            List<string> yfbz_codeList = new List<string>();

            List<string> yjbz_codeList = new List<string>();

            List<string> ssbz_codeList = new List<string>();

            List<string> zfbzList = new List<string>();

            for (int i = 0; i < jc_kswhParamList.Count; i++)
            {
                Jc_kswh jc_kswhParam = jc_kswhParamList[i];
                if ("" == jc_kswhParam.Id || null == jc_kswhParam.Id)
                {
                    throw new Exception("下标为" + i + "的数据，ID不能为空，请赋值后调用；错误出自：updateByIdBatch");
                }

            idList.Add(jc_kswhParam.Id);

            ksbhList.Add(jc_kswhParam.Ksbh);

            ksmcList.Add(jc_kswhParam.Ksmc);

            mzbz_codeList.Add(jc_kswhParam.Mzbz_code);

            zybz_codeList.Add(jc_kswhParam.Zybz_code);

            ykbz_codeList.Add(jc_kswhParam.Ykbz_code);

            yfbz_codeList.Add(jc_kswhParam.Yfbz_code);

            yjbz_codeList.Add(jc_kswhParam.Yjbz_code);

            ssbz_codeList.Add(jc_kswhParam.Ssbz_code);

            zfbzList.Add(jc_kswhParam.Zfbz);

            }


            
            List<OracleParameter> sqlparams = new List<OracleParameter>();

            StringBuilder sql = new StringBuilder("UPDATE JC_KSWH SET ");
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
            sql.Append(" MZBZ_CODE=:mzbz_code ");
            OracleParameter pMzbz_code = new OracleParameter(":mzbz_code", OracleDbType.NVarchar2);
            pMzbz_code.Direction = ParameterDirection.Input;
            pMzbz_code.Value = mzbz_codeList.ToArray();
            sqlparams.Add(pMzbz_code);

            this.isComma(sql);
            sql.Append(" ZYBZ_CODE=:zybz_code ");
            OracleParameter pZybz_code = new OracleParameter(":zybz_code", OracleDbType.NVarchar2);
            pZybz_code.Direction = ParameterDirection.Input;
            pZybz_code.Value = zybz_codeList.ToArray();
            sqlparams.Add(pZybz_code);

            this.isComma(sql);
            sql.Append(" YKBZ_CODE=:ykbz_code ");
            OracleParameter pYkbz_code = new OracleParameter(":ykbz_code", OracleDbType.NVarchar2);
            pYkbz_code.Direction = ParameterDirection.Input;
            pYkbz_code.Value = ykbz_codeList.ToArray();
            sqlparams.Add(pYkbz_code);

            this.isComma(sql);
            sql.Append(" YFBZ_CODE=:yfbz_code ");
            OracleParameter pYfbz_code = new OracleParameter(":yfbz_code", OracleDbType.NVarchar2);
            pYfbz_code.Direction = ParameterDirection.Input;
            pYfbz_code.Value = yfbz_codeList.ToArray();
            sqlparams.Add(pYfbz_code);

            this.isComma(sql);
            sql.Append(" YJBZ_CODE=:yjbz_code ");
            OracleParameter pYjbz_code = new OracleParameter(":yjbz_code", OracleDbType.NVarchar2);
            pYjbz_code.Direction = ParameterDirection.Input;
            pYjbz_code.Value = yjbz_codeList.ToArray();
            sqlparams.Add(pYjbz_code);

            this.isComma(sql);
            sql.Append(" SSBZ_CODE=:ssbz_code ");
            OracleParameter pSsbz_code = new OracleParameter(":ssbz_code", OracleDbType.NVarchar2);
            pSsbz_code.Direction = ParameterDirection.Input;
            pSsbz_code.Value = ssbz_codeList.ToArray();
            sqlparams.Add(pSsbz_code);

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
            int flag = OracleHelper.ExecuteBatch(sql.ToString(), con,jc_kswhParamList.Count, sqlparams.ToArray());
            if (jc_kswhParamList.Count == flag)
            {
                result = true;
            }
            return result;
        }

        /// <summary>
        /// 根据更新的条件，更新数据（如果需要供事务使用就传入OracleConnection对象，如果不供就传入null，方法自动生成OracleConnection对象）
        /// 不指定ID，如果要根据ID来更新数据，请使用updateForId方法
        /// </summary>
        /// <param name="jc_kswhParamCondition">条件对象</param>
        /// <param name="jc_kswhParamUpdate">要更新的数据对象</param>
        /// <param name="con">Oracle连接对象（为null时自动生成）</param>
        /// <returns>影响的行数不确定（不为-1就正确）</returns>
        public bool updateByOtherCondition(Jc_kswh jc_kswhParamCondition, Jc_kswh jc_kswhParamUpdate, OracleConnection con)
        {
            if ((null!=jc_kswhParamCondition.Id&&"!=jc_kswhParamCondition.Id)||(null!=jc_kswhParamUpdate.Id&&"!=jc_kswhParamUpdate.Id))
            {
                throw new Exception("此方法不允许指定参数的ID，数据库中的ID不允许修改，如需根据ID修改数据，请调用updateById或updateByIdBatch方法；错误出自：updateByOtherCondition");
            }
            List<OracleParameter> sqlparams = new List<OracleParameter>();
            //添加要修改的值
            StringBuilder sql = new StringBuilder("UPDATE JC_KSWH SET ");
            if (null != jc_kswhParamUpdate.Ksbh &&  ""!= jc_kswhParamUpdate.Ksbh)
            {
                this.isComma(sql);
                sql.Append(" KSBH=:ksbh ");
                OracleParameter pKsbh = new OracleParameter(":ksbh", OracleDbType.NVarchar2);
                pKsbh.Direction = ParameterDirection.Input;
                pKsbh.Value = jc_kswhParamUpdate.Ksbh;
                sqlparams.Add(pKsbh);

            }
                        
            if (null != jc_kswhParamUpdate.Ksmc &&  ""!= jc_kswhParamUpdate.Ksmc)
            {
                this.isComma(sql);
                sql.Append(" KSMC=:ksmc ");
                OracleParameter pKsmc = new OracleParameter(":ksmc", OracleDbType.NVarchar2);
                pKsmc.Direction = ParameterDirection.Input;
                pKsmc.Value = jc_kswhParamUpdate.Ksmc;
                sqlparams.Add(pKsmc);

            }
                        
            if (null != jc_kswhParamUpdate.Mzbz_code &&  ""!= jc_kswhParamUpdate.Mzbz_code)
            {
                this.isComma(sql);
                sql.Append(" MZBZ_CODE=:mzbz_code ");
                OracleParameter pMzbz_code = new OracleParameter(":mzbz_code", OracleDbType.NVarchar2);
                pMzbz_code.Direction = ParameterDirection.Input;
                pMzbz_code.Value = jc_kswhParamUpdate.Mzbz_code;
                sqlparams.Add(pMzbz_code);

            }
                        
            if (null != jc_kswhParamUpdate.Zybz_code &&  ""!= jc_kswhParamUpdate.Zybz_code)
            {
                this.isComma(sql);
                sql.Append(" ZYBZ_CODE=:zybz_code ");
                OracleParameter pZybz_code = new OracleParameter(":zybz_code", OracleDbType.NVarchar2);
                pZybz_code.Direction = ParameterDirection.Input;
                pZybz_code.Value = jc_kswhParamUpdate.Zybz_code;
                sqlparams.Add(pZybz_code);

            }
                        
            if (null != jc_kswhParamUpdate.Ykbz_code &&  ""!= jc_kswhParamUpdate.Ykbz_code)
            {
                this.isComma(sql);
                sql.Append(" YKBZ_CODE=:ykbz_code ");
                OracleParameter pYkbz_code = new OracleParameter(":ykbz_code", OracleDbType.NVarchar2);
                pYkbz_code.Direction = ParameterDirection.Input;
                pYkbz_code.Value = jc_kswhParamUpdate.Ykbz_code;
                sqlparams.Add(pYkbz_code);

            }
                        
            if (null != jc_kswhParamUpdate.Yfbz_code &&  ""!= jc_kswhParamUpdate.Yfbz_code)
            {
                this.isComma(sql);
                sql.Append(" YFBZ_CODE=:yfbz_code ");
                OracleParameter pYfbz_code = new OracleParameter(":yfbz_code", OracleDbType.NVarchar2);
                pYfbz_code.Direction = ParameterDirection.Input;
                pYfbz_code.Value = jc_kswhParamUpdate.Yfbz_code;
                sqlparams.Add(pYfbz_code);

            }
                        
            if (null != jc_kswhParamUpdate.Yjbz_code &&  ""!= jc_kswhParamUpdate.Yjbz_code)
            {
                this.isComma(sql);
                sql.Append(" YJBZ_CODE=:yjbz_code ");
                OracleParameter pYjbz_code = new OracleParameter(":yjbz_code", OracleDbType.NVarchar2);
                pYjbz_code.Direction = ParameterDirection.Input;
                pYjbz_code.Value = jc_kswhParamUpdate.Yjbz_code;
                sqlparams.Add(pYjbz_code);

            }
                        
            if (null != jc_kswhParamUpdate.Ssbz_code &&  ""!= jc_kswhParamUpdate.Ssbz_code)
            {
                this.isComma(sql);
                sql.Append(" SSBZ_CODE=:ssbz_code ");
                OracleParameter pSsbz_code = new OracleParameter(":ssbz_code", OracleDbType.NVarchar2);
                pSsbz_code.Direction = ParameterDirection.Input;
                pSsbz_code.Value = jc_kswhParamUpdate.Ssbz_code;
                sqlparams.Add(pSsbz_code);

            }
                        
            if (null != jc_kswhParamUpdate.Zfbz &&  ""!= jc_kswhParamUpdate.Zfbz)
            {
                this.isComma(sql);
                sql.Append(" ZFBZ=:zfbz ");
                OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                pZfbz.Direction = ParameterDirection.Input;
                pZfbz.Value = jc_kswhParamUpdate.Zfbz;
                sqlparams.Add(pZfbz);

            }
                        
            //添加条件的参数
            
            if (null != jc_kswhParamCondition.Ksbh &&  ""!= jc_kswhParamCondition.Ksbh)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" KSBH=:ksbh ");
                OracleParameter pKsbh = new OracleParameter(":ksbh", OracleDbType.NVarchar2);
                pKsbh.Direction = ParameterDirection.Input;
                pKsbh.Value = jc_kswhParamCondition.Ksbh;
                sqlparams.Add(pKsbh);

            }
                        
            if (null != jc_kswhParamCondition.Ksmc &&  ""!= jc_kswhParamCondition.Ksmc)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" KSMC=:ksmc ");
                OracleParameter pKsmc = new OracleParameter(":ksmc", OracleDbType.NVarchar2);
                pKsmc.Direction = ParameterDirection.Input;
                pKsmc.Value = jc_kswhParamCondition.Ksmc;
                sqlparams.Add(pKsmc);

            }
                        
            if (null != jc_kswhParamCondition.Mzbz_code &&  ""!= jc_kswhParamCondition.Mzbz_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" MZBZ_CODE=:mzbz_code ");
                OracleParameter pMzbz_code = new OracleParameter(":mzbz_code", OracleDbType.NVarchar2);
                pMzbz_code.Direction = ParameterDirection.Input;
                pMzbz_code.Value = jc_kswhParamCondition.Mzbz_code;
                sqlparams.Add(pMzbz_code);

            }
                        
            if (null != jc_kswhParamCondition.Zybz_code &&  ""!= jc_kswhParamCondition.Zybz_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" ZYBZ_CODE=:zybz_code ");
                OracleParameter pZybz_code = new OracleParameter(":zybz_code", OracleDbType.NVarchar2);
                pZybz_code.Direction = ParameterDirection.Input;
                pZybz_code.Value = jc_kswhParamCondition.Zybz_code;
                sqlparams.Add(pZybz_code);

            }
                        
            if (null != jc_kswhParamCondition.Ykbz_code &&  ""!= jc_kswhParamCondition.Ykbz_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" YKBZ_CODE=:ykbz_code ");
                OracleParameter pYkbz_code = new OracleParameter(":ykbz_code", OracleDbType.NVarchar2);
                pYkbz_code.Direction = ParameterDirection.Input;
                pYkbz_code.Value = jc_kswhParamCondition.Ykbz_code;
                sqlparams.Add(pYkbz_code);

            }
                        
            if (null != jc_kswhParamCondition.Yfbz_code &&  ""!= jc_kswhParamCondition.Yfbz_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" YFBZ_CODE=:yfbz_code ");
                OracleParameter pYfbz_code = new OracleParameter(":yfbz_code", OracleDbType.NVarchar2);
                pYfbz_code.Direction = ParameterDirection.Input;
                pYfbz_code.Value = jc_kswhParamCondition.Yfbz_code;
                sqlparams.Add(pYfbz_code);

            }
                        
            if (null != jc_kswhParamCondition.Yjbz_code &&  ""!= jc_kswhParamCondition.Yjbz_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" YJBZ_CODE=:yjbz_code ");
                OracleParameter pYjbz_code = new OracleParameter(":yjbz_code", OracleDbType.NVarchar2);
                pYjbz_code.Direction = ParameterDirection.Input;
                pYjbz_code.Value = jc_kswhParamCondition.Yjbz_code;
                sqlparams.Add(pYjbz_code);

            }
                        
            if (null != jc_kswhParamCondition.Ssbz_code &&  ""!= jc_kswhParamCondition.Ssbz_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" SSBZ_CODE=:ssbz_code ");
                OracleParameter pSsbz_code = new OracleParameter(":ssbz_code", OracleDbType.NVarchar2);
                pSsbz_code.Direction = ParameterDirection.Input;
                pSsbz_code.Value = jc_kswhParamCondition.Ssbz_code;
                sqlparams.Add(pSsbz_code);

            }
                        
            if (null != jc_kswhParamCondition.Zfbz &&  ""!= jc_kswhParamCondition.Zfbz)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" ZFBZ=:zfbz ");
                OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                pZfbz.Direction = ParameterDirection.Input;
                pZfbz.Value = jc_kswhParamCondition.Zfbz;
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
        /// <returns>Jc_kswh</returns>
        public Jc_kswh findById(string id)
        {
            if (""==id||null==id)
            {
                throw new Exception("ID不能为空，请赋值后调用；错误出自：findById");
            }
            StringBuilder sql = new StringBuilder("SELECT A.* ");
            //新建方法findContactObjectsById，在此加入多表连接要显示的项start
            //sql.Append(",B.字段一,B.字段二,B.字段三");
            //新建方法，在此加入多表连接要显示的项end
            sql.Append(" FROM JC_KSWH A ");
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
        /// <param name="jc_kswhParam"></param>
        /// <param name="page">分页对象</param>
        ///<param name="jc_kswhParamLike">模糊查询参数</param>
        ///<param name="sortList">排序参数对象的集合</param>
        /// <returns>满足条件的所有Jc_kswh对象集合list</returns>
        public List<object> find(Jc_kswh jc_kswhParam, Model.Common.PageInfo page,Jc_kswh jc_kswhParamLike,List<SortInfo> sortList)
        {

            //如果没有传查询条件参数，就new一个空的Jc_kswh对象，标示查询所有数据
            if (null == jc_kswhParam)
            {
                jc_kswhParam = new Jc_kswh();
            }
            if (null!=jc_kswhParam.Id&&""!=jc_kswhParam.Id)
            {
                throw new Exception("此方法不允许指定参数ID，如果需要根据ID查询数据，请调用findById方法；错误出自：find");
            }
            List<Jc_kswh> jc_kswhParamList = new List<Jc_kswh>();//接收查询出的Jc_kswh对象集合
            List<OracleParameter> sqlparams = new List<OracleParameter>();//保存参数的集合
            StringBuilder sql = new StringBuilder("SELECT A.* ");
            //新建方法findContactObjects(Jc_kswh jc_kswhParam, Model.Common.PageInfo page)，在此加入多表连接要显示的项start
            //sql.Append(",B.字段一,B.字段二,B.字段三");
            //新建方法，在此加入多表连接要显示的项end
            sql.Append(" FROM JC_KSWH A ");
            //新建一个方法，在此加入多表连接的语句start
            ////sql.Append(" LEFT JOIN 表名 B ON A.外键=B.ID");
            //新建一个方法，在此加入多表连接的语句end
            
            
            if (null != jc_kswhParam.Ksbh && "" != jc_kswhParam.Ksbh)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.KSBH=:ksbh ");
                OracleParameter pKsbh = new OracleParameter(":ksbh", OracleDbType.NVarchar2);
                pKsbh.Direction = ParameterDirection.Input;
                pKsbh.Value = jc_kswhParam.Ksbh;
                sqlparams.Add(pKsbh);
            }
                
            if (null != jc_kswhParam.Ksmc && "" != jc_kswhParam.Ksmc)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.KSMC=:ksmc ");
                OracleParameter pKsmc = new OracleParameter(":ksmc", OracleDbType.NVarchar2);
                pKsmc.Direction = ParameterDirection.Input;
                pKsmc.Value = jc_kswhParam.Ksmc;
                sqlparams.Add(pKsmc);
            }
                
            if (null != jc_kswhParam.Mzbz_code && "" != jc_kswhParam.Mzbz_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.MZBZ_CODE=:mzbz_code ");
                OracleParameter pMzbz_code = new OracleParameter(":mzbz_code", OracleDbType.NVarchar2);
                pMzbz_code.Direction = ParameterDirection.Input;
                pMzbz_code.Value = jc_kswhParam.Mzbz_code;
                sqlparams.Add(pMzbz_code);
            }
                
            if (null != jc_kswhParam.Zybz_code && "" != jc_kswhParam.Zybz_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.ZYBZ_CODE=:zybz_code ");
                OracleParameter pZybz_code = new OracleParameter(":zybz_code", OracleDbType.NVarchar2);
                pZybz_code.Direction = ParameterDirection.Input;
                pZybz_code.Value = jc_kswhParam.Zybz_code;
                sqlparams.Add(pZybz_code);
            }
                
            if (null != jc_kswhParam.Ykbz_code && "" != jc_kswhParam.Ykbz_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.YKBZ_CODE=:ykbz_code ");
                OracleParameter pYkbz_code = new OracleParameter(":ykbz_code", OracleDbType.NVarchar2);
                pYkbz_code.Direction = ParameterDirection.Input;
                pYkbz_code.Value = jc_kswhParam.Ykbz_code;
                sqlparams.Add(pYkbz_code);
            }
                
            if (null != jc_kswhParam.Yfbz_code && "" != jc_kswhParam.Yfbz_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.YFBZ_CODE=:yfbz_code ");
                OracleParameter pYfbz_code = new OracleParameter(":yfbz_code", OracleDbType.NVarchar2);
                pYfbz_code.Direction = ParameterDirection.Input;
                pYfbz_code.Value = jc_kswhParam.Yfbz_code;
                sqlparams.Add(pYfbz_code);
            }
                
            if (null != jc_kswhParam.Yjbz_code && "" != jc_kswhParam.Yjbz_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.YJBZ_CODE=:yjbz_code ");
                OracleParameter pYjbz_code = new OracleParameter(":yjbz_code", OracleDbType.NVarchar2);
                pYjbz_code.Direction = ParameterDirection.Input;
                pYjbz_code.Value = jc_kswhParam.Yjbz_code;
                sqlparams.Add(pYjbz_code);
            }
                
            if (null != jc_kswhParam.Ssbz_code && "" != jc_kswhParam.Ssbz_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.SSBZ_CODE=:ssbz_code ");
                OracleParameter pSsbz_code = new OracleParameter(":ssbz_code", OracleDbType.NVarchar2);
                pSsbz_code.Direction = ParameterDirection.Input;
                pSsbz_code.Value = jc_kswhParam.Ssbz_code;
                sqlparams.Add(pSsbz_code);
            }
                
            if (null != jc_kswhParam.Zfbz && "" != jc_kswhParam.Zfbz)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.ZFBZ=:zfbz ");
                OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                pZfbz.Direction = ParameterDirection.Input;
                pZfbz.Value = jc_kswhParam.Zfbz;
                sqlparams.Add(pZfbz);
            }
                
            if(jc_kswhParamLike!=null)
            {

                if (null != jc_kswhParamLike.Ksbh && "" != jc_kswhParamLike.Ksbh)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.KSBH LIKE '%'||:ksbh||'%' ");
                    OracleParameter pKsbh = new OracleParameter(":ksbh", OracleDbType.NVarchar2);
                    pKsbh.Direction = ParameterDirection.Input;
                    pKsbh.Value = jc_kswhParamLike.Ksbh;
                    sqlparams.Add(pKsbh);
                }
                
                if (null != jc_kswhParamLike.Ksmc && "" != jc_kswhParamLike.Ksmc)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.KSMC LIKE '%'||:ksmc||'%' ");
                    OracleParameter pKsmc = new OracleParameter(":ksmc", OracleDbType.NVarchar2);
                    pKsmc.Direction = ParameterDirection.Input;
                    pKsmc.Value = jc_kswhParamLike.Ksmc;
                    sqlparams.Add(pKsmc);
                }
                
                if (null != jc_kswhParamLike.Mzbz_code && "" != jc_kswhParamLike.Mzbz_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.MZBZ_CODE LIKE '%'||:mzbz_code||'%' ");
                    OracleParameter pMzbz_code = new OracleParameter(":mzbz_code", OracleDbType.NVarchar2);
                    pMzbz_code.Direction = ParameterDirection.Input;
                    pMzbz_code.Value = jc_kswhParamLike.Mzbz_code;
                    sqlparams.Add(pMzbz_code);
                }
                
                if (null != jc_kswhParamLike.Zybz_code && "" != jc_kswhParamLike.Zybz_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.ZYBZ_CODE LIKE '%'||:zybz_code||'%' ");
                    OracleParameter pZybz_code = new OracleParameter(":zybz_code", OracleDbType.NVarchar2);
                    pZybz_code.Direction = ParameterDirection.Input;
                    pZybz_code.Value = jc_kswhParamLike.Zybz_code;
                    sqlparams.Add(pZybz_code);
                }
                
                if (null != jc_kswhParamLike.Ykbz_code && "" != jc_kswhParamLike.Ykbz_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YKBZ_CODE LIKE '%'||:ykbz_code||'%' ");
                    OracleParameter pYkbz_code = new OracleParameter(":ykbz_code", OracleDbType.NVarchar2);
                    pYkbz_code.Direction = ParameterDirection.Input;
                    pYkbz_code.Value = jc_kswhParamLike.Ykbz_code;
                    sqlparams.Add(pYkbz_code);
                }
                
                if (null != jc_kswhParamLike.Yfbz_code && "" != jc_kswhParamLike.Yfbz_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YFBZ_CODE LIKE '%'||:yfbz_code||'%' ");
                    OracleParameter pYfbz_code = new OracleParameter(":yfbz_code", OracleDbType.NVarchar2);
                    pYfbz_code.Direction = ParameterDirection.Input;
                    pYfbz_code.Value = jc_kswhParamLike.Yfbz_code;
                    sqlparams.Add(pYfbz_code);
                }
                
                if (null != jc_kswhParamLike.Yjbz_code && "" != jc_kswhParamLike.Yjbz_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YJBZ_CODE LIKE '%'||:yjbz_code||'%' ");
                    OracleParameter pYjbz_code = new OracleParameter(":yjbz_code", OracleDbType.NVarchar2);
                    pYjbz_code.Direction = ParameterDirection.Input;
                    pYjbz_code.Value = jc_kswhParamLike.Yjbz_code;
                    sqlparams.Add(pYjbz_code);
                }
                
                if (null != jc_kswhParamLike.Ssbz_code && "" != jc_kswhParamLike.Ssbz_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.SSBZ_CODE LIKE '%'||:ssbz_code||'%' ");
                    OracleParameter pSsbz_code = new OracleParameter(":ssbz_code", OracleDbType.NVarchar2);
                    pSsbz_code.Direction = ParameterDirection.Input;
                    pSsbz_code.Value = jc_kswhParamLike.Ssbz_code;
                    sqlparams.Add(pSsbz_code);
                }
                
                if (null != jc_kswhParamLike.Zfbz && "" != jc_kswhParamLike.Zfbz)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.ZFBZ LIKE '%'||:zfbz||'%' ");
                    OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                    pZfbz.Direction = ParameterDirection.Input;
                    pZfbz.Value = jc_kswhParamLike.Zfbz;
                    sqlparams.Add(pZfbz);
                }
                
            }

            this.b_isWhere = false;
            this.addSort(sql, sortList);//排序
            //*******分页start1*********如果分页对象为空，则全部数据查出，如果不为空
            List<object> returnList = new List<object>();//返回的List,索引0为List<Jc_kswh>对象,索引1为Model.Common.PageInfo分页信息对象
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
            //把每一行数据转换为一个对象放入List<Jc_kswh>中
            for (int i = 0; i < rows.Count; i++)
            {
                DataRow row = rows[i];
                //jc_kswhParamList.Add(this.dataSetContactObjectsToModel(row));
                jc_kswhParamList.Add(this.dataSetToModel(row));
            }
            
             //*******分页start2*********如果没有传入分页对象，则新建一个分页对象当做返回值
            if (null == page)
            {
                page = new Model.Common.PageInfo();
                page.AllCount = rows.Count;
            }
            returnList.Add(jc_kswhParamList);//把List<Jc_kswh>放入List<object>中第一个
            returnList.Add(page);//把page对象放入List<object>中第二个
            //*******分页end2*********
            return returnList;
        }

        
        
        /// <summary>
        /// 根据条件得到集合的数量
        /// 第二个条件是模糊查询的条件
        /// </summary>
        /// <returns>int</returns>
        public int getCount(Jc_kswh jc_kswhParam,Jc_kswh jc_kswhParamLike)
        {
            //如果没有传查询条件参数，就new一个空的Jc_kswh对象，标示查询所有数据
            if (null == jc_kswhParam)
            {
                jc_kswhParam = new Jc_kswh();
            }
            List<OracleParameter> sqlparams = new List<OracleParameter>();//保存参数的集合
            StringBuilder sql = new StringBuilder("SELECT COUNT(ID) FROM JC_KSWH A");
                if (null != jc_kswhParam.Ksbh && "" != jc_kswhParam.Ksbh)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.KSBH=:ksbh ");
                    OracleParameter pKsbh = new OracleParameter(":ksbh", OracleDbType.NVarchar2);
                pKsbh.Value = jc_kswhParam.Ksbh;
                sqlparams.Add(pKsbh);
                }
                
                if (null != jc_kswhParam.Ksmc && "" != jc_kswhParam.Ksmc)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.KSMC=:ksmc ");
                    OracleParameter pKsmc = new OracleParameter(":ksmc", OracleDbType.NVarchar2);
                pKsmc.Value = jc_kswhParam.Ksmc;
                sqlparams.Add(pKsmc);
                }
                
                if (null != jc_kswhParam.Mzbz_code && "" != jc_kswhParam.Mzbz_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.MZBZ_CODE=:mzbz_code ");
                    OracleParameter pMzbz_code = new OracleParameter(":mzbz_code", OracleDbType.NVarchar2);
                pMzbz_code.Value = jc_kswhParam.Mzbz_code;
                sqlparams.Add(pMzbz_code);
                }
                
                if (null != jc_kswhParam.Zybz_code && "" != jc_kswhParam.Zybz_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.ZYBZ_CODE=:zybz_code ");
                    OracleParameter pZybz_code = new OracleParameter(":zybz_code", OracleDbType.NVarchar2);
                pZybz_code.Value = jc_kswhParam.Zybz_code;
                sqlparams.Add(pZybz_code);
                }
                
                if (null != jc_kswhParam.Ykbz_code && "" != jc_kswhParam.Ykbz_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YKBZ_CODE=:ykbz_code ");
                    OracleParameter pYkbz_code = new OracleParameter(":ykbz_code", OracleDbType.NVarchar2);
                pYkbz_code.Value = jc_kswhParam.Ykbz_code;
                sqlparams.Add(pYkbz_code);
                }
                
                if (null != jc_kswhParam.Yfbz_code && "" != jc_kswhParam.Yfbz_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YFBZ_CODE=:yfbz_code ");
                    OracleParameter pYfbz_code = new OracleParameter(":yfbz_code", OracleDbType.NVarchar2);
                pYfbz_code.Value = jc_kswhParam.Yfbz_code;
                sqlparams.Add(pYfbz_code);
                }
                
                if (null != jc_kswhParam.Yjbz_code && "" != jc_kswhParam.Yjbz_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YJBZ_CODE=:yjbz_code ");
                    OracleParameter pYjbz_code = new OracleParameter(":yjbz_code", OracleDbType.NVarchar2);
                pYjbz_code.Value = jc_kswhParam.Yjbz_code;
                sqlparams.Add(pYjbz_code);
                }
                
                if (null != jc_kswhParam.Ssbz_code && "" != jc_kswhParam.Ssbz_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.SSBZ_CODE=:ssbz_code ");
                    OracleParameter pSsbz_code = new OracleParameter(":ssbz_code", OracleDbType.NVarchar2);
                pSsbz_code.Value = jc_kswhParam.Ssbz_code;
                sqlparams.Add(pSsbz_code);
                }
                
                if (null != jc_kswhParam.Zfbz && "" != jc_kswhParam.Zfbz)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.ZFBZ=:zfbz ");
                    OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                pZfbz.Value = jc_kswhParam.Zfbz;
                sqlparams.Add(pZfbz);
                }
                
            if(jc_kswhParamLike!=null)
            {

                if (null != jc_kswhParamLike.Ksbh && "" != jc_kswhParamLike.Ksbh)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.KSBH LIKE '%'||:ksbh||'%' ");
                    OracleParameter pKsbh = new OracleParameter(":ksbh", OracleDbType.NVarchar2);
                    pKsbh.Direction = ParameterDirection.Input;
                    pKsbh.Value = jc_kswhParamLike.Ksbh;
                    sqlparams.Add(pKsbh);
                }
                
                if (null != jc_kswhParamLike.Ksmc && "" != jc_kswhParamLike.Ksmc)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.KSMC LIKE '%'||:ksmc||'%' ");
                    OracleParameter pKsmc = new OracleParameter(":ksmc", OracleDbType.NVarchar2);
                    pKsmc.Direction = ParameterDirection.Input;
                    pKsmc.Value = jc_kswhParamLike.Ksmc;
                    sqlparams.Add(pKsmc);
                }
                
                if (null != jc_kswhParamLike.Mzbz_code && "" != jc_kswhParamLike.Mzbz_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.MZBZ_CODE LIKE '%'||:mzbz_code||'%' ");
                    OracleParameter pMzbz_code = new OracleParameter(":mzbz_code", OracleDbType.NVarchar2);
                    pMzbz_code.Direction = ParameterDirection.Input;
                    pMzbz_code.Value = jc_kswhParamLike.Mzbz_code;
                    sqlparams.Add(pMzbz_code);
                }
                
                if (null != jc_kswhParamLike.Zybz_code && "" != jc_kswhParamLike.Zybz_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.ZYBZ_CODE LIKE '%'||:zybz_code||'%' ");
                    OracleParameter pZybz_code = new OracleParameter(":zybz_code", OracleDbType.NVarchar2);
                    pZybz_code.Direction = ParameterDirection.Input;
                    pZybz_code.Value = jc_kswhParamLike.Zybz_code;
                    sqlparams.Add(pZybz_code);
                }
                
                if (null != jc_kswhParamLike.Ykbz_code && "" != jc_kswhParamLike.Ykbz_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YKBZ_CODE LIKE '%'||:ykbz_code||'%' ");
                    OracleParameter pYkbz_code = new OracleParameter(":ykbz_code", OracleDbType.NVarchar2);
                    pYkbz_code.Direction = ParameterDirection.Input;
                    pYkbz_code.Value = jc_kswhParamLike.Ykbz_code;
                    sqlparams.Add(pYkbz_code);
                }
                
                if (null != jc_kswhParamLike.Yfbz_code && "" != jc_kswhParamLike.Yfbz_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YFBZ_CODE LIKE '%'||:yfbz_code||'%' ");
                    OracleParameter pYfbz_code = new OracleParameter(":yfbz_code", OracleDbType.NVarchar2);
                    pYfbz_code.Direction = ParameterDirection.Input;
                    pYfbz_code.Value = jc_kswhParamLike.Yfbz_code;
                    sqlparams.Add(pYfbz_code);
                }
                
                if (null != jc_kswhParamLike.Yjbz_code && "" != jc_kswhParamLike.Yjbz_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YJBZ_CODE LIKE '%'||:yjbz_code||'%' ");
                    OracleParameter pYjbz_code = new OracleParameter(":yjbz_code", OracleDbType.NVarchar2);
                    pYjbz_code.Direction = ParameterDirection.Input;
                    pYjbz_code.Value = jc_kswhParamLike.Yjbz_code;
                    sqlparams.Add(pYjbz_code);
                }
                
                if (null != jc_kswhParamLike.Ssbz_code && "" != jc_kswhParamLike.Ssbz_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.SSBZ_CODE LIKE '%'||:ssbz_code||'%' ");
                    OracleParameter pSsbz_code = new OracleParameter(":ssbz_code", OracleDbType.NVarchar2);
                    pSsbz_code.Direction = ParameterDirection.Input;
                    pSsbz_code.Value = jc_kswhParamLike.Ssbz_code;
                    sqlparams.Add(pSsbz_code);
                }
                
                if (null != jc_kswhParamLike.Zfbz && "" != jc_kswhParamLike.Zfbz)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.ZFBZ LIKE '%'||:zfbz||'%' ");
                    OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                    pZfbz.Direction = ParameterDirection.Input;
                    pZfbz.Value = jc_kswhParamLike.Zfbz;
                    sqlparams.Add(pZfbz);
                }
                
            }
this.b_isWhere = false;return Int32.Parse(OracleHelper.ExecuteScalar(sql.ToString(),sqlparams.ToArray()).ToString());
        }


        /// <summary>
        /// 通用的保存方法，根据用户传入的参数，有ID为修改，没有ID为新增(手动生成OracleConnection对象，此方法用于事务，使用事务必须使用同一个OracleConnection对象)
        /// </summary>
        /// <param name="jc_kswhParam"></param>
        /// <returns></returns>
        public bool save(Jc_kswh jc_kswhParam,OracleConnection con)
        {
            if ("" != jc_kswhParam.Id && null != jc_kswhParam.Id)
            {
                //修改
                return this.updateById(jc_kswhParam,con);
            }
            else
            {
                //新增
                return this.insert(jc_kswhParam,con);
            }
        }

        /// <summary>
        /// 把dataset中的一行转换为model
        /// </summary>
        /// <param name="row"></param>
        /// <returns></returns>
        private Jc_kswh dataSetToModel(DataRow row)
        {
            Jc_kswh jc_kswhParam = new Jc_kswh();
            jc_kswhParam.Id = Convert.ToString(row["ID"]).Trim(); 
            jc_kswhParam.Ksbh = Convert.ToString(row["KSBH"]).Trim(); 
            jc_kswhParam.Ksmc = Convert.ToString(row["KSMC"]).Trim(); 
            jc_kswhParam.Mzbz_code = Convert.ToString(row["MZBZ_CODE"]).Trim(); 
            jc_kswhParam.Zybz_code = Convert.ToString(row["ZYBZ_CODE"]).Trim(); 
            jc_kswhParam.Ykbz_code = Convert.ToString(row["YKBZ_CODE"]).Trim(); 
            jc_kswhParam.Yfbz_code = Convert.ToString(row["YFBZ_CODE"]).Trim(); 
            jc_kswhParam.Yjbz_code = Convert.ToString(row["YJBZ_CODE"]).Trim(); 
            jc_kswhParam.Ssbz_code = Convert.ToString(row["SSBZ_CODE"]).Trim(); 
            jc_kswhParam.Zfbz = Convert.ToString(row["ZFBZ"]).Trim(); 
            
            return jc_kswhParam;
        }

       
        
        //*******************在此以后添加新的方法start
        #region DAL层的implement,实现，start

        /// <summary>
        /// 把dataset中的一行转换为model, 包括相关联的外键对象
        /// </summary>
        /// <param name="row"></param>
        /// <returns></returns>
        private Jc_kswh dataSetContactObjectsToModel(DataRow row)
        {
            Jc_kswh jc_kswhParam = this.dataSetToModel(row);

            //添加代码类别实体对象,门诊标志（与代码表关联）对象
            Jc_code mzbzCode = new Jc_code();
            mzbzCode.Id = Convert.ToString(row["MZBZ_CODE_ID"]).Trim();
            mzbzCode.Name = Convert.ToString(row["MZBZ_CODE_NAME"]).Trim();
            mzbzCode.Value = Convert.ToString(row["MZBZ_CODE_VALUE"]).Trim();
            mzbzCode.Fk_code_type = Convert.ToString(row["MZBZ_CODE_FKCODETYPE"]).Trim();
            mzbzCode.Zfbz = Convert.ToString(row["MZBZ_CODE_ZFBZ"]).Trim();
            mzbzCode.Remark = Convert.ToString(row["MZBZ_CODE_REMARK"]).Trim();
            jc_kswhParam.MzbzCode = mzbzCode;

            //添加代码类别实体对象,住院标志（与代码表关联）对象
            Jc_code zybzCode = new Jc_code();
            zybzCode.Id = Convert.ToString(row["ZYBZ_CODE_ID"]).Trim();
            zybzCode.Name = Convert.ToString(row["ZYBZ_CODE_NAME"]).Trim();
            zybzCode.Value = Convert.ToString(row["ZYBZ_CODE_VALUE"]).Trim();
            zybzCode.Fk_code_type = Convert.ToString(row["ZYBZ_CODE_FKCODETYPE"]).Trim();
            zybzCode.Zfbz = Convert.ToString(row["ZYBZ_CODE_ZFBZ"]).Trim();
            zybzCode.Remark = Convert.ToString(row["ZYBZ_CODE_REMARK"]).Trim();
            jc_kswhParam.ZybzCode = zybzCode;

            //添加代码类别实体对象,药库标志（与代码表关联）对象
            Jc_code ykbzCode = new Jc_code();
            ykbzCode.Id = Convert.ToString(row["YKBZ_CODE_ID"]).Trim();
            ykbzCode.Name = Convert.ToString(row["YKBZ_CODE_NAME"]).Trim();
            ykbzCode.Value = Convert.ToString(row["YKBZ_CODE_VALUE"]).Trim();
            ykbzCode.Fk_code_type = Convert.ToString(row["YKBZ_CODE_FKCODETYPE"]).Trim();
            ykbzCode.Zfbz = Convert.ToString(row["YKBZ_CODE_ZFBZ"]).Trim();
            ykbzCode.Remark = Convert.ToString(row["YKBZ_CODE_REMARK"]).Trim();
            jc_kswhParam.YkbzCode = ykbzCode;

            //添加代码类别实体对象,药房标志（与代码表关联）对象
            Jc_code yfbzCode = new Jc_code();
            yfbzCode.Id = Convert.ToString(row["YFBZ_CODE_ID"]).Trim();
            yfbzCode.Name = Convert.ToString(row["YFBZ_CODE_NAME"]).Trim();
            yfbzCode.Value = Convert.ToString(row["YFBZ_CODE_VALUE"]).Trim();
            yfbzCode.Fk_code_type = Convert.ToString(row["YFBZ_CODE_FKCODETYPE"]).Trim();
            yfbzCode.Zfbz = Convert.ToString(row["YFBZ_CODE_ZFBZ"]).Trim();
            yfbzCode.Remark = Convert.ToString(row["YFBZ_CODE_REMARK"]).Trim();
            jc_kswhParam.YfbzCode = yfbzCode;

            //添加代码类别实体对象,医技标志（与代码表关联）对象
            Jc_code yjbzCode = new Jc_code();
            yjbzCode.Id = Convert.ToString(row["YJBZ_CODE_ID"]).Trim();
            yjbzCode.Name = Convert.ToString(row["YJBZ_CODE_NAME"]).Trim();
            yjbzCode.Value = Convert.ToString(row["YJBZ_CODE_VALUE"]).Trim();
            yjbzCode.Fk_code_type = Convert.ToString(row["YJBZ_CODE_FKCODETYPE"]).Trim();
            yjbzCode.Zfbz = Convert.ToString(row["YJBZ_CODE_ZFBZ"]).Trim();
            yjbzCode.Remark = Convert.ToString(row["YJBZ_CODE_REMARK"]).Trim();
            jc_kswhParam.YjbzCode = yjbzCode;

            //添加代码类别实体对象,手术标志（与代码表关联）对象
            Jc_code ssbzCode = new Jc_code();
            ssbzCode.Id = Convert.ToString(row["SSBZ_CODE_ID"]).Trim();
            ssbzCode.Name = Convert.ToString(row["SSBZ_CODE_NAME"]).Trim();
            ssbzCode.Value = Convert.ToString(row["SSBZ_CODE_VALUE"]).Trim();
            ssbzCode.Fk_code_type = Convert.ToString(row["SSBZ_CODE_FKCODETYPE"]).Trim();
            ssbzCode.Zfbz = Convert.ToString(row["SSBZ_CODE_ZFBZ"]).Trim();
            ssbzCode.Remark = Convert.ToString(row["SSBZ_CODE_REMARK"]).Trim();
            jc_kswhParam.SsbzCode = ssbzCode;

            return jc_kswhParam;
        }



        /// <summary>
        /// 查找指定ID的用户,得到相关联的外键对象的方法
        /// </summary>
        /// <remarks>如果id为null、id重复、id未找到就抛异常</remarks>
        /// <returns>Jc_kswh</returns>
        public Jc_kswh findContactObjectsById(string id)
        {
            if ("" == id || null == id)
            {
                throw new Exception("主键ID不能为空，请赋值");
            }
            StringBuilder sql = new StringBuilder("SELECT A.* ");
            //新建方法findContactObjectsById，在此加入多表连接要显示的项start
            //sql.Append(",B.字段一,B.字段二,B.字段三");

            sql.Append(@"
            ,TT_MZBZ_CODE.ID AS MZBZ_CODE_ID,TT_MZBZ_CODE.NAME AS MZBZ_CODE_NAME,TT_MZBZ_CODE.VALUE AS MZBZ_CODE_VALUE,TT_MZBZ_CODE.FK_CODE_TYPE AS MZBZ_CODE_FKCODETYPE,TT_MZBZ_CODE.ZFBZ AS MZBZ_CODE_ZFBZ,TT_MZBZ_CODE.REMARK AS MZBZ_CODE_REMARK
            ");

            sql.Append(@"
            ,TT_ZYBZ_CODE.ID AS ZYBZ_CODE_ID,TT_ZYBZ_CODE.NAME AS ZYBZ_CODE_NAME,TT_ZYBZ_CODE.VALUE AS ZYBZ_CODE_VALUE,TT_ZYBZ_CODE.FK_CODE_TYPE AS ZYBZ_CODE_FKCODETYPE,TT_ZYBZ_CODE.ZFBZ AS ZYBZ_CODE_ZFBZ,TT_ZYBZ_CODE.REMARK AS ZYBZ_CODE_REMARK
            ");

            sql.Append(@"
            ,TT_YKBZ_CODE.ID AS YKBZ_CODE_ID,TT_YKBZ_CODE.NAME AS YKBZ_CODE_NAME,TT_YKBZ_CODE.VALUE AS YKBZ_CODE_VALUE,TT_YKBZ_CODE.FK_CODE_TYPE AS YKBZ_CODE_FKCODETYPE,TT_YKBZ_CODE.ZFBZ AS YKBZ_CODE_ZFBZ,TT_YKBZ_CODE.REMARK AS YKBZ_CODE_REMARK
            ");

            sql.Append(@"
            ,TT_YFBZ_CODE.ID AS YFBZ_CODE_ID,TT_YFBZ_CODE.NAME AS YFBZ_CODE_NAME,TT_YFBZ_CODE.VALUE AS YFBZ_CODE_VALUE,TT_YFBZ_CODE.FK_CODE_TYPE AS YFBZ_CODE_FKCODETYPE,TT_YFBZ_CODE.ZFBZ AS YFBZ_CODE_ZFBZ,TT_YFBZ_CODE.REMARK AS YFBZ_CODE_REMARK
            ");

            sql.Append(@"
            ,TT_YJBZ_CODE.ID AS YJBZ_CODE_ID,TT_YJBZ_CODE.NAME AS YJBZ_CODE_NAME,TT_YJBZ_CODE.VALUE AS YJBZ_CODE_VALUE,TT_YJBZ_CODE.FK_CODE_TYPE AS YJBZ_CODE_FKCODETYPE,TT_YJBZ_CODE.ZFBZ AS YJBZ_CODE_ZFBZ,TT_YJBZ_CODE.REMARK AS YJBZ_CODE_REMARK
            ");

            sql.Append(@"
            ,TT_SSBZ_CODE.ID AS SSBZ_CODE_ID,TT_SSBZ_CODE.NAME AS SSBZ_CODE_NAME,TT_SSBZ_CODE.VALUE AS SSBZ_CODE_VALUE,TT_SSBZ_CODE.FK_CODE_TYPE AS SSBZ_CODE_FKCODETYPE,TT_SSBZ_CODE.ZFBZ AS SSBZ_CODE_ZFBZ,TT_SSBZ_CODE.REMARK AS SSBZ_CODE_REMARK
            ");

            //新建方法，在此加入多表连接要显示的项end
            sql.Append(" FROM JC_KSWH A ");
            //新建一个方法，在此加入多表连接的语句start
            //sql.Append("LEFT JOIN 外键表名 B ON A.外键=B.ID");

            sql.Append(@" 
                        LEFT JOIN 
                        (SELECT X.* FROM JC_CODE X WHERE X.FK_CODE_TYPE IN (SELECT Y.ID FROM JC_CODE_TYPE Y WHERE Y.VALUE='" + Model.Common.CommonCode.代码类型值.基础_勾叉 + @"')) TT_MZBZ_CODE
                        ON A.MZBZ_CODE = TT_MZBZ_CODE.VALUE
            ");

            sql.Append(@" 
                        LEFT JOIN 
                        (SELECT X.* FROM JC_CODE X WHERE X.FK_CODE_TYPE IN (SELECT Y.ID FROM JC_CODE_TYPE Y WHERE Y.VALUE='" + Model.Common.CommonCode.代码类型值.基础_勾叉 + @"')) TT_ZYBZ_CODE
                        ON A.ZYBZ_CODE = TT_ZYBZ_CODE.VALUE
            ");

            sql.Append(@" 
                        LEFT JOIN 
                        (SELECT X.* FROM JC_CODE X WHERE X.FK_CODE_TYPE IN (SELECT Y.ID FROM JC_CODE_TYPE Y WHERE Y.VALUE='" + Model.Common.CommonCode.代码类型值.基础_勾叉 + @"')) TT_YKBZ_CODE
                        ON A.YKBZ_CODE = TT_YKBZ_CODE.VALUE
            ");

            sql.Append(@" 
                        LEFT JOIN 
                        (SELECT X.* FROM JC_CODE X WHERE X.FK_CODE_TYPE IN (SELECT Y.ID FROM JC_CODE_TYPE Y WHERE Y.VALUE='" + Model.Common.CommonCode.代码类型值.基础_勾叉 + @"')) TT_YFBZ_CODE
                        ON A.YFBZ_CODE = TT_YFBZ_CODE.VALUE
            ");

            sql.Append(@" 
                        LEFT JOIN 
                        (SELECT X.* FROM JC_CODE X WHERE X.FK_CODE_TYPE IN (SELECT Y.ID FROM JC_CODE_TYPE Y WHERE Y.VALUE='" + Model.Common.CommonCode.代码类型值.基础_勾叉 + @"')) TT_YJBZ_CODE
                        ON A.YJBZ_CODE = TT_YJBZ_CODE.VALUE
            ");

            sql.Append(@" 
                        LEFT JOIN 
                        (SELECT X.* FROM JC_CODE X WHERE X.FK_CODE_TYPE IN (SELECT Y.ID FROM JC_CODE_TYPE Y WHERE Y.VALUE='" + Model.Common.CommonCode.代码类型值.基础_勾叉 + @"')) TT_SSBZ_CODE
                        ON A.SSBZ_CODE = TT_SSBZ_CODE.VALUE
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
        /// <param name="jc_kswhParam"></param>
        /// <param name="page">分页对象</param>
        ///<param name="jc_kswhParamLike">模糊查询参数</param>
        ///<param name="sortList">排序参数对象的集合</param>
        /// <returns>满足条件的所有Jc_kswh对象集合list</returns>
        public List<object> findContactObjects(Jc_kswh jc_kswhParam, Model.Common.PageInfo page, Jc_kswh jc_kswhParamLike, List<SortInfo> sortList)
        {
            //如果没有传查询条件参数，就new一个空的Jc_kswh对象，标示查询所有数据
            if (null == jc_kswhParam)
            {
                jc_kswhParam = new Jc_kswh();
            }
            if (null != jc_kswhParam.Id && "" != jc_kswhParam.Id)
            {
                throw new Exception("此方法不允许指定参数ID，如果需要根据ID查询数据，请调用findById方法；错误出自：find");
            }

            List<Jc_kswh> jc_kswhParamList = new List<Jc_kswh>();//接收查询出的Jc_kswh对象集合
            List<OracleParameter> sqlparams = new List<OracleParameter>();//保存参数的集合
            StringBuilder sql = new StringBuilder("SELECT A.* ");
            //新建方法findAllContactObjects(Jc_kswh jc_kswhParam, Model.Common.PageInfo page)，在此加入多表连接要显示的项start
            //sql.Append(",B.字段一,B.字段二,B.字段三");

            sql.Append(@"
            ,TT_MZBZ_CODE.ID AS MZBZ_CODE_ID,TT_MZBZ_CODE.NAME AS MZBZ_CODE_NAME,TT_MZBZ_CODE.VALUE AS MZBZ_CODE_VALUE,TT_MZBZ_CODE.FK_CODE_TYPE AS MZBZ_CODE_FKCODETYPE,TT_MZBZ_CODE.ZFBZ AS MZBZ_CODE_ZFBZ,TT_MZBZ_CODE.REMARK AS MZBZ_CODE_REMARK
            ");

            sql.Append(@"
            ,TT_ZYBZ_CODE.ID AS ZYBZ_CODE_ID,TT_ZYBZ_CODE.NAME AS ZYBZ_CODE_NAME,TT_ZYBZ_CODE.VALUE AS ZYBZ_CODE_VALUE,TT_ZYBZ_CODE.FK_CODE_TYPE AS ZYBZ_CODE_FKCODETYPE,TT_ZYBZ_CODE.ZFBZ AS ZYBZ_CODE_ZFBZ,TT_ZYBZ_CODE.REMARK AS ZYBZ_CODE_REMARK
            ");

            sql.Append(@"
            ,TT_YKBZ_CODE.ID AS YKBZ_CODE_ID,TT_YKBZ_CODE.NAME AS YKBZ_CODE_NAME,TT_YKBZ_CODE.VALUE AS YKBZ_CODE_VALUE,TT_YKBZ_CODE.FK_CODE_TYPE AS YKBZ_CODE_FKCODETYPE,TT_YKBZ_CODE.ZFBZ AS YKBZ_CODE_ZFBZ,TT_YKBZ_CODE.REMARK AS YKBZ_CODE_REMARK
            ");

            sql.Append(@"
            ,TT_YFBZ_CODE.ID AS YFBZ_CODE_ID,TT_YFBZ_CODE.NAME AS YFBZ_CODE_NAME,TT_YFBZ_CODE.VALUE AS YFBZ_CODE_VALUE,TT_YFBZ_CODE.FK_CODE_TYPE AS YFBZ_CODE_FKCODETYPE,TT_YFBZ_CODE.ZFBZ AS YFBZ_CODE_ZFBZ,TT_YFBZ_CODE.REMARK AS YFBZ_CODE_REMARK
            ");

            sql.Append(@"
            ,TT_YJBZ_CODE.ID AS YJBZ_CODE_ID,TT_YJBZ_CODE.NAME AS YJBZ_CODE_NAME,TT_YJBZ_CODE.VALUE AS YJBZ_CODE_VALUE,TT_YJBZ_CODE.FK_CODE_TYPE AS YJBZ_CODE_FKCODETYPE,TT_YJBZ_CODE.ZFBZ AS YJBZ_CODE_ZFBZ,TT_YJBZ_CODE.REMARK AS YJBZ_CODE_REMARK
            ");

            sql.Append(@"
            ,TT_SSBZ_CODE.ID AS SSBZ_CODE_ID,TT_SSBZ_CODE.NAME AS SSBZ_CODE_NAME,TT_SSBZ_CODE.VALUE AS SSBZ_CODE_VALUE,TT_SSBZ_CODE.FK_CODE_TYPE AS SSBZ_CODE_FKCODETYPE,TT_SSBZ_CODE.ZFBZ AS SSBZ_CODE_ZFBZ,TT_SSBZ_CODE.REMARK AS SSBZ_CODE_REMARK
            ");

            //新建方法，在此加入多表连接要显示的项end
            sql.Append(" FROM JC_KSWH A ");
            //新建一个方法，在此加入多表连接的语句start
            ////sql.Append(" LEFT JOIN 表名 B ON A.外键=B.ID");

            sql.Append(@" 
                        LEFT JOIN 
                        (SELECT X.* FROM JC_CODE X WHERE X.FK_CODE_TYPE IN (SELECT Y.ID FROM JC_CODE_TYPE Y WHERE Y.VALUE='" + Model.Common.CommonCode.代码类型值.基础_勾叉 + @"')) TT_MZBZ_CODE
                        ON A.MZBZ_CODE = TT_MZBZ_CODE.VALUE
            ");

            sql.Append(@" 
                        LEFT JOIN 
                        (SELECT X.* FROM JC_CODE X WHERE X.FK_CODE_TYPE IN (SELECT Y.ID FROM JC_CODE_TYPE Y WHERE Y.VALUE='" + Model.Common.CommonCode.代码类型值.基础_勾叉 + @"')) TT_ZYBZ_CODE
                        ON A.ZYBZ_CODE = TT_ZYBZ_CODE.VALUE
            ");

            sql.Append(@" 
                        LEFT JOIN 
                        (SELECT X.* FROM JC_CODE X WHERE X.FK_CODE_TYPE IN (SELECT Y.ID FROM JC_CODE_TYPE Y WHERE Y.VALUE='" + Model.Common.CommonCode.代码类型值.基础_勾叉 + @"')) TT_YKBZ_CODE
                        ON A.YKBZ_CODE = TT_YKBZ_CODE.VALUE
            ");

            sql.Append(@" 
                        LEFT JOIN 
                        (SELECT X.* FROM JC_CODE X WHERE X.FK_CODE_TYPE IN (SELECT Y.ID FROM JC_CODE_TYPE Y WHERE Y.VALUE='" + Model.Common.CommonCode.代码类型值.基础_勾叉 + @"')) TT_YFBZ_CODE
                        ON A.YFBZ_CODE = TT_YFBZ_CODE.VALUE
            ");

            sql.Append(@" 
                        LEFT JOIN 
                        (SELECT X.* FROM JC_CODE X WHERE X.FK_CODE_TYPE IN (SELECT Y.ID FROM JC_CODE_TYPE Y WHERE Y.VALUE='" + Model.Common.CommonCode.代码类型值.基础_勾叉 + @"')) TT_YJBZ_CODE
                        ON A.YJBZ_CODE = TT_YJBZ_CODE.VALUE
            ");

            sql.Append(@" 
                        LEFT JOIN 
                        (SELECT X.* FROM JC_CODE X WHERE X.FK_CODE_TYPE IN (SELECT Y.ID FROM JC_CODE_TYPE Y WHERE Y.VALUE='" + Model.Common.CommonCode.代码类型值.基础_勾叉 + @"')) TT_SSBZ_CODE
                        ON A.SSBZ_CODE = TT_SSBZ_CODE.VALUE
            ");

            //新建一个方法，在此加入多表连接的语句end


            if (null != jc_kswhParam.Ksbh && "" != jc_kswhParam.Ksbh)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.KSBH=:ksbh ");
                OracleParameter pKsbh = new OracleParameter(":ksbh", OracleDbType.NVarchar2);
                pKsbh.Value = jc_kswhParam.Ksbh;
                sqlparams.Add(pKsbh);
            }

            if (null != jc_kswhParam.Ksmc && "" != jc_kswhParam.Ksmc)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.KSMC=:ksmc ");
                OracleParameter pKsmc = new OracleParameter(":ksmc", OracleDbType.NVarchar2);
                pKsmc.Value = jc_kswhParam.Ksmc;
                sqlparams.Add(pKsmc);
            }

            if (null != jc_kswhParam.Mzbz_code && "" != jc_kswhParam.Mzbz_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.MZBZ_CODE=:mzbz_code ");
                OracleParameter pMzbz_code = new OracleParameter(":mzbz_code", OracleDbType.NVarchar2);
                pMzbz_code.Value = jc_kswhParam.Mzbz_code;
                sqlparams.Add(pMzbz_code);
            }

            if (null != jc_kswhParam.Zybz_code && "" != jc_kswhParam.Zybz_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.ZYBZ_CODE=:zybz_code ");
                OracleParameter pZybz_code = new OracleParameter(":zybz_code", OracleDbType.NVarchar2);
                pZybz_code.Value = jc_kswhParam.Zybz_code;
                sqlparams.Add(pZybz_code);
            }

            if (null != jc_kswhParam.Ykbz_code && "" != jc_kswhParam.Ykbz_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.YKBZ_CODE=:ykbz_code ");
                OracleParameter pYkbz_code = new OracleParameter(":ykbz_code", OracleDbType.NVarchar2);
                pYkbz_code.Value = jc_kswhParam.Ykbz_code;
                sqlparams.Add(pYkbz_code);
            }

            if (null != jc_kswhParam.Yfbz_code && "" != jc_kswhParam.Yfbz_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.YFBZ_CODE=:yfbz_code ");
                OracleParameter pYfbz_code = new OracleParameter(":yfbz_code", OracleDbType.NVarchar2);
                pYfbz_code.Value = jc_kswhParam.Yfbz_code;
                sqlparams.Add(pYfbz_code);
            }

            if (null != jc_kswhParam.Yjbz_code && "" != jc_kswhParam.Yjbz_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.YJBZ_CODE=:yjbz_code ");
                OracleParameter pYjbz_code = new OracleParameter(":yjbz_code", OracleDbType.NVarchar2);
                pYjbz_code.Value = jc_kswhParam.Yjbz_code;
                sqlparams.Add(pYjbz_code);
            }

            if (null != jc_kswhParam.Ssbz_code && "" != jc_kswhParam.Ssbz_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.SSBZ_CODE=:ssbz_code ");
                OracleParameter pSsbz_code = new OracleParameter(":ssbz_code", OracleDbType.NVarchar2);
                pSsbz_code.Value = jc_kswhParam.Ssbz_code;
                sqlparams.Add(pSsbz_code);
            }

            if (null != jc_kswhParam.Zfbz && "" != jc_kswhParam.Zfbz)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.ZFBZ=:zfbz ");
                OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                pZfbz.Value = jc_kswhParam.Zfbz;
                sqlparams.Add(pZfbz);
            }

            if (jc_kswhParamLike != null)
            {

                if (null != jc_kswhParamLike.Ksbh && "" != jc_kswhParamLike.Ksbh)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.KSBH LIKE '%'||:ksbh||'%' ");
                    OracleParameter pKsbh = new OracleParameter(":ksbh", OracleDbType.NVarchar2);
                    pKsbh.Direction = ParameterDirection.Input;
                    pKsbh.Value = jc_kswhParamLike.Ksbh;
                    sqlparams.Add(pKsbh);
                }

                if (null != jc_kswhParamLike.Ksmc && "" != jc_kswhParamLike.Ksmc)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.KSMC LIKE '%'||:ksmc||'%' ");
                    OracleParameter pKsmc = new OracleParameter(":ksmc", OracleDbType.NVarchar2);
                    pKsmc.Direction = ParameterDirection.Input;
                    pKsmc.Value = jc_kswhParamLike.Ksmc;
                    sqlparams.Add(pKsmc);
                }

                if (null != jc_kswhParamLike.Mzbz_code && "" != jc_kswhParamLike.Mzbz_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.MZBZ_CODE LIKE '%'||:mzbz_code||'%' ");
                    OracleParameter pMzbz_code = new OracleParameter(":mzbz_code", OracleDbType.NVarchar2);
                    pMzbz_code.Direction = ParameterDirection.Input;
                    pMzbz_code.Value = jc_kswhParamLike.Mzbz_code;
                    sqlparams.Add(pMzbz_code);
                }

                if (null != jc_kswhParamLike.Zybz_code && "" != jc_kswhParamLike.Zybz_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.ZYBZ_CODE LIKE '%'||:zybz_code||'%' ");
                    OracleParameter pZybz_code = new OracleParameter(":zybz_code", OracleDbType.NVarchar2);
                    pZybz_code.Direction = ParameterDirection.Input;
                    pZybz_code.Value = jc_kswhParamLike.Zybz_code;
                    sqlparams.Add(pZybz_code);
                }

                if (null != jc_kswhParamLike.Ykbz_code && "" != jc_kswhParamLike.Ykbz_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YKBZ_CODE LIKE '%'||:ykbz_code||'%' ");
                    OracleParameter pYkbz_code = new OracleParameter(":ykbz_code", OracleDbType.NVarchar2);
                    pYkbz_code.Direction = ParameterDirection.Input;
                    pYkbz_code.Value = jc_kswhParamLike.Ykbz_code;
                    sqlparams.Add(pYkbz_code);
                }

                if (null != jc_kswhParamLike.Yfbz_code && "" != jc_kswhParamLike.Yfbz_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YFBZ_CODE LIKE '%'||:yfbz_code||'%' ");
                    OracleParameter pYfbz_code = new OracleParameter(":yfbz_code", OracleDbType.NVarchar2);
                    pYfbz_code.Direction = ParameterDirection.Input;
                    pYfbz_code.Value = jc_kswhParamLike.Yfbz_code;
                    sqlparams.Add(pYfbz_code);
                }

                if (null != jc_kswhParamLike.Yjbz_code && "" != jc_kswhParamLike.Yjbz_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YJBZ_CODE LIKE '%'||:yjbz_code||'%' ");
                    OracleParameter pYjbz_code = new OracleParameter(":yjbz_code", OracleDbType.NVarchar2);
                    pYjbz_code.Direction = ParameterDirection.Input;
                    pYjbz_code.Value = jc_kswhParamLike.Yjbz_code;
                    sqlparams.Add(pYjbz_code);
                }

                if (null != jc_kswhParamLike.Ssbz_code && "" != jc_kswhParamLike.Ssbz_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.SSBZ_CODE LIKE '%'||:ssbz_code||'%' ");
                    OracleParameter pSsbz_code = new OracleParameter(":ssbz_code", OracleDbType.NVarchar2);
                    pSsbz_code.Direction = ParameterDirection.Input;
                    pSsbz_code.Value = jc_kswhParamLike.Ssbz_code;
                    sqlparams.Add(pSsbz_code);
                }

                if (null != jc_kswhParamLike.Zfbz && "" != jc_kswhParamLike.Zfbz)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.ZFBZ LIKE '%'||:zfbz||'%' ");
                    OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                    pZfbz.Direction = ParameterDirection.Input;
                    pZfbz.Value = jc_kswhParamLike.Zfbz;
                    sqlparams.Add(pZfbz);
                }

            }

            if (jc_kswhParamLike != null)
            {

            }

            this.b_isWhere = false;
            //排序
            this.addSort(sql, sortList);
            //*******分页start1*********如果分页对象为空，则全部数据查出，如果不为空
            List<object> returnList = new List<object>();//返回的List,索引0为List<Jc_kswh>对象,索引1为Model.Common.PageInfo分页信息对象
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
            //把每一行数据转换为一个对象放入List<Jc_kswh>中
            for (int i = 0; i < rows.Count; i++)
            {
                DataRow row = rows[i];
                jc_kswhParamList.Add(this.dataSetContactObjectsToModel(row));
                //jc_kswhParamList.Add(this.dataSetToModel(row));
            }

            //*******分页start2*********如果没有传入分页对象，则新建一个分页对象当做返回值
            if (null == page)
            {
                page = new Model.Common.PageInfo();
                page.AllCount = rows.Count;
            }
            returnList.Add(jc_kswhParamList);//把List<Jc_kswh>放入List<object>中第一个
            returnList.Add(page);//把page对象放入List<object>中第二个
            //*******分页end2*********
            return returnList;
        }
        #endregion DAL层的implement,实现，end

        


        //*******************在此以后添加新的方法end
        
    }
}


