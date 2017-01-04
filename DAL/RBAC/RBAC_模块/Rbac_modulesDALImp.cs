

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

namespace DAL.RBAC.RBAC_模块
{
    /// <summary>
    ///数据库访问层的Rbac_modules实现类
    ///此类由代码生成器生成
    ///表名：RBAC_MODULES
    ///生成日期：2015-12-02 16:39:31
    /// 

    ///作者：罗新鑫
    ///联系电话：15087010221
    ///联系邮箱：362527240@qq.com
        
    /// </summary>
    public class Rbac_modulesDALImp :Base.BasDAL,Rbac_modulesDAL
    {

        /// <summary>
        /// 插入一条数据（如果需要供事务使用就传入OracleConnection对象，如果不供就传入null，方法自动生成OracleConnection对象）
        /// 主键为null时，自动生成主键guid，一般不直接调用此方法，请调用save方法进行单条数据的插入和修改       
        /// </summary>
        /// <param name="rbac_modulesParam">要插入的rbac_modulesParam对象</param>
        /// <param name="con">Oracle连接对象（为null时自动生成）</param>
        /// <returns>是否添加成功（影响的行数为1时成功）</returns>
        public bool insert(Rbac_modules rbac_modulesParam,OracleConnection con)
        {
            if (""==rbac_modulesParam.Id||null==rbac_modulesParam.Id)
            {
                rbac_modulesParam.Id = Model.Common.GUIDHelper.getGuid();
            }
            List<OracleParameter> sqlparams = new List<OracleParameter>();
            
            StringBuilder sql = new StringBuilder("INSERT INTO RBAC_MODULES(id,pid,name,window_name,type_code,is_open_window_code,sort,icon,remark,zfbz) VALUES(:id,:pid,:name,:window_name,:type_code,:is_open_window_code,:sort,:icon,:remark,:zfbz)");
            
            OracleParameter pId = new OracleParameter(":id", OracleDbType.Varchar2);
            pId.Direction = ParameterDirection.Input;
            pId.Value = rbac_modulesParam.Id;
            sqlparams.Add(pId);
            OracleParameter pPid = new OracleParameter(":pid", OracleDbType.Varchar2);
            pPid.Direction = ParameterDirection.Input;
            pPid.Value = rbac_modulesParam.Pid;
            sqlparams.Add(pPid);
            OracleParameter pName = new OracleParameter(":name", OracleDbType.NVarchar2);
            pName.Direction = ParameterDirection.Input;
            pName.Value = rbac_modulesParam.Name;
            sqlparams.Add(pName);
            OracleParameter pWindow_name = new OracleParameter(":window_name", OracleDbType.NVarchar2);
            pWindow_name.Direction = ParameterDirection.Input;
            pWindow_name.Value = rbac_modulesParam.Window_name;
            sqlparams.Add(pWindow_name);
            OracleParameter pType_code = new OracleParameter(":type_code", OracleDbType.NVarchar2);
            pType_code.Direction = ParameterDirection.Input;
            pType_code.Value = rbac_modulesParam.Type_code;
            sqlparams.Add(pType_code);
            OracleParameter pIs_open_window_code = new OracleParameter(":is_open_window_code", OracleDbType.NVarchar2);
            pIs_open_window_code.Direction = ParameterDirection.Input;
            pIs_open_window_code.Value = rbac_modulesParam.Is_open_window_code;
            sqlparams.Add(pIs_open_window_code);
            OracleParameter pSort = new OracleParameter(":sort", OracleDbType.Decimal);
            pSort.Direction = ParameterDirection.Input;
            pSort.Value = rbac_modulesParam.Sort;
            sqlparams.Add(pSort);
            OracleParameter pIcon = new OracleParameter(":icon", OracleDbType.NVarchar2);
            pIcon.Direction = ParameterDirection.Input;
            pIcon.Value = rbac_modulesParam.Icon;
            sqlparams.Add(pIcon);
            OracleParameter pRemark = new OracleParameter(":remark", OracleDbType.NVarchar2);
            pRemark.Direction = ParameterDirection.Input;
            pRemark.Value = rbac_modulesParam.Remark;
            sqlparams.Add(pRemark);
            OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
            pZfbz.Direction = ParameterDirection.Input;
            pZfbz.Value = rbac_modulesParam.Zfbz;
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
        /// <param name="rbac_modulesParamList">要插入的rbac_modulesParam对象的集合</param>
        /// <param name="con">Oracle连接对象（为null时自动生成）</param>
        /// <returns>是否添加成功（影响的行数等于保存的对象的数量时成功）</returns>
        public bool inertBatch(List<Rbac_modules> rbac_modulesParamList, OracleConnection con)
        {
            if (rbac_modulesParamList.Count == 0)
            {
                return true;
            }
            List<string> idList = new List<string>();

            List<string> pidList = new List<string>();

            List<string> nameList = new List<string>();

            List<string> window_nameList = new List<string>();

            List<string> type_codeList = new List<string>();

            List<string> is_open_window_codeList = new List<string>();

            List<decimal?> sortList = new List<decimal?>();

            List<string> iconList = new List<string>();

            List<string> remarkList = new List<string>();

            List<string> zfbzList = new List<string>();

            for (int i = 0; i < rbac_modulesParamList.Count; i++)
            {
                Rbac_modules rbac_modulesParam = rbac_modulesParamList[i];
                if ("" == rbac_modulesParam.Id || null == rbac_modulesParam.Id)
                {
                    rbac_modulesParam.Id = Model.Common.GUIDHelper.getGuid();
                }

            idList.Add(rbac_modulesParam.Id);

            pidList.Add(rbac_modulesParam.Pid);

            nameList.Add(rbac_modulesParam.Name);

            window_nameList.Add(rbac_modulesParam.Window_name);

            type_codeList.Add(rbac_modulesParam.Type_code);

            is_open_window_codeList.Add(rbac_modulesParam.Is_open_window_code);

            sortList.Add(rbac_modulesParam.Sort);

            iconList.Add(rbac_modulesParam.Icon);

            remarkList.Add(rbac_modulesParam.Remark);

            zfbzList.Add(rbac_modulesParam.Zfbz);

            }

            List<OracleParameter> sqlparams = new List<OracleParameter>();

            StringBuilder sql = new StringBuilder("INSERT INTO RBAC_MODULES(id,pid,name,window_name,type_code,is_open_window_code,sort,icon,remark,zfbz) VALUES(:id,:pid,:name,:window_name,:type_code,:is_open_window_code,:sort,:icon,:remark,:zfbz)");
            
            OracleParameter pId = new OracleParameter(":id", OracleDbType.Varchar2);
            pId.Direction = ParameterDirection.Input;
            pId.Value = idList.ToArray();
            sqlparams.Add(pId);
            OracleParameter pPid = new OracleParameter(":pid", OracleDbType.Varchar2);
            pPid.Direction = ParameterDirection.Input;
            pPid.Value = pidList.ToArray();
            sqlparams.Add(pPid);
            OracleParameter pName = new OracleParameter(":name", OracleDbType.NVarchar2);
            pName.Direction = ParameterDirection.Input;
            pName.Value = nameList.ToArray();
            sqlparams.Add(pName);
            OracleParameter pWindow_name = new OracleParameter(":window_name", OracleDbType.NVarchar2);
            pWindow_name.Direction = ParameterDirection.Input;
            pWindow_name.Value = window_nameList.ToArray();
            sqlparams.Add(pWindow_name);
            OracleParameter pType_code = new OracleParameter(":type_code", OracleDbType.NVarchar2);
            pType_code.Direction = ParameterDirection.Input;
            pType_code.Value = type_codeList.ToArray();
            sqlparams.Add(pType_code);
            OracleParameter pIs_open_window_code = new OracleParameter(":is_open_window_code", OracleDbType.NVarchar2);
            pIs_open_window_code.Direction = ParameterDirection.Input;
            pIs_open_window_code.Value = is_open_window_codeList.ToArray();
            sqlparams.Add(pIs_open_window_code);
            OracleParameter pSort = new OracleParameter(":sort", OracleDbType.Decimal);
            pSort.Direction = ParameterDirection.Input;
            pSort.Value = sortList.ToArray();
            sqlparams.Add(pSort);
            OracleParameter pIcon = new OracleParameter(":icon", OracleDbType.NVarchar2);
            pIcon.Direction = ParameterDirection.Input;
            pIcon.Value = iconList.ToArray();
            sqlparams.Add(pIcon);
            OracleParameter pRemark = new OracleParameter(":remark", OracleDbType.NVarchar2);
            pRemark.Direction = ParameterDirection.Input;
            pRemark.Value = remarkList.ToArray();
            sqlparams.Add(pRemark);
            OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
            pZfbz.Direction = ParameterDirection.Input;
            pZfbz.Value = zfbzList.ToArray();
            sqlparams.Add(pZfbz);
            bool result = false;
            int flag = -1;
            flag = OracleHelper.ExecuteBatch(sql.ToString(), con, rbac_modulesParamList.Count, sqlparams.ToArray());
            if (rbac_modulesParamList.Count == flag)
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
            StringBuilder sql = new StringBuilder("DELETE RBAC_MODULES WHERE ID=:id");
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
            StringBuilder sql = new StringBuilder("DELETE RBAC_MODULES WHERE ID=:id");
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
        /// <param name="rbac_modulesParamCondition">删除的条件</param>
        /// <param name="con">Oracle连接对象（为null时自动生成）</param>
        /// <returns>无法确定删除的行数（影响行数大于等于0就算成功）</returns>
        public bool deleteByOtherCondition(Rbac_modules rbac_modulesParamCondition, OracleConnection con)
        {
            if (null!=rbac_modulesParamCondition.Id&&""!=rbac_modulesParamCondition.Id)
            {
                throw new Exception("不允许指定参数的ID，如果要根据ID删除数据请调用deleteById或者deleteByIdBatch方法；错误出自：deleteByOtherCondition");
            }
            List<OracleParameter> sqlparams = new List<OracleParameter>();
            StringBuilder sql = new StringBuilder("DELETE RBAC_MODULES ");

            if (null != rbac_modulesParamCondition.Pid &&  ""!= rbac_modulesParamCondition.Pid)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" PID=:pid ");
                OracleParameter pPid = new OracleParameter(":pid", OracleDbType.Varchar2);
                pPid.Direction = ParameterDirection.Input;
                pPid.Value = rbac_modulesParamCondition.Pid;
                sqlparams.Add(pPid);

            }
                        
            if (null != rbac_modulesParamCondition.Name &&  ""!= rbac_modulesParamCondition.Name)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" NAME=:name ");
                OracleParameter pName = new OracleParameter(":name", OracleDbType.NVarchar2);
                pName.Direction = ParameterDirection.Input;
                pName.Value = rbac_modulesParamCondition.Name;
                sqlparams.Add(pName);

            }
                        
            if (null != rbac_modulesParamCondition.Window_name &&  ""!= rbac_modulesParamCondition.Window_name)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" WINDOW_NAME=:window_name ");
                OracleParameter pWindow_name = new OracleParameter(":window_name", OracleDbType.NVarchar2);
                pWindow_name.Direction = ParameterDirection.Input;
                pWindow_name.Value = rbac_modulesParamCondition.Window_name;
                sqlparams.Add(pWindow_name);

            }
                        
            if (null != rbac_modulesParamCondition.Type_code &&  ""!= rbac_modulesParamCondition.Type_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" TYPE_CODE=:type_code ");
                OracleParameter pType_code = new OracleParameter(":type_code", OracleDbType.NVarchar2);
                pType_code.Direction = ParameterDirection.Input;
                pType_code.Value = rbac_modulesParamCondition.Type_code;
                sqlparams.Add(pType_code);

            }
                        
            if (null != rbac_modulesParamCondition.Is_open_window_code &&  ""!= rbac_modulesParamCondition.Is_open_window_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" IS_OPEN_WINDOW_CODE=:is_open_window_code ");
                OracleParameter pIs_open_window_code = new OracleParameter(":is_open_window_code", OracleDbType.NVarchar2);
                pIs_open_window_code.Direction = ParameterDirection.Input;
                pIs_open_window_code.Value = rbac_modulesParamCondition.Is_open_window_code;
                sqlparams.Add(pIs_open_window_code);

            }
                        
            if (null != rbac_modulesParamCondition.Sort)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" SORT=:sort ");
                OracleParameter pSort = new OracleParameter(":sort", OracleDbType.Decimal);
                pSort.Direction = ParameterDirection.Input;
                pSort.Value = rbac_modulesParamCondition.Sort;
                sqlparams.Add(pSort);

            }
                        
            if (null != rbac_modulesParamCondition.Icon &&  ""!= rbac_modulesParamCondition.Icon)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" ICON=:icon ");
                OracleParameter pIcon = new OracleParameter(":icon", OracleDbType.NVarchar2);
                pIcon.Direction = ParameterDirection.Input;
                pIcon.Value = rbac_modulesParamCondition.Icon;
                sqlparams.Add(pIcon);

            }
                        
            if (null != rbac_modulesParamCondition.Remark &&  ""!= rbac_modulesParamCondition.Remark)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" REMARK=:remark ");
                OracleParameter pRemark = new OracleParameter(":remark", OracleDbType.NVarchar2);
                pRemark.Direction = ParameterDirection.Input;
                pRemark.Value = rbac_modulesParamCondition.Remark;
                sqlparams.Add(pRemark);

            }
                        
            if (null != rbac_modulesParamCondition.Zfbz &&  ""!= rbac_modulesParamCondition.Zfbz)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" ZFBZ=:zfbz ");
                OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                pZfbz.Direction = ParameterDirection.Input;
                pZfbz.Value = rbac_modulesParamCondition.Zfbz;
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
        /// <param name="rbac_modulesParam"></param>
        /// <returns>影响的行数</returns>
        public bool updateById(Rbac_modules rbac_modulesParam,OracleConnection con)
        {
            if ("" == rbac_modulesParam.Id || null == rbac_modulesParam.Id)
            {
                throw new Exception("ID不允许为空，请赋值后调用；错误出自：updateById");
            }
            List<OracleParameter> sqlparams = new List<OracleParameter>();

            StringBuilder sql = new StringBuilder("UPDATE RBAC_MODULES SET ");
            if (null != rbac_modulesParam.Pid &&  ""!= rbac_modulesParam.Pid)
            {
                this.isComma(sql);
                sql.Append(" PID=:pid ");
                OracleParameter pPid = new OracleParameter(":pid", OracleDbType.Varchar2);
                pPid.Direction = ParameterDirection.Input;
                pPid.Value = rbac_modulesParam.Pid;
                sqlparams.Add(pPid);

            }
                        
            if (null != rbac_modulesParam.Name &&  ""!= rbac_modulesParam.Name)
            {
                this.isComma(sql);
                sql.Append(" NAME=:name ");
                OracleParameter pName = new OracleParameter(":name", OracleDbType.NVarchar2);
                pName.Direction = ParameterDirection.Input;
                pName.Value = rbac_modulesParam.Name;
                sqlparams.Add(pName);

            }
                        
            if (null != rbac_modulesParam.Window_name &&  ""!= rbac_modulesParam.Window_name)
            {
                this.isComma(sql);
                sql.Append(" WINDOW_NAME=:window_name ");
                OracleParameter pWindow_name = new OracleParameter(":window_name", OracleDbType.NVarchar2);
                pWindow_name.Direction = ParameterDirection.Input;
                pWindow_name.Value = rbac_modulesParam.Window_name;
                sqlparams.Add(pWindow_name);

            }
                        
            if (null != rbac_modulesParam.Type_code &&  ""!= rbac_modulesParam.Type_code)
            {
                this.isComma(sql);
                sql.Append(" TYPE_CODE=:type_code ");
                OracleParameter pType_code = new OracleParameter(":type_code", OracleDbType.NVarchar2);
                pType_code.Direction = ParameterDirection.Input;
                pType_code.Value = rbac_modulesParam.Type_code;
                sqlparams.Add(pType_code);

            }
                        
            if (null != rbac_modulesParam.Is_open_window_code &&  ""!= rbac_modulesParam.Is_open_window_code)
            {
                this.isComma(sql);
                sql.Append(" IS_OPEN_WINDOW_CODE=:is_open_window_code ");
                OracleParameter pIs_open_window_code = new OracleParameter(":is_open_window_code", OracleDbType.NVarchar2);
                pIs_open_window_code.Direction = ParameterDirection.Input;
                pIs_open_window_code.Value = rbac_modulesParam.Is_open_window_code;
                sqlparams.Add(pIs_open_window_code);

            }
                        
            if (null != rbac_modulesParam.Sort)
            {
                this.isComma(sql);
                sql.Append(" SORT=:sort ");
                OracleParameter pSort = new OracleParameter(":sort", OracleDbType.Decimal);
                pSort.Direction = ParameterDirection.Input;
                pSort.Value = rbac_modulesParam.Sort;
                sqlparams.Add(pSort);

            }
                        
            if (null != rbac_modulesParam.Icon &&  ""!= rbac_modulesParam.Icon)
            {
                this.isComma(sql);
                sql.Append(" ICON=:icon ");
                OracleParameter pIcon = new OracleParameter(":icon", OracleDbType.NVarchar2);
                pIcon.Direction = ParameterDirection.Input;
                pIcon.Value = rbac_modulesParam.Icon;
                sqlparams.Add(pIcon);

            }
                        
            if (null != rbac_modulesParam.Remark &&  ""!= rbac_modulesParam.Remark)
            {
                this.isComma(sql);
                sql.Append(" REMARK=:remark ");
                OracleParameter pRemark = new OracleParameter(":remark", OracleDbType.NVarchar2);
                pRemark.Direction = ParameterDirection.Input;
                pRemark.Value = rbac_modulesParam.Remark;
                sqlparams.Add(pRemark);

            }
                        
            if (null != rbac_modulesParam.Zfbz &&  ""!= rbac_modulesParam.Zfbz)
            {
                this.isComma(sql);
                sql.Append(" ZFBZ=:zfbz ");
                OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                pZfbz.Direction = ParameterDirection.Input;
                pZfbz.Value = rbac_modulesParam.Zfbz;
                sqlparams.Add(pZfbz);

            }
                        
            sql.Append(" WHERE ID=:id ");
            OracleParameter pId = new OracleParameter(":id", OracleDbType.Varchar2);
            pId.Value = rbac_modulesParam.Id;
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
        /// <param name="rbac_modulesParamList">要修改的Rbac_modules对象集合</param>
        /// <param name="con">Oracle连接对象（为null时自动生成）</param>
        /// <returns>是否删除成功（影响的行数等于要修改的对象数量时成功）</returns>
        public bool updateByIdBatch(List<Rbac_modules> rbac_modulesParamList, OracleConnection con)
        {


            List<string> idList = new List<string>();

            List<string> pidList = new List<string>();

            List<string> nameList = new List<string>();

            List<string> window_nameList = new List<string>();

            List<string> type_codeList = new List<string>();

            List<string> is_open_window_codeList = new List<string>();

            List<decimal?> sortList = new List<decimal?>();

            List<string> iconList = new List<string>();

            List<string> remarkList = new List<string>();

            List<string> zfbzList = new List<string>();

            for (int i = 0; i < rbac_modulesParamList.Count; i++)
            {
                Rbac_modules rbac_modulesParam = rbac_modulesParamList[i];
                if ("" == rbac_modulesParam.Id || null == rbac_modulesParam.Id)
                {
                    throw new Exception("下标为" + i + "的数据，ID不能为空，请赋值后调用；错误出自：updateByIdBatch");
                }

            idList.Add(rbac_modulesParam.Id);

            pidList.Add(rbac_modulesParam.Pid);

            nameList.Add(rbac_modulesParam.Name);

            window_nameList.Add(rbac_modulesParam.Window_name);

            type_codeList.Add(rbac_modulesParam.Type_code);

            is_open_window_codeList.Add(rbac_modulesParam.Is_open_window_code);

            sortList.Add(rbac_modulesParam.Sort);

            iconList.Add(rbac_modulesParam.Icon);

            remarkList.Add(rbac_modulesParam.Remark);

            zfbzList.Add(rbac_modulesParam.Zfbz);

            }


            
            List<OracleParameter> sqlparams = new List<OracleParameter>();

            StringBuilder sql = new StringBuilder("UPDATE RBAC_MODULES SET ");
            this.isComma(sql);
            sql.Append(" PID=:pid ");
            OracleParameter pPid = new OracleParameter(":pid", OracleDbType.Varchar2);
            pPid.Direction = ParameterDirection.Input;
            pPid.Value = pidList.ToArray();
            sqlparams.Add(pPid);

            this.isComma(sql);
            sql.Append(" NAME=:name ");
            OracleParameter pName = new OracleParameter(":name", OracleDbType.NVarchar2);
            pName.Direction = ParameterDirection.Input;
            pName.Value = nameList.ToArray();
            sqlparams.Add(pName);

            this.isComma(sql);
            sql.Append(" WINDOW_NAME=:window_name ");
            OracleParameter pWindow_name = new OracleParameter(":window_name", OracleDbType.NVarchar2);
            pWindow_name.Direction = ParameterDirection.Input;
            pWindow_name.Value = window_nameList.ToArray();
            sqlparams.Add(pWindow_name);

            this.isComma(sql);
            sql.Append(" TYPE_CODE=:type_code ");
            OracleParameter pType_code = new OracleParameter(":type_code", OracleDbType.NVarchar2);
            pType_code.Direction = ParameterDirection.Input;
            pType_code.Value = type_codeList.ToArray();
            sqlparams.Add(pType_code);

            this.isComma(sql);
            sql.Append(" IS_OPEN_WINDOW_CODE=:is_open_window_code ");
            OracleParameter pIs_open_window_code = new OracleParameter(":is_open_window_code", OracleDbType.NVarchar2);
            pIs_open_window_code.Direction = ParameterDirection.Input;
            pIs_open_window_code.Value = is_open_window_codeList.ToArray();
            sqlparams.Add(pIs_open_window_code);

            this.isComma(sql);
            sql.Append(" SORT=:sort ");
            OracleParameter pSort = new OracleParameter(":sort", OracleDbType.Decimal);
            pSort.Direction = ParameterDirection.Input;
            pSort.Value = sortList.ToArray();
            sqlparams.Add(pSort);

            this.isComma(sql);
            sql.Append(" ICON=:icon ");
            OracleParameter pIcon = new OracleParameter(":icon", OracleDbType.NVarchar2);
            pIcon.Direction = ParameterDirection.Input;
            pIcon.Value = iconList.ToArray();
            sqlparams.Add(pIcon);

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

            sql.Append(" WHERE ID=:id ");
            OracleParameter pId = new OracleParameter(":id", OracleDbType.Varchar2);
            pId.Value = idList.ToArray();
            sqlparams.Add(pId);
            bool result = false;
            int flag = OracleHelper.ExecuteBatch(sql.ToString(), con,rbac_modulesParamList.Count, sqlparams.ToArray());
            if (rbac_modulesParamList.Count == flag)
            {
                result = true;
            }
            return result;
        }

        /// <summary>
        /// 根据更新的条件，更新数据（如果需要供事务使用就传入OracleConnection对象，如果不供就传入null，方法自动生成OracleConnection对象）
        /// 不指定ID，如果要根据ID来更新数据，请使用updateForId方法
        /// </summary>
        /// <param name="rbac_modulesParamCondition">条件对象</param>
        /// <param name="rbac_modulesParamUpdate">要更新的数据对象</param>
        /// <param name="con">Oracle连接对象（为null时自动生成）</param>
        /// <returns>影响的行数不确定（不为-1就正确）</returns>
        public bool updateByOtherCondition(Rbac_modules rbac_modulesParamCondition, Rbac_modules rbac_modulesParamUpdate, OracleConnection con)
        {
            if ((null!=rbac_modulesParamCondition.Id&&"!=rbac_modulesParamCondition.Id)||(null!=rbac_modulesParamUpdate.Id&&"!=rbac_modulesParamUpdate.Id))
            {
                throw new Exception("此方法不允许指定参数的ID，数据库中的ID不允许修改，如需根据ID修改数据，请调用updateById或updateByIdBatch方法；错误出自：updateByOtherCondition");
            }
            List<OracleParameter> sqlparams = new List<OracleParameter>();
            //添加要修改的值
            StringBuilder sql = new StringBuilder("UPDATE RBAC_MODULES SET ");
            if (null != rbac_modulesParamUpdate.Pid &&  ""!= rbac_modulesParamUpdate.Pid)
            {
                this.isComma(sql);
                sql.Append(" PID=:pid ");
                OracleParameter pPid = new OracleParameter(":pid", OracleDbType.Varchar2);
                pPid.Direction = ParameterDirection.Input;
                pPid.Value = rbac_modulesParamUpdate.Pid;
                sqlparams.Add(pPid);

            }
                        
            if (null != rbac_modulesParamUpdate.Name &&  ""!= rbac_modulesParamUpdate.Name)
            {
                this.isComma(sql);
                sql.Append(" NAME=:name ");
                OracleParameter pName = new OracleParameter(":name", OracleDbType.NVarchar2);
                pName.Direction = ParameterDirection.Input;
                pName.Value = rbac_modulesParamUpdate.Name;
                sqlparams.Add(pName);

            }
                        
            if (null != rbac_modulesParamUpdate.Window_name &&  ""!= rbac_modulesParamUpdate.Window_name)
            {
                this.isComma(sql);
                sql.Append(" WINDOW_NAME=:window_name ");
                OracleParameter pWindow_name = new OracleParameter(":window_name", OracleDbType.NVarchar2);
                pWindow_name.Direction = ParameterDirection.Input;
                pWindow_name.Value = rbac_modulesParamUpdate.Window_name;
                sqlparams.Add(pWindow_name);

            }
                        
            if (null != rbac_modulesParamUpdate.Type_code &&  ""!= rbac_modulesParamUpdate.Type_code)
            {
                this.isComma(sql);
                sql.Append(" TYPE_CODE=:type_code ");
                OracleParameter pType_code = new OracleParameter(":type_code", OracleDbType.NVarchar2);
                pType_code.Direction = ParameterDirection.Input;
                pType_code.Value = rbac_modulesParamUpdate.Type_code;
                sqlparams.Add(pType_code);

            }
                        
            if (null != rbac_modulesParamUpdate.Is_open_window_code &&  ""!= rbac_modulesParamUpdate.Is_open_window_code)
            {
                this.isComma(sql);
                sql.Append(" IS_OPEN_WINDOW_CODE=:is_open_window_code ");
                OracleParameter pIs_open_window_code = new OracleParameter(":is_open_window_code", OracleDbType.NVarchar2);
                pIs_open_window_code.Direction = ParameterDirection.Input;
                pIs_open_window_code.Value = rbac_modulesParamUpdate.Is_open_window_code;
                sqlparams.Add(pIs_open_window_code);

            }
                        
            if (null != rbac_modulesParamUpdate.Sort)
            {
                this.isComma(sql);
                sql.Append(" SORT=:sort ");
                OracleParameter pSort = new OracleParameter(":sort", OracleDbType.Decimal);
                pSort.Direction = ParameterDirection.Input;
                pSort.Value = rbac_modulesParamUpdate.Sort;
                sqlparams.Add(pSort);

            }
                        
            if (null != rbac_modulesParamUpdate.Icon &&  ""!= rbac_modulesParamUpdate.Icon)
            {
                this.isComma(sql);
                sql.Append(" ICON=:icon ");
                OracleParameter pIcon = new OracleParameter(":icon", OracleDbType.NVarchar2);
                pIcon.Direction = ParameterDirection.Input;
                pIcon.Value = rbac_modulesParamUpdate.Icon;
                sqlparams.Add(pIcon);

            }
                        
            if (null != rbac_modulesParamUpdate.Remark &&  ""!= rbac_modulesParamUpdate.Remark)
            {
                this.isComma(sql);
                sql.Append(" REMARK=:remark ");
                OracleParameter pRemark = new OracleParameter(":remark", OracleDbType.NVarchar2);
                pRemark.Direction = ParameterDirection.Input;
                pRemark.Value = rbac_modulesParamUpdate.Remark;
                sqlparams.Add(pRemark);

            }
                        
            if (null != rbac_modulesParamUpdate.Zfbz &&  ""!= rbac_modulesParamUpdate.Zfbz)
            {
                this.isComma(sql);
                sql.Append(" ZFBZ=:zfbz ");
                OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                pZfbz.Direction = ParameterDirection.Input;
                pZfbz.Value = rbac_modulesParamUpdate.Zfbz;
                sqlparams.Add(pZfbz);

            }
                        
            //添加条件的参数
            
            if (null != rbac_modulesParamCondition.Pid &&  ""!= rbac_modulesParamCondition.Pid)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" PID=:pid ");
                OracleParameter pPid = new OracleParameter(":pid", OracleDbType.Varchar2);
                pPid.Direction = ParameterDirection.Input;
                pPid.Value = rbac_modulesParamCondition.Pid;
                sqlparams.Add(pPid);

            }
                        
            if (null != rbac_modulesParamCondition.Name &&  ""!= rbac_modulesParamCondition.Name)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" NAME=:name ");
                OracleParameter pName = new OracleParameter(":name", OracleDbType.NVarchar2);
                pName.Direction = ParameterDirection.Input;
                pName.Value = rbac_modulesParamCondition.Name;
                sqlparams.Add(pName);

            }
                        
            if (null != rbac_modulesParamCondition.Window_name &&  ""!= rbac_modulesParamCondition.Window_name)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" WINDOW_NAME=:window_name ");
                OracleParameter pWindow_name = new OracleParameter(":window_name", OracleDbType.NVarchar2);
                pWindow_name.Direction = ParameterDirection.Input;
                pWindow_name.Value = rbac_modulesParamCondition.Window_name;
                sqlparams.Add(pWindow_name);

            }
                        
            if (null != rbac_modulesParamCondition.Type_code &&  ""!= rbac_modulesParamCondition.Type_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" TYPE_CODE=:type_code ");
                OracleParameter pType_code = new OracleParameter(":type_code", OracleDbType.NVarchar2);
                pType_code.Direction = ParameterDirection.Input;
                pType_code.Value = rbac_modulesParamCondition.Type_code;
                sqlparams.Add(pType_code);

            }
                        
            if (null != rbac_modulesParamCondition.Is_open_window_code &&  ""!= rbac_modulesParamCondition.Is_open_window_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" IS_OPEN_WINDOW_CODE=:is_open_window_code ");
                OracleParameter pIs_open_window_code = new OracleParameter(":is_open_window_code", OracleDbType.NVarchar2);
                pIs_open_window_code.Direction = ParameterDirection.Input;
                pIs_open_window_code.Value = rbac_modulesParamCondition.Is_open_window_code;
                sqlparams.Add(pIs_open_window_code);

            }
                        
            if (null != rbac_modulesParamCondition.Sort)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" SORT=:sort ");
                OracleParameter pSort = new OracleParameter(":sort", OracleDbType.Decimal);
                pSort.Direction = ParameterDirection.Input;
                pSort.Value = rbac_modulesParamCondition.Sort;
                sqlparams.Add(pSort);

            }
                        
            if (null != rbac_modulesParamCondition.Icon &&  ""!= rbac_modulesParamCondition.Icon)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" ICON=:icon ");
                OracleParameter pIcon = new OracleParameter(":icon", OracleDbType.NVarchar2);
                pIcon.Direction = ParameterDirection.Input;
                pIcon.Value = rbac_modulesParamCondition.Icon;
                sqlparams.Add(pIcon);

            }
                        
            if (null != rbac_modulesParamCondition.Remark &&  ""!= rbac_modulesParamCondition.Remark)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" REMARK=:remark ");
                OracleParameter pRemark = new OracleParameter(":remark", OracleDbType.NVarchar2);
                pRemark.Direction = ParameterDirection.Input;
                pRemark.Value = rbac_modulesParamCondition.Remark;
                sqlparams.Add(pRemark);

            }
                        
            if (null != rbac_modulesParamCondition.Zfbz &&  ""!= rbac_modulesParamCondition.Zfbz)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" ZFBZ=:zfbz ");
                OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                pZfbz.Direction = ParameterDirection.Input;
                pZfbz.Value = rbac_modulesParamCondition.Zfbz;
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
        /// <returns>Rbac_modules</returns>
        public Rbac_modules findById(string id)
        {
            if (""==id||null==id)
            {
                throw new Exception("ID不能为空，请赋值后调用；错误出自：findById");
            }
            StringBuilder sql = new StringBuilder("SELECT A.* ");
            //新建方法findContactObjectsById，在此加入多表连接要显示的项start
            //sql.Append(",B.字段一,B.字段二,B.字段三");
            //新建方法，在此加入多表连接要显示的项end
            sql.Append(" FROM RBAC_MODULES A ");
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
        /// <param name="rbac_modulesParam"></param>
        /// <param name="page">分页对象</param>
        ///<param name="rbac_modulesParamLike">模糊查询参数</param>
        ///<param name="sortList">排序参数对象的集合</param>
        /// <returns>满足条件的所有Rbac_modules对象集合list</returns>
        public List<object> find(Rbac_modules rbac_modulesParam, Model.Common.PageInfo page,Rbac_modules rbac_modulesParamLike,List<SortInfo> sortList)
        {

            //如果没有传查询条件参数，就new一个空的Rbac_modules对象，标示查询所有数据
            if (null == rbac_modulesParam)
            {
                rbac_modulesParam = new Rbac_modules();
            }
            if (null!=rbac_modulesParam.Id&&""!=rbac_modulesParam.Id)
            {
                throw new Exception("此方法不允许指定参数ID，如果需要根据ID查询数据，请调用findById方法；错误出自：find");
            }
            List<Rbac_modules> rbac_modulesParamList = new List<Rbac_modules>();//接收查询出的Rbac_modules对象集合
            List<OracleParameter> sqlparams = new List<OracleParameter>();//保存参数的集合
            StringBuilder sql = new StringBuilder("SELECT A.* ");
            //新建方法findContactObjects(Rbac_modules rbac_modulesParam, Model.Common.PageInfo page)，在此加入多表连接要显示的项start
            //sql.Append(",B.字段一,B.字段二,B.字段三");
            //新建方法，在此加入多表连接要显示的项end
            sql.Append(" FROM RBAC_MODULES A ");
            //新建一个方法，在此加入多表连接的语句start
            ////sql.Append(" LEFT JOIN 表名 B ON A.外键=B.ID");
            //新建一个方法，在此加入多表连接的语句end
            
            
            if (null != rbac_modulesParam.Pid && "" != rbac_modulesParam.Pid)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.PID=:pid ");
                OracleParameter pPid = new OracleParameter(":pid", OracleDbType.Varchar2);
                pPid.Direction = ParameterDirection.Input;
                pPid.Value = rbac_modulesParam.Pid;
                sqlparams.Add(pPid);
            }
                
            if (null != rbac_modulesParam.Name && "" != rbac_modulesParam.Name)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.NAME=:name ");
                OracleParameter pName = new OracleParameter(":name", OracleDbType.NVarchar2);
                pName.Direction = ParameterDirection.Input;
                pName.Value = rbac_modulesParam.Name;
                sqlparams.Add(pName);
            }
                
            if (null != rbac_modulesParam.Window_name && "" != rbac_modulesParam.Window_name)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.WINDOW_NAME=:window_name ");
                OracleParameter pWindow_name = new OracleParameter(":window_name", OracleDbType.NVarchar2);
                pWindow_name.Direction = ParameterDirection.Input;
                pWindow_name.Value = rbac_modulesParam.Window_name;
                sqlparams.Add(pWindow_name);
            }
                
            if (null != rbac_modulesParam.Type_code && "" != rbac_modulesParam.Type_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.TYPE_CODE=:type_code ");
                OracleParameter pType_code = new OracleParameter(":type_code", OracleDbType.NVarchar2);
                pType_code.Direction = ParameterDirection.Input;
                pType_code.Value = rbac_modulesParam.Type_code;
                sqlparams.Add(pType_code);
            }
                
            if (null != rbac_modulesParam.Is_open_window_code && "" != rbac_modulesParam.Is_open_window_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.IS_OPEN_WINDOW_CODE=:is_open_window_code ");
                OracleParameter pIs_open_window_code = new OracleParameter(":is_open_window_code", OracleDbType.NVarchar2);
                pIs_open_window_code.Direction = ParameterDirection.Input;
                pIs_open_window_code.Value = rbac_modulesParam.Is_open_window_code;
                sqlparams.Add(pIs_open_window_code);
            }
                
            if (null != rbac_modulesParam.Sort)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.SORT=:sort ");
                OracleParameter pSort = new OracleParameter(":sort", OracleDbType.Decimal);
                pSort.Direction = ParameterDirection.Input;
                pSort.Value = rbac_modulesParam.Sort;
                sqlparams.Add(pSort);

            }
                        
            if (null != rbac_modulesParam.Icon && "" != rbac_modulesParam.Icon)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.ICON=:icon ");
                OracleParameter pIcon = new OracleParameter(":icon", OracleDbType.NVarchar2);
                pIcon.Direction = ParameterDirection.Input;
                pIcon.Value = rbac_modulesParam.Icon;
                sqlparams.Add(pIcon);
            }
                
            if (null != rbac_modulesParam.Remark && "" != rbac_modulesParam.Remark)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.REMARK=:remark ");
                OracleParameter pRemark = new OracleParameter(":remark", OracleDbType.NVarchar2);
                pRemark.Direction = ParameterDirection.Input;
                pRemark.Value = rbac_modulesParam.Remark;
                sqlparams.Add(pRemark);
            }
                
            if (null != rbac_modulesParam.Zfbz && "" != rbac_modulesParam.Zfbz)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.ZFBZ=:zfbz ");
                OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                pZfbz.Direction = ParameterDirection.Input;
                pZfbz.Value = rbac_modulesParam.Zfbz;
                sqlparams.Add(pZfbz);
            }
                
            if(rbac_modulesParamLike!=null)
            {

                if (null != rbac_modulesParamLike.Pid && "" != rbac_modulesParamLike.Pid)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.PID LIKE '%'||:pid||'%' ");
                    OracleParameter pPid = new OracleParameter(":pid", OracleDbType.Varchar2);
                    pPid.Direction = ParameterDirection.Input;
                    pPid.Value = rbac_modulesParamLike.Pid;
                    sqlparams.Add(pPid);
                }
                
                if (null != rbac_modulesParamLike.Name && "" != rbac_modulesParamLike.Name)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.NAME LIKE '%'||:name||'%' ");
                    OracleParameter pName = new OracleParameter(":name", OracleDbType.NVarchar2);
                    pName.Direction = ParameterDirection.Input;
                    pName.Value = rbac_modulesParamLike.Name;
                    sqlparams.Add(pName);
                }
                
                if (null != rbac_modulesParamLike.Window_name && "" != rbac_modulesParamLike.Window_name)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.WINDOW_NAME LIKE '%'||:window_name||'%' ");
                    OracleParameter pWindow_name = new OracleParameter(":window_name", OracleDbType.NVarchar2);
                    pWindow_name.Direction = ParameterDirection.Input;
                    pWindow_name.Value = rbac_modulesParamLike.Window_name;
                    sqlparams.Add(pWindow_name);
                }
                
                if (null != rbac_modulesParamLike.Type_code && "" != rbac_modulesParamLike.Type_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.TYPE_CODE LIKE '%'||:type_code||'%' ");
                    OracleParameter pType_code = new OracleParameter(":type_code", OracleDbType.NVarchar2);
                    pType_code.Direction = ParameterDirection.Input;
                    pType_code.Value = rbac_modulesParamLike.Type_code;
                    sqlparams.Add(pType_code);
                }
                
                if (null != rbac_modulesParamLike.Is_open_window_code && "" != rbac_modulesParamLike.Is_open_window_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.IS_OPEN_WINDOW_CODE LIKE '%'||:is_open_window_code||'%' ");
                    OracleParameter pIs_open_window_code = new OracleParameter(":is_open_window_code", OracleDbType.NVarchar2);
                    pIs_open_window_code.Direction = ParameterDirection.Input;
                    pIs_open_window_code.Value = rbac_modulesParamLike.Is_open_window_code;
                    sqlparams.Add(pIs_open_window_code);
                }
                
                if (null != rbac_modulesParamLike.Icon && "" != rbac_modulesParamLike.Icon)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.ICON LIKE '%'||:icon||'%' ");
                    OracleParameter pIcon = new OracleParameter(":icon", OracleDbType.NVarchar2);
                    pIcon.Direction = ParameterDirection.Input;
                    pIcon.Value = rbac_modulesParamLike.Icon;
                    sqlparams.Add(pIcon);
                }
                
                if (null != rbac_modulesParamLike.Remark && "" != rbac_modulesParamLike.Remark)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.REMARK LIKE '%'||:remark||'%' ");
                    OracleParameter pRemark = new OracleParameter(":remark", OracleDbType.NVarchar2);
                    pRemark.Direction = ParameterDirection.Input;
                    pRemark.Value = rbac_modulesParamLike.Remark;
                    sqlparams.Add(pRemark);
                }
                
                if (null != rbac_modulesParamLike.Zfbz && "" != rbac_modulesParamLike.Zfbz)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.ZFBZ LIKE '%'||:zfbz||'%' ");
                    OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                    pZfbz.Direction = ParameterDirection.Input;
                    pZfbz.Value = rbac_modulesParamLike.Zfbz;
                    sqlparams.Add(pZfbz);
                }
                
            }

            this.b_isWhere = false;
            this.addSort(sql, sortList);//排序
            //*******分页start1*********如果分页对象为空，则全部数据查出，如果不为空
            List<object> returnList = new List<object>();//返回的List,索引0为List<Rbac_modules>对象,索引1为Model.Common.PageInfo分页信息对象
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
            //把每一行数据转换为一个对象放入List<Rbac_modules>中
            for (int i = 0; i < rows.Count; i++)
            {
                DataRow row = rows[i];
                //rbac_modulesParamList.Add(this.dataSetContactObjectsToModel(row));
                rbac_modulesParamList.Add(this.dataSetToModel(row));
            }
            
             //*******分页start2*********如果没有传入分页对象，则新建一个分页对象当做返回值
            if (null == page)
            {
                page = new Model.Common.PageInfo();
                page.AllCount = rows.Count;
            }
            returnList.Add(rbac_modulesParamList);//把List<Rbac_modules>放入List<object>中第一个
            returnList.Add(page);//把page对象放入List<object>中第二个
            //*******分页end2*********
            return returnList;
        }

        
        
        /// <summary>
        /// 根据条件得到集合的数量
        /// 第二个条件是模糊查询的条件
        /// </summary>
        /// <returns>int</returns>
        public int getCount(Rbac_modules rbac_modulesParam,Rbac_modules rbac_modulesParamLike)
        {
            //如果没有传查询条件参数，就new一个空的Rbac_modules对象，标示查询所有数据
            if (null == rbac_modulesParam)
            {
                rbac_modulesParam = new Rbac_modules();
            }
            List<OracleParameter> sqlparams = new List<OracleParameter>();//保存参数的集合
            StringBuilder sql = new StringBuilder("SELECT COUNT(ID) FROM RBAC_MODULES A");
                if (null != rbac_modulesParam.Pid && "" != rbac_modulesParam.Pid)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.PID=:pid ");
                    OracleParameter pPid = new OracleParameter(":pid", OracleDbType.Varchar2);
                pPid.Value = rbac_modulesParam.Pid;
                sqlparams.Add(pPid);
                }
                
                if (null != rbac_modulesParam.Name && "" != rbac_modulesParam.Name)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.NAME=:name ");
                    OracleParameter pName = new OracleParameter(":name", OracleDbType.NVarchar2);
                pName.Value = rbac_modulesParam.Name;
                sqlparams.Add(pName);
                }
                
                if (null != rbac_modulesParam.Window_name && "" != rbac_modulesParam.Window_name)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.WINDOW_NAME=:window_name ");
                    OracleParameter pWindow_name = new OracleParameter(":window_name", OracleDbType.NVarchar2);
                pWindow_name.Value = rbac_modulesParam.Window_name;
                sqlparams.Add(pWindow_name);
                }
                
                if (null != rbac_modulesParam.Type_code && "" != rbac_modulesParam.Type_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.TYPE_CODE=:type_code ");
                    OracleParameter pType_code = new OracleParameter(":type_code", OracleDbType.NVarchar2);
                pType_code.Value = rbac_modulesParam.Type_code;
                sqlparams.Add(pType_code);
                }
                
                if (null != rbac_modulesParam.Is_open_window_code && "" != rbac_modulesParam.Is_open_window_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.IS_OPEN_WINDOW_CODE=:is_open_window_code ");
                    OracleParameter pIs_open_window_code = new OracleParameter(":is_open_window_code", OracleDbType.NVarchar2);
                pIs_open_window_code.Value = rbac_modulesParam.Is_open_window_code;
                sqlparams.Add(pIs_open_window_code);
                }
                
            if (null != rbac_modulesParam.Sort)
            {
                this.isComma(sql);
                sql.Append(" SORT=:sort ");
                OracleParameter pSort = new OracleParameter(":sort", OracleDbType.Decimal);
                pSort.Value = rbac_modulesParam.Sort;
                sqlparams.Add(pSort);

            }
                        
                if (null != rbac_modulesParam.Icon && "" != rbac_modulesParam.Icon)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.ICON=:icon ");
                    OracleParameter pIcon = new OracleParameter(":icon", OracleDbType.NVarchar2);
                pIcon.Value = rbac_modulesParam.Icon;
                sqlparams.Add(pIcon);
                }
                
                if (null != rbac_modulesParam.Remark && "" != rbac_modulesParam.Remark)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.REMARK=:remark ");
                    OracleParameter pRemark = new OracleParameter(":remark", OracleDbType.NVarchar2);
                pRemark.Value = rbac_modulesParam.Remark;
                sqlparams.Add(pRemark);
                }
                
                if (null != rbac_modulesParam.Zfbz && "" != rbac_modulesParam.Zfbz)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.ZFBZ=:zfbz ");
                    OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                pZfbz.Value = rbac_modulesParam.Zfbz;
                sqlparams.Add(pZfbz);
                }
                
            if(rbac_modulesParamLike!=null)
            {

                if (null != rbac_modulesParamLike.Pid && "" != rbac_modulesParamLike.Pid)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.PID LIKE '%'||:pid||'%' ");
                    OracleParameter pPid = new OracleParameter(":pid", OracleDbType.Varchar2);
                    pPid.Direction = ParameterDirection.Input;
                    pPid.Value = rbac_modulesParamLike.Pid;
                    sqlparams.Add(pPid);
                }
                
                if (null != rbac_modulesParamLike.Name && "" != rbac_modulesParamLike.Name)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.NAME LIKE '%'||:name||'%' ");
                    OracleParameter pName = new OracleParameter(":name", OracleDbType.NVarchar2);
                    pName.Direction = ParameterDirection.Input;
                    pName.Value = rbac_modulesParamLike.Name;
                    sqlparams.Add(pName);
                }
                
                if (null != rbac_modulesParamLike.Window_name && "" != rbac_modulesParamLike.Window_name)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.WINDOW_NAME LIKE '%'||:window_name||'%' ");
                    OracleParameter pWindow_name = new OracleParameter(":window_name", OracleDbType.NVarchar2);
                    pWindow_name.Direction = ParameterDirection.Input;
                    pWindow_name.Value = rbac_modulesParamLike.Window_name;
                    sqlparams.Add(pWindow_name);
                }
                
                if (null != rbac_modulesParamLike.Type_code && "" != rbac_modulesParamLike.Type_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.TYPE_CODE LIKE '%'||:type_code||'%' ");
                    OracleParameter pType_code = new OracleParameter(":type_code", OracleDbType.NVarchar2);
                    pType_code.Direction = ParameterDirection.Input;
                    pType_code.Value = rbac_modulesParamLike.Type_code;
                    sqlparams.Add(pType_code);
                }
                
                if (null != rbac_modulesParamLike.Is_open_window_code && "" != rbac_modulesParamLike.Is_open_window_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.IS_OPEN_WINDOW_CODE LIKE '%'||:is_open_window_code||'%' ");
                    OracleParameter pIs_open_window_code = new OracleParameter(":is_open_window_code", OracleDbType.NVarchar2);
                    pIs_open_window_code.Direction = ParameterDirection.Input;
                    pIs_open_window_code.Value = rbac_modulesParamLike.Is_open_window_code;
                    sqlparams.Add(pIs_open_window_code);
                }
                
                if (null != rbac_modulesParamLike.Icon && "" != rbac_modulesParamLike.Icon)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.ICON LIKE '%'||:icon||'%' ");
                    OracleParameter pIcon = new OracleParameter(":icon", OracleDbType.NVarchar2);
                    pIcon.Direction = ParameterDirection.Input;
                    pIcon.Value = rbac_modulesParamLike.Icon;
                    sqlparams.Add(pIcon);
                }
                
                if (null != rbac_modulesParamLike.Remark && "" != rbac_modulesParamLike.Remark)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.REMARK LIKE '%'||:remark||'%' ");
                    OracleParameter pRemark = new OracleParameter(":remark", OracleDbType.NVarchar2);
                    pRemark.Direction = ParameterDirection.Input;
                    pRemark.Value = rbac_modulesParamLike.Remark;
                    sqlparams.Add(pRemark);
                }
                
                if (null != rbac_modulesParamLike.Zfbz && "" != rbac_modulesParamLike.Zfbz)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.ZFBZ LIKE '%'||:zfbz||'%' ");
                    OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                    pZfbz.Direction = ParameterDirection.Input;
                    pZfbz.Value = rbac_modulesParamLike.Zfbz;
                    sqlparams.Add(pZfbz);
                }
                
            }
this.b_isWhere = false;return Int32.Parse(OracleHelper.ExecuteScalar(sql.ToString(),sqlparams.ToArray()).ToString());
        }


        /// <summary>
        /// 通用的保存方法，根据用户传入的参数，有ID为修改，没有ID为新增(手动生成OracleConnection对象，此方法用于事务，使用事务必须使用同一个OracleConnection对象)
        /// </summary>
        /// <param name="rbac_modulesParam"></param>
        /// <returns></returns>
        public bool save(Rbac_modules rbac_modulesParam,OracleConnection con)
        {
            if ("" != rbac_modulesParam.Id && null != rbac_modulesParam.Id)
            {
                //修改
                return this.updateById(rbac_modulesParam,con);
            }
            else
            {
                //新增
                return this.insert(rbac_modulesParam,con);
            }
        }

        /// <summary>
        /// 把dataset中的一行转换为model
        /// </summary>
        /// <param name="row"></param>
        /// <returns></returns>
        private Rbac_modules dataSetToModel(DataRow row)
        {
            Rbac_modules rbac_modulesParam = new Rbac_modules();
            rbac_modulesParam.Id = Convert.ToString(row["ID"]).Trim(); 
            rbac_modulesParam.Pid = Convert.ToString(row["PID"]).Trim(); 
            rbac_modulesParam.Name = Convert.ToString(row["NAME"]).Trim(); 
            rbac_modulesParam.Window_name = Convert.ToString(row["WINDOW_NAME"]).Trim(); 
            rbac_modulesParam.Type_code = Convert.ToString(row["TYPE_CODE"]).Trim(); 
            rbac_modulesParam.Is_open_window_code = Convert.ToString(row["IS_OPEN_WINDOW_CODE"]).Trim(); 
            rbac_modulesParam.Sort =  (decimal?)this.convertDBNullValue(row["SORT"]);
            rbac_modulesParam.Icon = Convert.ToString(row["ICON"]).Trim(); 
            rbac_modulesParam.Remark = Convert.ToString(row["REMARK"]).Trim(); 
            rbac_modulesParam.Zfbz = Convert.ToString(row["ZFBZ"]).Trim(); 
            
            return rbac_modulesParam;
        }

       
        
        //*******************在此以后添加新的方法start
        #region DAL层的implement,实现，start

        /// <summary>
        /// 把dataset中的一行转换为model, 包括相关联的外键对象
        /// </summary>
        /// <param name="row"></param>
        /// <returns></returns>
        private Rbac_modules dataSetContactObjectsToModel(DataRow row)
        {
            Rbac_modules rbac_modulesParam = this.dataSetToModel(row);

            //添加代码类别实体对象,模块类型，菜单还是功能点（关联代码表）对象
            Jc_code typeCode = new Jc_code();
            typeCode.Id = Convert.ToString(row["TYPE_CODE_ID"]).Trim();
            typeCode.Name = Convert.ToString(row["TYPE_CODE_NAME"]).Trim();
            typeCode.Value = Convert.ToString(row["TYPE_CODE_VALUE"]).Trim();
            typeCode.Fk_code_type = Convert.ToString(row["TYPE_CODE_FKCODETYPE"]).Trim();
            typeCode.Zfbz = Convert.ToString(row["TYPE_CODE_ZFBZ"]).Trim();
            typeCode.Remark = Convert.ToString(row["TYPE_CODE_REMARK"]).Trim();
            rbac_modulesParam.TypeCode = typeCode;

            //添加代码类别实体对象,菜单是否允许直接打开窗体（功能点必须允许,菜单可选，关联代码表，是否）对象
            Jc_code is_open_windowCode = new Jc_code();
            is_open_windowCode.Id = Convert.ToString(row["IS_OPEN_WINDOW_CODE_ID"]).Trim();
            is_open_windowCode.Name = Convert.ToString(row["IS_OPEN_WINDOW_CODE_NAME"]).Trim();
            is_open_windowCode.Value = Convert.ToString(row["IS_OPEN_WINDOW_CODE_VALUE"]).Trim();
            is_open_windowCode.Fk_code_type = Convert.ToString(row["IS_OPEN_WINDOW_CODE_FKCODETYPE"]).Trim();
            is_open_windowCode.Zfbz = Convert.ToString(row["IS_OPEN_WINDOW_CODE_ZFBZ"]).Trim();
            is_open_windowCode.Remark = Convert.ToString(row["IS_OPEN_WINDOW_CODE_REMARK"]).Trim();
            rbac_modulesParam.Is_open_windowCode = is_open_windowCode;

            return rbac_modulesParam;
        }



        /// <summary>
        /// 查找指定ID的用户,得到相关联的外键对象的方法
        /// </summary>
        /// <remarks>如果id为null、id重复、id未找到就抛异常</remarks>
        /// <returns>Rbac_modules</returns>
        public Rbac_modules findContactObjectsById(string id)
        {
            if ("" == id || null == id)
            {
                throw new Exception("主键ID不能为空，请赋值");
            }
            StringBuilder sql = new StringBuilder("SELECT A.* ");
            //新建方法findContactObjectsById，在此加入多表连接要显示的项start
            //sql.Append(",B.字段一,B.字段二,B.字段三");

            sql.Append(@"
            ,TT_TYPE_CODE.ID AS TYPE_CODE_ID,TT_TYPE_CODE.NAME AS TYPE_CODE_NAME,TT_TYPE_CODE.VALUE AS TYPE_CODE_VALUE,TT_TYPE_CODE.FK_CODE_TYPE AS TYPE_CODE_FKCODETYPE,TT_TYPE_CODE.ZFBZ AS TYPE_CODE_ZFBZ,TT_TYPE_CODE.REMARK AS TYPE_CODE_REMARK
            ");

            sql.Append(@"
            ,TT_IS_OPEN_WINDOW_CODE.ID AS IS_OPEN_WINDOW_CODE_ID,TT_IS_OPEN_WINDOW_CODE.NAME AS IS_OPEN_WINDOW_CODE_NAME,TT_IS_OPEN_WINDOW_CODE.VALUE AS IS_OPEN_WINDOW_CODE_VALUE,TT_IS_OPEN_WINDOW_CODE.FK_CODE_TYPE AS IS_OPEN_WINDOW_CODE_FKCODETYPE,TT_IS_OPEN_WINDOW_CODE.ZFBZ AS IS_OPEN_WINDOW_CODE_ZFBZ,TT_IS_OPEN_WINDOW_CODE.REMARK AS IS_OPEN_WINDOW_CODE_REMARK
            ");

            //新建方法，在此加入多表连接要显示的项end
            sql.Append(" FROM RBAC_MODULES A ");
            //新建一个方法，在此加入多表连接的语句start
            //sql.Append("LEFT JOIN 外键表名 B ON A.外键=B.ID");

            sql.Append(@" 
                        LEFT JOIN 
                        (SELECT X.* FROM JC_CODE X WHERE X.FK_CODE_TYPE IN (SELECT Y.ID FROM JC_CODE_TYPE Y WHERE Y.VALUE='" + Model.Common.CommonCode.代码类型值.RBAC_模块类型 + @"')) TT_TYPE_CODE
                        ON A.TYPE_CODE = TT_TYPE_CODE.VALUE
            ");

            sql.Append(@" 
                        LEFT JOIN 
                        (SELECT X.* FROM JC_CODE X WHERE X.FK_CODE_TYPE IN (SELECT Y.ID FROM JC_CODE_TYPE Y WHERE Y.VALUE='" + Model.Common.CommonCode.代码类型值.基础_是否 + @"')) TT_IS_OPEN_WINDOW_CODE
                        ON A.IS_OPEN_WINDOW_CODE = TT_IS_OPEN_WINDOW_CODE.VALUE
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
        /// <param name="rbac_modulesParam"></param>
        /// <param name="page">分页对象</param>
        ///<param name="rbac_modulesParamLike">模糊查询参数</param>
        ///<param name="sortList">排序参数对象的集合</param>
        /// <returns>满足条件的所有Rbac_modules对象集合list</returns>
        public List<object> findContactObjects(Rbac_modules rbac_modulesParam, Model.Common.PageInfo page, Rbac_modules rbac_modulesParamLike, List<SortInfo> sortList)
        {
            //如果没有传查询条件参数，就new一个空的Rbac_modules对象，标示查询所有数据
            if (null == rbac_modulesParam)
            {
                rbac_modulesParam = new Rbac_modules();
            }
            if (null != rbac_modulesParam.Id && "" != rbac_modulesParam.Id)
            {
                throw new Exception("此方法不允许指定参数ID，如果需要根据ID查询数据，请调用findById方法；错误出自：find");
            }

            List<Rbac_modules> rbac_modulesParamList = new List<Rbac_modules>();//接收查询出的Rbac_modules对象集合
            List<OracleParameter> sqlparams = new List<OracleParameter>();//保存参数的集合
            StringBuilder sql = new StringBuilder("SELECT A.* ");
            //新建方法findAllContactObjects(Rbac_modules rbac_modulesParam, Model.Common.PageInfo page)，在此加入多表连接要显示的项start
            //sql.Append(",B.字段一,B.字段二,B.字段三");

            sql.Append(@"
            ,TT_TYPE_CODE.ID AS TYPE_CODE_ID,TT_TYPE_CODE.NAME AS TYPE_CODE_NAME,TT_TYPE_CODE.VALUE AS TYPE_CODE_VALUE,TT_TYPE_CODE.FK_CODE_TYPE AS TYPE_CODE_FKCODETYPE,TT_TYPE_CODE.ZFBZ AS TYPE_CODE_ZFBZ,TT_TYPE_CODE.REMARK AS TYPE_CODE_REMARK
            ");

            sql.Append(@"
            ,TT_IS_OPEN_WINDOW_CODE.ID AS IS_OPEN_WINDOW_CODE_ID,TT_IS_OPEN_WINDOW_CODE.NAME AS IS_OPEN_WINDOW_CODE_NAME,TT_IS_OPEN_WINDOW_CODE.VALUE AS IS_OPEN_WINDOW_CODE_VALUE,TT_IS_OPEN_WINDOW_CODE.FK_CODE_TYPE AS IS_OPEN_WINDOW_CODE_FKCODETYPE,TT_IS_OPEN_WINDOW_CODE.ZFBZ AS IS_OPEN_WINDOW_CODE_ZFBZ,TT_IS_OPEN_WINDOW_CODE.REMARK AS IS_OPEN_WINDOW_CODE_REMARK
            ");

            //新建方法，在此加入多表连接要显示的项end
            sql.Append(" FROM RBAC_MODULES A ");
            //新建一个方法，在此加入多表连接的语句start
            ////sql.Append(" LEFT JOIN 表名 B ON A.外键=B.ID");

            sql.Append(@" 
                        LEFT JOIN 
                        (SELECT X.* FROM JC_CODE X WHERE X.FK_CODE_TYPE IN (SELECT Y.ID FROM JC_CODE_TYPE Y WHERE Y.VALUE='" + Model.Common.CommonCode.代码类型值.RBAC_模块类型 + @"')) TT_TYPE_CODE
                        ON A.TYPE_CODE = TT_TYPE_CODE.VALUE
            ");

            sql.Append(@" 
                        LEFT JOIN 
                        (SELECT X.* FROM JC_CODE X WHERE X.FK_CODE_TYPE IN (SELECT Y.ID FROM JC_CODE_TYPE Y WHERE Y.VALUE='" + Model.Common.CommonCode.代码类型值.基础_是否 + @"')) TT_IS_OPEN_WINDOW_CODE
                        ON A.IS_OPEN_WINDOW_CODE = TT_IS_OPEN_WINDOW_CODE.VALUE
            ");

            //新建一个方法，在此加入多表连接的语句end


            if (null != rbac_modulesParam.Pid && "" != rbac_modulesParam.Pid)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.PID=:pid ");
                OracleParameter pPid = new OracleParameter(":pid", OracleDbType.Varchar2);
                pPid.Value = rbac_modulesParam.Pid;
                sqlparams.Add(pPid);
            }

            if (null != rbac_modulesParam.Name && "" != rbac_modulesParam.Name)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.NAME=:name ");
                OracleParameter pName = new OracleParameter(":name", OracleDbType.NVarchar2);
                pName.Value = rbac_modulesParam.Name;
                sqlparams.Add(pName);
            }

            if (null != rbac_modulesParam.Window_name && "" != rbac_modulesParam.Window_name)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.WINDOW_NAME=:window_name ");
                OracleParameter pWindow_name = new OracleParameter(":window_name", OracleDbType.NVarchar2);
                pWindow_name.Value = rbac_modulesParam.Window_name;
                sqlparams.Add(pWindow_name);
            }

            if (null != rbac_modulesParam.Type_code && "" != rbac_modulesParam.Type_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.TYPE_CODE=:type_code ");
                OracleParameter pType_code = new OracleParameter(":type_code", OracleDbType.NVarchar2);
                pType_code.Value = rbac_modulesParam.Type_code;
                sqlparams.Add(pType_code);
            }

            if (null != rbac_modulesParam.Is_open_window_code && "" != rbac_modulesParam.Is_open_window_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.IS_OPEN_WINDOW_CODE=:is_open_window_code ");
                OracleParameter pIs_open_window_code = new OracleParameter(":is_open_window_code", OracleDbType.NVarchar2);
                pIs_open_window_code.Value = rbac_modulesParam.Is_open_window_code;
                sqlparams.Add(pIs_open_window_code);
            }

            if (null != rbac_modulesParam.Sort)
            {
                this.isComma(sql);
                sql.Append(" SORT=:sort ");
                OracleParameter pSort = new OracleParameter(":sort", OracleDbType.Decimal);
                pSort.Value = rbac_modulesParam.Sort;
                sqlparams.Add(pSort);

            }

            if (null != rbac_modulesParam.Icon && "" != rbac_modulesParam.Icon)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.ICON=:icon ");
                OracleParameter pIcon = new OracleParameter(":icon", OracleDbType.NVarchar2);
                pIcon.Value = rbac_modulesParam.Icon;
                sqlparams.Add(pIcon);
            }

            if (null != rbac_modulesParam.Remark && "" != rbac_modulesParam.Remark)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.REMARK=:remark ");
                OracleParameter pRemark = new OracleParameter(":remark", OracleDbType.NVarchar2);
                pRemark.Value = rbac_modulesParam.Remark;
                sqlparams.Add(pRemark);
            }

            if (null != rbac_modulesParam.Zfbz && "" != rbac_modulesParam.Zfbz)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.ZFBZ=:zfbz ");
                OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                pZfbz.Value = rbac_modulesParam.Zfbz;
                sqlparams.Add(pZfbz);
            }

            if (rbac_modulesParamLike != null)
            {

                if (null != rbac_modulesParamLike.Pid && "" != rbac_modulesParamLike.Pid)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.PID LIKE '%'||:pid||'%' ");
                    OracleParameter pPid = new OracleParameter(":pid", OracleDbType.Varchar2);
                    pPid.Direction = ParameterDirection.Input;
                    pPid.Value = rbac_modulesParamLike.Pid;
                    sqlparams.Add(pPid);
                }

                if (null != rbac_modulesParamLike.Name && "" != rbac_modulesParamLike.Name)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.NAME LIKE '%'||:name||'%' ");
                    OracleParameter pName = new OracleParameter(":name", OracleDbType.NVarchar2);
                    pName.Direction = ParameterDirection.Input;
                    pName.Value = rbac_modulesParamLike.Name;
                    sqlparams.Add(pName);
                }

                if (null != rbac_modulesParamLike.Window_name && "" != rbac_modulesParamLike.Window_name)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.WINDOW_NAME LIKE '%'||:window_name||'%' ");
                    OracleParameter pWindow_name = new OracleParameter(":window_name", OracleDbType.NVarchar2);
                    pWindow_name.Direction = ParameterDirection.Input;
                    pWindow_name.Value = rbac_modulesParamLike.Window_name;
                    sqlparams.Add(pWindow_name);
                }

                if (null != rbac_modulesParamLike.Type_code && "" != rbac_modulesParamLike.Type_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.TYPE_CODE LIKE '%'||:type_code||'%' ");
                    OracleParameter pType_code = new OracleParameter(":type_code", OracleDbType.NVarchar2);
                    pType_code.Direction = ParameterDirection.Input;
                    pType_code.Value = rbac_modulesParamLike.Type_code;
                    sqlparams.Add(pType_code);
                }

                if (null != rbac_modulesParamLike.Is_open_window_code && "" != rbac_modulesParamLike.Is_open_window_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.IS_OPEN_WINDOW_CODE LIKE '%'||:is_open_window_code||'%' ");
                    OracleParameter pIs_open_window_code = new OracleParameter(":is_open_window_code", OracleDbType.NVarchar2);
                    pIs_open_window_code.Direction = ParameterDirection.Input;
                    pIs_open_window_code.Value = rbac_modulesParamLike.Is_open_window_code;
                    sqlparams.Add(pIs_open_window_code);
                }

                if (null != rbac_modulesParamLike.Icon && "" != rbac_modulesParamLike.Icon)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.ICON LIKE '%'||:icon||'%' ");
                    OracleParameter pIcon = new OracleParameter(":icon", OracleDbType.NVarchar2);
                    pIcon.Direction = ParameterDirection.Input;
                    pIcon.Value = rbac_modulesParamLike.Icon;
                    sqlparams.Add(pIcon);
                }

                if (null != rbac_modulesParamLike.Remark && "" != rbac_modulesParamLike.Remark)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.REMARK LIKE '%'||:remark||'%' ");
                    OracleParameter pRemark = new OracleParameter(":remark", OracleDbType.NVarchar2);
                    pRemark.Direction = ParameterDirection.Input;
                    pRemark.Value = rbac_modulesParamLike.Remark;
                    sqlparams.Add(pRemark);
                }

                if (null != rbac_modulesParamLike.Zfbz && "" != rbac_modulesParamLike.Zfbz)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.ZFBZ LIKE '%'||:zfbz||'%' ");
                    OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                    pZfbz.Direction = ParameterDirection.Input;
                    pZfbz.Value = rbac_modulesParamLike.Zfbz;
                    sqlparams.Add(pZfbz);
                }

            }

            if (rbac_modulesParamLike != null)
            {

            }

            this.b_isWhere = false;
            //排序
            this.addSort(sql, sortList);
            //*******分页start1*********如果分页对象为空，则全部数据查出，如果不为空
            List<object> returnList = new List<object>();//返回的List,索引0为List<Rbac_modules>对象,索引1为Model.Common.PageInfo分页信息对象
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
            //把每一行数据转换为一个对象放入List<Rbac_modules>中
            for (int i = 0; i < rows.Count; i++)
            {
                DataRow row = rows[i];
                rbac_modulesParamList.Add(this.dataSetContactObjectsToModel(row));
                //rbac_modulesParamList.Add(this.dataSetToModel(row));
            }

            //*******分页start2*********如果没有传入分页对象，则新建一个分页对象当做返回值
            if (null == page)
            {
                page = new Model.Common.PageInfo();
                page.AllCount = rows.Count;
            }
            returnList.Add(rbac_modulesParamList);//把List<Rbac_modules>放入List<object>中第一个
            returnList.Add(page);//把page对象放入List<object>中第二个
            //*******分页end2*********
            return returnList;
        }
        #endregion DAL层的implement,实现，end

        


        //*******************在此以后添加新的方法end



        public bool deleteCurrentAndChildNode(string id, OracleConnection con)
        {
            if ("" == id || null == id)
            {
                throw new Exception("ID不能为空，请赋值");
            }
            StringBuilder sql = new StringBuilder(@"delete from RBAC_MODULES where RBAC_MODULES.id in(  
    select RBAC_MODULES.id from RBAC_MODULES  
      start with   RBAC_MODULES.id=:id
      connect by prior RBAC_MODULES.id=pid )");
            OracleParameter pId = new OracleParameter(":id", OracleDbType.Varchar2);
            pId.Value = id;
            int flag = OracleHelper.ExecuteNonQuery(sql.ToString(), con, pId);
            return true;
        }



        public bool deleteCurrentAndChildNodeRoleRelation(string id, OracleConnection con)
        {
            if ("" == id || null == id)
            {
                throw new Exception("ID不能为空，请赋值");
            }
            StringBuilder sql = new StringBuilder(@"delete from RBAC_ROLE_MODULES where RBAC_ROLE_MODULES.FK_MODULES_ID in
(
select id from RBAC_MODULES where RBAC_MODULES.id in(  
    select RBAC_MODULES.id from RBAC_MODULES  
      start with   RBAC_MODULES.id=:id
      connect by prior RBAC_MODULES.id=pid )
      )");
            OracleParameter pId = new OracleParameter(":id", OracleDbType.Varchar2);
            pId.Value = id;
            int flag = OracleHelper.ExecuteNonQuery(sql.ToString(), con, pId);
            return true;
        }

        public List<object> getModulesByUserId(string userId, Rbac_modules rbac_modulesParam, PageInfo page)
        {
            //如果没有传查询条件参数，就new一个空的Rbac_modules对象，标示查询所有数据
            if (null == rbac_modulesParam)
            {
                rbac_modulesParam = new Rbac_modules();
            }
            List<Rbac_modules> rbac_modulesParamList = new List<Rbac_modules>();//接收查询出的Rbac_modules对象集合
            List<OracleParameter> sqlparams = new List<OracleParameter>();//保存参数的集合
            StringBuilder sql = new StringBuilder(@"
select distinct B.id as ID,B.pid as PID,B.name as NAME,B.window_name as WINDOW_NAME,B.type_code as TYPE_CODE,B.is_open_window_code as IS_OPEN_WINDOW_CODE,B.sort as SORT,B.ICON AS ICON,B.remark as REMARK,B.zfbz as ZFBZ,
P.ID AS P_ID,P.PID AS P_PID ,P.NAME as P_NAME,P.WINDOW_NAME as P_WINDOW_NAME,P.TYPE_CODE as P_TYPE_CODE,P.IS_OPEN_WINDOW_CODE as P_IS_OPEN_WINDOW_CODE,P.SORT as P_SORT,P.ICON AS P_ICON,P.REMARK as P_REMARK,P.ZFBZ as P_ZFBZ
 ");
            //新建方法findContactObjects(Rbac_modules rbac_modulesParam, Model.Common.PageInfo page)，在此加入多表连接要显示的项start
            //sql.Append(",B.字段一,B.字段二,B.字段三");

            //新建方法，在此加入多表连接要显示的项end
            sql.Append(" from RBAC_ROLE_MODULES A  ");
            //新建一个方法，在此加入多表连接的语句start
            ////sql.Append(" LEFT JOIN 表名 B ON A.外键=B.ID");
            sql.Append(@" 
left join RBAC_MODULES B
    on A.FK_MODULES_ID = B.ID
    left join RBAC_MODULES P
    on B.PID = P.ID");


            //新建一个方法，在此加入多表连接的语句end
            this.b_isWhere = true;
            sql.Append(@"
 where A.FK_ROLE_ID in
       (select t_role.id as roleid
          from rbac_role t_role
         where t_role.id in
               (select t.fk_role_id
                  from RBAC_USER_ROLE t
                 where t.fk_user_id = :userid)) 
");
            OracleParameter pUserId = new OracleParameter(":userid", OracleDbType.Varchar2);
            pUserId.Value = userId;
            sqlparams.Add(pUserId);
            if (null != rbac_modulesParam.Pid && "" != rbac_modulesParam.Pid)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" B.PID=:pid ");
                OracleParameter pPid = new OracleParameter(":pid", OracleDbType.Varchar2);
                pPid.Value = rbac_modulesParam.Pid;
                sqlparams.Add(pPid);
            }

            if (null != rbac_modulesParam.Name && "" != rbac_modulesParam.Name)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" B.NAME=:name ");
                OracleParameter pName = new OracleParameter(":name", OracleDbType.NVarchar2);
                pName.Value = rbac_modulesParam.Name;
                sqlparams.Add(pName);
            }

            if (null != rbac_modulesParam.Window_name && "" != rbac_modulesParam.Window_name)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" B.WINDOW_NAME=:window_name ");
                OracleParameter pWindow_name = new OracleParameter(":window_name", OracleDbType.NVarchar2);
                pWindow_name.Value = rbac_modulesParam.Window_name;
                sqlparams.Add(pWindow_name);
            }

            if (null != rbac_modulesParam.Type_code && "" != rbac_modulesParam.Type_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" B.TYPE_CODE=:type_code ");
                OracleParameter pType_code = new OracleParameter(":type_code", OracleDbType.NChar);
                pType_code.Value = rbac_modulesParam.Type_code;
                sqlparams.Add(pType_code);
            }

            if (null != rbac_modulesParam.Is_open_window_code && "" != rbac_modulesParam.Is_open_window_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" B.IS_OPEN_WINDOW_CODE=:is_open_window_code ");
                OracleParameter pIs_open_window_code = new OracleParameter(":is_open_window_code", OracleDbType.NChar);
                pIs_open_window_code.Value = rbac_modulesParam.Is_open_window_code;
                sqlparams.Add(pIs_open_window_code);
            }

            if (null != rbac_modulesParam.Sort)
            {
                this.isComma(sql);
                sql.Append(" B.SORT=:sort ");
                OracleParameter pSort = new OracleParameter(":sort", OracleDbType.Decimal);
                pSort.Value = rbac_modulesParam.Sort;
                sqlparams.Add(pSort);

            }
            if (null != rbac_modulesParam.Icon && "" != rbac_modulesParam.Icon)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.ICON=:icon ");
                OracleParameter pIcon = new OracleParameter(":icon", OracleDbType.NVarchar2);
                pIcon.Value = rbac_modulesParam.Icon;
                sqlparams.Add(pIcon);
            }
            if (null != rbac_modulesParam.Remark && "" != rbac_modulesParam.Remark)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" B.REMARK=:remark ");
                OracleParameter pRemark = new OracleParameter(":remark", OracleDbType.NVarchar2);
                pRemark.Value = rbac_modulesParam.Remark;
                sqlparams.Add(pRemark);
            }

            if (null != rbac_modulesParam.Zfbz && "" != rbac_modulesParam.Zfbz)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" B.ZFBZ=:zfbz ");
                OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NChar);
                pZfbz.Value = rbac_modulesParam.Zfbz;
                sqlparams.Add(pZfbz);
            }

            this.b_isWhere = false;
            sql.Append(" ORDER BY B.SORT,B.ID ");//ID排序
            //*******分页start1*********如果分页对象为空，则全部数据查出，如果不为空
            List<object> returnList = new List<object>();//返回的List,索引0为List<Rbac_modules>对象,索引1为Model.Common.PageInfo分页信息对象
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
            //把每一行数据转换为一个对象放入List<Rbac_modules>中
            for (int i = 0; i < rows.Count; i++)
            {
                DataRow row = rows[i];
                Rbac_modules tmp = new Rbac_modules();
                tmp.Id = Convert.ToString(row["ID"]).Trim();
                tmp.Pid = Convert.ToString(row["PID"]).Trim();
                tmp.Name = Convert.ToString(row["NAME"]).Trim();
                tmp.Window_name = Convert.ToString(row["WINDOW_NAME"]).Trim();
                tmp.Type_code = Convert.ToString(row["TYPE_CODE"]).Trim();
                tmp.Is_open_window_code = Convert.ToString(row["IS_OPEN_WINDOW_CODE"]).Trim();
                tmp.Sort = (decimal?)this.convertDBNullValue(row["SORT"]);
                tmp.Icon = Convert.ToString(row["ICON"]).Trim();
                tmp.Remark = Convert.ToString(row["REMARK"]).Trim();
                tmp.Zfbz = Convert.ToString(row["ZFBZ"]).Trim();

                Rbac_modules p_modules = new Rbac_modules();
                p_modules.Id = Convert.ToString(row["P_ID"]).Trim();
                p_modules.Pid = Convert.ToString(row["P_PID"]).Trim();
                p_modules.Name = Convert.ToString(row["P_NAME"]).Trim();
                p_modules.Window_name = Convert.ToString(row["P_WINDOW_NAME"]).Trim();
                p_modules.Type_code = Convert.ToString(row["P_TYPE_CODE"]).Trim();
                p_modules.Is_open_window_code = Convert.ToString(row["P_IS_OPEN_WINDOW_CODE"]).Trim();
                p_modules.Sort = (decimal?)this.convertDBNullValue(row["P_SORT"]);
                p_modules.Icon = Convert.ToString(row["P_ICON"]).Trim();
                p_modules.Remark = Convert.ToString(row["P_REMARK"]).Trim();
                p_modules.Zfbz = Convert.ToString(row["P_ZFBZ"]).Trim();
                tmp.P_modules = p_modules;
                rbac_modulesParamList.Add(tmp);
            }

            //*******分页start2*********如果没有传入分页对象，则新建一个分页对象当做返回值
            if (null == page)
            {
                page = new Model.Common.PageInfo();
                page.AllCount = rows.Count;
            }
            returnList.Add(rbac_modulesParamList);//把List<Rbac_modules>放入List<object>中第一个
            returnList.Add(page);//把page对象放入List<object>中第二个
            //*******分页end2*********
            return returnList;
        }

        
    }
}


