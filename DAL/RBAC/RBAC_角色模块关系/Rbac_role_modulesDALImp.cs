

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAL.Common;
using System.Transactions;//引入事务
using Oracle.DataAccess.Client;//引入oracle驱动
using Model.RBAC;
using Model.Common;

namespace DAL.RBAC.RBAC_角色模块关系
{
    /// <summary>
    ///数据库访问层的Rbac_role_modules实现类
    ///此类由代码生成器生成
    ///表名：RBAC_ROLE_MODULES
    ///生成日期：2015-12-02 16:34:45
    /// 

    ///作者：罗新鑫
    ///联系电话：15087010221
    ///联系邮箱：362527240@qq.com
        
    /// </summary>
    public class Rbac_role_modulesDALImp :Base.BasDAL,Rbac_role_modulesDAL
    {

        /// <summary>
        /// 插入一条数据（如果需要供事务使用就传入OracleConnection对象，如果不供就传入null，方法自动生成OracleConnection对象）
        /// 主键为null时，自动生成主键guid，一般不直接调用此方法，请调用save方法进行单条数据的插入和修改       
        /// </summary>
        /// <param name="rbac_role_modulesParam">要插入的rbac_role_modulesParam对象</param>
        /// <param name="con">Oracle连接对象（为null时自动生成）</param>
        /// <returns>是否添加成功（影响的行数为1时成功）</returns>
        public bool insert(Rbac_role_modules rbac_role_modulesParam,OracleConnection con)
        {
            if (""==rbac_role_modulesParam.Id||null==rbac_role_modulesParam.Id)
            {
                rbac_role_modulesParam.Id = Model.Common.GUIDHelper.getGuid();
            }
            List<OracleParameter> sqlparams = new List<OracleParameter>();
            
            StringBuilder sql = new StringBuilder("INSERT INTO RBAC_ROLE_MODULES(id,fk_role_id,fk_modules_id,zfbz) VALUES(:id,:fk_role_id,:fk_modules_id,:zfbz)");
            
            OracleParameter pId = new OracleParameter(":id", OracleDbType.Varchar2);
            pId.Direction = ParameterDirection.Input;
            pId.Value = rbac_role_modulesParam.Id;
            sqlparams.Add(pId);
            OracleParameter pFk_role_id = new OracleParameter(":fk_role_id", OracleDbType.Varchar2);
            pFk_role_id.Direction = ParameterDirection.Input;
            pFk_role_id.Value = rbac_role_modulesParam.Fk_role_id;
            sqlparams.Add(pFk_role_id);
            OracleParameter pFk_modules_id = new OracleParameter(":fk_modules_id", OracleDbType.Varchar2);
            pFk_modules_id.Direction = ParameterDirection.Input;
            pFk_modules_id.Value = rbac_role_modulesParam.Fk_modules_id;
            sqlparams.Add(pFk_modules_id);
            OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
            pZfbz.Direction = ParameterDirection.Input;
            pZfbz.Value = rbac_role_modulesParam.Zfbz;
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
        /// <param name="rbac_role_modulesParamList">要插入的rbac_role_modulesParam对象的集合</param>
        /// <param name="con">Oracle连接对象（为null时自动生成）</param>
        /// <returns>是否添加成功（影响的行数等于保存的对象的数量时成功）</returns>
        public bool inertBatch(List<Rbac_role_modules> rbac_role_modulesParamList, OracleConnection con)
        {
            if (rbac_role_modulesParamList.Count == 0)
            {
                return true;
            }
            List<string> idList = new List<string>();

            List<string> fk_role_idList = new List<string>();

            List<string> fk_modules_idList = new List<string>();

            List<string> zfbzList = new List<string>();

            for (int i = 0; i < rbac_role_modulesParamList.Count; i++)
            {
                Rbac_role_modules rbac_role_modulesParam = rbac_role_modulesParamList[i];
                if ("" == rbac_role_modulesParam.Id || null == rbac_role_modulesParam.Id)
                {
                    rbac_role_modulesParam.Id = Model.Common.GUIDHelper.getGuid();
                }

            idList.Add(rbac_role_modulesParam.Id);

            fk_role_idList.Add(rbac_role_modulesParam.Fk_role_id);

            fk_modules_idList.Add(rbac_role_modulesParam.Fk_modules_id);

            zfbzList.Add(rbac_role_modulesParam.Zfbz);

            }

            List<OracleParameter> sqlparams = new List<OracleParameter>();

            StringBuilder sql = new StringBuilder("INSERT INTO RBAC_ROLE_MODULES(id,fk_role_id,fk_modules_id,zfbz) VALUES(:id,:fk_role_id,:fk_modules_id,:zfbz)");
            
            OracleParameter pId = new OracleParameter(":id", OracleDbType.Varchar2);
            pId.Direction = ParameterDirection.Input;
            pId.Value = idList.ToArray();
            sqlparams.Add(pId);
            OracleParameter pFk_role_id = new OracleParameter(":fk_role_id", OracleDbType.Varchar2);
            pFk_role_id.Direction = ParameterDirection.Input;
            pFk_role_id.Value = fk_role_idList.ToArray();
            sqlparams.Add(pFk_role_id);
            OracleParameter pFk_modules_id = new OracleParameter(":fk_modules_id", OracleDbType.Varchar2);
            pFk_modules_id.Direction = ParameterDirection.Input;
            pFk_modules_id.Value = fk_modules_idList.ToArray();
            sqlparams.Add(pFk_modules_id);
            OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
            pZfbz.Direction = ParameterDirection.Input;
            pZfbz.Value = zfbzList.ToArray();
            sqlparams.Add(pZfbz);
            bool result = false;
            int flag = -1;
            flag = OracleHelper.ExecuteBatch(sql.ToString(), con, rbac_role_modulesParamList.Count, sqlparams.ToArray());
            if (rbac_role_modulesParamList.Count == flag)
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
            StringBuilder sql = new StringBuilder("DELETE RBAC_ROLE_MODULES WHERE ID=:id");
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
            StringBuilder sql = new StringBuilder("DELETE RBAC_ROLE_MODULES WHERE ID=:id");
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
        /// <param name="rbac_role_modulesParamCondition">删除的条件</param>
        /// <param name="con">Oracle连接对象（为null时自动生成）</param>
        /// <returns>无法确定删除的行数（影响行数大于等于0就算成功）</returns>
        public bool deleteByOtherCondition(Rbac_role_modules rbac_role_modulesParamCondition, OracleConnection con)
        {
            if (null!=rbac_role_modulesParamCondition.Id&&""!=rbac_role_modulesParamCondition.Id)
            {
                throw new Exception("不允许指定参数的ID，如果要根据ID删除数据请调用deleteById或者deleteByIdBatch方法；错误出自：deleteByOtherCondition");
            }
            List<OracleParameter> sqlparams = new List<OracleParameter>();
            StringBuilder sql = new StringBuilder("DELETE RBAC_ROLE_MODULES ");

            if (null != rbac_role_modulesParamCondition.Fk_role_id &&  ""!= rbac_role_modulesParamCondition.Fk_role_id)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" FK_ROLE_ID=:fk_role_id ");
                OracleParameter pFk_role_id = new OracleParameter(":fk_role_id", OracleDbType.Varchar2);
                pFk_role_id.Direction = ParameterDirection.Input;
                pFk_role_id.Value = rbac_role_modulesParamCondition.Fk_role_id;
                sqlparams.Add(pFk_role_id);

            }
                        
            if (null != rbac_role_modulesParamCondition.Fk_modules_id &&  ""!= rbac_role_modulesParamCondition.Fk_modules_id)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" FK_MODULES_ID=:fk_modules_id ");
                OracleParameter pFk_modules_id = new OracleParameter(":fk_modules_id", OracleDbType.Varchar2);
                pFk_modules_id.Direction = ParameterDirection.Input;
                pFk_modules_id.Value = rbac_role_modulesParamCondition.Fk_modules_id;
                sqlparams.Add(pFk_modules_id);

            }
                        
            if (null != rbac_role_modulesParamCondition.Zfbz &&  ""!= rbac_role_modulesParamCondition.Zfbz)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" ZFBZ=:zfbz ");
                OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                pZfbz.Direction = ParameterDirection.Input;
                pZfbz.Value = rbac_role_modulesParamCondition.Zfbz;
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
        /// <param name="rbac_role_modulesParam"></param>
        /// <returns>影响的行数</returns>
        public bool updateById(Rbac_role_modules rbac_role_modulesParam,OracleConnection con)
        {
            if ("" == rbac_role_modulesParam.Id || null == rbac_role_modulesParam.Id)
            {
                throw new Exception("ID不允许为空，请赋值后调用；错误出自：updateById");
            }
            List<OracleParameter> sqlparams = new List<OracleParameter>();

            StringBuilder sql = new StringBuilder("UPDATE RBAC_ROLE_MODULES SET ");
            if (null != rbac_role_modulesParam.Fk_role_id &&  ""!= rbac_role_modulesParam.Fk_role_id)
            {
                this.isComma(sql);
                sql.Append(" FK_ROLE_ID=:fk_role_id ");
                OracleParameter pFk_role_id = new OracleParameter(":fk_role_id", OracleDbType.Varchar2);
                pFk_role_id.Direction = ParameterDirection.Input;
                pFk_role_id.Value = rbac_role_modulesParam.Fk_role_id;
                sqlparams.Add(pFk_role_id);

            }
                        
            if (null != rbac_role_modulesParam.Fk_modules_id &&  ""!= rbac_role_modulesParam.Fk_modules_id)
            {
                this.isComma(sql);
                sql.Append(" FK_MODULES_ID=:fk_modules_id ");
                OracleParameter pFk_modules_id = new OracleParameter(":fk_modules_id", OracleDbType.Varchar2);
                pFk_modules_id.Direction = ParameterDirection.Input;
                pFk_modules_id.Value = rbac_role_modulesParam.Fk_modules_id;
                sqlparams.Add(pFk_modules_id);

            }
                        
            if (null != rbac_role_modulesParam.Zfbz &&  ""!= rbac_role_modulesParam.Zfbz)
            {
                this.isComma(sql);
                sql.Append(" ZFBZ=:zfbz ");
                OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                pZfbz.Direction = ParameterDirection.Input;
                pZfbz.Value = rbac_role_modulesParam.Zfbz;
                sqlparams.Add(pZfbz);

            }
                        
            sql.Append(" WHERE ID=:id ");
            OracleParameter pId = new OracleParameter(":id", OracleDbType.Varchar2);
            pId.Value = rbac_role_modulesParam.Id;
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
        /// <param name="rbac_role_modulesParamList">要修改的Rbac_role_modules对象集合</param>
        /// <param name="con">Oracle连接对象（为null时自动生成）</param>
        /// <returns>是否删除成功（影响的行数等于要修改的对象数量时成功）</returns>
        public bool updateByIdBatch(List<Rbac_role_modules> rbac_role_modulesParamList, OracleConnection con)
        {


            List<string> idList = new List<string>();

            List<string> fk_role_idList = new List<string>();

            List<string> fk_modules_idList = new List<string>();

            List<string> zfbzList = new List<string>();

            for (int i = 0; i < rbac_role_modulesParamList.Count; i++)
            {
                Rbac_role_modules rbac_role_modulesParam = rbac_role_modulesParamList[i];
                if ("" == rbac_role_modulesParam.Id || null == rbac_role_modulesParam.Id)
                {
                    throw new Exception("下标为" + i + "的数据，ID不能为空，请赋值后调用；错误出自：updateByIdBatch");
                }

            idList.Add(rbac_role_modulesParam.Id);

            fk_role_idList.Add(rbac_role_modulesParam.Fk_role_id);

            fk_modules_idList.Add(rbac_role_modulesParam.Fk_modules_id);

            zfbzList.Add(rbac_role_modulesParam.Zfbz);

            }


            
            List<OracleParameter> sqlparams = new List<OracleParameter>();

            StringBuilder sql = new StringBuilder("UPDATE RBAC_ROLE_MODULES SET ");
            this.isComma(sql);
            sql.Append(" FK_ROLE_ID=:fk_role_id ");
            OracleParameter pFk_role_id = new OracleParameter(":fk_role_id", OracleDbType.Varchar2);
            pFk_role_id.Direction = ParameterDirection.Input;
            pFk_role_id.Value = fk_role_idList.ToArray();
            sqlparams.Add(pFk_role_id);

            this.isComma(sql);
            sql.Append(" FK_MODULES_ID=:fk_modules_id ");
            OracleParameter pFk_modules_id = new OracleParameter(":fk_modules_id", OracleDbType.Varchar2);
            pFk_modules_id.Direction = ParameterDirection.Input;
            pFk_modules_id.Value = fk_modules_idList.ToArray();
            sqlparams.Add(pFk_modules_id);

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
            int flag = OracleHelper.ExecuteBatch(sql.ToString(), con,rbac_role_modulesParamList.Count, sqlparams.ToArray());
            if (rbac_role_modulesParamList.Count == flag)
            {
                result = true;
            }
            return result;
        }

        /// <summary>
        /// 根据更新的条件，更新数据（如果需要供事务使用就传入OracleConnection对象，如果不供就传入null，方法自动生成OracleConnection对象）
        /// 不指定ID，如果要根据ID来更新数据，请使用updateForId方法
        /// </summary>
        /// <param name="rbac_role_modulesParamCondition">条件对象</param>
        /// <param name="rbac_role_modulesParamUpdate">要更新的数据对象</param>
        /// <param name="con">Oracle连接对象（为null时自动生成）</param>
        /// <returns>影响的行数不确定（不为-1就正确）</returns>
        public bool updateByOtherCondition(Rbac_role_modules rbac_role_modulesParamCondition, Rbac_role_modules rbac_role_modulesParamUpdate, OracleConnection con)
        {
            if ((null!=rbac_role_modulesParamCondition.Id&&"!=rbac_role_modulesParamCondition.Id)||(null!=rbac_role_modulesParamUpdate.Id&&"!=rbac_role_modulesParamUpdate.Id))
            {
                throw new Exception("此方法不允许指定参数的ID，数据库中的ID不允许修改，如需根据ID修改数据，请调用updateById或updateByIdBatch方法；错误出自：updateByOtherCondition");
            }
            List<OracleParameter> sqlparams = new List<OracleParameter>();
            //添加要修改的值
            StringBuilder sql = new StringBuilder("UPDATE RBAC_ROLE_MODULES SET ");
            if (null != rbac_role_modulesParamUpdate.Fk_role_id &&  ""!= rbac_role_modulesParamUpdate.Fk_role_id)
            {
                this.isComma(sql);
                sql.Append(" FK_ROLE_ID=:fk_role_id ");
                OracleParameter pFk_role_id = new OracleParameter(":fk_role_id", OracleDbType.Varchar2);
                pFk_role_id.Direction = ParameterDirection.Input;
                pFk_role_id.Value = rbac_role_modulesParamUpdate.Fk_role_id;
                sqlparams.Add(pFk_role_id);

            }
                        
            if (null != rbac_role_modulesParamUpdate.Fk_modules_id &&  ""!= rbac_role_modulesParamUpdate.Fk_modules_id)
            {
                this.isComma(sql);
                sql.Append(" FK_MODULES_ID=:fk_modules_id ");
                OracleParameter pFk_modules_id = new OracleParameter(":fk_modules_id", OracleDbType.Varchar2);
                pFk_modules_id.Direction = ParameterDirection.Input;
                pFk_modules_id.Value = rbac_role_modulesParamUpdate.Fk_modules_id;
                sqlparams.Add(pFk_modules_id);

            }
                        
            if (null != rbac_role_modulesParamUpdate.Zfbz &&  ""!= rbac_role_modulesParamUpdate.Zfbz)
            {
                this.isComma(sql);
                sql.Append(" ZFBZ=:zfbz ");
                OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                pZfbz.Direction = ParameterDirection.Input;
                pZfbz.Value = rbac_role_modulesParamUpdate.Zfbz;
                sqlparams.Add(pZfbz);

            }
                        
            //添加条件的参数
            
            if (null != rbac_role_modulesParamCondition.Fk_role_id &&  ""!= rbac_role_modulesParamCondition.Fk_role_id)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" FK_ROLE_ID=:fk_role_id ");
                OracleParameter pFk_role_id = new OracleParameter(":fk_role_id", OracleDbType.Varchar2);
                pFk_role_id.Direction = ParameterDirection.Input;
                pFk_role_id.Value = rbac_role_modulesParamCondition.Fk_role_id;
                sqlparams.Add(pFk_role_id);

            }
                        
            if (null != rbac_role_modulesParamCondition.Fk_modules_id &&  ""!= rbac_role_modulesParamCondition.Fk_modules_id)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" FK_MODULES_ID=:fk_modules_id ");
                OracleParameter pFk_modules_id = new OracleParameter(":fk_modules_id", OracleDbType.Varchar2);
                pFk_modules_id.Direction = ParameterDirection.Input;
                pFk_modules_id.Value = rbac_role_modulesParamCondition.Fk_modules_id;
                sqlparams.Add(pFk_modules_id);

            }
                        
            if (null != rbac_role_modulesParamCondition.Zfbz &&  ""!= rbac_role_modulesParamCondition.Zfbz)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" ZFBZ=:zfbz ");
                OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                pZfbz.Direction = ParameterDirection.Input;
                pZfbz.Value = rbac_role_modulesParamCondition.Zfbz;
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
        /// <returns>Rbac_role_modules</returns>
        public Rbac_role_modules findById(string id)
        {
            if (""==id||null==id)
            {
                throw new Exception("ID不能为空，请赋值后调用；错误出自：findById");
            }
            StringBuilder sql = new StringBuilder("SELECT A.* ");
            //新建方法findContactObjectsById，在此加入多表连接要显示的项start
            //sql.Append(",B.字段一,B.字段二,B.字段三");
            //新建方法，在此加入多表连接要显示的项end
            sql.Append(" FROM RBAC_ROLE_MODULES A ");
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
        /// <param name="rbac_role_modulesParam"></param>
        /// <param name="page">分页对象</param>
        ///<param name="rbac_role_modulesParamLike">模糊查询参数</param>
        ///<param name="sortList">排序参数对象的集合</param>
        /// <returns>满足条件的所有Rbac_role_modules对象集合list</returns>
        public List<object> find(Rbac_role_modules rbac_role_modulesParam, Model.Common.PageInfo page,Rbac_role_modules rbac_role_modulesParamLike,List<SortInfo> sortList)
        {

            //如果没有传查询条件参数，就new一个空的Rbac_role_modules对象，标示查询所有数据
            if (null == rbac_role_modulesParam)
            {
                rbac_role_modulesParam = new Rbac_role_modules();
            }
            if (null!=rbac_role_modulesParam.Id&&""!=rbac_role_modulesParam.Id)
            {
                throw new Exception("此方法不允许指定参数ID，如果需要根据ID查询数据，请调用findById方法；错误出自：find");
            }
            List<Rbac_role_modules> rbac_role_modulesParamList = new List<Rbac_role_modules>();//接收查询出的Rbac_role_modules对象集合
            List<OracleParameter> sqlparams = new List<OracleParameter>();//保存参数的集合
            StringBuilder sql = new StringBuilder("SELECT A.* ");
            //新建方法findContactObjects(Rbac_role_modules rbac_role_modulesParam, Model.Common.PageInfo page)，在此加入多表连接要显示的项start
            //sql.Append(",B.字段一,B.字段二,B.字段三");
            //新建方法，在此加入多表连接要显示的项end
            sql.Append(" FROM RBAC_ROLE_MODULES A ");
            //新建一个方法，在此加入多表连接的语句start
            ////sql.Append(" LEFT JOIN 表名 B ON A.外键=B.ID");
            //新建一个方法，在此加入多表连接的语句end
            
            
            if (null != rbac_role_modulesParam.Fk_role_id && "" != rbac_role_modulesParam.Fk_role_id)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.FK_ROLE_ID=:fk_role_id ");
                OracleParameter pFk_role_id = new OracleParameter(":fk_role_id", OracleDbType.Varchar2);
                pFk_role_id.Direction = ParameterDirection.Input;
                pFk_role_id.Value = rbac_role_modulesParam.Fk_role_id;
                sqlparams.Add(pFk_role_id);
            }
                
            if (null != rbac_role_modulesParam.Fk_modules_id && "" != rbac_role_modulesParam.Fk_modules_id)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.FK_MODULES_ID=:fk_modules_id ");
                OracleParameter pFk_modules_id = new OracleParameter(":fk_modules_id", OracleDbType.Varchar2);
                pFk_modules_id.Direction = ParameterDirection.Input;
                pFk_modules_id.Value = rbac_role_modulesParam.Fk_modules_id;
                sqlparams.Add(pFk_modules_id);
            }
                
            if (null != rbac_role_modulesParam.Zfbz && "" != rbac_role_modulesParam.Zfbz)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.ZFBZ=:zfbz ");
                OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                pZfbz.Direction = ParameterDirection.Input;
                pZfbz.Value = rbac_role_modulesParam.Zfbz;
                sqlparams.Add(pZfbz);
            }
                
            if(rbac_role_modulesParamLike!=null)
            {

                if (null != rbac_role_modulesParamLike.Fk_role_id && "" != rbac_role_modulesParamLike.Fk_role_id)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.FK_ROLE_ID LIKE '%'||:fk_role_id||'%' ");
                    OracleParameter pFk_role_id = new OracleParameter(":fk_role_id", OracleDbType.Varchar2);
                    pFk_role_id.Direction = ParameterDirection.Input;
                    pFk_role_id.Value = rbac_role_modulesParamLike.Fk_role_id;
                    sqlparams.Add(pFk_role_id);
                }
                
                if (null != rbac_role_modulesParamLike.Fk_modules_id && "" != rbac_role_modulesParamLike.Fk_modules_id)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.FK_MODULES_ID LIKE '%'||:fk_modules_id||'%' ");
                    OracleParameter pFk_modules_id = new OracleParameter(":fk_modules_id", OracleDbType.Varchar2);
                    pFk_modules_id.Direction = ParameterDirection.Input;
                    pFk_modules_id.Value = rbac_role_modulesParamLike.Fk_modules_id;
                    sqlparams.Add(pFk_modules_id);
                }
                
                if (null != rbac_role_modulesParamLike.Zfbz && "" != rbac_role_modulesParamLike.Zfbz)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.ZFBZ LIKE '%'||:zfbz||'%' ");
                    OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                    pZfbz.Direction = ParameterDirection.Input;
                    pZfbz.Value = rbac_role_modulesParamLike.Zfbz;
                    sqlparams.Add(pZfbz);
                }
                
            }

            this.b_isWhere = false;
            this.addSort(sql, sortList);//排序
            //*******分页start1*********如果分页对象为空，则全部数据查出，如果不为空
            List<object> returnList = new List<object>();//返回的List,索引0为List<Rbac_role_modules>对象,索引1为Model.Common.PageInfo分页信息对象
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
            //把每一行数据转换为一个对象放入List<Rbac_role_modules>中
            for (int i = 0; i < rows.Count; i++)
            {
                DataRow row = rows[i];
                //rbac_role_modulesParamList.Add(this.dataSetContactObjectsToModel(row));
                rbac_role_modulesParamList.Add(this.dataSetToModel(row));
            }
            
             //*******分页start2*********如果没有传入分页对象，则新建一个分页对象当做返回值
            if (null == page)
            {
                page = new Model.Common.PageInfo();
                page.AllCount = rows.Count;
            }
            returnList.Add(rbac_role_modulesParamList);//把List<Rbac_role_modules>放入List<object>中第一个
            returnList.Add(page);//把page对象放入List<object>中第二个
            //*******分页end2*********
            return returnList;
        }

        
        
        /// <summary>
        /// 根据条件得到集合的数量
        /// 第二个条件是模糊查询的条件
        /// </summary>
        /// <returns>int</returns>
        public int getCount(Rbac_role_modules rbac_role_modulesParam,Rbac_role_modules rbac_role_modulesParamLike)
        {
            //如果没有传查询条件参数，就new一个空的Rbac_role_modules对象，标示查询所有数据
            if (null == rbac_role_modulesParam)
            {
                rbac_role_modulesParam = new Rbac_role_modules();
            }
            List<OracleParameter> sqlparams = new List<OracleParameter>();//保存参数的集合
            StringBuilder sql = new StringBuilder("SELECT COUNT(ID) FROM RBAC_ROLE_MODULES A");
                if (null != rbac_role_modulesParam.Fk_role_id && "" != rbac_role_modulesParam.Fk_role_id)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.FK_ROLE_ID=:fk_role_id ");
                    OracleParameter pFk_role_id = new OracleParameter(":fk_role_id", OracleDbType.Varchar2);
                pFk_role_id.Value = rbac_role_modulesParam.Fk_role_id;
                sqlparams.Add(pFk_role_id);
                }
                
                if (null != rbac_role_modulesParam.Fk_modules_id && "" != rbac_role_modulesParam.Fk_modules_id)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.FK_MODULES_ID=:fk_modules_id ");
                    OracleParameter pFk_modules_id = new OracleParameter(":fk_modules_id", OracleDbType.Varchar2);
                pFk_modules_id.Value = rbac_role_modulesParam.Fk_modules_id;
                sqlparams.Add(pFk_modules_id);
                }
                
                if (null != rbac_role_modulesParam.Zfbz && "" != rbac_role_modulesParam.Zfbz)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.ZFBZ=:zfbz ");
                    OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                pZfbz.Value = rbac_role_modulesParam.Zfbz;
                sqlparams.Add(pZfbz);
                }
                
            if(rbac_role_modulesParamLike!=null)
            {

                if (null != rbac_role_modulesParamLike.Fk_role_id && "" != rbac_role_modulesParamLike.Fk_role_id)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.FK_ROLE_ID LIKE '%'||:fk_role_id||'%' ");
                    OracleParameter pFk_role_id = new OracleParameter(":fk_role_id", OracleDbType.Varchar2);
                    pFk_role_id.Direction = ParameterDirection.Input;
                    pFk_role_id.Value = rbac_role_modulesParamLike.Fk_role_id;
                    sqlparams.Add(pFk_role_id);
                }
                
                if (null != rbac_role_modulesParamLike.Fk_modules_id && "" != rbac_role_modulesParamLike.Fk_modules_id)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.FK_MODULES_ID LIKE '%'||:fk_modules_id||'%' ");
                    OracleParameter pFk_modules_id = new OracleParameter(":fk_modules_id", OracleDbType.Varchar2);
                    pFk_modules_id.Direction = ParameterDirection.Input;
                    pFk_modules_id.Value = rbac_role_modulesParamLike.Fk_modules_id;
                    sqlparams.Add(pFk_modules_id);
                }
                
                if (null != rbac_role_modulesParamLike.Zfbz && "" != rbac_role_modulesParamLike.Zfbz)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.ZFBZ LIKE '%'||:zfbz||'%' ");
                    OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                    pZfbz.Direction = ParameterDirection.Input;
                    pZfbz.Value = rbac_role_modulesParamLike.Zfbz;
                    sqlparams.Add(pZfbz);
                }
                
            }
this.b_isWhere = false;return Int32.Parse(OracleHelper.ExecuteScalar(sql.ToString(),sqlparams.ToArray()).ToString());
        }


        /// <summary>
        /// 通用的保存方法，根据用户传入的参数，有ID为修改，没有ID为新增(手动生成OracleConnection对象，此方法用于事务，使用事务必须使用同一个OracleConnection对象)
        /// </summary>
        /// <param name="rbac_role_modulesParam"></param>
        /// <returns></returns>
        public bool save(Rbac_role_modules rbac_role_modulesParam,OracleConnection con)
        {
            if ("" != rbac_role_modulesParam.Id && null != rbac_role_modulesParam.Id)
            {
                //修改
                return this.updateById(rbac_role_modulesParam,con);
            }
            else
            {
                //新增
                return this.insert(rbac_role_modulesParam,con);
            }
        }

        /// <summary>
        /// 把dataset中的一行转换为model
        /// </summary>
        /// <param name="row"></param>
        /// <returns></returns>
        private Rbac_role_modules dataSetToModel(DataRow row)
        {
            Rbac_role_modules rbac_role_modulesParam = new Rbac_role_modules();
            rbac_role_modulesParam.Id = Convert.ToString(row["ID"]).Trim(); 
            rbac_role_modulesParam.Fk_role_id = Convert.ToString(row["FK_ROLE_ID"]).Trim(); 
            rbac_role_modulesParam.Fk_modules_id = Convert.ToString(row["FK_MODULES_ID"]).Trim(); 
            rbac_role_modulesParam.Zfbz = Convert.ToString(row["ZFBZ"]).Trim(); 
            
            return rbac_role_modulesParam;
        }

       
        
        //*******************在此以后添加新的方法start
        #region DAL层的implement,实现，start

        /// <summary>
        /// 把dataset中的一行转换为model, 包括相关联的外键对象
        /// </summary>
        /// <param name="row"></param>
        /// <returns></returns>
        private Rbac_role_modules dataSetContactObjectsToModel(DataRow row)
        {
            Rbac_role_modules rbac_role_modulesParam = this.dataSetToModel(row);

            #region 添加Rbac_role类别实体对象
            Rbac_role rbac_role = new Rbac_role();
            rbac_role.Id = Convert.ToString(row["RE_ID"]).Trim();
            rbac_role.Name = Convert.ToString(row["RE_NAME"]).Trim();
            rbac_role.Remark = Convert.ToString(row["RE_REMARK"]).Trim();
            rbac_role.Zfbz = Convert.ToString(row["RE_ZFBZ"]).Trim();

            rbac_role_modulesParam.Rbac_role = rbac_role;
            #endregion 添加Rbac_role类别实体对象

            #region 添加Rbac_modules类别实体对象
            Rbac_modules rbac_modules = new Rbac_modules();
            rbac_modules.Id = Convert.ToString(row["RS_ID"]).Trim();
            rbac_modules.Pid = Convert.ToString(row["RS_PID"]).Trim();
            rbac_modules.Name = Convert.ToString(row["RS_NAME"]).Trim();
            rbac_modules.Window_name = Convert.ToString(row["RS_WINDOW_NAME"]).Trim();
            rbac_modules.Type_code = Convert.ToString(row["RS_TYPE_CODE"]).Trim();
            rbac_modules.Is_open_window_code = Convert.ToString(row["RS_IS_OPEN_WINDOW_CODE"]).Trim();
            rbac_modules.Sort = (decimal?)this.convertDBNullValue(row["RS_SORT"]);
            rbac_modules.Icon = Convert.ToString(row["RS_ICON"]).Trim();
            rbac_modules.Remark = Convert.ToString(row["RS_REMARK"]).Trim();
            rbac_modules.Zfbz = Convert.ToString(row["RS_ZFBZ"]).Trim();

            rbac_role_modulesParam.Rbac_modules = rbac_modules;
            #endregion 添加Rbac_modules类别实体对象

            return rbac_role_modulesParam;
        }



        /// <summary>
        /// 查找指定ID的用户,得到相关联的外键对象的方法
        /// </summary>
        /// <remarks>如果id为null、id重复、id未找到就抛异常</remarks>
        /// <returns>Rbac_role_modules</returns>
        public Rbac_role_modules findContactObjectsById(string id)
        {
            if ("" == id || null == id)
            {
                throw new Exception("主键ID不能为空，请赋值");
            }
            StringBuilder sql = new StringBuilder("SELECT A.* ");
            //新建方法findContactObjectsById，在此加入多表连接要显示的项start
            //sql.Append(",B.字段一,B.字段二,B.字段三");

            sql.Append(@"
            ,TT_RBAC_ROLE.ID AS RE_ID
            ,TT_RBAC_ROLE.NAME AS RE_NAME
            ,TT_RBAC_ROLE.REMARK AS RE_REMARK
            ,TT_RBAC_ROLE.ZFBZ AS RE_ZFBZ
            ");

            sql.Append(@"
            ,TT_RBAC_MODULES.ID AS RS_ID
            ,TT_RBAC_MODULES.PID AS RS_PID
            ,TT_RBAC_MODULES.NAME AS RS_NAME
            ,TT_RBAC_MODULES.WINDOW_NAME AS RS_WINDOW_NAME
            ,TT_RBAC_MODULES.TYPE_CODE AS RS_TYPE_CODE
            ,TT_RBAC_MODULES.IS_OPEN_WINDOW_CODE AS RS_IS_OPEN_WINDOW_CODE
            ,TT_RBAC_MODULES.SORT AS RS_SORT
            ,TT_RBAC_MODULES.ICON AS RS_ICON
            ,TT_RBAC_MODULES.REMARK AS RS_REMARK
            ,TT_RBAC_MODULES.ZFBZ AS RS_ZFBZ
            ");

            //新建方法，在此加入多表连接要显示的项end
            sql.Append(" FROM RBAC_ROLE_MODULES A ");
            //新建一个方法，在此加入多表连接的语句start
            //sql.Append("LEFT JOIN 外键表名 B ON A.外键=B.ID");

            sql.Append(@"
            LEFT JOIN RBAC_ROLE TT_RBAC_ROLE 
            ON A.FK_ROLE_ID = TT_RBAC_ROLE.ID

            ");

            sql.Append(@"
            LEFT JOIN RBAC_MODULES TT_RBAC_MODULES 
            ON A.FK_MODULES_ID = TT_RBAC_MODULES.ID

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
        /// <param name="rbac_role_modulesParam"></param>
        /// <param name="page">分页对象</param>
        ///<param name="rbac_role_modulesParamLike">模糊查询参数</param>
        ///<param name="sortList">排序参数对象的集合</param>
        /// <returns>满足条件的所有Rbac_role_modules对象集合list</returns>
        public List<object> findContactObjects(Rbac_role_modules rbac_role_modulesParam, Model.Common.PageInfo page, Rbac_role_modules rbac_role_modulesParamLike, List<SortInfo> sortList)
        {
            //如果没有传查询条件参数，就new一个空的Rbac_role_modules对象，标示查询所有数据
            if (null == rbac_role_modulesParam)
            {
                rbac_role_modulesParam = new Rbac_role_modules();
            }
            if (null != rbac_role_modulesParam.Id && "" != rbac_role_modulesParam.Id)
            {
                throw new Exception("此方法不允许指定参数ID，如果需要根据ID查询数据，请调用findById方法；错误出自：find");
            }

            List<Rbac_role_modules> rbac_role_modulesParamList = new List<Rbac_role_modules>();//接收查询出的Rbac_role_modules对象集合
            List<OracleParameter> sqlparams = new List<OracleParameter>();//保存参数的集合
            StringBuilder sql = new StringBuilder("SELECT A.* ");
            //新建方法findAllContactObjects(Rbac_role_modules rbac_role_modulesParam, Model.Common.PageInfo page)，在此加入多表连接要显示的项start
            //sql.Append(",B.字段一,B.字段二,B.字段三");

            sql.Append(@"
            ,TT_RBAC_ROLE.ID AS RE_ID
            ,TT_RBAC_ROLE.NAME AS RE_NAME
            ,TT_RBAC_ROLE.REMARK AS RE_REMARK
            ,TT_RBAC_ROLE.ZFBZ AS RE_ZFBZ
            ");

            sql.Append(@"
            ,TT_RBAC_MODULES.ID AS RS_ID
            ,TT_RBAC_MODULES.PID AS RS_PID
            ,TT_RBAC_MODULES.NAME AS RS_NAME
            ,TT_RBAC_MODULES.WINDOW_NAME AS RS_WINDOW_NAME
            ,TT_RBAC_MODULES.TYPE_CODE AS RS_TYPE_CODE
            ,TT_RBAC_MODULES.IS_OPEN_WINDOW_CODE AS RS_IS_OPEN_WINDOW_CODE
            ,TT_RBAC_MODULES.SORT AS RS_SORT
            ,TT_RBAC_MODULES.ICON AS RS_ICON
            ,TT_RBAC_MODULES.REMARK AS RS_REMARK
            ,TT_RBAC_MODULES.ZFBZ AS RS_ZFBZ
            ");

            //新建方法，在此加入多表连接要显示的项end
            sql.Append(" FROM RBAC_ROLE_MODULES A ");
            //新建一个方法，在此加入多表连接的语句start
            ////sql.Append(" LEFT JOIN 表名 B ON A.外键=B.ID");

            sql.Append(@"
            LEFT JOIN RBAC_ROLE TT_RBAC_ROLE 
            ON A.FK_ROLE_ID = TT_RBAC_ROLE.ID

            ");

            sql.Append(@"
            LEFT JOIN RBAC_MODULES TT_RBAC_MODULES 
            ON A.FK_MODULES_ID = TT_RBAC_MODULES.ID

            ");

            //新建一个方法，在此加入多表连接的语句end


            if (null != rbac_role_modulesParam.Fk_role_id && "" != rbac_role_modulesParam.Fk_role_id)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.FK_ROLE_ID=:fk_role_id ");
                OracleParameter pFk_role_id = new OracleParameter(":fk_role_id", OracleDbType.Varchar2);
                pFk_role_id.Value = rbac_role_modulesParam.Fk_role_id;
                sqlparams.Add(pFk_role_id);
            }

            if (null != rbac_role_modulesParam.Fk_modules_id && "" != rbac_role_modulesParam.Fk_modules_id)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.FK_MODULES_ID=:fk_modules_id ");
                OracleParameter pFk_modules_id = new OracleParameter(":fk_modules_id", OracleDbType.Varchar2);
                pFk_modules_id.Value = rbac_role_modulesParam.Fk_modules_id;
                sqlparams.Add(pFk_modules_id);
            }

            if (null != rbac_role_modulesParam.Zfbz && "" != rbac_role_modulesParam.Zfbz)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.ZFBZ=:zfbz ");
                OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                pZfbz.Value = rbac_role_modulesParam.Zfbz;
                sqlparams.Add(pZfbz);
            }

            if (rbac_role_modulesParamLike != null)
            {

                if (null != rbac_role_modulesParamLike.Fk_role_id && "" != rbac_role_modulesParamLike.Fk_role_id)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.FK_ROLE_ID LIKE '%'||:fk_role_id||'%' ");
                    OracleParameter pFk_role_id = new OracleParameter(":fk_role_id", OracleDbType.Varchar2);
                    pFk_role_id.Direction = ParameterDirection.Input;
                    pFk_role_id.Value = rbac_role_modulesParamLike.Fk_role_id;
                    sqlparams.Add(pFk_role_id);
                }

                if (null != rbac_role_modulesParamLike.Fk_modules_id && "" != rbac_role_modulesParamLike.Fk_modules_id)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.FK_MODULES_ID LIKE '%'||:fk_modules_id||'%' ");
                    OracleParameter pFk_modules_id = new OracleParameter(":fk_modules_id", OracleDbType.Varchar2);
                    pFk_modules_id.Direction = ParameterDirection.Input;
                    pFk_modules_id.Value = rbac_role_modulesParamLike.Fk_modules_id;
                    sqlparams.Add(pFk_modules_id);
                }

                if (null != rbac_role_modulesParamLike.Zfbz && "" != rbac_role_modulesParamLike.Zfbz)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.ZFBZ LIKE '%'||:zfbz||'%' ");
                    OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                    pZfbz.Direction = ParameterDirection.Input;
                    pZfbz.Value = rbac_role_modulesParamLike.Zfbz;
                    sqlparams.Add(pZfbz);
                }

            }

            if (null != rbac_role_modulesParam.Rbac_role)
            {

                if (null != rbac_role_modulesParam.Rbac_role.Id && null != rbac_role_modulesParam.Rbac_role.Id)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" TT_RBAC_ROLE.ID=:id ");
                    OracleParameter pId = new OracleParameter(":id", OracleDbType.Varchar2);
                    pId.Value = rbac_role_modulesParam.Rbac_role.Id;
                    sqlparams.Add(pId);
                }

                if (null != rbac_role_modulesParam.Rbac_role.Name && null != rbac_role_modulesParam.Rbac_role.Name)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" TT_RBAC_ROLE.NAME=:name ");
                    OracleParameter pName = new OracleParameter(":name", OracleDbType.NVarchar2);
                    pName.Value = rbac_role_modulesParam.Rbac_role.Name;
                    sqlparams.Add(pName);
                }

                if (null != rbac_role_modulesParam.Rbac_role.Remark && null != rbac_role_modulesParam.Rbac_role.Remark)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" TT_RBAC_ROLE.REMARK=:remark ");
                    OracleParameter pRemark = new OracleParameter(":remark", OracleDbType.NVarchar2);
                    pRemark.Value = rbac_role_modulesParam.Rbac_role.Remark;
                    sqlparams.Add(pRemark);
                }

                if (null != rbac_role_modulesParam.Rbac_role.Zfbz && null != rbac_role_modulesParam.Rbac_role.Zfbz)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" TT_RBAC_ROLE.ZFBZ=:zfbz ");
                    OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                    pZfbz.Value = rbac_role_modulesParam.Rbac_role.Zfbz;
                    sqlparams.Add(pZfbz);
                }

            }

            if (null != rbac_role_modulesParam.Rbac_modules)
            {

                if (null != rbac_role_modulesParam.Rbac_modules.Id && null != rbac_role_modulesParam.Rbac_modules.Id)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" TT_RBAC_MODULES.ID=:id ");
                    OracleParameter pId = new OracleParameter(":id", OracleDbType.Varchar2);
                    pId.Value = rbac_role_modulesParam.Rbac_modules.Id;
                    sqlparams.Add(pId);
                }

                if (null != rbac_role_modulesParam.Rbac_modules.Pid && null != rbac_role_modulesParam.Rbac_modules.Pid)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" TT_RBAC_MODULES.PID=:pid ");
                    OracleParameter pPid = new OracleParameter(":pid", OracleDbType.Varchar2);
                    pPid.Value = rbac_role_modulesParam.Rbac_modules.Pid;
                    sqlparams.Add(pPid);
                }

                if (null != rbac_role_modulesParam.Rbac_modules.Name && null != rbac_role_modulesParam.Rbac_modules.Name)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" TT_RBAC_MODULES.NAME=:name ");
                    OracleParameter pName = new OracleParameter(":name", OracleDbType.NVarchar2);
                    pName.Value = rbac_role_modulesParam.Rbac_modules.Name;
                    sqlparams.Add(pName);
                }

                if (null != rbac_role_modulesParam.Rbac_modules.Window_name && null != rbac_role_modulesParam.Rbac_modules.Window_name)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" TT_RBAC_MODULES.WINDOW_NAME=:window_name ");
                    OracleParameter pWindow_name = new OracleParameter(":window_name", OracleDbType.NVarchar2);
                    pWindow_name.Value = rbac_role_modulesParam.Rbac_modules.Window_name;
                    sqlparams.Add(pWindow_name);
                }

                if (null != rbac_role_modulesParam.Rbac_modules.Type_code && null != rbac_role_modulesParam.Rbac_modules.Type_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" TT_RBAC_MODULES.TYPE_CODE=:type_code ");
                    OracleParameter pType_code = new OracleParameter(":type_code", OracleDbType.NVarchar2);
                    pType_code.Value = rbac_role_modulesParam.Rbac_modules.Type_code;
                    sqlparams.Add(pType_code);
                }

                if (null != rbac_role_modulesParam.Rbac_modules.Is_open_window_code && null != rbac_role_modulesParam.Rbac_modules.Is_open_window_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" TT_RBAC_MODULES.IS_OPEN_WINDOW_CODE=:is_open_window_code ");
                    OracleParameter pIs_open_window_code = new OracleParameter(":is_open_window_code", OracleDbType.NVarchar2);
                    pIs_open_window_code.Value = rbac_role_modulesParam.Rbac_modules.Is_open_window_code;
                    sqlparams.Add(pIs_open_window_code);
                }

                if (null != rbac_role_modulesParam.Rbac_modules.Sort)
                {
                    this.isComma(sql);
                    sql.Append(" TT_RBAC_MODULES.SORT=:sort ");
                    OracleParameter pSort = new OracleParameter(":sort", OracleDbType.Decimal);
                    pSort.Value = rbac_role_modulesParam.Rbac_modules.Sort;
                    sqlparams.Add(pSort);

                }

                if (null != rbac_role_modulesParam.Rbac_modules.Icon && null != rbac_role_modulesParam.Rbac_modules.Icon)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" TT_RBAC_MODULES.ICON=:icon ");
                    OracleParameter pIcon = new OracleParameter(":icon", OracleDbType.NVarchar2);
                    pIcon.Value = rbac_role_modulesParam.Rbac_modules.Icon;
                    sqlparams.Add(pIcon);
                }

                if (null != rbac_role_modulesParam.Rbac_modules.Remark && null != rbac_role_modulesParam.Rbac_modules.Remark)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" TT_RBAC_MODULES.REMARK=:remark ");
                    OracleParameter pRemark = new OracleParameter(":remark", OracleDbType.NVarchar2);
                    pRemark.Value = rbac_role_modulesParam.Rbac_modules.Remark;
                    sqlparams.Add(pRemark);
                }

                if (null != rbac_role_modulesParam.Rbac_modules.Zfbz && null != rbac_role_modulesParam.Rbac_modules.Zfbz)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" TT_RBAC_MODULES.ZFBZ=:zfbz ");
                    OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                    pZfbz.Value = rbac_role_modulesParam.Rbac_modules.Zfbz;
                    sqlparams.Add(pZfbz);
                }

            }

          

            this.b_isWhere = false;
            //排序
            this.addSort(sql, sortList);
            //*******分页start1*********如果分页对象为空，则全部数据查出，如果不为空
            List<object> returnList = new List<object>();//返回的List,索引0为List<Rbac_role_modules>对象,索引1为Model.Common.PageInfo分页信息对象
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
            //把每一行数据转换为一个对象放入List<Rbac_role_modules>中
            for (int i = 0; i < rows.Count; i++)
            {
                DataRow row = rows[i];
                rbac_role_modulesParamList.Add(this.dataSetContactObjectsToModel(row));
                //rbac_role_modulesParamList.Add(this.dataSetToModel(row));
            }

            //*******分页start2*********如果没有传入分页对象，则新建一个分页对象当做返回值
            if (null == page)
            {
                page = new Model.Common.PageInfo();
                page.AllCount = rows.Count;
            }
            returnList.Add(rbac_role_modulesParamList);//把List<Rbac_role_modules>放入List<object>中第一个
            returnList.Add(page);//把page对象放入List<object>中第二个
            //*******分页end2*********
            return returnList;
        }
        #endregion DAL层的implement,实现，end

        


        //*******************在此以后添加新的方法end
        
    }
}


