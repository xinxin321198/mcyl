

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
using Model.RBAC;

namespace DAL.JC.基础_工作人员账户关系表
{
    /// <summary>
    ///数据库访问层的Jc_renyuan_user实现类
    ///此类由代码生成器生成
    ///表名：JC_RENYUAN_USER
    ///生成日期：2015-12-02 15:59:41
    /// 

    ///作者：罗新鑫
    ///联系电话：15087010221
    ///联系邮箱：362527240@qq.com
        
    /// </summary>
    public class Jc_renyuan_userDALImp :Base.BasDAL,Jc_renyuan_userDAL
    {

        /// <summary>
        /// 插入一条数据（如果需要供事务使用就传入OracleConnection对象，如果不供就传入null，方法自动生成OracleConnection对象）
        /// 主键为null时，自动生成主键guid，一般不直接调用此方法，请调用save方法进行单条数据的插入和修改       
        /// </summary>
        /// <param name="jc_renyuan_userParam">要插入的jc_renyuan_userParam对象</param>
        /// <param name="con">Oracle连接对象（为null时自动生成）</param>
        /// <returns>是否添加成功（影响的行数为1时成功）</returns>
        public bool insert(Jc_renyuan_user jc_renyuan_userParam,OracleConnection con)
        {
            if (""==jc_renyuan_userParam.Id||null==jc_renyuan_userParam.Id)
            {
                jc_renyuan_userParam.Id = Model.Common.GUIDHelper.getGuid();
            }
            List<OracleParameter> sqlparams = new List<OracleParameter>();
            
            StringBuilder sql = new StringBuilder("INSERT INTO JC_RENYUAN_USER(id,fk_renyuan_id,fk_user_id,zfbz) VALUES(:id,:fk_renyuan_id,:fk_user_id,:zfbz)");
            
            OracleParameter pId = new OracleParameter(":id", OracleDbType.Varchar2);
            pId.Direction = ParameterDirection.Input;
            pId.Value = jc_renyuan_userParam.Id;
            sqlparams.Add(pId);
            OracleParameter pFk_renyuan_id = new OracleParameter(":fk_renyuan_id", OracleDbType.Varchar2);
            pFk_renyuan_id.Direction = ParameterDirection.Input;
            pFk_renyuan_id.Value = jc_renyuan_userParam.Fk_renyuan_id;
            sqlparams.Add(pFk_renyuan_id);
            OracleParameter pFk_user_id = new OracleParameter(":fk_user_id", OracleDbType.Varchar2);
            pFk_user_id.Direction = ParameterDirection.Input;
            pFk_user_id.Value = jc_renyuan_userParam.Fk_user_id;
            sqlparams.Add(pFk_user_id);
            OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
            pZfbz.Direction = ParameterDirection.Input;
            pZfbz.Value = jc_renyuan_userParam.Zfbz;
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
        /// <param name="jc_renyuan_userParamList">要插入的jc_renyuan_userParam对象的集合</param>
        /// <param name="con">Oracle连接对象（为null时自动生成）</param>
        /// <returns>是否添加成功（影响的行数等于保存的对象的数量时成功）</returns>
        public bool inertBatch(List<Jc_renyuan_user> jc_renyuan_userParamList, OracleConnection con)
        {
            if (jc_renyuan_userParamList.Count==0)
            {
                return true;
            }
            List<string> idList = new List<string>();

            List<string> fk_renyuan_idList = new List<string>();

            List<string> fk_user_idList = new List<string>();

            List<string> zfbzList = new List<string>();

            for (int i = 0; i < jc_renyuan_userParamList.Count; i++)
            {
                Jc_renyuan_user jc_renyuan_userParam = jc_renyuan_userParamList[i];
                if ("" == jc_renyuan_userParam.Id || null == jc_renyuan_userParam.Id)
                {
                    jc_renyuan_userParam.Id = Model.Common.GUIDHelper.getGuid();
                }

            idList.Add(jc_renyuan_userParam.Id);

            fk_renyuan_idList.Add(jc_renyuan_userParam.Fk_renyuan_id);

            fk_user_idList.Add(jc_renyuan_userParam.Fk_user_id);

            zfbzList.Add(jc_renyuan_userParam.Zfbz);

            }

            List<OracleParameter> sqlparams = new List<OracleParameter>();

            StringBuilder sql = new StringBuilder("INSERT INTO JC_RENYUAN_USER(id,fk_renyuan_id,fk_user_id,zfbz) VALUES(:id,:fk_renyuan_id,:fk_user_id,:zfbz)");
            
            OracleParameter pId = new OracleParameter(":id", OracleDbType.Varchar2);
            pId.Direction = ParameterDirection.Input;
            pId.Value = idList.ToArray();
            sqlparams.Add(pId);
            OracleParameter pFk_renyuan_id = new OracleParameter(":fk_renyuan_id", OracleDbType.Varchar2);
            pFk_renyuan_id.Direction = ParameterDirection.Input;
            pFk_renyuan_id.Value = fk_renyuan_idList.ToArray();
            sqlparams.Add(pFk_renyuan_id);
            OracleParameter pFk_user_id = new OracleParameter(":fk_user_id", OracleDbType.Varchar2);
            pFk_user_id.Direction = ParameterDirection.Input;
            pFk_user_id.Value = fk_user_idList.ToArray();
            sqlparams.Add(pFk_user_id);
            OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
            pZfbz.Direction = ParameterDirection.Input;
            pZfbz.Value = zfbzList.ToArray();
            sqlparams.Add(pZfbz);
            bool result = false;
            int flag = -1;
            flag = OracleHelper.ExecuteBatch(sql.ToString(), con, jc_renyuan_userParamList.Count, sqlparams.ToArray());
            if (jc_renyuan_userParamList.Count == flag)
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
            StringBuilder sql = new StringBuilder("DELETE JC_RENYUAN_USER WHERE ID=:id");
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
            StringBuilder sql = new StringBuilder("DELETE JC_RENYUAN_USER WHERE ID=:id");
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
        /// <param name="jc_renyuan_userParamCondition">删除的条件</param>
        /// <param name="con">Oracle连接对象（为null时自动生成）</param>
        /// <returns>无法确定删除的行数（影响行数大于等于0就算成功）</returns>
        public bool deleteByOtherCondition(Jc_renyuan_user jc_renyuan_userParamCondition, OracleConnection con)
        {
            if (null!=jc_renyuan_userParamCondition.Id&&""!=jc_renyuan_userParamCondition.Id)
            {
                throw new Exception("不允许指定参数的ID，如果要根据ID删除数据请调用deleteById或者deleteByIdBatch方法；错误出自：deleteByOtherCondition");
            }
            List<OracleParameter> sqlparams = new List<OracleParameter>();
            StringBuilder sql = new StringBuilder("DELETE JC_RENYUAN_USER ");

            if (null != jc_renyuan_userParamCondition.Fk_renyuan_id &&  ""!= jc_renyuan_userParamCondition.Fk_renyuan_id)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" FK_RENYUAN_ID=:fk_renyuan_id ");
                OracleParameter pFk_renyuan_id = new OracleParameter(":fk_renyuan_id", OracleDbType.Varchar2);
                pFk_renyuan_id.Direction = ParameterDirection.Input;
                pFk_renyuan_id.Value = jc_renyuan_userParamCondition.Fk_renyuan_id;
                sqlparams.Add(pFk_renyuan_id);

            }
                        
            if (null != jc_renyuan_userParamCondition.Fk_user_id &&  ""!= jc_renyuan_userParamCondition.Fk_user_id)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" FK_USER_ID=:fk_user_id ");
                OracleParameter pFk_user_id = new OracleParameter(":fk_user_id", OracleDbType.Varchar2);
                pFk_user_id.Direction = ParameterDirection.Input;
                pFk_user_id.Value = jc_renyuan_userParamCondition.Fk_user_id;
                sqlparams.Add(pFk_user_id);

            }
                        
            if (null != jc_renyuan_userParamCondition.Zfbz &&  ""!= jc_renyuan_userParamCondition.Zfbz)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" ZFBZ=:zfbz ");
                OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                pZfbz.Direction = ParameterDirection.Input;
                pZfbz.Value = jc_renyuan_userParamCondition.Zfbz;
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
        /// <param name="jc_renyuan_userParam"></param>
        /// <returns>影响的行数</returns>
        public bool updateById(Jc_renyuan_user jc_renyuan_userParam,OracleConnection con)
        {
            if ("" == jc_renyuan_userParam.Id || null == jc_renyuan_userParam.Id)
            {
                throw new Exception("ID不允许为空，请赋值后调用；错误出自：updateById");
            }
            List<OracleParameter> sqlparams = new List<OracleParameter>();

            StringBuilder sql = new StringBuilder("UPDATE JC_RENYUAN_USER SET ");
            if (null != jc_renyuan_userParam.Fk_renyuan_id &&  ""!= jc_renyuan_userParam.Fk_renyuan_id)
            {
                this.isComma(sql);
                sql.Append(" FK_RENYUAN_ID=:fk_renyuan_id ");
                OracleParameter pFk_renyuan_id = new OracleParameter(":fk_renyuan_id", OracleDbType.Varchar2);
                pFk_renyuan_id.Direction = ParameterDirection.Input;
                pFk_renyuan_id.Value = jc_renyuan_userParam.Fk_renyuan_id;
                sqlparams.Add(pFk_renyuan_id);

            }
                        
            if (null != jc_renyuan_userParam.Fk_user_id &&  ""!= jc_renyuan_userParam.Fk_user_id)
            {
                this.isComma(sql);
                sql.Append(" FK_USER_ID=:fk_user_id ");
                OracleParameter pFk_user_id = new OracleParameter(":fk_user_id", OracleDbType.Varchar2);
                pFk_user_id.Direction = ParameterDirection.Input;
                pFk_user_id.Value = jc_renyuan_userParam.Fk_user_id;
                sqlparams.Add(pFk_user_id);

            }
                        
            if (null != jc_renyuan_userParam.Zfbz &&  ""!= jc_renyuan_userParam.Zfbz)
            {
                this.isComma(sql);
                sql.Append(" ZFBZ=:zfbz ");
                OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                pZfbz.Direction = ParameterDirection.Input;
                pZfbz.Value = jc_renyuan_userParam.Zfbz;
                sqlparams.Add(pZfbz);

            }
                        
            sql.Append(" WHERE ID=:id ");
            OracleParameter pId = new OracleParameter(":id", OracleDbType.Varchar2);
            pId.Value = jc_renyuan_userParam.Id;
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
        /// <param name="jc_renyuan_userParamList">要修改的Jc_renyuan_user对象集合</param>
        /// <param name="con">Oracle连接对象（为null时自动生成）</param>
        /// <returns>是否删除成功（影响的行数等于要修改的对象数量时成功）</returns>
        public bool updateByIdBatch(List<Jc_renyuan_user> jc_renyuan_userParamList, OracleConnection con)
        {


            List<string> idList = new List<string>();

            List<string> fk_renyuan_idList = new List<string>();

            List<string> fk_user_idList = new List<string>();

            List<string> zfbzList = new List<string>();

            for (int i = 0; i < jc_renyuan_userParamList.Count; i++)
            {
                Jc_renyuan_user jc_renyuan_userParam = jc_renyuan_userParamList[i];
                if ("" == jc_renyuan_userParam.Id || null == jc_renyuan_userParam.Id)
                {
                    throw new Exception("下标为" + i + "的数据，ID不能为空，请赋值后调用；错误出自：updateByIdBatch");
                }

            idList.Add(jc_renyuan_userParam.Id);

            fk_renyuan_idList.Add(jc_renyuan_userParam.Fk_renyuan_id);

            fk_user_idList.Add(jc_renyuan_userParam.Fk_user_id);

            zfbzList.Add(jc_renyuan_userParam.Zfbz);

            }


            
            List<OracleParameter> sqlparams = new List<OracleParameter>();

            StringBuilder sql = new StringBuilder("UPDATE JC_RENYUAN_USER SET ");
            this.isComma(sql);
            sql.Append(" FK_RENYUAN_ID=:fk_renyuan_id ");
            OracleParameter pFk_renyuan_id = new OracleParameter(":fk_renyuan_id", OracleDbType.Varchar2);
            pFk_renyuan_id.Direction = ParameterDirection.Input;
            pFk_renyuan_id.Value = fk_renyuan_idList.ToArray();
            sqlparams.Add(pFk_renyuan_id);

            this.isComma(sql);
            sql.Append(" FK_USER_ID=:fk_user_id ");
            OracleParameter pFk_user_id = new OracleParameter(":fk_user_id", OracleDbType.Varchar2);
            pFk_user_id.Direction = ParameterDirection.Input;
            pFk_user_id.Value = fk_user_idList.ToArray();
            sqlparams.Add(pFk_user_id);

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
            int flag = OracleHelper.ExecuteBatch(sql.ToString(), con,jc_renyuan_userParamList.Count, sqlparams.ToArray());
            if (jc_renyuan_userParamList.Count == flag)
            {
                result = true;
            }
            return result;
        }

        /// <summary>
        /// 根据更新的条件，更新数据（如果需要供事务使用就传入OracleConnection对象，如果不供就传入null，方法自动生成OracleConnection对象）
        /// 不指定ID，如果要根据ID来更新数据，请使用updateForId方法
        /// </summary>
        /// <param name="jc_renyuan_userParamCondition">条件对象</param>
        /// <param name="jc_renyuan_userParamUpdate">要更新的数据对象</param>
        /// <param name="con">Oracle连接对象（为null时自动生成）</param>
        /// <returns>影响的行数不确定（不为-1就正确）</returns>
        public bool updateByOtherCondition(Jc_renyuan_user jc_renyuan_userParamCondition, Jc_renyuan_user jc_renyuan_userParamUpdate, OracleConnection con)
        {
            if ((null!=jc_renyuan_userParamCondition.Id&&"!=jc_renyuan_userParamCondition.Id)||(null!=jc_renyuan_userParamUpdate.Id&&"!=jc_renyuan_userParamUpdate.Id))
            {
                throw new Exception("此方法不允许指定参数的ID，数据库中的ID不允许修改，如需根据ID修改数据，请调用updateById或updateByIdBatch方法；错误出自：updateByOtherCondition");
            }
            List<OracleParameter> sqlparams = new List<OracleParameter>();
            //添加要修改的值
            StringBuilder sql = new StringBuilder("UPDATE JC_RENYUAN_USER SET ");
            if (null != jc_renyuan_userParamUpdate.Fk_renyuan_id &&  ""!= jc_renyuan_userParamUpdate.Fk_renyuan_id)
            {
                this.isComma(sql);
                sql.Append(" FK_RENYUAN_ID=:fk_renyuan_id ");
                OracleParameter pFk_renyuan_id = new OracleParameter(":fk_renyuan_id", OracleDbType.Varchar2);
                pFk_renyuan_id.Direction = ParameterDirection.Input;
                pFk_renyuan_id.Value = jc_renyuan_userParamUpdate.Fk_renyuan_id;
                sqlparams.Add(pFk_renyuan_id);

            }
                        
            if (null != jc_renyuan_userParamUpdate.Fk_user_id &&  ""!= jc_renyuan_userParamUpdate.Fk_user_id)
            {
                this.isComma(sql);
                sql.Append(" FK_USER_ID=:fk_user_id ");
                OracleParameter pFk_user_id = new OracleParameter(":fk_user_id", OracleDbType.Varchar2);
                pFk_user_id.Direction = ParameterDirection.Input;
                pFk_user_id.Value = jc_renyuan_userParamUpdate.Fk_user_id;
                sqlparams.Add(pFk_user_id);

            }
                        
            if (null != jc_renyuan_userParamUpdate.Zfbz &&  ""!= jc_renyuan_userParamUpdate.Zfbz)
            {
                this.isComma(sql);
                sql.Append(" ZFBZ=:zfbz ");
                OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                pZfbz.Direction = ParameterDirection.Input;
                pZfbz.Value = jc_renyuan_userParamUpdate.Zfbz;
                sqlparams.Add(pZfbz);

            }
                        
            //添加条件的参数
            
            if (null != jc_renyuan_userParamCondition.Fk_renyuan_id &&  ""!= jc_renyuan_userParamCondition.Fk_renyuan_id)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" FK_RENYUAN_ID=:fk_renyuan_id ");
                OracleParameter pFk_renyuan_id = new OracleParameter(":fk_renyuan_id", OracleDbType.Varchar2);
                pFk_renyuan_id.Direction = ParameterDirection.Input;
                pFk_renyuan_id.Value = jc_renyuan_userParamCondition.Fk_renyuan_id;
                sqlparams.Add(pFk_renyuan_id);

            }
                        
            if (null != jc_renyuan_userParamCondition.Fk_user_id &&  ""!= jc_renyuan_userParamCondition.Fk_user_id)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" FK_USER_ID=:fk_user_id ");
                OracleParameter pFk_user_id = new OracleParameter(":fk_user_id", OracleDbType.Varchar2);
                pFk_user_id.Direction = ParameterDirection.Input;
                pFk_user_id.Value = jc_renyuan_userParamCondition.Fk_user_id;
                sqlparams.Add(pFk_user_id);

            }
                        
            if (null != jc_renyuan_userParamCondition.Zfbz &&  ""!= jc_renyuan_userParamCondition.Zfbz)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" ZFBZ=:zfbz ");
                OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                pZfbz.Direction = ParameterDirection.Input;
                pZfbz.Value = jc_renyuan_userParamCondition.Zfbz;
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
        /// <returns>Jc_renyuan_user</returns>
        public Jc_renyuan_user findById(string id)
        {
            if (""==id||null==id)
            {
                throw new Exception("ID不能为空，请赋值后调用；错误出自：findById");
            }
            StringBuilder sql = new StringBuilder("SELECT A.* ");
            //新建方法findContactObjectsById，在此加入多表连接要显示的项start
            //sql.Append(",B.字段一,B.字段二,B.字段三");
            //新建方法，在此加入多表连接要显示的项end
            sql.Append(" FROM JC_RENYUAN_USER A ");
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
        /// <param name="jc_renyuan_userParam"></param>
        /// <param name="page">分页对象</param>
        ///<param name="jc_renyuan_userParamLike">模糊查询参数</param>
        ///<param name="sortList">排序参数对象的集合</param>
        /// <returns>满足条件的所有Jc_renyuan_user对象集合list</returns>
        public List<object> find(Jc_renyuan_user jc_renyuan_userParam, Model.Common.PageInfo page,Jc_renyuan_user jc_renyuan_userParamLike,List<SortInfo> sortList)
        {

            //如果没有传查询条件参数，就new一个空的Jc_renyuan_user对象，标示查询所有数据
            if (null == jc_renyuan_userParam)
            {
                jc_renyuan_userParam = new Jc_renyuan_user();
            }
            if (null!=jc_renyuan_userParam.Id&&""!=jc_renyuan_userParam.Id)
            {
                throw new Exception("此方法不允许指定参数ID，如果需要根据ID查询数据，请调用findById方法；错误出自：find");
            }
            List<Jc_renyuan_user> jc_renyuan_userParamList = new List<Jc_renyuan_user>();//接收查询出的Jc_renyuan_user对象集合
            List<OracleParameter> sqlparams = new List<OracleParameter>();//保存参数的集合
            StringBuilder sql = new StringBuilder("SELECT A.* ");
            //新建方法findContactObjects(Jc_renyuan_user jc_renyuan_userParam, Model.Common.PageInfo page)，在此加入多表连接要显示的项start
            //sql.Append(",B.字段一,B.字段二,B.字段三");
            //新建方法，在此加入多表连接要显示的项end
            sql.Append(" FROM JC_RENYUAN_USER A ");
            //新建一个方法，在此加入多表连接的语句start
            ////sql.Append(" LEFT JOIN 表名 B ON A.外键=B.ID");
            //新建一个方法，在此加入多表连接的语句end
            
            
            if (null != jc_renyuan_userParam.Fk_renyuan_id && "" != jc_renyuan_userParam.Fk_renyuan_id)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.FK_RENYUAN_ID=:fk_renyuan_id ");
                OracleParameter pFk_renyuan_id = new OracleParameter(":fk_renyuan_id", OracleDbType.Varchar2);
                pFk_renyuan_id.Direction = ParameterDirection.Input;
                pFk_renyuan_id.Value = jc_renyuan_userParam.Fk_renyuan_id;
                sqlparams.Add(pFk_renyuan_id);
            }
                
            if (null != jc_renyuan_userParam.Fk_user_id && "" != jc_renyuan_userParam.Fk_user_id)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.FK_USER_ID=:fk_user_id ");
                OracleParameter pFk_user_id = new OracleParameter(":fk_user_id", OracleDbType.Varchar2);
                pFk_user_id.Direction = ParameterDirection.Input;
                pFk_user_id.Value = jc_renyuan_userParam.Fk_user_id;
                sqlparams.Add(pFk_user_id);
            }
                
            if (null != jc_renyuan_userParam.Zfbz && "" != jc_renyuan_userParam.Zfbz)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.ZFBZ=:zfbz ");
                OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                pZfbz.Direction = ParameterDirection.Input;
                pZfbz.Value = jc_renyuan_userParam.Zfbz;
                sqlparams.Add(pZfbz);
            }
                
            if(jc_renyuan_userParamLike!=null)
            {

                if (null != jc_renyuan_userParamLike.Fk_renyuan_id && "" != jc_renyuan_userParamLike.Fk_renyuan_id)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.FK_RENYUAN_ID LIKE '%'||:fk_renyuan_id||'%' ");
                    OracleParameter pFk_renyuan_id = new OracleParameter(":fk_renyuan_id", OracleDbType.Varchar2);
                    pFk_renyuan_id.Direction = ParameterDirection.Input;
                    pFk_renyuan_id.Value = jc_renyuan_userParamLike.Fk_renyuan_id;
                    sqlparams.Add(pFk_renyuan_id);
                }
                
                if (null != jc_renyuan_userParamLike.Fk_user_id && "" != jc_renyuan_userParamLike.Fk_user_id)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.FK_USER_ID LIKE '%'||:fk_user_id||'%' ");
                    OracleParameter pFk_user_id = new OracleParameter(":fk_user_id", OracleDbType.Varchar2);
                    pFk_user_id.Direction = ParameterDirection.Input;
                    pFk_user_id.Value = jc_renyuan_userParamLike.Fk_user_id;
                    sqlparams.Add(pFk_user_id);
                }
                
                if (null != jc_renyuan_userParamLike.Zfbz && "" != jc_renyuan_userParamLike.Zfbz)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.ZFBZ LIKE '%'||:zfbz||'%' ");
                    OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                    pZfbz.Direction = ParameterDirection.Input;
                    pZfbz.Value = jc_renyuan_userParamLike.Zfbz;
                    sqlparams.Add(pZfbz);
                }
                
            }

            this.b_isWhere = false;
            this.addSort(sql, sortList);//排序
            //*******分页start1*********如果分页对象为空，则全部数据查出，如果不为空
            List<object> returnList = new List<object>();//返回的List,索引0为List<Jc_renyuan_user>对象,索引1为Model.Common.PageInfo分页信息对象
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
            //把每一行数据转换为一个对象放入List<Jc_renyuan_user>中
            for (int i = 0; i < rows.Count; i++)
            {
                DataRow row = rows[i];
                //jc_renyuan_userParamList.Add(this.dataSetContactObjectsToModel(row));
                jc_renyuan_userParamList.Add(this.dataSetToModel(row));
            }
            
             //*******分页start2*********如果没有传入分页对象，则新建一个分页对象当做返回值
            if (null == page)
            {
                page = new Model.Common.PageInfo();
                page.AllCount = rows.Count;
            }
            returnList.Add(jc_renyuan_userParamList);//把List<Jc_renyuan_user>放入List<object>中第一个
            returnList.Add(page);//把page对象放入List<object>中第二个
            //*******分页end2*********
            return returnList;
        }

        
        
        /// <summary>
        /// 根据条件得到集合的数量
        /// 第二个条件是模糊查询的条件
        /// </summary>
        /// <returns>int</returns>
        public int getCount(Jc_renyuan_user jc_renyuan_userParam,Jc_renyuan_user jc_renyuan_userParamLike)
        {
            //如果没有传查询条件参数，就new一个空的Jc_renyuan_user对象，标示查询所有数据
            if (null == jc_renyuan_userParam)
            {
                jc_renyuan_userParam = new Jc_renyuan_user();
            }
            List<OracleParameter> sqlparams = new List<OracleParameter>();//保存参数的集合
            StringBuilder sql = new StringBuilder("SELECT COUNT(ID) FROM JC_RENYUAN_USER A");
                if (null != jc_renyuan_userParam.Fk_renyuan_id && "" != jc_renyuan_userParam.Fk_renyuan_id)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.FK_RENYUAN_ID=:fk_renyuan_id ");
                    OracleParameter pFk_renyuan_id = new OracleParameter(":fk_renyuan_id", OracleDbType.Varchar2);
                pFk_renyuan_id.Value = jc_renyuan_userParam.Fk_renyuan_id;
                sqlparams.Add(pFk_renyuan_id);
                }
                
                if (null != jc_renyuan_userParam.Fk_user_id && "" != jc_renyuan_userParam.Fk_user_id)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.FK_USER_ID=:fk_user_id ");
                    OracleParameter pFk_user_id = new OracleParameter(":fk_user_id", OracleDbType.Varchar2);
                pFk_user_id.Value = jc_renyuan_userParam.Fk_user_id;
                sqlparams.Add(pFk_user_id);
                }
                
                if (null != jc_renyuan_userParam.Zfbz && "" != jc_renyuan_userParam.Zfbz)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.ZFBZ=:zfbz ");
                    OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                pZfbz.Value = jc_renyuan_userParam.Zfbz;
                sqlparams.Add(pZfbz);
                }
                
            if(jc_renyuan_userParamLike!=null)
            {

                if (null != jc_renyuan_userParamLike.Fk_renyuan_id && "" != jc_renyuan_userParamLike.Fk_renyuan_id)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.FK_RENYUAN_ID LIKE '%'||:fk_renyuan_id||'%' ");
                    OracleParameter pFk_renyuan_id = new OracleParameter(":fk_renyuan_id", OracleDbType.Varchar2);
                    pFk_renyuan_id.Direction = ParameterDirection.Input;
                    pFk_renyuan_id.Value = jc_renyuan_userParamLike.Fk_renyuan_id;
                    sqlparams.Add(pFk_renyuan_id);
                }
                
                if (null != jc_renyuan_userParamLike.Fk_user_id && "" != jc_renyuan_userParamLike.Fk_user_id)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.FK_USER_ID LIKE '%'||:fk_user_id||'%' ");
                    OracleParameter pFk_user_id = new OracleParameter(":fk_user_id", OracleDbType.Varchar2);
                    pFk_user_id.Direction = ParameterDirection.Input;
                    pFk_user_id.Value = jc_renyuan_userParamLike.Fk_user_id;
                    sqlparams.Add(pFk_user_id);
                }
                
                if (null != jc_renyuan_userParamLike.Zfbz && "" != jc_renyuan_userParamLike.Zfbz)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.ZFBZ LIKE '%'||:zfbz||'%' ");
                    OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                    pZfbz.Direction = ParameterDirection.Input;
                    pZfbz.Value = jc_renyuan_userParamLike.Zfbz;
                    sqlparams.Add(pZfbz);
                }
                
            }
this.b_isWhere = false;return Int32.Parse(OracleHelper.ExecuteScalar(sql.ToString(),sqlparams.ToArray()).ToString());
        }


        /// <summary>
        /// 通用的保存方法，根据用户传入的参数，有ID为修改，没有ID为新增(手动生成OracleConnection对象，此方法用于事务，使用事务必须使用同一个OracleConnection对象)
        /// </summary>
        /// <param name="jc_renyuan_userParam"></param>
        /// <returns></returns>
        public bool save(Jc_renyuan_user jc_renyuan_userParam,OracleConnection con)
        {
            if ("" != jc_renyuan_userParam.Id && null != jc_renyuan_userParam.Id)
            {
                //修改
                return this.updateById(jc_renyuan_userParam,con);
            }
            else
            {
                //新增
                return this.insert(jc_renyuan_userParam,con);
            }
        }

        /// <summary>
        /// 把dataset中的一行转换为model
        /// </summary>
        /// <param name="row"></param>
        /// <returns></returns>
        private Jc_renyuan_user dataSetToModel(DataRow row)
        {
            Jc_renyuan_user jc_renyuan_userParam = new Jc_renyuan_user();
            jc_renyuan_userParam.Id = Convert.ToString(row["ID"]).Trim(); 
            jc_renyuan_userParam.Fk_renyuan_id = Convert.ToString(row["FK_RENYUAN_ID"]).Trim(); 
            jc_renyuan_userParam.Fk_user_id = Convert.ToString(row["FK_USER_ID"]).Trim(); 
            jc_renyuan_userParam.Zfbz = Convert.ToString(row["ZFBZ"]).Trim(); 
            
            return jc_renyuan_userParam;
        }

       
        
        //*******************在此以后添加新的方法start
        #region DAL层的implement,实现，start

        /// <summary>
        /// 把dataset中的一行转换为model, 包括相关联的外键对象
        /// </summary>
        /// <param name="row"></param>
        /// <returns></returns>
        private Jc_renyuan_user dataSetContactObjectsToModel(DataRow row)
        {
            Jc_renyuan_user jc_renyuan_userParam = this.dataSetToModel(row);

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

            jc_renyuan_userParam.Jc_renyuan = jc_renyuan;
            #endregion 添加Jc_renyuan类别实体对象

            #region 添加Rbac_user类别实体对象
            Rbac_user rbac_user = new Rbac_user();
            rbac_user.Id = Convert.ToString(row["RR_ID"]).Trim();
            rbac_user.Name = Convert.ToString(row["RR_NAME"]).Trim();
            rbac_user.Pwd = Convert.ToString(row["RR_PWD"]).Trim();
            rbac_user.Lx_code = Convert.ToString(row["RR_LX_CODE"]).Trim();
            rbac_user.Remark = Convert.ToString(row["RR_REMARK"]).Trim();
            rbac_user.Zfbz = Convert.ToString(row["RR_ZFBZ"]).Trim();
            rbac_user.Cjrq = (DateTime)row["RR_CJRQ"];

            jc_renyuan_userParam.Rbac_user = rbac_user;
            #endregion 添加Rbac_user类别实体对象

            return jc_renyuan_userParam;
        }



        /// <summary>
        /// 查找指定ID的用户,得到相关联的外键对象的方法
        /// </summary>
        /// <remarks>如果id为null、id重复、id未找到就抛异常</remarks>
        /// <returns>Jc_renyuan_user</returns>
        public Jc_renyuan_user findContactObjectsById(string id)
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
            ,TT_RBAC_USER.ID AS RR_ID
            ,TT_RBAC_USER.NAME AS RR_NAME
            ,TT_RBAC_USER.PWD AS RR_PWD
            ,TT_RBAC_USER.LX_CODE AS RR_LX_CODE
            ,TT_RBAC_USER.REMARK AS RR_REMARK
            ,TT_RBAC_USER.ZFBZ AS RR_ZFBZ
            ,TT_RBAC_USER.CJRQ AS RR_CJRQ
            ");

            //新建方法，在此加入多表连接要显示的项end
            sql.Append(" FROM JC_RENYUAN_USER A ");
            //新建一个方法，在此加入多表连接的语句start
            //sql.Append("LEFT JOIN 外键表名 B ON A.外键=B.ID");

            sql.Append(@"
            LEFT JOIN JC_RENYUAN TT_JC_RENYUAN 
            ON A.FK_RENYUAN_ID = TT_JC_RENYUAN.ID

            ");

            sql.Append(@"
            LEFT JOIN RBAC_USER TT_RBAC_USER 
            ON A.FK_USER_ID = TT_RBAC_USER.ID

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
        /// <param name="jc_renyuan_userParam"></param>
        /// <param name="page">分页对象</param>
        ///<param name="jc_renyuan_userParamLike">模糊查询参数</param>
        ///<param name="sortList">排序参数对象的集合</param>
        /// <returns>满足条件的所有Jc_renyuan_user对象集合list</returns>
        public List<object> findContactObjects(Jc_renyuan_user jc_renyuan_userParam, Model.Common.PageInfo page, Jc_renyuan_user jc_renyuan_userParamLike, List<SortInfo> sortList)
        {
            //如果没有传查询条件参数，就new一个空的Jc_renyuan_user对象，标示查询所有数据
            if (null == jc_renyuan_userParam)
            {
                jc_renyuan_userParam = new Jc_renyuan_user();
            }
            if (null != jc_renyuan_userParam.Id && "" != jc_renyuan_userParam.Id)
            {
                throw new Exception("此方法不允许指定参数ID，如果需要根据ID查询数据，请调用findById方法；错误出自：find");
            }

            List<Jc_renyuan_user> jc_renyuan_userParamList = new List<Jc_renyuan_user>();//接收查询出的Jc_renyuan_user对象集合
            List<OracleParameter> sqlparams = new List<OracleParameter>();//保存参数的集合
            StringBuilder sql = new StringBuilder("SELECT A.* ");
            //新建方法findAllContactObjects(Jc_renyuan_user jc_renyuan_userParam, Model.Common.PageInfo page)，在此加入多表连接要显示的项start
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
            ,TT_RBAC_USER.ID AS RR_ID
            ,TT_RBAC_USER.NAME AS RR_NAME
            ,TT_RBAC_USER.PWD AS RR_PWD
            ,TT_RBAC_USER.LX_CODE AS RR_LX_CODE
            ,TT_RBAC_USER.REMARK AS RR_REMARK
            ,TT_RBAC_USER.ZFBZ AS RR_ZFBZ
            ,TT_RBAC_USER.CJRQ AS RR_CJRQ
            ");

            //新建方法，在此加入多表连接要显示的项end
            sql.Append(" FROM JC_RENYUAN_USER A ");
            //新建一个方法，在此加入多表连接的语句start
            ////sql.Append(" LEFT JOIN 表名 B ON A.外键=B.ID");

            sql.Append(@"
            LEFT JOIN JC_RENYUAN TT_JC_RENYUAN 
            ON A.FK_RENYUAN_ID = TT_JC_RENYUAN.ID

            ");

            sql.Append(@"
            LEFT JOIN RBAC_USER TT_RBAC_USER 
            ON A.FK_USER_ID = TT_RBAC_USER.ID

            ");

            //新建一个方法，在此加入多表连接的语句end


            if (null != jc_renyuan_userParam.Fk_renyuan_id && "" != jc_renyuan_userParam.Fk_renyuan_id)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.FK_RENYUAN_ID=:fk_renyuan_id ");
                OracleParameter pFk_renyuan_id = new OracleParameter(":fk_renyuan_id", OracleDbType.Varchar2);
                pFk_renyuan_id.Value = jc_renyuan_userParam.Fk_renyuan_id;
                sqlparams.Add(pFk_renyuan_id);
            }

            if (null != jc_renyuan_userParam.Fk_user_id && "" != jc_renyuan_userParam.Fk_user_id)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.FK_USER_ID=:fk_user_id ");
                OracleParameter pFk_user_id = new OracleParameter(":fk_user_id", OracleDbType.Varchar2);
                pFk_user_id.Value = jc_renyuan_userParam.Fk_user_id;
                sqlparams.Add(pFk_user_id);
            }

            if (null != jc_renyuan_userParam.Zfbz && "" != jc_renyuan_userParam.Zfbz)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.ZFBZ=:zfbz ");
                OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                pZfbz.Value = jc_renyuan_userParam.Zfbz;
                sqlparams.Add(pZfbz);
            }

            if (jc_renyuan_userParamLike != null)
            {

                if (null != jc_renyuan_userParamLike.Fk_renyuan_id && "" != jc_renyuan_userParamLike.Fk_renyuan_id)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.FK_RENYUAN_ID LIKE '%'||:fk_renyuan_id||'%' ");
                    OracleParameter pFk_renyuan_id = new OracleParameter(":fk_renyuan_id", OracleDbType.Varchar2);
                    pFk_renyuan_id.Direction = ParameterDirection.Input;
                    pFk_renyuan_id.Value = jc_renyuan_userParamLike.Fk_renyuan_id;
                    sqlparams.Add(pFk_renyuan_id);
                }

                if (null != jc_renyuan_userParamLike.Fk_user_id && "" != jc_renyuan_userParamLike.Fk_user_id)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.FK_USER_ID LIKE '%'||:fk_user_id||'%' ");
                    OracleParameter pFk_user_id = new OracleParameter(":fk_user_id", OracleDbType.Varchar2);
                    pFk_user_id.Direction = ParameterDirection.Input;
                    pFk_user_id.Value = jc_renyuan_userParamLike.Fk_user_id;
                    sqlparams.Add(pFk_user_id);
                }

                if (null != jc_renyuan_userParamLike.Zfbz && "" != jc_renyuan_userParamLike.Zfbz)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.ZFBZ LIKE '%'||:zfbz||'%' ");
                    OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                    pZfbz.Direction = ParameterDirection.Input;
                    pZfbz.Value = jc_renyuan_userParamLike.Zfbz;
                    sqlparams.Add(pZfbz);
                }

            }

            if (null != jc_renyuan_userParam.Jc_renyuan)
            {

                if (null != jc_renyuan_userParam.Jc_renyuan.Id && null != jc_renyuan_userParam.Jc_renyuan.Id)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" TT_JC_RENYUAN.ID=:id ");
                    OracleParameter pId = new OracleParameter(":id", OracleDbType.Varchar2);
                    pId.Value = jc_renyuan_userParam.Jc_renyuan.Id;
                    sqlparams.Add(pId);
                }

                if (null != jc_renyuan_userParam.Jc_renyuan.Xm && null != jc_renyuan_userParam.Jc_renyuan.Xm)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" TT_JC_RENYUAN.XM=:xm ");
                    OracleParameter pXm = new OracleParameter(":xm", OracleDbType.NVarchar2);
                    pXm.Value = jc_renyuan_userParam.Jc_renyuan.Xm;
                    sqlparams.Add(pXm);
                }

                if (null != jc_renyuan_userParam.Jc_renyuan.Xb_code && null != jc_renyuan_userParam.Jc_renyuan.Xb_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" TT_JC_RENYUAN.XB_CODE=:xb_code ");
                    OracleParameter pXb_code = new OracleParameter(":xb_code", OracleDbType.NVarchar2);
                    pXb_code.Value = jc_renyuan_userParam.Jc_renyuan.Xb_code;
                    sqlparams.Add(pXb_code);
                }

                if (null != jc_renyuan_userParam.Jc_renyuan.Mz_code && null != jc_renyuan_userParam.Jc_renyuan.Mz_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" TT_JC_RENYUAN.MZ_CODE=:mz_code ");
                    OracleParameter pMz_code = new OracleParameter(":mz_code", OracleDbType.NVarchar2);
                    pMz_code.Value = jc_renyuan_userParam.Jc_renyuan.Mz_code;
                    sqlparams.Add(pMz_code);
                }

                if (DateTime.MinValue != jc_renyuan_userParam.Jc_renyuan.Csrq && null != jc_renyuan_userParam.Jc_renyuan.Csrq)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" TT_JC_RENYUAN.CSRQ=:csrq ");
                    OracleParameter pCsrq = new OracleParameter(":csrq", OracleDbType.Date);
                    pCsrq.Value = jc_renyuan_userParam.Jc_renyuan.Csrq;
                    sqlparams.Add(pCsrq);
                }

                if (null != jc_renyuan_userParam.Jc_renyuan.Sfzh && null != jc_renyuan_userParam.Jc_renyuan.Sfzh)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" TT_JC_RENYUAN.SFZH=:sfzh ");
                    OracleParameter pSfzh = new OracleParameter(":sfzh", OracleDbType.NVarchar2);
                    pSfzh.Value = jc_renyuan_userParam.Jc_renyuan.Sfzh;
                    sqlparams.Add(pSfzh);
                }

                if (null != jc_renyuan_userParam.Jc_renyuan.Zzmm_code && null != jc_renyuan_userParam.Jc_renyuan.Zzmm_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" TT_JC_RENYUAN.ZZMM_CODE=:zzmm_code ");
                    OracleParameter pZzmm_code = new OracleParameter(":zzmm_code", OracleDbType.NVarchar2);
                    pZzmm_code.Value = jc_renyuan_userParam.Jc_renyuan.Zzmm_code;
                    sqlparams.Add(pZzmm_code);
                }

                if (null != jc_renyuan_userParam.Jc_renyuan.Hyzk_code && null != jc_renyuan_userParam.Jc_renyuan.Hyzk_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" TT_JC_RENYUAN.HYZK_CODE=:hyzk_code ");
                    OracleParameter pHyzk_code = new OracleParameter(":hyzk_code", OracleDbType.NVarchar2);
                    pHyzk_code.Value = jc_renyuan_userParam.Jc_renyuan.Hyzk_code;
                    sqlparams.Add(pHyzk_code);
                }

                if (null != jc_renyuan_userParam.Jc_renyuan.Byxx && null != jc_renyuan_userParam.Jc_renyuan.Byxx)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" TT_JC_RENYUAN.BYXX=:byxx ");
                    OracleParameter pByxx = new OracleParameter(":byxx", OracleDbType.NVarchar2);
                    pByxx.Value = jc_renyuan_userParam.Jc_renyuan.Byxx;
                    sqlparams.Add(pByxx);
                }

                if (null != jc_renyuan_userParam.Jc_renyuan.Xl_code && null != jc_renyuan_userParam.Jc_renyuan.Xl_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" TT_JC_RENYUAN.XL_CODE=:xl_code ");
                    OracleParameter pXl_code = new OracleParameter(":xl_code", OracleDbType.NVarchar2);
                    pXl_code.Value = jc_renyuan_userParam.Jc_renyuan.Xl_code;
                    sqlparams.Add(pXl_code);
                }

                if (DateTime.MinValue != jc_renyuan_userParam.Jc_renyuan.Cjgzsj && null != jc_renyuan_userParam.Jc_renyuan.Cjgzsj)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" TT_JC_RENYUAN.CJGZSJ=:cjgzsj ");
                    OracleParameter pCjgzsj = new OracleParameter(":cjgzsj", OracleDbType.Date);
                    pCjgzsj.Value = jc_renyuan_userParam.Jc_renyuan.Cjgzsj;
                    sqlparams.Add(pCjgzsj);
                }

                if (null != jc_renyuan_userParam.Jc_renyuan.Zy && null != jc_renyuan_userParam.Jc_renyuan.Zy)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" TT_JC_RENYUAN.ZY=:zy ");
                    OracleParameter pZy = new OracleParameter(":zy", OracleDbType.NVarchar2);
                    pZy.Value = jc_renyuan_userParam.Jc_renyuan.Zy;
                    sqlparams.Add(pZy);
                }

                if (null != jc_renyuan_userParam.Jc_renyuan.Jg && null != jc_renyuan_userParam.Jc_renyuan.Jg)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" TT_JC_RENYUAN.JG=:jg ");
                    OracleParameter pJg = new OracleParameter(":jg", OracleDbType.NVarchar2);
                    pJg.Value = jc_renyuan_userParam.Jc_renyuan.Jg;
                    sqlparams.Add(pJg);
                }

                if (null != jc_renyuan_userParam.Jc_renyuan.Dz && null != jc_renyuan_userParam.Jc_renyuan.Dz)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" TT_JC_RENYUAN.DZ=:dz ");
                    OracleParameter pDz = new OracleParameter(":dz", OracleDbType.NVarchar2);
                    pDz.Value = jc_renyuan_userParam.Jc_renyuan.Dz;
                    sqlparams.Add(pDz);
                }

                if (null != jc_renyuan_userParam.Jc_renyuan.Lxdh && null != jc_renyuan_userParam.Jc_renyuan.Lxdh)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" TT_JC_RENYUAN.LXDH=:lxdh ");
                    OracleParameter pLxdh = new OracleParameter(":lxdh", OracleDbType.NVarchar2);
                    pLxdh.Value = jc_renyuan_userParam.Jc_renyuan.Lxdh;
                    sqlparams.Add(pLxdh);
                }

                if (null != jc_renyuan_userParam.Jc_renyuan.Qq && null != jc_renyuan_userParam.Jc_renyuan.Qq)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" TT_JC_RENYUAN.QQ=:qq ");
                    OracleParameter pQq = new OracleParameter(":qq", OracleDbType.NVarchar2);
                    pQq.Value = jc_renyuan_userParam.Jc_renyuan.Qq;
                    sqlparams.Add(pQq);
                }

                if (null != jc_renyuan_userParam.Jc_renyuan.Yx && null != jc_renyuan_userParam.Jc_renyuan.Yx)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" TT_JC_RENYUAN.YX=:yx ");
                    OracleParameter pYx = new OracleParameter(":yx", OracleDbType.NVarchar2);
                    pYx.Value = jc_renyuan_userParam.Jc_renyuan.Yx;
                    sqlparams.Add(pYx);
                }

                if (null != jc_renyuan_userParam.Jc_renyuan.Bz && null != jc_renyuan_userParam.Jc_renyuan.Bz)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" TT_JC_RENYUAN.BZ=:bz ");
                    OracleParameter pBz = new OracleParameter(":bz", OracleDbType.NVarchar2);
                    pBz.Value = jc_renyuan_userParam.Jc_renyuan.Bz;
                    sqlparams.Add(pBz);
                }

                if (null != jc_renyuan_userParam.Jc_renyuan.Pym && null != jc_renyuan_userParam.Jc_renyuan.Pym)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" TT_JC_RENYUAN.PYM=:pym ");
                    OracleParameter pPym = new OracleParameter(":pym", OracleDbType.NVarchar2);
                    pPym.Value = jc_renyuan_userParam.Jc_renyuan.Pym;
                    sqlparams.Add(pPym);
                }

                if (null != jc_renyuan_userParam.Jc_renyuan.Wbm && null != jc_renyuan_userParam.Jc_renyuan.Wbm)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" TT_JC_RENYUAN.WBM=:wbm ");
                    OracleParameter pWbm = new OracleParameter(":wbm", OracleDbType.NVarchar2);
                    pWbm.Value = jc_renyuan_userParam.Jc_renyuan.Wbm;
                    sqlparams.Add(pWbm);
                }

                if (null != jc_renyuan_userParam.Jc_renyuan.Rylx_code && null != jc_renyuan_userParam.Jc_renyuan.Rylx_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" TT_JC_RENYUAN.RYLX_CODE=:rylx_code ");
                    OracleParameter pRylx_code = new OracleParameter(":rylx_code", OracleDbType.NVarchar2);
                    pRylx_code.Value = jc_renyuan_userParam.Jc_renyuan.Rylx_code;
                    sqlparams.Add(pRylx_code);
                }

                if (null != jc_renyuan_userParam.Jc_renyuan.Zfbz && null != jc_renyuan_userParam.Jc_renyuan.Zfbz)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" TT_JC_RENYUAN.ZFBZ=:zfbz ");
                    OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                    pZfbz.Value = jc_renyuan_userParam.Jc_renyuan.Zfbz;
                    sqlparams.Add(pZfbz);
                }

            }

            if (null != jc_renyuan_userParam.Rbac_user)
            {

                if (null != jc_renyuan_userParam.Rbac_user.Id && null != jc_renyuan_userParam.Rbac_user.Id)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" TT_RBAC_USER.ID=:id ");
                    OracleParameter pId = new OracleParameter(":id", OracleDbType.Varchar2);
                    pId.Value = jc_renyuan_userParam.Rbac_user.Id;
                    sqlparams.Add(pId);
                }

                if (null != jc_renyuan_userParam.Rbac_user.Name && null != jc_renyuan_userParam.Rbac_user.Name)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" TT_RBAC_USER.NAME=:name ");
                    OracleParameter pName = new OracleParameter(":name", OracleDbType.NVarchar2);
                    pName.Value = jc_renyuan_userParam.Rbac_user.Name;
                    sqlparams.Add(pName);
                }

                if (null != jc_renyuan_userParam.Rbac_user.Pwd && null != jc_renyuan_userParam.Rbac_user.Pwd)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" TT_RBAC_USER.PWD=:pwd ");
                    OracleParameter pPwd = new OracleParameter(":pwd", OracleDbType.Varchar2);
                    pPwd.Value = jc_renyuan_userParam.Rbac_user.Pwd;
                    sqlparams.Add(pPwd);
                }

                if (null != jc_renyuan_userParam.Rbac_user.Lx_code && null != jc_renyuan_userParam.Rbac_user.Lx_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" TT_RBAC_USER.LX_CODE=:lx_code ");
                    OracleParameter pLx_code = new OracleParameter(":lx_code", OracleDbType.NVarchar2);
                    pLx_code.Value = jc_renyuan_userParam.Rbac_user.Lx_code;
                    sqlparams.Add(pLx_code);
                }

                if (null != jc_renyuan_userParam.Rbac_user.Remark && null != jc_renyuan_userParam.Rbac_user.Remark)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" TT_RBAC_USER.REMARK=:remark ");
                    OracleParameter pRemark = new OracleParameter(":remark", OracleDbType.NVarchar2);
                    pRemark.Value = jc_renyuan_userParam.Rbac_user.Remark;
                    sqlparams.Add(pRemark);
                }

                if (null != jc_renyuan_userParam.Rbac_user.Zfbz && null != jc_renyuan_userParam.Rbac_user.Zfbz)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" TT_RBAC_USER.ZFBZ=:zfbz ");
                    OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                    pZfbz.Value = jc_renyuan_userParam.Rbac_user.Zfbz;
                    sqlparams.Add(pZfbz);
                }

                if (DateTime.MinValue != jc_renyuan_userParam.Rbac_user.Cjrq && null != jc_renyuan_userParam.Rbac_user.Cjrq)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" TT_RBAC_USER.CJRQ=:cjrq ");
                    OracleParameter pCjrq = new OracleParameter(":cjrq", OracleDbType.Date);
                    pCjrq.Value = jc_renyuan_userParam.Rbac_user.Cjrq;
                    sqlparams.Add(pCjrq);
                }

            }

           

            

            this.b_isWhere = false;
            //排序
            this.addSort(sql, sortList);
            //*******分页start1*********如果分页对象为空，则全部数据查出，如果不为空
            List<object> returnList = new List<object>();//返回的List,索引0为List<Jc_renyuan_user>对象,索引1为Model.Common.PageInfo分页信息对象
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
            //把每一行数据转换为一个对象放入List<Jc_renyuan_user>中
            for (int i = 0; i < rows.Count; i++)
            {
                DataRow row = rows[i];
                jc_renyuan_userParamList.Add(this.dataSetContactObjectsToModel(row));
                //jc_renyuan_userParamList.Add(this.dataSetToModel(row));
            }

            //*******分页start2*********如果没有传入分页对象，则新建一个分页对象当做返回值
            if (null == page)
            {
                page = new Model.Common.PageInfo();
                page.AllCount = rows.Count;
            }
            returnList.Add(jc_renyuan_userParamList);//把List<Jc_renyuan_user>放入List<object>中第一个
            returnList.Add(page);//把page对象放入List<object>中第二个
            //*******分页end2*********
            return returnList;
        }
        #endregion DAL层的implement,实现，end

        


        //*******************在此以后添加新的方法end
        
    }
}


