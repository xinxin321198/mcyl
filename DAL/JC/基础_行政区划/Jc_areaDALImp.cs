

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

namespace DAL.JC.基础_行政区划
{
    /// <summary>
    ///数据库访问层的Jc_area实现类
    ///此类由代码生成器生成
    ///表名：JC_AREA
    ///生成日期：2015-12-02 16:04:56
    /// 

    ///作者：罗新鑫
    ///联系电话：15087010221
    ///联系邮箱：362527240@qq.com
        
    /// </summary>
    public class Jc_areaDALImp :Base.BasDAL,Jc_areaDAL
    {

        /// <summary>
        /// 插入一条数据（如果需要供事务使用就传入OracleConnection对象，如果不供就传入null，方法自动生成OracleConnection对象）
        /// 主键为null时，自动生成主键guid，一般不直接调用此方法，请调用save方法进行单条数据的插入和修改       
        /// </summary>
        /// <param name="jc_areaParam">要插入的jc_areaParam对象</param>
        /// <param name="con">Oracle连接对象（为null时自动生成）</param>
        /// <returns>是否添加成功（影响的行数为1时成功）</returns>
        public bool insert(Jc_area jc_areaParam,OracleConnection con)
        {
            if (""==jc_areaParam.Id||null==jc_areaParam.Id)
            {
                jc_areaParam.Id = Model.Common.GUIDHelper.getGuid();
            }
            List<OracleParameter> sqlparams = new List<OracleParameter>();
            
            StringBuilder sql = new StringBuilder("INSERT INTO JC_AREA(id,name,code,pid,pcode,zfbz,level_code,type_code,remark) VALUES(:id,:name,:code,:pid,:pcode,:zfbz,:level_code,:type_code,:remark)");
            
            OracleParameter pId = new OracleParameter(":id", OracleDbType.Varchar2);
            pId.Direction = ParameterDirection.Input;
            pId.Value = jc_areaParam.Id;
            sqlparams.Add(pId);
            OracleParameter pName = new OracleParameter(":name", OracleDbType.NVarchar2);
            pName.Direction = ParameterDirection.Input;
            pName.Value = jc_areaParam.Name;
            sqlparams.Add(pName);
            OracleParameter pCode = new OracleParameter(":code", OracleDbType.Varchar2);
            pCode.Direction = ParameterDirection.Input;
            pCode.Value = jc_areaParam.Code;
            sqlparams.Add(pCode);
            OracleParameter pPid = new OracleParameter(":pid", OracleDbType.Varchar2);
            pPid.Direction = ParameterDirection.Input;
            pPid.Value = jc_areaParam.Pid;
            sqlparams.Add(pPid);
            OracleParameter pPcode = new OracleParameter(":pcode", OracleDbType.Varchar2);
            pPcode.Direction = ParameterDirection.Input;
            pPcode.Value = jc_areaParam.Pcode;
            sqlparams.Add(pPcode);
            OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
            pZfbz.Direction = ParameterDirection.Input;
            pZfbz.Value = jc_areaParam.Zfbz;
            sqlparams.Add(pZfbz);
            OracleParameter pLevel_code = new OracleParameter(":level_code", OracleDbType.NVarchar2);
            pLevel_code.Direction = ParameterDirection.Input;
            pLevel_code.Value = jc_areaParam.Level_code;
            sqlparams.Add(pLevel_code);
            OracleParameter pType_code = new OracleParameter(":type_code", OracleDbType.NVarchar2);
            pType_code.Direction = ParameterDirection.Input;
            pType_code.Value = jc_areaParam.Type_code;
            sqlparams.Add(pType_code);
            OracleParameter pRemark = new OracleParameter(":remark", OracleDbType.NVarchar2);
            pRemark.Direction = ParameterDirection.Input;
            pRemark.Value = jc_areaParam.Remark;
            sqlparams.Add(pRemark);
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
        /// <param name="jc_areaParamList">要插入的jc_areaParam对象的集合</param>
        /// <param name="con">Oracle连接对象（为null时自动生成）</param>
        /// <returns>是否添加成功（影响的行数等于保存的对象的数量时成功）</returns>
        public bool inertBatch(List<Jc_area> jc_areaParamList, OracleConnection con)
        {
            if (jc_areaParamList.Count == 0)
            {
                return true;
            }
            List<string> idList = new List<string>();

            List<string> nameList = new List<string>();

            List<string> codeList = new List<string>();

            List<string> pidList = new List<string>();

            List<string> pcodeList = new List<string>();

            List<string> zfbzList = new List<string>();

            List<string> level_codeList = new List<string>();

            List<string> type_codeList = new List<string>();

            List<string> remarkList = new List<string>();

            for (int i = 0; i < jc_areaParamList.Count; i++)
            {
                Jc_area jc_areaParam = jc_areaParamList[i];
                if ("" == jc_areaParam.Id || null == jc_areaParam.Id)
                {
                    jc_areaParam.Id = Model.Common.GUIDHelper.getGuid();
                }

            idList.Add(jc_areaParam.Id);

            nameList.Add(jc_areaParam.Name);

            codeList.Add(jc_areaParam.Code);

            pidList.Add(jc_areaParam.Pid);

            pcodeList.Add(jc_areaParam.Pcode);

            zfbzList.Add(jc_areaParam.Zfbz);

            level_codeList.Add(jc_areaParam.Level_code);

            type_codeList.Add(jc_areaParam.Type_code);

            remarkList.Add(jc_areaParam.Remark);

            }

            List<OracleParameter> sqlparams = new List<OracleParameter>();

            StringBuilder sql = new StringBuilder("INSERT INTO JC_AREA(id,name,code,pid,pcode,zfbz,level_code,type_code,remark) VALUES(:id,:name,:code,:pid,:pcode,:zfbz,:level_code,:type_code,:remark)");
            
            OracleParameter pId = new OracleParameter(":id", OracleDbType.Varchar2);
            pId.Direction = ParameterDirection.Input;
            pId.Value = idList.ToArray();
            sqlparams.Add(pId);
            OracleParameter pName = new OracleParameter(":name", OracleDbType.NVarchar2);
            pName.Direction = ParameterDirection.Input;
            pName.Value = nameList.ToArray();
            sqlparams.Add(pName);
            OracleParameter pCode = new OracleParameter(":code", OracleDbType.Varchar2);
            pCode.Direction = ParameterDirection.Input;
            pCode.Value = codeList.ToArray();
            sqlparams.Add(pCode);
            OracleParameter pPid = new OracleParameter(":pid", OracleDbType.Varchar2);
            pPid.Direction = ParameterDirection.Input;
            pPid.Value = pidList.ToArray();
            sqlparams.Add(pPid);
            OracleParameter pPcode = new OracleParameter(":pcode", OracleDbType.Varchar2);
            pPcode.Direction = ParameterDirection.Input;
            pPcode.Value = pcodeList.ToArray();
            sqlparams.Add(pPcode);
            OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
            pZfbz.Direction = ParameterDirection.Input;
            pZfbz.Value = zfbzList.ToArray();
            sqlparams.Add(pZfbz);
            OracleParameter pLevel_code = new OracleParameter(":level_code", OracleDbType.NVarchar2);
            pLevel_code.Direction = ParameterDirection.Input;
            pLevel_code.Value = level_codeList.ToArray();
            sqlparams.Add(pLevel_code);
            OracleParameter pType_code = new OracleParameter(":type_code", OracleDbType.NVarchar2);
            pType_code.Direction = ParameterDirection.Input;
            pType_code.Value = type_codeList.ToArray();
            sqlparams.Add(pType_code);
            OracleParameter pRemark = new OracleParameter(":remark", OracleDbType.NVarchar2);
            pRemark.Direction = ParameterDirection.Input;
            pRemark.Value = remarkList.ToArray();
            sqlparams.Add(pRemark);
            bool result = false;
            int flag = -1;
            flag = OracleHelper.ExecuteBatch(sql.ToString(), con, jc_areaParamList.Count, sqlparams.ToArray());
            if (jc_areaParamList.Count == flag)
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
            StringBuilder sql = new StringBuilder("DELETE JC_AREA WHERE ID=:id");
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
            StringBuilder sql = new StringBuilder("DELETE JC_AREA WHERE ID=:id");
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
        /// <param name="jc_areaParamCondition">删除的条件</param>
        /// <param name="con">Oracle连接对象（为null时自动生成）</param>
        /// <returns>无法确定删除的行数（影响行数大于等于0就算成功）</returns>
        public bool deleteByOtherCondition(Jc_area jc_areaParamCondition, OracleConnection con)
        {
            if (null!=jc_areaParamCondition.Id&&""!=jc_areaParamCondition.Id)
            {
                throw new Exception("不允许指定参数的ID，如果要根据ID删除数据请调用deleteById或者deleteByIdBatch方法；错误出自：deleteByOtherCondition");
            }
            List<OracleParameter> sqlparams = new List<OracleParameter>();
            StringBuilder sql = new StringBuilder("DELETE JC_AREA ");

            if (null != jc_areaParamCondition.Name &&  ""!= jc_areaParamCondition.Name)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" NAME=:name ");
                OracleParameter pName = new OracleParameter(":name", OracleDbType.NVarchar2);
                pName.Direction = ParameterDirection.Input;
                pName.Value = jc_areaParamCondition.Name;
                sqlparams.Add(pName);

            }
                        
            if (null != jc_areaParamCondition.Code &&  ""!= jc_areaParamCondition.Code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" CODE=:code ");
                OracleParameter pCode = new OracleParameter(":code", OracleDbType.Varchar2);
                pCode.Direction = ParameterDirection.Input;
                pCode.Value = jc_areaParamCondition.Code;
                sqlparams.Add(pCode);

            }
                        
            if (null != jc_areaParamCondition.Pid &&  ""!= jc_areaParamCondition.Pid)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" PID=:pid ");
                OracleParameter pPid = new OracleParameter(":pid", OracleDbType.Varchar2);
                pPid.Direction = ParameterDirection.Input;
                pPid.Value = jc_areaParamCondition.Pid;
                sqlparams.Add(pPid);

            }
                        
            if (null != jc_areaParamCondition.Pcode &&  ""!= jc_areaParamCondition.Pcode)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" PCODE=:pcode ");
                OracleParameter pPcode = new OracleParameter(":pcode", OracleDbType.Varchar2);
                pPcode.Direction = ParameterDirection.Input;
                pPcode.Value = jc_areaParamCondition.Pcode;
                sqlparams.Add(pPcode);

            }
                        
            if (null != jc_areaParamCondition.Zfbz &&  ""!= jc_areaParamCondition.Zfbz)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" ZFBZ=:zfbz ");
                OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                pZfbz.Direction = ParameterDirection.Input;
                pZfbz.Value = jc_areaParamCondition.Zfbz;
                sqlparams.Add(pZfbz);

            }
                        
            if (null != jc_areaParamCondition.Level_code &&  ""!= jc_areaParamCondition.Level_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" LEVEL_CODE=:level_code ");
                OracleParameter pLevel_code = new OracleParameter(":level_code", OracleDbType.NVarchar2);
                pLevel_code.Direction = ParameterDirection.Input;
                pLevel_code.Value = jc_areaParamCondition.Level_code;
                sqlparams.Add(pLevel_code);

            }
                        
            if (null != jc_areaParamCondition.Type_code &&  ""!= jc_areaParamCondition.Type_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" TYPE_CODE=:type_code ");
                OracleParameter pType_code = new OracleParameter(":type_code", OracleDbType.NVarchar2);
                pType_code.Direction = ParameterDirection.Input;
                pType_code.Value = jc_areaParamCondition.Type_code;
                sqlparams.Add(pType_code);

            }
                        
            if (null != jc_areaParamCondition.Remark &&  ""!= jc_areaParamCondition.Remark)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" REMARK=:remark ");
                OracleParameter pRemark = new OracleParameter(":remark", OracleDbType.NVarchar2);
                pRemark.Direction = ParameterDirection.Input;
                pRemark.Value = jc_areaParamCondition.Remark;
                sqlparams.Add(pRemark);

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
        /// <param name="jc_areaParam"></param>
        /// <returns>影响的行数</returns>
        public bool updateById(Jc_area jc_areaParam,OracleConnection con)
        {
            if ("" == jc_areaParam.Id || null == jc_areaParam.Id)
            {
                throw new Exception("ID不允许为空，请赋值后调用；错误出自：updateById");
            }
            List<OracleParameter> sqlparams = new List<OracleParameter>();

            StringBuilder sql = new StringBuilder("UPDATE JC_AREA SET ");
            if (null != jc_areaParam.Name &&  ""!= jc_areaParam.Name)
            {
                this.isComma(sql);
                sql.Append(" NAME=:name ");
                OracleParameter pName = new OracleParameter(":name", OracleDbType.NVarchar2);
                pName.Direction = ParameterDirection.Input;
                pName.Value = jc_areaParam.Name;
                sqlparams.Add(pName);

            }
                        
            if (null != jc_areaParam.Code &&  ""!= jc_areaParam.Code)
            {
                this.isComma(sql);
                sql.Append(" CODE=:code ");
                OracleParameter pCode = new OracleParameter(":code", OracleDbType.Varchar2);
                pCode.Direction = ParameterDirection.Input;
                pCode.Value = jc_areaParam.Code;
                sqlparams.Add(pCode);

            }
                        
            if (null != jc_areaParam.Pid &&  ""!= jc_areaParam.Pid)
            {
                this.isComma(sql);
                sql.Append(" PID=:pid ");
                OracleParameter pPid = new OracleParameter(":pid", OracleDbType.Varchar2);
                pPid.Direction = ParameterDirection.Input;
                pPid.Value = jc_areaParam.Pid;
                sqlparams.Add(pPid);

            }
                        
            if (null != jc_areaParam.Pcode &&  ""!= jc_areaParam.Pcode)
            {
                this.isComma(sql);
                sql.Append(" PCODE=:pcode ");
                OracleParameter pPcode = new OracleParameter(":pcode", OracleDbType.Varchar2);
                pPcode.Direction = ParameterDirection.Input;
                pPcode.Value = jc_areaParam.Pcode;
                sqlparams.Add(pPcode);

            }
                        
            if (null != jc_areaParam.Zfbz &&  ""!= jc_areaParam.Zfbz)
            {
                this.isComma(sql);
                sql.Append(" ZFBZ=:zfbz ");
                OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                pZfbz.Direction = ParameterDirection.Input;
                pZfbz.Value = jc_areaParam.Zfbz;
                sqlparams.Add(pZfbz);

            }
                        
            if (null != jc_areaParam.Level_code &&  ""!= jc_areaParam.Level_code)
            {
                this.isComma(sql);
                sql.Append(" LEVEL_CODE=:level_code ");
                OracleParameter pLevel_code = new OracleParameter(":level_code", OracleDbType.NVarchar2);
                pLevel_code.Direction = ParameterDirection.Input;
                pLevel_code.Value = jc_areaParam.Level_code;
                sqlparams.Add(pLevel_code);

            }
                        
            if (null != jc_areaParam.Type_code &&  ""!= jc_areaParam.Type_code)
            {
                this.isComma(sql);
                sql.Append(" TYPE_CODE=:type_code ");
                OracleParameter pType_code = new OracleParameter(":type_code", OracleDbType.NVarchar2);
                pType_code.Direction = ParameterDirection.Input;
                pType_code.Value = jc_areaParam.Type_code;
                sqlparams.Add(pType_code);

            }
                        
            if (null != jc_areaParam.Remark &&  ""!= jc_areaParam.Remark)
            {
                this.isComma(sql);
                sql.Append(" REMARK=:remark ");
                OracleParameter pRemark = new OracleParameter(":remark", OracleDbType.NVarchar2);
                pRemark.Direction = ParameterDirection.Input;
                pRemark.Value = jc_areaParam.Remark;
                sqlparams.Add(pRemark);

            }
                        
            sql.Append(" WHERE ID=:id ");
            OracleParameter pId = new OracleParameter(":id", OracleDbType.Varchar2);
            pId.Value = jc_areaParam.Id;
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
        /// <param name="jc_areaParamList">要修改的Jc_area对象集合</param>
        /// <param name="con">Oracle连接对象（为null时自动生成）</param>
        /// <returns>是否删除成功（影响的行数等于要修改的对象数量时成功）</returns>
        public bool updateByIdBatch(List<Jc_area> jc_areaParamList, OracleConnection con)
        {


            List<string> idList = new List<string>();

            List<string> nameList = new List<string>();

            List<string> codeList = new List<string>();

            List<string> pidList = new List<string>();

            List<string> pcodeList = new List<string>();

            List<string> zfbzList = new List<string>();

            List<string> level_codeList = new List<string>();

            List<string> type_codeList = new List<string>();

            List<string> remarkList = new List<string>();

            for (int i = 0; i < jc_areaParamList.Count; i++)
            {
                Jc_area jc_areaParam = jc_areaParamList[i];
                if ("" == jc_areaParam.Id || null == jc_areaParam.Id)
                {
                    throw new Exception("下标为" + i + "的数据，ID不能为空，请赋值后调用；错误出自：updateByIdBatch");
                }

            idList.Add(jc_areaParam.Id);

            nameList.Add(jc_areaParam.Name);

            codeList.Add(jc_areaParam.Code);

            pidList.Add(jc_areaParam.Pid);

            pcodeList.Add(jc_areaParam.Pcode);

            zfbzList.Add(jc_areaParam.Zfbz);

            level_codeList.Add(jc_areaParam.Level_code);

            type_codeList.Add(jc_areaParam.Type_code);

            remarkList.Add(jc_areaParam.Remark);

            }


            
            List<OracleParameter> sqlparams = new List<OracleParameter>();

            StringBuilder sql = new StringBuilder("UPDATE JC_AREA SET ");
            this.isComma(sql);
            sql.Append(" NAME=:name ");
            OracleParameter pName = new OracleParameter(":name", OracleDbType.NVarchar2);
            pName.Direction = ParameterDirection.Input;
            pName.Value = nameList.ToArray();
            sqlparams.Add(pName);

            this.isComma(sql);
            sql.Append(" CODE=:code ");
            OracleParameter pCode = new OracleParameter(":code", OracleDbType.Varchar2);
            pCode.Direction = ParameterDirection.Input;
            pCode.Value = codeList.ToArray();
            sqlparams.Add(pCode);

            this.isComma(sql);
            sql.Append(" PID=:pid ");
            OracleParameter pPid = new OracleParameter(":pid", OracleDbType.Varchar2);
            pPid.Direction = ParameterDirection.Input;
            pPid.Value = pidList.ToArray();
            sqlparams.Add(pPid);

            this.isComma(sql);
            sql.Append(" PCODE=:pcode ");
            OracleParameter pPcode = new OracleParameter(":pcode", OracleDbType.Varchar2);
            pPcode.Direction = ParameterDirection.Input;
            pPcode.Value = pcodeList.ToArray();
            sqlparams.Add(pPcode);

            this.isComma(sql);
            sql.Append(" ZFBZ=:zfbz ");
            OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
            pZfbz.Direction = ParameterDirection.Input;
            pZfbz.Value = zfbzList.ToArray();
            sqlparams.Add(pZfbz);

            this.isComma(sql);
            sql.Append(" LEVEL_CODE=:level_code ");
            OracleParameter pLevel_code = new OracleParameter(":level_code", OracleDbType.NVarchar2);
            pLevel_code.Direction = ParameterDirection.Input;
            pLevel_code.Value = level_codeList.ToArray();
            sqlparams.Add(pLevel_code);

            this.isComma(sql);
            sql.Append(" TYPE_CODE=:type_code ");
            OracleParameter pType_code = new OracleParameter(":type_code", OracleDbType.NVarchar2);
            pType_code.Direction = ParameterDirection.Input;
            pType_code.Value = type_codeList.ToArray();
            sqlparams.Add(pType_code);

            this.isComma(sql);
            sql.Append(" REMARK=:remark ");
            OracleParameter pRemark = new OracleParameter(":remark", OracleDbType.NVarchar2);
            pRemark.Direction = ParameterDirection.Input;
            pRemark.Value = remarkList.ToArray();
            sqlparams.Add(pRemark);

            sql.Append(" WHERE ID=:id ");
            OracleParameter pId = new OracleParameter(":id", OracleDbType.Varchar2);
            pId.Value = idList.ToArray();
            sqlparams.Add(pId);
            bool result = false;
            int flag = OracleHelper.ExecuteBatch(sql.ToString(), con,jc_areaParamList.Count, sqlparams.ToArray());
            if (jc_areaParamList.Count == flag)
            {
                result = true;
            }
            return result;
        }

        /// <summary>
        /// 根据更新的条件，更新数据（如果需要供事务使用就传入OracleConnection对象，如果不供就传入null，方法自动生成OracleConnection对象）
        /// 不指定ID，如果要根据ID来更新数据，请使用updateForId方法
        /// </summary>
        /// <param name="jc_areaParamCondition">条件对象</param>
        /// <param name="jc_areaParamUpdate">要更新的数据对象</param>
        /// <param name="con">Oracle连接对象（为null时自动生成）</param>
        /// <returns>影响的行数不确定（不为-1就正确）</returns>
        public bool updateByOtherCondition(Jc_area jc_areaParamCondition, Jc_area jc_areaParamUpdate, OracleConnection con)
        {
            if ((null!=jc_areaParamCondition.Id&&"!=jc_areaParamCondition.Id)||(null!=jc_areaParamUpdate.Id&&"!=jc_areaParamUpdate.Id))
            {
                throw new Exception("此方法不允许指定参数的ID，数据库中的ID不允许修改，如需根据ID修改数据，请调用updateById或updateByIdBatch方法；错误出自：updateByOtherCondition");
            }
            List<OracleParameter> sqlparams = new List<OracleParameter>();
            //添加要修改的值
            StringBuilder sql = new StringBuilder("UPDATE JC_AREA SET ");
            if (null != jc_areaParamUpdate.Name &&  ""!= jc_areaParamUpdate.Name)
            {
                this.isComma(sql);
                sql.Append(" NAME=:name ");
                OracleParameter pName = new OracleParameter(":name", OracleDbType.NVarchar2);
                pName.Direction = ParameterDirection.Input;
                pName.Value = jc_areaParamUpdate.Name;
                sqlparams.Add(pName);

            }
                        
            if (null != jc_areaParamUpdate.Code &&  ""!= jc_areaParamUpdate.Code)
            {
                this.isComma(sql);
                sql.Append(" CODE=:code ");
                OracleParameter pCode = new OracleParameter(":code", OracleDbType.Varchar2);
                pCode.Direction = ParameterDirection.Input;
                pCode.Value = jc_areaParamUpdate.Code;
                sqlparams.Add(pCode);

            }
                        
            if (null != jc_areaParamUpdate.Pid &&  ""!= jc_areaParamUpdate.Pid)
            {
                this.isComma(sql);
                sql.Append(" PID=:pid ");
                OracleParameter pPid = new OracleParameter(":pid", OracleDbType.Varchar2);
                pPid.Direction = ParameterDirection.Input;
                pPid.Value = jc_areaParamUpdate.Pid;
                sqlparams.Add(pPid);

            }
                        
            if (null != jc_areaParamUpdate.Pcode &&  ""!= jc_areaParamUpdate.Pcode)
            {
                this.isComma(sql);
                sql.Append(" PCODE=:pcode ");
                OracleParameter pPcode = new OracleParameter(":pcode", OracleDbType.Varchar2);
                pPcode.Direction = ParameterDirection.Input;
                pPcode.Value = jc_areaParamUpdate.Pcode;
                sqlparams.Add(pPcode);

            }
                        
            if (null != jc_areaParamUpdate.Zfbz &&  ""!= jc_areaParamUpdate.Zfbz)
            {
                this.isComma(sql);
                sql.Append(" ZFBZ=:zfbz ");
                OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                pZfbz.Direction = ParameterDirection.Input;
                pZfbz.Value = jc_areaParamUpdate.Zfbz;
                sqlparams.Add(pZfbz);

            }
                        
            if (null != jc_areaParamUpdate.Level_code &&  ""!= jc_areaParamUpdate.Level_code)
            {
                this.isComma(sql);
                sql.Append(" LEVEL_CODE=:level_code ");
                OracleParameter pLevel_code = new OracleParameter(":level_code", OracleDbType.NVarchar2);
                pLevel_code.Direction = ParameterDirection.Input;
                pLevel_code.Value = jc_areaParamUpdate.Level_code;
                sqlparams.Add(pLevel_code);

            }
                        
            if (null != jc_areaParamUpdate.Type_code &&  ""!= jc_areaParamUpdate.Type_code)
            {
                this.isComma(sql);
                sql.Append(" TYPE_CODE=:type_code ");
                OracleParameter pType_code = new OracleParameter(":type_code", OracleDbType.NVarchar2);
                pType_code.Direction = ParameterDirection.Input;
                pType_code.Value = jc_areaParamUpdate.Type_code;
                sqlparams.Add(pType_code);

            }
                        
            if (null != jc_areaParamUpdate.Remark &&  ""!= jc_areaParamUpdate.Remark)
            {
                this.isComma(sql);
                sql.Append(" REMARK=:remark ");
                OracleParameter pRemark = new OracleParameter(":remark", OracleDbType.NVarchar2);
                pRemark.Direction = ParameterDirection.Input;
                pRemark.Value = jc_areaParamUpdate.Remark;
                sqlparams.Add(pRemark);

            }
                        
            //添加条件的参数
            
            if (null != jc_areaParamCondition.Name &&  ""!= jc_areaParamCondition.Name)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" NAME=:name ");
                OracleParameter pName = new OracleParameter(":name", OracleDbType.NVarchar2);
                pName.Direction = ParameterDirection.Input;
                pName.Value = jc_areaParamCondition.Name;
                sqlparams.Add(pName);

            }
                        
            if (null != jc_areaParamCondition.Code &&  ""!= jc_areaParamCondition.Code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" CODE=:code ");
                OracleParameter pCode = new OracleParameter(":code", OracleDbType.Varchar2);
                pCode.Direction = ParameterDirection.Input;
                pCode.Value = jc_areaParamCondition.Code;
                sqlparams.Add(pCode);

            }
                        
            if (null != jc_areaParamCondition.Pid &&  ""!= jc_areaParamCondition.Pid)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" PID=:pid ");
                OracleParameter pPid = new OracleParameter(":pid", OracleDbType.Varchar2);
                pPid.Direction = ParameterDirection.Input;
                pPid.Value = jc_areaParamCondition.Pid;
                sqlparams.Add(pPid);

            }
                        
            if (null != jc_areaParamCondition.Pcode &&  ""!= jc_areaParamCondition.Pcode)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" PCODE=:pcode ");
                OracleParameter pPcode = new OracleParameter(":pcode", OracleDbType.Varchar2);
                pPcode.Direction = ParameterDirection.Input;
                pPcode.Value = jc_areaParamCondition.Pcode;
                sqlparams.Add(pPcode);

            }
                        
            if (null != jc_areaParamCondition.Zfbz &&  ""!= jc_areaParamCondition.Zfbz)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" ZFBZ=:zfbz ");
                OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                pZfbz.Direction = ParameterDirection.Input;
                pZfbz.Value = jc_areaParamCondition.Zfbz;
                sqlparams.Add(pZfbz);

            }
                        
            if (null != jc_areaParamCondition.Level_code &&  ""!= jc_areaParamCondition.Level_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" LEVEL_CODE=:level_code ");
                OracleParameter pLevel_code = new OracleParameter(":level_code", OracleDbType.NVarchar2);
                pLevel_code.Direction = ParameterDirection.Input;
                pLevel_code.Value = jc_areaParamCondition.Level_code;
                sqlparams.Add(pLevel_code);

            }
                        
            if (null != jc_areaParamCondition.Type_code &&  ""!= jc_areaParamCondition.Type_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" TYPE_CODE=:type_code ");
                OracleParameter pType_code = new OracleParameter(":type_code", OracleDbType.NVarchar2);
                pType_code.Direction = ParameterDirection.Input;
                pType_code.Value = jc_areaParamCondition.Type_code;
                sqlparams.Add(pType_code);

            }
                        
            if (null != jc_areaParamCondition.Remark &&  ""!= jc_areaParamCondition.Remark)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" REMARK=:remark ");
                OracleParameter pRemark = new OracleParameter(":remark", OracleDbType.NVarchar2);
                pRemark.Direction = ParameterDirection.Input;
                pRemark.Value = jc_areaParamCondition.Remark;
                sqlparams.Add(pRemark);

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
        /// <returns>Jc_area</returns>
        public Jc_area findById(string id)
        {
            if (""==id||null==id)
            {
                throw new Exception("ID不能为空，请赋值后调用；错误出自：findById");
            }
            StringBuilder sql = new StringBuilder("SELECT A.* ");
            //新建方法findContactObjectsById，在此加入多表连接要显示的项start
            //sql.Append(",B.字段一,B.字段二,B.字段三");
            //新建方法，在此加入多表连接要显示的项end
            sql.Append(" FROM JC_AREA A ");
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
        /// <param name="jc_areaParam"></param>
        /// <param name="page">分页对象</param>
        ///<param name="jc_areaParamLike">模糊查询参数</param>
        ///<param name="sortList">排序参数对象的集合</param>
        /// <returns>满足条件的所有Jc_area对象集合list</returns>
        public List<object> find(Jc_area jc_areaParam, Model.Common.PageInfo page,Jc_area jc_areaParamLike,List<SortInfo> sortList)
        {

            //如果没有传查询条件参数，就new一个空的Jc_area对象，标示查询所有数据
            if (null == jc_areaParam)
            {
                jc_areaParam = new Jc_area();
            }
            if (null!=jc_areaParam.Id&&""!=jc_areaParam.Id)
            {
                throw new Exception("此方法不允许指定参数ID，如果需要根据ID查询数据，请调用findById方法；错误出自：find");
            }
            List<Jc_area> jc_areaParamList = new List<Jc_area>();//接收查询出的Jc_area对象集合
            List<OracleParameter> sqlparams = new List<OracleParameter>();//保存参数的集合
            StringBuilder sql = new StringBuilder("SELECT A.* ");
            //新建方法findContactObjects(Jc_area jc_areaParam, Model.Common.PageInfo page)，在此加入多表连接要显示的项start
            //sql.Append(",B.字段一,B.字段二,B.字段三");
            //新建方法，在此加入多表连接要显示的项end
            sql.Append(" FROM JC_AREA A ");
            //新建一个方法，在此加入多表连接的语句start
            ////sql.Append(" LEFT JOIN 表名 B ON A.外键=B.ID");
            //新建一个方法，在此加入多表连接的语句end
            
            
            if (null != jc_areaParam.Name && "" != jc_areaParam.Name)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.NAME=:name ");
                OracleParameter pName = new OracleParameter(":name", OracleDbType.NVarchar2);
                pName.Direction = ParameterDirection.Input;
                pName.Value = jc_areaParam.Name;
                sqlparams.Add(pName);
            }
                
            if (null != jc_areaParam.Code && "" != jc_areaParam.Code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.CODE=:code ");
                OracleParameter pCode = new OracleParameter(":code", OracleDbType.Varchar2);
                pCode.Direction = ParameterDirection.Input;
                pCode.Value = jc_areaParam.Code;
                sqlparams.Add(pCode);
            }
                
            if (null != jc_areaParam.Pid && "" != jc_areaParam.Pid)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.PID=:pid ");
                OracleParameter pPid = new OracleParameter(":pid", OracleDbType.Varchar2);
                pPid.Direction = ParameterDirection.Input;
                pPid.Value = jc_areaParam.Pid;
                sqlparams.Add(pPid);
            }
                
            if (null != jc_areaParam.Pcode && "" != jc_areaParam.Pcode)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.PCODE=:pcode ");
                OracleParameter pPcode = new OracleParameter(":pcode", OracleDbType.Varchar2);
                pPcode.Direction = ParameterDirection.Input;
                pPcode.Value = jc_areaParam.Pcode;
                sqlparams.Add(pPcode);
            }
                
            if (null != jc_areaParam.Zfbz && "" != jc_areaParam.Zfbz)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.ZFBZ=:zfbz ");
                OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                pZfbz.Direction = ParameterDirection.Input;
                pZfbz.Value = jc_areaParam.Zfbz;
                sqlparams.Add(pZfbz);
            }
                
            if (null != jc_areaParam.Level_code && "" != jc_areaParam.Level_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.LEVEL_CODE=:level_code ");
                OracleParameter pLevel_code = new OracleParameter(":level_code", OracleDbType.NVarchar2);
                pLevel_code.Direction = ParameterDirection.Input;
                pLevel_code.Value = jc_areaParam.Level_code;
                sqlparams.Add(pLevel_code);
            }
                
            if (null != jc_areaParam.Type_code && "" != jc_areaParam.Type_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.TYPE_CODE=:type_code ");
                OracleParameter pType_code = new OracleParameter(":type_code", OracleDbType.NVarchar2);
                pType_code.Direction = ParameterDirection.Input;
                pType_code.Value = jc_areaParam.Type_code;
                sqlparams.Add(pType_code);
            }
                
            if (null != jc_areaParam.Remark && "" != jc_areaParam.Remark)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.REMARK=:remark ");
                OracleParameter pRemark = new OracleParameter(":remark", OracleDbType.NVarchar2);
                pRemark.Direction = ParameterDirection.Input;
                pRemark.Value = jc_areaParam.Remark;
                sqlparams.Add(pRemark);
            }
                
            if(jc_areaParamLike!=null)
            {

                if (null != jc_areaParamLike.Name && "" != jc_areaParamLike.Name)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.NAME LIKE '%'||:name||'%' ");
                    OracleParameter pName = new OracleParameter(":name", OracleDbType.NVarchar2);
                    pName.Direction = ParameterDirection.Input;
                    pName.Value = jc_areaParamLike.Name;
                    sqlparams.Add(pName);
                }
                
                if (null != jc_areaParamLike.Code && "" != jc_areaParamLike.Code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.CODE LIKE '%'||:code||'%' ");
                    OracleParameter pCode = new OracleParameter(":code", OracleDbType.Varchar2);
                    pCode.Direction = ParameterDirection.Input;
                    pCode.Value = jc_areaParamLike.Code;
                    sqlparams.Add(pCode);
                }
                
                if (null != jc_areaParamLike.Pid && "" != jc_areaParamLike.Pid)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.PID LIKE '%'||:pid||'%' ");
                    OracleParameter pPid = new OracleParameter(":pid", OracleDbType.Varchar2);
                    pPid.Direction = ParameterDirection.Input;
                    pPid.Value = jc_areaParamLike.Pid;
                    sqlparams.Add(pPid);
                }
                
                if (null != jc_areaParamLike.Pcode && "" != jc_areaParamLike.Pcode)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.PCODE LIKE '%'||:pcode||'%' ");
                    OracleParameter pPcode = new OracleParameter(":pcode", OracleDbType.Varchar2);
                    pPcode.Direction = ParameterDirection.Input;
                    pPcode.Value = jc_areaParamLike.Pcode;
                    sqlparams.Add(pPcode);
                }
                
                if (null != jc_areaParamLike.Zfbz && "" != jc_areaParamLike.Zfbz)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.ZFBZ LIKE '%'||:zfbz||'%' ");
                    OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                    pZfbz.Direction = ParameterDirection.Input;
                    pZfbz.Value = jc_areaParamLike.Zfbz;
                    sqlparams.Add(pZfbz);
                }
                
                if (null != jc_areaParamLike.Level_code && "" != jc_areaParamLike.Level_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.LEVEL_CODE LIKE '%'||:level_code||'%' ");
                    OracleParameter pLevel_code = new OracleParameter(":level_code", OracleDbType.NVarchar2);
                    pLevel_code.Direction = ParameterDirection.Input;
                    pLevel_code.Value = jc_areaParamLike.Level_code;
                    sqlparams.Add(pLevel_code);
                }
                
                if (null != jc_areaParamLike.Type_code && "" != jc_areaParamLike.Type_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.TYPE_CODE LIKE '%'||:type_code||'%' ");
                    OracleParameter pType_code = new OracleParameter(":type_code", OracleDbType.NVarchar2);
                    pType_code.Direction = ParameterDirection.Input;
                    pType_code.Value = jc_areaParamLike.Type_code;
                    sqlparams.Add(pType_code);
                }
                
                if (null != jc_areaParamLike.Remark && "" != jc_areaParamLike.Remark)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.REMARK LIKE '%'||:remark||'%' ");
                    OracleParameter pRemark = new OracleParameter(":remark", OracleDbType.NVarchar2);
                    pRemark.Direction = ParameterDirection.Input;
                    pRemark.Value = jc_areaParamLike.Remark;
                    sqlparams.Add(pRemark);
                }
                
            }

            this.b_isWhere = false;
            this.addSort(sql, sortList);//排序
            //*******分页start1*********如果分页对象为空，则全部数据查出，如果不为空
            List<object> returnList = new List<object>();//返回的List,索引0为List<Jc_area>对象,索引1为Model.Common.PageInfo分页信息对象
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
            //把每一行数据转换为一个对象放入List<Jc_area>中
            for (int i = 0; i < rows.Count; i++)
            {
                DataRow row = rows[i];
                //jc_areaParamList.Add(this.dataSetContactObjectsToModel(row));
                jc_areaParamList.Add(this.dataSetToModel(row));
            }
            
             //*******分页start2*********如果没有传入分页对象，则新建一个分页对象当做返回值
            if (null == page)
            {
                page = new Model.Common.PageInfo();
                page.AllCount = rows.Count;
            }
            returnList.Add(jc_areaParamList);//把List<Jc_area>放入List<object>中第一个
            returnList.Add(page);//把page对象放入List<object>中第二个
            //*******分页end2*********
            return returnList;
        }

        
        
        /// <summary>
        /// 根据条件得到集合的数量
        /// 第二个条件是模糊查询的条件
        /// </summary>
        /// <returns>int</returns>
        public int getCount(Jc_area jc_areaParam,Jc_area jc_areaParamLike)
        {
            //如果没有传查询条件参数，就new一个空的Jc_area对象，标示查询所有数据
            if (null == jc_areaParam)
            {
                jc_areaParam = new Jc_area();
            }
            List<OracleParameter> sqlparams = new List<OracleParameter>();//保存参数的集合
            StringBuilder sql = new StringBuilder("SELECT COUNT(ID) FROM JC_AREA A");
                if (null != jc_areaParam.Name && "" != jc_areaParam.Name)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.NAME=:name ");
                    OracleParameter pName = new OracleParameter(":name", OracleDbType.NVarchar2);
                pName.Value = jc_areaParam.Name;
                sqlparams.Add(pName);
                }
                
                if (null != jc_areaParam.Code && "" != jc_areaParam.Code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.CODE=:code ");
                    OracleParameter pCode = new OracleParameter(":code", OracleDbType.Varchar2);
                pCode.Value = jc_areaParam.Code;
                sqlparams.Add(pCode);
                }
                
                if (null != jc_areaParam.Pid && "" != jc_areaParam.Pid)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.PID=:pid ");
                    OracleParameter pPid = new OracleParameter(":pid", OracleDbType.Varchar2);
                pPid.Value = jc_areaParam.Pid;
                sqlparams.Add(pPid);
                }
                
                if (null != jc_areaParam.Pcode && "" != jc_areaParam.Pcode)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.PCODE=:pcode ");
                    OracleParameter pPcode = new OracleParameter(":pcode", OracleDbType.Varchar2);
                pPcode.Value = jc_areaParam.Pcode;
                sqlparams.Add(pPcode);
                }
                
                if (null != jc_areaParam.Zfbz && "" != jc_areaParam.Zfbz)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.ZFBZ=:zfbz ");
                    OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                pZfbz.Value = jc_areaParam.Zfbz;
                sqlparams.Add(pZfbz);
                }
                
                if (null != jc_areaParam.Level_code && "" != jc_areaParam.Level_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.LEVEL_CODE=:level_code ");
                    OracleParameter pLevel_code = new OracleParameter(":level_code", OracleDbType.NVarchar2);
                pLevel_code.Value = jc_areaParam.Level_code;
                sqlparams.Add(pLevel_code);
                }
                
                if (null != jc_areaParam.Type_code && "" != jc_areaParam.Type_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.TYPE_CODE=:type_code ");
                    OracleParameter pType_code = new OracleParameter(":type_code", OracleDbType.NVarchar2);
                pType_code.Value = jc_areaParam.Type_code;
                sqlparams.Add(pType_code);
                }
                
                if (null != jc_areaParam.Remark && "" != jc_areaParam.Remark)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.REMARK=:remark ");
                    OracleParameter pRemark = new OracleParameter(":remark", OracleDbType.NVarchar2);
                pRemark.Value = jc_areaParam.Remark;
                sqlparams.Add(pRemark);
                }
                
            if(jc_areaParamLike!=null)
            {

                if (null != jc_areaParamLike.Name && "" != jc_areaParamLike.Name)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.NAME LIKE '%'||:name||'%' ");
                    OracleParameter pName = new OracleParameter(":name", OracleDbType.NVarchar2);
                    pName.Direction = ParameterDirection.Input;
                    pName.Value = jc_areaParamLike.Name;
                    sqlparams.Add(pName);
                }
                
                if (null != jc_areaParamLike.Code && "" != jc_areaParamLike.Code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.CODE LIKE '%'||:code||'%' ");
                    OracleParameter pCode = new OracleParameter(":code", OracleDbType.Varchar2);
                    pCode.Direction = ParameterDirection.Input;
                    pCode.Value = jc_areaParamLike.Code;
                    sqlparams.Add(pCode);
                }
                
                if (null != jc_areaParamLike.Pid && "" != jc_areaParamLike.Pid)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.PID LIKE '%'||:pid||'%' ");
                    OracleParameter pPid = new OracleParameter(":pid", OracleDbType.Varchar2);
                    pPid.Direction = ParameterDirection.Input;
                    pPid.Value = jc_areaParamLike.Pid;
                    sqlparams.Add(pPid);
                }
                
                if (null != jc_areaParamLike.Pcode && "" != jc_areaParamLike.Pcode)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.PCODE LIKE '%'||:pcode||'%' ");
                    OracleParameter pPcode = new OracleParameter(":pcode", OracleDbType.Varchar2);
                    pPcode.Direction = ParameterDirection.Input;
                    pPcode.Value = jc_areaParamLike.Pcode;
                    sqlparams.Add(pPcode);
                }
                
                if (null != jc_areaParamLike.Zfbz && "" != jc_areaParamLike.Zfbz)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.ZFBZ LIKE '%'||:zfbz||'%' ");
                    OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                    pZfbz.Direction = ParameterDirection.Input;
                    pZfbz.Value = jc_areaParamLike.Zfbz;
                    sqlparams.Add(pZfbz);
                }
                
                if (null != jc_areaParamLike.Level_code && "" != jc_areaParamLike.Level_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.LEVEL_CODE LIKE '%'||:level_code||'%' ");
                    OracleParameter pLevel_code = new OracleParameter(":level_code", OracleDbType.NVarchar2);
                    pLevel_code.Direction = ParameterDirection.Input;
                    pLevel_code.Value = jc_areaParamLike.Level_code;
                    sqlparams.Add(pLevel_code);
                }
                
                if (null != jc_areaParamLike.Type_code && "" != jc_areaParamLike.Type_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.TYPE_CODE LIKE '%'||:type_code||'%' ");
                    OracleParameter pType_code = new OracleParameter(":type_code", OracleDbType.NVarchar2);
                    pType_code.Direction = ParameterDirection.Input;
                    pType_code.Value = jc_areaParamLike.Type_code;
                    sqlparams.Add(pType_code);
                }
                
                if (null != jc_areaParamLike.Remark && "" != jc_areaParamLike.Remark)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.REMARK LIKE '%'||:remark||'%' ");
                    OracleParameter pRemark = new OracleParameter(":remark", OracleDbType.NVarchar2);
                    pRemark.Direction = ParameterDirection.Input;
                    pRemark.Value = jc_areaParamLike.Remark;
                    sqlparams.Add(pRemark);
                }
                
            }
this.b_isWhere = false;return Int32.Parse(OracleHelper.ExecuteScalar(sql.ToString(),sqlparams.ToArray()).ToString());
        }


        /// <summary>
        /// 通用的保存方法，根据用户传入的参数，有ID为修改，没有ID为新增(手动生成OracleConnection对象，此方法用于事务，使用事务必须使用同一个OracleConnection对象)
        /// </summary>
        /// <param name="jc_areaParam"></param>
        /// <returns></returns>
        public bool save(Jc_area jc_areaParam,OracleConnection con)
        {
            if ("" != jc_areaParam.Id && null != jc_areaParam.Id)
            {
                //修改
                return this.updateById(jc_areaParam,con);
            }
            else
            {
                //新增
                return this.insert(jc_areaParam,con);
            }
        }

        /// <summary>
        /// 把dataset中的一行转换为model
        /// </summary>
        /// <param name="row"></param>
        /// <returns></returns>
        private Jc_area dataSetToModel(DataRow row)
        {
            Jc_area jc_areaParam = new Jc_area();
            jc_areaParam.Id = Convert.ToString(row["ID"]).Trim(); 
            jc_areaParam.Name = Convert.ToString(row["NAME"]).Trim(); 
            jc_areaParam.Code = Convert.ToString(row["CODE"]).Trim(); 
            jc_areaParam.Pid = Convert.ToString(row["PID"]).Trim(); 
            jc_areaParam.Pcode = Convert.ToString(row["PCODE"]).Trim(); 
            jc_areaParam.Zfbz = Convert.ToString(row["ZFBZ"]).Trim(); 
            jc_areaParam.Level_code = Convert.ToString(row["LEVEL_CODE"]).Trim(); 
            jc_areaParam.Type_code = Convert.ToString(row["TYPE_CODE"]).Trim(); 
            jc_areaParam.Remark = Convert.ToString(row["REMARK"]).Trim(); 
            
            return jc_areaParam;
        }

       
        
        //*******************在此以后添加新的方法start
        #region DAL层的implement,实现，start

        /// <summary>
        /// 把dataset中的一行转换为model, 包括相关联的外键对象
        /// </summary>
        /// <param name="row"></param>
        /// <returns></returns>
        private Jc_area dataSetContactObjectsToModel(DataRow row)
        {
            Jc_area jc_areaParam = this.dataSetToModel(row);

            //添加代码类别实体对象,行政区划等级对象
            Jc_code levelCode = new Jc_code();
            levelCode.Id = Convert.ToString(row["LEVEL_CODE_ID"]).Trim();
            levelCode.Name = Convert.ToString(row["LEVEL_CODE_NAME"]).Trim();
            levelCode.Value = Convert.ToString(row["LEVEL_CODE_VALUE"]).Trim();
            levelCode.Fk_code_type = Convert.ToString(row["LEVEL_CODE_FKCODETYPE"]).Trim();
            levelCode.Zfbz = Convert.ToString(row["LEVEL_CODE_ZFBZ"]).Trim();
            levelCode.Remark = Convert.ToString(row["LEVEL_CODE_REMARK"]).Trim();
            jc_areaParam.LevelCode = levelCode;

            return jc_areaParam;
        }



        /// <summary>
        /// 查找指定ID的用户,得到相关联的外键对象的方法
        /// </summary>
        /// <remarks>如果id为null、id重复、id未找到就抛异常</remarks>
        /// <returns>Jc_area</returns>
        public Jc_area findContactObjectsById(string id)
        {
            if ("" == id || null == id)
            {
                throw new Exception("主键ID不能为空，请赋值");
            }
            StringBuilder sql = new StringBuilder("SELECT A.* ");
            //新建方法findContactObjectsById，在此加入多表连接要显示的项start
            //sql.Append(",B.字段一,B.字段二,B.字段三");

            sql.Append(@"
            ,TT_LEVEL_CODE.ID AS LEVEL_CODE_ID,TT_LEVEL_CODE.NAME AS LEVEL_CODE_NAME,TT_LEVEL_CODE.VALUE AS LEVEL_CODE_VALUE,TT_LEVEL_CODE.FK_CODE_TYPE AS LEVEL_CODE_FKCODETYPE,TT_LEVEL_CODE.ZFBZ AS LEVEL_CODE_ZFBZ,TT_LEVEL_CODE.REMARK AS LEVEL_CODE_REMARK
            ");

            //新建方法，在此加入多表连接要显示的项end
            sql.Append(" FROM JC_AREA A ");
            //新建一个方法，在此加入多表连接的语句start
            //sql.Append("LEFT JOIN 外键表名 B ON A.外键=B.ID");

            sql.Append(@" 
                        LEFT JOIN 
                        (SELECT X.* FROM JC_CODE X WHERE X.FK_CODE_TYPE IN (SELECT Y.ID FROM JC_CODE_TYPE Y WHERE Y.VALUE='" + Model.Common.CommonCode.代码类型值.行政区划等级 + @"')) TT_LEVEL_CODE
                        ON A.LEVEL_CODE = TT_LEVEL_CODE.VALUE
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
        /// <param name="jc_areaParam"></param>
        /// <param name="page">分页对象</param>
        ///<param name="jc_areaParamLike">模糊查询参数</param>
        ///<param name="sortList">排序参数对象的集合</param>
        /// <returns>满足条件的所有Jc_area对象集合list</returns>
        public List<object> findContactObjects(Jc_area jc_areaParam, Model.Common.PageInfo page, Jc_area jc_areaParamLike, List<SortInfo> sortList)
        {
            //如果没有传查询条件参数，就new一个空的Jc_area对象，标示查询所有数据
            if (null == jc_areaParam)
            {
                jc_areaParam = new Jc_area();
            }
            if (null != jc_areaParam.Id && "" != jc_areaParam.Id)
            {
                throw new Exception("此方法不允许指定参数ID，如果需要根据ID查询数据，请调用findById方法；错误出自：find");
            }

            List<Jc_area> jc_areaParamList = new List<Jc_area>();//接收查询出的Jc_area对象集合
            List<OracleParameter> sqlparams = new List<OracleParameter>();//保存参数的集合
            StringBuilder sql = new StringBuilder("SELECT A.* ");
            //新建方法findAllContactObjects(Jc_area jc_areaParam, Model.Common.PageInfo page)，在此加入多表连接要显示的项start
            //sql.Append(",B.字段一,B.字段二,B.字段三");

            sql.Append(@"
            ,TT_LEVEL_CODE.ID AS LEVEL_CODE_ID,TT_LEVEL_CODE.NAME AS LEVEL_CODE_NAME,TT_LEVEL_CODE.VALUE AS LEVEL_CODE_VALUE,TT_LEVEL_CODE.FK_CODE_TYPE AS LEVEL_CODE_FKCODETYPE,TT_LEVEL_CODE.ZFBZ AS LEVEL_CODE_ZFBZ,TT_LEVEL_CODE.REMARK AS LEVEL_CODE_REMARK
            ");

            //新建方法，在此加入多表连接要显示的项end
            sql.Append(" FROM JC_AREA A ");
            //新建一个方法，在此加入多表连接的语句start
            ////sql.Append(" LEFT JOIN 表名 B ON A.外键=B.ID");

            sql.Append(@" 
                        LEFT JOIN 
                        (SELECT X.* FROM JC_CODE X WHERE X.FK_CODE_TYPE IN (SELECT Y.ID FROM JC_CODE_TYPE Y WHERE Y.VALUE='" + Model.Common.CommonCode.代码类型值.行政区划等级 + @"')) TT_LEVEL_CODE
                        ON A.LEVEL_CODE = TT_LEVEL_CODE.VALUE
            ");

            //新建一个方法，在此加入多表连接的语句end


            if (null != jc_areaParam.Name && "" != jc_areaParam.Name)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.NAME=:name ");
                OracleParameter pName = new OracleParameter(":name", OracleDbType.NVarchar2);
                pName.Value = jc_areaParam.Name;
                sqlparams.Add(pName);
            }

            if (null != jc_areaParam.Code && "" != jc_areaParam.Code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.CODE=:code ");
                OracleParameter pCode = new OracleParameter(":code", OracleDbType.Varchar2);
                pCode.Value = jc_areaParam.Code;
                sqlparams.Add(pCode);
            }

            if (null != jc_areaParam.Pid && "" != jc_areaParam.Pid)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.PID=:pid ");
                OracleParameter pPid = new OracleParameter(":pid", OracleDbType.Varchar2);
                pPid.Value = jc_areaParam.Pid;
                sqlparams.Add(pPid);
            }

            if (null != jc_areaParam.Pcode && "" != jc_areaParam.Pcode)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.PCODE=:pcode ");
                OracleParameter pPcode = new OracleParameter(":pcode", OracleDbType.Varchar2);
                pPcode.Value = jc_areaParam.Pcode;
                sqlparams.Add(pPcode);
            }

            if (null != jc_areaParam.Zfbz && "" != jc_areaParam.Zfbz)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.ZFBZ=:zfbz ");
                OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                pZfbz.Value = jc_areaParam.Zfbz;
                sqlparams.Add(pZfbz);
            }

            if (null != jc_areaParam.Level_code && "" != jc_areaParam.Level_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.LEVEL_CODE=:level_code ");
                OracleParameter pLevel_code = new OracleParameter(":level_code", OracleDbType.NVarchar2);
                pLevel_code.Value = jc_areaParam.Level_code;
                sqlparams.Add(pLevel_code);
            }

            if (null != jc_areaParam.Type_code && "" != jc_areaParam.Type_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.TYPE_CODE=:type_code ");
                OracleParameter pType_code = new OracleParameter(":type_code", OracleDbType.NVarchar2);
                pType_code.Value = jc_areaParam.Type_code;
                sqlparams.Add(pType_code);
            }

            if (null != jc_areaParam.Remark && "" != jc_areaParam.Remark)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.REMARK=:remark ");
                OracleParameter pRemark = new OracleParameter(":remark", OracleDbType.NVarchar2);
                pRemark.Value = jc_areaParam.Remark;
                sqlparams.Add(pRemark);
            }

            if (jc_areaParamLike != null)
            {

                if (null != jc_areaParamLike.Name && "" != jc_areaParamLike.Name)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.NAME LIKE '%'||:name||'%' ");
                    OracleParameter pName = new OracleParameter(":name", OracleDbType.NVarchar2);
                    pName.Direction = ParameterDirection.Input;
                    pName.Value = jc_areaParamLike.Name;
                    sqlparams.Add(pName);
                }

                if (null != jc_areaParamLike.Code && "" != jc_areaParamLike.Code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.CODE LIKE '%'||:code||'%' ");
                    OracleParameter pCode = new OracleParameter(":code", OracleDbType.Varchar2);
                    pCode.Direction = ParameterDirection.Input;
                    pCode.Value = jc_areaParamLike.Code;
                    sqlparams.Add(pCode);
                }

                if (null != jc_areaParamLike.Pid && "" != jc_areaParamLike.Pid)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.PID LIKE '%'||:pid||'%' ");
                    OracleParameter pPid = new OracleParameter(":pid", OracleDbType.Varchar2);
                    pPid.Direction = ParameterDirection.Input;
                    pPid.Value = jc_areaParamLike.Pid;
                    sqlparams.Add(pPid);
                }

                if (null != jc_areaParamLike.Pcode && "" != jc_areaParamLike.Pcode)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.PCODE LIKE '%'||:pcode||'%' ");
                    OracleParameter pPcode = new OracleParameter(":pcode", OracleDbType.Varchar2);
                    pPcode.Direction = ParameterDirection.Input;
                    pPcode.Value = jc_areaParamLike.Pcode;
                    sqlparams.Add(pPcode);
                }

                if (null != jc_areaParamLike.Zfbz && "" != jc_areaParamLike.Zfbz)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.ZFBZ LIKE '%'||:zfbz||'%' ");
                    OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                    pZfbz.Direction = ParameterDirection.Input;
                    pZfbz.Value = jc_areaParamLike.Zfbz;
                    sqlparams.Add(pZfbz);
                }

                if (null != jc_areaParamLike.Level_code && "" != jc_areaParamLike.Level_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.LEVEL_CODE LIKE '%'||:level_code||'%' ");
                    OracleParameter pLevel_code = new OracleParameter(":level_code", OracleDbType.NVarchar2);
                    pLevel_code.Direction = ParameterDirection.Input;
                    pLevel_code.Value = jc_areaParamLike.Level_code;
                    sqlparams.Add(pLevel_code);
                }

                if (null != jc_areaParamLike.Type_code && "" != jc_areaParamLike.Type_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.TYPE_CODE LIKE '%'||:type_code||'%' ");
                    OracleParameter pType_code = new OracleParameter(":type_code", OracleDbType.NVarchar2);
                    pType_code.Direction = ParameterDirection.Input;
                    pType_code.Value = jc_areaParamLike.Type_code;
                    sqlparams.Add(pType_code);
                }

                if (null != jc_areaParamLike.Remark && "" != jc_areaParamLike.Remark)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.REMARK LIKE '%'||:remark||'%' ");
                    OracleParameter pRemark = new OracleParameter(":remark", OracleDbType.NVarchar2);
                    pRemark.Direction = ParameterDirection.Input;
                    pRemark.Value = jc_areaParamLike.Remark;
                    sqlparams.Add(pRemark);
                }

            }

            if (jc_areaParamLike != null)
            {

            }

            this.b_isWhere = false;
            //排序
            this.addSort(sql, sortList);
            //*******分页start1*********如果分页对象为空，则全部数据查出，如果不为空
            List<object> returnList = new List<object>();//返回的List,索引0为List<Jc_area>对象,索引1为Model.Common.PageInfo分页信息对象
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
            //把每一行数据转换为一个对象放入List<Jc_area>中
            for (int i = 0; i < rows.Count; i++)
            {
                DataRow row = rows[i];
                jc_areaParamList.Add(this.dataSetContactObjectsToModel(row));
                //jc_areaParamList.Add(this.dataSetToModel(row));
            }

            //*******分页start2*********如果没有传入分页对象，则新建一个分页对象当做返回值
            if (null == page)
            {
                page = new Model.Common.PageInfo();
                page.AllCount = rows.Count;
            }
            returnList.Add(jc_areaParamList);//把List<Jc_area>放入List<object>中第一个
            returnList.Add(page);//把page对象放入List<object>中第二个
            //*******分页end2*********
            return returnList;
        }
        #endregion DAL层的implement,实现，end

        


        //*******************在此以后添加新的方法end


        public bool deleteCurrentAndChildNode(string id)
        {
            if ("" == id || null == id)
            {
                throw new Exception("ID不能为空，请赋值");
            }
            StringBuilder sql = new StringBuilder(@"delete from jc_area where jc_area.id in(  
    select jc_area.id from jc_area  
      start with   jc_area.id=:id
      connect by prior jc_area.id=pid )");
            OracleParameter pId = new OracleParameter(":id", OracleDbType.Varchar2);
            pId.Value = id;
            int flag = OracleHelper.ExecuteNonQuery(sql.ToString(), null, pId);
            return true;
        }
    }
}


