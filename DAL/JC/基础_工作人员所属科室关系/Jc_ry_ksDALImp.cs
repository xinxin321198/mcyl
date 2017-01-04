

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

namespace DAL.JC.基础_工作人员所属科室关系
{
    /// <summary>
    ///数据库访问层的Jc_ry_ks实现类
    ///此类由代码生成器生成
    ///表名：JC_RY_KS
    ///生成日期：2015-12-02 15:50:44
    /// 

    ///作者：罗新鑫
    ///联系电话：15087010221
    ///联系邮箱：362527240@qq.com
        
    /// </summary>
    public class Jc_ry_ksDALImp :Base.BasDAL,Jc_ry_ksDAL
    {

        /// <summary>
        /// 插入一条数据（如果需要供事务使用就传入OracleConnection对象，如果不供就传入null，方法自动生成OracleConnection对象）
        /// 主键为null时，自动生成主键guid，一般不直接调用此方法，请调用save方法进行单条数据的插入和修改       
        /// </summary>
        /// <param name="jc_ry_ksParam">要插入的jc_ry_ksParam对象</param>
        /// <param name="con">Oracle连接对象（为null时自动生成）</param>
        /// <returns>是否添加成功（影响的行数为1时成功）</returns>
        public bool insert(Jc_ry_ks jc_ry_ksParam,OracleConnection con)
        {
            if (""==jc_ry_ksParam.Id||null==jc_ry_ksParam.Id)
            {
                jc_ry_ksParam.Id = Model.Common.GUIDHelper.getGuid();
            }
            List<OracleParameter> sqlparams = new List<OracleParameter>();
            
            StringBuilder sql = new StringBuilder("INSERT INTO JC_RY_KS(id,fk_renyuan_id,fk_keshi_id,zfbz) VALUES(:id,:fk_renyuan_id,:fk_keshi_id,:zfbz)");
            
            OracleParameter pId = new OracleParameter(":id", OracleDbType.Varchar2);
            pId.Direction = ParameterDirection.Input;
            pId.Value = jc_ry_ksParam.Id;
            sqlparams.Add(pId);
            OracleParameter pFk_renyuan_id = new OracleParameter(":fk_renyuan_id", OracleDbType.Varchar2);
            pFk_renyuan_id.Direction = ParameterDirection.Input;
            pFk_renyuan_id.Value = jc_ry_ksParam.Fk_renyuan_id;
            sqlparams.Add(pFk_renyuan_id);
            OracleParameter pFk_keshi_id = new OracleParameter(":fk_keshi_id", OracleDbType.Varchar2);
            pFk_keshi_id.Direction = ParameterDirection.Input;
            pFk_keshi_id.Value = jc_ry_ksParam.Fk_keshi_id;
            sqlparams.Add(pFk_keshi_id);
            OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
            pZfbz.Direction = ParameterDirection.Input;
            pZfbz.Value = jc_ry_ksParam.Zfbz;
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
        /// <param name="jc_ry_ksParamList">要插入的jc_ry_ksParam对象的集合</param>
        /// <param name="con">Oracle连接对象（为null时自动生成）</param>
        /// <returns>是否添加成功（影响的行数等于保存的对象的数量时成功）</returns>
        public bool inertBatch(List<Jc_ry_ks> jc_ry_ksParamList, OracleConnection con)
        {
            if (jc_ry_ksParamList.Count == 0)
            {
                return true;
            }
            List<string> idList = new List<string>();

            List<string> fk_renyuan_idList = new List<string>();

            List<string> fk_keshi_idList = new List<string>();

            List<string> zfbzList = new List<string>();

            for (int i = 0; i < jc_ry_ksParamList.Count; i++)
            {
                Jc_ry_ks jc_ry_ksParam = jc_ry_ksParamList[i];
                if ("" == jc_ry_ksParam.Id || null == jc_ry_ksParam.Id)
                {
                    jc_ry_ksParam.Id = Model.Common.GUIDHelper.getGuid();
                }

            idList.Add(jc_ry_ksParam.Id);

            fk_renyuan_idList.Add(jc_ry_ksParam.Fk_renyuan_id);

            fk_keshi_idList.Add(jc_ry_ksParam.Fk_keshi_id);

            zfbzList.Add(jc_ry_ksParam.Zfbz);

            }

            List<OracleParameter> sqlparams = new List<OracleParameter>();

            StringBuilder sql = new StringBuilder("INSERT INTO JC_RY_KS(id,fk_renyuan_id,fk_keshi_id,zfbz) VALUES(:id,:fk_renyuan_id,:fk_keshi_id,:zfbz)");
            
            OracleParameter pId = new OracleParameter(":id", OracleDbType.Varchar2);
            pId.Direction = ParameterDirection.Input;
            pId.Value = idList.ToArray();
            sqlparams.Add(pId);
            OracleParameter pFk_renyuan_id = new OracleParameter(":fk_renyuan_id", OracleDbType.Varchar2);
            pFk_renyuan_id.Direction = ParameterDirection.Input;
            pFk_renyuan_id.Value = fk_renyuan_idList.ToArray();
            sqlparams.Add(pFk_renyuan_id);
            OracleParameter pFk_keshi_id = new OracleParameter(":fk_keshi_id", OracleDbType.Varchar2);
            pFk_keshi_id.Direction = ParameterDirection.Input;
            pFk_keshi_id.Value = fk_keshi_idList.ToArray();
            sqlparams.Add(pFk_keshi_id);
            OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
            pZfbz.Direction = ParameterDirection.Input;
            pZfbz.Value = zfbzList.ToArray();
            sqlparams.Add(pZfbz);
            bool result = false;
            int flag = -1;
            flag = OracleHelper.ExecuteBatch(sql.ToString(), con, jc_ry_ksParamList.Count, sqlparams.ToArray());
            if (jc_ry_ksParamList.Count == flag)
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
            StringBuilder sql = new StringBuilder("DELETE JC_RY_KS WHERE ID=:id");
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
            StringBuilder sql = new StringBuilder("DELETE JC_RY_KS WHERE ID=:id");
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
        /// <param name="jc_ry_ksParamCondition">删除的条件</param>
        /// <param name="con">Oracle连接对象（为null时自动生成）</param>
        /// <returns>无法确定删除的行数（影响行数大于等于0就算成功）</returns>
        public bool deleteByOtherCondition(Jc_ry_ks jc_ry_ksParamCondition, OracleConnection con)
        {
            if (null!=jc_ry_ksParamCondition.Id&&""!=jc_ry_ksParamCondition.Id)
            {
                throw new Exception("不允许指定参数的ID，如果要根据ID删除数据请调用deleteById或者deleteByIdBatch方法；错误出自：deleteByOtherCondition");
            }
            List<OracleParameter> sqlparams = new List<OracleParameter>();
            StringBuilder sql = new StringBuilder("DELETE JC_RY_KS ");

            if (null != jc_ry_ksParamCondition.Fk_renyuan_id &&  ""!= jc_ry_ksParamCondition.Fk_renyuan_id)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" FK_RENYUAN_ID=:fk_renyuan_id ");
                OracleParameter pFk_renyuan_id = new OracleParameter(":fk_renyuan_id", OracleDbType.Varchar2);
                pFk_renyuan_id.Direction = ParameterDirection.Input;
                pFk_renyuan_id.Value = jc_ry_ksParamCondition.Fk_renyuan_id;
                sqlparams.Add(pFk_renyuan_id);

            }
                        
            if (null != jc_ry_ksParamCondition.Fk_keshi_id &&  ""!= jc_ry_ksParamCondition.Fk_keshi_id)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" FK_KESHI_ID=:fk_keshi_id ");
                OracleParameter pFk_keshi_id = new OracleParameter(":fk_keshi_id", OracleDbType.Varchar2);
                pFk_keshi_id.Direction = ParameterDirection.Input;
                pFk_keshi_id.Value = jc_ry_ksParamCondition.Fk_keshi_id;
                sqlparams.Add(pFk_keshi_id);

            }
                        
            if (null != jc_ry_ksParamCondition.Zfbz &&  ""!= jc_ry_ksParamCondition.Zfbz)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" ZFBZ=:zfbz ");
                OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                pZfbz.Direction = ParameterDirection.Input;
                pZfbz.Value = jc_ry_ksParamCondition.Zfbz;
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
        /// <param name="jc_ry_ksParam"></param>
        /// <returns>影响的行数</returns>
        public bool updateById(Jc_ry_ks jc_ry_ksParam,OracleConnection con)
        {
            if ("" == jc_ry_ksParam.Id || null == jc_ry_ksParam.Id)
            {
                throw new Exception("ID不允许为空，请赋值后调用；错误出自：updateById");
            }
            List<OracleParameter> sqlparams = new List<OracleParameter>();

            StringBuilder sql = new StringBuilder("UPDATE JC_RY_KS SET ");
            if (null != jc_ry_ksParam.Fk_renyuan_id &&  ""!= jc_ry_ksParam.Fk_renyuan_id)
            {
                this.isComma(sql);
                sql.Append(" FK_RENYUAN_ID=:fk_renyuan_id ");
                OracleParameter pFk_renyuan_id = new OracleParameter(":fk_renyuan_id", OracleDbType.Varchar2);
                pFk_renyuan_id.Direction = ParameterDirection.Input;
                pFk_renyuan_id.Value = jc_ry_ksParam.Fk_renyuan_id;
                sqlparams.Add(pFk_renyuan_id);

            }
                        
            if (null != jc_ry_ksParam.Fk_keshi_id &&  ""!= jc_ry_ksParam.Fk_keshi_id)
            {
                this.isComma(sql);
                sql.Append(" FK_KESHI_ID=:fk_keshi_id ");
                OracleParameter pFk_keshi_id = new OracleParameter(":fk_keshi_id", OracleDbType.Varchar2);
                pFk_keshi_id.Direction = ParameterDirection.Input;
                pFk_keshi_id.Value = jc_ry_ksParam.Fk_keshi_id;
                sqlparams.Add(pFk_keshi_id);

            }
                        
            if (null != jc_ry_ksParam.Zfbz &&  ""!= jc_ry_ksParam.Zfbz)
            {
                this.isComma(sql);
                sql.Append(" ZFBZ=:zfbz ");
                OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                pZfbz.Direction = ParameterDirection.Input;
                pZfbz.Value = jc_ry_ksParam.Zfbz;
                sqlparams.Add(pZfbz);

            }
                        
            sql.Append(" WHERE ID=:id ");
            OracleParameter pId = new OracleParameter(":id", OracleDbType.Varchar2);
            pId.Value = jc_ry_ksParam.Id;
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
        /// <param name="jc_ry_ksParamList">要修改的Jc_ry_ks对象集合</param>
        /// <param name="con">Oracle连接对象（为null时自动生成）</param>
        /// <returns>是否删除成功（影响的行数等于要修改的对象数量时成功）</returns>
        public bool updateByIdBatch(List<Jc_ry_ks> jc_ry_ksParamList, OracleConnection con)
        {


            List<string> idList = new List<string>();

            List<string> fk_renyuan_idList = new List<string>();

            List<string> fk_keshi_idList = new List<string>();

            List<string> zfbzList = new List<string>();

            for (int i = 0; i < jc_ry_ksParamList.Count; i++)
            {
                Jc_ry_ks jc_ry_ksParam = jc_ry_ksParamList[i];
                if ("" == jc_ry_ksParam.Id || null == jc_ry_ksParam.Id)
                {
                    throw new Exception("下标为" + i + "的数据，ID不能为空，请赋值后调用；错误出自：updateByIdBatch");
                }

            idList.Add(jc_ry_ksParam.Id);

            fk_renyuan_idList.Add(jc_ry_ksParam.Fk_renyuan_id);

            fk_keshi_idList.Add(jc_ry_ksParam.Fk_keshi_id);

            zfbzList.Add(jc_ry_ksParam.Zfbz);

            }


            
            List<OracleParameter> sqlparams = new List<OracleParameter>();

            StringBuilder sql = new StringBuilder("UPDATE JC_RY_KS SET ");
            this.isComma(sql);
            sql.Append(" FK_RENYUAN_ID=:fk_renyuan_id ");
            OracleParameter pFk_renyuan_id = new OracleParameter(":fk_renyuan_id", OracleDbType.Varchar2);
            pFk_renyuan_id.Direction = ParameterDirection.Input;
            pFk_renyuan_id.Value = fk_renyuan_idList.ToArray();
            sqlparams.Add(pFk_renyuan_id);

            this.isComma(sql);
            sql.Append(" FK_KESHI_ID=:fk_keshi_id ");
            OracleParameter pFk_keshi_id = new OracleParameter(":fk_keshi_id", OracleDbType.Varchar2);
            pFk_keshi_id.Direction = ParameterDirection.Input;
            pFk_keshi_id.Value = fk_keshi_idList.ToArray();
            sqlparams.Add(pFk_keshi_id);

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
            int flag = OracleHelper.ExecuteBatch(sql.ToString(), con,jc_ry_ksParamList.Count, sqlparams.ToArray());
            if (jc_ry_ksParamList.Count == flag)
            {
                result = true;
            }
            return result;
        }

        /// <summary>
        /// 根据更新的条件，更新数据（如果需要供事务使用就传入OracleConnection对象，如果不供就传入null，方法自动生成OracleConnection对象）
        /// 不指定ID，如果要根据ID来更新数据，请使用updateForId方法
        /// </summary>
        /// <param name="jc_ry_ksParamCondition">条件对象</param>
        /// <param name="jc_ry_ksParamUpdate">要更新的数据对象</param>
        /// <param name="con">Oracle连接对象（为null时自动生成）</param>
        /// <returns>影响的行数不确定（不为-1就正确）</returns>
        public bool updateByOtherCondition(Jc_ry_ks jc_ry_ksParamCondition, Jc_ry_ks jc_ry_ksParamUpdate, OracleConnection con)
        {
            if ((null!=jc_ry_ksParamCondition.Id&&"!=jc_ry_ksParamCondition.Id)||(null!=jc_ry_ksParamUpdate.Id&&"!=jc_ry_ksParamUpdate.Id))
            {
                throw new Exception("此方法不允许指定参数的ID，数据库中的ID不允许修改，如需根据ID修改数据，请调用updateById或updateByIdBatch方法；错误出自：updateByOtherCondition");
            }
            List<OracleParameter> sqlparams = new List<OracleParameter>();
            //添加要修改的值
            StringBuilder sql = new StringBuilder("UPDATE JC_RY_KS SET ");
            if (null != jc_ry_ksParamUpdate.Fk_renyuan_id &&  ""!= jc_ry_ksParamUpdate.Fk_renyuan_id)
            {
                this.isComma(sql);
                sql.Append(" FK_RENYUAN_ID=:fk_renyuan_id ");
                OracleParameter pFk_renyuan_id = new OracleParameter(":fk_renyuan_id", OracleDbType.Varchar2);
                pFk_renyuan_id.Direction = ParameterDirection.Input;
                pFk_renyuan_id.Value = jc_ry_ksParamUpdate.Fk_renyuan_id;
                sqlparams.Add(pFk_renyuan_id);

            }
                        
            if (null != jc_ry_ksParamUpdate.Fk_keshi_id &&  ""!= jc_ry_ksParamUpdate.Fk_keshi_id)
            {
                this.isComma(sql);
                sql.Append(" FK_KESHI_ID=:fk_keshi_id ");
                OracleParameter pFk_keshi_id = new OracleParameter(":fk_keshi_id", OracleDbType.Varchar2);
                pFk_keshi_id.Direction = ParameterDirection.Input;
                pFk_keshi_id.Value = jc_ry_ksParamUpdate.Fk_keshi_id;
                sqlparams.Add(pFk_keshi_id);

            }
                        
            if (null != jc_ry_ksParamUpdate.Zfbz &&  ""!= jc_ry_ksParamUpdate.Zfbz)
            {
                this.isComma(sql);
                sql.Append(" ZFBZ=:zfbz ");
                OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                pZfbz.Direction = ParameterDirection.Input;
                pZfbz.Value = jc_ry_ksParamUpdate.Zfbz;
                sqlparams.Add(pZfbz);

            }
                        
            //添加条件的参数
            
            if (null != jc_ry_ksParamCondition.Fk_renyuan_id &&  ""!= jc_ry_ksParamCondition.Fk_renyuan_id)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" FK_RENYUAN_ID=:fk_renyuan_id ");
                OracleParameter pFk_renyuan_id = new OracleParameter(":fk_renyuan_id", OracleDbType.Varchar2);
                pFk_renyuan_id.Direction = ParameterDirection.Input;
                pFk_renyuan_id.Value = jc_ry_ksParamCondition.Fk_renyuan_id;
                sqlparams.Add(pFk_renyuan_id);

            }
                        
            if (null != jc_ry_ksParamCondition.Fk_keshi_id &&  ""!= jc_ry_ksParamCondition.Fk_keshi_id)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" FK_KESHI_ID=:fk_keshi_id ");
                OracleParameter pFk_keshi_id = new OracleParameter(":fk_keshi_id", OracleDbType.Varchar2);
                pFk_keshi_id.Direction = ParameterDirection.Input;
                pFk_keshi_id.Value = jc_ry_ksParamCondition.Fk_keshi_id;
                sqlparams.Add(pFk_keshi_id);

            }
                        
            if (null != jc_ry_ksParamCondition.Zfbz &&  ""!= jc_ry_ksParamCondition.Zfbz)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" ZFBZ=:zfbz ");
                OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                pZfbz.Direction = ParameterDirection.Input;
                pZfbz.Value = jc_ry_ksParamCondition.Zfbz;
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
        /// <returns>Jc_ry_ks</returns>
        public Jc_ry_ks findById(string id)
        {
            if (""==id||null==id)
            {
                throw new Exception("ID不能为空，请赋值后调用；错误出自：findById");
            }
            StringBuilder sql = new StringBuilder("SELECT A.* ");
            //新建方法findContactObjectsById，在此加入多表连接要显示的项start
            //sql.Append(",B.字段一,B.字段二,B.字段三");
            //新建方法，在此加入多表连接要显示的项end
            sql.Append(" FROM JC_RY_KS A ");
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
        /// <param name="jc_ry_ksParam"></param>
        /// <param name="page">分页对象</param>
        ///<param name="jc_ry_ksParamLike">模糊查询参数</param>
        ///<param name="sortList">排序参数对象的集合</param>
        /// <returns>满足条件的所有Jc_ry_ks对象集合list</returns>
        public List<object> find(Jc_ry_ks jc_ry_ksParam, Model.Common.PageInfo page,Jc_ry_ks jc_ry_ksParamLike,List<SortInfo> sortList)
        {

            //如果没有传查询条件参数，就new一个空的Jc_ry_ks对象，标示查询所有数据
            if (null == jc_ry_ksParam)
            {
                jc_ry_ksParam = new Jc_ry_ks();
            }
            if (null!=jc_ry_ksParam.Id&&""!=jc_ry_ksParam.Id)
            {
                throw new Exception("此方法不允许指定参数ID，如果需要根据ID查询数据，请调用findById方法；错误出自：find");
            }
            List<Jc_ry_ks> jc_ry_ksParamList = new List<Jc_ry_ks>();//接收查询出的Jc_ry_ks对象集合
            List<OracleParameter> sqlparams = new List<OracleParameter>();//保存参数的集合
            StringBuilder sql = new StringBuilder("SELECT A.* ");
            //新建方法findContactObjects(Jc_ry_ks jc_ry_ksParam, Model.Common.PageInfo page)，在此加入多表连接要显示的项start
            //sql.Append(",B.字段一,B.字段二,B.字段三");
            //新建方法，在此加入多表连接要显示的项end
            sql.Append(" FROM JC_RY_KS A ");
            //新建一个方法，在此加入多表连接的语句start
            ////sql.Append(" LEFT JOIN 表名 B ON A.外键=B.ID");
            //新建一个方法，在此加入多表连接的语句end
            
            
            if (null != jc_ry_ksParam.Fk_renyuan_id && "" != jc_ry_ksParam.Fk_renyuan_id)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.FK_RENYUAN_ID=:fk_renyuan_id ");
                OracleParameter pFk_renyuan_id = new OracleParameter(":fk_renyuan_id", OracleDbType.Varchar2);
                pFk_renyuan_id.Direction = ParameterDirection.Input;
                pFk_renyuan_id.Value = jc_ry_ksParam.Fk_renyuan_id;
                sqlparams.Add(pFk_renyuan_id);
            }
                
            if (null != jc_ry_ksParam.Fk_keshi_id && "" != jc_ry_ksParam.Fk_keshi_id)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.FK_KESHI_ID=:fk_keshi_id ");
                OracleParameter pFk_keshi_id = new OracleParameter(":fk_keshi_id", OracleDbType.Varchar2);
                pFk_keshi_id.Direction = ParameterDirection.Input;
                pFk_keshi_id.Value = jc_ry_ksParam.Fk_keshi_id;
                sqlparams.Add(pFk_keshi_id);
            }
                
            if (null != jc_ry_ksParam.Zfbz && "" != jc_ry_ksParam.Zfbz)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.ZFBZ=:zfbz ");
                OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                pZfbz.Direction = ParameterDirection.Input;
                pZfbz.Value = jc_ry_ksParam.Zfbz;
                sqlparams.Add(pZfbz);
            }
                
            if(jc_ry_ksParamLike!=null)
            {

                if (null != jc_ry_ksParamLike.Fk_renyuan_id && "" != jc_ry_ksParamLike.Fk_renyuan_id)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.FK_RENYUAN_ID LIKE '%'||:fk_renyuan_id||'%' ");
                    OracleParameter pFk_renyuan_id = new OracleParameter(":fk_renyuan_id", OracleDbType.Varchar2);
                    pFk_renyuan_id.Direction = ParameterDirection.Input;
                    pFk_renyuan_id.Value = jc_ry_ksParamLike.Fk_renyuan_id;
                    sqlparams.Add(pFk_renyuan_id);
                }
                
                if (null != jc_ry_ksParamLike.Fk_keshi_id && "" != jc_ry_ksParamLike.Fk_keshi_id)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.FK_KESHI_ID LIKE '%'||:fk_keshi_id||'%' ");
                    OracleParameter pFk_keshi_id = new OracleParameter(":fk_keshi_id", OracleDbType.Varchar2);
                    pFk_keshi_id.Direction = ParameterDirection.Input;
                    pFk_keshi_id.Value = jc_ry_ksParamLike.Fk_keshi_id;
                    sqlparams.Add(pFk_keshi_id);
                }
                
                if (null != jc_ry_ksParamLike.Zfbz && "" != jc_ry_ksParamLike.Zfbz)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.ZFBZ LIKE '%'||:zfbz||'%' ");
                    OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                    pZfbz.Direction = ParameterDirection.Input;
                    pZfbz.Value = jc_ry_ksParamLike.Zfbz;
                    sqlparams.Add(pZfbz);
                }
                
            }

            this.b_isWhere = false;
            this.addSort(sql, sortList);//排序
            //*******分页start1*********如果分页对象为空，则全部数据查出，如果不为空
            List<object> returnList = new List<object>();//返回的List,索引0为List<Jc_ry_ks>对象,索引1为Model.Common.PageInfo分页信息对象
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
            //把每一行数据转换为一个对象放入List<Jc_ry_ks>中
            for (int i = 0; i < rows.Count; i++)
            {
                DataRow row = rows[i];
                //jc_ry_ksParamList.Add(this.dataSetContactObjectsToModel(row));
                jc_ry_ksParamList.Add(this.dataSetToModel(row));
            }
            
             //*******分页start2*********如果没有传入分页对象，则新建一个分页对象当做返回值
            if (null == page)
            {
                page = new Model.Common.PageInfo();
                page.AllCount = rows.Count;
            }
            returnList.Add(jc_ry_ksParamList);//把List<Jc_ry_ks>放入List<object>中第一个
            returnList.Add(page);//把page对象放入List<object>中第二个
            //*******分页end2*********
            return returnList;
        }

        
        
        /// <summary>
        /// 根据条件得到集合的数量
        /// 第二个条件是模糊查询的条件
        /// </summary>
        /// <returns>int</returns>
        public int getCount(Jc_ry_ks jc_ry_ksParam,Jc_ry_ks jc_ry_ksParamLike)
        {
            //如果没有传查询条件参数，就new一个空的Jc_ry_ks对象，标示查询所有数据
            if (null == jc_ry_ksParam)
            {
                jc_ry_ksParam = new Jc_ry_ks();
            }
            List<OracleParameter> sqlparams = new List<OracleParameter>();//保存参数的集合
            StringBuilder sql = new StringBuilder("SELECT COUNT(ID) FROM JC_RY_KS A");
                if (null != jc_ry_ksParam.Fk_renyuan_id && "" != jc_ry_ksParam.Fk_renyuan_id)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.FK_RENYUAN_ID=:fk_renyuan_id ");
                    OracleParameter pFk_renyuan_id = new OracleParameter(":fk_renyuan_id", OracleDbType.Varchar2);
                pFk_renyuan_id.Value = jc_ry_ksParam.Fk_renyuan_id;
                sqlparams.Add(pFk_renyuan_id);
                }
                
                if (null != jc_ry_ksParam.Fk_keshi_id && "" != jc_ry_ksParam.Fk_keshi_id)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.FK_KESHI_ID=:fk_keshi_id ");
                    OracleParameter pFk_keshi_id = new OracleParameter(":fk_keshi_id", OracleDbType.Varchar2);
                pFk_keshi_id.Value = jc_ry_ksParam.Fk_keshi_id;
                sqlparams.Add(pFk_keshi_id);
                }
                
                if (null != jc_ry_ksParam.Zfbz && "" != jc_ry_ksParam.Zfbz)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.ZFBZ=:zfbz ");
                    OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                pZfbz.Value = jc_ry_ksParam.Zfbz;
                sqlparams.Add(pZfbz);
                }
                
            if(jc_ry_ksParamLike!=null)
            {

                if (null != jc_ry_ksParamLike.Fk_renyuan_id && "" != jc_ry_ksParamLike.Fk_renyuan_id)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.FK_RENYUAN_ID LIKE '%'||:fk_renyuan_id||'%' ");
                    OracleParameter pFk_renyuan_id = new OracleParameter(":fk_renyuan_id", OracleDbType.Varchar2);
                    pFk_renyuan_id.Direction = ParameterDirection.Input;
                    pFk_renyuan_id.Value = jc_ry_ksParamLike.Fk_renyuan_id;
                    sqlparams.Add(pFk_renyuan_id);
                }
                
                if (null != jc_ry_ksParamLike.Fk_keshi_id && "" != jc_ry_ksParamLike.Fk_keshi_id)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.FK_KESHI_ID LIKE '%'||:fk_keshi_id||'%' ");
                    OracleParameter pFk_keshi_id = new OracleParameter(":fk_keshi_id", OracleDbType.Varchar2);
                    pFk_keshi_id.Direction = ParameterDirection.Input;
                    pFk_keshi_id.Value = jc_ry_ksParamLike.Fk_keshi_id;
                    sqlparams.Add(pFk_keshi_id);
                }
                
                if (null != jc_ry_ksParamLike.Zfbz && "" != jc_ry_ksParamLike.Zfbz)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.ZFBZ LIKE '%'||:zfbz||'%' ");
                    OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                    pZfbz.Direction = ParameterDirection.Input;
                    pZfbz.Value = jc_ry_ksParamLike.Zfbz;
                    sqlparams.Add(pZfbz);
                }
                
            }
this.b_isWhere = false;return Int32.Parse(OracleHelper.ExecuteScalar(sql.ToString(),sqlparams.ToArray()).ToString());
        }


        /// <summary>
        /// 通用的保存方法，根据用户传入的参数，有ID为修改，没有ID为新增(手动生成OracleConnection对象，此方法用于事务，使用事务必须使用同一个OracleConnection对象)
        /// </summary>
        /// <param name="jc_ry_ksParam"></param>
        /// <returns></returns>
        public bool save(Jc_ry_ks jc_ry_ksParam,OracleConnection con)
        {
            if ("" != jc_ry_ksParam.Id && null != jc_ry_ksParam.Id)
            {
                //修改
                return this.updateById(jc_ry_ksParam,con);
            }
            else
            {
                //新增
                return this.insert(jc_ry_ksParam,con);
            }
        }

        /// <summary>
        /// 把dataset中的一行转换为model
        /// </summary>
        /// <param name="row"></param>
        /// <returns></returns>
        private Jc_ry_ks dataSetToModel(DataRow row)
        {
            Jc_ry_ks jc_ry_ksParam = new Jc_ry_ks();
            jc_ry_ksParam.Id = Convert.ToString(row["ID"]).Trim(); 
            jc_ry_ksParam.Fk_renyuan_id = Convert.ToString(row["FK_RENYUAN_ID"]).Trim(); 
            jc_ry_ksParam.Fk_keshi_id = Convert.ToString(row["FK_KESHI_ID"]).Trim(); 
            jc_ry_ksParam.Zfbz = Convert.ToString(row["ZFBZ"]).Trim(); 
            
            return jc_ry_ksParam;
        }

       
        
        //*******************在此以后添加新的方法start
        #region DAL层的implement,实现，start

        /// <summary>
        /// 把dataset中的一行转换为model, 包括相关联的外键对象
        /// </summary>
        /// <param name="row"></param>
        /// <returns></returns>
        private Jc_ry_ks dataSetContactObjectsToModel(DataRow row)
        {
            Jc_ry_ks jc_ry_ksParam = this.dataSetToModel(row);

            #region 添加Jc_renyuan类别实体对象
            Jc_renyuan jc_renyuan = new Jc_renyuan();
            jc_renyuan.Id = Convert.ToString(row["JN_ID"]).Trim();
            jc_renyuan.Xm = Convert.ToString(row["JN_XM"]).Trim();
            jc_renyuan.Xb_code = Convert.ToString(row["JN_XB_CODE"]).Trim();
            jc_renyuan.Mz_code = Convert.ToString(row["JN_MZ_CODE"]).Trim();
            jc_renyuan.Csrq = (DateTime?)this.convertDBNullValue(row["JN_CSRQ"]);
            jc_renyuan.Sfzh = Convert.ToString(row["JN_SFZH"]).Trim();
            jc_renyuan.Zzmm_code = Convert.ToString(row["JN_ZZMM_CODE"]).Trim();
            jc_renyuan.Hyzk_code = Convert.ToString(row["JN_HYZK_CODE"]).Trim();
            jc_renyuan.Byxx = Convert.ToString(row["JN_BYXX"]).Trim();
            jc_renyuan.Xl_code = Convert.ToString(row["JN_XL_CODE"]).Trim();
            jc_renyuan.Cjgzsj = (DateTime?)this.convertDBNullValue(row["JN_CJGZSJ"]);
            jc_renyuan.Zy = Convert.ToString(row["JN_ZY"]).Trim();
            jc_renyuan.Jg = Convert.ToString(row["JN_JG"]).Trim();
            jc_renyuan.Dz = Convert.ToString(row["JN_DZ"]).Trim();
            jc_renyuan.Lxdh = Convert.ToString(row["JN_LXDH"]).Trim();
            jc_renyuan.Qq = Convert.ToString(row["JN_QQ"]).Trim();
            jc_renyuan.Yx = Convert.ToString(row["JN_YX"]).Trim();
            jc_renyuan.Bz = Convert.ToString(row["JN_BZ"]).Trim();
            jc_renyuan.Pym = Convert.ToString(row["JN_PYM"]).Trim();
            jc_renyuan.Wbm = Convert.ToString(row["JN_WBM"]).Trim();
            jc_renyuan.Rylx_code = Convert.ToString(row["JN_RYLX_CODE"]).Trim();
            jc_renyuan.Zfbz = Convert.ToString(row["JN_ZFBZ"]).Trim();

            jc_ry_ksParam.Jc_renyuan = jc_renyuan;
            #endregion 添加Jc_renyuan类别实体对象

            #region 添加Jc_kswh类别实体对象
            Jc_kswh jc_kswh = new Jc_kswh();
            jc_kswh.Id = Convert.ToString(row["JH_ID"]).Trim();
            jc_kswh.Ksbh = Convert.ToString(row["JH_KSBH"]).Trim();
            jc_kswh.Ksmc = Convert.ToString(row["JH_KSMC"]).Trim();
            jc_kswh.Mzbz_code = Convert.ToString(row["JH_MZBZ_CODE"]).Trim();
            jc_kswh.Zybz_code = Convert.ToString(row["JH_ZYBZ_CODE"]).Trim();
            jc_kswh.Ykbz_code = Convert.ToString(row["JH_YKBZ_CODE"]).Trim();
            jc_kswh.Yfbz_code = Convert.ToString(row["JH_YFBZ_CODE"]).Trim();
            jc_kswh.Yjbz_code = Convert.ToString(row["JH_YJBZ_CODE"]).Trim();
            jc_kswh.Ssbz_code = Convert.ToString(row["JH_SSBZ_CODE"]).Trim();
            jc_kswh.Zfbz = Convert.ToString(row["JH_ZFBZ"]).Trim();

            jc_ry_ksParam.Jc_kswh = jc_kswh;
            #endregion 添加Jc_kswh类别实体对象

            return jc_ry_ksParam;
        }



        /// <summary>
        /// 查找指定ID的用户,得到相关联的外键对象的方法
        /// </summary>
        /// <remarks>如果id为null、id重复、id未找到就抛异常</remarks>
        /// <returns>Jc_ry_ks</returns>
        public Jc_ry_ks findContactObjectsById(string id)
        {
            if ("" == id || null == id)
            {
                throw new Exception("主键ID不能为空，请赋值");
            }
            StringBuilder sql = new StringBuilder("SELECT A.* ");
            //新建方法findContactObjectsById，在此加入多表连接要显示的项start
            //sql.Append(",B.字段一,B.字段二,B.字段三");

            sql.Append(@"
            ,TT_JC_RENYUAN.ID AS JN_ID
            ,TT_JC_RENYUAN.XM AS JN_XM
            ,TT_JC_RENYUAN.XB_CODE AS JN_XB_CODE
            ,TT_JC_RENYUAN.MZ_CODE AS JN_MZ_CODE
            ,TT_JC_RENYUAN.CSRQ AS JN_CSRQ
            ,TT_JC_RENYUAN.SFZH AS JN_SFZH
            ,TT_JC_RENYUAN.ZZMM_CODE AS JN_ZZMM_CODE
            ,TT_JC_RENYUAN.HYZK_CODE AS JN_HYZK_CODE
            ,TT_JC_RENYUAN.BYXX AS JN_BYXX
            ,TT_JC_RENYUAN.XL_CODE AS JN_XL_CODE
            ,TT_JC_RENYUAN.CJGZSJ AS JN_CJGZSJ
            ,TT_JC_RENYUAN.ZY AS JN_ZY
            ,TT_JC_RENYUAN.JG AS JN_JG
            ,TT_JC_RENYUAN.DZ AS JN_DZ
            ,TT_JC_RENYUAN.LXDH AS JN_LXDH
            ,TT_JC_RENYUAN.QQ AS JN_QQ
            ,TT_JC_RENYUAN.YX AS JN_YX
            ,TT_JC_RENYUAN.BZ AS JN_BZ
            ,TT_JC_RENYUAN.PYM AS JN_PYM
            ,TT_JC_RENYUAN.WBM AS JN_WBM
            ,TT_JC_RENYUAN.RYLX_CODE AS JN_RYLX_CODE
            ,TT_JC_RENYUAN.ZFBZ AS JN_ZFBZ
            ");

            sql.Append(@"
            ,TT_JC_KSWH.ID AS JH_ID
            ,TT_JC_KSWH.KSBH AS JH_KSBH
            ,TT_JC_KSWH.KSMC AS JH_KSMC
            ,TT_JC_KSWH.MZBZ_CODE AS JH_MZBZ_CODE
            ,TT_JC_KSWH.ZYBZ_CODE AS JH_ZYBZ_CODE
            ,TT_JC_KSWH.YKBZ_CODE AS JH_YKBZ_CODE
            ,TT_JC_KSWH.YFBZ_CODE AS JH_YFBZ_CODE
            ,TT_JC_KSWH.YJBZ_CODE AS JH_YJBZ_CODE
            ,TT_JC_KSWH.SSBZ_CODE AS JH_SSBZ_CODE
            ,TT_JC_KSWH.ZFBZ AS JH_ZFBZ
            ");

            //新建方法，在此加入多表连接要显示的项end
            sql.Append(" FROM JC_RY_KS A ");
            //新建一个方法，在此加入多表连接的语句start
            //sql.Append("LEFT JOIN 外键表名 B ON A.外键=B.ID");

            sql.Append(@"
            LEFT JOIN JC_RENYUAN TT_JC_RENYUAN 
            ON A.FK_RENYUAN_ID = TT_JC_RENYUAN.ID

            ");

            sql.Append(@"
            LEFT JOIN JC_KSWH TT_JC_KSWH 
            ON A.FK_KESHI_ID = TT_JC_KSWH.ID

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
        /// <param name="jc_ry_ksParam"></param>
        /// <param name="page">分页对象</param>
        ///<param name="jc_ry_ksParamLike">模糊查询参数</param>
        ///<param name="sortList">排序参数对象的集合</param>
        /// <returns>满足条件的所有Jc_ry_ks对象集合list</returns>
        public List<object> findContactObjects(Jc_ry_ks jc_ry_ksParam, Model.Common.PageInfo page, Jc_ry_ks jc_ry_ksParamLike, List<SortInfo> sortList)
        {
            //如果没有传查询条件参数，就new一个空的Jc_ry_ks对象，标示查询所有数据
            if (null == jc_ry_ksParam)
            {
                jc_ry_ksParam = new Jc_ry_ks();
            }
            if (null != jc_ry_ksParam.Id && "" != jc_ry_ksParam.Id)
            {
                throw new Exception("此方法不允许指定参数ID，如果需要根据ID查询数据，请调用findById方法；错误出自：find");
            }

            List<Jc_ry_ks> jc_ry_ksParamList = new List<Jc_ry_ks>();//接收查询出的Jc_ry_ks对象集合
            List<OracleParameter> sqlparams = new List<OracleParameter>();//保存参数的集合
            StringBuilder sql = new StringBuilder("SELECT A.* ");
            //新建方法findAllContactObjects(Jc_ry_ks jc_ry_ksParam, Model.Common.PageInfo page)，在此加入多表连接要显示的项start
            //sql.Append(",B.字段一,B.字段二,B.字段三");

            sql.Append(@"
            ,TT_JC_RENYUAN.ID AS JN_ID
            ,TT_JC_RENYUAN.XM AS JN_XM
            ,TT_JC_RENYUAN.XB_CODE AS JN_XB_CODE
            ,TT_JC_RENYUAN.MZ_CODE AS JN_MZ_CODE
            ,TT_JC_RENYUAN.CSRQ AS JN_CSRQ
            ,TT_JC_RENYUAN.SFZH AS JN_SFZH
            ,TT_JC_RENYUAN.ZZMM_CODE AS JN_ZZMM_CODE
            ,TT_JC_RENYUAN.HYZK_CODE AS JN_HYZK_CODE
            ,TT_JC_RENYUAN.BYXX AS JN_BYXX
            ,TT_JC_RENYUAN.XL_CODE AS JN_XL_CODE
            ,TT_JC_RENYUAN.CJGZSJ AS JN_CJGZSJ
            ,TT_JC_RENYUAN.ZY AS JN_ZY
            ,TT_JC_RENYUAN.JG AS JN_JG
            ,TT_JC_RENYUAN.DZ AS JN_DZ
            ,TT_JC_RENYUAN.LXDH AS JN_LXDH
            ,TT_JC_RENYUAN.QQ AS JN_QQ
            ,TT_JC_RENYUAN.YX AS JN_YX
            ,TT_JC_RENYUAN.BZ AS JN_BZ
            ,TT_JC_RENYUAN.PYM AS JN_PYM
            ,TT_JC_RENYUAN.WBM AS JN_WBM
            ,TT_JC_RENYUAN.RYLX_CODE AS JN_RYLX_CODE
            ,TT_JC_RENYUAN.ZFBZ AS JN_ZFBZ
            ");

            sql.Append(@"
            ,TT_JC_KSWH.ID AS JH_ID
            ,TT_JC_KSWH.KSBH AS JH_KSBH
            ,TT_JC_KSWH.KSMC AS JH_KSMC
            ,TT_JC_KSWH.MZBZ_CODE AS JH_MZBZ_CODE
            ,TT_JC_KSWH.ZYBZ_CODE AS JH_ZYBZ_CODE
            ,TT_JC_KSWH.YKBZ_CODE AS JH_YKBZ_CODE
            ,TT_JC_KSWH.YFBZ_CODE AS JH_YFBZ_CODE
            ,TT_JC_KSWH.YJBZ_CODE AS JH_YJBZ_CODE
            ,TT_JC_KSWH.SSBZ_CODE AS JH_SSBZ_CODE
            ,TT_JC_KSWH.ZFBZ AS JH_ZFBZ
            ");

            //新建方法，在此加入多表连接要显示的项end
            sql.Append(" FROM JC_RY_KS A ");
            //新建一个方法，在此加入多表连接的语句start
            ////sql.Append(" LEFT JOIN 表名 B ON A.外键=B.ID");

            sql.Append(@"
            LEFT JOIN JC_RENYUAN TT_JC_RENYUAN 
            ON A.FK_RENYUAN_ID = TT_JC_RENYUAN.ID

            ");

            sql.Append(@"
            LEFT JOIN JC_KSWH TT_JC_KSWH 
            ON A.FK_KESHI_ID = TT_JC_KSWH.ID

            ");

            //新建一个方法，在此加入多表连接的语句end


            if (null != jc_ry_ksParam.Fk_renyuan_id && "" != jc_ry_ksParam.Fk_renyuan_id)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.FK_RENYUAN_ID=:fk_renyuan_id ");
                OracleParameter pFk_renyuan_id = new OracleParameter(":fk_renyuan_id", OracleDbType.Varchar2);
                pFk_renyuan_id.Value = jc_ry_ksParam.Fk_renyuan_id;
                sqlparams.Add(pFk_renyuan_id);
            }

            if (null != jc_ry_ksParam.Fk_keshi_id && "" != jc_ry_ksParam.Fk_keshi_id)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.FK_KESHI_ID=:fk_keshi_id ");
                OracleParameter pFk_keshi_id = new OracleParameter(":fk_keshi_id", OracleDbType.Varchar2);
                pFk_keshi_id.Value = jc_ry_ksParam.Fk_keshi_id;
                sqlparams.Add(pFk_keshi_id);
            }

            if (null != jc_ry_ksParam.Zfbz && "" != jc_ry_ksParam.Zfbz)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.ZFBZ=:zfbz ");
                OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                pZfbz.Value = jc_ry_ksParam.Zfbz;
                sqlparams.Add(pZfbz);
            }

            if (jc_ry_ksParamLike != null)
            {

                if (null != jc_ry_ksParamLike.Fk_renyuan_id && "" != jc_ry_ksParamLike.Fk_renyuan_id)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.FK_RENYUAN_ID LIKE '%'||:fk_renyuan_id||'%' ");
                    OracleParameter pFk_renyuan_id = new OracleParameter(":fk_renyuan_id", OracleDbType.Varchar2);
                    pFk_renyuan_id.Direction = ParameterDirection.Input;
                    pFk_renyuan_id.Value = jc_ry_ksParamLike.Fk_renyuan_id;
                    sqlparams.Add(pFk_renyuan_id);
                }

                if (null != jc_ry_ksParamLike.Fk_keshi_id && "" != jc_ry_ksParamLike.Fk_keshi_id)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.FK_KESHI_ID LIKE '%'||:fk_keshi_id||'%' ");
                    OracleParameter pFk_keshi_id = new OracleParameter(":fk_keshi_id", OracleDbType.Varchar2);
                    pFk_keshi_id.Direction = ParameterDirection.Input;
                    pFk_keshi_id.Value = jc_ry_ksParamLike.Fk_keshi_id;
                    sqlparams.Add(pFk_keshi_id);
                }

                if (null != jc_ry_ksParamLike.Zfbz && "" != jc_ry_ksParamLike.Zfbz)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.ZFBZ LIKE '%'||:zfbz||'%' ");
                    OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                    pZfbz.Direction = ParameterDirection.Input;
                    pZfbz.Value = jc_ry_ksParamLike.Zfbz;
                    sqlparams.Add(pZfbz);
                }

            }

            if (null != jc_ry_ksParam.Jc_renyuan)
            {

                if (null != jc_ry_ksParam.Jc_renyuan.Id && null != jc_ry_ksParam.Jc_renyuan.Id)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" TT_JC_RENYUAN.ID=:id ");
                    OracleParameter pId = new OracleParameter(":id", OracleDbType.Varchar2);
                    pId.Value = jc_ry_ksParam.Jc_renyuan.Id;
                    sqlparams.Add(pId);
                }

                if (null != jc_ry_ksParam.Jc_renyuan.Xm && null != jc_ry_ksParam.Jc_renyuan.Xm)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" TT_JC_RENYUAN.XM=:xm ");
                    OracleParameter pXm = new OracleParameter(":xm", OracleDbType.NVarchar2);
                    pXm.Value = jc_ry_ksParam.Jc_renyuan.Xm;
                    sqlparams.Add(pXm);
                }

                if (null != jc_ry_ksParam.Jc_renyuan.Xb_code && null != jc_ry_ksParam.Jc_renyuan.Xb_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" TT_JC_RENYUAN.XB_CODE=:xb_code ");
                    OracleParameter pXb_code = new OracleParameter(":xb_code", OracleDbType.NVarchar2);
                    pXb_code.Value = jc_ry_ksParam.Jc_renyuan.Xb_code;
                    sqlparams.Add(pXb_code);
                }

                if (null != jc_ry_ksParam.Jc_renyuan.Mz_code && null != jc_ry_ksParam.Jc_renyuan.Mz_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" TT_JC_RENYUAN.MZ_CODE=:mz_code ");
                    OracleParameter pMz_code = new OracleParameter(":mz_code", OracleDbType.NVarchar2);
                    pMz_code.Value = jc_ry_ksParam.Jc_renyuan.Mz_code;
                    sqlparams.Add(pMz_code);
                }

                if (DateTime.MinValue != jc_ry_ksParam.Jc_renyuan.Csrq && null != jc_ry_ksParam.Jc_renyuan.Csrq)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" TT_JC_RENYUAN.CSRQ=:csrq ");
                    OracleParameter pCsrq = new OracleParameter(":csrq", OracleDbType.Date);
                    pCsrq.Value = jc_ry_ksParam.Jc_renyuan.Csrq;
                    sqlparams.Add(pCsrq);
                }

                if (null != jc_ry_ksParam.Jc_renyuan.Sfzh && null != jc_ry_ksParam.Jc_renyuan.Sfzh)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" TT_JC_RENYUAN.SFZH=:sfzh ");
                    OracleParameter pSfzh = new OracleParameter(":sfzh", OracleDbType.NVarchar2);
                    pSfzh.Value = jc_ry_ksParam.Jc_renyuan.Sfzh;
                    sqlparams.Add(pSfzh);
                }

                if (null != jc_ry_ksParam.Jc_renyuan.Zzmm_code && null != jc_ry_ksParam.Jc_renyuan.Zzmm_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" TT_JC_RENYUAN.ZZMM_CODE=:zzmm_code ");
                    OracleParameter pZzmm_code = new OracleParameter(":zzmm_code", OracleDbType.NVarchar2);
                    pZzmm_code.Value = jc_ry_ksParam.Jc_renyuan.Zzmm_code;
                    sqlparams.Add(pZzmm_code);
                }

                if (null != jc_ry_ksParam.Jc_renyuan.Hyzk_code && null != jc_ry_ksParam.Jc_renyuan.Hyzk_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" TT_JC_RENYUAN.HYZK_CODE=:hyzk_code ");
                    OracleParameter pHyzk_code = new OracleParameter(":hyzk_code", OracleDbType.NVarchar2);
                    pHyzk_code.Value = jc_ry_ksParam.Jc_renyuan.Hyzk_code;
                    sqlparams.Add(pHyzk_code);
                }

                if (null != jc_ry_ksParam.Jc_renyuan.Byxx && null != jc_ry_ksParam.Jc_renyuan.Byxx)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" TT_JC_RENYUAN.BYXX=:byxx ");
                    OracleParameter pByxx = new OracleParameter(":byxx", OracleDbType.NVarchar2);
                    pByxx.Value = jc_ry_ksParam.Jc_renyuan.Byxx;
                    sqlparams.Add(pByxx);
                }

                if (null != jc_ry_ksParam.Jc_renyuan.Xl_code && null != jc_ry_ksParam.Jc_renyuan.Xl_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" TT_JC_RENYUAN.XL_CODE=:xl_code ");
                    OracleParameter pXl_code = new OracleParameter(":xl_code", OracleDbType.NVarchar2);
                    pXl_code.Value = jc_ry_ksParam.Jc_renyuan.Xl_code;
                    sqlparams.Add(pXl_code);
                }

                if (DateTime.MinValue != jc_ry_ksParam.Jc_renyuan.Cjgzsj && null != jc_ry_ksParam.Jc_renyuan.Cjgzsj)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" TT_JC_RENYUAN.CJGZSJ=:cjgzsj ");
                    OracleParameter pCjgzsj = new OracleParameter(":cjgzsj", OracleDbType.Date);
                    pCjgzsj.Value = jc_ry_ksParam.Jc_renyuan.Cjgzsj;
                    sqlparams.Add(pCjgzsj);
                }

                if (null != jc_ry_ksParam.Jc_renyuan.Zy && null != jc_ry_ksParam.Jc_renyuan.Zy)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" TT_JC_RENYUAN.ZY=:zy ");
                    OracleParameter pZy = new OracleParameter(":zy", OracleDbType.NVarchar2);
                    pZy.Value = jc_ry_ksParam.Jc_renyuan.Zy;
                    sqlparams.Add(pZy);
                }

                if (null != jc_ry_ksParam.Jc_renyuan.Jg && null != jc_ry_ksParam.Jc_renyuan.Jg)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" TT_JC_RENYUAN.JG=:jg ");
                    OracleParameter pJg = new OracleParameter(":jg", OracleDbType.NVarchar2);
                    pJg.Value = jc_ry_ksParam.Jc_renyuan.Jg;
                    sqlparams.Add(pJg);
                }

                if (null != jc_ry_ksParam.Jc_renyuan.Dz && null != jc_ry_ksParam.Jc_renyuan.Dz)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" TT_JC_RENYUAN.DZ=:dz ");
                    OracleParameter pDz = new OracleParameter(":dz", OracleDbType.NVarchar2);
                    pDz.Value = jc_ry_ksParam.Jc_renyuan.Dz;
                    sqlparams.Add(pDz);
                }

                if (null != jc_ry_ksParam.Jc_renyuan.Lxdh && null != jc_ry_ksParam.Jc_renyuan.Lxdh)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" TT_JC_RENYUAN.LXDH=:lxdh ");
                    OracleParameter pLxdh = new OracleParameter(":lxdh", OracleDbType.NVarchar2);
                    pLxdh.Value = jc_ry_ksParam.Jc_renyuan.Lxdh;
                    sqlparams.Add(pLxdh);
                }

                if (null != jc_ry_ksParam.Jc_renyuan.Qq && null != jc_ry_ksParam.Jc_renyuan.Qq)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" TT_JC_RENYUAN.QQ=:qq ");
                    OracleParameter pQq = new OracleParameter(":qq", OracleDbType.NVarchar2);
                    pQq.Value = jc_ry_ksParam.Jc_renyuan.Qq;
                    sqlparams.Add(pQq);
                }

                if (null != jc_ry_ksParam.Jc_renyuan.Yx && null != jc_ry_ksParam.Jc_renyuan.Yx)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" TT_JC_RENYUAN.YX=:yx ");
                    OracleParameter pYx = new OracleParameter(":yx", OracleDbType.NVarchar2);
                    pYx.Value = jc_ry_ksParam.Jc_renyuan.Yx;
                    sqlparams.Add(pYx);
                }

                if (null != jc_ry_ksParam.Jc_renyuan.Bz && null != jc_ry_ksParam.Jc_renyuan.Bz)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" TT_JC_RENYUAN.BZ=:bz ");
                    OracleParameter pBz = new OracleParameter(":bz", OracleDbType.NVarchar2);
                    pBz.Value = jc_ry_ksParam.Jc_renyuan.Bz;
                    sqlparams.Add(pBz);
                }

                if (null != jc_ry_ksParam.Jc_renyuan.Pym && null != jc_ry_ksParam.Jc_renyuan.Pym)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" TT_JC_RENYUAN.PYM=:pym ");
                    OracleParameter pPym = new OracleParameter(":pym", OracleDbType.NVarchar2);
                    pPym.Value = jc_ry_ksParam.Jc_renyuan.Pym;
                    sqlparams.Add(pPym);
                }

                if (null != jc_ry_ksParam.Jc_renyuan.Wbm && null != jc_ry_ksParam.Jc_renyuan.Wbm)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" TT_JC_RENYUAN.WBM=:wbm ");
                    OracleParameter pWbm = new OracleParameter(":wbm", OracleDbType.NVarchar2);
                    pWbm.Value = jc_ry_ksParam.Jc_renyuan.Wbm;
                    sqlparams.Add(pWbm);
                }

                if (null != jc_ry_ksParam.Jc_renyuan.Rylx_code && null != jc_ry_ksParam.Jc_renyuan.Rylx_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" TT_JC_RENYUAN.RYLX_CODE=:rylx_code ");
                    OracleParameter pRylx_code = new OracleParameter(":rylx_code", OracleDbType.NVarchar2);
                    pRylx_code.Value = jc_ry_ksParam.Jc_renyuan.Rylx_code;
                    sqlparams.Add(pRylx_code);
                }

                if (null != jc_ry_ksParam.Jc_renyuan.Zfbz && null != jc_ry_ksParam.Jc_renyuan.Zfbz)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" TT_JC_RENYUAN.ZFBZ=:zfbz ");
                    OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                    pZfbz.Value = jc_ry_ksParam.Jc_renyuan.Zfbz;
                    sqlparams.Add(pZfbz);
                }

            }

            if (null != jc_ry_ksParam.Jc_kswh)
            {

                if (null != jc_ry_ksParam.Jc_kswh.Id && null != jc_ry_ksParam.Jc_kswh.Id)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" TT_JC_KSWH.ID=:id ");
                    OracleParameter pId = new OracleParameter(":id", OracleDbType.Varchar2);
                    pId.Value = jc_ry_ksParam.Jc_kswh.Id;
                    sqlparams.Add(pId);
                }

                if (null != jc_ry_ksParam.Jc_kswh.Ksbh && null != jc_ry_ksParam.Jc_kswh.Ksbh)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" TT_JC_KSWH.KSBH=:ksbh ");
                    OracleParameter pKsbh = new OracleParameter(":ksbh", OracleDbType.NVarchar2);
                    pKsbh.Value = jc_ry_ksParam.Jc_kswh.Ksbh;
                    sqlparams.Add(pKsbh);
                }

                if (null != jc_ry_ksParam.Jc_kswh.Ksmc && null != jc_ry_ksParam.Jc_kswh.Ksmc)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" TT_JC_KSWH.KSMC=:ksmc ");
                    OracleParameter pKsmc = new OracleParameter(":ksmc", OracleDbType.NVarchar2);
                    pKsmc.Value = jc_ry_ksParam.Jc_kswh.Ksmc;
                    sqlparams.Add(pKsmc);
                }

                if (null != jc_ry_ksParam.Jc_kswh.Mzbz_code && null != jc_ry_ksParam.Jc_kswh.Mzbz_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" TT_JC_KSWH.MZBZ_CODE=:mzbz_code ");
                    OracleParameter pMzbz_code = new OracleParameter(":mzbz_code", OracleDbType.NVarchar2);
                    pMzbz_code.Value = jc_ry_ksParam.Jc_kswh.Mzbz_code;
                    sqlparams.Add(pMzbz_code);
                }

                if (null != jc_ry_ksParam.Jc_kswh.Zybz_code && null != jc_ry_ksParam.Jc_kswh.Zybz_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" TT_JC_KSWH.ZYBZ_CODE=:zybz_code ");
                    OracleParameter pZybz_code = new OracleParameter(":zybz_code", OracleDbType.NVarchar2);
                    pZybz_code.Value = jc_ry_ksParam.Jc_kswh.Zybz_code;
                    sqlparams.Add(pZybz_code);
                }

                if (null != jc_ry_ksParam.Jc_kswh.Ykbz_code && null != jc_ry_ksParam.Jc_kswh.Ykbz_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" TT_JC_KSWH.YKBZ_CODE=:ykbz_code ");
                    OracleParameter pYkbz_code = new OracleParameter(":ykbz_code", OracleDbType.NVarchar2);
                    pYkbz_code.Value = jc_ry_ksParam.Jc_kswh.Ykbz_code;
                    sqlparams.Add(pYkbz_code);
                }

                if (null != jc_ry_ksParam.Jc_kswh.Yfbz_code && null != jc_ry_ksParam.Jc_kswh.Yfbz_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" TT_JC_KSWH.YFBZ_CODE=:yfbz_code ");
                    OracleParameter pYfbz_code = new OracleParameter(":yfbz_code", OracleDbType.NVarchar2);
                    pYfbz_code.Value = jc_ry_ksParam.Jc_kswh.Yfbz_code;
                    sqlparams.Add(pYfbz_code);
                }

                if (null != jc_ry_ksParam.Jc_kswh.Yjbz_code && null != jc_ry_ksParam.Jc_kswh.Yjbz_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" TT_JC_KSWH.YJBZ_CODE=:yjbz_code ");
                    OracleParameter pYjbz_code = new OracleParameter(":yjbz_code", OracleDbType.NVarchar2);
                    pYjbz_code.Value = jc_ry_ksParam.Jc_kswh.Yjbz_code;
                    sqlparams.Add(pYjbz_code);
                }

                if (null != jc_ry_ksParam.Jc_kswh.Ssbz_code && null != jc_ry_ksParam.Jc_kswh.Ssbz_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" TT_JC_KSWH.SSBZ_CODE=:ssbz_code ");
                    OracleParameter pSsbz_code = new OracleParameter(":ssbz_code", OracleDbType.NVarchar2);
                    pSsbz_code.Value = jc_ry_ksParam.Jc_kswh.Ssbz_code;
                    sqlparams.Add(pSsbz_code);
                }

                if (null != jc_ry_ksParam.Jc_kswh.Zfbz && null != jc_ry_ksParam.Jc_kswh.Zfbz)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" TT_JC_KSWH.ZFBZ=:zfbz ");
                    OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                    pZfbz.Value = jc_ry_ksParam.Jc_kswh.Zfbz;
                    sqlparams.Add(pZfbz);
                }

            }

           
            

            this.b_isWhere = false;
            //排序
            this.addSort(sql, sortList);
            //*******分页start1*********如果分页对象为空，则全部数据查出，如果不为空
            List<object> returnList = new List<object>();//返回的List,索引0为List<Jc_ry_ks>对象,索引1为Model.Common.PageInfo分页信息对象
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
            //把每一行数据转换为一个对象放入List<Jc_ry_ks>中
            for (int i = 0; i < rows.Count; i++)
            {
                DataRow row = rows[i];
                jc_ry_ksParamList.Add(this.dataSetContactObjectsToModel(row));
                //jc_ry_ksParamList.Add(this.dataSetToModel(row));
            }

            //*******分页start2*********如果没有传入分页对象，则新建一个分页对象当做返回值
            if (null == page)
            {
                page = new Model.Common.PageInfo();
                page.AllCount = rows.Count;
            }
            returnList.Add(jc_ry_ksParamList);//把List<Jc_ry_ks>放入List<object>中第一个
            returnList.Add(page);//把page对象放入List<object>中第二个
            //*******分页end2*********
            return returnList;
        }
        #endregion DAL层的implement,实现，end

        


        //*******************在此以后添加新的方法end
        
    }
}


