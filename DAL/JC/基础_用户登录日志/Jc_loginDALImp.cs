

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

namespace DAL.JC.基础_用户登录日志
{
    /// <summary>
    ///数据库访问层的Jc_login实现类
    ///此类由代码生成器生成
    ///表名：JC_LOGIN
    ///生成日期：2016-01-04 09:46:39
    /// 

    ///作者：罗新鑫
    ///联系电话：15087010221
    ///联系邮箱：362527240@qq.com
        
    /// </summary>
    public class Jc_loginDALImp :Base.BasDAL,Jc_loginDAL
    {

        /// <summary>
        /// 插入一条数据（如果需要供事务使用就传入OracleConnection对象，如果不供就传入null，方法自动生成OracleConnection对象）
        /// 主键为null时，自动生成主键guid，一般不直接调用此方法，请调用save方法进行单条数据的插入和修改       
        /// </summary>
        /// <param name="jc_loginParam">要插入的jc_loginParam对象</param>
        /// <param name="con">Oracle连接对象（为null时自动生成）</param>
        /// <returns>是否添加成功（影响的行数为1时成功）</returns>
        public bool insert(Jc_login jc_loginParam,OracleConnection con)
        {
            if (""==jc_loginParam.Id||null==jc_loginParam.Id)
            {
                jc_loginParam.Id = Model.Common.GUIDHelper.getGuid();
            }
            List<OracleParameter> sqlparams = new List<OracleParameter>();
            
            StringBuilder sql = new StringBuilder("INSERT INTO JC_LOGIN(id,fk_user_id,user_name,fk_renyuan_id,renyuan_name,login_ip,login_date,zfbz) VALUES(:id,:fk_user_id,:user_name,:fk_renyuan_id,:renyuan_name,:login_ip,:login_date,:zfbz)");
            
            OracleParameter pId = new OracleParameter(":id", OracleDbType.Varchar2);
            pId.Direction = ParameterDirection.Input;
            pId.Value = jc_loginParam.Id;
            sqlparams.Add(pId);
            OracleParameter pFk_user_id = new OracleParameter(":fk_user_id", OracleDbType.Varchar2);
            pFk_user_id.Direction = ParameterDirection.Input;
            pFk_user_id.Value = jc_loginParam.Fk_user_id;
            sqlparams.Add(pFk_user_id);
            OracleParameter pUser_name = new OracleParameter(":user_name", OracleDbType.NVarchar2);
            pUser_name.Direction = ParameterDirection.Input;
            pUser_name.Value = jc_loginParam.User_name;
            sqlparams.Add(pUser_name);
            OracleParameter pFk_renyuan_id = new OracleParameter(":fk_renyuan_id", OracleDbType.Varchar2);
            pFk_renyuan_id.Direction = ParameterDirection.Input;
            pFk_renyuan_id.Value = jc_loginParam.Fk_renyuan_id;
            sqlparams.Add(pFk_renyuan_id);
            OracleParameter pRenyuan_name = new OracleParameter(":renyuan_name", OracleDbType.NVarchar2);
            pRenyuan_name.Direction = ParameterDirection.Input;
            pRenyuan_name.Value = jc_loginParam.Renyuan_name;
            sqlparams.Add(pRenyuan_name);
            OracleParameter pLogin_ip = new OracleParameter(":login_ip", OracleDbType.NVarchar2);
            pLogin_ip.Direction = ParameterDirection.Input;
            pLogin_ip.Value = jc_loginParam.Login_ip;
            sqlparams.Add(pLogin_ip);
            OracleParameter pLogin_date = new OracleParameter(":login_date", OracleDbType.Date);
            pLogin_date.Direction = ParameterDirection.Input;
            pLogin_date.Value = jc_loginParam.Login_date;
            sqlparams.Add(pLogin_date);
            OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
            pZfbz.Direction = ParameterDirection.Input;
            pZfbz.Value = jc_loginParam.Zfbz;
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
        /// <param name="jc_loginParamList">要插入的jc_loginParam对象的集合</param>
        /// <param name="con">Oracle连接对象（为null时自动生成）</param>
        /// <returns>是否添加成功（影响的行数等于保存的对象的数量时成功）</returns>
        public bool inertBatch(List<Jc_login> jc_loginParamList, OracleConnection con)
        {
            if (jc_loginParamList.Count == 0)
            {
                return true;
            }

            List<string> idList = new List<string>();

            List<string> fk_user_idList = new List<string>();

            List<string> user_nameList = new List<string>();

            List<string> fk_renyuan_idList = new List<string>();

            List<string> renyuan_nameList = new List<string>();

            List<string> login_ipList = new List<string>();

            List<DateTime?> login_dateList = new List<DateTime?>();

            List<string> zfbzList = new List<string>();

            for (int i = 0; i < jc_loginParamList.Count; i++)
            {
                Jc_login jc_loginParam = jc_loginParamList[i];
                if ("" == jc_loginParam.Id || null == jc_loginParam.Id)
                {
                    jc_loginParam.Id = Model.Common.GUIDHelper.getGuid();
                }

            idList.Add(jc_loginParam.Id);

            fk_user_idList.Add(jc_loginParam.Fk_user_id);

            user_nameList.Add(jc_loginParam.User_name);

            fk_renyuan_idList.Add(jc_loginParam.Fk_renyuan_id);

            renyuan_nameList.Add(jc_loginParam.Renyuan_name);

            login_ipList.Add(jc_loginParam.Login_ip);

            login_dateList.Add(jc_loginParam.Login_date);

            zfbzList.Add(jc_loginParam.Zfbz);

            }

            List<OracleParameter> sqlparams = new List<OracleParameter>();

            StringBuilder sql = new StringBuilder("INSERT INTO JC_LOGIN(id,fk_user_id,user_name,fk_renyuan_id,renyuan_name,login_ip,login_date,zfbz) VALUES(:id,:fk_user_id,:user_name,:fk_renyuan_id,:renyuan_name,:login_ip,:login_date,:zfbz)");
            
            OracleParameter pId = new OracleParameter(":id", OracleDbType.Varchar2);
            pId.Direction = ParameterDirection.Input;
            pId.Value = idList.ToArray();
            sqlparams.Add(pId);
            OracleParameter pFk_user_id = new OracleParameter(":fk_user_id", OracleDbType.Varchar2);
            pFk_user_id.Direction = ParameterDirection.Input;
            pFk_user_id.Value = fk_user_idList.ToArray();
            sqlparams.Add(pFk_user_id);
            OracleParameter pUser_name = new OracleParameter(":user_name", OracleDbType.NVarchar2);
            pUser_name.Direction = ParameterDirection.Input;
            pUser_name.Value = user_nameList.ToArray();
            sqlparams.Add(pUser_name);
            OracleParameter pFk_renyuan_id = new OracleParameter(":fk_renyuan_id", OracleDbType.Varchar2);
            pFk_renyuan_id.Direction = ParameterDirection.Input;
            pFk_renyuan_id.Value = fk_renyuan_idList.ToArray();
            sqlparams.Add(pFk_renyuan_id);
            OracleParameter pRenyuan_name = new OracleParameter(":renyuan_name", OracleDbType.NVarchar2);
            pRenyuan_name.Direction = ParameterDirection.Input;
            pRenyuan_name.Value = renyuan_nameList.ToArray();
            sqlparams.Add(pRenyuan_name);
            OracleParameter pLogin_ip = new OracleParameter(":login_ip", OracleDbType.NVarchar2);
            pLogin_ip.Direction = ParameterDirection.Input;
            pLogin_ip.Value = login_ipList.ToArray();
            sqlparams.Add(pLogin_ip);
            OracleParameter pLogin_date = new OracleParameter(":login_date", OracleDbType.Date);
            pLogin_date.Direction = ParameterDirection.Input;
            pLogin_date.Value = login_dateList.ToArray();
            sqlparams.Add(pLogin_date);
            OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
            pZfbz.Direction = ParameterDirection.Input;
            pZfbz.Value = zfbzList.ToArray();
            sqlparams.Add(pZfbz);
            bool result = false;
            int flag = -1;
            flag = OracleHelper.ExecuteBatch(sql.ToString(), con, jc_loginParamList.Count, sqlparams.ToArray());
            if (jc_loginParamList.Count == flag)
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
            StringBuilder sql = new StringBuilder("DELETE JC_LOGIN WHERE ID=:id");
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
            StringBuilder sql = new StringBuilder("DELETE JC_LOGIN WHERE ID=:id");
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
        /// <param name="jc_loginParamCondition">删除的条件</param>
        /// <param name="con">Oracle连接对象（为null时自动生成）</param>
        /// <returns>无法确定删除的行数（影响行数大于等于0就算成功）</returns>
        public bool deleteByOtherCondition(Jc_login jc_loginParamCondition, OracleConnection con)
        {
            if (null!=jc_loginParamCondition.Id&&""!=jc_loginParamCondition.Id)
            {
                throw new Exception("不允许指定参数的ID，如果要根据ID删除数据请调用deleteById或者deleteByIdBatch方法；错误出自：deleteByOtherCondition");
            }
            List<OracleParameter> sqlparams = new List<OracleParameter>();
            StringBuilder sql = new StringBuilder("DELETE JC_LOGIN ");

            if (null != jc_loginParamCondition.Fk_user_id &&  ""!= jc_loginParamCondition.Fk_user_id)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" FK_USER_ID=:fk_user_id ");
                OracleParameter pFk_user_id = new OracleParameter(":fk_user_id", OracleDbType.Varchar2);
                pFk_user_id.Direction = ParameterDirection.Input;
                pFk_user_id.Value = jc_loginParamCondition.Fk_user_id;
                sqlparams.Add(pFk_user_id);

            }
                        
            if (null != jc_loginParamCondition.User_name &&  ""!= jc_loginParamCondition.User_name)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" USER_NAME=:user_name ");
                OracleParameter pUser_name = new OracleParameter(":user_name", OracleDbType.NVarchar2);
                pUser_name.Direction = ParameterDirection.Input;
                pUser_name.Value = jc_loginParamCondition.User_name;
                sqlparams.Add(pUser_name);

            }
                        
            if (null != jc_loginParamCondition.Fk_renyuan_id &&  ""!= jc_loginParamCondition.Fk_renyuan_id)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" FK_RENYUAN_ID=:fk_renyuan_id ");
                OracleParameter pFk_renyuan_id = new OracleParameter(":fk_renyuan_id", OracleDbType.Varchar2);
                pFk_renyuan_id.Direction = ParameterDirection.Input;
                pFk_renyuan_id.Value = jc_loginParamCondition.Fk_renyuan_id;
                sqlparams.Add(pFk_renyuan_id);

            }
                        
            if (null != jc_loginParamCondition.Renyuan_name &&  ""!= jc_loginParamCondition.Renyuan_name)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" RENYUAN_NAME=:renyuan_name ");
                OracleParameter pRenyuan_name = new OracleParameter(":renyuan_name", OracleDbType.NVarchar2);
                pRenyuan_name.Direction = ParameterDirection.Input;
                pRenyuan_name.Value = jc_loginParamCondition.Renyuan_name;
                sqlparams.Add(pRenyuan_name);

            }
                        
            if (null != jc_loginParamCondition.Login_ip &&  ""!= jc_loginParamCondition.Login_ip)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" LOGIN_IP=:login_ip ");
                OracleParameter pLogin_ip = new OracleParameter(":login_ip", OracleDbType.NVarchar2);
                pLogin_ip.Direction = ParameterDirection.Input;
                pLogin_ip.Value = jc_loginParamCondition.Login_ip;
                sqlparams.Add(pLogin_ip);

            }
                        
            if (DateTime.MinValue != jc_loginParamCondition.Login_date &&null != jc_loginParamCondition.Login_date)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" LOGIN_DATE=:login_date ");
                OracleParameter pLogin_date = new OracleParameter(":login_date", OracleDbType.Date);
                pLogin_date.Direction = ParameterDirection.Input;
                pLogin_date.Value = jc_loginParamCondition.Login_date;
                sqlparams.Add(pLogin_date);

            }
                        
            if (null != jc_loginParamCondition.Zfbz &&  ""!= jc_loginParamCondition.Zfbz)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" ZFBZ=:zfbz ");
                OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                pZfbz.Direction = ParameterDirection.Input;
                pZfbz.Value = jc_loginParamCondition.Zfbz;
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
        /// <param name="jc_loginParam"></param>
        /// <returns>影响的行数</returns>
        public bool updateById(Jc_login jc_loginParam,OracleConnection con)
        {
            if ("" == jc_loginParam.Id || null == jc_loginParam.Id)
            {
                throw new Exception("ID不允许为空，请赋值后调用；错误出自：updateById");
            }
            List<OracleParameter> sqlparams = new List<OracleParameter>();

            StringBuilder sql = new StringBuilder("UPDATE JC_LOGIN SET ");
            if (null != jc_loginParam.Fk_user_id &&  ""!= jc_loginParam.Fk_user_id)
            {
                this.isComma(sql);
                sql.Append(" FK_USER_ID=:fk_user_id ");
                OracleParameter pFk_user_id = new OracleParameter(":fk_user_id", OracleDbType.Varchar2);
                pFk_user_id.Direction = ParameterDirection.Input;
                pFk_user_id.Value = jc_loginParam.Fk_user_id;
                sqlparams.Add(pFk_user_id);

            }
                        
            if (null != jc_loginParam.User_name &&  ""!= jc_loginParam.User_name)
            {
                this.isComma(sql);
                sql.Append(" USER_NAME=:user_name ");
                OracleParameter pUser_name = new OracleParameter(":user_name", OracleDbType.NVarchar2);
                pUser_name.Direction = ParameterDirection.Input;
                pUser_name.Value = jc_loginParam.User_name;
                sqlparams.Add(pUser_name);

            }
                        
            if (null != jc_loginParam.Fk_renyuan_id &&  ""!= jc_loginParam.Fk_renyuan_id)
            {
                this.isComma(sql);
                sql.Append(" FK_RENYUAN_ID=:fk_renyuan_id ");
                OracleParameter pFk_renyuan_id = new OracleParameter(":fk_renyuan_id", OracleDbType.Varchar2);
                pFk_renyuan_id.Direction = ParameterDirection.Input;
                pFk_renyuan_id.Value = jc_loginParam.Fk_renyuan_id;
                sqlparams.Add(pFk_renyuan_id);

            }
                        
            if (null != jc_loginParam.Renyuan_name &&  ""!= jc_loginParam.Renyuan_name)
            {
                this.isComma(sql);
                sql.Append(" RENYUAN_NAME=:renyuan_name ");
                OracleParameter pRenyuan_name = new OracleParameter(":renyuan_name", OracleDbType.NVarchar2);
                pRenyuan_name.Direction = ParameterDirection.Input;
                pRenyuan_name.Value = jc_loginParam.Renyuan_name;
                sqlparams.Add(pRenyuan_name);

            }
                        
            if (null != jc_loginParam.Login_ip &&  ""!= jc_loginParam.Login_ip)
            {
                this.isComma(sql);
                sql.Append(" LOGIN_IP=:login_ip ");
                OracleParameter pLogin_ip = new OracleParameter(":login_ip", OracleDbType.NVarchar2);
                pLogin_ip.Direction = ParameterDirection.Input;
                pLogin_ip.Value = jc_loginParam.Login_ip;
                sqlparams.Add(pLogin_ip);

            }
                        
            if (DateTime.MinValue != jc_loginParam.Login_date &&null != jc_loginParam.Login_date)
            {
                this.isComma(sql);
                sql.Append(" LOGIN_DATE=:login_date ");
                OracleParameter pLogin_date = new OracleParameter(":login_date", OracleDbType.Date);
                pLogin_date.Direction = ParameterDirection.Input;
                pLogin_date.Value = jc_loginParam.Login_date;
                sqlparams.Add(pLogin_date);

            }
                        
            if (null != jc_loginParam.Zfbz &&  ""!= jc_loginParam.Zfbz)
            {
                this.isComma(sql);
                sql.Append(" ZFBZ=:zfbz ");
                OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                pZfbz.Direction = ParameterDirection.Input;
                pZfbz.Value = jc_loginParam.Zfbz;
                sqlparams.Add(pZfbz);

            }
                        
            sql.Append(" WHERE ID=:id ");
            OracleParameter pId = new OracleParameter(":id", OracleDbType.Varchar2);
            pId.Value = jc_loginParam.Id;
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
        /// <param name="jc_loginParamList">要修改的Jc_login对象集合</param>
        /// <param name="con">Oracle连接对象（为null时自动生成）</param>
        /// <returns>是否删除成功（影响的行数等于要修改的对象数量时成功）</returns>
        public bool updateByIdBatch(List<Jc_login> jc_loginParamList, OracleConnection con)
        {


            List<string> idList = new List<string>();

            List<string> fk_user_idList = new List<string>();

            List<string> user_nameList = new List<string>();

            List<string> fk_renyuan_idList = new List<string>();

            List<string> renyuan_nameList = new List<string>();

            List<string> login_ipList = new List<string>();

            List<DateTime?> login_dateList = new List<DateTime?>();

            List<string> zfbzList = new List<string>();

            for (int i = 0; i < jc_loginParamList.Count; i++)
            {
                Jc_login jc_loginParam = jc_loginParamList[i];
                if ("" == jc_loginParam.Id || null == jc_loginParam.Id)
                {
                    throw new Exception("下标为" + i + "的数据，ID不能为空，请赋值后调用；错误出自：updateByIdBatch");
                }

            idList.Add(jc_loginParam.Id);

            fk_user_idList.Add(jc_loginParam.Fk_user_id);

            user_nameList.Add(jc_loginParam.User_name);

            fk_renyuan_idList.Add(jc_loginParam.Fk_renyuan_id);

            renyuan_nameList.Add(jc_loginParam.Renyuan_name);

            login_ipList.Add(jc_loginParam.Login_ip);

            login_dateList.Add(jc_loginParam.Login_date);

            zfbzList.Add(jc_loginParam.Zfbz);

            }


            
            List<OracleParameter> sqlparams = new List<OracleParameter>();

            StringBuilder sql = new StringBuilder("UPDATE JC_LOGIN SET ");
            this.isComma(sql);
            sql.Append(" FK_USER_ID=:fk_user_id ");
            OracleParameter pFk_user_id = new OracleParameter(":fk_user_id", OracleDbType.Varchar2);
            pFk_user_id.Direction = ParameterDirection.Input;
            pFk_user_id.Value = fk_user_idList.ToArray();
            sqlparams.Add(pFk_user_id);

            this.isComma(sql);
            sql.Append(" USER_NAME=:user_name ");
            OracleParameter pUser_name = new OracleParameter(":user_name", OracleDbType.NVarchar2);
            pUser_name.Direction = ParameterDirection.Input;
            pUser_name.Value = user_nameList.ToArray();
            sqlparams.Add(pUser_name);

            this.isComma(sql);
            sql.Append(" FK_RENYUAN_ID=:fk_renyuan_id ");
            OracleParameter pFk_renyuan_id = new OracleParameter(":fk_renyuan_id", OracleDbType.Varchar2);
            pFk_renyuan_id.Direction = ParameterDirection.Input;
            pFk_renyuan_id.Value = fk_renyuan_idList.ToArray();
            sqlparams.Add(pFk_renyuan_id);

            this.isComma(sql);
            sql.Append(" RENYUAN_NAME=:renyuan_name ");
            OracleParameter pRenyuan_name = new OracleParameter(":renyuan_name", OracleDbType.NVarchar2);
            pRenyuan_name.Direction = ParameterDirection.Input;
            pRenyuan_name.Value = renyuan_nameList.ToArray();
            sqlparams.Add(pRenyuan_name);

            this.isComma(sql);
            sql.Append(" LOGIN_IP=:login_ip ");
            OracleParameter pLogin_ip = new OracleParameter(":login_ip", OracleDbType.NVarchar2);
            pLogin_ip.Direction = ParameterDirection.Input;
            pLogin_ip.Value = login_ipList.ToArray();
            sqlparams.Add(pLogin_ip);

            this.isComma(sql);
            sql.Append(" LOGIN_DATE=:login_date ");
            OracleParameter pLogin_date = new OracleParameter(":login_date", OracleDbType.Date);
            pLogin_date.Direction = ParameterDirection.Input;
            pLogin_date.Value = login_dateList.ToArray();
            sqlparams.Add(pLogin_date);

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
            int flag = OracleHelper.ExecuteBatch(sql.ToString(), con,jc_loginParamList.Count, sqlparams.ToArray());
            if (jc_loginParamList.Count == flag)
            {
                result = true;
            }
            return result;
        }

        /// <summary>
        /// 根据更新的条件，更新数据（如果需要供事务使用就传入OracleConnection对象，如果不供就传入null，方法自动生成OracleConnection对象）
        /// 不指定ID，如果要根据ID来更新数据，请使用updateForId方法
        /// </summary>
        /// <param name="jc_loginParamCondition">条件对象</param>
        /// <param name="jc_loginParamUpdate">要更新的数据对象</param>
        /// <param name="con">Oracle连接对象（为null时自动生成）</param>
        /// <returns>影响的行数不确定（不为-1就正确）</returns>
        public bool updateByOtherCondition(Jc_login jc_loginParamCondition, Jc_login jc_loginParamUpdate, OracleConnection con)
        {
            if ((null!=jc_loginParamCondition.Id&&"!=jc_loginParamCondition.Id)||(null!=jc_loginParamUpdate.Id&&"!=jc_loginParamUpdate.Id))
            {
                throw new Exception("此方法不允许指定参数的ID，数据库中的ID不允许修改，如需根据ID修改数据，请调用updateById或updateByIdBatch方法；错误出自：updateByOtherCondition");
            }
            List<OracleParameter> sqlparams = new List<OracleParameter>();
            //添加要修改的值
            StringBuilder sql = new StringBuilder("UPDATE JC_LOGIN SET ");
            if (null != jc_loginParamUpdate.Fk_user_id &&  ""!= jc_loginParamUpdate.Fk_user_id)
            {
                this.isComma(sql);
                sql.Append(" FK_USER_ID=:fk_user_id ");
                OracleParameter pFk_user_id = new OracleParameter(":fk_user_id", OracleDbType.Varchar2);
                pFk_user_id.Direction = ParameterDirection.Input;
                pFk_user_id.Value = jc_loginParamUpdate.Fk_user_id;
                sqlparams.Add(pFk_user_id);

            }
                        
            if (null != jc_loginParamUpdate.User_name &&  ""!= jc_loginParamUpdate.User_name)
            {
                this.isComma(sql);
                sql.Append(" USER_NAME=:user_name ");
                OracleParameter pUser_name = new OracleParameter(":user_name", OracleDbType.NVarchar2);
                pUser_name.Direction = ParameterDirection.Input;
                pUser_name.Value = jc_loginParamUpdate.User_name;
                sqlparams.Add(pUser_name);

            }
                        
            if (null != jc_loginParamUpdate.Fk_renyuan_id &&  ""!= jc_loginParamUpdate.Fk_renyuan_id)
            {
                this.isComma(sql);
                sql.Append(" FK_RENYUAN_ID=:fk_renyuan_id ");
                OracleParameter pFk_renyuan_id = new OracleParameter(":fk_renyuan_id", OracleDbType.Varchar2);
                pFk_renyuan_id.Direction = ParameterDirection.Input;
                pFk_renyuan_id.Value = jc_loginParamUpdate.Fk_renyuan_id;
                sqlparams.Add(pFk_renyuan_id);

            }
                        
            if (null != jc_loginParamUpdate.Renyuan_name &&  ""!= jc_loginParamUpdate.Renyuan_name)
            {
                this.isComma(sql);
                sql.Append(" RENYUAN_NAME=:renyuan_name ");
                OracleParameter pRenyuan_name = new OracleParameter(":renyuan_name", OracleDbType.NVarchar2);
                pRenyuan_name.Direction = ParameterDirection.Input;
                pRenyuan_name.Value = jc_loginParamUpdate.Renyuan_name;
                sqlparams.Add(pRenyuan_name);

            }
                        
            if (null != jc_loginParamUpdate.Login_ip &&  ""!= jc_loginParamUpdate.Login_ip)
            {
                this.isComma(sql);
                sql.Append(" LOGIN_IP=:login_ip ");
                OracleParameter pLogin_ip = new OracleParameter(":login_ip", OracleDbType.NVarchar2);
                pLogin_ip.Direction = ParameterDirection.Input;
                pLogin_ip.Value = jc_loginParamUpdate.Login_ip;
                sqlparams.Add(pLogin_ip);

            }
                        
            if (DateTime.MinValue != jc_loginParamUpdate.Login_date &&null != jc_loginParamUpdate.Login_date)
            {
                this.isComma(sql);
                sql.Append(" LOGIN_DATE=:login_date ");
                OracleParameter pLogin_date = new OracleParameter(":login_date", OracleDbType.Date);
                pLogin_date.Direction = ParameterDirection.Input;
                pLogin_date.Value = jc_loginParamUpdate.Login_date;
                sqlparams.Add(pLogin_date);

            }
                        
            if (null != jc_loginParamUpdate.Zfbz &&  ""!= jc_loginParamUpdate.Zfbz)
            {
                this.isComma(sql);
                sql.Append(" ZFBZ=:zfbz ");
                OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                pZfbz.Direction = ParameterDirection.Input;
                pZfbz.Value = jc_loginParamUpdate.Zfbz;
                sqlparams.Add(pZfbz);

            }
                        
            //添加条件的参数
            
            if (null != jc_loginParamCondition.Fk_user_id &&  ""!= jc_loginParamCondition.Fk_user_id)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" FK_USER_ID=:fk_user_id ");
                OracleParameter pFk_user_id = new OracleParameter(":fk_user_id", OracleDbType.Varchar2);
                pFk_user_id.Direction = ParameterDirection.Input;
                pFk_user_id.Value = jc_loginParamCondition.Fk_user_id;
                sqlparams.Add(pFk_user_id);

            }
                        
            if (null != jc_loginParamCondition.User_name &&  ""!= jc_loginParamCondition.User_name)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" USER_NAME=:user_name ");
                OracleParameter pUser_name = new OracleParameter(":user_name", OracleDbType.NVarchar2);
                pUser_name.Direction = ParameterDirection.Input;
                pUser_name.Value = jc_loginParamCondition.User_name;
                sqlparams.Add(pUser_name);

            }
                        
            if (null != jc_loginParamCondition.Fk_renyuan_id &&  ""!= jc_loginParamCondition.Fk_renyuan_id)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" FK_RENYUAN_ID=:fk_renyuan_id ");
                OracleParameter pFk_renyuan_id = new OracleParameter(":fk_renyuan_id", OracleDbType.Varchar2);
                pFk_renyuan_id.Direction = ParameterDirection.Input;
                pFk_renyuan_id.Value = jc_loginParamCondition.Fk_renyuan_id;
                sqlparams.Add(pFk_renyuan_id);

            }
                        
            if (null != jc_loginParamCondition.Renyuan_name &&  ""!= jc_loginParamCondition.Renyuan_name)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" RENYUAN_NAME=:renyuan_name ");
                OracleParameter pRenyuan_name = new OracleParameter(":renyuan_name", OracleDbType.NVarchar2);
                pRenyuan_name.Direction = ParameterDirection.Input;
                pRenyuan_name.Value = jc_loginParamCondition.Renyuan_name;
                sqlparams.Add(pRenyuan_name);

            }
                        
            if (null != jc_loginParamCondition.Login_ip &&  ""!= jc_loginParamCondition.Login_ip)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" LOGIN_IP=:login_ip ");
                OracleParameter pLogin_ip = new OracleParameter(":login_ip", OracleDbType.NVarchar2);
                pLogin_ip.Direction = ParameterDirection.Input;
                pLogin_ip.Value = jc_loginParamCondition.Login_ip;
                sqlparams.Add(pLogin_ip);

            }
                        
            if (DateTime.MinValue != jc_loginParamCondition.Login_date &&null != jc_loginParamCondition.Login_date)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" LOGIN_DATE=:login_date ");
                OracleParameter pLogin_date = new OracleParameter(":login_date", OracleDbType.Date);
                pLogin_date.Direction = ParameterDirection.Input;
                pLogin_date.Value = jc_loginParamCondition.Login_date;
                sqlparams.Add(pLogin_date);

            }
                        
            if (null != jc_loginParamCondition.Zfbz &&  ""!= jc_loginParamCondition.Zfbz)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" ZFBZ=:zfbz ");
                OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                pZfbz.Direction = ParameterDirection.Input;
                pZfbz.Value = jc_loginParamCondition.Zfbz;
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
        /// <returns>Jc_login</returns>
        public Jc_login findById(string id)
        {
            if (""==id||null==id)
            {
                throw new Exception("ID不能为空，请赋值后调用；错误出自：findById");
            }
            StringBuilder sql = new StringBuilder("SELECT A.* ");
            //新建方法findContactObjectsById，在此加入多表连接要显示的项start
            //sql.Append(",B.字段一,B.字段二,B.字段三");
            //新建方法，在此加入多表连接要显示的项end
            sql.Append(" FROM JC_LOGIN A ");
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
        /// <param name="jc_loginParam"></param>
        /// <param name="page">分页对象</param>
        ///<param name="jc_loginParamLike">模糊查询参数</param>
        ///<param name="sortList">排序参数对象的集合</param>
        /// <returns>满足条件的所有Jc_login对象集合list</returns>
        public List<object> find(Jc_login jc_loginParam, Model.Common.PageInfo page,Jc_login jc_loginParamLike,List<SortInfo> sortList)
        {

            //如果没有传查询条件参数，就new一个空的Jc_login对象，标示查询所有数据
            if (null == jc_loginParam)
            {
                jc_loginParam = new Jc_login();
            }
            if (null!=jc_loginParam.Id&&""!=jc_loginParam.Id)
            {
                throw new Exception("此方法不允许指定参数ID，如果需要根据ID查询数据，请调用findById方法；错误出自：find");
            }
            List<Jc_login> jc_loginParamList = new List<Jc_login>();//接收查询出的Jc_login对象集合
            List<OracleParameter> sqlparams = new List<OracleParameter>();//保存参数的集合
            StringBuilder sql = new StringBuilder("SELECT A.* ");
            //新建方法findContactObjects(Jc_login jc_loginParam, Model.Common.PageInfo page)，在此加入多表连接要显示的项start
            //sql.Append(",B.字段一,B.字段二,B.字段三");
            //新建方法，在此加入多表连接要显示的项end
            sql.Append(" FROM JC_LOGIN A ");
            //新建一个方法，在此加入多表连接的语句start
            ////sql.Append(" LEFT JOIN 表名 B ON A.外键=B.ID");
            //新建一个方法，在此加入多表连接的语句end
            
            
            if (null != jc_loginParam.Fk_user_id && "" != jc_loginParam.Fk_user_id)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.FK_USER_ID=:fk_user_id ");
                OracleParameter pFk_user_id = new OracleParameter(":fk_user_id", OracleDbType.Varchar2);
                pFk_user_id.Direction = ParameterDirection.Input;
                pFk_user_id.Value = jc_loginParam.Fk_user_id;
                sqlparams.Add(pFk_user_id);
            }
                
            if (null != jc_loginParam.User_name && "" != jc_loginParam.User_name)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.USER_NAME=:user_name ");
                OracleParameter pUser_name = new OracleParameter(":user_name", OracleDbType.NVarchar2);
                pUser_name.Direction = ParameterDirection.Input;
                pUser_name.Value = jc_loginParam.User_name;
                sqlparams.Add(pUser_name);
            }
                
            if (null != jc_loginParam.Fk_renyuan_id && "" != jc_loginParam.Fk_renyuan_id)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.FK_RENYUAN_ID=:fk_renyuan_id ");
                OracleParameter pFk_renyuan_id = new OracleParameter(":fk_renyuan_id", OracleDbType.Varchar2);
                pFk_renyuan_id.Direction = ParameterDirection.Input;
                pFk_renyuan_id.Value = jc_loginParam.Fk_renyuan_id;
                sqlparams.Add(pFk_renyuan_id);
            }
                
            if (null != jc_loginParam.Renyuan_name && "" != jc_loginParam.Renyuan_name)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.RENYUAN_NAME=:renyuan_name ");
                OracleParameter pRenyuan_name = new OracleParameter(":renyuan_name", OracleDbType.NVarchar2);
                pRenyuan_name.Direction = ParameterDirection.Input;
                pRenyuan_name.Value = jc_loginParam.Renyuan_name;
                sqlparams.Add(pRenyuan_name);
            }
                
            if (null != jc_loginParam.Login_ip && "" != jc_loginParam.Login_ip)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.LOGIN_IP=:login_ip ");
                OracleParameter pLogin_ip = new OracleParameter(":login_ip", OracleDbType.NVarchar2);
                pLogin_ip.Direction = ParameterDirection.Input;
                pLogin_ip.Value = jc_loginParam.Login_ip;
                sqlparams.Add(pLogin_ip);
            }
                
                if (DateTime.MinValue != jc_loginParam.Login_date &&null != jc_loginParam.Login_date)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.LOGIN_DATE=:login_date ");
                    OracleParameter pLogin_date = new OracleParameter(":login_date", OracleDbType.Date);
                pLogin_date.Direction = ParameterDirection.Input;
                pLogin_date.Value = jc_loginParam.Login_date;
                sqlparams.Add(pLogin_date);
                }
                
            if (null != jc_loginParam.Zfbz && "" != jc_loginParam.Zfbz)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.ZFBZ=:zfbz ");
                OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                pZfbz.Direction = ParameterDirection.Input;
                pZfbz.Value = jc_loginParam.Zfbz;
                sqlparams.Add(pZfbz);
            }
                
            if(jc_loginParamLike!=null)
            {

                if (null != jc_loginParamLike.Fk_user_id && "" != jc_loginParamLike.Fk_user_id)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.FK_USER_ID LIKE '%'||:fk_user_id||'%' ");
                    OracleParameter pFk_user_id = new OracleParameter(":fk_user_id", OracleDbType.Varchar2);
                    pFk_user_id.Direction = ParameterDirection.Input;
                    pFk_user_id.Value = jc_loginParamLike.Fk_user_id;
                    sqlparams.Add(pFk_user_id);
                }
                
                if (null != jc_loginParamLike.User_name && "" != jc_loginParamLike.User_name)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.USER_NAME LIKE '%'||:user_name||'%' ");
                    OracleParameter pUser_name = new OracleParameter(":user_name", OracleDbType.NVarchar2);
                    pUser_name.Direction = ParameterDirection.Input;
                    pUser_name.Value = jc_loginParamLike.User_name;
                    sqlparams.Add(pUser_name);
                }
                
                if (null != jc_loginParamLike.Fk_renyuan_id && "" != jc_loginParamLike.Fk_renyuan_id)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.FK_RENYUAN_ID LIKE '%'||:fk_renyuan_id||'%' ");
                    OracleParameter pFk_renyuan_id = new OracleParameter(":fk_renyuan_id", OracleDbType.Varchar2);
                    pFk_renyuan_id.Direction = ParameterDirection.Input;
                    pFk_renyuan_id.Value = jc_loginParamLike.Fk_renyuan_id;
                    sqlparams.Add(pFk_renyuan_id);
                }
                
                if (null != jc_loginParamLike.Renyuan_name && "" != jc_loginParamLike.Renyuan_name)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.RENYUAN_NAME LIKE '%'||:renyuan_name||'%' ");
                    OracleParameter pRenyuan_name = new OracleParameter(":renyuan_name", OracleDbType.NVarchar2);
                    pRenyuan_name.Direction = ParameterDirection.Input;
                    pRenyuan_name.Value = jc_loginParamLike.Renyuan_name;
                    sqlparams.Add(pRenyuan_name);
                }
                
                if (null != jc_loginParamLike.Login_ip && "" != jc_loginParamLike.Login_ip)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.LOGIN_IP LIKE '%'||:login_ip||'%' ");
                    OracleParameter pLogin_ip = new OracleParameter(":login_ip", OracleDbType.NVarchar2);
                    pLogin_ip.Direction = ParameterDirection.Input;
                    pLogin_ip.Value = jc_loginParamLike.Login_ip;
                    sqlparams.Add(pLogin_ip);
                }
                
                if (null != jc_loginParamLike.Zfbz && "" != jc_loginParamLike.Zfbz)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.ZFBZ LIKE '%'||:zfbz||'%' ");
                    OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                    pZfbz.Direction = ParameterDirection.Input;
                    pZfbz.Value = jc_loginParamLike.Zfbz;
                    sqlparams.Add(pZfbz);
                }
                
            }

            this.b_isWhere = false;
            this.addSort(sql, sortList);//排序
            //*******分页start1*********如果分页对象为空，则全部数据查出，如果不为空
            List<object> returnList = new List<object>();//返回的List,索引0为List<Jc_login>对象,索引1为Model.Common.PageInfo分页信息对象
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
            //把每一行数据转换为一个对象放入List<Jc_login>中
            for (int i = 0; i < rows.Count; i++)
            {
                DataRow row = rows[i];
                //jc_loginParamList.Add(this.dataSetContactObjectsToModel(row));
                jc_loginParamList.Add(this.dataSetToModel(row));
            }
            
             //*******分页start2*********如果没有传入分页对象，则新建一个分页对象当做返回值
            if (null == page)
            {
                page = new Model.Common.PageInfo();
                page.AllCount = rows.Count;
            }
            returnList.Add(jc_loginParamList);//把List<Jc_login>放入List<object>中第一个
            returnList.Add(page);//把page对象放入List<object>中第二个
            //*******分页end2*********
            return returnList;
        }

        
        
        /// <summary>
        /// 根据条件得到集合的数量
        /// 第二个条件是模糊查询的条件
        /// </summary>
        /// <returns>int</returns>
        public int getCount(Jc_login jc_loginParam,Jc_login jc_loginParamLike)
        {
            //如果没有传查询条件参数，就new一个空的Jc_login对象，标示查询所有数据
            if (null == jc_loginParam)
            {
                jc_loginParam = new Jc_login();
            }
            List<OracleParameter> sqlparams = new List<OracleParameter>();//保存参数的集合
            StringBuilder sql = new StringBuilder("SELECT COUNT(ID) FROM JC_LOGIN A");
                if (null != jc_loginParam.Fk_user_id && "" != jc_loginParam.Fk_user_id)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.FK_USER_ID=:fk_user_id ");
                    OracleParameter pFk_user_id = new OracleParameter(":fk_user_id", OracleDbType.Varchar2);
                pFk_user_id.Value = jc_loginParam.Fk_user_id;
                sqlparams.Add(pFk_user_id);
                }
                
                if (null != jc_loginParam.User_name && "" != jc_loginParam.User_name)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.USER_NAME=:user_name ");
                    OracleParameter pUser_name = new OracleParameter(":user_name", OracleDbType.NVarchar2);
                pUser_name.Value = jc_loginParam.User_name;
                sqlparams.Add(pUser_name);
                }
                
                if (null != jc_loginParam.Fk_renyuan_id && "" != jc_loginParam.Fk_renyuan_id)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.FK_RENYUAN_ID=:fk_renyuan_id ");
                    OracleParameter pFk_renyuan_id = new OracleParameter(":fk_renyuan_id", OracleDbType.Varchar2);
                pFk_renyuan_id.Value = jc_loginParam.Fk_renyuan_id;
                sqlparams.Add(pFk_renyuan_id);
                }
                
                if (null != jc_loginParam.Renyuan_name && "" != jc_loginParam.Renyuan_name)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.RENYUAN_NAME=:renyuan_name ");
                    OracleParameter pRenyuan_name = new OracleParameter(":renyuan_name", OracleDbType.NVarchar2);
                pRenyuan_name.Value = jc_loginParam.Renyuan_name;
                sqlparams.Add(pRenyuan_name);
                }
                
                if (null != jc_loginParam.Login_ip && "" != jc_loginParam.Login_ip)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.LOGIN_IP=:login_ip ");
                    OracleParameter pLogin_ip = new OracleParameter(":login_ip", OracleDbType.NVarchar2);
                pLogin_ip.Value = jc_loginParam.Login_ip;
                sqlparams.Add(pLogin_ip);
                }
                
                if (DateTime.MinValue != jc_loginParam.Login_date &&null != jc_loginParam.Login_date)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.LOGIN_DATE=:login_date ");
                    OracleParameter pLogin_date = new OracleParameter(":login_date", OracleDbType.Date);
                pLogin_date.Value = jc_loginParam.Login_date;
                sqlparams.Add(pLogin_date);
                }
                
                if (null != jc_loginParam.Zfbz && "" != jc_loginParam.Zfbz)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.ZFBZ=:zfbz ");
                    OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                pZfbz.Value = jc_loginParam.Zfbz;
                sqlparams.Add(pZfbz);
                }
                
            if(jc_loginParamLike!=null)
            {

                if (null != jc_loginParamLike.Fk_user_id && "" != jc_loginParamLike.Fk_user_id)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.FK_USER_ID LIKE '%'||:fk_user_id||'%' ");
                    OracleParameter pFk_user_id = new OracleParameter(":fk_user_id", OracleDbType.Varchar2);
                    pFk_user_id.Direction = ParameterDirection.Input;
                    pFk_user_id.Value = jc_loginParamLike.Fk_user_id;
                    sqlparams.Add(pFk_user_id);
                }
                
                if (null != jc_loginParamLike.User_name && "" != jc_loginParamLike.User_name)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.USER_NAME LIKE '%'||:user_name||'%' ");
                    OracleParameter pUser_name = new OracleParameter(":user_name", OracleDbType.NVarchar2);
                    pUser_name.Direction = ParameterDirection.Input;
                    pUser_name.Value = jc_loginParamLike.User_name;
                    sqlparams.Add(pUser_name);
                }
                
                if (null != jc_loginParamLike.Fk_renyuan_id && "" != jc_loginParamLike.Fk_renyuan_id)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.FK_RENYUAN_ID LIKE '%'||:fk_renyuan_id||'%' ");
                    OracleParameter pFk_renyuan_id = new OracleParameter(":fk_renyuan_id", OracleDbType.Varchar2);
                    pFk_renyuan_id.Direction = ParameterDirection.Input;
                    pFk_renyuan_id.Value = jc_loginParamLike.Fk_renyuan_id;
                    sqlparams.Add(pFk_renyuan_id);
                }
                
                if (null != jc_loginParamLike.Renyuan_name && "" != jc_loginParamLike.Renyuan_name)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.RENYUAN_NAME LIKE '%'||:renyuan_name||'%' ");
                    OracleParameter pRenyuan_name = new OracleParameter(":renyuan_name", OracleDbType.NVarchar2);
                    pRenyuan_name.Direction = ParameterDirection.Input;
                    pRenyuan_name.Value = jc_loginParamLike.Renyuan_name;
                    sqlparams.Add(pRenyuan_name);
                }
                
                if (null != jc_loginParamLike.Login_ip && "" != jc_loginParamLike.Login_ip)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.LOGIN_IP LIKE '%'||:login_ip||'%' ");
                    OracleParameter pLogin_ip = new OracleParameter(":login_ip", OracleDbType.NVarchar2);
                    pLogin_ip.Direction = ParameterDirection.Input;
                    pLogin_ip.Value = jc_loginParamLike.Login_ip;
                    sqlparams.Add(pLogin_ip);
                }
                
                if (null != jc_loginParamLike.Zfbz && "" != jc_loginParamLike.Zfbz)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.ZFBZ LIKE '%'||:zfbz||'%' ");
                    OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                    pZfbz.Direction = ParameterDirection.Input;
                    pZfbz.Value = jc_loginParamLike.Zfbz;
                    sqlparams.Add(pZfbz);
                }
                
            }

            this.b_isWhere = false;
            return Int32.Parse(OracleHelper.ExecuteScalar(sql.ToString(),sqlparams.ToArray()).ToString());
        }


        /// <summary>
        /// 通用的保存方法，根据用户传入的参数，有ID为修改，没有ID为新增(手动生成OracleConnection对象，此方法用于事务，使用事务必须使用同一个OracleConnection对象)
        /// </summary>
        /// <param name="jc_loginParam"></param>
        /// <returns></returns>
        public bool save(Jc_login jc_loginParam,OracleConnection con)
        {
            if ("" != jc_loginParam.Id && null != jc_loginParam.Id)
            {
                //修改
                return this.updateById(jc_loginParam,con);
            }
            else
            {
                //新增
                return this.insert(jc_loginParam,con);
            }
        }

        /// <summary>
        /// 把dataset中的一行转换为model
        /// </summary>
        /// <param name="row"></param>
        /// <returns></returns>
        private Jc_login dataSetToModel(DataRow row)
        {
            Jc_login jc_loginParam = new Jc_login();
            jc_loginParam.Id = Convert.ToString(row["ID"]).Trim(); 
            jc_loginParam.Fk_user_id = Convert.ToString(row["FK_USER_ID"]).Trim(); 
            jc_loginParam.User_name = Convert.ToString(row["USER_NAME"]).Trim(); 
            jc_loginParam.Fk_renyuan_id = Convert.ToString(row["FK_RENYUAN_ID"]).Trim(); 
            jc_loginParam.Renyuan_name = Convert.ToString(row["RENYUAN_NAME"]).Trim(); 
            jc_loginParam.Login_ip = Convert.ToString(row["LOGIN_IP"]).Trim(); 
            jc_loginParam.Login_date =  (DateTime?)this.convertDBNullValue(row["LOGIN_DATE"]);
            jc_loginParam.Zfbz = Convert.ToString(row["ZFBZ"]).Trim(); 
            
            return jc_loginParam;
        }

       
        
        //*******************在此以后添加新的方法start

        //*******************在此以后添加新的方法end
        
    }
}


