

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
using Model.JC;

namespace DAL.RBAC.RBAC_用户
{
    /// <summary>
    ///数据库访问层的Rbac_user实现类
    ///此类由代码生成器生成
    ///表名：RBAC_USER
    ///生成日期：2015-12-05 12:05:04
    /// 

    ///作者：罗新鑫
    ///联系电话：15087010221
    ///联系邮箱：362527240@qq.com
        
    /// </summary>
    public class Rbac_userDALImp :Base.BasDAL,Rbac_userDAL
    {

        /// <summary>
        /// 插入一条数据（如果需要供事务使用就传入OracleConnection对象，如果不供就传入null，方法自动生成OracleConnection对象）
        /// 主键为null时，自动生成主键guid，一般不直接调用此方法，请调用save方法进行单条数据的插入和修改       
        /// </summary>
        /// <param name="rbac_userParam">要插入的rbac_userParam对象</param>
        /// <param name="con">Oracle连接对象（为null时自动生成）</param>
        /// <returns>是否添加成功（影响的行数为1时成功）</returns>
        public bool insert(Rbac_user rbac_userParam,OracleConnection con)
        {
            if (""==rbac_userParam.Id||null==rbac_userParam.Id)
            {
                rbac_userParam.Id = Model.Common.GUIDHelper.getGuid();
            }
            List<OracleParameter> sqlparams = new List<OracleParameter>();
            
            StringBuilder sql = new StringBuilder("INSERT INTO RBAC_USER(id,name,pwd,lx_code,remark,zfbz,cjrq) VALUES(:id,:name,:pwd,:lx_code,:remark,:zfbz,SYSDATE)");
            
            OracleParameter pId = new OracleParameter(":id", OracleDbType.Varchar2);
            pId.Direction = ParameterDirection.Input;
            pId.Value = rbac_userParam.Id;
            sqlparams.Add(pId);
            OracleParameter pName = new OracleParameter(":name", OracleDbType.NVarchar2);
            pName.Direction = ParameterDirection.Input;
            pName.Value = rbac_userParam.Name;
            sqlparams.Add(pName);
            OracleParameter pPwd = new OracleParameter(":pwd", OracleDbType.Varchar2);
            pPwd.Direction = ParameterDirection.Input;
            pPwd.Value = rbac_userParam.Pwd;
            sqlparams.Add(pPwd);
            OracleParameter pLx_code = new OracleParameter(":lx_code", OracleDbType.NVarchar2);
            pLx_code.Direction = ParameterDirection.Input;
            pLx_code.Value = rbac_userParam.Lx_code;
            sqlparams.Add(pLx_code);
            OracleParameter pRemark = new OracleParameter(":remark", OracleDbType.NVarchar2);
            pRemark.Direction = ParameterDirection.Input;
            pRemark.Value = rbac_userParam.Remark;
            sqlparams.Add(pRemark);
            OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
            pZfbz.Direction = ParameterDirection.Input;
            pZfbz.Value = rbac_userParam.Zfbz;
            sqlparams.Add(pZfbz);
            //OracleParameter pCjrq = new OracleParameter(":cjrq", OracleDbType.Date);
            //pCjrq.Direction = ParameterDirection.Input;
            //pCjrq.Value = rbac_userParam.Cjrq;
            //sqlparams.Add(pCjrq);
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
        /// <param name="rbac_userParamList">要插入的rbac_userParam对象的集合</param>
        /// <param name="con">Oracle连接对象（为null时自动生成）</param>
        /// <returns>是否添加成功（影响的行数等于保存的对象的数量时成功）</returns>
        public bool inertBatch(List<Rbac_user> rbac_userParamList, OracleConnection con)
        {
            if (rbac_userParamList.Count == 0)
            {
                return true;
            }
            List<string> idList = new List<string>();

            List<string> nameList = new List<string>();

            List<string> pwdList = new List<string>();

            List<string> lx_codeList = new List<string>();

            List<string> remarkList = new List<string>();

            List<string> zfbzList = new List<string>();

            List<DateTime> cjrqList = new List<DateTime>();

            for (int i = 0; i < rbac_userParamList.Count; i++)
            {
                Rbac_user rbac_userParam = rbac_userParamList[i];
                if ("" == rbac_userParam.Id || null == rbac_userParam.Id)
                {
                    rbac_userParam.Id = Model.Common.GUIDHelper.getGuid();
                }

            idList.Add(rbac_userParam.Id);

            nameList.Add(rbac_userParam.Name);

            pwdList.Add(rbac_userParam.Pwd);

            lx_codeList.Add(rbac_userParam.Lx_code);

            remarkList.Add(rbac_userParam.Remark);

            zfbzList.Add(rbac_userParam.Zfbz);

            cjrqList.Add(rbac_userParam.Cjrq);

            }

            List<OracleParameter> sqlparams = new List<OracleParameter>();

            StringBuilder sql = new StringBuilder("INSERT INTO RBAC_USER(id,name,pwd,lx_code,remark,zfbz,cjrq) VALUES(:id,:name,:pwd,:lx_code,:remark,:zfbz,SYSDATE)");
            
            OracleParameter pId = new OracleParameter(":id", OracleDbType.Varchar2);
            pId.Direction = ParameterDirection.Input;
            pId.Value = idList.ToArray();
            sqlparams.Add(pId);
            OracleParameter pName = new OracleParameter(":name", OracleDbType.NVarchar2);
            pName.Direction = ParameterDirection.Input;
            pName.Value = nameList.ToArray();
            sqlparams.Add(pName);
            OracleParameter pPwd = new OracleParameter(":pwd", OracleDbType.Varchar2);
            pPwd.Direction = ParameterDirection.Input;
            pPwd.Value = pwdList.ToArray();
            sqlparams.Add(pPwd);
            OracleParameter pLx_code = new OracleParameter(":lx_code", OracleDbType.NVarchar2);
            pLx_code.Direction = ParameterDirection.Input;
            pLx_code.Value = lx_codeList.ToArray();
            sqlparams.Add(pLx_code);
            OracleParameter pRemark = new OracleParameter(":remark", OracleDbType.NVarchar2);
            pRemark.Direction = ParameterDirection.Input;
            pRemark.Value = remarkList.ToArray();
            sqlparams.Add(pRemark);
            OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
            pZfbz.Direction = ParameterDirection.Input;
            pZfbz.Value = zfbzList.ToArray();
            sqlparams.Add(pZfbz);
            //OracleParameter pCjrq = new OracleParameter(":cjrq", OracleDbType.Date);
            //pCjrq.Direction = ParameterDirection.Input;
            //pCjrq.Value = cjrqList.ToArray();
            //sqlparams.Add(pCjrq);
            bool result = false;
            int flag = -1;
            flag = OracleHelper.ExecuteBatch(sql.ToString(), con, rbac_userParamList.Count, sqlparams.ToArray());
            if (rbac_userParamList.Count == flag)
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
            StringBuilder sql = new StringBuilder("DELETE RBAC_USER WHERE ID=:id");
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
            StringBuilder sql = new StringBuilder("DELETE RBAC_USER WHERE ID=:id");
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
        /// <param name="rbac_userParamCondition">删除的条件</param>
        /// <param name="con">Oracle连接对象（为null时自动生成）</param>
        /// <returns>无法确定删除的行数（影响行数大于等于0就算成功）</returns>
        public bool deleteByOtherCondition(Rbac_user rbac_userParamCondition, OracleConnection con)
        {
            if (null!=rbac_userParamCondition.Id&&""!=rbac_userParamCondition.Id)
            {
                throw new Exception("不允许指定参数的ID，如果要根据ID删除数据请调用deleteById或者deleteByIdBatch方法；错误出自：deleteByOtherCondition");
            }
            List<OracleParameter> sqlparams = new List<OracleParameter>();
            StringBuilder sql = new StringBuilder("DELETE RBAC_USER ");

            if (null != rbac_userParamCondition.Name &&  ""!= rbac_userParamCondition.Name)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" NAME=:name ");
                OracleParameter pName = new OracleParameter(":name", OracleDbType.NVarchar2);
                pName.Direction = ParameterDirection.Input;
                pName.Value = rbac_userParamCondition.Name;
                sqlparams.Add(pName);

            }
                        
            if (null != rbac_userParamCondition.Pwd &&  ""!= rbac_userParamCondition.Pwd)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" PWD=:pwd ");
                OracleParameter pPwd = new OracleParameter(":pwd", OracleDbType.Varchar2);
                pPwd.Direction = ParameterDirection.Input;
                pPwd.Value = rbac_userParamCondition.Pwd;
                sqlparams.Add(pPwd);

            }
                        
            if (null != rbac_userParamCondition.Lx_code &&  ""!= rbac_userParamCondition.Lx_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" LX_CODE=:lx_code ");
                OracleParameter pLx_code = new OracleParameter(":lx_code", OracleDbType.NVarchar2);
                pLx_code.Direction = ParameterDirection.Input;
                pLx_code.Value = rbac_userParamCondition.Lx_code;
                sqlparams.Add(pLx_code);

            }
                        
            if (null != rbac_userParamCondition.Remark &&  ""!= rbac_userParamCondition.Remark)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" REMARK=:remark ");
                OracleParameter pRemark = new OracleParameter(":remark", OracleDbType.NVarchar2);
                pRemark.Direction = ParameterDirection.Input;
                pRemark.Value = rbac_userParamCondition.Remark;
                sqlparams.Add(pRemark);

            }
                        
            if (null != rbac_userParamCondition.Zfbz &&  ""!= rbac_userParamCondition.Zfbz)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" ZFBZ=:zfbz ");
                OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                pZfbz.Direction = ParameterDirection.Input;
                pZfbz.Value = rbac_userParamCondition.Zfbz;
                sqlparams.Add(pZfbz);

            }
                        
            if (DateTime.MinValue != rbac_userParamCondition.Cjrq &&null != rbac_userParamCondition.Cjrq)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" CJRQ=:cjrq ");
                OracleParameter pCjrq = new OracleParameter(":cjrq", OracleDbType.Date);
                pCjrq.Direction = ParameterDirection.Input;
                pCjrq.Value = rbac_userParamCondition.Cjrq;
                sqlparams.Add(pCjrq);

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
        /// <param name="rbac_userParam"></param>
        /// <returns>影响的行数</returns>
        public bool updateById(Rbac_user rbac_userParam,OracleConnection con)
        {
            if ("" == rbac_userParam.Id || null == rbac_userParam.Id)
            {
                throw new Exception("ID不允许为空，请赋值后调用；错误出自：updateById");
            }
            List<OracleParameter> sqlparams = new List<OracleParameter>();

            StringBuilder sql = new StringBuilder("UPDATE RBAC_USER SET ");
            if (null != rbac_userParam.Name &&  ""!= rbac_userParam.Name)
            {
                this.isComma(sql);
                sql.Append(" NAME=:name ");
                OracleParameter pName = new OracleParameter(":name", OracleDbType.NVarchar2);
                pName.Direction = ParameterDirection.Input;
                pName.Value = rbac_userParam.Name;
                sqlparams.Add(pName);

            }
                        
            if (null != rbac_userParam.Pwd &&  ""!= rbac_userParam.Pwd)
            {
                this.isComma(sql);
                sql.Append(" PWD=:pwd ");
                OracleParameter pPwd = new OracleParameter(":pwd", OracleDbType.Varchar2);
                pPwd.Direction = ParameterDirection.Input;
                pPwd.Value = rbac_userParam.Pwd;
                sqlparams.Add(pPwd);

            }
                        
            if (null != rbac_userParam.Lx_code &&  ""!= rbac_userParam.Lx_code)
            {
                this.isComma(sql);
                sql.Append(" LX_CODE=:lx_code ");
                OracleParameter pLx_code = new OracleParameter(":lx_code", OracleDbType.NVarchar2);
                pLx_code.Direction = ParameterDirection.Input;
                pLx_code.Value = rbac_userParam.Lx_code;
                sqlparams.Add(pLx_code);

            }
                        
            if (null != rbac_userParam.Remark &&  ""!= rbac_userParam.Remark)
            {
                this.isComma(sql);
                sql.Append(" REMARK=:remark ");
                OracleParameter pRemark = new OracleParameter(":remark", OracleDbType.NVarchar2);
                pRemark.Direction = ParameterDirection.Input;
                pRemark.Value = rbac_userParam.Remark;
                sqlparams.Add(pRemark);

            }
                        
            if (null != rbac_userParam.Zfbz &&  ""!= rbac_userParam.Zfbz)
            {
                this.isComma(sql);
                sql.Append(" ZFBZ=:zfbz ");
                OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                pZfbz.Direction = ParameterDirection.Input;
                pZfbz.Value = rbac_userParam.Zfbz;
                sqlparams.Add(pZfbz);

            }
                        
            if (DateTime.MinValue != rbac_userParam.Cjrq &&null != rbac_userParam.Cjrq)
            {
                this.isComma(sql);
                sql.Append(" CJRQ=:cjrq ");
                OracleParameter pCjrq = new OracleParameter(":cjrq", OracleDbType.Date);
                pCjrq.Direction = ParameterDirection.Input;
                pCjrq.Value = rbac_userParam.Cjrq;
                sqlparams.Add(pCjrq);

            }
                        
            sql.Append(" WHERE ID=:id ");
            OracleParameter pId = new OracleParameter(":id", OracleDbType.Varchar2);
            pId.Value = rbac_userParam.Id;
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
        /// <param name="rbac_userParamList">要修改的Rbac_user对象集合</param>
        /// <param name="con">Oracle连接对象（为null时自动生成）</param>
        /// <returns>是否删除成功（影响的行数等于要修改的对象数量时成功）</returns>
        public bool updateByIdBatch(List<Rbac_user> rbac_userParamList, OracleConnection con)
        {


            List<string> idList = new List<string>();

            List<string> nameList = new List<string>();

            List<string> pwdList = new List<string>();

            List<string> lx_codeList = new List<string>();

            List<string> remarkList = new List<string>();

            List<string> zfbzList = new List<string>();

            List<DateTime> cjrqList = new List<DateTime>();

            for (int i = 0; i < rbac_userParamList.Count; i++)
            {
                Rbac_user rbac_userParam = rbac_userParamList[i];
                if ("" == rbac_userParam.Id || null == rbac_userParam.Id)
                {
                    throw new Exception("下标为" + i + "的数据，ID不能为空，请赋值后调用；错误出自：updateByIdBatch");
                }

            idList.Add(rbac_userParam.Id);

            nameList.Add(rbac_userParam.Name);

            pwdList.Add(rbac_userParam.Pwd);

            lx_codeList.Add(rbac_userParam.Lx_code);

            remarkList.Add(rbac_userParam.Remark);

            zfbzList.Add(rbac_userParam.Zfbz);

            cjrqList.Add(rbac_userParam.Cjrq);

            }


            
            List<OracleParameter> sqlparams = new List<OracleParameter>();

            StringBuilder sql = new StringBuilder("UPDATE RBAC_USER SET ");
            this.isComma(sql);
            sql.Append(" NAME=:name ");
            OracleParameter pName = new OracleParameter(":name", OracleDbType.NVarchar2);
            pName.Direction = ParameterDirection.Input;
            pName.Value = nameList.ToArray();
            sqlparams.Add(pName);

            this.isComma(sql);
            sql.Append(" PWD=:pwd ");
            OracleParameter pPwd = new OracleParameter(":pwd", OracleDbType.Varchar2);
            pPwd.Direction = ParameterDirection.Input;
            pPwd.Value = pwdList.ToArray();
            sqlparams.Add(pPwd);

            this.isComma(sql);
            sql.Append(" LX_CODE=:lx_code ");
            OracleParameter pLx_code = new OracleParameter(":lx_code", OracleDbType.NVarchar2);
            pLx_code.Direction = ParameterDirection.Input;
            pLx_code.Value = lx_codeList.ToArray();
            sqlparams.Add(pLx_code);

            this.isComma(sql);
            sql.Append(" REMARK=:remark ");
            OracleParameter pRemark = new OracleParameter(":remark", OracleDbType.NVarchar2);
            pRemark.Direction = ParameterDirection.Input;
            pRemark.Value = remarkList.ToArray();
            sqlparams.Add(pRemark);

            this.isComma(sql);
            sql.Append(" ZFBZ=:zfbz ");
            OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
            pZfbz.Direction = ParameterDirection.Input;
            pZfbz.Value = zfbzList.ToArray();
            sqlparams.Add(pZfbz);

            this.isComma(sql);
            sql.Append(" CJRQ=:cjrq ");
            OracleParameter pCjrq = new OracleParameter(":cjrq", OracleDbType.Date);
            pCjrq.Direction = ParameterDirection.Input;
            pCjrq.Value = cjrqList.ToArray();
            sqlparams.Add(pCjrq);

            sql.Append(" WHERE ID=:id ");
            OracleParameter pId = new OracleParameter(":id", OracleDbType.Varchar2);
            pId.Value = idList.ToArray();
            sqlparams.Add(pId);
            bool result = false;
            int flag = OracleHelper.ExecuteBatch(sql.ToString(), con,rbac_userParamList.Count, sqlparams.ToArray());
            if (rbac_userParamList.Count == flag)
            {
                result = true;
            }
            return result;
        }

        /// <summary>
        /// 根据更新的条件，更新数据（如果需要供事务使用就传入OracleConnection对象，如果不供就传入null，方法自动生成OracleConnection对象）
        /// 不指定ID，如果要根据ID来更新数据，请使用updateForId方法
        /// </summary>
        /// <param name="rbac_userParamCondition">条件对象</param>
        /// <param name="rbac_userParamUpdate">要更新的数据对象</param>
        /// <param name="con">Oracle连接对象（为null时自动生成）</param>
        /// <returns>影响的行数不确定（不为-1就正确）</returns>
        public bool updateByOtherCondition(Rbac_user rbac_userParamCondition, Rbac_user rbac_userParamUpdate, OracleConnection con)
        {
            if ((null!=rbac_userParamCondition.Id&&"!=rbac_userParamCondition.Id)||(null!=rbac_userParamUpdate.Id&&"!=rbac_userParamUpdate.Id))
            {
                throw new Exception("此方法不允许指定参数的ID，数据库中的ID不允许修改，如需根据ID修改数据，请调用updateById或updateByIdBatch方法；错误出自：updateByOtherCondition");
            }
            List<OracleParameter> sqlparams = new List<OracleParameter>();
            //添加要修改的值
            StringBuilder sql = new StringBuilder("UPDATE RBAC_USER SET ");
            if (null != rbac_userParamUpdate.Name &&  ""!= rbac_userParamUpdate.Name)
            {
                this.isComma(sql);
                sql.Append(" NAME=:name ");
                OracleParameter pName = new OracleParameter(":name", OracleDbType.NVarchar2);
                pName.Direction = ParameterDirection.Input;
                pName.Value = rbac_userParamUpdate.Name;
                sqlparams.Add(pName);

            }
                        
            if (null != rbac_userParamUpdate.Pwd &&  ""!= rbac_userParamUpdate.Pwd)
            {
                this.isComma(sql);
                sql.Append(" PWD=:pwd ");
                OracleParameter pPwd = new OracleParameter(":pwd", OracleDbType.Varchar2);
                pPwd.Direction = ParameterDirection.Input;
                pPwd.Value = rbac_userParamUpdate.Pwd;
                sqlparams.Add(pPwd);

            }
                        
            if (null != rbac_userParamUpdate.Lx_code &&  ""!= rbac_userParamUpdate.Lx_code)
            {
                this.isComma(sql);
                sql.Append(" LX_CODE=:lx_code ");
                OracleParameter pLx_code = new OracleParameter(":lx_code", OracleDbType.NVarchar2);
                pLx_code.Direction = ParameterDirection.Input;
                pLx_code.Value = rbac_userParamUpdate.Lx_code;
                sqlparams.Add(pLx_code);

            }
                        
            if (null != rbac_userParamUpdate.Remark &&  ""!= rbac_userParamUpdate.Remark)
            {
                this.isComma(sql);
                sql.Append(" REMARK=:remark ");
                OracleParameter pRemark = new OracleParameter(":remark", OracleDbType.NVarchar2);
                pRemark.Direction = ParameterDirection.Input;
                pRemark.Value = rbac_userParamUpdate.Remark;
                sqlparams.Add(pRemark);

            }
                        
            if (null != rbac_userParamUpdate.Zfbz &&  ""!= rbac_userParamUpdate.Zfbz)
            {
                this.isComma(sql);
                sql.Append(" ZFBZ=:zfbz ");
                OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                pZfbz.Direction = ParameterDirection.Input;
                pZfbz.Value = rbac_userParamUpdate.Zfbz;
                sqlparams.Add(pZfbz);

            }
                        
            if (DateTime.MinValue != rbac_userParamUpdate.Cjrq &&null != rbac_userParamUpdate.Cjrq)
            {
                this.isComma(sql);
                sql.Append(" CJRQ=:cjrq ");
                OracleParameter pCjrq = new OracleParameter(":cjrq", OracleDbType.Date);
                pCjrq.Direction = ParameterDirection.Input;
                pCjrq.Value = rbac_userParamUpdate.Cjrq;
                sqlparams.Add(pCjrq);

            }
                        
            //添加条件的参数
            
            if (null != rbac_userParamCondition.Name &&  ""!= rbac_userParamCondition.Name)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" NAME=:name ");
                OracleParameter pName = new OracleParameter(":name", OracleDbType.NVarchar2);
                pName.Direction = ParameterDirection.Input;
                pName.Value = rbac_userParamCondition.Name;
                sqlparams.Add(pName);

            }
                        
            if (null != rbac_userParamCondition.Pwd &&  ""!= rbac_userParamCondition.Pwd)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" PWD=:pwd ");
                OracleParameter pPwd = new OracleParameter(":pwd", OracleDbType.Varchar2);
                pPwd.Direction = ParameterDirection.Input;
                pPwd.Value = rbac_userParamCondition.Pwd;
                sqlparams.Add(pPwd);

            }
                        
            if (null != rbac_userParamCondition.Lx_code &&  ""!= rbac_userParamCondition.Lx_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" LX_CODE=:lx_code ");
                OracleParameter pLx_code = new OracleParameter(":lx_code", OracleDbType.NVarchar2);
                pLx_code.Direction = ParameterDirection.Input;
                pLx_code.Value = rbac_userParamCondition.Lx_code;
                sqlparams.Add(pLx_code);

            }
                        
            if (null != rbac_userParamCondition.Remark &&  ""!= rbac_userParamCondition.Remark)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" REMARK=:remark ");
                OracleParameter pRemark = new OracleParameter(":remark", OracleDbType.NVarchar2);
                pRemark.Direction = ParameterDirection.Input;
                pRemark.Value = rbac_userParamCondition.Remark;
                sqlparams.Add(pRemark);

            }
                        
            if (null != rbac_userParamCondition.Zfbz &&  ""!= rbac_userParamCondition.Zfbz)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" ZFBZ=:zfbz ");
                OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                pZfbz.Direction = ParameterDirection.Input;
                pZfbz.Value = rbac_userParamCondition.Zfbz;
                sqlparams.Add(pZfbz);

            }
                        
            if (DateTime.MinValue != rbac_userParamCondition.Cjrq &&null != rbac_userParamCondition.Cjrq)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" CJRQ=:cjrq ");
                OracleParameter pCjrq = new OracleParameter(":cjrq", OracleDbType.Date);
                pCjrq.Direction = ParameterDirection.Input;
                pCjrq.Value = rbac_userParamCondition.Cjrq;
                sqlparams.Add(pCjrq);

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
        /// <returns>Rbac_user</returns>
        public Rbac_user findById(string id)
        {
            if (""==id||null==id)
            {
                throw new Exception("ID不能为空，请赋值后调用；错误出自：findById");
            }
            StringBuilder sql = new StringBuilder("SELECT A.* ");
            //新建方法findContactObjectsById，在此加入多表连接要显示的项start
            //sql.Append(",B.字段一,B.字段二,B.字段三");
            //新建方法，在此加入多表连接要显示的项end
            sql.Append(" FROM RBAC_USER A ");
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
        /// <param name="rbac_userParam"></param>
        /// <param name="page">分页对象</param>
        ///<param name="rbac_userParamLike">模糊查询参数</param>
        ///<param name="sortList">排序参数对象的集合</param>
        /// <returns>满足条件的所有Rbac_user对象集合list</returns>
        public List<object> find(Rbac_user rbac_userParam, Model.Common.PageInfo page,Rbac_user rbac_userParamLike,List<SortInfo> sortList)
        {

            //如果没有传查询条件参数，就new一个空的Rbac_user对象，标示查询所有数据
            if (null == rbac_userParam)
            {
                rbac_userParam = new Rbac_user();
            }
            if (null!=rbac_userParam.Id&&""!=rbac_userParam.Id)
            {
                throw new Exception("此方法不允许指定参数ID，如果需要根据ID查询数据，请调用findById方法；错误出自：find");
            }
            List<Rbac_user> rbac_userParamList = new List<Rbac_user>();//接收查询出的Rbac_user对象集合
            List<OracleParameter> sqlparams = new List<OracleParameter>();//保存参数的集合
            StringBuilder sql = new StringBuilder("SELECT A.* ");
            //新建方法findContactObjects(Rbac_user rbac_userParam, Model.Common.PageInfo page)，在此加入多表连接要显示的项start
            //sql.Append(",B.字段一,B.字段二,B.字段三");
            //新建方法，在此加入多表连接要显示的项end
            sql.Append(" FROM RBAC_USER A ");
            //新建一个方法，在此加入多表连接的语句start
            ////sql.Append(" LEFT JOIN 表名 B ON A.外键=B.ID");
            //新建一个方法，在此加入多表连接的语句end
            
            
            if (null != rbac_userParam.Name && "" != rbac_userParam.Name)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.NAME=:name ");
                OracleParameter pName = new OracleParameter(":name", OracleDbType.NVarchar2);
                pName.Direction = ParameterDirection.Input;
                pName.Value = rbac_userParam.Name;
                sqlparams.Add(pName);
            }
                
            if (null != rbac_userParam.Pwd && "" != rbac_userParam.Pwd)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.PWD=:pwd ");
                OracleParameter pPwd = new OracleParameter(":pwd", OracleDbType.Varchar2);
                pPwd.Direction = ParameterDirection.Input;
                pPwd.Value = rbac_userParam.Pwd;
                sqlparams.Add(pPwd);
            }
                
            if (null != rbac_userParam.Lx_code && "" != rbac_userParam.Lx_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.LX_CODE=:lx_code ");
                OracleParameter pLx_code = new OracleParameter(":lx_code", OracleDbType.NVarchar2);
                pLx_code.Direction = ParameterDirection.Input;
                pLx_code.Value = rbac_userParam.Lx_code;
                sqlparams.Add(pLx_code);
            }
                
            if (null != rbac_userParam.Remark && "" != rbac_userParam.Remark)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.REMARK=:remark ");
                OracleParameter pRemark = new OracleParameter(":remark", OracleDbType.NVarchar2);
                pRemark.Direction = ParameterDirection.Input;
                pRemark.Value = rbac_userParam.Remark;
                sqlparams.Add(pRemark);
            }
                
            if (null != rbac_userParam.Zfbz && "" != rbac_userParam.Zfbz)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.ZFBZ=:zfbz ");
                OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                pZfbz.Direction = ParameterDirection.Input;
                pZfbz.Value = rbac_userParam.Zfbz;
                sqlparams.Add(pZfbz);
            }
                
                if (DateTime.MinValue != rbac_userParam.Cjrq &&null != rbac_userParam.Cjrq)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.CJRQ=:cjrq ");
                    OracleParameter pCjrq = new OracleParameter(":cjrq", OracleDbType.Date);
                pCjrq.Direction = ParameterDirection.Input;
                pCjrq.Value = rbac_userParam.Cjrq;
                sqlparams.Add(pCjrq);
                }
                
            if(rbac_userParamLike!=null)
            {

                if (null != rbac_userParamLike.Name && "" != rbac_userParamLike.Name)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.NAME LIKE '%'||:name||'%' ");
                    OracleParameter pName = new OracleParameter(":name", OracleDbType.NVarchar2);
                    pName.Direction = ParameterDirection.Input;
                    pName.Value = rbac_userParamLike.Name;
                    sqlparams.Add(pName);
                }
                
                if (null != rbac_userParamLike.Pwd && "" != rbac_userParamLike.Pwd)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.PWD LIKE '%'||:pwd||'%' ");
                    OracleParameter pPwd = new OracleParameter(":pwd", OracleDbType.Varchar2);
                    pPwd.Direction = ParameterDirection.Input;
                    pPwd.Value = rbac_userParamLike.Pwd;
                    sqlparams.Add(pPwd);
                }
                
                if (null != rbac_userParamLike.Lx_code && "" != rbac_userParamLike.Lx_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.LX_CODE LIKE '%'||:lx_code||'%' ");
                    OracleParameter pLx_code = new OracleParameter(":lx_code", OracleDbType.NVarchar2);
                    pLx_code.Direction = ParameterDirection.Input;
                    pLx_code.Value = rbac_userParamLike.Lx_code;
                    sqlparams.Add(pLx_code);
                }
                
                if (null != rbac_userParamLike.Remark && "" != rbac_userParamLike.Remark)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.REMARK LIKE '%'||:remark||'%' ");
                    OracleParameter pRemark = new OracleParameter(":remark", OracleDbType.NVarchar2);
                    pRemark.Direction = ParameterDirection.Input;
                    pRemark.Value = rbac_userParamLike.Remark;
                    sqlparams.Add(pRemark);
                }
                
                if (null != rbac_userParamLike.Zfbz && "" != rbac_userParamLike.Zfbz)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.ZFBZ LIKE '%'||:zfbz||'%' ");
                    OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                    pZfbz.Direction = ParameterDirection.Input;
                    pZfbz.Value = rbac_userParamLike.Zfbz;
                    sqlparams.Add(pZfbz);
                }
                
            }

            this.b_isWhere = false;
            this.addSort(sql, sortList);//排序
            //*******分页start1*********如果分页对象为空，则全部数据查出，如果不为空
            List<object> returnList = new List<object>();//返回的List,索引0为List<Rbac_user>对象,索引1为Model.Common.PageInfo分页信息对象
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
            //把每一行数据转换为一个对象放入List<Rbac_user>中
            for (int i = 0; i < rows.Count; i++)
            {
                DataRow row = rows[i];
                //rbac_userParamList.Add(this.dataSetContactObjectsToModel(row));
                rbac_userParamList.Add(this.dataSetToModel(row));
            }
            
             //*******分页start2*********如果没有传入分页对象，则新建一个分页对象当做返回值
            if (null == page)
            {
                page = new Model.Common.PageInfo();
                page.AllCount = rows.Count;
            }
            returnList.Add(rbac_userParamList);//把List<Rbac_user>放入List<object>中第一个
            returnList.Add(page);//把page对象放入List<object>中第二个
            //*******分页end2*********
            return returnList;
        }

        
        
        /// <summary>
        /// 根据条件得到集合的数量
        /// 第二个条件是模糊查询的条件
        /// </summary>
        /// <returns>int</returns>
        public int getCount(Rbac_user rbac_userParam,Rbac_user rbac_userParamLike)
        {
            //如果没有传查询条件参数，就new一个空的Rbac_user对象，标示查询所有数据
            if (null == rbac_userParam)
            {
                rbac_userParam = new Rbac_user();
            }
            List<OracleParameter> sqlparams = new List<OracleParameter>();//保存参数的集合
            StringBuilder sql = new StringBuilder("SELECT COUNT(ID) FROM RBAC_USER A");
                if (null != rbac_userParam.Name && "" != rbac_userParam.Name)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.NAME=:name ");
                    OracleParameter pName = new OracleParameter(":name", OracleDbType.NVarchar2);
                pName.Value = rbac_userParam.Name;
                sqlparams.Add(pName);
                }
                
                if (null != rbac_userParam.Pwd && "" != rbac_userParam.Pwd)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.PWD=:pwd ");
                    OracleParameter pPwd = new OracleParameter(":pwd", OracleDbType.Varchar2);
                pPwd.Value = rbac_userParam.Pwd;
                sqlparams.Add(pPwd);
                }
                
                if (null != rbac_userParam.Lx_code && "" != rbac_userParam.Lx_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.LX_CODE=:lx_code ");
                    OracleParameter pLx_code = new OracleParameter(":lx_code", OracleDbType.NVarchar2);
                pLx_code.Value = rbac_userParam.Lx_code;
                sqlparams.Add(pLx_code);
                }
                
                if (null != rbac_userParam.Remark && "" != rbac_userParam.Remark)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.REMARK=:remark ");
                    OracleParameter pRemark = new OracleParameter(":remark", OracleDbType.NVarchar2);
                pRemark.Value = rbac_userParam.Remark;
                sqlparams.Add(pRemark);
                }
                
                if (null != rbac_userParam.Zfbz && "" != rbac_userParam.Zfbz)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.ZFBZ=:zfbz ");
                    OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                pZfbz.Value = rbac_userParam.Zfbz;
                sqlparams.Add(pZfbz);
                }
                
                if (DateTime.MinValue != rbac_userParam.Cjrq &&null != rbac_userParam.Cjrq)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.CJRQ=:cjrq ");
                    OracleParameter pCjrq = new OracleParameter(":cjrq", OracleDbType.Date);
                pCjrq.Value = rbac_userParam.Cjrq;
                sqlparams.Add(pCjrq);
                }
                
            if(rbac_userParamLike!=null)
            {

                if (null != rbac_userParamLike.Name && "" != rbac_userParamLike.Name)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.NAME LIKE '%'||:name||'%' ");
                    OracleParameter pName = new OracleParameter(":name", OracleDbType.NVarchar2);
                    pName.Direction = ParameterDirection.Input;
                    pName.Value = rbac_userParamLike.Name;
                    sqlparams.Add(pName);
                }
                
                if (null != rbac_userParamLike.Pwd && "" != rbac_userParamLike.Pwd)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.PWD LIKE '%'||:pwd||'%' ");
                    OracleParameter pPwd = new OracleParameter(":pwd", OracleDbType.Varchar2);
                    pPwd.Direction = ParameterDirection.Input;
                    pPwd.Value = rbac_userParamLike.Pwd;
                    sqlparams.Add(pPwd);
                }
                
                if (null != rbac_userParamLike.Lx_code && "" != rbac_userParamLike.Lx_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.LX_CODE LIKE '%'||:lx_code||'%' ");
                    OracleParameter pLx_code = new OracleParameter(":lx_code", OracleDbType.NVarchar2);
                    pLx_code.Direction = ParameterDirection.Input;
                    pLx_code.Value = rbac_userParamLike.Lx_code;
                    sqlparams.Add(pLx_code);
                }
                
                if (null != rbac_userParamLike.Remark && "" != rbac_userParamLike.Remark)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.REMARK LIKE '%'||:remark||'%' ");
                    OracleParameter pRemark = new OracleParameter(":remark", OracleDbType.NVarchar2);
                    pRemark.Direction = ParameterDirection.Input;
                    pRemark.Value = rbac_userParamLike.Remark;
                    sqlparams.Add(pRemark);
                }
                
                if (null != rbac_userParamLike.Zfbz && "" != rbac_userParamLike.Zfbz)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.ZFBZ LIKE '%'||:zfbz||'%' ");
                    OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                    pZfbz.Direction = ParameterDirection.Input;
                    pZfbz.Value = rbac_userParamLike.Zfbz;
                    sqlparams.Add(pZfbz);
                }
                
            }
this.b_isWhere = false;return Int32.Parse(OracleHelper.ExecuteScalar(sql.ToString(),sqlparams.ToArray()).ToString());
        }


        /// <summary>
        /// 通用的保存方法，根据用户传入的参数，有ID为修改，没有ID为新增(手动生成OracleConnection对象，此方法用于事务，使用事务必须使用同一个OracleConnection对象)
        /// </summary>
        /// <param name="rbac_userParam"></param>
        /// <returns></returns>
        public bool save(Rbac_user rbac_userParam,OracleConnection con)
        {
            if ("" != rbac_userParam.Id && null != rbac_userParam.Id)
            {
                //修改
                return this.updateById(rbac_userParam,con);
            }
            else
            {
                //新增
                return this.insert(rbac_userParam,con);
            }
        }

        /// <summary>
        /// 把dataset中的一行转换为model
        /// </summary>
        /// <param name="row"></param>
        /// <returns></returns>
        private Rbac_user dataSetToModel(DataRow row)
        {
            Rbac_user rbac_userParam = new Rbac_user();
            rbac_userParam.Id = Convert.ToString(row["ID"]).Trim(); 
            rbac_userParam.Name = Convert.ToString(row["NAME"]).Trim(); 
            rbac_userParam.Pwd = Convert.ToString(row["PWD"]).Trim(); 
            rbac_userParam.Lx_code = Convert.ToString(row["LX_CODE"]).Trim(); 
            rbac_userParam.Remark = Convert.ToString(row["REMARK"]).Trim(); 
            rbac_userParam.Zfbz = Convert.ToString(row["ZFBZ"]).Trim(); 
            rbac_userParam.Cjrq =  (DateTime)row["CJRQ"];
            
            return rbac_userParam;
        }

       
        
        //*******************在此以后添加新的方法start
        #region DAL层的implement,实现，start

        /// <summary>
        /// 把dataset中的一行转换为model, 包括相关联的外键对象
        /// </summary>
        /// <param name="row"></param>
        /// <returns></returns>
        private Rbac_user dataSetContactObjectsToModel(DataRow row)
        {
            Rbac_user rbac_userParam = this.dataSetToModel(row);

            //添加代码类别实体对象,账户类型（关联代码表）对象
            Jc_code lxCode = new Jc_code();
            lxCode.Id = Convert.ToString(row["LX_CODE_ID"]).Trim();
            lxCode.Name = Convert.ToString(row["LX_CODE_NAME"]).Trim();
            lxCode.Value = Convert.ToString(row["LX_CODE_VALUE"]).Trim();
            lxCode.Fk_code_type = Convert.ToString(row["LX_CODE_FKCODETYPE"]).Trim();
            lxCode.Zfbz = Convert.ToString(row["LX_CODE_ZFBZ"]).Trim();
            lxCode.Remark = Convert.ToString(row["LX_CODE_REMARK"]).Trim();
            rbac_userParam.LxCode = lxCode;

            return rbac_userParam;
        }



        /// <summary>
        /// 查找指定ID的用户,得到相关联的外键对象的方法
        /// </summary>
        /// <remarks>如果id为null、id重复、id未找到就抛异常</remarks>
        /// <returns>Rbac_user</returns>
        public Rbac_user findContactObjectsById(string id)
        {
            if ("" == id || null == id)
            {
                throw new Exception("主键ID不能为空，请赋值");
            }
            StringBuilder sql = new StringBuilder("SELECT A.* ");
            //新建方法findContactObjectsById，在此加入多表连接要显示的项start
            //sql.Append(",B.字段一,B.字段二,B.字段三");

            sql.Append(@"
            ,TT_LX_CODE.ID AS LX_CODE_ID,TT_LX_CODE.NAME AS LX_CODE_NAME,TT_LX_CODE.VALUE AS LX_CODE_VALUE,TT_LX_CODE.FK_CODE_TYPE AS LX_CODE_FKCODETYPE,TT_LX_CODE.ZFBZ AS LX_CODE_ZFBZ,TT_LX_CODE.REMARK AS LX_CODE_REMARK
            ");

            //新建方法，在此加入多表连接要显示的项end
            sql.Append(" FROM RBAC_USER A ");
            //新建一个方法，在此加入多表连接的语句start
            //sql.Append("LEFT JOIN 外键表名 B ON A.外键=B.ID");

            sql.Append(@" 
                        LEFT JOIN 
                        (SELECT X.* FROM JC_CODE X WHERE X.FK_CODE_TYPE IN (SELECT Y.ID FROM JC_CODE_TYPE Y WHERE Y.VALUE='" + Model.Common.CommonCode.代码类型值.账户类别 + @"')) TT_LX_CODE
                        ON A.LX_CODE = TT_LX_CODE.VALUE
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
        /// <param name="rbac_userParam"></param>
        /// <param name="page">分页对象</param>
        ///<param name="rbac_userParamLike">模糊查询参数</param>
        ///<param name="sortList">排序参数对象的集合</param>
        /// <returns>满足条件的所有Rbac_user对象集合list</returns>
        public List<object> findContactObjects(Rbac_user rbac_userParam, Model.Common.PageInfo page, Rbac_user rbac_userParamLike, List<SortInfo> sortList)
        {
            //如果没有传查询条件参数，就new一个空的Rbac_user对象，标示查询所有数据
            if (null == rbac_userParam)
            {
                rbac_userParam = new Rbac_user();
            }
            if (null != rbac_userParam.Id && "" != rbac_userParam.Id)
            {
                throw new Exception("此方法不允许指定参数ID，如果需要根据ID查询数据，请调用findById方法；错误出自：find");
            }

            List<Rbac_user> rbac_userParamList = new List<Rbac_user>();//接收查询出的Rbac_user对象集合
            List<OracleParameter> sqlparams = new List<OracleParameter>();//保存参数的集合
            StringBuilder sql = new StringBuilder("SELECT A.* ");
            //新建方法findAllContactObjects(Rbac_user rbac_userParam, Model.Common.PageInfo page)，在此加入多表连接要显示的项start
            //sql.Append(",B.字段一,B.字段二,B.字段三");

            sql.Append(@"
            ,TT_LX_CODE.ID AS LX_CODE_ID,TT_LX_CODE.NAME AS LX_CODE_NAME,TT_LX_CODE.VALUE AS LX_CODE_VALUE,TT_LX_CODE.FK_CODE_TYPE AS LX_CODE_FKCODETYPE,TT_LX_CODE.ZFBZ AS LX_CODE_ZFBZ,TT_LX_CODE.REMARK AS LX_CODE_REMARK
            ");

            //新建方法，在此加入多表连接要显示的项end
            sql.Append(" FROM RBAC_USER A ");
            //新建一个方法，在此加入多表连接的语句start
            ////sql.Append(" LEFT JOIN 表名 B ON A.外键=B.ID");

            sql.Append(@" 
                        LEFT JOIN 
                        (SELECT X.* FROM JC_CODE X WHERE X.FK_CODE_TYPE IN (SELECT Y.ID FROM JC_CODE_TYPE Y WHERE Y.VALUE='" + Model.Common.CommonCode.代码类型值.账户类别 + @"')) TT_LX_CODE
                        ON A.LX_CODE = TT_LX_CODE.VALUE
            ");

            //新建一个方法，在此加入多表连接的语句end


            if (null != rbac_userParam.Name && "" != rbac_userParam.Name)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.NAME=:name ");
                OracleParameter pName = new OracleParameter(":name", OracleDbType.NVarchar2);
                pName.Value = rbac_userParam.Name;
                sqlparams.Add(pName);
            }

            if (null != rbac_userParam.Pwd && "" != rbac_userParam.Pwd)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.PWD=:pwd ");
                OracleParameter pPwd = new OracleParameter(":pwd", OracleDbType.Varchar2);
                pPwd.Value = rbac_userParam.Pwd;
                sqlparams.Add(pPwd);
            }

            if (null != rbac_userParam.Lx_code && "" != rbac_userParam.Lx_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.LX_CODE=:lx_code ");
                OracleParameter pLx_code = new OracleParameter(":lx_code", OracleDbType.NVarchar2);
                pLx_code.Value = rbac_userParam.Lx_code;
                sqlparams.Add(pLx_code);
            }

            if (null != rbac_userParam.Remark && "" != rbac_userParam.Remark)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.REMARK=:remark ");
                OracleParameter pRemark = new OracleParameter(":remark", OracleDbType.NVarchar2);
                pRemark.Value = rbac_userParam.Remark;
                sqlparams.Add(pRemark);
            }

            if (null != rbac_userParam.Zfbz && "" != rbac_userParam.Zfbz)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.ZFBZ=:zfbz ");
                OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                pZfbz.Value = rbac_userParam.Zfbz;
                sqlparams.Add(pZfbz);
            }

            if (DateTime.MinValue != rbac_userParam.Cjrq && null != rbac_userParam.Cjrq)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.CJRQ=:cjrq ");
                OracleParameter pCjrq = new OracleParameter(":cjrq", OracleDbType.Date);
                pCjrq.Value = rbac_userParam.Cjrq;
                sqlparams.Add(pCjrq);
            }

            if (rbac_userParamLike != null)
            {

                if (null != rbac_userParamLike.Name && "" != rbac_userParamLike.Name)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.NAME LIKE '%'||:name||'%' ");
                    OracleParameter pName = new OracleParameter(":name", OracleDbType.NVarchar2);
                    pName.Direction = ParameterDirection.Input;
                    pName.Value = rbac_userParamLike.Name;
                    sqlparams.Add(pName);
                }

                if (null != rbac_userParamLike.Pwd && "" != rbac_userParamLike.Pwd)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.PWD LIKE '%'||:pwd||'%' ");
                    OracleParameter pPwd = new OracleParameter(":pwd", OracleDbType.Varchar2);
                    pPwd.Direction = ParameterDirection.Input;
                    pPwd.Value = rbac_userParamLike.Pwd;
                    sqlparams.Add(pPwd);
                }

                if (null != rbac_userParamLike.Lx_code && "" != rbac_userParamLike.Lx_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.LX_CODE LIKE '%'||:lx_code||'%' ");
                    OracleParameter pLx_code = new OracleParameter(":lx_code", OracleDbType.NVarchar2);
                    pLx_code.Direction = ParameterDirection.Input;
                    pLx_code.Value = rbac_userParamLike.Lx_code;
                    sqlparams.Add(pLx_code);
                }

                if (null != rbac_userParamLike.Remark && "" != rbac_userParamLike.Remark)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.REMARK LIKE '%'||:remark||'%' ");
                    OracleParameter pRemark = new OracleParameter(":remark", OracleDbType.NVarchar2);
                    pRemark.Direction = ParameterDirection.Input;
                    pRemark.Value = rbac_userParamLike.Remark;
                    sqlparams.Add(pRemark);
                }

                if (null != rbac_userParamLike.Zfbz && "" != rbac_userParamLike.Zfbz)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.ZFBZ LIKE '%'||:zfbz||'%' ");
                    OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                    pZfbz.Direction = ParameterDirection.Input;
                    pZfbz.Value = rbac_userParamLike.Zfbz;
                    sqlparams.Add(pZfbz);
                }

            }

            if (rbac_userParamLike != null)
            {

            }

            this.b_isWhere = false;
            //排序
            this.addSort(sql, sortList);
            //*******分页start1*********如果分页对象为空，则全部数据查出，如果不为空
            List<object> returnList = new List<object>();//返回的List,索引0为List<Rbac_user>对象,索引1为Model.Common.PageInfo分页信息对象
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
            //把每一行数据转换为一个对象放入List<Rbac_user>中
            for (int i = 0; i < rows.Count; i++)
            {
                DataRow row = rows[i];
                rbac_userParamList.Add(this.dataSetContactObjectsToModel(row));
                //rbac_userParamList.Add(this.dataSetToModel(row));
            }

            //*******分页start2*********如果没有传入分页对象，则新建一个分页对象当做返回值
            if (null == page)
            {
                page = new Model.Common.PageInfo();
                page.AllCount = rows.Count;
            }
            returnList.Add(rbac_userParamList);//把List<Rbac_user>放入List<object>中第一个
            returnList.Add(page);//把page对象放入List<object>中第二个
            //*******分页end2*********
            return returnList;
        }
        #endregion DAL层的implement,实现，end

        


        //*******************在此以后添加新的方法end



        public List<Rbac_user> getSetOffRenyuan_user()
        {


            List<Rbac_user> rbac_userParamList = new List<Rbac_user>();//接收查询出的Rbac_user对象集合
            StringBuilder sql = new StringBuilder("SELECT A.* ");
            //新建方法findAllContactObjects(Rbac_user rbac_userParam, Model.Common.PageInfo page)，在此加入多表连接要显示的项start
            //sql.Append(",B.字段一,B.字段二,B.字段三");

            sql.Append(@"
            ,TT_LX_CODE.ID AS LX_CODE_ID,TT_LX_CODE.NAME AS LX_CODE_NAME,TT_LX_CODE.VALUE AS LX_CODE_VALUE,TT_LX_CODE.FK_CODE_TYPE AS LX_CODE_FKCODETYPE,TT_LX_CODE.ZFBZ AS LX_CODE_ZFBZ,TT_LX_CODE.REMARK AS LX_CODE_REMARK
            ");

            //新建方法，在此加入多表连接要显示的项end
            sql.Append(" FROM RBAC_USER A ");
            //新建一个方法，在此加入多表连接的语句start
            ////sql.Append(" LEFT JOIN 表名 B ON A.外键=B.ID");

            sql.Append(@" 
                        LEFT JOIN 
                        (SELECT X.* FROM JC_CODE X WHERE X.FK_CODE_TYPE IN (SELECT Y.ID FROM JC_CODE_TYPE Y WHERE Y.VALUE='" + Model.Common.CommonCode.代码类型值.账户类别 + @"')) TT_LX_CODE
                        ON A.LX_CODE = TT_LX_CODE.VALUE
            ");

            //新建一个方法，在此加入多表连接的语句end

            sql.Append(@" WHERE A.id  in(select fk_user_id from JC_RENYUAN_USER) ");
            //*******分页end1*********
            DataSet ds = OracleHelper.getDataSet(sql.ToString());
            DataRowCollection rows = ds.Tables[0].Rows;
            //把每一行数据转换为一个对象放入List<Rbac_user>中
            for (int i = 0; i < rows.Count; i++)
            {
                DataRow row = rows[i];
                rbac_userParamList.Add(this.dataSetContactObjectsToModel(row));
                //rbac_userParamList.Add(this.dataSetToModel(row));
            }


            return rbac_userParamList;
        }
    }
}


